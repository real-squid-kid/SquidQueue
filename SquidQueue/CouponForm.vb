Public Class CouponForm
    Private Sub CancelBtn_Click(sender As Object, e As EventArgs) Handles CancelBtn.Click
        Me.Close()
    End Sub

    Private Sub OKBtn_Click(sender As Object, e As EventArgs) Handles OKBtn.Click
        If PrizeTxt.Text = "" Or ClaimTxt.Text = "" Then
            MessageBox.Show("Please fill out both fields.", "RaffleRaffle", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        PrintCoupon(PrizeTxt.Text, ClaimTxt.Text)
        Me.Close()
    End Sub

    Public Sub PrintCoupon(prize As String, claim As String)
        Dim P As New PrinterClass(Application.StartupPath)
        With P
            'Printing Logo
            .RTL = False
            .SetFont()
            'Printing Title
            .FeedPaper(4)
            .AlignLeft()
            .BigFont()
            .Bold = True
            .WriteLine(My.Settings.SlipTitle)

            'Printing Date
            .Bold = False
            .GotoSixth(1)
            .NormalFont()
            .AlignLeft()
            If My.Settings.PrintDateAndTime Then .WriteLine(DateTime.Now.ToString)
            .DrawLine()
            .FeedPaper(1)
            .AlignLeft()
            .NormalFont()
            .WriteLine("Купон для получения следующего приза")
            .Bold = True
            .NormalFont()
            .AlignCenter()
            .FeedPaper(1)
            .WriteLine(prize)
            .FeedPaper(1)
            .Bold = False
            .AlignLeft()
            .SmallFont()
            .WriteLine("Купон погашается или изымается после выдачи приза.")
            .NormalFont()
            .WriteLine("Номер заявки:")
            .Bold = True
            .BigFont()
            .WriteLine(claim)
            'Additional
            .FeedPaper(2)
            .CutPaper()
            .EndDoc()
        End With
    End Sub
End Class