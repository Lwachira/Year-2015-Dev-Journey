Module Module1

    Sub Main()
        Dim currentRow As String()
        Dim minTotal, maxTotal, count As Integer
        Dim holdCity As String

        Console.Title = "Question 2"
        Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Weather.txt")
            myReader.TextFieldType = FileIO.FieldType.Delimited
            myReader.SetDelimiters("#")

            currentRow = myReader.ReadFields()
            holdCity = currentRow(0)
            PrintReportHeading()

            minTotal = Integer.Parse(currentRow(2))
            maxTotal = Integer.Parse(currentRow(3))
            count = 1
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()
                If holdCity <> currentRow(0) Then
                    PrintLine(holdCity, minTotal, maxTotal, count)
                    minTotal = 0
                    maxTotal = 0
                    count = 0
                    holdCity = currentRow(0)
                End If
                minTotal += Integer.Parse(currentRow(2))
                maxTotal += Integer.Parse(currentRow(3))
                count += 1
            End While
        End Using
        PrintLine(holdCity, minTotal, maxTotal, count)
        Console.ReadLine()
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("WEATHER REPORT")
        Console.WriteLine("==============")
        Console.WriteLine("CITY".PadRight(16, " ") + vbTab + "AVG MIN" + vbTab + "AVG MAX")
        Console.WriteLine("----".PadRight(16, " ") + vbTab + "-------" + vbTab + "-------")

    End Sub

    Private Sub PrintLine(city As String, minTotal As Integer, maxTotal As Integer, count As Integer)
        Dim minAverage, maxAverage As Double
        minAverage = minTotal / count
        maxAverage = maxTotal / count
        Console.WriteLine("{0}" + vbTab + "{1}" + vbTab + "{2}", city.PadRight(16, " "), Math.Round(minAverage), Math.Round(maxAverage))

    End Sub

End Module