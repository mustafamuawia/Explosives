<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPassCopies
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
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents cmdMinus As System.Windows.Forms.CheckBox
	Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
	Public WithEvents lstSirs As System.Windows.Forms.ListBox
	Public WithEvents lblNo As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents fmeImported As System.Windows.Forms.GroupBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdFmtAll = New System.Windows.Forms.CheckBox()
        Me.cmdFmtFound = New System.Windows.Forms.CheckBox()
        Me.cmdFmtDoc = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.fmeImported = New System.Windows.Forms.GroupBox()
        Me.txtSir = New System.Windows.Forms.ComboBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cmdMinus = New System.Windows.Forms.CheckBox()
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.lstSirs = New System.Windows.Forms.ListBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Point3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PassCopiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.PassCopiesTableAdapter = New Explosives.dsExplosivesTableAdapters.PassCopiesTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.fmeImported.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassCopiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnucolours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1350, 24)
        Me.MainMenu1.TabIndex = 30
        '
        'mnucolours
        '
        Me.mnucolours.Name = "mnucolours"
        Me.mnucolours.Size = New System.Drawing.Size(79, 20)
        Me.mnucolours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
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
        Me.Frame9.Location = New System.Drawing.Point(56, 120)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(465, 153)
        Me.Frame9.TabIndex = 29
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
        Me.cmdLogout.Location = New System.Drawing.Point(169, 88)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(121, 41)
        Me.cmdLogout.TabIndex = 12
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
        Me.cmdExit.Location = New System.Drawing.Point(18, 88)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(121, 41)
        Me.cmdExit.TabIndex = 13
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdFmtAll
        '
        Me.cmdFmtAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtAll.Enabled = False
        Me.cmdFmtAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtAll.Location = New System.Drawing.Point(18, 24)
        Me.cmdFmtAll.Name = "cmdFmtAll"
        Me.cmdFmtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtAll.Size = New System.Drawing.Size(121, 41)
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
        Me.cmdFmtFound.Enabled = False
        Me.cmdFmtFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtFound.Location = New System.Drawing.Point(165, 24)
        Me.cmdFmtFound.Name = "cmdFmtFound"
        Me.cmdFmtFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtFound.Size = New System.Drawing.Size(121, 41)
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
        Me.cmdFmtDoc.Location = New System.Drawing.Point(320, 24)
        Me.cmdFmtDoc.Name = "cmdFmtDoc"
        Me.cmdFmtDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtDoc.Size = New System.Drawing.Size(121, 41)
        Me.cmdFmtDoc.TabIndex = 10
        Me.cmdFmtDoc.Text = "ÿ»«⁄… «·’Ê—"
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
        Me.cmdReturn.Location = New System.Drawing.Point(320, 88)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(121, 41)
        Me.cmdReturn.TabIndex = 11
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'fmeImported
        '
        Me.fmeImported.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fmeImported.Controls.Add(Me.txtSir)
        Me.fmeImported.Controls.Add(Me.btnUp)
        Me.fmeImported.Controls.Add(Me.btnDown)
        Me.fmeImported.Controls.Add(Me.cmdMinus)
        Me.fmeImported.Controls.Add(Me.cmdPlus)
        Me.fmeImported.Controls.Add(Me.lstSirs)
        Me.fmeImported.Controls.Add(Me.lblNo)
        Me.fmeImported.Controls.Add(Me.Label3)
        Me.fmeImported.Controls.Add(Me.Label2)
        Me.fmeImported.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fmeImported.Location = New System.Drawing.Point(528, 359)
        Me.fmeImported.Name = "fmeImported"
        Me.fmeImported.Padding = New System.Windows.Forms.Padding(0)
        Me.fmeImported.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fmeImported.Size = New System.Drawing.Size(782, 347)
        Me.fmeImported.TabIndex = 24
        Me.fmeImported.TabStop = False
        Me.fmeImported.Text = "  «·’‹‹‹Ê— ≈·‹‹‹‹‹Ï   «·”‹‹‹«œ…  "
        '
        'txtSir
        '
        Me.txtSir.FormattingEnabled = True
        Me.txtSir.Location = New System.Drawing.Point(205, 20)
        Me.txtSir.Name = "txtSir"
        Me.txtSir.Size = New System.Drawing.Size(385, 21)
        Me.txtSir.TabIndex = 42
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnUp.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnUp.ForeColor = System.Drawing.Color.White
        Me.btnUp.Location = New System.Drawing.Point(604, 141)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(46, 50)
        Me.btnUp.TabIndex = 41
        Me.btnUp.Text = "\/"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnDown.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
        Me.btnDown.ForeColor = System.Drawing.Color.White
        Me.btnDown.Location = New System.Drawing.Point(604, 197)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(46, 50)
        Me.btnDown.TabIndex = 40
        Me.btnDown.Text = "/\"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'cmdMinus
        '
        Me.cmdMinus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdMinus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdMinus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdMinus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdMinus.Location = New System.Drawing.Point(317, 49)
        Me.cmdMinus.Name = "cmdMinus"
        Me.cmdMinus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdMinus.Size = New System.Drawing.Size(89, 33)
        Me.cmdMinus.TabIndex = 19
        Me.cmdMinus.Text = "-"
        Me.cmdMinus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdMinus.UseVisualStyleBackColor = False
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(445, 49)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdPlus.Size = New System.Drawing.Size(89, 33)
        Me.cmdPlus.TabIndex = 17
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'lstSirs
        '
        Me.lstSirs.BackColor = System.Drawing.SystemColors.Window
        Me.lstSirs.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstSirs.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstSirs.Location = New System.Drawing.Point(197, 88)
        Me.lstSirs.Name = "lstSirs"
        Me.lstSirs.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSirs.Size = New System.Drawing.Size(401, 238)
        Me.lstSirs.TabIndex = 18
        '
        'lblNo
        '
        Me.lblNo.BackColor = System.Drawing.Color.Transparent
        Me.lblNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblNo.ForeColor = System.Drawing.Color.Black
        Me.lblNo.Location = New System.Drawing.Point(192, 448)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblNo.Size = New System.Drawing.Size(97, 25)
        Me.lblNo.TabIndex = 27
        Me.lblNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(296, 448)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(113, 25)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "⁄‹‹œœ «·’Ê— Õ”» «·„”«—"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(605, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "«·”Ìœ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(56, 274)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(465, 57)
        Me.Frame7.TabIndex = 23
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.Enabled = False
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(251, 16)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "< «· ‹‹‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.Enabled = False
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLast.Location = New System.Drawing.Point(352, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 3
        Me.cmdLast.Text = "<< «·√ŒÌ‹‹‹—"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.Enabled = False
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(48, 16)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 4
        Me.cmdFirst.Text = "«·√Ê· >>"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.Enabled = False
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(149, 16)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 2
        Me.cmdPrev.Text = "«·”‹‹‹‹«»ﬁ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(56, 331)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(465, 57)
        Me.Frame6.TabIndex = 22
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(205, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 7
        Me.cmdEdit.Text = " ‹‹‹⁄‹‹‹œÌ·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(294, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.Enabled = False
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(381, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 5
        Me.cmdNew.Text = "Ã‹‹œÌ‹‹‹œ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(31, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 9
        Me.cmdDelete.Text = "Õ‹‹‹‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(118, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 8
        Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.lblID)
        Me.Frame1.Controls.Add(Me.DataGridView1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(528, 42)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(782, 311)
        Me.Frame1.TabIndex = 20
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  ‰ﬁ«ÿ «·„”«—  "
        '
        'lblID
        '
        Me.lblID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(647, 30)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(13, 13)
        Me.lblID.TabIndex = 1
        Me.lblID.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.SenderDataGridViewTextBoxColumn, Me.ReceiverDataGridViewTextBoxColumn, Me.Point1DataGridViewTextBoxColumn, Me.Point2DataGridViewTextBoxColumn, Me.Point3DataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PassCopiesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(90, 58)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(618, 211)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "«·—ﬁ„"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SenderDataGridViewTextBoxColumn
        '
        Me.SenderDataGridViewTextBoxColumn.DataPropertyName = "Sender"
        Me.SenderDataGridViewTextBoxColumn.HeaderText = "Sender"
        Me.SenderDataGridViewTextBoxColumn.Name = "SenderDataGridViewTextBoxColumn"
        Me.SenderDataGridViewTextBoxColumn.Visible = False
        '
        'ReceiverDataGridViewTextBoxColumn
        '
        Me.ReceiverDataGridViewTextBoxColumn.DataPropertyName = "Receiver"
        Me.ReceiverDataGridViewTextBoxColumn.HeaderText = "Receiver"
        Me.ReceiverDataGridViewTextBoxColumn.Name = "ReceiverDataGridViewTextBoxColumn"
        Me.ReceiverDataGridViewTextBoxColumn.Visible = False
        '
        'Point1DataGridViewTextBoxColumn
        '
        Me.Point1DataGridViewTextBoxColumn.DataPropertyName = "Point1"
        Me.Point1DataGridViewTextBoxColumn.HeaderText = "«·‰ﬁÿ… «·√Ê·Ï"
        Me.Point1DataGridViewTextBoxColumn.Name = "Point1DataGridViewTextBoxColumn"
        '
        'Point2DataGridViewTextBoxColumn
        '
        Me.Point2DataGridViewTextBoxColumn.DataPropertyName = "Point2"
        Me.Point2DataGridViewTextBoxColumn.HeaderText = "«·‰ﬁÿ… «·À«‰Ì…"
        Me.Point2DataGridViewTextBoxColumn.Name = "Point2DataGridViewTextBoxColumn"
        '
        'Point3DataGridViewTextBoxColumn
        '
        Me.Point3DataGridViewTextBoxColumn.DataPropertyName = "Point3"
        Me.Point3DataGridViewTextBoxColumn.HeaderText = "«·‰ﬁÿ… «·À«·À…"
        Me.Point3DataGridViewTextBoxColumn.Name = "Point3DataGridViewTextBoxColumn"
        '
        'PassCopiesBindingSource
        '
        Me.PassCopiesBindingSource.DataMember = "PassCopies"
        Me.PassCopiesBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PassCopiesTableAdapter
        '
        Me.PassCopiesTableAdapter.ClearBeforeFill = True
        '
        'frmPassCopies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.fmeImported)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmPassCopies"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.fmeImported.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassCopiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents txtSir As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents PassCopiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassCopiesTableAdapter As Explosives.dsExplosivesTableAdapters.PassCopiesTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Point1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Point2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Point3DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region
End Class