Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Header()
        Dim currentRow As String()
        Dim holdBranch As String
        Dim holdDepartment As String
        Dim totalDepartment As Double = 0
        Dim totalBranch As Double = 0
        Dim highestTotal As Integer = -1
        Dim lowestTotal As Integer = 10000000
        Dim highestName As String = ""
        Dim lowestName As String = ""
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
                    highestTotal = Math.Max(highestTotal, totalBranch)
                    lowestTotal = Math.Min(lowestTotal, totalBranch)

                    If totalBranch >= highestTotal Then
                        highestName = holdBranch
                    End If
                    If totalBranch <= lowestTotal Then
                        lowestName = holdBranch
                    End If

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
            highestTotal = Math.Max(highestTotal, totalBranch)
            lowestTotal = Math.Min(lowestTotal, totalBranch)

            PrintBranchLine(holdDepartment, totalDepartment)
            PrintBranchFooter(holdBranch, totalBranch)

            If totalBranch >= highestTotal Then
                highestName = holdBranch
            End If
            If totalBranch <= lowestTotal Then
                lowestName = holdBranch
            End If
            'PrintReport(highestTotal, lowestTotal)
            PrintReportName(highestName, lowestName, highestTotal, lowestTotal)
        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintReportName(highestName As String, lowestName As String, highestTotal As Integer, lowestTotal As Integer)
        Console.WriteLine()
        Console.WriteLine("Branch With Highest Sales Total: " + highestName + " With a value of: " + highestTotal.ToString("c2"))
        Console.WriteLine("Branch With Lowest Sales Total: " + lowestName + " With a value of: " + lowestTotal.ToString("c2"))
    End Sub

    'Private Sub PrintReport(high As Integer, low As Integer)
    '    Console.WriteLine()
    '    Console.WriteLine("Branch With Highest Sales Total: " + high.ToString("c2"))
    '    Console.WriteLine("Branch With Lowest Sales Total: " + low.ToString("c2"))
    'End Sub

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