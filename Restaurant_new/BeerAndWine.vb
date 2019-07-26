Imports MySql.Data.MySqlClient

Public Class BeerAndWine
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command

    Private Sub BeerAndWine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxBeer.Enabled = False
        GroupBoxWine.Enabled = False
    End Sub


    Private Sub btnBeer_Click(sender As Object, e As EventArgs) Handles btnBeer.Click
        GroupBoxBeer.Enabled = True
        GroupBoxWine.Enabled = False
    End Sub

    Private Sub btnWine_Click(sender As Object, e As EventArgs) Handles btnWine.Click
        GroupBoxBeer.Enabled = False
        GroupBoxWine.Enabled = True
    End Sub

    Private Sub btnOrderBeerAndWine_Click(sender As Object, e As EventArgs) Handles btnOrderBeerAndWine.Click
        If cbHeienken.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbHeienken.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbGuienes.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbGuienes.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbMetaBeer.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbMetaBeer.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbBedeleBeer.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbBedeleBeer.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbGiorgis.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbGiorgis.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbDashenBeer.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbDashenBeer.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbWaliyaBeer.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (beer,btime) values('" & cbWaliyaBeer.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbAwashBig.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbAwashBig.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbAwashSmall.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbAwashSmall.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbGuderBig.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbGuderBig.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbGuderSmall.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbGuderSmall.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbAxumaiteBig.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbAxumaiteBig.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbAxumaiteSmall.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.beeanwin (wine,wtime) values('" & cbAxumaiteSmall.Text & "','" & TimeOfDay & "')"

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