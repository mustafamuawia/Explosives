<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmImportAllowed
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
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents txtSideName As System.Windows.Forms.TextBox
    Public WithEvents txtId As System.Windows.Forms.TextBox
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
	Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents txtOther As System.Windows.Forms.TextBox
	Public WithEvents txtTel3 As System.Windows.Forms.TextBox
	Public WithEvents txtTel2 As System.Windows.Forms.TextBox
	Public WithEvents txtTel1 As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents txtFax As System.Windows.Forms.TextBox
	Public WithEvents txtE_mail As System.Windows.Forms.TextBox
	Public WithEvents txtPOB As System.Windows.Forms.TextBox
	Public WithEvents txtAddress As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
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
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker()
        Me.IMPORTALLOWEDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.txtSideName = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.chbIsDistractor = New System.Windows.Forms.CheckBox()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtTel3 = New System.Windows.Forms.TextBox()
        Me.txtTel2 = New System.Windows.Forms.TextBox()
        Me.txtTel1 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFax = New System.Windows.Forms.TextBox()
        Me.txtE_mail = New System.Windows.Forms.TextBox()
        Me.txtPOB = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.IMPORTALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1272, 24)
        Me.MainMenu1.TabIndex = 51
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
        Me.cmdRefresh.TabIndex = 50
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
        Me.Frame9.Location = New System.Drawing.Point(59, 104)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1153, 75)
        Me.Frame9.TabIndex = 42
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "  Œ‹‹Ì‹‹‹‹‹‹‹‹‹‹‹‹«—«   "
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(424, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 41
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
        Me.cmdPrintDoc.Location = New System.Drawing.Point(888, 24)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdPrintDoc.TabIndex = 47
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
        Me.cmdFound.Location = New System.Drawing.Point(723, 24)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdFound.TabIndex = 46
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
        Me.cmdPrintAll.Location = New System.Drawing.Point(574, 24)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdPrintAll.TabIndex = 45
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
        Me.cmdExit.Location = New System.Drawing.Point(128, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(129, 41)
        Me.cmdExit.TabIndex = 44
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
        Me.cmdLogout.Location = New System.Drawing.Point(277, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 43
        Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(312, 488)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command1.Size = New System.Drawing.Size(121, 41)
        Me.Command1.TabIndex = 40
        Me.Command1.Text = "Command1"
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.dtpFDate)
        Me.Frame5.Controls.Add(Me.txtSideName)
        Me.Frame5.Controls.Add(Me.txtId)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(739, 179)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(473, 97)
        Me.Frame5.TabIndex = 28
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " »Ì«‰«  «·„·› "
        '
        'dtpFDate
        '
        Me.dtpFDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.IMPORTALLOWEDBindingSource, "FDATE", True))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFDate.Location = New System.Drawing.Point(8, 26)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.Size = New System.Drawing.Size(167, 20)
        Me.dtpFDate.TabIndex = 35
        '
        'IMPORTALLOWEDBindingSource
        '
        Me.IMPORTALLOWEDBindingSource.DataMember = "IMPORTALLOWED"
        Me.IMPORTALLOWEDBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSideName
        '
        Me.txtSideName.AcceptsReturn = True
        Me.txtSideName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSideName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "SIDENAME", True))
        Me.txtSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSideName.Location = New System.Drawing.Point(8, 56)
        Me.txtSideName.MaxLength = 0
        Me.txtSideName.Multiline = True
        Me.txtSideName.Name = "txtSideName"
        Me.txtSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSideName.Size = New System.Drawing.Size(385, 25)
        Me.txtSideName.TabIndex = 33
        Me.txtSideName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtId
        '
        Me.txtId.AcceptsReturn = True
        Me.txtId.BackColor = System.Drawing.SystemColors.Window
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "ID", True))
        Me.txtId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtId.Location = New System.Drawing.Point(248, 24)
        Me.txtId.MaxLength = 0
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtId.Size = New System.Drawing.Size(145, 25)
        Me.txtId.TabIndex = 29
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(400, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(65, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "«”„ «·ÃÂ…"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(168, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "«· «—ÌŒ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(400, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(65, 25)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "‰„—… «·„·›"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.cmbCriteria)
        Me.Frame3.Controls.Add(Me.cmdFindNext)
        Me.Frame3.Controls.Add(Me.cmdFindPrev)
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(740, 276)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(473, 104)
        Me.Frame3.TabIndex = 26
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " «·‹»‹‹‹‹Õ‹‹‹‹‹‹À "
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "‰„—… «·„·›", "«”„ «·ÃÂ…", "«·⁄‰Ê«‰"})
        Me.cmbCriteria.Location = New System.Drawing.Point(280, 24)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCriteria.Size = New System.Drawing.Size(169, 21)
        Me.cmbCriteria.TabIndex = 48
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindNext.Location = New System.Drawing.Point(232, 24)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindNext.TabIndex = 39
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindPrev.Location = New System.Drawing.Point(32, 24)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindPrev.TabIndex = 38
        Me.cmdFindPrev.Text = ">"
        Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindPrev.UseVisualStyleBackColor = False
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(72, 24)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(153, 25)
        Me.txtFind.TabIndex = 27
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(40, 64)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 49
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(740, 380)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(473, 57)
        Me.Frame7.TabIndex = 21
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(251, 16)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 25
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
        Me.cmdLast.Location = New System.Drawing.Point(344, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 24
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
        Me.cmdFirst.Location = New System.Drawing.Point(48, 16)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 23
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
        Me.cmdPrev.Location = New System.Drawing.Point(149, 16)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 22
        Me.cmdPrev.Text = "«·”‹‹‹‹«»ﬁ >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(59, 380)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(681, 57)
        Me.Frame6.TabIndex = 16
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(149, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 37
        Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        Me.cmdCancel.Visible = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(352, 16)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 20
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
        Me.cmdNew.Location = New System.Drawing.Point(456, 16)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 19
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
        Me.cmdDelete.Location = New System.Drawing.Point(48, 16)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 18
        Me.cmdDelete.Text = "Õ‹‹‹‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(248, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 17
        Me.cmdEdit.Text = " ‹‹‹⁄‹‹‹œÌ·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.chbIsDistractor)
        Me.Frame1.Controls.Add(Me.txtOther)
        Me.Frame1.Controls.Add(Me.Frame2)
        Me.Frame1.Controls.Add(Me.txtFax)
        Me.Frame1.Controls.Add(Me.txtE_mail)
        Me.Frame1.Controls.Add(Me.txtPOB)
        Me.Frame1.Controls.Add(Me.txtAddress)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(59, 179)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(681, 201)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " »Ì«‰«  «·≈ ’«· "
        '
        'chbIsDistractor
        '
        Me.chbIsDistractor.AutoSize = True
        Me.chbIsDistractor.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.IMPORTALLOWEDBindingSource, "IsDistributor", True))
        Me.chbIsDistractor.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.chbIsDistractor.Location = New System.Drawing.Point(82, 24)
        Me.chbIsDistractor.Name = "chbIsDistractor"
        Me.chbIsDistractor.Size = New System.Drawing.Size(95, 21)
        Me.chbIsDistractor.TabIndex = 37
        Me.chbIsDistractor.Text = "ÊÕœ… ’«—›…"
        Me.chbIsDistractor.UseVisualStyleBackColor = True
        '
        'txtOther
        '
        Me.txtOther.AcceptsReturn = True
        Me.txtOther.BackColor = System.Drawing.SystemColors.Window
        Me.txtOther.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOther.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "OTHER", True))
        Me.txtOther.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtOther.Location = New System.Drawing.Point(16, 160)
        Me.txtOther.MaxLength = 0
        Me.txtOther.Multiline = True
        Me.txtOther.Name = "txtOther"
        Me.txtOther.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtOther.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOther.Size = New System.Drawing.Size(249, 25)
        Me.txtOther.TabIndex = 35
        Me.txtOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.txtTel3)
        Me.Frame2.Controls.Add(Me.txtTel2)
        Me.Frame2.Controls.Add(Me.txtTel1)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label4)
        Me.Frame2.Controls.Add(Me.Label3)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(8, 56)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(657, 65)
        Me.Frame2.TabIndex = 9
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " √—ﬁ«„ ÂÊ« › "
        '
        'txtTel3
        '
        Me.txtTel3.AcceptsReturn = True
        Me.txtTel3.BackColor = System.Drawing.SystemColors.Window
        Me.txtTel3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "TEL3", True))
        Me.txtTel3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTel3.Location = New System.Drawing.Point(16, 16)
        Me.txtTel3.MaxLength = 0
        Me.txtTel3.Multiline = True
        Me.txtTel3.Name = "txtTel3"
        Me.txtTel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTel3.Size = New System.Drawing.Size(153, 25)
        Me.txtTel3.TabIndex = 14
        Me.txtTel3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTel2
        '
        Me.txtTel2.AcceptsReturn = True
        Me.txtTel2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTel2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "TEL2", True))
        Me.txtTel2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTel2.Location = New System.Drawing.Point(228, 16)
        Me.txtTel2.MaxLength = 0
        Me.txtTel2.Multiline = True
        Me.txtTel2.Name = "txtTel2"
        Me.txtTel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTel2.Size = New System.Drawing.Size(153, 25)
        Me.txtTel2.TabIndex = 12
        Me.txtTel2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTel1
        '
        Me.txtTel1.AcceptsReturn = True
        Me.txtTel1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "TEL1", True))
        Me.txtTel1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTel1.Location = New System.Drawing.Point(440, 16)
        Me.txtTel1.MaxLength = 0
        Me.txtTel1.Multiline = True
        Me.txtTel1.Name = "txtTel1"
        Me.txtTel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtTel1.Size = New System.Drawing.Size(153, 25)
        Me.txtTel1.TabIndex = 10
        Me.txtTel1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(160, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "3"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(376, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "2"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(584, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "1"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFax
        '
        Me.txtFax.AcceptsReturn = True
        Me.txtFax.BackColor = System.Drawing.SystemColors.Window
        Me.txtFax.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFax.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "FAX", True))
        Me.txtFax.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFax.Location = New System.Drawing.Point(16, 128)
        Me.txtFax.MaxLength = 0
        Me.txtFax.Multiline = True
        Me.txtFax.Name = "txtFax"
        Me.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFax.Size = New System.Drawing.Size(249, 25)
        Me.txtFax.TabIndex = 7
        Me.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtE_mail
        '
        Me.txtE_mail.AcceptsReturn = True
        Me.txtE_mail.BackColor = System.Drawing.SystemColors.Window
        Me.txtE_mail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtE_mail.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "E_MAIL", True))
        Me.txtE_mail.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtE_mail.Location = New System.Drawing.Point(336, 128)
        Me.txtE_mail.MaxLength = 0
        Me.txtE_mail.Multiline = True
        Me.txtE_mail.Name = "txtE_mail"
        Me.txtE_mail.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtE_mail.Size = New System.Drawing.Size(249, 25)
        Me.txtE_mail.TabIndex = 5
        '
        'txtPOB
        '
        Me.txtPOB.AcceptsReturn = True
        Me.txtPOB.BackColor = System.Drawing.SystemColors.Window
        Me.txtPOB.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPOB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "POB", True))
        Me.txtPOB.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPOB.Location = New System.Drawing.Point(336, 160)
        Me.txtPOB.MaxLength = 0
        Me.txtPOB.Multiline = True
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPOB.Size = New System.Drawing.Size(249, 25)
        Me.txtPOB.TabIndex = 2
        Me.txtPOB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAddress
        '
        Me.txtAddress.AcceptsReturn = True
        Me.txtAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.IMPORTALLOWEDBindingSource, "ADDRESS", True))
        Me.txtAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAddress.Location = New System.Drawing.Point(236, 24)
        Me.txtAddress.MaxLength = 0
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAddress.Size = New System.Drawing.Size(349, 25)
        Me.txtAddress.TabIndex = 1
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(272, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "√Œ‹‹‹—Ï"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(272, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(65, 33)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "›«ﬂ”"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(592, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(65, 33)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "»—Ìœ ≈·ﬂ —Ê‰Ì"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(592, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(65, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "’‰œÊﬁ »—Ìœ"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(600, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 33)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "«·⁄‰Ê«‰"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'IMPORTALLOWEDTableAdapter
        '
        Me.IMPORTALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'frmImportAllowed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 662)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmImportAllowed"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "«·‘—ﬂ«  «·„’—Õ ·Â« »«” Ì—«œ «·„›—ﬁ⁄« "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.IMPORTALLOWEDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents IMPORTALLOWEDBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IMPORTALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbIsDistractor As System.Windows.Forms.CheckBox
#End Region
End Class