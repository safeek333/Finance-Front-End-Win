Imports System.IO
Imports System.Net

Public Class frmGenLoanSummary
    Private Sub frmGenLoanSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFileType.SelectedIndex = 0
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLoanNum.TextChanged

    End Sub

    Public Function GenPdfOrHtml(URL As Object, loanNumber As Long)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "GET"
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            Dim rec = myReader.ReadToEnd
            'MsgBox(URL & " / emi date :  " & rec)
            If (rec = "Success") Then
                GenPdfOrHtml = True
            Else
                GenPdfOrHtml = False
            End If
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Button1.Enabled = False
        If Not IsNumeric(txtLoanNum.Text) Then
            MsgBox("Invalid Loan Number")
        Else
            Try
                Dim loanNumber As Long
                loanNumber = CLng(txtLoanNum.Text)

                If cboFileType.SelectedItem = "HTML" Then
                    If GenPdfOrHtml("http://localhost:9091/loan/summary/" & loanNumber & "/html", loanNumber) = True Then
                        MsgBox("Html Generated Successfully")
                    Else
                        MsgBox("Html Not Generated")
                    End If
                Else
                    If GenPdfOrHtml("http://localhost:9091/loan/summary/" & loanNumber & "/pdf", loanNumber) = True Then
                        MsgBox("Pdf Generated Successfully")
                    Else
                        MsgBox("Pdf Not Generated")
                    End If
                End If
            Catch ex As Exception
                MsgBox("Invalid Loan Number")
            End Try
        End If
        Button1.Enabled = True
    End Sub
End Class