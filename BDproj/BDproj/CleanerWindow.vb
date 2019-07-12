Imports System.Data.SqlClient

Public Class CleanerWindow
    ' SQL Variabless
    Private connection As SqlConnection = New SqlConnection("Server=tcp:mednat.ieeta.pt\SQLSERVER,8101;Database=p6g7;User Id = p6g7;Password = Kamehameha07")
    Private command As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Employf.Show()
        Me.Close()
    End Sub

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        FNameTxtBox.Text = LoggedEmployee.Fname
        LNameTxtBox.Text = LoggedEmployee.Lname
        AddressTxtBox.Text = LoggedEmployee.Address
        NifTxtBox.Text = LoggedEmployee.NIF
        DobTxtBox.Text = LoggedEmployee.BirthDate
        PhoneNumTxtBox.Text = LoggedEmployee.PhoneNum
        WorkingShiftTxtBox.Text = LoggedEmployee.WorkingShift



        If LoggedEmployee.Rooms.Count() > 0 Then
            For Each item As Integer In LoggedEmployee.Rooms
                Dim ListViewItem = New ListViewItem
                ListViewItem.Text = item

                RoomNumberListView.Items.Add(ListViewItem)
            Next
        End If

        If LoggedEmployee.BookingNums.Count() > 0 Then
            For Each item As Integer In LoggedEmployee.BookingNums
                Dim ListViewItem = New ListViewItem With {
                    .Text = item
                }

                BookingNumsListView.Items.Add(ListViewItem)
            Next
        End If

        If LoggedEmployee.Meals.Count() > 0 Then
            Dim i = 0
            For Each meal In LoggedEmployee.Meals
                Dim item = New ListViewItem()
                MealsListView.Items.Add(meal.Meal_name)
                MealsListView.Items(i).SubItems.Add(meal.Meal_price.ToString + "€")
                i += 1
            Next
        End If

        If LoggedEmployee.Drinks.Count() > 0 Then
            Dim i = 0
            For Each drink In LoggedEmployee.Drinks
                Dim item = New ListViewItem()
                DrinksListView.Items.Add(drink.Drink_name)
                DrinksListView.Items(i).SubItems.Add(drink.Drink_price.ToString + "€")
                i += 1
            Next
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim command As New SqlCommand("UPDATE MANAGEMENT.EMPLOYEE SET Fname = @fname, Lname = @lname, phoneNum = @phonenum, Address = @address, BirthDate = @dob WHERE NIF = @nif", connection)

        command.Parameters.Add("@fname", SqlDbType.VarChar).Value = FNameTxtBox.Text
        command.Parameters.Add("@lname", SqlDbType.VarChar).Value = LNameTxtBox.Text
        command.Parameters.Add("@phonenum", SqlDbType.VarChar).Value = PhoneNumTxtBox.Text
        command.Parameters.Add("@address", SqlDbType.VarChar).Value = AddressTxtBox.Text
        command.Parameters.Add("@dob", SqlDbType.VarChar).Value = DobTxtBox.Text
        command.Parameters.Add("@nif", SqlDbType.VarChar).Value = NifTxtBox.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Customer was updated")
        Else
            MessageBox.Show("Customer was not updated")
        End If

        connection.Close()
    End Sub
End Class