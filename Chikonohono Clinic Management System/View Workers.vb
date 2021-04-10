Imports System.Data.OleDb
Public Class View_Workers
    Dim Con As New OleDbConnection
    Private Sub View_Workers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/ccms.mdb")
        Con.Open()

        Call Show_Records()

    End Sub
    Private Sub Show_Records()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from [workers records]", Con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        Con.Close()

    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Clinic_Management_Menu.Show()
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class