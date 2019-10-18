Imports MySql.Data.MySqlClient

Public Class SignUp
    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qry As String = "insert into users(uname, name, pwd) values('" & uname.Text & "', '" & fname.Text & "', '" & pwd.Text & "')"

        Try
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(qry, conn)
            cmd.ExecuteScalar()
            MessageBox.Show("User account Ready to Login!")
            conn.Close()
            Me.Close()
            Login.Show()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Username Already Exists")
        End Try
    End Sub
End Class