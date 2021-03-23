Imports System.Data.OleDb

Public Class Existing_Patients_Records

    Dim Con As New OleDbConnection
    Private Sub Patients_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Con.ConnectionString = ("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=|DataDirectory|/ccms.mdb")
        Con.Open()

        Show_Records()

    End Sub
    Private Sub Show_Records()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As New OleDbDataAdapter

        da = New OleDbDataAdapter("select * from [patient records]", Con)
        da.Fill(dt)

        DataGridView1.DataSource = dt.DefaultView
        Con.Close()


    End Sub


    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Patient_Records_Menu.Show()
        Me.Close()
    End Sub
End Class