Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Dim currentRow As String()
        Dim holdBranch As String
        Dim holdDepartment As String
        Dim totalDepartment As Double = 0
        Dim totalBranch As Double = 0

        Using myReader As New FileIO.TextFieldParser("2015 Sales.txt")
            myReader.TextFieldType = FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdBranch = currentRow(0)
            holdDepartment = currentRow(1)
            PrintHeading()
            PrintBranchHeading(holdBranch)
        End Using

        Console.ReadLine()
    End Sub

    Private Sub PrintBranchHeading(holdBranch As String)
        Console.WriteLine("BRANCH: ".PadRight(10) + holdBranch)
        Console.WriteLine("-------------------")
        Console.WriteLine("DEPARTMENT".PadRight(20) + "2015 Sales Total")
    End Sub

    Private Sub PrintHeading()
        Console.WriteLine("Nelson Mandela Bay Area - Spar Annual Sales Report")
        Console.WriteLine("===================================================")
    End Sub

End Module