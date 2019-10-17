Public Class RegisterComplaints
    Private Sub RegisterComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim User = Login.uname.Text
        MessageBox.Show("Hey there, " & User)
    End Sub
End Class