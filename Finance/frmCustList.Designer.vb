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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
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
        lblSearch = New Label()
        txtSearch = New TextBox()
        Button1 = New Button()
        CType(dgCustList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgCustList
        ' 
        dgCustList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgCustList.Columns.AddRange(New DataGridViewColumn() {custId, custType, custName, custNative, custMobileNum, custAddr, custDob, custAge, custStatus})
        dgCustList.Dock = DockStyle.Top
        dgCustList.Location = New Point(0, 0)
        dgCustList.Name = "dgCustList"
        dgCustList.RowHeadersWidth = 51
        dgCustList.RowTemplate.Height = 29
        dgCustList.Size = New Size(1051, 570)
        dgCustList.TabIndex = 0
        ' 
        ' custId
        ' 
        custId.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle1.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custId.DefaultCellStyle = DataGridViewCellStyle1
        custId.HeaderText = "CUST ID"
        custId.MinimumWidth = 6
        custId.Name = "custId"
        custId.ReadOnly = True
        custId.Width = 85
        ' 
        ' custType
        ' 
        custType.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custType.DefaultCellStyle = DataGridViewCellStyle2
        custType.HeaderText = "TYPE"
        custType.MinimumWidth = 6
        custType.Name = "custType"
        custType.ReadOnly = True
        custType.Width = 70
        ' 
        ' custName
        ' 
        custName.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle3.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custName.DefaultCellStyle = DataGridViewCellStyle3
        custName.HeaderText = "NAME"
        custName.MinimumWidth = 6
        custName.Name = "custName"
        custName.ReadOnly = True
        custName.Width = 80
        ' 
        ' custNative
        ' 
        custNative.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle4.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custNative.DefaultCellStyle = DataGridViewCellStyle4
        custNative.HeaderText = "NATIVE"
        custNative.MinimumWidth = 6
        custNative.Name = "custNative"
        custNative.ReadOnly = True
        custNative.Width = 87
        ' 
        ' custMobileNum
        ' 
        custMobileNum.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle5.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custMobileNum.DefaultCellStyle = DataGridViewCellStyle5
        custMobileNum.HeaderText = "MOBILE NUMBER"
        custMobileNum.MinimumWidth = 6
        custMobileNum.Name = "custMobileNum"
        custMobileNum.ReadOnly = True
        custMobileNum.Width = 141
        ' 
        ' custAddr
        ' 
        DataGridViewCellStyle6.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custAddr.DefaultCellStyle = DataGridViewCellStyle6
        custAddr.HeaderText = "ADDRESS"
        custAddr.MinimumWidth = 6
        custAddr.Name = "custAddr"
        custAddr.ReadOnly = True
        custAddr.Width = 300
        ' 
        ' custDob
        ' 
        custDob.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle7.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custDob.DefaultCellStyle = DataGridViewCellStyle7
        custDob.HeaderText = "DATE OF BIRTH"
        custDob.MinimumWidth = 6
        custDob.Name = "custDob"
        custDob.ReadOnly = True
        custDob.Width = 128
        ' 
        ' custAge
        ' 
        custAge.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle8.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custAge.DefaultCellStyle = DataGridViewCellStyle8
        custAge.HeaderText = "AGE"
        custAge.MinimumWidth = 6
        custAge.Name = "custAge"
        custAge.ReadOnly = True
        custAge.Width = 66
        ' 
        ' custStatus
        ' 
        custStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle9.Font = New Font("Microsoft Sans Serif", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        custStatus.DefaultCellStyle = DataGridViewCellStyle9
        custStatus.HeaderText = "STATUS"
        custStatus.MinimumWidth = 6
        custStatus.Name = "custStatus"
        custStatus.ReadOnly = True
        custStatus.Width = 88
        ' 
        ' lblSearch
        ' 
        lblSearch.AutoSize = True
        lblSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        lblSearch.Location = New Point(4, 591)
        lblSearch.Name = "lblSearch"
        lblSearch.Size = New Size(67, 28)
        lblSearch.TabIndex = 4
        lblSearch.Text = "Filter:"
        ' 
        ' txtSearch
        ' 
        txtSearch.BorderStyle = BorderStyle.FixedSingle
        txtSearch.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        txtSearch.Location = New Point(71, 588)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(272, 34)
        txtSearch.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(71, 649)
        Button1.Name = "Button1"
        Button1.Size = New Size(272, 41)
        Button1.TabIndex = 10
        Button1.Text = "Export As PDF"
        Button1.UseVisualStyleBackColor = True
        Button1.UseWaitCursor = True
        ' 
        ' frmCustList
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1051, 729)
        Controls.Add(Button1)
        Controls.Add(lblSearch)
        Controls.Add(txtSearch)
        Controls.Add(dgCustList)
        Name = "frmCustList"
        Text = "Customers"
        WindowState = FormWindowState.Maximized
        CType(dgCustList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
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
    Friend WithEvents lblSearch As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Button1 As Button
End Class
