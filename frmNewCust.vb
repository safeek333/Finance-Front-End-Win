Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Extensions.DependencyModel.Resolution
Imports Nancy.Json
Public Class frmNewCust
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
            Dim id As String
            id = myReader.ReadToEnd
            txtCustId.Text = id
            txtCustId.ReadOnly = True
            If Me.btnSave.Text = "Save" Then
                MsgBox("Customer Creted with ID " & id)
            ElseIf Me.btnSave.Text = "Update" Then
                MsgBox("Customer Updated for ID " & id)
            End If
            Me.btnSave.Text = "Update"
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Submit()
        Call Try01("http://localhost:9091/loan/custnew",
                   "{""customerId"":""" & txtCustId.Text &
                   """,""customerIdType"":""" & cboCustIdType.SelectedItem &
                   """,""customerNative"":""" & txtCustNative.Text &
                   """,""customerName"":""" & txtCustName.Text &
                   """,""customerMobileNumber"":""" & txtMobileNum.Text &
                   """,""customerAddress"":""" & txtCustAddr.Text &
                   """,""customerDob"":""" & dtCustDob.Value &
                   """,""customerStatus"":""" & cboCustStatus.SelectedItem &
                   """,""customerType"":""" & cboCustType.SelectedItem &
                   """,""customerAge"":""" & txtAge.Text &
                   """}")
    End Sub

    Public Sub SplitRecToView(Rec As String)
        'Define variables
        Dim MyArray() As String, I As Integer
        'Sample string with space delimiters
        'MyString = "One Two Three Four"
        'Use Split function to divide up the component parts of the string
        MyArray = Split(Rec, "|")
        'iterate through the array created to show each value
        Dim v As String
        For I = 0 To UBound(MyArray)
            v = MyArray(I)
            'MsgBox(abc)
            If v = "null" Then
                v = ""
            End If
            'Replace()
            If I = 0 Then
                txtCustId.Text = v
                txtCustId.Enabled = False
            End If

            If I = 1 Then
                cboCustIdType.SelectedItem = v
            End If
            If I = 2 Then
                txtCustNative.Text = v
            End If
            If I = 3 Then
                txtCustName.Text = v
            End If
            If I = 4 Then
                txtMobileNum.Text = v
            End If
            If I = 5 Then
                txtCustAddr.Text = v
            End If
            If I = 6 Then
                dtCustDob.Value = v
            End If
            If I = 7 Then
                txtAge.Text = v
            End If
            If I = 8 Then
                cboCustStatus.SelectedItem = v
            End If
            If I = 9 Then
                cboCustType.SelectedItem = v
            End If
        Next I
        Me.lblTitle.Text = Me.lblTitle.Text & " (Update)"
        Me.btnSave.Text = "Update"
    End Sub



    Private Sub dtCustDob_ValueChanged(sender As Object, e As EventArgs) Handles dtCustDob.ValueChanged
        txtAge.Text = DateDiff(DateInterval.Year, dtCustDob.Value, Today).ToString
    End Sub

    Private Sub btnSetAge_Click(sender As Object, e As EventArgs) Handles btnSetAge.Click
        SetAge()
    End Sub

    Private Sub SetAge()
        Try
            Dim age As Integer
            age = CInt(InputBox("Enter Customer Age", "Set Customer Age"))
            If (age > 18) Then
                dtCustDob.Value = DateAdd(DateInterval.Year, -age, Today)
                txtAge.Text = age
            Else
                MsgBox("Age Must be Greater Than 18")
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SetFormInitialValues()
        Try
            txtAge.Text = "19" 'Minimum Age to Get Loan
            cboCustIdType.SelectedIndex = 0
            cboCustStatus.SelectedIndex = 0
            cboCustType.SelectedIndex = 0
            txtCustNative.Text = "Elurpatty"
            txtMobileNum.Text = "NA"
            txtCustAddr.Text = "NA"
            txtCustName.Text = "NA"
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Submit()
    End Sub

    Private Sub frmNewCust_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormInitialValues()
    End Sub

    Public Sub LoadCustomer(URL As Object, reqString As String)
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
            Dim detail As String
            detail = myReader.ReadToEnd
            If detail.Count > 5 Then
                frmNewLoanReg.Show()
                frmNewLoanReg.SplitCustRecToView(detail)
                Me.Close()
            Else
                MsgBox("Customer Not Found")
            End If

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
End Class