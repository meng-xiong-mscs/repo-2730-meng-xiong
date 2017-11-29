' Name:         Conversion Solution
' Purpose:      Convert a measurement to either centimeters or inches
' Programmer:   Meng Xiong on 11/26/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtMeasurement_Enter(sender As Object, e As EventArgs) Handles txtMeasurement.Enter
        txtMeasurement.SelectAll()
    End Sub

    Private Sub txtMeasurement_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMeasurement.KeyPress
        ' allow only numbers, the period, and the Backspace key

        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso e.KeyChar <> "." AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub InputChanged(sender As Object, e As EventArgs) _
       Handles txtMeasurement.TextChanged, radSubCentimeters.CheckedChanged, radSubInches.CheckedChanged,
       radFuncCentimeters.CheckedChanged, radFuncInches.CheckedChanged

        Dim dblmeasurement As Double = 0.0
        Dim dblresult As Double = 0.0

        Double.TryParse(txtMeasurement.Text, dblmeasurement)

        If radSubCentimeters.Checked Then
            CalcCentimetersSub(dblmeasurement, dblresult)
        ElseIf radSubInches.Checked Then
            CalcInchesSub(dblmeasurement, dblresult)
        ElseIf radFuncCentimeters.Checked Then
            dblresult = CalcCentimetersFunc(dblmeasurement)
        ElseIf radFuncInches.Checked Then
            dblresult = CalcInchesFunc(dblmeasurement)
        End If
        lblResult.Text = dblresult.ToString("n2")
    End Sub

    Private Sub CalcCentimetersSub(ByVal dblmeasurment As Double, ByRef dblresult As Double)
        dblresult = dblmeasurment * 2.54
    End Sub

    Private Sub CalcInchesSub(ByVal dblmeasurement As Double, ByRef dblresult As Double)
        dblresult = dblmeasurement / 2.54
    End Sub

    Private Function CalcCentimetersFunc(ByVal dblmeasurement As Double) As Double
        Return dblmeasurement * 2.54
    End Function

    Private Function CalcInchesFunc(ByVal dblmeasurement As Double) As Double
        Return dblmeasurement / 2.54
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboPlanets.Items.Add("Earth")
        cboPlanets.Items.Add("Jupitar")
        cboPlanets.Items.Add("Mars")
        cboPlanets.Items.Add("Mercury")
        cboPlanets.Items.Add("Neptune")
        cboPlanets.Items.Add("Pluto")
        cboPlanets.Items.Add("Saturn")
        cboPlanets.Items.Add("Uranus")
        cboPlanets.Items.Add("Venus")
        cboPlanets.SelectedItem = "Earth"
    End Sub

    Private Sub txtEarthWeight_keypress(sender As Object, e As KeyPressEventArgs) Handles TxtEarthWeight.KeyPress
        If (e.KeyChar < "0" OrElse e.KeyChar > "9") AndAlso
        e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtEarthWeight_Enter(sender As Object, e As EventArgs) Handles TxtEarthWeight.Enter
        TxtEarthWeight.SelectAll()
    End Sub

    Private Function CalcWeightFunc(ByVal intWeight As Integer) As Double
        Dim dblGravity As Double = 0.0
        Select Case CType(cboPlanets.SelectedItem, String)
            Case "Earth"
                dblGravity = 1.0
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Jupitar"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        Return intWeight * dblGravity
    End Function

    Private Sub CalcWeightsub(ByVal intWeight As Integer, ByRef dblWeightOnPlanet As Double)
        Dim dblGravity As Double = 0.0
        Select Case CType(cboPlanets.SelectedItem, String)
            Case "Earth"
                dblGravity = 1.0
            Case "Mercury", "Mars"
                dblGravity = 0.38
            Case "Venus"
                dblGravity = 0.91
            Case "Jupitar"
                dblGravity = 2.34
            Case "Saturn"
                dblGravity = 1.06
            Case "Uranus"
                dblGravity = 0.92
            Case "Neptune"
                dblGravity = 1.14
            Case "Pluto"
                dblGravity = 0.06
        End Select
        dblWeightOnPlanet = intWeight * dblGravity
    End Sub

    Private Sub WeightInputChanged(sender As Object, e As EventArgs) _
        Handles TxtEarthWeight.TextChanged, cboPlanets.SelectedValueChanged

        Dim intweight As Integer = 0
        Dim dblWeightOnPlanet As Double = 0.0

        Int32.TryParse(TxtEarthWeight.Text, intweight)

        If rdoPlanetSub.Checked Then
            CalcWeightsub(intweight, dblWeightOnPlanet)
        ElseIf rdoPlanetFunc.Checked Then
            dblWeightOnPlanet = CalcWeightFunc(intweight)
        End If
        lblWeight.Text = dblWeightOnPlanet.ToString("n")
    End Sub
End Class
