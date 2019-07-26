Imports MySql.Data.MySqlClient

Public Class Lunch
    Dim query As String
    Dim Mysqlconn As MySqlConnection
    Dim reader As MySqlDataReader
    Dim Command
    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Me.Close()
    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub lblMax_Click(sender As Object, e As EventArgs) Handles lblMax.Click
        WindowState = FormWindowState.Maximized
    End Sub


    Private Sub Lunch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GroupBoxDesserts.Enabled = False
        GroupBoxFastMealandVeg.Enabled = False
    End Sub

    Private Sub btnFastMealandVeg_Click(sender As Object, e As EventArgs) Handles btnFastMealandVeg.Click
        GroupBoxFastMealandVeg.Enabled = True
        GroupBoxDesserts.Enabled = False
    End Sub

    Private Sub btnDessert_Click(sender As Object, e As EventArgs) Handles btnDessert.Click
        GroupBoxDesserts.Enabled = True
        GroupBoxFastMealandVeg.Enabled = False
    End Sub

    Private Sub btnDrinks_Click_1(sender As Object, e As EventArgs) Handles btnDrinks.Click
        DrinksAndShakes.Show()
    End Sub

    Private Sub cbFries_CheckedChanged(sender As Object, e As EventArgs) Handles cbFries.CheckedChanged


    End Sub



    Private Sub cbSalad_CheckedChanged(sender As Object, e As EventArgs) Handles cbSalad.CheckedChanged

    End Sub

    Private Sub btnOrderLunch_Click(sender As Object, e As EventArgs) Handles btnOrderLunch.Click
        If cbFries.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbFries.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbSalad.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbSalad.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbHamburger.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbHamburger.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbChickSalad.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.ordered (lunch,ltime) values('" & cbChickSalad.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbFishSand.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbFishSand.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbCheeseSand.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbCheeseSand.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbChickSand.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbChickSand.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbChickPiza.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (lunch,ltime) values('" & cbChickPiza.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbHashBrown.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (dessert,dtime) values('" & cbHashBrown.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbToastedBagel.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (dessert,dtime) values('" & cbToastedBagel.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbPineStick.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (dessert,dtime) values('" & cbPineStick.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbChoMuffin.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (dessert,dtime) values('" & cbChoMuffin.Text & "','" & TimeOfDay & "')"

                Command = New MySqlCommand(query, Mysqlconn)
                reader = Command.ExecuteReader

                MessageBox.Show("data sent to chef")
                reader.Close()
                Mysqlconn.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        ElseIf cbPanSyrp.Checked = True Then
            Try
                Mysqlconn = New MySqlConnection
                Mysqlconn.ConnectionString = "server=localhost;userid=root;password=root;database=misge"
                Mysqlconn.Open()
                Dim query As String

                query = "insert into misge.lunch (dessert,dtime) values('" & cbPanSyrp.Text & "','" & TimeOfDay & "')"

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

    Private Sub cbHamburger_CheckedChanged(sender As Object, e As EventArgs) Handles cbHamburger.CheckedChanged

    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Chef.Show()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Waiter.Show()
    End Sub
End Class