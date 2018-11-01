' MichiganCities.vb - This program prints a message for invalid cities in Michigan.  
' Input:  Interactive
' Output:  Error message or nothing
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



        ' Get user input
        City = InputBox$("Enter city name: ")

        ' Write your loop here	
        For X = 0 To CityNames.Length - 1
            ' Write your test statement here to see if there is 
            ' a match.  Set the flag to true if city is found. 
            If City = CityNames(X) Then
                FoundIt = True
                Console.WriteLine("Searched " & CityNames.Length & " Cities")
                Console.WriteLine("City " & City & " found")
            End If
        Next X
        ' Test to see if city was not found to determine if 
        ' "Not a city in Michigan" message should be printed
        If FoundIt = False Then
            Console.WriteLine("Searched " & CityNames.Length & " Cities")
            Console.WriteLine(City & " is not city in Michigan")
        End If






    End Sub  ' End of Main() procedure
End Module  ' End of MichiganCities module