Imports Microsoft.VisualBasic
Imports System.IO

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
        Dim playme As String
        playme = Directory.GetCurrentDirectory & "\sounds\" & Form1.SoundList.SelectedItem
        If My.Settings.Sound <> Nothing Then
            If My.Settings.Sound = "Default" Then
                My.Computer.Audio.Play(My.Resources.train_station, AudioPlayMode.Background)
            Else
                Try
                    My.Computer.Audio.Play(playme, AudioPlayMode.Background)
                Catch
                    MessageBox.Show("Missing or not a valid .wav file. Please use PCM 16bit files.", "SquidQueue", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                End Try
            End If
        End If
        TicketLabel.Text = e
        BlinkCycle = 0
        BlinkTimer.Enabled = True
        If My.Settings.ScreenFlash Then
            Me.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            Label1.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            ClockLabel.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            CustomLabel.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            TicketLabel.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            QueueCountLbl.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
            EstimateResultLbl.BackColor = Color.FromArgb(255 - My.Settings.BackColor.R, 255 - My.Settings.BackColor.G, 255 - My.Settings.BackColor.B)
        End If
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