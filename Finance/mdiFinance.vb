Imports System.Linq.Expressions
Imports WinFormsApp1

Public Class mdiFinance
    Private Sub NewLoanRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewLoanRegistrationToolStripMenuItem.Click
        'frmNewLoanReg.MdiParent = Me
        frmNewLoanReg.Show()
    End Sub

    Private Sub EditNewLoanRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditNewLoanRegistrationToolStripMenuItem.Click
        If frmNewLoanReg.Visible Then
            frmNewLoanReg.Close()
        End If
        frmEditLoanRegistrationInput.Show()
    End Sub

    Private Sub mdiFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Res As String
        Res = AboutBox1.GenLic()
        If Res = "f4eb05ce5953bd9b02cb6b8bea11c3c5#2a0v2h5b0d2s2j8f" Then
            frmLogin.Show()
            frmLogin.Focus()
            'frmLogin.UsernameTextBox.Text = "root"
            'frmLogin.PasswordTextBox.Text = "root"
        Else
            MsgBox("Application " & Res)
            Application.Exit()
        End If


    End Sub

    Private Sub EMIEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMIEntryToolStripMenuItem.Click

        frmCollectEmiSingleCust.OpenCollectEmiSingleCust(0)

    End Sub

    Private Sub PaymentEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentEntryToolStripMenuItem.Click
        frmNewEmiPayment.Show()

    End Sub

    Private Sub AddNewPenalityToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewPenalityToolStripMenuItem.Click
        frmNewPenality.Show()
    End Sub

    Private Sub ViewPayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPayToolStripMenuItem.Click
        frmPaymentList.OpenPaymentList(0)
    End Sub

    Private Sub ReportsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem1.Click
        frmCustList.OpenAllCustomerList()
    End Sub

    Private Sub ViewPenalityMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewPenalityMasterToolStripMenuItem.Click
        frmPenalityList.OpenAllPenalityList()
    End Sub

    Private Sub AllLoanDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllLoanDetailsToolStripMenuItem.Click
        frmLoanList.OpenAllLoanList()
    End Sub

    Private Sub CreateNewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateNewCustomerToolStripMenuItem.Click
        frmNewCust.Show()
    End Sub

    Private Sub EditCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditCustomerToolStripMenuItem.Click
        If frmNewCust.Visible Then
            frmNewCust.Close()
        End If
        Dim custId As String

        custId = ""
        Do Until IsNumeric(custId)
            custId = InputBox("Enter Customer ID")
        Loop

        frmNewCust.Show()
        frmNewCust.txtCustId.Text = custId
        frmNewCust.txtCustId.Enabled = False

        Dim myData As String = "{""customerId"":""" & custId & """}"
        frmNewCust.EditCustomer("http://localhost:9091/loan/custedit", myData)


    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub ViewAllReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewAllReceiptsToolStripMenuItem.Click
        frmReceiptList.OpenAllPenalityList()

    End Sub

    Private Sub GenerateLoanSummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateLoanSummaryToolStripMenuItem.Click
        frmGenLoanSummary.Show()
    End Sub

    Private Sub ViewEmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewEmToolStripMenuItem.Click
        frmGenEmiPendingList.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub ViewLoanReceiptsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewLoanReceiptsToolStripMenuItem.Click
        frmEditLoanRecepts.Show()
    End Sub
End Class
