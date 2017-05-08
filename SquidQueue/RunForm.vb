Imports Microsoft.VisualBasic
Imports System.IO
Public Class RunForm
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        My.Computer.Audio.Stop()
        Me.Close()
    End Sub

    Private Sub RunForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.run1, AudioPlayMode.background)
    End Sub
End Class