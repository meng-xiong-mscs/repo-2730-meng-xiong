Public Class Form1
    Private Sub pretestDoWhilebtn_Click(sender As Object, e As EventArgs) Handles pretestDoWhilebtn.Click
        lblEven.Text = "Pretest Do While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do While i <= 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub pretestDoUntilbtn_Click(sender As Object, e As EventArgs) Handles pretestDoUntilbtn.Click
        lblEven.Text = "Pretest Do Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do Until i = 22
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop
    End Sub

    Private Sub posttestLoopWhilebtn_Click(sender As Object, e As EventArgs) Handles posttestLoopWhilebtn.Click
        lblEven.Text = "PostTest Loop While" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop While i <= 20
    End Sub

    Private Sub posttestLoopUntilbtn_Click(sender As Object, e As EventArgs) Handles posttestLoopUntilbtn.Click
        lblEven.Text = "PostTest Loop Until" & ControlChars.NewLine
        Dim i As Integer = 2
        Do
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 2
        Loop Until i = 22
    End Sub

    Private Sub forLoopbtn_Click(sender As Object, e As EventArgs) Handles forLoopbtn.Click
        lblEven.Text = "Pretest For" & ControlChars.NewLine
        For i As Integer = 2 To 20
            lblEven.Text = lblEven.Text & i.ToString & ControlChars.NewLine
            i += 1
        Next i

    End Sub

    Private Sub btnSumDoWhile_Click(sender As Object, e As EventArgs) Handles btnSumDoWhile.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPrompt As String = "Enter a number." &
            ControlChars.NewLine & "Click cancel or leave blank to end."
        Const strTitle As String = "Number entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        strNum = InputBox(strPrompt, strTitle, "0")

        Do While strNum <> String.Empty
            Int32.TryParse(strNum, intNum)
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            intCount = intCount + 1
            intSum = intSum + intNum
            strNum = InputBox(strPrompt, strTitle, "0")
        Loop

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub brnSumLoopUntil_Click(sender As Object, e As EventArgs) Handles brnSumLoopUntil.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPrompt As String = "Enter a number." &
            ControlChars.NewLine & "Click cancel or leave blank to end."
        Const strTitle As String = "Number entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double

        strNum = InputBox(strPrompt, strTitle, "0")

        Do
            Int32.TryParse(strNum, intNum)
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            intCount = intCount + 1
            intSum = intSum + intNum
            strNum = InputBox(strPrompt, strTitle, "0")
        Loop Until strNum = String.Empty

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub

    Private Sub btnSumForNext_Click(sender As Object, e As EventArgs) Handles btnSumForNext.Click
        txtList.Text = String.Empty
        lblCount.Text = String.Empty
        lblAvg.Text = String.Empty

        Const strPrompt As String = "Enter #"
        Dim strInputCount As String = InputBox("Enter quantity of numbers", "Quantity", "0")
        Const strTitle As String = "Number entry"
        Dim strNum As String
        Dim intNum As Integer
        Dim intSum As Integer
        Dim intCount As Integer
        Dim dblAvg As Double
        Dim intInputCount As Integer
        Int32.TryParse(strInputCount, intInputCount)

        strNum = InputBox(strPrompt & intCount.ToString, strTitle)

        For intCount = 1 To intInputCount
            Int32.TryParse(strNum, intNum)
            txtList.Text = txtList.Text & intNum.ToString & ControlChars.NewLine
            intSum = intSum + intNum
            strNum = InputBox(strPrompt & intCount.ToString, strTitle)
        Next

        lblCount.Text = intCount.ToString

        If intCount > 0 Then
            dblAvg = intSum / intCount
            lblAvg.Text = dblAvg.ToString("N2")
        Else
            lblAvg.Text = "N/A"
        End If
    End Sub
End Class
