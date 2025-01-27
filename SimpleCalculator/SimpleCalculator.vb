'Angel Nava
'Spring 2025
'RCET2265
'SimpleCalculator
'https://github.com/TheGoldenPorkchop/SimpleCalculator

Module SimpleCalculator

    Sub Main()
        Dim numberOne As Integer
        Dim userInputOperation As String
        Dim numberTwo As Integer
        Dim solution As Integer

        'number seletion one
        Console.WriteLine("Choose your first [Whole] number")
        numberOne = Console.ReadLine()
        numberOne = CInt(numberOne)
        Console.WriteLine()

        'menu calc
        Console.WriteLine("Please make a selection: " & vbNewLine _
                          & "[1. Add]" & vbNewLine _
                          & "[2. Subtract]" & vbNewLine _
                          & "[3. Multiply]")
        userInputOperation = Console.ReadLine()

        'selects operation
        If userInputOperation = "1" Then
            Console.WriteLine("Adding")
            userInputOperation = "+"
        ElseIf userInputOperation = "2" Then
            Console.WriteLine("Subtracting")
            userInputOperation = "-"
        ElseIf userInputOperation = "3" Then
            Console.WriteLine("Multiplying")
            userInputOperation = "*"
        Else
            Console.WriteLine("Invalid Option")
        End If
        Console.WriteLine()

        'number seletion two
        Console.WriteLine("Choose your second [Whole] number")
        numberTwo = Console.ReadLine()
        numberTwo = CInt(numberTwo)
        Console.WriteLine()

        'prints answer
        Console.WriteLine(numberOne & userInputOperation & numberTwo & "=")
        If userInputOperation = "+" Then
            Console.WriteLine(numberOne + numberTwo)
        ElseIf userInputOperation = "-" Then
            Console.WriteLine(numberOne - numberTwo)
        ElseIf userInputOperation = "*" Then
            Console.WriteLine(numberOne * numberTwo)
        Else
            Console.WriteLine("Whoops. Something went wrong. Restart the program again...")
        End If

    End Sub

End Module
