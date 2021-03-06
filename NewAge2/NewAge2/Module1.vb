﻿' This program calculates your age in the year 2050.
' Input:  None
' Output: Your current age followed by your age in 2050
Option Explicit On
Option Strict On
Module NewAge2
    Sub Main()
        ' Declare and initialize variables
        Dim CurrentAge As Integer = 29
        Dim NewAge As Integer
        Dim CurrentYear As Integer = 2014
        ' Declare and intialize the constant named YEAR
        Const YEAR As Integer = 2050

        ' Calculate New Age
        NewAge = CurrentAge + (YEAR - CurrentYear)

        ' Display results
        System.Console.WriteLine("My Current Age is " & CurrentAge)
        System.Console.WriteLine("I'll be " & NewAge & " in " & YEAR & ".")
    End Sub
End Module
