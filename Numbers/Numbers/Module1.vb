
Option Explicit On
Option Strict On
Module Numbers

    Sub Main()
        Dim FirstNumberString As String
        Dim SecondNumberString As String
        Dim FirstNumber As Integer
        Dim SecondNumber As Integer
        Dim Average As Integer
        FirstNumberString = InputBox$("Enter First Number:")
        FirstNumber = Convert.ToInt32(FirstNumberString)
        SecondNumberString = InputBox$("Enter Second Number:")
        SecondNumber = Convert.ToInt32(SecondNumberString)

        If FirstNumber > SecondNumber Then
            Console.WriteLine("First is Larger")
        Else
            If FirstNumber < SecondNumber Then
                Console.WriteLine("Second is Larger")
            Else
                If FirstNumber = SecondNumber Then
                    Console.WriteLine("Numbers are Equal")
                Else
                End If
            End If
        End If
        Average = FirstNumber - SecondNumber
        Console.WriteLine("Average:" & Average)
        Console.WriteLine("End Of Program")

    End Sub

End Module
