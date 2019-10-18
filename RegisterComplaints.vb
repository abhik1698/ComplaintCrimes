Public Class RegisterComplaints
    Private Sub RegisterComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim User = Login.uname.Text
        Label1.Text = "Welcome " & User & ", thank for your interest." & vbCrLf & " Please do fill in these Details about the Crime Witnessed!"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If crimeb.Text <> "" Then
            Dim Q = New Queries
            Dim qry As String = "insert into criminals_record(name, crime, location, status, comments) values('" & cname.Text & "', '" & crimeb.Text & "', '" & mlocation.Text & "', 'complaint', '" & comments.Text & "')"
            Q.InsertQuery(qry)

            MessageBox.Show("Complaint Registered Successfully")
            Me.Close()
            Login.Show()
        Else
            MessageBox.Show("Fill in the details!")
        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class