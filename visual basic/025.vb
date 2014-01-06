Imports System.Numerics

Module Module1

    Sub Main()

        Dim fib0, fib1, sum, Limit As BigInteger
        Dim Counter As Integer

        fib1 = 1
        Limit = 1

        For Counter = 1 To 999
            Limit = Limit * 10
        Next

        Counter = 1

        Do Until sum > Limit
            Counter += 1
            sum = fib0 + fib1
            fib0 = fib1
            fib1 = sum
        Loop

        Console.WriteLine("The First Fibonacci Term to contain more than 1000 digits is term " & Counter)
        Console.ReadLine()

    End Sub

End Module