Module Module1

	Sub Main()
		Dim i As Integer
        Dim sum As Integer

        For i = 3 To 999
            If i Mod 3 = 0 Or i Mod 5 = 0 Then
                sum = sum + i
            End If
        Next
        Console.WriteLine(sum)
        Console.ReadLine()
    End Sub

End Module