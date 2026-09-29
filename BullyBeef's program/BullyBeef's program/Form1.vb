
Option Explicit On
Option Strict On

Public Class Form1

    Private Number As Integer
    Private Weight As Integer
    Private TotalWeight As Integer
    Private AveWeight As Double
    Private Counter As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Counter = 0
        TotalWeight = 0

    End Sub

    Private Sub btnCattle_Click(sender As Object, e As EventArgs) Handles btnCattle.Click

        Number = CInt(TxtNumber.Text)

    End Sub

    Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click

        If Counter >= Number Then

            MsgBox("All cattle weights have been read in")

        Else

            Weight = CInt(TxtWeight.Text)
            TotalWeight = TotalWeight + Weight
            Counter = Counter + 1

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        AveWeight = TotalWeight / Number
        TxtAve.Text = CStr(AveWeight) + "Kg"

    End Sub
End Class
