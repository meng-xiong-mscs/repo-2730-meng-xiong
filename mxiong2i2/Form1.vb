'Name: String Methods
'Purpose: Manipulation of strings
'Programmer: Meng Xong on 10/28/2017


Option Strict On
Option Explicit On
Option Infer Off


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '03 Insert/Remove
        Dim strWord As String = txt03RemoveInsert.Text
        strWord = strWord.Remove(0, 1)
        strWord = strWord.Insert(0, "cr")
        lbl03RemoveInsert.Text = strWord

        '04 Substring
        Dim strItem As String = txt04Substring.Text
        strItem = strItem.Substring(2, 4)
        lbl04Substring.Text = strItem

        '05a Length
        Dim strLength As String = txt05aLength.Text
        Dim strnumber As Integer
        strnumber = strLength.Length
        lbl05aLength.Text = strnumber.ToString()

        '05b Trim
        Dim strRedWing As String = txt05bTrim.Text
        lbl05bTrim.Text = strRedWing.Trim

        '05c Remove/Insert
        Dim strCater As String = txt05cRemoveInsert.Text
        strCater = strCater.Remove(1, 2)
        strCater = strCater.Insert(1, "rit")
        lbl05cRemoveInsert.Text = strCater

        '05d Insert
        Dim strday As String = txt05dInsert.Text
        strday = strday.Insert(0, "Mon")
        lbl05dInsert.Text = strday

        '05e Pad
        Dim strpad As String
        strpad = "765.44"
        lbl05ePad.Text = strpad.ToString().PadLeft(10, "*"c)

        '06 Remove
        Dim strComma As String
        strComma = "3,123,560"
        strComma = strComma.Remove(1, 1)
        strComma = strComma.Remove(4, 1)
        lbl06Remove.Text = strComma

        '07 Contains
        Dim strContains As String
        Dim contain As Boolean = True
        strContains = txt07Contains.Text
        strContains.Contains(txt07Contains.Text)
        If strContains.ToUpper.Contains("JEFFERSON STREET S") = contain Then
            lbl07Contains.Text = "Jeff St. Found"
        Else
            lbl07Contains.Text = "Jeff St. Not Found"
        End If

        '12 len/Remove
        Dim strPercent As String = txt12LenRemove.Text
        Dim strlblrev As String = lbl12LenRemove.Text
        Dim intLength As Integer
        strPercent = strPercent.Remove(3)
        Convert.ToInt32(Convert.ToDecimal(strPercent))
        intLength = txt12LenRemove.Text.Length
        strlblrev = Format(Val(strPercent) * (100))
        lbl12LenRemove.Text = strlblrev.ToString()

        'Like
        Dim str605 As String = txt13Like.Text
        If str605 Like "605##" Then
            lbl13Like.Text = "Shipping: $25"
        Else
            If str605 Like "606##" Then
                lbl13Like.Text = "Shipping: $30"
            Else
                lbl13Like.Text = "Invalid Zip"
            End If
        End If
    End Sub

End Class
