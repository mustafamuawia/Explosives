<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmWorkPermissions
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
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents cmbDuration As System.Windows.Forms.ComboBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents txtsID As System.Windows.Forms.TextBox
	Public WithEvents cmbsSideName As System.Windows.Forms.ComboBox
	Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cmbOwner As System.Windows.Forms.ComboBox
    Public WithEvents txtWorkPermissionNo As System.Windows.Forms.TextBox
    Public WithEvents cmbfSideName As System.Windows.Forms.ComboBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
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
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents txtPurpose As System.Windows.Forms.TextBox
    Public WithEvents cmbLocation As System.Windows.Forms.ComboBox
    Public WithEvents cmbState As System.Windows.Forms.ComboBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
    Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
    Public cmnDlgFont As System.Windows.Forms.FontDialog
    Public cmnDlgColor As System.Windows.Forms.ColorDialog
    Public cmnDlgPrint As System.Windows.Forms.PrintDialog
    Public WithEvents Label7 As System.Windows.Forms.Label
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.txtDate2 = New System.Windows.Forms.DateTimePicker()
        Me.txtDate1 = New System.Windows.Forms.DateTimePicker()
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
        Me.WORKPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.txtsID = New System.Windows.Forms.TextBox()
        Me.cmbsSideName = New System.Windows.Forms.ComboBox()
        Me.SSideNameBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtpFdate = New System.Windows.Forms.DateTimePicker()
        Me.cmbOwner = New System.Windows.Forms.ComboBox()
        Me.OwnerWORKPERMISSIONSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtfID = New System.Windows.Forms.TextBox()
        Me.txtWorkPermissionNo = New System.Windows.Forms.TextBox()
        Me.cmbfSideName = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.FSideNameWORKPERMISSIONSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FSideNameDsExplosives1 = New Explosives.dsExplosives()
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.cmbLocation = New System.Windows.Forms.ComboBox()
        Me.LocationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocationDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbState = New System.Windows.Forms.ComboBox()
        Me.StateBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateDsExplosives1 = New Explosives.dsExplosives()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.WorkCopiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.WorkCopiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.NameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.WORKPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter()
        Me.SSideNameDsExplosives1 = New Explosives.dsExplosives()
        Me.OwnerDsExplosives1 = New Explosives.dsExplosives()
        Me.WorkCopiesTableAdapter = New Explosives.dsExplosivesTableAdapters.WorkCopiesTableAdapter()
        Me.FSideNameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives1 = New Explosives.dsExplosives()
        Me.MainMenu1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SSideNameBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.OwnerWORKPERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSideNameWORKPERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSideNameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame10.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocationDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCopiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCopiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame7.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame8.SuspendLayout()
        CType(Me.SSideNameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OwnerDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FSideNameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours, Me.mnuPay})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1315, 24)
        Me.MainMenu1.TabIndex = 57
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
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.txtDate2)
        Me.Frame3.Controls.Add(Me.txtDate1)
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.cmbCriteria)
        Me.Frame3.Controls.Add(Me.cmdFindPrev)
        Me.Frame3.Controls.Add(Me.cmdFindNext)
        Me.Frame3.Controls.Add(Me.cmbDuration)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(640, 492)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(497, 121)
        Me.Frame3.TabIndex = 56
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " «·»‹Õ‹À ⁄‹‰ ”‹Ã‹· "
        '
        'txtDate2
        '
        Me.txtDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate2.Location = New System.Drawing.Point(33, 61)
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate2.RightToLeftLayout = True
        Me.txtDate2.Size = New System.Drawing.Size(90, 20)
        Me.txtDate2.TabIndex = 68
        '
        'txtDate1
        '
        Me.txtDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtDate1.Location = New System.Drawing.Point(156, 61)
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate1.RightToLeftLayout = True
        Me.txtDate1.Size = New System.Drawing.Size(90, 20)
        Me.txtDate1.TabIndex = 68
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
        Me.txtFind.TabIndex = 63
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "‰„—… «·„·›", " «—ÌŒ «·„·›", " «—ÌŒ «·Œÿ«»", "«”„ «·ÃÂ… «·„√–Ê‰ ·Â«", "«”„ «·ÃÂ… «·„Œ«ÿ»…", "«·«”„  Õ  «· ÊﬁÌ⁄"})
        Me.cmbCriteria.Location = New System.Drawing.Point(296, 24)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(177, 21)
        Me.cmbCriteria.TabIndex = 62
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindPrev.Location = New System.Drawing.Point(8, 24)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindPrev.TabIndex = 60
        Me.cmdFindPrev.Text = ">"
        Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindPrev.UseVisualStyleBackColor = False
        Me.cmdFindPrev.Visible = False
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindNext.Location = New System.Drawing.Point(275, 24)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindNext.TabIndex = 59
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        Me.cmdFindNext.Visible = False
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
        Me.cmbDuration.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(248, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(32, 17)
        Me.Label13.TabIndex = 66
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
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 65
        Me.Label14.Text = "≈·‹‹Ï"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.SystemColors.Control
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(40, 88)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 64
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame4.Controls.Add(Me.dtpSDate)
        Me.Frame4.Controls.Add(Me.txtsID)
        Me.Frame4.Controls.Add(Me.cmbsSideName)
        Me.Frame4.Controls.Add(Me.Label20)
        Me.Frame4.Controls.Add(Me.Label21)
        Me.Frame4.Controls.Add(Me.Label22)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(640, 403)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame4.Size = New System.Drawing.Size(497, 89)
        Me.Frame4.TabIndex = 49
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "  »Ì«‰«   Œÿ«» «·ÃÂ… «·ÿ«·»… ·≈” Œ—«Ã «·≈–‰ "
        '
        'dtpSDate
        '
        Me.dtpSDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WORKPERMISSIONSBindingSource, "SDATE", True))
        Me.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSDate.Location = New System.Drawing.Point(295, 26)
        Me.dtpSDate.Name = "dtpSDate"
        Me.dtpSDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpSDate.RightToLeftLayout = True
        Me.dtpSDate.Size = New System.Drawing.Size(130, 20)
        Me.dtpSDate.TabIndex = 68
        '
        'WORKPERMISSIONSBindingSource
        '
        Me.WORKPERMISSIONSBindingSource.DataMember = "WORKPERMISSIONS"
        Me.WORKPERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsID
        '
        Me.txtsID.AcceptsReturn = True
        Me.txtsID.BackColor = System.Drawing.SystemColors.Window
        Me.txtsID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "ID", True))
        Me.txtsID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtsID.Location = New System.Drawing.Point(8, 24)
        Me.txtsID.MaxLength = 0
        Me.txtsID.Multiline = True
        Me.txtsID.Name = "txtsID"
        Me.txtsID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtsID.Size = New System.Drawing.Size(217, 25)
        Me.txtsID.TabIndex = 51
        '
        'cmbsSideName
        '
        Me.cmbsSideName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbsSideName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbsSideName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "SSIDENAME", True))
        Me.cmbsSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "SSIDENAME", True))
        Me.cmbsSideName.DataSource = Me.SSideNameBindingSource2
        Me.cmbsSideName.DisplayMember = "SSIDENAME"
        Me.cmbsSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbsSideName.Location = New System.Drawing.Point(8, 56)
        Me.cmbsSideName.Name = "cmbsSideName"
        Me.cmbsSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbsSideName.Size = New System.Drawing.Size(417, 21)
        Me.cmbsSideName.TabIndex = 50
        Me.cmbsSideName.ValueMember = "SSIDENAME"
        '
        'SSideNameBindingSource2
        '
        Me.SSideNameBindingSource2.DataMember = "WORKPERMISSIONS"
        Me.SSideNameBindingSource2.DataSource = Me.DsExplosives
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(424, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 55
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
        Me.Label21.TabIndex = 54
        Me.Label21.Text = "«”„ «·ÃÂ…"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(224, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 25)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "«·‰„—…"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.dtpFdate)
        Me.Frame1.Controls.Add(Me.cmbOwner)
        Me.Frame1.Controls.Add(Me.txtfID)
        Me.Frame1.Controls.Add(Me.txtWorkPermissionNo)
        Me.Frame1.Controls.Add(Me.cmbfSideName)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(640, 282)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(497, 121)
        Me.Frame1.TabIndex = 41
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì«‰«  „·› «·≈–‰ "
        '
        'dtpFdate
        '
        Me.dtpFdate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.WORKPERMISSIONSBindingSource, "FDATE", True))
        Me.dtpFdate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFdate.Location = New System.Drawing.Point(295, 26)
        Me.dtpFdate.Name = "dtpFdate"
        Me.dtpFdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpFdate.RightToLeftLayout = True
        Me.dtpFdate.Size = New System.Drawing.Size(130, 20)
        Me.dtpFdate.TabIndex = 68
        '
        'cmbOwner
        '
        Me.cmbOwner.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOwner.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbOwner.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "OWNER", True))
        Me.cmbOwner.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "OWNER", True))
        Me.cmbOwner.DataSource = Me.OwnerWORKPERMISSIONSBindingSource2
        Me.cmbOwner.DisplayMember = "OWNER"
        Me.cmbOwner.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbOwner.Location = New System.Drawing.Point(8, 88)
        Me.cmbOwner.Name = "cmbOwner"
        Me.cmbOwner.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbOwner.Size = New System.Drawing.Size(417, 21)
        Me.cmbOwner.TabIndex = 67
        Me.cmbOwner.ValueMember = "OWNER"
        '
        'OwnerWORKPERMISSIONSBindingSource2
        '
        Me.OwnerWORKPERMISSIONSBindingSource2.DataMember = "WORKPERMISSIONS"
        Me.OwnerWORKPERMISSIONSBindingSource2.DataSource = Me.DsExplosives
        '
        'txtfID
        '
        Me.txtfID.AcceptsReturn = True
        Me.txtfID.BackColor = System.Drawing.SystemColors.Window
        Me.txtfID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "ID", True))
        Me.txtfID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfID.Location = New System.Drawing.Point(152, 25)
        Me.txtfID.MaxLength = 0
        Me.txtfID.Multiline = True
        Me.txtfID.Name = "txtfID"
        Me.txtfID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtfID.Size = New System.Drawing.Size(63, 25)
        Me.txtfID.TabIndex = 43
        '
        'txtWorkPermissionNo
        '
        Me.txtWorkPermissionNo.AcceptsReturn = True
        Me.txtWorkPermissionNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtWorkPermissionNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWorkPermissionNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "WorkPermissionNo", True))
        Me.txtWorkPermissionNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWorkPermissionNo.Location = New System.Drawing.Point(8, 24)
        Me.txtWorkPermissionNo.MaxLength = 0
        Me.txtWorkPermissionNo.Multiline = True
        Me.txtWorkPermissionNo.Name = "txtWorkPermissionNo"
        Me.txtWorkPermissionNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWorkPermissionNo.Size = New System.Drawing.Size(63, 25)
        Me.txtWorkPermissionNo.TabIndex = 43
        '
        'cmbfSideName
        '
        Me.cmbfSideName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbfSideName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbfSideName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbfSideName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbfSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "FSIDENAME", True))
        Me.cmbfSideName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "FSIDENAME", True))
        Me.cmbfSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbfSideName.Location = New System.Drawing.Point(8, 56)
        Me.cmbfSideName.Name = "cmbfSideName"
        Me.cmbfSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbfSideName.Size = New System.Drawing.Size(417, 21)
        Me.cmbfSideName.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(224, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "«· ”·”·Ì"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(80, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "«·‰‹‹„‹‹‹—…"
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
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "«”„ «·ÃÂ…"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(424, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "«·‹‹ ‹‹‹‹«—ÌŒ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(424, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(65, 17)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "«·„«·ﬂ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FSideNameWORKPERMISSIONSBindingSource1
        '
        Me.FSideNameWORKPERMISSIONSBindingSource1.DataMember = "WORKPERMISSIONS"
        Me.FSideNameWORKPERMISSIONSBindingSource1.DataSource = Me.FSideNameDsExplosives1
        '
        'FSideNameDsExplosives1
        '
        Me.FSideNameDsExplosives1.DataSetName = "dsExplosives"
        Me.FSideNameDsExplosives1.EnforceConstraints = False
        Me.FSideNameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Frame10.Location = New System.Drawing.Point(128, 120)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame10.Size = New System.Drawing.Size(1009, 81)
        Me.Frame10.TabIndex = 34
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
        Me.cmdRptAll.Location = New System.Drawing.Point(511, 24)
        Me.cmdRptAll.Name = "cmdRptAll"
        Me.cmdRptAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdRptAll.TabIndex = 40
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
        Me.cmdRptFound.TabIndex = 39
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
        Me.cmdRptDoc.TabIndex = 38
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
        Me.Check3.TabIndex = 37
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
        Me.Check2.TabIndex = 36
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
        Me.Check4.TabIndex = 35
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
        Me.Frame9.Location = New System.Drawing.Point(128, 201)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1009, 81)
        Me.Frame9.TabIndex = 27
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
        Me.cmdLogout.TabIndex = 33
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
        Me.cmdExit.TabIndex = 32
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
        Me.cmdFmtAll.TabIndex = 31
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
        Me.cmdFmtFound.TabIndex = 30
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
        Me.cmdFmtDoc.TabIndex = 29
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
        Me.cmdReturn.TabIndex = 28
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.txtPurpose)
        Me.Frame2.Controls.Add(Me.cmbLocation)
        Me.Frame2.Controls.Add(Me.cmbState)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(128, 282)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(513, 210)
        Me.Frame2.TabIndex = 16
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " »Ì«‰«  «” Œœ«„ «·„›—ﬁ⁄«  "
        '
        'txtPurpose
        '
        Me.txtPurpose.AcceptsReturn = True
        Me.txtPurpose.BackColor = System.Drawing.SystemColors.Window
        Me.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurpose.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "PURPOSE", True))
        Me.txtPurpose.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPurpose.Location = New System.Drawing.Point(16, 24)
        Me.txtPurpose.MaxLength = 0
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurpose.Size = New System.Drawing.Size(409, 25)
        Me.txtPurpose.TabIndex = 24
        '
        'cmbLocation
        '
        Me.cmbLocation.BackColor = System.Drawing.SystemColors.Window
        Me.cmbLocation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbLocation.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "LOCATION", True))
        Me.cmbLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "LOCATION", True))
        Me.cmbLocation.DataSource = Me.LocationBindingSource1
        Me.cmbLocation.DisplayMember = "Region"
        Me.cmbLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLocation.Location = New System.Drawing.Point(16, 88)
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbLocation.Size = New System.Drawing.Size(409, 21)
        Me.cmbLocation.TabIndex = 23
        Me.cmbLocation.ValueMember = "Region"
        '
        'LocationBindingSource1
        '
        Me.LocationBindingSource1.DataMember = "WorkCopies"
        Me.LocationBindingSource1.DataSource = Me.LocationDsExplosives1
        '
        'LocationDsExplosives1
        '
        Me.LocationDsExplosives1.DataSetName = "dsExplosives"
        Me.LocationDsExplosives1.EnforceConstraints = False
        Me.LocationDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbState
        '
        Me.cmbState.BackColor = System.Drawing.SystemColors.Window
        Me.cmbState.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbState.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "STATE", True))
        Me.cmbState.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "STATE", True))
        Me.cmbState.DataSource = Me.StateBindingSource1
        Me.cmbState.DisplayMember = "State"
        Me.cmbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbState.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbState.Location = New System.Drawing.Point(16, 56)
        Me.cmbState.Name = "cmbState"
        Me.cmbState.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbState.Size = New System.Drawing.Size(409, 21)
        Me.cmbState.TabIndex = 22
        Me.cmbState.ValueMember = "State"
        '
        'StateBindingSource1
        '
        Me.StateBindingSource1.DataMember = "WorkCopies"
        Me.StateBindingSource1.DataSource = Me.StateDsExplosives1
        '
        'StateDsExplosives1
        '
        Me.StateDsExplosives1.DataSetName = "dsExplosives"
        Me.StateDsExplosives1.EnforceConstraints = False
        Me.StateDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(432, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "«·‹‹€‹‹—÷"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(432, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "„Êﬁ⁄ «·⁄„·"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(432, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "«·Ê·«Ì…"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WorkCopiesBindingSource1
        '
        Me.WorkCopiesBindingSource1.DataMember = "WorkCopies"
        Me.WorkCopiesBindingSource1.DataSource = Me.DsExplosives
        '
        'WorkCopiesBindingSource
        '
        Me.WorkCopiesBindingSource.DataMember = "WorkCopies"
        Me.WorkCopiesBindingSource.DataSource = Me.DsExplosives
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRefresh.Location = New System.Drawing.Point(0, 24)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
        Me.cmdRefresh.TabIndex = 15
        Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(640, 613)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(497, 65)
        Me.Frame7.TabIndex = 10
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
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
        Me.cmdNext.TabIndex = 14
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
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
        Me.cmdPrev.TabIndex = 13
        Me.cmdPrev.Text = "«·”‹‹‹«»ﬁ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
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
        Me.cmdFirst.TabIndex = 11
        Me.cmdFirst.Text = ">> «·√Ê·"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.cmbPosition)
        Me.Frame5.Controls.Add(Me.cmbName)
        Me.Frame5.Controls.Add(Me.cmbRank)
        Me.Frame5.Controls.Add(Me.Label12)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Controls.Add(Me.Label2)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(127, 492)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(513, 121)
        Me.Frame5.TabIndex = 5
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " ’œ—  Õ   ÊﬁÌ⁄ "
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataSource = Me.PositionBindingSource1
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.Font = New System.Drawing.Font("Traditional Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(16, 80)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(409, 32)
        Me.cmbPosition.TabIndex = 21
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'PositionBindingSource1
        '
        Me.PositionBindingSource1.DataMember = "WORKPERMISSIONS"
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
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataSource = Me.NameBindingSource1
        Me.cmbName.DisplayMember = "NAME"
        Me.cmbName.Font = New System.Drawing.Font("Traditional Arabic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(16, 48)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(409, 32)
        Me.cmbName.TabIndex = 20
        Me.cmbName.ValueMember = "NAME"
        '
        'NameBindingSource1
        '
        Me.NameBindingSource1.DataMember = "WORKPERMISSIONS"
        Me.NameBindingSource1.DataSource = Me.NameDsExplosives1
        '
        'NameDsExplosives1
        '
        Me.NameDsExplosives1.DataSetName = "dsExplosives"
        Me.NameDsExplosives1.EnforceConstraints = False
        Me.NameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WORKPERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WORKPERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataSource = Me.RankBindingSource1
        Me.cmbRank.DisplayMember = "RANK"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(16, 20)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(409, 21)
        Me.cmbRank.TabIndex = 19
        Me.cmbRank.ValueMember = "RANK"
        '
        'RankBindingSource1
        '
        Me.RankBindingSource1.DataMember = "WORKPERMISSIONS"
        Me.RankBindingSource1.DataSource = Me.RankDsExplosives1
        '
        'RankDsExplosives1
        '
        Me.RankDsExplosives1.DataSetName = "dsExplosives"
        Me.RankDsExplosives1.EnforceConstraints = False
        Me.RankDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(432, 88)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(65, 17)
        Me.Label12.TabIndex = 8
        Me.Label12.Text = "«·„‰’»"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(432, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(65, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "«·«”‹‹‹„"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(432, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "«·— »… "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame8.Controls.Add(Me.cmdCancel)
        Me.Frame8.Controls.Add(Me.cmdEdit)
        Me.Frame8.Controls.Add(Me.cmdNew)
        Me.Frame8.Controls.Add(Me.cmdSave)
        Me.Frame8.Controls.Add(Me.cmdDelete)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(127, 613)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(513, 65)
        Me.Frame8.TabIndex = 0
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(22, 24)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
        Me.cmdCancel.TabIndex = 9
        Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        Me.cmdCancel.Visible = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(212, 22)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(89, 33)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = " ‹⁄‹œÌ‹·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(405, 22)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(89, 33)
        Me.cmdNew.TabIndex = 3
        Me.cmdNew.Text = "Ã‹‹œÌ‹‹œ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(309, 22)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(89, 33)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(117, 22)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "Õ‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(416, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "«”„ «·ÃÂ…"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WORKPERMISSIONSTableAdapter
        '
        Me.WORKPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'SSideNameDsExplosives1
        '
        Me.SSideNameDsExplosives1.DataSetName = "dsExplosives"
        Me.SSideNameDsExplosives1.EnforceConstraints = False
        Me.SSideNameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OwnerDsExplosives1
        '
        Me.OwnerDsExplosives1.DataSetName = "dsExplosives"
        Me.OwnerDsExplosives1.EnforceConstraints = False
        Me.OwnerDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkCopiesTableAdapter
        '
        Me.WorkCopiesTableAdapter.ClearBeforeFill = True
        '
        'FSideNameBindingSource1
        '
        Me.FSideNameBindingSource1.DataMember = "WORKPERMISSIONS"
        Me.FSideNameBindingSource1.DataSource = Me.FSideNameDsExplosives1
        '
        'DsExplosives1
        '
        Me.DsExplosives1.DataSetName = "dsExplosives"
        Me.DsExplosives1.EnforceConstraints = False
        Me.DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'frmWorkPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1315, 680)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame10)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmWorkPermissions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "√–Ê‰‹‹‹‹‹‹‹«  «” Œ‹‹‹‹‹‹œ«„ «·„‹ ›Ã‹‹‹‹‹‹‹‹‹‹—« "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame4.PerformLayout()
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SSideNameBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.OwnerWORKPERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSideNameWORKPERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSideNameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame10.ResumeLayout(False)
        Me.Frame9.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.LocationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocationDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCopiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCopiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame7.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame8.ResumeLayout(False)
        CType(Me.SSideNameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OwnerDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FSideNameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpSDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents WORKPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter
    Friend WithEvents FSideNameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents SSideNameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents NameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PositionDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents StateDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents LocationDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents FSideNameWORKPERMISSIONSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OwnerWORKPERMISSIONSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StateBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents OwnerDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents SSideNameBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents LocationBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RankBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCopiesTableAdapter As Explosives.dsExplosivesTableAdapters.WorkCopiesTableAdapter
    Friend WithEvents WorkCopiesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents WorkCopiesBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents txtfID As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents FSideNameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents txtDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDate1 As System.Windows.Forms.DateTimePicker
#End Region 
End Class