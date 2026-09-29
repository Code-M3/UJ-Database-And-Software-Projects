Option Explicit On
Option Infer Off
Option Strict On
Public Class Form1

    'Delcare Structure to store employee records
    Private Structure Employee_Rec
        Public EmpNum As Integer
        Public EmpNmae As String
        Public Department As String
        Public SalePerWeeek() As Double 'Dynamic array to store sales per week
        Public MonthlyTurnover As Double
        Public AverageTurnover As Double
        Public Rating As String
    End Structure

    'Delcare variables
    Private Employees() As Employee_Rec 'Dynamic array to store employee records

    Private NumberOfEmployees As Integer 'Variable to store the number of employees
    Private NumberOfWeeks As Integer 'Variable to store the number of weeks

    Private Sub DisplayInGrid(ByVal c As Integer, ByVal r As Integer, ByVal t As String)

        GrdEmployee.Cols = c
        GrdEmployee.Rows = r
        GrdEmployee.Text = t

    End Sub

    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click

        'Input from user for number of employees and weeks
        NumberOfEmployees = CInt(InputBox("Enter the number of employees:"))
        NumberOfWeeks = CInt(InputBox("Enter the number of weeks:"))

        'Resize the Employees array to store the specified number of employee records
        ReDim Employees(NumberOfEmployees)
        For emp As Integer = 1 To NumberOfEmployees
            DisplayInGrid(emp, 0, "Employee " & CStr(emp)) 'Display employee number in the grid
        Next emp
        For s As Integer = 1 To NumberOfWeeks
            DisplayInGrid(0, s, "Week " & CStr(s)) 'Display week number in the grid
        Next s

        DisplayInGrid(0, NumberOfEmployees + 1, "Monthly TurnOver")
        DisplayInGrid(0, NumberOfEmployees + 2, "Average TurnOver")
        DisplayInGrid(0, NumberOfEmployees + 3, "Rating")

    End Sub

End Class
