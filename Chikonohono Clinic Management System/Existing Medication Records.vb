Imports System.Data.OleDb
Public Class Existing_Medication_Records
    Dim con As New OleDbConnection
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispensary.Show()
        Me.Close()
    End Sub

    Private Sub Existing_Medication_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/ccms.mdb")
        Con.Open()

        Show_Records()
    End Sub
    Public Sub Show_Records()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from [dispensary]", con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        con.Close()
    End Sub
End Class