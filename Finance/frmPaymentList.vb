Imports System.IO
Imports System.Net
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmPaymentList
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
                Rec = Rec.Replace("null", "")
                MyArray = Split(Rec, "|")
                'iterate through the array created to show each value


                dgPaymentList.Rows.Insert(J, New String() {MyArray(0), MyArray(1), MyArray(2), MyArray(3), MyArray(4)})
                'MyArray(9), MyArray(10), MyArray(11), MyArray(12), MyArray(13), MyArray(14), MyArray(15), 


            End If
        Next J

        'Me.dgPaymentList.Rows(UBound(MyData) - 1).DefaultCellStyle.BackColor = Color.Yellow
    End Sub
    Public Sub OpenPaymentList(loanNum As Long)

        If (loanNum = 0) Then
            loanNum = InputBox("Enter Loan Number")
        End If

        Me.Show()

        Me.dgPaymentList.Rows.Clear()

        Call FetchEmiDetail("http://localhost:9091/loan/paymentlist",
                   "{""loanNumber"":""" & loanNum &
                   """}")
    End Sub

    Private Sub ExportAsPDF()
        Dim pdfTable As New PdfPTable(dgPaymentList.ColumnCount)
        pdfTable.DefaultCell.Padding = 3

        Dim widths As Single() = {0, 0, 0, 0, 0, 0}

        Dim j As Integer = 0
        For Each column As DataGridViewColumn In dgPaymentList.Columns
            widths(j) = column.Width - 25
            j += 1
        Next

        pdfTable.SetWidthPercentage(widths, PageSize.A4)

        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER
        pdfTable.DefaultCell.BorderWidth = 1
        pdfTable.HeaderRows = 1 'Add header for each page


        'Adding Header  
        For Each column As DataGridViewColumn In dgPaymentList.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        Dim cellvalue As String = ""
        Dim i As Integer = 0
        For Each row As DataGridViewRow In dgPaymentList.Rows
            For Each cell As DataGridViewCell In row.Cells
                cellvalue = cell.FormattedValue
                pdfTable.AddCell(Convert.ToString(cellvalue))
            Next
        Next

        'Exporting to PDF
        Dim folderPath As String = "C:\PDFs\"
        If Not Directory.Exists(folderPath) Then
            Directory.CreateDirectory(folderPath)
        End If
        Dim phrase As Phrase
        Dim font As Font = New Font(font.FontFamily.HELVETICA, 16, FontStyle.Bold)

        phrase = New Phrase(Me.Text & " Report", font)

        Using stream As New FileStream(folderPath & Me.Text & ".pdf", FileMode.Create)
            Dim pdfDoc As New iTextSharp.text.Document(PageSize.A4, 50.0F, 25.0F, 50.0F, 25.0F)

            PdfWriter.GetInstance(pdfDoc, stream)
            pdfDoc.Open()
            pdfDoc.Add(phrase)
            pdfDoc.Add(pdfTable)
            pdfDoc.Close()
            stream.Close()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ExportAsPDF()
            MsgBox("Exported Successfully")
        Catch
            MsgBox("Export Not Done")
        End Try
    End Sub
End Class