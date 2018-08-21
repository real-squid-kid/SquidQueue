Public Class CrashForm
    Public ex As Exception
    Private Sub CrashForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ex.ToString
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class