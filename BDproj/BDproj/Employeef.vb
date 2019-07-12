Imports System.Data.SqlClient

Public Class Employf
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainPage.Show()
        Me.Close()
    End Sub

    Private Sub LogginBut_Click(sender As Object, e As EventArgs) Handles LogginBut.Click
        Dim connection As New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")

        Dim command As New SqlCommand("select * from MANAGEMENT.EMPLOYEE where Staff_id = @username", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = LoginID.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username Or Password Are Invalid")
        Else
            ' Reset lists
            LoggedEmployee.Rooms = New List(Of Integer)
            LoggedEmployee.BookingNums = New List(Of Integer)
            LoggedEmployee.Drinks = New List(Of Drink)
            LoggedEmployee.Meals = New List(Of Meal)
            ' Update attributes
            LoggedEmployee.Staff_id = table.Rows(0).Item("Staff_id")
            LoggedEmployee.Address = table.Rows(0).Item("Address").ToString()
            LoggedEmployee.NIF = table.Rows(0).Item("NIF")
            LoggedEmployee.FName = table.Rows(0).Item("FName")
            LoggedEmployee.LName = table.Rows(0).Item("LName")
            LoggedEmployee.BirthDate = table.Rows(0).Item("BirthDate")
            LoggedEmployee.PhoneNum = table.Rows(0).Item("PhoneNum").ToString()

            ' Get the type of the employee
            command = New SqlCommand("SELECT MANAGEMENT.get_type_of_employee(@staff_id)", connection)
            command.Parameters.Add("@staff_id", SqlDbType.VarChar).Value = LoggedEmployee.Staff_id

            adapter = New SqlDataAdapter(command)
            table = New DataTable()
            adapter.Fill(table)

            If table.Rows.Count() > 0 Then
                Dim type As Integer = table.Rows(0).Item(0)
                If type = 0 Then
                    MessageBox.Show("Este utilizador não tem um tipo associado")
                End If
                LoggedEmployee.type = type

                ' Cleaner
                If type = 1 Then
                    command = New SqlCommand("SELECT * FROM MANAGEMENT.get_cleaner_information(@staff_id)", connection)
                    command.Parameters.Add("@staff_id", SqlDbType.VarChar).Value = LoggedEmployee.Staff_id

                    adapter = New SqlDataAdapter(command)
                    table = New DataTable()
                    adapter.Fill(table)

                    LoggedEmployee.WorkingShift = table.Rows(0).Item("Work_shift")

                    For Each row As DataRow In table.Rows
                        LoggedEmployee.Rooms.Add(row(1))
                    Next
                End If
                ' Receptionist
                If type = 2 Then
                    command = New SqlCommand("SELECT * FROM MANAGEMENT.get_receptionist_information(@staff_id)", connection)
                    command.Parameters.Add("@staff_id", SqlDbType.VarChar).Value = LoggedEmployee.Staff_id

                    adapter = New SqlDataAdapter(command)
                    table = New DataTable()
                    adapter.Fill(table)

                    LoggedEmployee.WorkingShift = table.Rows(0).Item("Work_shift")

                    For Each row As DataRow In table.Rows
                        LoggedEmployee.BookingNums.Add(row(0))
                    Next
                End If
                ' Bartender
                If type = 3 Then
                    command = New SqlCommand("SELECT * FROM MANAGEMENT.get_bartender_information(@staff_id)", connection)
                    command.Parameters.Add("@staff_id", SqlDbType.VarChar).Value = LoggedEmployee.Staff_id

                    adapter = New SqlDataAdapter(command)
                    table = New DataTable()
                    adapter.Fill(table)

                    LoggedEmployee.WorkingShift = table.Rows(0).Item("Work_shift")

                    For Each row As DataRow In table.Rows
                        Dim drink = New Drink With {
                            .Drink_name = row("Drink_name"),
                            .Drink_price = row("Drink_price")
                        }
                        LoggedEmployee.Drinks.Add(drink)
                    Next
                End If
                ' Chef
                If type = 4 Then
                    command = New SqlCommand("SELECT * FROM MANAGEMENT.get_chef_information(@staff_id)", connection)
                    command.Parameters.Add("@staff_id", SqlDbType.VarChar).Value = LoggedEmployee.Staff_id

                    adapter = New SqlDataAdapter(command)
                    table = New DataTable()
                    adapter.Fill(table)

                    LoggedEmployee.WorkingShift = table.Rows(0).Item("Work_shift")

                    For Each row As DataRow In table.Rows
                        Dim meal = New Meal With {
                            .Meal_name = row("Meal_name"),
                            .Meal_price = row("Meal_price")
                        }
                        LoggedEmployee.Meals.Add(meal)
                    Next
                End If
                Me.Close()
                CleanerWindow.Show()
            End If
            End If
    End Sub

End Class