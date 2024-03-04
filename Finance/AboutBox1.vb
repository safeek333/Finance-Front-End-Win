Imports System.IO
Imports System.Net

Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Set the title of the form.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("About {0}", ApplicationTitle)
        ' Initialize all of the text displayed on the About Box.
        ' TODO: Customize the application's assembly information in the "Application" pane of the project 
        '    properties dialog (under the "Project" menu).
        Me.LabelProductName.Text = "Product Name: " + My.Application.Info.ProductName
        Me.LabelVersion.Text = String.Format("Version: {0}", My.Application.Info.Version.ToString)
        Me.LabelCopyright.Text = "Copyright © SAFA Software Solutions."
        Me.LabelCompanyName.Text = "Company Name: ®SAFA Software Solutions"
        Me.TextBoxDescription.Text = "  The application belongs to ®SAFA Software Solutions. This front end solution is for Windows Platform dependently work with one or more backends. The product is Licenced and valid for 1 year(s) initially. The id of this product is " & GenLic()
    End Sub

    Public Function GenLic()
        Try
            Dim URL As Object
            URL = "http://localhost:9091/loan/lic/f4eb05ce5953bd9b02cb6b8bea11c3c5"
            Dim myReq As HttpWebRequest
            Dim myResp As HttpWebResponse
            Dim myReader As StreamReader
            myReq = HttpWebRequest.Create(URL)
            myReq.Method = "GET"
            myResp = myReq.GetResponse
            myReader = New System.IO.StreamReader(myResp.GetResponseStream)
            Dim rec = myReader.ReadToEnd
            'MsgBox(URL & " / emi date :  " & rec)
            GenLic = rec
            'SplitCustRecToView(rec)
            'txtLoanNum.ReadOnly = True
        Catch ex As Exception
            'MsgBox("Error: " & ex.Message)
            GenLic = "Offline"
        End Try

    End Function

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

    Private Sub TextBoxDescription_TextChanged(sender As Object, e As EventArgs) Handles TextBoxDescription.TextChanged

    End Sub
End Class
