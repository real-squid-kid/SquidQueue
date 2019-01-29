Imports System.Drawing
Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Imports System.IO
Imports System.Net.Sockets
Imports System.Text
Public Class Form1

    Public CurrentTicket As Long
    Public TotalTickets As Long
    Public QueueCount As Long
    Public ElapsedTime As Long
    Public EstimateTime As New List(Of Long)
    Public EstimateResult As Long
    Public RollPercent As Double
    Public CurrentPassword As String
    Public Blocked As Boolean
    Private AutoCheckThread As Threading.Thread
    Dim AllSounds As String()
    Dim PreviousResult As String

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        Dim n = 1
        n = RepeatTxt.Text
        If n > 1 Then
            Dim response As DialogResult = MessageBox.Show("Printing several tickets could take a LONG time. The program may look hung up while your tickets are preparing. Are you sure?", "RaffleRaffle", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            If response = DialogResult.Cancel Then Exit Sub
        End If
        For i = 1 To n Step 1
            ShowAsBusy()
            TotalTickets += 1
            My.Settings.CurrentTicket = TotalTickets
            My.Settings.Save()
            PrintTicket(TotalTickets, 0)
            RegisterButton.Enabled = True
            ShowAsReady()
        Next i
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EstimateResult = 0
        Blocked = False
        PictureBox1.Image = SystemIcons.Information.ToBitmap
        ElapsedTime = 0
        If My.Settings.PrinterInUse = Nothing Then LoadDefaults()
        TotalTickets = My.Settings.CurrentTicket
        CurrentTicket = My.Settings.CurrentTicket
        LogoPathTxt.Text = My.Settings.LogoPath
        SlipTitleTxt.Text = My.Settings.SlipTitle
        SlipDateTimeChk.Checked = My.Settings.PrintDateAndTime
        SlipFooterTxt.Text = My.Settings.SlipFooter
        RafflieChk.Checked = My.Settings.PrintRaffle
        SlipRaffleTxt.Text = My.Settings.RaffleComment
        AlwaysRaffleChk.Checked = My.Settings.AlwaysRaffle
        PrefixTxt.MaxLength = My.Settings.PrinterCalibrate(4)
        PrefixTxt.Text = My.Settings.Prefix
        PrefixChk.Checked = My.Settings.PrintPrefix
        PrintLogoChk.Checked = My.Settings.PrintLogo
        PrinterNameTxt.Text = My.Settings.PrinterName
        'UpdateLabel()
    End Sub

    Private Sub StatusPing_Tick(sender As Object, e As EventArgs) Handles StatusPing.Tick
        QueueCount = TotalTickets - CurrentTicket
        TotalTicketsLbl.Text = TotalTickets
        If My.Settings.RollRemaining = -1 Then
            RemainRollLbl.Text = "---"
            RemainRollProgress.Style = ProgressBarStyle.Marquee
            RollPicture.Image = SystemIcons.Asterisk.ToBitmap
        Else
            Try
                RemainRollProgress.Style = ProgressBarStyle.Continuous

                RollPercent = Math.Ceiling(My.Settings.RollRemaining / My.Settings.RollTotal * 100)
                RemainRollProgress.Value = RollPercent
                RemainRollLbl.Text = RollPercent & "%"
                If RollPercent < 11 Then
                    RollPicture.Image = SystemIcons.Warning.ToBitmap()
                Else
                    RollPicture.Image = SystemIcons.Asterisk.ToBitmap
                End If
            Catch ex As Exception
                MessageBox.Show("We found an error in tracking roll: " & ex.Message & ". The settings were reset to non-trackable. Sorry!", "RaffleRaffle", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                My.Settings.RollRemaining = -1
                My.Settings.RollTotal = 0
            End Try
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ShowAsBusy()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            If My.Settings.PrintLogo = True Then .PrintLogo()
            .SetFont()

            'Printing Title
            .FeedPaper(1)
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
            .WriteLine("1234567890")
            .BigFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .NormalFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .SmallFont()
            .WriteLine("В чащах леса жил бы цитрус? Да, но фальшивый экземпляръ!")
            .Bold = False
            .HugeFont()
            .WriteLine("1234567890")
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
        ShowAsReady()
    End Sub
    Private Sub PrintTicket(e As Long, est As Byte)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            If My.Settings.PrintLogo = True Then .PrintLogo()
            .SetFont()
            'Printing Title
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
            .WriteLine("Ваш номер:")
            .Bold = True
            .HugeFont()
            .AlignCenter()
            If My.Settings.PrintPrefix = True Then
                .WriteLine(My.Settings.Prefix & "-")
            End If
            .WriteLine(e)
            'Estimated time
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
                If AutoCheck.Checked Then
                    .RTL = False
                    'Raffle
                    If My.Settings.PrintLogo = True Then .PrintLogo()
                    .NormalFont()
                    .DrawLine()
                    .FeedPaper(1)
                    .DrawLine()
                    .NormalFont()
                    If My.Settings.PrintDateAndTime Then .WriteLine(DateTime.Now.ToString)
                    .HugeFont()
                    .AlignLeft()
                    .Bold = True
                    If My.Settings.PrintPrefix = True Then
                        .WriteLine(My.Settings.Prefix & "-")
                    End If
                    .WriteLine(e)
                    .NormalFont()
                    .Bold = False
                    .AlignLeft()
                    .WriteLine(My.Settings.RaffleComment)
                    .FeedPaper(1)
                    .CutPaper()
                    .EndDoc()
                Else
                    If My.Settings.AlwaysRaffle = True Then
                        .RTL = False
                        'Raffle
                        If My.Settings.PrintLogo = True Then .PrintLogo()
                        .NormalFont()
                        .DrawLine()
                        .FeedPaper(1)
                        .DrawLine()
                        .NormalFont()
                        If My.Settings.PrintDateAndTime Then .WriteLine(DateTime.Now.ToString)
                        .HugeFont()
                        .AlignLeft()
                        .Bold = True
                        If My.Settings.PrintPrefix = True Then
                            .WriteLine(My.Settings.Prefix & "-")
                        End If
                        .WriteLine(e)
                        .NormalFont()
                        .Bold = False
                        .AlignLeft()
                        .WriteLine(My.Settings.RaffleComment)
                        .FeedPaper(1)
                        .CutPaper()
                        .EndDoc()
                    Else
                        Dim Result As Integer = MessageBox.Show("Press OK to print the raffle part.", "RaffleRaffle", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                        If Result = DialogResult.OK Then
                            .RTL = False
                            'Raffle
                            If My.Settings.PrintLogo = True Then .PrintLogo()
                            .NormalFont()
                            .DrawLine()
                            .FeedPaper(1)
                            .DrawLine()
                            .NormalFont()
                            If My.Settings.PrintDateAndTime Then .WriteLine(DateTime.Now.ToString)
                            .HugeFont()
                            .AlignLeft()
                            .Bold = True
                            If My.Settings.PrintPrefix = True Then
                                .WriteLine(My.Settings.Prefix & "-")
                            End If
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
                End If
            End If

        End With
    End Sub

    Private Sub MostAbilities()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            If My.Settings.PrintLogo = True Then .PrintLogo()
            .SetFont()

            'Printing Title
            .FeedPaper(1)
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
        ShowAsBusy()
        Dim est As Byte = 0
        PrintTicket(TicketNumberLbl.Text, est)
        ShowAsReady()
    End Sub

    Private Sub PrinterNameTxt_TextChanged(sender As Object, e As EventArgs) Handles PrinterNameTxt.TextChanged
        My.Settings.PrinterName = PrinterNameTxt.Text
        My.Settings.Save()
    End Sub

    Public Sub CalibrationPage()
        ShowAsBusy()
        My.Settings.OmitCalibration = True
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            If My.Settings.PrintLogo = True Then .PrintLogo()
            .SetFont()

            'Printing Title
            .FeedPaper(1)
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
        ShowAsReady()
    End Sub

    Private Sub CalibrationBtn_Click(sender As Object, e As EventArgs) Handles CalibrationBtn.Click
        CalibrationPage()
        CalibrationForm.ShowDialog()
    End Sub

    Private Sub LogoPathTxt_TextChanged(sender As Object, e As EventArgs) Handles LogoPathTxt.TextChanged
        My.Settings.LogoPath = LogoPathTxt.Text
    End Sub
    Public Sub LoadDefaults()
        With My.Settings
            .PrinterName = ""
            .LogoPath = Nothing
            .PrinterInUse = True
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
        ShowAsBusy()
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .SetFont()

            'Printing Title
            .FeedPaper(1)

            'Printing Header
            .Bold = False
            Select Case FontSizeBar.Value
                Case 0
                    .TinyFont()
                    MessageBox.Show("For debug purposes only! Text could be unreadable and word-wrapped wrong.")
                Case 1
                    .SmallFont()
                Case 2
                    .NormalFont()
                Case 3
                    .BigFont()
                Case 4
                    .HugeFont()

            End Select

            .WriteLine(DebugPrintTxt.Text)
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
        ShowAsReady()
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
        ShowAsBusy()
        PrintTicket(0, 0)
        ShowAsReady()
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

    Private Sub ShowAsBusy()
        PictureBox1.Image = SystemIcons.Error.ToBitmap
    End Sub

    Private Sub ShowAsReady()
        PictureBox1.Image = SystemIcons.Information.ToBitmap
    End Sub

    Private Sub AutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles AutoCheck.CheckedChanged
        ShowAsBusy()
        Select Case AutoCheck.Checked
            Case True
                AutoCheckThread = New Threading.Thread(AddressOf ThreadTask) With {
                    .IsBackground = True
                }
                AutoCheckThread.Start()
            Case False
                If AutoCheckThread.IsAlive = True Then
                    AutoCheckThread.Suspend()
                End If
        End Select
        RegisterButton.Enabled = Not AutoCheck.Checked
        If AutoCheck.Checked = False Then
            AutoModeStatusLbl.Text = "Auto check is off."
            PreviousResult = Nothing
        End If
        ShowAsReady()
    End Sub
    'deprecated, left for legacy
    Private Sub AutoModePinger_Tick(sender As Object, e As EventArgs) Handles AutoModePinger.Tick
        ShowAsBusy()
        Try
            Dim webClient As New System.Net.WebClient
            Dim result As String = webClient.DownloadString(ListenOnTxt.Text)
            If PreviousResult = Nothing Then
                PreviousResult = result
                AutoModeStatusLbl.Text = result & ", now listening on " & ListenOnTxt.Text & " ... " & DateTime.Now.ToString
                Exit Sub
            End If
            If PreviousResult = result Then
                PreviousResult = result
                AutoModeStatusLbl.Text = result & ", no changes, still listening..." & DateTime.Now.ToString
            Else
                PreviousResult = result
                AutoModeStatusLbl.Text = "Found a change, printing... " & DateTime.Now.ToString
                'printing function

                Dim est As Byte = 0
                If SyncListenChk.Checked Then
                    TotalTickets = result
                    My.Settings.CurrentTicket = TotalTickets
                    My.Settings.Save()
                    PrintTicket(result, est)
                Else
                    TotalTickets += 1
                    My.Settings.CurrentTicket = TotalTickets
                    My.Settings.Save()
                    PrintTicket(TotalTickets, est)
                End If

                RegisterButton.Enabled = True
                'end printing function
            End If
        Catch ex As Exception
            AutoModeStatusLbl.Text = "Problem accessing listen page, trying again... " & DateTime.Now.ToString
        End Try
        ShowAsReady()
    End Sub

    Private Sub ThreadTask()
        Do
            ShowAsBusy()
            Threading.Thread.Sleep(50)
            Try
                ThreadInfoChanger(AutoModeStatusLbl, "Working...")
                Dim webClient As New System.Net.WebClient
                Dim result As String = webClient.DownloadString(ListenOnTxt.Text)
                If PreviousResult = Nothing Then
                    PreviousResult = result
                    'AutoModeStatusLbl.Text = result & ", now listening on " & ListenOnTxt.Text & " ... " & DateTime.Now.ToString
                    ThreadInfoChanger(AutoModeStatusLbl, result & ", now listening on " & ListenOnTxt.Text & " ... " & DateTime.Now.ToString)
                    Exit Try
                End If
                If PreviousResult = result Then
                    PreviousResult = result
                    'AutoModeStatusLbl.Text = result & ", no changes, still listening..." & DateTime.Now.ToString
                    ThreadInfoChanger(AutoModeStatusLbl, result & ", no changes, still listening..." & DateTime.Now.ToString)
                Else
                    PreviousResult = result
                    'AutoModeStatusLbl.Text = "Found a change, printing... " & DateTime.Now.ToString
                    ThreadInfoChanger(AutoModeStatusLbl, "Found a change, printing... " & DateTime.Now.ToString)
                    My.Computer.Audio.Play(My.Resources.tracker, Microsoft.VisualBasic.AudioPlayMode.Background)
                    'printing function

                    Dim est As Byte = 0
                    If SyncListenChk.Checked Then
                        TotalTickets = result
                        PrintTicket(result, est)
                    Else
                        TotalTickets += 1
                        PrintTicket(TotalTickets, est)
                    End If

                    RegisterButton.Enabled = True
                    'end printing function
                End If
            Catch ex As Exception

                'AutoModeStatusLbl.Text = "Problem accessing listen page, trying again... " & DateTime.Now.ToString
                ThreadInfoChanger(AutoModeStatusLbl, ex.Message)
            End Try
            ShowAsReady()

            Threading.Thread.Sleep(2000)
        Loop
    End Sub

    Private Sub CameraOpenBtn_Click(sender As Object, e As EventArgs) Handles CameraOpenBtn.Click
        CameraForm.ShowDialog()
    End Sub

    Private Sub ThreadInfoChanger(ByVal ctl As Control, ByVal e As String)
        If ctl.InvokeRequired Then
            ctl.BeginInvoke(New Action(Of Control, String)(AddressOf ThreadInfoChanger), ctl, e)
        Else
            ctl.Text = e
        End If
    End Sub

    Private Sub PrintLabelBtn_Click(sender As Object, e As EventArgs) Handles PrintLabelBtn.Click
        ShowAsBusy()
        MessageBox.Show("Make sure that label is protruding from printer a little and then press OK.", "RaffleRaffle", MessageBoxButtons.OK, MessageBoxIcon.Question)
        Dim P As New PrinterClass(Application.StartupPath)
        My.Settings.OmitCalibration = True
        With P
            'Printing Logo
            .RTL = False
            .SetFont()
            'Printing Title
            .FeedPaper(1)
            .AlignCenter()
            .Bold = True
            .BigFont()
            .WriteLine(NameTxt.Text)
            .Bold = False
            .NormalFont()
            .WriteLine(MediaTxt.Text)
            .WriteLine(OccupationTxt.Text)
            '.FeedPaper(1)


            .CutPaper() ' Can be used with real printer to cut the paper.

            'Ending the session
            .EndDoc()
        End With
        My.Settings.OmitCalibration = False
        NameTxt.Focus()
        ShowAsReady()
    End Sub

    Private Sub NameTxt_TextChanged(sender As Object, e As EventArgs) Handles NameTxt.TextChanged
        '     UpdateLabel()
    End Sub

    '  Sub UpdateLabel()
    ' Try
    '        NameLenLbl.Text = NameTxt.TextLength & " / " & My.Settings.PrinterCalibrate(5)
    '       MediaLenLbl.Text = MediaTxt.TextLength & " / " & My.Settings.PrinterCalibrate(2)
    '      OccuLenLbl.Text = OccupationTxt.TextLength & " / " & My.Settings.PrinterCalibrate(2)
    'Catch ex As Exception
    'End Try

    'End Sub

    Private Sub MediaTxt_TextChanged(sender As Object, e As EventArgs) Handles MediaTxt.TextChanged
        '    UpdateLabel()
    End Sub

    Private Sub OccupationTxt_TextChanged(sender As Object, e As EventArgs) Handles OccupationTxt.TextChanged
        '    UpdateLabel()
    End Sub

    Private Sub TicketsResetBtn_Click(sender As Object, e As EventArgs) Handles TicketsResetBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset the counter?", "RaffleRaffle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If result = DialogResult.Yes Then
            TotalTickets = 0
            My.Settings.CurrentTicket = TotalTickets
            My.Settings.Save()
            TotalTicketsLbl.Text = 0
        End If
    End Sub

    Private Sub AllAbilitiesPrintBtn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub CouponFormBtn_Click(sender As Object, e As EventArgs) Handles CouponFormBtn.Click
        CouponForm.ShowDialog()
    End Sub

    Private Sub RollServiceBtn_Click(sender As Object, e As EventArgs) Handles RollServiceBtn.Click
        ChangeRollForm.ShowDialog()
    End Sub

    Private Sub TextExBtn_Click(sender As Object, e As EventArgs) Handles TextExBtn.Click
        Throw New Exception("OOPSIE WOOPSIE!! Uwu We made a fucky wucky!! A wittle fucko boingo! The code monkeys at our headquarters are working VEWY HAWD to fix this!")
    End Sub

    Private Sub PickPrinterTxt_Click(sender As Object, e As EventArgs) Handles PickPrinterTxt.Click
        PrintDialog1.ShowDialog()
        PrinterNameTxt.Text = PrintDialog1.PrinterSettings.PrinterName
        My.Settings.PrinterName = PrinterNameTxt.Text
        My.Settings.Save()
    End Sub

    Public Sub Block()
        PrinterSettingsBox.Enabled = False
        EditorTab.Enabled = False
        LabelTab.Enabled = False
        ExtrasTab.Enabled = False
        LockBtn.Text = "🔒"
        LockLbl.Text = "Press Lock to unlock controls."
    End Sub

    Public Sub Unblock()
        PrinterSettingsBox.Enabled = True
        EditorTab.Enabled = True
        LabelTab.Enabled = True
        ExtrasTab.Enabled = True
        LockBtn.Text = "🔓"
        LockLbl.Text = "Press Lock to lock settings and additional features."
    End Sub

    Private Sub LockBtn_Click(sender As Object, e As EventArgs) Handles LockBtn.Click
        LockForm.ShowDialog()
    End Sub

    Private Sub AlwaysRaffleChk_CheckedChanged(sender As Object, e As EventArgs) Handles AlwaysRaffleChk.CheckedChanged
        My.Settings.AlwaysRaffle = AlwaysRaffleChk.Checked
    End Sub

    Private Sub PrefixChk_CheckedChanged(sender As Object, e As EventArgs) Handles PrefixChk.CheckedChanged
        My.Settings.PrintPrefix = PrefixChk.Checked
    End Sub

    Private Sub PrefixTxt_TextChanged(sender As Object, e As EventArgs) Handles PrefixTxt.TextChanged
        My.Settings.Prefix = PrefixTxt.Text
    End Sub

    Private Sub PrintLogoChk_CheckedChanged(sender As Object, e As EventArgs) Handles PrintLogoChk.CheckedChanged
        My.Settings.PrintLogo = PrintLogoChk.Checked
    End Sub

    Private Sub PickImageBtn_Click(sender As Object, e As EventArgs) Handles PickImageBtn.Click
#Disable Warning IDE0017 ' Simplify object initialization
        Dim open As New OpenFileDialog
#Enable Warning IDE0017 ' Simplify object initialization
        open.Title = "Select an image"
        open.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyPictures
        open.Filter = "Images|*.jpg;*.png;*.bmp"
        If open.ShowDialog() = DialogResult.OK Then
            LogoPathTxt.Text = open.FileName
        End If
    End Sub

    Public Sub PrintWheelCoupon(times As Integer)
        Dim P As New PrinterClass(Application.StartupPath)
        My.Settings.OmitCalibration = True
        For i = 1 To times Step 1
            With P
                .RTL = False
                'Raffle
                .DrawLine()
                .FeedPaper(1)
                .DrawLine()
                .HugeFont()
                .AlignCenter()
                If My.Settings.PrintLogo = True Then .PrintLogo()
                .Bold = True
                .WriteLine("*")
                .NormalFont()
                .Bold = False
                .AlignLeft()
                .WriteLine("Купон на одну попытку на")
                .WriteLine("колесе удачи")
                .FeedPaper(1)
                .CutPaper()
                .EndDoc()
            End With
        Next i

    End Sub

    Private Sub PrintWheelCouponBtn_Click(sender As Object, e As EventArgs) Handles PrintWheelCouponBtn.Click
        PrintWheelCoupon(PrinWheelTimesTxt.Text)
    End Sub
End Class



