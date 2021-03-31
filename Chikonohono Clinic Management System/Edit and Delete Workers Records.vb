Imports System.Data.OleDb

Public Class Edit_and_Delete_Workers_Records
    Dim search As String
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Dim Com As New OleDbCommand(Nothing, con)
    Dim dr As New OleDbDataAdapter(Com)
    Dim ds As New DataSet
    Dim sk As String
    Dim DataSet1 As New DataSet
    Dim Str As String
    Dim M As String
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Clinic_Management_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox1.Text
        If search = "" Then
            MsgBox("The Search field cant be empty.", MsgBoxStyle.Exclamation)
        Else
            If search <> "" Then
                GrpBoxResults.Visible = True
                Com.CommandText = "select * FROM [workers records] WHERE [First Name]= " & "'" & search & "'"
                'GrpBoxResults.Visible = True
                Try
                    ds.Clear()
                    dr.Fill(ds) 'dataset 
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
                    ComboBoxGender.Text = (ds.Tables(0).Rows(0)("Gender"))
                    txtProfession.Text = (ds.Tables(0).Rows(0)("Profession"))
                    txtAddress.Text = (ds.Tables(0).Rows(0)("Address"))
                    txtContact_Number.Text = (ds.Tables(0).Rows(0)("Contact Number"))

                Catch ex As Exception
                    Err.Clear()
                    Exit Sub
                End Try
            End If
        End If
        Try
        Catch ex As Exception
            con.Open()
            con.Close()
        End Try
    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Dim SavInto As New OleDb.OleDbCommand
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        SavInto.Connection = con
        SavInto.CommandType = CommandType.Text
        M = TextBox1.Text
        SavInto.CommandText = "UPDATE [workers records] SET [National ID]='" & Trim(txtNational_id.Text) & "',[First Name]='" & Trim(txtFirst_Name.Text) & "',[Surname]='" & Trim(txtSurname.Text) & "',[Date Of Birth]='" & Trim(date_of_birth.Text) & "',[Gender]='" & Trim(ComboBoxGender.Text) & "',[Address]= '" & Trim(txtAddress.Text) & "',[Contact Number]= '" & Trim(txtContact_Number.Text) & "',[Profession]= '" & Trim(txtProfession.Text) & "'WHERE [First Name] ='" & M & "'"
        con.Open()
        SavInto.ExecuteNonQuery()
        con.Close()
        MsgBox("Worker's Details Successfully updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

    Private Sub btnDelete_Record_Click(sender As Object, e As EventArgs) Handles btnDelete_Record.Click
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        Dim SavInto As New OleDb.OleDbCommand
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                SavInto.Connection = con
                SavInto.CommandType = CommandType.Text
                SavInto.CommandText = "DELETE FROM [workers records] WHERE [First Name] ='" & Trim(txtFirst_Name.Text) & "'"
                con.Open()
                SavInto.ExecuteNonQuery()
                DataSet1.Clear()
                MsgBox("Worker Successfully Deleted From the Database.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class