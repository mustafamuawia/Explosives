<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmClasses
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
	Public WithEvents cmdImpDistDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdImpDistFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdImpDISTAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Public WithEvents Option1 As System.Windows.Forms.RadioButton
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmbAccount As System.Windows.Forms.ComboBox
    Public WithEvents txtClassID As System.Windows.Forms.TextBox
    Public WithEvents txtClass As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblRecent As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lblImported As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents lblDistracted As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Command2 As System.Windows.Forms.Button
    Public WithEvents Command1 As System.Windows.Forms.Button
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
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdImpDistDoc = New System.Windows.Forms.CheckBox()
        Me.cmdImpDistFound = New System.Windows.Forms.CheckBox()
        Me.cmdImpDISTAll = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Option1 = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.CLASSESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.UnitBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.UnitDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbAccount = New System.Windows.Forms.ComboBox()
        Me.txtClassID = New System.Windows.Forms.TextBox()
        Me.txtClass = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblRecent = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblImported = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblDistracted = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Command2 = New System.Windows.Forms.Button()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.CLASSESTableAdapter = New Explosives.dsExplosivesTableAdapters.CLASSESTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.CLASSESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UnitDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1272, 24)
        Me.MainMenu1.TabIndex = 45
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
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
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdImpDistDoc)
        Me.Frame9.Controls.Add(Me.cmdImpDistFound)
        Me.Frame9.Controls.Add(Me.cmdImpDISTAll)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(328, 93)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(617, 179)
        Me.Frame9.TabIndex = 44
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "   »Ì«‰«  «·„›—ﬁ⁄«    "
        '
        'cmdImpDistDoc
        '
        Me.cmdImpDistDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdImpDistDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdImpDistDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImpDistDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdImpDistDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdImpDistDoc.Location = New System.Drawing.Point(456, 64)
        Me.cmdImpDistDoc.Name = "cmdImpDistDoc"
        Me.cmdImpDistDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdImpDistDoc.Size = New System.Drawing.Size(145, 41)
        Me.cmdImpDistDoc.TabIndex = 2
        Me.cmdImpDistDoc.Text = "„⁄ «·Ê«—œ Ê «·„‰’—›"
        Me.cmdImpDistDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdImpDistDoc.UseVisualStyleBackColor = False
        '
        'cmdImpDistFound
        '
        Me.cmdImpDistFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdImpDistFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdImpDistFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImpDistFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdImpDistFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdImpDistFound.Location = New System.Drawing.Point(240, 64)
        Me.cmdImpDistFound.Name = "cmdImpDistFound"
        Me.cmdImpDistFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdImpDistFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdImpDistFound.TabIndex = 4
        Me.cmdImpDistFound.Text = "„⁄ «·Ê«—œ Ê «·„‰’—›"
        Me.cmdImpDistFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdImpDistFound.UseVisualStyleBackColor = False
        '
        'cmdImpDISTAll
        '
        Me.cmdImpDISTAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdImpDISTAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdImpDISTAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdImpDISTAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdImpDISTAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdImpDISTAll.Location = New System.Drawing.Point(24, 64)
        Me.cmdImpDISTAll.Name = "cmdImpDISTAll"
        Me.cmdImpDISTAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdImpDISTAll.Size = New System.Drawing.Size(145, 41)
        Me.cmdImpDISTAll.TabIndex = 6
        Me.cmdImpDISTAll.Text = "„⁄ «·Ê«—œ Ê «·„‰’—›"
        Me.cmdImpDISTAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdImpDISTAll.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(456, 120)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(145, 41)
        Me.cmdReturn.TabIndex = 7
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdLogout
        '
        Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLogout.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(240, 120)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(145, 41)
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
        Me.cmdExit.Location = New System.Drawing.Point(24, 120)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(145, 41)
        Me.cmdExit.TabIndex = 9
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintAll.Location = New System.Drawing.Point(24, 24)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(145, 41)
        Me.cmdPrintAll.TabIndex = 5
        Me.cmdPrintAll.Text = "ÿ»«⁄… ﬂ«›… «·√’‰«›"
        Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintAll.UseVisualStyleBackColor = False
        '
        'cmdFound
        '
        Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFound.Location = New System.Drawing.Point(240, 24)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdFound.TabIndex = 3
        Me.cmdFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
        Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFound.UseVisualStyleBackColor = False
        '
        'cmdPrintDoc
        '
        Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintDoc.Location = New System.Drawing.Point(456, 24)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(145, 41)
        Me.cmdPrintDoc.TabIndex = 1
        Me.cmdPrintDoc.Text = "ÿ»«⁄… «·’‰›"
        Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintDoc.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.lblPosition)
        Me.Frame2.Controls.Add(Me.cmbCriteria)
        Me.Frame2.Controls.Add(Me.txtFind)
        Me.Frame2.Controls.Add(Me.Frame3)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(328, 441)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(617, 110)
        Me.Frame2.TabIndex = 42
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " «·»ÕÀ ⁄‰ ”Ã· "
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(392, 73)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(97, 13)
        Me.lblPosition.TabIndex = 46
        Me.lblPosition.Text = "***************"
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "«”„ «·’‰›", "ÊÕœ… «·ﬁÌ«”", "«·Õ”«»", "Ê«—œ Ê„‰’—› ’‰› ›Ì › —… „«"})
        Me.cmbCriteria.Location = New System.Drawing.Point(320, 16)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(201, 21)
        Me.cmbCriteria.TabIndex = 14
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(320, 40)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFind.Size = New System.Drawing.Size(201, 20)
        Me.txtFind.TabIndex = 15
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.dtpTo)
        Me.Frame3.Controls.Add(Me.dtpFrom)
        Me.Frame3.Controls.Add(Me.Option1)
        Me.Frame3.Controls.Add(Me.Label6)
        Me.Frame3.Controls.Add(Me.Label8)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(8, 16)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(306, 49)
        Me.Frame3.TabIndex = 45
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " »ÕÀ ›Ì «·› —… "
        '
        'dtpTo
        '
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(28, 19)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(75, 20)
        Me.dtpTo.TabIndex = 48
        '
        'dtpFrom
        '
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(152, 18)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(75, 20)
        Me.dtpFrom.TabIndex = 48
        '
        'Option1
        '
        Me.Option1.BackColor = System.Drawing.Color.Transparent
        Me.Option1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Option1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Option1.ForeColor = System.Drawing.Color.Transparent
        Me.Option1.Location = New System.Drawing.Point(248, 19)
        Me.Option1.Name = "Option1"
        Me.Option1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Option1.Size = New System.Drawing.Size(49, 25)
        Me.Option1.TabIndex = 16
        Me.Option1.TabStop = True
        Me.Option1.Text = "ﬂ· «·› —…"
        Me.Option1.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(109, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(36, 20)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "≈·Ï"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(219, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(30, 20)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "„‰"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Frame6.Location = New System.Drawing.Point(328, 604)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(617, 57)
        Me.Frame6.TabIndex = 40
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(255, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 25
        Me.cmdEdit.Text = " ‹‹‹⁄‹‹‹œÌ·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(160, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹«¡"
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
        Me.cmdSave.Location = New System.Drawing.Point(357, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 24
        Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(458, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 23
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
        Me.cmdDelete.Location = New System.Drawing.Point(72, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 41
        Me.cmdDelete.Text = "Õ‹‹‹‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(328, 550)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(617, 57)
        Me.Frame7.TabIndex = 39
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(307, 16)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 19
        Me.cmdNext.Text = "< «· ‹‹‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLast.Location = New System.Drawing.Point(408, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 21
        Me.cmdLast.Text = "<< «·√ŒÌ‹‹‹—"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(104, 16)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 22
        Me.cmdFirst.Text = "«·√Ê· >>"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(205, 16)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 20
        Me.cmdPrev.Text = "«·”‹‹‹‹«»ﬁ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmbUnit)
        Me.Frame1.Controls.Add(Me.cmbAccount)
        Me.Frame1.Controls.Add(Me.txtClassID)
        Me.Frame1.Controls.Add(Me.txtClass)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.lblRecent)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.lblImported)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.lblDistracted)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(328, 272)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(617, 169)
        Me.Frame1.TabIndex = 29
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì«‰«  «·√’‰«›  "
        '
        'cmbUnit
        '
        Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.CLASSESBindingSource, "UNIT", True))
        Me.cmbUnit.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "UNIT", True))
        Me.cmbUnit.DataSource = Me.UnitBindingSource1
        Me.cmbUnit.DisplayMember = "UNIT"
        Me.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Location = New System.Drawing.Point(321, 65)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbUnit.Size = New System.Drawing.Size(208, 21)
        Me.cmbUnit.TabIndex = 13
        Me.cmbUnit.ValueMember = "UNIT"
        '
        'CLASSESBindingSource
        '
        Me.CLASSESBindingSource.DataMember = "CLASSES"
        Me.CLASSESBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UnitBindingSource1
        '
        Me.UnitBindingSource1.DataMember = "CLASSES"
        Me.UnitBindingSource1.DataSource = Me.UnitDsExplosives1
        '
        'UnitDsExplosives1
        '
        Me.UnitDsExplosives1.DataSetName = "dsExplosives"
        Me.UnitDsExplosives1.EnforceConstraints = False
        Me.UnitDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbAccount
        '
        Me.cmbAccount.BackColor = System.Drawing.SystemColors.Window
        Me.cmbAccount.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbAccount.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAccount.Items.AddRange(New Object() {"«·⁄«»", "„›—ﬁ⁄« ", "’Ê«—ÌŒ"})
        Me.cmbAccount.Location = New System.Drawing.Point(8, 64)
        Me.cmbAccount.Name = "cmbAccount"
        Me.cmbAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbAccount.Size = New System.Drawing.Size(209, 21)
        Me.cmbAccount.TabIndex = 13
        '
        'txtClassID
        '
        Me.txtClassID.AcceptsReturn = True
        Me.txtClassID.BackColor = System.Drawing.SystemColors.Window
        Me.txtClassID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClassID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "ID", True))
        Me.txtClassID.Enabled = False
        Me.txtClassID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtClassID.Location = New System.Drawing.Point(8, 32)
        Me.txtClassID.MaxLength = 0
        Me.txtClassID.Name = "txtClassID"
        Me.txtClassID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClassID.Size = New System.Drawing.Size(209, 20)
        Me.txtClassID.TabIndex = 11
        Me.txtClassID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtClass
        '
        Me.txtClass.AcceptsReturn = True
        Me.txtClass.BackColor = System.Drawing.SystemColors.Window
        Me.txtClass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtClass.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "CLASS", True))
        Me.txtClass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtClass.Location = New System.Drawing.Point(320, 32)
        Me.txtClass.MaxLength = 0
        Me.txtClass.Name = "txtClass"
        Me.txtClass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtClass.Size = New System.Drawing.Size(209, 20)
        Me.txtClass.TabIndex = 10
        Me.txtClass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(224, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Õ”«»"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblRecent
        '
        Me.lblRecent.BackColor = System.Drawing.SystemColors.Window
        Me.lblRecent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecent.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblRecent.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "RECENT", True))
        Me.lblRecent.Enabled = False
        Me.lblRecent.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblRecent.Location = New System.Drawing.Point(320, 128)
        Me.lblRecent.Name = "lblRecent"
        Me.lblRecent.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblRecent.Size = New System.Drawing.Size(209, 27)
        Me.lblRecent.TabIndex = 38
        Me.lblRecent.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(536, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "«·ﬂ„Ì… «·„ÊÃÊœ… "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(536, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(73, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "ÊÕœ… «·ﬁÌ«”"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(240, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(49, 17)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "‰„—… «·⁄Ì‰…"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(544, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(81, 17)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "«”„ «·’‰›"
        '
        'lblImported
        '
        Me.lblImported.BackColor = System.Drawing.SystemColors.Window
        Me.lblImported.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblImported.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblImported.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "IMPORTED", True))
        Me.lblImported.Enabled = False
        Me.lblImported.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblImported.Location = New System.Drawing.Point(320, 96)
        Me.lblImported.Name = "lblImported"
        Me.lblImported.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblImported.Size = New System.Drawing.Size(209, 27)
        Me.lblImported.TabIndex = 30
        Me.lblImported.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(528, 104)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(89, 17)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "«·ﬂ„Ì… «·Ê«—œ…"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDistracted
        '
        Me.lblDistracted.BackColor = System.Drawing.SystemColors.Window
        Me.lblDistracted.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDistracted.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblDistracted.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLASSESBindingSource, "DISTRACTED", True))
        Me.lblDistracted.Enabled = False
        Me.lblDistracted.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDistracted.Location = New System.Drawing.Point(8, 96)
        Me.lblDistracted.Name = "lblDistracted"
        Me.lblDistracted.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblDistracted.Size = New System.Drawing.Size(209, 27)
        Me.lblDistracted.TabIndex = 32
        Me.lblDistracted.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(224, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(89, 17)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "«·ﬂ„Ì… «·’«œ—…"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Command2
        '
        Me.Command2.BackColor = System.Drawing.SystemColors.Control
        Me.Command2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command2.Location = New System.Drawing.Point(104, 272)
        Me.Command2.Name = "Command2"
        Me.Command2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command2.Size = New System.Drawing.Size(89, 41)
        Me.Command2.TabIndex = 28
        Me.Command2.Text = "Command2"
        Me.Command2.UseVisualStyleBackColor = False
        Me.Command2.Visible = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(104, 192)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(89, 81)
        Me.Command1.TabIndex = 27
        Me.Command1.Text = "Command1"
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
        '
        'CLASSESTableAdapter
        '
        Me.CLASSESTableAdapter.ClearBeforeFill = True
        '
        'frmClasses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 734)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmClasses"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "√’‹‹‰‹‹‹‹‹‹‹‹‹‹‹‹«› «·„›ﬁ‹‹‹—ﬁ⁄‹‹‹‹‹‹‹‹‹‹« "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.CLASSESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UnitDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents CLASSESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CLASSESTableAdapter As Explosives.dsExplosivesTableAdapters.CLASSESTableAdapter
    Public WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents UnitDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents UnitBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblPosition As System.Windows.Forms.Label
#End Region 
End Class