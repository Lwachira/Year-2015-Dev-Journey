Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Console.Title = "Question 1"

        Dim currentRow As String()
        Dim total, highest As Integer
        Dim holdCity As String

        Using myReader As New FileIO.TextFieldParser("Rainfall.txt")

            myReader.TextFieldType = FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdCity = currentRow(0)
            total = Integer.Parse(currentRow(2))
            highest = -1
            highest = Math.Max(total, highest)

            PrintReportHeading()
            PrintSectionHeading(holdCity)
            PrintLine(currentRow(1), currentRow(2))
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()

                If holdCity <> currentRow(0) Then
                    PrintSectionFooter(total)
                    highest = Math.Max(total, highest)
                    total = 0
                    holdCity = currentRow(0)
                    PrintSectionHeading(holdCity)
                End If
                PrintLine(currentRow(1), currentRow(2))
                total += Integer.Parse(currentRow(2))
            End While
            highest = Math.Max(total, highest)
            PrintSectionFooter(total)
            PrintReportFooter(highest)
        End Using

        Console.ReadLine()

    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("RAINFALL REPORT")
        Console.WriteLine("===============")
    End Sub
    Private Sub PrintSectionHeading(city As String)
        Console.WriteLine(city.ToUpper.PadRight(16, " ") + vbTab + "Rainfall (mm)")
    End Sub

    Private Sub PrintLine(cityDate As String, rainFall As String)
        Console.WriteLine(cityDate.PadRight(16, " ") + vbTab + rainFall)
    End Sub

    Private Sub PrintSectionFooter(total As Integer)
        Console.WriteLine("Total: ".PadRight(16, " ") + vbTab + "{0}", total)
        Console.WriteLine()
    End Sub

    Private Sub PrintReportFooter(highest As Integer)
        Console.WriteLine("Highest recorded total rainfall:  {0}", highest)
    End Sub

End Module