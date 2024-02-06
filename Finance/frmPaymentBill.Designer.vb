<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaymentBill
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
        components = New ComponentModel.Container()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(frmPaymentBill))
        lblBillDate = New Label()
        lblCustName = New Label()
        lblRupees = New Label()
        lblInWords1 = New Label()
        lblInWords2 = New Label()
        lblBillVeichleNo = New Label()
        lblBillLoanNo = New Label()
        lblEmiDate = New Label()
        lblBillEmiNo = New Label()
        lblBilTotalEmiNos = New Label()
        lblBillAmount = New Label()
        lblBillTotal = New Label()
        ImageList1 = New ImageList(components)
        ImageList2 = New ImageList(components)
        SuspendLayout()
        ' 
        ' lblBillDate
        ' 
        resources.ApplyResources(lblBillDate, "lblBillDate")
        lblBillDate.BackColor = Color.Transparent
        lblBillDate.ForeColor = SystemColors.WindowText
        lblBillDate.Name = "lblBillDate"
        ' 
        ' lblCustName
        ' 
        resources.ApplyResources(lblCustName, "lblCustName")
        lblCustName.BackColor = Color.Transparent
        lblCustName.ForeColor = SystemColors.WindowText
        lblCustName.Name = "lblCustName"
        ' 
        ' lblRupees
        ' 
        resources.ApplyResources(lblRupees, "lblRupees")
        lblRupees.BackColor = Color.Transparent
        lblRupees.ForeColor = SystemColors.WindowText
        lblRupees.Name = "lblRupees"
        ' 
        ' lblInWords1
        ' 
        resources.ApplyResources(lblInWords1, "lblInWords1")
        lblInWords1.BackColor = Color.Transparent
        lblInWords1.ForeColor = SystemColors.WindowText
        lblInWords1.Name = "lblInWords1"
        ' 
        ' lblInWords2
        ' 
        resources.ApplyResources(lblInWords2, "lblInWords2")
        lblInWords2.BackColor = Color.Transparent
        lblInWords2.ForeColor = SystemColors.WindowText
        lblInWords2.Name = "lblInWords2"
        ' 
        ' lblBillVeichleNo
        ' 
        resources.ApplyResources(lblBillVeichleNo, "lblBillVeichleNo")
        lblBillVeichleNo.BackColor = Color.Transparent
        lblBillVeichleNo.ForeColor = SystemColors.WindowText
        lblBillVeichleNo.Name = "lblBillVeichleNo"
        ' 
        ' lblBillLoanNo
        ' 
        resources.ApplyResources(lblBillLoanNo, "lblBillLoanNo")
        lblBillLoanNo.BackColor = Color.Transparent
        lblBillLoanNo.ForeColor = Color.Black
        lblBillLoanNo.Name = "lblBillLoanNo"
        ' 
        ' lblEmiDate
        ' 
        resources.ApplyResources(lblEmiDate, "lblEmiDate")
        lblEmiDate.BackColor = Color.Transparent
        lblEmiDate.ForeColor = SystemColors.WindowText
        lblEmiDate.Name = "lblEmiDate"
        ' 
        ' lblBillEmiNo
        ' 
        resources.ApplyResources(lblBillEmiNo, "lblBillEmiNo")
        lblBillEmiNo.BackColor = Color.Transparent
        lblBillEmiNo.ForeColor = SystemColors.WindowText
        lblBillEmiNo.Name = "lblBillEmiNo"
        ' 
        ' lblBilTotalEmiNos
        ' 
        resources.ApplyResources(lblBilTotalEmiNos, "lblBilTotalEmiNos")
        lblBilTotalEmiNos.BackColor = Color.Transparent
        lblBilTotalEmiNos.ForeColor = SystemColors.WindowText
        lblBilTotalEmiNos.Name = "lblBilTotalEmiNos"
        ' 
        ' lblBillAmount
        ' 
        resources.ApplyResources(lblBillAmount, "lblBillAmount")
        lblBillAmount.BackColor = Color.Transparent
        lblBillAmount.ForeColor = SystemColors.WindowText
        lblBillAmount.Name = "lblBillAmount"
        ' 
        ' lblBillTotal
        ' 
        resources.ApplyResources(lblBillTotal, "lblBillTotal")
        lblBillTotal.BackColor = Color.Transparent
        lblBillTotal.ForeColor = SystemColors.WindowText
        lblBillTotal.Name = "lblBillTotal"
        ' 
        ' ImageList1
        ' 
        ImageList1.ColorDepth = ColorDepth.Depth8Bit
        ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), ImageListStreamer)
        ImageList1.TransparentColor = Color.Transparent
        ImageList1.Images.SetKeyName(0, "bill.png")
        ' 
        ' ImageList2
        ' 
        ImageList2.ColorDepth = ColorDepth.Depth8Bit
        ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), ImageListStreamer)
        ImageList2.TransparentColor = Color.Transparent
        ImageList2.Images.SetKeyName(0, "bill.png")
        ' 
        ' frmPaymentBill
        ' 
        resources.ApplyResources(Me, "$this")
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblBillDate)
        Controls.Add(lblBillTotal)
        Controls.Add(lblBillAmount)
        Controls.Add(lblBilTotalEmiNos)
        Controls.Add(lblBillEmiNo)
        Controls.Add(lblEmiDate)
        Controls.Add(lblBillLoanNo)
        Controls.Add(lblBillVeichleNo)
        Controls.Add(lblInWords2)
        Controls.Add(lblInWords1)
        Controls.Add(lblRupees)
        Controls.Add(lblCustName)
        ForeColor = SystemColors.Window
        Name = "frmPaymentBill"
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblBillDate As Label
    Friend WithEvents lblCustName As Label
    Friend WithEvents lblRupees As Label
    Friend WithEvents lblInWords1 As Label
    Friend WithEvents lblInWords2 As Label
    Friend WithEvents lblBillVeichleNo As Label
    Friend WithEvents lblBillLoanNo As Label
    Friend WithEvents lblEmiDate As Label
    Friend WithEvents lblBillEmiNo As Label
    Friend WithEvents lblBilTotalEmiNos As Label
    Friend WithEvents lblBillAmount As Label
    Friend WithEvents lblBillTotal As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ImageList2 As ImageList
End Class
