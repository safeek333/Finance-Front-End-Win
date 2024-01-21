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
        dgPaymentList = New DataGridView()
        loanNumber = New DataGridViewTextBoxColumn()
        paymentAmt = New DataGridViewTextBoxColumn()
        paymentDate = New DataGridViewTextBoxColumn()
        paymentType = New DataGridViewTextBoxColumn()
        paymentStatus = New DataGridViewTextBoxColumn()
        paymentDesc = New DataGridViewTextBoxColumn()
        CType(dgPaymentList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgPaymentList
        ' 
        dgPaymentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgPaymentList.Columns.AddRange(New DataGridViewColumn() {loanNumber, paymentAmt, paymentDate, paymentType, paymentStatus, paymentDesc})
        dgPaymentList.Dock = DockStyle.Fill
        dgPaymentList.Location = New Point(0, 0)
        dgPaymentList.Name = "dgPaymentList"
        dgPaymentList.RowHeadersWidth = 51
        dgPaymentList.RowTemplate.Height = 29
        dgPaymentList.Size = New Size(800, 450)
        dgPaymentList.TabIndex = 0
        ' 
        ' loanNumber
        ' 
        loanNumber.HeaderText = "LOAN NUM"
        loanNumber.MinimumWidth = 6
        loanNumber.Name = "loanNumber"
        loanNumber.ReadOnly = True
        loanNumber.Width = 125
        ' 
        ' paymentAmt
        ' 
        paymentAmt.HeaderText = "PAYMENT AMT"
        paymentAmt.MinimumWidth = 6
        paymentAmt.Name = "paymentAmt"
        paymentAmt.ReadOnly = True
        paymentAmt.Width = 125
        ' 
        ' paymentDate
        ' 
        paymentDate.HeaderText = "PAYMENT DATE"
        paymentDate.MinimumWidth = 6
        paymentDate.Name = "paymentDate"
        paymentDate.ReadOnly = True
        paymentDate.Width = 125
        ' 
        ' paymentType
        ' 
        paymentType.HeaderText = "PAYMENT TYPE"
        paymentType.MinimumWidth = 6
        paymentType.Name = "paymentType"
        paymentType.ReadOnly = True
        paymentType.Width = 125
        ' 
        ' paymentStatus
        ' 
        paymentStatus.HeaderText = "PAYMENT STATUS"
        paymentStatus.MinimumWidth = 6
        paymentStatus.Name = "paymentStatus"
        paymentStatus.ReadOnly = True
        paymentStatus.Width = 125
        ' 
        ' paymentDesc
        ' 
        paymentDesc.HeaderText = "PAYMENT DESC"
        paymentDesc.MinimumWidth = 6
        paymentDesc.Name = "paymentDesc"
        paymentDesc.ReadOnly = True
        paymentDesc.Width = 125
        ' 
        ' frmPaymentList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgPaymentList)
        Name = "frmPaymentList"
        Text = "frmPaymentList"
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
End Class
