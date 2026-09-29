Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private NumMember As Integer
    Private NumAct As Integer

    Private Structure Member

        Public Name As String
        Public Activity As String
        Public Minutes As Integer
        Public Calories() As Double

    End Structure

    Private Members() As Member

    Private TotCal() As Double
    Private AveCal() As Double

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        NumMember = CInt(TxtName.Text)
        NumAct = CInt(TxtNumber.Text)

        ReDim Members(NumMember)

        For i As Integer = 1 To NumMember

            ReDim Members(i).Calories(NumAct)

        Next

        ReDim TotCal(NumMember)
        ReDim AveCal(NumMember)

        grdGym.Rows = NumAct + 3
        grdGym.Cols = NumMember + 3

        For i As Integer = 1 To NumMember

            DisplayInGrid(i, 0, "Member: " + CStr(i))

        Next


        For j As Integer = 1 To NumAct

            DisplayInGrid(0, j, "Act " + CStr(j))

        Next

        DisplayInGrid(0, NumMember + 1, "Total")
        DisplayInGrid(0, NumMember + 2, "Average")

    End Sub

    Private Sub DisplayInGrid(r As Integer, c As Integer, t As String)

        grdGym.Row = r
        grdGym.Col = c
        grdGym.Text = t

    End Sub

    Private Sub btnInput_Click(sender As Object, e As EventArgs) Handles btnInput.Click

        For i As Integer = 1 To NumMember

            Members(i).Name = InputBox("Enter the name.")
            Members(i).NumAct = CInt(InputBox("Enter the number of activities."))

            For j As Integer = 1 To NumAct

                Members(i).Calories(j) = CDbl(InputBox("Enter the profit for farmer " + CStr(i) + " period" + CStr(j)))

                DisplayInGrid(i, j, CStr(Members(i).Calories(j)))

            Next j

        Next i

    End Sub
End Class
