Option Explicit On
Option Strict On
Public Class Form1
    Private MP11, MP12, MP13 As Integer
    Private MP21, MP22, MP23 As Integer
    Private MP31, MP32, MP33 As Integer
    Private Month, Province, Number As Integer
    Private Month1Tot, Month2Tot, Month3Tot As Integer

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        Month = CInt(TxtMonth.Text)
        Province = CInt(TxtProvince.Text)
        Number = CInt(TxtNumber.Text)

        If Month = 1 Then
            If Province = 1 Then
                MP11 = Number
                Place_Result(1, 1, CStr(MP11))
            ElseIf Province = 2 Then
                MP12 = Number
            ElseIf Province = 3 Then
                MP13 = Number
            End If
        End If
        If Month = 2 Then
            If Province = 1 Then
                MP21 = Number
            ElseIf Province = 2 Then
                MP22 = Number
            ElseIf Province = 3 Then
                MP23 = Number
            End If
        End If
        If Month = 3 Then
            If Province = 1 Then
                MP31 = Number
            ElseIf Province = 2 Then
                MP32 = Number
            ElseIf Province = 3 Then
                MP33 = Number
            End If
        End If

        Month1Tot = MP11 + MP12 + MP13
        Month2Tot = MP21 + MP22 + MP23
        Month3Tot = MP31 + MP32 + MP33

        TxtMonth.Text = ""
        TxtProvince.Text = ""
        TxtNumber.Text = ""
    End Sub
    Private Sub Place_Result()
        Place_Result(1, 1, CStr(MP11))
        Place_Result(1, 2, CStr(MP12))
        Place_Result(1, 3, CStr(MP13))

        Place_Result(2, 1, CStr(MP21))
        Place_Result(2, 2, CStr(MP22))
        Place_Result(2, 3, CStr(MP23))

        Place_Result(3, 1, CStr(MP31))
        Place_Result(3, 2, CStr(MP32))
        Place_Result(3, 3, CStr(MP33))

        Place_Result(1, 4, CStr(Month1Tot))
        Place_Result(2, 4, CStr(Month2Tot))
        Place_Result(3, 4, CStr(Month3Tot))
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Number of coloums and rows
        grdMoon.Cols = 5
        grdMoon.Rows = 4

        Place_Result(0, 1, "Moonteng")
        Place_Result(0, 2, "North West Moon")
        Place_Result(0, 3, "Darkside")
        Place_Result(0, 4, "Total")
        Place_Result(1, 0, "Month 1")
        Place_Result(2, 0, "Month 2")
        Place_Result(3, 0, "Month 3")
    End Sub
    'Subprogram to display data in the grid
    Private Sub Place_Result(ByVal r As Integer, ByVal c As Integer, ByVal t As String)
        grdMoon.Row = r
        grdMoon.Col = c
        grdMoon.Text = t
    End Sub

End Class
