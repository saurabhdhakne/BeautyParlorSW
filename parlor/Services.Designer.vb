<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Services
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Services))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Database1DataSet2 = New parlor.Database1DataSet2()
        Me.ServicesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicesTableAdapter = New parlor.Database1DataSet2TableAdapters.ServicesTableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ServiceDataGridViewTextBoxColumn, Me.RateDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ServicesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(508, 188)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(345, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Database1DataSet2
        '
        Me.Database1DataSet2.DataSetName = "Database1DataSet2"
        Me.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ServicesBindingSource
        '
        Me.ServicesBindingSource.DataMember = "Services"
        Me.ServicesBindingSource.DataSource = Me.Database1DataSet2
        '
        'ServicesTableAdapter
        '
        Me.ServicesTableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ServiceDataGridViewTextBoxColumn
        '
        Me.ServiceDataGridViewTextBoxColumn.DataPropertyName = "Service"
        Me.ServiceDataGridViewTextBoxColumn.HeaderText = "Service"
        Me.ServiceDataGridViewTextBoxColumn.Name = "ServiceDataGridViewTextBoxColumn"
        '
        'RateDataGridViewTextBoxColumn
        '
        Me.RateDataGridViewTextBoxColumn.DataPropertyName = "Rate"
        Me.RateDataGridViewTextBoxColumn.HeaderText = "Rate"
        Me.RateDataGridViewTextBoxColumn.Name = "RateDataGridViewTextBoxColumn"
        '
        'Services
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Services"
        Me.Text = "Services"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Database1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Database1DataSet2 As parlor.Database1DataSet2
    Friend WithEvents ServicesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ServicesTableAdapter As parlor.Database1DataSet2TableAdapters.ServicesTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ServiceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
