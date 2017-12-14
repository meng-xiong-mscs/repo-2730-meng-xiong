'Name:              mxiong3e1
'Purpose:           Display counts of salespeople commission
'Programmer:        Meng Xiong on 12/7/2017

Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1
    Private intCommission() As Integer = {300, 500, 200, 150, 600, 700, 900,
            150, 100, 200, 250, 650, 300, 750, 800, 350, 250, 150, 100, 300}
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayCommission()
        cboSearchValues.SelectedIndex = 0
        cboSearchRanges.SelectedIndex = 0
    End Sub

    Private Sub DisplayCommission()
        For Each intCommis As Integer In intCommission
            lblCommission.Text &= intCommis.ToString() & ", "
        Next
        If lblCommission.Text.EndsWith(", ") Then
            lblCommission.Text = lblCommission.Text.Substring(0, lblCommission.Text.Length - 2)
        End If
    End Sub

    Private Sub cboSearchValues_TextChanged(sender As Object, e As EventArgs) Handles cboSearchValues.TextChanged
        Dim intSearchValue As Integer = 0
        Int32.TryParse(cboSearchValues.Text, intSearchValue)
        If intSearchValue >= 0 AndAlso intSearchValue <= 1000 Then
            lblValueCount.Text = CountValue(intSearchValue).ToString
        Else
            MessageBox.Show("Wrong Input", "Value must be range in 0 - 1000")
        End If
    End Sub

    Private Function CountValue(intSearchValue As Integer) As Integer
        Dim inttotal As Integer = 0
        For intCom As Integer = 0 To intCommission.Count - 1

            If intCommission(intCom) = intSearchValue Then
                inttotal = inttotal + 1
            End If
        Next intCom

        Return inttotal

    End Function
    Private Function CountRange(intSearchMin As Integer, intSearchMax As Integer) As Integer
        Dim intnum As Integer = 0
        For intCom As Integer = 0 To intCommission.Count - 1
            If intCommission(intCom) <= intSearchMax AndAlso intCommission(intCom) >= intSearchMin Then
                intnum = intnum + 1
            End If
        Next intCom
        Return intnum
    End Function

    Private Sub cboSearchRanges_TextChanged(sender As Object, e As EventArgs) Handles cboSearchRanges.TextChanged
        lblRangeCount.Text = String.Empty
        Dim intSearchMin As Integer = 0
        Dim intSearchMax As Integer = 0
        Dim intHyphenIndex As Integer = cboSearchRanges.Text.IndexOf("-")
        If intHyphenIndex >= 0 AndAlso cboSearchRanges.Text.Length > intHyphenIndex + 1 Then
            Dim strSearchMin As String =
                cboSearchRanges.Text.Substring(0, intHyphenIndex).Trim()
            Dim strSearchMax As String =
                cboSearchRanges.Text.Substring(intHyphenIndex + 1).Trim()
            Int32.TryParse(strSearchMin, intSearchMin)
            Int32.TryParse(strSearchMax, intSearchMax)
            If intSearchMax >= intSearchMin Then
                lblRangeCount.Text = CountRange(intSearchMin, intSearchMax).ToString
            End If
        End If
    End Sub
End Class
