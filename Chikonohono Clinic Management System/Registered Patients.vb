Imports System.Data.OleDb

Public Class Registered_Patients
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=|DtaDirectory|/users.mdb"
    Dim MyConn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim source1 As New BindingSource
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyConn = New OleDbConnection
        MyConn.ConnectionString = connString
        ds = New DataSet
        tables = ds.Tables
        da = New OleDbDataAdapter("Select * from [records]", MyConn) 'Change items to your database name
        da.Fill(ds, "records") 'Change items to your database name
        Dim view As New DataView(tables(0))
        source1.DataSource = view
        DataGridView1.DataSource = view
    End Sub
End Class