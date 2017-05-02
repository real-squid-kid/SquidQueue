'Imports Microsoft.PointOfService
Imports System.Drawing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class Form1


    Public CurrentTicket As Long
    Public TotalTickets As Long

    Private Sub ShowScreenBtn_Click(sender As Object, e As EventArgs) Handles ShowScreenBtn.Click
        Screen.Show()

    End Sub

    Private Sub ClockCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ClockCheck.CheckedChanged
        If ClockCheck.Checked = True Then
            Screen.ClockLabel.Visible = True
        Else
            Screen.ClockLabel.Visible = False
        End If
    End Sub

    Private Sub CustomCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CustomCheck.CheckedChanged
        If CustomCheck.Checked = True Then
            Screen.CustomLabel.Visible = True
        Else
            Screen.CustomLabel.Visible = False
        End If
    End Sub

    Private Sub CustomLabel_TextChanged(sender As Object, e As EventArgs) Handles CustomLabel.TextChanged
        My.Settings.ScreenLabel = CustomLabel.Text
        Screen.CustomLabel.Text = My.Settings.ScreenLabel
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        TotalTickets = TotalTickets + 1
        PrintTicket(TotalTickets)
        RegisterButton.Enabled = True
        ReEnableTimer.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.PrinterInUse = Nothing Then LoadDefaults()
        TotalTickets = 0
        CurrentTicket = 0
        CustomLabel.Text = My.Settings.ScreenLabel
        LogoPathTxt.Text = My.Settings.LogoPath
        Try
            UsePrinterChk.Checked = My.Settings.PrinterInUse
        Catch
            My.Settings.PrinterInUse = False
        End Try
    End Sub

    Private Sub ReEnableTimer_Tick(sender As Object, e As EventArgs) Handles ReEnableTimer.Tick

        RegisterButton.Enabled = True
        RegisterButton.Text = "Register another ticket"
        If TotalTickets > 0 Then
            ServeButton.Text = "Serve"
            ServeButton.Enabled = True
        End If

    End Sub

    Private Sub ServeButton_Click(sender As Object, e As EventArgs) Handles ServeButton.Click
        If TotalTickets = CurrentTicket Then
            ServeButton.Text = "Can't serve, no more free tickets"
            ReEnableTimer.Enabled = True
            ServeButton.Enabled = False
            Exit Sub
        End If
        CurrentTicket = CurrentTicket + 1
        Screen.CallOut(CurrentTicket)
    End Sub

    Private Sub StatusPing_Tick(sender As Object, e As EventArgs) Handles StatusPing.Tick
        CurrentTicketLbl.Text = CurrentTicket
        TotalTicketsLbl.Text = TotalTickets
        If UsePrinterChk.Checked = False Then
            PrintExactBtn.Enabled = False
            PrinterNameTxt.Enabled = False
            TicketNumberLbl.Enabled = False
            Button2.Enabled = False
            'CalibrationBtn.Enabled = False
            PrintLogoChk.Enabled = False
            LogoPathTxt.Enabled = False
        Else
            PrintExactBtn.Enabled = True
            PrinterNameTxt.Enabled = True
            TicketNumberLbl.Enabled = True
            Button2.Enabled = True
            'CalibrationBtn.Enabled = True
            PrintLogoChk.Enabled = True
            LogoPathTxt.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub BrandedCheck_Click(sender As Object, e As EventArgs)
        '        Screen.Brand()
    End Sub

    Private Sub GenericCheck_Click(sender As Object, e As EventArgs)
        '        Screen.Debrand()
    End Sub

    Private Sub ColorPickerBtn_Click(sender As Object, e As EventArgs) Handles ColorPickerBtn.Click
        Dim cDialog As New ColorDialog() With {
            .Color = Color.White ' initial selection is current color.
            }
        If (cDialog.ShowDialog() = DialogResult.OK) Then
            My.Settings.ScreenFontColor = cDialog.Color
            Screen.Brand() ' update with user selected color.
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .FontName = "Times New Roman"

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Тест шрифта")

            'Printing Date
            .GotoSixth(1)
            .NormalFont()
            .WriteChars("Время:")
            .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header
            .AlignLeft()
            .HugeFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .BigFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .NormalFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .SmallFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .Bold = False
            .HugeFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .BigFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .NormalFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .SmallFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub
    Private Sub PrintTicket(e As Long)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .FontName = "Times New Roman"

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("SquidQueue")
            .WriteLine("Очередь")

            'Printing Date
            .Bold = False
            .GotoSixth(1)
            .NormalFont()
            .WriteChars("Время:")
            .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Number
            .AlignLeft()
            .BigFont()
            .WriteLine("Ваш номер в очереди:")
            .Bold = True
            .HugeFont()
            .AlignCenter()
            .WriteLine(e)
            'Estimated time
            .NormalFont()
            .WriteLine("Примерное время ожидания:")
            .BigFont()
            .AlignCenter()
            .WriteLine("N минут")
            .Bold = False
            'Additional
            .NormalFont()
            .AlignLeft()
            .WriteLine("Сохраняйте купон до конца")
            .WriteLine("мероприятия! Он вам пригодится")
            .WriteLine("во время розыгрыша призов.")
            .FeedPaper(1)
            'Raffle
            .DrawLine()
            .FeedPaper(1)
            .DrawLine()
            .FeedPaper(1)
            .HugeFont()
            .AlignCenter()
            .PrintLogo()
            .FeedPaper(1)
            .Bold = True
            .WriteLine(e)
            .NormalFont()
            .Bold = False
            .WriteLine("Опусти меня в барабан")
            .FeedPaper(1)
            .CutPaper()
            .EndDoc()
        End With
    End Sub

    Private Sub MostAbilities()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .FontName = "Times New Roman"

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Тест принтера")

            'Printing Date
            .GotoSixth(1)
            .NormalFont()
            .WriteChars("Время:")
            .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header
            .GotoSixth(1)
            .WriteChars("#")
            .GotoSixth(2)
            .WriteChars("Description")
            .GotoSixth(5)
            .WriteChars("Count")
            .GotoSixth(6)
            .WriteChars("Total")
            .WriteLine("")
            .DrawLine()
            '.FeedPaper(1)

            'Printing Items
            .SmallFont()
            Dim i As Integer
            For i = 1 To 6
                .GotoSixth(1)
                .WriteChars(i)
                .GotoSixth(2)
                .WriteChars("Item# " & 50 \ 1)
                .GotoSixth(5)
                .WriteChars(50 * 10 \ 1)
                .GotoSixth(6)
                .WriteChars((50 * 50 \ 1) & " JD(s)")
                .WriteLine("")
            Next

            'Printing Totals
            .NormalFont()
            .DrawLine()
            .GotoSixth(1)
            .UnderlineOn()
            .WriteChars("Total")
            .UnderlineOff()
            .GotoSixth(5)
            .WriteChars((50 * 300 \ 1) & " JD(s)")
            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub

    Private Sub PrintExactBtn_Click(sender As Object, e As EventArgs) Handles PrintExactBtn.Click
        PrintTicket(TicketNumberLbl.Text)
    End Sub

    Private Sub UsePrinterChk_CheckedChanged(sender As Object, e As EventArgs) Handles UsePrinterChk.CheckedChanged
        If UsePrinterChk.Checked = True Then
            My.Settings.PrinterInUse = True
            MessageBox.Show("Please be informed that this software was written with a one particular printer in mind, and other printers could produce undesirable result. You can change the code dedicated to printing solution to suit your needs. Check the 'About Me' section for the source code.", "SquidQueue", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            My.Settings.PrinterInUse = False
        End If
    End Sub

    Private Sub PrinterNameTxt_TextChanged(sender As Object, e As EventArgs) Handles PrinterNameTxt.TextChanged
        My.Settings.PrinterName = PrinterNameTxt.Text
    End Sub

    Public Sub CalibrationPage()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .FontName = "Times New Roman"

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Калибровка")

            'Printing Date
            .GotoSixth(1)
            .NormalFont()
            .WriteChars("Время:")
            .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header
            .AlignLeft()
            .HugeFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .BigFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .NormalFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .SmallFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .Bold = False
            .HugeFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .BigFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .NormalFont()
            .WriteLine("1234567890123456789012345678901234567890")
            .SmallFont()
            .WriteLine("1234567890123456789012345678901234567890")
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub

    Private Sub CalibrationBtn_Click(sender As Object, e As EventArgs) Handles CalibrationBtn.Click
        CalibrationPage()
    End Sub

    Private Sub LogoPathTxt_TextChanged(sender As Object, e As EventArgs) Handles LogoPathTxt.TextChanged
        My.Settings.LogoPath = LogoPathTxt.Text
    End Sub

    Private Sub FullHDCheck_CheckedChanged(sender As Object, e As EventArgs) Handles FullHDCheck.CheckedChanged
        If FullHDCheck.Checked = True Then
            Screen.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub HDCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HDCheck.CheckedChanged
        If HDCheck.Checked = True Then
            Screen.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub FontPickerBtn_Click(sender As Object, e As EventArgs) Handles FontPickerBtn.Click
        FontPciker.ShowDialog()
        My.Settings.ScreenFont = FontPciker.Font.Name
        Screen.Brand()
    End Sub
    Public Sub LoadDefaults()
        With My.Settings
            .PrinterName = "POS-58"
            .LogoPath = Nothing
            .ScreenFont = "Century Gothic"
            .ScreenFontColor = Color.White
            .ScreenLabel = "SquidQueue"
            .PrinterInUse = False
            .PrinterFont = "Times New Roman"
        End With
    End Sub
End Class

