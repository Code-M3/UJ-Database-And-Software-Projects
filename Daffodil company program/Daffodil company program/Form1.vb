
Option Explicit On
Option Infer Off
Option Strict On

Public Class Form1

    Private NumBulbs As Integer
    Private NumSchools As Integer

    Private Structure Bulb

        Public Name As String
        Public FlowerTime As String
        Public Sold() As Integer

    End Structure

    Private Bulbs() As Bulb

    Private SchoolT() As Integer
    Private SchoolA() As Double

    Private BulbT() As Integer
    Private BulbA() As Double

    Private Max() As Integer
    Private Idx() As Integer

    Private Sub btnIni_Click(sender As Object, e As EventArgs) Handles btnIni.Click

        NumBulbs = CInt(InputBox("How many bulbs will be tracked?"))
        NumSchools = CInt(InputBox("How many schools were used?"))

        ReDim Bulbs(NumBulbs)

        ReDim BulbT(NumSchools)
        ReDim BulbA(NumSchools)

        ReDim SchoolT(NumBulbs)
        ReDim SchoolA(NumBulbs)

        ReDim Max(NumSchools)
        ReDim Idx(NumSchools)

        For b As Integer = 1 To NumBulbs

            ReDim Bulbs(b).Sold(NumSchools)

        Next

        grdBulb.Cols = NumBulbs + 4
        grdBulb.Rows = NumBulbs + 3

        For b As Integer = 1 To NumBulbs

            DisplayInGrid(b, 0, "Bulb " + CStr(b))

        Next

        For s As Integer = 1 To NumSchools

            DisplayInGrid(0, s, "School " + CStr(s))

        Next

        DisplayInGrid(NumBulbs + 1, 0, "Schools total")
        DisplayInGrid(NumBulbs + 2, 0, "Schools average")
        DisplayInGrid(NumBulbs + 3, 0, "Best bulb in schools")
        DisplayInGrid(0, NumBulbs + 1, "Total bulbs")
        DisplayInGrid(0, NumBulbs + 2, "Average bulbs")

    End Sub

    Private Sub DisplayInGrid(c As Integer, r As Integer, t As String)

        grdBulb.Col = c
        grdBulb.Row = r
        grdBulb.Text = t

    End Sub

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        For b As Integer = 1 To NumBulbs

            Bulbs(b).Name = InputBox("What is the name of bulb #" + CStr(b))
            Bulbs(b).FlowerTime = InputBox("What time of the year does the bulb flower?")

            For s As Integer = 1 To NumSchools

                Bulbs(b).Sold(s) = CInt(InputBox("How many bulbs were sold at school #" + CStr(s)))

                DisplayInGrid(b, s, CStr(Bulbs(b).Sold(s)))

            Next

        Next

    End Sub

    Private Sub BtnTA_Click(sender As Object, e As EventArgs) Handles BtnTA.Click

        For b As Integer = 1 To NumBulbs

            BulbT(b) = 0
            BulbA(b) = 0

            For s As Integer = 1 To NumSchools

                BulbT(b) += Bulbs(b).Sold(s)

            Next

            BulbA(b) = BulbT(b) / NumSchools

            DisplayInGrid(b, NumSchools + 1, CStr(BulbT(b)))
            DisplayInGrid(b, NumSchools + 2, CStr(BulbA(b)))

        Next

        For s As Integer = 1 To NumSchools

            SchoolT(s) = 0
            SchoolA(s) = 0

            For b As Integer = 1 To NumBulbs

                SchoolT(s) += Bulbs(b).Sold(s)

            Next

            SchoolA(s) = SchoolT(s) / NumBulbs

            DisplayInGrid(NumBulbs + 1, s, CStr(SchoolT(s)))
            DisplayInGrid(NumBulbs + 2, s, CStr(SchoolA(s)))

        Next

    End Sub

    Private Sub btnBest_Click(sender As Object, e As EventArgs) Handles btnBest.Click

        For s As Integer = 1 To NumSchools

            Max(s) = Bulbs(1).Sold(s)
            Idx(s) = 1

            For b As Integer = 2 To NumBulbs

                If Bulbs(b).Sold(s) > Max(s) Then

                    Max(s) = Bulbs(b).Sold(s)
                    Idx(s) = b

                End If

            Next b

            DisplayInGrid(NumBulbs + 3, s, Bulbs(Idx(s)).Name)

        Next s

        Dim localmax As Integer
        Dim localidx As Integer

        localmax = SchoolT(1)
        localidx = 1

        For s As Integer = 2 To NumSchools

            If SchoolT(s) > localmax Then

                localmax = SchoolT(s)
                localidx = s

            End If

        Next s

        TxtBSB.Text = "The name of the best seller at school # " & localidx & " is " & Bulbs(Idx(localidx)).Name

    End Sub
End Class
