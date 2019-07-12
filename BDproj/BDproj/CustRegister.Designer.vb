<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustRegister
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LnameTextBox = New System.Windows.Forms.TextBox()
        Me.FnameTextBox = New System.Windows.Forms.TextBox()
        Me.nifTextBox = New System.Windows.Forms.TextBox()
        Me.phoneNumTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PassTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(241, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "NIF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(241, 238)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(340, 395)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 30)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LnameTextBox
        '
        Me.LnameTextBox.Location = New System.Drawing.Point(407, 75)
        Me.LnameTextBox.Name = "LnameTextBox"
        Me.LnameTextBox.Size = New System.Drawing.Size(123, 22)
        Me.LnameTextBox.TabIndex = 0
        '
        'FnameTextBox
        '
        Me.FnameTextBox.Location = New System.Drawing.Point(244, 75)
        Me.FnameTextBox.Name = "FnameTextBox"
        Me.FnameTextBox.Size = New System.Drawing.Size(123, 22)
        Me.FnameTextBox.TabIndex = 1
        '
        'nifTextBox
        '
        Me.nifTextBox.Location = New System.Drawing.Point(244, 166)
        Me.nifTextBox.Name = "nifTextBox"
        Me.nifTextBox.Size = New System.Drawing.Size(123, 22)
        Me.nifTextBox.TabIndex = 2
        '
        'phoneNumTextBox
        '
        Me.phoneNumTextBox.Location = New System.Drawing.Point(407, 166)
        Me.phoneNumTextBox.Name = "phoneNumTextBox"
        Me.phoneNumTextBox.Size = New System.Drawing.Size(123, 22)
        Me.phoneNumTextBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(404, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name"
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(244, 258)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(123, 22)
        Me.AddressTextBox.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(404, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Password"
        '
        'PassTextBox
        '
        Me.PassTextBox.Location = New System.Drawing.Point(407, 258)
        Me.PassTextBox.Name = "PassTextBox"
        Me.PassTextBox.Size = New System.Drawing.Size(123, 22)
        Me.PassTextBox.TabIndex = 11
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(331, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 27)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Register"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CustRegister
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PassTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.phoneNumTextBox)
        Me.Controls.Add(Me.nifTextBox)
        Me.Controls.Add(Me.FnameTextBox)
        Me.Controls.Add(Me.LnameTextBox)
        Me.Name = "CustRegister"
        Me.Text = "CustRegister"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents LnameTextBox As TextBox
    Friend WithEvents FnameTextBox As TextBox
    Friend WithEvents nifTextBox As TextBox
    Friend WithEvents phoneNumTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents PassTextBox As TextBox
    Friend WithEvents Button1 As Button
End Class
