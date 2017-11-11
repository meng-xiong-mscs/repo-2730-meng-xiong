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
End Class
