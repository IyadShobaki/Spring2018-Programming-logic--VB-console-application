Option Explicit On
Option Strict On
Module test
    Sub Main()
        Dim CityPopulation() As Integer = {9500000, 87110, 23900}
        Dim Cities() As String = {"Chicago", "Detroit", "Batavia"}
        Dim loopIndex As Integer
        For loopIndex = 0 To 2
            CityPopulation(loopIndex) = 12345
            Cities(loopIndex) = "Any City"
        Next
    End Sub
End Module