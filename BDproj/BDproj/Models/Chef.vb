Public Class Chef : Inherits Employee
    Public ChefId As String
    Public meals As List(Of Meal)

    Public Sub New()
        meals = New List(Of Meal)
    End Sub
End Class
