Public Class SplashScreen

    Private Sub Progressbartimer_Tick(sender As Object, e As EventArgs) Handles Progressbartimer.Tick

        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 100 Then
            Progressbartimer.Stop()
            Login_Form.Show()
            Me.Hide()
        End If

        processing.Text = ProgressBar1.Value & "%"
        Dateandtime.Text = DateTime.Now.ToString("dddd dd MMMM yyyy , hh:mm:ss tt")

    End Sub

    Private Sub processing_Click(sender As Object, e As EventArgs) Handles processing.Click

    End Sub

    Private Sub Dateandtime_Click(sender As Object, e As EventArgs) Handles Dateandtime.Click

    End Sub

    Private Sub SplashScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
