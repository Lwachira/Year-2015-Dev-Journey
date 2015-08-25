Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()

        Dim currentRow As String()
        Dim total As Integer
        Dim holdCity As String
        Console.Title = "Question 2"
        Using myReader As New FileIO.TextFieldParser("Rainfall.txt")
            myReader.TextFieldType = FieldType.Delimited
            myReader.SetDelimiters("#")
            currentRow = myReader.ReadFields()
            holdCity = currentRow(0)
            total = Integer.Parse(currentRow(2))
            PrintReportHeading()
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()
                If holdCity <> currentRow(0) Then
                    PrintLine(holdCity, total)
                    total = 0
                    holdCity = currentRow(0)

                End If
                total += Integer.Parse(currentRow(2))

            End While
            PrintLine(holdCity, total)
        End Using
        Console.ReadLine()
    End Sub

    Private Sub PrintReportHeading()
        Console.WriteLine("RAINFALL REPORT")
        Console.WriteLine("===============")
        Console.WriteLine("CITY".PadRight(16, " ") + vbTab +
        "TOTAL RAINFALL")
        Console.WriteLine("----".PadRight(16, " ") + vbTab +
        "--------------")
    End Sub
    Private Sub PrintLine(city As String, total As Integer)
        Console.Write(city.PadRight(16, " ") + vbTab +
        total.ToString() + vbTab)
        For index = 1 To total
            Console.Write("o")
        Next
        Console.WriteLine()
    End Sub
End Module