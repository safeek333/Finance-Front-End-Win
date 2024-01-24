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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        dgLoanList.Dock = DockStyle.Top
        dgLoanList.Location = New Point(0, 0)
        dgLoanList.Name = "dgLoanList"
        dgLoanList.RowHeadersWidth = 51
        dgLoanList.RowTemplate.Height = 29
        dgLoanList.Size = New Size(1482, 813)
        dgLoanList.TabIndex = 0
        ' 
        ' loanNumber
        ' 
        loanNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanNumber.DefaultCellStyle = DataGridViewCellStyle1
        loanNumber.HeaderText = "LOAN NUM"
        loanNumber.MinimumWidth = 6
        loanNumber.Name = "loanNumber"
        loanNumber.ReadOnly = True
        loanNumber.Width = 105
        ' 
        ' veichleNumber
        ' 
        veichleNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        veichleNumber.DefaultCellStyle = DataGridViewCellStyle2
        veichleNumber.HeaderText = "VEICHLE NUMBER"
        veichleNumber.MinimumWidth = 6
        veichleNumber.Name = "veichleNumber"
        veichleNumber.ReadOnly = True
        veichleNumber.Width = 145
        ' 
        ' customerAddress
        ' 
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        customerAddress.DefaultCellStyle = DataGridViewCellStyle3
        customerAddress.HeaderText = "CUSTOMER ADDRESS"
        customerAddress.MinimumWidth = 6
        customerAddress.Name = "customerAddress"
        customerAddress.ReadOnly = True
        customerAddress.Width = 166
        ' 
        ' garandorAddress
        ' 
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        garandorAddress.DefaultCellStyle = DataGridViewCellStyle4
        garandorAddress.HeaderText = "GARANDOR ADDRESS"
        garandorAddress.MinimumWidth = 6
        garandorAddress.Name = "garandorAddress"
        garandorAddress.ReadOnly = True
        garandorAddress.Width = 172
        ' 
        ' loanAmount
        ' 
        loanAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanAmount.DefaultCellStyle = DataGridViewCellStyle5
        loanAmount.HeaderText = "LOAN AMT"
        loanAmount.MinimumWidth = 6
        loanAmount.Name = "loanAmount"
        loanAmount.ReadOnly = True
        loanAmount.Width = 102
        ' 
        ' documentCharge
        ' 
        documentCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        documentCharge.DefaultCellStyle = DataGridViewCellStyle6
        documentCharge.HeaderText = "DOC CHARGE"
        documentCharge.MinimumWidth = 6
        documentCharge.Name = "documentCharge"
        documentCharge.ReadOnly = True
        documentCharge.Width = 119
        ' 
        ' emiAmount
        ' 
        emiAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        emiAmount.DefaultCellStyle = DataGridViewCellStyle7
        emiAmount.HeaderText = "EMI AMT"
        emiAmount.MinimumWidth = 6
        emiAmount.Name = "emiAmount"
        emiAmount.ReadOnly = True
        emiAmount.Width = 91
        ' 
        ' emiMonths
        ' 
        emiMonths.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        emiMonths.DefaultCellStyle = DataGridViewCellStyle8
        emiMonths.HeaderText = "MONTHS"
        emiMonths.MinimumWidth = 6
        emiMonths.Name = "emiMonths"
        emiMonths.ReadOnly = True
        ' 
        ' veichleType
        ' 
        veichleType.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        veichleType.DefaultCellStyle = DataGridViewCellStyle9
        veichleType.HeaderText = "VEICHLE TYPE"
        veichleType.MinimumWidth = 6
        veichleType.Name = "veichleType"
        veichleType.ReadOnly = True
        veichleType.Width = 119
        ' 
        ' afc
        ' 
        afc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        afc.DefaultCellStyle = DataGridViewCellStyle10
        afc.HeaderText = "AFC"
        afc.MinimumWidth = 6
        afc.Name = "afc"
        afc.ReadOnly = True
        afc.Width = 64
        ' 
        ' insuranceDetails
        ' 
        insuranceDetails.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        insuranceDetails.DefaultCellStyle = DataGridViewCellStyle11
        insuranceDetails.HeaderText = "INSURANCE DETAILS"
        insuranceDetails.MinimumWidth = 6
        insuranceDetails.Name = "insuranceDetails"
        insuranceDetails.ReadOnly = True
        insuranceDetails.Width = 162
        ' 
        ' principleAmount
        ' 
        principleAmount.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        principleAmount.DefaultCellStyle = DataGridViewCellStyle12
        principleAmount.HeaderText = "PRINCIPLE AMT"
        principleAmount.MinimumWidth = 6
        principleAmount.Name = "principleAmount"
        principleAmount.ReadOnly = True
        principleAmount.Width = 129
        ' 
        ' loanStartDate
        ' 
        loanStartDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle13.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanStartDate.DefaultCellStyle = DataGridViewCellStyle13
        loanStartDate.HeaderText = "LOAN START DATE"
        loanStartDate.MinimumWidth = 6
        loanStartDate.Name = "loanStartDate"
        loanStartDate.ReadOnly = True
        loanStartDate.Width = 147
        ' 
        ' loanCloseDate
        ' 
        loanCloseDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle14.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanCloseDate.DefaultCellStyle = DataGridViewCellStyle14
        loanCloseDate.HeaderText = "LOAN CLOSE DATE"
        loanCloseDate.MinimumWidth = 6
        loanCloseDate.Name = "loanCloseDate"
        loanCloseDate.ReadOnly = True
        loanCloseDate.Width = 148
        ' 
        ' loanStatus
        ' 
        loanStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle15.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanStatus.DefaultCellStyle = DataGridViewCellStyle15
        loanStatus.HeaderText = "LOAN STATUS"
        loanStatus.MinimumWidth = 6
        loanStatus.Name = "loanStatus"
        loanStatus.ReadOnly = True
        loanStatus.Width = 119
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtSearch.Location = New Point(75, 819)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 34)
        txtSearch.TabIndex = 1
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblSearch.Location = New Point(8, 822)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(67, 28)
        lblSearch.TabIndex = 2
        lblSearch.Text = "Filter:"
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
        Text = "Loans"
        WindowState = FormWindowState.Maximized
        CType(dgLoanList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgLoanList As DataGridView
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents lblSearch As Label
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
End Class
