Imports MySql.Data.MySqlClient

Public Class Breakfast
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command
    Private Sub Breakfast_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOrderBreakfast_Click(sender As Object, e As EventArgs) Handles btnOrderBreakfast.Click
        If cbEggSand.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.breakefast (breakefast,brtime) values('" & cbEggSand.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbScrmEgg.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.breakefast (breakefast,brtime) values('" & cbScrmEgg.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbEggWthMeat.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.breakefast (breakefast,brtime) values('" & cbEggWthMeat.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbOmlete.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.breakefast (breakefast,brtime) values('" & cbOmlete.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub
End Class