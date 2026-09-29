Option Explicit On
Option Strict On
Option Infer Off
Public Class Form1

    Private NumFarmers As Integer
    Private NumPeriods As Integer

    Private Structure Farmers

        Public Name As String
        Public NumWorkers As Integer
        Public Profits() As Double

    End Structure

    Private farmer() As Farmers

    Private PeriodT() As Double
    Private PeriodA() As Double

    Private FarmerT() As Double
    Private FarmerA() As Double

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        NumFarmers = CInt(TxtFarmer.Text)
        NumPeriods = CInt(TxtPeriod.Text)

        ReDim farmer(NumFarmers)

        For i As Integer = 1 To NumFarmers

            ReDim farmer(i).Profits(NumPeriods)

        Next

        ReDim FarmerT(NumFarmers)
        ReDim FarmerA(NumFarmers)

        ReDim PeriodT(NumPeriods)
        ReDim PeriodA(NumPeriods)

        grdMars.Rows = NumPeriods + 3
        grdMars.Cols = NumFarmers + 3

        For i As Integer = 1 To NumFarmers

            DisplayInGrid(i, 0, "Farmer " + CStr(i))

        Next

        DisplayInGrid(NumFarmers + 1, 0, "Total")
        DisplayInGrid(NumFarmers + 2, 0, "Avetage")

        For j As Integer = 1 To NumFarmers

            DisplayInGrid(0, j, "Period " + CStr(j))

        Next

        DisplayInGrid(0, NumFarmers + 1, "Total")
        DisplayInGrid(0, NumFarmers + 2, "Average")

    End Sub

    Private Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdMars.Row = r
        grdMars.Col = c
        grdMars.Text = t

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        For i As Integer = 1 To NumFarmers

            farmer(i).Name = InputBox("Enter the name of the farmer.")
            farmer(i).NumWorkers = CInt(InputBox("Enter the number of workers."))

            For j As Integer = 1 To NumPeriods

                farmer(i).Profits(j) = CDbl(InputBox("Enter the profit for farmer " + CStr(i) + " period" + CStr(j)))

                DisplayInGrid(i, j, CStr(farmer(i).Profits(j)))

            Next j

        Next i

    End Sub

    Private Sub btnTA_Click(sender As Object, e As EventArgs) Handles btnTA.Click

        For f As Integer = 1 To NumFarmers

            FarmerT(f) = 0

            For p As Integer = 1 To NumPeriods

                FarmerT(f) = FarmerT(f) + farmer(f).Profits(p)

            Next

            DisplayInGrid(f, NumFarmers + 1, CStr(FarmerT(i)))

        Next

        For p As Integer = 1 To NumPeriods

            PeriodT(p) = 0

            For f As Integer = 1 To NumFarmers

                PeriodT(p) = PeriodT(p) + farmer(f).Profits(p)

            Next

            DisplayInGrid(NumFarmers + 1, p, CStr(PeriodT(p)))

        Next

    End Sub
End Class
