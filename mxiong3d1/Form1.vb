'Name:          Exercise 3D: Array subscripts, totals, avg, min
'Purpose:       Displays the average number sold
'Programmer:    Meng Xiong on 12/1/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intsold() As Integer = {250, 225, 192, 260}
    Private dblWholeSale() As Double = {17.5, 9, 10.5, 18.75, 26, 8.5, 5.65, 10, 30}

    Private Sub btnDisplayDays_Click(sender As Object, e As EventArgs) Handles btnDisplayDays.Click

        Static intNum(11) As Integer
        Dim intMonthNumber As Integer
        Dim intDaysInMonth() As Integer = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31}
        If Integer.TryParse(txtMonth.Text, intMonthNumber) AndAlso intMonthNumber >= 1 AndAlso intMonthNumber <= 12 Then
            lblDays.Text = intDaysInMonth(intMonthNumber).ToString
        Else
            MessageBox.Show("Invalid month. Enter a number from 1 to 12.", "Month", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtMonth.Focus()
        txtMonth.SelectAll()
    End Sub
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        Dim dblavg As Double
        Dim inttotal As Integer = intsold.GetUpperBound(0)
        For intnum As Integer = 0 To inttotal
            dblavg = intnum + intsold(inttotal)
        Next intnum
        lblAvg.Text = dblavg.ToString
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click

    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
