Option Explicit On
Option Strict On
Module MichiganCities
    Sub Main()
        ' Declare variables.
        Dim City As String                  ' city to look up in array
        ' Initialized array of Michigan cities
        Dim CityNames() As String = {"Acme", "Albion", "Detroit", "Watervliet", "Coloma", "Saginaw", "Richland", "Glenn", "Midland", "Brooklyn"}
        Dim FoundIt As Boolean = False      ' Flag variable
        Dim X As Integer            ' Loop control variable
        Const FINISH As String = "XXX"


        City = InputBox$("Enter city name: ")
        Do While City <> FINISH
            FoundIt = False
            X = 0
            Do While X <= CityNames.Length - 1
                If City = CityNames(X) Then
                    FoundIt = True
                End If
                X = X + 1
            Loop
            If FoundIt = True Then
                Console.WriteLine("Searched " & CityNames.Length & " Cities")
                Console.WriteLine("City " & City & " found")
            Else
                Console.WriteLine("Searched " & CityNames.Length & " Cities")
                Console.WriteLine(City & " is not city in Michigan")

            End If
            City = InputBox$("Enter next city or " &
                    FINISH & " to quit ")

        Loop


    End Sub
End Module
