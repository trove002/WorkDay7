Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As Object, e As EventArgs) Handles btnPopulation.Click
        Dim pop As Double = 7000000000
        Dim year As Integer = 2014

        Do While pop >= 6000000
            pop = pop / 2
            year = year - 50
        Loop

        MessageBox.Show("The answer: The population was 6,000,000 in " & CStr(year))

    End Sub
End Class
