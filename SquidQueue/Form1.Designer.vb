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
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.FontSizeBar = New System.Windows.Forms.TrackBar()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.DebugPrintBtn = New System.Windows.Forms.Button()
        Me.DebugPrintTxt = New System.Windows.Forms.TextBox()
        Me.PrinterNameTxt = New System.Windows.Forms.TextBox()
        Me.PrinterFontBtn = New System.Windows.Forms.Button()
        Me.CalibrationBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UsePrinterChk = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SyncListenChk = New System.Windows.Forms.CheckBox()
        Me.AutoModeStatusLbl = New System.Windows.Forms.Label()
        Me.PrintExactBtn = New System.Windows.Forms.Button()
        Me.TicketNumberLbl = New System.Windows.Forms.TextBox()
        Me.ListenOnTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AutoCheck = New System.Windows.Forms.CheckBox()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
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
        Me.AutoModePinger = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage4.SuspendLayout()
        CType(Me.FontSizeBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
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
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.FontSizeBar)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.DebugPrintBtn)
        Me.TabPage4.Controls.Add(Me.DebugPrintTxt)
        Me.TabPage4.Controls.Add(Me.PrinterNameTxt)
        Me.TabPage4.Controls.Add(Me.PrinterFontBtn)
        Me.TabPage4.Controls.Add(Me.CalibrationBtn)
        Me.TabPage4.Controls.Add(Me.Button2)
        Me.TabPage4.Controls.Add(Me.UsePrinterChk)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(464, 390)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "System settings"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'FontSizeBar
        '
        Me.FontSizeBar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FontSizeBar.Location = New System.Drawing.Point(61, 211)
        Me.FontSizeBar.Maximum = 4
        Me.FontSizeBar.Name = "FontSizeBar"
        Me.FontSizeBar.Size = New System.Drawing.Size(104, 45)
        Me.FontSizeBar.TabIndex = 15
        Me.FontSizeBar.Value = 2
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 216)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 14
        Me.Label18.Text = "Font size:"
        '
        'DebugPrintBtn
        '
        Me.DebugPrintBtn.Location = New System.Drawing.Point(171, 211)
        Me.DebugPrintBtn.Name = "DebugPrintBtn"
        Me.DebugPrintBtn.Size = New System.Drawing.Size(99, 23)
        Me.DebugPrintBtn.TabIndex = 12
        Me.DebugPrintBtn.Text = "Debug Print This"
        Me.DebugPrintBtn.UseVisualStyleBackColor = True
        '
        'DebugPrintTxt
        '
        Me.DebugPrintTxt.Location = New System.Drawing.Point(6, 111)
        Me.DebugPrintTxt.Multiline = True
        Me.DebugPrintTxt.Name = "DebugPrintTxt"
        Me.DebugPrintTxt.Size = New System.Drawing.Size(264, 94)
        Me.DebugPrintTxt.TabIndex = 11
        Me.DebugPrintTxt.Text = "Jackdaws love my big sphinx of quartz. 1234567890"
        '
        'PrinterNameTxt
        '
        Me.PrinterNameTxt.Location = New System.Drawing.Point(77, 43)
        Me.PrinterNameTxt.Name = "PrinterNameTxt"
        Me.PrinterNameTxt.Size = New System.Drawing.Size(100, 20)
        Me.PrinterNameTxt.TabIndex = 2
        Me.PrinterNameTxt.Text = "POS-58"
        '
        'PrinterFontBtn
        '
        Me.PrinterFontBtn.Location = New System.Drawing.Point(6, 69)
        Me.PrinterFontBtn.Name = "PrinterFontBtn"
        Me.PrinterFontBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrinterFontBtn.TabIndex = 10
        Me.PrinterFontBtn.Text = "Font..."
        Me.PrinterFontBtn.UseVisualStyleBackColor = True
        '
        'CalibrationBtn
        '
        Me.CalibrationBtn.Location = New System.Drawing.Point(168, 69)
        Me.CalibrationBtn.Name = "CalibrationBtn"
        Me.CalibrationBtn.Size = New System.Drawing.Size(116, 23)
        Me.CalibrationBtn.TabIndex = 6
        Me.CalibrationBtn.Text = "Font calibration..."
        Me.CalibrationBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(87, 69)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Test font"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UsePrinterChk
        '
        Me.UsePrinterChk.AutoSize = True
        Me.UsePrinterChk.Location = New System.Drawing.Point(6, 13)
        Me.UsePrinterChk.Name = "UsePrinterChk"
        Me.UsePrinterChk.Size = New System.Drawing.Size(77, 17)
        Me.UsePrinterChk.TabIndex = 3
        Me.UsePrinterChk.Text = "Use printer"
        Me.UsePrinterChk.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Printer Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "About me..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.SyncListenChk)
        Me.TabPage3.Controls.Add(Me.AutoModeStatusLbl)
        Me.TabPage3.Controls.Add(Me.PrintExactBtn)
        Me.TabPage3.Controls.Add(Me.TicketNumberLbl)
        Me.TabPage3.Controls.Add(Me.ListenOnTxt)
        Me.TabPage3.Controls.Add(Me.Label4)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Controls.Add(Me.AutoCheck)
        Me.TabPage3.Controls.Add(Me.RegisterButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(464, 390)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Register"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SyncListenChk
        '
        Me.SyncListenChk.AutoSize = True
        Me.SyncListenChk.Location = New System.Drawing.Point(7, 118)
        Me.SyncListenChk.Name = "SyncListenChk"
        Me.SyncListenChk.Size = New System.Drawing.Size(215, 17)
        Me.SyncListenChk.TabIndex = 19
        Me.SyncListenChk.Text = "Sync printing number with listening page"
        Me.SyncListenChk.UseVisualStyleBackColor = True
        '
        'AutoModeStatusLbl
        '
        Me.AutoModeStatusLbl.AutoSize = True
        Me.AutoModeStatusLbl.Location = New System.Drawing.Point(14, 362)
        Me.AutoModeStatusLbl.Name = "AutoModeStatusLbl"
        Me.AutoModeStatusLbl.Size = New System.Drawing.Size(90, 13)
        Me.AutoModeStatusLbl.TabIndex = 18
        Me.AutoModeStatusLbl.Text = "Auto check is off."
        '
        'PrintExactBtn
        '
        Me.PrintExactBtn.Location = New System.Drawing.Point(345, 68)
        Me.PrintExactBtn.Name = "PrintExactBtn"
        Me.PrintExactBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrintExactBtn.TabIndex = 16
        Me.PrintExactBtn.Text = "Print"
        Me.PrintExactBtn.UseVisualStyleBackColor = True
        '
        'TicketNumberLbl
        '
        Me.TicketNumberLbl.Location = New System.Drawing.Point(288, 70)
        Me.TicketNumberLbl.Name = "TicketNumberLbl"
        Me.TicketNumberLbl.Size = New System.Drawing.Size(51, 20)
        Me.TicketNumberLbl.TabIndex = 15
        '
        'ListenOnTxt
        '
        Me.ListenOnTxt.Location = New System.Drawing.Point(64, 92)
        Me.ListenOnTxt.Name = "ListenOnTxt"
        Me.ListenOnTxt.Size = New System.Drawing.Size(100, 20)
        Me.ListenOnTxt.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(187, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Print ticket number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Listen on:"
        '
        'AutoCheck
        '
        Me.AutoCheck.AutoSize = True
        Me.AutoCheck.Location = New System.Drawing.Point(7, 68)
        Me.AutoCheck.Name = "AutoCheck"
        Me.AutoCheck.Size = New System.Drawing.Size(103, 17)
        Me.AutoCheck.TabIndex = 1
        Me.AutoCheck.Text = "Automatic Mode"
        Me.AutoCheck.UseVisualStyleBackColor = True
        '
        'RegisterButton
        '
        Me.RegisterButton.Location = New System.Drawing.Point(3, 3)
        Me.RegisterButton.Name = "RegisterButton"
        Me.RegisterButton.Size = New System.Drawing.Size(164, 57)
        Me.RegisterButton.TabIndex = 0
        Me.RegisterButton.Text = "Register another ticket"
        Me.RegisterButton.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(472, 416)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.CheckTicketBtn)
        Me.TabPage5.Controls.Add(Me.Label8)
        Me.TabPage5.Controls.Add(Me.RafflieChk)
        Me.TabPage5.Controls.Add(Me.SlipDateTimeChk)
        Me.TabPage5.Controls.Add(Me.Label9)
        Me.TabPage5.Controls.Add(Me.Label10)
        Me.TabPage5.Controls.Add(Me.Label6)
        Me.TabPage5.Controls.Add(Me.SlipFooterTxt)
        Me.TabPage5.Controls.Add(Me.SlipRaffleTxt)
        Me.TabPage5.Controls.Add(Me.SlipTitleTxt)
        Me.TabPage5.Controls.Add(Me.LogoPathTxt)
        Me.TabPage5.Controls.Add(Me.PrintLogoChk)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(464, 390)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Ticket Editor"
        Me.TabPage5.UseVisualStyleBackColor = True
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
        Me.LogoPathTxt.Size = New System.Drawing.Size(199, 20)
        Me.LogoPathTxt.TabIndex = 12
        '
        'PrintLogoChk
        '
        Me.PrintLogoChk.AutoSize = True
        Me.PrintLogoChk.Checked = True
        Me.PrintLogoChk.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PrintLogoChk.Location = New System.Drawing.Point(66, 24)
        Me.PrintLogoChk.Name = "PrintLogoChk"
        Me.PrintLogoChk.Size = New System.Drawing.Size(70, 17)
        Me.PrintLogoChk.TabIndex = 10
        Me.PrintLogoChk.Text = "Print logo"
        Me.PrintLogoChk.UseVisualStyleBackColor = True
        '
        'AutoModePinger
        '
        Me.AutoModePinger.Interval = 2000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 441)
        Me.Controls.Add(Me.TotalTicketsLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "RaffleRaffle"
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        CType(Me.FontSizeBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalTicketsLbl As Label
    Friend WithEvents StatusPing As Timer
    Friend WithEvents FontPciker As FontDialog
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents DebugPrintBtn As Button
    Friend WithEvents DebugPrintTxt As TextBox
    Friend WithEvents PrinterNameTxt As TextBox
    Friend WithEvents PrinterFontBtn As Button
    Friend WithEvents CalibrationBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UsePrinterChk As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PrintExactBtn As Button
    Friend WithEvents TicketNumberLbl As TextBox
    Friend WithEvents ListenOnTxt As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AutoCheck As CheckBox
    Friend WithEvents RegisterButton As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage5 As TabPage
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
End Class
