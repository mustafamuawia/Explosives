<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFinance
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
	Public WithEvents cmdInOut As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmbReceivee As System.Windows.Forms.ComboBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Label28 As System.Windows.Forms.Label
    Public WithEvents Label29 As System.Windows.Forms.Label
    Public WithEvents lblPosition As System.Windows.Forms.Label
    Public WithEvents Frame2 As System.Windows.Forms.GroupBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmbSideName As System.Windows.Forms.ComboBox
    Public WithEvents txtID As System.Windows.Forms.TextBox
    Public WithEvents txtReceiver As System.Windows.Forms.TextBox
    Public WithEvents cmbStation As System.Windows.Forms.ComboBox
    Public WithEvents txtreceivee As System.Windows.Forms.TextBox
    Public WithEvents cmbCertifier As System.Windows.Forms.ComboBox
    Public WithEvents txtMoneyText As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdInOut = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.dtpDate1 = New System.Windows.Forms.DateTimePicker()
        Me.dtpDate2 = New System.Windows.Forms.DateTimePicker()
        Me.cmbReceivee = New System.Windows.Forms.ComboBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtData = New System.Windows.Forms.TextBox()
        Me.nudMoney = New System.Windows.Forms.NumericUpDown()
        Me.FINANCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.nudAmount = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Amount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbCome = New System.Windows.Forms.ComboBox()
        Me.cmbSideName = New System.Windows.Forms.ComboBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtReceiver = New System.Windows.Forms.TextBox()
        Me.cmbStation = New System.Windows.Forms.ComboBox()
        Me.txtreceivee = New System.Windows.Forms.TextBox()
        Me.cmbCertifier = New System.Windows.Forms.ComboBox()
        Me.txtMoneyText = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.FINANCETableAdapter = New Explosives.dsExplosivesTableAdapters.FINANCETableAdapter()
        Me.StatesTableAdapter1 = New Explosives.dsExplosivesTableAdapters.StatesTableAdapter()
        Me.FinanceDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.FinanceDetailsTableAdapter()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankFINANCEBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionFINANCEBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives3 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.NameFINANCEBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives2 = New Explosives.dsExplosives()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame2.SuspendLayout()
        Me.Frame8.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.nudMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FINANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RankFINANCEBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionFINANCEBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameFINANCEBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1350, 24)
        Me.MainMenu1.TabIndex = 48
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
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
        Me.cmdRefresh.TabIndex = 47
        Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdInOut)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(786, 437)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(377, 223)
        Me.Frame9.TabIndex = 40
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "  ≈Ã—«¡«  «·‰Ÿ«„  "
        '
        'cmdInOut
        '
        Me.cmdInOut.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdInOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdInOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInOut.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdInOut.Location = New System.Drawing.Point(8, 104)
        Me.cmdInOut.Name = "cmdInOut"
        Me.cmdInOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdInOut.Size = New System.Drawing.Size(177, 33)
        Me.cmdInOut.TabIndex = 57
        Me.cmdInOut.Text = "ÿ»‹‹‹«⁄… Ê«—œ/„‰‹‹‹‹’—›"
        Me.cmdInOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdInOut.UseVisualStyleBackColor = False
        '
        'cmdPrintAll
        '
        Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintAll.Location = New System.Drawing.Point(8, 64)
        Me.cmdPrintAll.Name = "cmdPrintAll"
        Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintAll.Size = New System.Drawing.Size(177, 33)
        Me.cmdPrintAll.TabIndex = 46
        Me.cmdPrintAll.Text = "ÿ‹‹»‹‹«⁄… «·‹‹‹‹ﬂ‹‹‹·"
        Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintAll.UseVisualStyleBackColor = False
        '
        'cmdPrintDoc
        '
        Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrintDoc.Location = New System.Drawing.Point(192, 64)
        Me.cmdPrintDoc.Name = "cmdPrintDoc"
        Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrintDoc.Size = New System.Drawing.Size(177, 33)
        Me.cmdPrintDoc.TabIndex = 45
        Me.cmdPrintDoc.Text = "ÿ‹‹‹»‹«⁄… «·„” ‰œ"
        Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintDoc.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdExit.Location = New System.Drawing.Point(8, 184)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(177, 33)
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
        Me.cmdLogout.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLogout.Location = New System.Drawing.Point(192, 184)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(177, 33)
        Me.cmdLogout.TabIndex = 43
        Me.cmdLogout.Text = " ”ÃÌ‹· Œ‹‹‹‹—ÊÃ"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(8, 144)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(361, 33)
        Me.cmdReturn.TabIndex = 42
        Me.cmdReturn.Text = "—Ã‹‹‹‹‹‹‹‹‹‹Ê⁄"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdFound
        '
        Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFound.Enabled = False
        Me.cmdFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFound.Location = New System.Drawing.Point(192, 104)
        Me.cmdFound.Name = "cmdFound"
        Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFound.Size = New System.Drawing.Size(177, 33)
        Me.cmdFound.TabIndex = 41
        Me.cmdFound.Text = "ÿ‹‹‹»‹«⁄‹… ‰‹ ‹ÌÃ‹… «·‹»‹‹Õ‹‹‹À"
        Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFound.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.dtpDate1)
        Me.Frame2.Controls.Add(Me.dtpDate2)
        Me.Frame2.Controls.Add(Me.cmbReceivee)
        Me.Frame2.Controls.Add(Me.cmbCriteria)
        Me.Frame2.Controls.Add(Me.txtFind)
        Me.Frame2.Controls.Add(Me.cmdFindPrev)
        Me.Frame2.Controls.Add(Me.cmdFindNext)
        Me.Frame2.Controls.Add(Me.Label13)
        Me.Frame2.Controls.Add(Me.Label15)
        Me.Frame2.Controls.Add(Me.Label28)
        Me.Frame2.Controls.Add(Me.Label29)
        Me.Frame2.Controls.Add(Me.lblPosition)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(787, 108)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(377, 201)
        Me.Frame2.TabIndex = 31
        Me.Frame2.TabStop = False
        Me.Frame2.Text = " «·‹‹‹‹»Õ‹‹‹‹‹À "
        '
        'dtpDate1
        '
        Me.dtpDate1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate1.Location = New System.Drawing.Point(192, 162)
        Me.dtpDate1.Name = "dtpDate1"
        Me.dtpDate1.Size = New System.Drawing.Size(122, 20)
        Me.dtpDate1.TabIndex = 54
        '
        'dtpDate2
        '
        Me.dtpDate2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate2.Location = New System.Drawing.Point(16, 162)
        Me.dtpDate2.Name = "dtpDate2"
        Me.dtpDate2.Size = New System.Drawing.Size(122, 20)
        Me.dtpDate2.TabIndex = 54
        '
        'cmbReceivee
        '
        Me.cmbReceivee.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReceivee.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbReceivee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReceivee.Items.AddRange(New Object() {"‰„—… «·„” ‰œ", "«·Õ”«»", "«·ÊÕœ… «·’«—›…", "«·ÊÕœ… «·„” ·„…", " «—ÌŒ «·’—›", "› —…  «—ÌŒÌ…"})
        Me.cmbReceivee.Location = New System.Drawing.Point(16, 112)
        Me.cmbReceivee.Name = "cmbReceivee"
        Me.cmbReceivee.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbReceivee.Size = New System.Drawing.Size(297, 21)
        Me.cmbReceivee.TabIndex = 55
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"«·ﬂ·", "‰„—… «·„” ‰œ", "«·‘«Âœ", "«·ÃÂ… «·œ«›⁄…", " «—ÌŒ «·„” ‰œ", "› —…  «—ÌŒÌ…", "«· ’—ÌÕ √Ê «·≈–‰"})
        Me.cmbCriteria.Location = New System.Drawing.Point(16, 84)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(297, 21)
        Me.cmbCriteria.TabIndex = 53
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(64, 24)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(249, 25)
        Me.txtFind.TabIndex = 36
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindPrev.Location = New System.Drawing.Point(24, 24)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindPrev.TabIndex = 35
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
        Me.cmdFindNext.Location = New System.Drawing.Point(320, 24)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindNext.TabIndex = 34
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(326, 108)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label13.Size = New System.Drawing.Size(37, 29)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "«·ÃÂ… «·œ«›⁄…"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(320, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "»‹Õ‹À »"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label28
        '
        Me.Label28.BackColor = System.Drawing.Color.Transparent
        Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label28.ForeColor = System.Drawing.Color.White
        Me.Label28.Location = New System.Drawing.Point(320, 168)
        Me.Label28.Name = "Label28"
        Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label28.Size = New System.Drawing.Size(33, 17)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "„‹‹‰"
        Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label29
        '
        Me.Label29.BackColor = System.Drawing.Color.Transparent
        Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label29.ForeColor = System.Drawing.Color.White
        Me.Label29.Location = New System.Drawing.Point(144, 168)
        Me.Label29.Name = "Label29"
        Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label29.Size = New System.Drawing.Size(33, 17)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "≈·‹‹‹Ï"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(16, 56)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPosition.Size = New System.Drawing.Size(345, 17)
        Me.lblPosition.TabIndex = 37
        Me.lblPosition.Text = " „ «·⁄ÀÊ— ⁄·Ï "
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        Me.Frame8.Location = New System.Drawing.Point(187, 595)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(600, 65)
        Me.Frame8.TabIndex = 25
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(354, 24)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(89, 33)
        Me.cmdSave.TabIndex = 30
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
        Me.cmdNew.Location = New System.Drawing.Point(460, 24)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(89, 33)
        Me.cmdNew.TabIndex = 29
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
        Me.cmdDelete.Location = New System.Drawing.Point(40, 24)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
        Me.cmdDelete.TabIndex = 28
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
        Me.cmdEdit.Location = New System.Drawing.Point(247, 24)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(89, 33)
        Me.cmdEdit.TabIndex = 27
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
        Me.cmdCancel.Location = New System.Drawing.Point(142, 24)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
        Me.cmdCancel.TabIndex = 26
        Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        Me.cmdCancel.Visible = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(187, 533)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(600, 65)
        Me.Frame7.TabIndex = 20
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(88, 24)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(89, 33)
        Me.cmdFirst.TabIndex = 24
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
        Me.cmdLast.Location = New System.Drawing.Point(408, 24)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(89, 33)
        Me.cmdLast.TabIndex = 23
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
        Me.cmdPrev.Location = New System.Drawing.Point(195, 24)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(89, 33)
        Me.cmdPrev.TabIndex = 22
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
        Me.cmdNext.Location = New System.Drawing.Point(302, 24)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(89, 33)
        Me.cmdNext.TabIndex = 21
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.txtData)
        Me.Frame1.Controls.Add(Me.nudMoney)
        Me.Frame1.Controls.Add(Me.nudAmount)
        Me.Frame1.Controls.Add(Me.DataGridView1)
        Me.Frame1.Controls.Add(Me.dtpDate)
        Me.Frame1.Controls.Add(Me.cmbCome)
        Me.Frame1.Controls.Add(Me.cmbSideName)
        Me.Frame1.Controls.Add(Me.txtID)
        Me.Frame1.Controls.Add(Me.txtReceiver)
        Me.Frame1.Controls.Add(Me.cmbStation)
        Me.Frame1.Controls.Add(Me.txtreceivee)
        Me.Frame1.Controls.Add(Me.cmbCertifier)
        Me.Frame1.Controls.Add(Me.txtMoneyText)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label5)
        Me.Frame1.Controls.Add(Me.Label2)
        Me.Frame1.Controls.Add(Me.Label9)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label11)
        Me.Frame1.Controls.Add(Me.Label10)
        Me.Frame1.Controls.Add(Me.Label14)
        Me.Frame1.Controls.Add(Me.Label17)
        Me.Frame1.Controls.Add(Me.Label16)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label7)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(187, 107)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(600, 426)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì«‰«  «·„” ‰œ  "
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(32, 149)
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(225, 20)
        Me.txtData.TabIndex = 57
        '
        'nudMoney
        '
        Me.nudMoney.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FINANCEBindingSource, "MONEYIN", True))
        Me.nudMoney.Location = New System.Drawing.Point(460, 54)
        Me.nudMoney.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudMoney.Name = "nudMoney"
        Me.nudMoney.Size = New System.Drawing.Size(77, 20)
        Me.nudMoney.TabIndex = 56
        '
        'FINANCEBindingSource
        '
        Me.FINANCEBindingSource.DataMember = "FINANCE"
        Me.FINANCEBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nudAmount
        '
        Me.nudAmount.Location = New System.Drawing.Point(325, 149)
        Me.nudAmount.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.nudAmount.Name = "nudAmount"
        Me.nudAmount.Size = New System.Drawing.Size(77, 20)
        Me.nudAmount.TabIndex = 56
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Amount, Me.Data})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 12.0!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Location = New System.Drawing.Point(32, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(409, 115)
        Me.DataGridView1.TabIndex = 55
        '
        'Amount
        '
        Me.Amount.HeaderText = "«·„»·€"
        Me.Amount.Name = "Amount"
        Me.Amount.ReadOnly = True
        '
        'Data
        '
        Me.Data.HeaderText = "«·»Ì«‰"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        '
        'dtpDate
        '
        Me.dtpDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FINANCEBindingSource, "FDATE", True))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(358, 400)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(186, 20)
        Me.dtpDate.TabIndex = 54
        '
        'cmbCome
        '
        Me.cmbCome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "COME", True))
        Me.cmbCome.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FINANCEBindingSource, "COME", True))
        Me.cmbCome.FormattingEnabled = True
        Me.cmbCome.Items.AddRange(New Object() {"„‰’—›", "Ê«—œ"})
        Me.cmbCome.Location = New System.Drawing.Point(476, 167)
        Me.cmbCome.Name = "cmbCome"
        Me.cmbCome.Size = New System.Drawing.Size(61, 21)
        Me.cmbCome.TabIndex = 53
        Me.cmbCome.Text = "Ê«—œ"
        '
        'cmbSideName
        '
        Me.cmbSideName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSideName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbSideName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "SIDENAME", True))
        Me.cmbSideName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSideName.Location = New System.Drawing.Point(80, 120)
        Me.cmbSideName.Name = "cmbSideName"
        Me.cmbSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSideName.Size = New System.Drawing.Size(353, 21)
        Me.cmbSideName.TabIndex = 52
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "ID", True))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(80, 24)
        Me.txtID.MaxLength = 0
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(361, 20)
        Me.txtID.TabIndex = 51
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtReceiver
        '
        Me.txtReceiver.AcceptsReturn = True
        Me.txtReceiver.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceiver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceiver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "RECEIVER", True))
        Me.txtReceiver.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceiver.Location = New System.Drawing.Point(16, 336)
        Me.txtReceiver.MaxLength = 0
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtReceiver.Size = New System.Drawing.Size(241, 20)
        Me.txtReceiver.TabIndex = 16
        Me.txtReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbStation
        '
        Me.cmbStation.BackColor = System.Drawing.SystemColors.Window
        Me.cmbStation.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbStation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "STATION", True))
        Me.cmbStation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbStation.Items.AddRange(New Object() {"«·ﬂœ—Ê"})
        Me.cmbStation.Location = New System.Drawing.Point(358, 368)
        Me.cmbStation.Name = "cmbStation"
        Me.cmbStation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbStation.Size = New System.Drawing.Size(185, 21)
        Me.cmbStation.TabIndex = 14
        Me.cmbStation.Text = "«·ﬂœ—Ê"
        '
        'txtreceivee
        '
        Me.txtreceivee.AcceptsReturn = True
        Me.txtreceivee.BackColor = System.Drawing.SystemColors.Window
        Me.txtreceivee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtreceivee.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "RECEIVEE", True))
        Me.txtreceivee.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtreceivee.Location = New System.Drawing.Point(302, 336)
        Me.txtreceivee.MaxLength = 0
        Me.txtreceivee.Name = "txtreceivee"
        Me.txtreceivee.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtreceivee.Size = New System.Drawing.Size(241, 20)
        Me.txtreceivee.TabIndex = 5
        Me.txtreceivee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCertifier
        '
        Me.cmbCertifier.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCertifier.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCertifier.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "CERTIFIER", True))
        Me.cmbCertifier.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCertifier.Location = New System.Drawing.Point(40, 88)
        Me.cmbCertifier.Name = "cmbCertifier"
        Me.cmbCertifier.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCertifier.Size = New System.Drawing.Size(497, 21)
        Me.cmbCertifier.TabIndex = 3
        '
        'txtMoneyText
        '
        Me.txtMoneyText.AcceptsReturn = True
        Me.txtMoneyText.BackColor = System.Drawing.SystemColors.Window
        Me.txtMoneyText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMoneyText.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "MONEYTEXT", True))
        Me.txtMoneyText.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMoneyText.Location = New System.Drawing.Point(16, 56)
        Me.txtMoneyText.MaxLength = 0
        Me.txtMoneyText.Name = "txtMoneyText"
        Me.txtMoneyText.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMoneyText.Size = New System.Drawing.Size(281, 20)
        Me.txtMoneyText.TabIndex = 2
        Me.txtMoneyText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(448, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "—ﬁ„ «·„” ‰œ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(544, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(41, 25)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "√‘Âœ √‰«"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(33, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ﬁœ"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(112, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(49, 25)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "«·„” ·„"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(550, 400)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(41, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "«· «—ÌŒ"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(550, 368)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label11.Size = New System.Drawing.Size(41, 25)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "«·„Õÿ…"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(408, 307)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(49, 25)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "«·„”·„"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(452, 201)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label14.Size = New System.Drawing.Size(145, 25)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = " ›«’Ì·Â ﬂ«·¬ Ì"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(259, 149)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(41, 25)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "«·»Ì«‰"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.SystemColors.Control
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(408, 149)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label16.Size = New System.Drawing.Size(41, 25)
        Me.Label16.TabIndex = 10
        Me.Label16.Text = "«·„»·€"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(544, 171)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(41, 25)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "⁄‹‹‹‹‰"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(57, 25)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "ÊÂÊ ⁄»«—…"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(304, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(33, 25)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "›ﬁÿ "
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(440, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(145, 25)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "«” ·„  «·„»·€ «·„Ê÷Õ √⁄·«Â „‰"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(544, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(41, 25)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "«·„»·€"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'FINANCETableAdapter
        '
        Me.FINANCETableAdapter.ClearBeforeFill = True
        '
        'StatesTableAdapter1
        '
        Me.StatesTableAdapter1.ClearBeforeFill = True
        '
        'FinanceDetailsTableAdapter
        '
        Me.FinanceDetailsTableAdapter.ClearBeforeFill = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbRank)
        Me.GroupBox1.Controls.Add(Me.cmbPosition)
        Me.GroupBox1.Controls.Add(Me.cmbName)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(787, 311)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(377, 126)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  ’«œ— »√„‹‹‹‹‹—  "
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FINANCEBindingSource, "Rank", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "Rank", True))
        Me.cmbRank.DataSource = Me.RankFINANCEBindingSource1
        Me.cmbRank.DisplayMember = "Rank"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(16, 21)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(269, 21)
        Me.cmbRank.TabIndex = 75
        Me.cmbRank.ValueMember = "Rank"
        '
        'RankFINANCEBindingSource1
        '
        Me.RankFINANCEBindingSource1.DataMember = "FINANCE"
        Me.RankFINANCEBindingSource1.DataSource = Me.RankDsExplosives1
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
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FINANCEBindingSource, "Position", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "Position", True))
        Me.cmbPosition.DataSource = Me.PositionFINANCEBindingSource3
        Me.cmbPosition.DisplayMember = "Position"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(16, 85)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(269, 21)
        Me.cmbPosition.TabIndex = 77
        Me.cmbPosition.ValueMember = "Position"
        '
        'PositionFINANCEBindingSource3
        '
        Me.PositionFINANCEBindingSource3.DataMember = "FINANCE"
        Me.PositionFINANCEBindingSource3.DataSource = Me.PositionDsExplosives3
        '
        'PositionDsExplosives3
        '
        Me.PositionDsExplosives3.DataSetName = "dsExplosives"
        Me.PositionDsExplosives3.EnforceConstraints = False
        Me.PositionDsExplosives3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FINANCEBindingSource, "Name", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FINANCEBindingSource, "Name", True))
        Me.cmbName.DataSource = Me.NameFINANCEBindingSource2
        Me.cmbName.DisplayMember = "Name"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(16, 53)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(269, 21)
        Me.cmbName.TabIndex = 76
        Me.cmbName.ValueMember = "Name"
        '
        'NameFINANCEBindingSource2
        '
        Me.NameFINANCEBindingSource2.DataMember = "FINANCE"
        Me.NameFINANCEBindingSource2.DataSource = Me.NameDsExplosives2
        '
        'NameDsExplosives2
        '
        Me.NameDsExplosives2.DataSetName = "dsExplosives"
        Me.NameDsExplosives2.EnforceConstraints = False
        Me.NameDsExplosives2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(306, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(31, 13)
        Me.Label18.TabIndex = 80
        Me.Label18.Text = "«·— »…"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(306, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(48, 13)
        Me.Label19.TabIndex = 79
        Me.Label19.Text = "«·«”‹‹‹‹„"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(302, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(55, 13)
        Me.Label20.TabIndex = 78
        Me.Label20.Text = "«·„‰‹‹’‹‹»"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1350, 734)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmFinance"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "«·„” ‰œ«  «·„«·Ì…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        Me.Frame8.ResumeLayout(False)
        Me.Frame7.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.nudMoney, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FINANCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RankFINANCEBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionFINANCEBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameFINANCEBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend cmbCome As System.Windows.Forms.ComboBox
    Friend dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents FINANCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FINANCETableAdapter As Explosives.dsExplosivesTableAdapters.FINANCETableAdapter
    Public WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Amount As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents nudAmount As System.Windows.Forms.NumericUpDown
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents StatesTableAdapter1 As Explosives.dsExplosivesTableAdapters.StatesTableAdapter
    Friend WithEvents FinanceDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.FinanceDetailsTableAdapter
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents nudMoney As System.Windows.Forms.NumericUpDown
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents RankFINANCEBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionFINANCEBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents NameFINANCEBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents NameDsExplosives2 As Explosives.dsExplosives
    Friend WithEvents PositionDsExplosives3 As Explosives.dsExplosives
#End Region
End Class