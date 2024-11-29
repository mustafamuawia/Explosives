<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmGetPass
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
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents txtDate2 As System.Windows.Forms.TextBox
	Public WithEvents txtDate1 As System.Windows.Forms.TextBox
	Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbBy As System.Windows.Forms.ComboBox
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdMain As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdInOut As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmbStoreAgent As System.Windows.Forms.ComboBox
	Public WithEvents cmbReceiver As System.Windows.Forms.ComboBox
	Public WithEvents txtDocID As System.Windows.Forms.TextBox
	Public WithEvents txtPID As System.Windows.Forms.TextBox
	Public WithEvents cmbSideName As System.Windows.Forms.ComboBox
	Public WithEvents txtCarID As System.Windows.Forms.TextBox
	Public WithEvents txtClasses As System.Windows.Forms.TextBox
	Public WithEvents txtID As System.Windows.Forms.TextBox
	Public WithEvents txtPermission As System.Windows.Forms.TextBox
	Public WithEvents txtDate As System.Windows.Forms.TextBox
	Public WithEvents txtStoreID As System.Windows.Forms.TextBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label24 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGetPass))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.cmdRefresh = New System.Windows.Forms.CheckBox
		Me.Frame2 = New System.Windows.Forms.GroupBox
		Me.txtDate2 = New System.Windows.Forms.TextBox
		Me.txtDate1 = New System.Windows.Forms.TextBox
		Me.cmdFindNext = New System.Windows.Forms.CheckBox
		Me.cmdFindPrev = New System.Windows.Forms.CheckBox
		Me.txtFind = New System.Windows.Forms.TextBox
		Me.cmbBy = New System.Windows.Forms.ComboBox
		Me.lblPosition = New System.Windows.Forms.Label
		Me.Label29 = New System.Windows.Forms.Label
		Me.Label28 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.cmdReturn = New System.Windows.Forms.CheckBox
		Me.cmdMain = New System.Windows.Forms.CheckBox
		Me.cmdFound = New System.Windows.Forms.CheckBox
		Me.cmdLogout = New System.Windows.Forms.CheckBox
		Me.cmdExit = New System.Windows.Forms.CheckBox
		Me.cmdPrintDoc = New System.Windows.Forms.CheckBox
		Me.cmdPrintAll = New System.Windows.Forms.CheckBox
		Me.cmdInOut = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmbStoreAgent = New System.Windows.Forms.ComboBox
		Me.cmbReceiver = New System.Windows.Forms.ComboBox
		Me.txtDocID = New System.Windows.Forms.TextBox
		Me.txtPID = New System.Windows.Forms.TextBox
		Me.cmbSideName = New System.Windows.Forms.ComboBox
		Me.txtCarID = New System.Windows.Forms.TextBox
		Me.txtClasses = New System.Windows.Forms.TextBox
		Me.txtID = New System.Windows.Forms.TextBox
		Me.txtPermission = New System.Windows.Forms.TextBox
		Me.txtDate = New System.Windows.Forms.TextBox
		Me.txtStoreID = New System.Windows.Forms.TextBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label24 = New System.Windows.Forms.Label
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.cmdNext = New System.Windows.Forms.CheckBox
		Me.cmdPrev = New System.Windows.Forms.CheckBox
		Me.cmdLast = New System.Windows.Forms.CheckBox
		Me.cmdFirst = New System.Windows.Forms.CheckBox
		Me.Frame8 = New System.Windows.Forms.GroupBox
		Me.cmdEdit = New System.Windows.Forms.CheckBox
		Me.cmdCancel = New System.Windows.Forms.CheckBox
		Me.cmdDelete = New System.Windows.Forms.CheckBox
		Me.cmdNew = New System.Windows.Forms.CheckBox
		Me.cmdSave = New System.Windows.Forms.CheckBox
		Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog
		Me.cmnDlgFont = New System.Windows.Forms.FontDialog
		Me.cmnDlgColor = New System.Windows.Forms.ColorDialog
		Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog
		Me.Frame2.SuspendLayout()
		Me.Frame9.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame7.SuspendLayout()
		Me.Frame8.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.ClientSize = New System.Drawing.Size(1228, 635)
		Me.Location = New System.Drawing.Point(4, 27)
		Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "frmGetPass"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRefresh.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
		Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
		Me.cmdRefresh.Location = New System.Drawing.Point(0, 0)
		Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdRefresh.TabIndex = 0
		Me.cmdRefresh.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdRefresh.CausesValidation = True
		Me.cmdRefresh.Enabled = True
		Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRefresh.TabStop = True
		Me.cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdRefresh.Visible = True
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.Frame2.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame2.Text = " «·‹‹‹‹»Õ‹‹‹‹‹À "
		Me.Frame2.Size = New System.Drawing.Size(377, 177)
		Me.Frame2.Location = New System.Drawing.Point(745, 72)
		Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame2.TabIndex = 48
		Me.Frame2.Enabled = True
		Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame2.Visible = True
		Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame2.Name = "Frame2"
		Me.txtDate2.AutoSize = False
		Me.txtDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDate2.Size = New System.Drawing.Size(121, 25)
		Me.txtDate2.Location = New System.Drawing.Point(16, 128)
		Me.txtDate2.MultiLine = True
		Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDate2.TabIndex = 49
		Me.txtDate2.AcceptsReturn = True
		Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
		Me.txtDate2.CausesValidation = True
		Me.txtDate2.Enabled = True
		Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDate2.HideSelection = True
		Me.txtDate2.ReadOnly = False
		Me.txtDate2.Maxlength = 0
		Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDate2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDate2.TabStop = True
		Me.txtDate2.Visible = True
		Me.txtDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate2.Name = "txtDate2"
		Me.txtDate1.AutoSize = False
		Me.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDate1.Size = New System.Drawing.Size(121, 25)
		Me.txtDate1.Location = New System.Drawing.Point(192, 128)
		Me.txtDate1.MultiLine = True
		Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDate1.TabIndex = 14
		Me.txtDate1.AcceptsReturn = True
		Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
		Me.txtDate1.CausesValidation = True
		Me.txtDate1.Enabled = True
		Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDate1.HideSelection = True
		Me.txtDate1.ReadOnly = False
		Me.txtDate1.Maxlength = 0
		Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDate1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDate1.TabStop = True
		Me.txtDate1.Visible = True
		Me.txtDate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate1.Name = "txtDate1"
		Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFindNext.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdFindNext.Text = "<"
		Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFindNext.Size = New System.Drawing.Size(33, 25)
		Me.cmdFindNext.Location = New System.Drawing.Point(320, 24)
		Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFindNext.TabIndex = 11
		Me.cmdFindNext.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFindNext.CausesValidation = True
		Me.cmdFindNext.Enabled = True
		Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFindNext.TabStop = True
		Me.cmdFindNext.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFindNext.Visible = True
		Me.cmdFindNext.Name = "cmdFindNext"
		Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFindPrev.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdFindPrev.Text = ">"
		Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFindPrev.Size = New System.Drawing.Size(33, 25)
		Me.cmdFindPrev.Location = New System.Drawing.Point(24, 24)
		Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFindPrev.TabIndex = 12
		Me.cmdFindPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFindPrev.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFindPrev.CausesValidation = True
		Me.cmdFindPrev.Enabled = True
		Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFindPrev.TabStop = True
		Me.cmdFindPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFindPrev.Visible = True
		Me.cmdFindPrev.Name = "cmdFindPrev"
		Me.txtFind.AutoSize = False
		Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtFind.Size = New System.Drawing.Size(249, 25)
		Me.txtFind.Location = New System.Drawing.Point(64, 24)
		Me.txtFind.MultiLine = True
		Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtFind.TabIndex = 10
		Me.txtFind.AcceptsReturn = True
		Me.txtFind.BackColor = System.Drawing.SystemColors.Window
		Me.txtFind.CausesValidation = True
		Me.txtFind.Enabled = True
		Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFind.HideSelection = True
		Me.txtFind.ReadOnly = False
		Me.txtFind.Maxlength = 0
		Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFind.TabStop = True
		Me.txtFind.Visible = True
		Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFind.Name = "txtFind"
		Me.cmbBy.Size = New System.Drawing.Size(297, 21)
		Me.cmbBy.Location = New System.Drawing.Point(16, 84)
		Me.cmbBy.Items.AddRange(New Object(){"«·ﬂ·", "—ﬁ„ «·„·›", "‰„—… „” ‰œ  ’—ÌÕ «·„—Ê—", "—ﬁ„ «·ﬁ”„", "’‰›", "√„Ì‰ «·„Œ«“‰", "‰„—… «·⁄—»…", " «—ÌŒ «·„·›", "«”„ «·„” ·„"})
		Me.cmbBy.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbBy.TabIndex = 13
		Me.cmbBy.BackColor = System.Drawing.SystemColors.Window
		Me.cmbBy.CausesValidation = True
		Me.cmbBy.Enabled = True
		Me.cmbBy.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbBy.IntegralHeight = True
		Me.cmbBy.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbBy.Sorted = False
		Me.cmbBy.TabStop = True
		Me.cmbBy.Visible = True
		Me.cmbBy.Name = "cmbBy"
		Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblPosition.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.lblPosition.Text = " „ «·⁄ÀÊ— ⁄·Ï "
		Me.lblPosition.Size = New System.Drawing.Size(345, 17)
		Me.lblPosition.Location = New System.Drawing.Point(16, 56)
		Me.lblPosition.TabIndex = 53
		Me.lblPosition.Enabled = True
		Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblPosition.UseMnemonic = True
		Me.lblPosition.Visible = True
		Me.lblPosition.AutoSize = False
		Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPosition.Name = "lblPosition"
		Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label29.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label29.Text = "≈·‹‹‹Ï"
		Me.Label29.Size = New System.Drawing.Size(33, 17)
		Me.Label29.Location = New System.Drawing.Point(144, 136)
		Me.Label29.TabIndex = 52
		Me.Label29.Enabled = True
		Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label29.UseMnemonic = True
		Me.Label29.Visible = True
		Me.Label29.AutoSize = False
		Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label29.Name = "Label29"
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label28.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label28.Text = "„‹‹‰"
		Me.Label28.Size = New System.Drawing.Size(33, 17)
		Me.Label28.Location = New System.Drawing.Point(320, 136)
		Me.Label28.TabIndex = 51
		Me.Label28.Enabled = True
		Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label28.UseMnemonic = True
		Me.Label28.Visible = True
		Me.Label28.AutoSize = False
		Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label28.Name = "Label28"
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label15.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label15.Text = "»‹Õ‹À »‹‹ "
		Me.Label15.Size = New System.Drawing.Size(43, 13)
		Me.Label15.Location = New System.Drawing.Point(317, 88)
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label15.TabIndex = 50
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = True
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Frame9.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame9.Text = "  ⁄„·Ì«   "
		Me.Frame9.Size = New System.Drawing.Size(377, 176)
		Me.Frame9.Location = New System.Drawing.Point(745, 249)
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame9.TabIndex = 47
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReturn.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdReturn.Text = "—Ã‹‹‹‹‹‹‹‹‹‹Ê⁄"
		Me.cmdReturn.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdReturn.Size = New System.Drawing.Size(361, 33)
		Me.cmdReturn.Location = New System.Drawing.Point(8, 96)
		Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdReturn.TabIndex = 19
		Me.cmdReturn.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdReturn.CausesValidation = True
		Me.cmdReturn.Enabled = True
		Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReturn.TabStop = True
		Me.cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdReturn.Visible = True
		Me.cmdReturn.Name = "cmdReturn"
		Me.cmdMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdMain.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdMain.Text = "«·’‹›‹‹Õ‹‹‹… «·—∆Ì‹”‹‹‹…"
		Me.cmdMain.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdMain.Size = New System.Drawing.Size(177, 33)
		Me.cmdMain.Location = New System.Drawing.Point(8, 96)
		Me.cmdMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdMain.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdMain.TabIndex = 54
		Me.cmdMain.Visible = False
		Me.cmdMain.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdMain.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdMain.CausesValidation = True
		Me.cmdMain.Enabled = True
		Me.cmdMain.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdMain.TabStop = True
		Me.cmdMain.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdMain.Name = "cmdMain"
		Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFound.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdFound.Text = "ÿ‹‹‹»‹«⁄‹… ‰‹ ‹ÌÃ‹… «·‹»‹‹Õ‹‹‹À"
		Me.cmdFound.Enabled = False
		Me.cmdFound.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFound.Size = New System.Drawing.Size(177, 33)
		Me.cmdFound.Location = New System.Drawing.Point(192, 56)
		Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFound.TabIndex = 17
		Me.cmdFound.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFound.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFound.CausesValidation = True
		Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFound.TabStop = True
		Me.cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFound.Visible = True
		Me.cmdFound.Name = "cmdFound"
		Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLogout.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdLogout.Text = " ”ÃÌ‹· Œ‹‹‹‹—ÊÃ"
		Me.cmdLogout.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLogout.Size = New System.Drawing.Size(177, 33)
		Me.cmdLogout.Location = New System.Drawing.Point(192, 136)
		Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLogout.TabIndex = 20
		Me.cmdLogout.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdLogout.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdLogout.CausesValidation = True
		Me.cmdLogout.Enabled = True
		Me.cmdLogout.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLogout.TabStop = True
		Me.cmdLogout.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdLogout.Visible = True
		Me.cmdLogout.Name = "cmdLogout"
		Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdExit.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
		Me.cmdExit.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdExit.Size = New System.Drawing.Size(177, 33)
		Me.cmdExit.Location = New System.Drawing.Point(8, 136)
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdExit.TabIndex = 21
		Me.cmdExit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.TabStop = True
		Me.cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdExit.Visible = True
		Me.cmdExit.Name = "cmdExit"
		Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrintDoc.Text = "ÿ‹‹‹»‹«⁄… «·„” ‰œ"
		Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrintDoc.Size = New System.Drawing.Size(177, 33)
		Me.cmdPrintDoc.Location = New System.Drawing.Point(192, 16)
		Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrintDoc.TabIndex = 15
		Me.cmdPrintDoc.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrintDoc.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrintDoc.CausesValidation = True
		Me.cmdPrintDoc.Enabled = True
		Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrintDoc.TabStop = True
		Me.cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrintDoc.Visible = True
		Me.cmdPrintDoc.Name = "cmdPrintDoc"
		Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrintAll.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrintAll.Text = "ÿ‹‹»‹‹«⁄… «·‹‹‹‹ﬂ‹‹‹·"
		Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrintAll.Size = New System.Drawing.Size(177, 33)
		Me.cmdPrintAll.Location = New System.Drawing.Point(8, 16)
		Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrintAll.TabIndex = 16
		Me.cmdPrintAll.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrintAll.CausesValidation = True
		Me.cmdPrintAll.Enabled = True
		Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrintAll.TabStop = True
		Me.cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrintAll.Visible = True
		Me.cmdPrintAll.Name = "cmdPrintAll"
		Me.cmdInOut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdInOut.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdInOut.Text = "ÿ»‹‹‹«⁄… Ê«—œ/„‰‹‹‹‹’—›"
		Me.cmdInOut.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdInOut.Size = New System.Drawing.Size(177, 33)
		Me.cmdInOut.Location = New System.Drawing.Point(8, 56)
		Me.cmdInOut.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdInOut.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdInOut.TabIndex = 18
		Me.cmdInOut.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdInOut.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdInOut.CausesValidation = True
		Me.cmdInOut.Enabled = True
		Me.cmdInOut.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdInOut.TabStop = True
		Me.cmdInOut.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdInOut.Visible = True
		Me.cmdInOut.Name = "cmdInOut"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame1.Text = "  »Ì«‰«  „·› «·≈–‰ "
		Me.Frame1.Size = New System.Drawing.Size(689, 353)
		Me.Frame1.Location = New System.Drawing.Point(56, 72)
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame1.TabIndex = 35
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmbStoreAgent.Size = New System.Drawing.Size(233, 21)
		Me.cmbStoreAgent.Location = New System.Drawing.Point(376, 272)
		Me.cmbStoreAgent.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbStoreAgent.TabIndex = 29
		Me.cmbStoreAgent.BackColor = System.Drawing.SystemColors.Window
		Me.cmbStoreAgent.CausesValidation = True
		Me.cmbStoreAgent.Enabled = True
		Me.cmbStoreAgent.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbStoreAgent.IntegralHeight = True
		Me.cmbStoreAgent.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbStoreAgent.Sorted = False
		Me.cmbStoreAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbStoreAgent.TabStop = True
		Me.cmbStoreAgent.Visible = True
		Me.cmbStoreAgent.Name = "cmbStoreAgent"
		Me.cmbReceiver.Size = New System.Drawing.Size(265, 21)
		Me.cmbReceiver.Location = New System.Drawing.Point(16, 304)
		Me.cmbReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbReceiver.TabIndex = 32
		Me.cmbReceiver.BackColor = System.Drawing.SystemColors.Window
		Me.cmbReceiver.CausesValidation = True
		Me.cmbReceiver.Enabled = True
		Me.cmbReceiver.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbReceiver.IntegralHeight = True
		Me.cmbReceiver.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbReceiver.Sorted = False
		Me.cmbReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbReceiver.TabStop = True
		Me.cmbReceiver.Visible = True
		Me.cmbReceiver.Name = "cmbReceiver"
		Me.txtDocID.AutoSize = False
		Me.txtDocID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDocID.Size = New System.Drawing.Size(217, 25)
		Me.txtDocID.Location = New System.Drawing.Point(16, 24)
		Me.txtDocID.MultiLine = True
		Me.txtDocID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDocID.TabIndex = 23
		Me.txtDocID.AcceptsReturn = True
		Me.txtDocID.BackColor = System.Drawing.SystemColors.Window
		Me.txtDocID.CausesValidation = True
		Me.txtDocID.Enabled = True
		Me.txtDocID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDocID.HideSelection = True
		Me.txtDocID.ReadOnly = False
		Me.txtDocID.Maxlength = 0
		Me.txtDocID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDocID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDocID.TabStop = True
		Me.txtDocID.Visible = True
		Me.txtDocID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDocID.Name = "txtDocID"
		Me.txtPID.AutoSize = False
		Me.txtPID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtPID.Size = New System.Drawing.Size(185, 25)
		Me.txtPID.Location = New System.Drawing.Point(360, 24)
		Me.txtPID.MultiLine = True
		Me.txtPID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtPID.TabIndex = 22
		Me.txtPID.AcceptsReturn = True
		Me.txtPID.BackColor = System.Drawing.SystemColors.Window
		Me.txtPID.CausesValidation = True
		Me.txtPID.Enabled = True
		Me.txtPID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPID.HideSelection = True
		Me.txtPID.ReadOnly = False
		Me.txtPID.Maxlength = 0
		Me.txtPID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPID.TabStop = True
		Me.txtPID.Visible = True
		Me.txtPID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPID.Name = "txtPID"
		Me.cmbSideName.Size = New System.Drawing.Size(601, 21)
		Me.cmbSideName.Location = New System.Drawing.Point(16, 128)
		Me.cmbSideName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbSideName.TabIndex = 27
		Me.cmbSideName.BackColor = System.Drawing.SystemColors.Window
		Me.cmbSideName.CausesValidation = True
		Me.cmbSideName.Enabled = True
		Me.cmbSideName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbSideName.IntegralHeight = True
		Me.cmbSideName.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbSideName.Sorted = False
		Me.cmbSideName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbSideName.TabStop = True
		Me.cmbSideName.Visible = True
		Me.cmbSideName.Name = "cmbSideName"
		Me.txtCarID.AutoSize = False
		Me.txtCarID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtCarID.Size = New System.Drawing.Size(265, 25)
		Me.txtCarID.Location = New System.Drawing.Point(16, 272)
		Me.txtCarID.MultiLine = True
		Me.txtCarID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtCarID.TabIndex = 30
		Me.txtCarID.AcceptsReturn = True
		Me.txtCarID.BackColor = System.Drawing.SystemColors.Window
		Me.txtCarID.CausesValidation = True
		Me.txtCarID.Enabled = True
		Me.txtCarID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtCarID.HideSelection = True
		Me.txtCarID.ReadOnly = False
		Me.txtCarID.Maxlength = 0
		Me.txtCarID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCarID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtCarID.TabStop = True
		Me.txtCarID.Visible = True
		Me.txtCarID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtCarID.Name = "txtCarID"
		Me.txtClasses.AutoSize = False
		Me.txtClasses.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtClasses.Size = New System.Drawing.Size(609, 81)
		Me.txtClasses.Location = New System.Drawing.Point(16, 184)
		Me.txtClasses.MultiLine = True
		Me.txtClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtClasses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
		Me.txtClasses.TabIndex = 28
		Me.txtClasses.Text = "Text2"
		Me.txtClasses.AcceptsReturn = True
		Me.txtClasses.BackColor = System.Drawing.SystemColors.Window
		Me.txtClasses.CausesValidation = True
		Me.txtClasses.Enabled = True
		Me.txtClasses.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtClasses.HideSelection = True
		Me.txtClasses.ReadOnly = False
		Me.txtClasses.Maxlength = 0
		Me.txtClasses.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtClasses.TabStop = True
		Me.txtClasses.Visible = True
		Me.txtClasses.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtClasses.Name = "txtClasses"
		Me.txtID.AutoSize = False
		Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtID.Size = New System.Drawing.Size(169, 25)
		Me.txtID.Location = New System.Drawing.Point(448, 56)
		Me.txtID.MultiLine = True
		Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtID.TabIndex = 24
		Me.txtID.AcceptsReturn = True
		Me.txtID.BackColor = System.Drawing.SystemColors.Window
		Me.txtID.CausesValidation = True
		Me.txtID.Enabled = True
		Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtID.HideSelection = True
		Me.txtID.ReadOnly = False
		Me.txtID.Maxlength = 0
		Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtID.TabStop = True
		Me.txtID.Visible = True
		Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtID.Name = "txtID"
		Me.txtPermission.AutoSize = False
		Me.txtPermission.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtPermission.Size = New System.Drawing.Size(425, 25)
		Me.txtPermission.Location = New System.Drawing.Point(192, 88)
		Me.txtPermission.MultiLine = True
		Me.txtPermission.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtPermission.TabIndex = 26
		Me.txtPermission.AcceptsReturn = True
		Me.txtPermission.BackColor = System.Drawing.SystemColors.Window
		Me.txtPermission.CausesValidation = True
		Me.txtPermission.Enabled = True
		Me.txtPermission.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPermission.HideSelection = True
		Me.txtPermission.ReadOnly = False
		Me.txtPermission.Maxlength = 0
		Me.txtPermission.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPermission.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPermission.TabStop = True
		Me.txtPermission.Visible = True
		Me.txtPermission.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPermission.Name = "txtPermission"
		Me.txtDate.AutoSize = False
		Me.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDate.Size = New System.Drawing.Size(233, 25)
		Me.txtDate.Location = New System.Drawing.Point(376, 304)
		Me.txtDate.MultiLine = True
		Me.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDate.TabIndex = 31
		Me.txtDate.AcceptsReturn = True
		Me.txtDate.BackColor = System.Drawing.SystemColors.Window
		Me.txtDate.CausesValidation = True
		Me.txtDate.Enabled = True
		Me.txtDate.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDate.HideSelection = True
		Me.txtDate.ReadOnly = False
		Me.txtDate.Maxlength = 0
		Me.txtDate.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDate.TabStop = True
		Me.txtDate.Visible = True
		Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate.Name = "txtDate"
		Me.txtStoreID.AutoSize = False
		Me.txtStoreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtStoreID.Size = New System.Drawing.Size(345, 25)
		Me.txtStoreID.Location = New System.Drawing.Point(16, 56)
		Me.txtStoreID.MultiLine = True
		Me.txtStoreID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtStoreID.TabIndex = 25
		Me.txtStoreID.AcceptsReturn = True
		Me.txtStoreID.BackColor = System.Drawing.SystemColors.Window
		Me.txtStoreID.CausesValidation = True
		Me.txtStoreID.Enabled = True
		Me.txtStoreID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtStoreID.HideSelection = True
		Me.txtStoreID.ReadOnly = False
		Me.txtStoreID.Maxlength = 0
		Me.txtStoreID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStoreID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStoreID.TabStop = True
		Me.txtStoreID.Visible = True
		Me.txtStoreID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStoreID.Name = "txtStoreID"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label9.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label9.Text = "‰„—… „” ‰œ «·’—›"
		Me.Label9.Size = New System.Drawing.Size(89, 17)
		Me.Label9.Location = New System.Drawing.Point(240, 32)
		Me.Label9.TabIndex = 46
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label7.Text = "‰„—… „” ‰œ  ’—ÌÕ «·„—Ê—"
		Me.Label7.Size = New System.Drawing.Size(113, 17)
		Me.Label7.Location = New System.Drawing.Point(552, 32)
		Me.Label7.TabIndex = 45
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label8.Text = "«”„ «·„” ·„"
		Me.Label8.Size = New System.Drawing.Size(65, 17)
		Me.Label8.Location = New System.Drawing.Point(280, 304)
		Me.Label8.TabIndex = 44
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label6.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label6.Text = "‰„—… «·⁄—»…"
		Me.Label6.Size = New System.Drawing.Size(57, 25)
		Me.Label6.Location = New System.Drawing.Point(284, 272)
		Me.Label6.TabIndex = 43
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label5.Text = ": «·√’‰«› «·„”„ÊÕ ·Â« »«·„—Ê—"
		Me.Label5.Size = New System.Drawing.Size(153, 17)
		Me.Label5.Location = New System.Drawing.Point(520, 160)
		Me.Label5.TabIndex = 42
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label2.Text = "—ﬁ„ «·„·›"
		Me.Label2.Size = New System.Drawing.Size(49, 25)
		Me.Label2.Location = New System.Drawing.Point(624, 56)
		Me.Label2.TabIndex = 41
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label4.Text = " ’—ÌÕ"
		Me.Label4.Size = New System.Drawing.Size(65, 25)
		Me.Label4.Location = New System.Drawing.Point(616, 88)
		Me.Label4.TabIndex = 40
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label3.Text = "«· «—ÌŒ"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(624, 304)
		Me.Label3.TabIndex = 39
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label1.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label1.Text = "„‰ ( «”„ «·ÊÕœ… «·„‰’—› ·Â« «·√’‰«› )"
		Me.Label1.Size = New System.Drawing.Size(185, 17)
		Me.Label1.Location = New System.Drawing.Point(16, 96)
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label1.TabIndex = 38
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label16.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label16.Text = "√„Ì‰ «·„Œ«“‰"
		Me.Label16.Size = New System.Drawing.Size(65, 17)
		Me.Label16.Location = New System.Drawing.Point(616, 272)
		Me.Label16.TabIndex = 37
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label24.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label24.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label24.Text = "ﬁ”„ ‰„—…"
		Me.Label24.Size = New System.Drawing.Size(57, 25)
		Me.Label24.Location = New System.Drawing.Point(368, 56)
		Me.Label24.TabIndex = 36
		Me.Label24.Enabled = True
		Me.Label24.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label24.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label24.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label24.UseMnemonic = True
		Me.Label24.Visible = True
		Me.Label24.AutoSize = False
		Me.Label24.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label24.Name = "Label24"
		Me.Frame7.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
		Me.Frame7.Size = New System.Drawing.Size(689, 73)
		Me.Frame7.Location = New System.Drawing.Point(56, 498)
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame7.TabIndex = 34
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.Visible = True
		Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame7.Name = "Frame7"
		Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNext.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdNext.Text = "< «· ‹‹«·Ì"
		Me.cmdNext.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdNext.Size = New System.Drawing.Size(89, 33)
		Me.cmdNext.Location = New System.Drawing.Point(312, 24)
		Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNext.TabIndex = 1
		Me.cmdNext.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdNext.CausesValidation = True
		Me.cmdNext.Enabled = True
		Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNext.TabStop = True
		Me.cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdNext.Visible = True
		Me.cmdNext.Name = "cmdNext"
		Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrev.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrev.Text = "«·”‹‹‹«»ﬁ >"
		Me.cmdPrev.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrev.Size = New System.Drawing.Size(89, 33)
		Me.cmdPrev.Location = New System.Drawing.Point(216, 24)
		Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrev.TabIndex = 2
		Me.cmdPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrev.CausesValidation = True
		Me.cmdPrev.Enabled = True
		Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrev.TabStop = True
		Me.cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrev.Visible = True
		Me.cmdPrev.Name = "cmdPrev"
		Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdLast.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdLast.Text = "<< «·√ŒÌ—"
		Me.cmdLast.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLast.Size = New System.Drawing.Size(89, 33)
		Me.cmdLast.Location = New System.Drawing.Point(408, 24)
		Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLast.TabIndex = 3
		Me.cmdLast.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdLast.CausesValidation = True
		Me.cmdLast.Enabled = True
		Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdLast.TabStop = True
		Me.cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdLast.Visible = True
		Me.cmdLast.Name = "cmdLast"
		Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFirst.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdFirst.Text = ">> «·√Ê·"
		Me.cmdFirst.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFirst.Size = New System.Drawing.Size(89, 33)
		Me.cmdFirst.Location = New System.Drawing.Point(120, 24)
		Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFirst.TabIndex = 4
		Me.cmdFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFirst.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFirst.CausesValidation = True
		Me.cmdFirst.Enabled = True
		Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFirst.TabStop = True
		Me.cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFirst.Visible = True
		Me.cmdFirst.Name = "cmdFirst"
		Me.Frame8.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame8.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
		Me.Frame8.Size = New System.Drawing.Size(689, 73)
		Me.Frame8.Location = New System.Drawing.Point(56, 425)
		Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame8.TabIndex = 33
		Me.Frame8.Enabled = True
		Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame8.Visible = True
		Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame8.Name = "Frame8"
		Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEdit.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdEdit.Text = " ‹⁄‹œÌ‹·"
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdEdit.Size = New System.Drawing.Size(89, 33)
		Me.cmdEdit.Location = New System.Drawing.Point(216, 24)
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdEdit.TabIndex = 7
		Me.cmdEdit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdEdit.CausesValidation = True
		Me.cmdEdit.Enabled = True
		Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEdit.TabStop = True
		Me.cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdEdit.Visible = True
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(120, 24)
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdCancel.TabIndex = 8
		Me.cmdCancel.Visible = False
		Me.cmdCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelete.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdDelete.Text = "Õ‹‹–›"
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
		Me.cmdDelete.Location = New System.Drawing.Point(120, 24)
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdDelete.TabIndex = 9
		Me.cmdDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Enabled = True
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdDelete.Visible = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.cmdNew.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdNew.Text = "Ã‹‹œÌ‹‹œ"
		Me.cmdNew.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdNew.Size = New System.Drawing.Size(89, 33)
		Me.cmdNew.Location = New System.Drawing.Point(408, 24)
		Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNew.TabIndex = 5
		Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdNew.CausesValidation = True
		Me.cmdNew.Enabled = True
		Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNew.TabStop = True
		Me.cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdNew.Visible = True
		Me.cmdNew.Name = "cmdNew"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
		Me.cmdSave.Enabled = False
		Me.cmdSave.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdSave.Size = New System.Drawing.Size(89, 33)
		Me.cmdSave.Location = New System.Drawing.Point(312, 24)
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdSave.TabIndex = 6
		Me.cmdSave.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.TabStop = True
		Me.cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdSave.Visible = True
		Me.cmdSave.Name = "cmdSave"
		Me.Controls.Add(cmdRefresh)
		Me.Controls.Add(Frame2)
		Me.Controls.Add(Frame9)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame7)
		Me.Controls.Add(Frame8)
		Me.Frame2.Controls.Add(txtDate2)
		Me.Frame2.Controls.Add(txtDate1)
		Me.Frame2.Controls.Add(cmdFindNext)
		Me.Frame2.Controls.Add(cmdFindPrev)
		Me.Frame2.Controls.Add(txtFind)
		Me.Frame2.Controls.Add(cmbBy)
		Me.Frame2.Controls.Add(lblPosition)
		Me.Frame2.Controls.Add(Label29)
		Me.Frame2.Controls.Add(Label28)
		Me.Frame2.Controls.Add(Label15)
		Me.Frame9.Controls.Add(cmdReturn)
		Me.Frame9.Controls.Add(cmdMain)
		Me.Frame9.Controls.Add(cmdFound)
		Me.Frame9.Controls.Add(cmdLogout)
		Me.Frame9.Controls.Add(cmdExit)
		Me.Frame9.Controls.Add(cmdPrintDoc)
		Me.Frame9.Controls.Add(cmdPrintAll)
		Me.Frame9.Controls.Add(cmdInOut)
		Me.Frame1.Controls.Add(cmbStoreAgent)
		Me.Frame1.Controls.Add(cmbReceiver)
		Me.Frame1.Controls.Add(txtDocID)
		Me.Frame1.Controls.Add(txtPID)
		Me.Frame1.Controls.Add(cmbSideName)
		Me.Frame1.Controls.Add(txtCarID)
		Me.Frame1.Controls.Add(txtClasses)
		Me.Frame1.Controls.Add(txtID)
		Me.Frame1.Controls.Add(txtPermission)
		Me.Frame1.Controls.Add(txtDate)
		Me.Frame1.Controls.Add(txtStoreID)
		Me.Frame1.Controls.Add(Label9)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label4)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame1.Controls.Add(Label16)
		Me.Frame1.Controls.Add(Label24)
		Me.Frame7.Controls.Add(cmdNext)
		Me.Frame7.Controls.Add(cmdPrev)
		Me.Frame7.Controls.Add(cmdLast)
		Me.Frame7.Controls.Add(cmdFirst)
		Me.Frame8.Controls.Add(cmdEdit)
		Me.Frame8.Controls.Add(cmdCancel)
		Me.Frame8.Controls.Add(cmdDelete)
		Me.Frame8.Controls.Add(cmdNew)
		Me.Frame8.Controls.Add(cmdSave)
		Me.Frame2.ResumeLayout(False)
		Me.Frame9.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame7.ResumeLayout(False)
		Me.Frame8.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class