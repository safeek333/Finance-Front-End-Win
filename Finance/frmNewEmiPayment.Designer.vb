<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewEmiPayment
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
        dtLoanStart = New DateTimePicker()
        lblLoanStartDate = New Label()
        cboLoanStatus = New ComboBox()
        lblLoanStatus = New Label()
        txtEmiMonths = New TextBox()
        lblEmiMonths = New Label()
        txtEmiAmount = New TextBox()
        lblEmiAmount = New Label()
        txtLoanAmt = New TextBox()
        lblLoanAmt = New Label()
        txtLoanNum = New TextBox()
        lblLoanNum = New Label()
        lblTitle = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        dtLoanClose = New DateTimePicker()
        lblLoanCloseDate = New Label()
        loadBasicDetail = New Button()
        GroupBox1 = New GroupBox()
        lblReceiptBookNum = New Label()
        txtReceiptBookNum = New TextBox()
        Label10 = New Label()
        txtTotalAmt = New TextBox()
        Label9 = New Label()
        txtAHCAmt = New TextBox()
        lblBillDoneBy = New Label()
        txtBillDoneBy = New TextBox()
        dtEmiDate = New DateTimePicker()
        Label7 = New Label()
        cboEmiId = New ComboBox()
        lblEmiId = New Label()
        txtAmtInWords = New TextBox()
        Label6 = New Label()
        cboPaymentType = New ComboBox()
        txtPaymentDesc = New TextBox()
        Label5 = New Label()
        Label1 = New Label()
        Button1 = New Button()
        txtEmiPaymentAmt = New TextBox()
        Label4 = New Label()
        dtEmiPaymentDate = New DateTimePicker()
        lblEmiPaymentDate = New Label()
        GroupBox2 = New GroupBox()
        Label8 = New Label()
        txtVeichleNum = New TextBox()
        btnLoanNumEdit = New Button()
        GroupBox3 = New GroupBox()
        txtCustAddr = New TextBox()
        Label3 = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        BackgroundWorker2 = New ComponentModel.BackgroundWorker()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtLoanStart
        ' 
        dtLoanStart.Enabled = False
        dtLoanStart.Location = New Point(9, 116)
        dtLoanStart.Name = "dtLoanStart"
        dtLoanStart.Size = New Size(162, 27)
        dtLoanStart.TabIndex = 94
        ' 
        ' lblLoanStartDate
        ' 
        lblLoanStartDate.AutoSize = True
        lblLoanStartDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanStartDate.Location = New Point(9, 93)
        lblLoanStartDate.Name = "lblLoanStartDate"
        lblLoanStartDate.Size = New Size(141, 20)
        lblLoanStartDate.TabIndex = 93
        lblLoanStartDate.Text = "Loan Start Date:"
        ' 
        ' cboLoanStatus
        ' 
        cboLoanStatus.Enabled = False
        cboLoanStatus.FormattingEnabled = True
        cboLoanStatus.Items.AddRange(New Object() {"Active Pending", "Active", "Pending Close", "Closed"})
        cboLoanStatus.Location = New Point(345, 116)
        cboLoanStatus.Name = "cboLoanStatus"
        cboLoanStatus.Size = New Size(162, 28)
        cboLoanStatus.TabIndex = 92
        ' 
        ' lblLoanStatus
        ' 
        lblLoanStatus.AutoSize = True
        lblLoanStatus.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanStatus.Location = New Point(345, 93)
        lblLoanStatus.Name = "lblLoanStatus"
        lblLoanStatus.Size = New Size(110, 20)
        lblLoanStatus.TabIndex = 91
        lblLoanStatus.Text = "Loan Status:"
        ' 
        ' txtEmiMonths
        ' 
        txtEmiMonths.Location = New Point(177, 55)
        txtEmiMonths.Name = "txtEmiMonths"
        txtEmiMonths.ReadOnly = True
        txtEmiMonths.Size = New Size(162, 27)
        txtEmiMonths.TabIndex = 90
        txtEmiMonths.Text = "10"
        ' 
        ' lblEmiMonths
        ' 
        lblEmiMonths.AutoSize = True
        lblEmiMonths.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiMonths.Location = New Point(177, 32)
        lblEmiMonths.Name = "lblEmiMonths"
        lblEmiMonths.Size = New Size(107, 20)
        lblEmiMonths.TabIndex = 89
        lblEmiMonths.Text = "EMI Months:"
        ' 
        ' txtEmiAmount
        ' 
        txtEmiAmount.Location = New Point(345, 55)
        txtEmiAmount.Name = "txtEmiAmount"
        txtEmiAmount.ReadOnly = True
        txtEmiAmount.Size = New Size(162, 27)
        txtEmiAmount.TabIndex = 88
        txtEmiAmount.Text = "0.0"
        ' 
        ' lblEmiAmount
        ' 
        lblEmiAmount.AutoSize = True
        lblEmiAmount.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiAmount.Location = New Point(345, 32)
        lblEmiAmount.Name = "lblEmiAmount"
        lblEmiAmount.Size = New Size(111, 20)
        lblEmiAmount.TabIndex = 87
        lblEmiAmount.Text = "EMI Amount:"
        ' 
        ' txtLoanAmt
        ' 
        txtLoanAmt.Location = New Point(8, 54)
        txtLoanAmt.Name = "txtLoanAmt"
        txtLoanAmt.ReadOnly = True
        txtLoanAmt.Size = New Size(162, 27)
        txtLoanAmt.TabIndex = 86
        txtLoanAmt.Text = "0.0"
        ' 
        ' lblLoanAmt
        ' 
        lblLoanAmt.AutoSize = True
        lblLoanAmt.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanAmt.Location = New Point(8, 31)
        lblLoanAmt.Name = "lblLoanAmt"
        lblLoanAmt.Size = New Size(121, 20)
        lblLoanAmt.TabIndex = 85
        lblLoanAmt.Text = "Loan Amount:"
        ' 
        ' txtLoanNum
        ' 
        txtLoanNum.Location = New Point(12, 80)
        txtLoanNum.Name = "txtLoanNum"
        txtLoanNum.Size = New Size(95, 27)
        txtLoanNum.TabIndex = 84
        ' 
        ' lblLoanNum
        ' 
        lblLoanNum.AutoSize = True
        lblLoanNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanNum.Location = New Point(12, 57)
        lblLoanNum.Name = "lblLoanNum"
        lblLoanNum.Size = New Size(124, 20)
        lblLoanNum.TabIndex = 83
        lblLoanNum.Text = "Loan Number:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(6, 9)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(471, 27)
        lblTitle.TabIndex = 82
        lblTitle.Text = "New EMI Payment/Discount/Charge Entry"
        ' 
        ' dtLoanClose
        ' 
        dtLoanClose.Enabled = False
        dtLoanClose.Location = New Point(177, 116)
        dtLoanClose.Name = "dtLoanClose"
        dtLoanClose.Size = New Size(162, 27)
        dtLoanClose.TabIndex = 96
        ' 
        ' lblLoanCloseDate
        ' 
        lblLoanCloseDate.AutoSize = True
        lblLoanCloseDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanCloseDate.Location = New Point(177, 94)
        lblLoanCloseDate.Name = "lblLoanCloseDate"
        lblLoanCloseDate.Size = New Size(148, 20)
        lblLoanCloseDate.TabIndex = 95
        lblLoanCloseDate.Text = "Loan Close Date:"
        ' 
        ' loadBasicDetail
        ' 
        loadBasicDetail.Location = New Point(12, 113)
        loadBasicDetail.Name = "loadBasicDetail"
        loadBasicDetail.Size = New Size(150, 50)
        loadBasicDetail.TabIndex = 97
        loadBasicDetail.Text = "Load Basic Details"
        loadBasicDetail.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lblReceiptBookNum)
        GroupBox1.Controls.Add(txtReceiptBookNum)
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(txtTotalAmt)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(txtAHCAmt)
        GroupBox1.Controls.Add(lblBillDoneBy)
        GroupBox1.Controls.Add(txtBillDoneBy)
        GroupBox1.Controls.Add(dtEmiDate)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(cboEmiId)
        GroupBox1.Controls.Add(lblEmiId)
        GroupBox1.Controls.Add(txtAmtInWords)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(cboPaymentType)
        GroupBox1.Controls.Add(txtPaymentDesc)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(txtEmiPaymentAmt)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(dtEmiPaymentDate)
        GroupBox1.Controls.Add(lblEmiPaymentDate)
        GroupBox1.Location = New Point(12, 344)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(682, 336)
        GroupBox1.TabIndex = 98
        GroupBox1.TabStop = False
        GroupBox1.Text = "Payment Entry"
        ' 
        ' lblReceiptBookNum
        ' 
        lblReceiptBookNum.AutoSize = True
        lblReceiptBookNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblReceiptBookNum.Location = New Point(513, 94)
        lblReceiptBookNum.Name = "lblReceiptBookNum"
        lblReceiptBookNum.Size = New Size(151, 20)
        lblReceiptBookNum.TabIndex = 119
        lblReceiptBookNum.Text = "Book Receipt No."
        ' 
        ' txtReceiptBookNum
        ' 
        txtReceiptBookNum.Location = New Point(513, 117)
        txtReceiptBookNum.Name = "txtReceiptBookNum"
        txtReceiptBookNum.Size = New Size(156, 27)
        txtReceiptBookNum.TabIndex = 120
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label10.Location = New Point(337, 94)
        Label10.Name = "Label10"
        Label10.Size = New Size(93, 20)
        Label10.TabIndex = 117
        Label10.Text = "Total Amt:"
        ' 
        ' txtTotalAmt
        ' 
        txtTotalAmt.Location = New Point(337, 117)
        txtTotalAmt.Name = "txtTotalAmt"
        txtTotalAmt.ReadOnly = True
        txtTotalAmt.Size = New Size(156, 27)
        txtTotalAmt.TabIndex = 118
        txtTotalAmt.Text = "0.0"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label9.Location = New Point(174, 94)
        Label9.Name = "Label9"
        Label9.Size = New Size(164, 20)
        Label9.TabIndex = 115
        Label9.Text = "AHC Payment Amt:"
        ' 
        ' txtAHCAmt
        ' 
        txtAHCAmt.Location = New Point(174, 117)
        txtAHCAmt.Name = "txtAHCAmt"
        txtAHCAmt.Size = New Size(156, 27)
        txtAHCAmt.TabIndex = 116
        txtAHCAmt.Text = "0.0"
        ' 
        ' lblBillDoneBy
        ' 
        lblBillDoneBy.AutoSize = True
        lblBillDoneBy.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblBillDoneBy.Location = New Point(510, 263)
        lblBillDoneBy.Name = "lblBillDoneBy"
        lblBillDoneBy.Size = New Size(113, 20)
        lblBillDoneBy.TabIndex = 99
        lblBillDoneBy.Text = "Bill Done By:"
        ' 
        ' txtBillDoneBy
        ' 
        txtBillDoneBy.Location = New Point(510, 286)
        txtBillDoneBy.Name = "txtBillDoneBy"
        txtBillDoneBy.ReadOnly = True
        txtBillDoneBy.Size = New Size(149, 27)
        txtBillDoneBy.TabIndex = 100
        txtBillDoneBy.Text = "Root"
        ' 
        ' dtEmiDate
        ' 
        dtEmiDate.Location = New Point(340, 58)
        dtEmiDate.Name = "dtEmiDate"
        dtEmiDate.Size = New Size(162, 27)
        dtEmiDate.TabIndex = 114
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(340, 35)
        Label7.Name = "Label7"
        Label7.Size = New Size(88, 20)
        Label7.TabIndex = 113
        Label7.Text = "Emi Date:"
        ' 
        ' cboEmiId
        ' 
        cboEmiId.FormattingEnabled = True
        cboEmiId.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        cboEmiId.Location = New Point(173, 57)
        cboEmiId.Name = "cboEmiId"
        cboEmiId.Size = New Size(161, 28)
        cboEmiId.TabIndex = 112
        ' 
        ' lblEmiId
        ' 
        lblEmiId.AutoSize = True
        lblEmiId.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiId.Location = New Point(173, 34)
        lblEmiId.Name = "lblEmiId"
        lblEmiId.Size = New Size(108, 20)
        lblEmiId.TabIndex = 111
        lblEmiId.Text = "Loan EMI Id:"
        ' 
        ' txtAmtInWords
        ' 
        txtAmtInWords.Location = New Point(9, 171)
        txtAmtInWords.Multiline = True
        txtAmtInWords.Name = "txtAmtInWords"
        txtAmtInWords.ReadOnly = True
        txtAmtInWords.Size = New Size(492, 50)
        txtAmtInWords.TabIndex = 110
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(9, 148)
        Label6.Name = "Label6"
        Label6.Size = New Size(199, 20)
        Label6.TabIndex = 109
        Label6.Text = "Total Amount In Words:"
        ' 
        ' cboPaymentType
        ' 
        cboPaymentType.FormattingEnabled = True
        cboPaymentType.Items.AddRange(New Object() {"CUST PAY IN", "CUST PAY OUT", "CUST DISCOUNT", "CUST CHARGE", ""})
        cboPaymentType.Location = New Point(6, 58)
        cboPaymentType.Name = "cboPaymentType"
        cboPaymentType.Size = New Size(161, 28)
        cboPaymentType.TabIndex = 98
        ' 
        ' txtPaymentDesc
        ' 
        txtPaymentDesc.Location = New Point(6, 260)
        txtPaymentDesc.Multiline = True
        txtPaymentDesc.Name = "txtPaymentDesc"
        txtPaymentDesc.Size = New Size(495, 64)
        txtPaymentDesc.TabIndex = 108
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(6, 35)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 20)
        Label5.TabIndex = 97
        Label5.Text = "Payment Type:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(12, 94)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 20)
        Label1.TabIndex = 97
        Label1.Text = "EMI Payment Amt:"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(510, 171)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 50)
        Button1.TabIndex = 100
        Button1.Text = "Make Payment Entry"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' txtEmiPaymentAmt
        ' 
        txtEmiPaymentAmt.Location = New Point(12, 117)
        txtEmiPaymentAmt.Name = "txtEmiPaymentAmt"
        txtEmiPaymentAmt.Size = New Size(156, 27)
        txtEmiPaymentAmt.TabIndex = 98
        txtEmiPaymentAmt.Text = "0.0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(9, 237)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 20)
        Label4.TabIndex = 107
        Label4.Text = "Payment Description:"
        ' 
        ' dtEmiPaymentDate
        ' 
        dtEmiPaymentDate.Location = New Point(513, 58)
        dtEmiPaymentDate.Name = "dtEmiPaymentDate"
        dtEmiPaymentDate.Size = New Size(162, 27)
        dtEmiPaymentDate.TabIndex = 98
        ' 
        ' lblEmiPaymentDate
        ' 
        lblEmiPaymentDate.AutoSize = True
        lblEmiPaymentDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiPaymentDate.Location = New Point(513, 35)
        lblEmiPaymentDate.Name = "lblEmiPaymentDate"
        lblEmiPaymentDate.Size = New Size(163, 20)
        lblEmiPaymentDate.TabIndex = 97
        lblEmiPaymentDate.Text = "Emi Payment Date:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(Label8)
        GroupBox2.Controls.Add(txtVeichleNum)
        GroupBox2.Controls.Add(dtLoanClose)
        GroupBox2.Controls.Add(lblLoanAmt)
        GroupBox2.Controls.Add(txtLoanAmt)
        GroupBox2.Controls.Add(lblEmiAmount)
        GroupBox2.Controls.Add(lblLoanCloseDate)
        GroupBox2.Controls.Add(txtEmiAmount)
        GroupBox2.Controls.Add(dtLoanStart)
        GroupBox2.Controls.Add(lblEmiMonths)
        GroupBox2.Controls.Add(lblLoanStartDate)
        GroupBox2.Controls.Add(txtEmiMonths)
        GroupBox2.Controls.Add(cboLoanStatus)
        GroupBox2.Controls.Add(lblLoanStatus)
        GroupBox2.Location = New Point(9, 182)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(685, 156)
        GroupBox2.TabIndex = 99
        GroupBox2.TabStop = False
        GroupBox2.Text = "Loan Basic Details"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(513, 32)
        Label8.Name = "Label8"
        Label8.Size = New Size(103, 20)
        Label8.TabIndex = 97
        Label8.Text = "Veichle No:"
        ' 
        ' txtVeichleNum
        ' 
        txtVeichleNum.Location = New Point(513, 55)
        txtVeichleNum.Name = "txtVeichleNum"
        txtVeichleNum.ReadOnly = True
        txtVeichleNum.Size = New Size(162, 27)
        txtVeichleNum.TabIndex = 98
        txtVeichleNum.Text = "NA"
        ' 
        ' btnLoanNumEdit
        ' 
        btnLoanNumEdit.Location = New Point(109, 80)
        btnLoanNumEdit.Name = "btnLoanNumEdit"
        btnLoanNumEdit.Size = New Size(53, 27)
        btnLoanNumEdit.TabIndex = 101
        btnLoanNumEdit.Text = "Edit"
        btnLoanNumEdit.UseVisualStyleBackColor = True
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(txtCustAddr)
        GroupBox3.Controls.Add(Label3)
        GroupBox3.Controls.Add(TextBox1)
        GroupBox3.Controls.Add(Label2)
        GroupBox3.Location = New Point(185, 39)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(509, 124)
        GroupBox3.TabIndex = 102
        GroupBox3.TabStop = False
        GroupBox3.Text = "Customer Basic Details"
        ' 
        ' txtCustAddr
        ' 
        txtCustAddr.Location = New Point(101, 55)
        txtCustAddr.Multiline = True
        txtCustAddr.Name = "txtCustAddr"
        txtCustAddr.ReadOnly = True
        txtCustAddr.Size = New Size(396, 54)
        txtCustAddr.TabIndex = 106
        txtCustAddr.Text = "NA"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(104, 32)
        Label3.Name = "Label3"
        Label3.Size = New Size(256, 20)
        Label3.TabIndex = 105
        Label3.Text = "Customer Name And Address:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(6, 55)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(89, 27)
        TextBox1.TabIndex = 104
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(6, 32)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 103
        Label2.Text = "Cust Id:"
        ' 
        ' frmNewEmiPayment
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 699)
        Controls.Add(GroupBox3)
        Controls.Add(btnLoanNumEdit)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(loadBasicDetail)
        Controls.Add(txtLoanNum)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
        Location = New Point(30, 600)
        Name = "frmNewEmiPayment"
        Text = "New EMI Payment/Discount/Charge Entry"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtLoanStart As DateTimePicker
    Friend WithEvents lblLoanStartDate As Label
    Friend WithEvents cboLoanStatus As ComboBox
    Friend WithEvents lblLoanStatus As Label
    Friend WithEvents txtEmiMonths As TextBox
    Friend WithEvents lblEmiMonths As Label
    Friend WithEvents txtEmiAmount As TextBox
    Friend WithEvents lblEmiAmount As Label
    Friend WithEvents txtLoanAmt As TextBox
    Friend WithEvents lblLoanAmt As Label
    Friend WithEvents txtLoanNum As TextBox
    Friend WithEvents lblLoanNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents dtLoanClose As DateTimePicker
    Friend WithEvents lblLoanCloseDate As Label
    Friend WithEvents loadBasicDetail As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmiPaymentAmt As TextBox
    Friend WithEvents dtEmiPaymentDate As DateTimePicker
    Friend WithEvents lblEmiPaymentDate As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnLoanNumEdit As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtCustAddr As TextBox
    Friend WithEvents cboPaymentType As ComboBox
    Friend WithEvents txtPaymentDesc As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAmtInWords As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboEmiId As ComboBox
    Friend WithEvents lblEmiId As Label
    Friend WithEvents dtEmiDate As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtVeichleNum As TextBox
    Friend WithEvents lblBillDoneBy As Label
    Friend WithEvents txtBillDoneBy As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtAHCAmt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtTotalAmt As TextBox
    Friend WithEvents lblReceiptBookNum As Label
    Friend WithEvents txtReceiptBookNum As TextBox
End Class
