Imports System.Data.OleDb
Public Class Search_Patient_Records
    Dim search As String
    'declaration of variables and initialisation of the connection string
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Dim Com As New OleDbCommand(Nothing, con)
    Dim da As New OleDbDataAdapter(Com)
    Dim ds As New DataSet
    Dim sk As String
    Dim DataSet1 As New DataSet
    Dim Str As String
    Dim Gender As String
    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox1.Text
        If search = "" Then
            'the search textbox cannot be empty
            MsgBox("The search field cannot be empty.", MsgBoxStyle.Exclamation)
        Else
            If search <> "" Then
                'Executing a query to select required data from the MS Access Database
                Com.CommandText = "select * FROM [patient records] WHERE [First Name]= " & "'" & search & "'"

                Try
                    ds.Clear()
                    da.Fill(ds) 'filling the dataset 
                    con.Close()
                Catch ex As Exception

                    con.Close()
                    Exit Sub
                End Try

                Try
                    'Adding Textbox, Combo Box, Radio buttons data and Date time picker data from MS Access database into related VB.Net fields.
                    txtRegistration_Number.Text = (ds.Tables(0).Rows(0)("Registration Number"))
                    txtNational_id.Text = (ds.Tables(0).Rows(0)("National ID"))
                    txtFirst_Name.Text = (ds.Tables(0).Rows(0)("First Name"))
                    txtSurname.Text = (ds.Tables(0).Rows(0)("Surname"))
                    date_of_birth.Text = (ds.Tables(0).Rows(0)("Date Of Birth"))
                    ComboBox1.Text = (ds.Tables(0).Rows(0)("Gender"))
                    txtAddress.Text = (ds.Tables(0).Rows(0)("Address"))
                    txtContact_Number.Text = (ds.Tables(0).Rows(0)("Contact Number"))
                    CB_Bloodgp.Text = (ds.Tables(0).Rows(0)("Blood Group"))
                    txtDoctor.Text = (ds.Tables(0).Rows(0)("Doctor"))
                    txtDisease.Text = (ds.Tables(0).Rows(0)("Disease"))
                    txt_Remarks.Text = (ds.Tables(0).Rows(0)("Remarks"))


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

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Patient_Records_Menu.Show()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
