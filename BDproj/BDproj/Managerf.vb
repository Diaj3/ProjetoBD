Imports System.Data.SqlClient


Public Class Managerf
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPage.Show()
        Me.Close()
    End Sub

    Private Sub LogginBut_Click(sender As Object, e As EventArgs) Handles LogginBut.Click
        Dim connection As New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")

        Dim command As New SqlCommand("MANAGEMENT.LOGIN_MANAGER", connection) With {
            .CommandType = CommandType.StoredProcedure
        }
        command.Parameters.Add("@hotel_id", SqlDbType.VarChar).Value = LoginID.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Pass.Text
        command.Parameters.Add("@successLogin", SqlDbType.Int).Direction = ParameterDirection.Output

        connection.Open()

        command.ExecuteNonQuery()

        Dim loginSuccess = CInt(command.Parameters("@successLogin").Value)

        If loginSuccess = 0 Then
            MessageBox.Show("Utilizador/Password inválido")
        Else

            LoggedManager.hotel_id = LoginID.Text
            ManagerWindow.Show()
            Me.Close()
        End If
    End Sub
End Class