Public Class frmPaymentBill
    Private Sub frmPaymentBill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PrintPreviewControl1.Hide()
    End Sub

    Public Sub UpdateBillContent(dt As String, custName As String, rupees As String, rupeesInWords1 As String,
                                 rupeesInWords2 As String, billLoanNo As String, emiDt As String,
                                 emino As String, emitotno As String, billamt As String, billTot As String, veichleNo As String, ahcamt As String)
        lblBillDate.Text = dt
        lblCustName.Text = custName
        lblRupees.Text = billTot 'rupees
        lblInWords1.Text = rupeesInWords1
        lblInWords2.Text = rupeesInWords2
        lblBillLoanNo.Text = billLoanNo
        If CInt(emino) > 0 Then
            lblEmiDate.Text = emiDt
            lblBillEmiNo.Text = emino & "/" & emitotno
        Else
            lblEmiDate.Text = "NA"
            lblBillEmiNo.Text = "NA/" & emitotno
        End If

        'lblBilTotalEmiNos.Text = emitotno
        lblBillAmount.Text = billamt
        lblBillTotal.Text = billTot
        lblBillVeichleNo.Text = veichleNo
        lblAhcAmt.Text = ahcamt




    End Sub

    Public Sub UpdateBillContentStr(billNo As String, dt As String, custName As String, rupees As String, rupeesInWords1 As String,
                                 rupeesInWords2 As String, veichleNo As String, billLoanNo As String, emiDt As String,
                                 emiid As String, billamt As String, billTot As String, ahcamt As String)

        lblBillNo.Text = billNo
        lblBillDate.Text = dt
        lblCustName.Text = custName
        lblRupees.Text = billTot 'rupees
        lblInWords1.Text = rupeesInWords1
        lblInWords2.Text = rupeesInWords2
        lblBillLoanNo.Text = billLoanNo
        lblBillEmiNo.Text = emiid
        lblBillAmount.Text = billamt
        lblBillTotal.Text = billTot
        lblBillVeichleNo.Text = veichleNo
        lblEmiDate.Text = emiDt
        lblAhcAmt.Text = ahcamt



    End Sub

    Private Sub btnBillPrint_Click(sender As Object, e As EventArgs) Handles btnBillPrint.Click
        printBill()
    End Sub

    Dim memoryImage As Bitmap

    Private Sub printBill()
        'PrintPreviewControl1.Hide()
        Dim graphics As Graphics 'Graphics graphics = this.CreateGraphics();
        graphics = CreateGraphics()
        Dim s As Size 'Size s = this.Size;
        s = Me.Size
        s.Height = s.Height + 50
        s.Width = s.Width + 130
        memoryImage = New Bitmap(s.Width, s.Height, graphics)
        Dim memoryGraphics As Graphics    'Graphics memoryGraphics = graphics.FromImage(memoryImage);
        memoryGraphics = Graphics.FromImage(memoryImage)
        memoryGraphics.CopyFromScreen(Me.Location.X + 10, Me.Location.Y + 35, 0, 0, s)
        'graphics = memoryGraphics
        'UpdateBillDateAndTime();
        'PrintPreviewControl1.Document = PrintDocument1


        PrintDocument1.Print()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(memoryImage, 20, 0)
    End Sub

    Private Sub frmPaymentBill_Move(sender As Object, e As EventArgs) Handles MyBase.Move
        Me.Left = 0
        Me.Top = 30
    End Sub
End Class