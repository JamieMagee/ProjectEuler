Module Module1

    Sub Main()

        Dim Numbers(100) As String
        Dim sum As Decimal
        Dim Counter As Integer

        FileOpen(1, "C:\Documents and Settings\Jamie\My Documents\Project Euler\Problem 13 Numbers.txt", OpenMode.Input)
        For Counter = 1 To 100
            Numbers(Counter) = LineInput(1)
        Next
        FileClose(1)

        For Counter = 1 To 100
            sum = sum + (Numbers(Counter) / 10 ^ 40)
        Next

        Console.WriteLine(Mid(sum.ToString, 1, 10))
        Console.ReadLine()
    End Sub


End Module