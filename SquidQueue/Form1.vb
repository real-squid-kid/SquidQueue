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
        Screen.CustomLabel.Text = CustomLabel.Text
    End Sub

    Private Sub RegisterButton_Click(sender As Object, e As EventArgs) Handles RegisterButton.Click
        TotalTickets = TotalTickets + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TotalTickets = 0
        CurrentTicket = 0
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
            ServeButton.Enabled = False
            Exit Sub
        End If

    End Sub
End Class
