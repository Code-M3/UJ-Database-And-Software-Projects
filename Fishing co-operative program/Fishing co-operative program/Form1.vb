Option Explicit On
Option Strict On

Public Class Form1

    Private NumDays As Integer
    Private Sales() As Double
    Private TotSales As Double
    Private AveSales As Double

    Private Sub btnDays_Click(sender As Object, e As EventArgs) Handles btnDays.Click

        NumDays = CInt(TxtNumDay.Text)
        ReDim Preserve Sales(NumDays)

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

        For i = 1 To NumDays
            Sales(i) = CInt(InputBox("Input the sales amount"))
        Next
        MsgBox("Sales have been obtained for all number of days")

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        TotSales = 0

        For i = 1 To NumDays
            TotSales = TotSales + Sales(i)
        Next i
        TxtTotSales.Text = "R " + CStr(TotSales)

        AveSales = TotSales / NumDays
        TxtAveSales.Text = "R " + CStr(AveSales)
        MsgBox("Total and Average Sales have been calculated")

    End Sub
End Class
