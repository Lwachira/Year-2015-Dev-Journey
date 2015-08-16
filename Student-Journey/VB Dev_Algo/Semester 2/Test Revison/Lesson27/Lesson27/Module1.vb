Module Module1

    Sub Main()
        Dim total As Double = 0
        Dim count As Integer = 0
        Dim finalTotal As Double = 0
        Dim average As Double = 0
        Dim currentRow As String()
        Dim holdSalesPersonCode, salesPersonName As String
        Console.Title = "Lesson 27"
        Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser("data.txt")
            myreader.TextFieldType = FileIO.FieldType.Delimited
            myreader.SetDelimiters("#")
            PrintReportHeading()
            currentRow = myreader.ReadFields()
            holdSalesPersonCode = currentRow(0)
            salesPersonName = currentRow(1)
            total += Double.Parse(currentRow(3))

            While Not myreader.EndOfData
                currentRow = myreader.ReadFields()
                If holdSalesPersonCode <> currentRow(0) Then
                    PrintOrderLine(holdSalesPersonCode, salesPersonName, total)
                    finalTotal += total
                    count += 1
                    total = 0
                End If
                holdSalesPersonCode = currentRow(0)
                salesPersonName = currentRow(1)
                total += Double.Parse(currentRow(3))

            End While

            PrintOrderLine(holdSalesPersonCode, salesPersonName, total)
            finalTotal += total
            count += 1
            average = finalTotal / count

            PrintReportFooter(finalTotal, count, average)
            total = 0
            Console.ReadLine()
        End Using
    End Sub

    Private Sub PrintOrderLine(holdSalesPersonCode As String, salesPersonName As String, total As Double)
        Console.WriteLine(holdSalesPersonCode + vbTab + salesPersonName.PadRight(20, " ") + vbTab +
                total.ToString())
    End Sub

    Private Sub PrintReportFooter(finalTotal As Double, count As Integer, average As Double)
        Console.WriteLine()
        Console.WriteLine("TOTAL VEHICLES SOLD: {0}", finalTotal)
        Console.WriteLine("NUMBER OF SALES STAFF: {0}", count)
        Console.WriteLine("AVERAGE SALES PER SALES PERSON: {0}", average)
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("FRANK's CAR DEALERSHIP: 2015 SALES REPORT")
        Console.WriteLine("=========================================")
        Console.WriteLine("CODE" + vbTab + "NAME".PadRight(20, " ") + vbTab +
        "VEHICLES SOLD")
    End Sub
End Module