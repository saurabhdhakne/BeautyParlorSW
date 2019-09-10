<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim Label5 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Database1DataSet3 = New parlor.Database1DataSet3()
        Me.CustomersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter = New parlor.Database1DataSet3TableAdapters.CustomersTableAdapter()
        Me.username = New System.Windows.Forms.ListBox()
        Me.CustomersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet1 = New parlor.Database1DataSet1()
        Me.Database1DataSet4 = New parlor.Database1DataSet4()
        Me.CustomersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersTableAdapter1 = New parlor.Database1DataSet4TableAdapters.CustomersTableAdapter()
        Me.CustomersTableAdapter2 = New parlor.Database1DataSet1TableAdapters.CustomersTableAdapter()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Database1DataSet5 = New parlor.Database1DataSet5()
        Me.Database1DataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicesTableAdapter = New parlor.Database1DataSet5TableAdapters.ServicesTableAdapter()
        Me.print = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.rate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.total = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Label5 = New System.Windows.Forms.Label()
        CType(Me.Database1DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.BackColor = System.Drawing.Color.Transparent
        Label5.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Label5.Location = New System.Drawing.Point(1165, 161)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(161, 50)
        Label5.TabIndex = 4
        Label5.Text = "Admin"
        AddHandler Label5.Click, AddressOf Me.Label5_Click
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(108, 323)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Services"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(118, 491)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 48)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "About"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(108, 407)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(169, 48)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Gallery"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(108, 580)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(182, 48)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Register"
        '
        'Database1DataSet3
        '
        Me.Database1DataSet3.DataSetName = "Database1DataSet3"
        Me.Database1DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource
        '
        Me.CustomersBindingSource.DataMember = "Customers"
        Me.CustomersBindingSource.DataSource = Me.Database1DataSet3
        '
        'CustomersTableAdapter
        '
        Me.CustomersTableAdapter.ClearBeforeFill = True
        '
        'username
        '
        Me.username.DataSource = Me.CustomersBindingSource2
        Me.username.DisplayMember = "Username"
        Me.username.FormattingEnabled = True
        Me.username.Location = New System.Drawing.Point(976, 407)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(329, 147)
        Me.username.TabIndex = 5
        '
        'CustomersBindingSource2
        '
        Me.CustomersBindingSource2.DataMember = "Customers"
        Me.CustomersBindingSource2.DataSource = Me.Database1DataSet1
        '
        'Database1DataSet1
        '
        Me.Database1DataSet1.DataSetName = "Database1DataSet1"
        Me.Database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet4
        '
        Me.Database1DataSet4.DataSetName = "Database1DataSet4"
        Me.Database1DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomersBindingSource1
        '
        Me.CustomersBindingSource1.DataMember = "Customers"
        Me.CustomersBindingSource1.DataSource = Me.Database1DataSet4
        '
        'CustomersTableAdapter1
        '
        Me.CustomersTableAdapter1.ClearBeforeFill = True
        '
        'CustomersTableAdapter2
        '
        Me.CustomersTableAdapter2.ClearBeforeFill = True
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.Database1DataSet5
        '
        'Database1DataSet5
        '
        Me.Database1DataSet5.DataSetName = "Database1DataSet5"
        Me.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Database1DataSet4BindingSource
        '
        Me.Database1DataSet4BindingSource.DataSource = Me.Database1DataSet4
        Me.Database1DataSet4BindingSource.Position = 0
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'print
        '
        Me.print.Location = New System.Drawing.Point(1144, 625)
        Me.print.Name = "print"
        Me.print.Size = New System.Drawing.Size(75, 23)
        Me.print.TabIndex = 7
        Me.print.Text = "Print"
        Me.print.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'rate
        '
        Me.rate.Location = New System.Drawing.Point(1021, 581)
        Me.rate.Name = "rate"
        Me.rate.Size = New System.Drawing.Size(117, 20)
        Me.rate.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(971, 580)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Rate"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1144, 581)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 20)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(970, 625)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 25)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total : "
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.BackColor = System.Drawing.Color.Transparent
        Me.total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.total.Location = New System.Drawing.Point(1054, 625)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(24, 25)
        Me.total.TabIndex = 12
        Me.total.Text = "0"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1230, 625)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1230, 580)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 20)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Sub"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.total)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rate)
        Me.Controls.Add(Me.print)
        Me.Controls.Add(Me.username)
        Me.Controls.Add(Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Database1DataSet3,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomersBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomersBindingSource2,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database1DataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database1DataSet4,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CustomersBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.ServicesBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database1DataSet5,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Database1DataSet4BindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Database1DataSet3 As parlor.Database1DataSet3
    Friend WithEvents CustomersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter As parlor.Database1DataSet3TableAdapters.CustomersTableAdapter
    Friend WithEvents username As System.Windows.Forms.ListBox
    Friend WithEvents Database1DataSet4 As parlor.Database1DataSet4
    Friend WithEvents CustomersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter1 As parlor.Database1DataSet4TableAdapters.CustomersTableAdapter
    Friend WithEvents Database1DataSet1 As parlor.Database1DataSet1
    Friend WithEvents CustomersBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomersTableAdapter2 As parlor.Database1DataSet1TableAdapters.CustomersTableAdapter
    Friend WithEvents Database1DataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Database1DataSet5 As parlor.Database1DataSet5
    Friend WithEvents ServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicesTableAdapter As parlor.Database1DataSet5TableAdapters.ServicesTableAdapter
    Friend WithEvents print As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents rate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
