Option Explicit On
Option Strict On
Module PayrollReport
    Sub Main()
        Dim Name As String
        Dim EmployeeNumberString As String
        Dim EmployeeNumber As Integer
        Dim GrossString As String
        Dim BonusString As String
        Dim Gross, Bonus, Deduct, Net As Double
        Const RATE As Double = 0.25
        Const QUIT As String = "XXX"
        Const REPORT_HEADING As String = "Payroll Report"
        Const END_LINE As String = "**End of report"
        Console.WriteLine(REPORT_HEADING)
        Name = InputBox$("Enter Employee's Name:")
        While (Name <> QUIT)
            EmployeeNumberString = InputBox$("Enetr Employee's Number:")
            EmployeeNumber = Convert.ToInt32(EmployeeNumberString)
            GrossString = InputBox$("Enetr Employee's Gross Pay:")
            Gross = Convert.ToDouble(GrossString)
            BonusString = InputBox$("Enter Employee's Bonus Pay:")
            Bonus = Convert.ToDouble(BonusString)
            Deduct = Gross * RATE
            Net = (Gross - Deduct) + Bonus
            Console.WriteLine("Employee's Number:" & EmployeeNumber)
            Console.WriteLine("Name:" & Name)
            Console.WriteLine("Gross Pay:" & Gross)
            Console.WriteLine("Deduction:" & Deduct)
            Console.WriteLine("Bonus:" & Bonus)
            Console.WriteLine("Net Pay:" & Net)
            Name = InputBox$("Enter Employee's Name:")
        End While
        Console.WriteLine(END_LINE)
    End Sub

End Module
