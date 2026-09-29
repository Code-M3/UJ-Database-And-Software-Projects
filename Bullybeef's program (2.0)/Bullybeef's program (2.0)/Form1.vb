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

        Number = CInt(InputBox("How many cattle to read in?"))

    End Sub

    Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click

        While Counter < Number

            Weight = CInt(InputBox("Weight of cattle?"))
            TotalWeight = TotalWeight + Weight
            Counter = Counter + 1

        End While

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click

        AveWeight = TotalWeight / Number
        TxtAve.Text = CStr(AveWeight)

    End Sub
End Class
