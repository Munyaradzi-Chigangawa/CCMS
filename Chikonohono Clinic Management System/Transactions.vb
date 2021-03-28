Imports System.Data.OleDb
Public Class Transactions
    Dim Con As New OleDbConnection
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Patient_Bill_Information.Show()
        Me.Close()
    End Sub

    Private Sub Transactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/ccms.mdb")
        Con.Open()

        Show_Records()

    End Sub
    Private Sub Show_Records()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from [bill info]", Con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        Con.Close()

    End Sub
End Class