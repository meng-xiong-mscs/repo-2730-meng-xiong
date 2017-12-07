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
            lblDays.Text = intDaysInMonth(intMonthNumber - 1).ToString
        Else
            MessageBox.Show("Invalid month. Enter a number from 1 to 12.", "Month", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        txtMonth.Focus()
        txtMonth.SelectAll()
    End Sub
    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty

        Dim dblavg As Double
        Dim inttotal As Integer = 0
        For intnum As Integer = 0 To intsold.GetUpperBound(0)
            inttotal += intsold(intnum)
        Next intnum
        dblavg = inttotal / 4
        lblAvg.Text = dblavg.ToString

        For intnum As Integer = 0 To intsold.GetUpperBound(0)
            If intsold(intnum) < dblavg Then
                lblLessThanAvg.Text &= intsold(intnum).ToString() & ", "
            End If
        Next intnum
    End Sub

    Private Sub btnForEachNext_Click(sender As Object, e As EventArgs) Handles btnForEachNext.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim dblavg As Double
        Dim inttotal As Integer = intsold.GetUpperBound(0)
        For Each intnum As Integer In intsold
            inttotal += intnum
        Next intnum
        dblavg = inttotal / 4
        lblAvg.Text = dblavg.ToString
        For Each intnum As Integer In intsold
            If intsold(intnum) < dblavg Then
                lblLessThanAvg.Text &= intsold(intnum).ToString() & ", "
            End If
        Next intnum
    End Sub

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        lblAvg.Text = String.Empty
        lblLessThanAvg.Text = String.Empty
        Dim dblavg As Double
        Dim inttotalsub As Integer
        Dim intavg As Integer
        Dim inttotal As Integer = intsold.GetUpperBound(0)
        Do While inttotalsub <= inttotal
            intavg += intsold(inttotalsub)
            inttotalsub += 1
        Loop
        dblavg = intavg / 4
        lblAvg.Text = dblavg.ToString
        Do While inttotalsub <= inttotal
            If intsold(inttotalsub) < dblavg Then
                lblLessThanAvg.Text &= intsold(inttotalsub).ToString() & ", "
            End If
        Loop
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRetail_Click(sender As Object, e As EventArgs) Handles btnRetail.Click
        'dblWholeSale(0) = 100.0
        Dim dblsale As Double
        Dim strbox As String
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            Do While dblsale < 0.01 Or dblsale > 1.0
                strbox = InputBox("Mark Up", "Enter Mark Up Rate")
                Double.TryParse(strbox, dblsale)
                lstRetail.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
            Loop
        Next intSub
    End Sub

    Private Sub btnWholesale_Click(sender As Object, e As EventArgs) Handles btnWholesale.Click
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            dblWholeSale(intSub) = Convert.ToDouble(lstWholesale.Items(intSub))
        Next intSub
        lstRetail.Items.Clear()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intSub As Integer = 0 To dblWholeSale.GetUpperBound(0)
            lstWholesale.Items.Add(dblWholeSale(intSub).ToString("n2").PadLeft(6))
        Next intSub
    End Sub
End Class
