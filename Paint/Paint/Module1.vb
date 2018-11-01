' This program calculates the number of gallons 
' of paint needed.
Option Explicit On
Option Strict On
Module Paint
    Sub Main()
        ' Declare and initialize variables
        Dim Height1 As Double = 9
        Dim Width1 As Double = 19.5
        Dim Width2 As Double = 20.0
        Dim SquareFeet As Double
        Dim NumGallons As Double

        SquareFeet = (Width1 * Height1 + Width2 * Height1) * 2
        NumGallons = SquareFeet / 150

        System.Console.WriteLine("Number of Gallons: " & _
                                  NumGallons)
    End Sub
End Module
