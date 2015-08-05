Module Module1

    Sub Main()
        Console.Title = "Lesson 26"
        Dim currentRow As String()
        Dim total As Double
        Dim subtotal As Double = 0
        Dim finalTotal As Double = 0
        Dim holdOrderNumber As String
        Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser("Lesson_26.txt")
            myreader.TextFieldType = FileIO.FieldType.Delimited
            myreader.SetDelimiters("#")
            currentRow = myreader.ReadFields()

            holdOrderNumber = currentRow(0)
            subtotal += Integer.Parse(currentRow(3)) * Double.Parse(currentRow(4))
            PrintHeader()
            PrintOrderNumber(holdOrderNumber)
            PrintOrderLine(currentRow(2), currentRow(1), currentRow(3), currentRow(4))
            While Not myreader.EndOfData
                currentRow = myreader.ReadFields()
                If (holdOrderNumber <> currentRow(0)) Then
                    PrintSectionFooter(subtotal)
                    finalTotal += subtotal
                    subtotal = 0
                    holdOrderNumber = currentRow(0)
                    PrintOrderNumber(holdOrderNumber)
                End If
                PrintOrderLine(currentRow(2), currentRow(1), currentRow(3), currentRow(4))
                subtotal += Integer.Parse(currentRow(3)) * Double.Parse(currentRow(4))

            End While

        End Using
        PrintSectionFooter(subtotal)
        finalTotal += subtotal
        printReportFinal(finalTotal)
        finalTotal = 0
        Console.ReadLine()
    End Sub

    Private Sub printReportFinal(finalTotal As Double)
        Console.WriteLine("Total Sales: " + finalTotal.ToString("f2"))
    End Sub

    Private Sub PrintSectionFooter(subtotal As Double)
        Console.WriteLine("Total: " + subtotal.ToString("f2"))
        Console.WriteLine()

    End Sub

    Private Sub PrintOrderLine(c1 As String, c2 As String, c3 As String, c4 As String)
        Dim subTotal As Double
        subTotal = Double.Parse(c3) * Double.Parse(c4)
        If c1.Contains("A") Then
            Console.WriteLine(c2.ToString() + vbTab + vbTab + "(" + c3.ToString() + " x " + c4.ToString() + ")" + vbTab + subTotal.ToString("f2"))

        Else
            Console.WriteLine(c1.ToString() + " " + c2.ToString() + vbTab + vbTab + "(" + c3.ToString() + " x " + c4.ToString() + ")" + vbTab + subTotal.ToString("f2"))

        End If

    End Sub

    Private Sub PrintOrderNumber(holdOrderNumber As String)
        Console.WriteLine("Order Number: {0}", holdOrderNumber)
    End Sub

    Private Sub PrintHeader()
        Console.WriteLine("Domino's Sales")
        Console.WriteLine("==============")

    End Sub
End Module
