Imports System.IO
Imports System.Net

Public Class frmEditLoanRegistrationInput
    Private Sub lblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblLoanNum_Click(sender As Object, e As EventArgs) Handles lblLoanNum.Click
    End Sub

    Private Sub txtLoanNum_TextChanged(sender As Object, e As EventArgs) Handles txtLoanNum.TextChanged
    End Sub

    Private Sub frmEditLoanRegistrationInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Name = "Edit Loan Details"
    End Sub

    Public Sub Try01(URL As Object, reqString As String)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "POST"
            myReq.ContentType = "application/json"
            myReq.Accept = "application/json"
            myReq.Headers.Add("Authorization", "Bearer LKJLMLKJLHLMKLJLM839800K=")
            Dim myData = reqString.Replace(vbCrLf, "\n")
            'txtInsDetails.Text = myData
            'Dim myData As String = "{""loanNumber"":& txtLoanNumber.,""userId"":""10000004030"",""applicationName"":""MyTestRESTAPI""}"
            myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            Dim loanDetails As String
            loanDetails = myReader.ReadToEnd
            If loanDetails.Count > 5 Then
                frmNewLoanReg.Show()
                frmNewLoanReg.SplitRecToView(loanDetails)
                Me.Close()
            Else
                MsgBox("Not Found")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGetLoanDetails_Click(sender As Object, e As EventArgs) Handles btnGetLoanDetails.Click
        Call Try01("http://localhost:9091/loan/loanedit",
                   "{""loanNumber"":""" & txtLoanNum.Text &
                   """}")
    End Sub
End Class