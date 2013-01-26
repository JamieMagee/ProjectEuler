Imports System.Numerics

Module Module1

    Sub Main()

        Dim Multiplicand As Integer
        Dim Multiplier As Integer
        Dim Product As Integer
        Dim Input As String
        Dim Answer As New ArrayList
        Dim Total As Integer

        For Multiplicand = 1 To 2000
            For Multiplier = Multiplicand To 2000
                Product = Multiplicand * Multiplier
                Input = Product & Multiplicand & Multiplier
                If IsPandigital(Input) = True Then
                    If Not Answer.Contains(Product) Then
                        Answer.Add(Product)
                        Total += Product
                    End If
                End If
            Next
        Next

        Console.WriteLine(Total)
        Console.ReadLine()

    End Sub

    Function IsPandigital(ByRef Input As String) As Boolean

        Dim Counter As Integer

        If Len(Input) = 9 Then
            If InStr(Input, "1") Then
                If InStr(Input, "2") Then
                    If InStr(Input, "3") Then
                        If InStr(Input, "4") Then
                            If InStr(Input, "5") Then
                                If InStr(Input, "6") Then
                                    If InStr(Input, "7") Then
                                        If InStr(Input, "8") Then
                                            If InStr(Input, "9") Then
                                                Counter += 1
                                                If Counter Mod 2 <> 0 Then
                                                    IsPandigital = True
                                                End If
                                            Else
                                                IsPandigital = False
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Function

End Module