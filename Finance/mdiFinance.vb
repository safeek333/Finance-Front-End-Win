﻿Imports System.Linq.Expressions
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

    Private Sub DailyExpensesBillEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyExpensesBillEntryToolStripMenuItem.Click
        'BillExpenseEntry.Show()
        'Process.Start("C:\Users\safiya\source\repos\WinFormsApp1\WinFormsApp1\bin\Release\net6.0-windows\WinFormsApp1.exe")

    End Sub

    Private Sub mdiFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmLogin.Show()
        frmLogin.Focus()

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
End Class
