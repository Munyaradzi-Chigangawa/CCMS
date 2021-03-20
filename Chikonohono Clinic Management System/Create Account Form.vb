Imports System.Data.OleDb
Public Class Create_Account_Form

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim str As String

    Private Sub btnCreate_Account_Click(sender As Object, e As EventArgs) Handles btnCreate_Account.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        datafile = "|DataDirectory|\ccms.mdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()

        If PasswordTextBox.Text <> txtconfirmpassword.Text Then
            MsgBox("Please confirm your password", MsgBoxStyle.Exclamation)
            txtconfirmpassword.Clear()
            PasswordTextBox.Clear()
        Else
            str = "insert into [user info] ([Username], [Password], [User type]) values (?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
            cmd.Parameters.Add(New OleDbParameter("Username", CType(UsernameTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(PasswordTextBox.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("User type", CType(cb_usertype.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            If cb_usertype.Text = "" Then
                MsgBox("Please select user type.", MsgBoxStyle.Exclamation)
            Else
                MsgBox("User Successfully added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "User Registration")

            End If
            myconnection.Close()

        End If
    End Sub


    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Main_Window.Show()
        Me.Close()
    End Sub


    Private Sub CB_Show_Password_CheckedChanged(sender As Object, e As EventArgs)
        If CB_Show_Password.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "•"
        End If
    End Sub
End Class
