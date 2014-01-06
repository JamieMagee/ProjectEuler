Module Module1

    Sub Main()

        Dim Counter As Integer
        Dim TriangleNum(20000) As Long
        Dim num As Long

        For Counter = 1 To 20000
            num = (Counter * (Counter + 1)) / 2
            TriangleNum(Counter) = num
        Next

        For Counter = 0 To TriangleNum.Count - 1
            num = TriangleNum(Counter)
            If GetFactors(num) > 500 Then
                Console.WriteLine(TriangleNum(Counter))
                Console.ReadLine()
            End If
        Next

    End Sub


    Function GetFactors(ByVal num As Long) As Long

        Dim Counter As Long

        GetFactors = 0

        For Counter = 1 To (num ^ 0.5)
            If num Mod Counter = 0 Then
                GetFactors = GetFactors + 1
            End If
        Next

        GetFactors = 2 * GetFactors

    End Function

End Module