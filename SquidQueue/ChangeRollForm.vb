﻿Public Class ChangeRollForm
    Private Sub OKButton_Click(sender As Object, e As EventArgs) Handles OKButton.Click
        My.Settings.RollRemaining = (RollLengthTxt.Text * 1000) - 200
        My.Settings.RollTotal = (RollLengthTxt.Text * 1000)
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub NoTrackBtn_Click(sender As Object, e As EventArgs) Handles NoTrackBtn.Click
        My.Settings.RollRemaining = -1
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub ChangeRollForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DebugLbl.Text = "Debug stat (for nerds):" & My.Settings.RollRemaining
    End Sub
End Class