<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchImportPermission
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
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.IMPORTPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IMPORTPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportPermissionNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERMITTEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PORTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RANKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINANCEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"الجهة المستلمة", "الجهة الصارفة", "رقم مستند الصرف"})
        Me.ComboBox1.Location = New System.Drawing.Point(539, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ComboBox1.Size = New System.Drawing.Size(155, 27)
        Me.ComboBox1.TabIndex = 7
        Me.ComboBox1.Text = "الجهة المستلمة"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(208, 27)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(301, 27)
        Me.txtSearch.TabIndex = 6
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ImportPermissionNoDataGridViewTextBoxColumn, Me.PERMITTEDDataGridViewTextBoxColumn, Me.FDATEDataGridViewTextBoxColumn, Me.SIDDataGridViewTextBoxColumn, Me.SDATEDataGridViewTextBoxColumn, Me.CRAFTSMANSHIPDataGridViewTextBoxColumn, Me.ADDRESSDataGridViewTextBoxColumn, Me.PORTDataGridViewTextBoxColumn, Me.EXPLOSIVESIDDataGridViewTextBoxColumn, Me.POINT1DataGridViewTextBoxColumn, Me.POINT2DataGridViewTextBoxColumn, Me.POINT3DataGridViewTextBoxColumn, Me.RANKDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.POSITIONDataGridViewTextBoxColumn, Me.NOOBJECTIONIDDataGridViewTextBoxColumn, Me.FINANCEIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.IMPORTPERMISSIONSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(861, 344)
        Me.DataGridView1.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(386, 458)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(90, 33)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "الغاء"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IMPORTPERMISSIONSBindingSource
        '
        Me.IMPORTPERMISSIONSBindingSource.DataMember = "IMPORTPERMISSIONS"
        Me.IMPORTPERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'IMPORTPERMISSIONSTableAdapter
        '
        Me.IMPORTPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "التسلسلي"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImportPermissionNoDataGridViewTextBoxColumn
        '
        Me.ImportPermissionNoDataGridViewTextBoxColumn.DataPropertyName = "ImportPermissionNo"
        Me.ImportPermissionNoDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.ImportPermissionNoDataGridViewTextBoxColumn.HeaderText = "نمرة اذن الاستيراد"
        Me.ImportPermissionNoDataGridViewTextBoxColumn.Name = "ImportPermissionNoDataGridViewTextBoxColumn"
        Me.ImportPermissionNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PERMITTEDDataGridViewTextBoxColumn
        '
        Me.PERMITTEDDataGridViewTextBoxColumn.DataPropertyName = "PERMITTED"
        Me.PERMITTEDDataGridViewTextBoxColumn.FillWeight = 200.0!
        Me.PERMITTEDDataGridViewTextBoxColumn.HeaderText = "المستورد"
        Me.PERMITTEDDataGridViewTextBoxColumn.Name = "PERMITTEDDataGridViewTextBoxColumn"
        Me.PERMITTEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FDATEDataGridViewTextBoxColumn
        '
        Me.FDATEDataGridViewTextBoxColumn.DataPropertyName = "FDATE"
        Me.FDATEDataGridViewTextBoxColumn.HeaderText = "التاريخ"
        Me.FDATEDataGridViewTextBoxColumn.Name = "FDATEDataGridViewTextBoxColumn"
        Me.FDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "SID"
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "SID"
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        Me.SIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SIDDataGridViewTextBoxColumn.Visible = False
        '
        'SDATEDataGridViewTextBoxColumn
        '
        Me.SDATEDataGridViewTextBoxColumn.DataPropertyName = "SDATE"
        Me.SDATEDataGridViewTextBoxColumn.HeaderText = "SDATE"
        Me.SDATEDataGridViewTextBoxColumn.Name = "SDATEDataGridViewTextBoxColumn"
        Me.SDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.SDATEDataGridViewTextBoxColumn.Visible = False
        '
        'CRAFTSMANSHIPDataGridViewTextBoxColumn
        '
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn.DataPropertyName = "CRAFTSMANSHIP"
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn.HeaderText = "CRAFTSMANSHIP"
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn.Name = "CRAFTSMANSHIPDataGridViewTextBoxColumn"
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn.ReadOnly = True
        Me.CRAFTSMANSHIPDataGridViewTextBoxColumn.Visible = False
        '
        'ADDRESSDataGridViewTextBoxColumn
        '
        Me.ADDRESSDataGridViewTextBoxColumn.DataPropertyName = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.HeaderText = "ADDRESS"
        Me.ADDRESSDataGridViewTextBoxColumn.Name = "ADDRESSDataGridViewTextBoxColumn"
        Me.ADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.ADDRESSDataGridViewTextBoxColumn.Visible = False
        '
        'PORTDataGridViewTextBoxColumn
        '
        Me.PORTDataGridViewTextBoxColumn.DataPropertyName = "PORT"
        Me.PORTDataGridViewTextBoxColumn.HeaderText = "PORT"
        Me.PORTDataGridViewTextBoxColumn.Name = "PORTDataGridViewTextBoxColumn"
        Me.PORTDataGridViewTextBoxColumn.ReadOnly = True
        Me.PORTDataGridViewTextBoxColumn.Visible = False
        '
        'EXPLOSIVESIDDataGridViewTextBoxColumn
        '
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn.DataPropertyName = "EXPLOSIVESID"
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn.HeaderText = "EXPLOSIVESID"
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn.Name = "EXPLOSIVESIDDataGridViewTextBoxColumn"
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EXPLOSIVESIDDataGridViewTextBoxColumn.Visible = False
        '
        'POINT1DataGridViewTextBoxColumn
        '
        Me.POINT1DataGridViewTextBoxColumn.DataPropertyName = "POINT1"
        Me.POINT1DataGridViewTextBoxColumn.HeaderText = "POINT1"
        Me.POINT1DataGridViewTextBoxColumn.Name = "POINT1DataGridViewTextBoxColumn"
        Me.POINT1DataGridViewTextBoxColumn.ReadOnly = True
        Me.POINT1DataGridViewTextBoxColumn.Visible = False
        '
        'POINT2DataGridViewTextBoxColumn
        '
        Me.POINT2DataGridViewTextBoxColumn.DataPropertyName = "POINT2"
        Me.POINT2DataGridViewTextBoxColumn.HeaderText = "POINT2"
        Me.POINT2DataGridViewTextBoxColumn.Name = "POINT2DataGridViewTextBoxColumn"
        Me.POINT2DataGridViewTextBoxColumn.ReadOnly = True
        Me.POINT2DataGridViewTextBoxColumn.Visible = False
        '
        'POINT3DataGridViewTextBoxColumn
        '
        Me.POINT3DataGridViewTextBoxColumn.DataPropertyName = "POINT3"
        Me.POINT3DataGridViewTextBoxColumn.HeaderText = "POINT3"
        Me.POINT3DataGridViewTextBoxColumn.Name = "POINT3DataGridViewTextBoxColumn"
        Me.POINT3DataGridViewTextBoxColumn.ReadOnly = True
        Me.POINT3DataGridViewTextBoxColumn.Visible = False
        '
        'RANKDataGridViewTextBoxColumn
        '
        Me.RANKDataGridViewTextBoxColumn.DataPropertyName = "RANK"
        Me.RANKDataGridViewTextBoxColumn.HeaderText = "RANK"
        Me.RANKDataGridViewTextBoxColumn.Name = "RANKDataGridViewTextBoxColumn"
        Me.RANKDataGridViewTextBoxColumn.ReadOnly = True
        Me.RANKDataGridViewTextBoxColumn.Visible = False
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        Me.NAMEDataGridViewTextBoxColumn.ReadOnly = True
        Me.NAMEDataGridViewTextBoxColumn.Visible = False
        '
        'POSITIONDataGridViewTextBoxColumn
        '
        Me.POSITIONDataGridViewTextBoxColumn.DataPropertyName = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.HeaderText = "POSITION"
        Me.POSITIONDataGridViewTextBoxColumn.Name = "POSITIONDataGridViewTextBoxColumn"
        Me.POSITIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.POSITIONDataGridViewTextBoxColumn.Visible = False
        '
        'NOOBJECTIONIDDataGridViewTextBoxColumn
        '
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn.DataPropertyName = "NOOBJECTIONID"
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn.HeaderText = "NOOBJECTIONID"
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn.Name = "NOOBJECTIONIDDataGridViewTextBoxColumn"
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.NOOBJECTIONIDDataGridViewTextBoxColumn.Visible = False
        '
        'FINANCEIDDataGridViewTextBoxColumn
        '
        Me.FINANCEIDDataGridViewTextBoxColumn.DataPropertyName = "FINANCEID"
        Me.FINANCEIDDataGridViewTextBoxColumn.HeaderText = "FINANCEID"
        Me.FINANCEIDDataGridViewTextBoxColumn.Name = "FINANCEIDDataGridViewTextBoxColumn"
        Me.FINANCEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FINANCEIDDataGridViewTextBoxColumn.Visible = False
        '
        'frmSearchImportPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 503)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearchImportPermission"
        Me.Text = "بحث تصاريح المرور"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents IMPORTPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPORTPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImportPermissionNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PERMITTEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CRAFTSMANSHIPDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PORTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EXPLOSIVESIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RANKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOOBJECTIONIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINANCEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
