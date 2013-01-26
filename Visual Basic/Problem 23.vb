Imports System.Math

Module Module1

    Sub Main()

        Dim AbundantNbrs(28123) As Boolean
        Dim AbundantSums(28123) As Integer
        Dim Counter As Integer
        Dim Counter2 As Integer


        For Counter = 0 To UBound(AbundantNbrs)
            AbundantSums(Counter) = Counter
        Next

        For Counter = 12 To UBound(AbundantNbrs)
            If AbundantNbrs(Counter) Then
            ElseIf Sum(GetFactors(Counter)) - Counter > Counter Then
                AbundantNbrs(Counter) = True
                For Counter2 = 2 To 28123 \ Counter
                    AbundantNbrs(Counter * Counter2) = True
                Next Counter2
            End If
        Next Counter

        For Counter = 1 To UBound(AbundantNbrs) \ 2
            If AbundantNbrs(Counter) Then
                For Counter2 = Counter To 28123 - Counter
                    If AbundantNbrs(Counter2) Then
                        AbundantSums(Counter + Counter2) = 0
                    End If
                Next
            End If
        Next

        Console.WriteLine(Sum(AbundantSums))
        Console.ReadLine()

    End Sub

    Function GetFactors(ByVal X)
        Dim Result() As Object
        Dim Counter As Object

        ReDim Result(1)
        Result(0) = 1
        Result(1) = X

        For Counter = 2 To Int(Sqrt(X))
            If Int(X / Counter) = X / Counter Then
                ReDim Preserve Result(UBound(Result) + 2)
                Result(UBound(Result) - 1) = Counter
                If Counter <> X / Counter Then Result(UBound(Result)) = X / Counter Else ReDim Preserve Result(UBound(Result) - 1)
            End If
        Next Counter

        getFactors = Result
    End Function

    Function Sum(ByVal X As Array)
        Dim Result As ULong
        Dim Counter As Integer

        For Counter = 1 To X.Length - 1
            Result += X(Counter)
        Next

        Sum = Result
    End Function

End Module