Module Module1

    Sub Main()

        Dim height(4) As Double
        Dim name(4) As String

        GetStudentDetails(height, name)
        UnsortedStudentDetails(height, name)
        AscendingOrder(height, name)
        DescendingOrder(height, name)



        Console.ReadLine()

    End Sub

    Private Sub GetStudentDetails(height As Double(), name As String())
        'Populating the arrays with data
        For i = 0 To height.Length - 1
            Console.Write("Please enter your friends name: ")
            name(i) = Console.ReadLine()
            Console.Write("Please enter {0} height: ", name(i))
            height(i) = Double.Parse(Console.ReadLine())

        Next
    End Sub

    Private Sub UnsortedStudentDetails(height As Double(), name As String())
        Console.Clear()
        Console.WriteLine("Unsorted list")
        Console.WriteLine("--------------")
        For i = 0 To height.Length - 1
            Console.WriteLine("{0}{1}{2}", name(i), vbTab, height(i).ToString("f2"))
        Next

    End Sub

    Private Sub AscendingOrder(height As Double(), name As String())
        Console.WriteLine()
        Console.WriteLine("Ascended Order")
        Console.WriteLine("--------------")
        Dim x, futureValue As Double
        Dim futureName As String
        Dim done As Boolean
        For i = 1 To height.Length - 1
            done = False
            futureValue = height(i)
            futureName = name(i)
            x = i - 1
            While x >= 0 And done = False
                If height(x) > futureValue Then
                    height(x + 1) = height(x)
                    name(x + 1) = name(x)
                    x = x - 1
                Else
                    done = True
                End If


            End While
            height(x + 1) = futureValue
            name(x + 1) = futureName

        Next

        For i = 0 To height.Length - 1
            Console.WriteLine("{0}{1}{2}", height(i).ToString("f2"), vbTab, name(i))
        Next

    End Sub

    Private Sub DescendingOrder(height As Double(), name As String())
        Console.WriteLine()
        Console.WriteLine("Descended Order")
        Console.WriteLine("--------------")

        Dim x, futureValue As Double
        Dim futureName As String
        Dim done As Boolean
        For i = 1 To height.Length - 1
            done = False
            futureValue = height(i)
            futureName = name(i)
            x = i - 1
            While x >= 0 And done = False
                If height(x) < futureValue Then
                    height(x + 1) = height(x)
                    name(x + 1) = name(x)
                    x = x - 1
                Else
                    done = True
                End If


            End While
            height(x + 1) = futureValue
            name(x + 1) = futureName

        Next

        For i = 0 To height.Length - 1
            Console.WriteLine("{0}{1}{2}", height(i).ToString("f2"), vbTab, name(i))
        Next
    End Sub

End Module
