Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Header()
        Dim currentRow As String()
        Dim holdBranch As String
        Dim holdDepartment As String
        Dim totalDepartment As Double = 0
        Dim totalBranch As Double = 0

        Console.Title = "Sales 2015"

        Using myReader As New FileIO.TextFieldParser("2015 Sales.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdBranch = currentRow(0)
            holdDepartment = currentRow(1)
            truSub(holdBranch)
            totalDepartment += Double.Parse(currentRow(4))

            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()
                If holdBranch <> currentRow(0) Then
                    totalBranch += totalDepartment

                    PrintBranchLine(holdDepartment, totalDepartment)
                    PrintBranchFooter(holdBranch, totalBranch)

                    holdDepartment = currentRow(1)
                    holdBranch = currentRow(0)
                    totalDepartment = 0
                    totalBranch = 0
                    truSub(holdBranch)
                ElseIf holdDepartment <> currentRow(1)

                    PrintBranchLine(holdDepartment, totalDepartment)
                    totalBranch += totalDepartment
                    totalDepartment = 0
                    holdDepartment = currentRow(1)

                End If
                totalDepartment += currentRow(4)

            End While
            totalBranch += totalDepartment
            PrintBranchLine(holdDepartment, totalDepartment)
            PrintBranchFooter(holdBranch, totalBranch)
        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintBranchLine(holdDepartment As String, totalDepartment As Double)
        Console.WriteLine(holdDepartment.PadRight(15) + totalDepartment.ToString("c2"))
    End Sub

    Private Sub PrintBranchFooter(holdBranch As String, totalBranch As Double)
        Console.WriteLine("2015 Sales For " + holdBranch + ":".PadRight(10) + totalBranch.ToString("c2"))
        Console.WriteLine()

    End Sub

    Private Sub Header()
        Console.WriteLine("Spar Annual Sales Report".ToUpper())
        Console.WriteLine("==========================")

    End Sub

    Private Sub truSub(branch As String)
        Console.WriteLine()
        Console.WriteLine("BRANCH: " + branch)
        Console.WriteLine("-----------------")
        Console.WriteLine("DEPARTMENT " + vbTab + "2015 Sales Totals")

    End Sub
End Module