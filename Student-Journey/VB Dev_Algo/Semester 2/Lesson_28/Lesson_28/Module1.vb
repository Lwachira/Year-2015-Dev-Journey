Module Module1

    Sub Main()
        Dim sum As Integer = 0
        Dim count As Integer = 0
        Dim currentRow As String()
        Dim holdStudentNumber, studentName As String
        Dim mark1, mark2, mark3, mark4 As String
        Console.Title = "Lesson 28"
        Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Lesson28.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdStudentNumber = currentRow(0)
            studentName = currentRow(1) + " " + currentRow(2)
            PrintReportHeadline()
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()
                If holdStudentNumber <> currentRow(0) Then
                    PrintLine(holdStudentNumber, studentName, mark1, mark2, mark3, mark4)
                    holdStudentNumber = currentRow(0)
                    studentName = currentRow(1) + " " + currentRow(2)
                End If
            End While
            PrintLine(holdStudentNumber, studentName, mark1, mark2, mark3, mark4)

        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintReportHeadline()
        Console.WriteLine("Final Marks Report")
        Console.WriteLine("==================")
        Console.WriteLine("Student#   " + "Name".PadRight(20, " ") +
                          vbTab + "Mark1" + vbTab + "Mark2" + vbTab + "Mark3" + vbTab + "Mark4" + vbTab + "Final" + vbTab + "Result")
    End Sub

    Private Sub PrintLine(studentNumber As String, studentName As String, mark1 As String, mark2 As String, mark3 As String, mark4 As String)
        Console.WriteLine(studentNumber + "   " + studentName.PadRight(20, " ") + vbTab + mark1 + vbTab + mark2 + vbTab + mark3 + vbTab + mark4)
    End Sub
End Module
