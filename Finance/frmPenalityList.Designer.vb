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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgPenalityList = New DataGridView()
        penalityId = New DataGridViewTextBoxColumn()
        penalityAmt = New DataGridViewTextBoxColumn()
        effectiveDate = New DataGridViewTextBoxColumn()
        penalityDesc = New DataGridViewTextBoxColumn()
        lblSearch = New Label()
        txtSearch = New TextBox()
        CType(dgPenalityList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPenalityList
        ' 
        dgPenalityList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPenalityList.Columns.AddRange(New DataGridViewColumn() {penalityId, penalityAmt, effectiveDate, penalityDesc})
        dgPenalityList.Dock = DockStyle.Top
        dgPenalityList.Location = New Point(0, 0)
        dgPenalityList.Name = "dgPenalityList"
        dgPenalityList.RowHeadersWidth = 51
        dgPenalityList.RowTemplate.Height = 29
        dgPenalityList.Size = New Size(800, 570)
        dgPenalityList.TabIndex = 0
        ' 
        ' penalityId
        ' 
        penalityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        penalityId.DefaultCellStyle = DataGridViewCellStyle1
        penalityId.HeaderText = "PENALITY ID"
        penalityId.MinimumWidth = 6
        penalityId.Name = "penalityId"
        penalityId.ReadOnly = True
        penalityId.Width = 111
        ' 
        ' penalityAmt
        ' 
        penalityAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        penalityAmt.DefaultCellStyle = DataGridViewCellStyle2
        penalityAmt.HeaderText = "AMOUNT (per month)"
        penalityAmt.MinimumWidth = 6
        penalityAmt.Name = "penalityAmt"
        penalityAmt.ReadOnly = True
        penalityAmt.Width = 125
        ' 
        ' effectiveDate
        ' 
        effectiveDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        effectiveDate.DefaultCellStyle = DataGridViewCellStyle3
        effectiveDate.HeaderText = "EFFECTIVE DATE"
        effectiveDate.MinimumWidth = 6
        effectiveDate.Name = "effectiveDate"
        effectiveDate.ReadOnly = True
        effectiveDate.Width = 134
        ' 
        ' penalityDesc
        ' 
        penalityDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        penalityDesc.DefaultCellStyle = DataGridViewCellStyle4
        penalityDesc.HeaderText = "DESCRIPTION"
        penalityDesc.MinimumWidth = 6
        penalityDesc.Name = "penalityDesc"
        penalityDesc.ReadOnly = True
        penalityDesc.Width = 129
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSearch.Location = New Point(1, 579)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(67, 28)
        lblSearch.TabIndex = 6
        lblSearch.Text = "Filter:"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSearch.Location = New Point(68, 576)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 34)
        txtSearch.TabIndex = 5
        ' 
        ' frmPenalityList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 714)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgPenalityList)
        Name = "frmPenalityList"
        Text = "Penality"
        WindowState = FormWindowState.Maximized
        CType(dgPenalityList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgPenalityList As DataGridView
    Friend WithEvents penalityId As DataGridViewTextBoxColumn
    Friend WithEvents penalityAmt As DataGridViewTextBoxColumn
    Friend WithEvents effectiveDate As DataGridViewTextBoxColumn
    Friend WithEvents penalityDesc As DataGridViewTextBoxColumn
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
End Class
