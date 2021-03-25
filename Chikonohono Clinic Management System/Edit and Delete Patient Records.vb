Imports System.Data.OleDb

Public Class Edit_and_Update_Patient_Records
    Private search As String
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Private Com As New OleDbCommand(Nothing, con)
    Private dr As New OleDbDataAdapter(CoM)
    Private ds As New DataSet
    Private sk As String
    Dim DataSet1 As New DataSet
    Dim Str As String
    Dim sex, M As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Patient_Records_Menu.Show()
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox1.Text
        If search = "" Then
            Exit Sub
        Else
            If search <> "" Then

                Com.CommandText = "select * FROM [patient records] WHERE [First Name]= " & "'" & search & "'"
                GrpBoxResults.Visible = True
                Try
                    ds.Clear()
                    dr.Fill(ds) 'dataset 
                    con.Close()
                Catch ex As Exception

                    con.Close()
                    Exit Sub
                End Try

                Try

                    txtRegistration_Number.Text = (ds.Tables(0).Rows(0)("Registration Number"))
                    txtNational_id.Text = (ds.Tables(0).Rows(0)("National ID"))
                    txtFirst_Name.Text = (ds.Tables(0).Rows(0)("First Name"))
                    txtSurname.Text = (ds.Tables(0).Rows(0)("Surname"))
                    date_of_birth.Text = (ds.Tables(0).Rows(0)("Date Of Birth"))
                    ComboBoxGender.Text = (ds.Tables(0).Rows(0)("Gender"))
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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete_Record.Click
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        Dim SavInto As New OleDb.OleDbCommand
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                SavInto.Connection = con
                SavInto.CommandType = CommandType.Text
                SavInto.CommandText = "DELETE FROM [patient records] WHERE [First Name] ='" & Trim(txtFirst_Name.Text) & "'"
                con.Open()
                SavInto.ExecuteNonQuery()
                DataSet1.Clear()
                MsgBox("Patient Successfully Deleted From the Database.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

       
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Dim SavInto As New OleDb.OleDbCommand
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        SavInto.Connection = con
        SavInto.CommandType = CommandType.Text
        M = TextBox1.Text
        SavInto.CommandText = "UPDATE [patient records] SET [Registration Number]='" & Trim(txtRegistration_Number.Text) & "',[National ID]='" & Trim(txtNational_id.Text) & "',[First Name]='" & Trim(txtFirst_Name.Text) & "',[Surname]='" & Trim(txtSurname.Text) & "',[Gender]='" & Trim(ComboBoxGender.Text) & "',[Date Of Birth]='" & Trim(date_of_birth.Text) & "',[Address]= '" & Trim(txtAddress.Text) & "',[Contact Number]= '" & Trim(txtContact_Number.Text) & "',[Blood Group]= '" & Trim(CB_Bloodgp.Text) & "',[Doctor]= '" & Trim(txtDoctor.Text) & "',[Disease]= '" & Trim(txtDisease.Text) & "',[Remarks]= '" & Trim(txt_Remarks.Text) & "'WHERE [First Name] ='" & M & "'"
        con.Open()
        SavInto.ExecuteNonQuery()
        con.Close()
        MsgBox("Patient Details Successfully updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub

End Class