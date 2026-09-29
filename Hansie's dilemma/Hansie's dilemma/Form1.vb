Option Explicit On
Option Strict On
Public Class Form1

    'Variables
    Private Country, Series, Runs As Integer
    'Private C1S1, C1S2, C1S3, C1S4 As Integer
    AusRuns(3) As Integer

    'Private C2S1, C2S2, C2S3, C2S4 As Integer
    PakRuns(3) As Integer

    'Private C3S1, C3S2, C3S3, C3S4 As Integer
    ZimRuns(3) As Integer

    'Private C1Tot, C2Tot, C3Tot As Integer
    CountryTotals(3) As Integer

    'Private S1Tot, S2Tot, S3Tot, S4Tot As Integer
    SeriesTotals(3) As Integer


    Private Sub btnRuns_Click(sender As Object, e As EventArgs) Handles btnRuns.Click

        Country = CInt(TxtCountry.Text)
        Series = CInt(TxtSeries.Text)
        Runs = CInt(TxtRuns.Text)

        'Calculate the runs for each country and series
        If Country = 1 Then
            AusRuns(Series) = Runs

        End If
        If Country = 2 Then
            PakRuns(Series) = Runs

        End If
        If Country = 3 Then
            ZimRuns(Series) = Runs

        End If

        'Make textboxes empty for next input
        TxtCountry.Text = ""
        TxtSeries.Text = ""
        TxtRuns.Text = ""

    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click

        'Calculating series totals
        For i = 1 To 4
            SeriesTotals(i) = 0
            SeriesTotals(i) = AusRuns(i) + PakRuns(i) + ZimRuns(i)
        Next


        'S1Tot = C1S1 + C2S1 + C3S1
        'S2Tot = C1S2 + C2S2 + C3S2
        'S3Tot = C1S3 + C2S3 + C3S3
        'S4Tot = C1S4 + C2S4 + C3S4

        'Calculating country totals
        For j = 1 To 3
            CountryTotals(1) = CountryTotals(1) + AusRuns(j)
            CountryTotals(2) = CountryTotals(2) + PakRuns(j)
            CountryTotals(3) = CountryTotals(3) + ZimRuns(j)
        Next

        'C1Tot = C1S1 + C1S2 + C1S3 + C1S4
        'C2Tot = C2S1 + C2S2 + C2S3 + C2S4
        'C3Tot = C3S1 + C3S2 + C3S3 + C3S4

        'Displaying the totals in the textboxes
        TxtSeries1.Text = CStr(SerieTotal(1))
        TxtSeries2.Text = CStr(SerieTotal(2))
        TxtSeries3.Text = CStr(SerieTotal(3))
        TxtSeries4.Text = CStr(SerieTotal(4))

        TxtAus.Text = CStr(CounrtyTotal(1))
        TxtPak.Text = CStr(CounrtyTotal(2))
        TxtZim.Text = CStr(CounrtyTotal(3))

    End Sub

End Class
