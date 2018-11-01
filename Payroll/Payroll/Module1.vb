' This program calculates an employee's take-home pay. 
Option Explicit On
Option Strict On
Module Payroll
    Sub Main()
        ' Declare and initialize variables
        Dim Salary As Double = 1250.0
        Dim StateTax As Double
        Dim FederalTax As Double
        Dim NumDependents As Integer = 2
        Dim DependentDeduction As Double
        Dim TotalWithholding As Double
        Dim TakeHomePay As Double

        'Calculate and display results
        StateTax = Salary * 0.065
        System.Console.WriteLine("State Tax: $" & StateTax)
        FederalTax = salary * 0.28
        System.Console.WriteLine("Federal Tax: $" & FederalTax)
        DependentDeduction = Salary * 0.025 * NumDependents
        System.Console.WriteLine("Dependents: $" & DependentDeduction)
        TotalWithholding = StateTax + FederalTax
        TakeHomePay = Salary - TotalWithholding + DependentDeduction
        System.Console.WriteLine("Salary: $" & Salary)
        System.Console.WriteLine("Take-Home Pay: $" & TakeHomePay)
    End Sub
End Module

