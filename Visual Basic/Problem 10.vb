Module Module1

    Sub Main()

        Dim Primes(2000000) As ULong
        Dim Counter As ULong
        Dim Prime As ULong
        Dim NewPrime As ULong
        Dim Answer As ULong
        Dim NextPrime As Boolean

        For Counter = 2 To 2000000
            Primes(Counter) = Counter
        Next

        Prime = 2

        Do While Prime < 2000000
            Console.WriteLine(Prime)
            NextPrime = False
            For Counter = Prime To 2000000 Step Prime
                If Counter <> Prime Then
                    Primes(Counter) = 0
                End If
            Next
            Counter = Prime + 1
            Do Until NewPrime > Prime Or Counter = 2000000
                If Primes(Counter) <> 0 Then
                    NewPrime = Primes(Counter)
                Else
                    Counter = Counter + 1
                End If
            Loop
            If Counter < 2000000 Then
                Prime = NewPrime
            Else
                Prime = 2000000
            End If
        Loop

        For Counter = 2 To 2000000
            If Primes(Counter) <> 0 Then
                Answer = Answer + Primes(Counter)
            End If
        Next

        Console.WriteLine(Answer)
        Console.ReadLine()

    End Sub

End Module