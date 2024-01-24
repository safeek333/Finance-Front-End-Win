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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        emiPaymentRcvd = New DataGridViewTextBoxColumn()
        emiPaidAmt = New DataGridViewTextBoxColumn()
        emiBalance = New DataGridViewTextBoxColumn()
        emiPendingDays = New DataGridViewTextBoxColumn()
        emiPenalityAmt = New DataGridViewTextBoxColumn()
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
        lblTitle.UseWaitCursor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(81, 156)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 20)
        Label1.TabIndex = 1
        Label1.Text = "Label1"
        Label1.UseWaitCursor = True
        ' 
        ' dgCollectEmiSingleCust
        ' 
        dgCollectEmiSingleCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCollectEmiSingleCust.Columns.AddRange(New DataGridViewColumn() {emiId, emiAmt, emiDate, finCharge, dicountOnFinCharge, emiStatus, emiPaidDate, emiPaymentRcvd, emiPaidAmt, emiBalance, emiPendingDays, emiPenalityAmt})
        dgCollectEmiSingleCust.Dock = DockStyle.Fill
        dgCollectEmiSingleCust.Location = New Point(0, 0)
        dgCollectEmiSingleCust.Name = "dgCollectEmiSingleCust"
        dgCollectEmiSingleCust.RowHeadersWidth = 51
        dgCollectEmiSingleCust.RowTemplate.Height = 29
        dgCollectEmiSingleCust.Size = New Size(1413, 450)
        dgCollectEmiSingleCust.TabIndex = 2
        dgCollectEmiSingleCust.UseWaitCursor = True
        ' 
        ' emiId
        ' 
        emiId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiId.DefaultCellStyle = DataGridViewCellStyle1
        emiId.HeaderText = "EMI ID"
        emiId.MinimumWidth = 6
        emiId.Name = "emiId"
        emiId.ReadOnly = True
        emiId.Width = 63
        ' 
        ' emiAmt
        ' 
        emiAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiAmt.DefaultCellStyle = DataGridViewCellStyle2
        emiAmt.HeaderText = "EMI AMOUNT"
        emiAmt.MinimumWidth = 6
        emiAmt.Name = "emiAmt"
        emiAmt.ReadOnly = True
        emiAmt.Width = 119
        ' 
        ' emiDate
        ' 
        emiDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiDate.DefaultCellStyle = DataGridViewCellStyle3
        emiDate.HeaderText = "EMI DATE"
        emiDate.MinimumWidth = 6
        emiDate.Name = "emiDate"
        emiDate.ReadOnly = True
        emiDate.Width = 95
        ' 
        ' finCharge
        ' 
        finCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        finCharge.DefaultCellStyle = DataGridViewCellStyle4
        finCharge.HeaderText = "FIN. CHARGES"
        finCharge.MinimumWidth = 6
        finCharge.Name = "finCharge"
        finCharge.ReadOnly = True
        finCharge.Width = 121
        ' 
        ' dicountOnFinCharge
        ' 
        dicountOnFinCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        dicountOnFinCharge.DefaultCellStyle = DataGridViewCellStyle5
        dicountOnFinCharge.HeaderText = "DISCOUNT AMT"
        dicountOnFinCharge.MinimumWidth = 6
        dicountOnFinCharge.Name = "dicountOnFinCharge"
        dicountOnFinCharge.ReadOnly = True
        dicountOnFinCharge.Width = 133
        ' 
        ' emiStatus
        ' 
        emiStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiStatus.DefaultCellStyle = DataGridViewCellStyle6
        emiStatus.HeaderText = "EMI STATUS"
        emiStatus.MinimumWidth = 6
        emiStatus.Name = "emiStatus"
        emiStatus.ReadOnly = True
        emiStatus.Width = 108
        ' 
        ' emiPaidDate
        ' 
        emiPaidDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidDate.DefaultCellStyle = DataGridViewCellStyle7
        emiPaidDate.HeaderText = "LAST PAYMENT DATE"
        emiPaidDate.MinimumWidth = 6
        emiPaidDate.Name = "emiPaidDate"
        emiPaidDate.ReadOnly = True
        emiPaidDate.Width = 164
        ' 
        ' emiPaymentRcvd
        ' 
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaymentRcvd.DefaultCellStyle = DataGridViewCellStyle8
        emiPaymentRcvd.HeaderText = "PAYMENT RCVD"
        emiPaymentRcvd.MinimumWidth = 6
        emiPaymentRcvd.Name = "emiPaymentRcvd"
        emiPaymentRcvd.ReadOnly = True
        emiPaymentRcvd.Width = 125
        ' 
        ' emiPaidAmt
        ' 
        emiPaidAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidAmt.DefaultCellStyle = DataGridViewCellStyle9
        emiPaidAmt.HeaderText = "EMI PAID AMT"
        emiPaidAmt.MinimumWidth = 6
        emiPaidAmt.Name = "emiPaidAmt"
        emiPaidAmt.ReadOnly = True
        emiPaidAmt.Width = 123
        ' 
        ' emiBalance
        ' 
        emiBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle10.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiBalance.DefaultCellStyle = DataGridViewCellStyle10
        emiBalance.HeaderText = "EMI BALANCE"
        emiBalance.MinimumWidth = 6
        emiBalance.Name = "emiBalance"
        emiBalance.ReadOnly = True
        emiBalance.Width = 120
        ' 
        ' emiPendingDays
        ' 
        emiPendingDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle11.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPendingDays.DefaultCellStyle = DataGridViewCellStyle11
        emiPendingDays.HeaderText = "PENDING DAYS"
        emiPendingDays.MinimumWidth = 6
        emiPendingDays.Name = "emiPendingDays"
        emiPendingDays.ReadOnly = True
        emiPendingDays.Width = 129
        ' 
        ' emiPenalityAmt
        ' 
        emiPenalityAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle12.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPenalityAmt.DefaultCellStyle = DataGridViewCellStyle12
        emiPenalityAmt.HeaderText = "PENALITY AMT"
        emiPenalityAmt.MinimumWidth = 6
        emiPenalityAmt.Name = "emiPenalityAmt"
        emiPenalityAmt.ReadOnly = True
        emiPenalityAmt.Width = 126
        ' 
        ' frmCollectEmiSingleCust
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1413, 450)
        Controls.Add(dgCollectEmiSingleCust)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmCollectEmiSingleCust"
        Text = "Loan Emi Details"
        UseWaitCursor = True
        WindowState = FormWindowState.Maximized
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
    Friend WithEvents emiPaymentRcvd As DataGridViewTextBoxColumn
    Friend WithEvents emiPaidAmt As DataGridViewTextBoxColumn
    Friend WithEvents emiBalance As DataGridViewTextBoxColumn
    Friend WithEvents emiPendingDays As DataGridViewTextBoxColumn
    Friend WithEvents emiPenalityAmt As DataGridViewTextBoxColumn
End Class
