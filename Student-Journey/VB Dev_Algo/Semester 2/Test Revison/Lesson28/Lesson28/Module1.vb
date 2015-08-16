Module Module1

    Sub Main()
        Dim sum As Integer = 0
        Dim count As Integer = 0
        Dim currentRow As String()
        Dim holdStudentNumber, studentName As String
        Dim mark1, mark2, mark3, mark4 As String

        Console.Title = "Lesson 28"
        Try
            Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("data.txt")
                myReader.TextFieldType = FileIO.FieldType.Delimited
                myReader.SetDelimiters("#")
                PrintReportHeading()
                currentRow = myReader.ReadFields()
                holdStudentNumber = currentRow(0)
                studentName = currentRow(1)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("FINAL MARKS REPORT")
        Console.WriteLine("==================")
        Console.WriteLine("STUDENT# " + "NAME".PadRight(20, " ") + vbTab +
"MARK1" + vbTab + "MARK2" + vbTab + "MARK3" + vbTab + "MARK4" + vbTab +
"FINAL" + vbTab + "RESULT")
    End Sub
End Module