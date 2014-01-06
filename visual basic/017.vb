Module Module1

    Sub Main()

        Dim Counter As Integer
        Dim NumofChars As ULong
        Dim word As String

        For Counter = 1 To 1000
            word = words(Counter)
            NumofChars = NumofChars + Trim(Len(Replace(word, " ", "", 1)))
        Next

        Console.WriteLine(NumofChars)
        Console.ReadLine()

    End Sub

    Function words(ByVal Number As Integer) As String
        Dim small() As String = {"", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"}
        Dim tens() As String = {"", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"}
        Select Case Number
            Case Is < 20
                words = small(Number)
            Case 20 To 99
                words = tens(Number \ 10) + " " + small(Number Mod 10)
            Case 100 To 999
                words = small(Number \ 100) + " Hundred " + IIf(((Number Mod 100) <> 0), "and ", "") + words(Number Mod 100)
            Case 1000
                words = "one thousand"
        End Select
    End Function

End Module