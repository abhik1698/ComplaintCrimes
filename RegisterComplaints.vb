Public Class RegisterComplaints
    Private Sub RegisterComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim User = Login.uname.Text
        MessageBox.Show("Hey there, " & User)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Q = New Queries
        Dim qry As String = "insert into criminals_record(name, crime, location, status, comments) values('" & cname.Text & "', '" & crimeb.Text & "', '" & location.Text & "', 'complaint', '" & comments.Text & "')"
        Q.InsertQuery(qry)

        MessageBox.Show("Complaint Registered Successfully")
        Me.Close()
        Login.Show()
    End Sub
End Class