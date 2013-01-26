Module Module1

    Sub Main()

        Dim n As Integer
        Dim Sum As Long

        For n = 1 To 501
            Sum = Sum + (((2 * (n - 1)) + 1) ^ 2) + ((4 * ((n - 1) ^ 2)) + 1) + ((4 * (n ^ 2)) - (10 * n) + 7) + ((4 * (n ^ 2)) - (6 * n) + 3)
        Next

        Sum = Sum - 3
        Console.WriteLine(Sum)
        Console.ReadLine()

    End Sub

End Module