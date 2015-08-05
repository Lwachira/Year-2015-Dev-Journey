Module Module1

    Sub Main()

        Dim total As Double = 0
        Dim count As Integer = 0
        Dim finalTotal As Double = 0
        Dim average As Double = 0
        Dim currentRow As String()
        Dim holdSalesPersonCode, salesPersonName As String
        Console.Title = "Lesson 27"
        Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser("lesson27.txt")
            myreader.TextFieldType = FileIO.FieldType.Delimited
            myreader.SetDelimiters("#")
            PrintReportHeading()
            currentRow = myreader.ReadFields
            holdSalesPersonCode = currentRow(0)
            salesPersonName = currentRow(1)

            While Not myreader.EndOfData

                total += Double.Parse(currentRow(3))
                currentRow = myreader.ReadFields()

                If holdSalesPersonCode <> currentRow(0) Then
                    PrintReadLine(holdSalesPersonCode, salesPersonName, total)

                    holdSalesPersonCode = currentRow(0)
                    salesPersonName = currentRow(1)
                    count = count + 1
                    finalTotal += total
                    total = 0
                End If

            End While
            total += Double.Parse(currentRow(3))
            PrintReadLine(holdSalesPersonCode, salesPersonName, total)
            count = count + 1
            finalTotal += total
            average = finalTotal / count
        End Using

        PrintReportFooter(finalTotal, count, average)
        Console.ReadLine()

    End Sub

    Private Sub PrintReadLine(code As String, name As String, total As Double)
        Console.WriteLine("(" + code.ToString() + ")" + vbTab + name.PadRight(20, " ") + vbTab + total.ToString())
    End Sub

    Private Sub PrintReportFooter(finalTotal As Double, count As Integer, average As Double)
        Console.WriteLine()
        Console.WriteLine("Total Vehicles Sold:  {0}", finalTotal)
        Console.WriteLine("Number of sales staff: {0}", count)
        Console.WriteLine("Average sales per sales person: {0}", average)
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("Franks Car Dealership: 2015 Sales Report")
        Console.WriteLine("========================================")
        Console.WriteLine("Code" + vbTab + "Name".PadRight(20, " ") + vbTab + "Vehicles Sold")
    End Sub
End Module
