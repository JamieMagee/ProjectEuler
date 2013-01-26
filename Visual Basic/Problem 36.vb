Module Module1

    Sub Main()

        Dim Counter As Long
        Dim Sum As Long

        For Counter = 1 To 1000000
            If StrReverse(Convert.ToString(Counter, 2)) = Convert.ToString(Counter, 2) And StrReverse(Convert.ToString(Counter)) = Convert.ToString(Counter) Then
                Sum = Sum + Counter
            End If
        Next

        Console.WriteLine(Sum)
        Console.ReadLine()

    End Sub

End Module