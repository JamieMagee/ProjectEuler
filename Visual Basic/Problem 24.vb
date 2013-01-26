Module Module1

    Sub Main()

        Dim a As Integer
        Dim b As Integer
        Dim c As Integer
        Dim d As Integer
        Dim e As Integer
        Dim f As Integer
        Dim g As Integer
        Dim h As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Permutation As ULong
        Dim Number As Integer


        For a = 0 To 9
            For b = 0 To 9
                For c = 0 To 9
                    For d = 0 To 9
                        For e = 0 To 9
                            For f = 0 To 9
                                For g = 0 To 9
                                    For h = 0 To 9
                                        For i = 0 To 9
                                            For j = 0 To 9
                                                If Not (a = b Or a = c Or a = d Or a = e Or a = f Or a = g Or a = h Or a = i Or a = j Or b = c Or b = d Or b = e Or b = f Or b = g Or b = h Or b = i Or b = j Or c = d Or c = e Or c = f Or c = g Or c = h Or c = i Or c = j Or d = e Or d = f Or d = g Or d = h Or d = i Or d = j Or e = f Or e = g Or e = h Or e = i Or e = j Or f = g Or f = h Or f = i Or f = j Or g = h Or g = i Or g = j Or h = i Or h = j Or i = j) Then
                                                    Permutation = Permutation + 1
                                                    If Permutation = 1000000 Then
                                                        Console.WriteLine("Lexographical Permutation Number " & Permutation & ": ")
                                                        Console.WriteLine(a & b & c & d & e & f & g & h & i & j)
                                                        Console.ReadLine()
                                                    End If
                                                End If
                                            Next
                                        Next
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next

    End Sub

End Module