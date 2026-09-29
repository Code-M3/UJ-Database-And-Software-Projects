
Option Explicit On
Option Strict On

Public Class Form1

    Private Shifts As Integer
    Private TotQuality As Integer
    Private AveQuality As Double
    Private Counter As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Counter = 0
        TotQuality = 0

    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click

        Shifts = CInt(TxtShifts.Text)

        MsgBox("All data has been entered")

    End Sub

    Private Sub btnTot_Click(sender As Object, e As EventArgs) Handles btnTot.Click

        Dim checks As Integer

        While Counter < Shifts

            checks = CInt(InputBox("Enter quality checks for shift " & (Counter + 1)))
            TotQuality = TotQuality + checks
            Counter = Counter + 1

        End While

        TxtTot.Text = CStr(TotQuality)

    End Sub

    Private Sub btnAve_Click(sender As Object, e As EventArgs) Handles btnAve.Click

        AveQuality = TotQuality / Shifts
        TxtAve.Text = CStr(AveQuality)

        MsgBox("The average quality is " & AveQuality & " total quality is " & TotQuality)

    End Sub
End Class
