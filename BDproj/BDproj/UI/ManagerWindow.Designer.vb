<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManagerWindow
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Passtxt As System.Windows.Forms.Label
        Me.EmployeeTab = New System.Windows.Forms.TabControl()
        Me.EmployeePage = New System.Windows.Forms.TabPage()
        Me.MenuBtn = New System.Windows.Forms.Button()
        Me.DynamicLabel = New System.Windows.Forms.Label()
        Me.RoomsListView = New System.Windows.Forms.ListView()
        Me.ShiftComboBox = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EmployeeNIFTxtBox = New System.Windows.Forms.TextBox()
        Me.BirthdateTxtBox = New System.Windows.Forms.Label()
        Me.EmployeeBirthdateTxtBox = New System.Windows.Forms.TextBox()
        Me.AddressTxtBox = New System.Windows.Forms.Label()
        Me.EmployeeAddressTxtBox = New System.Windows.Forms.TextBox()
        Me.LNameTxtBox = New System.Windows.Forms.Label()
        Me.EmployeeLastNameTxtBox = New System.Windows.Forms.TextBox()
        Me.NIFTxtBox = New System.Windows.Forms.Label()
        Me.phoneNumTxtBox = New System.Windows.Forms.Label()
        Me.EmployeePhoneNumTxtBox = New System.Windows.Forms.TextBox()
        Me.FNameTxtBox = New System.Windows.Forms.Label()
        Me.EmployeeFirstNameTxtBox = New System.Windows.Forms.TextBox()
        Me.DeleteEmployeeBtn = New System.Windows.Forms.Button()
        Me.UpdateEmployeeBtn = New System.Windows.Forms.Button()
        Me.EmployeeListView = New System.Windows.Forms.ListView()
        Me.NameColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TypeColumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CustomerPage = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.MenuBtn2 = New System.Windows.Forms.Button()
        Me.passTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneNumtxt = New System.Windows.Forms.Label()
        Me.phoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Lnametxt = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Addresstxt = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Niftxt = New System.Windows.Forms.Label()
        Me.nifTextBox = New System.Windows.Forms.TextBox()
        Me.Fnametxt = New System.Windows.Forms.Label()
        Me.ffnameTextBox = New System.Windows.Forms.TextBox()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.CustomerList = New System.Windows.Forms.ListView()
        Passtxt = New System.Windows.Forms.Label()
        Me.EmployeeTab.SuspendLayout()
        Me.EmployeePage.SuspendLayout()
        Me.CustomerPage.SuspendLayout()
        Me.SuspendLayout()
        '
        'Passtxt
        '
        Passtxt.AutoSize = True
        Passtxt.Location = New System.Drawing.Point(689, 295)
        Passtxt.Name = "Passtxt"
        Passtxt.Size = New System.Drawing.Size(69, 17)
        Passtxt.TabIndex = 15
        Passtxt.Text = "Password"
        '
        'EmployeeTab
        '
        Me.EmployeeTab.Controls.Add(Me.EmployeePage)
        Me.EmployeeTab.Controls.Add(Me.CustomerPage)
        Me.EmployeeTab.Location = New System.Drawing.Point(1, 2)
        Me.EmployeeTab.Name = "EmployeeTab"
        Me.EmployeeTab.SelectedIndex = 0
        Me.EmployeeTab.Size = New System.Drawing.Size(1021, 592)
        Me.EmployeeTab.TabIndex = 0
        '
        'EmployeePage
        '
        Me.EmployeePage.Controls.Add(Me.MenuBtn)
        Me.EmployeePage.Controls.Add(Me.DynamicLabel)
        Me.EmployeePage.Controls.Add(Me.RoomsListView)
        Me.EmployeePage.Controls.Add(Me.ShiftComboBox)
        Me.EmployeePage.Controls.Add(Me.Label8)
        Me.EmployeePage.Controls.Add(Me.Label7)
        Me.EmployeePage.Controls.Add(Me.EmployeeNIFTxtBox)
        Me.EmployeePage.Controls.Add(Me.BirthdateTxtBox)
        Me.EmployeePage.Controls.Add(Me.EmployeeBirthdateTxtBox)
        Me.EmployeePage.Controls.Add(Me.AddressTxtBox)
        Me.EmployeePage.Controls.Add(Me.EmployeeAddressTxtBox)
        Me.EmployeePage.Controls.Add(Me.LNameTxtBox)
        Me.EmployeePage.Controls.Add(Me.EmployeeLastNameTxtBox)
        Me.EmployeePage.Controls.Add(Me.NIFTxtBox)
        Me.EmployeePage.Controls.Add(Me.phoneNumTxtBox)
        Me.EmployeePage.Controls.Add(Me.EmployeePhoneNumTxtBox)
        Me.EmployeePage.Controls.Add(Me.FNameTxtBox)
        Me.EmployeePage.Controls.Add(Me.EmployeeFirstNameTxtBox)
        Me.EmployeePage.Controls.Add(Me.DeleteEmployeeBtn)
        Me.EmployeePage.Controls.Add(Me.UpdateEmployeeBtn)
        Me.EmployeePage.Controls.Add(Me.EmployeeListView)
        Me.EmployeePage.Location = New System.Drawing.Point(4, 25)
        Me.EmployeePage.Name = "EmployeePage"
        Me.EmployeePage.Padding = New System.Windows.Forms.Padding(3)
        Me.EmployeePage.Size = New System.Drawing.Size(1013, 563)
        Me.EmployeePage.TabIndex = 0
        Me.EmployeePage.Text = "Employees"
        Me.EmployeePage.UseVisualStyleBackColor = True
        '
        'MenuBtn
        '
        Me.MenuBtn.Location = New System.Drawing.Point(365, 501)
        Me.MenuBtn.Name = "MenuBtn"
        Me.MenuBtn.Size = New System.Drawing.Size(91, 37)
        Me.MenuBtn.TabIndex = 38
        Me.MenuBtn.Text = "Menu"
        Me.MenuBtn.UseVisualStyleBackColor = True
        '
        'DynamicLabel
        '
        Me.DynamicLabel.AutoSize = True
        Me.DynamicLabel.Location = New System.Drawing.Point(673, 32)
        Me.DynamicLabel.Name = "DynamicLabel"
        Me.DynamicLabel.Size = New System.Drawing.Size(0, 17)
        Me.DynamicLabel.TabIndex = 37
        '
        'RoomsListView
        '
        Me.RoomsListView.Location = New System.Drawing.Point(676, 52)
        Me.RoomsListView.Name = "RoomsListView"
        Me.RoomsListView.Size = New System.Drawing.Size(309, 449)
        Me.RoomsListView.TabIndex = 36
        Me.RoomsListView.UseCompatibleStateImageBehavior = False
        Me.RoomsListView.View = System.Windows.Forms.View.Details
        '
        'ShiftComboBox
        '
        Me.ShiftComboBox.FormattingEnabled = True
        Me.ShiftComboBox.Items.AddRange(New Object() {"morning_shift", "afternoon_shift", "evening_shift"})
        Me.ShiftComboBox.Location = New System.Drawing.Point(320, 246)
        Me.ShiftComboBox.Name = "ShiftComboBox"
        Me.ShiftComboBox.Size = New System.Drawing.Size(180, 24)
        Me.ShiftComboBox.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Employees"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(317, 226)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(90, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Working shift"
        '
        'EmployeeNIFTxtBox
        '
        Me.EmployeeNIFTxtBox.Enabled = False
        Me.EmployeeNIFTxtBox.Location = New System.Drawing.Point(320, 304)
        Me.EmployeeNIFTxtBox.Name = "EmployeeNIFTxtBox"
        Me.EmployeeNIFTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeNIFTxtBox.TabIndex = 32
        '
        'BirthdateTxtBox
        '
        Me.BirthdateTxtBox.AutoSize = True
        Me.BirthdateTxtBox.Location = New System.Drawing.Point(317, 329)
        Me.BirthdateTxtBox.Name = "BirthdateTxtBox"
        Me.BirthdateTxtBox.Size = New System.Drawing.Size(65, 17)
        Me.BirthdateTxtBox.TabIndex = 31
        Me.BirthdateTxtBox.Text = "Birthdate"
        '
        'EmployeeBirthdateTxtBox
        '
        Me.EmployeeBirthdateTxtBox.Enabled = False
        Me.EmployeeBirthdateTxtBox.Location = New System.Drawing.Point(320, 349)
        Me.EmployeeBirthdateTxtBox.Name = "EmployeeBirthdateTxtBox"
        Me.EmployeeBirthdateTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeBirthdateTxtBox.TabIndex = 30
        '
        'AddressTxtBox
        '
        Me.AddressTxtBox.AutoSize = True
        Me.AddressTxtBox.Location = New System.Drawing.Point(317, 172)
        Me.AddressTxtBox.Name = "AddressTxtBox"
        Me.AddressTxtBox.Size = New System.Drawing.Size(60, 17)
        Me.AddressTxtBox.TabIndex = 29
        Me.AddressTxtBox.Text = "Address"
        '
        'EmployeeAddressTxtBox
        '
        Me.EmployeeAddressTxtBox.Location = New System.Drawing.Point(320, 192)
        Me.EmployeeAddressTxtBox.Name = "EmployeeAddressTxtBox"
        Me.EmployeeAddressTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeAddressTxtBox.TabIndex = 28
        '
        'LNameTxtBox
        '
        Me.LNameTxtBox.AutoSize = True
        Me.LNameTxtBox.Location = New System.Drawing.Point(317, 81)
        Me.LNameTxtBox.Name = "LNameTxtBox"
        Me.LNameTxtBox.Size = New System.Drawing.Size(74, 17)
        Me.LNameTxtBox.TabIndex = 27
        Me.LNameTxtBox.Text = "Last name"
        '
        'EmployeeLastNameTxtBox
        '
        Me.EmployeeLastNameTxtBox.Location = New System.Drawing.Point(320, 101)
        Me.EmployeeLastNameTxtBox.Name = "EmployeeLastNameTxtBox"
        Me.EmployeeLastNameTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeLastNameTxtBox.TabIndex = 26
        '
        'NIFTxtBox
        '
        Me.NIFTxtBox.AutoSize = True
        Me.NIFTxtBox.Location = New System.Drawing.Point(317, 284)
        Me.NIFTxtBox.Name = "NIFTxtBox"
        Me.NIFTxtBox.Size = New System.Drawing.Size(29, 17)
        Me.NIFTxtBox.TabIndex = 25
        Me.NIFTxtBox.Text = "NIF"
        '
        'phoneNumTxtBox
        '
        Me.phoneNumTxtBox.AutoSize = True
        Me.phoneNumTxtBox.Location = New System.Drawing.Point(317, 127)
        Me.phoneNumTxtBox.Name = "phoneNumTxtBox"
        Me.phoneNumTxtBox.Size = New System.Drawing.Size(78, 17)
        Me.phoneNumTxtBox.TabIndex = 23
        Me.phoneNumTxtBox.Text = "PhoneNum"
        '
        'EmployeePhoneNumTxtBox
        '
        Me.EmployeePhoneNumTxtBox.Location = New System.Drawing.Point(320, 147)
        Me.EmployeePhoneNumTxtBox.Name = "EmployeePhoneNumTxtBox"
        Me.EmployeePhoneNumTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeePhoneNumTxtBox.TabIndex = 22
        '
        'FNameTxtBox
        '
        Me.FNameTxtBox.AutoSize = True
        Me.FNameTxtBox.Location = New System.Drawing.Point(317, 32)
        Me.FNameTxtBox.Name = "FNameTxtBox"
        Me.FNameTxtBox.Size = New System.Drawing.Size(74, 17)
        Me.FNameTxtBox.TabIndex = 21
        Me.FNameTxtBox.Text = "First name"
        '
        'EmployeeFirstNameTxtBox
        '
        Me.EmployeeFirstNameTxtBox.Location = New System.Drawing.Point(320, 52)
        Me.EmployeeFirstNameTxtBox.Name = "EmployeeFirstNameTxtBox"
        Me.EmployeeFirstNameTxtBox.Size = New System.Drawing.Size(180, 22)
        Me.EmployeeFirstNameTxtBox.TabIndex = 20
        '
        'DeleteEmployeeBtn
        '
        Me.DeleteEmployeeBtn.Location = New System.Drawing.Point(48, 501)
        Me.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn"
        Me.DeleteEmployeeBtn.Size = New System.Drawing.Size(223, 37)
        Me.DeleteEmployeeBtn.TabIndex = 19
        Me.DeleteEmployeeBtn.Text = "Delete"
        Me.DeleteEmployeeBtn.UseVisualStyleBackColor = True
        '
        'UpdateEmployeeBtn
        '
        Me.UpdateEmployeeBtn.Location = New System.Drawing.Point(365, 395)
        Me.UpdateEmployeeBtn.Name = "UpdateEmployeeBtn"
        Me.UpdateEmployeeBtn.Size = New System.Drawing.Size(87, 37)
        Me.UpdateEmployeeBtn.TabIndex = 18
        Me.UpdateEmployeeBtn.Text = "Update"
        Me.UpdateEmployeeBtn.UseVisualStyleBackColor = True
        '
        'EmployeeListView
        '
        Me.EmployeeListView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmployeeListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.NameColumn, Me.TypeColumn})
        Me.EmployeeListView.Location = New System.Drawing.Point(48, 52)
        Me.EmployeeListView.MultiSelect = False
        Me.EmployeeListView.Name = "EmployeeListView"
        Me.EmployeeListView.ShowGroups = False
        Me.EmployeeListView.Size = New System.Drawing.Size(223, 449)
        Me.EmployeeListView.TabIndex = 16
        Me.EmployeeListView.UseCompatibleStateImageBehavior = False
        Me.EmployeeListView.View = System.Windows.Forms.View.Details
        '
        'NameColumn
        '
        Me.NameColumn.Text = "Name"
        Me.NameColumn.Width = 106
        '
        'TypeColumn
        '
        Me.TypeColumn.Text = "Type"
        Me.TypeColumn.Width = 101
        '
        'CustomerPage
        '
        Me.CustomerPage.Controls.Add(Me.Button1)
        Me.CustomerPage.Controls.Add(Me.Label9)
        Me.CustomerPage.Controls.Add(Me.MenuBtn2)
        Me.CustomerPage.Controls.Add(Passtxt)
        Me.CustomerPage.Controls.Add(Me.passTextBox)
        Me.CustomerPage.Controls.Add(Me.PhoneNumtxt)
        Me.CustomerPage.Controls.Add(Me.phoneNumTextBox)
        Me.CustomerPage.Controls.Add(Me.Lnametxt)
        Me.CustomerPage.Controls.Add(Me.lnameTextBox)
        Me.CustomerPage.Controls.Add(Me.Addresstxt)
        Me.CustomerPage.Controls.Add(Me.addressTextBox)
        Me.CustomerPage.Controls.Add(Me.Niftxt)
        Me.CustomerPage.Controls.Add(Me.nifTextBox)
        Me.CustomerPage.Controls.Add(Me.Fnametxt)
        Me.CustomerPage.Controls.Add(Me.ffnameTextBox)
        Me.CustomerPage.Controls.Add(Me.UpdateButton)
        Me.CustomerPage.Controls.Add(Me.CustomerList)
        Me.CustomerPage.Location = New System.Drawing.Point(4, 25)
        Me.CustomerPage.Name = "CustomerPage"
        Me.CustomerPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CustomerPage.Size = New System.Drawing.Size(1013, 563)
        Me.CustomerPage.TabIndex = 1
        Me.CustomerPage.Text = "Customers"
        Me.CustomerPage.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(41, 486)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(235, 37)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 17)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Customers"
        '
        'MenuBtn2
        '
        Me.MenuBtn2.Location = New System.Drawing.Point(596, 462)
        Me.MenuBtn2.Name = "MenuBtn2"
        Me.MenuBtn2.Size = New System.Drawing.Size(91, 37)
        Me.MenuBtn2.TabIndex = 39
        Me.MenuBtn2.Text = "Menu"
        Me.MenuBtn2.UseVisualStyleBackColor = True
        '
        'passTextBox
        '
        Me.passTextBox.Location = New System.Drawing.Point(685, 315)
        Me.passTextBox.Name = "passTextBox"
        Me.passTextBox.Size = New System.Drawing.Size(180, 22)
        Me.passTextBox.TabIndex = 14
        '
        'PhoneNumtxt
        '
        Me.PhoneNumtxt.AutoSize = True
        Me.PhoneNumtxt.Location = New System.Drawing.Point(682, 170)
        Me.PhoneNumtxt.Name = "PhoneNumtxt"
        Me.PhoneNumtxt.Size = New System.Drawing.Size(103, 17)
        Me.PhoneNumtxt.TabIndex = 13
        Me.PhoneNumtxt.Text = "Phone Number"
        '
        'phoneNumTextBox
        '
        Me.phoneNumTextBox.Location = New System.Drawing.Point(685, 190)
        Me.phoneNumTextBox.Name = "phoneNumTextBox"
        Me.phoneNumTextBox.Size = New System.Drawing.Size(180, 22)
        Me.phoneNumTextBox.TabIndex = 12
        '
        'Lnametxt
        '
        Me.Lnametxt.AutoSize = True
        Me.Lnametxt.Location = New System.Drawing.Point(682, 49)
        Me.Lnametxt.Name = "Lnametxt"
        Me.Lnametxt.Size = New System.Drawing.Size(76, 17)
        Me.Lnametxt.TabIndex = 11
        Me.Lnametxt.Text = "Last Name"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Location = New System.Drawing.Point(685, 69)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.lnameTextBox.TabIndex = 10
        '
        'Addresstxt
        '
        Me.Addresstxt.AutoSize = True
        Me.Addresstxt.Location = New System.Drawing.Point(405, 170)
        Me.Addresstxt.Name = "Addresstxt"
        Me.Addresstxt.Size = New System.Drawing.Size(60, 17)
        Me.Addresstxt.TabIndex = 9
        Me.Addresstxt.Text = "Address"
        '
        'addressTextBox
        '
        Me.addressTextBox.Location = New System.Drawing.Point(408, 190)
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(180, 22)
        Me.addressTextBox.TabIndex = 8
        '
        'Niftxt
        '
        Me.Niftxt.AutoSize = True
        Me.Niftxt.Location = New System.Drawing.Point(405, 295)
        Me.Niftxt.Name = "Niftxt"
        Me.Niftxt.Size = New System.Drawing.Size(29, 17)
        Me.Niftxt.TabIndex = 7
        Me.Niftxt.Text = "NIF"
        '
        'nifTextBox
        '
        Me.nifTextBox.Location = New System.Drawing.Point(408, 315)
        Me.nifTextBox.Name = "nifTextBox"
        Me.nifTextBox.Size = New System.Drawing.Size(180, 22)
        Me.nifTextBox.TabIndex = 6
        '
        'Fnametxt
        '
        Me.Fnametxt.AutoSize = True
        Me.Fnametxt.Location = New System.Drawing.Point(405, 49)
        Me.Fnametxt.Name = "Fnametxt"
        Me.Fnametxt.Size = New System.Drawing.Size(76, 17)
        Me.Fnametxt.TabIndex = 5
        Me.Fnametxt.Text = "First Name"
        '
        'ffnameTextBox
        '
        Me.ffnameTextBox.Location = New System.Drawing.Point(408, 69)
        Me.ffnameTextBox.Name = "ffnameTextBox"
        Me.ffnameTextBox.Size = New System.Drawing.Size(180, 22)
        Me.ffnameTextBox.TabIndex = 4
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(542, 396)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(203, 37)
        Me.UpdateButton.TabIndex = 2
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'CustomerList
        '
        Me.CustomerList.Location = New System.Drawing.Point(41, 50)
        Me.CustomerList.Name = "CustomerList"
        Me.CustomerList.Size = New System.Drawing.Size(235, 430)
        Me.CustomerList.TabIndex = 0
        Me.CustomerList.UseCompatibleStateImageBehavior = False
        '
        'ManagerWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1022, 591)
        Me.Controls.Add(Me.EmployeeTab)
        Me.Name = "ManagerWindow"
        Me.Text = "ManagerWindow"
        Me.EmployeeTab.ResumeLayout(False)
        Me.EmployeePage.ResumeLayout(False)
        Me.EmployeePage.PerformLayout()
        Me.CustomerPage.ResumeLayout(False)
        Me.CustomerPage.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents EmployeeTab As TabControl
    Friend WithEvents EmployeePage As TabPage
    Friend WithEvents CustomerPage As TabPage
    Friend WithEvents UpdateButton As Button
    Friend WithEvents CustomerList As ListView
    Friend WithEvents EmployeeListView As ListView
    Friend WithEvents passTextBox As TextBox
    Friend WithEvents PhoneNumtxt As Label
    Friend WithEvents phoneNumTextBox As TextBox
    Friend WithEvents Lnametxt As Label
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Addresstxt As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Niftxt As Label
    Friend WithEvents nifTextBox As TextBox
    Friend WithEvents Fnametxt As Label
    Friend WithEvents ffnameTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents EmployeeNIFTxtBox As TextBox
    Friend WithEvents BirthdateTxtBox As Label
    Friend WithEvents EmployeeBirthdateTxtBox As TextBox
    Friend WithEvents AddressTxtBox As Label
    Friend WithEvents EmployeeAddressTxtBox As TextBox
    Friend WithEvents LNameTxtBox As Label
    Friend WithEvents EmployeeLastNameTxtBox As TextBox
    Friend WithEvents NIFTxtBox As Label
    Friend WithEvents phoneNumTxtBox As Label
    Friend WithEvents EmployeePhoneNumTxtBox As TextBox
    Friend WithEvents FNameTxtBox As Label
    Friend WithEvents EmployeeFirstNameTxtBox As TextBox
    Friend WithEvents DeleteEmployeeBtn As Button
    Friend WithEvents UpdateEmployeeBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents ShiftComboBox As ComboBox
    Friend WithEvents DynamicLabel As Label
    Friend WithEvents RoomsListView As ListView
    Friend WithEvents MenuBtn As Button
    Friend WithEvents MenuBtn2 As Button
    Friend WithEvents NameColumn As ColumnHeader
    Friend WithEvents TypeColumn As ColumnHeader
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
End Class
