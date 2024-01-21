<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoanList
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
        dgLoanList = New DataGridView()
        loanNumber = New DataGridViewTextBoxColumn()
        veichleNumber = New DataGridViewTextBoxColumn()
        customerAddress = New DataGridViewTextBoxColumn()
        garandorAddress = New DataGridViewTextBoxColumn()
        loanAmount = New DataGridViewTextBoxColumn()
        documentCharge = New DataGridViewTextBoxColumn()
        emiAmount = New DataGridViewTextBoxColumn()
        emiMonths = New DataGridViewTextBoxColumn()
        veichleType = New DataGridViewTextBoxColumn()
        afc = New DataGridViewTextBoxColumn()
        insuranceDetails = New DataGridViewTextBoxColumn()
        principleAmount = New DataGridViewTextBoxColumn()
        loanStartDate = New DataGridViewTextBoxColumn()
        loanCloseDate = New DataGridViewTextBoxColumn()
        loanStatus = New DataGridViewTextBoxColumn()
        txtSearch = New TextBox()
        lblSearch = New Label()
        CType(dgLoanList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgLoanList
        ' 
        dgLoanList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgLoanList.Columns.AddRange(New DataGridViewColumn() {loanNumber, veichleNumber, customerAddress, garandorAddress, loanAmount, documentCharge, emiAmount, emiMonths, veichleType, afc, insuranceDetails, principleAmount, loanStartDate, loanCloseDate, loanStatus})
        dgLoanList.Dock = DockStyle.Bottom
        dgLoanList.Location = New Point(0, 40)
        dgLoanList.Name = "dgLoanList"
        dgLoanList.RowHeadersWidth = 51
        dgLoanList.RowTemplate.Height = 29
        dgLoanList.Size = New Size(1482, 813)
        dgLoanList.TabIndex = 0
        ' 
        ' loanNumber
        ' 
        loanNumber.HeaderText = "LOAN NUM"
        loanNumber.MinimumWidth = 6
        loanNumber.Name = "loanNumber"
        loanNumber.ReadOnly = True
        loanNumber.Width = 125
        ' 
        ' veichleNumber
        ' 
        veichleNumber.HeaderText = "VEICHLE NUMBER"
        veichleNumber.MinimumWidth = 6
        veichleNumber.Name = "veichleNumber"
        veichleNumber.ReadOnly = True
        veichleNumber.Width = 125
        ' 
        ' customerAddress
        ' 
        customerAddress.HeaderText = "CUSTOMER ADDRESS"
        customerAddress.MinimumWidth = 6
        customerAddress.Name = "customerAddress"
        customerAddress.ReadOnly = True
        customerAddress.Width = 125
        ' 
        ' garandorAddress
        ' 
        garandorAddress.HeaderText = "GARANDOR ADDRESS"
        garandorAddress.MinimumWidth = 6
        garandorAddress.Name = "garandorAddress"
        garandorAddress.ReadOnly = True
        garandorAddress.Width = 125
        ' 
        ' loanAmount
        ' 
        loanAmount.HeaderText = "LOAN AMT"
        loanAmount.MinimumWidth = 6
        loanAmount.Name = "loanAmount"
        loanAmount.ReadOnly = True
        loanAmount.Width = 125
        ' 
        ' documentCharge
        ' 
        documentCharge.HeaderText = "DOC CHARGE"
        documentCharge.MinimumWidth = 6
        documentCharge.Name = "documentCharge"
        documentCharge.ReadOnly = True
        documentCharge.Width = 125
        ' 
        ' emiAmount
        ' 
        emiAmount.HeaderText = "EMI AMT"
        emiAmount.MinimumWidth = 6
        emiAmount.Name = "emiAmount"
        emiAmount.ReadOnly = True
        emiAmount.Width = 125
        ' 
        ' emiMonths
        ' 
        emiMonths.HeaderText = "MONTHS"
        emiMonths.MinimumWidth = 6
        emiMonths.Name = "emiMonths"
        emiMonths.ReadOnly = True
        emiMonths.Width = 125
        ' 
        ' veichleType
        ' 
        veichleType.HeaderText = "VEICHLE TYPE"
        veichleType.MinimumWidth = 6
        veichleType.Name = "veichleType"
        veichleType.ReadOnly = True
        veichleType.Width = 125
        ' 
        ' afc
        ' 
        afc.HeaderText = "AFC"
        afc.MinimumWidth = 6
        afc.Name = "afc"
        afc.ReadOnly = True
        afc.Width = 125
        ' 
        ' insuranceDetails
        ' 
        insuranceDetails.HeaderText = "INSURANCE DETAILS"
        insuranceDetails.MinimumWidth = 6
        insuranceDetails.Name = "insuranceDetails"
        insuranceDetails.ReadOnly = True
        insuranceDetails.Width = 125
        ' 
        ' principleAmount
        ' 
        principleAmount.HeaderText = "PRINCIPLE AMT"
        principleAmount.MinimumWidth = 6
        principleAmount.Name = "principleAmount"
        principleAmount.ReadOnly = True
        principleAmount.Width = 125
        ' 
        ' loanStartDate
        ' 
        loanStartDate.HeaderText = "LOAN START DATE"
        loanStartDate.MinimumWidth = 6
        loanStartDate.Name = "loanStartDate"
        loanStartDate.ReadOnly = True
        loanStartDate.Width = 125
        ' 
        ' loanCloseDate
        ' 
        loanCloseDate.HeaderText = "LOAN CLOSE DATE"
        loanCloseDate.MinimumWidth = 6
        loanCloseDate.Name = "loanCloseDate"
        loanCloseDate.ReadOnly = True
        loanCloseDate.Width = 125
        ' 
        ' loanStatus
        ' 
        loanStatus.HeaderText = "LOAN STATUS"
        loanStatus.MinimumWidth = 6
        loanStatus.Name = "loanStatus"
        loanStatus.ReadOnly = True
        loanStatus.Width = 125
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(60, 7)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 27)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Location = New Point(12, 10)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(42, 20)
        lblSearch.TabIndex = 2
        lblSearch.Text = "Filter"
        ' 
        ' frmLoanList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1482, 853)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgLoanList)
        Name = "frmLoanList"
        Text = "frmLoanList"
        WindowState = FormWindowState.Maximized
        CType(dgLoanList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgLoanList As DataGridView
    Friend WithEvents loanNumber As DataGridViewTextBoxColumn
    Friend WithEvents veichleNumber As DataGridViewTextBoxColumn
    Friend WithEvents customerAddress As DataGridViewTextBoxColumn
    Friend WithEvents garandorAddress As DataGridViewTextBoxColumn
    Friend WithEvents loanAmount As DataGridViewTextBoxColumn
    Friend WithEvents documentCharge As DataGridViewTextBoxColumn
    Friend WithEvents emiAmount As DataGridViewTextBoxColumn
    Friend WithEvents emiMonths As DataGridViewTextBoxColumn
    Friend WithEvents veichleType As DataGridViewTextBoxColumn
    Friend WithEvents afc As DataGridViewTextBoxColumn
    Friend WithEvents insuranceDetails As DataGridViewTextBoxColumn
    Friend WithEvents principleAmount As DataGridViewTextBoxColumn
    Friend WithEvents loanStartDate As DataGridViewTextBoxColumn
    Friend WithEvents loanCloseDate As DataGridViewTextBoxColumn
    Friend WithEvents loanStatus As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
End Class
