Imports System.IO
Imports System.Net

Public Class frmNewEmiPayment
    Private Sub btnLoanNumEdit_Click(sender As Object, e As EventArgs) Handles btnLoanNumEdit.Click
        Dim s As String
        s = InputBox("Enter Loan Number")

        If IsNumeric(s) Then

            txtLoanNum.Text = FormatNumber(CInt(s), 0,,, vbFalse)
        Else
            MsgBox("Invalid Input, Try Again")
        End If
    End Sub

    Public Sub MakePayment(URL As Object, reqString As String)
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
            MsgBox("Payment Made Successfully for Loan Number " & rec)
            'SplitCustRecToView(rec)
            txtLoanNum.ReadOnly = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If IsNumeric(txtLoanNum.Text) Then
            txtLoanNum.Text = FormatNumber(CInt(txtLoanNum.Text), 0,,, vbFalse)
            If Not IsNumeric(txtEmiPaymentAmt.Text) Or CDbl(txtEmiPaymentAmt.Text) <= 0 Then
                MsgBox("Invalid Payment Amount")
                Return
            End If

            If cboPaymentType.SelectedItem = "" Then
                MsgBox("Invalid Payment Type")
                Return
            End If

            If txtPaymentDesc.Text = "" Or txtPaymentDesc.TextLength <= 5 Then
                MsgBox("Invalid Payment Description Minimum Required 5")
                Return
            End If

            Call MakePayment("http://localhost:9091/loan/paymentnew",
                   "{""loanNumber"":""" & txtLoanNum.Text &
                   """,""paymentDate"":""" & dtEmiPaymentDate.Value &
                   """,""paymentAmt"":""" & txtEmiPaymentAmt.Text &
                   """,""paymentType"":""" & cboPaymentType.SelectedItem &
                   """,""paymentDesc"":""" & txtPaymentDesc.Text &
                   """}")
        Else
            MsgBox("Invalid Loan Number")
        End If
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub frmNewEmiPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPaymentType.SelectedIndex = 0
        txtPaymentDesc.Text = "RECEIVED FROM CUSTOMER FOR EMI"
    End Sub

    Private Sub loadBasicDetail_Click(sender As Object, e As EventArgs) Handles loadBasicDetail.Click
        If IsNumeric(txtLoanNum.Text) Then
            txtLoanNum.Text = FormatNumber(CInt(txtLoanNum.Text), 0,,, vbFalse)
            GetLoanDetailBasic(txtLoanNum.Text)
        Else
            MsgBox("Invalid Loan Number, Try Again")
        End If
    End Sub

    Public Sub GetLoanDetail(URL As Object, reqString As String)
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

            SplitRecToView(loanDetails)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Public Sub SplitRecToView(LoanRecord As String)
        'Define variables
        Dim MyArray() As String, I As Integer
        'Sample string with space delimiters
        'MyString = "One Two Three Four"
        'Use Split function to divide up the component parts of the string
        MyArray = Split(LoanRecord, "|")
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
                txtLoanNum.Text = v
                txtLoanNum.Enabled = False
            End If

            If I = 1 Then
                'txtVeichleNum.Text = v
            End If
            If I = 2 Then
                txtCustAddr.Text = v
            End If
            If I = 3 Then
                'txtGarandorAddr.Text = v
            End If
            If I = 4 Then
                txtLoanAmt.Text = v
            End If
            If I = 5 Then
                'txtDocCharge.Text = v
            End If
            If I = 6 Then
                txtEmiAmount.Text = v
            End If
            If I = 7 Then
                txtEmiMonths.Text = v
            End If
            If I = 8 Then
                'txtVeichleType.Text = v
            End If
            If I = 9 Then
                'txtAFC.Text = v
            End If
            If I = 10 Then
                'txtInsDetails.Text = v
            End If

            If I = 11 Then
                'txtPrincipleAmt.Text = v
            End If
            If I = 12 Then
                dtLoanStart.Value = v
            End If
            If I = 13 Then
                dtLoanClose.Value = v
            End If
            If I = 14 Then
                cboLoanStatus.SelectedItem = v
            End If

        Next I

    End Sub
    Private Sub GetLoanDetailBasic(loanNumber As Long)
        Call GetLoanDetail("http://localhost:9091/loan/loanedit",
                   "{""loanNumber"":""" & loanNumber &
                   """}")
    End Sub
End Class