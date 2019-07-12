Imports System.Data.SqlClient

Public Class CustLogged

    ' SQL Variabless
    Private connection As SqlConnection = New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")
    Private command As SqlCommand
    Private command3 As SqlCommand
    Private command5 As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Customerf.Show()
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        FnameTextBox.Text = LoggedCustomer.fname
        LnameTextBox.Text = LoggedCustomer.lname
        nifTextBox.Text = LoggedCustomer.NIF
        phoneNumTextBox.Text = LoggedCustomer.phoneNum
        AddressTextBox.Text = LoggedCustomer.address
        PassTextBox.Text = LoggedCustomer.pass

        LoggedCustomer.Gastos = New List(Of Gasto)

        GetCustomerData()
        GetTotalGastos()
        GetCustomerBookings()

    End Sub

    Public Sub GetCustomerData()
        Dim command As New SqlCommand("Select * FROM MANAGEMENT.CUSTOMER_DATA(@NIF)", connection)
        command.Parameters.Add("@NIF", SqlDbType.Char).Value = LoggedCustomer.NIF

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            For Each row In table.Rows
                Dim gasto = New Gasto With {
                .Drink_name = row("Drink_name"),
                .Drink_price = row("Drink_price"),
                .Checkin_time = row("Checkin_time"),
                .Checkout_time = row("Checkout_time"),
                .Meal_name = row("Meal_name"),
                .Meal_price = row("Meal_price"),
                .RoomNum = row("RoomNum"),
                .RoomPrice = row("RoomPrice")
            }
                LoggedCustomer.Gastos.Add(gasto)

                Dim item = New ListViewItem(gasto.Drink_name)
                item.SubItems.Add(gasto.Drink_price)
                Dim item2 = New ListViewItem(gasto.Meal_name)
                item2.SubItems.Add(gasto.Meal_price)
                GastosListView.Items.Add(item)
                GastosListView.Items.Add(item2)
            Next
            Dim checkIn = LoggedCustomer.Gastos(0).Checkin_time
            Dim checkout = LoggedCustomer.Gastos(0).Checkout_time
            Dim days = DateDiff(DateInterval.Day, checkIn, checkout)

            For value As Integer = 0 To days
                Dim item3 = New ListViewItem("Room" + LoggedCustomer.Gastos(0).RoomNum.ToString)
                item3.SubItems.Add(LoggedCustomer.Gastos(0).RoomPrice)
                GastosListView.Items.Add(item3)
            Next

        End If
    End Sub

    Public Sub GetCustomerBookings()
        Dim command As New SqlCommand("Select * FROM MANAGEMENT.CUSTOMER_DATA(@NIF)", connection)
        command.Parameters.Add("@NIF", SqlDbType.Char).Value = LoggedCustomer.NIF
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count > 0 Then
            For Each row In table.Rows
                Dim booking = New Gasto With {
                .Checkin_time = row("Checkin_time"),
                .Checkout_time = row("Checkout_time"),
                .RoomNum = row("RoomNum"),
                .RoomPrice = row("RoomPrice")
            }
                LoggedCustomer.Gastos.Add(booking)

            Next
            Dim checkIn = LoggedCustomer.Gastos(0).Checkin_time
            Dim checkout = LoggedCustomer.Gastos(0).Checkout_time
            Dim days = DateDiff(DateInterval.Day, checkIn, checkout)

            Dim item1 = New ListViewItem("Room nº" + LoggedCustomer.Gastos(0).RoomNum.ToString)
            Dim item2 = New ListViewItem(LoggedCustomer.Gastos(0).Checkin_time.ToString)
            Dim item3 = New ListViewItem(LoggedCustomer.Gastos(0).Checkin_time.ToString)
            Dim item4 = New ListViewItem((LoggedCustomer.Gastos(0).RoomPrice * days).ToString + "€")
            CheckBookingsListView.Items.Add(item1)
            CheckBookingsListView.Items.Add(item2)
            CheckBookingsListView.Items.Add(item3)
            CheckBookingsListView.Items.Add(item4)

        End If
    End Sub

    Public Sub GetTotalGastos()
        If LoggedCustomer.Gastos.Count() > 0 Then
            Dim totalGastos = 0

            For Each gasto In LoggedCustomer.Gastos
                totalGastos += gasto.Drink_price
                totalGastos += gasto.Meal_price
            Next

            Dim checkIn = LoggedCustomer.Gastos(0).Checkin_time
            Dim checkout = LoggedCustomer.Gastos(0).Checkout_time
            Dim roomPricePerDay = LoggedCustomer.Gastos(0).RoomPrice

            Dim days = DateDiff(DateInterval.Day, checkIn, checkout)

            totalGastos += days * roomPricePerDay

            totalGastosText.Text = totalGastos
        End If

    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Dim command As New SqlCommand("UPDATE MANAGEMENT.CUSTOMER SET Fname = @fname, Lname = @lname, phoneNum = @phonenum, Address = @address, Pass = @pass WHERE NIF = @nif", connection)

        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FnameTextBox.Text
        'command.Parameters.Add("@lname", SqlDbType.VarChar).Value = LnameTextBox.Text
        command.Parameters.Add("@phonenum", SqlDbType.VarChar).Value = phoneNumTextBox.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTextBox.Text
        command.Parameters.Add("@pass", SqlDbType.VarChar).Value = PassTextBox.Text
        command.Parameters.Add("@nif", SqlDbType.VarChar).Value = nifTextBox.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Customer was updated")
        Else
            MessageBox.Show("Customer was not updated")
        End If

        connection.Close()
    End Sub

    Private Sub RoomTypeBox_Click(sender As Object, e As EventArgs) Handles RoomTypeBox.Click
        RoomTypeBox.Items.Add("Single")
        RoomTypeBox.Items.Add("Double")
        RoomTypeBox.Items.Add("Triple")
        RoomTypeBox.Items.Add("Quad")
        RoomTypeBox.Items.Add("Queen")
        RoomTypeBox.Items.Add("King")
        RoomTypeBox.Items.Add("Twin")
        RoomTypeBox.Items.Add("Studio")
        RoomTypeBox.Items.Add("Suite")
        RoomTypeBox.Items.Add("Cabana")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MessageBox.Show("Booking was made")
    End Sub
End Class