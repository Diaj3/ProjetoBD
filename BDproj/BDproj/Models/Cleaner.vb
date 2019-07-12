Public Class Cleaner : Inherits Employee

    Public cleaner_id As String
    Public rooms As List(Of Room)


    Public Sub New()
        rooms = New List(Of Room)
    End Sub
End Class
