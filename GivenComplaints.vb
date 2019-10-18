Imports MySql.Data.MySqlClient

Public Class GivenComplaints

    Private Sub mtable_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles mtable.CellContentClick

    End Sub

    Private Sub GivenComplaints_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtable.ColumnCount = 6
        mtable.Columns(0).Name = "ID"
        mtable.Columns(1).Name = "Name"
        mtable.Columns(2).Name = "Crime"
        mtable.Columns(3).Name = "Location"
        mtable.Columns(4).Name = "Status"
        mtable.Columns(5).Name = "Comments"

        Try
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")
            conn.Open()

            Dim myAdapter As New MySqlDataAdapter

            Dim myCommand As New MySqlCommand("select * from criminals_record where status <> 'released'", conn)

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader

            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                While myData.Read()
                    Dim row As String() = New String() {myData(0).ToString, myData(1).ToString, myData(2).ToString, myData(3).ToString, myData(4).ToString, myData(5).ToString}
                    mtable.Rows.Add(row)
                End While

            End If
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim conn2 As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")
            conn2.Open()
            Dim myAdapter As New MySqlDataAdapter

            Dim st As String
            If Arr.Checked Then
                st = "Arrested"
            ElseIf Rel.Checked Then
                st = "Released"
            Else
                st = "Remove"
            End If
            Dim myCommand As New MySqlCommand("update criminals_record set status='" & st & "' where id= '" & id.Text & "' and status<>'released'", conn2)

            myAdapter.UpdateCommand = myCommand
            Dim u = myCommand.ExecuteReader()
            u.Close()

            Dim dCommand As New MySqlCommand("delete from criminals_record where status='Remove'", conn2)
            myAdapter.UpdateCommand = myCommand
            Dim d = dCommand.ExecuteReader
            d.Close()

            mtable.ColumnCount = 0
            mtable.ColumnCount = 6
            mtable.Columns(0).Name = "ID"
            mtable.Columns(1).Name = "Name"
            mtable.Columns(2).Name = "Crime"
            mtable.Columns(3).Name = "Location"
            mtable.Columns(4).Name = "Status"
            mtable.Columns(5).Name = "Comments"
            Dim myAdapter2 As New MySqlDataAdapter
            Dim myCommand2 As New MySqlCommand("select * from criminals_record where status='Complaint' or status='Arrested'", conn2)
            myAdapter2.SelectCommand = myCommand2
            Dim myData2 As MySqlDataReader
            myData2 = myCommand2.ExecuteReader()
            If myData2.HasRows Then
                While myData2.Read()
                    Dim row As String() = New String() {myData2(0).ToString, myData2(1).ToString, myData2(2).ToString, myData2(3).ToString, myData2(4).ToString, myData2(5).ToString}
                    mtable.Rows.Add(row)
                End While
            End If
            conn2.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class