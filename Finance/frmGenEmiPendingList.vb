Imports System.IO
Imports System.Net

Public Class frmGenEmiPendingList
    Private Sub frmGenEmiPendingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboFileType.SelectedIndex = 0
    End Sub

    Public Function GenPdfOrHtml(URL As Object)
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
        Try
            Button1.Enabled = False
            If cboFileType.SelectedItem = "HTML" Then
                If GenPdfOrHtml("http://localhost:9091/loan/pending/html") = True Then
                    MsgBox("Html Generated Successfully")
                Else
                    MsgBox("Html Not Generated")
                End If
            Else
                If GenPdfOrHtml("http://localhost:9091/loan/pending/pdf") = True Then
                    MsgBox("Pdf Generated Successfully")
                Else
                    MsgBox("Pdf Not Generated")
                End If
            End If
        Catch ex As Exception

        End Try
        Button1.Enabled = True
    End Sub

    Private Sub cboFileType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboFileType.SelectedIndexChanged
        Button1.Enabled = True
    End Sub
End Class