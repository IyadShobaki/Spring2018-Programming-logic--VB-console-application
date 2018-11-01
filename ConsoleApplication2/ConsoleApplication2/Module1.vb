Option Explicit On
Option Strict On
Module Module1

    Sub Main()
        Dim ScoreString As String
        Dim Score As Integer
        ScoreString = InputBox$("Enter a test score:")
        Score = Convert.ToInt32(ScoreString)
        If Score >= 90 Then
            Console.WriteLine("Great Job!")
        Else
            Console.WriteLine("Keep Trying")
        End If
        Console.WriteLine("Thank you for using this program")
    End Sub

End Module
