<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmConditions
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
	Public WithEvents mnuColours As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdConditions As System.Windows.Forms.CheckBox
	Public WithEvents cmbCnditionFile As System.Windows.Forms.ComboBox
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
	Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdConditions = New System.Windows.Forms.CheckBox()
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbCnditionFile = New System.Windows.Forms.ComboBox()
        Me.PermissionNamesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.ConditionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.txtCondition = New System.Windows.Forms.TextBox()
        Me.ConditionsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives1 = New Explosives.dsExplosives()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.ConditionsTableAdapter = New Explosives.dsExplosivesTableAdapters.ConditionsTableAdapter()
        Me.PermissionNamesTableAdapter = New Explosives.dsExplosivesTableAdapters.PermissionNamesTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.MainMenu1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.PermissionNamesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.ConditionsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame9.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdConditions
        '
        Me.cmdConditions.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdConditions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdConditions.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConditions.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdConditions.Location = New System.Drawing.Point(8, 16)
        Me.cmdConditions.Name = "cmdConditions"
        Me.cmdConditions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdConditions.Size = New System.Drawing.Size(69, 33)
        Me.cmdConditions.TabIndex = 16
        Me.cmdConditions.Text = "+"
        Me.cmdConditions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdConditions, "≈÷«›…")
        Me.cmdConditions.UseVisualStyleBackColor = False
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(141, 24)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(66, 33)
        Me.cmdPlus.TabIndex = 12
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdPlus, "≈÷«›…")
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemove.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRemove.Location = New System.Drawing.Point(72, 24)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(65, 33)
        Me.cmdRemove.TabIndex = 11
        Me.cmdRemove.Text = "-"
        Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdRemove, "≈“«·…")
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1010, 24)
        Me.MainMenu1.TabIndex = 15
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmdConditions)
        Me.Frame2.Controls.Add(Me.cmbCnditionFile)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(368, 129)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(528, 57)
        Me.Frame2.TabIndex = 14
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "  ‰‹‹‹‹‹Ê⁄ «·≈–‰  "
        '
        'cmbCnditionFile
        '
        Me.cmbCnditionFile.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCnditionFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCnditionFile.DataSource = Me.PermissionNamesBindingSource
        Me.cmbCnditionFile.DisplayMember = "PermissionName"
        Me.cmbCnditionFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCnditionFile.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCnditionFile.Location = New System.Drawing.Point(80, 24)
        Me.cmbCnditionFile.Name = "cmbCnditionFile"
        Me.cmbCnditionFile.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCnditionFile.Size = New System.Drawing.Size(409, 21)
        Me.cmbCnditionFile.TabIndex = 15
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
        'ConditionsBindingSource
        '
        Me.ConditionsBindingSource.DataMember = "Conditions"
        Me.ConditionsBindingSource.DataSource = Me.DsExplosives
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.btnCancel)
        Me.Frame1.Controls.Add(Me.List1)
        Me.Frame1.Controls.Add(Me.txtCondition)
        Me.Frame1.Controls.Add(Me.cmdPlus)
        Me.Frame1.Controls.Add(Me.cmdRemove)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(368, 184)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(528, 459)
        Me.Frame1.TabIndex = 9
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  «·‘‹‹‹‹‹—Êÿ  "
        '
        'List1
        '
        Me.List1.DataSource = Me.ConditionsBindingSource
        Me.List1.DisplayMember = "Condition"
        Me.List1.FormattingEnabled = True
        Me.List1.Location = New System.Drawing.Point(8, 61)
        Me.List1.Name = "List1"
        Me.List1.Size = New System.Drawing.Size(481, 368)
        Me.List1.TabIndex = 14
        Me.List1.ValueMember = "Condition"
        '
        'txtCondition
        '
        Me.txtCondition.Location = New System.Drawing.Point(227, 31)
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.Size = New System.Drawing.Size(262, 20)
        Me.txtCondition.TabIndex = 13
        '
        'ConditionsBindingSource1
        '
        Me.ConditionsBindingSource1.DataMember = "Conditions"
        Me.ConditionsBindingSource1.DataSource = Me.DsExplosives1
        '
        'DsExplosives1
        '
        Me.DsExplosives1.DataSetName = "dsExplosives"
        Me.DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(368, 56)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(528, 73)
        Me.Frame9.TabIndex = 0
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "  «·‰Ÿ‹‹‹‹«„  "
        '
        'cmdLogout
        '
        Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(183, 16)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(137, 41)
        Me.cmdLogout.TabIndex = 3
        Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdExit.Location = New System.Drawing.Point(8, 16)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(137, 41)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(358, 16)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(137, 41)
        Me.cmdReturn.TabIndex = 1
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'ConditionsTableAdapter
        '
        Me.ConditionsTableAdapter.ClearBeforeFill = True
        '
        'PermissionNamesTableAdapter
        '
        Me.PermissionNamesTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(8, 24)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 31)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "«·€«¡"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'frmConditions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1010, 734)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmConditions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "‘‹‹—Êÿ ⁄‹‹‹‹‹‹‹‹‹‹‹œ„ «·„„‹‹‹‹‹‹‹‹‹«‰⁄‹‹‹‹‹‹‹‹‹‹…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        CType(Me.PermissionNamesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConditionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.ConditionsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame9.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents ConditionsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConditionsTableAdapter As Explosives.dsExplosivesTableAdapters.ConditionsTableAdapter
    Friend WithEvents ConditionsBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PermissionNamesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PermissionNamesTableAdapter As Explosives.dsExplosivesTableAdapters.PermissionNamesTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
#End Region
End Class