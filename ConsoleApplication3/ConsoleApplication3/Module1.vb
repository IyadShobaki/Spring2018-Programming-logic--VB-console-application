Module PayrollReport

    Sub Main()
        Dim Name As String
        Dim GrossString As String
        Dim Gross, Deduct, Net As Double
        Const RATE As Double = 0.25
        Const QUIT As String = "XXX"
        Const REPORT_HEADING As String = "Payroll Report"
        Const END_LINE As String = "**End of report"
        Console.WriteLine(REPORT_HEADING)
        Name = InputBox$("Enter Employee's Name:")
        While (Name <> QUIT)
            GrossString = InputBox$("Enetr Employee's Gross Pay:")
            Gross = Convert.ToDouble(GrossString)
            Deduct = Gross * RATE
            Net = Gross - Deduct
            Console.WriteLine("Name" & Name)
            Console.WriteLine("Gross Pa:" & Gross)
            Console.WriteLine("Deduction:" & Deduct)
            Console.WriteLine("Net Pay:" & Net)
            Name = InputBox$("Enter Employee's Name:")
        End While
        Console.WriteLine(END_LINE)
    End Sub

End Module
