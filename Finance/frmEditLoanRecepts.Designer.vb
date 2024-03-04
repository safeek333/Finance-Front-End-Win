<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditLoanRecepts
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
        btnGetLoanDetails = New Button()
        txtLoanNum = New TextBox()
        lblLoanNum = New Label()
        lblTitle = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        SuspendLayout()
        ' 
        ' btnGetLoanDetails
        ' 
        btnGetLoanDetails.Location = New Point(192, 82)
        btnGetLoanDetails.Name = "btnGetLoanDetails"
        btnGetLoanDetails.Size = New Size(155, 29)
        btnGetLoanDetails.TabIndex = 60
        btnGetLoanDetails.Text = "Get Loan Recepts"
        btnGetLoanDetails.UseVisualStyleBackColor = True
        ' 
        ' txtLoanNum
        ' 
        txtLoanNum.Location = New Point(12, 85)
        txtLoanNum.Name = "txtLoanNum"
        txtLoanNum.Size = New Size(142, 27)
        txtLoanNum.TabIndex = 59
        ' 
        ' lblLoanNum
        ' 
        lblLoanNum.AutoSize = True
        lblLoanNum.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblLoanNum.Location = New Point(12, 62)
        lblLoanNum.Name = "lblLoanNum"
        lblLoanNum.Size = New Size(124, 20)
        lblLoanNum.TabIndex = 58
        lblLoanNum.Text = "Loan Number:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(8, 9)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(192, 32)
        lblTitle.TabIndex = 57
        lblTitle.Text = "Enter Details"
        ' 
        ' frmEditLoanRecepts
        ' 
        AcceptButton = btnGetLoanDetails
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(367, 129)
        Controls.Add(btnGetLoanDetails)
        Controls.Add(txtLoanNum)
        Controls.Add(lblLoanNum)
        Controls.Add(lblTitle)
        Name = "frmEditLoanRecepts"
        Text = "Enter Loan Number"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGetLoanDetails As Button
    Friend WithEvents txtLoanNum As TextBox
    Friend WithEvents lblLoanNum As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
