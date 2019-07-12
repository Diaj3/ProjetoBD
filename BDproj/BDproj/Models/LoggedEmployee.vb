Public Class LoggedEmployee
    Public Shared Address As String
    Public Shared NIF As String
    Public Shared Fname As String
    Public Shared Lname As String
    Public Shared BirthDate As Date
    Public Shared PhoneNum As Integer
    Public Shared Staff_id As String
    Public Shared type As Integer
    Public Shared WorkingShift As String

    Public Shared Rooms As List(Of Integer) = New List(Of Integer)
    Public Shared BookingNums As List(Of Integer) = New List(Of Integer)
    Public Shared Meals As List(Of Meal) = New List(Of Meal)
    Public Shared Drinks As List(Of Drink) = New List(Of Drink)
End Class
