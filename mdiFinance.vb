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
        'frmLogin.Show()
        'frmLogin.Focus()

    End Sub

    Private Sub EMIEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMIEntryToolStripMenuItem.Click

        frmCollectEmiSingleCust.OpenCollectEmiSingleCust(0)

    End Sub

    Private Sub PaymentEntryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentEntryToolStripMenuItem.Click
        frmNewEmiPayment.Show()

    End Sub
End Class
