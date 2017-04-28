Public Class Screen
    Public BlinkCycle As Byte
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

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

        If TicketLabel.Visible = True Then
            TicketLabel.Visible = False
        Else
            TicketLabel.Visible = True
        End If
    End Sub
End Class