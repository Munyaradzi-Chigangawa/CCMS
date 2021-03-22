Imports System.Data.OleDb
Public Class users
    Dim Con As New OleDbConnection
    Private Sub users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter
        Con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/ccms.mdb")
        Con.Open()
        da = New OleDbDataAdapter("select * from [user info]", Con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        Con.Close()

    End Sub
End Class