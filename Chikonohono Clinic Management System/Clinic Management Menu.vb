Public Class Clinic_Management_Menu

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Main_Window.Show()
        Me.Close()
    End Sub

    Private Sub btnAddWorkers_Click(sender As Object, e As EventArgs) Handles btnAddWorkers.Click
        Workers_Registration.Show()
        Me.Close()
    End Sub

    Private Sub btnViewWorkers_Click(sender As Object, e As EventArgs) Handles btnViewWorkers.Click
        View_Workers.Show()
        Me.Close()
    End Sub

    Private Sub btnSearchWorkers_Click(sender As Object, e As EventArgs) Handles btnSearchWorkers.Click
        Search_Workers_Records.Show()
        Me.Close()
    End Sub

    Private Sub btnEditDeleteWorkers_Click(sender As Object, e As EventArgs) Handles btnEditDeleteWorkers.Click
        Edit_and_Delete_Workers_Records.Show()
        Me.Close()
    End Sub
End Class