Module Module1

    Sub Main()

        Dim a As Integer
        Dim b As Integer
        Dim SumOfAmicablePairs As Integer
        Dim Pairs As Integer

        For a = 1 To 10000
            b = DivisorsSum(a)
            If DivisorsSum(b) = a And a <> b Then
                Pairs = Pairs + 1
                If Pairs Mod 2 <> 0 Then
                    SumOfAmicablePairs = SumOfAmicablePairs + a + b
                    'Console.WriteLine("(" & a & " , " & b & ")")
                    'Console.ReadLine()
                End If
            End If
        Next

        Console.WriteLine(SumOfAmicablePairs)
        Console.ReadLine()

    End Sub

    Function DivisorsSum(ByVal n As Integer) As Integer

        Dim Counter As Integer

        For Counter = 1 To n / 2
            If n Mod Counter = 0 Then
                DivisorsSum = DivisorsSum + Counter
            End If
        Next

    End Function

End Module