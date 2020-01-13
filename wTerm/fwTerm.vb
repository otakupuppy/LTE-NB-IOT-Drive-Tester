Option Explicit On
Option Strict On
Imports System.Linq

Public Class fwterm

    Private mIniFile As w2IniFile
    Private mPort As New IO.Ports.SerialPort
    Private mTxt As w2TxtBuffer

    Dim AC As String
    Dim SCELLID As String
    Dim PCELLID As String
    Dim C1 As String
    Dim ARFCN As String
    Dim LEVEL As String
    Dim QUAL As String
    Dim eNB As String
    Dim PCI As String
    Dim RSRP As String
    Dim RSRQ As String
    Dim RSSNR As String
    Dim CQI As String
    Dim RSSI As String
    Dim TAC As String
    Dim OpMode As String
    Dim SysMode As String
    Dim MccMnc As String
    Dim FreqB As String
    Dim dlbw As String
    Dim ulbw As String
    Dim CELLID As String

    Private Sub ConnectPort()
        'check port properties
        If cboPort.SelectedIndex = -1 Then Return
        If cboRate.SelectedIndex = -1 Then Return
        If cboParity.SelectedIndex = -1 Then Return
        If cboData.SelectedIndex = -1 Then Return
        If cboStop.SelectedIndex = -1 Then Return

        'close port
        If mPort IsNot Nothing Then mPort.Close()

        'set port properties
        mPort.PortName = cboPort.Text
        mPort.BaudRate = Convert.ToInt32(cboRate.Text)
        mPort.DataBits = Convert.ToInt32(cboData.Text)

        mPort.Parity = CType([Enum].Parse(GetType(IO.Ports.Parity), cboParity.Text), IO.Ports.Parity)
        mPort.StopBits = CType([Enum].Parse(GetType(IO.Ports.StopBits), cboStop.Text), IO.Ports.StopBits)

        'try connection
        Try
            mPort.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End Try

        'set 
        mPort.NewLine = ControlChars.Cr
        'mPort.ReadTimeout = 1000   'this is not needed as we are going to use DataReceived event
        AddHandler mPort.DataReceived, AddressOf DataReceived

        'save info
        mIniFile.WriteParemeter("Port", "Port", cboPort.Text)
        mIniFile.WriteParemeter("Port", "BaudRate", cboRate.Text)
        mIniFile.WriteParemeter("Port", "DataBits", cboData.Text)
        mIniFile.WriteParemeter("Port", "StopBits", cboStop.Text)
        mIniFile.WriteParemeter("Port", "Parity", cboParity.Text)
    End Sub

    ''' <summary>
    ''' Note that this is called from a backrbound thread
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)
        If e.EventType = IO.Ports.SerialData.Chars Then ShowReceived()
    End Sub

    ''' <summary>
    ''' The following handles the actual call from DataReceived in a thread safe way.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub ShowReceived()
        Static s As String = ""
        Dim idx As Integer = 0
        Dim sData() As String

        If Me.InvokeRequired Then
            'invoke the thread
            Me.Invoke(New MethodInvoker(AddressOf ShowReceived))
        Else
            'attach the left over of the line
            s += mPort.ReadExisting()
            sData = s.Split(ControlChars.Cr)
            For i As Integer = 0 To sData.Length - 1
                s = sData(i)
                'remove line feed, if any
                s = s.Replace(ControlChars.Lf, "")
                'removed the last line if it is part of the line being added
                If (i = 0) Then
                    idx = lstData.Items.Count - 1
                    If idx > 0 Then
                        If s.Contains(lstData.Items(idx).ToString) Then
                            'select one item above to prevent the RemoveAt forces the TopIndex to 0
                            lstData.SelectedIndex = idx - 1
                            'remove item 
                            lstData.Items.RemoveAt(idx)
                            'remove fake selection, 
                            lstData.SelectedIndex = -1
                        End If
                    End If
                End If
                'show line
                idx = lstData.Items.Add(s)
            Next
            'show the data
            If Me.Visible And idx > lstData.TopIndex Then lstData.TopIndex = idx

            'save the non-complete line
            s = sData(sData.Length - 1)
        End If

    End Sub

    Private Sub fwterm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim i As Integer
        Dim s As String
        Dim x As Object()

        'ini file
        mIniFile = New w2IniFile(IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), "wterm.ini"))

        'set port properties
        cboPort.DropDownStyle = ComboBoxStyle.DropDownList
        For Each s In My.Computer.Ports.SerialPortNames
            cboPort.Items.Add(s)
        Next
        s = mIniFile.ReadParameter("Port", "Port", "")
        cboPort.SelectedIndex = cboPort.Items.IndexOf(s)

        cboRate.DropDownStyle = ComboBoxStyle.DropDownList
        x = New Object() {1200, 1800, 2400, 4800, 7200, 9600, 14400, 19200, 38400, 57600, 115200, 128000}
        cboRate.Items.AddRange(x)
        i = mIniFile.ReadParameter("Port", "BaudRate", 0)
        cboRate.SelectedIndex = cboRate.Items.IndexOf(i)

        cboParity.DropDownStyle = ComboBoxStyle.DropDownList
        For Each s In [Enum].GetNames(GetType(IO.Ports.Parity))
            cboParity.Items.Add(s)
        Next
        s = mIniFile.ReadParameter("Port", "Parity", "")
        cboParity.SelectedIndex = cboParity.Items.IndexOf(s)

        cboData.DropDownStyle = ComboBoxStyle.DropDownList
        x = New Object() {4, 5, 6, 7, 8}
        cboData.Items.AddRange(x)
        i = mIniFile.ReadParameter("Port", "DataBits", 0)
        cboData.SelectedIndex = cboData.Items.IndexOf(i)

        cboStop.DropDownStyle = ComboBoxStyle.DropDownList
        For Each s In [Enum].GetNames(GetType(IO.Ports.StopBits))
            cboStop.Items.Add(s)
        Next
        s = mIniFile.ReadParameter("Port", "StopBits", "")
        cboStop.SelectedIndex = cboStop.Items.IndexOf(s)

        'button 
        btnConnect.ImageList = ImageList
        btnConnect.Text = "Connect"
        btnConnect.ImageKey = btnConnect.Text

        'terminal and enhancement
        lblPort.Text = ""
        PanelIO.Enabled = False

        mTxt = New w2TxtBuffer(txtSend)
        mTxt.ClearLastCommand = True
        chkCap.Checked = mIniFile.ReadParameter("Port", "CAPS", False)

        lstData.MultiColumn = False
        lstData.SelectionMode = SelectionMode.MultiExtended
        Dim Menu As New w2ContextMenu(lstData, ImageList)

        'me
        Me.Text = "wTerm - a serial port terminal without flow control"
        Me.MinimumSize = Me.Size()

        'lbl
        lblMccMnc.ResetText()
        lblOpMode.ResetText()
        lblSysMode.ResetText()
        lblSCID.ResetText()
        lblLac.ResetText()
        lblPCI.ResetText()
        lblARFCN.ResetText()
        lblBand.ResetText()
        lblRSRP.ResetText()
        lblRSRQ.ResetText()
        lblRSSI.ResetText()
        lblRSSNR.ResetText()


    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            ConnectPort()
        Else
            If mPort.IsOpen Then
                mPort.Close()
                RemoveHandler mPort.DataReceived, AddressOf DataReceived
            End If
        End If

        If mPort.IsOpen Then
            btnConnect.Text = "Disconnect"
            PanelIO.Enabled = True
            lblPort.Text = "Connected to " & cboPort.Text & ":" & cboRate.Text & ":" _
                            & cboParity.Text & ":" & cboData.Text & ":" & cboStop.Text
        Else
            btnConnect.Text = "Connect"
            lblPort.Text = "Disconnected"
            PanelIO.Enabled = False
        End If
        btnConnect.Image = ImageList.Images(btnConnect.Text)
    End Sub

    Private Sub chkCap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCap.CheckedChanged
        mTxt.Uppercase = chkCap.Checked
        mIniFile.WriteParemeter("Port", "CAPS", mTxt.Uppercase.ToString)
    End Sub

    Private Sub txtSend_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSend.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            mPort.WriteLine(txtSend.Text)
            txtSend.Text = ""
        End If
    End Sub
    Public Function RemoveWhitespace(fullString As String) As String
        Return New String(fullString.Where(Function(x) Not Char.IsWhiteSpace(x)).ToArray())
    End Function
    Public Function CID(tmp As Integer) As String
        Dim temp As String
        Dim temp1 As String
        Dim temp2 As Integer
        temp2 = Convert.ToInt32(tmp)
        temp = Hex(tmp)
        temp = temp.Remove(temp.Length - 2)
        temp1 = Convert.ToInt32(temp, 16).ToString


        Return temp1

    End Function
    Private Sub CPSI_Command()
        Dim Incoming As String
        mPort.WriteLine("AT+CPSI?")
        RemoveHandler mPort.DataReceived, AddressOf DataReceived
        Incoming = mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            Dim outgoing() As String = Split(Incoming, ":")
            Dim tempstr As String = outgoing(outgoing.Length - 1)
            Dim incoming_1() As String = Split(tempstr, ",")
            SysMode = ArrayAccess(incoming_1, 0)
            OpMode = ArrayAccess(incoming_1, 1)
            MccMnc = ArrayAccess(incoming_1, 2)
            Dim temp() As String = Split(ArrayAccess(incoming_1, 3), "x")
            TAC = ArrayAccess(incoming_1, 3) 'Convert.ToInt32(temp(1), 16).ToString
            SCELLID = ArrayAccess(incoming_1, 4)
            PCELLID = ArrayAccess(incoming_1, 5)
            FreqB = ArrayAccess(incoming_1, 6)
            ARFCN = ArrayAccess(incoming_1, 7)
            dlbw = ArrayAccess(incoming_1, 8)
            ulbw = ArrayAccess(incoming_1, 9)
            RSRQ = ArrayAccess(incoming_1, 10)
            RSRP = ArrayAccess(incoming_1, 11)
            RSSI = ArrayAccess(incoming_1, 12)
            Dim temp2 As String = ArrayAccess(incoming_1, 13)
            Dim temp1() As String = System.Text.RegularExpressions.Regex.Split(temp2, Environment.NewLine)
            RSSNR = ArrayAccess(temp1, 0)


            lblSysMode.Text = SysMode
            lblOpMode.Text = OpMode
            lblMccMnc.Text = MccMnc
            lblLac.Text = TAC
            lblSCID.Text = CELLID
            lblPCI.Text = PCELLID
            lblBand.Text = FreqB
            lblARFCN.Text = ARFCN
            lblRSRQ.Text = RSRQ
            lblRSRP.Text = RSRP
            lblRSSI.Text = RSSI
            lblRSSNR.Text = RSSNR

        End If
        Me.DataGridView1.Rows.Add(DateTime.Now.ToString, TAC, SCELLID, PCELLID, ARFCN, RSRP, RSRQ)
        AddHandler mPort.DataReceived, AddressOf DataReceived
    End Sub

    Public Function ArrayAccess(ArrayPass As String(), index As Integer) As String

        Dim returnstr As String
        Try
            returnstr = ArrayPass(index)

        Catch ex As Exception
            Return "Error"
        End Try
        Return returnstr
    End Function

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click
        RemoveHandler mPort.DataReceived, AddressOf DataReceived
        mPort.DiscardOutBuffer()
        CPSI_Command()
        AddHandler mPort.DataReceived, AddressOf DataReceived
    End Sub

    Private Sub btnLog_Click_1(sender As Object, e As EventArgs) Handles btnLog.Click
        If btnLog.Text = "Start Logging" Then
            btnLog.Text = "Logging"
            Timer1.Interval = Convert.ToInt32(txtTimer.Text)
            Timer1.Start()
        ElseIf btnLog.Text = "Logging" Then
            btnLog.Text = "Start Logging"
            Timer1.Stop()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim Incoming As String
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.DiscardOutBuffer()
        mPort.WriteLine("AT+CPSI?")
        RemoveHandler mPort.DataReceived, AddressOf DataReceived
        Incoming = mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            Dim outgoing() As String = Split(Incoming, ":")
            Dim tempstr As String = outgoing(outgoing.Length - 1)
            Dim incoming_1() As String = Split(tempstr, ",")
            SysMode = ArrayAccess(incoming_1, 0)
            OpMode = ArrayAccess(incoming_1, 1)
            MccMnc = ArrayAccess(incoming_1, 2)
            Dim temp() As String = Split(ArrayAccess(incoming_1, 3), "x")
            TAC = ArrayAccess(incoming_1, 3) 'Convert.ToInt32(temp(1), 16).ToString
            SCELLID = ArrayAccess(incoming_1, 4)
            PCELLID = ArrayAccess(incoming_1, 5)
            FreqB = ArrayAccess(incoming_1, 6)
            ARFCN = ArrayAccess(incoming_1, 7)
            dlbw = ArrayAccess(incoming_1, 8)
            ulbw = ArrayAccess(incoming_1, 9)
            RSRQ = ArrayAccess(incoming_1, 10)
            RSRP = ArrayAccess(incoming_1, 11)
            RSSI = ArrayAccess(incoming_1, 12)
            Dim temp2 As String = ArrayAccess(incoming_1, 13)
            Dim temp1() As String = System.Text.RegularExpressions.Regex.Split(temp2, Environment.NewLine)
            RSSNR = ArrayAccess(temp1, 0)


            'lblSysMode.Text = SysMode
            'lblOpMode.Text = OpMode
            'lblMccMnc.Text = MccMnc
            'lblLac.Text = TAC
            'lblSCID.Text = SCELLID
            'lblPCI.Text = PCELLID
            'lblBand.Text = FreqB
            'lblARFCN.Text = ARFCN
            'lblRSRQ.Text = RSRQ
            'lblRSRP.Text = RSRP
            'lblRSSI.Text = RSSI
            'lblRSSNR.Text = RSSNR
            Me.DataGridView1.Rows.Add(DateTime.Now.ToString, TAC, SCELLID, PCELLID, ARFCN, RSRP, RSRQ)
        End If

    End Sub
End Class
