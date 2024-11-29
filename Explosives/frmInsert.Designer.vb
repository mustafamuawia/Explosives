<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmInsert
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
	Public WithEvents cmdOk As System.Windows.Forms.CheckBox
	Public WithEvents cmbClass As System.Windows.Forms.TextBox
	Public WithEvents cmbUnit As System.Windows.Forms.TextBox
	Public WithEvents cmdMinus As System.Windows.Forms.CheckBox
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
	Public WithEvents txtAmmount As System.Windows.Forms.TextBox
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdOk = New System.Windows.Forms.CheckBox()
        Me.cmbClass = New System.Windows.Forms.TextBox()
        Me.cmbUnit = New System.Windows.Forms.TextBox()
        Me.cmdMinus = New System.Windows.Forms.CheckBox()
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.txtAmmount = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdOk
        '
        Me.cmdOk.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdOk.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdOk.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdOk.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdOk.Location = New System.Drawing.Point(112, 376)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdOk.Size = New System.Drawing.Size(369, 33)
        Me.cmdOk.TabIndex = 11
        Me.cmdOk.Text = "„Ê«›ﬁ"
        Me.cmdOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdOk.UseVisualStyleBackColor = False
        '
        'cmbClass
        '
        Me.cmbClass.AcceptsReturn = True
        Me.cmbClass.BackColor = System.Drawing.SystemColors.Window
        Me.cmbClass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbClass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClass.Location = New System.Drawing.Point(8, 8)
        Me.cmbClass.MaxLength = 0
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbClass.Size = New System.Drawing.Size(385, 25)
        Me.cmbClass.TabIndex = 10
        Me.cmbClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbUnit
        '
        Me.cmbUnit.AcceptsReturn = True
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Location = New System.Drawing.Point(400, 8)
        Me.cmbUnit.MaxLength = 0
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbUnit.Size = New System.Drawing.Size(89, 25)
        Me.cmbUnit.TabIndex = 9
        Me.cmbUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdMinus
        '
        Me.cmdMinus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdMinus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMinus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdMinus.Location = New System.Drawing.Point(56, 40)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMinus.Size = New System.Drawing.Size(89, 33)
        Me.cmdMinus.TabIndex = 5
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdMinus.UseVisualStyleBackColor = False
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(240, 40)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPlus.Size = New System.Drawing.Size(89, 33)
        Me.cmdPlus.TabIndex = 1
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'txtAmmount
        '
        Me.txtAmmount.AcceptsReturn = True
        Me.txtAmmount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmmount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmmount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmmount.Location = New System.Drawing.Point(496, 8)
        Me.txtAmmount.MaxLength = 0
        Me.txtAmmount.Name = "txtAmmount"
        Me.txtAmmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmmount.Size = New System.Drawing.Size(89, 25)
        Me.txtAmmount.TabIndex = 0
        Me.txtAmmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(500, 48)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(73, 17)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = " «·⁄œœ √Ê «·ﬂ„Ì…"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(408, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(65, 17)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "ÊÕœ… «·ﬁÌ«”"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(160, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 6
        Me.Label23.Text = "Ê’› «·’‰›"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Unit, Me.Quantity})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(577, 260)
        Me.DataGridView1.TabIndex = 12
        '
        'Description
        '
        Me.Description.FillWeight = 70.77156!
        Me.Description.HeaderText = "Ê’› «·’‰›"
        Me.Description.Name = "Description"
        '
        'Unit
        '
        Me.Unit.FillWeight = 34.3242!
        Me.Unit.HeaderText = "ÊÕœ… «·ﬁÌ«”"
        Me.Unit.Name = "Unit"
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 34.3242!
        Me.Quantity.HeaderText = "«·⁄œœ"
        Me.Quantity.Name = "Quantity"
        '
        'frmInsert
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(593, 418)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmbClass)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmdMinus)
        Me.Controls.Add(Me.cmdPlus)
        Me.Controls.Add(Me.txtAmmount)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Label23)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(8, 30)
        Me.Name = "frmInsert"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "≈œŒ«· «·„ ›Ã—«  «·„” Ê—œ…"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class