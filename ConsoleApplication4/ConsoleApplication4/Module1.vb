Option Explicit On
Option Strict On
Module Module1

    Sub Main()
        Dim XString As String
        Dim YString As String
        Dim X, Y As Integer
        Dim Sum As Integer
        XString = InputBox$("Enter X  Value:")
        X = Convert.ToInt32(XString)
        YString = InputBox$("Enter Y Value:")
        Y = Convert.ToInt32(YString)
        Sum = X + Y
        Console.WriteLine("X value:" & X)
        Console.WriteLine("Y value:" & Y)
        Console.WriteLine("Sum:" & Sum)

    End Sub

End Module
