<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchPassPermission
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
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassPermissionNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENDERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLACEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LICENSEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENDERADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POINT3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOSTOREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOREIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FFROMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.STOREDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AMMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UNITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RANKDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.POSITIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FINANCEIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FYEARDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PURPOSEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WORKPERMISSIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.PERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.PassPermissionNo, Me.SENDERDataGridViewTextBoxColumn, Me.RECEIVERDataGridViewTextBoxColumn, Me.FDATEDataGridViewTextBoxColumn, Me.FIDDataGridViewTextBoxColumn, Me.PLACEDataGridViewTextBoxColumn, Me.LICENSEIDDataGridViewTextBoxColumn, Me.SENDERADDRESSDataGridViewTextBoxColumn, Me.RECEIVERADDRESSDataGridViewTextBoxColumn, Me.POINT1DataGridViewTextBoxColumn, Me.POINT2DataGridViewTextBoxColumn, Me.POINT3DataGridViewTextBoxColumn, Me.TRANSPORTEDBYDataGridViewTextBoxColumn, Me.TOSTOREDataGridViewTextBoxColumn, Me.STOREIDDataGridViewTextBoxColumn, Me.FFROMDataGridViewTextBoxColumn, Me.FTODataGridViewTextBoxColumn, Me.STOREDATEDataGridViewTextBoxColumn, Me.CLASSDataGridViewTextBoxColumn, Me.AMMOUNTDataGridViewTextBoxColumn, Me.UNITDataGridViewTextBoxColumn, Me.RANKDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.POSITIONDataGridViewTextBoxColumn, Me.FINANCEIDDataGridViewTextBoxColumn, Me.FYEARDataGridViewTextBoxColumn, Me.PURPOSEDataGridViewTextBoxColumn, Me.WORKPERMISSIONDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PERMISSIONSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(11, 122)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(861, 311)
        Me.DataGridView1.TabIndex = 5
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.IDDataGridViewTextBoxColumn.HeaderText = "التسلسلي"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PassPermissionNo
        '
        Me.PassPermissionNo.DataPropertyName = "PassPermissionNo"
        Me.PassPermissionNo.FillWeight = 50.0!
        Me.PassPermissionNo.HeaderText = "نمرة تصريح المرور"
        Me.PassPermissionNo.Name = "PassPermissionNo"
        Me.PassPermissionNo.ReadOnly = True
        '
        'SENDERDataGridViewTextBoxColumn
        '
        Me.SENDERDataGridViewTextBoxColumn.DataPropertyName = "SENDER"
        Me.SENDERDataGridViewTextBoxColumn.HeaderText = "الجهة الصارفة"
        Me.SENDERDataGridViewTextBoxColumn.Name = "SENDERDataGridViewTextBoxColumn"
        Me.SENDERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RECEIVERDataGridViewTextBoxColumn
        '
        Me.RECEIVERDataGridViewTextBoxColumn.DataPropertyName = "RECEIVER"
        Me.RECEIVERDataGridViewTextBoxColumn.HeaderText = "الجهة المستلمة"
        Me.RECEIVERDataGridViewTextBoxColumn.Name = "RECEIVERDataGridViewTextBoxColumn"
        Me.RECEIVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FDATEDataGridViewTextBoxColumn
        '
        Me.FDATEDataGridViewTextBoxColumn.DataPropertyName = "FDATE"
        Me.FDATEDataGridViewTextBoxColumn.HeaderText = "التاريخ"
        Me.FDATEDataGridViewTextBoxColumn.Name = "FDATEDataGridViewTextBoxColumn"
        Me.FDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FIDDataGridViewTextBoxColumn
        '
        Me.FIDDataGridViewTextBoxColumn.DataPropertyName = "FID"
        Me.FIDDataGridViewTextBoxColumn.HeaderText = "FID"
        Me.FIDDataGridViewTextBoxColumn.Name = "FIDDataGridViewTextBoxColumn"
        Me.FIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FIDDataGridViewTextBoxColumn.Visible = False
        '
        'PLACEDataGridViewTextBoxColumn
        '
        Me.PLACEDataGridViewTextBoxColumn.DataPropertyName = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn.HeaderText = "PLACE"
        Me.PLACEDataGridViewTextBoxColumn.Name = "PLACEDataGridViewTextBoxColumn"
        Me.PLACEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PLACEDataGridViewTextBoxColumn.Visible = False
        '
        'LICENSEIDDataGridViewTextBoxColumn
        '
        Me.LICENSEIDDataGridViewTextBoxColumn.DataPropertyName = "LICENSEID"
        Me.LICENSEIDDataGridViewTextBoxColumn.HeaderText = "LICENSEID"
        Me.LICENSEIDDataGridViewTextBoxColumn.Name = "LICENSEIDDataGridViewTextBoxColumn"
        Me.LICENSEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.LICENSEIDDataGridViewTextBoxColumn.Visible = False
        '
        'SENDERADDRESSDataGridViewTextBoxColumn
        '
        Me.SENDERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "SENDERADDRESS"
        Me.SENDERADDRESSDataGridViewTextBoxColumn.HeaderText = "SENDERADDRESS"
        Me.SENDERADDRESSDataGridViewTextBoxColumn.Name = "SENDERADDRESSDataGridViewTextBoxColumn"
        Me.SENDERADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.SENDERADDRESSDataGridViewTextBoxColumn.Visible = False
        '
        'RECEIVERADDRESSDataGridViewTextBoxColumn
        '
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn.DataPropertyName = "RECEIVERADDRESS"
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn.HeaderText = "RECEIVERADDRESS"
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn.Name = "RECEIVERADDRESSDataGridViewTextBoxColumn"
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn.ReadOnly = True
        Me.RECEIVERADDRESSDataGridViewTextBoxColumn.Visible = False
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
        'TRANSPORTEDBYDataGridViewTextBoxColumn
        '
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn.DataPropertyName = "TRANSPORTEDBY"
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn.HeaderText = "TRANSPORTEDBY"
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn.Name = "TRANSPORTEDBYDataGridViewTextBoxColumn"
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn.ReadOnly = True
        Me.TRANSPORTEDBYDataGridViewTextBoxColumn.Visible = False
        '
        'TOSTOREDataGridViewTextBoxColumn
        '
        Me.TOSTOREDataGridViewTextBoxColumn.DataPropertyName = "TOSTORE"
        Me.TOSTOREDataGridViewTextBoxColumn.HeaderText = "TOSTORE"
        Me.TOSTOREDataGridViewTextBoxColumn.Name = "TOSTOREDataGridViewTextBoxColumn"
        Me.TOSTOREDataGridViewTextBoxColumn.ReadOnly = True
        Me.TOSTOREDataGridViewTextBoxColumn.Visible = False
        '
        'STOREIDDataGridViewTextBoxColumn
        '
        Me.STOREIDDataGridViewTextBoxColumn.DataPropertyName = "STOREID"
        Me.STOREIDDataGridViewTextBoxColumn.HeaderText = "STOREID"
        Me.STOREIDDataGridViewTextBoxColumn.Name = "STOREIDDataGridViewTextBoxColumn"
        Me.STOREIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.STOREIDDataGridViewTextBoxColumn.Visible = False
        '
        'FFROMDataGridViewTextBoxColumn
        '
        Me.FFROMDataGridViewTextBoxColumn.DataPropertyName = "FFROM"
        Me.FFROMDataGridViewTextBoxColumn.HeaderText = "FFROM"
        Me.FFROMDataGridViewTextBoxColumn.Name = "FFROMDataGridViewTextBoxColumn"
        Me.FFROMDataGridViewTextBoxColumn.ReadOnly = True
        Me.FFROMDataGridViewTextBoxColumn.Visible = False
        '
        'FTODataGridViewTextBoxColumn
        '
        Me.FTODataGridViewTextBoxColumn.DataPropertyName = "FTO"
        Me.FTODataGridViewTextBoxColumn.HeaderText = "FTO"
        Me.FTODataGridViewTextBoxColumn.Name = "FTODataGridViewTextBoxColumn"
        Me.FTODataGridViewTextBoxColumn.ReadOnly = True
        Me.FTODataGridViewTextBoxColumn.Visible = False
        '
        'STOREDATEDataGridViewTextBoxColumn
        '
        Me.STOREDATEDataGridViewTextBoxColumn.DataPropertyName = "STOREDATE"
        Me.STOREDATEDataGridViewTextBoxColumn.HeaderText = "STOREDATE"
        Me.STOREDATEDataGridViewTextBoxColumn.Name = "STOREDATEDataGridViewTextBoxColumn"
        Me.STOREDATEDataGridViewTextBoxColumn.ReadOnly = True
        Me.STOREDATEDataGridViewTextBoxColumn.Visible = False
        '
        'CLASSDataGridViewTextBoxColumn
        '
        Me.CLASSDataGridViewTextBoxColumn.DataPropertyName = "CLASS"
        Me.CLASSDataGridViewTextBoxColumn.HeaderText = "CLASS"
        Me.CLASSDataGridViewTextBoxColumn.Name = "CLASSDataGridViewTextBoxColumn"
        Me.CLASSDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLASSDataGridViewTextBoxColumn.Visible = False
        '
        'AMMOUNTDataGridViewTextBoxColumn
        '
        Me.AMMOUNTDataGridViewTextBoxColumn.DataPropertyName = "AMMOUNT"
        Me.AMMOUNTDataGridViewTextBoxColumn.HeaderText = "AMMOUNT"
        Me.AMMOUNTDataGridViewTextBoxColumn.Name = "AMMOUNTDataGridViewTextBoxColumn"
        Me.AMMOUNTDataGridViewTextBoxColumn.ReadOnly = True
        Me.AMMOUNTDataGridViewTextBoxColumn.Visible = False
        '
        'UNITDataGridViewTextBoxColumn
        '
        Me.UNITDataGridViewTextBoxColumn.DataPropertyName = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.HeaderText = "UNIT"
        Me.UNITDataGridViewTextBoxColumn.Name = "UNITDataGridViewTextBoxColumn"
        Me.UNITDataGridViewTextBoxColumn.ReadOnly = True
        Me.UNITDataGridViewTextBoxColumn.Visible = False
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
        'FINANCEIDDataGridViewTextBoxColumn
        '
        Me.FINANCEIDDataGridViewTextBoxColumn.DataPropertyName = "FINANCEID"
        Me.FINANCEIDDataGridViewTextBoxColumn.HeaderText = "FINANCEID"
        Me.FINANCEIDDataGridViewTextBoxColumn.Name = "FINANCEIDDataGridViewTextBoxColumn"
        Me.FINANCEIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.FINANCEIDDataGridViewTextBoxColumn.Visible = False
        '
        'FYEARDataGridViewTextBoxColumn
        '
        Me.FYEARDataGridViewTextBoxColumn.DataPropertyName = "FYEAR"
        Me.FYEARDataGridViewTextBoxColumn.HeaderText = "FYEAR"
        Me.FYEARDataGridViewTextBoxColumn.Name = "FYEARDataGridViewTextBoxColumn"
        Me.FYEARDataGridViewTextBoxColumn.ReadOnly = True
        Me.FYEARDataGridViewTextBoxColumn.Visible = False
        '
        'PURPOSEDataGridViewTextBoxColumn
        '
        Me.PURPOSEDataGridViewTextBoxColumn.DataPropertyName = "PURPOSE"
        Me.PURPOSEDataGridViewTextBoxColumn.HeaderText = "PURPOSE"
        Me.PURPOSEDataGridViewTextBoxColumn.Name = "PURPOSEDataGridViewTextBoxColumn"
        Me.PURPOSEDataGridViewTextBoxColumn.ReadOnly = True
        Me.PURPOSEDataGridViewTextBoxColumn.Visible = False
        '
        'WORKPERMISSIONDataGridViewTextBoxColumn
        '
        Me.WORKPERMISSIONDataGridViewTextBoxColumn.DataPropertyName = "WORKPERMISSION"
        Me.WORKPERMISSIONDataGridViewTextBoxColumn.HeaderText = "WORKPERMISSION"
        Me.WORKPERMISSIONDataGridViewTextBoxColumn.Name = "WORKPERMISSIONDataGridViewTextBoxColumn"
        Me.WORKPERMISSIONDataGridViewTextBoxColumn.ReadOnly = True
        Me.WORKPERMISSIONDataGridViewTextBoxColumn.Visible = False
        '
        'PERMISSIONSBindingSource
        '
        Me.PERMISSIONSBindingSource.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERMISSIONSTableAdapter
        '
        Me.PERMISSIONSTableAdapter.ClearBeforeFill = True
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
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(539, 75)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.RightToLeftLayout = True
        Me.DateTimePicker2.Size = New System.Drawing.Size(155, 27)
        Me.DateTimePicker2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(712, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "التاريخ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(535, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "بحث بـــــ"
        '
        'frmSearchPassPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(884, 503)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmSearchPassPermission"
        Me.Text = "بحث تصاريح المرور"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents PERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PassPermissionNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SENDERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PLACEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LICENSEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SENDERADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RECEIVERADDRESSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POINT3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRANSPORTEDBYDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TOSTOREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOREIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FFROMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents STOREDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AMMOUNTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UNITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RANKDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents POSITIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FINANCEIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FYEARDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PURPOSEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WORKPERMISSIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
