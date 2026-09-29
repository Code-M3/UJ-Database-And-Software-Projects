Option Explicit On
Option Strict On
Public Class Form1
    Private Number As Integer
    Private Sum As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sum = 0
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Number = CInt(TxtNumber.Text)
        If Number >= 0 Then
            Sum = Sum + Number

            TxtPrompt.Text = "Read in next number"
        Else
            TxtSum.Text = CStr(Sum)

            TxtPrompt.Text = "End of program"
        End If
    End Sub
End Class
