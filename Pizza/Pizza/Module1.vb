Option Explicit On
Option Strict On
Module Module1

    Sub Main()
      

        Dim Pizza1 As New cPizza


        Pizza1.setTopping(NAME)
        Pizza1.setDiameter(SIZE)
        Pizza1.setPrice(COST)

        Pizza1.setTopping(NAME)
        Console.WriteLine("Pizza topping " & Pizza1.getTopping())
        Pizza1.setDiameter(SIZE)
        Console.WriteLine("Pizza size " & Pizza1.getDiameter())
        Pizza1.setPrice(COST)
        Console.WriteLine("The price " & Pizza1.getPrice())

    End Sub

End Module
