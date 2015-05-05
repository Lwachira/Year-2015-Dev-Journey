Module Module1

    Sub Main()
        Console.Title = "Bubble Sort"
        Dim anArray(5) As Integer

        fillArray(anArray)
        Console.WriteLine()
        Console.WriteLine("UNSORTED ARRAY:")
        DisplayArray(anArray)
        BubbleSort(anArray)
        Console.WriteLine("SORTED ARRAY:")
        DisplayArray(anArray)
  
        Console.ReadLine()
    End Sub

    'Fills array with of random numbers
    Private Sub fillArray(anArray As Integer())
        Dim number As New Random
        For i = 0 To anArray.Length - 1

            anArray(i) = number.Next(1, 101)

        Next

    End Sub

    'Display an the random array
    Private Sub DisplayArray(anArray As Integer())
        For i = 0 To anArray.Length - 2
            Console.Write(anArray(i).ToString() + ", ")
        Next
        Console.WriteLine(anArray(anArray.Length - 1))
    End Sub

    Private Sub BubbleSort(anArray As Integer())
        '80,20,13,20 some values
        Dim temp As Integer
        Dim n As Integer
        n = anArray.Length - 1
        For x = 0 To n

            For i = 1 To anArray.Length - 1
                If anArray(i - 1) < anArray(i) Then
                    temp = anArray(i - 1) 'temp = 80,20
                    anArray(i - 1) = anArray(i) 'anArray (i - 1) = 20,13
                    anArray(i) = temp 'anrray(i) = 80,20

                End If
                n = n - 1
            Next

        Next

    End Sub

    

End Module
