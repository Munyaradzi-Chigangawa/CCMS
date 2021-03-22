Public Class Patient_Records_Menu

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Main_Window.Show()
        Me.Close()
    End Sub

    Private Sub Search_Click(sender As Object, e As EventArgs) Handles Search.Click
        Search_Patient_Records.Show()
        Me.Close()
    End Sub

    Private Sub viewrecords_Click(sender As Object, e As EventArgs) Handles viewrecords.Click
        Existing_Patients_Records.Show()
        Me.Close()
    End Sub

    Private Sub btnEdit_and_Update_Click(sender As Object, e As EventArgs) Handles btnEdit_or_Delete_patient_record.Click
        Edit_and_Update_Patient_Records.Show()
        Me.Close()
    End Sub

    Private Sub btnGenerate_Report_Click(sender As Object, e As EventArgs) Handles btnGenerate_Report.Click

    End Sub
End Class