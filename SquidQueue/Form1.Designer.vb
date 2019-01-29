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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RollServiceBtn = New System.Windows.Forms.Button()
        Me.MainTab = New System.Windows.Forms.TabPage()
        Me.RepeatTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
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
        Me.PickImageBtn = New System.Windows.Forms.Button()
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
        Me.ExtrasTab = New System.Windows.Forms.TabPage()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PrinWheelTimesTxt = New System.Windows.Forms.TextBox()
        Me.PrintWheelCouponBtn = New System.Windows.Forms.Button()
        Me.TextExBtn = New System.Windows.Forms.Button()
        Me.CouponFormBtn = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CameraOpenBtn = New System.Windows.Forms.Button()
        Me.AutoModePinger = New System.Windows.Forms.Timer(Me.components)
        Me.TicketsResetBtn = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintLabelBtn = New System.Windows.Forms.Button()
        Me.OccupationTxt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.MediaTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NameTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SettingsTab.SuspendLayout()
        Me.PrinterSettingsBox.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.FontSizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainTab.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.EditorTab.SuspendLayout()
        Me.ExtrasTab.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1181, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total tickets:"
        '
        'TotalTicketsLbl
        '
        Me.TotalTicketsLbl.AutoSize = True
        Me.TotalTicketsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TotalTicketsLbl.Location = New System.Drawing.Point(1173, 35)
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
        Me.SettingsTab.Controls.Add(Me.Button1)
        Me.SettingsTab.Location = New System.Drawing.Point(4, 34)
        Me.SettingsTab.Name = "SettingsTab"
        Me.SettingsTab.Size = New System.Drawing.Size(1150, 544)
        Me.SettingsTab.TabIndex = 3
        Me.SettingsTab.Text = "Printer settings"
        Me.SettingsTab.UseVisualStyleBackColor = True
        '
        'LockLbl
        '
        Me.LockLbl.AutoSize = True
        Me.LockLbl.Location = New System.Drawing.Point(62, 491)
        Me.LockLbl.Name = "LockLbl"
        Me.LockLbl.Size = New System.Drawing.Size(500, 25)
        Me.LockLbl.TabIndex = 29
        Me.LockLbl.Text = "Press Lock to lock settings and additional features."
        '
        'LockBtn
        '
        Me.LockBtn.AutoSize = True
        Me.LockBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LockBtn.Location = New System.Drawing.Point(11, 487)
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
        Me.PrinterSettingsBox.Location = New System.Drawing.Point(18, 17)
        Me.PrinterSettingsBox.Name = "PrinterSettingsBox"
        Me.PrinterSettingsBox.Size = New System.Drawing.Size(481, 267)
        Me.PrinterSettingsBox.TabIndex = 27
        Me.PrinterSettingsBox.TabStop = False
        Me.PrinterSettingsBox.Text = "Printer settings"
        '
        'PickPrinterTxt
        '
        Me.PickPrinterTxt.Location = New System.Drawing.Point(347, 27)
        Me.PickPrinterTxt.Name = "PickPrinterTxt"
        Me.PickPrinterTxt.Size = New System.Drawing.Size(128, 31)
        Me.PickPrinterTxt.TabIndex = 25
        Me.PickPrinterTxt.Text = "Pick..."
        Me.PickPrinterTxt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 25)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Printer Name"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(158, 83)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 37)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Test font"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CalibrationBtn
        '
        Me.CalibrationBtn.Location = New System.Drawing.Point(243, 214)
        Me.CalibrationBtn.Name = "CalibrationBtn"
        Me.CalibrationBtn.Size = New System.Drawing.Size(232, 39)
        Me.CalibrationBtn.TabIndex = 6
        Me.CalibrationBtn.Text = "Font calibration..."
        Me.CalibrationBtn.UseVisualStyleBackColor = True
        '
        'PrinterFontBtn
        '
        Me.PrinterFontBtn.Location = New System.Drawing.Point(16, 83)
        Me.PrinterFontBtn.Name = "PrinterFontBtn"
        Me.PrinterFontBtn.Size = New System.Drawing.Size(136, 37)
        Me.PrinterFontBtn.TabIndex = 10
        Me.PrinterFontBtn.Text = "Font..."
        Me.PrinterFontBtn.UseVisualStyleBackColor = True
        '
        'PrinterNameTxt
        '
        Me.PrinterNameTxt.Enabled = False
        Me.PrinterNameTxt.Location = New System.Drawing.Point(154, 27)
        Me.PrinterNameTxt.Name = "PrinterNameTxt"
        Me.PrinterNameTxt.Size = New System.Drawing.Size(187, 31)
        Me.PrinterNameTxt.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DebugPrintTxt)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.FontSizeBar)
        Me.GroupBox2.Controls.Add(Me.DebugPrintBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(690, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(445, 267)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Debug printer"
        '
        'DebugPrintTxt
        '
        Me.DebugPrintTxt.Location = New System.Drawing.Point(11, 39)
        Me.DebugPrintTxt.Multiline = True
        Me.DebugPrintTxt.Name = "DebugPrintTxt"
        Me.DebugPrintTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DebugPrintTxt.Size = New System.Drawing.Size(428, 88)
        Me.DebugPrintTxt.TabIndex = 11
        Me.DebugPrintTxt.Text = "Jackdaws love my big sphinx of quartz. 1234567890"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(106, 25)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Font size:"
        '
        'FontSizeBar
        '
        Me.FontSizeBar.AutoSize = False
        Me.FontSizeBar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FontSizeBar.Location = New System.Drawing.Point(206, 147)
        Me.FontSizeBar.Maximum = 4
        Me.FontSizeBar.Name = "FontSizeBar"
        Me.FontSizeBar.Size = New System.Drawing.Size(233, 61)
        Me.FontSizeBar.TabIndex = 15
        Me.FontSizeBar.Value = 2
        '
        'DebugPrintBtn
        '
        Me.DebugPrintBtn.Location = New System.Drawing.Point(206, 214)
        Me.DebugPrintBtn.Name = "DebugPrintBtn"
        Me.DebugPrintBtn.Size = New System.Drawing.Size(233, 47)
        Me.DebugPrintBtn.TabIndex = 12
        Me.DebugPrintBtn.Text = "Debug Print This"
        Me.DebugPrintBtn.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(972, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 40)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About me..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RollServiceBtn
        '
        Me.RollServiceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RollServiceBtn.Location = New System.Drawing.Point(1177, 200)
        Me.RollServiceBtn.Name = "RollServiceBtn"
        Me.RollServiceBtn.Size = New System.Drawing.Size(82, 76)
        Me.RollServiceBtn.TabIndex = 24
        Me.RollServiceBtn.Text = "Chg roll"
        Me.RollServiceBtn.UseVisualStyleBackColor = True
        '
        'MainTab
        '
        Me.MainTab.Controls.Add(Me.RepeatTxt)
        Me.MainTab.Controls.Add(Me.Label14)
        Me.MainTab.Controls.Add(Me.AlwaysRaffleChk)
        Me.MainTab.Controls.Add(Me.PrefixTxt)
        Me.MainTab.Controls.Add(Me.PrefixChk)
        Me.MainTab.Controls.Add(Me.GroupBox1)
        Me.MainTab.Controls.Add(Me.PrintExactBtn)
        Me.MainTab.Controls.Add(Me.TicketNumberLbl)
        Me.MainTab.Controls.Add(Me.Label4)
        Me.MainTab.Controls.Add(Me.RegisterButton)
        Me.MainTab.Location = New System.Drawing.Point(4, 34)
        Me.MainTab.Name = "MainTab"
        Me.MainTab.Size = New System.Drawing.Size(1150, 544)
        Me.MainTab.TabIndex = 2
        Me.MainTab.Text = "Register"
        Me.MainTab.UseVisualStyleBackColor = True
        '
        'RepeatTxt
        '
        Me.RepeatTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RepeatTxt.Location = New System.Drawing.Point(870, 503)
        Me.RepeatTxt.Name = "RepeatTxt"
        Me.RepeatTxt.Size = New System.Drawing.Size(50, 31)
        Me.RepeatTxt.TabIndex = 27
        Me.RepeatTxt.Text = "1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label14.Location = New System.Drawing.Point(681, 510)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(183, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Repeat how many times:"
        '
        'AlwaysRaffleChk
        '
        Me.AlwaysRaffleChk.AutoSize = True
        Me.AlwaysRaffleChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AlwaysRaffleChk.Location = New System.Drawing.Point(516, 272)
        Me.AlwaysRaffleChk.Name = "AlwaysRaffleChk"
        Me.AlwaysRaffleChk.Size = New System.Drawing.Size(244, 29)
        Me.AlwaysRaffleChk.TabIndex = 25
        Me.AlwaysRaffleChk.Text = "Always print raffle part"
        Me.AlwaysRaffleChk.UseVisualStyleBackColor = True
        '
        'PrefixTxt
        '
        Me.PrefixTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrefixTxt.Location = New System.Drawing.Point(660, 225)
        Me.PrefixTxt.Name = "PrefixTxt"
        Me.PrefixTxt.Size = New System.Drawing.Size(100, 31)
        Me.PrefixTxt.TabIndex = 24
        '
        'PrefixChk
        '
        Me.PrefixChk.AutoSize = True
        Me.PrefixChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrefixChk.Location = New System.Drawing.Point(516, 227)
        Me.PrefixChk.Name = "PrefixChk"
        Me.PrefixChk.Size = New System.Drawing.Size(128, 29)
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
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 225)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 221)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Automatic mode"
        '
        'AutoCheck
        '
        Me.AutoCheck.AutoSize = True
        Me.AutoCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AutoCheck.Location = New System.Drawing.Point(12, 130)
        Me.AutoCheck.Name = "AutoCheck"
        Me.AutoCheck.Size = New System.Drawing.Size(112, 29)
        Me.AutoCheck.TabIndex = 1
        Me.AutoCheck.Text = "Turn on"
        Me.AutoCheck.UseVisualStyleBackColor = True
        '
        'AutoModeStatusLbl
        '
        Me.AutoModeStatusLbl.AutoSize = True
        Me.AutoModeStatusLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AutoModeStatusLbl.Location = New System.Drawing.Point(44, 172)
        Me.AutoModeStatusLbl.Name = "AutoModeStatusLbl"
        Me.AutoModeStatusLbl.Size = New System.Drawing.Size(177, 25)
        Me.AutoModeStatusLbl.TabIndex = 18
        Me.AutoModeStatusLbl.Text = "Auto check is off."
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(6, 165)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'SyncListenChk
        '
        Me.SyncListenChk.AutoSize = True
        Me.SyncListenChk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SyncListenChk.Location = New System.Drawing.Point(12, 68)
        Me.SyncListenChk.Name = "SyncListenChk"
        Me.SyncListenChk.Size = New System.Drawing.Size(332, 29)
        Me.SyncListenChk.TabIndex = 19
        Me.SyncListenChk.Text = "Sync printing number with page"
        Me.SyncListenChk.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Listen on:"
        '
        'ListenOnTxt
        '
        Me.ListenOnTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ListenOnTxt.Location = New System.Drawing.Point(118, 25)
        Me.ListenOnTxt.Name = "ListenOnTxt"
        Me.ListenOnTxt.Size = New System.Drawing.Size(321, 31)
        Me.ListenOnTxt.TabIndex = 3
        '
        'PrintExactBtn
        '
        Me.PrintExactBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.PrintExactBtn.Location = New System.Drawing.Point(283, 505)
        Me.PrintExactBtn.Name = "PrintExactBtn"
        Me.PrintExactBtn.Size = New System.Drawing.Size(75, 30)
        Me.PrintExactBtn.TabIndex = 16
        Me.PrintExactBtn.Text = "Print"
        Me.PrintExactBtn.UseVisualStyleBackColor = True
        '
        'TicketNumberLbl
        '
        Me.TicketNumberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TicketNumberLbl.Location = New System.Drawing.Point(157, 504)
        Me.TicketNumberLbl.Name = "TicketNumberLbl"
        Me.TicketNumberLbl.Size = New System.Drawing.Size(120, 31)
        Me.TicketNumberLbl.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 510)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Print ticket number"
        '
        'RegisterButton
        '
        Me.RegisterButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.RegisterButton.Location = New System.Drawing.Point(274, 46)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(637, 113)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "NEXT"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.MainTab)
        Me.TabControl1.Controls.Add(Me.SettingsTab)
        Me.TabControl1.Controls.Add(Me.EditorTab)
        Me.TabControl1.Controls.Add(Me.ExtrasTab)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1158, 582)
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
        Me.EditorTab.Location = New System.Drawing.Point(4, 34)
        Me.EditorTab.Name = "EditorTab"
        Me.EditorTab.Padding = New System.Windows.Forms.Padding(3)
        Me.EditorTab.Size = New System.Drawing.Size(1150, 544)
        Me.EditorTab.TabIndex = 4
        Me.EditorTab.Text = "Ticket Editor"
        Me.EditorTab.UseVisualStyleBackColor = True
        '
        'PickImageBtn
        '
        Me.PickImageBtn.Location = New System.Drawing.Point(748, 14)
        Me.PickImageBtn.Name = "PickImageBtn"
        Me.PickImageBtn.Size = New System.Drawing.Size(123, 31)
        Me.PickImageBtn.TabIndex = 18
        Me.PickImageBtn.Text = "Pick..."
        Me.PickImageBtn.UseVisualStyleBackColor = True
        '
        'CheckTicketBtn
        '
        Me.CheckTicketBtn.Location = New System.Drawing.Point(216, 348)
        Me.CheckTicketBtn.Name = "CheckTicketBtn"
        Me.CheckTicketBtn.Size = New System.Drawing.Size(115, 39)
        Me.CheckTicketBtn.TabIndex = 17
        Me.CheckTicketBtn.Text = "Check ticket"
        Me.CheckTicketBtn.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(210, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(116, 31)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Number"
        '
        'RafflieChk
        '
        Me.RafflieChk.AutoSize = True
        Me.RafflieChk.Location = New System.Drawing.Point(216, 279)
        Me.RafflieChk.Name = "RafflieChk"
        Me.RafflieChk.Size = New System.Drawing.Size(172, 29)
        Me.RafflieChk.TabIndex = 15
        Me.RafflieChk.Text = "Print raffle part"
        Me.RafflieChk.UseVisualStyleBackColor = True
        '
        'SlipDateTimeChk
        '
        Me.SlipDateTimeChk.AutoSize = True
        Me.SlipDateTimeChk.Location = New System.Drawing.Point(216, 109)
        Me.SlipDateTimeChk.Name = "SlipDateTimeChk"
        Me.SlipDateTimeChk.Size = New System.Drawing.Size(211, 29)
        Me.SlipDateTimeChk.TabIndex = 15
        Me.SlipDateTimeChk.Text = "Print date and time"
        Me.SlipDateTimeChk.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(211, 194)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Footer text"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(211, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(103, 25)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Comment"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(211, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 25)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Title"
        '
        'SlipFooterTxt
        '
        Me.SlipFooterTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SlipFooterTxt.Location = New System.Drawing.Point(350, 194)
        Me.SlipFooterTxt.Multiline = True
        Me.SlipFooterTxt.Name = "SlipFooterTxt"
        Me.SlipFooterTxt.Size = New System.Drawing.Size(381, 79)
        Me.SlipFooterTxt.TabIndex = 13
        '
        'SlipRaffleTxt
        '
        Me.SlipRaffleTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SlipRaffleTxt.Location = New System.Drawing.Point(350, 317)
        Me.SlipRaffleTxt.Name = "SlipRaffleTxt"
        Me.SlipRaffleTxt.Size = New System.Drawing.Size(381, 20)
        Me.SlipRaffleTxt.TabIndex = 13
        '
        'SlipTitleTxt
        '
        Me.SlipTitleTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.SlipTitleTxt.Location = New System.Drawing.Point(350, 67)
        Me.SlipTitleTxt.Name = "SlipTitleTxt"
        Me.SlipTitleTxt.Size = New System.Drawing.Size(381, 20)
        Me.SlipTitleTxt.TabIndex = 13
        '
        'LogoPathTxt
        '
        Me.LogoPathTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.LogoPathTxt.Location = New System.Drawing.Point(350, 15)
        Me.LogoPathTxt.Name = "LogoPathTxt"
        Me.LogoPathTxt.Size = New System.Drawing.Size(381, 20)
        Me.LogoPathTxt.TabIndex = 12
        '
        'PrintLogoChk
        '
        Me.PrintLogoChk.AutoSize = True
        Me.PrintLogoChk.Location = New System.Drawing.Point(216, 11)
        Me.PrintLogoChk.Name = "PrintLogoChk"
        Me.PrintLogoChk.Size = New System.Drawing.Size(122, 29)
        Me.PrintLogoChk.TabIndex = 10
        Me.PrintLogoChk.Text = "Print logo"
        Me.PrintLogoChk.UseVisualStyleBackColor = True
        '
        'ExtrasTab
        '
        Me.ExtrasTab.Controls.Add(Me.PrintLabelBtn)
        Me.ExtrasTab.Controls.Add(Me.OccupationTxt)
        Me.ExtrasTab.Controls.Add(Me.Label11)
        Me.ExtrasTab.Controls.Add(Me.MediaTxt)
        Me.ExtrasTab.Controls.Add(Me.Label7)
        Me.ExtrasTab.Controls.Add(Me.NameTxt)
        Me.ExtrasTab.Controls.Add(Me.Label1)
        Me.ExtrasTab.Controls.Add(Me.Label15)
        Me.ExtrasTab.Controls.Add(Me.PrinWheelTimesTxt)
        Me.ExtrasTab.Controls.Add(Me.PrintWheelCouponBtn)
        Me.ExtrasTab.Controls.Add(Me.TextExBtn)
        Me.ExtrasTab.Controls.Add(Me.CouponFormBtn)
        Me.ExtrasTab.Controls.Add(Me.Label12)
        Me.ExtrasTab.Controls.Add(Me.CameraOpenBtn)
        Me.ExtrasTab.Location = New System.Drawing.Point(4, 34)
        Me.ExtrasTab.Name = "ExtrasTab"
        Me.ExtrasTab.Padding = New System.Windows.Forms.Padding(3)
        Me.ExtrasTab.Size = New System.Drawing.Size(1150, 544)
        Me.ExtrasTab.TabIndex = 6
        Me.ExtrasTab.Text = "Extras"
        Me.ExtrasTab.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(389, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(63, 25)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "times"
        '
        'PrinWheelTimesTxt
        '
        Me.PrinWheelTimesTxt.Location = New System.Drawing.Point(314, 221)
        Me.PrinWheelTimesTxt.Name = "PrinWheelTimesTxt"
        Me.PrinWheelTimesTxt.Size = New System.Drawing.Size(69, 31)
        Me.PrinWheelTimesTxt.TabIndex = 25
        Me.PrinWheelTimesTxt.Text = "1"
        '
        'PrintWheelCouponBtn
        '
        Me.PrintWheelCouponBtn.Location = New System.Drawing.Point(6, 206)
        Me.PrintWheelCouponBtn.Name = "PrintWheelCouponBtn"
        Me.PrintWheelCouponBtn.Size = New System.Drawing.Size(285, 60)
        Me.PrintWheelCouponBtn.TabIndex = 24
        Me.PrintWheelCouponBtn.Text = "Print wheel coupon"
        Me.PrintWheelCouponBtn.UseVisualStyleBackColor = True
        '
        'TextExBtn
        '
        Me.TextExBtn.Location = New System.Drawing.Point(6, 140)
        Me.TextExBtn.Name = "TextExBtn"
        Me.TextExBtn.Size = New System.Drawing.Size(285, 50)
        Me.TextExBtn.TabIndex = 24
        Me.TextExBtn.Text = "Test exception"
        Me.TextExBtn.UseVisualStyleBackColor = True
        '
        'CouponFormBtn
        '
        Me.CouponFormBtn.Location = New System.Drawing.Point(6, 73)
        Me.CouponFormBtn.Name = "CouponFormBtn"
        Me.CouponFormBtn.Size = New System.Drawing.Size(285, 50)
        Me.CouponFormBtn.TabIndex = 23
        Me.CouponFormBtn.Text = "Print coupon..."
        Me.CouponFormBtn.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(309, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(303, 25)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "< very buggy, use with caution"
        '
        'CameraOpenBtn
        '
        Me.CameraOpenBtn.Location = New System.Drawing.Point(6, 6)
        Me.CameraOpenBtn.Name = "CameraOpenBtn"
        Me.CameraOpenBtn.Size = New System.Drawing.Size(285, 57)
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
        Me.TicketsResetBtn.BackColor = System.Drawing.Color.Red
        Me.TicketsResetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TicketsResetBtn.Location = New System.Drawing.Point(1177, 93)
        Me.TicketsResetBtn.Name = "TicketsResetBtn"
        Me.TicketsResetBtn.Size = New System.Drawing.Size(82, 77)
        Me.TicketsResetBtn.TabIndex = 22
        Me.TicketsResetBtn.Text = "Reset"
        Me.TicketsResetBtn.UseVisualStyleBackColor = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintLabelBtn
        '
        Me.PrintLabelBtn.Location = New System.Drawing.Point(173, 492)
        Me.PrintLabelBtn.Name = "PrintLabelBtn"
        Me.PrintLabelBtn.Size = New System.Drawing.Size(255, 35)
        Me.PrintLabelBtn.TabIndex = 33
        Me.PrintLabelBtn.Text = "Print"
        Me.PrintLabelBtn.UseVisualStyleBackColor = True
        '
        'OccupationTxt
        '
        Me.OccupationTxt.Location = New System.Drawing.Point(173, 432)
        Me.OccupationTxt.Name = "OccupationTxt"
        Me.OccupationTxt.Size = New System.Drawing.Size(255, 31)
        Me.OccupationTxt.TabIndex = 32
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 435)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(121, 25)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Occupation"
        '
        'MediaTxt
        '
        Me.MediaTxt.Location = New System.Drawing.Point(173, 371)
        Me.MediaTxt.Name = "MediaTxt"
        Me.MediaTxt.Size = New System.Drawing.Size(255, 31)
        Me.MediaTxt.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 25)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Media"
        '
        'NameTxt
        '
        Me.NameTxt.Location = New System.Drawing.Point(173, 314)
        Me.NameTxt.Name = "NameTxt"
        Me.NameTxt.Size = New System.Drawing.Size(255, 31)
        Me.NameTxt.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 314)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Name"
        '
        'Form1
        '
        Me.AcceptButton = Me.RegisterButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 609)
        Me.Controls.Add(Me.RollServiceBtn)
        Me.Controls.Add(Me.TicketsResetBtn)
        Me.Controls.Add(Me.TotalTicketsLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
        Me.ExtrasTab.ResumeLayout(False)
        Me.ExtrasTab.PerformLayout()
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
    Friend WithEvents ExtrasTab As TabPage
    Friend WithEvents Label12 As Label
    Friend WithEvents CameraOpenBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TicketsResetBtn As Button
    Friend WithEvents CouponFormBtn As Button
    Friend WithEvents RollServiceBtn As Button
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
    Friend WithEvents RepeatTxt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents PrintWheelCouponBtn As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents PrinWheelTimesTxt As TextBox
    Friend WithEvents PrintLabelBtn As Button
    Friend WithEvents OccupationTxt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents MediaTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents NameTxt As TextBox
    Friend WithEvents Label1 As Label
End Class
