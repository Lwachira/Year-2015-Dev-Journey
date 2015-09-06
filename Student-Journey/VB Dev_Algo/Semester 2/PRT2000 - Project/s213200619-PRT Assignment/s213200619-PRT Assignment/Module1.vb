Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()
        Console.Title = "s213200619-PRT Assignment"

        PrintHeading()
        Dim currentRow As String()
        Dim holdFaculty As String
        Dim holdDepart As String
        Dim studNum As String
        Dim studName As String
        Dim studentCount As Integer = 0

        Using myReader As New FileIO.TextFieldParser("students.txt")
            myReader.TextFieldType = FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdFaculty = currentRow(0)
            holdDepart = currentRow(1)
            studNum = currentRow(2)
            studName = currentRow(3)
            PrintCourseHeading(holdFaculty)
            PrintDepartmentHeading(holdDepart)
            PrintStudentline(studNum, studName)
            studentCount += 1
            While Not myReader.EndOfData

            End While

        End Using

        Console.ReadLine()
    End Sub

    Private Sub PrintStudentline(studNum As String, studName As String)
        Console.WriteLine(studNum + vbTab + studName)
    End Sub

    Private Sub PrintDepartmentHeading(holdDepart As String)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Department of: " + holdDepart)
        Console.ResetColor()
    End Sub

    Private Sub PrintCourseHeading(holdFaculty As String)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("School of: " + holdFaculty)
        Console.WriteLine("---------------")
        Console.ResetColor()
    End Sub

    Private Sub PrintHeading()
        Console.WriteLine("NMMU Registered Students and Course")
        Console.WriteLine("-----------------------------------")
        Console.WriteLine()
    End Sub
End Module