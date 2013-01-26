Module Module1

    Sub Main()

        Dim Found As Boolean
        Dim Counter As Integer
        Dim Counter2 As Integer
        Dim Counter3 As Integer
        Dim Sum(6) As Integer
        Dim Product(6) As Long

        For Counter2 = 1 To 6
            Product(Counter2) = 1
        Next

        Do Until Found = True
            Counter += 1
            For Counter2 = 1 To 6
                For Counter3 = 1 To Len(CStr(Counter * Counter2))
                    Sum(Counter2) += CInt(Mid(CStr(Counter * Counter2), Counter3, 1))
                    Product(Counter2) *= CInt(Mid(CStr(Counter * Counter2), Counter3, 1))
                Next
            Next
            If Sum(1) = Sum(2) And Sum(2) = Sum(3) And Sum(3) = Sum(4) And Sum(4) = Sum(5) And Sum(5) = Sum(6) And Product(1) = Product(2) And Product(2) = Product(3) And Product(3) = Product(4) And Product(4) = Product(5) And Product(5) = Product(6) And InStr(CStr(Counter), "0") = 0 Then
                Console.WriteLine(Counter)
                Found = True
            Else
                For Counter2 = 1 To 6
                    Sum(Counter2) = 0
                    Product(Counter2) = 1
                Next
            End If
        Loop

        Console.ReadLine()

    End Sub

End Module