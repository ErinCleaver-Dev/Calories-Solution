' Name:         Calories Project
' Purpose:      Display calorie information.
' Programmer:   <your name> on <current date>

'Name:  Erin Cleaver
'Date Completed:  1/10/2021
'Class:  Visual Basic Programming II CIS225.6306.W22

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' Display calorie information.

        Dim intCalories() As Integer = {2250, 1920, 2125, 2505, 2010, 1950, 1825,
                                        2025, 2000, 1820, 1990, 1950, 1875, 1750}
        Dim intTotal As Integer = 0
        Dim intCountAbove As Integer = 0
        Dim intCountBelow As Integer = 0
        Dim intCountSame As Integer = 0


        ' A for each loop that adds up the average
        For Each intCalorie As Integer In intCalories
            intTotal += intCalorie
        Next

        ' Finds the average using math and divding the total number of values by the lenght
        Dim intAverge As Integer = CInt(Math.Round(intTotal / intCalories.Length()))

        lblAvg.Text = intAverge.ToString()

        For Each intCalorie As Integer In intCalories
            If intCalorie > intAverge Then
                intCountAbove += 1
            ElseIf intCalorie < intAverge Then
                intCountBelow += 1
            ElseIf intCalorie = intAverge Then
                intCountSame += 1
            End If
        Next


        lblAboveAvg.Text = intCountAbove.ToString()
        lblBelowAvg.Text = intCountBelow.ToString()
        lblAtAvg.Text = intCountSame.ToString()

    End Sub


End Class
