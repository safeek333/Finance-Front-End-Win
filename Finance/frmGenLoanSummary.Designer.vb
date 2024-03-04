<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenLoanSummary
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
        Button1 = New Button()
        cboFileType = New ComboBox()
        Label3 = New Label()
        txtLoanNum = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(130, 159)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 29)
        Button1.TabIndex = 5
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cboFileType
        ' 
        cboFileType.FormattingEnabled = True
        cboFileType.Items.AddRange(New Object() {"PDF", "HTML"})
        cboFileType.Location = New Point(130, 109)
        cboFileType.Name = "cboFileType"
        cboFileType.Size = New Size(151, 28)
        cboFileType.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 109)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 3
        Label3.Text = "File Type:"
        ' 
        ' txtLoanNum
        ' 
        txtLoanNum.Location = New Point(130, 68)
        txtLoanNum.Name = "txtLoanNum"
        txtLoanNum.Size = New Size(151, 27)
        txtLoanNum.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(22, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(342, 38)
        Label2.TabIndex = 1
        Label2.Text = "Generate Loan Summary"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(102, 20)
        Label1.TabIndex = 0
        Label1.Text = "Loan Number:"
        ' 
        ' frmGenLoanSummary
        ' 
        AcceptButton = Button1
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(382, 202)
        Controls.Add(Button1)
        Controls.Add(cboFileType)
        Controls.Add(Label3)
        Controls.Add(txtLoanNum)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmGenLoanSummary"
        Text = "Generate Loan Summary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cboFileType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtLoanNum As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
