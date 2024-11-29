<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmImportPermissions
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
	Public WithEvents mnuDefAll As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDefBacks As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAll As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuBack As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuButtons As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuTexts As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLabels As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFrames As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuActiveControl As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuEmpty As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuBacks As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuDefFont As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnufAll As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnufButtons As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnufTexts As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFLabels As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFFrames As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFonts As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuColours As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuPay As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	Public WithEvents cmbDuration As System.Windows.Forms.ComboBox
	Public WithEvents txtDate1 As System.Windows.Forms.TextBox
    Public WithEvents txtDate2 As System.Windows.Forms.TextBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Public WithEvents lblPosition As System.Windows.Forms.Label
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
    Public WithEvents cmdFmtDoc As System.Windows.Forms.CheckBox
    Public WithEvents cmdFmtFound As System.Windows.Forms.CheckBox
    Public WithEvents cmdFmtAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdExit As System.Windows.Forms.CheckBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents cmdRptAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdRptFound As System.Windows.Forms.CheckBox
    Public WithEvents cmdRptDoc As System.Windows.Forms.CheckBox
    Public WithEvents Check3 As System.Windows.Forms.CheckBox
    Public WithEvents Check2 As System.Windows.Forms.CheckBox
    Public WithEvents Check4 As System.Windows.Forms.CheckBox
    Public WithEvents Frame10 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents txtPoint1 As System.Windows.Forms.TextBox
    Public WithEvents txtPoint2 As System.Windows.Forms.TextBox
    Public WithEvents txtPoint3 As System.Windows.Forms.TextBox
    Public WithEvents txtPort As System.Windows.Forms.TextBox
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPermitted As System.Windows.Forms.ComboBox
    Public WithEvents txtAddress As System.Windows.Forms.TextBox
    Public WithEvents txtCraftsManship As System.Windows.Forms.TextBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmbYear As System.Windows.Forms.ComboBox
    Public WithEvents txtNoObjectionID As System.Windows.Forms.TextBox
    Public WithEvents txtID As System.Windows.Forms.TextBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDefAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBacks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDefBacks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBack = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuButtons = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTexts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFrames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActiveControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEmpty = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFonts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDefFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnufAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnufButtons = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnufTexts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFLabels = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFFrames = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.btnMovementForm = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFmtDoc = New System.Windows.Forms.CheckBox()
        Me.cmdFmtFound = New System.Windows.Forms.CheckBox()
        Me.cmdFmtAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.Frame10 = New System.Windows.Forms.GroupBox()
        Me.cmdRptAll = New System.Windows.Forms.CheckBox()
        Me.cmdRptFound = New System.Windows.Forms.CheckBox()
        Me.cmdRptDoc = New System.Windows.Forms.CheckBox()
        Me.Check3 = New System.Windows.Forms.CheckBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.Check4 = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.IMPORTPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.NameIMPORTPERMISSIONSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionIMPORTPERMISSIONSBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankIMPORTPERMISSIONSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtPoint1 = New System.Windows.Forms.TextBox()
        Me.txtPoint2 = New System.Windows.Forms.TextBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.UnitBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDsExplosives1 = New Explosives.dsExplosives()
        Me.txtPoint3 = New System.Windows.Forms.TextBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.DescriptionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DescriptionDsExplosives1 = New Explosives.dsExplosives()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbPermitted = New System.Windows.Forms.ComboBox()
        Me.IMPORTALLOWEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCraftsManship = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NOOBJECTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WORKALLOWEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.txtNoObjectionID = New System.Windows.Forms.TextBox()
        Me.txtImportPermissionNo = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.IMPORTPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter()
        Me.TableAdapterManager = New Explosives.dsExplosivesTableAdapters.TableAdapterManager()
        Me.NOOBJECTIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.dtpSDate = New System.Windows.Forms.DateTimePicker()
        Me.WORKALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKALLOWEDTableAdapter()
        Me.ImportPermissionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter()
        Me.IMPORTALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame10.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameIMPORTPERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionIMPORTPERMISSIONSBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankIMPORTPERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        CType(Me.UnitBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DescriptionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame2.SuspendLayout()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WORKALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(322, 50)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(21, 25)
        Me.cmdPlus.TabIndex = 81
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
        Me.cmdRemove.Location = New System.Drawing.Point(301, 51)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(25, 24)
        Me.cmdRemove.TabIndex = 82
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
        Me.MainMenu1.Size = New System.Drawing.Size(1370, 24)
        Me.MainMenu1.TabIndex = 57
        '
        'mnuColours
        '
        Me.mnuColours.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDefAll, Me.mnuBacks, Me.mnuFonts})
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'mnuDefAll
        '
        Me.mnuDefAll.Name = "mnuDefAll"
        Me.mnuDefAll.Size = New System.Drawing.Size(120, 22)
        Me.mnuDefAll.Text = "«·«› —«÷Ì"
        '
        'mnuBacks
        '
        Me.mnuBacks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDefBacks, Me.mnuAll, Me.mnuBack, Me.mnuButtons, Me.mnuTexts, Me.mnuLabels, Me.mnuFrames, Me.mnuActiveControl, Me.mnuEmpty})
        Me.mnuBacks.Name = "mnuBacks"
        Me.mnuBacks.Size = New System.Drawing.Size(120, 22)
        Me.mnuBacks.Text = "«·Œ·›Ì« "
        '
        'mnuDefBacks
        '
        Me.mnuDefBacks.Name = "mnuDefBacks"
        Me.mnuDefBacks.Size = New System.Drawing.Size(212, 22)
        Me.mnuDefBacks.Text = "«·«› —«÷Ì"
        '
        'mnuAll
        '
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(212, 22)
        Me.mnuAll.Text = "«·ﬂ·"
        '
        'mnuBack
        '
        Me.mnuBack.Name = "mnuBack"
        Me.mnuBack.Size = New System.Drawing.Size(212, 22)
        Me.mnuBack.Text = "«·⁄«„…"
        '
        'mnuButtons
        '
        Me.mnuButtons.Name = "mnuButtons"
        Me.mnuButtons.Size = New System.Drawing.Size(212, 22)
        Me.mnuButtons.Text = "«·√“—«—"
        '
        'mnuTexts
        '
        Me.mnuTexts.Name = "mnuTexts"
        Me.mnuTexts.Size = New System.Drawing.Size(212, 22)
        Me.mnuTexts.Text = "’‰«œÌﬁ «·‰’"
        '
        'mnuLabels
        '
        Me.mnuLabels.Name = "mnuLabels"
        Me.mnuLabels.Size = New System.Drawing.Size(212, 22)
        Me.mnuLabels.Text = "«· ”„Ì« "
        '
        'mnuFrames
        '
        Me.mnuFrames.Name = "mnuFrames"
        Me.mnuFrames.Size = New System.Drawing.Size(212, 22)
        Me.mnuFrames.Text = "«·≈ÿ«—« "
        '
        'mnuActiveControl
        '
        Me.mnuActiveControl.Name = "mnuActiveControl"
        Me.mnuActiveControl.Size = New System.Drawing.Size(212, 22)
        Me.mnuActiveControl.Text = "«·√œ«… «·‰‘ÿ…"
        '
        'mnuEmpty
        '
        Me.mnuEmpty.Name = "mnuEmpty"
        Me.mnuEmpty.Size = New System.Drawing.Size(212, 22)
        Me.mnuEmpty.Text = "«·’‰«œÌﬁ «·›«—€… ⁄‰œ «·≈œŒ«·"
        '
        'mnuFonts
        '
        Me.mnuFonts.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDefFont, Me.mnufAll, Me.mnufButtons, Me.mnufTexts, Me.mnuFLabels, Me.mnuFFrames})
        Me.mnuFonts.Name = "mnuFonts"
        Me.mnuFonts.Size = New System.Drawing.Size(120, 22)
        Me.mnuFonts.Text = "«·Œÿ"
        '
        'mnuDefFont
        '
        Me.mnuDefFont.Name = "mnuDefFont"
        Me.mnuDefFont.Size = New System.Drawing.Size(142, 22)
        Me.mnuDefFont.Text = "«·«› —«÷Ì"
        '
        'mnufAll
        '
        Me.mnufAll.Name = "mnufAll"
        Me.mnufAll.Size = New System.Drawing.Size(142, 22)
        Me.mnufAll.Text = "«·ﬂ·"
        '
        'mnufButtons
        '
        Me.mnufButtons.Name = "mnufButtons"
        Me.mnufButtons.Size = New System.Drawing.Size(142, 22)
        Me.mnufButtons.Text = "«·√“—«—"
        '
        'mnufTexts
        '
        Me.mnufTexts.Name = "mnufTexts"
        Me.mnufTexts.Size = New System.Drawing.Size(142, 22)
        Me.mnufTexts.Text = "’‰«œÌﬁ «·‰’"
        '
        'mnuFLabels
        '
        Me.mnuFLabels.Name = "mnuFLabels"
        Me.mnuFLabels.Size = New System.Drawing.Size(142, 22)
        Me.mnuFLabels.Text = "«· ”„Ì« "
        '
        'mnuFFrames
        '
        Me.mnuFFrames.Name = "mnuFFrames"
        Me.mnuFFrames.Size = New System.Drawing.Size(142, 22)
        Me.mnuFFrames.Text = "«·≈ÿ«—« "
        '
        'mnuPay
        '
        Me.mnuPay.Name = "mnuPay"
        Me.mnuPay.Size = New System.Drawing.Size(135, 20)
        Me.mnuPay.Text = " √ﬂÌœ œ›⁄ «·—”Ê„ «·„«·Ì…"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        'Frame8
        '
        Me.Frame8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame8.Controls.Add(Me.cmbDuration)
        Me.Frame8.Controls.Add(Me.cmbCriteria)
        Me.Frame8.Controls.Add(Me.txtFind)
        Me.Frame8.Controls.Add(Me.txtDate1)
        Me.Frame8.Controls.Add(Me.txtDate2)
        Me.Frame8.Controls.Add(Me.lblPosition)
        Me.Frame8.Controls.Add(Me.Label14)
        Me.Frame8.Controls.Add(Me.Label10)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(647, 382)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(489, 188)
        Me.Frame8.TabIndex = 56
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " «·»‹Õ‹À ⁄‹‰ ”‹Ã‹· "
        '
        'cmbDuration
        '
        Me.cmbDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDuration.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDuration.Items.AddRange(New Object() {"⁄«„", "› —… » «—ÌŒ «·„·›", "› —… » «—ÌŒ «·Œÿ«»"})
        Me.cmbDuration.Location = New System.Drawing.Point(297, 80)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbDuration.Size = New System.Drawing.Size(177, 21)
        Me.cmbDuration.TabIndex = 63
        '
        'cmbCriteria
        '
        Me.cmbCriteria.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "‰„—… «· ’—ÌÕ", " «—ÌŒ «· ’—ÌÕ", "‰„—… Œÿ«» «·ÃÂ…", " «—ÌŒ Œÿ«» «·ÃÂ…", "«·ÃÂ… «·„„‰ÊÕ…", "⁄‰Ê«‰ «·ÃÂ… «·„„‰ÊÕ…", "„Ì‰«¡ «·œŒÊ·"})
        Me.cmbCriteria.Location = New System.Drawing.Point(297, 48)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(177, 21)
        Me.cmbCriteria.TabIndex = 58
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(34, 48)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(233, 25)
        Me.txtFind.TabIndex = 57
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDate1
        '
        Me.txtDate1.AcceptsReturn = True
        Me.txtDate1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate1.Location = New System.Drawing.Point(162, 80)
        Me.txtDate1.MaxLength = 0
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate1.Size = New System.Drawing.Size(81, 20)
        Me.txtDate1.TabIndex = 62
        Me.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDate2
        '
        Me.txtDate2.AcceptsReturn = True
        Me.txtDate2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate2.Location = New System.Drawing.Point(34, 80)
        Me.txtDate2.MaxLength = 0
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate2.Size = New System.Drawing.Size(81, 20)
        Me.txtDate2.TabIndex = 59
        Me.txtDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPosition
        '
        Me.lblPosition.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPosition.BackColor = System.Drawing.SystemColors.Control
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(41, 112)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 66
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(121, 88)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(25, 17)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "≈·‹‹Ï"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(249, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(17, 17)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "„‰"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame9
        '
        Me.Frame9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.btnMovementForm)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFmtDoc)
        Me.Frame9.Controls.Add(Me.cmdFmtFound)
        Me.Frame9.Controls.Add(Me.cmdFmtAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(222, 144)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(913, 81)
        Me.Frame9.TabIndex = 55
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   ’Ì‹‹€‹‹‹‹… Œ‹ÿ‹‹‹‹‹‹‹‹‹‹‹«»   "
        '
        'btnMovementForm
        '
        Me.btnMovementForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnMovementForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMovementForm.Font = New System.Drawing.Font("Traditional Arabic", 16.0!, System.Drawing.FontStyle.Bold)
        Me.btnMovementForm.ForeColor = System.Drawing.Color.White
        Me.btnMovementForm.Location = New System.Drawing.Point(697, 24)
        Me.btnMovementForm.Name = "btnMovementForm"
        Me.btnMovementForm.Size = New System.Drawing.Size(145, 41)
        Me.btnMovementForm.TabIndex = 10
        Me.btnMovementForm.Text = "«Ê—‰Ìﬂ «· Õ—ﬂ« "
        Me.btnMovementForm.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(238, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(105, 41)
        Me.cmdReturn.TabIndex = 7
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdFmtDoc
        '
        Me.cmdFmtDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtDoc.Location = New System.Drawing.Point(585, 24)
        Me.cmdFmtDoc.Name = "cmdFmtDoc"
        Me.cmdFmtDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtDoc.Size = New System.Drawing.Size(105, 41)
        Me.cmdFmtDoc.TabIndex = 4
        Me.cmdFmtDoc.Text = "ÿ»«⁄… «·≈–‰"
        Me.cmdFmtDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtDoc.UseVisualStyleBackColor = False
        '
        'cmdFmtFound
        '
        Me.cmdFmtFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtFound.Location = New System.Drawing.Point(460, 24)
        Me.cmdFmtFound.Name = "cmdFmtFound"
        Me.cmdFmtFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtFound.Size = New System.Drawing.Size(121, 41)
        Me.cmdFmtFound.TabIndex = 5
        Me.cmdFmtFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
        Me.cmdFmtFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtFound.UseVisualStyleBackColor = False
        '
        'cmdFmtAll
        '
        Me.cmdFmtAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtAll.Location = New System.Drawing.Point(349, 24)
        Me.cmdFmtAll.Name = "cmdFmtAll"
        Me.cmdFmtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtAll.Size = New System.Drawing.Size(105, 41)
        Me.cmdFmtAll.TabIndex = 6
        Me.cmdFmtAll.Text = "ÿ»«⁄… «·ﬂ·"
        Me.cmdFmtAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtAll.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdExit.Location = New System.Drawing.Point(16, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(105, 41)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(127, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(105, 41)
        Me.cmdLogout.TabIndex = 8
        Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Frame10
        '
        Me.Frame10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame10.Controls.Add(Me.cmdRptAll)
        Me.Frame10.Controls.Add(Me.cmdRptFound)
        Me.Frame10.Controls.Add(Me.cmdRptDoc)
        Me.Frame10.Controls.Add(Me.Check3)
        Me.Frame10.Controls.Add(Me.Check2)
        Me.Frame10.Controls.Add(Me.Check4)
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(222, 63)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame10.Size = New System.Drawing.Size(913, 81)
        Me.Frame10.TabIndex = 51
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "   ’Ì‹€‹‹‹‹…  ﬁ‹‹‹‹‹‹‹‹‹‹‹‹‹—Ì—  "
        '
        'cmdRptAll
        '
        Me.cmdRptAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptAll.Location = New System.Drawing.Point(434, 24)
        Me.cmdRptAll.Name = "cmdRptAll"
        Me.cmdRptAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptAll.Size = New System.Drawing.Size(105, 41)
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
        Me.cmdRptFound.Location = New System.Drawing.Point(573, 24)
        Me.cmdRptFound.Name = "cmdRptFound"
        Me.cmdRptFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptFound.Size = New System.Drawing.Size(121, 41)
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
        Me.cmdRptDoc.Location = New System.Drawing.Point(728, 24)
        Me.cmdRptDoc.Name = "cmdRptDoc"
        Me.cmdRptDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptDoc.Size = New System.Drawing.Size(105, 41)
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
        Me.Check3.Location = New System.Drawing.Point(16, 24)
        Me.Check3.Name = "Check3"
        Me.Check3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check3.Size = New System.Drawing.Size(105, 41)
        Me.Check3.TabIndex = 54
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
        Me.Check2.Location = New System.Drawing.Point(156, 24)
        Me.Check2.Name = "Check2"
        Me.Check2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check2.Size = New System.Drawing.Size(105, 41)
        Me.Check2.TabIndex = 53
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
        Me.Check4.Location = New System.Drawing.Point(295, 24)
        Me.Check4.Name = "Check4"
        Me.Check4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check4.Size = New System.Drawing.Size(105, 41)
        Me.Check4.TabIndex = 52
        Me.Check4.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.Check4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check4.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(647, 571)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(489, 51)
        Me.Frame6.TabIndex = 50
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdEdit
        '
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cmdEdit.ForeColor = System.Drawing.Color.White
        Me.cmdEdit.Location = New System.Drawing.Point(206, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(86, 29)
        Me.cmdEdit.TabIndex = 15
        Me.cmdEdit.Text = " ⁄‹‹‹‹œÌ·"
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(111, 14)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
        Me.cmdCancel.TabIndex = 14
        Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
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
        Me.cmdSave.Location = New System.Drawing.Point(293, 14)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(89, 33)
        Me.cmdSave.TabIndex = 11
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
        Me.cmdNew.Location = New System.Drawing.Point(386, 14)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(89, 33)
        Me.cmdNew.TabIndex = 10
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
        Me.cmdDelete.Location = New System.Drawing.Point(11, 14)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
        Me.cmdDelete.TabIndex = 13
        Me.cmdDelete.Text = "Õ‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(647, 622)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(489, 68)
        Me.Frame7.TabIndex = 49
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(24, 24)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(89, 33)
        Me.cmdFirst.TabIndex = 18
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
        Me.cmdLast.Location = New System.Drawing.Point(376, 24)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(89, 33)
        Me.cmdLast.TabIndex = 17
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
        Me.cmdPrev.Location = New System.Drawing.Point(142, 24)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(89, 33)
        Me.cmdPrev.TabIndex = 16
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
        Me.cmdNext.Location = New System.Drawing.Point(259, 24)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(89, 33)
        Me.cmdNext.TabIndex = 15
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.cmbName)
        Me.Frame5.Controls.Add(Me.cmbPosition)
        Me.Frame5.Controls.Add(Me.cmbRank)
        Me.Frame5.Controls.Add(Me.Label8)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Controls.Add(Me.Label12)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(222, 560)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(425, 130)
        Me.Frame5.TabIndex = 41
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " ’œ—  Õ   ÊﬁÌ⁄ "
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IMPORTPERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataSource = Me.NameIMPORTPERMISSIONSBindingSource2
        Me.cmbName.DisplayMember = "NAME"
        Me.cmbName.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(8, 48)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(329, 37)
        Me.cmbName.TabIndex = 70
        Me.cmbName.ValueMember = "NAME"
        '
        'IMPORTPERMISSIONSBindingSource
        '
        Me.IMPORTPERMISSIONSBindingSource.DataMember = "IMPORTPERMISSIONS"
        Me.IMPORTPERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameIMPORTPERMISSIONSBindingSource2
        '
        Me.NameIMPORTPERMISSIONSBindingSource2.DataMember = "IMPORTPERMISSIONS"
        Me.NameIMPORTPERMISSIONSBindingSource2.DataSource = Me.NameDsExplosives1
        '
        'NameDsExplosives1
        '
        Me.NameDsExplosives1.DataSetName = "dsExplosives"
        Me.NameDsExplosives1.EnforceConstraints = False
        Me.NameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IMPORTPERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataSource = Me.PositionIMPORTPERMISSIONSBindingSource3
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(8, 88)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(329, 37)
        Me.cmbPosition.TabIndex = 69
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'PositionIMPORTPERMISSIONSBindingSource3
        '
        Me.PositionIMPORTPERMISSIONSBindingSource3.DataMember = "IMPORTPERMISSIONS"
        Me.PositionIMPORTPERMISSIONSBindingSource3.DataSource = Me.PositionDsExplosives1
        '
        'PositionDsExplosives1
        '
        Me.PositionDsExplosives1.DataSetName = "dsExplosives"
        Me.PositionDsExplosives1.EnforceConstraints = False
        Me.PositionDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IMPORTPERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataSource = Me.RankIMPORTPERMISSIONSBindingSource1
        Me.cmbRank.DisplayMember = "RANK"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(8, 24)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(329, 21)
        Me.cmbRank.TabIndex = 68
        Me.cmbRank.ValueMember = "RANK"
        '
        'RankIMPORTPERMISSIONSBindingSource1
        '
        Me.RankIMPORTPERMISSIONSBindingSource1.DataMember = "IMPORTPERMISSIONS"
        Me.RankIMPORTPERMISSIONSBindingSource1.DataSource = Me.RankDsExplosives1
        '
        'RankDsExplosives1
        '
        Me.RankDsExplosives1.DataSetName = "dsExplosives"
        Me.RankDsExplosives1.EnforceConstraints = False
        Me.RankDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(344, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "«·— »… "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(344, 58)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "«·«”‹‹‹„"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(344, 98)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "«·„‰’»"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame3
        '
        Me.Frame3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.cmdPlus)
        Me.Frame3.Controls.Add(Me.txtPoint1)
        Me.Frame3.Controls.Add(Me.cmdRemove)
        Me.Frame3.Controls.Add(Me.txtPoint2)
        Me.Frame3.Controls.Add(Me.cmbUnit)
        Me.Frame3.Controls.Add(Me.txtPoint3)
        Me.Frame3.Controls.Add(Me.nudQuantity)
        Me.Frame3.Controls.Add(Me.txtPort)
        Me.Frame3.Controls.Add(Me.cmbClass)
        Me.Frame3.Controls.Add(Me.Label9)
        Me.Frame3.Controls.Add(Me.DataGridView1)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label4)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(222, 352)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(425, 213)
        Me.Frame3.TabIndex = 37
        Me.Frame3.TabStop = False
        Me.Frame3.Text = "  »Ì«‰«  «·‘Õ‰…  "
        '
        'txtPoint1
        '
        Me.txtPoint1.AcceptsReturn = True
        Me.txtPoint1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "POINT1", True))
        Me.txtPoint1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint1.Location = New System.Drawing.Point(224, 182)
        Me.txtPoint1.MaxLength = 0
        Me.txtPoint1.Name = "txtPoint1"
        Me.txtPoint1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint1.Size = New System.Drawing.Size(113, 20)
        Me.txtPoint1.TabIndex = 28
        '
        'txtPoint2
        '
        Me.txtPoint2.AcceptsReturn = True
        Me.txtPoint2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "POINT2", True))
        Me.txtPoint2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint2.Location = New System.Drawing.Point(120, 182)
        Me.txtPoint2.MaxLength = 0
        Me.txtPoint2.Name = "txtPoint2"
        Me.txtPoint2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint2.Size = New System.Drawing.Size(97, 20)
        Me.txtPoint2.TabIndex = 29
        '
        'cmbUnit
        '
        Me.cmbUnit.DataSource = Me.UnitBindingSource1
        Me.cmbUnit.DisplayMember = "Unit"
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(73, 51)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(68, 21)
        Me.cmbUnit.TabIndex = 80
        Me.cmbUnit.ValueMember = "Unit"
        '
        'UnitBindingSource1
        '
        Me.UnitBindingSource1.DataMember = "ImportPermissionDetails"
        Me.UnitBindingSource1.DataSource = Me.UnitDsExplosives1
        '
        'UnitDsExplosives1
        '
        Me.UnitDsExplosives1.DataSetName = "dsExplosives"
        Me.UnitDsExplosives1.EnforceConstraints = False
        Me.UnitDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPoint3
        '
        Me.txtPoint3.AcceptsReturn = True
        Me.txtPoint3.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "POINT3", True))
        Me.txtPoint3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint3.Location = New System.Drawing.Point(8, 182)
        Me.txtPoint3.MaxLength = 0
        Me.txtPoint3.Name = "txtPoint3"
        Me.txtPoint3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint3.Size = New System.Drawing.Size(105, 20)
        Me.txtPoint3.TabIndex = 30
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(8, 52)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(59, 20)
        Me.nudQuantity.TabIndex = 79
        '
        'txtPort
        '
        Me.txtPort.AcceptsReturn = True
        Me.txtPort.BackColor = System.Drawing.SystemColors.Window
        Me.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPort.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "PORT", True))
        Me.txtPort.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPort.Location = New System.Drawing.Point(8, 24)
        Me.txtPort.MaxLength = 0
        Me.txtPort.Name = "txtPort"
        Me.txtPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPort.Size = New System.Drawing.Size(329, 20)
        Me.txtPort.TabIndex = 26
        '
        'cmbClass
        '
        Me.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClass.DataSource = Me.DescriptionBindingSource1
        Me.cmbClass.DisplayMember = "Description"
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(153, 51)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(147, 21)
        Me.cmbClass.TabIndex = 78
        Me.cmbClass.ValueMember = "Description"
        '
        'DescriptionBindingSource1
        '
        Me.DescriptionBindingSource1.DataMember = "ImportPermissionDetails"
        Me.DescriptionBindingSource1.DataSource = Me.DescriptionDsExplosives1
        '
        'DescriptionDsExplosives1
        '
        Me.DescriptionDsExplosives1.DataSetName = "dsExplosives"
        Me.DescriptionDsExplosives1.EnforceConstraints = False
        Me.DescriptionDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(344, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Œÿ «·”Ì‹‹‹—"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Unit, Me.Quantity})
        Me.DataGridView1.Location = New System.Drawing.Point(8, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(333, 98)
        Me.DataGridView1.TabIndex = 77
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.FillWeight = 130.0!
        Me.Description.HeaderText = "«·Ê’›"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.FillWeight = 70.0!
        Me.Unit.HeaderText = "«·ÊÕœ…"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "«·ﬂ„Ì…"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(344, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(78, 19)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "„Ì‰«¡ «·≈” Ì—«œ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(342, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(77, 45)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "«”„ ‰„—… «·„›—ﬁ⁄«  √Ê«·Ê“‰ «·’«›Ì"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame2
        '
        Me.Frame2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmbPermitted)
        Me.Frame2.Controls.Add(Me.txtAddress)
        Me.Frame2.Controls.Add(Me.txtCraftsManship)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(222, 223)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(425, 129)
        Me.Frame2.TabIndex = 34
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "  »Ì«‰«  «·„” Ê—œ  "
        '
        'cmbPermitted
        '
        Me.cmbPermitted.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPermitted.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPermitted.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IMPORTPERMISSIONSBindingSource, "PERMITTED", True))
        Me.cmbPermitted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "PERMITTED", True))
        Me.cmbPermitted.DataSource = Me.IMPORTALLOWEDBindingSource
        Me.cmbPermitted.DisplayMember = "SIDENAME"
        Me.cmbPermitted.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPermitted.Location = New System.Drawing.Point(8, 24)
        Me.cmbPermitted.Name = "cmbPermitted"
        Me.cmbPermitted.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPermitted.Size = New System.Drawing.Size(329, 21)
        Me.cmbPermitted.TabIndex = 71
        Me.cmbPermitted.ValueMember = "SIDENAME"
        '
        'IMPORTALLOWEDBindingSource
        '
        Me.IMPORTALLOWEDBindingSource.DataMember = "IMPORTALLOWED"
        Me.IMPORTALLOWEDBindingSource.DataSource = Me.DsExplosives
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "ADDRESS", True))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(8, 88)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAddress.Size = New System.Drawing.Size(329, 20)
        Me.txtAddress.TabIndex = 25
        '
        'txtCraftsManship
        '
        Me.txtCraftsManship.AcceptsReturn = True
        Me.txtCraftsManship.BackColor = System.Drawing.SystemColors.Window
        Me.txtCraftsManship.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCraftsManship.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "CRAFTSMANSHIP", True))
        Me.txtCraftsManship.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCraftsManship.Location = New System.Drawing.Point(8, 56)
        Me.txtCraftsManship.MaxLength = 0
        Me.txtCraftsManship.Name = "txtCraftsManship"
        Me.txtCraftsManship.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCraftsManship.Size = New System.Drawing.Size(329, 20)
        Me.txtCraftsManship.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(344, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "⁄‰Ê«‰Â"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(344, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(57, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Õ—› Â"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(344, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "«”„ «·„„‰ÊÕ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NOOBJECTIONSBindingSource
        '
        Me.NOOBJECTIONSBindingSource.DataMember = "NOOBJECTIONS"
        Me.NOOBJECTIONSBindingSource.DataSource = Me.DsExplosives
        '
        'WORKALLOWEDBindingSource
        '
        Me.WORKALLOWEDBindingSource.DataMember = "WORKALLOWED"
        Me.WORKALLOWEDBindingSource.DataSource = Me.DsExplosives
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.dtpFDate)
        Me.Frame1.Controls.Add(Me.cmbYear)
        Me.Frame1.Controls.Add(Me.txtNoObjectionID)
        Me.Frame1.Controls.Add(Me.txtImportPermissionNo)
        Me.Frame1.Controls.Add(Me.txtID)
        Me.Frame1.Controls.Add(Me.Label15)
        Me.Frame1.Controls.Add(Me.Label16)
        Me.Frame1.Controls.Add(Me.Label13)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(647, 223)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(489, 108)
        Me.Frame1.TabIndex = 31
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì‰«  «·„·›  "
        '
        'dtpFDate
        '
        Me.dtpFDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IMPORTPERMISSIONSBindingSource, "FDATE", True))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFDate.Location = New System.Drawing.Point(24, 32)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpFDate.RightToLeftLayout = True
        Me.dtpFDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpFDate.TabIndex = 74
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.SystemColors.Window
        Me.cmbYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbYear.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.IMPORTPERMISSIONSBindingSource, "FDATE", True))
        Me.cmbYear.DataSource = Me.NOOBJECTIONSBindingSource
        Me.cmbYear.DisplayMember = "FDATE"
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbYear.Location = New System.Drawing.Point(379, 74)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbYear.Size = New System.Drawing.Size(97, 21)
        Me.cmbYear.TabIndex = 72
        Me.cmbYear.ValueMember = "FDATE"
        '
        'txtNoObjectionID
        '
        Me.txtNoObjectionID.AcceptsReturn = True
        Me.txtNoObjectionID.BackColor = System.Drawing.SystemColors.Window
        Me.txtNoObjectionID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNoObjectionID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "NOOBJECTIONID", True))
        Me.txtNoObjectionID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNoObjectionID.Location = New System.Drawing.Point(251, 74)
        Me.txtNoObjectionID.MaxLength = 0
        Me.txtNoObjectionID.Name = "txtNoObjectionID"
        Me.txtNoObjectionID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtNoObjectionID.Size = New System.Drawing.Size(121, 20)
        Me.txtNoObjectionID.TabIndex = 20
        Me.txtNoObjectionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImportPermissionNo
        '
        Me.txtImportPermissionNo.AcceptsReturn = True
        Me.txtImportPermissionNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtImportPermissionNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImportPermissionNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "ImportPermissionNo", True))
        Me.txtImportPermissionNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtImportPermissionNo.Location = New System.Drawing.Point(171, 35)
        Me.txtImportPermissionNo.MaxLength = 0
        Me.txtImportPermissionNo.Name = "txtImportPermissionNo"
        Me.txtImportPermissionNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtImportPermissionNo.Size = New System.Drawing.Size(121, 20)
        Me.txtImportPermissionNo.TabIndex = 19
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "ID", True))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(360, 32)
        Me.txtID.MaxLength = 0
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(121, 20)
        Me.txtID.TabIndex = 19
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(371, 58)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(113, 17)
        Me.Label15.TabIndex = 73
        Me.Label15.Text = "”‰… „·› ⁄œ„ «·„„«‰⁄…"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(203, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(65, 17)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "‰„—… «· ’—ÌÕ"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(248, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(129, 20)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "‰„—… „·› ⁄œ„ «·„„«‰⁄…"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(392, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "«· ”·”·Ì"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(48, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "«· «—ÌŒ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IMPORTPERMISSIONSTableAdapter
        '
        Me.IMPORTPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AmmoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLASSESTableAdapter = Nothing
        Me.TableAdapterManager.ConditionsTableAdapter = Nothing
        Me.TableAdapterManager.FinanceDetailsTableAdapter = Nothing
        Me.TableAdapterManager.FINANCETableAdapter = Nothing
        Me.TableAdapterManager.FireworksRequestDetailsTableAdapter = Nothing
        Me.TableAdapterManager.FireworksRequestsTableAdapter = Nothing
        Me.TableAdapterManager.FireworksTableAdapter = Nothing
        Me.TableAdapterManager.FuelStationsTableAdapter = Nothing
        Me.TableAdapterManager.GasCentersTableAdapter = Nothing
        Me.TableAdapterManager.GasDepotsTableAdapter = Nothing
        Me.TableAdapterManager.IMPORTALLOWEDTableAdapter = Nothing
        Me.TableAdapterManager.ImportPermissionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.IMPORTPERMISSIONSTableAdapter = Me.IMPORTPERMISSIONSTableAdapter
        Me.TableAdapterManager.MovementFormDetialsTableAdapter = Nothing
        Me.TableAdapterManager.MovementFormsTableAdapter = Nothing
        Me.TableAdapterManager.NoObjectionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.NOOBJECTIONSTableAdapter = Nothing
        Me.TableAdapterManager.OurDistractDetailsTableAdapter = Nothing
        Me.TableAdapterManager.OURDISTRACTTableAdapter = Nothing
        Me.TableAdapterManager.OurImportDetailsTableAdapter = Nothing
        Me.TableAdapterManager.OURIMPORTTableAdapter = Nothing
        Me.TableAdapterManager.PassCopiesDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PassCopiesTableAdapter = Nothing
        Me.TableAdapterManager.PermissionDetailsTableAdapter = Nothing
        Me.TableAdapterManager.PermissionNamesTableAdapter = Nothing
        Me.TableAdapterManager.PermissionsCopiesTableAdapter = Nothing
        Me.TableAdapterManager.PERMISSIONSTableAdapter = Nothing
        Me.TableAdapterManager.SecurityTableAdapter = Nothing
        Me.TableAdapterManager.StatesTableAdapter = Nothing
        Me.TableAdapterManager.TeamsTableAdapter = Nothing
        Me.TableAdapterManager.TownshipsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Explosives.dsExplosivesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WORKALLOWEDTableAdapter = Nothing
        Me.TableAdapterManager.WorkCopiesDetailsTableAdapter = Nothing
        Me.TableAdapterManager.WorkCopiesTableAdapter = Nothing
        Me.TableAdapterManager.WORKPERMISSIONSTableAdapter = Nothing
        '
        'NOOBJECTIONSTableAdapter
        '
        Me.NOOBJECTIONSTableAdapter.ClearBeforeFill = True
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(416, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 46
        Me.Label22.Text = "«·‰‹‹„‹‹‹—…"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(160, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(57, 17)
        Me.Label20.TabIndex = 47
        Me.Label20.Text = "«·‹‹ ‹‹‹‹«—ÌŒ"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSID
        '
        Me.txtSID.AcceptsReturn = True
        Me.txtSID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTPERMISSIONSBindingSource, "SID", True))
        Me.txtSID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSID.Location = New System.Drawing.Point(272, 24)
        Me.txtSID.MaxLength = 0
        Me.txtSID.Multiline = True
        Me.txtSID.Name = "txtSID"
        Me.txtSID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSID.Size = New System.Drawing.Size(145, 25)
        Me.txtSID.TabIndex = 22
        Me.txtSID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frame4
        '
        Me.Frame4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame4.Controls.Add(Me.dtpSDate)
        Me.Frame4.Controls.Add(Me.txtSID)
        Me.Frame4.Controls.Add(Me.Label20)
        Me.Frame4.Controls.Add(Me.Label22)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(647, 321)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame4.Size = New System.Drawing.Size(489, 64)
        Me.Frame4.TabIndex = 45
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "  »Ì«‰«   Œÿ«» «·ÃÂ… «·ÿ«·»… ·≈” Œ—«Ã «·≈–‰ "
        '
        'dtpSDate
        '
        Me.dtpSDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpSDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IMPORTPERMISSIONSBindingSource, "SDATE", True))
        Me.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSDate.Location = New System.Drawing.Point(24, 26)
        Me.dtpSDate.Name = "dtpSDate"
        Me.dtpSDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpSDate.RightToLeftLayout = True
        Me.dtpSDate.Size = New System.Drawing.Size(96, 20)
        Me.dtpSDate.TabIndex = 75
        '
        'WORKALLOWEDTableAdapter
        '
        Me.WORKALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'ImportPermissionDetailsTableAdapter
        '
        Me.ImportPermissionDetailsTableAdapter.ClearBeforeFill = True
        '
        'IMPORTALLOWEDTableAdapter
        '
        Me.IMPORTALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'frmImportPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 706)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmImportPermissions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = " ‹‹’‹‹‹‹‹‹‹«—ÌÕ «·≈”‹ Ì‹‹‹‹‹‹‹‹—«œ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame8.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame10.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameIMPORTPERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionIMPORTPERMISSIONSBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankIMPORTPERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.UnitBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DescriptionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WORKALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents IMPORTPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPORTPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter
    Friend WithEvents TableAdapterManager As Explosives.dsExplosivesTableAdapters.TableAdapterManager
    Friend WithEvents NOOBJECTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOOBJECTIONSTableAdapter As Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label22 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents txtSID As System.Windows.Forms.TextBox
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Friend WithEvents dtpSDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents WORKALLOWEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.WORKALLOWEDTableAdapter
    Friend WithEvents NameIMPORTPERMISSIONSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionIMPORTPERMISSIONSBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents RankIMPORTPERMISSIONSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PositionDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents btnMovementForm As System.Windows.Forms.Button
    Public WithEvents txtImportPermissionNo As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
    Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DescriptionDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents ImportPermissionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter
    Friend WithEvents UnitBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents UnitDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents IMPORTALLOWEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPORTALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter
#End Region
End Class