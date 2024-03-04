Public Class frmEditLoanRecepts
    Private Sub btnGetLoanDetails_Click(sender As Object, e As EventArgs) Handles btnGetLoanDetails.Click
        If IsNumeric(txtLoanNum.Text) Then
            Try
                frmReceiptList.OpenAllPenalityList(CLng(txtLoanNum.Text))
            Catch ex As Exception
                MsgBox("Invlid Loan Number")
            End Try
        Else
            MsgBox("Invlid Loan Number")
        End If

    End Sub
End Class