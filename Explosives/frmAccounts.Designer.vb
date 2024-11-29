<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAccounts
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
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents txtID As System.Windows.Forms.TextBox
	Public WithEvents txtAccount As System.Windows.Forms.TextBox
	Public WithEvents lblImported As System.Windows.Forms.Label
	Public WithEvents lblDistracted As System.Windows.Forms.Label
	Public WithEvents lblRecent As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents lblClassesNo As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFmtDoc = New System.Windows.Forms.CheckBox()
        Me.cmdFmtFound = New System.Windows.Forms.CheckBox()
        Me.cmdFmtAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.lblImported = New System.Windows.Forms.Label()
        Me.lblDistracted = New System.Windows.Forms.Label()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblClassesNo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.Accounts_Imported_DistractedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Accounts_Imported_DistractedTableAdapter = New Explosives.dsExplosivesTableAdapters.Accounts_Imported_DistractedTableAdapter()
        Me.TableAdapterManager = New Explosives.dsExplosivesTableAdapters.TableAdapterManager()
        Me.AccountsTableAdapter = New Explosives.dsExplosivesTableAdapters.AccountsTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Accounts_Imported_DistractedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1370, 24)
        Me.MainMenu1.TabIndex = 26
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
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFmtDoc)
        Me.Frame9.Controls.Add(Me.cmdFmtFound)
        Me.Frame9.Controls.Add(Me.cmdFmtAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(371, 88)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(617, 137)
        Me.Frame9.TabIndex = 25
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   ÕíÜÜÛÜÜÜÜÉ ÎÜØÜÜÜÜÜÜÜÜÜÜÜÇÈ   "
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(440, 80)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 31
        Me.cmdReturn.Text = "ÑÌÜÜÜÜÜæÚ"
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
        Me.cmdFmtDoc.Location = New System.Drawing.Point(440, 24)
        Me.cmdFmtDoc.Name = "cmdFmtDoc"
        Me.cmdFmtDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdFmtDoc.TabIndex = 30
        Me.cmdFmtDoc.Text = "ØÈÇÚÉ ÇáÍÓÇÈ"
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
        Me.cmdFmtFound.Location = New System.Drawing.Point(243, 24)
        Me.cmdFmtFound.Name = "cmdFmtFound"
        Me.cmdFmtFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtFound.Size = New System.Drawing.Size(129, 41)
        Me.cmdFmtFound.TabIndex = 29
        Me.cmdFmtFound.Text = "ØÈÇÚÉ äÊíÌÉ ÇáÈÍË"
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
        Me.cmdFmtAll.Location = New System.Drawing.Point(46, 24)
        Me.cmdFmtAll.Name = "cmdFmtAll"
        Me.cmdFmtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdFmtAll.TabIndex = 28
        Me.cmdFmtAll.Text = "ØÈÇÚÉ Çáßá"
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
        Me.cmdExit.Location = New System.Drawing.Point(48, 80)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(129, 41)
        Me.cmdExit.TabIndex = 27
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
        Me.cmdLogout.Location = New System.Drawing.Point(244, 80)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 26
        Me.cmdLogout.Text = "ÊÓÌíá ÎÑæÌ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.lblPosition)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(371, 362)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(617, 75)
        Me.Frame7.TabIndex = 8
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " ÇáÊäÞá Èíä ÇáÓÌáÇÊ "
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(280, 14)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(90, 19)
        Me.lblPosition.TabIndex = 13
        Me.lblPosition.Text = "*********"
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(205, 38)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 12
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
        Me.cmdFirst.Location = New System.Drawing.Point(104, 38)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 11
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
        Me.cmdLast.Location = New System.Drawing.Point(408, 38)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 10
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
        Me.cmdNext.Location = New System.Drawing.Point(307, 38)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 9
        Me.cmdNext.Text = "< ÇáÊÜÜÜÜÇáí"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(371, 437)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(617, 57)
        Me.Frame6.TabIndex = 2
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ÚãáíÇÊ Úáì ÇáÓÌáÇÊ "
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(104, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 7
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
        Me.cmdNew.Location = New System.Drawing.Point(461, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 6
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
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(374, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 5
        Me.cmdSave.Text = "ÍÜÜÜÝÜÜÜÙ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(285, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "ÅáÜÜÜÛÜÜÜÇÁ"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(191, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 3
        Me.cmdEdit.Text = "ÊÜÜÜÚÜÜÜÏíá"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.txtID)
        Me.Frame2.Controls.Add(Me.txtAccount)
        Me.Frame2.Controls.Add(Me.lblImported)
        Me.Frame2.Controls.Add(Me.lblDistracted)
        Me.Frame2.Controls.Add(Me.lblRecent)
        Me.Frame2.Controls.Add(Me.Label7)
        Me.Frame2.Controls.Add(Me.lblClassesNo)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label1)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(371, 225)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(617, 137)
        Me.Frame2.TabIndex = 0
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " ÇáÈÍË Úä ÓÌá "
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "ID", True))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(344, 24)
        Me.txtID.MaxLength = 0
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtID.Size = New System.Drawing.Size(137, 20)
        Me.txtID.TabIndex = 14
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAccount
        '
        Me.txtAccount.AcceptsReturn = True
        Me.txtAccount.BackColor = System.Drawing.SystemColors.Window
        Me.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccount.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AccountsBindingSource, "ACCOUNT", True))
        Me.txtAccount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAccount.Location = New System.Drawing.Point(80, 24)
        Me.txtAccount.MaxLength = 0
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAccount.Size = New System.Drawing.Size(137, 20)
        Me.txtAccount.TabIndex = 1
        Me.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblImported
        '
        Me.lblImported.BackColor = System.Drawing.SystemColors.Window
        Me.lblImported.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImported.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblImported.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accounts_Imported_DistractedBindingSource, "Imported", True))
        Me.lblImported.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblImported.Location = New System.Drawing.Point(344, 88)
        Me.lblImported.Name = "lblImported"
        Me.lblImported.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblImported.Size = New System.Drawing.Size(137, 27)
        Me.lblImported.TabIndex = 23
        Me.lblImported.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDistracted
        '
        Me.lblDistracted.BackColor = System.Drawing.SystemColors.Window
        Me.lblDistracted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDistracted.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDistracted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accounts_Imported_DistractedBindingSource, "Recent", True))
        Me.lblDistracted.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDistracted.Location = New System.Drawing.Point(80, 88)
        Me.lblDistracted.Name = "lblDistracted"
        Me.lblDistracted.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDistracted.Size = New System.Drawing.Size(137, 27)
        Me.lblDistracted.TabIndex = 22
        Me.lblDistracted.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRecent
        '
        Me.lblRecent.BackColor = System.Drawing.SystemColors.Window
        Me.lblRecent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecent.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRecent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Accounts_Imported_DistractedBindingSource, "Distracted", True))
        Me.lblRecent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRecent.Location = New System.Drawing.Point(80, 56)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblRecent.Size = New System.Drawing.Size(137, 27)
        Me.lblRecent.TabIndex = 21
        Me.lblRecent.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(224, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 27)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "ÇáãäÕÑÝ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblClassesNo
        '
        Me.lblClassesNo.BackColor = System.Drawing.SystemColors.Window
        Me.lblClassesNo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClassesNo.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblClassesNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblClassesNo.Location = New System.Drawing.Point(344, 56)
        Me.lblClassesNo.Name = "lblClassesNo"
        Me.lblClassesNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblClassesNo.Size = New System.Drawing.Size(137, 27)
        Me.lblClassesNo.TabIndex = 19
        Me.lblClassesNo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(488, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "ÇáæÇÑÏ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(224, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 27)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "ßãíÉ ÇáãæÌæÏ"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(488, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 27)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "ÚÏÏ ÇáÃÕäÇÝ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(488, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 27)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "ÑÞã ÇáÍÓÇÈ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(224, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 27)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "ÇÓã ÇáÍÓÇÈ"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AccountsBindingSource
        '
        Me.AccountsBindingSource.DataMember = "Accounts"
        Me.AccountsBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Accounts_Imported_DistractedBindingSource
        '
        Me.Accounts_Imported_DistractedBindingSource.DataMember = "Accounts_Imported_Distracted"
        Me.Accounts_Imported_DistractedBindingSource.DataSource = Me.DsExplosives
        '
        'Accounts_Imported_DistractedTableAdapter
        '
        Me.Accounts_Imported_DistractedTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AccountsTableAdapter = Nothing
        Me.TableAdapterManager.AmmoTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CLASSESTableAdapter = Nothing
        Me.TableAdapterManager.ConditionsTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
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
        Me.TableAdapterManager.IMPORTPERMISSIONSTableAdapter = Nothing
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
        Me.TableAdapterManager.TownshipsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Explosives.dsExplosivesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WORKALLOWEDTableAdapter = Nothing
        Me.TableAdapterManager.WorkCopiesDetailsTableAdapter = Nothing
        Me.TableAdapterManager.WorkCopiesTableAdapter = Nothing
        Me.TableAdapterManager.WORKPERMISSIONSTableAdapter = Nothing
        '
        'AccountsTableAdapter
        '
        Me.AccountsTableAdapter.ClearBeforeFill = True
        '
        'frmAccounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1370, 749)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 50)
        Me.Name = "frmAccounts"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "ÇáÍÜÜÜÜÜÜÜÜÜÜÜÜÜÜÓÜÜÜÜÜÜÜÜÜÜÇÈÜÜÜÜÇÊ"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame7.PerformLayout()
        Me.Frame6.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.AccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Accounts_Imported_DistractedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents Accounts_Imported_DistractedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Accounts_Imported_DistractedTableAdapter As Explosives.dsExplosivesTableAdapters.Accounts_Imported_DistractedTableAdapter
    Friend WithEvents TableAdapterManager As Explosives.dsExplosivesTableAdapters.TableAdapterManager
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents AccountsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AccountsTableAdapter As Explosives.dsExplosivesTableAdapters.AccountsTableAdapter
#End Region
End Class