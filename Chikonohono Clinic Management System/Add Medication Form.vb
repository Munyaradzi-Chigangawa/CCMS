Imports System.Data.OleDb
Public Class Add_Medication_Form
    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myconnection As OleDbConnection = New OleDbConnection
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dispensary.Show()
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Call Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        provider = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source ="
        datafile = "|DataDirectory|\ccms.mdb"
        connString = provider & datafile
        myconnection.ConnectionString = connString
        myconnection.Open()

        Dim str As String

        str = "insert into [dispensary] ([Code], [Name], [Quantity], [Description], [Handler], [Manufacture Date],[Expiry Date]) values (?, ?, ?, ?, ?, ?, ?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, myconnection)
        cmd.Parameters.Add(New OleDbParameter("Code", CType(txtCode.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Name", CType(txtName.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Quantity", CType(txtQuantity.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Description", CType(txtDescription.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Handler", CType(txtHandler.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Manufacture Date", CType(DTPManufacture_date.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Expiry Date", CType(DTPExpiry_Date.Text, String)))

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            myconnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        myconnection.Close()
        MsgBox("Mecication Record Successfully added.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Successful")
        Call Clear()
    End Sub

    Public Sub Clear()
        txtCode.Clear()
        txtName.Clear()
        txtQuantity.Clear()
        txtHandler.Clear()
        txtDescription.Clear()
        DTPManufacture_date.Value = Date.Now
        DTPExpiry_Date.Value = Date.Now
    End Sub

    Private Sub txtCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCode.KeyPress

    End Sub

    Private Sub txtQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantity.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsDigit(e.KeyChar)) Then
                'do nothing


            Else
                e.Handled = True
                MsgBox("Sorry Only Digits Allowed!!", MsgBoxStyle.Information, "Verify")
                txtQuantity.Focus()
            End If
        End If
    End Sub

    Private Sub txtName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtName.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtName.Focus()

            End If
        End If

    End Sub

    Private Sub txtDescription_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescription.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtDescription.Focus()

            End If
        End If

    End Sub

    Private Sub txtHandler_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtHandler.KeyPress
        If (Char.IsControl(e.KeyChar) = False) Then
            If (Char.IsLetter(e.KeyChar)) Or (Char.IsWhiteSpace(e.KeyChar)) Then
                'do nothing

            Else
                e.Handled = True
                MsgBox("Sorry Only Character & Spaces Allowed!!", MsgBoxStyle.Information, "Verify")
                txtHandler.Focus()

            End If
        End If

    End Sub

End Class