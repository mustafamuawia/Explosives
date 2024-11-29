<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmNoObjections
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
	Public WithEvents mnuPay As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents cmbCountry As System.Windows.Forms.ComboBox
	Public WithEvents txtExporter As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmdRptAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdRptFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdRptDoc As System.Windows.Forms.CheckBox
	Public WithEvents Check3 As System.Windows.Forms.CheckBox
	Public WithEvents Check2 As System.Windows.Forms.CheckBox
	Public WithEvents Check4 As System.Windows.Forms.CheckBox
	Public WithEvents Frame10 As System.Windows.Forms.GroupBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents cmbDuration As System.Windows.Forms.ComboBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents txtsSideName As System.Windows.Forms.TextBox
    Public WithEvents txtsID As System.Windows.Forms.TextBox
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents txtfSideName As System.Windows.Forms.TextBox
    Public WithEvents txtfID As System.Windows.Forms.TextBox
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
	Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.NOOBJECTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.RankNOOBJECTIONSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.NameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives1 = New Explosives.dsExplosives()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.txtExporter = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame10 = New System.Windows.Forms.GroupBox()
        Me.cmdRptAll = New System.Windows.Forms.CheckBox()
        Me.cmdRptFound = New System.Windows.Forms.CheckBox()
        Me.cmdRptDoc = New System.Windows.Forms.CheckBox()
        Me.Check3 = New System.Windows.Forms.CheckBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.Check4 = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdFmtAll = New System.Windows.Forms.CheckBox()
        Me.cmdFmtFound = New System.Windows.Forms.CheckBox()
        Me.cmdFmtDoc = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.dtpSDate = New System.Windows.Forms.DateTimePicker()
        Me.txtsSideName = New System.Windows.Forms.TextBox()
        Me.txtsID = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker()
        Me.txtfSideName = New System.Windows.Forms.TextBox()
        Me.txtNoObjectionNO = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtfID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NOOBJECTIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter()
        Me.NoObjectionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.NoObjectionDetailsTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame6.SuspendLayout()
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankNOOBJECTIONSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(32, 19)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(21, 25)
        Me.cmdPlus.TabIndex = 30
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
        Me.cmdRemove.Location = New System.Drawing.Point(8, 19)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(25, 24)
        Me.cmdRemove.TabIndex = 31
        Me.cmdRemove.Text = "-"
        Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdRemove, "≈“«·…")
        Me.cmdRemove.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours, Me.mnuPay})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1244, 24)
        Me.MainMenu1.TabIndex = 72
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'mnuPay
        '
        Me.mnuPay.Name = "mnuPay"
        Me.mnuPay.Size = New System.Drawing.Size(101, 20)
        Me.mnuPay.Text = " √ﬂÌœ œ›⁄ «·—”Ê„"
        '
        'Timer1
        '
        Me.Timer1.Interval = 10000
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRefresh.Location = New System.Drawing.Point(0, 24)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
        Me.cmdRefresh.TabIndex = 0
        Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmbRank)
        Me.Frame6.Controls.Add(Me.cmbPosition)
        Me.Frame6.Controls.Add(Me.cmbName)
        Me.Frame6.Controls.Add(Me.Label9)
        Me.Frame6.Controls.Add(Me.Label8)
        Me.Frame6.Controls.Add(Me.Label7)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(174, 509)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(513, 121)
        Me.Frame6.TabIndex = 71
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "  ’«œ— »√„‹‹‹‹‹—  "
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "RANK", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NOOBJECTIONSBindingSource, "NAME", True))
        Me.cmbRank.DataSource = Me.RankNOOBJECTIONSBindingSource1
        Me.cmbRank.DisplayMember = "RANK"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(8, 24)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(417, 21)
        Me.cmbRank.TabIndex = 35
        Me.cmbRank.ValueMember = "RANK"
        '
        'NOOBJECTIONSBindingSource
        '
        Me.NOOBJECTIONSBindingSource.DataMember = "NOOBJECTIONS"
        Me.NOOBJECTIONSBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RankNOOBJECTIONSBindingSource1
        '
        Me.RankNOOBJECTIONSBindingSource1.DataMember = "NOOBJECTIONS"
        Me.RankNOOBJECTIONSBindingSource1.DataSource = Me.RankDsExplosives1
        '
        'RankDsExplosives1
        '
        Me.RankDsExplosives1.DataSetName = "dsExplosives"
        Me.RankDsExplosives1.EnforceConstraints = False
        Me.RankDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NOOBJECTIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataSource = Me.PositionBindingSource1
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(8, 89)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(417, 21)
        Me.cmbPosition.TabIndex = 36
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'PositionBindingSource1
        '
        Me.PositionBindingSource1.DataMember = "NOOBJECTIONS"
        Me.PositionBindingSource1.DataSource = Me.PositionDsExplosives1
        '
        'PositionDsExplosives1
        '
        Me.PositionDsExplosives1.DataSetName = "dsExplosives"
        Me.PositionDsExplosives1.EnforceConstraints = False
        Me.PositionDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "NAME", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NOOBJECTIONSBindingSource, "RANK", True))
        Me.cmbName.DataSource = Me.NameBindingSource1
        Me.cmbName.DisplayMember = "NAME"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(8, 56)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(417, 21)
        Me.cmbName.TabIndex = 36
        Me.cmbName.ValueMember = "NAME"
        '
        'NameBindingSource1
        '
        Me.NameBindingSource1.DataMember = "NOOBJECTIONS"
        Me.NameBindingSource1.DataSource = Me.NameDsExplosives1
        '
        'NameDsExplosives1
        '
        Me.NameDsExplosives1.DataSetName = "dsExplosives"
        Me.NameDsExplosives1.EnforceConstraints = False
        Me.NameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(446, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(31, 13)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "«·— »…"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(446, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 73
        Me.Label8.Text = "«·«”‹‹‹‹„"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(442, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "«·„‰‹‹’‹‹»"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.cmbCountry)
        Me.Frame5.Controls.Add(Me.txtExporter)
        Me.Frame5.Controls.Add(Me.Label6)
        Me.Frame5.Controls.Add(Me.Label5)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(687, 420)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(497, 89)
        Me.Frame5.TabIndex = 68
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "  »Ì«‰«  «·ÃÂ… «·„” Ê—œ „‰Â«  "
        '
        'cmbCountry
        '
        Me.cmbCountry.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCountry.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCountry.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "COUNTRY", True))
        Me.cmbCountry.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NOOBJECTIONSBindingSource, "COUNTRY", True))
        Me.cmbCountry.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCountry.Items.AddRange(New Object() {"Afghanistan", "Albania", "Algeria", "Andorra", "Angola", "Antigua and Barbuda", "Argentina", "Armenia", "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", "Belarus", "Belgium", "Belize", "Benin", "Bhutan", "Bolivia", "Bosnia and Herzegovina ", "Botswana", "Brazil", "Brunei", "Bulgaria", "Burkina Faso", "Burundi", "Cambodia", "Cameroon", "Canada", "Cape Verde", "Central African Republic", "Chad", "Chile", "China", "Colombia", "Comoros", "Congo", "Congo Democratic Republic", "Costa Rica", "Cote d'Ivoire", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", "Djibouti", "Dominica", "Dominican Republic", "Ecuador", "East Timor", "Egypt", "El Salvador", "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Fiji", "Finland", "France", "Gabon", "Gambia", "Georgia", "Germany", "Ghana", "Greece", "Grenada", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", "Haiti", "Honduras", "Hungary", "Iceland", "India", "Indonesia", "Iran", "Iraq", "Ireland", "Italy", "Jamaica", "Japan", "Jordan", "Kazakhstan", "Kenya", "Kiribati", "Korea North", "Korea South", "Kosovo", "Kuwait", "Kyrgyzstan", "Laos", "Latvia", "Lebanon", "Lesotho", "Liberia", "Libya", "Liechtenstein", "Lithuania", "Luxembourg", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", "Mali", "Malta", "Marshall Islands", "Mauritania", "Mauritius", "Mexico", "Micronesia", "Moldova", "Monaco", "Mongolia", "Montenegro", "Morocco", "Mozambique", "Myanmar (Burma)", "Namibia", "Nauru", "Nepal", "The Netherlands", "New Zealand", "Nicaragua", "Niger", "Nigeria", "Norway", "Oman", "Pakistan", "Palau", "Palestine", "Panama", "Papua New Guinea", "Paraguay", "Peru", "The Philippines", "Poland", "Portugal", "Qatar ", "Romania ", "Russia ", "Rwanda ", "St. Kitts and Nevis ", "St. Lucia ", "St. Vincent and The Grenadines ", "Samoa ", "San Marino ", "Sao Tome and Principe ", "Saudi Arabia ", "Senegal ", "Serbia ", "Seychelles ", "Sierra Leone ", "Singapore ", "Slovakia ", "Slovenia ", "Solomon Islands ", "Somalia ", "South Africa ", "South Sudan ", "Spain ", "Sri Lanka ", "Sudan ", "Suriname ", "Swaziland ", "Sweden ", "Switzerland ", "Syria ", "Taiwan ", "Tajikistan ", "Tanzania ", "Thailand ", "Togo ", "Tonga ", "Trinidad and Tobago ", "Tunisia ", "Turkey ", "Turkmenistan ", "Tuvalu ", "Uganda ", "Ukraine ", "United Arab Emirates ", "United Kingdom ", "United States of America ", "Uruguay ", "Uzbekistan ", "Vanuatu ", "Vatican City (Holy See) ", "Venezuela ", "Vietnam ", "Yemen ", "Zambia", "Zimbabwe"})
        Me.cmbCountry.Location = New System.Drawing.Point(8, 56)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCountry.Size = New System.Drawing.Size(417, 21)
        Me.cmbCountry.TabIndex = 26
        '
        'txtExporter
        '
        Me.txtExporter.AcceptsReturn = True
        Me.txtExporter.BackColor = System.Drawing.SystemColors.Window
        Me.txtExporter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtExporter.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "EXPORTER", True))
        Me.txtExporter.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtExporter.Location = New System.Drawing.Point(8, 24)
        Me.txtExporter.MaxLength = 0
        Me.txtExporter.Multiline = True
        Me.txtExporter.Name = "txtExporter"
        Me.txtExporter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtExporter.Size = New System.Drawing.Size(417, 25)
        Me.txtExporter.TabIndex = 25
        Me.txtExporter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(433, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "«”„ «·œÊ·…"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(434, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "«”„ «·ÃÂ…"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame10
        '
        Me.Frame10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame10.Controls.Add(Me.cmdRptAll)
        Me.Frame10.Controls.Add(Me.cmdRptFound)
        Me.Frame10.Controls.Add(Me.cmdRptDoc)
        Me.Frame10.Controls.Add(Me.Check3)
        Me.Frame10.Controls.Add(Me.Check2)
        Me.Frame10.Controls.Add(Me.Check4)
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(174, 80)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame10.Size = New System.Drawing.Size(1009, 81)
        Me.Frame10.TabIndex = 60
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "   ’Ì‹€‹‹‹‹…  ﬁ‹‹‹‹‹‹‹‹‹‹‹‹‹—Ì—  "
        Me.Frame10.Visible = False
        '
        'cmdRptAll
        '
        Me.cmdRptAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptAll.Location = New System.Drawing.Point(511, 24)
        Me.cmdRptAll.Name = "cmdRptAll"
        Me.cmdRptAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdRptAll.TabIndex = 3
        Me.cmdRptAll.Text = "ÿ»«⁄… «·ﬂ·"
        Me.cmdRptAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptAll.UseVisualStyleBackColor = False
        '
        'cmdRptFound
        '
        Me.cmdRptFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptFound.Location = New System.Drawing.Point(660, 24)
        Me.cmdRptFound.Name = "cmdRptFound"
        Me.cmdRptFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdRptFound.TabIndex = 2
        Me.cmdRptFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
        Me.cmdRptFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptFound.UseVisualStyleBackColor = False
        '
        'cmdRptDoc
        '
        Me.cmdRptDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptDoc.Location = New System.Drawing.Point(824, 24)
        Me.cmdRptDoc.Name = "cmdRptDoc"
        Me.cmdRptDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdRptDoc.TabIndex = 1
        Me.cmdRptDoc.Text = "ÿ»«⁄… «·≈–‰"
        Me.cmdRptDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptDoc.UseVisualStyleBackColor = False
        '
        'Check3
        '
        Me.Check3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check3.Enabled = False
        Me.Check3.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check3.Location = New System.Drawing.Point(64, 24)
        Me.Check3.Name = "Check3"
        Me.Check3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check3.Size = New System.Drawing.Size(129, 41)
        Me.Check3.TabIndex = 63
        Me.Check3.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.Check3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check3.UseVisualStyleBackColor = False
        '
        'Check2
        '
        Me.Check2.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check2.Enabled = False
        Me.Check2.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check2.Location = New System.Drawing.Point(213, 24)
        Me.Check2.Name = "Check2"
        Me.Check2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check2.Size = New System.Drawing.Size(129, 41)
        Me.Check2.TabIndex = 62
        Me.Check2.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.Check2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check2.UseVisualStyleBackColor = False
        '
        'Check4
        '
        Me.Check4.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check4.Enabled = False
        Me.Check4.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check4.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check4.Location = New System.Drawing.Point(362, 24)
        Me.Check4.Name = "Check4"
        Me.Check4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check4.Size = New System.Drawing.Size(129, 41)
        Me.Check4.TabIndex = 61
        Me.Check4.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.Check4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check4.UseVisualStyleBackColor = False
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdFmtAll)
        Me.Frame9.Controls.Add(Me.cmdFmtFound)
        Me.Frame9.Controls.Add(Me.cmdFmtDoc)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(174, 161)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1009, 81)
        Me.Frame9.TabIndex = 59
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   ’Ì‹‹€‹‹‹‹… Œ‹ÿ‹‹‹‹‹‹‹‹‹‹‹«»   "
        '
        'cmdLogout
        '
        Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(213, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 8
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
        Me.cmdExit.Location = New System.Drawing.Point(64, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(129, 41)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdFmtAll
        '
        Me.cmdFmtAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtAll.Location = New System.Drawing.Point(510, 24)
        Me.cmdFmtAll.Name = "cmdFmtAll"
        Me.cmdFmtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdFmtAll.TabIndex = 6
        Me.cmdFmtAll.Text = "ÿ»«⁄… «·ﬂ·"
        Me.cmdFmtAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtAll.UseVisualStyleBackColor = False
        '
        'cmdFmtFound
        '
        Me.cmdFmtFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtFound.Location = New System.Drawing.Point(659, 24)
        Me.cmdFmtFound.Name = "cmdFmtFound"
        Me.cmdFmtFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdFmtFound.TabIndex = 5
        Me.cmdFmtFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
        Me.cmdFmtFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtFound.UseVisualStyleBackColor = False
        '
        'cmdFmtDoc
        '
        Me.cmdFmtDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtDoc.Location = New System.Drawing.Point(824, 24)
        Me.cmdFmtDoc.Name = "cmdFmtDoc"
        Me.cmdFmtDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdFmtDoc.TabIndex = 4
        Me.cmdFmtDoc.Text = "ÿ»«⁄… «·≈–‰"
        Me.cmdFmtDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtDoc.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(360, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 7
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame8.Controls.Add(Me.cmdSave)
        Me.Frame8.Controls.Add(Me.cmdNew)
        Me.Frame8.Controls.Add(Me.cmdDelete)
        Me.Frame8.Controls.Add(Me.cmdEdit)
        Me.Frame8.Controls.Add(Me.cmdCancel)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(174, 630)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(513, 65)
        Me.Frame8.TabIndex = 58
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(305, 24)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(89, 33)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(400, 24)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(89, 33)
        Me.cmdNew.TabIndex = 14
        Me.cmdNew.Text = "Ã‹‹œÌ‹‹œ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(10, 24)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
        Me.cmdDelete.TabIndex = 17
        Me.cmdDelete.Text = "Õ‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(200, 24)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(89, 33)
        Me.cmdEdit.TabIndex = 16
        Me.cmdEdit.Text = " ‹⁄‹œÌ‹·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(105, 24)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
        Me.cmdCancel.TabIndex = 18
        Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.dtpTo)
        Me.Frame3.Controls.Add(Me.dtpFrom)
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.cmbCriteria)
        Me.Frame3.Controls.Add(Me.cmdFindPrev)
        Me.Frame3.Controls.Add(Me.cmdFindNext)
        Me.Frame3.Controls.Add(Me.cmbDuration)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(687, 509)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(497, 121)
        Me.Frame3.TabIndex = 54
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " «·»‹Õ‹À ⁄‹‰ ”‹Ã‹· "
        '
        'dtpTo
        '
        Me.dtpTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(31, 61)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(83, 20)
        Me.dtpTo.TabIndex = 58
        '
        'dtpFrom
        '
        Me.dtpFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(141, 61)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(97, 20)
        Me.dtpFrom.TabIndex = 58
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(33, 24)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(233, 25)
        Me.txtFind.TabIndex = 40
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "‰„—… «·„·›", " «—ÌŒ «·„·›", " «—ÌŒ Œÿ«» «·ÃÂ… «·ÿ«·»…", "«”„ «·ÃÂ… «·„√–Ê‰ ·Â«", "«”„ «·ÃÂ… «·„Œ«ÿ»…", "«”„ «·ÃÂ… «·„” Ê—œ „‰Â«", "«”„ «·œÊ·…"})
        Me.cmbCriteria.Location = New System.Drawing.Point(296, 24)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(177, 21)
        Me.cmbCriteria.TabIndex = 38
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.Color.White
        Me.cmdFindPrev.Location = New System.Drawing.Point(8, 24)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindPrev.TabIndex = 42
        Me.cmdFindPrev.Text = ">"
        Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindPrev.UseVisualStyleBackColor = False
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.Color.White
        Me.cmdFindNext.Location = New System.Drawing.Point(275, 24)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindNext.TabIndex = 41
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        '
        'cmbDuration
        '
        Me.cmbDuration.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDuration.Items.AddRange(New Object() {"⁄«„", "› —… » «—ÌŒ «·„·›", "› —… » «—ÌŒ «·Œÿ«»"})
        Me.cmbDuration.Location = New System.Drawing.Point(296, 56)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbDuration.Size = New System.Drawing.Size(177, 21)
        Me.cmbDuration.TabIndex = 39
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(248, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(21, 17)
        Me.Label13.TabIndex = 57
        Me.Label13.Text = "„‰"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(120, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(25, 17)
        Me.Label14.TabIndex = 56
        Me.Label14.Text = "≈·‹‹Ï"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(40, 88)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 55
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame4.Controls.Add(Me.dtpSDate)
        Me.Frame4.Controls.Add(Me.txtsSideName)
        Me.Frame4.Controls.Add(Me.txtsID)
        Me.Frame4.Controls.Add(Me.Label20)
        Me.Frame4.Controls.Add(Me.Label21)
        Me.Frame4.Controls.Add(Me.Label22)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(687, 331)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame4.Size = New System.Drawing.Size(497, 89)
        Me.Frame4.TabIndex = 50
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "  »Ì«‰«   Œÿ«» «·ÃÂ… «·ÿ«·»… ·≈” Œ—«Ã «·≈–‰ "
        '
        'dtpSDate
        '
        Me.dtpSDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NOOBJECTIONSBindingSource, "SDATE", True))
        Me.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSDate.Location = New System.Drawing.Point(8, 29)
        Me.dtpSDate.Name = "dtpSDate"
        Me.dtpSDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpSDate.TabIndex = 50
        '
        'txtsSideName
        '
        Me.txtsSideName.AcceptsReturn = True
        Me.txtsSideName.BackColor = System.Drawing.SystemColors.Window
        Me.txtsSideName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "SSIDENAME", True))
        Me.txtsSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsSideName.Location = New System.Drawing.Point(8, 56)
        Me.txtsSideName.MaxLength = 0
        Me.txtsSideName.Multiline = True
        Me.txtsSideName.Name = "txtsSideName"
        Me.txtsSideName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsSideName.Size = New System.Drawing.Size(417, 25)
        Me.txtsSideName.TabIndex = 24
        Me.txtsSideName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtsID
        '
        Me.txtsID.AcceptsReturn = True
        Me.txtsID.BackColor = System.Drawing.SystemColors.Window
        Me.txtsID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "SID", True))
        Me.txtsID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsID.Location = New System.Drawing.Point(208, 24)
        Me.txtsID.MaxLength = 0
        Me.txtsID.Multiline = True
        Me.txtsID.Name = "txtsID"
        Me.txtsID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtsID.Size = New System.Drawing.Size(217, 25)
        Me.txtsID.TabIndex = 22
        Me.txtsID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(136, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 53
        Me.Label20.Text = "«·‹‹ ‹‹‹‹«—ÌŒ"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(424, 64)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(65, 17)
        Me.Label21.TabIndex = 52
        Me.Label21.Text = "«”„ «·ÃÂ…"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(424, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 25)
        Me.Label22.TabIndex = 51
        Me.Label22.Text = "«·‰‹‹„‹‹‹—…"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.dtpFDate)
        Me.Frame1.Controls.Add(Me.txtfSideName)
        Me.Frame1.Controls.Add(Me.txtNoObjectionNO)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.txtfID)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(687, 242)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(497, 89)
        Me.Frame1.TabIndex = 46
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì«‰«  „·› ⁄œ„ «·„„«‰⁄…  "
        '
        'dtpFDate
        '
        Me.dtpFDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.NOOBJECTIONSBindingSource, "FDATE", True))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFDate.Location = New System.Drawing.Point(8, 29)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(128, 20)
        Me.dtpFDate.TabIndex = 50
        '
        'txtfSideName
        '
        Me.txtfSideName.AcceptsReturn = True
        Me.txtfSideName.BackColor = System.Drawing.SystemColors.Window
        Me.txtfSideName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "FSIDENAME", True))
        Me.txtfSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfSideName.Location = New System.Drawing.Point(8, 56)
        Me.txtfSideName.MaxLength = 0
        Me.txtfSideName.Multiline = True
        Me.txtfSideName.Name = "txtfSideName"
        Me.txtfSideName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtfSideName.Size = New System.Drawing.Size(417, 25)
        Me.txtfSideName.TabIndex = 21
        Me.txtfSideName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNoObjectionNO
        '
        Me.txtNoObjectionNO.AcceptsReturn = True
        Me.txtNoObjectionNO.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoObjectionNO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoObjectionNO.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "NoObjectionNo", True))
        Me.txtNoObjectionNO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoObjectionNO.Location = New System.Drawing.Point(207, 24)
        Me.txtNoObjectionNO.MaxLength = 0
        Me.txtNoObjectionNO.Multiline = True
        Me.txtNoObjectionNO.Name = "txtNoObjectionNO"
        Me.txtNoObjectionNO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNoObjectionNO.Size = New System.Drawing.Size(72, 25)
        Me.txtNoObjectionNO.TabIndex = 19
        Me.txtNoObjectionNO.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(272, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(67, 25)
        Me.Label10.TabIndex = 49
        Me.Label10.Text = "«·‰„—…"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtfID
        '
        Me.txtfID.AcceptsReturn = True
        Me.txtfID.BackColor = System.Drawing.SystemColors.Window
        Me.txtfID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NOOBJECTIONSBindingSource, "ID", True))
        Me.txtfID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfID.Location = New System.Drawing.Point(344, 24)
        Me.txtfID.MaxLength = 0
        Me.txtfID.Multiline = True
        Me.txtfID.Name = "txtfID"
        Me.txtfID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtfID.Size = New System.Drawing.Size(81, 25)
        Me.txtfID.TabIndex = 19
        Me.txtfID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(427, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(67, 25)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "«· ”·”·Ì"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(424, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "«”„ «·ÃÂ…"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(136, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "«·‹‹ ‹‹‹‹«—ÌŒ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(687, 630)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(497, 65)
        Me.Frame7.TabIndex = 45
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(56, 24)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(89, 33)
        Me.cmdFirst.TabIndex = 13
        Me.cmdFirst.Text = ">> «·√Ê·"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLast.Location = New System.Drawing.Point(344, 24)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(89, 33)
        Me.cmdLast.TabIndex = 12
        Me.cmdLast.Text = "<< «·√ŒÌ—"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(152, 24)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(89, 33)
        Me.cmdPrev.TabIndex = 11
        Me.cmdPrev.Text = "«·”‹‹‹«»ﬁ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(248, 24)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(89, 33)
        Me.cmdNext.TabIndex = 10
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmbClass)
        Me.Frame2.Controls.Add(Me.cmbUnit)
        Me.Frame2.Controls.Add(Me.nudQuantity)
        Me.Frame2.Controls.Add(Me.DataGridView1)
        Me.Frame2.Controls.Add(Me.cmdPlus)
        Me.Frame2.Controls.Add(Me.cmdRemove)
        Me.Frame2.Controls.Add(Me.Label26)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label23)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(174, 242)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(513, 267)
        Me.Frame2.TabIndex = 64
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "  «·‘‹‹‹‹‹—Êÿ  "
        '
        'cmbClass
        '
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(64, 21)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(277, 21)
        Me.cmbClass.TabIndex = 71
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(357, 22)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(68, 21)
        Me.cmbUnit.TabIndex = 70
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(432, 22)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(67, 20)
        Me.nudQuantity.TabIndex = 69
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.Unit, Me.Description})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 88)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(497, 142)
        Me.DataGridView1.TabIndex = 68
        '
        'Quantity
        '
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "«·ﬂ„Ì…"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.FillWeight = 50.0!
        Me.Unit.HeaderText = "«·ÊÕœ…"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Description
        '
        Me.Description.FillWeight = 151.0!
        Me.Description.HeaderText = "«·’‰›"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label26.Location = New System.Drawing.Point(364, 58)
        Me.Label26.Name = "Label26"
        Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label26.Size = New System.Drawing.Size(65, 13)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "ÊÕœ… «·ﬁÌ«”"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(429, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = " «·⁄œœ √Ê «·ﬂ„Ì…"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(152, 58)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 65
        Me.Label23.Text = "Ê’› «·’‰›"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NOOBJECTIONSTableAdapter
        '
        Me.NOOBJECTIONSTableAdapter.ClearBeforeFill = True
        '
        'NoObjectionDetailsTableAdapter
        '
        Me.NoObjectionDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmNoObjections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1244, 734)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmNoObjections"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Œ‹‹‹ÿ‹‹‹‹«»«  ⁄‹‹‹‹œ„ «·„„‹‹‹‹«‰‹⁄‹‹‹‹…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankNOOBJECTIONSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        Me.Frame10.ResumeLayout(False)
        Me.Frame9.ResumeLayout(False)
        Me.Frame8.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpSDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents NOOBJECTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOOBJECTIONSTableAdapter As Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter
    Friend WithEvents NoObjectionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.NoObjectionDetailsTableAdapter
    Friend WithEvents RankNOOBJECTIONSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents NameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PositionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionDsExplosives1 As Explosives.dsExplosives
    Public WithEvents txtNoObjectionNO As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
#End Region
End Class