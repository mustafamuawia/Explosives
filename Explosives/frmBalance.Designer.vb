<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmBalance
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
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents txtAccount As System.Windows.Forms.TextBox
	Public WithEvents txtSideName As System.Windows.Forms.TextBox
	Public WithEvents optYet As System.Windows.Forms.RadioButton
	Public WithEvents optDone As System.Windows.Forms.RadioButton
	Public WithEvents txtDate As System.Windows.Forms.TextBox
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _Label6_2 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmbAccount As System.Windows.Forms.ComboBox
	Public WithEvents cmbYear As System.Windows.Forms.ComboBox
	Public WithEvents cmbSearchSide As System.Windows.Forms.ComboBox
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents fmeImported As System.Windows.Forms.GroupBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
    'Public WithEvents Label6 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
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
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtAccount = New System.Windows.Forms.TextBox()
        Me.txtSideName = New System.Windows.Forms.TextBox()
        Me.optYet = New System.Windows.Forms.RadioButton()
        Me.optDone = New System.Windows.Forms.RadioButton()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me._Label6_2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.cmbAccount = New System.Windows.Forms.ComboBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbSearchSide = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.fmeImported = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ImpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LEFTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UnitDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DISTDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DistractorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BALANCEDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BalanceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.BalanceTableAdapter = New Explosives.dsExplosivesTableAdapters.BalanceTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.fmeImported.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1350, 24)
        Me.MainMenu1.TabIndex = 43
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
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
        Me.cmdRefresh.TabIndex = 42
        Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(90, 112)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1169, 83)
        Me.Frame9.TabIndex = 33
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   »Ì«‰«  «·„›—ﬁ⁄«    "
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(414, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(137, 41)
        Me.cmdReturn.TabIndex = 39
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdPrintDoc
        '
        Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintDoc.Location = New System.Drawing.Point(952, 24)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(137, 41)
        Me.cmdPrintDoc.TabIndex = 38
        Me.cmdPrintDoc.Text = "ÿ»«⁄… «· ’—ÌÕ"
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
        Me.cmdFound.Location = New System.Drawing.Point(755, 24)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(153, 41)
        Me.cmdFound.TabIndex = 37
        Me.cmdFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
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
        Me.cmdPrintAll.Location = New System.Drawing.Point(585, 24)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(137, 41)
        Me.cmdPrintAll.TabIndex = 36
        Me.cmdPrintAll.Text = "ÿ»«⁄… «·ﬂ·"
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
        Me.cmdExit.Location = New System.Drawing.Point(72, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(137, 41)
        Me.cmdExit.TabIndex = 35
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
        Me.cmdLogout.Location = New System.Drawing.Point(243, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(137, 41)
        Me.cmdLogout.TabIndex = 34
        Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.txtAccount)
        Me.Frame1.Controls.Add(Me.txtSideName)
        Me.Frame1.Controls.Add(Me.optYet)
        Me.Frame1.Controls.Add(Me.optDone)
        Me.Frame1.Controls.Add(Me.txtDate)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me._Label6_2)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(731, 195)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(529, 193)
        Me.Frame1.TabIndex = 15
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " »Ì«‰«  «·ÃÂ… "
        '
        'txtAccount
        '
        Me.txtAccount.AcceptsReturn = True
        Me.txtAccount.BackColor = System.Drawing.SystemColors.Control
        Me.txtAccount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAccount.ForeColor = System.Drawing.Color.Black
        Me.txtAccount.Location = New System.Drawing.Point(296, 56)
        Me.txtAccount.MaxLength = 0
        Me.txtAccount.Name = "txtAccount"
        Me.txtAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAccount.Size = New System.Drawing.Size(153, 20)
        Me.txtAccount.TabIndex = 32
        Me.txtAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSideName
        '
        Me.txtSideName.AcceptsReturn = True
        Me.txtSideName.BackColor = System.Drawing.SystemColors.Control
        Me.txtSideName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSideName.ForeColor = System.Drawing.Color.Black
        Me.txtSideName.Location = New System.Drawing.Point(64, 88)
        Me.txtSideName.MaxLength = 0
        Me.txtSideName.Name = "txtSideName"
        Me.txtSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSideName.Size = New System.Drawing.Size(385, 20)
        Me.txtSideName.TabIndex = 31
        Me.txtSideName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'optYet
        '
        Me.optYet.BackColor = System.Drawing.Color.Transparent
        Me.optYet.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optYet.Cursor = System.Windows.Forms.Cursors.Default
        Me.optYet.Font = New System.Drawing.Font("Traditional Arabic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.optYet.ForeColor = System.Drawing.Color.Black
        Me.optYet.Location = New System.Drawing.Point(328, 152)
        Me.optYet.Name = "optYet"
        Me.optYet.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optYet.Size = New System.Drawing.Size(121, 38)
        Me.optYet.TabIndex = 26
        Me.optYet.TabStop = True
        Me.optYet.Text = "·Ì‹‹‹‹” »‹‹‹⁄‹‹‹‹‹œ"
        Me.optYet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optYet.UseVisualStyleBackColor = False
        '
        'optDone
        '
        Me.optDone.BackColor = System.Drawing.Color.Transparent
        Me.optDone.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optDone.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDone.Enabled = False
        Me.optDone.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.optDone.ForeColor = System.Drawing.Color.Black
        Me.optDone.Location = New System.Drawing.Point(329, 118)
        Me.optDone.Name = "optDone"
        Me.optDone.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDone.Size = New System.Drawing.Size(121, 32)
        Me.optDone.TabIndex = 25
        Me.optDone.TabStop = True
        Me.optDone.Text = " ‹‹‹„ «· ÕÊÌ·"
        Me.optDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optDone.UseVisualStyleBackColor = False
        '
        'txtDate
        '
        Me.txtDate.AcceptsReturn = True
        Me.txtDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate.ForeColor = System.Drawing.Color.Black
        Me.txtDate.Location = New System.Drawing.Point(296, 24)
        Me.txtDate.MaxLength = 0
        Me.txtDate.Name = "txtDate"
        Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate.Size = New System.Drawing.Size(153, 20)
        Me.txtDate.TabIndex = 23
        Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(456, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "«· ÕÊÌ·"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(456, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "√—’œ… ··⁄«„"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        '_Label6_2
        '
        Me._Label6_2.BackColor = System.Drawing.Color.Transparent
        Me._Label6_2.Cursor = System.Windows.Forms.Cursors.Default
        Me._Label6_2.ForeColor = System.Drawing.SystemColors.ControlText
        Me._Label6_2.Location = New System.Drawing.Point(464, 64)
        Me._Label6_2.Name = "_Label6_2"
        Me._Label6_2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me._Label6_2.Size = New System.Drawing.Size(49, 17)
        Me._Label6_2.TabIndex = 17
        Me._Label6_2.Text = "Õ”«»"
        Me._Label6_2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(456, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "«”„ «·ÃÂ…"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.cmbAccount)
        Me.Frame2.Controls.Add(Me.cmbYear)
        Me.Frame2.Controls.Add(Me.cmbSearchSide)
        Me.Frame2.Controls.Add(Me.Label13)
        Me.Frame2.Controls.Add(Me.Label10)
        Me.Frame2.Controls.Add(Me.Label9)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(731, 388)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(529, 121)
        Me.Frame2.TabIndex = 14
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "«·»‹‹‹‹Õ‹‹‹‹‹‹‹À"
        '
        'cmbAccount
        '
        Me.cmbAccount.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAccount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAccount.Location = New System.Drawing.Point(296, 56)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbAccount.Size = New System.Drawing.Size(153, 21)
        Me.cmbAccount.TabIndex = 41
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.SystemColors.Window
        Me.cmbYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbYear.Location = New System.Drawing.Point(296, 24)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbYear.Size = New System.Drawing.Size(153, 21)
        Me.cmbYear.TabIndex = 28
        '
        'cmbSearchSide
        '
        Me.cmbSearchSide.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSearchSide.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSearchSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSearchSide.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSearchSide.Location = New System.Drawing.Point(56, 88)
        Me.cmbSearchSide.Name = "cmbSearchSide"
        Me.cmbSearchSide.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSearchSide.Size = New System.Drawing.Size(393, 21)
        Me.cmbSearchSide.TabIndex = 27
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(464, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(57, 17)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "«·Õ”«»"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(464, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(57, 17)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "‰Â«Ì… Ê »œ«Ì… "
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(464, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 17)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "«”„ «·ÃÂ…"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(731, 509)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(529, 73)
        Me.Frame7.TabIndex = 9
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(56, 20)
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
        Me.cmdLast.Location = New System.Drawing.Point(368, 20)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(89, 33)
        Me.cmdLast.TabIndex = 12
        Me.cmdLast.Text = "<< «·√ŒÌ‹‹‹‹—"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(160, 20)
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
        Me.cmdNext.Location = New System.Drawing.Point(264, 20)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(89, 33)
        Me.cmdNext.TabIndex = 10
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'fmeImported
        '
        Me.fmeImported.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.fmeImported.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.fmeImported.Controls.Add(Me.DataGridView1)
        Me.fmeImported.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fmeImported.Location = New System.Drawing.Point(90, 195)
        Me.fmeImported.Name = "fmeImported"
        Me.fmeImported.Padding = New System.Windows.Forms.Padding(0)
        Me.fmeImported.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.fmeImported.Size = New System.Drawing.Size(641, 387)
        Me.fmeImported.TabIndex = 0
        Me.fmeImported.TabStop = False
        Me.fmeImported.Text = " „Ã„ÂÊ⁄ «·Ê«—œ ≈·Ï „Œ«“‰ «·”·«Õ "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ImpDataGridViewTextBoxColumn, Me.DistDataGridViewTextBoxColumn, Me.LEFTDataGridViewTextBoxColumn, Me.UnitDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.ClassIDDataGridViewTextBoxColumn, Me.DtDataGridViewTextBoxColumn, Me.DISTDATEDataGridViewTextBoxColumn, Me.DistractorDataGridViewTextBoxColumn, Me.AccountDataGridViewTextBoxColumn, Me.BALANCEDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BalanceBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(616, 303)
        Me.DataGridView1.TabIndex = 23
        '
        'ImpDataGridViewTextBoxColumn
        '
        Me.ImpDataGridViewTextBoxColumn.DataPropertyName = "Imp"
        Me.ImpDataGridViewTextBoxColumn.HeaderText = "«·Ê«—œ"
        Me.ImpDataGridViewTextBoxColumn.Name = "ImpDataGridViewTextBoxColumn"
        Me.ImpDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DistDataGridViewTextBoxColumn
        '
        Me.DistDataGridViewTextBoxColumn.DataPropertyName = "Dist"
        Me.DistDataGridViewTextBoxColumn.HeaderText = "«·„‰’—›"
        Me.DistDataGridViewTextBoxColumn.Name = "DistDataGridViewTextBoxColumn"
        Me.DistDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LEFTDataGridViewTextBoxColumn
        '
        Me.LEFTDataGridViewTextBoxColumn.DataPropertyName = "LEFT"
        Me.LEFTDataGridViewTextBoxColumn.HeaderText = "«·„ »ﬁÌ «Ê «·„ÕÊ·"
        Me.LEFTDataGridViewTextBoxColumn.Name = "LEFTDataGridViewTextBoxColumn"
        Me.LEFTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UnitDataGridViewTextBoxColumn
        '
        Me.UnitDataGridViewTextBoxColumn.DataPropertyName = "Unit"
        Me.UnitDataGridViewTextBoxColumn.HeaderText = "ÊÕœ… «·⁄Ì‰…"
        Me.UnitDataGridViewTextBoxColumn.Name = "UnitDataGridViewTextBoxColumn"
        Me.UnitDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "«·’‰›"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClassIDDataGridViewTextBoxColumn
        '
        Me.ClassIDDataGridViewTextBoxColumn.DataPropertyName = "ClassID"
        Me.ClassIDDataGridViewTextBoxColumn.HeaderText = "‰„—… «·⁄Ì‰…"
        Me.ClassIDDataGridViewTextBoxColumn.Name = "ClassIDDataGridViewTextBoxColumn"
        Me.ClassIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DtDataGridViewTextBoxColumn
        '
        Me.DtDataGridViewTextBoxColumn.DataPropertyName = "Dt"
        Me.DtDataGridViewTextBoxColumn.HeaderText = "«· «—ÌŒ"
        Me.DtDataGridViewTextBoxColumn.Name = "DtDataGridViewTextBoxColumn"
        Me.DtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DISTDATEDataGridViewTextBoxColumn
        '
        Me.DISTDATEDataGridViewTextBoxColumn.DataPropertyName = "DISTDATE"
        Me.DISTDATEDataGridViewTextBoxColumn.HeaderText = "DISTDATE"
        Me.DISTDATEDataGridViewTextBoxColumn.Name = "DISTDATEDataGridViewTextBoxColumn"
        Me.DISTDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DistractorDataGridViewTextBoxColumn
        '
        Me.DistractorDataGridViewTextBoxColumn.DataPropertyName = "Distractor"
        Me.DistractorDataGridViewTextBoxColumn.HeaderText = "Distractor"
        Me.DistractorDataGridViewTextBoxColumn.Name = "DistractorDataGridViewTextBoxColumn"
        Me.DistractorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AccountDataGridViewTextBoxColumn
        '
        Me.AccountDataGridViewTextBoxColumn.DataPropertyName = "Account"
        Me.AccountDataGridViewTextBoxColumn.HeaderText = "Account"
        Me.AccountDataGridViewTextBoxColumn.Name = "AccountDataGridViewTextBoxColumn"
        Me.AccountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BALANCEDDataGridViewTextBoxColumn
        '
        Me.BALANCEDDataGridViewTextBoxColumn.DataPropertyName = "BALANCED"
        Me.BALANCEDDataGridViewTextBoxColumn.HeaderText = "BALANCED"
        Me.BALANCEDDataGridViewTextBoxColumn.Name = "BALANCEDDataGridViewTextBoxColumn"
        Me.BALANCEDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BalanceBindingSource
        '
        Me.BalanceBindingSource.DataMember = "Balance"
        Me.BalanceBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BalanceTableAdapter
        '
        Me.BalanceTableAdapter.ClearBeforeFill = True
        '
        'frmBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.fmeImported)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 50)
        Me.Name = "frmBalance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "«·√—’‹‹‹‹‹œ… «·„Õ‹‹‹‹‹‹‹‹Ê·…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.fmeImported.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BalanceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents BalanceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BalanceTableAdapter As Explosives.dsExplosivesTableAdapters.BalanceTableAdapter
    Friend WithEvents ImpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LEFTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClassIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DtDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DISTDATEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DistractorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BALANCEDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
#End Region 
End Class