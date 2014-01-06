Module Module1

    Sub Main()

        Dim GridLine(20) As String
        Dim NumGrid(20, 20) As Integer
        Dim i As Integer
        Dim j As Integer
        Dim Start As Integer
        Dim vert As ULong
        Dim horz As ULong
        Dim diag1 As ULong
        Dim diag2 As ULong
        Dim MaxProduct As ULong

        MaxProduct = 0

        'Open File and read in one line at NumGrid time
        FileOpen(1, "C:\Documents and Settings\Jamie\My Documents\Project Euler\Problem 11 Numbers.txt", OpenMode.Input)
        For i = 1 To 20
            GridLine(i) = LineInput(1)
        Next
        FileClose(1)

        'Split each line into its individual numbers, and read into array
        For i = 1 To 20
            Start = 1
            For j = 1 To 20
                NumGrid(i, j) = Convert.ToInt32(Mid(GridLine(i), Start, 2))
                Start += 2
            Next
        Next

        For i = 1 To 20
            For j = 1 To 20

                'Calculate Max Product Vertically
                If i < 18 Then
                    vert = NumGrid(i, j) * NumGrid(i + 1, j) * NumGrid(i + 2, j) * NumGrid(i + 3, j)
                End If
                If MaxProduct < vert Then
                    MaxProduct = vert
                End If

                'Calculate Max Product Horizontally
                If j < 18 Then
                    horz = NumGrid(i, j) * NumGrid(i, j + 1) * NumGrid(i, j + 2) * NumGrid(i, j + 3)
                End If
                If MaxProduct < horz Then
                    MaxProduct = horz
                End If

                'Calculate Max Product Diagonally Right
                If i < 18 And j < 18 Then
                    diag1 = NumGrid(i, j) * NumGrid(i + 1, j + 1) * NumGrid(i + 2, j + 2) * NumGrid(i + 3, j + 3)
                End If
                If MaxProduct < diag1 Then
                    MaxProduct = diag1
                End If

                'Calculate Max Product Diagonally Left
                If i < 18 And j > 3 Then
                    diag2 = NumGrid(i, j) * NumGrid(i + 1, j - 1) * NumGrid(i + 2, j - 2) * NumGrid(i + 3, j - 3)
                End If
                If MaxProduct < diag2 Then
                    MaxProduct = diag2
                End If

            Next
        Next

        Console.WriteLine(MaxProduct)
        Console.ReadLine()

    End Sub

End Module