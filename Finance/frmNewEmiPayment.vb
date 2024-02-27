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

    Public Sub GetNumber2Words(URL As Object)
        Try
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "GET"
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            Dim rec = myReader.ReadToEnd
            'MsgBox("Number 2 Word :  " & rec)
            txtAmtInWords.Text = rec
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Sub GetEmiDate(URL As Object)
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
            dtEmiDate.Value = rec
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try

    End Sub

    Public Function isLoanClosed(loanNumber As Long)
        Try
            Dim URL As Object
            URL = "http://localhost:9091/loan/status/" & loanNumber
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "GET"
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            Dim rec = myReader.ReadToEnd
            'MsgBox(URL & " / emi date :  " & rec)
            If (rec = "Closed") Then
                isLoanClosed = True
            Else
                isLoanClosed = False
            End If
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
        End Try

    End Function

    Public Sub MakePayment(URL As Object, reqString As String)
        Try
            If Not IsNumeric(txtLoanNum.Text) Then
                MsgBox("Loan Number Required")
                Return
            Else
                If isLoanClosed(CLng(txtLoanNum.Text)) Then
                    MsgBox("Loan Closed. Cannnot Proceed.")
                    Return
                End If
            End If


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

        If Not IsNumeric(txtLoanNum.Text) Then
            MsgBox("Loan Number Required")
            Return
        Else
            If isLoanClosed(CLng(txtLoanNum.Text)) Then
                MsgBox("Loan Closed. Cannnot Proceed.")
                Return
            End If
        End If
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

            validateEmiId()
            validateEmiDate()

            Dim receipt As String

            Dim request As String


            If frmPaymentBill.Visible And (Me.cboPaymentType.SelectedItem = "CUST PAY IN") Then
                receipt = "{""receiptDate"":""" & frmPaymentBill.lblBillDate.Text &
                """,""receiptCustAddr"":""" & frmPaymentBill.lblCustName.Text &
                """,""receiptAmt"":""" & frmPaymentBill.lblRupees.Text &
                """,""receiptAmtInWords"":""" & frmPaymentBill.lblInWords2.Text &
                """,""receiptVeichleNum"":""" & frmPaymentBill.lblBillVeichleNo.Text &
                """,""receiptLoanNum"":""" & frmPaymentBill.lblBillLoanNo.Text &
                """,""receiptEmiDate"":""" & frmPaymentBill.lblEmiDate.Text &
                """,""receiptEmiId"":""" & frmPaymentBill.lblBillEmiNo.Text &
                """,""receiptEmiAmt"":""" & frmPaymentBill.lblBillAmount.Text &
                """,""receiptTotal"":""" & frmPaymentBill.lblBillTotal.Text &
                """,""receiptCollSign"":""" & "Root" &
                """}"

                request = "{""loanNumber"":""" & txtLoanNum.Text &
                   """,""paymentDate"":""" & dtEmiPaymentDate.Value &
                   """,""paymentAmt"":""" & txtEmiPaymentAmt.Text &
                   """,""paymentType"":""" & cboPaymentType.SelectedItem &
                   """,""paymentDesc"":""" & txtPaymentDesc.Text &
                   """,""paymentReceipt"":" & receipt &
                   "}"
            Else
                request = "{""loanNumber"":""" & txtLoanNum.Text &
                   """,""paymentDate"":""" & dtEmiPaymentDate.Value &
                   """,""paymentAmt"":""" & txtEmiPaymentAmt.Text &
                   """,""paymentType"":""" & cboPaymentType.SelectedItem &
                   """,""paymentDesc"":""" & txtPaymentDesc.Text &
                   """}"
            End If


            MsgBox(request)

            Call MakePayment("http://localhost:9091/loan/paymentnew", request)


        Else
            MsgBox("Invalid Loan Number")
        End If
    End Sub



    Private Sub frmNewEmiPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPaymentType.SelectedIndex = 0
        cboEmiId.SelectedIndex = 0
        txtPaymentDesc.Text = "RECEIVED FROM CUSTOMER FOR EMI"
        txtEmiPaymentAmt.Focus()

    End Sub

    Private Sub loadBasicDetail_Click(sender As Object, e As EventArgs) Handles loadBasicDetail.Click
        If IsNumeric(txtLoanNum.Text) Then
            txtLoanNum.Text = FormatNumber(CInt(txtLoanNum.Text), 0,,, vbFalse)
            GetLoanDetailBasic(txtLoanNum.Text)
            UpdateBill()

        Else
            MsgBox("Invalid Loan Number, Try Again")
        End If
    End Sub

    Private Sub UpdateBill()
        Try
            If Me.cboPaymentType.SelectedItem = "CUST PAY IN" Then
                frmPaymentBill.Show()
                Try
                    GetNumber2Words("http://localhost:9091/loan/n2w/" & CLng(Me.txtEmiPaymentAmt.Text))
                Catch e As Exception

                End Try

                Try

                    GetEmiDate("http://localhost:9091/loan/emidate/" & CLng(Me.txtLoanNum.Text) & "/" & CInt(Me.cboEmiId.SelectedItem))

                Catch ex As Exception

                End Try

                frmPaymentBill.UpdateBillContent(
                    Me.dtEmiPaymentDate.Value.ToString(),
                    Me.txtCustAddr.Text,
                    Me.txtEmiPaymentAmt.Text,
                    " **** ",
                    Me.txtAmtInWords.Text,
                    Me.txtLoanNum.Text,
                    Me.dtEmiDate.Value,
                    Me.cboEmiId.SelectedItem,
                    Me.txtEmiMonths.Text,
                    Me.txtEmiPaymentAmt.Text,
                    Me.txtEmiPaymentAmt.Text,
                    Me.txtVeichleNum.Text)
            Else
                frmPaymentBill.Hide()
            End If
        Catch ex As Exception

        End Try
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
                txtVeichleNum.Text = v
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
                txtEmiPaymentAmt.Text = v
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

    Private Sub dtEmiPaymentDate_ValueChanged(sender As Object, e As EventArgs) Handles dtEmiPaymentDate.ValueChanged
        validateEmiDate()
        UpdateBill()

    End Sub

    Private Sub txtEmiPaymentAmt_TextChanged(sender As Object, e As EventArgs) Handles txtEmiPaymentAmt.TextChanged
        UpdateBill()
    End Sub

    Private Sub cboLoanStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanStatus.SelectedIndexChanged
        UpdateBill()
    End Sub

    Private Sub txtAmtInWords_TextChanged(sender As Object, e As EventArgs) Handles txtAmtInWords.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub cboEmiId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboEmiId.SelectedIndexChanged
        validateEmiId()
        validateEmiDate()
        UpdateBill()
    End Sub

    Private Sub cboPaymentType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPaymentType.SelectedIndexChanged
        UpdateBill()
    End Sub

    Private Sub dtEmiDate_ValueChanged(sender As Object, e As EventArgs) Handles dtEmiDate.ValueChanged
        validateEmiDate()
    End Sub

    Private Sub validateEmiDate()
        If Me.cboPaymentType.SelectedItem = "CUST PAY IN" Then
            If dtEmiDate.Value > DateAdd("d", 1, dtLoanClose.Value) Then
                MsgBox("Emi Date should not greater then Loan Close Date")
                dtEmiDate.Value = DateAdd("d", 1, dtLoanClose.Value)
                cboEmiId.SelectedItem = txtEmiMonths.Text
            End If
        End If
    End Sub

    Private Sub validateEmiId()
        If Me.cboPaymentType.SelectedItem = "CUST PAY IN" Then
            If (CInt(cboEmiId.SelectedItem) > CInt(txtEmiMonths.Text)) Then
                MsgBox("Emi Id should not greater then Loan Emi Months")
                cboEmiId.SelectedIndex = 1
            End If

        End If
    End Sub

End Class