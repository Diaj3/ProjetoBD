Imports System.Data.SqlClient

Public Class ManagerWindow
    'List of classes
    Private cleaners As List(Of Cleaner) = New List(Of Cleaner)
    Private chefs As List(Of Chef) = New List(Of Chef)
    Private receptionists As List(Of Receptionist) = New List(Of Receptionist)
    Private bartenders As List(Of Bartender) = New List(Of Bartender)
    Private customers As List(Of Customer) = New List(Of Customer)

    Private currentEmployee As Employee
    Private currentCustomer As Customer

    ' SQL Variables
    Private connection As SqlConnection = New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")
    Private command As SqlCommand

    Public Sub New()
        InitializeComponent()
        ' Get the list of employees
        GetCleaners()
        GetChefs()
        GetBartenders()
        GetReceptionists()
        GetCustomers()

        ' Popular a lista dos employees
        PopulateEmployeeListView()

    End Sub

    Public Sub GetCleaners()
        command = New SqlCommand("SELECT C.Cleaner_id, RS.RoomNum, H.Work_shift, E.* FROM MANAGEMENT.CLEANER C 
                                    INNER JOIN MANAGEMENT.ROOM_SERVICE RS ON C.Cleaner_id = RS.Cleaner_id 
                                    INNER JOIN MANAGEMENT.EMPLOYEE E ON C.Cleaner_id = E.Staff_id
                                    INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = E.Staff_id
                                    ", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        For Each row In table.Rows
            Dim room = New Room With {
                .RoomNum = row("RoomNum")
            }

            Dim cleanerId = row("Cleaner_id")
            If cleaners.Exists(Function(value As Cleaner) value.Cleaner_id = cleanerId) Then
                Dim existingCleaner = cleaners.Find(Function(value As Cleaner) value.Cleaner_id = cleanerId)
                existingCleaner.rooms.Add(room)
            Else
                Dim cleaner = New Cleaner With {
                .Fname = row("Fname"),
                .Lname = row("Lname"),
                .NIF = row("NIF"),
                .Staff_id = row("Staff_id"),
                .Address = row("Address").ToString(),
                .BirthDate = row("BirthDate"),
                .PhoneNum = row("PhoneNum").ToString(),
                .cleaner_id = row("Cleaner_id"),
                .Working_shift = row("Work_shift"),
                .type = "Cleaner"
            }
                cleaner.rooms.Add(room)

                cleaners.Add(cleaner)
            End If
        Next
    End Sub

    Public Sub GetChefs()
        command = New SqlCommand("SELECT M.Meal_name, M.Meal_price, C.*, E.*, H.Work_shift FROM MANAGEMENT.CHEF C 
                                INNER JOIN MANAGEMENT.EMPLOYEE E ON C.Chef_id = E.Staff_id
	                            INNER JOIN MANAGEMENT.MEAL M ON M.Chef_id = C.Chef_id
	                            INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = C.Chef_id", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        For Each row In table.Rows
            Dim chefId = row("Chef_id")
            Dim meal = New Meal With {
                .Meal_name = row("Meal_name"),
                .Meal_price = row("Meal_price")
            }
            If chefs.Exists(Function(value As Chef) value.ChefId = chefId) Then
                Dim existingChef = chefs.Find(Function(value As Chef) value.ChefId = chefId)
                existingChef.meals.Add(meal)
            Else
                Dim chef = New Chef With {
                .Fname = row("Fname"),
                .Lname = row("Lname"),
                .NIF = row("NIF"),
                .Staff_id = row("Staff_id"),
                .Address = row("Address").ToString(),
                .BirthDate = row("BirthDate"),
                .PhoneNum = row("PhoneNum").ToString(),
                .ChefId = row("Staff_id"),
                .Working_shift = row("Work_shift"),
                .type = "Chef"
            }
                chef.meals.Add(meal)

                chefs.Add(chef)
            End If
        Next
    End Sub

    Public Sub GetReceptionists()
        command = New SqlCommand("SELECT B.BookingNum, R.*, E.*, H.Work_shift FROM MANAGEMENT.RECEPTIONIST R
	INNER JOIN MANAGEMENT.EMPLOYEE E ON R.Receptionist_id = E.Staff_id
	INNER JOIN MANAGEMENT.BOOKING B ON B.Receptionist_id = R.Receptionist_id
	INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = R.Receptionist_id", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        For Each row In table.Rows

            Dim num = row("BookingNum")

            Dim receptionist_ID = row("Receptionist_id")
            If receptionists.Exists(Function(value As Receptionist) value.receptionistId = receptionist_ID) Then
                Dim existingReceptionist = receptionists.Find(Function(value As Receptionist) value.receptionistId = receptionist_ID)
                existingReceptionist.bookingNums.Add(num)
            Else
                Dim receptionist = New Receptionist With {
                .Fname = row("Fname"),
                .Lname = row("Lname"),
                .NIF = row("NIF"),
                .Staff_id = row("Staff_id"),
                .Address = row("Address").ToString(),
                .BirthDate = row("BirthDate"),
                .PhoneNum = row("PhoneNum").ToString(),
                .receptionistId = row("Receptionist_id"),
                .Working_shift = row("Work_shift"),
                .type = "Receptionist"
            }
                receptionist.bookingNums.Add(num)

                receptionists.Add(receptionist)
            End If
        Next
    End Sub

    Public Sub GetBartenders()
        command = New SqlCommand("SELECT D.Drink_name, D.Drink_price, B.*, E.*, H.Work_shift FROM MANAGEMENT.BARTENDER B 
                                INNER JOIN MANAGEMENT.EMPLOYEE E ON B.Bartender_id = E.Staff_id
	                            INNER JOIN MANAGEMENT.DRINK D ON D.Bartender_id = B.Bartender_id
	                            INNER JOIN MANAGEMENT.HAS H ON H.Staff_id = B.Bartender_id", connection)

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        For Each row In table.Rows
            Dim bartenderId = row("Bartender_id")
            Dim drink = New Drink With {
                .Drink_name = row("Drink_name"),
                .Drink_price = row("Drink_price")
            }
            If bartenders.Exists(Function(value As Bartender) value.bartenderId = bartenderId) Then
                Dim existingBartender = bartenders.Find(Function(value As Bartender) value.bartenderId = bartenderId)
                existingBartender.drinks.Add(Drink)
            Else
                Dim bartender = New Bartender With {
                .Fname = row("Fname"),
                .Lname = row("Lname"),
                .NIF = row("NIF"),
                .Staff_id = row("Staff_id"),
                .Address = row("Address").ToString(),
                .BirthDate = row("BirthDate"),
                .PhoneNum = row("PhoneNum").ToString(),
                .bartenderId = row("Bartender_id"),
                .Working_shift = row("Work_shift"),
                .type = "Bartender"
            }
                bartender.drinks.Add(drink)

                bartenders.Add(bartender)
            End If
        Next
    End Sub
    Public Sub GetCustomers()
        command = New SqlCommand("SELECT * FROM MANAGEMENT.CUSTOMER", connection)

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        For Each row In table.Rows
            Dim nif = row("NIF")

            If customers.Exists(Function(value As Customer) value.NIF = nif) Then
                Dim existingCustomer = customers.Find(Function(value As Customer) value.NIF = nif)
            Else
                Dim customer = New Customer With {
                .Fname = row("Fname"),
                .Lname = row("Lname"),
                .NIF = row("NIF"),
                .Address = row("Address").ToString(),
                .PhoneNum = row("PhoneNum").ToString(),
                .Pass = row("Pass")
            }
                customers.Add(customer)
            End If
        Next

    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    Public Sub PopulateEmployeeListView()
        For Each cleaner In cleaners
            Dim item = New ListViewItem(cleaner.Fname + " " + cleaner.Lname)
            item.SubItems.Add(cleaner.type)
            item.SubItems.Add(cleaner.Staff_id)
            EmployeeListView.Items.Add(item)
        Next
        For Each chef In chefs
            Dim item = New ListViewItem(chef.Fname + " " + chef.Lname)
            item.SubItems.Add(chef.type)
            item.SubItems.Add(chef.Staff_id)
            EmployeeListView.Items.Add(item)
        Next
        For Each bartender In bartenders
            Dim item = New ListViewItem(bartender.Fname + " " + bartender.Lname)
            item.SubItems.Add(bartender.type)
            item.SubItems.Add(bartender.Staff_id)
            EmployeeListView.Items.Add(item)
        Next
        For Each receptionist In receptionists
            Dim item = New ListViewItem(receptionist.Fname + " " + receptionist.Lname)
            item.SubItems.Add(receptionist.type)
            item.SubItems.Add(receptionist.Staff_id)
            EmployeeListView.Items.Add(item)
        Next
        For Each customer In customers
            Dim item = New ListViewItem(customer.Fname + " " + customer.Lname)
            CustomerList.Items.Add(item)
            item.SubItems.Add(customer.NIF)
        Next
    End Sub

    Private Sub EmployeeListView_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles EmployeeListView.Click
        If EmployeeListView.SelectedItems.Count() > 0 Then
            Dim employee
            Dim employeeType = EmployeeListView.SelectedItems(0).SubItems(1).Text ' Type

            If employeeType = "Cleaner" Then
                Dim cleanerId = EmployeeListView.SelectedItems(0).SubItems(2).Text ' Staff id
                employee = cleaners.Find(Function(cl As Cleaner) cl.cleaner_id = cleanerId)
                PopulateTextBoxes(employee)
                PopulateAuxiliarList()
            End If
            If employeeType = "Receptionist" Then
                Dim receptionistId = EmployeeListView.SelectedItems(0).SubItems(2).Text ' Staff id
                employee = receptionists.Find(Function(r As Receptionist) r.receptionistId = receptionistId)
                PopulateTextBoxes(employee)
                PopulateAuxiliarList()
            End If
            If employeeType = "Bartender" Then
                Dim bartenderId = EmployeeListView.SelectedItems(0).SubItems(2).Text ' Staff id
                employee = bartenders.Find(Function(cl As Bartender) cl.bartenderId = bartenderId)
                PopulateTextBoxes(employee)
                PopulateAuxiliarList()
            End If
            If employeeType = "Chef" Then
                Dim chefId = EmployeeListView.SelectedItems(0).SubItems(2).Text ' Staff id
                employee = chefs.Find(Function(cl As Chef) cl.ChefId = chefId)
                PopulateTextBoxes(employee)
                PopulateAuxiliarList()
            End If
        End If
    End Sub

    Private Sub CustomerList_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CustomerList.Click
        If CustomerList.SelectedItems.Count() > 0 Then
            Dim nif = CustomerList.SelectedItems(0).SubItems(1).Text
            'Console.WriteLine(nif)
            Dim customeer = customers.Find(Function(value As Customer) value.NIF = nif)
            PopulateCustomerTextBoxes(customeer)
        End If
    End Sub

    Private Sub PopulateAuxiliarList()
        RoomsListView.Clear()
        If currentEmployee.type = "Cleaner" Then
            RoomsListView.Columns.Add("Room")
            Dim cleaner = cleaners.Find(Function(c As Cleaner) c.cleaner_id = currentEmployee.Staff_id)
            DynamicLabel.Text = "Rooms"
            For Each room In cleaner.rooms
                Dim listView As ListViewItem = New ListViewItem With {
                    .Text = room.RoomNum
                }
                RoomsListView.Items.Add(listView)
            Next
        End If
        If currentEmployee.type = "Chef" Then
            RoomsListView.Columns.Add("Meal Name")
            RoomsListView.Columns.Add("Meal Price")
            Dim chef = chefs.Find(Function(c As Chef) c.ChefId = currentEmployee.Staff_id)
            DynamicLabel.Text = "Meals"
            For Each meal In chef.meals
                Dim item = New ListViewItem(meal.Meal_name)
                item.SubItems.Add(meal.Meal_price)
                RoomsListView.Items.Add(item)
            Next
        End If
        If currentEmployee.type = "Bartender" Then
            RoomsListView.Columns.Add("Drink Name")
            RoomsListView.Columns.Add("Drink Price")
            Dim bartender = bartenders.Find(Function(c As Bartender) c.bartenderId = currentEmployee.Staff_id)
            DynamicLabel.Text = "Drinks"
            For Each drink In bartender.drinks
                Dim item = New ListViewItem(drink.Drink_name)
                item.SubItems.Add(drink.Drink_price)
                RoomsListView.Items.Add(item)
            Next
        End If
        If currentEmployee.type = "Receptionist" Then
            RoomsListView.Columns.Add("BookingNum")
            Dim receptionist = receptionists.Find(Function(c As Receptionist) c.receptionistId = currentEmployee.Staff_id)
            DynamicLabel.Text = "Bookings"
            For Each bookingNum In receptionist.bookingNums
                Dim item = New ListViewItem(bookingNum)
                RoomsListView.Items.Add(item)
            Next
        End If

    End Sub

    Private Sub PopulateTextBoxes(employee As Employee)
        EmployeeFirstNameTxtBox.Text = employee.Fname
        EmployeeLastNameTxtBox.Text = employee.Lname
        EmployeeNIFTxtBox.Text = employee.NIF
        EmployeeAddressTxtBox.Text = employee.Address
        EmployeeBirthdateTxtBox.Text = employee.BirthDate
        EmployeePhoneNumTxtBox.Text = employee.PhoneNum
        ShiftComboBox.SelectedIndex = ShiftComboBox.FindString(employee.Working_shift)

        currentEmployee = employee
    End Sub

    Private Sub PopulateCustomerTextBoxes(customeer As Customer)
        ffnameTextBox.Text = customeer.Fname
        lnameTextBox.Text = customeer.Lname
        nifTextBox.Text = customeer.NIF
        addressTextBox.Text = customeer.Address
        phoneNumTextBox.Text = customeer.PhoneNum
        passTextBox.Text = customeer.Pass

        currentCustomer = customeer
    End Sub

    Private Sub DeleteEmployeeBtn_Click(sender As Object, e As EventArgs) Handles DeleteEmployeeBtn.Click
        If EmployeeListView.SelectedItems.Count > 0 Then
            If currentEmployee.type = "Cleaner" Then
                command = New SqlCommand("MANAGEMENT.DELETE_CLEANER", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }
                command.Parameters.Add("@cleanerId", SqlDbType.VarChar).Value = currentEmployee.Staff_id
                command.Parameters.Add("@outputResult", SqlDbType.Int).Direction = ParameterDirection.Output

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                Dim success = CInt(command.Parameters("@outputResult").Value)
                If success = 0 Then
                    Dim cleanerToDelete = cleaners.Find(Function(c As Cleaner) c.cleaner_id = currentEmployee.Staff_id)
                    cleaners.Remove(cleanerToDelete)
                    ResetControls()
                Else
                    MessageBox.Show("Erro a eliminar o utilizador!!!")
                End If

            End If

            If currentEmployee.type = "Chef" Then
                command = New SqlCommand("MANAGEMENT.DELETE_CHEF", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }
                command.Parameters.Add("@chefId", SqlDbType.VarChar).Value = currentEmployee.Staff_id
                command.Parameters.Add("@outputResult", SqlDbType.Int).Direction = ParameterDirection.Output

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                Dim success = CInt(command.Parameters("@outputResult").Value)
                If success = 0 Then
                    Dim chefToDelete = chefs.Find(Function(c As Chef) c.ChefId = currentEmployee.Staff_id)
                    chefs.Remove(chefToDelete)
                    ResetControls()
                Else
                    MessageBox.Show("Erro a eliminar o utilizador!!!")
                End If

            End If

            If currentEmployee.type = "Receptionist" Then
                command = New SqlCommand("MANAGEMENT.DELETE_RECEPTIONIST", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }
                command.Parameters.Add("@receptionistId", SqlDbType.VarChar).Value = currentEmployee.Staff_id
                command.Parameters.Add("@outputResult", SqlDbType.Int).Direction = ParameterDirection.Output

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                Dim success = CInt(command.Parameters("@outputResult").Value)
                If success = 0 Then
                    Dim receptionistToDelete = receptionists.Find(Function(c As Receptionist) c.receptionistId = currentEmployee.Staff_id)
                    receptionists.Remove(receptionistToDelete)
                    ResetControls()
                Else
                    MessageBox.Show("Erro a eliminar o utilizador!!!")
                End If

            End If

            If currentEmployee.type = "Bartender" Then
                command = New SqlCommand("MANAGEMENT.DELETE_BARTENDER", connection) With {
                        .CommandType = CommandType.StoredProcedure
                    }
                command.Parameters.Add("@bastenderId", SqlDbType.VarChar).Value = currentEmployee.Staff_id
                command.Parameters.Add("@outputResult", SqlDbType.Int).Direction = ParameterDirection.Output

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
                Dim success = CInt(command.Parameters("@outputResult").Value)
                If success = 0 Then
                    Dim bartenderToDelete = bartenders.Find(Function(c As Bartender) c.bartenderId = currentEmployee.Staff_id)
                    bartenders.Remove(bartenderToDelete)
                    ResetControls()
                Else
                    MessageBox.Show("Erro a eliminar o utilizador!!!")
                End If

            End If
        End If
    End Sub

    Private Sub ResetControls()
        EmployeeListView.Items.Remove(EmployeeListView.SelectedItems(0))
        EmployeeFirstNameTxtBox.Text = ""
        EmployeeLastNameTxtBox.Text = ""
        EmployeeNIFTxtBox.Text = ""
        EmployeeAddressTxtBox.Text = ""
        EmployeeBirthdateTxtBox.Text = ""
        EmployeePhoneNumTxtBox.Text = ""
        ShiftComboBox.SelectedIndex = -1

        currentEmployee = Nothing
        RoomsListView.Visible = False
        DynamicLabel.Visible = False
    End Sub

    Private Sub ResetControlsCustomer()
        CustomerList.Items.Remove(CustomerList.SelectedItems(0))
        ffnameTextBox.Text = ""
        lnameTextBox.Text = ""
        nifTextBox.Text = ""
        addressTextBox.Text = ""
        passTextBox.Text = ""
        phoneNumTextBox.Text = ""

        currentEmployee = Nothing
        RoomsListView.Visible = False
        DynamicLabel.Visible = False
    End Sub

    Private Sub MenuBtn_Click(sender As Object, e As EventArgs) Handles MenuBtn.Click
        Me.Close()
        Managerf.Show()
    End Sub

    Private Sub MenuBtn2_Click(sender As Object, e As EventArgs) Handles MenuBtn2.Click
        Me.Close()
        Managerf.Show()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim command As New SqlCommand("UPDATE MANAGEMENT.CUSTOMER SET Fname = @fname, Lname = @lname, phoneNum = @phonenum, Address = @address, Pass = @pass WHERE NIF = @nif", connection)

        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = ffnameTextBox.Text
        command.Parameters.Add("@lname", SqlDbType.VarChar).Value = lnameTextBox.Text
        command.Parameters.Add("@phonenum", SqlDbType.VarChar).Value = phoneNumTextBox.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = addressTextBox.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = passTextBox.Text
        command.Parameters.Add("@nif", SqlDbType.VarChar).Value = nifTextBox.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Customer was updated")
        Else
            MessageBox.Show("Customer was not updated")
        End If

        connection.Close()
    End Sub

    Private Sub UpdateEmployeeBtn_Click(sender As Object, e As EventArgs) Handles UpdateEmployeeBtn.Click
        Dim command As New SqlCommand("UPDATE MANAGEMENT.EMPLOYEE SET Fname = @fname, Lname = @lname, phoneNum = @phonenum, Address = @address, BirthDate = @bday WHERE NIF = @nif", connection)

        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = EmployeeFirstNameTxtBox.Text
        command.Parameters.Add("@lname", SqlDbType.VarChar).Value = EmployeeLastNameTxtBox.Text
        command.Parameters.Add("@phonenum", SqlDbType.VarChar).Value = EmployeePhoneNumTxtBox.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = EmployeeAddressTxtBox.Text
        command.Parameters.Add("@bday", SqlDbType.VarChar).Value = EmployeeBirthdateTxtBox.Text
        command.Parameters.Add("@nif", SqlDbType.VarChar).Value = EmployeeNIFTxtBox.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Customer was updated")
        Else
            MessageBox.Show("Customer was not updated")
        End If

        connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        CustRegister.Show()
    End Sub
End Class