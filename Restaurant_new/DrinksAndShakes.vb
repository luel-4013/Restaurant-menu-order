Imports MySql.Data.MySqlClient

Public Class DrinksAndShakes
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command
    Private Sub DrinksAndShakes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxDrinks.Enabled = False
        GroupBoxShakes.Enabled = False
        ' GroupBoxDrinks.Visible = True
        'GroupBoxShakes.Visible = True
    End Sub

    Private Sub btnDrinks_Click(sender As Object, e As EventArgs) Handles btnDrinks.Click
        GroupBoxDrinks.Enabled = True
        GroupBoxShakes.Enabled = False
        GroupBoxShakes.Visible = True
        GroupBoxDrinks.Visible = True
    End Sub

    Private Sub btnShakes_Click(sender As Object, e As EventArgs) Handles btnShakes.Click
        GroupBoxDrinks.Enabled = False
        GroupBoxShakes.Enabled = True
        GroupBoxShakes.Visible = True
        GroupBoxDrinks.Visible = True
    End Sub

    Private Sub btnBeerAndWine_Click(sender As Object, e As EventArgs) Handles btnBeerAndWine.Click
        BeerAndWine.Show()
    End Sub

    Private Sub btnOrderDrinksAndShakes_Click(sender As Object, e As EventArgs) Handles btnOrderDrinksAndShakes.Click
        If cbTea.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (drinks,dtime) values('" & cbTea.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbCoffee.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (drinks,dtime) values('" & cbCoffee.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbCola.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (drinks,dtime) values('" & cbCola.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbOrange.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (drinks,dtime) values('" & cbOrange.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbBottelWater.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (drinks,dtime) values('" & cbBottelWater.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbVannillaCone.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (shakes,stime) values('" & cbVannillaCone.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbVanillaShake.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (shakes,stime) values('" & cbVanillaShake.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbStrawShake.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (shakes,stime) values('" & cbStrawShake.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbChocoMilkShake.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.driandsha (shakes,stime) values('" & cbChocoMilkShake.Text & "','" & TimeOfDay & "')"

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