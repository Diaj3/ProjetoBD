Public Class Receptionist : Inherits Employee
    Public receptionistId As String
    Public bookingNums As List(Of String)

    Public Sub New()
        bookingNums = New List(Of String)
    End Sub
End Class
