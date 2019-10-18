Imports MySql.Data.MySqlClient

Public Class CMap
    Private Sub CMap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mtable.ColumnCount = 1
        mtable.Columns(0).Name = "Locations"
        Try
            Dim conn As New MySql.Data.MySqlClient.MySqlConnection("server=127.0.0.1;uid=root;port=3306;database=crime")
            conn.Open()

            Dim myAdapter As New MySqlDataAdapter

            Dim myCommand As New MySqlCommand("select location from criminals_record", conn)

            myAdapter.SelectCommand = myCommand
            Dim myData As MySqlDataReader

            myData = myCommand.ExecuteReader()
            If myData.HasRows Then
                While myData.Read()
                    Dim row As String() = New String() {myData(0).ToString}
                    mtable.Rows.Add(row)
                End While

            End If
            conn.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class