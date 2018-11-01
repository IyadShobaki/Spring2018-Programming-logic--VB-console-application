' This program calculates your age in the year 2050.
' Input:  None
' Output: Your current age followed by your age in 2050
Option Explicit On
Option Strict On
Module NewAge
    Sub Main()
        'Declare and initialize variables
        Dim CurrentAge As Integer = 29
        Dim NewAge As Integer
        Dim CurrentYear As Integer = 2014

        'Calculate NewAge
        NewAge = CurrentAge + (2050 - CurrentYear)

        'Display results
        System.Console.WriteLine("My Current Age is " & CurrentAge)
        System.Console.WriteLine("I will be " & NewAge & " in 2050.")
    End Sub
End Module

