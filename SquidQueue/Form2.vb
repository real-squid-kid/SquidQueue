﻿Public Class Form2
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click, Label5.Click
        Process.Start("https://github.com/real-squid-kid/SquidQueue")
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        RunForm.Show()
    End Sub

End Class