Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()
        Console.Title = "s213200619-PRT Assignment"

        PrintHeading()
        Dim currentRow As String()
        Dim holdFaculty As String
        Dim holdDepart As String

        Dim studentCount As Integer = 0

        Using myReader As New FileIO.TextFieldParser("students.txt")
            myReader.TextFieldType = FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdFaculty = currentRow(0)
            holdDepart = currentRow(1)

            PrintCourseHeading(holdFaculty)
            PrintDepartmentHeading(holdDepart)
            PrintStudentline(currentRow(2), currentRow(3))
            studentCount += 1
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()

                If holdFaculty <> currentRow(0) Then


                    PrinttotalStudents(studentCount, holdDepart)
                    PrintCourseHeading(currentRow(0))

                    PrintDepartmentHeading(currentRow(1))
                    holdDepart = currentRow(1)
                    holdFaculty = currentRow(0)
                    studentCount = 0
                ElseIf holdDepart <> currentRow(1)
                    PrinttotalStudents(studentCount, holdDepart)
                    PrintDepartmentHeading(currentRow(1))

                    holdDepart = currentRow(1)
                    studentCount = 0
                End If

                'Always has to happen
                PrintStudentline(currentRow(2), currentRow(3))
                studentCount += 1
            End While
            PrinttotalStudents(studentCount, holdDepart)
        End Using

        Console.ReadLine()
    End Sub

    Private Sub PrinttotalStudents(studCount As Integer, holdDepartment As String)
        Console.WriteLine()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("There are {0} students in {1} ", studCount.ToString(), holdDepartment)
        Console.WriteLine()

        Console.ResetColor()
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
        Console.WriteLine()
        Console.WriteLine("School of: " + holdFaculty)
        Console.WriteLine("---------------")
        Console.ResetColor()
    End Sub

    Private Sub PrintHeading()
        Console.WriteLine("NMMU Registered Students and Course")
        Console.WriteLine("-----------------------------------")
    End Sub
End Module