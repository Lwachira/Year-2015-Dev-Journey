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

                average = subTotal / 4
                PrintEachLine(currentRow, average)
                subTotal = 0
                While Not myReader.EndOfData
                    currentRow = myReader.ReadFields()
                    subTotal += Integer.Parse(currentRow(3)) + Integer.Parse(currentRow(4)) + Integer.Parse(currentRow(5)) + Integer.Parse(currentRow(6))

                    average = subTotal / 4
                    PrintEachLine(currentRow, average)
                    subTotal = 0
                End While

            End Using
        Catch ex As ArgumentException

        Finally
            Console.ReadLine()
        End Try
    End Sub

    Private Sub PrintEachLine(currentRow() As String, average As Double)
        Console.WriteLine(currentRow(0) + "  " + currentRow(1) + " " + currentRow(2).PadRight(10) + vbTab + currentRow(3) + "{0}" + currentRow(4) + "{0}" + currentRow(5) + "{0}" + currentRow(6) + "{0}" + average.ToString(), vbTab)
    End Sub

    Private Sub PrintHead()
        Console.WriteLine("Student# " + " Student Name ".PadRight(15) + vbTab + "Mark 1 " + " Mark 2 " + " Mark 3 " + " Mark 4 " + "Average")
    End Sub
End Module