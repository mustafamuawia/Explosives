<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheck
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents chkAll As System.Windows.Forms.CheckBox
	Public WithEvents cmbCnditionFile As System.Windows.Forms.ComboBox
	Public WithEvents List1 As System.Windows.Forms.CheckedListBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdOK As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents Timer3 As System.Windows.Forms.Timer
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.chkAll = New System.Windows.Forms.CheckBox()
        Me.cmbCnditionFile = New System.Windows.Forms.ComboBox()
        Me.PermissionNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.List1 = New System.Windows.Forms.CheckedListBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdOK = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConditionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConditionsTableAdapter = New Explosives.dsExplosivesTableAdapters.ConditionsTableAdapter()
        Me.PermissionNamesTableAdapter = New Explosives.dsExplosivesTableAdapters.PermissionNamesTableAdapter()
        CType(Me.PermissionNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkAll
        '
        Me.chkAll.BackColor = System.Drawing.SystemColors.Control
        Me.chkAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.chkAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.chkAll.Location = New System.Drawing.Point(408, 72)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkAll.Size = New System.Drawing.Size(13, 13)
        Me.chkAll.TabIndex = 5
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'cmbCnditionFile
        '
        Me.cmbCnditionFile.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCnditionFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCnditionFile.DataSource = Me.PermissionNamesBindingSource
        Me.cmbCnditionFile.DisplayMember = "PermissionName"
        Me.cmbCnditionFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCnditionFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCnditionFile.Location = New System.Drawing.Point(24, 40)
        Me.cmbCnditionFile.Name = "cmbCnditionFile"
        Me.cmbCnditionFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCnditionFile.Size = New System.Drawing.Size(401, 21)
        Me.cmbCnditionFile.TabIndex = 4
        Me.cmbCnditionFile.ValueMember = "PermissionNameID"
        '
        'PermissionNamesBindingSource
        '
        Me.PermissionNamesBindingSource.DataMember = "PermissionNames"
        Me.PermissionNamesBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'List1
        '
        Me.List1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.Location = New System.Drawing.Point(24, 100)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.List1.Size = New System.Drawing.Size(401, 484)
        Me.List1.TabIndex = 2
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'cmdOK
        '
        Me.cmdOK.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdOK.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOK.ForeColor = System.Drawing.Color.White
        Me.cmdOK.Location = New System.Drawing.Point(128, 64)
        Me.cmdOK.Name = "cmdOK"
        Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOK.Size = New System.Drawing.Size(97, 33)
        Me.cmdOK.TabIndex = 1
        Me.cmdOK.Text = "„Ê«›ﬁ"
        Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOK.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.Color.White
        Me.cmdCancel.Location = New System.Drawing.Point(24, 64)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCancel.Size = New System.Drawing.Size(97, 33)
        Me.cmdCancel.TabIndex = 0
        Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer3
        '
        Me.Timer3.Enabled = True
        Me.Timer3.Interval = 1
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.Control
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(304, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(121, 25)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "      ’ÕÌÕ «·ﬂ·"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(232, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(185, 25)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "«· Õﬁﬁ „‰ ‘—Êÿ ≈÷«›…  :"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'ConditionsBindingSource
        '
        Me.ConditionsBindingSource.DataMember = "Conditions"
        Me.ConditionsBindingSource.DataSource = Me.DsExplosives
        '
        'ConditionsTableAdapter
        '
        Me.ConditionsTableAdapter.ClearBeforeFill = True
        '
        'PermissionNamesTableAdapter
        '
        Me.PermissionNamesTableAdapter.ClearBeforeFill = True
        '
        'frmCheck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(452, 605)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.cmbCnditionFile)
        Me.Controls.Add(Me.List1)
        Me.Controls.Add(Me.cmdOK)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheck"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PermissionNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents ConditionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConditionsTableAdapter As Explosives.dsExplosivesTableAdapters.ConditionsTableAdapter
    Friend WithEvents PermissionNamesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PermissionNamesTableAdapter As Explosives.dsExplosivesTableAdapters.PermissionNamesTableAdapter
#End Region
End Class