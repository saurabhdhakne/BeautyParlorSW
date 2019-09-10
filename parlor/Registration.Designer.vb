<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.user = New System.Windows.Forms.TextBox()
        Me.contact = New System.Windows.Forms.TextBox()
        Me.age = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'user
        '
        Me.user.Location = New System.Drawing.Point(543, 268)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(524, 20)
        Me.user.TabIndex = 0
        '
        'contact
        '
        Me.contact.Location = New System.Drawing.Point(543, 349)
        Me.contact.Name = "contact"
        Me.contact.Size = New System.Drawing.Size(524, 20)
        Me.contact.TabIndex = 1
        '
        'age
        '
        Me.age.Location = New System.Drawing.Point(543, 428)
        Me.age.Name = "age"
        Me.age.Size = New System.Drawing.Size(112, 20)
        Me.age.TabIndex = 2
        '
        'address
        '
        Me.address.Location = New System.Drawing.Point(543, 511)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(524, 20)
        Me.address.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(391, 605)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Register"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(856, 605)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 46)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Reset"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.age)
        Me.Controls.Add(Me.contact)
        Me.Controls.Add(Me.user)
        Me.Name = "Registration"
        Me.Text = "Registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents user As System.Windows.Forms.TextBox
    Friend WithEvents contact As System.Windows.Forms.TextBox
    Friend WithEvents age As System.Windows.Forms.TextBox
    Friend WithEvents address As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
