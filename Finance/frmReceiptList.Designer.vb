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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        txtAchAmt = New DataGridViewTextBoxColumn()
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
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Teal
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgPaymentReceipt.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgPaymentReceipt.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentReceipt.Columns.AddRange(New DataGridViewColumn() {receiptNum, receiptDate, receiptCustAddr, receiptAmt, receiptAmtInWords, receiptVeichleNum, receiptLoanNum, receiptEmiDate, receiptEmiId, receiptEmiAmt, receiptTotal, txtAchAmt, receiptCollSign})
        dgPaymentReceipt.Dock = DockStyle.Bottom
        dgPaymentReceipt.Location = New Point(0, 676)
        dgPaymentReceipt.Name = "dgPaymentReceipt"
        dgPaymentReceipt.RowHeadersWidth = 51
        dgPaymentReceipt.RowTemplate.Height = 29
        dgPaymentReceipt.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgPaymentReceipt.Size = New Size(1316, 379)
        dgPaymentReceipt.TabIndex = 0
        ' 
        ' receiptNum
        ' 
        receiptNum.HeaderText = "Receipt Num."
        receiptNum.MinimumWidth = 6
        receiptNum.Name = "receiptNum"
        receiptNum.Width = 60
        ' 
        ' receiptDate
        ' 
        receiptDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptDate.HeaderText = "Receipt Date"
        receiptDate.MinimumWidth = 6
        receiptDate.Name = "receiptDate"
        receiptDate.Width = 117
        ' 
        ' receiptCustAddr
        ' 
        receiptCustAddr.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptCustAddr.HeaderText = "Customer Address"
        receiptCustAddr.MinimumWidth = 6
        receiptCustAddr.Name = "receiptCustAddr"
        receiptCustAddr.Width = 153
        ' 
        ' receiptAmt
        ' 
        receiptAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptAmt.HeaderText = "Amount"
        receiptAmt.MinimumWidth = 6
        receiptAmt.Name = "receiptAmt"
        receiptAmt.Width = 96
        ' 
        ' receiptAmtInWords
        ' 
        receiptAmtInWords.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptAmtInWords.HeaderText = "Amount In Words"
        receiptAmtInWords.MinimumWidth = 6
        receiptAmtInWords.Name = "receiptAmtInWords"
        receiptAmtInWords.Width = 109
        ' 
        ' receiptVeichleNum
        ' 
        receiptVeichleNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptVeichleNum.HeaderText = "Veichle Number"
        receiptVeichleNum.MinimumWidth = 6
        receiptVeichleNum.Name = "receiptVeichleNum"
        receiptVeichleNum.Width = 137
        ' 
        ' receiptLoanNum
        ' 
        receiptLoanNum.HeaderText = "Loan Number"
        receiptLoanNum.MinimumWidth = 6
        receiptLoanNum.Name = "receiptLoanNum"
        receiptLoanNum.Width = 60
        ' 
        ' receiptEmiDate
        ' 
        receiptEmiDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiDate.HeaderText = "Emi Date"
        receiptEmiDate.MinimumWidth = 6
        receiptEmiDate.Name = "receiptEmiDate"
        receiptEmiDate.Width = 93
        ' 
        ' receiptEmiId
        ' 
        receiptEmiId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiId.HeaderText = "Emi Id"
        receiptEmiId.MinimumWidth = 6
        receiptEmiId.Name = "receiptEmiId"
        receiptEmiId.Width = 64
        ' 
        ' receiptEmiAmt
        ' 
        receiptEmiAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptEmiAmt.HeaderText = "Emi Amount"
        receiptEmiAmt.MinimumWidth = 6
        receiptEmiAmt.Name = "receiptEmiAmt"
        receiptEmiAmt.Width = 116
        ' 
        ' receiptTotal
        ' 
        receiptTotal.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        receiptTotal.HeaderText = "Total"
        receiptTotal.MinimumWidth = 6
        receiptTotal.Name = "receiptTotal"
        receiptTotal.Width = 73
        ' 
        ' txtAchAmt
        ' 
        txtAchAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        txtAchAmt.HeaderText = "Ach Amt"
        txtAchAmt.MinimumWidth = 6
        txtAchAmt.Name = "txtAchAmt"
        txtAchAmt.Width = 92
        ' 
        ' receiptCollSign
        ' 
        receiptCollSign.HeaderText = "Collected By"
        receiptCollSign.MinimumWidth = 6
        receiptCollSign.Name = "receiptCollSign"
        receiptCollSign.Width = 50
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(871, 32)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(212, 27)
        txtSearch.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(871, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(50, 20)
        Label1.TabIndex = 2
        Label1.Text = "Filter:"
        ' 
        ' txtExport
        ' 
        txtExport.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        txtExport.ForeColor = Color.Teal
        txtExport.Location = New Point(1089, 30)
        txtExport.Name = "txtExport"
        txtExport.Size = New Size(115, 29)
        txtExport.TabIndex = 3
        txtExport.Text = "Export PDF"
        txtExport.UseVisualStyleBackColor = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.Teal
        btnPrint.Location = New Point(1210, 30)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(92, 29)
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
        Label2.ForeColor = Color.Red
        Label2.Location = New Point(871, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(403, 20)
        Label2.TabIndex = 5
        Label2.Text = "Note: 1. (Use , | ; for sub filter)  2. Click any row to view it's bill"
        ' 
        ' frmReceiptList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1316, 1055)
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
    Friend WithEvents Label2 As Label
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
    Friend WithEvents txtAchAmt As DataGridViewTextBoxColumn
    Friend WithEvents receiptCollSign As DataGridViewTextBoxColumn
End Class
