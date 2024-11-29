<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOurDistract
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
	Public WithEvents mnucolours As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents Timer1 As System.Windows.Forms.Timer
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
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnucolours = New System.Windows.Forms.ToolStripMenuItem()
        Me.OURDISTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.IMPORTALLOWEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKALLOWEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.OURDISTRACTTableAdapter = New Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter()
        Me.AccountsTableAdapter = New Explosives.dsExplosivesTableAdapters.AccountsTableAdapter()
        Me.IMPORTALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter()
        Me.WORKALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKALLOWEDTableAdapter()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.txtDistractAutherity = New System.Windows.Forms.TextBox()
        Me.txtDistRank = New System.Windows.Forms.TextBox()
        Me.txtDistName = New System.Windows.Forms.TextBox()
        Me.txtDistSignature = New System.Windows.Forms.TextBox()
        Me.txtDisAdoption = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chbSkipImport = New System.Windows.Forms.CheckBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInstructions = New System.Windows.Forms.TextBox()
        Me.cmbDistractor = New System.Windows.Forms.ComboBox()
        Me.txtPolicyID = New System.Windows.Forms.TextBox()
        Me.txtStationDist = New System.Windows.Forms.TextBox()
        Me.txtConsignment = New System.Windows.Forms.TextBox()
        Me.txtStationRec = New System.Windows.Forms.TextBox()
        Me.txtNotes = New System.Windows.Forms.TextBox()
        Me.cmbReceiver = New System.Windows.Forms.ComboBox()
        Me.WORKPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtAmmount = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SampleNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RecordNo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.txtRecord = New System.Windows.Forms.TextBox()
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdMinus = New System.Windows.Forms.CheckBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbAccount = New System.Windows.Forms.ComboBox()
        Me.txtOurDistractNo = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDuration = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.WORKPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter()
        Me.MainMenu1.SuspendLayout()
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame9.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame5.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        CType(Me.txtAmmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnucolours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1370, 24)
        Me.MainMenu1.TabIndex = 97
        '
        'mnucolours
        '
        Me.mnucolours.Name = "mnucolours"
        Me.mnucolours.Size = New System.Drawing.Size(79, 20)
        Me.mnucolours.Text = "ÖÈØ ÇáÃáæÇä"
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
        'IMPORTALLOWEDBindingSource
        '
        Me.IMPORTALLOWEDBindingSource.DataMember = "IMPORTALLOWED"
        Me.IMPORTALLOWEDBindingSource.DataSource = Me.DsExplosives
        '
        'WORKALLOWEDBindingSource
        '
        Me.WORKALLOWEDBindingSource.DataMember = "WORKALLOWED"
        Me.WORKALLOWEDBindingSource.DataSource = Me.DsExplosives
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.DsExplosives
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'OURDISTRACTTableAdapter
        '
        Me.OURDISTRACTTableAdapter.ClearBeforeFill = True
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'IMPORTALLOWEDTableAdapter
        '
        Me.IMPORTALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'WORKALLOWEDTableAdapter
        '
        Me.WORKALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(914, 302)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(410, 144)
        Me.Frame9.TabIndex = 105
        Me.Frame9.TabStop = False
        Me.Frame9.Text = " ÇáÊäÞá Èíä ÇáÓÌáÇÊ "
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintAll.Location = New System.Drawing.Point(30, 16)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(177, 33)
        Me.cmdPrintAll.TabIndex = 95
        Me.cmdPrintAll.Text = "ØÜÜÈÜÜÇÚÉ ÇáÜÜÜÜßÜÜÜá"
        Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintAll.UseVisualStyleBackColor = False
        '
        'cmdPrintDoc
        '
        Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintDoc.Enabled = False
        Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintDoc.Location = New System.Drawing.Point(214, 16)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(177, 33)
        Me.cmdPrintDoc.TabIndex = 94
        Me.cmdPrintDoc.Text = "ØÜÜÜÈÜÇÚÉ ÇáãÓÊäÏ"
        Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintDoc.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdExit.Location = New System.Drawing.Point(30, 96)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(177, 33)
        Me.cmdExit.TabIndex = 93
        Me.cmdExit.Text = "ÎÜÜÜÜÜÜÜÜÜÑæÌ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(214, 96)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(177, 33)
        Me.cmdLogout.TabIndex = 92
        Me.cmdLogout.Text = "ÊÓÌíÜá ÎÜÜÜÜÑæÌ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(30, 56)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(177, 33)
        Me.cmdReturn.TabIndex = 91
        Me.cmdReturn.Text = "ÑÌÜÜÜÜÜÜÜÜÜæÚ"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdFound
        '
        Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFound.Location = New System.Drawing.Point(214, 56)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(177, 33)
        Me.cmdFound.TabIndex = 90
        Me.cmdFound.Text = "ÇáÊÞÑíÑ"
        Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFound.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(914, 237)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(410, 65)
        Me.Frame7.TabIndex = 103
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " ÇáÊäÞá Èíä ÇáÓÌáÇÊ "
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(123, 16)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 77
        Me.cmdPrev.Text = "ÇáÓÜÜÜÜÇÈÞ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(29, 16)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 76
        Me.cmdFirst.Text = "ÇáÃæá >>"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLast.Location = New System.Drawing.Point(309, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 75
        Me.cmdLast.Text = "<< ÇáÃÎíÜÜÜÑ"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(216, 16)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 74
        Me.cmdNext.Text = "< ÇáÊÜÜÜÜÇáí"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(914, 172)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(410, 65)
        Me.Frame6.TabIndex = 100
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ÚãáíÇÊ Úáì ÇáÓÌáÇÊ "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(112, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(60, 33)
        Me.cmdCancel.TabIndex = 34
        Me.cmdCancel.Text = "ÅáÜÜÜÛÜÜÜÇÁ"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(268, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(60, 33)
        Me.cmdSave.TabIndex = 31
        Me.cmdSave.Text = "ÍÜÜÜÝÜÜÜÙ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(192, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(60, 33)
        Me.cmdEdit.TabIndex = 32
        Me.cmdEdit.Text = "ÊÜÜÜÚÜÜÜÏíá"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(25, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 33
        Me.cmdDelete.Text = "ÍÜÜÜÜÜÐÝ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(344, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(60, 33)
        Me.cmdNew.TabIndex = 30
        Me.cmdNew.Text = "ÌÜÜÏíÜÜÜÏ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Frame5.Controls.Add(Me.txtDistractAutherity)
        Me.Frame5.Controls.Add(Me.txtDistRank)
        Me.Frame5.Controls.Add(Me.txtDistName)
        Me.Frame5.Controls.Add(Me.txtDistSignature)
        Me.Frame5.Controls.Add(Me.txtDisAdoption)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Label18)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label21)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(922, 479)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(580, 150)
        Me.Frame5.TabIndex = 99
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " ÇáÌåÉ ÇáÕÇÑÝÉ"
        Me.Frame5.Visible = False
        '
        'txtDistractAutherity
        '
        Me.txtDistractAutherity.AcceptsReturn = True
        Me.txtDistractAutherity.BackColor = System.Drawing.SystemColors.Window
        Me.txtDistractAutherity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDistractAutherity.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDistractAutherity.Location = New System.Drawing.Point(337, 65)
        Me.txtDistractAutherity.MaxLength = 0
        Me.txtDistractAutherity.Multiline = True
        Me.txtDistractAutherity.Name = "txtDistractAutherity"
        Me.txtDistractAutherity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistractAutherity.Size = New System.Drawing.Size(153, 25)
        Me.txtDistractAutherity.TabIndex = 20
        Me.txtDistractAutherity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDistRank
        '
        Me.txtDistRank.AcceptsReturn = True
        Me.txtDistRank.BackColor = System.Drawing.SystemColors.Window
        Me.txtDistRank.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDistRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDistRank.Location = New System.Drawing.Point(337, 21)
        Me.txtDistRank.MaxLength = 0
        Me.txtDistRank.Multiline = True
        Me.txtDistRank.Name = "txtDistRank"
        Me.txtDistRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistRank.Size = New System.Drawing.Size(153, 25)
        Me.txtDistRank.TabIndex = 21
        Me.txtDistRank.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDistName
        '
        Me.txtDistName.AcceptsReturn = True
        Me.txtDistName.BackColor = System.Drawing.SystemColors.Window
        Me.txtDistName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDistName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDistName.Location = New System.Drawing.Point(30, 21)
        Me.txtDistName.MaxLength = 0
        Me.txtDistName.Multiline = True
        Me.txtDistName.Name = "txtDistName"
        Me.txtDistName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistName.Size = New System.Drawing.Size(225, 25)
        Me.txtDistName.TabIndex = 22
        Me.txtDistName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDistSignature
        '
        Me.txtDistSignature.AcceptsReturn = True
        Me.txtDistSignature.BackColor = System.Drawing.SystemColors.Window
        Me.txtDistSignature.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDistSignature.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDistSignature.Location = New System.Drawing.Point(30, 62)
        Me.txtDistSignature.MaxLength = 0
        Me.txtDistSignature.Multiline = True
        Me.txtDistSignature.Name = "txtDistSignature"
        Me.txtDistSignature.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDistSignature.Size = New System.Drawing.Size(225, 25)
        Me.txtDistSignature.TabIndex = 23
        Me.txtDistSignature.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDisAdoption
        '
        Me.txtDisAdoption.AcceptsReturn = True
        Me.txtDisAdoption.BackColor = System.Drawing.SystemColors.Window
        Me.txtDisAdoption.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDisAdoption.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDisAdoption.Location = New System.Drawing.Point(161, 108)
        Me.txtDisAdoption.MaxLength = 0
        Me.txtDisAdoption.Multiline = True
        Me.txtDisAdoption.Name = "txtDisAdoption"
        Me.txtDisAdoption.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisAdoption.Size = New System.Drawing.Size(329, 25)
        Me.txtDisAdoption.TabIndex = 24
        Me.txtDisAdoption.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(496, 65)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(73, 25)
        Me.Label20.TabIndex = 51
        Me.Label20.Text = "ÇáÓáØÉ ÇáÕÇÑÝÉ"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(496, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(81, 25)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "ÑÊÈÉ ÖÇÈØ ÇáÕÑÝ"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(266, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(65, 17)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "ÇÓãå"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(243, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(89, 25)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "ÅãÖÇÁ ÖÇÈØ ÇáÕÑÝ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(496, 108)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(73, 25)
        Me.Label21.TabIndex = 47
        Me.Label21.Text = "ÅÚÊãÇÏ ÇáÞÇÆÏ"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame8.Controls.Add(Me.lblPosition)
        Me.Frame8.Controls.Add(Me.txtFind)
        Me.Frame8.Controls.Add(Me.cmdFindPrev)
        Me.Frame8.Controls.Add(Me.cmdFindNext)
        Me.Frame8.Controls.Add(Me.cmbCriteria)
        Me.Frame8.Controls.Add(Me.txtDate1)
        Me.Frame8.Controls.Add(Me.txtDate2)
        Me.Frame8.Controls.Add(Me.Label28)
        Me.Frame8.Controls.Add(Me.Label29)
        Me.Frame8.Controls.Add(Me.Label30)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(914, 51)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(410, 121)
        Me.Frame8.TabIndex = 104
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " ÇáÜÜÜÜÈÍÜÜÜÜÜË "
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(44, 56)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(79, 13)
        Me.lblPosition.TabIndex = 89
        Me.lblPosition.Text = "************"
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(127, 16)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(161, 25)
        Me.txtFind.TabIndex = 84
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindPrev.Location = New System.Drawing.Point(87, 16)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindPrev.TabIndex = 83
        Me.cmdFindPrev.Text = ">"
        Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindPrev.UseVisualStyleBackColor = False
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindNext.Location = New System.Drawing.Point(295, 16)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindNext.TabIndex = 82
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"ÚÇã", "äãÑÉ ÇáãÓÊäÏ", "ÇáÍÓÇÈ", "ÇáæÍÏÉ ÇáÕÇÑÝÉ", "ÇáæÍÏÉ ÇáãÓÊáãÉ", "ÊÇÑíÎ ÇáÕÑÝ", "ÝÊÑÉ ÊÇÑíÎíÉ"})
        Me.cmbCriteria.Location = New System.Drawing.Point(207, 48)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCriteria.Size = New System.Drawing.Size(121, 21)
        Me.cmbCriteria.TabIndex = 81
        '
        'txtDate1
        '
        Me.txtDate1.AcceptsReturn = True
        Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate1.Location = New System.Drawing.Point(207, 80)
        Me.txtDate1.MaxLength = 0
        Me.txtDate1.Multiline = True
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate1.Size = New System.Drawing.Size(121, 25)
        Me.txtDate1.TabIndex = 80
        Me.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDate2
        '
        Me.txtDate2.AcceptsReturn = True
        Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate2.Location = New System.Drawing.Point(31, 80)
        Me.txtDate2.MaxLength = 0
        Me.txtDate2.Multiline = True
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate2.Size = New System.Drawing.Size(121, 25)
        Me.txtDate2.TabIndex = 79
        Me.txtDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label28.Location = New System.Drawing.Point(343, 80)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(33, 17)
        Me.Label28.TabIndex = 88
        Me.Label28.Text = "ãÜÜä"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label29.Location = New System.Drawing.Point(167, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(33, 17)
        Me.Label29.TabIndex = 87
        Me.Label29.Text = "ÅáÜÜÜì"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label30.Location = New System.Drawing.Point(334, 56)
        Me.Label30.Name = "Label30"
        Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label30.Size = New System.Drawing.Size(52, 13)
        Me.Label30.TabIndex = 85
        Me.Label30.Text = "ÇáÈÍË Úä"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.chbSkipImport)
        Me.Frame1.Controls.Add(Me.dtpDate)
        Me.Frame1.Controls.Add(Me.txtInstructions)
        Me.Frame1.Controls.Add(Me.cmbDistractor)
        Me.Frame1.Controls.Add(Me.txtPolicyID)
        Me.Frame1.Controls.Add(Me.txtStationDist)
        Me.Frame1.Controls.Add(Me.txtConsignment)
        Me.Frame1.Controls.Add(Me.txtStationRec)
        Me.Frame1.Controls.Add(Me.txtNotes)
        Me.Frame1.Controls.Add(Me.cmbReceiver)
        Me.Frame1.Controls.Add(Me.Label27)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label11)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label14)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(112, 116)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(801, 186)
        Me.Frame1.TabIndex = 102
        Me.Frame1.TabStop = False
        '
        'chbSkipImport
        '
        Me.chbSkipImport.AutoSize = True
        Me.chbSkipImport.Location = New System.Drawing.Point(31, 112)
        Me.chbSkipImport.Name = "chbSkipImport"
        Me.chbSkipImport.Size = New System.Drawing.Size(138, 17)
        Me.chbSkipImport.TabIndex = 74
        Me.chbSkipImport.Text = "ÊÎØí ÇáßãíÇÊ Ýí ÇáæÇÑÏ"
        Me.chbSkipImport.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.OURDISTRACTBindingSource, "DISTDATE", True))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(8, 48)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(160, 20)
        Me.dtpDate.TabIndex = 73
        '
        'txtInstructions
        '
        Me.txtInstructions.AcceptsReturn = True
        Me.txtInstructions.BackColor = System.Drawing.SystemColors.Window
        Me.txtInstructions.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtInstructions.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "INSTRUCTIONS", True))
        Me.txtInstructions.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtInstructions.Location = New System.Drawing.Point(248, 144)
        Me.txtInstructions.MaxLength = 0
        Me.txtInstructions.Multiline = True
        Me.txtInstructions.Name = "txtInstructions"
        Me.txtInstructions.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtInstructions.Size = New System.Drawing.Size(449, 25)
        Me.txtInstructions.TabIndex = 71
        Me.txtInstructions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbDistractor
        '
        Me.cmbDistractor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.cmbDistractor.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDistractor.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDistractor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "DISTRACTOR", True))
        Me.cmbDistractor.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OURDISTRACTBindingSource, "DISTRACTOR", True))
        Me.cmbDistractor.DataSource = Me.IMPORTALLOWEDBindingSource
        Me.cmbDistractor.DisplayMember = "SIDENAME"
        Me.cmbDistractor.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDistractor.Location = New System.Drawing.Point(248, 16)
        Me.cmbDistractor.Name = "cmbDistractor"
        Me.cmbDistractor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbDistractor.Size = New System.Drawing.Size(217, 21)
        Me.cmbDistractor.TabIndex = 4
        Me.cmbDistractor.ValueMember = "SIDENAME"
        '
        'txtPolicyID
        '
        Me.txtPolicyID.AcceptsReturn = True
        Me.txtPolicyID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPolicyID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPolicyID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "POLICYID", True))
        Me.txtPolicyID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPolicyID.Location = New System.Drawing.Point(248, 80)
        Me.txtPolicyID.MaxLength = 0
        Me.txtPolicyID.Multiline = True
        Me.txtPolicyID.Name = "txtPolicyID"
        Me.txtPolicyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPolicyID.Size = New System.Drawing.Size(449, 25)
        Me.txtPolicyID.TabIndex = 8
        Me.txtPolicyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStationDist
        '
        Me.txtStationDist.AcceptsReturn = True
        Me.txtStationDist.BackColor = System.Drawing.SystemColors.Window
        Me.txtStationDist.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStationDist.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "STATIONDIST", True))
        Me.txtStationDist.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStationDist.Location = New System.Drawing.Point(552, 16)
        Me.txtStationDist.MaxLength = 0
        Me.txtStationDist.Multiline = True
        Me.txtStationDist.Name = "txtStationDist"
        Me.txtStationDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStationDist.Size = New System.Drawing.Size(145, 25)
        Me.txtStationDist.TabIndex = 3
        '
        'txtConsignment
        '
        Me.txtConsignment.AcceptsReturn = True
        Me.txtConsignment.BackColor = System.Drawing.SystemColors.Window
        Me.txtConsignment.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtConsignment.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtConsignment.Location = New System.Drawing.Point(8, 16)
        Me.txtConsignment.MaxLength = 0
        Me.txtConsignment.Multiline = True
        Me.txtConsignment.Name = "txtConsignment"
        Me.txtConsignment.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtConsignment.Size = New System.Drawing.Size(161, 25)
        Me.txtConsignment.TabIndex = 5
        Me.txtConsignment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtStationRec
        '
        Me.txtStationRec.AcceptsReturn = True
        Me.txtStationRec.BackColor = System.Drawing.SystemColors.Window
        Me.txtStationRec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStationRec.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "STATIONREC", True))
        Me.txtStationRec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStationRec.Location = New System.Drawing.Point(552, 48)
        Me.txtStationRec.MaxLength = 0
        Me.txtStationRec.Multiline = True
        Me.txtStationRec.Name = "txtStationRec"
        Me.txtStationRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStationRec.Size = New System.Drawing.Size(145, 25)
        Me.txtStationRec.TabIndex = 6
        '
        'txtNotes
        '
        Me.txtNotes.AcceptsReturn = True
        Me.txtNotes.BackColor = System.Drawing.SystemColors.Window
        Me.txtNotes.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNotes.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "NOTES", True))
        Me.txtNotes.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNotes.Location = New System.Drawing.Point(248, 112)
        Me.txtNotes.MaxLength = 0
        Me.txtNotes.Multiline = True
        Me.txtNotes.Name = "txtNotes"
        Me.txtNotes.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNotes.Size = New System.Drawing.Size(449, 25)
        Me.txtNotes.TabIndex = 9
        Me.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbReceiver
        '
        Me.cmbReceiver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbReceiver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbReceiver.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReceiver.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbReceiver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "RECEIVER", True))
        Me.cmbReceiver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OURDISTRACTBindingSource, "RECEIVER", True))
        Me.cmbReceiver.DataSource = Me.WORKPERMISSIONSBindingSource
        Me.cmbReceiver.DisplayMember = "FSIDENAME"
        Me.cmbReceiver.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReceiver.Location = New System.Drawing.Point(248, 48)
        Me.cmbReceiver.Name = "cmbReceiver"
        Me.cmbReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbReceiver.Size = New System.Drawing.Size(217, 21)
        Me.cmbReceiver.TabIndex = 7
        Me.cmbReceiver.ValueMember = "FSIDENAME"
        '
        'WORKPERMISSIONSBindingSource
        '
        Me.WORKPERMISSIONSBindingSource.DataMember = "WORKPERMISSIONS"
        Me.WORKPERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'Label27
        '
        Me.Label27.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(700, 152)
        Me.Label27.Name = "Label27"
        Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label27.Size = New System.Drawing.Size(89, 33)
        Me.Label27.TabIndex = 72
        Me.Label27.Text = "* ÇáÊÚáíãÇÊ ÈÙÇåÑå"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(701, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(89, 21)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "äãÑÉ ÇáÈæáíÓÉ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(712, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "ÇáãÍØÉ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(176, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "ÊÇÑíÎ ÇáÕÑÝ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(176, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "ØÑíÞÉ ÅÑÓÇá ÇáÅÑÓÇáíÉ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(712, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "ÇáãÍØÉ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(472, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(73, 17)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "ÇáæÍÏÉ ÇáÕÇÑÝÉ"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(696, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(107, 49)
        Me.Label12.TabIndex = 64
        Me.Label12.Text = "ÇáÊÕÑíÍ Ãæ ãáÍæÙÇÊ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(464, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(92, 17)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "ÇáæÍÏÉ ÇáãÓÊáãÉ"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.txtAmmount)
        Me.Frame3.Controls.Add(Me.DataGridView1)
        Me.Frame3.Controls.Add(Me.cmbUnit)
        Me.Frame3.Controls.Add(Me.cmbClass)
        Me.Frame3.Controls.Add(Me.txtClassID)
        Me.Frame3.Controls.Add(Me.txtRecord)
        Me.Frame3.Controls.Add(Me.cmdPlus)
        Me.Frame3.Controls.Add(Me.cmdMinus)
        Me.Frame3.Controls.Add(Me.Label25)
        Me.Frame3.Controls.Add(Me.Label24)
        Me.Frame3.Controls.Add(Me.Label23)
        Me.Frame3.Controls.Add(Me.Label22)
        Me.Frame3.Controls.Add(Me.Label26)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(112, 302)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(801, 393)
        Me.Frame3.TabIndex = 101
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " ÈíÇäÇÊ ÇáãÝÑÞÚÇÊ "
        '
        'txtAmmount
        '
        Me.txtAmmount.Location = New System.Drawing.Point(715, 17)
        Me.txtAmmount.Maximum = New Decimal(New Integer() {999999999, 0, 0, 0})
        Me.txtAmmount.Name = "txtAmmount"
        Me.txtAmmount.Size = New System.Drawing.Size(71, 20)
        Me.txtAmmount.TabIndex = 62
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.Unit, Me.Description, Me.SampleNo, Me.RecordNo})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 96)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(785, 231)
        Me.DataGridView1.TabIndex = 61
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "ÇáÚÏÏ Ãæ ÇáßãíÉ"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.FillWeight = 50.0!
        Me.Unit.HeaderText = "æÍÏÉ ÇáÞíÇÓ"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Description
        '
        Me.Description.FillWeight = 194.535!
        Me.Description.HeaderText = "æÕÝ ÇáÕäÝ"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'SampleNo
        '
        Me.SampleNo.FillWeight = 44.26149!
        Me.SampleNo.HeaderText = "äãÑÉ ÇáÚíäÉ"
        Me.SampleNo.Name = "SampleNo"
        Me.SampleNo.ReadOnly = True
        '
        'RecordNo
        '
        Me.RecordNo.FillWeight = 54.149!
        Me.RecordNo.HeaderText = "äãÑÉ ÕÝÍÉ ÇáÓÌá"
        Me.RecordNo.Name = "RecordNo"
        Me.RecordNo.ReadOnly = True
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Location = New System.Drawing.Point(608, 16)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbUnit.Size = New System.Drawing.Size(89, 21)
        Me.cmbUnit.TabIndex = 11
        '
        'cmbClass
        '
        Me.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClass.BackColor = System.Drawing.SystemColors.Window
        Me.cmbClass.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbClass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbClass.Location = New System.Drawing.Point(216, 16)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbClass.Size = New System.Drawing.Size(377, 21)
        Me.cmbClass.TabIndex = 12
        '
        'txtClassID
        '
        Me.txtClassID.AcceptsReturn = True
        Me.txtClassID.BackColor = System.Drawing.SystemColors.Window
        Me.txtClassID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClassID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtClassID.Location = New System.Drawing.Point(96, 16)
        Me.txtClassID.MaxLength = 0
        Me.txtClassID.Multiline = True
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtClassID.Size = New System.Drawing.Size(113, 25)
        Me.txtClassID.TabIndex = 13
        Me.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRecord
        '
        Me.txtRecord.AcceptsReturn = True
        Me.txtRecord.BackColor = System.Drawing.SystemColors.Window
        Me.txtRecord.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRecord.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRecord.Location = New System.Drawing.Point(8, 16)
        Me.txtRecord.MaxLength = 0
        Me.txtRecord.Multiline = True
        Me.txtRecord.Name = "txtRecord"
        Me.txtRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRecord.Size = New System.Drawing.Size(81, 25)
        Me.txtRecord.TabIndex = 14
        Me.txtRecord.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(448, 48)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPlus.Size = New System.Drawing.Size(89, 33)
        Me.cmdPlus.TabIndex = 55
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'cmdMinus
        '
        Me.cmdMinus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdMinus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMinus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdMinus.Location = New System.Drawing.Point(264, 48)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMinus.Size = New System.Drawing.Size(89, 33)
        Me.cmdMinus.TabIndex = 54
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdMinus.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label25.ForeColor = System.Drawing.Color.Black
        Me.Label25.Location = New System.Drawing.Point(16, 54)
        Me.Label25.Name = "Label25"
        Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label25.Size = New System.Drawing.Size(65, 33)
        Me.Label25.TabIndex = 60
        Me.Label25.Text = "äãÑÉ ÕÝÍÉ ÇáÓÌá"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(120, 56)
        Me.Label24.Name = "Label24"
        Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label24.Size = New System.Drawing.Size(65, 17)
        Me.Label24.TabIndex = 59
        Me.Label24.Text = "äãÑÉ ÇáÚíäÉ"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.Color.Black
        Me.Label23.Location = New System.Drawing.Point(368, 56)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(65, 17)
        Me.Label23.TabIndex = 58
        Me.Label23.Text = "æÕÝ ÇáÕäÝ"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(712, 56)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(86, 17)
        Me.Label22.TabIndex = 57
        Me.Label22.Text = " ÇáÚÏÏ Ãæ ÇáßãíÉ"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(620, 56)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(65, 17)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "æÍÏÉ ÇáÞíÇÓ"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmbAccount)
        Me.Frame2.Controls.Add(Me.txtOurDistractNo)
        Me.Frame2.Controls.Add(Me.txtID)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.txtDuration)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(112, 51)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(801, 65)
        Me.Frame2.TabIndex = 98
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "  ãÇ íãáÃ ÈæÇÓØÉ ÇáÖÇÈØ ÇáÕÇÑÝ "
        '
        'cmbAccount
        '
        Me.cmbAccount.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAccount.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.OURDISTRACTBindingSource, "ACCOUNT", True))
        Me.cmbAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "ACCOUNT", True))
        Me.cmbAccount.DataSource = Me.AccountsBindingSource
        Me.cmbAccount.DisplayMember = "ACCOUNT"
        Me.cmbAccount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAccount.Location = New System.Drawing.Point(248, 24)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbAccount.Size = New System.Drawing.Size(155, 21)
        Me.cmbAccount.TabIndex = 1
        Me.cmbAccount.ValueMember = "ACCOUNT"
        '
        'txtOurDistractNo
        '
        Me.txtOurDistractNo.AcceptsReturn = True
        Me.txtOurDistractNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtOurDistractNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOurDistractNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "OurDistractNo", True))
        Me.txtOurDistractNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOurDistractNo.Location = New System.Drawing.Point(482, 24)
        Me.txtOurDistractNo.MaxLength = 0
        Me.txtOurDistractNo.Name = "txtOurDistractNo"
        Me.txtOurDistractNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOurDistractNo.Size = New System.Drawing.Size(74, 20)
        Me.txtOurDistractNo.TabIndex = 0
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "ID", True))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(645, 24)
        Me.txtID.MaxLength = 0
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(74, 25)
        Me.txtID.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(553, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(86, 33)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "ãÓÊäÏ ãäÕÑÝ äÜÜÜÜÜÜãÜÜÜÜÜÑÉ"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtDuration
        '
        Me.txtDuration.AcceptsReturn = True
        Me.txtDuration.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuration.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDuration.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.OURDISTRACTBindingSource, "DURATION", True))
        Me.txtDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDuration.Location = New System.Drawing.Point(8, 24)
        Me.txtDuration.MaxLength = 0
        Me.txtDuration.Multiline = True
        Me.txtDuration.Name = "txtDuration"
        Me.txtDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDuration.Size = New System.Drawing.Size(161, 25)
        Me.txtDuration.TabIndex = 2
        Me.txtDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(725, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 33)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "ÇáÊÓáÓáí"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(168, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "ÇáãÏÉ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(390, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(106, 45)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ÍÓÇÈ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WORKPERMISSIONSTableAdapter
        '
        Me.WORKPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'frmOurDistract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmOurDistract"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ãÜÜÓÊäÜÜÜÜÜÜÏÇÊ ÇáÜÕÜÜÜÜÜÜÜÜÇÏÑ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame9.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.txtAmmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents OURDISTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OURDISTRACTTableAdapter As Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountsTableAdapter As Explosives.dsExplosivesTableAdapters.AccountsTableAdapter
    Friend WithEvents IMPORTALLOWEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPORTALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter
    Friend WithEvents WORKALLOWEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.WORKALLOWEDTableAdapter
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
    Public WithEvents cmdExit As System.Windows.Forms.CheckBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
    Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
    Public WithEvents cmdFound As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents txtDistractAutherity As System.Windows.Forms.TextBox
    Public WithEvents txtDistRank As System.Windows.Forms.TextBox
    Public WithEvents txtDistName As System.Windows.Forms.TextBox
    Public WithEvents txtDistSignature As System.Windows.Forms.TextBox
    Public WithEvents txtDisAdoption As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents txtDate1 As System.Windows.Forms.TextBox
    Public WithEvents txtDate2 As System.Windows.Forms.TextBox
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents Label30 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtInstructions As System.Windows.Forms.TextBox
    Public WithEvents cmbDistractor As System.Windows.Forms.ComboBox
    Public WithEvents txtPolicyID As System.Windows.Forms.TextBox
    Public WithEvents txtStationDist As System.Windows.Forms.TextBox
    Public WithEvents txtConsignment As System.Windows.Forms.TextBox
    Public WithEvents txtStationRec As System.Windows.Forms.TextBox
    Public WithEvents txtNotes As System.Windows.Forms.TextBox
    Public WithEvents cmbReceiver As System.Windows.Forms.ComboBox
    Public WithEvents Label27 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAmmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SampleNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RecordNo As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Public WithEvents cmbClass As System.Windows.Forms.ComboBox
    Public WithEvents txtClassID As System.Windows.Forms.TextBox
    Public WithEvents txtRecord As System.Windows.Forms.TextBox
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
    Public WithEvents cmdMinus As System.Windows.Forms.CheckBox
    Public WithEvents Label25 As System.Windows.Forms.Label
    Public WithEvents Label24 As System.Windows.Forms.Label
    Public WithEvents Label23 As System.Windows.Forms.Label
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label26 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Public WithEvents txtID As System.Windows.Forms.TextBox
    Public WithEvents txtDuration As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents WORKPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents txtOurDistractNo As System.Windows.Forms.TextBox
    Friend WithEvents chbSkipImport As System.Windows.Forms.CheckBox

#End Region
End Class