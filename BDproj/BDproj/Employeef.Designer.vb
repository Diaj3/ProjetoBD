<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employf
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
        Me.LogginBut = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogginBut
        '
        Me.LogginBut.Location = New System.Drawing.Point(531, 74)
        Me.LogginBut.Margin = New System.Windows.Forms.Padding(4)
        Me.LogginBut.Name = "LogginBut"
        Me.LogginBut.Size = New System.Drawing.Size(133, 28)
        Me.LogginBut.TabIndex = 13
        Me.LogginBut.Text = "Login"
        Me.LogginBut.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(464, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Staff_id:"
        '
        'LoginID
        '
        Me.LoginID.Location = New System.Drawing.Point(532, 44)
        Me.LoginID.Margin = New System.Windows.Forms.Padding(4)
        Me.LoginID.Name = "LoginID"
        Me.LoginID.Size = New System.Drawing.Size(132, 22)
        Me.LoginID.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 52)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Return"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(276, 52)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Employee View"
        '
        'Employf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(685, 128)
        Me.Controls.Add(Me.LogginBut)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LoginID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Employf"
        Me.Text = "Employf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LogginBut As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginID As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
End Class
