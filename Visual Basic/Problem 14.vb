Module Module1

    Sub Main()

        Dim Number As ULong
        Dim Steps As ULong
        Dim MostSteps As ULong
        Dim Answer As ULong
        Dim Counter As ULong

        Steps = 0
        MostSteps = 0

        For Counter = 2 To 1000000
            If Steps > MostSteps Then
                MostSteps = Steps
                Answer = Counter - 1
            End If
            Number = Counter
            Steps = 0
            Do Until Number = 1
                If Number Mod 2 = 0 Then
                    Number = Number / 2
                    Steps = Steps + 1
                Else
                    Number = 3 * Number + 1
                    Steps = Steps + 1
                End If
            Loop
        Next

        Console.WriteLine(Answer)
        Console.ReadLine()

    End Sub

End Module