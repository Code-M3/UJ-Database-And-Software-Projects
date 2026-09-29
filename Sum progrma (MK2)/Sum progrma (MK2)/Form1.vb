Option Explicit On
Option Strict On
Public Class Form1
    Private Sum As Integer
    Private Counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Sum = 0
        Counter = 0
    End Sub
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        While Counter <= 5
            Sum = Sum + Counter
            Counter = Counter + 1
        End While
        'Display Sum in txtSum textbox
        TxtSum.Text = CStr(Sum)
    End Sub
End Class
