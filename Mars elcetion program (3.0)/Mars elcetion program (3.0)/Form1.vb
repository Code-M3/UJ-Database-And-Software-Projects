Option Strict On
Option Explicit On
Public Class Form1
    Private Region As Integer
    Private Number As Integer
    Private TotVotes As Integer
    Private AveVotes As Double
    Private Counter As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Counter = 0
        TotVotes = 0
    End Sub
    Private Sub btnRegion_Click(sender As Object, e As EventArgs) Handles btnRegion.Click
        Region = CInt(TxtRegion.Text)
    End Sub
    Private Sub btnVotes_Click(sender As Object, e As EventArgs) Handles btnVotes.Click
        If Counter >= Number Then
            MsgBox("All votes from regions have been read in")
        Else
            Number = CInt(TxtVotes.Text)
            TotVotes = TotVotes + Number
            Counter = Counter + 1
        End If
    End Sub
    Private Sub btnAve_Click(sender As Object, e As EventArgs) Handles btnAve.Click
        AveVotes = TotVotes / Number
        TxtAve.Text = CStr(AveVotes)
    End Sub
End Class
