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
        RegisterButton.Enabled = True
        ReEnableTimer.Enabled = True
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub BrandedCheck_Click(sender As Object, e As EventArgs) Handles BrandedCheck.Click
        '        Screen.Brand()
    End Sub

    Private Sub GenericCheck_Click(sender As Object, e As EventArgs) Handles GenericCheck.Click
        '        Screen.Debrand()
    End Sub

    Private Sub ColorPickerBtn_Click(sender As Object, e As EventArgs) Handles ColorPickerBtn.Click
        Dim cDialog As New ColorDialog()
        cDialog.Color = Color.White ' initial selection is current color.

        If (cDialog.ShowDialog() = DialogResult.OK) Then
            Screen.Brand(cDialog.Color) ' update with user selected color.
        End If
    End Sub
End Class
