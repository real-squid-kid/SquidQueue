Public Class LockForm
    Private Sub LockForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ""
        If Form1.Blocked = True Then
            Me.Text = "Unlock..."
            Label1.Text = "Enter password to unlock:"
            TextBox1.UseSystemPasswordChar = True
        Else
            Me.Text = "Lock..."
            Label1.Text = "Enter password to lock:"
            TextBox1.UseSystemPasswordChar = False
        End If
        Me.AcceptButton = Button1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Press()
    End Sub

    Private Sub Press()
        If Form1.Blocked = True Then
            If TextBox1.Text = Form1.CurrentPassword Then
                Form1.Unblock()
                Form1.Blocked = False
                Me.Close()
            Else
                TextBox1.SelectAll()
                Label1.Text = "Wrong password."
            End If
        Else
            Form1.CurrentPassword = TextBox1.Text
            Form1.Block()
            Form1.Blocked = True
            Me.Close()
        End If
    End Sub
End Class