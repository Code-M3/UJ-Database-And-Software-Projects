Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1

    Private numfarmer As Integer

    Private Structure farmer

        Public name As String
        Public numworkers As Integer
        Public profits As Double

    End Structure

    Private Farmers() As farmer

    Private average As Double
    Private total As Double

    Private Sub btnSet_Click(sender As Object, e As EventArgs) Handles btnSet.Click

        numfarmer = CInt(TxtNumfarmer.Text)
        ReDim Farmers(numfarmer)

        grdisplay.Cols = 2
        grdisplay.Rows = numfarmer + 3

        For i As Integer = 1 To numfarmer

            DisplayInGrid(i, 0, "Farmer " + CStr(i))

        Next

        DisplayInGrid(numfarmer + 1, 0, "Total")
        DisplayInGrid(numfarmer + 2, 0, "Average")

    End Sub

    Public Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdisplay.Row = r
        grdisplay.Col = c
        grdisplay.Text = t

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        For i As Integer = 1 To numfarmer

            Farmers(i).name = InputBox("What is the name of the farmer?")
            Farmers(i).numworkers = CInt(InputBox("How many workers does the farmer have?"))
            Farmers(i).profits = CDbl(InputBox("What is the profit of the farmer?"))

            DisplayInGrid(i, 1, CStr(Farmers(i).profits))

        Next i

    End Sub

    Private Sub btnTA_Click(sender As Object, e As EventArgs) Handles btnTA.Click

        total = 0
        For i As Integer = 1 To numfarmer

            total = total + Farmers(i).profits

        Next

        DisplayInGrid(numfarmer + 1, 1, CStr(total))
        TxtTotal.Text = CStr(total)

        average = total / numfarmer

        DisplayInGrid(numfarmer + 2, 1, CStr(average))
        TxtAve.Text = CStr(average)

    End Sub
End Class
