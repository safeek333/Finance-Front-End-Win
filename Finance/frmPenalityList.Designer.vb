<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenalityList
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
        dgPenalityList = New DataGridView()
        penalityId = New DataGridViewTextBoxColumn()
        penalityAmt = New DataGridViewTextBoxColumn()
        effectiveDate = New DataGridViewTextBoxColumn()
        penalityDesc = New DataGridViewTextBoxColumn()
        CType(dgPenalityList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPenalityList
        ' 
        dgPenalityList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPenalityList.Columns.AddRange(New DataGridViewColumn() {penalityId, penalityAmt, effectiveDate, penalityDesc})
        dgPenalityList.Dock = DockStyle.Fill
        dgPenalityList.Location = New Point(0, 0)
        dgPenalityList.Name = "dgPenalityList"
        dgPenalityList.RowHeadersWidth = 51
        dgPenalityList.RowTemplate.Height = 29
        dgPenalityList.Size = New Size(800, 450)
        dgPenalityList.TabIndex = 0
        ' 
        ' penalityId
        ' 
        penalityId.HeaderText = "PENALITY ID"
        penalityId.MinimumWidth = 6
        penalityId.Name = "penalityId"
        penalityId.ReadOnly = True
        penalityId.Width = 125
        ' 
        ' penalityAmt
        ' 
        penalityAmt.HeaderText = "AMOUNT (per month)"
        penalityAmt.MinimumWidth = 6
        penalityAmt.Name = "penalityAmt"
        penalityAmt.ReadOnly = True
        penalityAmt.Width = 125
        ' 
        ' effectiveDate
        ' 
        effectiveDate.HeaderText = "EFFECTIVE DATE"
        effectiveDate.MinimumWidth = 6
        effectiveDate.Name = "effectiveDate"
        effectiveDate.ReadOnly = True
        effectiveDate.Width = 125
        ' 
        ' penalityDesc
        ' 
        penalityDesc.HeaderText = "DESCRIPTION"
        penalityDesc.MinimumWidth = 6
        penalityDesc.Name = "penalityDesc"
        penalityDesc.ReadOnly = True
        penalityDesc.Width = 125
        ' 
        ' frmPenalityList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgPenalityList)
        Name = "frmPenalityList"
        Text = "frmPenalityList"
        CType(dgPenalityList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgPenalityList As DataGridView
    Friend WithEvents penalityId As DataGridViewTextBoxColumn
    Friend WithEvents penalityAmt As DataGridViewTextBoxColumn
    Friend WithEvents effectiveDate As DataGridViewTextBoxColumn
    Friend WithEvents penalityDesc As DataGridViewTextBoxColumn
End Class
