Module Module1

    Sub Main()
        Console.Title = "June Test"


        'Question 1.2 
        'Dim number As Double = 39.9
        'Dim word As String = "test"
        'If number <= 39 And word = "test" Then
        '    Console.Write("Option 1")
        'ElseIf number <= 39 Or word = "test"
        '    Console.Write("Option 2")
        'ElseIf number <= 40 Or word = "test"
        '    Console.Write("Option 3")
        'ElseIf number <= 40 And word = "test"
        '    Console.Write("Option 4")

        'End If

        'Question 3

        'Dim mark As Integer
        'mark = GetTestMark()


        Console.ReadLine()
    End Sub

    Private Function GetTestMark()
        Dim validInput As Boolean
        Dim mark As Integer

        Do
            validInput = True

            Try
                Console.Write("Please enter a mark: ")
                mark = Console.ReadLine()
                If mark < 0 Or mark > 100 Then
                    Console.Write("Please re-enter a proper mark that is higher than 0 and less 101")
                    validInput = False
                Else
                    Console.Write("Your mark is: " + mark.ToString())
                End If


            Catch ex As Exception
                Console.Write("it seems you entered a none interger mark please re-enter the mark")
                validInput = False
            End Try
        Loop While validInput = False
        Return mark
    End Function
End Module
