Public Class frmMark
    Private Mark As Integer
    Private Status As String
    Private Sub btnDete_Click(sender As Object, e As EventArgs) Handles btnDete.Click
        'Asigning values to variables
        Mark = TxtMark.Text
        Status = TxtStatus.Text

        'Calculations to determine the status of the student
        If Mark < 50 Then
            Status = "Student didn't attend classes"
        End If
        If Mark >= 50 Then
            Status = "Pass"
        End If
        If Mark >= 75 Then
            Status = "Cum laude"
        End If

        'Output
        TxtStatus.Text = CStr(Status)
    End Sub
End Class
