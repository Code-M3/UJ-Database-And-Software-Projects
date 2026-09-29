Option Explicit On
Option Strict On
Option Infer Off

Public Class Form1

    Private Structure ProductRecord

        Public Name As String
        Public Cat As String
        Public Unit As Integer
        Public Revenue As Double

    End Structure

    Private NumProducts As Integer

    Private totalr As Double
    Private Average As Double

    Private Products() As ProductRecord

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        NumProducts = CInt(TxtNumber.Text)
        ReDim Products(NumProducts)

        grdStore.Rows = NumProducts + 1
        grdStore.Cols = 4

        DisplayInGrid(0, 0, "Name")
        DisplayInGrid(0, 1, "Cat")
        DisplayInGrid(0, 2, "Sold")
        DisplayInGrid(0, 3, "Revenue")

    End Sub

    Private Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdStore.Row = r
        grdStore.Col = c
        grdStore.Text = t

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        For p As Integer = 1 To NumProducts

            Products(p).Name = InputBox("Name?")
            Products(p).Cat = InputBox("Cat?")
            Products(p).Unit = CInt(InputBox("Sold?"))
            Products(p).Revenue = CDbl(InputBox("Rev?"))

        Next

    End Sub
End Class
