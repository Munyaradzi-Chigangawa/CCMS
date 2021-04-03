Imports System.Data.OleDb
Public Class Workers_Registration
    Dim sex As String

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Clinic_Management_Menu.Show()
        Me.Close()
    End Sub

    Private Sub RB_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Male.CheckedChanged
        If RB_Male.Checked Then
            sex = "Male"
        End If
    End Sub

    Private Sub RB_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Female.CheckedChanged
        If RB_Female.Checked Then
            sex = "Female"
        End If
    End Sub

    Private Sub btnAdd_Worker_Click(sender As Object, e As EventArgs) Handles btnAdd_Worker.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        datafile = "|DataDirectory|\ccms.mdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()

        Dim str As String

        str = "insert into [workers records] ([National ID], [First Name], [Surname], [Date Of Birth], [Address], [Contact Number],[Profession] ,[Gender] ) values (?, ?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("National ID", CType(txtNational_id.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("First Name", CType(txtFirst_Name.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Surname", CType(txtSurname.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date Of Birth", CType(date_of_birth.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Address", CType(txtAddress.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Contact Number", CType(txtContact_Number.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Profession", CType(txtProfession.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Gender", CType(sex, String)))
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()
        MsgBox("Worker Successfully added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Worker's Registration")
        Call Clear()
    End Sub

    Public Sub Clear()
        txtNational_id.Clear()
        txtFirst_Name.Clear()
        txtSurname.Clear()
        date_of_birth.Value = Date.Now
        txtAddress.Clear()
        txtContact_Number.Clear()
        txtProfession.Clear()
        RB_Male.Checked = False
        RB_Female.Checked = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
    End Sub

    Private Sub txtFirst_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirst_Name.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtFirst_Name.Focus()

            End If
        End If

    End Sub

    Private Sub txtContact_Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact_Number.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing


            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Information, "Verify")
                txtContact_Number.Focus()

            End If
        End If
    End Sub

    Private Sub txtContact_Number_TextChanged(sender As Object, e As EventArgs) Handles txtContact_Number.TextChanged

    End Sub

    Private Sub txtFirst_Name_TextChanged(sender As Object, e As EventArgs) Handles txtFirst_Name.TextChanged

    End Sub

    Private Sub txtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSurname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtSurname.Focus()

            End If
        End If

    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged

    End Sub

    Private Sub txtProfession_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProfession.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtProfession.Focus()

            End If
        End If

    End Sub

    Private Sub txtProfession_TextChanged(sender As Object, e As EventArgs) Handles txtProfession.TextChanged

    End Sub
End Class