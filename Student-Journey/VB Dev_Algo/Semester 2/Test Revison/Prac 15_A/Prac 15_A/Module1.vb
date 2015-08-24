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
            While Not myReader.EndOfData
                currentRow = myReader.ReadFields()
                If holdCity <> currentRow(0) Then

                End If
            End While
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

    Private Sub PrintSectionFooter()
        Console.WriteLine("Total: ".PadRight())
    End Sub

End Module