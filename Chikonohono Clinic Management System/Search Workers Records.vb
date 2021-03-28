Imports System.Data.OleDb

Public Class Search_Workers_Records
    Dim search As String
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Dim Com As New OleDbCommand(Nothing, con)
    Dim da As New OleDbDataAdapter(Com)
    Dim ds As New DataSet
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox1.Text
        If search = "" Then
            Exit Sub
        Else
            If search <> "" Then
                GrpBoxResults.Visible = True
                Com.CommandText = "select * FROM [workers records] WHERE [First Name]= " & "'" & search & "'"

                Try
                    ds.Clear()
                    da.Fill(ds) 'dataset 
                    con.Close()
                Catch ex As Exception

                    con.Close()
                    Exit Sub
                End Try

                Try


                    txtNational_id.Text = (ds.Tables(0).Rows(0)("National ID"))
                    txtFirst_Name.Text = (ds.Tables(0).Rows(0)("First Name"))
                    txtSurname.Text = (ds.Tables(0).Rows(0)("Surname"))
                    date_of_birth.Text = (ds.Tables(0).Rows(0)("Date Of Birth"))
                    txtProfession.Text = (ds.Tables(0).Rows(0)("Profession"))
                    txtAddress.Text = (ds.Tables(0).Rows(0)("Address"))
                    txtContact_Number.Text = (ds.Tables(0).Rows(0)("Contact Number"))
                    ComboBoxGender.Text = (ds.Tables(0).Rows(0)("Gender"))

                Catch ex As Exception
                    Err.Clear()
                    Exit Sub
                End Try
            End If
        End If
        Try
            con.Close()
        Catch ex As Exception
            con.Open()
            con.Close()
        End Try
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Clinic_Management_Menu.Show()
        Me.Close()
    End Sub

    Private Sub Search_Workers_Records_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'GrpBoxResults.Visible = False
        'btnProduce_Report.Visible = False
    End Sub

End Class