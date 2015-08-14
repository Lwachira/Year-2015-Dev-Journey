Module Module1

    Sub Main()
        Dim sum As Double = 0
        Dim count As Integer = 0
        Dim currentRow As String()
        Dim holdStudentNumber, studentName As String
        Dim mark1, mark2, mark3, mark4 As String
        mark1 = " "
        mark2 = " "
        mark3 = " "
        mark4 = " "
        Console.Title = "Lesson 28"
        Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Lesson28.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdStudentNumber = currentRow(0)
            studentName = currentRow(1) + " " + currentRow(2)
            PrintReportHeadline()
            While Not myReader.EndOfData

                If currentRow(3).ToString().Contains("1") Then
                    mark1 = currentRow(4).ToString()
                ElseIf currentRow(3).ToString().Contains("2") Then
                    mark2 = currentRow(4).ToString()
                ElseIf currentRow(3).ToString().Contains("3") Then
                    mark3 = currentRow(4).ToString()
                ElseIf currentRow(3).ToString().Contains("4") Then
                    mark4 = currentRow(4).ToString()

                    sum += (Double.Parse(mark1) + Double.Parse(mark2) + Double.Parse(mark3) + Double.Parse(mark4)) / 4

                End If

                currentRow = myReader.ReadFields()

                If holdStudentNumber <> currentRow(0) Then
                    PrintLine(holdStudentNumber, studentName, mark1, mark2, mark3, mark4, sum)
                    holdStudentNumber = currentRow(0)
                    studentName = currentRow(1) + " " + currentRow(2)
                    sum = 0
                End If

            End While
            sum += (Double.Parse(mark1) + Double.Parse(mark2) + Double.Parse(mark3) + Double.Parse(mark4)) / 4
            PrintLine(holdStudentNumber, studentName, mark1, mark2, mark3, mark4, sum)

        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintReportHeadline()
        Console.WriteLine("Final Marks Report")
        Console.WriteLine("==================")
        Console.WriteLine("Student#   " + "Name".PadRight(20, " ") +
                          vbTab + "Mark1" + vbTab + "Mark2" + vbTab + "Mark3" + vbTab + "Mark4" + vbTab + "Final" + vbTab + "Result")
    End Sub

    Private Sub PrintLine(studentNumber As String, studentName As String, mark1 As String, mark2 As String, mark3 As String, mark4 As String, sum As Double)
        Dim result As String = ""
        If sum < 40 Then
            result = "F"
        ElseIf sum > 40 And sum < 75
            result = "P"
        Else
            result = "PD"
        End If
        Console.Write(studentNumber + "   " + studentName.PadRight(20, " ") + vbTab + mark1 + vbTab + mark2 + vbTab + mark3 + vbTab + mark4 + vbTab + sum.ToString() + vbTab + result)
        Console.WriteLine()
    End Sub
End Module