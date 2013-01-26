Module Module1

    Sub Main()

        Dim Numerator As Integer
        Dim Denominator As Integer
        Dim a As Single
        Dim b As Single
        Dim c As Single
        Dim d As Single
        Dim StrangeFraction As Decimal
        Dim Fraction As Decimal
        Dim Sum As Decimal = 1

        For Numerator = 10 To 99
            For Denominator = 10 To 99
                a = CInt(Mid(Convert.ToString(Numerator), 1, 1))
                b = CInt(Mid(Convert.ToString(Numerator), 2, 1))
                c = CInt(Mid(Convert.ToString(Denominator), 1, 1))
                d = CInt(Mid(Convert.ToString(Denominator), 2, 1))
                If b <> 0 And d <> 0 And Numerator <> Denominator And Numerator < Denominator Then
                    Select Case a
                        Case Is = c
                            StrangeFraction = b / d
                        Case Is = d
                            StrangeFraction = b / c
                    End Select
                    Select Case b
                        Case Is = c
                            StrangeFraction = a / d
                        Case Is = d
                            StrangeFraction = a / c
                    End Select
                    Fraction = (Numerator / Denominator)
                    If StrangeFraction = Fraction Then
                        Sum = Sum * StrangeFraction
                    Else
                        StrangeFraction = 0
                    End If
                End If
            Next
        Next

        Console.WriteLine("Sum: " & Sum)
        Console.ReadLine()

    End Sub

End Module