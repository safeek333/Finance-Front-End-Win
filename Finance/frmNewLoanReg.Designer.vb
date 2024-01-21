<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNewLoanReg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnReset = New Button()
        btnSave = New Button()
        txtInsDetails = New TextBox()
        lblInsDetails = New Label()
        txtAFC = New TextBox()
        lblAFC = New Label()
        txtVeichleType = New TextBox()
        lblVeichleType = New Label()
        txtEmiMonths = New TextBox()
        lblEmiMonths = New Label()
        txtEmiAmount = New TextBox()
        lblEmiAmount = New Label()
        txtDocCharge = New TextBox()
        lblDocCharge = New Label()
        txtLoanAmt = New TextBox()
        lblLoanAmt = New Label()
        txtGarandorAddr = New TextBox()
        lblGarantorAddr = New Label()
        txtCustAddr = New TextBox()
        lblCustAddr = New Label()
        txtVeichleNum = New TextBox()
        lblVeichleNum = New Label()
        txtLoanNum = New TextBox()
        lblLoanNum = New Label()
        lblTitle = New Label()
        BindingSource1 = New BindingSource(components)
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        txtPrincipleAmt = New TextBox()
        lblPrincipleAmt = New Label()
        lblLoanStatus = New Label()
        cboLoanStatus = New ComboBox()
        lblLoanStartDate = New Label()
        lblLoanCloseDate = New Label()
        dtLoanStart = New DateTimePicker()
        dtLoanClose = New DateTimePicker()
        txtLoanIntrestPercent = New TextBox()
        lblLoanIntrestPercent = New Label()
        txtDocumentPercent = New TextBox()
        lblDocumentChargePercent = New Label()
        txtCustId = New TextBox()
        Label1 = New Label()
        btnEditDocCharge = New Button()
        lblLoanIntPerMonth = New Label()
        btnNewCust = New Button()
        btnLoadCustAddr = New Button()
        btnEditAFC = New Button()
        CType(BindingSource1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(362, 516)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(126, 34)
        btnReset.TabIndex = 74
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(211, 516)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(126, 34)
        btnSave.TabIndex = 73
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtInsDetails
        ' 
        txtInsDetails.Location = New Point(12, 397)
        txtInsDetails.Multiline = True
        txtInsDetails.Name = "txtInsDetails"
        txtInsDetails.Size = New Size(322, 93)
        txtInsDetails.TabIndex = 72
        txtInsDetails.Text = "NA"
        ' 
        ' lblInsDetails
        ' 
        lblInsDetails.AutoSize = True
        lblInsDetails.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblInsDetails.Location = New Point(12, 374)
        lblInsDetails.Name = "lblInsDetails"
        lblInsDetails.Size = New Size(157, 20)
        lblInsDetails.TabIndex = 71
        lblInsDetails.Text = "Insurance Details:"
        ' 
        ' txtAFC
        ' 
        txtAFC.Location = New Point(543, 331)
        txtAFC.Name = "txtAFC"
        txtAFC.ReadOnly = True
        txtAFC.Size = New Size(106, 27)
        txtAFC.TabIndex = 70
        txtAFC.Text = "0.0"
        ' 
        ' lblAFC
        ' 
        lblAFC.AutoSize = True
        lblAFC.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblAFC.Location = New Point(543, 310)
        lblAFC.Name = "lblAFC"
        lblAFC.Size = New Size(49, 20)
        lblAFC.TabIndex = 69
        lblAFC.Text = "AFC:"
        ' 
        ' txtVeichleType
        ' 
        txtVeichleType.Location = New Point(12, 331)
        txtVeichleType.Name = "txtVeichleType"
        txtVeichleType.Size = New Size(142, 27)
        txtVeichleType.TabIndex = 68
        txtVeichleType.Text = "NA"
        ' 
        ' lblVeichleType
        ' 
        lblVeichleType.AutoSize = True
        lblVeichleType.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblVeichleType.Location = New Point(12, 310)
        lblVeichleType.Name = "lblVeichleType"
        lblVeichleType.Size = New Size(121, 20)
        lblVeichleType.TabIndex = 67
        lblVeichleType.Text = "Veichle Type:"
        ' 
        ' txtEmiMonths
        ' 
        txtEmiMonths.Location = New Point(12, 270)
        txtEmiMonths.Name = "txtEmiMonths"
        txtEmiMonths.Size = New Size(142, 27)
        txtEmiMonths.TabIndex = 66
        txtEmiMonths.Text = "10"
        ' 
        ' lblEmiMonths
        ' 
        lblEmiMonths.AutoSize = True
        lblEmiMonths.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiMonths.Location = New Point(12, 247)
        lblEmiMonths.Name = "lblEmiMonths"
        lblEmiMonths.Size = New Size(107, 20)
        lblEmiMonths.TabIndex = 65
        lblEmiMonths.Text = "EMI Months:"
        ' 
        ' txtEmiAmount
        ' 
        txtEmiAmount.Location = New Point(172, 270)
        txtEmiAmount.Name = "txtEmiAmount"
        txtEmiAmount.ReadOnly = True
        txtEmiAmount.Size = New Size(162, 27)
        txtEmiAmount.TabIndex = 64
        txtEmiAmount.Text = "0.0"
        ' 
        ' lblEmiAmount
        ' 
        lblEmiAmount.AutoSize = True
        lblEmiAmount.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiAmount.Location = New Point(172, 247)
        lblEmiAmount.Name = "lblEmiAmount"
        lblEmiAmount.Size = New Size(111, 20)
        lblEmiAmount.TabIndex = 63
        lblEmiAmount.Text = "EMI Amount:"
        ' 
        ' txtDocCharge
        ' 
        txtDocCharge.Location = New Point(172, 206)
        txtDocCharge.Name = "txtDocCharge"
        txtDocCharge.ReadOnly = True
        txtDocCharge.Size = New Size(111, 27)
        txtDocCharge.TabIndex = 62
        txtDocCharge.Text = "0.0"
        ' 
        ' lblDocCharge
        ' 
        lblDocCharge.AutoSize = True
        lblDocCharge.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblDocCharge.Location = New Point(172, 183)
        lblDocCharge.Name = "lblDocCharge"
        lblDocCharge.Size = New Size(163, 20)
        lblDocCharge.TabIndex = 61
        lblDocCharge.Text = "Document Charge:"
        ' 
        ' txtLoanAmt
        ' 
        txtLoanAmt.Location = New Point(172, 148)
        txtLoanAmt.Name = "txtLoanAmt"
        txtLoanAmt.Size = New Size(162, 27)
        txtLoanAmt.TabIndex = 60
        txtLoanAmt.Text = "0.0"
        ' 
        ' lblLoanAmt
        ' 
        lblLoanAmt.AutoSize = True
        lblLoanAmt.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanAmt.Location = New Point(172, 125)
        lblLoanAmt.Name = "lblLoanAmt"
        lblLoanAmt.Size = New Size(121, 20)
        lblLoanAmt.TabIndex = 59
        lblLoanAmt.Text = "Loan Amount:"
        ' 
        ' txtGarandorAddr
        ' 
        txtGarandorAddr.Location = New Point(363, 206)
        txtGarandorAddr.Multiline = True
        txtGarandorAddr.Name = "txtGarandorAddr"
        txtGarandorAddr.Size = New Size(352, 93)
        txtGarandorAddr.TabIndex = 58
        txtGarandorAddr.Text = "NA"
        ' 
        ' lblGarantorAddr
        ' 
        lblGarantorAddr.AutoSize = True
        lblGarantorAddr.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblGarantorAddr.Location = New Point(363, 183)
        lblGarantorAddr.Name = "lblGarantorAddr"
        lblGarantorAddr.Size = New Size(286, 20)
        lblGarantorAddr.TabIndex = 57
        lblGarantorAddr.Text = "Garandor Name and Full Address:"
        ' 
        ' txtCustAddr
        ' 
        txtCustAddr.Location = New Point(427, 82)
        txtCustAddr.Multiline = True
        txtCustAddr.Name = "txtCustAddr"
        txtCustAddr.Size = New Size(288, 93)
        txtCustAddr.TabIndex = 56
        txtCustAddr.Text = "NA"
        ' 
        ' lblCustAddr
        ' 
        lblCustAddr.AutoSize = True
        lblCustAddr.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustAddr.Location = New Point(363, 62)
        lblCustAddr.Name = "lblCustAddr"
        lblCustAddr.Size = New Size(288, 20)
        lblCustAddr.TabIndex = 55
        lblCustAddr.Text = "Customer Name and Full Address:"
        ' 
        ' txtVeichleNum
        ' 
        txtVeichleNum.Location = New Point(172, 333)
        txtVeichleNum.Name = "txtVeichleNum"
        txtVeichleNum.Size = New Size(162, 27)
        txtVeichleNum.TabIndex = 54
        txtVeichleNum.Text = "NA"
        ' 
        ' lblVeichleNum
        ' 
        lblVeichleNum.AutoSize = True
        lblVeichleNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblVeichleNum.Location = New Point(172, 310)
        lblVeichleNum.Name = "lblVeichleNum"
        lblVeichleNum.Size = New Size(146, 20)
        lblVeichleNum.TabIndex = 53
        lblVeichleNum.Text = "Veichle Number:"
        ' 
        ' txtLoanNum
        ' 
        txtLoanNum.Location = New Point(12, 85)
        txtLoanNum.Name = "txtLoanNum"
        txtLoanNum.Size = New Size(142, 27)
        txtLoanNum.TabIndex = 52
        ' 
        ' lblLoanNum
        ' 
        lblLoanNum.AutoSize = True
        lblLoanNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanNum.Location = New Point(12, 62)
        lblLoanNum.Name = "lblLoanNum"
        lblLoanNum.Size = New Size(124, 20)
        lblLoanNum.TabIndex = 51
        lblLoanNum.Text = "Loan Number:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(7, 9)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(326, 32)
        lblTitle.TabIndex = 50
        lblTitle.Text = "New Loan Registration"
        ' 
        ' txtPrincipleAmt
        ' 
        txtPrincipleAmt.Location = New Point(363, 330)
        txtPrincipleAmt.Name = "txtPrincipleAmt"
        txtPrincipleAmt.ReadOnly = True
        txtPrincipleAmt.Size = New Size(142, 27)
        txtPrincipleAmt.TabIndex = 76
        txtPrincipleAmt.Text = "0.0"
        ' 
        ' lblPrincipleAmt
        ' 
        lblPrincipleAmt.AutoSize = True
        lblPrincipleAmt.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblPrincipleAmt.Location = New Point(363, 307)
        lblPrincipleAmt.Name = "lblPrincipleAmt"
        lblPrincipleAmt.Size = New Size(125, 20)
        lblPrincipleAmt.TabIndex = 75
        lblPrincipleAmt.Text = "Principle Amt:"
        ' 
        ' lblLoanStatus
        ' 
        lblLoanStatus.AutoSize = True
        lblLoanStatus.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanStatus.Location = New Point(363, 441)
        lblLoanStatus.Name = "lblLoanStatus"
        lblLoanStatus.Size = New Size(110, 20)
        lblLoanStatus.TabIndex = 77
        lblLoanStatus.Text = "Loan Status:"
        ' 
        ' cboLoanStatus
        ' 
        cboLoanStatus.FormattingEnabled = True
        cboLoanStatus.Items.AddRange(New Object() {"Active Pending", "Active", "Pending Close", "Closed"})
        cboLoanStatus.Location = New Point(363, 464)
        cboLoanStatus.Name = "cboLoanStatus"
        cboLoanStatus.Size = New Size(342, 28)
        cboLoanStatus.TabIndex = 78
        ' 
        ' lblLoanStartDate
        ' 
        lblLoanStartDate.AutoSize = True
        lblLoanStartDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanStartDate.Location = New Point(363, 374)
        lblLoanStartDate.Name = "lblLoanStartDate"
        lblLoanStartDate.Size = New Size(141, 20)
        lblLoanStartDate.TabIndex = 79
        lblLoanStartDate.Text = "Loan Start Date:"
        ' 
        ' lblLoanCloseDate
        ' 
        lblLoanCloseDate.AutoSize = True
        lblLoanCloseDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanCloseDate.Location = New Point(543, 374)
        lblLoanCloseDate.Name = "lblLoanCloseDate"
        lblLoanCloseDate.Size = New Size(148, 20)
        lblLoanCloseDate.TabIndex = 80
        lblLoanCloseDate.Text = "Loan Close Date:"
        ' 
        ' dtLoanStart
        ' 
        dtLoanStart.Location = New Point(363, 397)
        dtLoanStart.Name = "dtLoanStart"
        dtLoanStart.Size = New Size(162, 27)
        dtLoanStart.TabIndex = 81
        ' 
        ' dtLoanClose
        ' 
        dtLoanClose.Location = New Point(543, 396)
        dtLoanClose.Name = "dtLoanClose"
        dtLoanClose.Size = New Size(162, 27)
        dtLoanClose.TabIndex = 82
        ' 
        ' txtLoanIntrestPercent
        ' 
        txtLoanIntrestPercent.Location = New Point(12, 148)
        txtLoanIntrestPercent.Name = "txtLoanIntrestPercent"
        txtLoanIntrestPercent.Size = New Size(57, 27)
        txtLoanIntrestPercent.TabIndex = 84
        txtLoanIntrestPercent.Text = "24.00"
        ' 
        ' lblLoanIntrestPercent
        ' 
        lblLoanIntrestPercent.AutoSize = True
        lblLoanIntrestPercent.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanIntrestPercent.Location = New Point(12, 125)
        lblLoanIntrestPercent.Name = "lblLoanIntrestPercent"
        lblLoanIntrestPercent.Size = New Size(130, 20)
        lblLoanIntrestPercent.TabIndex = 83
        lblLoanIntrestPercent.Text = "Loan Intrest %:"
        ' 
        ' txtDocumentPercent
        ' 
        txtDocumentPercent.Location = New Point(12, 206)
        txtDocumentPercent.Name = "txtDocumentPercent"
        txtDocumentPercent.Size = New Size(142, 27)
        txtDocumentPercent.TabIndex = 86
        txtDocumentPercent.Text = "6.00"
        ' 
        ' lblDocumentChargePercent
        ' 
        lblDocumentChargePercent.AutoSize = True
        lblDocumentChargePercent.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblDocumentChargePercent.Location = New Point(12, 183)
        lblDocumentChargePercent.Name = "lblDocumentChargePercent"
        lblDocumentChargePercent.Size = New Size(136, 20)
        lblDocumentChargePercent.TabIndex = 85
        lblDocumentChargePercent.Text = "Doc. Charge %:"
        ' 
        ' txtCustId
        ' 
        txtCustId.Location = New Point(172, 85)
        txtCustId.Name = "txtCustId"
        txtCustId.Size = New Size(111, 27)
        txtCustId.TabIndex = 88
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(172, 62)
        Label1.Name = "Label1"
        Label1.Size = New Size(116, 20)
        Label1.TabIndex = 87
        Label1.Text = "Customer ID:"
        ' 
        ' btnEditDocCharge
        ' 
        btnEditDocCharge.Location = New Point(289, 206)
        btnEditDocCharge.Name = "btnEditDocCharge"
        btnEditDocCharge.Size = New Size(48, 27)
        btnEditDocCharge.TabIndex = 89
        btnEditDocCharge.Text = "Edit"
        btnEditDocCharge.UseVisualStyleBackColor = True
        ' 
        ' lblLoanIntPerMonth
        ' 
        lblLoanIntPerMonth.AutoSize = True
        lblLoanIntPerMonth.Font = New Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanIntPerMonth.Location = New Point(75, 151)
        lblLoanIntPerMonth.Name = "lblLoanIntPerMonth"
        lblLoanIntPerMonth.Size = New Size(60, 22)
        lblLoanIntPerMonth.TabIndex = 90
        lblLoanIntPerMonth.Text = "Loan Int"
        ' 
        ' btnNewCust
        ' 
        btnNewCust.Location = New Point(289, 85)
        btnNewCust.Name = "btnNewCust"
        btnNewCust.Size = New Size(48, 27)
        btnNewCust.TabIndex = 91
        btnNewCust.Text = "New"
        btnNewCust.UseVisualStyleBackColor = True
        ' 
        ' btnLoadCustAddr
        ' 
        btnLoadCustAddr.Location = New Point(363, 82)
        btnLoadCustAddr.Name = "btnLoadCustAddr"
        btnLoadCustAddr.Size = New Size(58, 93)
        btnLoadCustAddr.TabIndex = 92
        btnLoadCustAddr.Text = "Load"
        btnLoadCustAddr.UseVisualStyleBackColor = True
        ' 
        ' btnEditAFC
        ' 
        btnEditAFC.Location = New Point(657, 330)
        btnEditAFC.Name = "btnEditAFC"
        btnEditAFC.Size = New Size(48, 27)
        btnEditAFC.TabIndex = 93
        btnEditAFC.Text = "Edit"
        btnEditAFC.UseVisualStyleBackColor = True
        ' 
        ' frmNewLoanReg
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(729, 576)
        Controls.Add(btnEditAFC)
        Controls.Add(btnLoadCustAddr)
        Controls.Add(btnNewCust)
        Controls.Add(lblLoanIntPerMonth)
        Controls.Add(btnEditDocCharge)
        Controls.Add(txtCustId)
        Controls.Add(Label1)
        Controls.Add(txtDocumentPercent)
        Controls.Add(lblDocumentChargePercent)
        Controls.Add(txtLoanIntrestPercent)
        Controls.Add(lblLoanIntrestPercent)
        Controls.Add(dtLoanClose)
        Controls.Add(dtLoanStart)
        Controls.Add(lblLoanCloseDate)
        Controls.Add(lblLoanStartDate)
        Controls.Add(cboLoanStatus)
        Controls.Add(lblLoanStatus)
        Controls.Add(txtPrincipleAmt)
        Controls.Add(lblPrincipleAmt)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(txtInsDetails)
        Controls.Add(lblInsDetails)
        Controls.Add(txtAFC)
        Controls.Add(lblAFC)
        Controls.Add(txtVeichleType)
        Controls.Add(lblVeichleType)
        Controls.Add(txtEmiMonths)
        Controls.Add(lblEmiMonths)
        Controls.Add(txtEmiAmount)
        Controls.Add(lblEmiAmount)
        Controls.Add(txtDocCharge)
        Controls.Add(lblDocCharge)
        Controls.Add(txtLoanAmt)
        Controls.Add(lblLoanAmt)
        Controls.Add(txtGarandorAddr)
        Controls.Add(lblGarantorAddr)
        Controls.Add(txtCustAddr)
        Controls.Add(lblCustAddr)
        Controls.Add(txtVeichleNum)
        Controls.Add(lblVeichleNum)
        Controls.Add(txtLoanNum)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
        Name = "frmNewLoanReg"
        Text = "New Loan Registration"
        CType(BindingSource1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtInsDetails As TextBox
    Friend WithEvents lblInsDetails As Label
    Friend WithEvents txtAFC As TextBox
    Friend WithEvents lblAFC As Label
    Friend WithEvents txtVeichleType As TextBox
    Friend WithEvents lblVeichleType As Label
    Friend WithEvents txtEmiMonths As TextBox
    Friend WithEvents lblEmiMonths As Label
    Friend WithEvents txtEmiAmount As TextBox
    Friend WithEvents lblEmiAmount As Label
    Friend WithEvents txtDocCharge As TextBox
    Friend WithEvents lblDocCharge As Label
    Friend WithEvents txtLoanAmt As TextBox
    Friend WithEvents lblLoanAmt As Label
    Friend WithEvents txtGarandorAddr As TextBox
    Friend WithEvents lblGarantorAddr As Label
    Friend WithEvents txtCustAddr As TextBox
    Friend WithEvents lblCustAddr As Label
    Friend WithEvents txtVeichleNum As TextBox
    Friend WithEvents lblVeichleNum As Label
    Friend WithEvents txtLoanNum As TextBox
    Friend WithEvents lblLoanNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtPrincipleAmt As TextBox
    Friend WithEvents lblPrincipleAmt As Label
    Friend WithEvents lblLoanStatus As Label
    Friend WithEvents cboLoanStatus As ComboBox
    Friend WithEvents lblLoanStartDate As Label
    Friend WithEvents lblLoanCloseDate As Label
    Friend WithEvents dtLoanStart As DateTimePicker
    Friend WithEvents dtLoanClose As DateTimePicker
    Friend WithEvents txtLoanIntrestPercent As TextBox
    Friend WithEvents lblLoanIntrestPercent As Label
    Friend WithEvents txtDocumentPercent As TextBox
    Friend WithEvents lblDocumentChargePercent As Label
    Friend WithEvents txtCustId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnEditDocCharge As Button
    Friend WithEvents lblLoanIntPerMonth As Label
    Friend WithEvents btnNewCust As Button
    Friend WithEvents btnLoadCustAddr As Button
    Friend WithEvents btnEditAFC As Button
End Class
