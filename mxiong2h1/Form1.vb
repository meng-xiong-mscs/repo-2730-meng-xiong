'Name: Marshal Sales Commission
'Purpose: Calculate Total Commission
'Programmer: Meng Xong on 10/23/2017


Public Class Form1
    Private Sub txtSales_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSales.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
                e.KeyChar <> ControlChars.Back AndAlso
                e.KeyChar <> "." Then
            'cancel the key
            e.Handled = True
        End If
    End Sub

    Private Sub btnCalc_IfThen_Click(sender As Object, e As EventArgs) Handles btnCalc_IfThen.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        End If

        If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        End If

        If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        End If

        If boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()

    End Sub

    Private Sub btnCalc_NestedIf_Click(sender As Object, e As EventArgs) Handles btnCalc_NestedIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        Else

            If boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
                dblCommissionOnly = dblSales * 0.1
            Else

                If boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
                    dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
                Else

                    If boolSalesOK AndAlso dblSales >= 30000.0 Then
                        dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14

                    End If
                End If
            End If
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub ClearCommission(sender As Object, e As EventArgs) Handles txtSales.TextChanged, chkMoreThan10.CheckedChanged, chkTravel.CheckedChanged
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty
    End Sub

    Private Sub btnCalc_IfElseIf_Click(sender As Object, e As EventArgs) Handles btnCalc_IfElseIf.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        If boolSalesOK AndAlso dblSales < 1.0 Then
            dblCommissionOnly = 0.0
        ElseIf boolSalesOK AndAlso dblSales >= 1.0 AndAlso dblSales < 6000.0 Then
            dblCommissionOnly = dblSales * 0.1
        ElseIf boolSalesOK AndAlso dblSales >= 6000.0 AndAlso dblSales < 30000.0 Then
            dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
        ElseIf boolSalesOK AndAlso dblSales >= 30000.0 Then
            dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End If

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnCalc_SelectCase_Click(sender As Object, e As EventArgs) Handles btnCalc_SelectCase.Click
        lblCommissionOnly.Text = String.Empty
        lblAdditional.Text = String.Empty
        lblTotalCommission.Text = String.Empty

        Dim dblSales As Double = 0.0
        Dim dblCommissionOnly As Double = 0.0
        Dim dblAdditional As Double = 0.0
        Dim dblTotalCommission As Double = 0.0
        Dim boolSalesOK As Boolean =
            Double.TryParse(txtSales.Text, dblSales)

        If Not boolSalesOK Then
            MessageBox.Show("Invalid Input", "Number Format Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        Select Case dblSales
            Case 1 To 5999.99
                dblCommissionOnly = 0.1
            Case 6000 To 29999.99
                dblCommissionOnly = 120.0 + (dblSales - 6000.0) * 0.13
            Case Else
                dblCommissionOnly = 3120.0 + (dblSales - 30000) * 0.14
        End Select

        If chkMoreThan10.Checked Then
            dblAdditional = dblAdditional + 500.0
        End If

        If chkTravel.Checked Then
            dblAdditional = dblAdditional + 700.0
        End If

        dblTotalCommission = dblCommissionOnly + dblAdditional

        If boolSalesOK Then
            lblCommissionOnly.Text = dblCommissionOnly.ToString("c2")
            lblAdditional.Text = dblAdditional.ToString("c2")
            lblTotalCommission.Text = dblTotalCommission.ToString("c2")
        End If

        txtSales.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
