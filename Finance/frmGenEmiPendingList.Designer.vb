<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenEmiPendingList
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
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(120, 115)
        Button1.Name = "Button1"
        Button1.Size = New Size(151, 29)
        Button1.TabIndex = 11
        Button1.Text = "Generate"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' cboFileType
        ' 
        cboFileType.FormattingEnabled = True
        cboFileType.Items.AddRange(New Object() {"PDF", "HTML"})
        cboFileType.Location = New Point(120, 65)
        cboFileType.Name = "cboFileType"
        cboFileType.Size = New Size(151, 28)
        cboFileType.TabIndex = 10
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 65)
        Label3.Name = "Label3"
        Label3.Size = New Size(70, 20)
        Label3.TabIndex = 9
        Label3.Text = "File Type:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(348, 38)
        Label2.TabIndex = 7
        Label2.Text = "Generate Pending Report"
        ' 
        ' frmGenEmiPendingList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(373, 162)
        Controls.Add(Button1)
        Controls.Add(cboFileType)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Name = "frmGenEmiPendingList"
        Text = "Generate Pending Report"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents cboFileType As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
