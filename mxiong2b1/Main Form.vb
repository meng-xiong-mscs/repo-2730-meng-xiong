﻿' Name:             Cranston Berry Project
' Purpose:          Caculates Project Sales
' Programmer:       Meng Xiong on 9/25/2017

Option Strict On
Option Explicit On
Option Infer Off

Public Class FrmMain

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        'Calculates Amount of Sales
        lblProjStraw.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtStraw.Text), "currency")
        lblProjBlue.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtBlue.Text), "currency")
        lblProjRasp.Text = Format((1 + Val(txtProjIncrease.Text)) * Val(txtRasp.Text), "currency")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Prepare Screen for next Projected Sales
        txtProjIncrease.Text = String.Empty
        txtStraw.Text = String.Empty
        txtBlue.Text = String.Empty
        txtRasp.Text = String.Empty
        lblProjStraw.Text = String.Empty
        lblProjBlue.Text = String.Empty
        lblProjRasp.Text = String.Empty
        txtProjIncrease.Text = "0.05"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRetirementForm_Click(sender As Object, e As EventArgs) Handles btnRetirementForm.Click
        frmRetirement.Show()
    End Sub
End Class

