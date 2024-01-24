<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewPenality
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
        GroupBox1 = New GroupBox()
        Label1 = New Label()
        txtPenalityDesc = New TextBox()
        btnMakePenalityEntry = New Button()
        Label4 = New Label()
        lblPenalityAmt = New Label()
        txtPenalityAmt = New TextBox()
        dtEffectiveDate = New DateTimePicker()
        lblEffectiveDate = New Label()
        lblTitle = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(txtPenalityDesc)
        GroupBox1.Controls.Add(btnMakePenalityEntry)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(lblPenalityAmt)
        GroupBox1.Controls.Add(txtPenalityAmt)
        GroupBox1.Controls.Add(dtEffectiveDate)
        GroupBox1.Controls.Add(lblEffectiveDate)
        GroupBox1.Location = New Point(18, 44)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(507, 187)
        GroupBox1.TabIndex = 100
        GroupBox1.TabStop = False
        GroupBox1.Text = "Penality Entry"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(279, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(92, 20)
        Label1.TabIndex = 109
        Label1.Text = "per month"
        ' 
        ' txtPenalityDesc
        ' 
        txtPenalityDesc.Location = New Point(6, 118)
        txtPenalityDesc.Multiline = True
        txtPenalityDesc.Name = "txtPenalityDesc"
        txtPenalityDesc.Size = New Size(334, 61)
        txtPenalityDesc.TabIndex = 108
        txtPenalityDesc.Text = "PENALITY AMOUNT CHANGED"
        ' 
        ' btnMakePenalityEntry
        ' 
        btnMakePenalityEntry.Location = New Point(354, 118)
        btnMakePenalityEntry.Name = "btnMakePenalityEntry"
        btnMakePenalityEntry.Size = New Size(153, 61)
        btnMakePenalityEntry.TabIndex = 100
        btnMakePenalityEntry.Text = "Make Penality Entry"
        btnMakePenalityEntry.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(9, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 20)
        Label4.TabIndex = 107
        Label4.Text = "Penality Description:"
        ' 
        ' lblPenalityAmt
        ' 
        lblPenalityAmt.AutoSize = True
        lblPenalityAmt.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblPenalityAmt.Location = New Point(178, 29)
        lblPenalityAmt.Name = "lblPenalityAmt"
        lblPenalityAmt.Size = New Size(117, 20)
        lblPenalityAmt.TabIndex = 97
        lblPenalityAmt.Text = "Penality Amt:"
        ' 
        ' txtPenalityAmt
        ' 
        txtPenalityAmt.Location = New Point(178, 52)
        txtPenalityAmt.Name = "txtPenalityAmt"
        txtPenalityAmt.Size = New Size(95, 27)
        txtPenalityAmt.TabIndex = 98
        txtPenalityAmt.Text = "250.0"
        ' 
        ' dtEffectiveDate
        ' 
        dtEffectiveDate.Location = New Point(9, 52)
        dtEffectiveDate.Name = "dtEffectiveDate"
        dtEffectiveDate.Size = New Size(162, 27)
        dtEffectiveDate.TabIndex = 98
        ' 
        ' lblEffectiveDate
        ' 
        lblEffectiveDate.AutoSize = True
        lblEffectiveDate.Font = New Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblEffectiveDate.Location = New Point(9, 29)
        lblEffectiveDate.Name = "lblEffectiveDate"
        lblEffectiveDate.Size = New Size(130, 20)
        lblEffectiveDate.TabIndex = 97
        lblEffectiveDate.Text = "Effective Date:"
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial Rounded MT Bold", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        lblTitle.Location = New Point(18, 9)
        lblTitle.Margin = New Padding(9, 0, 9, 0)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(273, 32)
        lblTitle.TabIndex = 99
        lblTitle.Text = "New Penality Entry"
        ' 
        ' frmNewPenality
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(535, 233)
        Controls.Add(GroupBox1)
        Controls.Add(lblTitle)
        Name = "frmNewPenality"
        Text = "New Penality"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtPenalityDesc As TextBox
    Friend WithEvents btnMakePenalityEntry As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPenalityAmt As Label
    Friend WithEvents txtPenalityAmt As TextBox
    Friend WithEvents dtEffectiveDate As DateTimePicker
    Friend WithEvents lblEffectiveDate As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
End Class
