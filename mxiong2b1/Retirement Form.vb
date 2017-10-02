Public Class frmRetirement
    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Declarations
        Dim decWeeklyPay As Decimal
        Dim decEmployeeRate As Decimal
        Dim decEmployerRate As Decimal
        Dim intemploycontrib As Integer
        Dim intemployercontrib As Integer
        Dim inttotalcontrib As Integer


        'TryParse extractions
        Decimal.TryParse(txtGrossPay.Text, decWeeklyPay)
        Decimal.TryParse(txtEmployeeRate.Text, decEmployeeRate)
        Decimal.TryParse(txtEmployerRate.Text, decEmployerRate)
        Integer.TryParse(lblEmployeeContrib.Text, intemploycontrib)
        Integer.TryParse(lblEmployerContrib.Text, intemployercontrib)
        Integer.TryParse(lblTotalContrib.Text, inttotalcontrib)


        'Calculate Employee contributions
        intemploycontrib = decWeeklyPay * 52 * decEmployeeRate

        'To string Employee Contributions

        lblEmployeeContrib.Text = Convert.ToString(intemploycontrib)
        lblEmployeeContrib.Text = intemploycontrib.ToString("C2")
        lblEmployeeContrib.Text = "txtGrossPay.Txt" + txtEmployeeRate.Text

        'Calculate Employer contributions 
        intemployercontrib = decWeeklyPay * 52 * decEmployerRate

        'To string Employee Contributions
        lblEmployerContrib.Text = Convert.ToString(intemployercontrib)
        lblEmployerContrib.Text = (5).ToString("C2")


        'Calculate total annual contributions
        inttotalcontrib = intemploycontrib + intemployercontrib

        'To string Annual Contributions 
        lblTotalContrib.Text = Convert.ToString(inttotalcontrib)
        lblTotalContrib.Text = inttotalcontrib.ToString("C2")


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class