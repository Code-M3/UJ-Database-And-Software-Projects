Option Explicit On
Option Strict On
Public Class frmVAT
    Private Price As Integer
    Private VAT As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Price = CInt(TxtPrice.Text)
        VAT = Price * VAT / 100
        VAT = CInt(TxtVat.Text)

        TxtVat.Text = CStr(VAT)
    End Sub
End Class
