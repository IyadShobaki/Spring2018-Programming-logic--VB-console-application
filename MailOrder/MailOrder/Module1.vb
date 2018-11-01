Option Explicit On
Option Strict On
Module Module1
    Sub Main()
        Dim Item As Integer
        Dim BadItemCount As Integer = 0
        Dim ItemString As String
        Const SIZE As Integer = 6
        Dim VALID_ITEMS() As Integer = {106, 108, 307, 405, 457, 688}
        Dim Subscript As Integer
        Dim FoundIt As Boolean = False
        Const MSG_YES As String = "Item Available"
        Const MSG_NO As String = "Item not found"
        Const FINISH As Integer = 999

        ' This is the work done in the getReady() procedure
        ItemString = InputBox$("Enter item number: ")
        Item = Convert.ToInt32(ItemString)

        Do While Item <> FINISH
            ' This is the work done in the findItem() procedure
            FoundIt = False
            Subscript = 0
            Do While Subscript < SIZE
                If Item = VALID_ITEMS(Subscript) Then
                    FoundIt = True
                End If
                Subscript = Subscript + 1
            Loop
            If FoundIt = True Then
                System.Console.WriteLine(MSG_YES)
            Else
                System.Console.WriteLine(MSG_NO)
                BadItemCount = BadItemCount + 1
            End If
            ItemString = InputBox$("Enter next item number or " & _
                    FINISH & " to quit ")
            Item = Convert.ToInt32(ItemString)
        Loop
        ' This is the work done in the finishUp() procedure
        System.Console.WriteLine(BadItemCount & " items had invalid numbers")
    End Sub
End Module
