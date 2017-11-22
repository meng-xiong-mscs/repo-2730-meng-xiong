' Name:         Multiplication Project
' Purpose:      Display a multiplication table that shows
'               the multiplicand, multiplier, and product
' Programmer:   <your name> on <current date>

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Const dblTAXRATE As Double = 0.05

    Private Sub btnDoLoop_Click(sender As Object, e As EventArgs) Handles btnDoLoop.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop
        For count = 1 To 9
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString & " = " & product.ToString)
        Next count
    End Sub

    Private Sub btnForNext_Click(sender As Object, e As EventArgs) Handles btnForNext.Click
        ' displays a multiplication table
        Dim number, product, count As Integer
        lstMultTable.Items.Clear()
        lstMultTable.Items.Add("For loop:")
        Integer.TryParse(txtNumber.Text, number)
        'for loop
        For count = 1 To 9
            product = number * count
            lstMultTable.Items.Add("    " & number.ToString() & " * " & count.ToString & " = " & product.ToString)
        Next count
    End Sub

    Private Sub txtNumber_Enter(sender As Object, e As EventArgs) Handles txtNumber.Enter
        txtNumber.SelectAll()
    End Sub

    Private Sub txtNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumber.KeyPress
        ' allows only numbers and the Backspace

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        'lblTable.Text = String.Empty
        'clear the list box
        lstMultTable.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i As Integer = 1 To 4
            lstPrices.Items.Add(i.ToString("n2"))
        Next

        Dim dblpretaxtotal As Double = 0
        Dim strselecteditem As String
        Dim dblSelectedPrice As Double

        For index As Integer = 0 To lstPrices.Items.Count - 1
            lstPrices.SelectedIndex = index
            strselecteditem = lstPrices.SelectedItem.ToString()
            Double.TryParse(strselecteditem, dblSelectedPrice)
            dblpretaxtotal = dblSelectedPrice + dblpretaxtotal
        Next index



        lblPreTax.Text = dblpretaxtotal.ToString("f")
        lblTax.Text = CType(Val(dblTAXRATE * dblpretaxtotal), String)
        lblTotal.Text = dblpretaxtotal.ToString() + lblTax.Text
        lstPrices.SelectedIndex = -1
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Dim strPrice As String = InputBox("Valid Prices: 1.00 to 9.99", "Valid Entry")
        Dim strPrice As String
        strPrice = InputBox("Valid Prices: 1.00 to 9.99", "Valid Entry")
        Dim dblPrice As Double
        Double.TryParse(strPrice, dblPrice)
        Dim intlist As Integer = 0
        Dim dblPretaxtotal As Double


        Do While intlist < lstPrices.Items.Count
            strPrice = InputBox("Valid Prices: 1.00 to 9.99", "Invalid Entry")
            Double.TryParse(strPrice, dblPrice)
            intlist = intlist + 1
            strPrice = lstPrices.SelectedItem.ToString
            Double.TryParse(strPrice, dblPrice)
            dblPretaxtotal += dblPrice
        Loop

        lblPreTax.Text = dblPretaxtotal.ToString("f")
        lblTax.Text = CType(Val(dblTAXRATE * dblPretaxtotal), String)
        lblTotal.Text = dblPretaxtotal.ToString() + lblTax.Text
        lstPrices.SelectedIndex = -1

    End Sub

    Private Sub lstPrices_KeyDown(sender As Object, e As KeyEventArgs) Handles lstPrices.KeyDown
        If lstPrices.SelectedIndex <> -1 AndAlso (e.KeyCode = Keys.Delete) Then
            lstPrices.Items.RemoveAt(lstPrices.SelectedIndex)
        End If

        Dim dblpretaxtotal As Double = 0
            Dim strselecteditem As String
            Dim dblSelectedPrice As Double

            For index As Integer = 0 To lstPrices.Items.Count - 1
                lstPrices.SelectedIndex = index
                strselecteditem = lstPrices.SelectedItem.ToString()
                Double.TryParse(strselecteditem, dblSelectedPrice)
                dblpretaxtotal = dblSelectedPrice + dblpretaxtotal
            Next index



            lblPreTax.Text = dblpretaxtotal.ToString("f")
            lblTax.Text = CType(Val(dblTAXRATE * dblpretaxtotal), String)
            lblTotal.Text = dblpretaxtotal.ToString() + lblTax.Text
            lstPrices.SelectedIndex = -1
    End Sub
End Class
