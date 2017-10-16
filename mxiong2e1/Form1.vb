Public Class Form1
    Private Sub txtcard_TextChanged(Sender As Object, e As EventArgs) Handles txtCard.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim dblOrder As Double
        Dim dblShipping As Double
        Double.TryParse(txtOrder.Text, dblOrder)

        Dim creditcard As String
        Dim Yes As String
        creditcard = txtCard.Text
        txtCard.Text = creditcard.ToUpper
        Yes = "Y"

        If ((dblOrder >= 100) And (Yes = creditcard)) Then
            dblShipping = 0
        Else
            dblShipping = 9

        End If
        lblShipping.Text = dblShipping.ToString("c")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim dblOrder As Double
        Dim dblShipping As Double
        Double.TryParse(txtOrder.Text, dblOrder)

        Dim creditcard As String
        Dim Yes As String
        creditcard = txtCard.Text
        txtCard.Text = creditcard.ToUpper
        Yes = "Y"

        If ((dblOrder >= 100) Or (Yes = creditcard)) Then
            dblShipping = 0
        Else
            dblShipping = 9

        End If
        lblShipping.Text = dblShipping.ToString("c")
    End Sub

    Private Sub btnCalcEql_Click(sender As Object, e As EventArgs) Handles btnCalcEql.Click
        Dim A1 As Integer
        Dim B2 As Integer
        Dim C3 As Integer
        Dim dblsales As Integer
        Dim dblCommission As Integer
        Double.TryParse(txtSales.Text, dblsales)


        Dim idLetters As String
        idLetters = txtID.Text
        txtID.Text = idLetters.ToUpper

        If ((A1 >= 25000) And (B2 >= 25000) And (C3 >= 25000)) Then
            dblCommission = 0.15 * dblsales
        Else
            dblCommission = 0.12 * dblsales
        End If

        lblCommission.Text = dblCommission.ToString("C")

    End Sub

    Private Sub btnCalcNotEql_Click(sender As Object, e As EventArgs) Handles btnCalcNotEql.Click
        Dim A1 As Integer = 25000
        Dim B2 As Integer = 25000
        Dim C3 As Integer = 25000
        Dim dblsales As Integer
        Dim dblCommission As Integer
        Double.TryParse(txtSales.Text, dblsales)

        Dim idLetters As String
        idLetters = txtID.Text
        txtID.Text = idLetters.ToUpper

        If ((A1 >= 25000) And (B2 >= 25000) And (C3 >= 25000)) Then
            dblCommission = 0.15 * dblsales
        ElseIf ((A1 <> 25000) And (B2 <> 25000) And (C3 <> 25000)) Then
            dblCommission = 0.12 * dblsales
        Else
            dblCommission = 0.12 * dblsales
        End If

        lblCommission.Text = dblCommission.ToString("C")
    End Sub
End Class
