<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalTicketsLbl = New System.Windows.Forms.Label()
        Me.StatusPing = New System.Windows.Forms.Timer(Me.components)
        Me.FontPciker = New System.Windows.Forms.FontDialog()
        Me.SettingsTab = New System.Windows.Forms.TabPage()
        Me.LockLbl = New System.Windows.Forms.Label()
        Me.LockBtn = New System.Windows.Forms.Label()
        Me.PrinterSettingsBox = New System.Windows.Forms.GroupBox()
        Me.PickPrinterTxt = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CalibrationBtn = New System.Windows.Forms.Button()
        Me.PrinterFontBtn = New System.Windows.Forms.Button()
        Me.PrinterNameTxt = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DebugPrintTxt = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.FontSizeBar = New System.Windows.Forms.TrackBar()
        Me.DebugPrintBtn = New System.Windows.Forms.Button()
        Me.RollServiceBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.AlwaysRaffleChk = New System.Windows.Forms.CheckBox()
        Me.PrefixTxt = New System.Windows.Forms.TextBox()
        Me.PrefixChk = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AutoCheck = New System.Windows.Forms.CheckBox()
        Me.AutoModeStatusLbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SyncListenChk = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ListenOnTxt = New System.Windows.Forms.TextBox()
        Me.PrintExactBtn = New System.Windows.Forms.Button()
        Me.TicketNumberLbl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.EditorTab = New System.Windows.Forms.TabPage()
        Me.CheckTicketBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RafflieChk = New System.Windows.Forms.CheckBox()
        Me.SlipDateTimeChk = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SlipFooterTxt = New System.Windows.Forms.TextBox()
        Me.SlipRaffleTxt = New System.Windows.Forms.TextBox()
        Me.SlipTitleTxt = New System.Windows.Forms.TextBox()
        Me.LogoPathTxt = New System.Windows.Forms.TextBox()
        Me.PrintLogoChk = New System.Windows.Forms.CheckBox()
        Me.LabelTab = New System.Windows.Forms.TabPage()
        Me.PrintLabelBtn = New System.Windows.Forms.Button()
        Me.OccupationTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MediaTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.OccuLenLbl = New System.Windows.Forms.Label()
        Me.MediaLenLbl = New System.Windows.Forms.Label()
        Me.NameLenLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ExtrasTab = New System.Windows.Forms.TabPage()
        Me.TextExBtn = New System.Windows.Forms.Button()
        Me.CouponFormBtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CameraOpenBtn = New System.Windows.Forms.Button()
        Me.AutoModePinger = New System.Windows.Forms.Timer(Me.components)
        Me.TicketsResetBtn = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.RemainRollProgress = New System.Windows.Forms.ProgressBar()
        Me.RemainRollLbl = New System.Windows.Forms.Label()
        Me.RollPicture = New System.Windows.Forms.PictureBox()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PickImageBtn = New System.Windows.Forms.Button()
        Me.SettingsTab.SuspendLayout()
        Me.PrinterSettingsBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FontSizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.EditorTab.SuspendLayout()
        Me.LabelTab.SuspendLayout()
        Me.ExtrasTab.SuspendLayout()
        CType(Me.RollPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total tickets:"
        '
        'TotalTicketsLbl
        '
        Me.TotalTicketsLbl.AutoSize = True
        Me.TotalTicketsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TotalTicketsLbl.Location = New System.Drawing.Point(491, 48)
        Me.TotalTicketsLbl.Name = "TotalTicketsLbl"
        Me.TotalTicketsLbl.Size = New System.Drawing.Size(51, 55)
        Me.TotalTicketsLbl.TabIndex = 1
        Me.TotalTicketsLbl.Text = "0"
        '
        'StatusPing
        '
        Me.StatusPing.Enabled = True
        '
        'SettingsTab
        '
        Me.SettingsTab.Controls.Add(Me.LockLbl)
        Me.SettingsTab.Controls.Add(Me.LockBtn)
        Me.SettingsTab.Controls.Add(Me.PrinterSettingsBox)
        Me.SettingsTab.Controls.Add(Me.GroupBox2)
        Me.SettingsTab.Controls.Add(Me.RollServiceBtn)
        Me.SettingsTab.Controls.Add(Me.Button1)
        Me.SettingsTab.Location = New System.Drawing.Point(4, 22)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Size = New System.Drawing.Size(464, 346)
        Me.SettingsTab.TabIndex = 3
        Me.SettingsTab.Text = "Printer settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'LockLbl
        '
        Me.LockLbl.AutoSize = True
        Me.LockLbl.Location = New System.Drawing.Point(56, 319)
        Me.LockLbl.Name = "LockLbl"
        Me.LockLbl.Size = New System.Drawing.Size(247, 13)
        Me.LockLbl.TabIndex = 29
        Me.LockLbl.Text = "Press Lock to lock settings and additional features."
        '
        'LockBtn
        '
        Me.LockBtn.AutoSize = True
        Me.LockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LockBtn.Location = New System.Drawing.Point(5, 305)
        Me.LockBtn.Name = "LockBtn"
        Me.LockBtn.Size = New System.Drawing.Size(45, 39)
        Me.LockBtn.TabIndex = 28
        Me.LockBtn.Text = "🔓"
        '
        'PrinterSettingsBox
        '
        Me.PrinterSettingsBox.Controls.Add(Me.PickPrinterTxt)
        Me.PrinterSettingsBox.Controls.Add(Me.Label5)
        Me.PrinterSettingsBox.Controls.Add(Me.Button2)
        Me.PrinterSettingsBox.Controls.Add(Me.CalibrationBtn)
        Me.PrinterSettingsBox.Controls.Add(Me.PrinterFontBtn)
        Me.PrinterSettingsBox.Controls.Add(Me.PrinterNameTxt)
        Me.PrinterSettingsBox.Location = New System.Drawing.Point(6, 3)
        Me.PrinterSettingsBox.Name = "PrinterSettingsBox"
        Me.PrinterSettingsBox.Size = New System.Drawing.Size(271, 122)
        Me.PrinterSettingsBox.TabIndex = 27
        Me.PrinterSettingsBox.TabStop = False
        Me.PrinterSettingsBox.Text = "Printer settings"
        '
        'PickPrinterTxt
        '
        Me.PickPrinterTxt.Location = New System.Drawing.Point(187, 18)
        Me.PickPrinterTxt.Name = "PickPrinterTxt"
        Me.PickPrinterTxt.Size = New System.Drawing.Size(75, 23)
        Me.PickPrinterTxt.TabIndex = 25
        Me.PickPrinterTxt.Text = "Pick..."
        Me.PickPrinterTxt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Printer Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(8, 86)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Test font"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CalibrationBtn
        '
        Me.CalibrationBtn.Location = New System.Drawing.Point(146, 57)
        Me.CalibrationBtn.Name = "CalibrationBtn"
        Me.CalibrationBtn.Size = New System.Drawing.Size(116, 23)
        Me.CalibrationBtn.TabIndex = 6
        Me.CalibrationBtn.Text = "Font calibration..."
        Me.CalibrationBtn.UseVisualStyleBackColor = True
        '
        'PrinterFontBtn
        '
        Me.PrinterFontBtn.Location = New System.Drawing.Point(8, 57)
        Me.PrinterFontBtn.Name = "PrinterFontBtn"
        Me.PrinterFontBtn.Size = New System.Drawing.Size(104, 23)
        Me.PrinterFontBtn.TabIndex = 10
        Me.PrinterFontBtn.Text = "Font..."
        Me.PrinterFontBtn.UseVisualStyleBackColor = True
        '
        'PrinterNameTxt
        '
        Me.PrinterNameTxt.Location = New System.Drawing.Point(81, 20)
        Me.PrinterNameTxt.Name = "PrinterNameTxt"
        Me.PrinterNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.PrinterNameTxt.TabIndex = 2
        Me.PrinterNameTxt.Text = "POS-58"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DebugPrintTxt)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.FontSizeBar)
        Me.GroupBox2.Controls.Add(Me.DebugPrintBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(271, 171)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debug printer"
        '
        'DebugPrintTxt
        '
        Me.DebugPrintTxt.Location = New System.Drawing.Point(8, 19)
        Me.DebugPrintTxt.Multiline = True
        Me.DebugPrintTxt.Name = "DebugPrintTxt"
        Me.DebugPrintTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DebugPrintTxt.Size = New System.Drawing.Size(254, 79)
        Me.DebugPrintTxt.TabIndex = 11
        Me.DebugPrintTxt.Text = "Jackdaws love my big sphinx of quartz. 1234567890"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(13, 109)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Font size:"
        '
        'FontSizeBar
        '
        Me.FontSizeBar.AutoSize = False
        Me.FontSizeBar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FontSizeBar.Location = New System.Drawing.Point(71, 104)
        Me.FontSizeBar.Maximum = 4
        Me.FontSizeBar.Name = "FontSizeBar"
        Me.FontSizeBar.Size = New System.Drawing.Size(104, 38)
        Me.FontSizeBar.TabIndex = 15
        Me.FontSizeBar.Value = 2
        '
        'DebugPrintBtn
        '
        Me.DebugPrintBtn.Location = New System.Drawing.Point(135, 142)
        Me.DebugPrintBtn.Name = "DebugPrintBtn"
        Me.DebugPrintBtn.Size = New System.Drawing.Size(99, 23)
        Me.DebugPrintBtn.TabIndex = 12
        Me.DebugPrintBtn.Text = "Debug Print This"
        Me.DebugPrintBtn.UseVisualStyleBackColor = True
        '
        'RollServiceBtn
        '
        Me.RollServiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RollServiceBtn.Location = New System.Drawing.Point(283, 42)
        Me.RollServiceBtn.Name = "RollServiceBtn"
        Me.RollServiceBtn.Size = New System.Drawing.Size(164, 52)
        Me.RollServiceBtn.TabIndex = 24
        Me.RollServiceBtn.Text = "Change roll..."
        Me.RollServiceBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(366, 314)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About me..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.AlwaysRaffleChk)
        Me.MainTab.Controls.Add(Me.PrefixTxt)
        Me.MainTab.Controls.Add(Me.PrefixChk)
        Me.MainTab.Controls.Add(Me.GroupBox1)
        Me.MainTab.Controls.Add(Me.PrintExactBtn)
        Me.MainTab.Controls.Add(Me.TicketNumberLbl)
        Me.MainTab.Controls.Add(Me.Label4)
        Me.MainTab.Controls.Add(Me.RegisterButton)
        Me.MainTab.Location = New System.Drawing.Point(4, 22)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(464, 346)
        Me.MainTab.TabIndex = 2
        Me.MainTab.Text = "Register"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'AlwaysRaffleChk
        '
        Me.AlwaysRaffleChk.AutoSize = True
        Me.AlwaysRaffleChk.Location = New System.Drawing.Point(265, 205)
        Me.AlwaysRaffleChk.Name = "AlwaysRaffleChk"
        Me.AlwaysRaffleChk.Size = New System.Drawing.Size(129, 17)
        Me.AlwaysRaffleChk.TabIndex = 25
        Me.AlwaysRaffleChk.Text = "Always print raffle part"
        Me.AlwaysRaffleChk.UseVisualStyleBackColor = True
        '
        'PrefixTxt
        '
        Me.PrefixTxt.Location = New System.Drawing.Point(344, 179)
        Me.PrefixTxt.Name = "PrefixTxt"
        Me.PrefixTxt.Size = New System.Drawing.Size(100, 20)
        Me.PrefixTxt.TabIndex = 24
        '
        'PrefixChk
        '
        Me.PrefixChk.AutoSize = True
        Me.PrefixChk.Location = New System.Drawing.Point(265, 182)
        Me.PrefixChk.Name = "PrefixChk"
        Me.PrefixChk.Size = New System.Drawing.Size(73, 17)
        Me.PrefixChk.TabIndex = 23
        Me.PrefixChk.Text = "Add prefix"
        Me.PrefixChk.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AutoCheck)
        Me.GroupBox1.Controls.Add(Me.AutoModeStatusLbl)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.SyncListenChk)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ListenOnTxt)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 126)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatic mode"
        '
        'AutoCheck
        '
        Me.AutoCheck.AutoSize = True
        Me.AutoCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AutoCheck.Location = New System.Drawing.Point(9, 59)
        Me.AutoCheck.Name = "AutoCheck"
        Me.AutoCheck.Size = New System.Drawing.Size(85, 22)
        Me.AutoCheck.TabIndex = 1
        Me.AutoCheck.Text = "Turn on"
        Me.AutoCheck.UseVisualStyleBackColor = True
        '
        'AutoModeStatusLbl
        '
        Me.AutoModeStatusLbl.AutoSize = True
        Me.AutoModeStatusLbl.Location = New System.Drawing.Point(47, 97)
        Me.AutoModeStatusLbl.Name = "AutoModeStatusLbl"
        Me.AutoModeStatusLbl.Size = New System.Drawing.Size(90, 13)
        Me.AutoModeStatusLbl.TabIndex = 18
        Me.AutoModeStatusLbl.Text = "Auto check is off."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(9, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'SyncListenChk
        '
        Me.SyncListenChk.AutoSize = True
        Me.SyncListenChk.Location = New System.Drawing.Point(9, 36)
        Me.SyncListenChk.Name = "SyncListenChk"
        Me.SyncListenChk.Size = New System.Drawing.Size(174, 17)
        Me.SyncListenChk.TabIndex = 19
        Me.SyncListenChk.Text = "Sync printing number with page"
        Me.SyncListenChk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Listen on:"
        '
        'ListenOnTxt
        '
        Me.ListenOnTxt.Location = New System.Drawing.Point(65, 13)
        Me.ListenOnTxt.Name = "ListenOnTxt"
        Me.ListenOnTxt.Size = New System.Drawing.Size(165, 20)
        Me.ListenOnTxt.TabIndex = 3
        '
        'PrintExactBtn
        '
        Me.PrintExactBtn.Location = New System.Drawing.Point(166, 313)
        Me.PrintExactBtn.Name = "PrintExactBtn"
        Me.PrintExactBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrintExactBtn.TabIndex = 16
        Me.PrintExactBtn.Text = "Print"
        Me.PrintExactBtn.UseVisualStyleBackColor = True
        '
        'TicketNumberLbl
        '
        Me.TicketNumberLbl.Location = New System.Drawing.Point(109, 315)
        Me.TicketNumberLbl.Name = "TicketNumberLbl"
        Me.TicketNumberLbl.Size = New System.Drawing.Size(51, 20)
        Me.TicketNumberLbl.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Print ticket number"
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(11, 13)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(448, 151)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "NEXT"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainTab)
        Me.TabControl1.Controls.Add(Me.SettingsTab)
        Me.TabControl1.Controls.Add(Me.EditorTab)
        Me.TabControl1.Controls.Add(Me.LabelTab)
        Me.TabControl1.Controls.Add(Me.ExtrasTab)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 372)
        Me.TabControl1.TabIndex = 0
        '
        'EditorTab
        '
        Me.EditorTab.Controls.Add(Me.PickImageBtn)
        Me.EditorTab.Controls.Add(Me.CheckTicketBtn)
        Me.EditorTab.Controls.Add(Me.Label8)
        Me.EditorTab.Controls.Add(Me.RafflieChk)
        Me.EditorTab.Controls.Add(Me.SlipDateTimeChk)
        Me.EditorTab.Controls.Add(Me.Label9)
        Me.EditorTab.Controls.Add(Me.Label10)
        Me.EditorTab.Controls.Add(Me.Label6)
        Me.EditorTab.Controls.Add(Me.SlipFooterTxt)
        Me.EditorTab.Controls.Add(Me.SlipRaffleTxt)
        Me.EditorTab.Controls.Add(Me.SlipTitleTxt)
        Me.EditorTab.Controls.Add(Me.LogoPathTxt)
        Me.EditorTab.Controls.Add(Me.PrintLogoChk)
        Me.EditorTab.Location = New System.Drawing.Point(4, 22)
        Me.EditorTab.Name = "EditorTab"
        Me.EditorTab.Padding = New System.Windows.Forms.Padding(3)
        Me.EditorTab.Size = New System.Drawing.Size(464, 346)
        Me.EditorTab.TabIndex = 4
        Me.EditorTab.Text = "Ticket Editor"
        Me.EditorTab.UseVisualStyleBackColor = True
        '
        'CheckTicketBtn
        '
        Me.CheckTicketBtn.Location = New System.Drawing.Point(182, 288)
        Me.CheckTicketBtn.Name = "CheckTicketBtn"
        Me.CheckTicketBtn.Size = New System.Drawing.Size(94, 23)
        Me.CheckTicketBtn.TabIndex = 17
        Me.CheckTicketBtn.Text = "Check ticket"
        Me.CheckTicketBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(212, 97)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number"
        '
        'RafflieChk
        '
        Me.RafflieChk.AutoSize = True
        Me.RafflieChk.Location = New System.Drawing.Point(182, 226)
        Me.RafflieChk.Name = "RafflieChk"
        Me.RafflieChk.Size = New System.Drawing.Size(94, 17)
        Me.RafflieChk.TabIndex = 15
        Me.RafflieChk.Text = "Print raffle part"
        Me.RafflieChk.UseVisualStyleBackColor = True
        '
        'SlipDateTimeChk
        '
        Me.SlipDateTimeChk.AutoSize = True
        Me.SlipDateTimeChk.Location = New System.Drawing.Point(185, 77)
        Me.SlipDateTimeChk.Name = "SlipDateTimeChk"
        Me.SlipDateTimeChk.Size = New System.Drawing.Size(114, 17)
        Me.SlipDateTimeChk.TabIndex = 15
        Me.SlipDateTimeChk.Text = "Print date and time"
        Me.SlipDateTimeChk.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(79, 136)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Footer text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 252)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 13)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Comment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(109, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Title"
        '
        'SlipFooterTxt
        '
        Me.SlipFooterTxt.Location = New System.Drawing.Point(142, 136)
        Me.SlipFooterTxt.Multiline = True
        Me.SlipFooterTxt.Name = "SlipFooterTxt"
        Me.SlipFooterTxt.Size = New System.Drawing.Size(199, 60)
        Me.SlipFooterTxt.TabIndex = 13
        '
        'SlipRaffleTxt
        '
        Me.SlipRaffleTxt.Location = New System.Drawing.Point(142, 249)
        Me.SlipRaffleTxt.Name = "SlipRaffleTxt"
        Me.SlipRaffleTxt.Size = New System.Drawing.Size(199, 20)
        Me.SlipRaffleTxt.TabIndex = 13
        '
        'SlipTitleTxt
        '
        Me.SlipTitleTxt.Location = New System.Drawing.Point(142, 49)
        Me.SlipTitleTxt.Name = "SlipTitleTxt"
        Me.SlipTitleTxt.Size = New System.Drawing.Size(199, 20)
        Me.SlipTitleTxt.TabIndex = 13
        '
        'LogoPathTxt
        '
        Me.LogoPathTxt.Location = New System.Drawing.Point(142, 22)
        Me.LogoPathTxt.Name = "LogoPathTxt"
        Me.LogoPathTxt.Size = New System.Drawing.Size(118, 20)
        Me.LogoPathTxt.TabIndex = 12
        '
        'PrintLogoChk
        '
        Me.PrintLogoChk.AutoSize = True
        Me.PrintLogoChk.Location = New System.Drawing.Point(66, 24)
        Me.PrintLogoChk.Name = "PrintLogoChk"
        Me.PrintLogoChk.Size = New System.Drawing.Size(70, 17)
        Me.PrintLogoChk.TabIndex = 10
        Me.PrintLogoChk.Text = "Print logo"
        Me.PrintLogoChk.UseVisualStyleBackColor = True
        '
        'LabelTab
        '
        Me.LabelTab.Controls.Add(Me.PrintLabelBtn)
        Me.LabelTab.Controls.Add(Me.OccupationTxt)
        Me.LabelTab.Controls.Add(Me.Label11)
        Me.LabelTab.Controls.Add(Me.MediaTxt)
        Me.LabelTab.Controls.Add(Me.Label7)
        Me.LabelTab.Controls.Add(Me.NameTxt)
        Me.LabelTab.Controls.Add(Me.OccuLenLbl)
        Me.LabelTab.Controls.Add(Me.MediaLenLbl)
        Me.LabelTab.Controls.Add(Me.NameLenLbl)
        Me.LabelTab.Controls.Add(Me.Label1)
        Me.LabelTab.Location = New System.Drawing.Point(4, 22)
        Me.LabelTab.Name = "LabelTab"
        Me.LabelTab.Padding = New System.Windows.Forms.Padding(3)
        Me.LabelTab.Size = New System.Drawing.Size(464, 346)
        Me.LabelTab.TabIndex = 5
        Me.LabelTab.Text = "Label Printer"
        Me.LabelTab.UseVisualStyleBackColor = True
        '
        'PrintLabelBtn
        '
        Me.PrintLabelBtn.Location = New System.Drawing.Point(200, 152)
        Me.PrintLabelBtn.Name = "PrintLabelBtn"
        Me.PrintLabelBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrintLabelBtn.TabIndex = 4
        Me.PrintLabelBtn.Text = "Print"
        Me.PrintLabelBtn.UseVisualStyleBackColor = True
        '
        'OccupationTxt
        '
        Me.OccupationTxt.Location = New System.Drawing.Point(114, 109)
        Me.OccupationTxt.Name = "OccupationTxt"
        Me.OccupationTxt.Size = New System.Drawing.Size(255, 20)
        Me.OccupationTxt.TabIndex = 3
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Occupation"
        '
        'MediaTxt
        '
        Me.MediaTxt.Location = New System.Drawing.Point(114, 70)
        Me.MediaTxt.Name = "MediaTxt"
        Me.MediaTxt.Size = New System.Drawing.Size(255, 20)
        Me.MediaTxt.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(69, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Media"
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(114, 32)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(255, 20)
        Me.NameTxt.TabIndex = 1
        '
        'OccuLenLbl
        '
        Me.OccuLenLbl.AutoSize = True
        Me.OccuLenLbl.Location = New System.Drawing.Point(375, 112)
        Me.OccuLenLbl.Name = "OccuLenLbl"
        Me.OccuLenLbl.Size = New System.Drawing.Size(35, 13)
        Me.OccuLenLbl.TabIndex = 0
        Me.OccuLenLbl.Text = "Name"
        '
        'MediaLenLbl
        '
        Me.MediaLenLbl.AutoSize = True
        Me.MediaLenLbl.Location = New System.Drawing.Point(375, 73)
        Me.MediaLenLbl.Name = "MediaLenLbl"
        Me.MediaLenLbl.Size = New System.Drawing.Size(35, 13)
        Me.MediaLenLbl.TabIndex = 0
        Me.MediaLenLbl.Text = "Name"
        '
        'NameLenLbl
        '
        Me.NameLenLbl.AutoSize = True
        Me.NameLenLbl.Location = New System.Drawing.Point(375, 35)
        Me.NameLenLbl.Name = "NameLenLbl"
        Me.NameLenLbl.Size = New System.Drawing.Size(35, 13)
        Me.NameLenLbl.TabIndex = 0
        Me.NameLenLbl.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'ExtrasTab
        '
        Me.ExtrasTab.Controls.Add(Me.TextExBtn)
        Me.ExtrasTab.Controls.Add(Me.CouponFormBtn)
        Me.ExtrasTab.Controls.Add(Me.Label12)
        Me.ExtrasTab.Controls.Add(Me.CameraOpenBtn)
        Me.ExtrasTab.Location = New System.Drawing.Point(4, 22)
        Me.ExtrasTab.Name = "ExtrasTab"
        Me.ExtrasTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ExtrasTab.Size = New System.Drawing.Size(464, 346)
        Me.ExtrasTab.TabIndex = 6
        Me.ExtrasTab.Text = "Extras"
        Me.ExtrasTab.UseVisualStyleBackColor = True
        '
        'TextExBtn
        '
        Me.TextExBtn.Location = New System.Drawing.Point(7, 65)
        Me.TextExBtn.Name = "TextExBtn"
        Me.TextExBtn.Size = New System.Drawing.Size(116, 23)
        Me.TextExBtn.TabIndex = 24
        Me.TextExBtn.Text = "Test exception"
        Me.TextExBtn.UseVisualStyleBackColor = True
        '
        'CouponFormBtn
        '
        Me.CouponFormBtn.Location = New System.Drawing.Point(6, 35)
        Me.CouponFormBtn.Name = "CouponFormBtn"
        Me.CouponFormBtn.Size = New System.Drawing.Size(117, 23)
        Me.CouponFormBtn.TabIndex = 23
        Me.CouponFormBtn.Text = "Print coupon..."
        Me.CouponFormBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(129, 11)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(151, 13)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "< very buggy, use with caution"
        '
        'CameraOpenBtn
        '
        Me.CameraOpenBtn.Location = New System.Drawing.Point(6, 6)
        Me.CameraOpenBtn.Name = "CameraOpenBtn"
        Me.CameraOpenBtn.Size = New System.Drawing.Size(117, 23)
        Me.CameraOpenBtn.TabIndex = 21
        Me.CameraOpenBtn.Text = "Pocket Camera..."
        Me.CameraOpenBtn.UseVisualStyleBackColor = True
        '
        'AutoModePinger
        '
        Me.AutoModePinger.Interval = 2000
        '
        'TicketsResetBtn
        '
        Me.TicketsResetBtn.Location = New System.Drawing.Point(490, 106)
        Me.TicketsResetBtn.Name = "TicketsResetBtn"
        Me.TicketsResetBtn.Size = New System.Drawing.Size(75, 23)
        Me.TicketsResetBtn.TabIndex = 22
        Me.TicketsResetBtn.Text = "Reset"
        Me.TicketsResetBtn.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(13, 413)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 13)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "Approximate roll remaining:"
        '
        'RemainRollProgress
        '
        Me.RemainRollProgress.Location = New System.Drawing.Point(148, 409)
        Me.RemainRollProgress.Name = "RemainRollProgress"
        Me.RemainRollProgress.Size = New System.Drawing.Size(289, 23)
        Me.RemainRollProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.RemainRollProgress.TabIndex = 24
        '
        'RemainRollLbl
        '
        Me.RemainRollLbl.AutoSize = True
        Me.RemainRollLbl.Location = New System.Drawing.Point(443, 413)
        Me.RemainRollLbl.Name = "RemainRollLbl"
        Me.RemainRollLbl.Size = New System.Drawing.Size(33, 13)
        Me.RemainRollLbl.TabIndex = 23
        Me.RemainRollLbl.Text = "100%"
        '
        'RollPicture
        '
        Me.RollPicture.Location = New System.Drawing.Point(482, 400)
        Me.RollPicture.Name = "RollPicture"
        Me.RollPicture.Size = New System.Drawing.Size(32, 32)
        Me.RollPicture.TabIndex = 21
        Me.RollPicture.TabStop = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PickImageBtn
        '
        Me.PickImageBtn.Location = New System.Drawing.Point(266, 20)
        Me.PickImageBtn.Name = "PickImageBtn"
        Me.PickImageBtn.Size = New System.Drawing.Size(75, 23)
        Me.PickImageBtn.TabIndex = 18
        Me.PickImageBtn.Text = "Pick..."
        Me.PickImageBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AcceptButton = Me.RegisterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 441)
        Me.Controls.Add(Me.RemainRollProgress)
        Me.Controls.Add(Me.RollPicture)
        Me.Controls.Add(Me.RemainRollLbl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TicketsResetBtn)
        Me.Controls.Add(Me.TotalTicketsLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RaffleRaffle"
        Me.SettingsTab.ResumeLayout(False)
        Me.SettingsTab.PerformLayout()
        Me.PrinterSettingsBox.ResumeLayout(False)
        Me.PrinterSettingsBox.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.FontSizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainTab.ResumeLayout(False)
        Me.MainTab.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.EditorTab.ResumeLayout(False)
        Me.EditorTab.PerformLayout()
        Me.LabelTab.ResumeLayout(False)
        Me.LabelTab.PerformLayout()
        Me.ExtrasTab.ResumeLayout(False)
        Me.ExtrasTab.PerformLayout()
        CType(Me.RollPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalTicketsLbl As Label
    Friend WithEvents StatusPing As Timer
    Friend WithEvents FontPciker As FontDialog
    Friend WithEvents SettingsTab As TabPage
    Friend WithEvents DebugPrintBtn As Button
    Friend WithEvents DebugPrintTxt As TextBox
    Friend WithEvents PrinterNameTxt As TextBox
    Friend WithEvents PrinterFontBtn As Button
    Friend WithEvents CalibrationBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MainTab As TabPage
    Friend WithEvents PrintExactBtn As Button
    Friend WithEvents TicketNumberLbl As TextBox
    Friend WithEvents ListenOnTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AutoCheck As CheckBox
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents EditorTab As TabPage
    Friend WithEvents LogoPathTxt As TextBox
    Friend WithEvents PrintLogoChk As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RafflieChk As CheckBox
    Friend WithEvents SlipDateTimeChk As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SlipFooterTxt As TextBox
    Friend WithEvents SlipRaffleTxt As TextBox
    Friend WithEvents SlipTitleTxt As TextBox
    Friend WithEvents CheckTicketBtn As Button
    Friend WithEvents FontSizeBar As TrackBar
    Friend WithEvents Label18 As Label
    Friend WithEvents AutoModeStatusLbl As Label
    Friend WithEvents AutoModePinger As Timer
    Friend WithEvents SyncListenChk As CheckBox
    Friend WithEvents LabelTab As TabPage
    Friend WithEvents PrintLabelBtn As Button
    Friend WithEvents OccupationTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MediaTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents OccuLenLbl As Label
    Friend WithEvents MediaLenLbl As Label
    Friend WithEvents NameLenLbl As Label
    Friend WithEvents ExtrasTab As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents CameraOpenBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TicketsResetBtn As Button
    Friend WithEvents CouponFormBtn As Button
    Friend WithEvents RollServiceBtn As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents RemainRollProgress As ProgressBar
    Friend WithEvents RemainRollLbl As Label
    Friend WithEvents RollPicture As PictureBox
    Friend WithEvents TextExBtn As Button
    Friend WithEvents PickPrinterTxt As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents LockLbl As Label
    Friend WithEvents LockBtn As Label
    Friend WithEvents PrinterSettingsBox As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents AlwaysRaffleChk As CheckBox
    Friend WithEvents PrefixTxt As TextBox
    Friend WithEvents PrefixChk As CheckBox
    Friend WithEvents PickImageBtn As Button
End Class
