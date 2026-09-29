Option Explicit On
Option Strict On
Option Infer Off
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Function GetResult(ByVal Mark As Integer) As String

        If Mark < 50 Then
            GetResult = "Fail"
        Else
            If Mark >= 50 And Mark <= 75 Then
                GetResult = "Pass"
            Else
                If Mark > 75 Then
                    GetResult = "Cum laude"
                End If
            End If
        End If

    End Function

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click

        Dim StudentMark As Integer
        Dim Status As String

        StudentMark = CInt(InputBox("What mark did the student get?"))
        Status = GetResult(StudentMark)
        MsgBox(Status)

    End Sub
End Class
