Imports System.Data
Imports MySql.Data.MySqlClient


Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub lblMax_Click(sender As Object, e As EventArgs) Handles lblMax.Click
        WindowState = FormWindowState.Maximized
    End Sub

    Private Sub lblMin_Click(sender As Object, e As EventArgs) Handles lblMin.Click
        WindowState = FormWindowState.Normal
    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs) Handles lblExit.Click
        Application.Exit()
    End Sub


    Private Sub btnLunch_Click(sender As Object, e As EventArgs) Handles btnLunch.Click
        Lunch.Show()
    End Sub

    Private Sub btnBreakfast_Click_1(sender As Object, e As EventArgs) Handles btnBreakfast.Click
        Breakfast.Show()
    End Sub
End Class
