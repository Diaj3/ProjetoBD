Imports System.Data.SqlClient


Public Class Customerf

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPage.Show()
        Me.Close()
    End Sub

    Private Sub LogginBut_Click(sender As Object, e As EventArgs) Handles LogginBut.Click
        Dim connection As New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")

        Dim command As New SqlCommand("select * from MANAGEMENT.CUSTOMER where NIF = @username and Pass = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = LoginID.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = Pass.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("Username Or Password Are Invalid")

        Else
            LoggedCustomer.NIF = table.Rows(0).Item("NIF")
            LoggedCustomer.fname = table.Rows(0).Item("Fname")
            LoggedCustomer.lname = table.Rows(0).Item("Lname")
            LoggedCustomer.phoneNum = table.Rows(0).Item("PhoneNum")
            LoggedCustomer.address = table.Rows(0).Item("Address")
            LoggedCustomer.pass = table.Rows(0).Item("Pass")

            command = New SqlCommand("SELECT MANAGEMENT.get_booking_info(@username)")
            command.Parameters.Add("@username", SqlDbType.VarChar).Value = LoggedCustomer.NIF


            Me.Close()

            CustLogged.Show()

        End If

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        CustRegister.Show()
    End Sub
End Class