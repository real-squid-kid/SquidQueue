﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CurrentTicketLbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TotalTicketsLbl = New System.Windows.Forms.Label()
        Me.ReEnableTimer = New System.Windows.Forms.Timer(Me.components)
        Me.StatusPing = New System.Windows.Forms.Timer(Me.components)
        Me.FontPciker = New System.Windows.Forms.FontDialog()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
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
        Me.PrintExactBtn = New System.Windows.Forms.Button()
        Me.TicketNumberLbl = New System.Windows.Forms.TextBox()
        Me.ListenOnTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AutoCheck = New System.Windows.Forms.CheckBox()
        Me.RegisterButton = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.ChgOrderButton = New System.Windows.Forms.Button()
        Me.JustCallOutBtn = New System.Windows.Forms.Button()
        Me.CallOutTxt = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ServeButton = New System.Windows.Forms.Button()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.FontPickerBtn = New System.Windows.Forms.Button()
        Me.ColorPickerBtn = New System.Windows.Forms.Button()
        Me.CustomLabel = New System.Windows.Forms.TextBox()
        Me.CustomCheck = New System.Windows.Forms.CheckBox()
        Me.ClockCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FullHDCheck = New System.Windows.Forms.RadioButton()
        Me.HDCheck = New System.Windows.Forms.RadioButton()
        Me.ShowScreenBtn = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RafflieChk = New System.Windows.Forms.CheckBox()
        Me.EstimatedTimeChk = New System.Windows.Forms.CheckBox()
        Me.SlipDateTimeChk = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SlipFooterTxt = New System.Windows.Forms.TextBox()
        Me.SlipRaffleTxt = New System.Windows.Forms.TextBox()
        Me.SlipTitleTxt = New System.Windows.Forms.TextBox()
        Me.LogoPathTxt = New System.Windows.Forms.TextBox()
        Me.PrintLogoChk = New System.Windows.Forms.CheckBox()
        Me.CheckTicketBtn = New System.Windows.Forms.Button()
        Me.TabPage4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(492, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Now serving:"
        '
        'CurrentTicketLbl
        '
        Me.CurrentTicketLbl.AutoSize = True
        Me.CurrentTicketLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.CurrentTicketLbl.Location = New System.Drawing.Point(491, 48)
        Me.CurrentTicketLbl.Name = "CurrentTicketLbl"
        Me.CurrentTicketLbl.Size = New System.Drawing.Size(51, 55)
        Me.CurrentTicketLbl.TabIndex = 1
        Me.CurrentTicketLbl.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total tickets:"
        '
        'TotalTicketsLbl
        '
        Me.TotalTicketsLbl.AutoSize = True
        Me.TotalTicketsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TotalTicketsLbl.Location = New System.Drawing.Point(491, 116)
        Me.TotalTicketsLbl.Name = "TotalTicketsLbl"
        Me.TotalTicketsLbl.Size = New System.Drawing.Size(51, 55)
        Me.TotalTicketsLbl.TabIndex = 1
        Me.TotalTicketsLbl.Text = "0"
        '
        'ReEnableTimer
        '
        Me.ReEnableTimer.Interval = 3000
        '
        'StatusPing
        '
        Me.StatusPing.Enabled = True
        '
        'TabPage4
        '
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
        'DebugPrintBtn
        '
        Me.DebugPrintBtn.Location = New System.Drawing.Point(159, 273)
        Me.DebugPrintBtn.Name = "DebugPrintBtn"
        Me.DebugPrintBtn.Size = New System.Drawing.Size(99, 23)
        Me.DebugPrintBtn.TabIndex = 12
        Me.DebugPrintBtn.Text = "Debug Print This"
        Me.DebugPrintBtn.UseVisualStyleBackColor = True
        '
        'DebugPrintTxt
        '
        Me.DebugPrintTxt.Location = New System.Drawing.Point(8, 173)
        Me.DebugPrintTxt.Multiline = True
        Me.DebugPrintTxt.Name = "DebugPrintTxt"
        Me.DebugPrintTxt.Size = New System.Drawing.Size(250, 94)
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
        Me.PrinterFontBtn.Location = New System.Drawing.Point(8, 133)
        Me.PrinterFontBtn.Name = "PrinterFontBtn"
        Me.PrinterFontBtn.Size = New System.Drawing.Size(75, 23)
        Me.PrinterFontBtn.TabIndex = 10
        Me.PrinterFontBtn.Text = "Font..."
        Me.PrinterFontBtn.UseVisualStyleBackColor = True
        '
        'CalibrationBtn
        '
        Me.CalibrationBtn.Location = New System.Drawing.Point(345, 133)
        Me.CalibrationBtn.Name = "CalibrationBtn"
        Me.CalibrationBtn.Size = New System.Drawing.Size(116, 23)
        Me.CalibrationBtn.TabIndex = 6
        Me.CalibrationBtn.Text = "Font calibration..."
        Me.CalibrationBtn.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 133)
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
        Me.ListenOnTxt.Enabled = False
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
        Me.AutoCheck.Enabled = False
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.ChgOrderButton)
        Me.TabPage2.Controls.Add(Me.JustCallOutBtn)
        Me.TabPage2.Controls.Add(Me.CallOutTxt)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.ServeButton)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(464, 390)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Operator"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'ChgOrderButton
        '
        Me.ChgOrderButton.Location = New System.Drawing.Point(312, 41)
        Me.ChgOrderButton.Name = "ChgOrderButton"
        Me.ChgOrderButton.Size = New System.Drawing.Size(135, 23)
        Me.ChgOrderButton.TabIndex = 3
        Me.ChgOrderButton.Text = "Serve and change order"
        Me.ChgOrderButton.UseVisualStyleBackColor = True
        '
        'JustCallOutBtn
        '
        Me.JustCallOutBtn.Location = New System.Drawing.Point(312, 13)
        Me.JustCallOutBtn.Name = "JustCallOutBtn"
        Me.JustCallOutBtn.Size = New System.Drawing.Size(135, 23)
        Me.JustCallOutBtn.TabIndex = 3
        Me.JustCallOutBtn.Text = "Just serve"
        Me.JustCallOutBtn.UseVisualStyleBackColor = True
        '
        'CallOutTxt
        '
        Me.CallOutTxt.Location = New System.Drawing.Point(205, 28)
        Me.CallOutTxt.Name = "CallOutTxt"
        Me.CallOutTxt.Size = New System.Drawing.Size(100, 20)
        Me.CallOutTxt.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Serve this:"
        '
        'ServeButton
        '
        Me.ServeButton.Location = New System.Drawing.Point(6, 6)
        Me.ServeButton.Name = "ServeButton"
        Me.ServeButton.Size = New System.Drawing.Size(130, 62)
        Me.ServeButton.TabIndex = 0
        Me.ServeButton.Text = "Serve next"
        Me.ServeButton.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.FontPickerBtn)
        Me.TabPage1.Controls.Add(Me.ColorPickerBtn)
        Me.TabPage1.Controls.Add(Me.CustomLabel)
        Me.TabPage1.Controls.Add(Me.CustomCheck)
        Me.TabPage1.Controls.Add(Me.ClockCheck)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.ShowScreenBtn)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(464, 390)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Screen"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'FontPickerBtn
        '
        Me.FontPickerBtn.Location = New System.Drawing.Point(116, 97)
        Me.FontPickerBtn.Name = "FontPickerBtn"
        Me.FontPickerBtn.Size = New System.Drawing.Size(114, 23)
        Me.FontPickerBtn.TabIndex = 11
        Me.FontPickerBtn.Text = "Font..."
        Me.FontPickerBtn.UseVisualStyleBackColor = True
        '
        'ColorPickerBtn
        '
        Me.ColorPickerBtn.Location = New System.Drawing.Point(116, 68)
        Me.ColorPickerBtn.Name = "ColorPickerBtn"
        Me.ColorPickerBtn.Size = New System.Drawing.Size(114, 23)
        Me.ColorPickerBtn.TabIndex = 10
        Me.ColorPickerBtn.Text = "Text Color..."
        Me.ColorPickerBtn.UseVisualStyleBackColor = True
        '
        'CustomLabel
        '
        Me.CustomLabel.Location = New System.Drawing.Point(102, 171)
        Me.CustomLabel.MaxLength = 40
        Me.CustomLabel.Name = "CustomLabel"
        Me.CustomLabel.Size = New System.Drawing.Size(160, 20)
        Me.CustomLabel.TabIndex = 9
        Me.CustomLabel.Text = "SquidQueue"
        '
        'CustomCheck
        '
        Me.CustomCheck.AutoSize = True
        Me.CustomCheck.Checked = True
        Me.CustomCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CustomCheck.Location = New System.Drawing.Point(6, 174)
        Me.CustomCheck.Name = "CustomCheck"
        Me.CustomCheck.Size = New System.Drawing.Size(90, 17)
        Me.CustomCheck.TabIndex = 8
        Me.CustomCheck.Text = "Custom Label"
        Me.CustomCheck.UseVisualStyleBackColor = True
        '
        'ClockCheck
        '
        Me.ClockCheck.AutoSize = True
        Me.ClockCheck.Checked = True
        Me.ClockCheck.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClockCheck.Location = New System.Drawing.Point(6, 151)
        Me.ClockCheck.Name = "ClockCheck"
        Me.ClockCheck.Size = New System.Drawing.Size(53, 17)
        Me.ClockCheck.TabIndex = 7
        Me.ClockCheck.Text = "Clock"
        Me.ClockCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FullHDCheck)
        Me.GroupBox1.Controls.Add(Me.HDCheck)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(104, 77)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Dimensions"
        '
        'FullHDCheck
        '
        Me.FullHDCheck.AutoSize = True
        Me.FullHDCheck.Location = New System.Drawing.Point(15, 46)
        Me.FullHDCheck.Name = "FullHDCheck"
        Me.FullHDCheck.Size = New System.Drawing.Size(74, 17)
        Me.FullHDCheck.TabIndex = 2
        Me.FullHDCheck.Text = "Maximized"
        Me.FullHDCheck.UseVisualStyleBackColor = True
        '
        'HDCheck
        '
        Me.HDCheck.AutoSize = True
        Me.HDCheck.Checked = True
        Me.HDCheck.Location = New System.Drawing.Point(15, 23)
        Me.HDCheck.Name = "HDCheck"
        Me.HDCheck.Size = New System.Drawing.Size(49, 17)
        Me.HDCheck.TabIndex = 2
        Me.HDCheck.TabStop = True
        Me.HDCheck.Text = "720p"
        Me.HDCheck.UseVisualStyleBackColor = True
        '
        'ShowScreenBtn
        '
        Me.ShowScreenBtn.Location = New System.Drawing.Point(6, 6)
        Me.ShowScreenBtn.Name = "ShowScreenBtn"
        Me.ShowScreenBtn.Size = New System.Drawing.Size(152, 56)
        Me.ShowScreenBtn.TabIndex = 0
        Me.ShowScreenBtn.Text = "Show Screen"
        Me.ShowScreenBtn.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
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
        Me.TabPage5.Controls.Add(Me.EstimatedTimeChk)
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
        'EstimatedTimeChk
        '
        Me.EstimatedTimeChk.AutoSize = True
        Me.EstimatedTimeChk.Enabled = False
        Me.EstimatedTimeChk.Location = New System.Drawing.Point(182, 113)
        Me.EstimatedTimeChk.Name = "EstimatedTimeChk"
        Me.EstimatedTimeChk.Size = New System.Drawing.Size(117, 17)
        Me.EstimatedTimeChk.TabIndex = 15
        Me.EstimatedTimeChk.Text = "Print estimated time"
        Me.EstimatedTimeChk.UseVisualStyleBackColor = True
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
        'CheckTicketBtn
        '
        Me.CheckTicketBtn.Location = New System.Drawing.Point(182, 288)
        Me.CheckTicketBtn.Name = "CheckTicketBtn"
        Me.CheckTicketBtn.Size = New System.Drawing.Size(94, 23)
        Me.CheckTicketBtn.TabIndex = 17
        Me.CheckTicketBtn.Text = "Check ticket"
        Me.CheckTicketBtn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 441)
        Me.Controls.Add(Me.TotalTicketsLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CurrentTicketLbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Control Panel"
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents CurrentTicketLbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TotalTicketsLbl As Label
    Friend WithEvents ReEnableTimer As Timer
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
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ChgOrderButton As Button
    Friend WithEvents JustCallOutBtn As Button
    Friend WithEvents CallOutTxt As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ServeButton As Button
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents FontPickerBtn As Button
    Friend WithEvents ColorPickerBtn As Button
    Friend WithEvents CustomLabel As TextBox
    Friend WithEvents CustomCheck As CheckBox
    Friend WithEvents ClockCheck As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents FullHDCheck As RadioButton
    Friend WithEvents HDCheck As RadioButton
    Friend WithEvents ShowScreenBtn As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents LogoPathTxt As TextBox
    Friend WithEvents PrintLogoChk As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents RafflieChk As CheckBox
    Friend WithEvents EstimatedTimeChk As CheckBox
    Friend WithEvents SlipDateTimeChk As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SlipFooterTxt As TextBox
    Friend WithEvents SlipRaffleTxt As TextBox
    Friend WithEvents SlipTitleTxt As TextBox
    Friend WithEvents CheckTicketBtn As Button
End Class
