Imports System.Data.OleDb

Public Class Login_Form
    'declaration of variables
    Dim con As OleDbConnection, cmd As OleDbCommand
    Dim provider As String
    Dim datafile As String
    Dim str As String

#Region "Variable"
    Public Shared counter As Integer = 3
    Dim x As String = "Attempts Left : "

#End Region

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'initialising the connection string
        con = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source= |DataDirectory|\ccms.mdb")
        con.Open()
        str = "Select * from [user info] WHERE [Username] like '" & Trim(UsernameTextBox.Text) & _
       "' and [Password] like '" & Trim(PasswordTextBox.Text) & "' and [User type] like '" & Trim(cb_usertype.Text) & "';"

        cmd = New OleDbCommand(str, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader()

        If dr.HasRows = False Then
            MsgBox("Invalid Login Details. Please Provide your Login Details", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            fields_clear()
            counter = counter - 1
            Attempts.Text = x & counter

            If counter = 0 Then
                MsgBox("Unauthorised user. System Shutting Down", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "System Shutdown")
                Application.Exit()
            End If
        End If

        While (dr.Read())
            If (UsernameTextBox.Text = dr(0).ToString()) Or (PasswordTextBox.Text = dr(1).ToString()) And (cb_usertype.Text = dr(2).ToString()) Then
                MsgBox("Successfully Logged in, Welcome.", MessageBoxIcon.Information, "Login Successful.")
            End If
            Main_Window.Show()
            Me.Close()
        End While
        dr.Close()
        cmd = Nothing
        con.Close()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        End
    End Sub


    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Attempts.Text = x & counter
    End Sub

    Private Sub fields_clear()
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()
        cb_usertype.SelectedIndex = -1
    End Sub

    Private Sub CB_Show_Password_CheckedChanged(sender As Object, e As EventArgs) Handles CB_Show_Password.CheckedChanged
        If CB_Show_Password.Checked = True Then
            PasswordTextBox.PasswordChar = ""
        Else
            PasswordTextBox.PasswordChar = "•"
        End If
    End Sub

End Class
