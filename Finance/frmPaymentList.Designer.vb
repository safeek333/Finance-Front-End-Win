<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentList
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
        dgPaymentList = New DataGridView()
        Button1 = New Button()
        Label1 = New Label()
        loanNumber = New DataGridViewTextBoxColumn()
        paymentAmt = New DataGridViewTextBoxColumn()
        txtAchAmt = New DataGridViewTextBoxColumn()
        paymentDate = New DataGridViewTextBoxColumn()
        paymentType = New DataGridViewTextBoxColumn()
        paymentStatus = New DataGridViewTextBoxColumn()
        paymentDesc = New DataGridViewTextBoxColumn()
        CType(dgPaymentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPaymentList
        ' 
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Teal
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        dgPaymentList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        dgPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentList.Columns.AddRange(New DataGridViewColumn() {loanNumber, paymentAmt, txtAchAmt, paymentDate, paymentType, paymentStatus, paymentDesc})
        dgPaymentList.Location = New Point(0, 51)
        dgPaymentList.Name = "dgPaymentList"
        dgPaymentList.RowHeadersWidth = 51
        dgPaymentList.RowTemplate.Height = 29
        dgPaymentList.Size = New Size(1354, 850)
        dgPaymentList.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.ForeColor = Color.Teal
        Button1.Location = New Point(1184, 6)
        Button1.Name = "Button1"
        Button1.Size = New Size(170, 41)
        Button1.TabIndex = 8
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = Color.Teal
        Label1.Location = New Point(0, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(215, 38)
        Label1.TabIndex = 9
        Label1.Text = "Loan Payments"
        ' 
        ' loanNumber
        ' 
        loanNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        loanNumber.DefaultCellStyle = DataGridViewCellStyle2
        loanNumber.HeaderText = "LOAN NUM"
        loanNumber.MinimumWidth = 6
        loanNumber.Name = "loanNumber"
        loanNumber.ReadOnly = True
        loanNumber.Width = 121
        ' 
        ' paymentAmt
        ' 
        paymentAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paymentAmt.DefaultCellStyle = DataGridViewCellStyle3
        paymentAmt.HeaderText = "PAYMENT AMT"
        paymentAmt.MinimumWidth = 6
        paymentAmt.Name = "paymentAmt"
        paymentAmt.ReadOnly = True
        paymentAmt.Width = 146
        ' 
        ' txtAchAmt
        ' 
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtAchAmt.DefaultCellStyle = DataGridViewCellStyle4
        txtAchAmt.HeaderText = "PAYMENT ACH AMT"
        txtAchAmt.MinimumWidth = 6
        txtAchAmt.Name = "txtAchAmt"
        txtAchAmt.Width = 125
        ' 
        ' paymentDate
        ' 
        paymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paymentDate.DefaultCellStyle = DataGridViewCellStyle5
        paymentDate.HeaderText = "PAYMENT DATE"
        paymentDate.MinimumWidth = 6
        paymentDate.Name = "paymentDate"
        paymentDate.ReadOnly = True
        paymentDate.Width = 137
        ' 
        ' paymentType
        ' 
        paymentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paymentType.DefaultCellStyle = DataGridViewCellStyle6
        paymentType.HeaderText = "PAYMENT TYPE"
        paymentType.MinimumWidth = 6
        paymentType.Name = "paymentType"
        paymentType.ReadOnly = True
        paymentType.Width = 135
        ' 
        ' paymentStatus
        ' 
        paymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paymentStatus.DefaultCellStyle = DataGridViewCellStyle7
        paymentStatus.HeaderText = "PAYMENT STATUS"
        paymentStatus.MinimumWidth = 6
        paymentStatus.Name = "paymentStatus"
        paymentStatus.ReadOnly = True
        paymentStatus.Width = 152
        ' 
        ' paymentDesc
        ' 
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point)
        paymentDesc.DefaultCellStyle = DataGridViewCellStyle8
        paymentDesc.HeaderText = "PAYMENT DESC"
        paymentDesc.MinimumWidth = 6
        paymentDesc.Name = "paymentDesc"
        paymentDesc.ReadOnly = True
        paymentDesc.Width = 300
        ' 
        ' frmPaymentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1364, 676)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(dgPaymentList)
        Name = "frmPaymentList"
        Text = "Payments"
        WindowState = FormWindowState.Maximized
        CType(dgPaymentList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgPaymentList As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents loanNumber As DataGridViewTextBoxColumn
    Friend WithEvents paymentAmt As DataGridViewTextBoxColumn
    Friend WithEvents txtAchAmt As DataGridViewTextBoxColumn
    Friend WithEvents paymentDate As DataGridViewTextBoxColumn
    Friend WithEvents paymentType As DataGridViewTextBoxColumn
    Friend WithEvents paymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents paymentDesc As DataGridViewTextBoxColumn
End Class
