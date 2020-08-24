Option Explicit On
Option Strict On

Module ConsoleFun

    Sub Main()
        Dim userInput As String
        'Console.WriteLine("Please Type Some Text Then Press Enter...")
        'userInput = Console.ReadLine()
        'Console.WriteLine("Thanks!! You entered: " & userInput & ", Good Work!!")
        'Console.ReadLine() 

        Dim firstNumber As Integer
        Dim Result As Integer

        Console.WriteLine("Please Enter A Number")
        userInput = Console.ReadLine()
        firstNumber = CInt(userInput)
        Result = 5 + firstNumber
        Console.WriteLine(Result)
        Console.ReadLine()


    End Sub

End Module
