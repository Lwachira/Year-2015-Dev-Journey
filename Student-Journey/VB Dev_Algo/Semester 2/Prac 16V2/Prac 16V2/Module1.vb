Imports Microsoft.VisualBasic.FileIO
Module Module1

    Sub Main()
        Using myReader As New FileIO.TextFieldParser("2015 Sales.txt")
            PrintHeading()

            Console.ReadLine()
    End Sub

    Private Sub PrintHeading()
        Console.WriteLine("Nelson Mandela Bay Area - Spar Annual Sales Report")
        Console.WriteLine("===================================================")
    End Sub

End Module