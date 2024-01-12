<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCust
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
        btnSetAge = New Button()
        dtCustDob = New DateTimePicker()
        lblCustDbo = New Label()
        cboCustIdType = New ComboBox()
        lblCustIdType = New Label()
        txtMobileNum = New TextBox()
        lblEmiMonths = New Label()
        txtCustId = New TextBox()
        lblLoanNum = New Label()
        lblTitle = New Label()
        Label1 = New Label()
        cboCustType = New ComboBox()
        txtCustName = New TextBox()
        lblCustName = New Label()
        txtCustNative = New TextBox()
        Label2 = New Label()
        txtCustAddr = New TextBox()
        lblCustAddr = New Label()
        btnReset = New Button()
        btnSave = New Button()
        txtAge = New TextBox()
        Label3 = New Label()
        cboCustStatus = New ComboBox()
        lblCustStatus = New Label()
        txtCustSocialId = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' btnSetAge
        ' 
        btnSetAge.Location = New Point(274, 345)
        btnSetAge.Name = "btnSetAge"
        btnSetAge.Size = New Size(129, 27)
        btnSetAge.TabIndex = 100
        btnSetAge.Text = "Edit"
        btnSetAge.UseVisualStyleBackColor = True
        ' 
        ' dtCustDob
        ' 
        dtCustDob.Location = New Point(15, 343)
        dtCustDob.Name = "dtCustDob"
        dtCustDob.Size = New Size(162, 27)
        dtCustDob.TabIndex = 99
        ' 
        ' lblCustDbo
        ' 
        lblCustDbo.AutoSize = True
        lblCustDbo.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustDbo.Location = New Point(15, 320)
        lblCustDbo.Name = "lblCustDbo"
        lblCustDbo.Size = New Size(120, 20)
        lblCustDbo.TabIndex = 98
        lblCustDbo.Text = "Date Of Birth:"
        ' 
        ' cboCustIdType
        ' 
        cboCustIdType.FormattingEnabled = True
        cboCustIdType.Items.AddRange(New Object() {"Auto", "Aadhar", "Passport", "Voter", "License", "Mobile"})
        cboCustIdType.Location = New Point(15, 206)
        cboCustIdType.Name = "cboCustIdType"
        cboCustIdType.Size = New Size(163, 28)
        cboCustIdType.TabIndex = 97
        ' 
        ' lblCustIdType
        ' 
        lblCustIdType.AutoSize = True
        lblCustIdType.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustIdType.Location = New Point(15, 183)
        lblCustIdType.Name = "lblCustIdType"
        lblCustIdType.Size = New Size(132, 20)
        lblCustIdType.TabIndex = 96
        lblCustIdType.Text = "Social ID Type:"
        ' 
        ' txtMobileNum
        ' 
        txtMobileNum.Location = New Point(14, 272)
        txtMobileNum.Name = "txtMobileNum"
        txtMobileNum.Size = New Size(164, 27)
        txtMobileNum.TabIndex = 95
        txtMobileNum.Text = "NA"
        ' 
        ' lblEmiMonths
        ' 
        lblEmiMonths.AutoSize = True
        lblEmiMonths.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEmiMonths.Location = New Point(14, 249)
        lblEmiMonths.Name = "lblEmiMonths"
        lblEmiMonths.Size = New Size(139, 20)
        lblEmiMonths.TabIndex = 94
        lblEmiMonths.Text = "Mobile Number:"
        ' 
        ' txtCustId
        ' 
        txtCustId.Location = New Point(15, 79)
        txtCustId.Name = "txtCustId"
        txtCustId.Size = New Size(129, 27)
        txtCustId.TabIndex = 93
        ' 
        ' lblLoanNum
        ' 
        lblLoanNum.AutoSize = True
        lblLoanNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanNum.Location = New Point(15, 56)
        lblLoanNum.Name = "lblLoanNum"
        lblLoanNum.Size = New Size(116, 20)
        lblLoanNum.TabIndex = 92
        lblLoanNum.Text = "Customer ID:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(11, 3)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(392, 32)
        lblTitle.TabIndex = 91
        lblTitle.Text = "New Customer Registration"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(164, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(139, 20)
        Label1.TabIndex = 102
        Label1.Text = "Customer Type:"
        ' 
        ' cboCustType
        ' 
        cboCustType.FormattingEnabled = True
        cboCustType.Items.AddRange(New Object() {"Loan Customer", "Garantor"})
        cboCustType.Location = New Point(163, 79)
        cboCustType.Name = "cboCustType"
        cboCustType.Size = New Size(240, 28)
        cboCustType.TabIndex = 103
        ' 
        ' txtCustName
        ' 
        txtCustName.Location = New Point(15, 143)
        txtCustName.Name = "txtCustName"
        txtCustName.Size = New Size(388, 27)
        txtCustName.TabIndex = 105
        ' 
        ' lblCustName
        ' 
        lblCustName.AutoSize = True
        lblCustName.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustName.Location = New Point(15, 120)
        lblCustName.Name = "lblCustName"
        lblCustName.Size = New Size(146, 20)
        lblCustName.TabIndex = 104
        lblCustName.Text = "Customer Name:"
        ' 
        ' txtCustNative
        ' 
        txtCustNative.Location = New Point(201, 272)
        txtCustNative.Name = "txtCustNative"
        txtCustNative.Size = New Size(202, 27)
        txtCustNative.TabIndex = 107
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(201, 249)
        Label2.Name = "Label2"
        Label2.Size = New Size(67, 20)
        Label2.TabIndex = 106
        Label2.Text = "Native:"
        ' 
        ' txtCustAddr
        ' 
        txtCustAddr.Location = New Point(14, 410)
        txtCustAddr.Multiline = True
        txtCustAddr.Name = "txtCustAddr"
        txtCustAddr.Size = New Size(389, 93)
        txtCustAddr.TabIndex = 109
        txtCustAddr.Text = "NA"
        ' 
        ' lblCustAddr
        ' 
        lblCustAddr.AutoSize = True
        lblCustAddr.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustAddr.Location = New Point(14, 387)
        lblCustAddr.Name = "lblCustAddr"
        lblCustAddr.Size = New Size(288, 20)
        lblCustAddr.TabIndex = 108
        lblCustAddr.Text = "Customer Name and Full Address:"
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(317, 538)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(86, 34)
        btnReset.TabIndex = 111
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(202, 538)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(86, 34)
        btnSave.TabIndex = 110
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(201, 345)
        txtAge.Name = "txtAge"
        txtAge.ReadOnly = True
        txtAge.Size = New Size(67, 27)
        txtAge.TabIndex = 112
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(202, 320)
        Label3.Name = "Label3"
        Label3.Size = New Size(47, 20)
        Label3.TabIndex = 113
        Label3.Text = "Age:"
        ' 
        ' cboCustStatus
        ' 
        cboCustStatus.FormattingEnabled = True
        cboCustStatus.Items.AddRange(New Object() {"Pending", "Active", "Blocked", "Deleted"})
        cboCustStatus.Location = New Point(14, 542)
        cboCustStatus.Name = "cboCustStatus"
        cboCustStatus.Size = New Size(164, 28)
        cboCustStatus.TabIndex = 115
        ' 
        ' lblCustStatus
        ' 
        lblCustStatus.AutoSize = True
        lblCustStatus.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblCustStatus.Location = New Point(14, 519)
        lblCustStatus.Name = "lblCustStatus"
        lblCustStatus.Size = New Size(150, 20)
        lblCustStatus.TabIndex = 114
        lblCustStatus.Text = "Customer Status:"
        ' 
        ' txtCustSocialId
        ' 
        txtCustSocialId.Location = New Point(201, 206)
        txtCustSocialId.Name = "txtCustSocialId"
        txtCustSocialId.Size = New Size(202, 27)
        txtCustSocialId.TabIndex = 117
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(201, 183)
        Label4.Name = "Label4"
        Label4.Size = New Size(135, 20)
        Label4.TabIndex = 116
        Label4.Text = "lblCustSocialId"
        ' 
        ' frmNewCust
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(423, 657)
        Controls.Add(txtCustSocialId)
        Controls.Add(Label4)
        Controls.Add(cboCustStatus)
        Controls.Add(lblCustStatus)
        Controls.Add(Label3)
        Controls.Add(txtAge)
        Controls.Add(btnReset)
        Controls.Add(btnSave)
        Controls.Add(txtCustAddr)
        Controls.Add(lblCustAddr)
        Controls.Add(txtCustNative)
        Controls.Add(Label2)
        Controls.Add(txtCustName)
        Controls.Add(lblCustName)
        Controls.Add(cboCustType)
        Controls.Add(Label1)
        Controls.Add(btnSetAge)
        Controls.Add(dtCustDob)
        Controls.Add(lblCustDbo)
        Controls.Add(cboCustIdType)
        Controls.Add(lblCustIdType)
        Controls.Add(txtMobileNum)
        Controls.Add(lblEmiMonths)
        Controls.Add(txtCustId)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
        Name = "frmNewCust"
        Text = "New Customer"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSetAge As Button
    Friend WithEvents dtCustDob As DateTimePicker
    Friend WithEvents lblCustDbo As Label
    Friend WithEvents cboCustIdType As ComboBox
    Friend WithEvents lblCustIdType As Label
    Friend WithEvents txtMobileNum As TextBox
    Friend WithEvents lblEmiMonths As Label
    Friend WithEvents txtCustId As TextBox
    Friend WithEvents lblLoanNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cboCustType As ComboBox
    Friend WithEvents txtCustName As TextBox
    Friend WithEvents lblCustName As Label
    Friend WithEvents txtCustNative As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCustAddr As TextBox
    Friend WithEvents lblCustAddr As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents txtAge As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboCustStatus As ComboBox
    Friend WithEvents lblCustStatus As Label
    Friend WithEvents txtCustSocialId As TextBox
    Friend WithEvents Label4 As Label
End Class
