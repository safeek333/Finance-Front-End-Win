Public Class frmPaymentBill
    Private Sub frmPaymentBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub UpdateBillContent(dt As String, custName As String, rupees As String, rupeesInWords1 As String,
                                 rupeesInWords2 As String, billLoanNo As String, emiDt As String,
                                 emino As String, emitotno As String, billamt As String, billTot As String)
        lblBillDate.Text = dt
        lblCustName.Text = custName
        lblRupees.Text = rupees
        lblInWords1.Text = rupeesInWords1
        lblInWords2.Text = rupeesInWords2
        lblBillLoanNo.Text = billLoanNo
        lblEmiDate.Text = emiDt
        lblBillEmiNo.Text = emino
        lblBilTotalEmiNos.Text = emitotno
        lblBillAmount.Text = billamt
        lblBillTotal.Text = billTot



    End Sub

End Class