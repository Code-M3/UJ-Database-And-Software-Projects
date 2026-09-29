Option Explicit On
Option Strict On

Public Class Form1
    Private Sum As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initialize the Counter and Sum variables
        Sum = 0

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        For x = 1 To 100
            Sum = Sum + x
        Next x

        'Display the Sum in the lblSum label
        TxtSum.Text = CStr(Sum)

    End Sub
End Class
