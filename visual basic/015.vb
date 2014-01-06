Module Module1

    Sub Main()

        Dim current As Integer
        Dim Counter As Integer

        For Counter = 1 To 10
            current = Fact(Counter * 2) / (Fact(Counter) * Fact(Counter))

            Console.WriteLine(current)
        Next
        Console.ReadLine()

    End Sub


    Private Function Fact(ByVal n As Integer) As Long

        Dim i As Integer

        Fact = 1

        For i = 2 To n
            Fact = Fact * i
        Next

    End Function

End Module