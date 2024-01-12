<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCollectEmiSingleCust
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
        lblTitle = New Label()
        Label1 = New Label()
        dgCollectEmiSingleCust = New DataGridView()
        emiId = New DataGridViewTextBoxColumn()
        emiAmt = New DataGridViewTextBoxColumn()
        emiDate = New DataGridViewTextBoxColumn()
        finCharge = New DataGridViewTextBoxColumn()
        dicountOnFinCharge = New DataGridViewTextBoxColumn()
        emiStatus = New DataGridViewTextBoxColumn()
        emiPaidDate = New DataGridViewTextBoxColumn()
        emiPaidAmt = New DataGridViewTextBoxColumn()
        emiBalance = New DataGridViewTextBoxColumn()
        CType(dgCollectEmiSingleCust, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.Location = New Point(12, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(407, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Collect EMI - Single Customer"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        ' 
        ' dgCollectEmiSingleCust
        ' 
        dgCollectEmiSingleCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCollectEmiSingleCust.Columns.AddRange(New DataGridViewColumn() {emiId, emiAmt, emiDate, finCharge, dicountOnFinCharge, emiStatus, emiPaidDate, emiPaidAmt, emiBalance})
        dgCollectEmiSingleCust.Dock = DockStyle.Fill
        dgCollectEmiSingleCust.Location = New Point(0, 0)
        dgCollectEmiSingleCust.Name = "dgCollectEmiSingleCust"
        dgCollectEmiSingleCust.RowHeadersWidth = 51
        dgCollectEmiSingleCust.RowTemplate.Height = 29
        dgCollectEmiSingleCust.Size = New Size(1413, 450)
        dgCollectEmiSingleCust.TabIndex = 2
        ' 
        ' emiId
        ' 
        emiId.HeaderText = "EMI ID"
        emiId.MinimumWidth = 6
        emiId.Name = "emiId"
        emiId.Width = 125
        ' 
        ' emiAmt
        ' 
        emiAmt.HeaderText = "EMI AMOUNT"
        emiAmt.MinimumWidth = 6
        emiAmt.Name = "emiAmt"
        emiAmt.Width = 125
        ' 
        ' emiDate
        ' 
        emiDate.HeaderText = "EMI DATE"
        emiDate.MinimumWidth = 6
        emiDate.Name = "emiDate"
        emiDate.Width = 125
        ' 
        ' finCharge
        ' 
        finCharge.HeaderText = "FIN. CHARGES"
        finCharge.MinimumWidth = 6
        finCharge.Name = "finCharge"
        finCharge.Width = 125
        ' 
        ' dicountOnFinCharge
        ' 
        dicountOnFinCharge.HeaderText = "DISCOUNT AMT"
        dicountOnFinCharge.MinimumWidth = 6
        dicountOnFinCharge.Name = "dicountOnFinCharge"
        dicountOnFinCharge.Width = 125
        ' 
        ' emiStatus
        ' 
        emiStatus.HeaderText = "EMI STATUS"
        emiStatus.MinimumWidth = 6
        emiStatus.Name = "emiStatus"
        emiStatus.Width = 125
        ' 
        ' emiPaidDate
        ' 
        emiPaidDate.HeaderText = "EMI PAID DATE"
        emiPaidDate.MinimumWidth = 6
        emiPaidDate.Name = "emiPaidDate"
        emiPaidDate.Width = 125
        ' 
        ' emiPaidAmt
        ' 
        emiPaidAmt.HeaderText = "EMI PAID AMT"
        emiPaidAmt.MinimumWidth = 6
        emiPaidAmt.Name = "emiPaidAmt"
        emiPaidAmt.Width = 125
        ' 
        ' emiBalance
        ' 
        emiBalance.HeaderText = "EMI BALANCE"
        emiBalance.MinimumWidth = 6
        emiBalance.Name = "emiBalance"
        emiBalance.Width = 125
        ' 
        ' frmCollectEmiSingleCust
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1413, 450)
        Controls.Add(dgCollectEmiSingleCust)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmCollectEmiSingleCust"
        Text = "frmCollectEmiSingleCust"
        CType(dgCollectEmiSingleCust, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCollectEmiSingleCust As DataGridView
    Friend WithEvents emiId As DataGridViewTextBoxColumn
    Friend WithEvents emiAmt As DataGridViewTextBoxColumn
    Friend WithEvents emiDate As DataGridViewTextBoxColumn
    Friend WithEvents finCharge As DataGridViewTextBoxColumn
    Friend WithEvents dicountOnFinCharge As DataGridViewTextBoxColumn
    Friend WithEvents emiStatus As DataGridViewTextBoxColumn
    Friend WithEvents emiPaidDate As DataGridViewTextBoxColumn
    Friend WithEvents emiPaidAmt As DataGridViewTextBoxColumn
    Friend WithEvents emiBalance As DataGridViewTextBoxColumn
End Class
