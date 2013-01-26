Module Module1

    Sub Main()

        Dim penny, twopence, fivepence, tenpence, twentypence, fiftypence, pound, twopound As Integer
        Dim Counter As Decimal

        For penny = 0 To 200
            For twopence = 0 To 100
                For fivepence = 0 To 40
                    For tenpence = 0 To 20
                        For twentypence = 0 To 10
                            For fiftypence = 0 To 4
                                For pound = 0 To 2
                                    For twopound = 0 To 1
                                        If (penny * 1) + (twopence * 2) + (fivepence * 5) + (tenpence * 10) + (twentypence * 20) + (fiftypence * 50) + (pound * 100) + (twopound * 200) = 200 Then
                                            Counter = Counter + 1
                                        End If
                                    Next
                                Next
                            Next
                        Next
                    Next
                Next
            Next
        Next

        Console.WriteLine("There are " & Counter & " ways to make two pounds")
        Console.ReadLine()
    End Sub

End Module