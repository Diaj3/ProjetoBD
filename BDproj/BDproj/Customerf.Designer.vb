<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customerf
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LogginBut = New System.Windows.Forms.Button()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LoginID = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 38)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 44)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Customer View"
        '
        'LogginBut
        '
        Me.LogginBut.Location = New System.Drawing.Point(524, 71)
        Me.LogginBut.Margin = New System.Windows.Forms.Padding(4)
        Me.LogginBut.Name = "LogginBut"
        Me.LogginBut.Size = New System.Drawing.Size(133, 28)
        Me.LogginBut.TabIndex = 11
        Me.LogginBut.Text = "Login"
        Me.LogginBut.UseVisualStyleBackColor = True
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(524, 44)
        Me.Pass.Margin = New System.Windows.Forms.Padding(4)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(132, 22)
        Me.Pass.TabIndex = 10
        Me.Pass.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(446, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Password:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(455, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Login ID:"
        '
        'LoginID
        '
        Me.LoginID.Location = New System.Drawing.Point(524, 12)
        Me.LoginID.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginID.Name = "LoginID"
        Me.LoginID.Size = New System.Drawing.Size(132, 22)
        Me.LoginID.TabIndex = 7
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(673, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 88)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Register"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Customerf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 112)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.LogginBut)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LoginID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Customerf"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LogginBut As Button
    Friend WithEvents Pass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LoginID As TextBox
    Friend WithEvents Button2 As Button
End Class
