Imports MySql.Data.MySqlClient
Public Class Waiter
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command
    Private Sub txtFinish_TextChanged(sender As Object, e As EventArgs) Handles txtFinish.TextChanged

    End Sub

    Private Sub Waiter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'Mysqlconn = New MySqlConnection
            'Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
            'Mysqlconn.Open()
            ' Dim query As String

            'query = "select * from misge.ordered (finish)"

            ' Command = New MySqlCommand(query, Mysqlconn)
            ' reader = Command.ExecuteReader

            'MessageBox.Show("based on the priority the order is completed")
            'reader.Close()
            ' Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnOrderCompleted_Click(sender As Object, e As EventArgs) Handles btnOrderCompleted.Click
        Try
            Mysqlconn = New MySqlConnection
            Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
            Mysqlconn.Open()
            Dim query As String
        
            query = "select * from (driandsha , lunch , beeanwin , breakefast)"

            Command = New MySqlCommand(query, Mysqlconn)
            reader = Command.ExecuteReader
            MessageBox.Show(query)
            'MessageBox.Show("based on the priority the order is completed")
            reader.Close()
            Mysqlconn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class