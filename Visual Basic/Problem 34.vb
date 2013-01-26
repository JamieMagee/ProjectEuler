Module Module1

    Sub Main()
        Dim Num As Decimal
        Dim Sum As Decimal
        Dim Length As Integer
        Dim TotalSum As Decimal

        For Num = 1 To 50000
            Sum = 0
            For Length = 1 To Len(Convert.ToString(Num))
                Sum = Sum + Fact(Convert.ToInt32(Convert.ToString(Mid(Num, Length, 1))))
            Next
            If Sum = Num And Num <> 1 And Num <> 2 Then
                Console.WriteLine(Sum)
                TotalSum = TotalSum + Sum
            End If
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