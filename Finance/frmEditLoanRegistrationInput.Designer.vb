<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditLoanRegistrationInput
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
        txtLoanNum = New TextBox()
        lblLoanNum = New Label()
        lblTitle = New Label()
        btnGetLoanDetails = New Button()
        SuspendLayout()
        ' 
        ' txtLoanNum
        ' 
        txtLoanNum.Location = New Point(38, 97)
        txtLoanNum.Name = "txtLoanNum"
        txtLoanNum.Size = New Size(142, 27)
        txtLoanNum.TabIndex = 55
        ' 
        ' lblLoanNum
        ' 
        lblLoanNum.AutoSize = True
        lblLoanNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanNum.Location = New Point(38, 74)
        lblLoanNum.Name = "lblLoanNum"
        lblLoanNum.Size = New Size(124, 20)
        lblLoanNum.TabIndex = 54
        lblLoanNum.Text = "Loan Number:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(34, 21)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(192, 32)
        lblTitle.TabIndex = 53
        lblTitle.Text = "Enter Details"
        ' 
        ' btnGetLoanDetails
        ' 
        btnGetLoanDetails.Location = New Point(218, 94)
        btnGetLoanDetails.Name = "btnGetLoanDetails"
        btnGetLoanDetails.Size = New Size(155, 29)
        btnGetLoanDetails.TabIndex = 56
        btnGetLoanDetails.Text = "Get Loan Details"
        btnGetLoanDetails.UseVisualStyleBackColor = True
        ' 
        ' frmEditLoanRegistrationInput
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(395, 142)
        Controls.Add(btnGetLoanDetails)
        Controls.Add(txtLoanNum)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
        Name = "frmEditLoanRegistrationInput"
        Text = "frmEditLoanRegistrationInput"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtLoanNum As TextBox
    Friend WithEvents lblLoanNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnGetLoanDetails As Button
End Class
