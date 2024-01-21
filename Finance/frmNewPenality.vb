Imports System.IO
Imports System.Net

Public Class frmNewPenality

    Public Sub MakePenality(URL As Object, reqString As String)
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
            Dim rec = myReader.ReadToEnd
            MsgBox("Penality Made Successfully for id " & rec)
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnMakePenalityEntry_Click(sender As Object, e As EventArgs) Handles btnMakePenalityEntry.Click
        Call MakePenality("http://localhost:9091/loan/penalitynew",
                   "{""penalityAmt"":""" & txtPenalityAmt.Text &
                   """,""effectiveDate"":""" & dtEffectiveDate.Value &
                   """,""penalityDesc"":""" & txtPenalityDesc.Text &
                   """}")
    End Sub

    Private Sub txtPenalityDesc_TextChanged(sender As Object, e As EventArgs) Handles txtPenalityDesc.TextChanged

    End Sub
End Class