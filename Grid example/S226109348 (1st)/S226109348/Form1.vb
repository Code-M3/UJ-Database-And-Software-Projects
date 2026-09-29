Option Strict On
Option Explicit On
Public Class Form1

    Private Number As Integer
    Private TotPages As Integer
    Private AvePages As Double
    Private Sum As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TotPages = 0

    End Sub

    Private Sub btnDays_Click(sender As Object, e As EventArgs) Handles btnDays.Click
        Number = CInt(TxtDays.Text)
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        For TotPages = 1 To 100
            Sum = Sum + TotPages
        Next TotPages
        TxtTotPages.Text = CStr(TotPages)
        MsgBox("All pages and days have been read in the code")
    End Sub
    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        AvePages = TotPages / Number
        TxtAve.Text = CStr(AvePages) + " pages"
        MsgBox("You have obtained the average number of pages per day")
    End Sub
End Class
