<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmUsers
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
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents cmbType As System.Windows.Forms.ComboBox
	Public WithEvents cmbUnit As System.Windows.Forms.ComboBox
	Public WithEvents cmbRank As System.Windows.Forms.ComboBox
	Public WithEvents txtPassword As System.Windows.Forms.TextBox
	Public WithEvents txtUserName As System.Windows.Forms.TextBox
	Public WithEvents txtName As System.Windows.Forms.TextBox
	Public WithEvents txtID As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents _Label4_0 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents _Label4_1 As System.Windows.Forms.Label
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
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
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUsers))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.cmdReturn = New System.Windows.Forms.CheckBox
		Me.cmdLogout = New System.Windows.Forms.CheckBox
		Me.cmdExit = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.cmbType = New System.Windows.Forms.ComboBox
		Me.cmbUnit = New System.Windows.Forms.ComboBox
		Me.cmbRank = New System.Windows.Forms.ComboBox
		Me.txtPassword = New System.Windows.Forms.TextBox
		Me.txtUserName = New System.Windows.Forms.TextBox
		Me.txtName = New System.Windows.Forms.TextBox
		Me.txtID = New System.Windows.Forms.TextBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me._Label4_0 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame3 = New System.Windows.Forms.GroupBox
		Me.txtFind = New System.Windows.Forms.TextBox
		Me.cmbCriteria = New System.Windows.Forms.ComboBox
		Me.Label5 = New System.Windows.Forms.Label
		Me._Label4_1 = New System.Windows.Forms.Label
		Me.lblPosition = New System.Windows.Forms.Label
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.cmdEdit = New System.Windows.Forms.CheckBox
		Me.cmdSave = New System.Windows.Forms.CheckBox
		Me.cmdNew = New System.Windows.Forms.CheckBox
		Me.cmdDelete = New System.Windows.Forms.CheckBox
		Me.cmdCancel = New System.Windows.Forms.CheckBox
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.cmdNext = New System.Windows.Forms.CheckBox
		Me.cmdLast = New System.Windows.Forms.CheckBox
		Me.cmdFirst = New System.Windows.Forms.CheckBox
		Me.cmdPrev = New System.Windows.Forms.CheckBox
		Me.cmdRefresh = New System.Windows.Forms.CheckBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog
		Me.cmnDlgFont = New System.Windows.Forms.FontDialog
		Me.cmnDlgColor = New System.Windows.Forms.ColorDialog
		Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog
        'Me.Label4 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Frame9.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame3.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame7.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
        'CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(1350, 730)
		Me.Location = New System.Drawing.Point(15, 37)
		Me.Icon = CType(resources.GetObject("frmUsers.Icon"), System.Drawing.Icon)
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
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.Name = "frmUsers"
		Me.Frame9.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame9.Text = "   »Ì«‰«  «·„›—ﬁ⁄«    "
		Me.Frame9.Size = New System.Drawing.Size(545, 83)
		Me.Frame9.Location = New System.Drawing.Point(400, 80)
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame9.TabIndex = 36
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReturn.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
		Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdReturn.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
		Me.cmdReturn.Location = New System.Drawing.Point(370, 24)
		Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdReturn.TabIndex = 18
		Me.cmdReturn.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdReturn.CausesValidation = True
		Me.cmdReturn.Enabled = True
		Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReturn.TabStop = True
		Me.cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdReturn.Visible = True
		Me.cmdReturn.Name = "cmdReturn"
		Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLogout.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
		Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdLogout.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLogout.Size = New System.Drawing.Size(145, 41)
		Me.cmdLogout.Location = New System.Drawing.Point(196, 24)
		Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLogout.TabIndex = 19
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
		Me.cmdExit.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdExit.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdExit.Size = New System.Drawing.Size(129, 41)
		Me.cmdExit.Location = New System.Drawing.Point(38, 24)
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdExit.TabIndex = 20
		Me.cmdExit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.TabStop = True
		Me.cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdExit.Visible = True
		Me.cmdExit.Name = "cmdExit"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame1.Text = "  »Ì«‰«  «·„” Œœ„  "
		Me.Frame1.Size = New System.Drawing.Size(545, 225)
		Me.Frame1.Location = New System.Drawing.Point(400, 163)
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame1.TabIndex = 26
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.cmbType.Size = New System.Drawing.Size(169, 21)
		Me.cmbType.Location = New System.Drawing.Point(288, 192)
		Me.cmbType.Items.AddRange(New Object(){"„‘—›", "⁄«œÌ"})
		Me.cmbType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbType.TabIndex = 15
		Me.cmbType.BackColor = System.Drawing.SystemColors.Window
		Me.cmbType.CausesValidation = True
		Me.cmbType.Enabled = True
		Me.cmbType.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbType.IntegralHeight = True
		Me.cmbType.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbType.Sorted = False
		Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbType.TabStop = True
		Me.cmbType.Visible = True
		Me.cmbType.Name = "cmbType"
		Me.cmbUnit.Size = New System.Drawing.Size(169, 21)
		Me.cmbUnit.Location = New System.Drawing.Point(288, 96)
		Me.cmbUnit.Items.AddRange(New Object(){"«·—∆«”…", "ﬂ Ì»… «·≈œ«—… Ê«·Œœ„« ", "„⁄Âœ «·√”·Õ… Ê«·–Œ«∆—", "«·Ê—‘ «·›‰Ì…"})
		Me.cmbUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbUnit.TabIndex = 12
		Me.cmbUnit.BackColor = System.Drawing.SystemColors.Window
		Me.cmbUnit.CausesValidation = True
		Me.cmbUnit.Enabled = True
		Me.cmbUnit.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbUnit.IntegralHeight = True
		Me.cmbUnit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbUnit.Sorted = False
		Me.cmbUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbUnit.TabStop = True
		Me.cmbUnit.Visible = True
		Me.cmbUnit.Name = "cmbUnit"
		Me.cmbRank.Size = New System.Drawing.Size(169, 21)
		Me.cmbRank.Location = New System.Drawing.Point(16, 32)
		Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbRank.TabIndex = 10
		Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
		Me.cmbRank.CausesValidation = True
		Me.cmbRank.Enabled = True
		Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbRank.IntegralHeight = True
		Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbRank.Sorted = False
		Me.cmbRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbRank.TabStop = True
		Me.cmbRank.Visible = True
		Me.cmbRank.Name = "cmbRank"
		Me.txtPassword.AutoSize = False
		Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtPassword.Size = New System.Drawing.Size(273, 25)
		Me.txtPassword.Location = New System.Drawing.Point(184, 160)
		Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtPassword.TabIndex = 14
		Me.txtPassword.AcceptsReturn = True
		Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
		Me.txtPassword.CausesValidation = True
		Me.txtPassword.Enabled = True
		Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtPassword.HideSelection = True
		Me.txtPassword.ReadOnly = False
		Me.txtPassword.Maxlength = 0
		Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtPassword.MultiLine = False
		Me.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtPassword.TabStop = True
		Me.txtPassword.Visible = True
		Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtPassword.Name = "txtPassword"
		Me.txtUserName.AutoSize = False
		Me.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtUserName.Size = New System.Drawing.Size(273, 25)
		Me.txtUserName.Location = New System.Drawing.Point(184, 128)
		Me.txtUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtUserName.TabIndex = 13
		Me.txtUserName.AcceptsReturn = True
		Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
		Me.txtUserName.CausesValidation = True
		Me.txtUserName.Enabled = True
		Me.txtUserName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtUserName.HideSelection = True
		Me.txtUserName.ReadOnly = False
		Me.txtUserName.Maxlength = 0
		Me.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtUserName.MultiLine = False
		Me.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtUserName.TabStop = True
		Me.txtUserName.Visible = True
		Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtUserName.Name = "txtUserName"
		Me.txtName.AutoSize = False
		Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtName.Size = New System.Drawing.Size(441, 25)
		Me.txtName.Location = New System.Drawing.Point(16, 64)
		Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtName.TabIndex = 11
		Me.txtName.AcceptsReturn = True
		Me.txtName.BackColor = System.Drawing.SystemColors.Window
		Me.txtName.CausesValidation = True
		Me.txtName.Enabled = True
		Me.txtName.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtName.HideSelection = True
		Me.txtName.ReadOnly = False
		Me.txtName.Maxlength = 0
		Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtName.MultiLine = False
		Me.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtName.TabStop = True
		Me.txtName.Visible = True
		Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtName.Name = "txtName"
		Me.txtID.AutoSize = False
		Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtID.Size = New System.Drawing.Size(169, 25)
		Me.txtID.Location = New System.Drawing.Point(288, 32)
		Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtID.TabIndex = 9
		Me.txtID.AcceptsReturn = True
		Me.txtID.BackColor = System.Drawing.SystemColors.Window
		Me.txtID.CausesValidation = True
		Me.txtID.Enabled = True
		Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtID.HideSelection = True
		Me.txtID.ReadOnly = False
		Me.txtID.Maxlength = 0
		Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtID.MultiLine = False
		Me.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtID.TabStop = True
		Me.txtID.Visible = True
		Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtID.Name = "txtID"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Text = "‰Ê⁄ «·„” Œœ„"
		Me.Label6.Size = New System.Drawing.Size(73, 25)
		Me.Label6.Location = New System.Drawing.Point(464, 200)
		Me.Label6.TabIndex = 35
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Text = "«·— »…"
		Me.Label2.Size = New System.Drawing.Size(73, 17)
		Me.Label2.Location = New System.Drawing.Point(176, 34)
		Me.Label2.TabIndex = 32
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Text = "«·ÊÕœ…"
		Me.Label8.Size = New System.Drawing.Size(73, 25)
		Me.Label8.Location = New System.Drawing.Point(464, 104)
		Me.Label8.TabIndex = 31
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Text = "ﬂ·„… «·”—"
		Me.Label7.Size = New System.Drawing.Size(73, 25)
		Me.Label7.Location = New System.Drawing.Point(464, 168)
		Me.Label7.TabIndex = 30
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me._Label4_0.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label4_0.BackColor = System.Drawing.Color.Transparent
		Me._Label4_0.Text = "«”„ «·„” Œœ„"
		Me._Label4_0.Size = New System.Drawing.Size(73, 25)
		Me._Label4_0.Location = New System.Drawing.Point(464, 136)
		Me._Label4_0.TabIndex = 29
		Me._Label4_0.Enabled = True
		Me._Label4_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label4_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label4_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label4_0.UseMnemonic = True
		Me._Label4_0.Visible = True
		Me._Label4_0.AutoSize = False
		Me._Label4_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label4_0.Name = "_Label4_0"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Text = "«·«”„"
		Me.Label3.Size = New System.Drawing.Size(73, 25)
		Me.Label3.Location = New System.Drawing.Point(464, 72)
		Me.Label3.TabIndex = 28
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Text = "‰„—… «·»ÿ«ﬁ…"
		Me.Label1.Size = New System.Drawing.Size(73, 25)
		Me.Label1.Location = New System.Drawing.Point(464, 40)
		Me.Label1.TabIndex = 27
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame3.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame3.Text = " «·»ÕÀ ⁄‰ „” Œœ„  "
		Me.Frame3.Size = New System.Drawing.Size(545, 97)
		Me.Frame3.Location = New System.Drawing.Point(402, 388)
		Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame3.TabIndex = 24
		Me.Frame3.Enabled = True
		Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame3.Visible = True
		Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame3.Name = "Frame3"
		Me.txtFind.AutoSize = False
		Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtFind.Size = New System.Drawing.Size(265, 27)
		Me.txtFind.Location = New System.Drawing.Point(184, 56)
		Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtFind.TabIndex = 17
		Me.txtFind.AcceptsReturn = True
		Me.txtFind.BackColor = System.Drawing.SystemColors.Window
		Me.txtFind.CausesValidation = True
		Me.txtFind.Enabled = True
		Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtFind.HideSelection = True
		Me.txtFind.ReadOnly = False
		Me.txtFind.Maxlength = 0
		Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtFind.MultiLine = False
		Me.txtFind.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtFind.TabStop = True
		Me.txtFind.Visible = True
		Me.txtFind.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtFind.Name = "txtFind"
		Me.cmbCriteria.Size = New System.Drawing.Size(137, 21)
		Me.cmbCriteria.Location = New System.Drawing.Point(312, 24)
		Me.cmbCriteria.Items.AddRange(New Object(){"⁄«„", "‰„—… «·»ÿ«ﬁ…", "«·«”„", "«·— »…", "«·ÊÕœ…", "«”„ «·„” Œœ„", "ﬂ·„… «·”—", "‰Ê⁄ «·„” Œœ„"})
		Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbCriteria.TabIndex = 16
		Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
		Me.cmbCriteria.CausesValidation = True
		Me.cmbCriteria.Enabled = True
		Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbCriteria.IntegralHeight = True
		Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbCriteria.Sorted = False
		Me.cmbCriteria.TabStop = True
		Me.cmbCriteria.Visible = True
		Me.cmbCriteria.Name = "cmbCriteria"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Text = "‰’ «·»ÕÀ"
		Me.Label5.Size = New System.Drawing.Size(73, 25)
		Me.Label5.Location = New System.Drawing.Point(448, 64)
		Me.Label5.TabIndex = 34
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me._Label4_1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me._Label4_1.BackColor = System.Drawing.Color.Transparent
		Me._Label4_1.Text = "Œ«’Ì… «·»ÕÀ"
		Me._Label4_1.Size = New System.Drawing.Size(73, 25)
		Me._Label4_1.Location = New System.Drawing.Point(448, 32)
		Me._Label4_1.TabIndex = 33
		Me._Label4_1.Enabled = True
		Me._Label4_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label4_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label4_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label4_1.UseMnemonic = True
		Me._Label4_1.Visible = True
		Me._Label4_1.AutoSize = False
		Me._Label4_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label4_1.Name = "_Label4_1"
		Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblPosition.Text = "********"
		Me.lblPosition.Size = New System.Drawing.Size(169, 25)
		Me.lblPosition.Location = New System.Drawing.Point(8, 56)
		Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lblPosition.TabIndex = 25
		Me.lblPosition.BackColor = System.Drawing.Color.Transparent
		Me.lblPosition.Enabled = True
		Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPosition.UseMnemonic = True
		Me.lblPosition.Visible = True
		Me.lblPosition.AutoSize = False
		Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPosition.Name = "lblPosition"
		Me.Frame6.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame6.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
		Me.Frame6.Size = New System.Drawing.Size(545, 57)
		Me.Frame6.Location = New System.Drawing.Point(402, 542)
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame6.TabIndex = 23
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEdit.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdEdit.Text = " ‹‹‹⁄‹‹‹œÌ·"
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
		Me.cmdEdit.Location = New System.Drawing.Point(181, 16)
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdEdit.TabIndex = 6
		Me.cmdEdit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdEdit.CausesValidation = True
		Me.cmdEdit.Enabled = True
		Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEdit.TabStop = True
		Me.cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdEdit.Visible = True
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSave.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdSave.Text = "Õ‹‹‹›‹‹‹Ÿ"
		Me.cmdSave.Enabled = False
		Me.cmdSave.ForeColor = System.Drawing.Color.White
		Me.cmdSave.Size = New System.Drawing.Size(81, 33)
		Me.cmdSave.Location = New System.Drawing.Point(283, 16)
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdSave.TabIndex = 5
		Me.cmdSave.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.TabStop = True
		Me.cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdSave.Visible = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNew.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdNew.Text = "Ã‹‹œÌ‹‹‹œ"
		Me.cmdNew.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdNew.Size = New System.Drawing.Size(81, 33)
		Me.cmdNew.Location = New System.Drawing.Point(384, 16)
		Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNew.TabIndex = 4
		Me.cmdNew.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdNew.CausesValidation = True
		Me.cmdNew.Enabled = True
		Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNew.TabStop = True
		Me.cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdNew.Visible = True
		Me.cmdNew.Name = "cmdNew"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelete.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdDelete.Text = "Õ‹‹‹‹‹–›"
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
		Me.cmdDelete.Location = New System.Drawing.Point(80, 16)
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdDelete.TabIndex = 7
		Me.cmdDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Enabled = True
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdDelete.Visible = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹«¡"
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(80, 16)
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
		Me.Frame7.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
		Me.Frame7.Size = New System.Drawing.Size(545, 57)
		Me.Frame7.Location = New System.Drawing.Point(402, 485)
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame7.TabIndex = 22
		Me.Frame7.Enabled = True
		Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame7.Visible = True
		Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame7.Name = "Frame7"
		Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNext.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdNext.Text = "< «· ‹‹‹‹«·Ì"
		Me.cmdNext.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdNext.Size = New System.Drawing.Size(81, 33)
		Me.cmdNext.Location = New System.Drawing.Point(283, 16)
		Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNext.TabIndex = 0
		Me.cmdNext.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdNext.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdNext.CausesValidation = True
		Me.cmdNext.Enabled = True
		Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdNext.TabStop = True
		Me.cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdNext.Visible = True
		Me.cmdNext.Name = "cmdNext"
		Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLast.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdLast.Text = "<< «·√ŒÌ‹‹‹—"
		Me.cmdLast.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLast.Size = New System.Drawing.Size(81, 33)
		Me.cmdLast.Location = New System.Drawing.Point(384, 16)
		Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLast.TabIndex = 2
		Me.cmdLast.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
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
		Me.cmdFirst.Text = "«·√Ê· >>"
		Me.cmdFirst.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
		Me.cmdFirst.Location = New System.Drawing.Point(80, 16)
		Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFirst.TabIndex = 3
		Me.cmdFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFirst.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFirst.CausesValidation = True
		Me.cmdFirst.Enabled = True
		Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFirst.TabStop = True
		Me.cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFirst.Visible = True
		Me.cmdFirst.Name = "cmdFirst"
		Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrev.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrev.Text = "«·”‹‹‹‹«»ﬁ >"
		Me.cmdPrev.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
		Me.cmdPrev.Location = New System.Drawing.Point(181, 16)
		Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrev.TabIndex = 1
		Me.cmdPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrev.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrev.CausesValidation = True
		Me.cmdPrev.Enabled = True
		Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrev.TabStop = True
		Me.cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrev.Visible = True
		Me.cmdPrev.Name = "cmdPrev"
		Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRefresh.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
		Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
		Me.cmdRefresh.Location = New System.Drawing.Point(0, 0)
		Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdRefresh.TabIndex = 21
		Me.cmdRefresh.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdRefresh.CausesValidation = True
		Me.cmdRefresh.Enabled = True
		Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRefresh.TabStop = True
		Me.cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdRefresh.Visible = True
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.Timer1.Enabled = False
		Me.Timer1.Interval = 1
		Me.Controls.Add(Frame9)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(Frame3)
		Me.Controls.Add(Frame6)
		Me.Controls.Add(Frame7)
		Me.Controls.Add(cmdRefresh)
		Me.Frame9.Controls.Add(cmdReturn)
		Me.Frame9.Controls.Add(cmdLogout)
		Me.Frame9.Controls.Add(cmdExit)
		Me.Frame1.Controls.Add(cmbType)
		Me.Frame1.Controls.Add(cmbUnit)
		Me.Frame1.Controls.Add(cmbRank)
		Me.Frame1.Controls.Add(txtPassword)
		Me.Frame1.Controls.Add(txtUserName)
		Me.Frame1.Controls.Add(txtName)
		Me.Frame1.Controls.Add(txtID)
		Me.Frame1.Controls.Add(Label6)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label8)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame1.Controls.Add(_Label4_0)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label1)
		Me.Frame3.Controls.Add(txtFind)
		Me.Frame3.Controls.Add(cmbCriteria)
		Me.Frame3.Controls.Add(Label5)
		Me.Frame3.Controls.Add(_Label4_1)
		Me.Frame3.Controls.Add(lblPosition)
		Me.Frame6.Controls.Add(cmdEdit)
		Me.Frame6.Controls.Add(cmdSave)
		Me.Frame6.Controls.Add(cmdNew)
		Me.Frame6.Controls.Add(cmdDelete)
		Me.Frame6.Controls.Add(cmdCancel)
		Me.Frame7.Controls.Add(cmdNext)
		Me.Frame7.Controls.Add(cmdLast)
		Me.Frame7.Controls.Add(cmdFirst)
		Me.Frame7.Controls.Add(cmdPrev)
        'Me.Label4.SetIndex(_Label4_0, CType(0, Short))
        'Me.Label4.SetIndex(_Label4_1, CType(1, Short))
        'CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Frame9.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame3.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Frame7.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class