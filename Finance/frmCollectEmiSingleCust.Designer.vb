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
        Dim DataGridViewCellStyle29 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle30 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle31 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle32 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle33 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle34 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle35 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle36 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle37 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle41 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        Label1 = New Label()
        dgCollectEmiSingleCust = New DataGridView()
        Button1 = New Button()
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
        paidAfc = New DataGridViewTextBoxColumn()
        CType(dgCollectEmiSingleCust, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitle.ForeColor = Color.Teal
        lblTitle.Location = New Point(0, 9)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(237, 38)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Loan EMI Details"
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
        DataGridViewCellStyle29.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle29.BackColor = Color.Teal
        DataGridViewCellStyle29.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle29.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle29.SelectionBackColor = Color.MediumTurquoise
        DataGridViewCellStyle29.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle29.WrapMode = DataGridViewTriState.True
        dgCollectEmiSingleCust.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle29
        dgCollectEmiSingleCust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCollectEmiSingleCust.Columns.AddRange(New DataGridViewColumn() {emiId, emiAmt, emiDate, finCharge, dicountOnFinCharge, emiStatus, emiPaidDate, emiPaymentRcvd, emiPaidAmt, emiBalance, emiPendingDays, emiPenalityAmt, paidAfc})
        dgCollectEmiSingleCust.Dock = DockStyle.Bottom
        dgCollectEmiSingleCust.GridColor = SystemColors.ButtonShadow
        dgCollectEmiSingleCust.Location = New Point(0, 164)
        dgCollectEmiSingleCust.Name = "dgCollectEmiSingleCust"
        dgCollectEmiSingleCust.RowHeadersWidth = 51
        dgCollectEmiSingleCust.RowTemplate.Height = 29
        dgCollectEmiSingleCust.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgCollectEmiSingleCust.Size = New Size(1867, 851)
        dgCollectEmiSingleCust.StandardTab = True
        dgCollectEmiSingleCust.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Teal
        Button1.Location = New Point(1357, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(163, 41)
        Button1.TabIndex = 9
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' emiId
        ' 
        emiId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle30.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiId.DefaultCellStyle = DataGridViewCellStyle30
        emiId.HeaderText = "EMI ID"
        emiId.MinimumWidth = 6
        emiId.Name = "emiId"
        emiId.ReadOnly = True
        emiId.Width = 85
        ' 
        ' emiAmt
        ' 
        emiAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle31.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiAmt.DefaultCellStyle = DataGridViewCellStyle31
        emiAmt.HeaderText = "EMI AMOUNT"
        emiAmt.MinimumWidth = 6
        emiAmt.Name = "emiAmt"
        emiAmt.ReadOnly = True
        emiAmt.Width = 137
        ' 
        ' emiDate
        ' 
        emiDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle32.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiDate.DefaultCellStyle = DataGridViewCellStyle32
        emiDate.HeaderText = "EMI DATE"
        emiDate.MinimumWidth = 6
        emiDate.Name = "emiDate"
        emiDate.ReadOnly = True
        emiDate.Width = 107
        ' 
        ' finCharge
        ' 
        finCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle33.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        finCharge.DefaultCellStyle = DataGridViewCellStyle33
        finCharge.HeaderText = "FIN. CHARGES"
        finCharge.MinimumWidth = 6
        finCharge.Name = "finCharge"
        finCharge.ReadOnly = True
        finCharge.Width = 139
        ' 
        ' dicountOnFinCharge
        ' 
        dicountOnFinCharge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle34.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        dicountOnFinCharge.DefaultCellStyle = DataGridViewCellStyle34
        dicountOnFinCharge.HeaderText = "DISCOUNT AMT"
        dicountOnFinCharge.MinimumWidth = 6
        dicountOnFinCharge.Name = "dicountOnFinCharge"
        dicountOnFinCharge.ReadOnly = True
        dicountOnFinCharge.Width = 139
        ' 
        ' emiStatus
        ' 
        emiStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle35.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiStatus.DefaultCellStyle = DataGridViewCellStyle35
        emiStatus.HeaderText = "EMI STATUS"
        emiStatus.MinimumWidth = 6
        emiStatus.Name = "emiStatus"
        emiStatus.ReadOnly = True
        emiStatus.Width = 113
        ' 
        ' emiPaidDate
        ' 
        emiPaidDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle36.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidDate.DefaultCellStyle = DataGridViewCellStyle36
        emiPaidDate.HeaderText = "LAST PAYMENT DATE"
        emiPaidDate.MinimumWidth = 6
        emiPaidDate.Name = "emiPaidDate"
        emiPaidDate.ReadOnly = True
        emiPaidDate.Width = 173
        ' 
        ' emiPaymentRcvd
        ' 
        DataGridViewCellStyle37.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaymentRcvd.DefaultCellStyle = DataGridViewCellStyle37
        emiPaymentRcvd.HeaderText = "PAYMENT RCVD"
        emiPaymentRcvd.MinimumWidth = 6
        emiPaymentRcvd.Name = "emiPaymentRcvd"
        emiPaymentRcvd.ReadOnly = True
        emiPaymentRcvd.Width = 125
        ' 
        ' emiPaidAmt
        ' 
        emiPaidAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle38.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPaidAmt.DefaultCellStyle = DataGridViewCellStyle38
        emiPaidAmt.HeaderText = "EMI PAID AMT"
        emiPaidAmt.MinimumWidth = 6
        emiPaidAmt.Name = "emiPaidAmt"
        emiPaidAmt.ReadOnly = True
        emiPaidAmt.Width = 130
        ' 
        ' emiBalance
        ' 
        emiBalance.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle39.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiBalance.DefaultCellStyle = DataGridViewCellStyle39
        emiBalance.HeaderText = "EMI BALANCE"
        emiBalance.MinimumWidth = 6
        emiBalance.Name = "emiBalance"
        emiBalance.ReadOnly = True
        emiBalance.Width = 127
        ' 
        ' emiPendingDays
        ' 
        emiPendingDays.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle40.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPendingDays.DefaultCellStyle = DataGridViewCellStyle40
        emiPendingDays.HeaderText = "PENDING DAYS"
        emiPendingDays.MinimumWidth = 6
        emiPendingDays.Name = "emiPendingDays"
        emiPendingDays.ReadOnly = True
        emiPendingDays.Width = 136
        ' 
        ' emiPenalityAmt
        ' 
        emiPenalityAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle41.Font = New Font("Microsoft Sans Serif", 12.2F, FontStyle.Bold, GraphicsUnit.Point)
        emiPenalityAmt.DefaultCellStyle = DataGridViewCellStyle41
        emiPenalityAmt.HeaderText = "AFC AMT"
        emiPenalityAmt.MinimumWidth = 6
        emiPenalityAmt.Name = "emiPenalityAmt"
        emiPenalityAmt.ReadOnly = True
        emiPenalityAmt.Width = 96
        ' 
        ' paidAfc
        ' 
        DataGridViewCellStyle42.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paidAfc.DefaultCellStyle = DataGridViewCellStyle42
        paidAfc.HeaderText = "AFC PAID"
        paidAfc.MinimumWidth = 6
        paidAfc.Name = "paidAfc"
        paidAfc.Width = 125
        ' 
        ' frmCollectEmiSingleCust
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1867, 1015)
        Controls.Add(Button1)
        Controls.Add(dgCollectEmiSingleCust)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Name = "frmCollectEmiSingleCust"
        Text = "Loan Emi Details"
        WindowState = FormWindowState.Maximized
        CType(dgCollectEmiSingleCust, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgCollectEmiSingleCust As DataGridView
    Friend WithEvents Button1 As Button
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
    Friend WithEvents paidAfc As DataGridViewTextBoxColumn
End Class
