Option Explicit On
Option Strict On
Public Class frmSalary
    Private Gross As Integer
    Private TaxValue As Double
    Private NetSal As Double
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        TaxValue = CInt(TxtTax.Text)
        TaxValue = 30 / 100
        TxtTax.Text = CStr(TaxValue)

        Gross = CInt(TxtGross.Text)
        NetSal = Gross - TaxValue

        TxtNet.Text = CStr(NetSal)
    End Sub
End Class
