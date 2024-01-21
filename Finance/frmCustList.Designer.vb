<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustList
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
        dgCustList = New DataGridView()
        custId = New DataGridViewTextBoxColumn()
        custType = New DataGridViewTextBoxColumn()
        custName = New DataGridViewTextBoxColumn()
        custNative = New DataGridViewTextBoxColumn()
        custMobileNum = New DataGridViewTextBoxColumn()
        custAddr = New DataGridViewTextBoxColumn()
        custDob = New DataGridViewTextBoxColumn()
        custAge = New DataGridViewTextBoxColumn()
        custStatus = New DataGridViewTextBoxColumn()
        CType(dgCustList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgCustList
        ' 
        dgCustList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCustList.Columns.AddRange(New DataGridViewColumn() {custId, custType, custName, custNative, custMobileNum, custAddr, custDob, custAge, custStatus})
        dgCustList.Dock = DockStyle.Fill
        dgCustList.Location = New Point(0, 0)
        dgCustList.Name = "dgCustList"
        dgCustList.RowHeadersWidth = 51
        dgCustList.RowTemplate.Height = 29
        dgCustList.Size = New Size(800, 450)
        dgCustList.TabIndex = 0
        ' 
        ' custId
        ' 
        custId.HeaderText = "CUST ID"
        custId.MinimumWidth = 6
        custId.Name = "custId"
        custId.ReadOnly = True
        custId.Width = 125
        ' 
        ' custType
        ' 
        custType.HeaderText = "TYPE"
        custType.MinimumWidth = 6
        custType.Name = "custType"
        custType.ReadOnly = True
        custType.Width = 125
        ' 
        ' custName
        ' 
        custName.HeaderText = "NAME"
        custName.MinimumWidth = 6
        custName.Name = "custName"
        custName.ReadOnly = True
        custName.Width = 125
        ' 
        ' custNative
        ' 
        custNative.HeaderText = "NATIVE"
        custNative.MinimumWidth = 6
        custNative.Name = "custNative"
        custNative.ReadOnly = True
        custNative.Width = 125
        ' 
        ' custMobileNum
        ' 
        custMobileNum.HeaderText = "MOBILE NUMBER"
        custMobileNum.MinimumWidth = 6
        custMobileNum.Name = "custMobileNum"
        custMobileNum.ReadOnly = True
        custMobileNum.Width = 125
        ' 
        ' custAddr
        ' 
        custAddr.HeaderText = "ADDRESS"
        custAddr.MinimumWidth = 6
        custAddr.Name = "custAddr"
        custAddr.ReadOnly = True
        custAddr.Width = 125
        ' 
        ' custDob
        ' 
        custDob.HeaderText = "DATE OF BIRTH"
        custDob.MinimumWidth = 6
        custDob.Name = "custDob"
        custDob.ReadOnly = True
        custDob.Width = 125
        ' 
        ' custAge
        ' 
        custAge.HeaderText = "AGE"
        custAge.MinimumWidth = 6
        custAge.Name = "custAge"
        custAge.ReadOnly = True
        custAge.Width = 125
        ' 
        ' custStatus
        ' 
        custStatus.HeaderText = "STATUS"
        custStatus.MinimumWidth = 6
        custStatus.Name = "custStatus"
        custStatus.ReadOnly = True
        custStatus.Width = 125
        ' 
        ' frmCustList
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgCustList)
        Name = "frmCustList"
        Text = "frmCustList"
        CType(dgCustList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents dgCustList As DataGridView
    Friend WithEvents custId As DataGridViewTextBoxColumn
    Friend WithEvents custType As DataGridViewTextBoxColumn
    Friend WithEvents custName As DataGridViewTextBoxColumn
    Friend WithEvents custNative As DataGridViewTextBoxColumn
    Friend WithEvents custMobileNum As DataGridViewTextBoxColumn
    Friend WithEvents custAddr As DataGridViewTextBoxColumn
    Friend WithEvents custDob As DataGridViewTextBoxColumn
    Friend WithEvents custAge As DataGridViewTextBoxColumn
    Friend WithEvents custStatus As DataGridViewTextBoxColumn
End Class
