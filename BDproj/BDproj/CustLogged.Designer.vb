<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CustLogged
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
        Dim ListViewGroup1 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Drinks", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup2 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Meals", System.Windows.Forms.HorizontalAlignment.Left)
        Dim ListViewGroup3 As System.Windows.Forms.ListViewGroup = New System.Windows.Forms.ListViewGroup("Rooms", System.Windows.Forms.HorizontalAlignment.Left)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBookingsListView = New System.Windows.Forms.ListView()
        Me.GastosListView = New System.Windows.Forms.ListView()
        Me.Name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.nifTextBox = New System.Windows.Forms.TextBox()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.updatebtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.totalGastosText = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.RoomTypeBox = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.AccTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 507)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(114, 44)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(479, 9)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Gastos"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(484, 208)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Check Bookings"
        '
        'CheckBookingsListView
        '
        Me.CheckBookingsListView.Location = New System.Drawing.Point(482, 228)
        Me.CheckBookingsListView.Name = "CheckBookingsListView"
        Me.CheckBookingsListView.Size = New System.Drawing.Size(319, 94)
        Me.CheckBookingsListView.TabIndex = 17
        Me.CheckBookingsListView.UseCompatibleStateImageBehavior = False
        '
        'GastosListView
        '
        Me.GastosListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Name, Me.Price})
        ListViewGroup1.Header = "Drinks"
        ListViewGroup1.Name = "Drinks"
        ListViewGroup2.Header = "Meals"
        ListViewGroup2.Name = "Meals"
        ListViewGroup3.Header = "Rooms"
        ListViewGroup3.Name = "Rooms"
        Me.GastosListView.Groups.AddRange(New System.Windows.Forms.ListViewGroup() {ListViewGroup1, ListViewGroup2, ListViewGroup3})
        Me.GastosListView.Location = New System.Drawing.Point(482, 29)
        Me.GastosListView.Name = "GastosListView"
        Me.GastosListView.Size = New System.Drawing.Size(319, 145)
        Me.GastosListView.TabIndex = 18
        Me.GastosListView.UseCompatibleStateImageBehavior = False
        Me.GastosListView.View = System.Windows.Forms.View.Details
        '
        'Name
        '
        Me.Name.Text = "CustLogged"
        '
        'Price
        '
        Me.Price.Text = "Price"
        '
        'FnameTextBox
        '
        Me.FnameTextBox.Location = New System.Drawing.Point(39, 62)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(118, 22)
        Me.FnameTextBox.TabIndex = 19
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(38, 387)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(118, 22)
        Me.PassTextBox.TabIndex = 20
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(38, 228)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(294, 22)
        Me.AddressTextBox.TabIndex = 21
        '
        'phoneNumTextBox
        '
        Me.phoneNumTextBox.Location = New System.Drawing.Point(212, 141)
        Me.phoneNumTextBox.Name = "phoneNumTextBox"
        Me.phoneNumTextBox.Size = New System.Drawing.Size(120, 22)
        Me.phoneNumTextBox.TabIndex = 22
        '
        'nifTextBox
        '
        Me.nifTextBox.Enabled = False
        Me.nifTextBox.Location = New System.Drawing.Point(39, 141)
        Me.nifTextBox.Name = "nifTextBox"
        Me.nifTextBox.Size = New System.Drawing.Size(118, 22)
        Me.nifTextBox.TabIndex = 23
        '
        'LnameTextBox
        '
        Me.LnameTextBox.Location = New System.Drawing.Point(212, 62)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(120, 22)
        Me.LnameTextBox.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 17)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(36, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "NIF"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(209, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 17)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Phone Number"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(36, 367)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 17)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(36, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 17)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Address"
        '
        'updatebtn
        '
        Me.updatebtn.Location = New System.Drawing.Point(145, 439)
        Me.updatebtn.Name = "updatebtn"
        Me.updatebtn.Size = New System.Drawing.Size(89, 36)
        Me.updatebtn.TabIndex = 30
        Me.updatebtn.Text = "Update"
        Me.updatebtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(479, 177)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Gastos totais:"
        '
        'totalGastosText
        '
        Me.totalGastosText.AutoSize = True
        Me.totalGastosText.Location = New System.Drawing.Point(654, 177)
        Me.totalGastosText.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalGastosText.Name = "totalGastosText"
        Me.totalGastosText.Size = New System.Drawing.Size(0, 17)
        Me.totalGastosText.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(512, 439)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 17)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Room Type"
        '
        'RoomTypeBox
        '
        Me.RoomTypeBox.FormattingEnabled = True
        Me.RoomTypeBox.Location = New System.Drawing.Point(515, 459)
        Me.RoomTypeBox.Name = "RoomTypeBox"
        Me.RoomTypeBox.Size = New System.Drawing.Size(249, 24)
        Me.RoomTypeBox.TabIndex = 36
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(515, 404)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(249, 22)
        Me.DateTimePicker2.TabIndex = 35
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(515, 362)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(249, 22)
        Me.DateTimePicker1.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(512, 342)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 17)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "Book a room"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(582, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(120, 32)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Book"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AccTextBox
        '
        Me.AccTextBox.Enabled = False
        Me.AccTextBox.Location = New System.Drawing.Point(38, 300)
        Me.AccTextBox.Name = "AccTextBox"
        Me.AccTextBox.Size = New System.Drawing.Size(153, 22)
        Me.AccTextBox.TabIndex = 39
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(35, 280)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 17)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Account Record nº"
        '
        'CustLogged
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(841, 564)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.AccTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.RoomTypeBox)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.totalGastosText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.updatebtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LnameTextBox)
        Me.Controls.Add(Me.nifTextBox)
        Me.Controls.Add(Me.phoneNumTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(Me.GastosListView)
        Me.Controls.Add(Me.CheckBookingsListView)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "CustLogged"
        Me.Text = "CustLogged"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckBookingsListView As ListView
    Friend WithEvents GastosListView As ListView
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents phoneNumTextBox As TextBox
    Friend WithEvents nifTextBox As TextBox
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents updatebtn As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents totalGastosText As Label
    Friend WithEvents Name As ColumnHeader
    Friend WithEvents Price As ColumnHeader
    Friend WithEvents Label10 As Label
    Friend WithEvents RoomTypeBox As ComboBox
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents AccTextBox As TextBox
    Friend WithEvents Label12 As Label
End Class
