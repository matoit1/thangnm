Public Class Inport
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim strConnection As System.Data.OleDb.OleDbConnection
        Dim myPath As String = fupImportExcel.PostedFile.FileName
        Dim dsData As New DataSet
        Dim dt As New DataTable
        Dim objAdapter As System.Data.OleDb.OleDbDataAdapter
        strConnection = New System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source='" & myPath & " '; " & "Extended Properties=Excel 8.0;")
        strConnection.Open()
        dt = strConnection.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, New Object() {Nothing, Nothing, Nothing, Nothing})
        objAdapter = New System.Data.OleDb.OleDbDataAdapter(String.Format("SELECT * FROM [{0}]",
        dt.Rows(0).Item("TABLE_NAME")), strConnection)
        objAdapter.Fill(dsData)
        GridView1.DataSource = dsData
        GridView1.DataBind()
    End Sub
End Class