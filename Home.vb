
Public Class Home
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SignUp.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Login.Show()
    End Sub

    Private Sub psignin_Click(sender As Object, e As EventArgs) Handles psignin.Click
        PLogin.Show()
    End Sub
End Class
