Option Explicit On
Option Strict On
Module Module1
    Sub Main()
        ' Declare a named constant for array size here
        Const MAX_AVERAGES As Integer = 8

        ' Declare array here
        Dim Averages(MAX_AVERAGES - 1) As Double

        ' Use this integer variable as your loop index
        Dim LoopIndex As Integer

        ' Use this variable to store the number input by user
        Dim BattingAverage As Double

        ' Declare string version of batting average here
        Dim BattingString As String
        ' Use these variables to store the minimim and maximum values
        Dim Min As Double
        Dim Max As Double

        ' Use these variables to store the total and the average
        Dim Total As Double
        Dim Average As Double

        ' Write a loop to get batting averages from user and assign to array
        For LoopIndex = 0 To MAX_AVERAGES - 1
            BattingString = InputBox$("Enter a batting average: ")
            BattingAverage = Convert.ToDouble(BattingString)
            ' Assign value to array
            Averages(LoopIndex) = BattingAverage
        Next LoopIndex
        ' Assign the first element in the array to be the minimum and the maximum
        Min = Averages(0)
        Max = Averages(0)
        ' Start out your total with the value of the first element in the array
        Total = Averages(0)
        ' Write a loop here to access array values starting with Averages(1)
        For LoopIndex = 1 To MAX_AVERAGES - 1
            ' Within the loop test for minimum and maximum batting averages
            If Averages(LoopIndex) < Min Then
                Min = Averages(LoopIndex)
            End If
            If Averages(LoopIndex) > Max Then
                Max = Averages(LoopIndex)
            End If
            ' Also accumulate a total of all batting averages
            Total += Averages(LoopIndex)
        Next LoopIndex
        ' Calculate the average of the 8 batting averages
        Average = Total / MAX_AVERAGES

        ' Print the batting averages stored in the Averages array 
        For LoopIndex = 0 To MAX_AVERAGES - 1
            System.Console.WriteLine("Averages(" & LoopIndex & ") is: " & Averages(LoopIndex))
        Next LoopIndex
        ' Print the maximum value, minimum value, and average 
        System.Console.WriteLine("Minimum batting average is " & Min)
        System.Console.WriteLine("Maximum batting average is " & Max)
        System.Console.WriteLine("Average batting average is " & Average)
    End Sub
End Module