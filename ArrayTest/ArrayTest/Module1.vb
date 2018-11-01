Module Module1

    Sub Main()
        Dim Target(2) As Double
        Dim Source() As Double = {1.0, 5.5, 7.9}
        Dim LoopIndex As Integer
        ' Copy values from Source to Target
        For LoopIndex = 0 To 2
            Target(LoopIndex) = Source(LoopIndex)
        Next LoopIndex
        ' Assign values to two elements of Target
        Target(0) = 2.0
        Target(1) = 4.5
        ' Print values stored in Source and Target 
        For LoopIndex = 0 To 2
            System.Console.WriteLine("Source " & _
                                     Source(LoopIndex))
            System.Console.WriteLine("Target " & _
                                     Target(LoopIndex))
        Next LoopIndex
    End Sub

End Module
