
Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private nF As Integer 'Number of MarsFarmers

    'Information for each Martian farmer
    Private Structure Farmer
        Public Name As String
        Public Workers As Integer
        Public Profit As Integer     'nP
    End Structure

    Private MarsFarmers() As Farmer  'nF 

    'Totals and Aves for the Period
    Private PeriodTot As Integer   'nP
    Private PeriodAve As Double    'nP

    Private Sub btnInit_Click(sender As Object, e As EventArgs) Handles btnInit.Click

        'Read number of Farmers and Periods
        nF = CInt(TxtFarmers.Text)

        'Set sizes of arrays
        ReDim MarsFarmers(nF)  'Set size of MarsFarmers array
        grdMars.Rows = nF + 3

        For i As Integer = 1 To nF ' For each MarsFarmer (i refers to Farmers)

            'Read Name of Farmer
            MarsFarmers(i).Name = InputBox("Name " & CStr(i))

            'Read Number of workers of Farmer
            MarsFarmers(i).Workers = CInt(InputBox("Number of workers for " & CStr(i)))

            'Read Profit for each Period of MarsFarmer i … 
            MarsFarmers(i).Profit = CInt(InputBox(“Profit for " & CStr(i)))

        Next i

    End Sub

    Public Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdMars.Row = r
        grdMars.Col = c
        grdMars.Text = t

    End Sub

    Private Sub btnTA_Click(sender As Object, e As EventArgs) Handles btnTA.Click

        'Calculate the Total of each Period
        PeriodTot = 0     'Init Total to zero

        For f As Integer = 1 To nF          'For each Farmer (f refers to Farmer!)
            PeriodTot = PeriodTot + MarsFarmers(f).Profit
        Next f

        'Calculate the Ave for each Farmer
        PeriodAve = PeriodTot / nF

        'Display the Total and Ave for the Period
        DisplayInGrid(nF + 1, 1, CStr(PeriodTot))
        DisplayInGrid(nF + 2, 1, CStr(PeriodAve))

    End Sub
End Class
