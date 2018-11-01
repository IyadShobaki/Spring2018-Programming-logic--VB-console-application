Public Class cPizza
    
    Private Topping As String = "Pepperoni"
    Private Diameter As Double = 12
    Private Price As Double = 13.9

    Public Sub setTopping(ByVal name As String)
        Topping = name
    End Sub

    Public Sub setDiameter(ByVal size As Double)
        Diameter = size
    End Sub
    Public Sub setPrice(ByVal cost As Double)
        Price = cost
    End Sub

    Public Function getTopping() As String
        Return Topping
    End Function

    Public Function getDiameter() As String
        Return Diameter
    End Function

    Public Function getPrice() As Double
        Return Price
    End Function

    

End Class