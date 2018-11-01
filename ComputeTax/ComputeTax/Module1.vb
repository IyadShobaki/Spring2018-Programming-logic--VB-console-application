Module Module1

    Sub Main()
        Dim balance, rate, tax As Integer
        Dim balanceString, rateString As String
        Dim ComputeTax() As String = {balance, rate}
        balanceString = InputBox$("Enetr balance:")
        balance = Convert.ToInt32(balanceString)
        rateString = InputBox$("Enetr rate:")
        rate = Convert.ToInt32(rateString)
        Console.WriteLine("Tax:" & tax)
    End Sub
    Dim amount As Integer
    Dim rate As Integer
    Dim tax As Integer
    Dim ComputeTax() As String = {amount, rate}
    tax = amount * rate

End Module
