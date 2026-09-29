Option Explicit On
Option Strict On
Public Class Form1

    'Variables
    Private Country, Series, Runs As Integer
    Private C1S1, C1S2, C1S3, C1S4 As Integer
    Private C2S1, C2S2, C2S3, C2S4 As Integer
    Private C3S1, C3S2, C3S3, C3S4 As Integer
    Private C1Tot, C2Tot, C3Tot As Integer
    Private S1Tot, S2Tot, S3Tot, S4Tot As Integer

    Private Sub btnRuns_Click(sender As Object, e As EventArgs) Handles btnRuns.Click

        Country = CInt(txtCountry.Text)
        Series = CInt(TxtSeries.Text)
        Runs = CInt(txtRuns.Text)

        'Calculate the runs for each country and series
        If Country = 1 Then
            If Series = 1 Then
                C1S1 = Runs
            ElseIf Series = 2 Then
                C1S2 = Runs
            ElseIf Series = 3 Then
                C1S3 = Runs
            ElseIf Series = 4 Then
                C1S4 = Runs
            End If
        End If
        If Country = 2 Then
            If Series = 1 Then
                C2S1 = Runs
            ElseIf Series = 2 Then
                C2S2 = Runs
            ElseIf Series = 3 Then
                C2S3 = Runs
            ElseIf Series = 4 Then
                C2S4 = Runs
            End If
        End If
        If Country = 3 Then
            If Series = 1 Then
                C3S1 = Runs
            ElseIf Series = 2 Then
                C3S2 = Runs
            ElseIf Series = 3 Then
                C3S3 = Runs
            ElseIf Series = 4 Then
                C3S4 = Runs
            End If
        End If

        'Make textboxes empty for next input
        txtCountry.Text = ""
        TxtSeries.Text = ""
        txtRuns.Text = ""

    End Sub

    Private Sub btnTotals_Click(sender As Object, e As EventArgs) Handles btnTotals.Click

        'Calculating series totals
        S1Tot = 0
        S2Tot = 0
        S3Tot = 0


        S1Tot = C1S1 + C2S1 + C3S1
        S2Tot = C1S2 + C2S2 + C3S2
        S3Tot = C1S3 + C2S3 + C3S3
        S4Tot = C1S4 + C2S4 + C3S4

        'Calculating country totals
        C1Tot = 0
        C2Tot = 0
        C3Tot = 0

        C1Tot = C1S1 + C1S2 + C1S3 + C1S4
        C2Tot = C2S1 + C2S2 + C2S3 + C2S4
        C3Tot = C3S1 + C3S2 + C3S3 + C3S4

        'Displaying the totals in the textboxes
        txtSeries1.Text = CStr(S1Tot)
        txtSeries2.Text = CStr(S2Tot)
        txtSeries3.Text = CStr(S3Tot)
        txtSeries4.Text = CStr(S4Tot)

        txtAus.Text = CStr(C1Tot)
        txtPak.Text = CStr(C2Tot)
        txtZim.Text = CStr(C3Tot)

    End Sub

End Class
