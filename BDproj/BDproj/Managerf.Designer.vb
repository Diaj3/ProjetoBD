<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Managerf
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LoginID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Pass = New System.Windows.Forms.TextBox()
        Me.LogginBut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(242, 69)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Manager View"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 67)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LoginID
        '
        Me.LoginID.Location = New System.Drawing.Point(535, 31)
        Me.LoginID.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginID.Name = "LoginID"
        Me.LoginID.Size = New System.Drawing.Size(132, 22)
        Me.LoginID.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(465, 31)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Hotel ID:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(454, 64)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password:"
        '
        'Pass
        '
        Me.Pass.Location = New System.Drawing.Point(535, 64)
        Me.Pass.Margin = New System.Windows.Forms.Padding(4)
        Me.Pass.Name = "Pass"
        Me.Pass.Size = New System.Drawing.Size(132, 22)
        Me.Pass.TabIndex = 5
        Me.Pass.UseSystemPasswordChar = True
        '
        'LogginBut
        '
        Me.LogginBut.Location = New System.Drawing.Point(534, 111)
        Me.LogginBut.Margin = New System.Windows.Forms.Padding(4)
        Me.LogginBut.Name = "LogginBut"
        Me.LogginBut.Size = New System.Drawing.Size(133, 28)
        Me.LogginBut.TabIndex = 6
        Me.LogginBut.Text = "Login"
        Me.LogginBut.UseVisualStyleBackColor = True
        '
        'Managerf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(733, 164)
        Me.Controls.Add(Me.LogginBut)
        Me.Controls.Add(Me.Pass)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Managerf"
        Me.Text = "Manager login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LoginID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Pass As TextBox
    Friend WithEvents LogginBut As Button
End Class
