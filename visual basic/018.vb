Imports System.Math

Module Module1

    Sub Main()

        Dim Triangle(15, 15) As Integer
        Dim GridLine(15) As String
        Dim Start As Integer

        FileOpen(1, "C:\Documents and Settings\Jamie\My Documents\Project Euler\Problem 18 Numbers.txt", OpenMode.Input)
        For i = 1 To 15
            GridLine(i) = LineInput(1)
        Next
        FileClose(1)

        For i = 1 To 15
            Start = 1
            For j = 1 To 15
                Triangle(i, j) = Convert.ToInt32(Mid(GridLine(i), Start, 2))
                Start += 2
            Next
        Next

        For i = 15 To 1 Step -1
            For j = 1 To i - 1
                Triangle(i - 1, j) += Max(Triangle(i, j), Triangle(i, j + 1))
            Next
        Next

        Console.WriteLine(Triangle(1, 1))
        Console.ReadLine()


    End Sub

End Module