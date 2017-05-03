Imports Microsoft.VisualBasic

Public Class Screen
    Public BlinkCycle As Byte
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub Brand()
        Try
            ClockLabel.Font = New Font(My.Settings.ScreenFont, 48, FontStyle.Bold)
            CustomLabel.Font = New Font(My.Settings.ScreenFont, 48, FontStyle.Bold)
            QueueCountLbl.Font = New Font(My.Settings.ScreenFont, 24, FontStyle.Bold)
            TicketLabel.Font = New Font(My.Settings.ScreenFont, 250, FontStyle.Bold)
            EstimateResultLbl.Font = New Font(My.Settings.ScreenFont, 24, FontStyle.Bold)
            TicketLabel.ForeColor = My.Settings.ScreenFontColor
            ClockLabel.ForeColor = My.Settings.ScreenFontColor
            CustomLabel.ForeColor = My.Settings.ScreenFontColor
            QueueCountLbl.ForeColor = My.Settings.ScreenFontColor
            EstimateResultLbl.ForeColor = My.Settings.ScreenFontColor
        Catch

            My.Settings.ScreenFont = "Century Gothic"
            My.Settings.ScreenFontColor = Color.White
            Brand()
        End Try
    End Sub

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    Label1.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    Label1.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    Label1.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub

    Private Sub ClockTimer_Tick(sender As Object, e As EventArgs) Handles ClockTimer.Tick
        ClockLabel.Text = DateTime.Now.ToString("HH:mm:ss")
    End Sub

    Public Sub CallOut(e As Long)
        My.Computer.Audio.Play(My.Resources.train_station, AudioPlayMode.Background)
        TicketLabel.Text = e
        BlinkCycle = 0
        BlinkTimer.Enabled = True
    End Sub

    Private Sub BlinkTimer_Tick(sender As Object, e As EventArgs) Handles BlinkTimer.Tick
        BlinkCycle = BlinkCycle + 1
        If TicketLabel.Visible = True Then
            TicketLabel.Visible = False
        Else
            TicketLabel.Visible = True
        End If
        If BlinkCycle = 10 Then
            BlinkTimer.Enabled = False
            TicketLabel.Visible = True
        End If
    End Sub

    Private Sub Screen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Brand()
    End Sub

    Private Sub SyncPing_Tick(sender As Object, e As EventArgs) Handles SyncPing.Tick
        Me.BackColor = My.Settings.BackColor
        Label1.BackColor = My.Settings.BackColor
        ClockLabel.BackColor = My.Settings.BackColor
        CustomLabel.BackColor = My.Settings.BackColor
        TicketLabel.BackColor = My.Settings.BackColor
        QueueCountLbl.BackColor = My.Settings.BackColor
        EstimateResultLbl.BackColor = My.Settings.BackColor
        ClockLabel.Left = Me.Width - Me.Width / 20 - ClockLabel.Width
        CustomLabel.Left = Me.Width - Me.Width / 2 - CustomLabel.Width / 2
        CustomLabel.Top = Me.Height / 5
        TicketLabel.Left = Me.Width - Me.Width / 2 - TicketLabel.Width / 2
        TicketLabel.Top = Me.Height / 3
        QueueCountLbl.Left = Me.Width / 20
        QueueCountLbl.Top = Me.Height - Me.Height / 10
        EstimateResultLbl.Top = Me.Height - Me.Height / 10
        EstimateResultLbl.Left = Me.Width / 2
        QueueCountLbl.Text = "Людей в очереди - " & Form1.QueueCount
        QueueCountLbl.Visible = Form1.QueueCountChk.Checked
        EstimateResultLbl.Visible = Form1.ScreenEstimatedChk.Checked
        If Form1.OverrideChk.Checked Then
            EstimateResultLbl.Text = "Время между людьми - " & Form1.OverrideLbl.Text & " мин."
        Else
            EstimateResultLbl.Text = "Время между людьми - " & Form1.ToMins(Form1.EstimateResult) & " мин."
        End If
    End Sub

    Private Sub Screen_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub
End Class