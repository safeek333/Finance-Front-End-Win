﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mdiFinance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        LoanToolStripMenuItem = New ToolStripMenuItem()
        NewLoanRegistrationToolStripMenuItem = New ToolStripMenuItem()
        EditNewLoanRegistrationToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator2 = New ToolStripSeparator()
        EMIDetailsToolStripMenuItem = New ToolStripMenuItem()
        EMIEntryToolStripMenuItem = New ToolStripMenuItem()
        PaymentToolStripMenuItem = New ToolStripMenuItem()
        PaymentEntryToolStripMenuItem = New ToolStripMenuItem()
        ViewPayToolStripMenuItem = New ToolStripMenuItem()
        ToolStripMenuItem1 = New ToolStripMenuItem()
        AddNewPenalityToolStripMenuItem = New ToolStripMenuItem()
        ViewPenalityMasterToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator3 = New ToolStripSeparator()
        CloseLoanToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator1 = New ToolStripSeparator()
        ReportsToolStripMenuItem = New ToolStripMenuItem()
        AllLoanDetailsToolStripMenuItem = New ToolStripMenuItem()
        CustomerToolStripMenuItem = New ToolStripMenuItem()
        CreateNewCustomerToolStripMenuItem = New ToolStripMenuItem()
        EditCustomerToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator4 = New ToolStripSeparator()
        ReportsToolStripMenuItem1 = New ToolStripMenuItem()
        OfficeExpeToolStripMenuItem = New ToolStripMenuItem()
        DailyExpensesBillEntryToolStripMenuItem = New ToolStripMenuItem()
        SearchViewExpensesBillsToolStripMenuItem = New ToolStripMenuItem()
        ToolStripSeparator5 = New ToolStripSeparator()
        ReportsToolStripMenuItem2 = New ToolStripMenuItem()
        CalculationsToolStripMenuItem = New ToolStripMenuItem()
        FinanceChargeCalcToolStripMenuItem = New ToolStripMenuItem()
        PercentageCalcAmountToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        UserManualToolStripMenuItem = New ToolStripMenuItem()
        AboutToolStripMenuItem = New ToolStripMenuItem()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        FileSystemWatcher2 = New IO.FileSystemWatcher()
        MenuStrip1.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        CType(FileSystemWatcher2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, LoanToolStripMenuItem, CustomerToolStripMenuItem, OfficeExpeToolStripMenuItem, CalculationsToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1924, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ExitToolStripMenuItem})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(116, 26)
        ExitToolStripMenuItem.Text = "Exit"
        ' 
        ' LoanToolStripMenuItem
        ' 
        LoanToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewLoanRegistrationToolStripMenuItem, EditNewLoanRegistrationToolStripMenuItem, ToolStripSeparator2, EMIDetailsToolStripMenuItem, PaymentToolStripMenuItem, ToolStripMenuItem1, ToolStripSeparator3, CloseLoanToolStripMenuItem, ToolStripSeparator1, ReportsToolStripMenuItem})
        LoanToolStripMenuItem.Name = "LoanToolStripMenuItem"
        LoanToolStripMenuItem.Size = New Size(55, 24)
        LoanToolStripMenuItem.Text = "Loan"
        ' 
        ' NewLoanRegistrationToolStripMenuItem
        ' 
        NewLoanRegistrationToolStripMenuItem.Name = "NewLoanRegistrationToolStripMenuItem"
        NewLoanRegistrationToolStripMenuItem.Size = New Size(273, 26)
        NewLoanRegistrationToolStripMenuItem.Text = "New Loan"
        ' 
        ' EditNewLoanRegistrationToolStripMenuItem
        ' 
        EditNewLoanRegistrationToolStripMenuItem.Name = "EditNewLoanRegistrationToolStripMenuItem"
        EditNewLoanRegistrationToolStripMenuItem.Size = New Size(273, 26)
        EditNewLoanRegistrationToolStripMenuItem.Text = "Edit Loan"
        ' 
        ' ToolStripSeparator2
        ' 
        ToolStripSeparator2.Name = "ToolStripSeparator2"
        ToolStripSeparator2.Size = New Size(270, 6)
        ' 
        ' EMIDetailsToolStripMenuItem
        ' 
        EMIDetailsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {EMIEntryToolStripMenuItem})
        EMIDetailsToolStripMenuItem.Name = "EMIDetailsToolStripMenuItem"
        EMIDetailsToolStripMenuItem.Size = New Size(273, 26)
        EMIDetailsToolStripMenuItem.Text = "Loan EMI"
        ' 
        ' EMIEntryToolStripMenuItem
        ' 
        EMIEntryToolStripMenuItem.Name = "EMIEntryToolStripMenuItem"
        EMIEntryToolStripMenuItem.Size = New Size(239, 26)
        EMIEntryToolStripMenuItem.Text = "View Loan EMI Details"
        ' 
        ' PaymentToolStripMenuItem
        ' 
        PaymentToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PaymentEntryToolStripMenuItem, ViewPayToolStripMenuItem})
        PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem"
        PaymentToolStripMenuItem.Size = New Size(273, 26)
        PaymentToolStripMenuItem.Text = "Loan Payment"
        ' 
        ' PaymentEntryToolStripMenuItem
        ' 
        PaymentEntryToolStripMenuItem.Name = "PaymentEntryToolStripMenuItem"
        PaymentEntryToolStripMenuItem.Size = New Size(250, 26)
        PaymentEntryToolStripMenuItem.Text = "Add New Loan Payment"
        ' 
        ' ViewPayToolStripMenuItem
        ' 
        ViewPayToolStripMenuItem.Name = "ViewPayToolStripMenuItem"
        ViewPayToolStripMenuItem.Size = New Size(250, 26)
        ViewPayToolStripMenuItem.Text = "View Loan Payments"
        ' 
        ' ToolStripMenuItem1
        ' 
        ToolStripMenuItem1.DropDownItems.AddRange(New ToolStripItem() {AddNewPenalityToolStripMenuItem, ViewPenalityMasterToolStripMenuItem})
        ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        ToolStripMenuItem1.Size = New Size(273, 26)
        ToolStripMenuItem1.Text = "Additional Finance Charges"
        ' 
        ' AddNewPenalityToolStripMenuItem
        ' 
        AddNewPenalityToolStripMenuItem.Name = "AddNewPenalityToolStripMenuItem"
        AddNewPenalityToolStripMenuItem.Size = New Size(224, 26)
        AddNewPenalityToolStripMenuItem.Text = "Add New AFC"
        ' 
        ' ViewPenalityMasterToolStripMenuItem
        ' 
        ViewPenalityMasterToolStripMenuItem.Name = "ViewPenalityMasterToolStripMenuItem"
        ViewPenalityMasterToolStripMenuItem.Size = New Size(224, 26)
        ViewPenalityMasterToolStripMenuItem.Text = "View All AFC"
        ' 
        ' ToolStripSeparator3
        ' 
        ToolStripSeparator3.Name = "ToolStripSeparator3"
        ToolStripSeparator3.Size = New Size(270, 6)
        ' 
        ' CloseLoanToolStripMenuItem
        ' 
        CloseLoanToolStripMenuItem.Name = "CloseLoanToolStripMenuItem"
        CloseLoanToolStripMenuItem.Size = New Size(273, 26)
        CloseLoanToolStripMenuItem.Text = "Close Loan"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(270, 6)
        ' 
        ' ReportsToolStripMenuItem
        ' 
        ReportsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AllLoanDetailsToolStripMenuItem})
        ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        ReportsToolStripMenuItem.Size = New Size(273, 26)
        ReportsToolStripMenuItem.Text = "Loan Reports"
        ' 
        ' AllLoanDetailsToolStripMenuItem
        ' 
        AllLoanDetailsToolStripMenuItem.Name = "AllLoanDetailsToolStripMenuItem"
        AllLoanDetailsToolStripMenuItem.Size = New Size(232, 26)
        AllLoanDetailsToolStripMenuItem.Text = "View All Loan Details"
        ' 
        ' CustomerToolStripMenuItem
        ' 
        CustomerToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CreateNewCustomerToolStripMenuItem, EditCustomerToolStripMenuItem, ToolStripSeparator4, ReportsToolStripMenuItem1})
        CustomerToolStripMenuItem.Name = "CustomerToolStripMenuItem"
        CustomerToolStripMenuItem.Size = New Size(86, 24)
        CustomerToolStripMenuItem.Text = "Customer"
        ' 
        ' CreateNewCustomerToolStripMenuItem
        ' 
        CreateNewCustomerToolStripMenuItem.Name = "CreateNewCustomerToolStripMenuItem"
        CreateNewCustomerToolStripMenuItem.Size = New Size(213, 26)
        CreateNewCustomerToolStripMenuItem.Text = "New Customer"
        ' 
        ' EditCustomerToolStripMenuItem
        ' 
        EditCustomerToolStripMenuItem.Name = "EditCustomerToolStripMenuItem"
        EditCustomerToolStripMenuItem.Size = New Size(213, 26)
        EditCustomerToolStripMenuItem.Text = "Edit Customer"
        ' 
        ' ToolStripSeparator4
        ' 
        ToolStripSeparator4.Name = "ToolStripSeparator4"
        ToolStripSeparator4.Size = New Size(210, 6)
        ' 
        ' ReportsToolStripMenuItem1
        ' 
        ReportsToolStripMenuItem1.Name = "ReportsToolStripMenuItem1"
        ReportsToolStripMenuItem1.Size = New Size(213, 26)
        ReportsToolStripMenuItem1.Text = "View All Customer"
        ' 
        ' OfficeExpeToolStripMenuItem
        ' 
        OfficeExpeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DailyExpensesBillEntryToolStripMenuItem, SearchViewExpensesBillsToolStripMenuItem, ToolStripSeparator5, ReportsToolStripMenuItem2})
        OfficeExpeToolStripMenuItem.Name = "OfficeExpeToolStripMenuItem"
        OfficeExpeToolStripMenuItem.Size = New Size(83, 24)
        OfficeExpeToolStripMenuItem.Text = "Accounts"
        ' 
        ' DailyExpensesBillEntryToolStripMenuItem
        ' 
        DailyExpensesBillEntryToolStripMenuItem.Name = "DailyExpensesBillEntryToolStripMenuItem"
        DailyExpensesBillEntryToolStripMenuItem.Size = New Size(271, 26)
        DailyExpensesBillEntryToolStripMenuItem.Text = "Daily Expenses Bill Entry"
        ' 
        ' SearchViewExpensesBillsToolStripMenuItem
        ' 
        SearchViewExpensesBillsToolStripMenuItem.Name = "SearchViewExpensesBillsToolStripMenuItem"
        SearchViewExpensesBillsToolStripMenuItem.Size = New Size(271, 26)
        SearchViewExpensesBillsToolStripMenuItem.Text = "Search & View Expenses Bills"
        ' 
        ' ToolStripSeparator5
        ' 
        ToolStripSeparator5.Name = "ToolStripSeparator5"
        ToolStripSeparator5.Size = New Size(268, 6)
        ' 
        ' ReportsToolStripMenuItem2
        ' 
        ReportsToolStripMenuItem2.Name = "ReportsToolStripMenuItem2"
        ReportsToolStripMenuItem2.Size = New Size(271, 26)
        ReportsToolStripMenuItem2.Text = "Reports"
        ' 
        ' CalculationsToolStripMenuItem
        ' 
        CalculationsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FinanceChargeCalcToolStripMenuItem, PercentageCalcAmountToolStripMenuItem})
        CalculationsToolStripMenuItem.Name = "CalculationsToolStripMenuItem"
        CalculationsToolStripMenuItem.Size = New Size(103, 24)
        CalculationsToolStripMenuItem.Text = "Calculations"
        ' 
        ' FinanceChargeCalcToolStripMenuItem
        ' 
        FinanceChargeCalcToolStripMenuItem.Name = "FinanceChargeCalcToolStripMenuItem"
        FinanceChargeCalcToolStripMenuItem.Size = New Size(264, 26)
        FinanceChargeCalcToolStripMenuItem.Text = "Charge Calc - Days"
        ' 
        ' PercentageCalcAmountToolStripMenuItem
        ' 
        PercentageCalcAmountToolStripMenuItem.Name = "PercentageCalcAmountToolStripMenuItem"
        PercentageCalcAmountToolStripMenuItem.Size = New Size(264, 26)
        PercentageCalcAmountToolStripMenuItem.Text = "Percentage Calc - Amount"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UserManualToolStripMenuItem, AboutToolStripMenuItem})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' UserManualToolStripMenuItem
        ' 
        UserManualToolStripMenuItem.Name = "UserManualToolStripMenuItem"
        UserManualToolStripMenuItem.Size = New Size(174, 26)
        UserManualToolStripMenuItem.Text = "User Manual"
        ' 
        ' AboutToolStripMenuItem
        ' 
        AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        AboutToolStripMenuItem.Size = New Size(174, 26)
        AboutToolStripMenuItem.Text = "About"
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' FileSystemWatcher2
        ' 
        FileSystemWatcher2.EnableRaisingEvents = True
        FileSystemWatcher2.SynchronizingObject = Me
        ' 
        ' mdiFinance
        ' 
        AutoScaleDimensions = New SizeF(25F, 46F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1924, 1035)
        Controls.Add(MenuStrip1)
        Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(9, 7, 9, 7)
        Name = "mdiFinance"
        Text = "Finance"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        CType(FileSystemWatcher2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewLoanRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditNewLoanRegistrationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents FileSystemWatcher2 As IO.FileSystemWatcher
    Friend WithEvents EMIDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CreateNewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EMIEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PaymentEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseLoanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllLoanDetailsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents ReportsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OfficeExpeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyExpensesBillEntryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchViewExpensesBillsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents ReportsToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents CalculationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FinanceChargeCalcToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PercentageCalcAmountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewPenalityToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewPenalityMasterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UserManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
End Class
