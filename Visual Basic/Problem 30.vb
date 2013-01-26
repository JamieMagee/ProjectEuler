Module Module1

    Sub Main()

        Dim Counter As Decimal
        Dim Number As Decimal
        Dim Digit(6) As Integer
        Dim Sum As Decimal
        Dim TotalSum As Decimal
        Dim Index As Integer


        For Counter = 2 To 200000
            Number = Counter
            Sum = 0
            For Index = 1 To 6
                Digit(Index) = 0
            Next
            'Console.WriteLine("The Number is " & Number)
            For Index = 1 To Len(Number.ToString)
                Digit(Index) = (Convert.ToInt32(Mid(Number.ToString, Index, 1))) ^ 5
                'Console.WriteLine("Digit number " & Index & " to the power of 5 is " & Digit(Index))
                Sum = Sum + Digit(Index)
            Next
            'Console.Write("The Sum of the digits to the power of 5 is " & Sum)
            'Console.ReadLine()
            If Sum = Number Then
                TotalSum = TotalSum + Sum
                'Console.WriteLine("The Number is " & Number)
            End If
        Next

        Console.WriteLine(TotalSum)
        Console.ReadLine()

    End Sub

End Module