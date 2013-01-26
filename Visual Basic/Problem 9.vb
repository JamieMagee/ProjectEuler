Module Module1

    Sub Main()

        Dim a As Integer
        Dim b As Integer
        Dim c As Decimal
        Dim Answer As ULong
        Dim Counter As Integer
        Dim IsInteger As Boolean

        For a = 998 To 1 Step -1
            For b = 998 To 1 Step -1
                IsInteger = False
                c = (a ^ 2 + b ^ 2) ^ (0.5)
                For Counter = 1 To 1000
                    If c = Counter Then
                        IsInteger = True
                    End If
                Next
                If a + b + c = 1000 And a < b < c And IsInteger = True Then
                    Answer = a * b * c
                End If
            Next
        Next

        Console.WriteLine(Answer)
        Console.ReadLine()

    End Sub

End Module