Module Module1

    Sub Main()

        Dim NumberofItems As Integer
        Dim NoMoreSwaps As Boolean
        Dim List As New ArrayList
        Dim Temp As String
        Dim Counter As Integer
        Dim TotalScore As ULong
        Dim Score As ULong
        Dim Index As Integer

        NumberofItems = 0

        FileOpen(1, "C:\Documents and Settings\Jamie\My Documents\Project Euler\Problem 22 Names.txt", OpenMode.Input)

        Do Until EOF(1) = True
            NumberofItems = NumberofItems + 1
            List.Add(LineInput(1))
        Loop
        FileClose(1)

        NumberofItems = NumberofItems - 1

        Do Until NoMoreSwaps = True
            NoMoreSwaps = True
            For Counter = 0 To (NumberofItems - 1)
                If List(Counter) > List(Counter + 1) Then
                    NoMoreSwaps = False
                    Temp = List.Item(Counter)
                    List.Item(Counter) = List.Item(Counter + 1)
                    List.Item(Counter + 1) = Temp
                End If
            Next
            NumberOfItems = NumberOfItems - 1
        Loop

        For Counter = 0 To (List.Count - 1)
            For Index = 1 To Len(List(Counter))
                Score = Score + (InStr("ABCDEFGHIJKLMNOPQRSTUVWXYZ", Mid((List(Counter)), Index, 1)))
            Next
            Score = Score * (Counter + 1)
            TotalScore = TotalScore + Score
            Score = 0
        Next

        Console.WriteLine(TotalScore)
        Console.ReadLine()

    End Sub

End Module