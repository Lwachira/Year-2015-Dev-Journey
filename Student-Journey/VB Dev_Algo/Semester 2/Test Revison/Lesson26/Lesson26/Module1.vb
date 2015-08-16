Module Module1

    Sub Main()
        Dim currentRow As String()
        Dim total As Double
        Dim subTotal As Double = 0
        Dim finalTotal As Double = 0
        Dim holdOrderNumber As String
        Console.Title = "Lesson 26"
        Try
            Using myReader As New Microsoft.VisualBasic.FileIO.TextFieldParser("data.txt")
                myReader.TextFieldType = FileIO.FieldType.Delimited
                myReader.SetDelimiters("#")
                PrintHead()
                currentRow = myReader.ReadFields()
                holdOrderNumber = currentRow(0)
                PrintOrderNumber(holdOrderNumber)
                total += Double.Parse(currentRow(3)) * Double.Parse(currentRow(4))
                PrintOrderLine(currentRow, total)
                subTotal += total
                total = 0
                While Not myReader.EndOfData
                    currentRow = myReader.ReadFields()

                    If holdOrderNumber <> currentRow(0) Then

                        finalTotal += subTotal
                        PrintTotal(subTotal)
                        subTotal = 0
                        holdOrderNumber = currentRow(0)
                        PrintOrderNumber(holdOrderNumber)

                    End If
                    total += Double.Parse(currentRow(3)) * Double.Parse(currentRow(4))
                    PrintOrderLine(currentRow, total)
                    subTotal += total
                    total = 0

                End While
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        finalTotal += subTotal
        PrintTotal(subTotal)

        PrintSection(finalTotal)
        Console.ReadLine()
    End Sub

    Private Sub PrintSection(finalTotal As Double)
        Console.WriteLine("Total Sales: " + finalTotal.ToString("c2"))
    End Sub

    Private Sub PrintTotal(subTotal As Double)
        Console.WriteLine("Total: " + subTotal.ToString())
        Console.WriteLine()
    End Sub

    Private Sub PrintOrderLine(currentRow() As String, total As Double)

        If currentRow(2).Contains("A") Then
            Console.WriteLine(currentRow(1).PadRight(30) + vbTab + vbTab + "(" + currentRow(3) + " x " + currentRow(4) + ")" + vbTab + total.ToString("c2"))
        Else

            Console.WriteLine(currentRow(2) + " " + currentRow(1).PadRight(30) + vbTab + "(" + currentRow(3) + " x " + currentRow(4) + ") " + vbTab + total.ToString("c2"))

        End If
    End Sub

    Private Sub PrintOrderNumber(holdOrderNumber As String)
        Console.WriteLine("Order Number: " + holdOrderNumber)
    End Sub

    Private Sub PrintHead()
        Console.WriteLine("Domino's Sales")
        Console.WriteLine("==============")
    End Sub
End Module