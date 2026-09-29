Option Strict On
Option Explicit On
Public Class Form1
    Private OriginalCost As Integer
    Private VatAmount As Double
    Private TotalVat As Double
    Private FinalPrice As Double
    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        OriginalCost = CInt(TxtOriginalPrice.Text)
        VatAmount = CInt(TxtVatAmount.Text)

        TotalVat = VatAmount / 100
        TxtTotVat.Text = CStr(TotalVat)

        FinalPrice = OriginalCost + TotalVat

        TxtFinalPrice.Text = "R" + CStr(FinalPrice)
    End Sub
End Class
