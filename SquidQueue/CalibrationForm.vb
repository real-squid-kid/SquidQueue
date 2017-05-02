Public Class CalibrationForm
    Private Sub CalibrationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RegularHugeTxt.Text = My.Settings.PrinterCalibrate(0)
        RegularBigTxt.Text = My.Settings.PrinterCalibrate(1)
        RegularNormalTxt.Text = My.Settings.PrinterCalibrate(2)
        RegularSmallTxt.Text = My.Settings.PrinterCalibrate(3)
        BoldHugeTXT.Text = My.Settings.PrinterCalibrate(4)
        BoldBigTxt.Text = My.Settings.PrinterCalibrate(5)
        BoldNormalTxt.Text = My.Settings.PrinterCalibrate(6)
        BoldSmallTxt.Text = My.Settings.PrinterCalibrate(7)
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        My.Settings.PrinterCalibrate(0) = RegularHugeTxt.Text
        My.Settings.PrinterCalibrate(1) = RegularBigTxt.Text
        My.Settings.PrinterCalibrate(2) = RegularNormalTxt.Text
        My.Settings.PrinterCalibrate(3) = RegularSmallTxt.Text
        My.Settings.PrinterCalibrate(4) = BoldHugeTXT.Text
        My.Settings.PrinterCalibrate(5) = BoldBigTxt.Text
        My.Settings.PrinterCalibrate(6) = BoldNormalTxt.Text
        My.Settings.PrinterCalibrate(7) = BoldSmallTxt.Text
        Me.Close()
    End Sub

    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub
End Class