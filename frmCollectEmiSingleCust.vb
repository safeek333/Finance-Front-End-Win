﻿Imports System.IO
Imports System.Net

Public Class frmCollectEmiSingleCust

    Public pubLoanNum As Integer
    Private Sub frmCollectEmiSingleCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OpenCollectEmiSingleCust(0)

        'Dim loanNum As Integer




    End Sub

    Public Sub FetchEmiDetail(URL As Object, reqString As String)
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
            SplitRecToView(rec)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    'Below is for Customer Record to View
    Public Sub SplitRecToView(Data As String)
        Dim MyData() As String, J As Integer
        MyData = Split(Data, "~")

        For J = 0 To UBound(MyData)
            'Define variables
            Dim MyArray() As String, I As Integer
            'Sample string with space delimiters
            'MyString = "One Two Three Four"
            'Use Split function to divide up the component parts of the string


            Dim Rec As String
            Rec = MyData(J)

            If Rec.Length > 5 Then
                MyArray = Split(Rec, "|")
                'iterate through the array created to show each value

                dgCollectEmiSingleCust.Rows.Insert(J, New String() {MyArray(1), MyArray(2), MyArray(3), MyArray(4), MyArray(5), MyArray(6), MyArray(7),
                                               MyArray(8), MyArray(9), MyArray(10), MyArray(11), MyArray(12), MyArray(13), MyArray(14), MyArray(15)})

            End If
        Next J
    End Sub
    Public Sub OpenCollectEmiSingleCust(loanNum As Long)

        If (loanNum = 0) Then
            loanNum = InputBox("Enter Loan Number")
        End If

        Me.Show()

        Call FetchEmiDetail("http://localhost:9091/loan/emilistedit",
                   "{""loanNumber"":""" & loanNum &
                   """}")

        'Call to backend


        'dgCollectEmiSingleCust.ControlCollection.DataGridViewControlCollection(1)



    End Sub

    Private Sub dgCollectEmiSingleCust_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgCollectEmiSingleCust.CellContentClick

    End Sub
End Class