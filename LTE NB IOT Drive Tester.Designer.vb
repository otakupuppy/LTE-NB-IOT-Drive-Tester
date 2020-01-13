<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fwterm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fwterm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.btnLogClear = New System.Windows.Forms.TabPage()
        Me.btnGSM = New System.Windows.Forms.Button()
        Me.btnIOT = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colTIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCELLID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colPCI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colARFCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLEVEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLong = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetails = New System.Windows.Forms.Button()
        Me.pgGPS = New System.Windows.Forms.TabPage()
        Me.lblLong = New System.Windows.Forms.Label()
        Me.lblLat = New System.Windows.Forms.Label()
        Me.btnGetLoca = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnLocaOff = New System.Windows.Forms.Button()
        Me.btnLocaOn = New System.Windows.Forms.Button()
        Me.pgFunction = New System.Windows.Forms.TabPage()
        Me.btnRFDn = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnRFUp = New System.Windows.Forms.Button()
        Me.btnDevMgr = New System.Windows.Forms.Button()
        Me.lblRSSNR = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.lblRSSI = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblRSRP = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.lblRSRQ = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblARFCN = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lblBand = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblPCI = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSCID = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblLac = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblMccMnc = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblOpMode = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblSysMode = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboStop = New System.Windows.Forms.ComboBox()
        Me.cboData = New System.Windows.Forms.ComboBox()
        Me.cboParity = New System.Windows.Forms.ComboBox()
        Me.cboRate = New System.Windows.Forms.ComboBox()
        Me.cboPort = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip2 = New System.Windows.Forms.StatusStrip()
        Me.lblPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.btnLogClear.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgGPS.SuspendLayout()
        Me.pgFunction.SuspendLayout()
        Me.StatusStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StatusStrip2)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Controls.Add(Me.btnDevMgr)
        Me.Panel1.Controls.Add(Me.lblRSSNR)
        Me.Panel1.Controls.Add(Me.Label24)
        Me.Panel1.Controls.Add(Me.lblRSSI)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.lblRSRP)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.lblRSRQ)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lblARFCN)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.lblBand)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.lblPCI)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.lblSCID)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.lblLac)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblMccMnc)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.lblOpMode)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.lblSysMode)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cboStop)
        Me.Panel1.Controls.Add(Me.cboData)
        Me.Panel1.Controls.Add(Me.cboParity)
        Me.Panel1.Controls.Add(Me.cboRate)
        Me.Panel1.Controls.Add(Me.cboPort)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1087, 735)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.btnLogClear)
        Me.TabControl1.Controls.Add(Me.pgGPS)
        Me.TabControl1.Controls.Add(Me.pgFunction)
        Me.TabControl1.Location = New System.Drawing.Point(247, 26)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(834, 684)
        Me.TabControl1.TabIndex = 4
        '
        'btnLogClear
        '
        Me.btnLogClear.BackColor = System.Drawing.SystemColors.Control
        Me.btnLogClear.Controls.Add(Me.Button1)
        Me.btnLogClear.Controls.Add(Me.btnGSM)
        Me.btnLogClear.Controls.Add(Me.btnIOT)
        Me.btnLogClear.Controls.Add(Me.Label14)
        Me.btnLogClear.Controls.Add(Me.Label8)
        Me.btnLogClear.Controls.Add(Me.txtTimer)
        Me.btnLogClear.Controls.Add(Me.btnLog)
        Me.btnLogClear.Controls.Add(Me.DataGridView1)
        Me.btnLogClear.Controls.Add(Me.btnDetails)
        Me.btnLogClear.Location = New System.Drawing.Point(4, 25)
        Me.btnLogClear.Name = "btnLogClear"
        Me.btnLogClear.Padding = New System.Windows.Forms.Padding(3)
        Me.btnLogClear.Size = New System.Drawing.Size(826, 655)
        Me.btnLogClear.TabIndex = 0
        Me.btnLogClear.Text = "DT"
        '
        'btnGSM
        '
        Me.btnGSM.Location = New System.Drawing.Point(703, 6)
        Me.btnGSM.Name = "btnGSM"
        Me.btnGSM.Size = New System.Drawing.Size(117, 27)
        Me.btnGSM.TabIndex = 136
        Me.btnGSM.Text = "GSM Mode"
        Me.btnGSM.UseVisualStyleBackColor = True
        '
        'btnIOT
        '
        Me.btnIOT.Location = New System.Drawing.Point(703, 38)
        Me.btnIOT.Name = "btnIOT"
        Me.btnIOT.Size = New System.Drawing.Size(117, 27)
        Me.btnIOT.TabIndex = 135
        Me.btnIOT.Text = "IOT Mode"
        Me.btnIOT.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(444, 27)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 134
        Me.Label14.Text = "ms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 25)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 133
        Me.Label8.Text = "Every"
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(342, 25)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(100, 22)
        Me.txtTimer.TabIndex = 132
        Me.txtTimer.Text = "5000"
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(147, 23)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(117, 25)
        Me.btnLog.TabIndex = 131
        Me.btnLog.Text = "Start Logging"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTIME, Me.colTAC, Me.colCELLID, Me.colPCI, Me.colARFCN, Me.colLEVEL, Me.colQUAL, Me.colLat, Me.colLong})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(808, 578)
        Me.DataGridView1.TabIndex = 130
        '
        'colTIME
        '
        Me.colTIME.HeaderText = "TIME"
        Me.colTIME.MinimumWidth = 6
        Me.colTIME.Name = "colTIME"
        Me.colTIME.ReadOnly = True
        Me.colTIME.Width = 125
        '
        'colTAC
        '
        Me.colTAC.HeaderText = "TAC"
        Me.colTAC.MinimumWidth = 6
        Me.colTAC.Name = "colTAC"
        Me.colTAC.ReadOnly = True
        Me.colTAC.Width = 60
        '
        'colCELLID
        '
        Me.colCELLID.HeaderText = "CELLID"
        Me.colCELLID.MinimumWidth = 6
        Me.colCELLID.Name = "colCELLID"
        Me.colCELLID.ReadOnly = True
        Me.colCELLID.Width = 80
        '
        'colPCI
        '
        Me.colPCI.HeaderText = "PCI"
        Me.colPCI.MinimumWidth = 6
        Me.colPCI.Name = "colPCI"
        Me.colPCI.ReadOnly = True
        Me.colPCI.Width = 60
        '
        'colARFCN
        '
        Me.colARFCN.HeaderText = "ARFCN"
        Me.colARFCN.MinimumWidth = 6
        Me.colARFCN.Name = "colARFCN"
        Me.colARFCN.ReadOnly = True
        Me.colARFCN.Width = 60
        '
        'colLEVEL
        '
        Me.colLEVEL.HeaderText = "RSRP"
        Me.colLEVEL.MinimumWidth = 6
        Me.colLEVEL.Name = "colLEVEL"
        Me.colLEVEL.ReadOnly = True
        Me.colLEVEL.Width = 60
        '
        'colQUAL
        '
        Me.colQUAL.HeaderText = "RSRQ"
        Me.colQUAL.MinimumWidth = 6
        Me.colQUAL.Name = "colQUAL"
        Me.colQUAL.ReadOnly = True
        Me.colQUAL.Width = 60
        '
        'colLat
        '
        Me.colLat.HeaderText = "Latitude"
        Me.colLat.MinimumWidth = 6
        Me.colLat.Name = "colLat"
        Me.colLat.ReadOnly = True
        Me.colLat.Width = 125
        '
        'colLong
        '
        Me.colLong.HeaderText = "Longitude"
        Me.colLong.MinimumWidth = 6
        Me.colLong.Name = "colLong"
        Me.colLong.ReadOnly = True
        Me.colLong.Width = 125
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(12, 22)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(117, 27)
        Me.btnDetails.TabIndex = 129
        Me.btnDetails.Text = "Get Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'pgGPS
        '
        Me.pgGPS.BackColor = System.Drawing.SystemColors.Control
        Me.pgGPS.Controls.Add(Me.lblLong)
        Me.pgGPS.Controls.Add(Me.lblLat)
        Me.pgGPS.Controls.Add(Me.btnGetLoca)
        Me.pgGPS.Controls.Add(Me.Label19)
        Me.pgGPS.Controls.Add(Me.Label17)
        Me.pgGPS.Controls.Add(Me.btnLocaOff)
        Me.pgGPS.Controls.Add(Me.btnLocaOn)
        Me.pgGPS.Location = New System.Drawing.Point(4, 25)
        Me.pgGPS.Name = "pgGPS"
        Me.pgGPS.Padding = New System.Windows.Forms.Padding(3)
        Me.pgGPS.Size = New System.Drawing.Size(772, 681)
        Me.pgGPS.TabIndex = 1
        Me.pgGPS.Text = "GPS"
        '
        'lblLong
        '
        Me.lblLong.AutoSize = True
        Me.lblLong.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLong.Location = New System.Drawing.Point(182, 321)
        Me.lblLong.Name = "lblLong"
        Me.lblLong.Size = New System.Drawing.Size(0, 32)
        Me.lblLong.TabIndex = 6
        '
        'lblLat
        '
        Me.lblLat.AutoSize = True
        Me.lblLat.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLat.Location = New System.Drawing.Point(182, 269)
        Me.lblLat.Name = "lblLat"
        Me.lblLat.Size = New System.Drawing.Size(0, 32)
        Me.lblLat.TabIndex = 5
        '
        'btnGetLoca
        '
        Me.btnGetLoca.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btnGetLoca.Location = New System.Drawing.Point(272, 35)
        Me.btnGetLoca.Name = "btnGetLoca"
        Me.btnGetLoca.Size = New System.Drawing.Size(225, 80)
        Me.btnGetLoca.TabIndex = 4
        Me.btnGetLoca.Text = "Get Location"
        Me.btnGetLoca.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(16, 321)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(142, 32)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Longitude"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(16, 269)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(118, 32)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Latitude"
        '
        'btnLocaOff
        '
        Me.btnLocaOff.Location = New System.Drawing.Point(16, 149)
        Me.btnLocaOff.Name = "btnLocaOff"
        Me.btnLocaOff.Size = New System.Drawing.Size(225, 80)
        Me.btnLocaOff.TabIndex = 1
        Me.btnLocaOff.Text = "GPS Power OFF"
        Me.btnLocaOff.UseVisualStyleBackColor = True
        '
        'btnLocaOn
        '
        Me.btnLocaOn.Location = New System.Drawing.Point(16, 35)
        Me.btnLocaOn.Name = "btnLocaOn"
        Me.btnLocaOn.Size = New System.Drawing.Size(225, 80)
        Me.btnLocaOn.TabIndex = 0
        Me.btnLocaOn.Text = "Power ON GPS"
        Me.btnLocaOn.UseVisualStyleBackColor = True
        '
        'pgFunction
        '
        Me.pgFunction.BackColor = System.Drawing.SystemColors.Control
        Me.pgFunction.Controls.Add(Me.btnRFDn)
        Me.pgFunction.Controls.Add(Me.Button5)
        Me.pgFunction.Controls.Add(Me.Button4)
        Me.pgFunction.Controls.Add(Me.Button3)
        Me.pgFunction.Controls.Add(Me.Button2)
        Me.pgFunction.Controls.Add(Me.btnRFUp)
        Me.pgFunction.Location = New System.Drawing.Point(4, 25)
        Me.pgFunction.Name = "pgFunction"
        Me.pgFunction.Padding = New System.Windows.Forms.Padding(3)
        Me.pgFunction.Size = New System.Drawing.Size(772, 681)
        Me.pgFunction.TabIndex = 2
        Me.pgFunction.Text = "Funct."
        '
        'btnRFDn
        '
        Me.btnRFDn.Location = New System.Drawing.Point(12, 115)
        Me.btnRFDn.Name = "btnRFDn"
        Me.btnRFDn.Size = New System.Drawing.Size(196, 68)
        Me.btnRFDn.TabIndex = 6
        Me.btnRFDn.Text = "RF Down"
        Me.btnRFDn.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(12, 192)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(196, 68)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(214, 39)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(196, 68)
        Me.Button4.TabIndex = 3
        Me.Button4.Text = "Lock EARFCN"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(214, 113)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(196, 68)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Button3"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(214, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(196, 68)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnRFUp
        '
        Me.btnRFUp.Location = New System.Drawing.Point(12, 39)
        Me.btnRFUp.Name = "btnRFUp"
        Me.btnRFUp.Size = New System.Drawing.Size(196, 68)
        Me.btnRFUp.TabIndex = 0
        Me.btnRFUp.Text = "RF Up"
        Me.btnRFUp.UseVisualStyleBackColor = True
        '
        'btnDevMgr
        '
        Me.btnDevMgr.Location = New System.Drawing.Point(15, 647)
        Me.btnDevMgr.Name = "btnDevMgr"
        Me.btnDevMgr.Size = New System.Drawing.Size(130, 32)
        Me.btnDevMgr.TabIndex = 121
        Me.btnDevMgr.Text = "Device Manager"
        Me.btnDevMgr.UseVisualStyleBackColor = True
        '
        'lblRSSNR
        '
        Me.lblRSSNR.AutoSize = True
        Me.lblRSSNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSSNR.Location = New System.Drawing.Point(132, 616)
        Me.lblRSSNR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRSSNR.Name = "lblRSSNR"
        Me.lblRSSNR.Size = New System.Drawing.Size(40, 17)
        Me.lblRSSNR.TabIndex = 112
        Me.lblRSSNR.Text = "MCC"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(66, 616)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(61, 17)
        Me.Label24.TabIndex = 111
        Me.Label24.Text = "RSSNR"
        '
        'lblRSSI
        '
        Me.lblRSSI.AutoSize = True
        Me.lblRSSI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSSI.Location = New System.Drawing.Point(132, 596)
        Me.lblRSSI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRSSI.Name = "lblRSSI"
        Me.lblRSSI.Size = New System.Drawing.Size(40, 17)
        Me.lblRSSI.TabIndex = 110
        Me.lblRSSI.Text = "MCC"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(75, 596)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(43, 17)
        Me.Label22.TabIndex = 109
        Me.Label22.Text = "RSSI"
        '
        'lblRSRP
        '
        Me.lblRSRP.AutoSize = True
        Me.lblRSRP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSRP.Location = New System.Drawing.Point(132, 576)
        Me.lblRSRP.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRSRP.Name = "lblRSRP"
        Me.lblRSRP.Size = New System.Drawing.Size(40, 17)
        Me.lblRSRP.TabIndex = 108
        Me.lblRSRP.Text = "MCC"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(74, 576)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 17)
        Me.Label20.TabIndex = 107
        Me.Label20.Text = "RSRP"
        '
        'lblRSRQ
        '
        Me.lblRSRQ.AutoSize = True
        Me.lblRSRQ.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSRQ.Location = New System.Drawing.Point(132, 556)
        Me.lblRSRQ.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRSRQ.Name = "lblRSRQ"
        Me.lblRSRQ.Size = New System.Drawing.Size(40, 17)
        Me.lblRSRQ.TabIndex = 106
        Me.lblRSRQ.Text = "MCC"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(74, 556)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 17)
        Me.Label18.TabIndex = 105
        Me.Label18.Text = "RSRQ"
        '
        'lblARFCN
        '
        Me.lblARFCN.AutoSize = True
        Me.lblARFCN.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblARFCN.Location = New System.Drawing.Point(132, 536)
        Me.lblARFCN.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblARFCN.Name = "lblARFCN"
        Me.lblARFCN.Size = New System.Drawing.Size(40, 17)
        Me.lblARFCN.TabIndex = 104
        Me.lblARFCN.Text = "MCC"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(56, 536)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 17)
        Me.Label16.TabIndex = 103
        Me.Label16.Text = "EARFCN"
        '
        'lblBand
        '
        Me.lblBand.AutoSize = True
        Me.lblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBand.Location = New System.Drawing.Point(131, 516)
        Me.lblBand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblBand.Name = "lblBand"
        Me.lblBand.Size = New System.Drawing.Size(40, 17)
        Me.lblBand.TabIndex = 102
        Me.lblBand.Text = "MCC"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 516)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 17)
        Me.Label11.TabIndex = 101
        Me.Label11.Text = "Freq Band"
        '
        'lblPCI
        '
        Me.lblPCI.AutoSize = True
        Me.lblPCI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCI.Location = New System.Drawing.Point(132, 496)
        Me.lblPCI.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPCI.Name = "lblPCI"
        Me.lblPCI.Size = New System.Drawing.Size(40, 17)
        Me.lblPCI.TabIndex = 100
        Me.lblPCI.Text = "MCC"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(54, 496)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 17)
        Me.Label15.TabIndex = 99
        Me.Label15.Text = "PCELLID"
        '
        'lblSCID
        '
        Me.lblSCID.AutoSize = True
        Me.lblSCID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSCID.Location = New System.Drawing.Point(132, 476)
        Me.lblSCID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSCID.Name = "lblSCID"
        Me.lblSCID.Size = New System.Drawing.Size(40, 17)
        Me.lblSCID.TabIndex = 98
        Me.lblSCID.Text = "MCC"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(54, 476)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "SCELLID"
        '
        'lblLac
        '
        Me.lblLac.AutoSize = True
        Me.lblLac.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLac.Location = New System.Drawing.Point(131, 456)
        Me.lblLac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLac.Name = "lblLac"
        Me.lblLac.Size = New System.Drawing.Size(40, 17)
        Me.lblLac.TabIndex = 96
        Me.lblLac.Text = "MCC"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(53, 456)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 17)
        Me.Label9.TabIndex = 95
        Me.Label9.Text = "LAC/TAC"
        '
        'lblMccMnc
        '
        Me.lblMccMnc.AutoSize = True
        Me.lblMccMnc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMccMnc.Location = New System.Drawing.Point(132, 436)
        Me.lblMccMnc.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMccMnc.Name = "lblMccMnc"
        Me.lblMccMnc.Size = New System.Drawing.Size(40, 17)
        Me.lblMccMnc.TabIndex = 94
        Me.lblMccMnc.Text = "MCC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(45, 436)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 17)
        Me.Label12.TabIndex = 93
        Me.Label12.Text = "MCC-MNC"
        '
        'lblOpMode
        '
        Me.lblOpMode.AutoSize = True
        Me.lblOpMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOpMode.Location = New System.Drawing.Point(132, 416)
        Me.lblOpMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblOpMode.Name = "lblOpMode"
        Me.lblOpMode.Size = New System.Drawing.Size(40, 17)
        Me.lblOpMode.TabIndex = 92
        Me.lblOpMode.Text = "MCC"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(0, 416)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(124, 17)
        Me.Label10.TabIndex = 91
        Me.Label10.Text = "Operation Mode"
        '
        'lblSysMode
        '
        Me.lblSysMode.AutoSize = True
        Me.lblSysMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSysMode.Location = New System.Drawing.Point(132, 396)
        Me.lblSysMode.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSysMode.Name = "lblSysMode"
        Me.lblSysMode.Size = New System.Drawing.Size(40, 17)
        Me.lblSysMode.TabIndex = 90
        Me.lblSysMode.Text = "MCC"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 396)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "System Mode"
        '
        'cboStop
        '
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(27, 347)
        Me.cboStop.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(213, 24)
        Me.cboStop.TabIndex = 10
        '
        'cboData
        '
        Me.cboData.FormattingEnabled = True
        Me.cboData.Location = New System.Drawing.Point(27, 287)
        Me.cboData.Margin = New System.Windows.Forms.Padding(4)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(213, 24)
        Me.cboData.TabIndex = 9
        '
        'cboParity
        '
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Location = New System.Drawing.Point(25, 226)
        Me.cboParity.Margin = New System.Windows.Forms.Padding(4)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(215, 24)
        Me.cboParity.TabIndex = 8
        '
        'cboRate
        '
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Location = New System.Drawing.Point(25, 166)
        Me.cboRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(215, 24)
        Me.cboRate.TabIndex = 7
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(25, 106)
        Me.cboPort.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(215, 24)
        Me.cboPort.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 320)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Stop Bits"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 260)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data Bits"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 199)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Parity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 139)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Baud Rate"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 79)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "COM Port"
        '
        'btnConnect
        '
        Me.btnConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConnect.Location = New System.Drawing.Point(25, 26)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(215, 32)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "Copy")
        Me.ImageList.Images.SetKeyName(1, "Delete")
        Me.ImageList.Images.SetKeyName(2, "Select All")
        Me.ImageList.Images.SetKeyName(3, "Clear All")
        Me.ImageList.Images.SetKeyName(4, "Select None")
        Me.ImageList.Images.SetKeyName(5, "Connect")
        Me.ImageList.Images.SetKeyName(6, "Disconnect")
        Me.ImageList.Images.SetKeyName(7, "Refresh")
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'Timer3
        '
        '
        'StatusStrip2
        '
        Me.StatusStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPort})
        Me.StatusStrip2.Location = New System.Drawing.Point(0, 709)
        Me.StatusStrip2.Name = "StatusStrip2"
        Me.StatusStrip2.Size = New System.Drawing.Size(1087, 26)
        Me.StatusStrip2.TabIndex = 122
        Me.StatusStrip2.Text = "StatusStrip2"
        '
        'lblPort
        '
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(153, 20)
        Me.lblPort.Text = "ToolStripStatusLabel1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(477, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 25)
        Me.Button1.TabIndex = 137
        Me.Button1.Text = "Clear Log"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'fwterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 735)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fwterm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.btnLogClear.ResumeLayout(False)
        Me.btnLogClear.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgGPS.ResumeLayout(False)
        Me.pgGPS.PerformLayout()
        Me.pgFunction.ResumeLayout(False)
        Me.StatusStrip2.ResumeLayout(False)
        Me.StatusStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPort As System.Windows.Forms.ComboBox
    Friend WithEvents cboRate As System.Windows.Forms.ComboBox
    Friend WithEvents cboStop As System.Windows.Forms.ComboBox
    Friend WithEvents cboData As System.Windows.Forms.ComboBox
    Friend WithEvents cboParity As System.Windows.Forms.ComboBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents lblRSSNR As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents lblRSSI As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lblRSRP As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents lblRSRQ As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents lblARFCN As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lblBand As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblPCI As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblSCID As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents lblLac As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lblMccMnc As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents lblOpMode As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblSysMode As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents btnDevMgr As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents btnLogClear As TabPage
    Friend WithEvents btnGSM As Button
    Friend WithEvents btnIOT As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDetails As Button
    Friend WithEvents pgGPS As TabPage
    Friend WithEvents btnLocaOff As Button
    Friend WithEvents btnLocaOn As Button
    Friend WithEvents btnGetLoca As Button
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblLong As Label
    Friend WithEvents lblLat As Label
    Friend WithEvents colTIME As DataGridViewTextBoxColumn
    Friend WithEvents colTAC As DataGridViewTextBoxColumn
    Friend WithEvents colCELLID As DataGridViewTextBoxColumn
    Friend WithEvents colPCI As DataGridViewTextBoxColumn
    Friend WithEvents colARFCN As DataGridViewTextBoxColumn
    Friend WithEvents colLEVEL As DataGridViewTextBoxColumn
    Friend WithEvents colQUAL As DataGridViewTextBoxColumn
    Friend WithEvents colLat As DataGridViewTextBoxColumn
    Friend WithEvents colLong As DataGridViewTextBoxColumn
    Friend WithEvents pgFunction As TabPage
    Friend WithEvents btnRFDn As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnRFUp As Button
    Friend WithEvents StatusStrip2 As StatusStrip
    Friend WithEvents lblPort As ToolStripStatusLabel
    Friend WithEvents Button1 As Button
End Class
