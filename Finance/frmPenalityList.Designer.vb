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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgPenalityList = New DataGridView()
        penalityId = New DataGridViewTextBoxColumn()
        penalityAmt = New DataGridViewTextBoxColumn()
        effectiveDate = New DataGridViewTextBoxColumn()
        penalityDesc = New DataGridViewTextBoxColumn()
        lblSearch = New Label()
        txtSearch = New TextBox()
        Button1 = New Button()
        PrintDialog1 = New PrintDialog()
        PrintDocument1 = New Printing.PrintDocument()
        btnPrint = New Button()
        Label1 = New Label()
        CType(dgPenalityList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPenalityList
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Teal
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgPenalityList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgPenalityList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPenalityList.Columns.AddRange(New DataGridViewColumn() {penalityId, penalityAmt, effectiveDate, penalityDesc})
        dgPenalityList.Location = New Point(1, 107)
        dgPenalityList.Name = "dgPenalityList"
        dgPenalityList.RowHeadersWidth = 51
        dgPenalityList.RowTemplate.Height = 29
        dgPenalityList.Size = New Size(974, 850)
        dgPenalityList.TabIndex = 0
        ' 
        ' penalityId
        ' 
        penalityId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        penalityId.DefaultCellStyle = DataGridViewCellStyle2
        penalityId.HeaderText = "ID"
        penalityId.MinimumWidth = 6
        penalityId.Name = "penalityId"
        penalityId.ReadOnly = True
        penalityId.Width = 54
        ' 
        ' penalityAmt
        ' 
        penalityAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        penalityAmt.DefaultCellStyle = DataGridViewCellStyle3
        penalityAmt.HeaderText = "AMOUNT (per month)"
        penalityAmt.MinimumWidth = 6
        penalityAmt.Name = "penalityAmt"
        penalityAmt.ReadOnly = True
        penalityAmt.Width = 131
        ' 
        ' effectiveDate
        ' 
        effectiveDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        effectiveDate.DefaultCellStyle = DataGridViewCellStyle4
        effectiveDate.HeaderText = "EFFECTIVE DATE"
        effectiveDate.MinimumWidth = 6
        effectiveDate.Name = "effectiveDate"
        effectiveDate.ReadOnly = True
        effectiveDate.Width = 140
        ' 
        ' penalityDesc
        ' 
        penalityDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        penalityDesc.DefaultCellStyle = DataGridViewCellStyle5
        penalityDesc.HeaderText = "DESCRIPTION"
        penalityDesc.MinimumWidth = 6
        penalityDesc.Name = "penalityDesc"
        penalityDesc.ReadOnly = True
        penalityDesc.Width = 135
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        lblSearch.ForeColor = Color.Teal
        lblSearch.Location = New Point(623, 73)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(67, 28)
        lblSearch.TabIndex = 6
        lblSearch.Text = "Filter:"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtSearch.Location = New Point(703, 67)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 34)
        txtSearch.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Teal
        Button1.Location = New Point(623, 17)
        Button1.Name = "Button1"
        Button1.Size = New Size(173, 41)
        Button1.TabIndex = 7
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.Document = PrintDocument1
        PrintDialog1.UseEXDialog = True
        ' 
        ' btnPrint
        ' 
        btnPrint.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        btnPrint.ForeColor = Color.Teal
        btnPrint.Location = New Point(802, 17)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(173, 41)
        btnPrint.TabIndex = 8
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(1, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(509, 38)
        Label1.TabIndex = 9
        Label1.Text = "Additional Finanace Charges (Master)"
        ' 
        ' frmPenalityList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(987, 755)
        Controls.Add(Label1)
        Controls.Add(btnPrint)
        Controls.Add(Button1)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgPenalityList)
        Name = "frmPenalityList"
        Text = "Additional Finance Charges"
        WindowState = FormWindowState.Maximized
        CType(dgPenalityList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgPenalityList As DataGridView
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents penalityId As DataGridViewTextBoxColumn
    Friend WithEvents penalityAmt As DataGridViewTextBoxColumn
    Friend WithEvents effectiveDate As DataGridViewTextBoxColumn
    Friend WithEvents penalityDesc As DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Label1 As Label
End Class
