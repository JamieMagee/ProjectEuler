Imports System.Numerics

Module Module1

    Sub Main()

        Dim Num As BigInteger
        Dim List As New ArrayList
        Dim Counter As ULong

        For a = 2 To 100
            For b = 2 To 100
                Num = a ^ b
                If Not List.Contains(Num) Then
                    List.Add(Num)
                    Counter += 1
                End If
            Next
        Next

        Console.WriteLine(Counter)
        Console.ReadLine()
    End Sub

End Module