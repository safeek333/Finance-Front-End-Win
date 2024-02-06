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
        dgPaymentList = New DataGridView()
        loanNumber = New DataGridViewTextBoxColumn()
        paymentAmt = New DataGridViewTextBoxColumn()
        paymentDate = New DataGridViewTextBoxColumn()
        paymentType = New DataGridViewTextBoxColumn()
        paymentStatus = New DataGridViewTextBoxColumn()
        paymentDesc = New DataGridViewTextBoxColumn()
        Button1 = New Button()
        CType(dgPaymentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPaymentList
        ' 
        dgPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentList.Columns.AddRange(New DataGridViewColumn() {loanNumber, paymentAmt, paymentDate, paymentType, paymentStatus, paymentDesc})
        dgPaymentList.Dock = DockStyle.Top
        dgPaymentList.Location = New Point(0, 0)
        dgPaymentList.Name = "dgPaymentList"
        dgPaymentList.RowHeadersWidth = 51
        dgPaymentList.RowTemplate.Height = 29
        dgPaymentList.Size = New Size(973, 515)
        dgPaymentList.TabIndex = 0
        ' 
        ' loanNumber
        ' 
        loanNumber.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        loanNumber.DefaultCellStyle = DataGridViewCellStyle1
        loanNumber.HeaderText = "LOAN NUM"
        loanNumber.MinimumWidth = 6
        loanNumber.Name = "loanNumber"
        loanNumber.ReadOnly = True
        loanNumber.Width = 105
        ' 
        ' paymentAmt
        ' 
        paymentAmt.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        paymentAmt.DefaultCellStyle = DataGridViewCellStyle2
        paymentAmt.HeaderText = "PAYMENT AMT"
        paymentAmt.MinimumWidth = 6
        paymentAmt.Name = "paymentAmt"
        paymentAmt.ReadOnly = True
        paymentAmt.Width = 126
        ' 
        ' paymentDate
        ' 
        paymentDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        paymentDate.DefaultCellStyle = DataGridViewCellStyle3
        paymentDate.HeaderText = "PAYMENT DATE"
        paymentDate.MinimumWidth = 6
        paymentDate.Name = "paymentDate"
        paymentDate.ReadOnly = True
        paymentDate.Width = 130
        ' 
        ' paymentType
        ' 
        paymentType.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        paymentType.DefaultCellStyle = DataGridViewCellStyle4
        paymentType.HeaderText = "PAYMENT TYPE"
        paymentType.MinimumWidth = 6
        paymentType.Name = "paymentType"
        paymentType.ReadOnly = True
        paymentType.Width = 127
        ' 
        ' paymentStatus
        ' 
        paymentStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        paymentStatus.DefaultCellStyle = DataGridViewCellStyle5
        paymentStatus.HeaderText = "PAYMENT STATUS"
        paymentStatus.MinimumWidth = 6
        paymentStatus.Name = "paymentStatus"
        paymentStatus.ReadOnly = True
        paymentStatus.Width = 143
        ' 
        ' paymentDesc
        ' 
        paymentDesc.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        paymentDesc.DefaultCellStyle = DataGridViewCellStyle6
        paymentDesc.HeaderText = "PAYMENT DESC"
        paymentDesc.MinimumWidth = 6
        paymentDesc.Name = "paymentDesc"
        paymentDesc.ReadOnly = True
        paymentDesc.Width = 130
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(0, 521)
        Button1.Name = "Button1"
        Button1.Size = New Size(272, 41)
        Button1.TabIndex = 8
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' frmPaymentList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(973, 676)
        Controls.Add(Button1)
        Controls.Add(dgPaymentList)
        Name = "frmPaymentList"
        Text = "Payments"
        WindowState = FormWindowState.Maximized
        CType(dgPaymentList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgPaymentList As DataGridView
    Friend WithEvents loanNumber As DataGridViewTextBoxColumn
    Friend WithEvents paymentAmt As DataGridViewTextBoxColumn
    Friend WithEvents paymentDate As DataGridViewTextBoxColumn
    Friend WithEvents paymentType As DataGridViewTextBoxColumn
    Friend WithEvents paymentStatus As DataGridViewTextBoxColumn
    Friend WithEvents paymentDesc As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
