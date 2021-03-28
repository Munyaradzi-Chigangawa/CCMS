Imports System.Data.OleDb

Public Class Patient_Bill_Information
    Dim search As String
    Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\ccms.mdb;")
    Dim Com As New OleDbCommand(Nothing, con)
    Dim da As New OleDbDataAdapter(Com)
    Dim ds As New DataSet
    Dim connString As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtReg_No.Clear()
        txtPatient_Name.Clear()
        txtAmountPaid.Clear()
        txtAttendant.Clear()
        txtDiagnosis.Clear()
        txtChange.Clear()
        txtTotalBill.Clear()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Window.Show()
        Me.Close()


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        search = TextBox2.Text
        If search = "" Then
            MsgBox("The search field cannot be empty.", MsgBoxStyle.Exclamation)
        Else
            If search <> "" Then
                'Executing a query to select required data from the MS Access Database
                Com.CommandText = "select * FROM [patient records] WHERE [First Name]= " & "'" & search & "'"

                Try
                    ds.Clear()
                    da.Fill(ds) 'filling a dataset 
                    con.Close()
                Catch ex As Exception

                    con.Close()
                    Exit Sub
                End Try

                Try
                    'Adding Textbox, Combo Box, Radio buttons data and Date time picker data from MS Access database into corresponding VB.Net fields.
                    txtReg_No.Text = (ds.Tables(0).Rows(0)("Registration Number"))
                    txtPatient_Name.Text = (ds.Tables(0).Rows(0)("First Name") + (" ") + (ds.Tables(0).Rows(0)("Surname")))


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

    Private Sub txtReg_No_TextChanged(sender As Object, e As EventArgs) Handles txtReg_No.TextChanged
        lblReg_No.Text = txtReg_No.Text
    End Sub

    Private Sub txtPatient_Name_TextChanged(sender As Object, e As EventArgs) Handles txtPatient_Name.TextChanged
        lblPatient_Name.Text = txtPatient_Name.Text
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_and_time.Text = DateTime.Now.ToString("dd - MM - yyyy , HH:mm:ss")
    End Sub

    Private Sub txtChange_TextChanged(sender As Object, e As EventArgs) Handles txtChange.TextChanged
        lblChange.Text = txtChange.Text
    End Sub

    Private Sub txtAmountPaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountPaid.TextChanged
        lblAmountPaid.Text = txtAmountPaid.Text
    End Sub

    Private Sub txtTotalBill_TextChanged(sender As Object, e As EventArgs) Handles txtTotalBill.TextChanged
        lblTotalBill.Text = txtTotalBill.Text
    End Sub

    Private Sub txtAttendent_TextChanged(sender As Object, e As EventArgs) Handles txtAttendant.TextChanged
        lblAttendant.Text = txtAttendant.Text
    End Sub

    Private Sub txtDiagnosis_TextChanged(sender As Object, e As EventArgs) Handles txtDiagnosis.TextChanged
        lblDiagnosis.Text = txtDiagnosis.Text
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\users.mdb;"
        con.ConnectionString = connString

        con.Open()
        Dim str As String
        'Adding textbox data into MS Access Database
        str = "insert into [bill info] ([Registration Number], [Patient Name], [Attendant], [Diagnosis], [Amount Paid], [Total Bill], [Change]) values (?,?,?,?,?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("Registration Number", CType(txtReg_No.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Patient Name", CType(txtPatient_Name.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Attendant", CType(txtAttendant.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Diagnosis", CType(txtDiagnosis.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Total Bill", CType(txtTotalBill.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Amount Paid", CType(txtAmountPaid.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Change", CType(txtChange.Text, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
        MsgBox("Transaction Successfully Processed", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Transaction")
        'Record Successfully Added into the Database.
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        Transactions.Show()
        Me.Hide()
    End Sub
End Class