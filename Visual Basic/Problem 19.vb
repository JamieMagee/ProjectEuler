Module Module1

    Sub Main()

        Dim First As New Date(1901, 1, 1)
        Dim NumofSundays As Integer

        For Counter = 1 To 1200
            If Weekday(First) = 1 Then
                NumofSundays = NumofSundays + 1
            End If
            First = First.AddMonths(1)
        Next

        Console.WriteLine(NumofSundays)
        Console.ReadLine()

    End Sub

End Module