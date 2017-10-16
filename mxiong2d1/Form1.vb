'Name:          Ch4 Lesson B, If statements. message boxes
'Purpose:       Currency, Tea, Electric, Quotient
'Programmer:    Meng Xiong on 10/10/2017




Public Class Form1
    Private Sub btnConvertEq_Click(sender As Object, e As EventArgs) Handles btnConvertEq.Click
        'Convert American dollars to Euro, the British pound, and the South African rand

        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblpound As Double
        Dim dblrand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblAmDollar)

        If dblAmDollar = 0 Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            dblEuro = dblEURO_RATE * dblAmDollar
            dblpound = dblPOUND_RATE * dblAmDollar
            dblrand = dblRAND_RATE * dblAmDollar

            'display charges
            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblpound.ToString("c2")
            lblRand.Text = dblrand.ToString("c2")
        End If


    End Sub

    Private Sub brnConvertNE_Click(sender As Object, e As EventArgs) Handles brnConvertNE.Click
        Const dblEURO_RATE As Double = 0.9
        Const dblPOUND_RATE As Double = 0.79
        Const dblRAND_RATE As Double = 13.89
        Dim dblAmDollar As Double
        Dim dblEuro As Double
        Dim dblpound As Double
        Dim dblrand As Double

        lblEuro.Text = String.Empty
        lblPound.Text = String.Empty
        lblRand.Text = String.Empty

        Double.TryParse(txtAmDollar.Text, dblAmDollar)

        If dblAmDollar <> 0 Then
            MessageBox.Show("Please enter the number of American dollars.",
                            "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Else

            dblEuro = dblEURO_RATE * dblAmDollar
            dblpound = dblPOUND_RATE * dblAmDollar
            dblrand = dblRAND_RATE * dblAmDollar

            'display charges
            lblEuro.Text = dblEuro.ToString("c2")
            lblPound.Text = dblpound.ToString("c2")
            lblRand.Text = dblrand.ToString("c2")
        End If
    End Sub

    Private Sub btnCalcTea_Click(sender As Object, e As EventArgs) Handles btnCalcTea.Click

        Dim dblOrdered As Double
        Dim dblPrice As Double
        Dim dblTotalDue As Double
        Dim dblShipping As Double = 0.0

        Double.TryParse(txtOrdered.Text, dblOrdered)
        Double.TryParse(txtPrice.Text, dblPrice)

        Dim dialogresult As DialogResult
        dialogresult = MessageBox.Show("Charge for Shipping?", "Shipping",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If dialogresult = Windows.Forms.DialogResult.Yes Then
            dblShipping = 15.0
        End If

        dblTotalDue = dblOrdered * dblPrice + dblShipping

        'Display result
        lblTotalDue.Text = dblTotalDue.ToString("c2")




    End Sub

    Private Sub btnCalcElectric_Click(sender As Object, e As EventArgs) Handles btnCalcElectric.Click
        Const dblRATE As Double = 0.13
        Dim dblPrevious As Double
        Dim dblCurrent As Double
        Dim dblBill As Double

        Double.TryParse(txtPrevious.Text, dblPrevious)
        Double.TryParse(txtCurrent.Text, dblCurrent)

        txtCurrent.Text = String.Empty
        txtPrevious.Text = String.Empty

        'Message Box
        If dblCurrent < dblPrevious Then
            MessageBox.Show("The current reading must be greater than or equal to the previous reading", "Triple County",
                       MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else


            dblBill = dblRATE * (dblCurrent - dblPrevious)

            lblBill.Text = dblBill.ToString("c2")
        End If

    End Sub

    Private Sub btnQuot_Click(sender As Object, e As EventArgs) Handles btnQuot.Click
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intQuotient As Integer

        Integer.TryParse(txtNum1.Text, intNum1)
        Integer.TryParse(txtNum2.Text, intNum2)

        If intNum1 > intNum2 Then
            Dim intTemp As Integer
            intTemp = intNum1
            intNum1 = intNum2
            intNum2 = intTemp
        End If

        If intNum1 = 0 Then
            MessageBox.Show("Cannot divide by 0", "Division by 0",
                MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            intQuotient = intNum2 / intNum1
            lblQuotient.Text = intQuotient.ToString()

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
