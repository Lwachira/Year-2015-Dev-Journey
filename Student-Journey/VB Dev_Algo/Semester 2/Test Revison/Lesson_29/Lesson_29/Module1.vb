Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()
        Dim currentRow As String()
        Dim minTotal, maxTotal, count As Integer
        Dim lowestMin, highestMax As Integer
        Dim holdcity As String

        Console.Title = "Question 1"

        Try
            Using myReader As New TextFieldParser("Weather.txt")

                myReader.TextFieldType = FieldType.Delimited
                myReader.SetDelimiters("#")

                currentRow = myReader.ReadFields()
                holdcity = currentRow(0)
                PrintReportHeading()
                PrintSectionHeading(currentRow(0))
                PrintLine(currentRow(1), currentRow(2), currentRow(3))
                minTotal = Integer.Parse(currentRow(2))
                maxTotal = Integer.Parse(currentRow(3))
                count = 1
                lowestMin = Integer.Parse(currentRow(2))
                highestMax = Integer.Parse(currentRow(3))

                While Not myReader.EndOfData
                    currentRow = myReader.ReadFields()
                    If holdcity <> currentRow(0) Then
                        PrintSectionFooter(minTotal, maxTotal, count)
                        minTotal = 0
                        maxTotal = 0
                        count = 0
                        holdcity = currentRow(0)
                        PrintSectionHeading(currentRow(0))
                    End If
                    PrintLine(currentRow(1), currentRow(2), currentRow(3))
                    minTotal += Integer.Parse(currentRow(2))
                    maxTotal += Integer.Parse(currentRow(3))
                    count += 1
                    lowestMin = Math.Min(Integer.Parse(currentRow(2)), lowestMin)
                    highestMax = Math.Max(Integer.Parse(currentRow(3)), highestMax)
                End While

            End Using
            PrintSectionFooter(minTotal, maxTotal, count)
            PrintReportFooter(lowestMin, highestMax)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Console.ReadLine()
    End Sub

    Private Sub PrintReportFooter(lowestMin As Integer, highestMax As Integer)
        Console.WriteLine("LOWEST RECORDED MINIMUM:  {0}", lowestMin)
        Console.WriteLine("HIGHEST RECORDED MAXIMUM: {0}", highestMax)
    End Sub

    Private Sub PrintSectionFooter(minTotal As Integer, maxTotal As Integer, count As Integer)
        Dim minAverage, maxAverage As Double
        minAverage = minTotal / count
        maxAverage = maxTotal / count
        Console.WriteLine("AVERAGE:".PadRight(16, " ") + vbTab + "{0}" + vbTab + "{1}", Math.Round(minAverage), Math.Round(maxAverage))
        Console.WriteLine()
    End Sub

    Private Sub PrintSectionHeading(city As String)
        Console.WriteLine(city.ToUpper.PadRight(16, " ") + vbTab + "MIN" + vbTab + "MAX")
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("WEATHER REPORT")
        Console.WriteLine("==============")
    End Sub
    Private Sub PrintLine(cityDate As String, min As String, max As String)
        Console.WriteLine(cityDate.PadRight(16, " ") + vbTab + min + vbTab + max)
    End Sub
End Module