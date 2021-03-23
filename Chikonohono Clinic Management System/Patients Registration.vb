Imports System.Data.OleDb
Public Class Patients_Registration_Form
    'Declaring variables which allows VB to interface with the MS Access Database.
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Dim sex As String

    Public Sub Clear()
        'This function serves the purpose to clear the related fields after data entry has been made.  
        txtReg_No.Clear()
        txtNational_id.Clear()
        txtFirst_Name.Clear()
        txtSurname.Clear()
        RB_Male.Checked = False
        RB_Female.Checked = False
        txtAddress.Clear()
        txtContact_Number.Clear()
        txtDisease.Clear()
        txt_Remarks.Clear()
        CB_Bloodgp.SelectedIndex = -1
        txtDoctor.Clear()
        date_of_birth.Value = Date.Now
    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Window.Show()
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call Clear()
    End Sub

    Private Sub btnAdd_Patient_Click(sender As Object, e As EventArgs) Handles btnAdd_Patient.Click
        If Len(Trim(txtReg_No.Text)) = 0 Then
            MessageBox.Show("Sorry Registration Number cannot be empty.", "Registration Number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtReg_No.Focus()
        End If

        If Len(Trim(txtFirst_Name.Text)) = 0 Then
            MessageBox.Show("Sorry First Name cannot be empty.", "First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtFirst_Name.Focus()
        End If

        If Len(Trim(txtNational_id.Text)) = 0 Then
            MessageBox.Show("Sorry National Identity cannot be empty.", "National Identity", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtNational_id.Focus()
        End If

        If Len(Trim(txtAddress.Text)) = 0 Then
            MessageBox.Show("Sorry Surname cannot be empty.", "Surname", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSurname.Focus()

            If Len(Trim(txtAddress.Text)) = 0 Then
                MessageBox.Show("Address cannot be empty.", "Address", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtAddress.Focus()
            End If
        End If

        Try
            'Generating ConnectionString to connect to MS Access Database.
            provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
            datafile = "|DataDirectory|\ccms.mdb"
            connString = provider & datafile
            myconnection.ConnectionString = connString
            myconnection.Open()

            Dim str As String
            'Adding textbox, radio buttons , combo box and date time picker data into MS Access Database
            str = "insert into [patient records] ([Registration Number], [National ID], [First Name], [Surname], [Date Of Birth], [Address], [Contact Number], [Blood Group], [Doctor], [Disease], [Remarks], [Gender]) values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
            cmd.Parameters.Add(New OleDbParameter("Registration Number", CType(txtReg_No.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("National ID", CType(txtNational_id.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("First Name", CType(txtFirst_Name.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Surname", CType(txtSurname.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Date Of Birth", CType(date_of_birth.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Address", CType(txtAddress.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Contact Number", CType(txtContact_Number.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Blood Group", CType(CB_Bloodgp.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Doctor", CType(txtDoctor.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Disease", CType(txtDisease.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Remarks", CType(txt_Remarks.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Gender", CType(sex, String)))
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            myconnection.Close()
            MsgBox("Patient Successfully added", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Patient Registration")
            'Record Successfully Added into the Database.
            Call Clear()
        Catch ex As Exception

        End Try


    End Sub

    Private Sub RB_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Male.CheckedChanged
        sex = "Male"
    End Sub

    Private Sub RB_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Female.CheckedChanged
        sex = "Female"
    End Sub

    Private Sub txtReg_No_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReg_No.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'if numbers are inserted then do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Information, "Registration Number")
                txtRegistration_Number.Focus()
                'This textbox does not allow text to be inserted into the field. 
            End If
        End If
    End Sub

    Private Sub txtContact_Number_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact_Number.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'if numbers are inserted then do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Information, "Contact Number")
                txtContact_Number.Focus()
            End If
        End If
    End Sub

    Private Sub txtFirst_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirst_Name.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "First Name")
                txtFirst_Name.Focus()

            End If
        End If

    End Sub

    Private Sub txtSurname_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSurname.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Surname")
                txtSurname.Focus()

            End If
        End If

    End Sub

    Private Sub txtSurname_TextChanged(sender As Object, e As EventArgs) Handles txtSurname.TextChanged

    End Sub

    Private Sub txtDoctor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDoctor.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Doctor")
                txtDoctor.Focus()

            End If
        End If

    End Sub

    Private Sub txtDoctor_TextChanged(sender As Object, e As EventArgs) Handles txtDoctor.TextChanged

    End Sub

    Private Sub txtDisease_TextChanged(sender As Object, e As EventArgs) Handles txtDisease.TextChanged

    End Sub

    Private Sub txt_Remarks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Remarks.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Remarks")
                txt_Remarks.Focus()

            End If
        End If

    End Sub

    Private Sub txt_Remarks_TextChanged(sender As Object, e As EventArgs) Handles txt_Remarks.TextChanged

    End Sub

    Private Sub txtReg_No_TextChanged(sender As Object, e As EventArgs) Handles txtReg_No.TextChanged


    End Sub
End Class