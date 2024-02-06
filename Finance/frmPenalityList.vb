Imports System.Drawing.Printing
Imports System.IO
Imports System.Net
Imports System.Reflection.Metadata
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class frmPenalityList
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


                dgPenalityList.Rows.Insert(J, New String() {MyArray(0), MyArray(1), MyArray(2), MyArray(3)})
                'MyArray(9), MyArray(10), MyArray(11), MyArray(12), MyArray(13), MyArray(14), MyArray(15), 


            End If
        Next J

        Try
            Me.dgPenalityList.Rows(UBound(MyData) - 1).DefaultCellStyle.BackColor = Color.Yellow
        Catch

        End Try

    End Sub
    Public Sub OpenAllPenalityList()



        Me.Show()

        Me.dgPenalityList.Rows.Clear()

        Call FetchEmiDetail("http://localhost:9091/loan/penalitylist", "|")
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Me.Show()
        dgPenalityList.Location = New Point(0, 50)
        Me.dgPenalityList.Rows.Clear()
        Dim text As String
        text = txtSearch.Text.Trim()
        If (text = "") Then
            text = "|"
        End If
        Call FetchEmiDetail("http://localhost:9091/loan/penalitylist", text)
    End Sub

    Private Sub ExportAsPDF()
        Dim pdfTable As New PdfPTable(dgPenalityList.ColumnCount)
        pdfTable.DefaultCell.Padding = 3

        Dim widths As Single() = {0, 0, 0, 0}

        Dim j As Integer = 0
        For Each column As DataGridViewColumn In dgPenalityList.Columns
            widths(j) = column.Width
            j += 1
        Next

        pdfTable.SetWidthPercentage(widths, PageSize.A4)

        pdfTable.HorizontalAlignment = Element.ALIGN_CENTER
        pdfTable.DefaultCell.BorderWidth = 1
        pdfTable.HeaderRows = 1 'Add header for each page


        'Adding Header  
        For Each column As DataGridViewColumn In dgPenalityList.Columns
            Dim cell As New PdfPCell(New Phrase(column.HeaderText))
            cell.BackgroundColor = iTextSharp.text.BaseColor.LIGHT_GRAY
            pdfTable.AddCell(cell)
        Next

        'Adding DataRow
        Dim cellvalue As String = ""
        Dim i As Integer = 0
        For Each row As DataGridViewRow In dgPenalityList.Rows
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
        Dim font As Font = New Font(Font.FontFamily.HELVETICA, 16, FontStyle.Bold)

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

    Private Sub PrintPdf()
        Dim psi As New ProcessStartInfo
        psi.UseShellExecute = True
        psi.Verb = "print"
        psi.WindowStyle = ProcessWindowStyle.Normal
        'MsgBox(PrintDialog1.PrinterSettings.PrinterName.ToString())
        psi.Arguments = PrintDialog1.PrinterSettings.PrinterName.ToString()
        psi.FileName = "C://PDFs/" & Me.Text & ".pdf"
        'MsgBox(psi.FileName)
        Process.Start(psi)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            ExportAsPDF()
            MsgBox("Exported Successfully")
        Catch
            MsgBox("Export Not Done")
        End Try
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Try
            ExportAsPDF()
            PrintPdf()
            MsgBox("Exported As PDF and Printed Successfully")
        Catch
            MsgBox("Export Not Done")
        End Try
    End Sub

    Private Sub dgPenalityList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPenalityList.CellContentClick

    End Sub
End Class