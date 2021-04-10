Public Class Dispensary

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Main_Window.Show()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd_Medicine.Click
        Add_Medication_Form.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnView_Medication_Available.Click
        Existing_Medication_Records.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_Medication_Records_Click(sender As Object, e As EventArgs) Handles btnEdit_Medication_Records.Click
        Edit_and_Delete_Medication_Records.Show()
        Me.Close()
    End Sub
End Class