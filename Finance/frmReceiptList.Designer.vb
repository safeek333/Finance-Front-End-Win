<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceiptList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        dgPaymentReceipt = New DataGridView()
        receiptNum = New DataGridViewTextBoxColumn()
        receiptDate = New DataGridViewTextBoxColumn()
        receiptCustAddr = New DataGridViewTextBoxColumn()
        receiptAmt = New DataGridViewTextBoxColumn()
        receiptAmtInWords = New DataGridViewTextBoxColumn()
        receiptVeichleNum = New DataGridViewTextBoxColumn()
        receiptLoanNum = New DataGridViewTextBoxColumn()
        receiptEmiDate = New DataGridViewTextBoxColumn()
        receiptEmiId = New DataGridViewTextBoxColumn()
        receiptEmiAmt = New DataGridViewTextBoxColumn()
        receiptTotal = New DataGridViewTextBoxColumn()
        receiptCollSign = New DataGridViewTextBoxColumn()
        txtSearch = New TextBox()
        Label1 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        txtExport = New Button()
        btnPrint = New Button()
        PrintDialog1 = New PrintDialog()
        Label2 = New Label()
        CType(dgPaymentReceipt, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPaymentReceipt
        ' 
        dgPaymentReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentReceipt.Columns.AddRange(New DataGridViewColumn() {receiptNum, receiptDate, receiptCustAddr, receiptAmt, receiptAmtInWords, receiptVeichleNum, receiptLoanNum, receiptEmiDate, receiptEmiId, receiptEmiAmt, receiptTotal, receiptCollSign})
        dgPaymentReceipt.Dock = DockStyle.Bottom
        dgPaymentReceipt.Location = New Point(0, 676)
        dgPaymentReceipt.Name = "dgPaymentReceipt"
        dgPaymentReceipt.RowHeadersWidth = 51
        dgPaymentReceipt.RowTemplate.Height = 29
        dgPaymentReceipt.Size = New Size(1139, 379)
        dgPaymentReceipt.TabIndex = 0
        ' 
        ' receiptNum
        ' 
        receiptNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptNum.HeaderText = "Receipt Num."
        receiptNum.MinimumWidth = 6
        receiptNum.Name = "receiptNum"
        receiptNum.Width = 117
        ' 
        ' receiptDate
        ' 
        receiptDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptDate.HeaderText = "Receipt Date"
        receiptDate.MinimumWidth = 6
        receiptDate.Name = "receiptDate"
        receiptDate.Width = 114
        ' 
        ' receiptCustAddr
        ' 
        receiptCustAddr.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptCustAddr.HeaderText = "Customer Address"
        receiptCustAddr.MinimumWidth = 6
        receiptCustAddr.Name = "receiptCustAddr"
        receiptCustAddr.Width = 145
        ' 
        ' receiptAmt
        ' 
        receiptAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptAmt.HeaderText = "Amount"
        receiptAmt.MinimumWidth = 6
        receiptAmt.Name = "receiptAmt"
        receiptAmt.Width = 91
        ' 
        ' receiptAmtInWords
        ' 
        receiptAmtInWords.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptAmtInWords.HeaderText = "Amount In Words"
        receiptAmtInWords.MinimumWidth = 6
        receiptAmtInWords.Name = "receiptAmtInWords"
        receiptAmtInWords.Width = 102
        ' 
        ' receiptVeichleNum
        ' 
        receiptVeichleNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptVeichleNum.HeaderText = "Veichle Number"
        receiptVeichleNum.MinimumWidth = 6
        receiptVeichleNum.Name = "receiptVeichleNum"
        receiptVeichleNum.Width = 131
        ' 
        ' receiptLoanNum
        ' 
        receiptLoanNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptLoanNum.HeaderText = "Loan Number"
        receiptLoanNum.MinimumWidth = 6
        receiptLoanNum.Name = "receiptLoanNum"
        receiptLoanNum.Width = 118
        ' 
        ' receiptEmiDate
        ' 
        receiptEmiDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiDate.HeaderText = "Emi Date"
        receiptEmiDate.MinimumWidth = 6
        receiptEmiDate.Name = "receiptEmiDate"
        receiptEmiDate.Width = 92
        ' 
        ' receiptEmiId
        ' 
        receiptEmiId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiId.HeaderText = "Emi Id"
        receiptEmiId.MinimumWidth = 6
        receiptEmiId.Name = "receiptEmiId"
        receiptEmiId.Width = 63
        ' 
        ' receiptEmiAmt
        ' 
        receiptEmiAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiAmt.HeaderText = "Emi Amount"
        receiptEmiAmt.MinimumWidth = 6
        receiptEmiAmt.Name = "receiptEmiAmt"
        receiptEmiAmt.Width = 110
        ' 
        ' receiptTotal
        ' 
        receiptTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptTotal.HeaderText = "Total"
        receiptTotal.MinimumWidth = 6
        receiptTotal.Name = "receiptTotal"
        receiptTotal.Width = 71
        ' 
        ' receiptCollSign
        ' 
        receiptCollSign.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptCollSign.HeaderText = "Collected By"
        receiptCollSign.MinimumWidth = 6
        receiptCollSign.Name = "receiptCollSign"
        receiptCollSign.Width = 111
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(56, 623)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(212, 27)
        txtSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(5, 626)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 20)
        Label1.TabIndex = 2
        Label1.Text = "Filter:"
        ' 
        ' txtExport
        ' 
        txtExport.Location = New Point(274, 621)
        txtExport.Name = "txtExport"
        txtExport.Size = New Size(212, 29)
        txtExport.TabIndex = 3
        txtExport.Text = "Export PDF"
        txtExport.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Location = New Point(492, 621)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(212, 29)
        btnPrint.TabIndex = 4
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point)
        Label2.Location = New Point(56, 653)
        Label2.Name = "Label2"
        Label2.Size = New Size(403, 20)
        Label2.TabIndex = 5
        Label2.Text = "Note: 1. (Use , | ; for sub filter)  2. Click any row to view it's bill"
        ' 
        ' frmReceiptList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1139, 1055)
        Controls.Add(Label2)
        Controls.Add(btnPrint)
        Controls.Add(txtExport)
        Controls.Add(Label1)
        Controls.Add(txtSearch)
        Controls.Add(dgPaymentReceipt)
        Name = "frmReceiptList"
        Text = "All Payment Receipts"
        WindowState = FormWindowState.Maximized
        CType(dgPaymentReceipt, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgPaymentReceipt As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents txtExport As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents receiptNum As DataGridViewTextBoxColumn
    Friend WithEvents receiptDate As DataGridViewTextBoxColumn
    Friend WithEvents receiptCustAddr As DataGridViewTextBoxColumn
    Friend WithEvents receiptAmt As DataGridViewTextBoxColumn
    Friend WithEvents receiptAmtInWords As DataGridViewTextBoxColumn
    Friend WithEvents receiptVeichleNum As DataGridViewTextBoxColumn
    Friend WithEvents receiptLoanNum As DataGridViewTextBoxColumn
    Friend WithEvents receiptEmiDate As DataGridViewTextBoxColumn
    Friend WithEvents receiptEmiId As DataGridViewTextBoxColumn
    Friend WithEvents receiptEmiAmt As DataGridViewTextBoxColumn
    Friend WithEvents receiptTotal As DataGridViewTextBoxColumn
    Friend WithEvents receiptCollSign As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
End Class
