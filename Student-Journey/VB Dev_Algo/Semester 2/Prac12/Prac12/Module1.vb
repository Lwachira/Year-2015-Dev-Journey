Module Module1

    Sub Main()
        Console.Title = "Prac 12"
        Dim currentRow As String()
        Dim holdNumber As String

        Using myReader As New FileIO.TextFieldParser("Marks.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdNumber = currentRow(0)
            PrintHead()
            While Not myReader.EndOfData

            End While
        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintHead()
        Console.WriteLine("Student# " + " Student Name")
    End Sub
End Module
