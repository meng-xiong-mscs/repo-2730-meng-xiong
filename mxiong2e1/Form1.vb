Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dblOrder As Double
        Dim dblShipping As Double

        Double.TryParse(txtOrder.Text, dblOrder)

        Dim creditcard As String
        creditcard = txtCard.Text
        txtCard.Text = creditcard.ToUpper
        If creditcard.ToUpper = "Y" Then
            dblShipping = 0
        Else
            dblShipping = 9
        End If
        If dblOrder = 100 AndAlso creditcard = "Y" Then
            dblShipping = 0
            lblShipping.Text = dblShipping.ToString("c")
        End If

        If dblOrder < 100 AndAlso creditcard = "N" Then
            dblShipping = 9
            lblShipping.Text = dblShipping.ToString("c")

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dblOrder As Double
        Dim dblShipping As Double

        Double.TryParse(txtOrder.Text, dblOrder)

        Dim creditcard As String
        creditcard = txtCard.Text
        txtCard.Text = creditcard.ToUpper
        If creditcard.ToUpper = "Y" Then
            dblShipping = 0
        Else
            dblShipping = 9
        End If
        If dblOrder = 100 OrElse creditcard = "Y" Then
            dblShipping = 0
            lblShipping.Text = dblShipping.ToString("c")
        End If

        If dblOrder < 100 OrElse creditcard = "N" Then
            dblShipping = 9
            lblShipping.Text = dblShipping.ToString("c")

        End If
    End Sub

    Private Sub btnCalcEql_Click(sender As Object, e As EventArgs) Handles btnCalcEql.Click
        Const dblA1 As Double = 0.15
        Const dblB2 As Double = 0.15
        Const dblC3 As Double = 0.15
        Dim dblsales As Double
        Dim dblCommission As Double

        Double.TryParse(txtSales.Text, dblsales)

        Dim idLetters As String
        Dim A1 As String
        Dim B2 As String
        Dim C3 As String
        idLetters = txtID.Text
        txtID.Text = idLetters.ToUpper

        If idLetters = A1 AndAlso idLetters = B2 AndAlso idLetters = C3 Then
            dblCommission = dblsales * dblA1
        ElseIf dblCommission = dblsales * dblB2 Then
        ElseIf dblCommission = dblsales * dblC3 Then
        Else
            dblCommission = dblsales * 0.12
        End If


        'If dblsales > 100000 Then
        '    dblCommission = dblsales * dblA1
        'Else
        '    dblCommission = dblsales * 0.12
        '    lblCommission.Text = dblCommission.ToString("c")
        'End If

        'If dblsales > 100000 Then
        '    dblCommission = dblsales * dblB2
        'Else
        '    dblCommission = dblsales * 0.12
        '    lblCommission.Text = dblCommission.ToString("c")
        'End If

        'If dblsales > 100000 Then
        '    dblCommission = dblsales * dblC3
        'Else
        '    lblCommission.Text = dblsales * 0.12
        '    lblCommission.Text = dblCommission.ToString("c")

        'End If


    End Sub

    Private Sub btnCalcNotEql_Click(sender As Object, e As EventArgs) Handles btnCalcNotEql.Click

    End Sub
End Class
