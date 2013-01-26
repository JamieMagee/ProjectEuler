Module Module1

    Sub Main()

        Dim answer As String

        answer = Two(1000)

        Console.WriteLine(answer)
        Console.ReadLine()

    End Sub

    Function Two(ByVal power As Integer) As String

        Dim digits As Integer = CInt(Int(power * Math.Log10(2)))

        Dim number(digits) As Byte
        number(digits) = 1

        For i As Integer = 1 To power
            Dim carry As Byte = 0
            For j As Integer = digits To 0 Step -1
                number(j) <<= 1
                number(j) = number(j) + carry
                If number(j) > 9 Then
                    carry = number(j) \ CByte(10)
                    number(j) = number(j) - CByte(10)
                Else
                    carry = 0
                End If
            Next
        Next

        Dim result As Integer
        For i As Integer = 0 To digits
            result = result + number(i)
        Next
        Return result.ToString

    End Function


End Module