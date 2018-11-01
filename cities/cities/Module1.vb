Option Explicit On
Option Strict On
Module Module1

    Sub Main()
        Dim CityPopulations() As Integer = {9500000, 871100, 23900}
        Dim Cities() As String = {"Akron", "Canton", "Cleveland"}
        Dim LoopIndex As Integer
        For LoopIndex = 0 To 2

            Console.WriteLine(CityPopulations(LoopIndex))
            Console.WriteLine(Cities(LoopIndex))
        Next

        For LoopIndex = 0 To 2
            CityPopulations(LoopIndex) = 12345
            Cities(LoopIndex) = "Any City"
            Console.WriteLine(CityPopulations(LoopIndex))
            Console.WriteLine(Cities(LoopIndex))
        Next

    End Sub
End Module