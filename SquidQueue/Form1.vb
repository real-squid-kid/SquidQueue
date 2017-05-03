'Imports Microsoft.PointOfService
Imports System.Drawing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6

Public Class Form1


    Public CurrentTicket As Long
    Public TotalTickets As Long
    Public QueueCount As Long
    Public ElapsedTime As Long
    Public EstimateTime As New List(Of Long)
    Public EstimateResult As Long

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
        Dim est As Byte = 0
        If AutoEstimateRdo.Checked Then est = 2
        If ManualEstimateRdo.Checked Then est = 1
        If My.Settings.PrinterInUse Then PrintTicket(TotalTickets, est)
        RegisterButton.Enabled = True
        ReEnableTimer.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstimateResult = 0
        ElapsedTime = 0
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
        SlipTitleTxt.Text = My.Settings.SlipTitle
        SlipDateTimeChk.Checked = My.Settings.PrintDateAndTime
        SlipFooterTxt.Text = My.Settings.SlipFooter
        RafflieChk.Checked = My.Settings.PrintRaffle
        SlipRaffleTxt.Text = My.Settings.RaffleComment
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
        EstimateTime.Add(ElapsedTime)
        ElapsedTime = 0
        CurrentTicket = CurrentTicket + 1
        Screen.CallOut(CurrentTicket)
        'count estimate time
        EstimateResult = 0
        For Each n In EstimateTime
            EstimateResult += n
        Next
        EstimateResult = Math.Round(EstimateResult / (EstimateTime.Count))
        EstimateResultLbl.Text = ToTime(EstimateResult)
    End Sub

    Private Sub StatusPing_Tick(sender As Object, e As EventArgs) Handles StatusPing.Tick
        QueueCount = TotalTickets - CurrentTicket
        QueueCountLbl.Text = QueueCount
        CurrentTicketLbl.Text = CurrentTicket
        TotalTicketsLbl.Text = TotalTickets
        If UsePrinterChk.Checked = False Then
            PrintExactBtn.Enabled = False
            PrinterNameTxt.Enabled = False
            TicketNumberLbl.Enabled = False
            Button2.Enabled = False
            CalibrationBtn.Enabled = False
            PrintLogoChk.Enabled = False
            LogoPathTxt.Enabled = False
            PrinterFontBtn.Enabled = False
            DebugPrintBtn.Enabled = False
            DebugPrintTxt.Enabled = False
            CheckTicketBtn.Enabled = False
            NoEstimateRdo.Checked = True
            NoEstimateRdo.Enabled = False
            AutoEstimateRdo.Enabled = False
            ManualEstimateRdo.Enabled = False
            ManualEstimateTxt.Enabled = False
        Else
            PrintExactBtn.Enabled = True
            PrinterNameTxt.Enabled = True
            TicketNumberLbl.Enabled = True
            Button2.Enabled = True
            CalibrationBtn.Enabled = True
            PrintLogoChk.Enabled = True
            LogoPathTxt.Enabled = True
            PrinterFontBtn.Enabled = True
            DebugPrintBtn.Enabled = True
            DebugPrintTxt.Enabled = True
            CheckTicketBtn.Enabled = True
            NoEstimateRdo.Enabled = True
            AutoEstimateRdo.Enabled = True
            ManualEstimateRdo.Enabled = True
            ManualEstimateTxt.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
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
            .SetFont()

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Тест шрифта")

            'Printing Date
            .GotoSixth(1)
            .NormalFont()
            .AlignLeft()
            .WriteChars(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header

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
    Private Sub PrintTicket(e As Long, est As Byte)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .SetFont()

            'Printing Title
            .FeedPaper(4)
            .AlignLeft()
            .BigFont()
            .Bold = True
            .WriteLine(My.Settings.SlipTitle)

            'Printing Date
            .Bold = False
            .GotoSixth(1)
            .NormalFont()
            .AlignLeft()
            If My.Settings.PrintDateAndTime Then .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Number
            .BigFont()
            .WriteLine("Ваш номер в очереди:")
            .Bold = True
            .HugeFont()
            .AlignCenter()
            .WriteLine(e)
            'Estimated time
            If est = 2 Then
                .NormalFont()
                .WriteLine("Примерное время ожидания:")
                .BigFont()
                .AlignCenter()
                .WriteLine(EstimateResult * QueueCount & " минут")
                .Bold = False
            End If
            If est = 1 Then
                .NormalFont()
                .WriteLine("Примерное время ожидания:")
                .BigFont()
                .AlignCenter()
                .WriteLine(ManualEstimateTxt.Text & " минут")
                .Bold = False
            End If
            .Bold = False
            'Additional
            .NormalFont()
            .AlignLeft()
            .WriteLine(My.Settings.SlipFooter)
            .FeedPaper(1)
            .CutPaper()
            .EndDoc()
        End With
        With P
            If My.Settings.PrintRaffle Then
                Dim Result As Integer = MessageBox.Show("Press OK to print the raffle part.", "SquidQueue", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                If Result = DialogResult.OK Then
                    .RTL = False
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
                    .AlignLeft()
                    .WriteLine(My.Settings.RaffleComment)
                    .FeedPaper(1)
                    .CutPaper()
                    .EndDoc()
                End If
            End If
        End With
    End Sub

    Private Sub MostAbilities()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .SetFont()

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
        Dim est As Byte = 0
        If AutoEstimateRdo.Checked Then est = 2
        If ManualEstimateRdo.Checked Then est = 1
        PrintTicket(TicketNumberLbl.Text, est)
    End Sub

    Private Sub UsePrinterChk_CheckedChanged(sender As Object, e As EventArgs) Handles UsePrinterChk.CheckedChanged
        If UsePrinterChk.Checked = True Then
            My.Settings.PrinterInUse = True
            MessageBox.Show("Please be informed that this software was written with one particular printer in mind, and other printers could produce undesirable result. You can change the code dedicated to printing solution to suit your needs. Check the 'About Me' section for the source code.", "SquidQueue", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            My.Settings.PrinterInUse = False
        End If

    End Sub

    Private Sub PrinterNameTxt_TextChanged(sender As Object, e As EventArgs) Handles PrinterNameTxt.TextChanged
        My.Settings.PrinterName = PrinterNameTxt.Text
    End Sub

    Public Sub CalibrationPage()
        My.Settings.OmitCalibration = True
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .PrintLogo()
            .SetFont()

            'Printing Title
            .FeedPaper(4)
            .AlignCenter()
            .BigFont()
            .Bold = True
            .WriteLine("Калибровка")

            'Printing Date
            .AlignLeft()
            .GotoSixth(1)
            .NormalFont()
            .Bold = False
            .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)

            'Printing Header
            .Bold = False
            .HugeFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .BigFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .NormalFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .SmallFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .Bold = True
            .HugeFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .BigFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .NormalFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            .SmallFont()
            .WriteLine("@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&@@@@&")
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
        My.Settings.OmitCalibration = False
    End Sub

    Private Sub CalibrationBtn_Click(sender As Object, e As EventArgs) Handles CalibrationBtn.Click
        CalibrationPage()
        CalibrationForm.Show()
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
            .PrinterCalibrate(0) = 7
            .PrinterCalibrate(1) = 18
            .PrinterCalibrate(2) = 28
            .PrinterCalibrate(3) = 40
            .PrinterCalibrate(4) = 7
            .PrinterCalibrate(5) = 18
            .PrinterCalibrate(6) = 28
            .PrinterCalibrate(7) = 40
            .OmitCalibration = False

        End With
    End Sub

    Private Sub PrinterFontBtn_Click(sender As Object, e As EventArgs) Handles PrinterFontBtn.Click
        FontPciker.ShowDialog()
        My.Settings.PrinterFont = FontPciker.Font.Name

    End Sub

    Private Sub DebugPrintBtn_Click(sender As Object, e As EventArgs) Handles DebugPrintBtn.Click
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .SetFont()

            'Printing Title
            .FeedPaper(4)

            'Printing Header
            .Bold = False
            .NormalFont()
            .WriteLine(DebugPrintTxt.Text)
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
    End Sub

    Private Sub JustCallOutBtn_Click(sender As Object, e As EventArgs) Handles JustCallOutBtn.Click
        Screen.CallOut(CallOutTxt.Text)
    End Sub

    Private Sub ChgOrderButton_Click(sender As Object, e As EventArgs) Handles ChgOrderButton.Click
        CurrentTicket = CallOutTxt.Text
        Screen.CallOut(CallOutTxt.Text)
    End Sub

    Private Sub SlipTitleTxt_TextChanged(sender As Object, e As EventArgs) Handles SlipTitleTxt.TextChanged
        My.Settings.SlipTitle = SlipTitleTxt.Text
    End Sub

    Private Sub SlipDateTimeChk_CheckedChanged(sender As Object, e As EventArgs) Handles SlipDateTimeChk.CheckedChanged
        My.Settings.PrintDateAndTime = SlipDateTimeChk.Checked
    End Sub

    Private Sub SlipFooterTxt_TextChanged(sender As Object, e As EventArgs) Handles SlipFooterTxt.TextChanged
        My.Settings.SlipFooter = SlipFooterTxt.Text
    End Sub

    Private Sub RafflieChk_CheckedChanged(sender As Object, e As EventArgs) Handles RafflieChk.CheckedChanged
        My.Settings.PrintRaffle = RafflieChk.Checked
        If RafflieChk.Checked Then
            SlipRaffleTxt.Enabled = True
        Else
            SlipRaffleTxt.Enabled = False
        End If
    End Sub

    Private Sub SlipRaffleTxt_TextChanged(sender As Object, e As EventArgs) Handles SlipRaffleTxt.TextChanged
        My.Settings.RaffleComment = SlipRaffleTxt.Text
    End Sub

    Private Sub CheckTicketBtn_Click(sender As Object, e As EventArgs) Handles CheckTicketBtn.Click
        Dim est As Byte = 0
        If AutoEstimateRdo.Checked Then est = 2
        If ManualEstimateRdo.Checked Then est = 1
        PrintTicket(0, 0)
    End Sub
    Public Function ToTime(e As Long)
        Dim Ret As String
        Dim Hrs, Mins, Secs As String
        Hrs = Math.Truncate(e / 3600)
        Mins = Math.Truncate(e / 60) - Hrs * 60
        If Mins < 10 Then Mins = "0" & Mins
        Secs = e - Hrs * 3600 - Mins * 60
        If Secs < 10 Then Secs = "0" & Secs
        Ret = Hrs & ":" & Mins & ":" & Secs
        Return Ret
    End Function

    Public Function ToMins(e As Long)
        Dim Mins As String
        Mins = Math.Truncate(e / 60)
        If Mins < 10 Then Mins = "0" & Mins
        Return Mins
    End Function

    Private Sub SecsCount_Tick(sender As Object, e As EventArgs) Handles SecsCount.Tick
        ElapsedTime += 1
        ElapsedTimeLbl.Text = ToTime(ElapsedTime)
    End Sub

    Private Sub BackPickerBtn_Click(sender As Object, e As EventArgs) Handles BackPickerBtn.Click
        Dim cDialog As New ColorDialog() With {
    .Color = Color.White ' initial selection is current color.
    }
        If (cDialog.ShowDialog() = DialogResult.OK) Then
            My.Settings.BackColor = cDialog.Color
            Screen.Brand() ' update with user selected color.
        End If
    End Sub
End Class

