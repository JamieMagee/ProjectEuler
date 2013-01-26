Module Module1

    Sub Main()

        Dim Counter As Integer
        Dim Index As Integer
        Dim Sum As Long
        Dim Product As Long

        For Counter = 1 To 1000
            Product = Counter
            For Index = 1 To Counter - 1
                Product = (Product * Counter) Mod 10000000000
                Console.ReadLine()
            Next
            Sum = Sum + Product
        Next

        Console.WriteLine(Mid(CStr(Sum), Len(CStr(Sum)) - 9, 10))
        Console.ReadLine()

    End Sub

End Module