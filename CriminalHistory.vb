Imports MySql.Data.MySqlClient

Public Class CriminalHistory
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim qry As String = "insert into pusers(uname, name, rank, pwd) values('" & uname.Text & "', '" & pname.Text & "', '" & rank.Text & "', '" & pwd.Text & "')"
        Try
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(qry, conn)
            cmd.ExecuteScalar()
            MessageBox.Show("User account Ready to Login!")
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show("Username Already Exists")
        End Try
    End Sub

    Private Sub CriminalHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtable.ColumnCount = 6
        mtable.Columns(0).Name = "ID"
        mtable.Columns(1).Name = "Name"
        mtable.Columns(2).Name = "Crime"
        mtable.Columns(3).Name = "Location"
        mtable.Columns(4).Name = "Status"
        mtable.Columns(5).Name = "Comments"

        Try

            conn.Open()

            Dim myAdapter As New MySqlDataAdapter

            Dim myCommand As New MySqlCommand("select * from criminals_record", conn)

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader

            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                While myData.Read()
                    Dim row As String() = New String() {myData(0).ToString, myData(1).ToString, myData(2).ToString, myData(3).ToString, myData(4).ToString, myData(5).ToString}
                    mtable.Rows.Add(row)
                End While

            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mtable.ColumnCount = 0
        mtable.ColumnCount = 6
        mtable.Columns(0).Name = "ID"
        mtable.Columns(1).Name = "Name"
        mtable.Columns(2).Name = "Crime"
        mtable.Columns(3).Name = "Location"
        mtable.Columns(4).Name = "Status"
        mtable.Columns(5).Name = "Comments"

        Try

            conn.Open()

            Dim myAdapter As New MySqlDataAdapter

            Dim myCommand As New MySqlCommand("select * from criminals_record where name like '" & searchText.Text & "%' or location like '" & searchText.Text & "%'", conn)

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader

            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                While myData.Read()
                    Dim row As String() = New String() {myData(0).ToString, myData(1).ToString, myData(2).ToString, myData(3).ToString, myData(4).ToString, myData(5).ToString}
                    mtable.Rows.Add(row)
                End While

            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class