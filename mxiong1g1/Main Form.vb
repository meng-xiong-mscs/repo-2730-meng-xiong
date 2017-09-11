' Name:             Average Project
' Purpose:          Displays the Average of 3 Test Scores
' Programmer:       Meng Xiong on 9/10/2017

Option Strict On

Public Class frmMain
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculates the Average Scores
        lblAverage.Text = Format((Val(txtTest1.Text)) + Val(txtTest2.Text) + Val(txtTest3.Text))
        lblAverage.Text = Format(Val(lblAverage.Text) / 3, "standard")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears all boxes
        txtTest1.Text = String.Empty
        txtTest2.Text = String.Empty
        txtTest3.Text = String.Empty
        lblAverage.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Exits out of the application
        Me.Close()
    End Sub
End Class
