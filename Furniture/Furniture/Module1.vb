' This program calculates profits and sales prices for a furniture company. 
Option Explicit On
Option Strict On
Module Module1
    Sub Main()
        'Declare variables
        Dim itemName As String = "TV Stand"
        Dim RetailPrice As Double = 325.0
        Dim WholesalePrice As Double = 200.0
        Dim SalePrice As Double
        Dim Profit As Double
        Dim SaleProfit As Double

        'Perform calculations
        Profit = RetailPrice - WholesalePrice
        SalePrice = RetailPrice * 0.75
        SaleProfit = SalePrice - WholesalePrice

        'Display results
        System.Console.WriteLine("Item Name: " & itemName)
        System.Console.WriteLine("Retail Price: $" & RetailPrice)
        System.Console.WriteLine("Wholesale Price: $" & WholesalePrice)
        System.Console.WriteLine("Profit: $" & Profit)
        System.Console.WriteLine("Sale Price: $" & SalePrice)
        System.Console.WriteLine("Sale Profit: $" & SaleProfit)
    End Sub
End Module