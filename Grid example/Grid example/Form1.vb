
Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private rows As Integer
    Private cols As Integer

    Private values() As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim i As Integer
        i = 1

        Dim min As Integer
        min = values(i)

        MsgBox("Before we start we assume that the first one i sthe lowest. The index is " + CStr(i) + "the value is  " + CStr(min))

    End Sub

    Public Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdMars.Row = r
        grdMars.Col = c
        grdMars.Text = t

    End Sub

End Class
