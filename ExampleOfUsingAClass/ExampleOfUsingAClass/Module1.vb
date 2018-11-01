Module Module1

    Sub Main()
        Const LOW As Double = 9.0
        Const HIGH As Double = 14.65

        'Instantiate the object
        Dim myGardener As New Employee

        'Update the instance variables of object myGardener
        myGardener.setLastName("Greene")
        'Recall that setting the hourly wage will also update the weeklyPay instance variable
        myGardener.setHourlyWage(LOW)

        'Display the object's weekly pay
        Console.WriteLine("My gardener makes " & myGardener.getWeeklyPay() & " per week.")

        'Update object's hourly wage and then display the resulting weekly pay
        myGardener.setHourlyWage(HIGH)
        Console.WriteLine("My gardener makes " & myGardener.getWeeklyPay() & " per week.")

    End Sub

End Module