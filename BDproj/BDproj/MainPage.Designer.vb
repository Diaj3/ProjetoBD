<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainPage
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
        Me.buttonManager = New System.Windows.Forms.Button()
        Me.buttonCustomer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Employ = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'buttonManager
        '
        Me.buttonManager.Location = New System.Drawing.Point(13, 250)
        Me.buttonManager.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonManager.Name = "buttonManager"
        Me.buttonManager.Size = New System.Drawing.Size(236, 170)
        Me.buttonManager.TabIndex = 0
        Me.buttonManager.Text = "Manager"
        Me.buttonManager.UseVisualStyleBackColor = True
        '
        'buttonCustomer
        '
        Me.buttonCustomer.Location = New System.Drawing.Point(553, 250)
        Me.buttonCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.buttonCustomer.Name = "buttonCustomer"
        Me.buttonCustomer.Size = New System.Drawing.Size(236, 170)
        Me.buttonCustomer.TabIndex = 1
        Me.buttonCustomer.Text = "Customer"
        Me.buttonCustomer.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(276, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome"
        '
        'Employ
        '
        Me.Employ.Location = New System.Drawing.Point(285, 250)
        Me.Employ.Margin = New System.Windows.Forms.Padding(4)
        Me.Employ.Name = "Employ"
        Me.Employ.Size = New System.Drawing.Size(236, 170)
        Me.Employ.TabIndex = 3
        Me.Employ.Text = "Employee"
        Me.Employ.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 69)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "to"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(225, 147)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(364, 69)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "The Hotel App"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 433)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Employ)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.buttonCustomer)
        Me.Controls.Add(Me.buttonManager)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents buttonManager As Button
    Friend WithEvents buttonCustomer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Employ As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
