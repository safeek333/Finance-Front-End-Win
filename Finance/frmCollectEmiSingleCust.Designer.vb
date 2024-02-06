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
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        Button1 = New Button()
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
        dgCollectEmiSingleCust.Dock = DockStyle.Top
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
        DataGridViewCellStyle13.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiId.DefaultCellStyle = DataGridViewCellStyle13
        emiId.HeaderText = "EMI ID"
        emiId.MinimumWidth = 6
        emiId.Name = "emiId"
        emiId.ReadOnly = True
        emiId.Width = 63
        ' 
        ' emiAmt
        ' 
        emiAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle14.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiAmt.DefaultCellStyle = DataGridViewCellStyle14
        emiAmt.HeaderText = "EMI AMOUNT"
        emiAmt.MinimumWidth = 6
        emiAmt.Name = "emiAmt"
        emiAmt.ReadOnly = True
        emiAmt.Width = 119
        ' 
        ' emiDate
        ' 
        emiDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle15.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiDate.DefaultCellStyle = DataGridViewCellStyle15
        emiDate.HeaderText = "EMI DATE"
        emiDate.MinimumWidth = 6
        emiDate.Name = "emiDate"
        emiDate.ReadOnly = True
        emiDate.Width = 95
        ' 
        ' finCharge
        ' 
        finCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle16.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        finCharge.DefaultCellStyle = DataGridViewCellStyle16
        finCharge.HeaderText = "FIN. CHARGES"
        finCharge.MinimumWidth = 6
        finCharge.Name = "finCharge"
        finCharge.ReadOnly = True
        finCharge.Width = 121
        ' 
        ' dicountOnFinCharge
        ' 
        dicountOnFinCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle17.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        dicountOnFinCharge.DefaultCellStyle = DataGridViewCellStyle17
        dicountOnFinCharge.HeaderText = "DISCOUNT AMT"
        dicountOnFinCharge.MinimumWidth = 6
        dicountOnFinCharge.Name = "dicountOnFinCharge"
        dicountOnFinCharge.ReadOnly = True
        dicountOnFinCharge.Width = 133
        ' 
        ' emiStatus
        ' 
        emiStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle18.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiStatus.DefaultCellStyle = DataGridViewCellStyle18
        emiStatus.HeaderText = "EMI STATUS"
        emiStatus.MinimumWidth = 6
        emiStatus.Name = "emiStatus"
        emiStatus.ReadOnly = True
        emiStatus.Width = 108
        ' 
        ' emiPaidDate
        ' 
        emiPaidDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle19.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidDate.DefaultCellStyle = DataGridViewCellStyle19
        emiPaidDate.HeaderText = "LAST PAYMENT DATE"
        emiPaidDate.MinimumWidth = 6
        emiPaidDate.Name = "emiPaidDate"
        emiPaidDate.ReadOnly = True
        emiPaidDate.Width = 164
        ' 
        ' emiPaymentRcvd
        ' 
        DataGridViewCellStyle20.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaymentRcvd.DefaultCellStyle = DataGridViewCellStyle20
        emiPaymentRcvd.HeaderText = "PAYMENT RCVD"
        emiPaymentRcvd.MinimumWidth = 6
        emiPaymentRcvd.Name = "emiPaymentRcvd"
        emiPaymentRcvd.ReadOnly = True
        emiPaymentRcvd.Width = 125
        ' 
        ' emiPaidAmt
        ' 
        emiPaidAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle21.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidAmt.DefaultCellStyle = DataGridViewCellStyle21
        emiPaidAmt.HeaderText = "EMI PAID AMT"
        emiPaidAmt.MinimumWidth = 6
        emiPaidAmt.Name = "emiPaidAmt"
        emiPaidAmt.ReadOnly = True
        emiPaidAmt.Width = 123
        ' 
        ' emiBalance
        ' 
        emiBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle22.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiBalance.DefaultCellStyle = DataGridViewCellStyle22
        emiBalance.HeaderText = "EMI BALANCE"
        emiBalance.MinimumWidth = 6
        emiBalance.Name = "emiBalance"
        emiBalance.ReadOnly = True
        emiBalance.Width = 120
        ' 
        ' emiPendingDays
        ' 
        emiPendingDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle23.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPendingDays.DefaultCellStyle = DataGridViewCellStyle23
        emiPendingDays.HeaderText = "PENDING DAYS"
        emiPendingDays.MinimumWidth = 6
        emiPendingDays.Name = "emiPendingDays"
        emiPendingDays.ReadOnly = True
        emiPendingDays.Width = 129
        ' 
        ' emiPenalityAmt
        ' 
        emiPenalityAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle24.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPenalityAmt.DefaultCellStyle = DataGridViewCellStyle24
        emiPenalityAmt.HeaderText = "PENALITY AMT"
        emiPenalityAmt.MinimumWidth = 6
        emiPenalityAmt.Name = "emiPenalityAmt"
        emiPenalityAmt.ReadOnly = True
        emiPenalityAmt.Width = 126
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 456)
        Button1.Name = "Button1"
        Button1.Size = New Size(272, 41)
        Button1.TabIndex = 9
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmCollectEmiSingleCust
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1413, 572)
        Controls.Add(Button1)
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
    Friend WithEvents Button1 As Button
End Class
