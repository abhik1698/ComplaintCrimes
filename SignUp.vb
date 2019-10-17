Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Q = New Queries
        Dim qry As String = "insert into users(uname, name, pwd) values('" & uname.Text & "', '" & pwd.Text & "', '" & fname.Text & "')"
        Q.InsertQuery(qry)

        MessageBox.Show("User account Ready to Login!")
        Me.Close()
        Login.Show()
    End Sub
End Class