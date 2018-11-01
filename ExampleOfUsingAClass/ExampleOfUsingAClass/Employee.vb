Public Class Employee
    Private lastName As String
    Private hourlyWage As Double
    Private weeklyPay As Double

    Public Sub setLastName(ByVal name As String)
        lastName = name
    End Sub

    Public Sub setHourlyWage(ByVal wage As Double)
        hourlyWage = wage
        calculateWeeklyPay()
    End Sub

    Public Function getLastName() As String
        Return lastName
    End Function

    Public Function getHourlyWage() As String
        Return hourlyWage
    End Function

    Public Function getWeeklyPay() As Double
        Return weeklyPay
    End Function

    Private Sub calculateWeeklyPay()
        Const WORK_WEEK_HOURS As Integer = 40
        weeklyPay = hourlyWage * WORK_WEEK_HOURS
    End Sub
End Class
