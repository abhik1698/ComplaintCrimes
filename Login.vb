﻿Public Class Login
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Q = New Queries
        Dim qry = "select count(*) from users where uname='" & uname.Text & "'and pwd='" & pwd.Text & "'"
        Dim res As Integer = Q.Login(qry)
        If (res = 0) Then
            MessageBox.Show("Invalid Credentials")
        Else
            RegisterComplaints.Show()
            Me.Close()
        End If

    End Sub

    Private Sub pwd_TextChanged(sender As Object, e As EventArgs) Handles pwd.TextChanged

    End Sub

    Private Sub uname_TextChanged(sender As Object, e As EventArgs) Handles uname.TextChanged

    End Sub
End Class