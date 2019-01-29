Public Class ChangeRollForm

    Private Sub NoTrackBtn_Click(sender As Object, e As EventArgs) Handles NoTrackBtn.Click
        My.Settings.RollRemaining = -1
        My.Settings.Save()
        My.Settings.OmitCalibration = True
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            .DrawLine()
            .FeedPaper(1)
            .CutPaper()
            .EndDoc()
        End With
        My.Settings.OmitCalibration = False
        Me.Close()
    End Sub
End Class