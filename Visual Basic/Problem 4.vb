Module Module1

    Sub Main()
        Dim Num1 As Integer
        Dim Num2 As Integer
        Dim product As ULong
        Dim productstring As String
        Dim counter1 As Integer
        Dim counter2 As Integer
        Dim answer As ULong

        Num1 = 999
        Num2 = 999
        answer = 0

            For counter1 = Num1 To 100 Step -1
                For counter2 = Num2 To 100 Step -1
                    product = counter1 * counter2
                    productstring = Convert.ToString(product)
                    If productstring = StrReverse(productstring) Then
                    If product > answer Then
                        answer = product
                    End If
                End If
            Next
            Next

        Console.WriteLine(answer)
        Console.ReadLine()

    End Sub

End Module