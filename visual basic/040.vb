Module Module1

    Sub Main()

        Dim Counter As ULong
        Dim DecimalPart As String
        Dim Num As Integer

        Counter = 1

        Do Until Len(DecimalPart) >= 1000000
            DecimalPart += CStr(Counter)
            Counter += 1
        Loop

        Num = CInt(Mid(DecimalPart, 1, 1)) * CInt(Mid(DecimalPart, 10, 1)) * CInt(Mid(DecimalPart, 100, 1)) * CInt(Mid(DecimalPart, 1000, 1)) * CInt(Mid(DecimalPart, 10000, 1)) * CInt(Mid(DecimalPart, 100000, 1)) * CInt(Mid(DecimalPart, 1000000, 1))

        Console.WriteLine(Num)
        Console.ReadLine()

    End Sub

End Module