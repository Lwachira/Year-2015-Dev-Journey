Module Module1

    Sub Main()
        Dim currentRow As String()
        Dim subTotal As Integer
        Dim average As Double
        Dim studentCount As Integer = 1

        Try
            Using myReader As New FileIO.TextFieldParser("Marks.txt")
                myReader.TextFieldType = FileIO.FieldType.Delimited
                myReader.SetDelimiters("#")
                currentRow = myReader.ReadFields()
                PrintHead()
                subTotal += Integer.Parse(currentRow(3)) + Integer.Parse(currentRow(4)) + Integer.Parse(currentRow(5)) + Integer.Parse(currentRow(6))

                average = subTotal / studentCount
            End Using
        Catch ex As ArgumentException

        Finally
            Console.ReadLine()
        End Try
    End Sub

    Private Sub PrintHead()
        Console.WriteLine("Student# " + vbTab + "Student Name".PadRight(20) + "Mark 1 " + vbTab + " Mark 2 " + vbTab + " Mark 3 " + vbTab + " Mark 4 ")
    End Sub
End Module