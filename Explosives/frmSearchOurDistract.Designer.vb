<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchOurDistract
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACCOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATIONRECDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONSIGNMENTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POLICYIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RANKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTSIGNATUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTADOPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECAUTHERITYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECRANKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECSIGNATUREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECADOPTIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DURATIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STATIONDISTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.INSTRUCTIONSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTRACTORDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OURDISTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OURDISTRACTTableAdapter = New Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ACCOUNTDataGridViewTextBoxColumn, Me.STATIONRECDataGridViewTextBoxColumn, Me.RECEIVERDataGridViewTextBoxColumn, Me.CONSIGNMENTDataGridViewTextBoxColumn, Me.DISTDATEDataGridViewTextBoxColumn, Me.POLICYIDDataGridViewTextBoxColumn, Me.NOTESDataGridViewTextBoxColumn, Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn, Me.RANKDataGridViewTextBoxColumn, Me.DISTSIGNATUREDataGridViewTextBoxColumn, Me.DISTADOPTIONDataGridViewTextBoxColumn, Me.RECAUTHERITYDataGridViewTextBoxColumn, Me.RECRANKDataGridViewTextBoxColumn, Me.RECNAMEDataGridViewTextBoxColumn, Me.DISTNAMEDataGridViewTextBoxColumn, Me.RECSIGNATUREDataGridViewTextBoxColumn, Me.RECADOPTIONDataGridViewTextBoxColumn, Me.DURATIONDataGridViewTextBoxColumn, Me.STATIONDISTDataGridViewTextBoxColumn, Me.INSTRUCTIONSDataGridViewTextBoxColumn, Me.DISTRACTORDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.OURDISTRACTBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 144)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(934, 292)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "نمرة مستند الصرف"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ACCOUNTDataGridViewTextBoxColumn
        '
        Me.ACCOUNTDataGridViewTextBoxColumn.DataPropertyName = "ACCOUNT"
        Me.ACCOUNTDataGridViewTextBoxColumn.HeaderText = "ACCOUNT"
        Me.ACCOUNTDataGridViewTextBoxColumn.Name = "ACCOUNTDataGridViewTextBoxColumn"
        Me.ACCOUNTDataGridViewTextBoxColumn.ReadOnly = True
        Me.ACCOUNTDataGridViewTextBoxColumn.Visible = False
        '
        'STATIONRECDataGridViewTextBoxColumn
        '
        Me.STATIONRECDataGridViewTextBoxColumn.DataPropertyName = "STATIONREC"
        Me.STATIONRECDataGridViewTextBoxColumn.HeaderText = "STATIONREC"
        Me.STATIONRECDataGridViewTextBoxColumn.Name = "STATIONRECDataGridViewTextBoxColumn"
        Me.STATIONRECDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATIONRECDataGridViewTextBoxColumn.Visible = False
        '
        'RECEIVERDataGridViewTextBoxColumn
        '
        Me.RECEIVERDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER"
        Me.RECEIVERDataGridViewTextBoxColumn.HeaderText = "الجهة المستلمة"
        Me.RECEIVERDataGridViewTextBoxColumn.Name = "RECEIVERDataGridViewTextBoxColumn"
        Me.RECEIVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONSIGNMENTDataGridViewTextBoxColumn
        '
        Me.CONSIGNMENTDataGridViewTextBoxColumn.DataPropertyName = "CONSIGNMENT"
        Me.CONSIGNMENTDataGridViewTextBoxColumn.HeaderText = "CONSIGNMENT"
        Me.CONSIGNMENTDataGridViewTextBoxColumn.Name = "CONSIGNMENTDataGridViewTextBoxColumn"
        Me.CONSIGNMENTDataGridViewTextBoxColumn.ReadOnly = True
        Me.CONSIGNMENTDataGridViewTextBoxColumn.Visible = False
        '
        'DISTDATEDataGridViewTextBoxColumn
        '
        Me.DISTDATEDataGridViewTextBoxColumn.DataPropertyName = "DISTDATE"
        Me.DISTDATEDataGridViewTextBoxColumn.HeaderText = "تاريخ مستند الصرف"
        Me.DISTDATEDataGridViewTextBoxColumn.Name = "DISTDATEDataGridViewTextBoxColumn"
        Me.DISTDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'POLICYIDDataGridViewTextBoxColumn
        '
        Me.POLICYIDDataGridViewTextBoxColumn.DataPropertyName = "POLICYID"
        Me.POLICYIDDataGridViewTextBoxColumn.HeaderText = "POLICYID"
        Me.POLICYIDDataGridViewTextBoxColumn.Name = "POLICYIDDataGridViewTextBoxColumn"
        Me.POLICYIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.POLICYIDDataGridViewTextBoxColumn.Visible = False
        '
        'NOTESDataGridViewTextBoxColumn
        '
        Me.NOTESDataGridViewTextBoxColumn.DataPropertyName = "NOTES"
        Me.NOTESDataGridViewTextBoxColumn.HeaderText = "NOTES"
        Me.NOTESDataGridViewTextBoxColumn.Name = "NOTESDataGridViewTextBoxColumn"
        Me.NOTESDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOTESDataGridViewTextBoxColumn.Visible = False
        '
        'DISTRACTAUTHERITYDataGridViewTextBoxColumn
        '
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn.DataPropertyName = "DISTRACTAUTHERITY"
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn.HeaderText = "DISTRACTAUTHERITY"
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn.Name = "DISTRACTAUTHERITYDataGridViewTextBoxColumn"
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.DISTRACTAUTHERITYDataGridViewTextBoxColumn.Visible = False
        '
        'RANKDataGridViewTextBoxColumn
        '
        Me.RANKDataGridViewTextBoxColumn.DataPropertyName = "RANK"
        Me.RANKDataGridViewTextBoxColumn.HeaderText = "RANK"
        Me.RANKDataGridViewTextBoxColumn.Name = "RANKDataGridViewTextBoxColumn"
        Me.RANKDataGridViewTextBoxColumn.ReadOnly = True
        Me.RANKDataGridViewTextBoxColumn.Visible = False
        '
        'DISTSIGNATUREDataGridViewTextBoxColumn
        '
        Me.DISTSIGNATUREDataGridViewTextBoxColumn.DataPropertyName = "DISTSIGNATURE"
        Me.DISTSIGNATUREDataGridViewTextBoxColumn.HeaderText = "DISTSIGNATURE"
        Me.DISTSIGNATUREDataGridViewTextBoxColumn.Name = "DISTSIGNATUREDataGridViewTextBoxColumn"
        Me.DISTSIGNATUREDataGridViewTextBoxColumn.ReadOnly = True
        Me.DISTSIGNATUREDataGridViewTextBoxColumn.Visible = False
        '
        'DISTADOPTIONDataGridViewTextBoxColumn
        '
        Me.DISTADOPTIONDataGridViewTextBoxColumn.DataPropertyName = "DISTADOPTION"
        Me.DISTADOPTIONDataGridViewTextBoxColumn.HeaderText = "DISTADOPTION"
        Me.DISTADOPTIONDataGridViewTextBoxColumn.Name = "DISTADOPTIONDataGridViewTextBoxColumn"
        Me.DISTADOPTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DISTADOPTIONDataGridViewTextBoxColumn.Visible = False
        '
        'RECAUTHERITYDataGridViewTextBoxColumn
        '
        Me.RECAUTHERITYDataGridViewTextBoxColumn.DataPropertyName = "RECAUTHERITY"
        Me.RECAUTHERITYDataGridViewTextBoxColumn.HeaderText = "RECAUTHERITY"
        Me.RECAUTHERITYDataGridViewTextBoxColumn.Name = "RECAUTHERITYDataGridViewTextBoxColumn"
        Me.RECAUTHERITYDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECAUTHERITYDataGridViewTextBoxColumn.Visible = False
        '
        'RECRANKDataGridViewTextBoxColumn
        '
        Me.RECRANKDataGridViewTextBoxColumn.DataPropertyName = "RECRANK"
        Me.RECRANKDataGridViewTextBoxColumn.HeaderText = "RECRANK"
        Me.RECRANKDataGridViewTextBoxColumn.Name = "RECRANKDataGridViewTextBoxColumn"
        Me.RECRANKDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECRANKDataGridViewTextBoxColumn.Visible = False
        '
        'RECNAMEDataGridViewTextBoxColumn
        '
        Me.RECNAMEDataGridViewTextBoxColumn.DataPropertyName = "RECNAME"
        Me.RECNAMEDataGridViewTextBoxColumn.HeaderText = "RECNAME"
        Me.RECNAMEDataGridViewTextBoxColumn.Name = "RECNAMEDataGridViewTextBoxColumn"
        Me.RECNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'DISTNAMEDataGridViewTextBoxColumn
        '
        Me.DISTNAMEDataGridViewTextBoxColumn.DataPropertyName = "DISTNAME"
        Me.DISTNAMEDataGridViewTextBoxColumn.HeaderText = "DISTNAME"
        Me.DISTNAMEDataGridViewTextBoxColumn.Name = "DISTNAMEDataGridViewTextBoxColumn"
        Me.DISTNAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.DISTNAMEDataGridViewTextBoxColumn.Visible = False
        '
        'RECSIGNATUREDataGridViewTextBoxColumn
        '
        Me.RECSIGNATUREDataGridViewTextBoxColumn.DataPropertyName = "RECSIGNATURE"
        Me.RECSIGNATUREDataGridViewTextBoxColumn.HeaderText = "RECSIGNATURE"
        Me.RECSIGNATUREDataGridViewTextBoxColumn.Name = "RECSIGNATUREDataGridViewTextBoxColumn"
        Me.RECSIGNATUREDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECSIGNATUREDataGridViewTextBoxColumn.Visible = False
        '
        'RECADOPTIONDataGridViewTextBoxColumn
        '
        Me.RECADOPTIONDataGridViewTextBoxColumn.DataPropertyName = "RECADOPTION"
        Me.RECADOPTIONDataGridViewTextBoxColumn.HeaderText = "RECADOPTION"
        Me.RECADOPTIONDataGridViewTextBoxColumn.Name = "RECADOPTIONDataGridViewTextBoxColumn"
        Me.RECADOPTIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECADOPTIONDataGridViewTextBoxColumn.Visible = False
        '
        'DURATIONDataGridViewTextBoxColumn
        '
        Me.DURATIONDataGridViewTextBoxColumn.DataPropertyName = "DURATION"
        Me.DURATIONDataGridViewTextBoxColumn.HeaderText = "DURATION"
        Me.DURATIONDataGridViewTextBoxColumn.Name = "DURATIONDataGridViewTextBoxColumn"
        Me.DURATIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.DURATIONDataGridViewTextBoxColumn.Visible = False
        '
        'STATIONDISTDataGridViewTextBoxColumn
        '
        Me.STATIONDISTDataGridViewTextBoxColumn.DataPropertyName = "STATIONDIST"
        Me.STATIONDISTDataGridViewTextBoxColumn.HeaderText = "STATIONDIST"
        Me.STATIONDISTDataGridViewTextBoxColumn.Name = "STATIONDISTDataGridViewTextBoxColumn"
        Me.STATIONDISTDataGridViewTextBoxColumn.ReadOnly = True
        Me.STATIONDISTDataGridViewTextBoxColumn.Visible = False
        '
        'INSTRUCTIONSDataGridViewTextBoxColumn
        '
        Me.INSTRUCTIONSDataGridViewTextBoxColumn.DataPropertyName = "INSTRUCTIONS"
        Me.INSTRUCTIONSDataGridViewTextBoxColumn.HeaderText = "INSTRUCTIONS"
        Me.INSTRUCTIONSDataGridViewTextBoxColumn.Name = "INSTRUCTIONSDataGridViewTextBoxColumn"
        Me.INSTRUCTIONSDataGridViewTextBoxColumn.ReadOnly = True
        Me.INSTRUCTIONSDataGridViewTextBoxColumn.Visible = False
        '
        'DISTRACTORDataGridViewTextBoxColumn
        '
        Me.DISTRACTORDataGridViewTextBoxColumn.DataPropertyName = "DISTRACTOR"
        Me.DISTRACTORDataGridViewTextBoxColumn.HeaderText = "الجهة الصارفة"
        Me.DISTRACTORDataGridViewTextBoxColumn.Name = "DISTRACTORDataGridViewTextBoxColumn"
        Me.DISTRACTORDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OURDISTRACTBindingSource
        '
        Me.OURDISTRACTBindingSource.DataMember = "OURDISTRACT"
        Me.OURDISTRACTBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(245, 45)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(301, 27)
        Me.txtSearch.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(749, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "بحث بـــــ"
        '
        'OURDISTRACTTableAdapter
        '
        Me.OURDISTRACTTableAdapter.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"الجهة المستلمة", "الجهة الصارفة", "رقم مستند الصرف"})
        Me.ComboBox1.Location = New System.Drawing.Point(576, 45)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(155, 27)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Text = "الجهة المستلمة"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(572, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "بحث بـــــ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(749, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "التاريخ"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(576, 94)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(155, 27)
        Me.DateTimePicker2.TabIndex = 5
        '
        'frmSearchOurDistract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(970, 448)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearchOurDistract"
        Me.Text = "بحث سندات صرف"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents OURDISTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OURDISTRACTTableAdapter As Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ACCOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATIONRECDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONSIGNMENTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POLICYIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTESDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTRACTAUTHERITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RANKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTSIGNATUREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTADOPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECAUTHERITYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECRANKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTNAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECSIGNATUREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECADOPTIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DURATIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STATIONDISTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents INSTRUCTIONSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTRACTORDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
End Class
