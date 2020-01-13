<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fwterm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fwterm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTimer = New System.Windows.Forms.TextBox()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.colTIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colCELLID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colC1C2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colARFCN = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colLEVEL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colQUAL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDetails = New System.Windows.Forms.Button()
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
        Me.PanelIO = New System.Windows.Forms.Panel()
        Me.lstData = New System.Windows.Forms.ListBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblPort = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chkCap = New System.Windows.Forms.CheckBox()
        Me.txtSend = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.bgWorker = New System.ComponentModel.BackgroundWorker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelIO.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.txtTimer)
        Me.Panel1.Controls.Add(Me.btnLog)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.btnDetails)
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
        Me.Panel1.Size = New System.Drawing.Size(1034, 683)
        Me.Panel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(698, 24)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 17)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "ms"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(542, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 17)
        Me.Label8.TabIndex = 117
        Me.Label8.Text = "Every"
        '
        'txtTimer
        '
        Me.txtTimer.Location = New System.Drawing.Point(596, 22)
        Me.txtTimer.Name = "txtTimer"
        Me.txtTimer.Size = New System.Drawing.Size(100, 22)
        Me.txtTimer.TabIndex = 116
        Me.txtTimer.Text = "5000"
        '
        'btnLog
        '
        Me.btnLog.Location = New System.Drawing.Point(401, 20)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(117, 25)
        Me.btnLog.TabIndex = 115
        Me.btnLog.Text = "Start Logging"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTIME, Me.colTAC, Me.colCELLID, Me.colC1C2, Me.colARFCN, Me.colLEVEL, Me.colQUAL})
        Me.DataGridView1.Location = New System.Drawing.Point(266, 68)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(749, 589)
        Me.DataGridView1.TabIndex = 114
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
        'colC1C2
        '
        Me.colC1C2.HeaderText = "C1-C2"
        Me.colC1C2.MinimumWidth = 6
        Me.colC1C2.Name = "colC1C2"
        Me.colC1C2.ReadOnly = True
        Me.colC1C2.Width = 60
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
        Me.colLEVEL.HeaderText = "LEVEL"
        Me.colLEVEL.MinimumWidth = 6
        Me.colLEVEL.Name = "colLEVEL"
        Me.colLEVEL.ReadOnly = True
        Me.colLEVEL.Width = 60
        '
        'colQUAL
        '
        Me.colQUAL.HeaderText = "QUAL"
        Me.colQUAL.MinimumWidth = 6
        Me.colQUAL.Name = "colQUAL"
        Me.colQUAL.ReadOnly = True
        Me.colQUAL.Width = 60
        '
        'btnDetails
        '
        Me.btnDetails.Location = New System.Drawing.Point(266, 19)
        Me.btnDetails.Name = "btnDetails"
        Me.btnDetails.Size = New System.Drawing.Size(117, 27)
        Me.btnDetails.TabIndex = 113
        Me.btnDetails.Text = "Get Details"
        Me.btnDetails.UseVisualStyleBackColor = True
        '
        'lblRSSNR
        '
        Me.lblRSSNR.AutoSize = True
        Me.lblRSSNR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRSSNR.Location = New System.Drawing.Point(132, 605)
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
        Me.Label24.Location = New System.Drawing.Point(66, 605)
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
        Me.lblRSSI.Location = New System.Drawing.Point(132, 585)
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
        Me.Label22.Location = New System.Drawing.Point(75, 585)
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
        Me.lblRSRP.Location = New System.Drawing.Point(132, 565)
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
        Me.Label20.Location = New System.Drawing.Point(74, 565)
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
        Me.lblRSRQ.Location = New System.Drawing.Point(132, 545)
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
        Me.Label18.Location = New System.Drawing.Point(74, 545)
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
        Me.lblARFCN.Location = New System.Drawing.Point(132, 525)
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
        Me.Label16.Location = New System.Drawing.Point(56, 525)
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
        Me.lblBand.Location = New System.Drawing.Point(131, 505)
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
        Me.Label11.Location = New System.Drawing.Point(42, 505)
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
        Me.lblPCI.Location = New System.Drawing.Point(132, 485)
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
        Me.Label15.Location = New System.Drawing.Point(54, 485)
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
        Me.lblSCID.Location = New System.Drawing.Point(132, 465)
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
        Me.Label13.Location = New System.Drawing.Point(54, 465)
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
        Me.lblLac.Location = New System.Drawing.Point(131, 445)
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
        Me.Label9.Location = New System.Drawing.Point(53, 445)
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
        Me.lblMccMnc.Location = New System.Drawing.Point(132, 425)
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
        Me.Label12.Location = New System.Drawing.Point(45, 425)
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
        Me.lblOpMode.Location = New System.Drawing.Point(132, 405)
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
        Me.Label10.Location = New System.Drawing.Point(0, 405)
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
        Me.lblSysMode.Location = New System.Drawing.Point(132, 385)
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
        Me.Label7.Location = New System.Drawing.Point(19, 385)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "System Mode"
        '
        'cboStop
        '
        Me.cboStop.FormattingEnabled = True
        Me.cboStop.Location = New System.Drawing.Point(27, 336)
        Me.cboStop.Margin = New System.Windows.Forms.Padding(4)
        Me.cboStop.Name = "cboStop"
        Me.cboStop.Size = New System.Drawing.Size(213, 24)
        Me.cboStop.TabIndex = 10
        '
        'cboData
        '
        Me.cboData.FormattingEnabled = True
        Me.cboData.Location = New System.Drawing.Point(27, 276)
        Me.cboData.Margin = New System.Windows.Forms.Padding(4)
        Me.cboData.Name = "cboData"
        Me.cboData.Size = New System.Drawing.Size(213, 24)
        Me.cboData.TabIndex = 9
        '
        'cboParity
        '
        Me.cboParity.FormattingEnabled = True
        Me.cboParity.Location = New System.Drawing.Point(25, 215)
        Me.cboParity.Margin = New System.Windows.Forms.Padding(4)
        Me.cboParity.Name = "cboParity"
        Me.cboParity.Size = New System.Drawing.Size(215, 24)
        Me.cboParity.TabIndex = 8
        '
        'cboRate
        '
        Me.cboRate.FormattingEnabled = True
        Me.cboRate.Location = New System.Drawing.Point(25, 155)
        Me.cboRate.Margin = New System.Windows.Forms.Padding(4)
        Me.cboRate.Name = "cboRate"
        Me.cboRate.Size = New System.Drawing.Size(215, 24)
        Me.cboRate.TabIndex = 7
        '
        'cboPort
        '
        Me.cboPort.FormattingEnabled = True
        Me.cboPort.Location = New System.Drawing.Point(25, 95)
        Me.cboPort.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPort.Name = "cboPort"
        Me.cboPort.Size = New System.Drawing.Size(215, 24)
        Me.cboPort.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(4, 309)
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
        Me.Label4.Location = New System.Drawing.Point(3, 249)
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
        Me.Label3.Location = New System.Drawing.Point(4, 188)
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
        Me.Label2.Location = New System.Drawing.Point(4, 128)
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
        Me.Label1.Location = New System.Drawing.Point(4, 68)
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
        Me.btnConnect.Location = New System.Drawing.Point(25, 15)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(215, 32)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'PanelIO
        '
        Me.PanelIO.Controls.Add(Me.lstData)
        Me.PanelIO.Controls.Add(Me.StatusStrip1)
        Me.PanelIO.Controls.Add(Me.Panel3)
        Me.PanelIO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelIO.Location = New System.Drawing.Point(1034, 0)
        Me.PanelIO.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelIO.Name = "PanelIO"
        Me.PanelIO.Size = New System.Drawing.Size(400, 683)
        Me.PanelIO.TabIndex = 1
        '
        'lstData
        '
        Me.lstData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lstData.FormattingEnabled = True
        Me.lstData.IntegralHeight = False
        Me.lstData.ItemHeight = 16
        Me.lstData.Location = New System.Drawing.Point(0, 34)
        Me.lstData.Margin = New System.Windows.Forms.Padding(4)
        Me.lstData.Name = "lstData"
        Me.lstData.Size = New System.Drawing.Size(400, 623)
        Me.lstData.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblPort})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 657)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(400, 26)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblPort
        '
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(153, 20)
        Me.lblPort.Text = "ToolStripStatusLabel1"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chkCap)
        Me.Panel3.Controls.Add(Me.txtSend)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(400, 34)
        Me.Panel3.TabIndex = 1
        '
        'chkCap
        '
        Me.chkCap.AutoSize = True
        Me.chkCap.Location = New System.Drawing.Point(296, 7)
        Me.chkCap.Margin = New System.Windows.Forms.Padding(4)
        Me.chkCap.Name = "chkCap"
        Me.chkCap.Size = New System.Drawing.Size(95, 21)
        Me.chkCap.TabIndex = 4
        Me.chkCap.Text = "ALL CAPS"
        Me.chkCap.UseVisualStyleBackColor = True
        '
        'txtSend
        '
        Me.txtSend.Location = New System.Drawing.Point(124, 5)
        Me.txtSend.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSend.Name = "txtSend"
        Me.txtSend.Size = New System.Drawing.Size(165, 22)
        Me.txtSend.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 7)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Text to Send"
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
        'fwterm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1434, 683)
        Me.Controls.Add(Me.PanelIO)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "fwterm"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelIO.ResumeLayout(False)
        Me.PanelIO.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents PanelIO As System.Windows.Forms.Panel
    Friend WithEvents lstData As System.Windows.Forms.ListBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtSend As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkCap As System.Windows.Forms.CheckBox
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents bgWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblPort As System.Windows.Forms.ToolStripStatusLabel
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
    Friend WithEvents btnDetails As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtTimer As TextBox
    Friend WithEvents btnLog As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents colTIME As DataGridViewTextBoxColumn
    Friend WithEvents colTAC As DataGridViewTextBoxColumn
    Friend WithEvents colCELLID As DataGridViewTextBoxColumn
    Friend WithEvents colC1C2 As DataGridViewTextBoxColumn
    Friend WithEvents colARFCN As DataGridViewTextBoxColumn
    Friend WithEvents colLEVEL As DataGridViewTextBoxColumn
    Friend WithEvents colQUAL As DataGridViewTextBoxColumn
    Friend WithEvents Timer1 As Timer
End Class
