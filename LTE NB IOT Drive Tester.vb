Option Explicit On
Option Strict On
Imports System.Linq
Imports System.Text
Imports System.IO



Public Class fwterm

    Private mIniFile As w2IniFile
    Private mPort As New IO.Ports.SerialPort
    Private mTxt As w2TxtBuffer

    Dim AC As String        'Area Code
    Dim SCELLID As String   'Serving Cell ID - GSM Mode
    Dim PCELLID As String   'Physciall Cell ID - GSM Mode
    Dim C1 As String        'no idea why i mde this
    Dim ARFCN As String     'ARFCN
    Dim LEVEL As String
    Dim QUAL As String
    Dim eNB As String
    Dim PCI As String
    Dim RSRP As String      'self explanatory
    Dim RSRQ As String
    Dim RSSNR As String
    Dim CQI As String
    Dim RSSI As String
    Dim TAC As String
    Dim OpMode As String    'operation mode Online or LPM etc
    Dim SysMode As String   'NB-IoT or GSM
    Dim MccMnc As String    'MCC-MNC
    Dim FreqB As String     'Frequency Band
    Dim dlbw As String
    Dim ulbw As String
    Dim CELLID As String
    Dim Lat As String       'Latitude
    Dim Longi As String     'Longitude

    Dim fname As String     'file name



    Private Sub ConnectPort()

        'handles connecting to the port pretty much nothing that requires your attention

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
        'mPort.ReadTimeout = 1000   'this is not needed as we are going to use DataReceived event // yeah ditched that and opted for mPort.ReadExisting. Cheers !!
        'AddHandler mPort.DataReceived, AddressOf DataReceived

        'save info
        mIniFile.WriteParemeter("Port", "Port", cboPort.Text)
        mIniFile.WriteParemeter("Port", "BaudRate", cboRate.Text)
        mIniFile.WriteParemeter("Port", "DataBits", cboData.Text)
        mIniFile.WriteParemeter("Port", "StopBits", cboStop.Text)
        mIniFile.WriteParemeter("Port", "Parity", cboParity.Text)
    End Sub


    Private Sub fwterm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'handles what happens when the application is first opened

        Dim i As Integer
        Dim s As String
        Dim x As Object()

        'ini file
        mIniFile = New w2IniFile(IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory(), "wterm.ini"))

        'set port properties
        cboPort.DropDownStyle = ComboBoxStyle.DropDownList
        For Each s In IO.Ports.SerialPort.GetPortNames
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

        btnLogClear.Enabled = False
        pgGPS.Enabled = False
        pgFunction.Enabled = False



        'me
        Me.Text = "LTE NB IOT Drive Tester"
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
        lblLat.ResetText()
        lblLong.ResetText()



    End Sub

    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connect" Then
            ConnectPort()
        Else
            If mPort.IsOpen Then
                mPort.WriteLine("AT+CGNSPWR=0")        'incase user forgets to power down GPS
                mPort.Close()
                'RemoveHandler mPort.DataReceived, AddressOf DataReceived
            End If
        End If

        If mPort.IsOpen Then
            btnConnect.Text = "Disconnect"

            btnLogClear.Enabled = True
            pgGPS.Enabled = True
            pgFunction.Enabled = True
            lblPort.Text = "Connected to " & cboPort.Text & ":" & cboRate.Text & ":" _
                            & cboParity.Text & ":" & cboData.Text & ":" & cboStop.Text
        Else
            btnConnect.Text = "Connect"
            lblPort.Text = "Disconnected"

            btnLogClear.Enabled = False
            pgGPS.Enabled = False
            pgFunction.Enabled = False

        End If
        btnConnect.Image = ImageList.Images(btnConnect.Text)
    End Sub


    Private Sub CPSI_Command()

        'runs the AT+CPSI? command and parses the result discarded in favour of AT+CPSI?;+CGNSINF

        mPort.DiscardInBuffer()
        mPort.DiscardInBuffer()

        Dim Incoming As String
        mPort.WriteLine("AT+CPSI?")
        'RemoveHandler mPort.DataReceived, AddressOf DataReceived
        Incoming = mPort.ReadExisting()                                     'reads the return string i.e recieve buffer
        If Incoming Is Nothing Then                                         'handles if buffer is null
        Else
            Dim outgoing() As String = Split(Incoming, ":")                 'splits the string at token :
            Dim tempstr As String = outgoing(outgoing.Length - 1)           'primitive way to remove CR and LF chaarcters
            Dim incoming_1() As String = Split(tempstr, ",")                'Splits the string at every ,
            SysMode = ArrayAccess(incoming_1, 0)                            'assigns split string values to variables
            OpMode = ArrayAccess(incoming_1, 1)
            MccMnc = ArrayAccess(incoming_1, 2)
            TAC = ACParse(ArrayAccess(incoming_1, 3))
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
            Try                                                             'checks the System Mode and parses the Cell Id if in LTE mode and does nothing if in GSM mode
                If SysMode.Substring(0, 4) = " LTE" Then                    'since in LTE mode Cell ID is returned in hex form more info @CIDParse funct.
                    SCELLID = CIDParse(SCELLID)
                Else
                    SCELLID = SCELLID
                End If
            Catch ex As Exception
                SCELLID = "Error"
            End Try

            lblMccMnc.Text = MccMnc
            lblLac.Text = TAC
            lblSCID.Text = SCELLID
            lblPCI.Text = PCELLID
            lblBand.Text = FreqB
            lblARFCN.Text = ARFCN
            lblRSRQ.Text = RSRQ
            lblRSRP.Text = RSRP
            lblRSSI.Text = RSSI
            lblRSSNR.Text = RSSNR

            Array.Clear(outgoing, 0, outgoing.Length)
            Array.Clear(incoming_1, 0, incoming_1.Length)


        End If
        Me.DataGridView1.Rows.Add(DateTime.Now.ToString, TAC, SCELLID, PCELLID, ARFCN, RSRP, RSRQ, Lat, Longi)  'adds details to table
        SysMode = String.Empty
        OpMode = String.Empty
        MccMnc = String.Empty
        TAC = String.Empty
        SCELLID = String.Empty
        PCELLID = String.Empty
        FreqB = String.Empty
        ARFCN = String.Empty
        dlbw = String.Empty
        ulbw = String.Empty
        RSRQ = String.Empty
        RSRP = String.Empty
        RSSI = String.Empty
        'AddHandler mPort.DataReceived, AddressOf DataReceived



    End Sub

    Private Sub CPSI_CGNSINF_Command()

        'the used function

        Dim outgoing() As String
        mPort.WriteLine("AT+CPSI?;+CGNSINF")


        Dim Incoming As String = mPort.ReadExisting()           'reads incoming
        Incoming += mPort.ReadExisting()                        'reads and concatanates if return string exceeded the buffer size
        Incoming += mPort.ReadExisting()
        Incoming += mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            outgoing = System.Text.RegularExpressions.Regex.Split(Incoming, Environment.NewLine)    'splits at <CR><LF> characters

            Dim CPSI As String
            Try                                                 'handles partial returns
                CPSI = outgoing(1)
            Catch ex As Exception
                CPSI = "+CPSI:0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
            End Try


            Dim CGNSINF As String

            Try
                CGNSINF = outgoing(3)
            Catch ex As Exception
                CGNSINF = "+CGNSINF:0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
            End Try

            Dim CPSI_Split() As String = Split(CPSI, ":")                               'handles the return for CPSI? part
            Dim CPSI_Splitted As String = CPSI_Split(CPSI_Split.Length - 1)
            Dim incoming_1() As String = Split(CPSI_Splitted, ",")
            SysMode = ArrayAccess(incoming_1, 0)
            OpMode = ArrayAccess(incoming_1, 1)
            MccMnc = ArrayAccess(incoming_1, 2)
            TAC = ACParse(ArrayAccess(incoming_1, 3))
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

            Dim CGNSINF_Split() As String
            'Dim incoming_2() As String = Split(CGNSINF_Split(1), ",")

            Try                                                                         'handles the return for +GGNSINF
                CGNSINF_Split = Split(CGNSINF, ":", 2)
            Catch ex As Exception
                CGNSINF_Split = Split("CGNSINF:0,0,0,0,0,0,0,0,0,0", ":")
            End Try
            Dim tempstr As String = CGNSINF_Split(CGNSINF_Split.Length - 1)
            Dim incoming_2() As String = Split(tempstr, ",")
            Lat = ArrayAccess(incoming_2, 3)
            Longi = ArrayAccess(incoming_2, 4)


            lblSysMode.Text = SysMode
            lblOpMode.Text = OpMode
            Try
                If SysMode.Substring(0, 4) = " LTE" Then
                    SCELLID = CIDParse(SCELLID)
                Else
                    SCELLID = SCELLID
                End If
            Catch ex As Exception
                SCELLID = "Error"
            End Try

            lblMccMnc.Text = MccMnc
            lblLac.Text = TAC
            lblSCID.Text = SCELLID
            lblPCI.Text = PCELLID
            lblBand.Text = FreqB
            lblARFCN.Text = ARFCN
            lblRSRQ.Text = RSRQ
            lblRSRP.Text = RSRP
            lblRSSI.Text = RSSI
            lblRSSNR.Text = RSSNR

            Array.Clear(outgoing, 0, outgoing.Length)
            Array.Clear(incoming_1, 0, incoming_1.Length)
        End If

        Me.DataGridView1.Rows.Add(DateTime.Now.ToString, TAC, SCELLID, PCELLID, ARFCN, RSRP, RSRQ, Lat, Longi)
        SysMode = String.Empty
        OpMode = String.Empty
        MccMnc = String.Empty
        TAC = String.Empty
        SCELLID = String.Empty
        PCELLID = String.Empty
        FreqB = String.Empty
        ARFCN = String.Empty
        dlbw = String.Empty
        ulbw = String.Empty
        RSRQ = String.Empty
        RSRP = String.Empty
        RSSI = String.Empty
        Lat = String.Empty
        Longi = String.Empty

        'AddHandler mPort.DataReceived, AddressOf DataReceived


    End Sub

    Public Function ArrayAccess(ArrayPass As String(), index As Integer) As String
        'to access array safely in case of index out of bounds exception
        Dim returnstr As String
        Try
            returnstr = ArrayPass(index)

        Catch ex As Exception
            Return "Error"
        End Try
        Return returnstr
    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'execution for the logging function same as the CPSI_CGNSINF_Command() but doesn't change the labels


        Dim outgoing() As String
        mPort.WriteLine("AT+CPSI?;+CGNSINF")


        Dim Incoming As String = mPort.ReadExisting()
        Incoming += mPort.ReadExisting()
        Incoming += mPort.ReadExisting()
        Incoming += mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            outgoing = System.Text.RegularExpressions.Regex.Split(Incoming, Environment.NewLine)

            Dim CPSI As String
            Try
                CPSI = outgoing(1)
            Catch ex As Exception
                CPSI = "+CPSI:0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
            End Try


            Dim CGNSINF As String

            Try
                CGNSINF = outgoing(3)
            Catch ex As Exception
                CGNSINF = "+CGNSINF:0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0"
            End Try

            Dim CPSI_Split() As String = Split(CPSI, ":")
            Dim CPSI_Splitted As String = CPSI_Split(CPSI_Split.Length - 1)
            Dim incoming_1() As String = Split(CPSI_Splitted, ",")
            SysMode = ArrayAccess(incoming_1, 0)
            OpMode = ArrayAccess(incoming_1, 1)
            MccMnc = ArrayAccess(incoming_1, 2)
            TAC = ACParse(ArrayAccess(incoming_1, 3))
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

            Dim CGNSINF_Split() As String
            'Dim incoming_2() As String = Split(CGNSINF_Split(1), ",")

            Try
                CGNSINF_Split = Split(CGNSINF, ":", 2)
            Catch ex As Exception
                CGNSINF_Split = Split("CGNSINF:0,0,0,0,0,0,0,0,0,0", ":")
            End Try
            Dim tempstr As String = CGNSINF_Split(CGNSINF_Split.Length - 1)
            Dim incoming_2() As String = Split(tempstr, ",")
            Lat = ArrayAccess(incoming_2, 3)
            Longi = ArrayAccess(incoming_2, 4)


            lblSysMode.Text = SysMode
            lblOpMode.Text = OpMode
            Try
                If SysMode.Substring(0, 4) = " LTE" Then
                    SCELLID = CIDParse(SCELLID)
                Else
                    SCELLID = SCELLID
                End If
            Catch ex As Exception
                SCELLID = "Error"
            End Try

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

            Array.Clear(outgoing, 0, outgoing.Length)
            Array.Clear(incoming_1, 0, incoming_1.Length)
        End If

        Me.DataGridView1.Rows.Add(DateTime.Now.ToString, TAC, SCELLID, PCELLID, ARFCN, RSRP, RSRQ, Lat, Longi)
        SysMode = String.Empty
        OpMode = String.Empty
        MccMnc = String.Empty
        TAC = String.Empty
        SCELLID = String.Empty
        PCELLID = String.Empty
        FreqB = String.Empty
        ARFCN = String.Empty
        dlbw = String.Empty
        ulbw = String.Empty
        RSRQ = String.Empty
        RSRP = String.Empty
        RSSI = String.Empty
        Lat = String.Empty
        Longi = String.Empty


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'side delay function instead of sleeping thread
        Timer2.Stop()
    End Sub

    Private Sub Delay(time As Integer)
        'delay function to avoid overlaoding port with commands
        Timer2.Interval = time
        Timer2.Start()
    End Sub

    Private Function ACParse(tmp As String) As String

        'parsing the Area code since its returned as an hex value

        Dim temp() As String = Split(tmp, "x")
        Dim temp1 As String = ArrayAccess(temp, 1)
        'While temp1 = "Error"
        '    CPSI_Command()
        'End While

        Dim temp2 As Integer
        temp1 = temp1.Substring(0, 4)
        temp2 = HexConvert(temp1)
        Return CType(temp2, String)
    End Function

    Public Function HexConvert(str As String) As Integer
        'converts hex to integer

        Dim returnstr As Integer
        Try
            returnstr = Convert.ToInt32(str, 16)

        Catch ex As Exception
            Return -1
        End Try
        Return returnstr
    End Function

    Private Function CIDParse(tmp As String) As String

        'parses the Cell ID return hex string

        Dim temp As String
        temp = IntConvert(tmp)
        Dim temp1 As String = temp.Substring(0, 5)
        'Dim SectorID As String = temp.Substring(5)
        temp1 = CType(HexConvert(temp1), String)
        Return temp1

    End Function

    Public Function IntConvert(tmp As String) As String
        'converts integer to hex string
        Dim returnstr As String
        Try
            returnstr = Conversion.Hex(CInt(tmp))

        Catch ex As Exception
            Return "Error"
        End Try
        Return returnstr
    End Function

    Private Sub DataGridToCSV(ByRef dt As DataGridView, Qualifier As String)

        'exports table

        Dim pwd As String = My.Computer.FileSystem.CurrentDirectory
        Dim TempDirectory As String = pwd & "\Export"
        System.IO.Directory.CreateDirectory(TempDirectory)
        Dim oWrite As System.IO.StreamWriter
        Dim file As String = fname & ".csv"
        oWrite = IO.File.CreateText(TempDirectory & "\" & file)

        Dim CSV As StringBuilder = New StringBuilder()

        Dim i As Integer = 1
        Dim CSVHeader As StringBuilder = New StringBuilder()
        For Each c As DataGridViewColumn In dt.Columns
            If i = 1 Then
                CSVHeader.Append(Qualifier & c.HeaderText.ToString() & Qualifier)
            Else
                CSVHeader.Append("," & Qualifier & c.HeaderText.ToString() & Qualifier)
            End If
            i += 1
        Next

        'CSV.AppendLine(CSVHeader.ToString())
        oWrite.WriteLine(CSVHeader.ToString())
        oWrite.Flush()

        For r As Integer = 0 To dt.Rows.Count - 1

            Dim CSVLine As StringBuilder = New StringBuilder()
            Dim s As String = ""
            For c As Integer = 0 To dt.Columns.Count - 1
                If c = 0 Then
                    'CSVLine.Append(Qualifier & gridResults.Rows(r).Cells(c).Value.ToString() & Qualifier)
                    s = s & Qualifier & DataGridView1.Rows(r).Cells(c).Value.ToString() & Qualifier
                Else
                    'CSVLine.Append("," & Qualifier & gridResults.Rows(r).Cells(c).Value.ToString() & Qualifier)
                    s = s & "," & Qualifier & DataGridView1.Rows(r).Cells(c).Value.ToString() & Qualifier
                End If

            Next
            oWrite.WriteLine(s)
            oWrite.Flush()
            'CSV.AppendLine(CSVLine.ToString())
            'CSVLine.Clear()
        Next

        'oWrite.Write(CSV.ToString())

        oWrite.Close()
        oWrite = Nothing

        'System.Diagnostics.Process.Start(TempDirectory & "\" & file)

        GC.Collect()

    End Sub

    Private Sub GNSS_Start()
        'unused
        mPort.WriteLine("AT+CGNSPORT=3")
        Timer3.Interval = 3000

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        mPort.WriteLine("AT+CFUN=4")
    End Sub

    Private Sub btnDevMgr_Click(sender As Object, e As EventArgs) Handles btnDevMgr.Click
        'opens device manager
        Process.Start("devmgmt.msc")
    End Sub

    Private Sub btnLocaOn_Click(sender As Object, e As EventArgs) Handles btnLocaOn.Click
        'RF up
        mPort.WriteLine("AT+CGNSPWR=1")
    End Sub

    Private Sub btnLocaOff_Click(sender As Object, e As EventArgs) Handles btnLocaOff.Click
        'GPS Power OFF
        mPort.WriteLine("AT+CGNSPWR=0")
    End Sub

    Private Sub GPS_Fix()

        'Gets location only

        Dim Incoming As String
        mPort.WriteLine("AT+CGNSINF")
        'RemoveHandler mPort.DataReceived, AddressOf DataReceived
        Incoming = mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            Dim line() As String = System.Text.RegularExpressions.Regex.Split(Incoming, Environment.NewLine)
            Dim split_line() As String
            Try
                split_line = Split(line(1), ":", 2)
            Catch ex As Exception
                split_line = Split("CGNSINF:0,0,0,0,0,0,0,0,0,0")
            End Try
            Dim tempstr As String = split_line(split_line.Length - 1)
            Dim incoming_1() As String = Split(tempstr, ",")
            Lat = ArrayAccess(incoming_1, 3)
            Longi = ArrayAccess(incoming_1, 4)
            lblLat.Text = Lat
            lblLong.Text = Longi

            Array.Clear(line, 0, line.Length)
            Array.Clear(split_line, 0, split_line.Length)
            Array.Clear(incoming_1, 0, incoming_1.Length)


        End If

        'AddHandler mPort.DataReceived, AddressOf DataReceived

    End Sub

    Private Function Get_GPS_Fix() As Object

        'different implementation of GPS_Fix()

        Dim Incoming As String
        mPort.WriteLine("AT+CGNSINF")
        'RemoveHandler mPort.DataReceived, AddressOf DataReceived
        Incoming = mPort.ReadExisting()
        If Incoming Is Nothing Then
        Else
            Dim line() As String = System.Text.RegularExpressions.Regex.Split(Incoming, Environment.NewLine)
            Dim split_line() As String
            Try
                split_line = Split(line(1), ":", 2)
            Catch ex As Exception
                split_line = Split("CGNSINF:0,0,0,0,0,0,0,0,0,0")
            End Try
            Dim tempstr As String = split_line(split_line.Length - 1)
            Dim incoming_1() As String = Split(tempstr, ",")
            Lat = ArrayAccess(incoming_1, 3)
            lblLat.Text = Lat
            Longi = ArrayAccess(incoming_1, 4)
            lblLong.Text = Longi

            Array.Clear(line, 0, line.Length)
            Array.Clear(split_line, 0, split_line.Length)
            Array.Clear(incoming_1, 0, incoming_1.Length)


        End If

        'AddHandler mPort.DataReceived, AddressOf DataReceived

        mPort.DiscardInBuffer()
        mPort.DiscardOutBuffer()


        Return {Lat, Longi}
    End Function

    Private Sub btnDetails_Click(sender As Object, e As EventArgs) Handles btnDetails.Click

        'CPSI_Command()
        CPSI_CGNSINF_Command()


    End Sub

    Private Sub btnGetLoca_Click(sender As Object, e As EventArgs) Handles btnGetLoca.Click
        mPort.DiscardOutBuffer()
        GPS_Fix()
    End Sub

    Private Sub btnIOT_Click(sender As Object, e As EventArgs) Handles btnIOT.Click
        mPort.WriteLine("AT+CFUN=4;+CNMP=38;+CFUN=1")
    End Sub

    Private Sub btnGSM_Click(sender As Object, e As EventArgs) Handles btnGSM.Click
        mPort.WriteLine("AT+CFUN=4;+CNMP=13;+CFUN=1")
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        If btnLog.Text = "Start Logging" Then
            btnLog.Text = "Logging"

            fname = System.DateTime.Now.ToString("yyyyMMdd-HHmm")
            Timer1.Interval = Convert.ToInt32(txtTimer.Text)
            Timer1.Start()
        ElseIf btnLog.Text = "Logging" Then
            btnLog.Text = "Start Logging"
            Timer1.Stop()

            DataGridToCSV(DataGridView1, ",")

        End If
    End Sub

    Private Sub btnRFUp_Click(sender As Object, e As EventArgs) Handles btnRFUp.Click
        'RF Up
        mPort.WriteLine("AT+CFUN=1")
        mPort.DiscardInBuffer()
        mPort.DiscardInBuffer()
    End Sub

    Private Sub btnRFDn_Click(sender As Object, e As EventArgs) Handles btnRFDn.Click
        'RF Down
        mPort.WriteLine("AT+CFUN=4")
        mPort.DiscardInBuffer()
        mPort.DiscardInBuffer()
    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DataGridView1.Rows.Clear()
    End Sub

    Private Sub btnCellLock_Click(sender As Object, e As EventArgs) Handles btnCellLock.Click

        'Locks Cell
        Dim message, title, defaultValue As String
        Dim myValue As Object

        message = "Please Enter Cell EARFCN and PCI"
        title = "Lock NB-IoT Cell"
        defaultValue = "EARFCN,PCI"

        myValue = InputBox(message, title, defaultValue)

        If myValue Is "" Then
            mPort.WriteLine("AT+NCELLLOCK=0")
            mPort.DiscardInBuffer()
            mPort.DiscardInBuffer()

        Else
            mPort.WriteLine("AT+NCELLLOCK=1," & myValue.ToString)
            mPort.DiscardInBuffer()
            mPort.DiscardInBuffer()
        End If
    End Sub
End Class
