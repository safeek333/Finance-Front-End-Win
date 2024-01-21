Imports System.IO
Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.Extensions.DependencyModel.Resolution
Imports Nancy.Json

Public Class frmNewLoanReg
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
            Dim loanNumber As String
            loanNumber = myReader.ReadToEnd
            txtLoanNum.Text = loanNumber
            txtLoanNum.ReadOnly = True
            If Me.btnSave.Text = "Save" Then
                MsgBox("Loan Creted with Loan Number " & loanNumber)
            ElseIf Me.btnSave.Text = "Update" Then
                MsgBox("Loan Updated for Loan Number " & loanNumber)
            End If
            Me.btnSave.Text = "Update"
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
                txtGarandorAddr.Text = v
            End If
            If I = 4 Then
                txtLoanAmt.Text = v
            End If
            If I = 5 Then
                txtDocCharge.Text = v
            End If
            If I = 6 Then
                txtEmiAmount.Text = v
            End If
            If I = 7 Then
                txtEmiMonths.Text = v
            End If
            If I = 8 Then
                txtVeichleType.Text = v
            End If
            If I = 9 Then
                txtAFC.Text = v
            End If
            If I = 10 Then
                txtInsDetails.Text = v
            End If

            If I = 11 Then
                txtPrincipleAmt.Text = v
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
        Me.lblTitle.Text = Me.lblTitle.Text & " (Update)"
        Me.btnSave.Text = "Update"
    End Sub

    'Below is for Customer to Fetch
    Public Sub FetchCustomerDetail(URL As Object, reqString As String)
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
            SplitCustRecToView(rec)
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub
    'Below is for Customer Record to View
    Public Sub SplitCustRecToView(Rec As String)
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
                'txtCustId.Enabled = False
            End If

            If I = 5 Then
                txtCustAddr.Text = v
            End If

        Next I
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Call Try01("http://localhost:9091/loan/loannew",
                   "{""loanNumber"":""" & txtLoanNum.Text &
                   """,""veichleNumber"":""" & txtVeichleNum.Text &
                   """,""customerAddress"":""" & txtCustAddr.Text &
                   """,""garandorAddress"":""" & txtGarandorAddr.Text &
                   """,""loanAmount"":""" & txtLoanAmt.Text &
                   """,""documentCharge"":""" & txtDocCharge.Text &
                   """,""emiAmount"":""" & txtEmiAmount.Text &
                   """,""emiMonths"":""" & txtEmiMonths.Text &
                   """,""veichleType"":""" & txtVeichleType.Text &
                   """,""afc"":""" & txtAFC.Text &
                   """,""insuranceDetails"":""" & txtInsDetails.Text &
                   """,""principleAmount"":""" & txtPrincipleAmt.Text &
                   """,""loanStartDate"":""" & dtLoanStart.Value &
                   """,""loanCloseDate"":""" & dtLoanClose.Value &
                   """,""loanStatus"":""" & cboLoanStatus.SelectedItem &
                   """}")

    End Sub

    Private Sub frmNewLoanReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetFormValues()
    End Sub

    Private Sub ResetFormValues()
        txtLoanIntrestPercent.Text = "24.00"
        txtDocumentPercent.Text = "6.00"
        txtLoanAmt.Text = "0.00"
        txtDocCharge.Text = "0.00"
        txtEmiAmount.Text = "0.00"
        txtEmiMonths.Text = "10"
        txtPrincipleAmt.Text = "0.00"
        dtLoanStart.Value = Today
        dtLoanClose.Value = Today
        txtLoanNum.Enabled = False
        cboLoanStatus.SelectedIndex = 0
        txtVeichleNum.Text = "NA"
        txtVeichleType.Text = "NA"
        txtInsDetails.Text = "NA"
        txtCustAddr.Text = "NA"
        txtGarandorAddr.Text = "NA"
        LoanIntPerMonthUpdate()
        CloseDateUpdate()
    End Sub


    Private Sub txtEmiMonths_TextChanged(sender As Object, e As EventArgs) Handles txtEmiMonths.TextChanged
        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtEmiMonths.Text) Then
            EmiAmountUpdate(CDbl(txtLoanAmt.Text), CInt(txtEmiMonths.Text))
        End If
        CloseDateUpdate()
    End Sub

    Private Sub CloseDateUpdate()
        Try
            dtLoanClose.Value = DateAdd(DateInterval.Month, CDbl(txtEmiMonths.Text), dtLoanStart.Value)
            dtLoanClose.Value = DateAdd(DateInterval.Day, -1, dtLoanClose.Value)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub EmiAmountUpdate(loanAmount As Double, emiMonth As Integer)
        Try
            If emiMonth > 0 Then
                txtEmiAmount.Text = FormatNumber(loanAmount / emiMonth, 2,,, vbFalse)
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub dtLoanStart_ValueChanged(sender As Object, e As EventArgs) Handles dtLoanStart.ValueChanged
        CloseDateUpdate()
    End Sub

    Private Sub DocumentChargeUpdate(loanAmt As Double, docPercent As Double)
        Try
            txtDocCharge.Text = loanAmt * docPercent / 100.0
        Catch ex As Exception

        End Try

    End Sub

    Private Sub PrincipleAmountUpdate(loanAmt As Double, docCharge As Double)
        Try
            txtPrincipleAmt.Text = loanAmt - docCharge
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DocumentPercentUpdate(loanAmt As Double, docCharge As Double)
        Try
            If loanAmt > 0 Then
                txtDocumentPercent.Text = FormatNumber(docCharge / loanAmt * 100, 2,,, vbFalse)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLoanAmt_TextChanged(sender As Object, e As EventArgs) Handles txtLoanAmt.TextChanged
        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocumentPercent.Text) Then
            DocumentChargeUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocumentPercent.Text))
        End If

        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocCharge.Text) Then
            PrincipleAmountUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocCharge.Text))
        End If

        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtEmiMonths.Text) Then
            EmiAmountUpdate(CDbl(txtLoanAmt.Text), CInt(txtEmiMonths.Text))
        End If

    End Sub

    Private Sub txtDocumentPercent_TextChanged(sender As Object, e As EventArgs) Handles txtDocumentPercent.TextChanged
        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocumentPercent.Text) Then
            DocumentChargeUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocumentPercent.Text))
        End If

        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocCharge.Text) Then
            PrincipleAmountUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocCharge.Text))
        End If
    End Sub

    Private Sub LoanIntPerMonthUpdate()
        Try
            If IsNumeric(txtLoanIntrestPercent.Text) Then
                lblLoanIntPerMonth.Text = FormatNumber(CDbl(txtLoanIntrestPercent.Text) / 12.0, 2,,, vbFalse) & "% pm"
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtLoanIntrestPercent_TextChanged(sender As Object, e As EventArgs) Handles txtLoanIntrestPercent.TextChanged
        LoanIntPerMonthUpdate()


    End Sub

    Private Sub txtDocCharge_TextChanged(sender As Object, e As EventArgs) Handles txtDocCharge.TextChanged
        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocCharge.Text) Then
            PrincipleAmountUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocCharge.Text))

        End If
    End Sub

    Private Sub txtEmiAmount_TextChanged(sender As Object, e As EventArgs) Handles txtEmiAmount.TextChanged

    End Sub

    Private Sub btnEditDocCharge_Click(sender As Object, e As EventArgs) Handles btnEditDocCharge.Click
        txtDocCharge.Text = FormatNumber(InputBox("Enter Value for Document Charge", "Value Change"), 2,,, vbFalse)
        If IsNumeric(txtLoanAmt.Text) And IsNumeric(txtDocCharge.Text) Then
            DocumentPercentUpdate(CDbl(txtLoanAmt.Text), CDbl(txtDocCharge.Text))
        End If
    End Sub

    Private Sub btnNewCust_Click(sender As Object, e As EventArgs) Handles btnNewCust.Click
        frmNewCust.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetFormValues()
    End Sub

    Private Sub cboLoanStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLoanStatus.SelectedIndexChanged

    End Sub

    Private Sub btnLoadCustAddr_Click(sender As Object, e As EventArgs) Handles btnLoadCustAddr.Click
        Call FetchCustomerDetail("http://localhost:9091/loan/custedit",
                   "{""customerId"":""" & txtCustId.Text &
                   """}")
    End Sub
End Class