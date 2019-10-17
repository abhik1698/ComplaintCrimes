Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient

Public Class Queries
    Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")

    Public Sub InsertQuery(q As String)
        Try
            conn.Open()

            Dim cmd As MySqlCommand = New MySqlCommand(q, conn)
            cmd.ExecuteScalar()

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Function Login(q As String) As String
        Try
            conn.Open()

            Dim myAdapter As New MySqlDataAdapter

            Dim myCommand As New MySqlCommand(q, conn)

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader

            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                myData.Read()
                Dim count As Integer = myData(0)
                Return count
            End If

        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try

        Return 0
    End Function
End Class
