<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmTeams
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
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents cmbOrder As System.Windows.Forms.ComboBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmbRank As System.Windows.Forms.ComboBox
	Public WithEvents cmbWorkRegion As System.Windows.Forms.ComboBox
	Public WithEvents cmbSideName As System.Windows.Forms.ComboBox
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Public WithEvents txtCardNo As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents _Label4_1 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents lblAge As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents _Label4_0 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
    Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
    Public cmnDlgFont As System.Windows.Forms.FontDialog
    Public cmnDlgColor As System.Windows.Forms.ColorDialog
    Public cmnDlgPrint As System.Windows.Forms.PrintDialog
    'Public WithEvents Label4 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmbOrder = New System.Windows.Forms.ComboBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtpBirthDate = New System.Windows.Forms.DateTimePicker()
        Me.TeamsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.dtpCommissionDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbRoots = New System.Windows.Forms.ComboBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.cmbWorkRegion = New System.Windows.Forms.ComboBox()
        Me.cmbSideName = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me._Label4_1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTeamNo = New System.Windows.Forms.TextBox()
        Me.txtCardNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me._Label4_0 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.TeamsTableAdapter = New Explosives.dsExplosivesTableAdapters.TeamsTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1350, 24)
        Me.MainMenu1.TabIndex = 46
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "ÖÈØ ÇáÃáæÇä"
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
        Me.cmdRefresh.TabIndex = 45
        Me.cmdRefresh.Text = "ÊÜÜÜÜÜÜÜÍÜÜÜÜÏíÜÜÜÜÜÜÜË ÇáÈíÜÜÜÜÜÜÜÇäÇÊ"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(403, 73)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(545, 131)
        Me.Frame9.TabIndex = 41
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   ÈíÇäÇÊ ÇáãÝÑÞÚÇÊ   "
        '
        'cmdPrintDoc
        '
        Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintDoc.Location = New System.Drawing.Point(370, 24)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdPrintDoc.TabIndex = 3
        Me.cmdPrintDoc.Text = "ØÈÇÚÉ ÈíäÇÊ ÇáÝÑÏ"
        Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintDoc.UseVisualStyleBackColor = False
        '
        'cmdFound
        '
        Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFound.Location = New System.Drawing.Point(196, 24)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdFound.TabIndex = 2
        Me.cmdFound.Text = "ØÈÇÚÉ äÊíÌÉ ÇáÈÍË"
        Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFound.UseVisualStyleBackColor = False
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintAll.Location = New System.Drawing.Point(38, 24)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdPrintAll.TabIndex = 0
        Me.cmdPrintAll.Text = "ØÈÇÚÉ Çáßá"
        Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintAll.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdExit.Location = New System.Drawing.Point(38, 72)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(129, 41)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "ÎÜÜÜÜÜÜÜÜÜÑæÌ"
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
        Me.cmdLogout.Location = New System.Drawing.Point(196, 72)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(145, 41)
        Me.cmdLogout.TabIndex = 5
        Me.cmdLogout.Text = "ÊÓÌíá ÎÑæÌ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(370, 72)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 4
        Me.cmdReturn.Text = "ÑÌÜÜÜÜÜæÚ"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(403, 590)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(545, 57)
        Me.Frame7.TabIndex = 34
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " ÇáÊäÞá Èíä ÇáÓÌáÇÊ "
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(181, 16)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 38
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
        Me.cmdFirst.Location = New System.Drawing.Point(80, 16)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 37
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
        Me.cmdLast.Location = New System.Drawing.Point(384, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 36
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
        Me.cmdNext.Location = New System.Drawing.Point(283, 16)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 35
        Me.cmdNext.Text = "< ÇáÊÜÜÜÜÇáí"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(403, 647)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(545, 57)
        Me.Frame6.TabIndex = 28
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ÚãáíÇÊ Úáì ÇáÓÌáÇÊ "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(16, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 30
        Me.cmdCancel.Text = "ÅáÜÜÜÛÜÜÜÇÁ"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(127, 16)
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
        Me.cmdNew.Location = New System.Drawing.Point(448, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 32
        Me.cmdNew.Text = "ÌÜÜÏíÜÜÜÏ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(335, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
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
        Me.cmdEdit.Location = New System.Drawing.Point(228, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 29
        Me.cmdEdit.Text = "ÊÜÜÜÚÜÜÜÏíá"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.cmbOrder)
        Me.Frame3.Controls.Add(Me.cmbCriteria)
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(403, 493)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(545, 97)
        Me.Frame3.TabIndex = 26
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " ÇáÈÍË Úä ÓÌá "
        '
        'cmbOrder
        '
        Me.cmbOrder.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOrder.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbOrder.Items.AddRange(New Object() {"ÃÞÏãíÉ ÇáäãÑÉ æ ÇáÑÊÈÉ", "ÇáÇÓã", "ÇáæÍÏÉ", "ÇÓã ÇáÌåÉ ÇáãäÊÏÈ ÅáíåÇ", "ÊÇÑíÎ ÇáÇäÊÏÇÈ", "ÊÇÑíÎ ÇáãíáÇÏ"})
        Me.cmbOrder.Location = New System.Drawing.Point(320, 56)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbOrder.Size = New System.Drawing.Size(137, 21)
        Me.cmbOrder.TabIndex = 43
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"ÚÇã", "äãÑÉ ÇáÈØÇÞÉ", "ÇáÇÓã", "ÇáÑÊÈÉ", "ÇáæÍÏÉ", "ÊÇÑíÎ ÇáãíáÇÏ", "ÊÇÑíÎ ÂÎÑ ÇÈÊÚÇË", "ÇÓã ÇáÌåÉ ÇáãÈÚæË ÅáíåÇ", "ãæÞÚ ÇáÚãá"})
        Me.cmbCriteria.Location = New System.Drawing.Point(320, 24)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(137, 21)
        Me.cmbCriteria.TabIndex = 39
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(104, 24)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(177, 20)
        Me.txtFind.TabIndex = 27
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(464, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(65, 17)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "ÊÑÊíÈ ÇáÃÝÑÇÏ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(80, 64)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 40
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.dtpBirthDate)
        Me.Frame1.Controls.Add(Me.dtpCommissionDate)
        Me.Frame1.Controls.Add(Me.cmbRoots)
        Me.Frame1.Controls.Add(Me.cmbUnit)
        Me.Frame1.Controls.Add(Me.cmbRank)
        Me.Frame1.Controls.Add(Me.cmbWorkRegion)
        Me.Frame1.Controls.Add(Me.cmbSideName)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.lblAge)
        Me.Frame1.Controls.Add(Me._Label4_1)
        Me.Frame1.Controls.Add(Me.txtName)
        Me.Frame1.Controls.Add(Me.txtTeamNo)
        Me.Frame1.Controls.Add(Me.txtCardNo)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me._Label4_0)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(403, 205)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(545, 289)
        Me.Frame1.TabIndex = 1
        Me.Frame1.TabStop = False
        '
        'dtpBirthDate
        '
        Me.dtpBirthDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TeamsBindingSource, "BirthDate", True))
        Me.dtpBirthDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "BirthDate", True))
        Me.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpBirthDate.Location = New System.Drawing.Point(288, 130)
        Me.dtpBirthDate.Name = "dtpBirthDate"
        Me.dtpBirthDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpBirthDate.RightToLeftLayout = True
        Me.dtpBirthDate.Size = New System.Drawing.Size(168, 20)
        Me.dtpBirthDate.TabIndex = 43
        '
        'TeamsBindingSource
        '
        Me.TeamsBindingSource.DataMember = "Teams"
        Me.TeamsBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpCommissionDate
        '
        Me.dtpCommissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "CommissionDate", True))
        Me.dtpCommissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TeamsBindingSource, "CommissionDate", True))
        Me.dtpCommissionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCommissionDate.Location = New System.Drawing.Point(17, 136)
        Me.dtpCommissionDate.Name = "dtpCommissionDate"
        Me.dtpCommissionDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpCommissionDate.RightToLeftLayout = True
        Me.dtpCommissionDate.Size = New System.Drawing.Size(168, 20)
        Me.dtpCommissionDate.TabIndex = 43
        '
        'cmbRoots
        '
        Me.cmbRoots.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRoots.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRoots.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "Roots", True))
        Me.cmbRoots.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRoots.Location = New System.Drawing.Point(288, 165)
        Me.cmbRoots.Name = "cmbRoots"
        Me.cmbRoots.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRoots.Size = New System.Drawing.Size(169, 21)
        Me.cmbRoots.TabIndex = 42
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "Unit", True))
        Me.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Location = New System.Drawing.Point(16, 99)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbUnit.Size = New System.Drawing.Size(169, 21)
        Me.cmbUnit.TabIndex = 42
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "Rank", True))
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Items.AddRange(New Object() {"ÌäÏí", "æßíá ÚÑíÝ", "ÚÑíÝ", "ÑÞíÈ", "ãÓÇÚÏ", "ãáÇÒã Çæá", "ãáÇÒã ËÇäí", "äÞíÈ", "ÑÇÆÏ", "ÚÞíÏ", "ÚãíÏ", "áæÇÁ", "ÝÑíÞ", "ÝÑíÞ Ãæá", "ãÔíÑ"})
        Me.cmbRank.Location = New System.Drawing.Point(16, 32)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(169, 21)
        Me.cmbRank.TabIndex = 42
        '
        'cmbWorkRegion
        '
        Me.cmbWorkRegion.BackColor = System.Drawing.SystemColors.Window
        Me.cmbWorkRegion.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbWorkRegion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbWorkRegion.Location = New System.Drawing.Point(184, 232)
        Me.cmbWorkRegion.Name = "cmbWorkRegion"
        Me.cmbWorkRegion.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbWorkRegion.Size = New System.Drawing.Size(273, 21)
        Me.cmbWorkRegion.TabIndex = 25
        '
        'cmbSideName
        '
        Me.cmbSideName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSideName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSideName.Location = New System.Drawing.Point(184, 192)
        Me.cmbSideName.Name = "cmbSideName"
        Me.cmbSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSideName.Size = New System.Drawing.Size(273, 21)
        Me.cmbSideName.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(181, 164)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ÇáÚãÜÜÜÜÑ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblAge
        '
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblAge.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAge.Location = New System.Drawing.Point(19, 164)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblAge.Size = New System.Drawing.Size(169, 25)
        Me.lblAge.TabIndex = 15
        Me.lblAge.Text = "ÇáÚãÑ"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label4_1
        '
        Me._Label4_1.BackColor = System.Drawing.Color.Transparent
        Me._Label4_1.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_1.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_1.Location = New System.Drawing.Point(191, 136)
        Me._Label4_1.Name = "_Label4_1"
        Me._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_1.Size = New System.Drawing.Size(81, 26)
        Me._Label4_1.TabIndex = 20
        Me._Label4_1.Text = "ÊÇÑíÎ ÂÎÑ ÇäÊÏÇÈ"
        Me._Label4_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtName
        '
        Me.txtName.AcceptsReturn = True
        Me.txtName.BackColor = System.Drawing.SystemColors.Window
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "Name", True))
        Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtName.Location = New System.Drawing.Point(16, 64)
        Me.txtName.MaxLength = 0
        Me.txtName.Name = "txtName"
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtName.Size = New System.Drawing.Size(441, 20)
        Me.txtName.TabIndex = 10
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTeamNo
        '
        Me.txtTeamNo.AcceptsReturn = True
        Me.txtTeamNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTeamNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTeamNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "TeamNo", True))
        Me.txtTeamNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTeamNo.Location = New System.Drawing.Point(288, 32)
        Me.txtTeamNo.MaxLength = 0
        Me.txtTeamNo.Name = "txtTeamNo"
        Me.txtTeamNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTeamNo.Size = New System.Drawing.Size(169, 20)
        Me.txtTeamNo.TabIndex = 7
        Me.txtTeamNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCardNo
        '
        Me.txtCardNo.AcceptsReturn = True
        Me.txtCardNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCardNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCardNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeamsBindingSource, "CardNo", True))
        Me.txtCardNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCardNo.Location = New System.Drawing.Point(287, 99)
        Me.txtCardNo.MaxLength = 0
        Me.txtCardNo.Name = "txtCardNo"
        Me.txtCardNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtCardNo.Size = New System.Drawing.Size(169, 20)
        Me.txtCardNo.TabIndex = 7
        Me.txtCardNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(464, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(73, 33)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ãæÞÚ ÇáÚãá ÇáÍÇáí"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(464, 192)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(73, 33)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "ÇÓã ÇáÌåÉ ÇáãäÊÏÈ áÏíåÇ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(193, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(73, 25)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ÇáæÍÏÉ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(464, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(73, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ãÓÞØ ÇáÑÃÓ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label4_0
        '
        Me._Label4_0.BackColor = System.Drawing.Color.Transparent
        Me._Label4_0.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label4_0.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label4_0.Location = New System.Drawing.Point(464, 136)
        Me._Label4_0.Name = "_Label4_0"
        Me._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label4_0.Size = New System.Drawing.Size(73, 25)
        Me._Label4_0.TabIndex = 12
        Me._Label4_0.Text = "ÊÇÑíÎ ÇáãíáÇÏ"
        Me._Label4_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(464, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ÇáÇÓã"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(192, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "ÇáÜÜÑÊÈÜÜÜÜÉ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(464, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(73, 18)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "äãÑÉ ÇáÈØÇÞÉ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(464, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ÇáÊÓáÓáí"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TeamsTableAdapter
        '
        Me.TeamsTableAdapter.ClearBeforeFill = True
        '
        'frmTeams
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 50)
        Me.Name = "frmTeams"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ÝÜÜÜÜÜÜÜÜÑÞ ÇáÜÜÜÚãÜÜÜÜá ãÚ ÇáÌÜÜÜÜåÜÜÜÜÜÜÜÜÇÊ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TeamsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpBirthDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpCommissionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents TeamsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeamsTableAdapter As Explosives.dsExplosivesTableAdapters.TeamsTableAdapter
    Public WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Public WithEvents cmbRoots As System.Windows.Forms.ComboBox
    Public WithEvents txtTeamNo As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
#End Region 
End Class