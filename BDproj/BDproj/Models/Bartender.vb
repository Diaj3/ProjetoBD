Public Class Bartender : Inherits Employee
    Public bartenderId As String
    Public drinks As List(Of Drink)

    Public Sub New()
        drinks = New List(Of Drink)
    End Sub
End Class
