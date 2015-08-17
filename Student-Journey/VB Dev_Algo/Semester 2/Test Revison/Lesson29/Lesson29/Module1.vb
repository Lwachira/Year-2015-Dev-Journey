Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Dim currentRow As String()
        Dim minTotal, maxTotal, count As Integer
        Dim lowestMin, highestMax As Integer
        Dim holdCity As String
        Console.Title = "Lesson 29"
        Try
            Using myReader As New TextFieldParser("data.txt")
                myReader.TextFieldType = FieldType.Delimited
                myReader.SetDelimiters("#")

                currentRow = myReader.ReadFields()
                holdCity = currentRow(0)

                PrintReportHeading()
                PrintSectionHeading(currentRow(0))
                printOrderLine(currentRow)

                'Initialize the totals and count
                minTotal = Integer.Parse(currentRow(2))
                maxTotal = Integer.Parse(currentRow(3))
                count = 1

                lowestMin = Integer.Parse(minTotal)
                highestMax = Integer.Parse(maxTotal)

                While Not myReader.EndOfData
                    currentRow = myReader.ReadFields()
                    If holdCity <> currentRow(0) Then
                        PrintSectionFooter(minTotal, maxTotal, count)
                        minTotal = 0
                        maxTotal = 0
                        count = 0
                        holdCity = currentRow(0)
                        PrintSectionHeading(currentRow(0))
                    End If

                End While

            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Console.ReadLine()
    End Sub

    Private Sub PrintSectionFooter(minTotal As Integer, maxTotal As Integer, count As Integer)
        Dim minAverage, maxAverage As Double
        minAverage = minTotal / count
        maxAverage = maxTotal / count
        Console.WriteLine("AVERAGE:".PadRight(16, " ") + vbTab + "{0}" + vbTab + "{1}", Math.Round(minAverage), Math.Round(maxAverage))
        Console.WriteLine()
    End Sub

    Private Sub printOrderLine(currentRow() As String)
        Console.WriteLine(currentRow(0).PadRight(20) + currentRow(1) + vbTab + (currentRow(2)))
    End Sub

    Private Sub PrintSectionHeading(city As String)
        Console.WriteLine(city.PadRight(20) + "Min" + vbTab + vbTab + "Max")
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("Weather Report")
        Console.WriteLine("==============")
    End Sub
End Module