Imports System.Data.SqlClient

Public Class CustRegister

    ' SQL Variabless
    Private connection As SqlConnection = New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")
    Private command As SqlCommand
    Private command2 As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        command = New SqlCommand("MANAGEMENT.INSERT_CUSTOMER", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }
        command2 = New SqlCommand("MANAGEMENT.INSERT_ACCOUNT_RECORD", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }

        'Generate the account_record_id
        Dim rn As New Random
        Dim acc = rn.Next(100, 9999)

        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FnameTextBox.Text
        command.Parameters.Add("@lname", SqlDbType.VarChar).Value = LnameTextBox.Text
        command.Parameters.Add("@phonenum", SqlDbType.VarChar).Value = phoneNumTextBox.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = PassTextBox.Text
        command.Parameters.Add("@nif", sqlDbType:=SqlDbType.VarChar).Value = nifTextBox.Text
        command2.Parameters.Add("@nif", SqlDbType.VarChar).Value = nifTextBox.Text
        command2.Parameters.Add("@Account_record_id", SqlDbType.VarChar).Value = acc

        connection.Open()

        If command.ExecuteNonQuery() = 1 And command2.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Registration was successful")
        Else
            MessageBox.Show("Registration was not successful")
            connection.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Customerf.Show()
    End Sub
End Class