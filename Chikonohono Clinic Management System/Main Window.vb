Public Class Main_Window

    Private Sub Main_Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub
    Private Sub quit_Click(sender As Object, e As EventArgs) Handles quit.Click
        If MessageBox.Show("Please confirm shutting down the system!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub patientregistration_Click(sender As Object, e As EventArgs) Handles patientregistration.Click
        Patients_Registration_Form.Show()
        Me.Close()
    End Sub

    Private Sub existingpatientrecords_Click(sender As Object, e As EventArgs) Handles existingpatientrecords.Click
        Patient_Records_Menu.Show()
        Me.Close()
    End Sub

    Private Sub medicationavailable_Click(sender As Object, e As EventArgs) Handles medicationavailable.Click
        Dispensary.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Patient_Bill_Info.Click
        Patient_Bill_Information.Show()
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        date_and_time.Text = DateTime.Now.ToString("dddd dd MMMM yyyy , hh:mm:ss tt")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        If MessageBox.Show("Please confirm shutting down the system!", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub PatientRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PatientRegistrationToolStripMenuItem.Click
        Patients_Registration_Form.Show()
        Me.Show()
    End Sub

    Private Sub ViewRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewRecordsToolStripMenuItem.Click
        Existing_Patients_Records.Show()
        Me.Show()
    End Sub

    Private Sub SearchRecordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchRecordsToolStripMenuItem.Click
        Search_Patient_Records.Show()
        Me.Show()
    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Edit_and_Update_Patient_Records.Show()
        Me.Show()
    End Sub

    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        Add_Medication_Form.Show()
        Me.Show()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Existing_Medication_Records.Show()
        Me.Show()
    End Sub

    Private Sub SearchToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem1.Click
        Edit_and_Delete_Workers_Records.Show()
        Me.Show()
    End Sub

    Private Sub EditToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem2.Click
        Edit_and_Delete_Workers_Records.Show()
        Me.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
        Edit_and_Delete_Medication_Records.Show()
        Me.Close()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub btnClinic_Management_Click(sender As Object, e As EventArgs) Handles btnClinic_Management.Click
        Clinic_Management_Menu.Show()
        Me.Close()
    End Sub

    Private Sub AddToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem1.Click
        View_Workers.Show()
        Me.Close()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Workers_Registration.Show()
        Me.Close()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        If MessageBox.Show("Please confirm logging out of the System.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
            Login_Form.Show()
            Me.Close()
        End If
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub


    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click

    End Sub

    Private Sub CreateUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUsersToolStripMenuItem.Click
        Create_Account_Form.Show()
        Me.Hide()
    End Sub

    Private Sub ViewUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewUsersToolStripMenuItem.Click
        users.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        Edit_and_Update_Patient_Records.Show()
        Me.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Search_Workers_Records.Show()
        Me.Show()
    End Sub

    Private Sub EditToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem1.Click
        Edit_and_Delete_Workers_Records.Show()
        Me.Show()
    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Edit_and_Delete_Workers_Records.Show()
        Me.Show()
    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click
        Help.Show()
    End Sub

End Class