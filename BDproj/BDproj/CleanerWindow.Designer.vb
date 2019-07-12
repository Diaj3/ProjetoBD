<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CleanerWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.FNameTxtBox = New System.Windows.Forms.TextBox()
        Me.FNameLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddressTxtBox = New System.Windows.Forms.TextBox()
        Me.LNameLabel = New System.Windows.Forms.Label()
        Me.LNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NifTxtBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DobTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PhoneNumTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RoomNumberListView = New System.Windows.Forms.ListView()
        Me.WorkingShiftTxtBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BookingNumsListView = New System.Windows.Forms.ListView()
        Me.DrinksListView = New System.Windows.Forms.ListView()
        Me.DrinkName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DrinkPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MealsListView = New System.Windows.Forms.ListView()
        Me.MealName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MealPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 15)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FNameTxtBox
        '
        Me.FNameTxtBox.Location = New System.Drawing.Point(16, 86)
        Me.FNameTxtBox.Name = "FNameTxtBox"
        Me.FNameTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.FNameTxtBox.TabIndex = 10
        '
        'FNameLabel
        '
        Me.FNameLabel.AutoSize = True
        Me.FNameLabel.Location = New System.Drawing.Point(13, 66)
        Me.FNameLabel.Name = "FNameLabel"
        Me.FNameLabel.Size = New System.Drawing.Size(74, 17)
        Me.FNameLabel.TabIndex = 11
        Me.FNameLabel.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Address"
        '
        'AddressTxtBox
        '
        Me.AddressTxtBox.Location = New System.Drawing.Point(16, 155)
        Me.AddressTxtBox.Name = "AddressTxtBox"
        Me.AddressTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.AddressTxtBox.TabIndex = 12
        '
        'LNameLabel
        '
        Me.LNameLabel.AutoSize = True
        Me.LNameLabel.Location = New System.Drawing.Point(144, 66)
        Me.LNameLabel.Name = "LNameLabel"
        Me.LNameLabel.Size = New System.Drawing.Size(74, 17)
        Me.LNameLabel.TabIndex = 15
        Me.LNameLabel.Text = "Last name"
        '
        'LNameTxtBox
        '
        Me.LNameTxtBox.Location = New System.Drawing.Point(147, 86)
        Me.LNameTxtBox.Name = "LNameTxtBox"
        Me.LNameTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.LNameTxtBox.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(144, 198)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 17)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "NIF"
        '
        'NifTxtBox
        '
        Me.NifTxtBox.Enabled = False
        Me.NifTxtBox.Location = New System.Drawing.Point(147, 218)
        Me.NifTxtBox.Name = "NifTxtBox"
        Me.NifTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.NifTxtBox.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Birthdate"
        '
        'DobTxtBox
        '
        Me.DobTxtBox.Enabled = False
        Me.DobTxtBox.Location = New System.Drawing.Point(16, 218)
        Me.DobTxtBox.Name = "DobTxtBox"
        Me.DobTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.DobTxtBox.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(144, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "PhoneNum"
        '
        'PhoneNumTxtBox
        '
        Me.PhoneNumTxtBox.Location = New System.Drawing.Point(147, 155)
        Me.PhoneNumTxtBox.Name = "PhoneNumTxtBox"
        Me.PhoneNumTxtBox.Size = New System.Drawing.Size(100, 22)
        Me.PhoneNumTxtBox.TabIndex = 20
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(301, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Rooms"
        '
        'RoomNumberListView
        '
        Me.RoomNumberListView.Location = New System.Drawing.Point(304, 86)
        Me.RoomNumberListView.Name = "RoomNumberListView"
        Me.RoomNumberListView.Size = New System.Drawing.Size(442, 109)
        Me.RoomNumberListView.TabIndex = 26
        Me.RoomNumberListView.UseCompatibleStateImageBehavior = False
        '
        'WorkingShiftTxtBox
        '
        Me.WorkingShiftTxtBox.Enabled = False
        Me.WorkingShiftTxtBox.Location = New System.Drawing.Point(16, 290)
        Me.WorkingShiftTxtBox.Name = "WorkingShiftTxtBox"
        Me.WorkingShiftTxtBox.Size = New System.Drawing.Size(237, 22)
        Me.WorkingShiftTxtBox.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 270)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Working shift"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(301, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Meals"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(301, 209)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 17)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "BookingNums"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(13, 360)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Drinks"
        '
        'BookingNumsListView
        '
        Me.BookingNumsListView.Location = New System.Drawing.Point(304, 229)
        Me.BookingNumsListView.Name = "BookingNumsListView"
        Me.BookingNumsListView.Size = New System.Drawing.Size(442, 83)
        Me.BookingNumsListView.TabIndex = 32
        Me.BookingNumsListView.UseCompatibleStateImageBehavior = False
        '
        'DrinksListView
        '
        Me.DrinksListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DrinkName, Me.DrinkPrice})
        Me.DrinksListView.Location = New System.Drawing.Point(15, 380)
        Me.DrinksListView.Name = "DrinksListView"
        Me.DrinksListView.Size = New System.Drawing.Size(238, 173)
        Me.DrinksListView.TabIndex = 33
        Me.DrinksListView.UseCompatibleStateImageBehavior = False
        Me.DrinksListView.View = System.Windows.Forms.View.Details
        '
        'DrinkName
        '
        Me.DrinkName.Text = "Drink Name"
        Me.DrinkName.Width = 107
        '
        'DrinkPrice
        '
        Me.DrinkPrice.Text = "Drink Price"
        Me.DrinkPrice.Width = 117
        '
        'MealsListView
        '
        Me.MealsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MealName, Me.MealPrice})
        Me.MealsListView.Location = New System.Drawing.Point(304, 380)
        Me.MealsListView.Name = "MealsListView"
        Me.MealsListView.Size = New System.Drawing.Size(442, 173)
        Me.MealsListView.TabIndex = 34
        Me.MealsListView.UseCompatibleStateImageBehavior = False
        Me.MealsListView.View = System.Windows.Forms.View.Details
        '
        'MealName
        '
        Me.MealName.Text = "Meal Name"
        Me.MealName.Width = 100
        '
        'MealPrice
        '
        Me.MealPrice.Text = "Meal Price"
        Me.MealPrice.Width = 100
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 332)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CleanerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(823, 572)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MealsListView)
        Me.Controls.Add(Me.DrinksListView)
        Me.Controls.Add(Me.BookingNumsListView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WorkingShiftTxtBox)
        Me.Controls.Add(Me.RoomNumberListView)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PhoneNumTxtBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DobTxtBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.NifTxtBox)
        Me.Controls.Add(Me.LNameLabel)
        Me.Controls.Add(Me.LNameTxtBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddressTxtBox)
        Me.Controls.Add(Me.FNameLabel)
        Me.Controls.Add(Me.FNameTxtBox)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CleanerWindow"
        Me.Text = "EmpLogged"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents FNameTxtBox As TextBox
    Friend WithEvents FNameLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LNameLabel As Label
    Friend WithEvents LNameTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents NifTxtBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DobTxtBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PhoneNumTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents RoomNumberListView As ListView
    Friend WithEvents WorkingShiftTxtBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BookingNumsListView As ListView
    Friend WithEvents DrinksListView As ListView
    Friend WithEvents MealsListView As ListView
    Friend WithEvents MealName As ColumnHeader
    Friend WithEvents MealPrice As ColumnHeader
    Friend WithEvents DrinkName As ColumnHeader
    Friend WithEvents DrinkPrice As ColumnHeader
    Friend WithEvents Button2 As Button
    Friend WithEvents AddressTxtBox As TextBox
End Class
