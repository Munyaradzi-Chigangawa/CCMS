Imports System.Data.OleDb
Public Class Edit_and_Delete_Medication_Records
    Private search As String
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Private Com As New OleDbCommand(Nothing, con)
    Private dr As New OleDbDataAdapter(CoM)
    Private ds As New DataSet
    Private sk As String
    Dim DataSet1 As New DataSet
    Dim Str, M As String
    Private Sub Back_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispensary.Show()
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox1.Text
        If search = "" Then
            Exit Sub
        Else
            If search <> "" Then

                Com.CommandText = "select * FROM [dispensary] WHERE [Name]= " & "'" & search & "'"

                Try
                    ds.Clear()
                    dr.Fill(ds) 'dataset 
                    con.Close()
                Catch ex As Exception

                    con.Close()
                    Exit Sub
                End Try

                Try

                    txtCode.Text = (ds.Tables(0).Rows(0)("Code"))
                    txtName.Text = (ds.Tables(0).Rows(0)("Name"))
                    txtQuantity.Text = (ds.Tables(0).Rows(0)("Quantity"))
                    txtDescription.Text = (ds.Tables(0).Rows(0)("Description"))
                    txtHandler.Text = (ds.Tables(0).Rows(0)("Handler"))
                    DTPManufacture_date.Text = (ds.Tables(0).Rows(0)("Manufacture Date"))
                    DTPExpiry_Date.Text = (ds.Tables(0).Rows(0)("Expiry Date"))

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

    Private Sub btnDelete_Record_Click(sender As Object, e As EventArgs) Handles btnDelete_Record.Click
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        Dim SavInto As New OleDb.OleDbCommand
        Try
            If MessageBox.Show("Do you really want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then

                SavInto.Connection = con
                SavInto.CommandType = CommandType.Text
                SavInto.CommandText = "DELETE FROM [dispensary] WHERE [Name] ='" & Trim(txtName.Text) & "'"
                con.Open()
                SavInto.ExecuteNonQuery()
                DataSet1.Clear()
                MsgBox("Record Successfully Deleted From the Database.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
                con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnUpdate_record_Click(sender As Object, e As EventArgs) Handles btnUpdate_record.Click
        Dim SavInto As New OleDb.OleDbCommand
        Dim DataAdpeter2 As New OleDbDataAdapter(Str, con)
        SavInto.Connection = con
        SavInto.CommandType = CommandType.Text
        M = TextBox1.Text
        SavInto.CommandText = "UPDATE [dispensary] SET [Code]='" & Trim(txtCode.Text) & "',[Name]='" & Trim(txtName.Text) & "',[Quantity]='" & Trim(txtQuantity.Text) & "',[Handler]='" & Trim(txtHandler.Text) & "',[Manufacture Date]='" & Trim(DTPManufacture_date.Text) & "',[Expiry Date]='" & Trim(DTPExpiry_Date.Text) & "'WHERE [Name] ='" & M & "'"
        con.Open()
        SavInto.ExecuteNonQuery()
        con.Close()
        MsgBox("Patient Details Successfully updated.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
    End Sub
End Class