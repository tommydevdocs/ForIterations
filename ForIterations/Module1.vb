Module Module1

    Sub Main()
        For index = 1 To 10
            'Console.WriteLine(index)
            If (index = 7) Then
                Console.WriteLine("Found seven!")
                Exit For
            End If
        Next
        For i = 10 To 5 Step -1
            Console.WriteLine(i)

        Next

        Console.ReadLine()
    End Sub

End Module
