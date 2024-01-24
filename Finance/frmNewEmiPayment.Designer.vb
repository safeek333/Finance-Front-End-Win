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
        cboPaymentType = New ComboBox()
        txtPaymentDesc = New TextBox()
        Label5 = New Label()
        Button1 = New Button()
        Label4 = New Label()
        Label1 = New Label()
        txtEmiPaymentAmt = New TextBox()
        dtEmiPaymentDate = New DateTimePicker()
        lblEmiPaymentDate = New Label()
        GroupBox2 = New GroupBox()
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
        loadBasicDetail.Location = New Point(169, 57)
        loadBasicDetail.Name = "loadBasicDetail"
        loadBasicDetail.Size = New Size(342, 50)
        loadBasicDetail.TabIndex = 97
        loadBasicDetail.Text = "Load Basic Details"
        loadBasicDetail.UseVisualStyleBackColor = True
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cboPaymentType)
        GroupBox1.Controls.Add(txtPaymentDesc)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Button1)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtEmiPaymentAmt)
        GroupBox1.Controls.Add(dtEmiPaymentDate)
        GroupBox1.Controls.Add(lblEmiPaymentDate)
        GroupBox1.Location = New Point(12, 419)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(507, 187)
        GroupBox1.TabIndex = 98
        GroupBox1.TabStop = False
        GroupBox1.Text = "Payment Entry"
        ' 
        ' cboPaymentType
        ' 
        cboPaymentType.FormattingEnabled = True
        cboPaymentType.Items.AddRange(New Object() {"CUST PAY IN", "CUST PAY OUT", "CUST DISCOUNT", "CUST CHARGE", ""})
        cboPaymentType.Location = New Point(346, 52)
        cboPaymentType.Name = "cboPaymentType"
        cboPaymentType.Size = New Size(161, 28)
        cboPaymentType.TabIndex = 98
        ' 
        ' txtPaymentDesc
        ' 
        txtPaymentDesc.Location = New Point(6, 118)
        txtPaymentDesc.Multiline = True
        txtPaymentDesc.Name = "txtPaymentDesc"
        txtPaymentDesc.Size = New Size(334, 61)
        txtPaymentDesc.TabIndex = 108
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(346, 29)
        Label5.Name = "Label5"
        Label5.Size = New Size(130, 20)
        Label5.TabIndex = 97
        Label5.Text = "Payment Type:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(354, 118)
        Button1.Name = "Button1"
        Button1.Size = New Size(153, 61)
        Button1.TabIndex = 100
        Button1.Text = "Make Payment Entry"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(9, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(185, 20)
        Label4.TabIndex = 107
        Label4.Text = "Payment Description:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(178, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 20)
        Label1.TabIndex = 97
        Label1.Text = "EMI Payment Amt:"
        ' 
        ' txtEmiPaymentAmt
        ' 
        txtEmiPaymentAmt.Location = New Point(178, 52)
        txtEmiPaymentAmt.Name = "txtEmiPaymentAmt"
        txtEmiPaymentAmt.Size = New Size(162, 27)
        txtEmiPaymentAmt.TabIndex = 98
        txtEmiPaymentAmt.Text = "0.0"
        ' 
        ' dtEmiPaymentDate
        ' 
        dtEmiPaymentDate.Location = New Point(9, 52)
        dtEmiPaymentDate.Name = "dtEmiPaymentDate"
        dtEmiPaymentDate.Size = New Size(162, 27)
        dtEmiPaymentDate.TabIndex = 98
        ' 
        ' lblEmiPaymentDate
        ' 
        lblEmiPaymentDate.AutoSize = True
        lblEmiPaymentDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiPaymentDate.Location = New Point(9, 29)
        lblEmiPaymentDate.Name = "lblEmiPaymentDate"
        lblEmiPaymentDate.Size = New Size(163, 20)
        lblEmiPaymentDate.TabIndex = 97
        lblEmiPaymentDate.Text = "Emi Payment Date:"
        ' 
        ' GroupBox2
        ' 
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
        GroupBox2.Location = New Point(12, 254)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(507, 159)
        GroupBox2.TabIndex = 99
        GroupBox2.TabStop = False
        GroupBox2.Text = "Loan Basic Details"
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
        GroupBox3.Location = New Point(12, 132)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(507, 116)
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
        txtCustAddr.Size = New Size(406, 55)
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
        ClientSize = New Size(540, 611)
        Controls.Add(GroupBox3)
        Controls.Add(btnLoanNumEdit)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Controls.Add(loadBasicDetail)
        Controls.Add(txtLoanNum)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
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
End Class
