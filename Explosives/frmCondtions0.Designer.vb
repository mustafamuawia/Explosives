<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCondtions0
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
    'Public WithEvents Adodc1 As VB6.ADODC
    'Public WithEvents DataGrid1 As AxMSDataGridLib.AxDataGrid
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtPermissionName = New System.Windows.Forms.TextBox()
        Me.List1 = New System.Windows.Forms.ListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Frame1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(40, 24)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(37, 33)
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
        Me.cmdRemove.Location = New System.Drawing.Point(8, 24)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(33, 33)
        Me.cmdRemove.TabIndex = 11
        Me.cmdRemove.Text = "-"
        Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdRemove, "≈“«·…")
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.txtPermissionName)
        Me.Frame1.Controls.Add(Me.cmdPlus)
        Me.Frame1.Controls.Add(Me.cmdRemove)
        Me.Frame1.Controls.Add(Me.List1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(25, 23)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(505, 457)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  «·‘‹‹‹‹‹—Êÿ  "
        '
        'txtCondition
        '
        Me.txtPermissionName.AcceptsReturn = True
        Me.txtPermissionName.BackColor = System.Drawing.SystemColors.Window
        Me.txtPermissionName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPermissionName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPermissionName.Location = New System.Drawing.Point(80, 24)
        Me.txtPermissionName.MaxLength = 0
        Me.txtPermissionName.Name = "txtCondition"
        Me.txtPermissionName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPermissionName.Size = New System.Drawing.Size(417, 27)
        Me.txtPermissionName.TabIndex = 13
        Me.txtPermissionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'List1
        '
        Me.List1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.List1.BackColor = System.Drawing.SystemColors.Window
        Me.List1.Cursor = System.Windows.Forms.Cursors.Default
        Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.List1.ItemHeight = 19
        Me.List1.Location = New System.Drawing.Point(8, 64)
        Me.List1.Name = "List1"
        Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.List1.Size = New System.Drawing.Size(489, 365)
        Me.List1.TabIndex = 10
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(321, 486)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(82, 42)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Õ›Ÿ"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(165, 486)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(82, 42)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "«·€«¡"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmCondtions0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(556, 540)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Location = New System.Drawing.Point(3, 25)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCondtions0"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "«÷«›… Ê ⁄œÌ· «·‘—Êÿ"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
#End Region
#Region "Upgrade Support"
    Public Sub VB6_AddADODataBinding()
        'DataGrid1.DataSource = CType(Adodc1, msdatasrc.DataSource)
    End Sub
    Public Sub VB6_RemoveADODataBinding()
        'DataGrid1.DataSource = Nothing
    End Sub
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtPermissionName As System.Windows.Forms.TextBox
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
    Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Public WithEvents List1 As System.Windows.Forms.ListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
#End Region
End Class