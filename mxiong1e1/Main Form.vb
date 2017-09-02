'Name:          Richardson County Property Tax Project (mxiong1e1)
'Purpose:       Calculates Property Tax
'Programmer:    Meng Xiong on 9/1/2017


Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        ' calculate annual property tax
        lblTax.Text = Val(txtAssessed.Text)
        lblTax.Text = Val(lblTax.Text) * 0.015
        lblTax.Text = Format(lblTax.Text, "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clear the calculator for the next tax
        txtAssessed.Text = String.Empty
        lblTax.Text = String.Empty

        'send the focus to txtAssessed box
        txtAssessed.Focus()
    End Sub
End Class
