Module Module1

    Sub Main()
        Dim Counter As ULong
        Dim Counter2 As Integer
        Dim Pandigital As Boolean
        Dim Largest As ULong

        For Counter = 1234567 To 7654321
            Pandigital = True
            If IsPrime(Counter) Then
                For Counter2 = 1 To Len(CStr(Counter))
                    If InStr(CStr(Counter), CStr(Counter2)) = Nothing Then
                        Pandigital = False
                    End If
                Next
                If Pandigital = True Then
                    Largest = Counter
                End If
            End If
        Next
        Console.WriteLine(Largest)
        Console.ReadLine()
    End Sub

    Function IsPrime(ByVal n As Long) As Boolean

        Dim i As Long

        For i = 2 To Math.Sqrt(n)
            If n Mod i = 0 Then
                Return False
            End If
        Next
        Return True

    End Function

End Module