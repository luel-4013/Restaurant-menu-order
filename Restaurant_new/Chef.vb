Imports MySql.Data.MySqlClient
Public Class Chef
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command
    Private Sub Chef_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOrderCompleted_Click(sender As Object, e As EventArgs) Handles btnOrderCompleted.Click
        Try
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
            Mysqlconn.Open()
            Dim query As String

            query = "insert into misge.ordered (finish) values('finished')"

            Command = New MySqlCommand(query, Mysqlconn)
            reader = Command.ExecuteReader

            MessageBox.Show("data sent to waiter")
            reader.Close()
            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class