Module Module1

    Sub Main()
        Console.Title = "Prac 12"
        Dim currentRow As String()
        Dim subTotal As Integer
        Dim average As Double
        Dim studentCount As Integer = 1
        Using myReader As New FileIO.TextFieldParser("Marks.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            PrintHead()
            subTotal += Integer.Parse(currentRow(3)) + Integer.Parse(currentRow(4)) + Integer.Parse(currentRow(5)) + Integer.Parse(currentRow(6))
            average = subTotal / 4
            printStudentLine(currentRow, average)

            While Not myReader.EndOfData
                subTotal = 0
                currentRow = myReader.ReadFields()
                subTotal += Integer.Parse(currentRow(3)) + Integer.Parse(currentRow(4)) + Integer.Parse(currentRow(5)) + Integer.Parse(currentRow(6))
                average = subTotal / 4
                printStudentLine(currentRow, average)
                subTotal = 0
                studentCount += 1
            End While
        End Using
        Console.WriteLine()
        Console.Write("Number of Students: " + studentCount.ToString())
        Console.ReadLine()
    End Sub



    Private Sub printStudentLine(currentRow() As String, average As Double)



        Console.Write(currentRow(0) + "  " + currentRow(1) + " " + currentRow(2).PadRight(10) + vbTab + currentRow(3) + "{0}" + currentRow(4) + "{0}" + currentRow(5) + "{0}" + currentRow(6) + "{0}" + average.ToString(), vbTab)
        Console.WriteLine()
    End Sub

    Private Sub PrintHead()
        Console.Write("Student# " + " Student   Name ".PadRight(10) + vbTab + "Mark 1 " + " Mark 2 " + " Mark 3 " + " Mark 4 " + "Average")
        'For index = 1 To 4
        '    Console.Write(" Mark " + index.ToString() + " ")
        'Next
        'Console.Write("Average")
        Console.WriteLine()
    End Sub
End Module
