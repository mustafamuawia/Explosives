<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmOurRecentDistract
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
	Public WithEvents mmnuColours As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents txtReceiver As System.Windows.Forms.TextBox
	Public WithEvents txtDistractor As System.Windows.Forms.TextBox
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
	Public WithEvents lstClassIDStr As System.Windows.Forms.ListBox
	Public WithEvents lstClassStr As System.Windows.Forms.ListBox
	Public WithEvents lstUnitStr As System.Windows.Forms.ListBox
	Public WithEvents lstAmmountStr As System.Windows.Forms.ListBox
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents fmeImported As System.Windows.Forms.GroupBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbSearch As System.Windows.Forms.ComboBox
	Public WithEvents txtDate2 As System.Windows.Forms.TextBox
	Public WithEvents txtDate1 As System.Windows.Forms.TextBox
	Public WithEvents cmbReceiver As System.Windows.Forms.ComboBox
	Public WithEvents chkAll As System.Windows.Forms.CheckBox
	Public WithEvents chkReceiver As System.Windows.Forms.CheckBox
	Public WithEvents cmbAccount As System.Windows.Forms.ComboBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents lblReceiver As System.Windows.Forms.Label
	Public WithEvents lblDistractor As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents lstClassIDDist As System.Windows.Forms.ListBox
	Public WithEvents lstClassDist As System.Windows.Forms.ListBox
	Public WithEvents lstUnitDist As System.Windows.Forms.ListBox
	Public WithEvents lstAmmountDist As System.Windows.Forms.ListBox
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents fmeDistracted As System.Windows.Forms.GroupBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	Public WithEvents Picture1 As System.Windows.Forms.Panel
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOurRecentDistract))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.mmnuColours = New System.Windows.Forms.ToolStripMenuItem
		Me.cmdRefresh = New System.Windows.Forms.CheckBox
		Me.Picture1 = New System.Windows.Forms.Panel
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Frame9 = New System.Windows.Forms.GroupBox
		Me.cmdLogout = New System.Windows.Forms.CheckBox
		Me.cmdExit = New System.Windows.Forms.CheckBox
		Me.cmdPrintAll = New System.Windows.Forms.CheckBox
		Me.cmdFound = New System.Windows.Forms.CheckBox
		Me.cmdPrintDoc = New System.Windows.Forms.CheckBox
		Me.cmdReturn = New System.Windows.Forms.CheckBox
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.txtReceiver = New System.Windows.Forms.TextBox
		Me.txtDistractor = New System.Windows.Forms.TextBox
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Frame7 = New System.Windows.Forms.GroupBox
		Me.cmdNext = New System.Windows.Forms.CheckBox
		Me.cmdPrev = New System.Windows.Forms.CheckBox
		Me.cmdLast = New System.Windows.Forms.CheckBox
		Me.cmdFirst = New System.Windows.Forms.CheckBox
		Me.fmeImported = New System.Windows.Forms.GroupBox
		Me.lstClassIDStr = New System.Windows.Forms.ListBox
		Me.lstClassStr = New System.Windows.Forms.ListBox
		Me.lstUnitStr = New System.Windows.Forms.ListBox
		Me.lstAmmountStr = New System.Windows.Forms.ListBox
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Frame6 = New System.Windows.Forms.GroupBox
		Me.cmdEdit = New System.Windows.Forms.CheckBox
		Me.cmdDelete = New System.Windows.Forms.CheckBox
		Me.cmdNew = New System.Windows.Forms.CheckBox
		Me.cmdSave = New System.Windows.Forms.CheckBox
		Me.cmdCancel = New System.Windows.Forms.CheckBox
		Me.Frame4 = New System.Windows.Forms.GroupBox
		Me.txtFind = New System.Windows.Forms.TextBox
		Me.cmbSearch = New System.Windows.Forms.ComboBox
		Me.txtDate2 = New System.Windows.Forms.TextBox
		Me.txtDate1 = New System.Windows.Forms.TextBox
		Me.cmbReceiver = New System.Windows.Forms.ComboBox
		Me.chkAll = New System.Windows.Forms.CheckBox
		Me.chkReceiver = New System.Windows.Forms.CheckBox
		Me.cmbAccount = New System.Windows.Forms.ComboBox
		Me.Label6 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.lblReceiver = New System.Windows.Forms.Label
		Me.lblDistractor = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.lblPosition = New System.Windows.Forms.Label
		Me.fmeDistracted = New System.Windows.Forms.GroupBox
		Me.lstClassIDDist = New System.Windows.Forms.ListBox
		Me.lstClassDist = New System.Windows.Forms.ListBox
		Me.lstUnitDist = New System.Windows.Forms.ListBox
		Me.lstAmmountDist = New System.Windows.Forms.ListBox
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog
		Me.cmnDlgFont = New System.Windows.Forms.FontDialog
		Me.cmnDlgColor = New System.Windows.Forms.ColorDialog
		Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog
		Me.MainMenu1.SuspendLayout()
		Me.Picture1.SuspendLayout()
		Me.Frame9.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.Frame7.SuspendLayout()
		Me.fmeImported.SuspendLayout()
		Me.Frame6.SuspendLayout()
		Me.Frame4.SuspendLayout()
		Me.fmeDistracted.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.Text = "«·„Êﬁ› «·Õ‹‹‹‹‹‹‹‹‹‹«·‹‹‹‹Ì ··‹‹‹‹’‹‹‹‹«œ—"
		Me.ClientSize = New System.Drawing.Size(1350, 734)
		Me.Location = New System.Drawing.Point(15, 50)
		Me.Icon = CType(resources.GetObject("frmOurRecentDistract.Icon"), System.Drawing.Icon)
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
		Me.Name = "frmOurRecentDistract"
		Me.mmnuColours.Name = "mmnuColours"
		Me.mmnuColours.Text = "÷»ÿ «·√·Ê«‰"
		Me.mmnuColours.Checked = False
		Me.mmnuColours.Enabled = True
		Me.mmnuColours.Visible = True
		Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdRefresh.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
		Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
		Me.cmdRefresh.Location = New System.Drawing.Point(0, 24)
		Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdRefresh.TabIndex = 57
		Me.cmdRefresh.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdRefresh.CausesValidation = True
		Me.cmdRefresh.Enabled = True
		Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdRefresh.TabStop = True
		Me.cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdRefresh.Visible = True
		Me.cmdRefresh.Name = "cmdRefresh"
		Me.Picture1.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.Picture1.Size = New System.Drawing.Size(1953, 1545)
		Me.Picture1.Location = New System.Drawing.Point(0, -96)
		Me.Picture1.TabIndex = 0
		Me.Picture1.Dock = System.Windows.Forms.DockStyle.None
		Me.Picture1.CausesValidation = True
		Me.Picture1.Enabled = True
		Me.Picture1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Picture1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Picture1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Picture1.TabStop = True
		Me.Picture1.Visible = True
		Me.Picture1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Picture1.Name = "Picture1"
		Me.Timer1.Interval = 1
		Me.Timer1.Enabled = True
		Me.Frame9.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame9.Text = "   »Ì«‰«  «·„›—ﬁ⁄«    "
		Me.Frame9.Size = New System.Drawing.Size(1057, 75)
		Me.Frame9.Location = New System.Drawing.Point(104, 176)
		Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame9.TabIndex = 50
		Me.Frame9.Enabled = True
		Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame9.Visible = True
		Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame9.Name = "Frame9"
		Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdLogout.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdLogout.Text = " ”ÃÌ· Œ—ÊÃ"
		Me.cmdLogout.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdLogout.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
		Me.cmdLogout.Location = New System.Drawing.Point(237, 24)
		Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLogout.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLogout.TabIndex = 56
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
		Me.cmdExit.Location = New System.Drawing.Point(88, 24)
		Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdExit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdExit.TabIndex = 55
		Me.cmdExit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdExit.CausesValidation = True
		Me.cmdExit.Enabled = True
		Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdExit.TabStop = True
		Me.cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdExit.Visible = True
		Me.cmdExit.Name = "cmdExit"
		Me.cmdPrintAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrintAll.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrintAll.Text = "ÿ»«⁄… «·ﬂ·"
		Me.cmdPrintAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdPrintAll.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrintAll.Size = New System.Drawing.Size(129, 41)
		Me.cmdPrintAll.Location = New System.Drawing.Point(534, 24)
		Me.cmdPrintAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrintAll.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrintAll.TabIndex = 54
		Me.cmdPrintAll.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrintAll.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrintAll.CausesValidation = True
		Me.cmdPrintAll.Enabled = True
		Me.cmdPrintAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrintAll.TabStop = True
		Me.cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrintAll.Visible = True
		Me.cmdPrintAll.Name = "cmdPrintAll"
		Me.cmdFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdFound.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
		Me.cmdFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdFound.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdFound.Size = New System.Drawing.Size(145, 41)
		Me.cmdFound.Location = New System.Drawing.Point(683, 24)
		Me.cmdFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFound.TabIndex = 53
		Me.cmdFound.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFound.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFound.CausesValidation = True
		Me.cmdFound.Enabled = True
		Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFound.TabStop = True
		Me.cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFound.Visible = True
		Me.cmdFound.Name = "cmdFound"
		Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdPrintDoc.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdPrintDoc.Text = "ÿ»«⁄… «· ﬁ—Ì—"
		Me.cmdPrintDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdPrintDoc.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdPrintDoc.Size = New System.Drawing.Size(129, 41)
		Me.cmdPrintDoc.Location = New System.Drawing.Point(848, 24)
		Me.cmdPrintDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrintDoc.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrintDoc.TabIndex = 52
		Me.cmdPrintDoc.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdPrintDoc.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdPrintDoc.CausesValidation = True
		Me.cmdPrintDoc.Enabled = True
		Me.cmdPrintDoc.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdPrintDoc.TabStop = True
		Me.cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdPrintDoc.Visible = True
		Me.cmdPrintDoc.Name = "cmdPrintDoc"
		Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdReturn.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdReturn.Text = "—Ã‹‹‹‹‹Ê⁄"
		Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.cmdReturn.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
		Me.cmdReturn.Location = New System.Drawing.Point(384, 24)
		Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdReturn.TabIndex = 51
		Me.cmdReturn.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdReturn.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdReturn.CausesValidation = True
		Me.cmdReturn.Enabled = True
		Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdReturn.TabStop = True
		Me.cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdReturn.Visible = True
		Me.cmdReturn.Name = "cmdReturn"
		Me.Frame1.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame1.Text = " »Ì«‰«  «·ÃÂ… "
		Me.Frame1.Size = New System.Drawing.Size(529, 153)
		Me.Frame1.Location = New System.Drawing.Point(632, 251)
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame1.TabIndex = 45
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.txtReceiver.AutoSize = False
		Me.txtReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtReceiver.Size = New System.Drawing.Size(385, 25)
		Me.txtReceiver.Location = New System.Drawing.Point(24, 56)
		Me.txtReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtReceiver.TabIndex = 47
		Me.txtReceiver.AcceptsReturn = True
		Me.txtReceiver.BackColor = System.Drawing.SystemColors.Window
		Me.txtReceiver.CausesValidation = True
		Me.txtReceiver.Enabled = True
		Me.txtReceiver.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtReceiver.HideSelection = True
		Me.txtReceiver.ReadOnly = False
		Me.txtReceiver.Maxlength = 0
		Me.txtReceiver.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtReceiver.MultiLine = False
		Me.txtReceiver.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtReceiver.TabStop = True
		Me.txtReceiver.Visible = True
		Me.txtReceiver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtReceiver.Name = "txtReceiver"
		Me.txtDistractor.AutoSize = False
		Me.txtDistractor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		Me.txtDistractor.Size = New System.Drawing.Size(385, 25)
		Me.txtDistractor.Location = New System.Drawing.Point(24, 24)
		Me.txtDistractor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDistractor.TabIndex = 46
		Me.txtDistractor.AcceptsReturn = True
		Me.txtDistractor.BackColor = System.Drawing.SystemColors.Window
		Me.txtDistractor.CausesValidation = True
		Me.txtDistractor.Enabled = True
		Me.txtDistractor.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDistractor.HideSelection = True
		Me.txtDistractor.ReadOnly = False
		Me.txtDistractor.Maxlength = 0
		Me.txtDistractor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDistractor.MultiLine = False
		Me.txtDistractor.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDistractor.TabStop = True
		Me.txtDistractor.Visible = True
		Me.txtDistractor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDistractor.Name = "txtDistractor"
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label5.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label5.Text = "«”„ «·ÃÂ… «·„” ·„…"
		Me.Label5.Size = New System.Drawing.Size(105, 17)
		Me.Label5.Location = New System.Drawing.Point(408, 64)
		Me.Label5.TabIndex = 49
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label7.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Label7.Text = "«”„ «·ÃÂ… «·’«—›…"
		Me.Label7.Size = New System.Drawing.Size(105, 17)
		Me.Label7.Location = New System.Drawing.Point(408, 32)
		Me.Label7.TabIndex = 48
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.Visible = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Frame7.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
		Me.Frame7.Size = New System.Drawing.Size(529, 65)
		Me.Frame7.Location = New System.Drawing.Point(632, 725)
		Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame7.TabIndex = 40
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
		Me.cmdNext.Location = New System.Drawing.Point(272, 20)
		Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNext.TabIndex = 44
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
		Me.cmdPrev.Location = New System.Drawing.Point(168, 20)
		Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdPrev.TabIndex = 43
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
		Me.cmdLast.Text = "<< «·√ŒÌ‹‹‹‹—"
		Me.cmdLast.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdLast.Size = New System.Drawing.Size(89, 33)
		Me.cmdLast.Location = New System.Drawing.Point(376, 20)
		Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdLast.TabIndex = 42
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
		Me.cmdFirst.Location = New System.Drawing.Point(64, 20)
		Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdFirst.TabIndex = 41
		Me.cmdFirst.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdFirst.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdFirst.CausesValidation = True
		Me.cmdFirst.Enabled = True
		Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdFirst.TabStop = True
		Me.cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdFirst.Visible = True
		Me.cmdFirst.Name = "cmdFirst"
		Me.fmeImported.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.fmeImported.Text = "   „Ã„Ê⁄ „«  „ ’—›Â „‰ „Œ«“‰ «·”·«Õ   "
		Me.fmeImported.Size = New System.Drawing.Size(529, 321)
		Me.fmeImported.Location = New System.Drawing.Point(104, 404)
		Me.fmeImported.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.fmeImported.TabIndex = 31
		Me.fmeImported.Enabled = True
		Me.fmeImported.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fmeImported.Visible = True
		Me.fmeImported.Padding = New System.Windows.Forms.Padding(0)
		Me.fmeImported.Name = "fmeImported"
		Me.lstClassIDStr.Size = New System.Drawing.Size(73, 254)
		Me.lstClassIDStr.Location = New System.Drawing.Point(8, 56)
		Me.lstClassIDStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstClassIDStr.TabIndex = 35
		Me.lstClassIDStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstClassIDStr.BackColor = System.Drawing.SystemColors.Window
		Me.lstClassIDStr.CausesValidation = True
		Me.lstClassIDStr.Enabled = True
		Me.lstClassIDStr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstClassIDStr.IntegralHeight = True
		Me.lstClassIDStr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstClassIDStr.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstClassIDStr.Sorted = False
		Me.lstClassIDStr.TabStop = True
		Me.lstClassIDStr.Visible = True
		Me.lstClassIDStr.MultiColumn = False
		Me.lstClassIDStr.Name = "lstClassIDStr"
		Me.lstClassStr.Size = New System.Drawing.Size(241, 254)
		Me.lstClassStr.Location = New System.Drawing.Point(88, 56)
		Me.lstClassStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstClassStr.TabIndex = 34
		Me.lstClassStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstClassStr.BackColor = System.Drawing.SystemColors.Window
		Me.lstClassStr.CausesValidation = True
		Me.lstClassStr.Enabled = True
		Me.lstClassStr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstClassStr.IntegralHeight = True
		Me.lstClassStr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstClassStr.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstClassStr.Sorted = False
		Me.lstClassStr.TabStop = True
		Me.lstClassStr.Visible = True
		Me.lstClassStr.MultiColumn = False
		Me.lstClassStr.Name = "lstClassStr"
		Me.lstUnitStr.Size = New System.Drawing.Size(97, 254)
		Me.lstUnitStr.Location = New System.Drawing.Point(336, 56)
		Me.lstUnitStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstUnitStr.TabIndex = 33
		Me.lstUnitStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstUnitStr.BackColor = System.Drawing.SystemColors.Window
		Me.lstUnitStr.CausesValidation = True
		Me.lstUnitStr.Enabled = True
		Me.lstUnitStr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstUnitStr.IntegralHeight = True
		Me.lstUnitStr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstUnitStr.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstUnitStr.Sorted = False
		Me.lstUnitStr.TabStop = True
		Me.lstUnitStr.Visible = True
		Me.lstUnitStr.MultiColumn = False
		Me.lstUnitStr.Name = "lstUnitStr"
		Me.lstAmmountStr.Size = New System.Drawing.Size(81, 254)
		Me.lstAmmountStr.Location = New System.Drawing.Point(440, 56)
		Me.lstAmmountStr.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstAmmountStr.TabIndex = 32
		Me.lstAmmountStr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstAmmountStr.BackColor = System.Drawing.SystemColors.Window
		Me.lstAmmountStr.CausesValidation = True
		Me.lstAmmountStr.Enabled = True
		Me.lstAmmountStr.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstAmmountStr.IntegralHeight = True
		Me.lstAmmountStr.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstAmmountStr.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstAmmountStr.Sorted = False
		Me.lstAmmountStr.TabStop = True
		Me.lstAmmountStr.Visible = True
		Me.lstAmmountStr.MultiColumn = False
		Me.lstAmmountStr.Name = "lstAmmountStr"
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label12.Text = "‰„—… «·⁄Ì‰…"
		Me.Label12.Size = New System.Drawing.Size(65, 17)
		Me.Label12.Location = New System.Drawing.Point(16, 32)
		Me.Label12.TabIndex = 39
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label11.Text = "«·ﬂ„Ì…"
		Me.Label11.Size = New System.Drawing.Size(57, 17)
		Me.Label11.Location = New System.Drawing.Point(448, 32)
		Me.Label11.TabIndex = 38
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.Visible = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.Text = "ÊÕœ… «·ﬁÌ«”"
		Me.Label2.Size = New System.Drawing.Size(81, 17)
		Me.Label2.Location = New System.Drawing.Point(352, 32)
		Me.Label2.TabIndex = 37
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.Text = "«·’‰›"
		Me.Label1.Size = New System.Drawing.Size(65, 17)
		Me.Label1.Location = New System.Drawing.Point(184, 32)
		Me.Label1.TabIndex = 36
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Frame6.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame6.Text = "⁄„·Ì«  ⁄·Ï ”Ã·«  "
		Me.Frame6.Size = New System.Drawing.Size(529, 65)
		Me.Frame6.Location = New System.Drawing.Point(104, 725)
		Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame6.TabIndex = 25
		Me.Frame6.Enabled = True
		Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame6.Visible = True
		Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame6.Name = "Frame6"
		Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdEdit.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdEdit.Text = " ‹‹‹⁄‹‹‹œÌ·"
		Me.cmdEdit.Enabled = False
		Me.cmdEdit.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
		Me.cmdEdit.Location = New System.Drawing.Point(173, 20)
		Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdEdit.TabIndex = 30
		Me.cmdEdit.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdEdit.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdEdit.CausesValidation = True
		Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdEdit.TabStop = True
		Me.cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdEdit.Visible = True
		Me.cmdEdit.Name = "cmdEdit"
		Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdDelete.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdDelete.Text = "Õ‹‹‹‹‹–›"
		Me.cmdDelete.Enabled = False
		Me.cmdDelete.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
		Me.cmdDelete.Location = New System.Drawing.Point(72, 20)
		Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdDelete.TabIndex = 29
		Me.cmdDelete.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdDelete.CausesValidation = True
		Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdDelete.TabStop = True
		Me.cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdDelete.Visible = True
		Me.cmdDelete.Name = "cmdDelete"
		Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdNew.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdNew.Text = "Ã‹‹‹‹œÌ‹‹‹‹œ"
		Me.cmdNew.Enabled = False
		Me.cmdNew.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdNew.Size = New System.Drawing.Size(81, 33)
		Me.cmdNew.Location = New System.Drawing.Point(384, 20)
		Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdNew.TabIndex = 28
		Me.cmdNew.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdNew.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdNew.CausesValidation = True
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
		Me.cmdSave.Size = New System.Drawing.Size(81, 33)
		Me.cmdSave.Location = New System.Drawing.Point(283, 20)
		Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdSave.TabIndex = 27
		Me.cmdSave.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdSave.CausesValidation = True
		Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSave.TabStop = True
		Me.cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdSave.Visible = True
		Me.cmdSave.Name = "cmdSave"
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹«¡"
		Me.cmdCancel.Enabled = False
		Me.cmdCancel.ForeColor = System.Drawing.SystemColors.highlightText
		Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(173, 20)
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdCancel.TabIndex = 26
		Me.cmdCancel.Visible = False
		Me.cmdCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdCancel.Name = "cmdCancel"
		Me.Frame4.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.Frame4.Text = " «·»ÕÀ ›Ì «·”Ã·«  "
		Me.Frame4.Size = New System.Drawing.Size(529, 153)
		Me.Frame4.Location = New System.Drawing.Point(104, 251)
		Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Frame4.TabIndex = 10
		Me.Frame4.Enabled = True
		Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame4.Visible = True
		Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame4.Name = "Frame4"
		Me.txtFind.AutoSize = False
		Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtFind.Size = New System.Drawing.Size(241, 25)
		Me.txtFind.Location = New System.Drawing.Point(16, 24)
		Me.txtFind.MultiLine = True
		Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtFind.TabIndex = 18
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
		Me.cmbSearch.Size = New System.Drawing.Size(201, 21)
		Me.cmbSearch.Location = New System.Drawing.Point(304, 24)
		Me.cmbSearch.Items.AddRange(New Object(){"⁄«„", "«”„ «·ÃÂ… «·’«—›…", "«”„ «·ÃÂ… «·„” ·„…"})
		Me.cmbSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbSearch.TabIndex = 17
		Me.cmbSearch.BackColor = System.Drawing.SystemColors.Window
		Me.cmbSearch.CausesValidation = True
		Me.cmbSearch.Enabled = True
		Me.cmbSearch.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbSearch.IntegralHeight = True
		Me.cmbSearch.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbSearch.Sorted = False
		Me.cmbSearch.TabStop = True
		Me.cmbSearch.Visible = True
		Me.cmbSearch.Name = "cmbSearch"
		Me.txtDate2.AutoSize = False
		Me.txtDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtDate2.Size = New System.Drawing.Size(97, 25)
		Me.txtDate2.Location = New System.Drawing.Point(16, 72)
		Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDate2.TabIndex = 16
		Me.txtDate2.AcceptsReturn = True
		Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
		Me.txtDate2.CausesValidation = True
		Me.txtDate2.Enabled = True
		Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDate2.HideSelection = True
		Me.txtDate2.ReadOnly = False
		Me.txtDate2.Maxlength = 0
		Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDate2.MultiLine = False
		Me.txtDate2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDate2.TabStop = True
		Me.txtDate2.Visible = True
		Me.txtDate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate2.Name = "txtDate2"
		Me.txtDate1.AutoSize = False
		Me.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtDate1.Size = New System.Drawing.Size(97, 25)
		Me.txtDate1.Location = New System.Drawing.Point(160, 72)
		Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.txtDate1.TabIndex = 15
		Me.txtDate1.AcceptsReturn = True
		Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
		Me.txtDate1.CausesValidation = True
		Me.txtDate1.Enabled = True
		Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDate1.HideSelection = True
		Me.txtDate1.ReadOnly = False
		Me.txtDate1.Maxlength = 0
		Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDate1.MultiLine = False
		Me.txtDate1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDate1.TabStop = True
		Me.txtDate1.Visible = True
		Me.txtDate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDate1.Name = "txtDate1"
		Me.cmbReceiver.Size = New System.Drawing.Size(201, 21)
		Me.cmbReceiver.Location = New System.Drawing.Point(304, 74)
		Me.cmbReceiver.Items.AddRange(New Object(){"«”„ «·ÃÂ… «·„” ·„…", "⁄«„"})
		Me.cmbReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbReceiver.Sorted = True
		Me.cmbReceiver.TabIndex = 14
		Me.cmbReceiver.Text = "cmbReceiver"
		Me.cmbReceiver.BackColor = System.Drawing.SystemColors.Window
		Me.cmbReceiver.CausesValidation = True
		Me.cmbReceiver.Enabled = True
		Me.cmbReceiver.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbReceiver.IntegralHeight = True
		Me.cmbReceiver.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbReceiver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cmbReceiver.TabStop = True
		Me.cmbReceiver.Visible = True
		Me.cmbReceiver.Name = "cmbReceiver"
		Me.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkAll.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.chkAll.Text = "«·ﬂ·"
		Me.chkAll.ForeColor = System.Drawing.Color.White
		Me.chkAll.Size = New System.Drawing.Size(41, 17)
		Me.chkAll.Location = New System.Drawing.Point(262, 24)
		Me.chkAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.chkAll.TabIndex = 13
		Me.chkAll.CheckState = System.Windows.Forms.CheckState.Indeterminate
		Me.chkAll.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkAll.CausesValidation = True
		Me.chkAll.Enabled = True
		Me.chkAll.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkAll.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkAll.TabStop = True
		Me.chkAll.Visible = True
		Me.chkAll.Name = "chkAll"
		Me.chkReceiver.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
		Me.chkReceiver.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.chkReceiver.Text = "«·ﬂ·"
		Me.chkReceiver.ForeColor = System.Drawing.Color.White
		Me.chkReceiver.Size = New System.Drawing.Size(41, 17)
		Me.chkReceiver.Location = New System.Drawing.Point(352, 56)
		Me.chkReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.chkReceiver.TabIndex = 12
		Me.chkReceiver.CheckState = System.Windows.Forms.CheckState.Indeterminate
		Me.chkReceiver.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chkReceiver.CausesValidation = True
		Me.chkReceiver.Enabled = True
		Me.chkReceiver.Cursor = System.Windows.Forms.Cursors.Default
		Me.chkReceiver.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chkReceiver.TabStop = True
		Me.chkReceiver.Visible = True
		Me.chkReceiver.Name = "chkReceiver"
		Me.cmbAccount.Size = New System.Drawing.Size(153, 21)
		Me.cmbAccount.Location = New System.Drawing.Point(304, 112)
		Me.cmbAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmbAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cmbAccount.TabIndex = 11
		Me.cmbAccount.BackColor = System.Drawing.SystemColors.Window
		Me.cmbAccount.CausesValidation = True
		Me.cmbAccount.Enabled = True
		Me.cmbAccount.ForeColor = System.Drawing.SystemColors.WindowText
		Me.cmbAccount.IntegralHeight = True
		Me.cmbAccount.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmbAccount.Sorted = False
		Me.cmbAccount.TabStop = True
		Me.cmbAccount.Visible = True
		Me.cmbAccount.Name = "cmbAccount"
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label6.Text = "≈·‹Ï"
		Me.Label6.Size = New System.Drawing.Size(41, 25)
		Me.Label6.Location = New System.Drawing.Point(112, 80)
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label6.TabIndex = 24
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label10.Text = "„‰"
		Me.Label10.Size = New System.Drawing.Size(17, 17)
		Me.Label10.Location = New System.Drawing.Point(264, 80)
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label10.TabIndex = 23
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.UseMnemonic = True
		Me.Label10.Visible = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.lblReceiver.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblReceiver.BackColor = System.Drawing.Color.Transparent
		Me.lblReceiver.Text = "«”„ «·ÃÂ… «·„” ·„… :"
		Me.lblReceiver.Size = New System.Drawing.Size(97, 17)
		Me.lblReceiver.Location = New System.Drawing.Point(408, 56)
		Me.lblReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lblReceiver.TabIndex = 22
		Me.lblReceiver.Enabled = True
		Me.lblReceiver.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblReceiver.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblReceiver.UseMnemonic = True
		Me.lblReceiver.Visible = True
		Me.lblReceiver.AutoSize = False
		Me.lblReceiver.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblReceiver.Name = "lblReceiver"
		Me.lblDistractor.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDistractor.BackColor = System.Drawing.Color.Transparent
		Me.lblDistractor.Text = "«”„ «·ÃÂ…«·’«—›… :"
		Me.lblDistractor.Size = New System.Drawing.Size(97, 17)
		Me.lblDistractor.Location = New System.Drawing.Point(408, 56)
		Me.lblDistractor.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lblDistractor.TabIndex = 21
		Me.lblDistractor.Enabled = True
		Me.lblDistractor.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblDistractor.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDistractor.UseMnemonic = True
		Me.lblDistractor.Visible = True
		Me.lblDistractor.AutoSize = False
		Me.lblDistractor.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDistractor.Name = "lblDistractor"
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label13.BackColor = System.Drawing.Color.Transparent
		Me.Label13.Text = "Õ”«»"
		Me.Label13.Size = New System.Drawing.Size(65, 17)
		Me.Label13.Location = New System.Drawing.Point(456, 120)
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label13.TabIndex = 20
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.UseMnemonic = True
		Me.Label13.Visible = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblPosition.Text = "Label14"
		Me.lblPosition.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblPosition.Size = New System.Drawing.Size(257, 33)
		Me.lblPosition.Location = New System.Drawing.Point(16, 104)
		Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lblPosition.TabIndex = 19
		Me.lblPosition.BackColor = System.Drawing.SystemColors.Control
		Me.lblPosition.Enabled = True
		Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblPosition.UseMnemonic = True
		Me.lblPosition.Visible = True
		Me.lblPosition.AutoSize = False
		Me.lblPosition.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblPosition.Name = "lblPosition"
		Me.fmeDistracted.BackColor = System.Drawing.Color.FromARGB(192, 64, 0)
		Me.fmeDistracted.Text = "    „Ã„Ê⁄ „«  „ ’—›Â „‰ „Œ«“‰ «·”·«Õ    "
		Me.fmeDistracted.Enabled = False
		Me.fmeDistracted.Size = New System.Drawing.Size(529, 321)
		Me.fmeDistracted.Location = New System.Drawing.Point(632, 404)
		Me.fmeDistracted.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.fmeDistracted.TabIndex = 1
		Me.fmeDistracted.ForeColor = System.Drawing.SystemColors.ControlText
		Me.fmeDistracted.Visible = True
		Me.fmeDistracted.Padding = New System.Windows.Forms.Padding(0)
		Me.fmeDistracted.Name = "fmeDistracted"
		Me.lstClassIDDist.Enabled = False
		Me.lstClassIDDist.Size = New System.Drawing.Size(73, 254)
		Me.lstClassIDDist.Location = New System.Drawing.Point(8, 56)
		Me.lstClassIDDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstClassIDDist.TabIndex = 5
		Me.lstClassIDDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstClassIDDist.BackColor = System.Drawing.SystemColors.Window
		Me.lstClassIDDist.CausesValidation = True
		Me.lstClassIDDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstClassIDDist.IntegralHeight = True
		Me.lstClassIDDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstClassIDDist.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstClassIDDist.Sorted = False
		Me.lstClassIDDist.TabStop = True
		Me.lstClassIDDist.Visible = True
		Me.lstClassIDDist.MultiColumn = False
		Me.lstClassIDDist.Name = "lstClassIDDist"
		Me.lstClassDist.Enabled = False
		Me.lstClassDist.Size = New System.Drawing.Size(241, 254)
		Me.lstClassDist.Location = New System.Drawing.Point(88, 56)
		Me.lstClassDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstClassDist.TabIndex = 4
		Me.lstClassDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstClassDist.BackColor = System.Drawing.SystemColors.Window
		Me.lstClassDist.CausesValidation = True
		Me.lstClassDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstClassDist.IntegralHeight = True
		Me.lstClassDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstClassDist.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstClassDist.Sorted = False
		Me.lstClassDist.TabStop = True
		Me.lstClassDist.Visible = True
		Me.lstClassDist.MultiColumn = False
		Me.lstClassDist.Name = "lstClassDist"
		Me.lstUnitDist.Enabled = False
		Me.lstUnitDist.Size = New System.Drawing.Size(97, 254)
		Me.lstUnitDist.Location = New System.Drawing.Point(336, 56)
		Me.lstUnitDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstUnitDist.TabIndex = 3
		Me.lstUnitDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstUnitDist.BackColor = System.Drawing.SystemColors.Window
		Me.lstUnitDist.CausesValidation = True
		Me.lstUnitDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstUnitDist.IntegralHeight = True
		Me.lstUnitDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstUnitDist.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstUnitDist.Sorted = False
		Me.lstUnitDist.TabStop = True
		Me.lstUnitDist.Visible = True
		Me.lstUnitDist.MultiColumn = False
		Me.lstUnitDist.Name = "lstUnitDist"
		Me.lstAmmountDist.Enabled = False
		Me.lstAmmountDist.Size = New System.Drawing.Size(81, 254)
		Me.lstAmmountDist.Location = New System.Drawing.Point(440, 56)
		Me.lstAmmountDist.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lstAmmountDist.TabIndex = 2
		Me.lstAmmountDist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lstAmmountDist.BackColor = System.Drawing.SystemColors.Window
		Me.lstAmmountDist.CausesValidation = True
		Me.lstAmmountDist.ForeColor = System.Drawing.SystemColors.WindowText
		Me.lstAmmountDist.IntegralHeight = True
		Me.lstAmmountDist.Cursor = System.Windows.Forms.Cursors.Default
		Me.lstAmmountDist.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.lstAmmountDist.Sorted = False
		Me.lstAmmountDist.TabStop = True
		Me.lstAmmountDist.Visible = True
		Me.lstAmmountDist.MultiColumn = False
		Me.lstAmmountDist.Name = "lstAmmountDist"
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label9.Text = "‰„—… «·⁄Ì‰…"
		Me.Label9.Enabled = False
		Me.Label9.Size = New System.Drawing.Size(65, 17)
		Me.Label9.Location = New System.Drawing.Point(16, 32)
		Me.Label9.TabIndex = 9
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.Visible = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label8.Text = "«·ﬂ„Ì…"
		Me.Label8.Enabled = False
		Me.Label8.Size = New System.Drawing.Size(57, 17)
		Me.Label8.Location = New System.Drawing.Point(448, 32)
		Me.Label8.TabIndex = 8
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label3.Text = "«·’‰›"
		Me.Label3.Enabled = False
		Me.Label3.Size = New System.Drawing.Size(65, 17)
		Me.Label3.Location = New System.Drawing.Point(184, 32)
		Me.Label3.TabIndex = 7
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label4.Text = "ÊÕœ… «·ﬁÌ«”"
		Me.Label4.Enabled = False
		Me.Label4.Size = New System.Drawing.Size(81, 17)
		Me.Label4.Location = New System.Drawing.Point(352, 32)
		Me.Label4.TabIndex = 6
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Controls.Add(cmdRefresh)
		Me.Controls.Add(Picture1)
		Me.Picture1.Controls.Add(Frame9)
		Me.Picture1.Controls.Add(Frame1)
		Me.Picture1.Controls.Add(Frame7)
		Me.Picture1.Controls.Add(fmeImported)
		Me.Picture1.Controls.Add(Frame6)
		Me.Picture1.Controls.Add(Frame4)
		Me.Picture1.Controls.Add(fmeDistracted)
		Me.Frame9.Controls.Add(cmdLogout)
		Me.Frame9.Controls.Add(cmdExit)
		Me.Frame9.Controls.Add(cmdPrintAll)
		Me.Frame9.Controls.Add(cmdFound)
		Me.Frame9.Controls.Add(cmdPrintDoc)
		Me.Frame9.Controls.Add(cmdReturn)
		Me.Frame1.Controls.Add(txtReceiver)
		Me.Frame1.Controls.Add(txtDistractor)
		Me.Frame1.Controls.Add(Label5)
		Me.Frame1.Controls.Add(Label7)
		Me.Frame7.Controls.Add(cmdNext)
		Me.Frame7.Controls.Add(cmdPrev)
		Me.Frame7.Controls.Add(cmdLast)
		Me.Frame7.Controls.Add(cmdFirst)
		Me.fmeImported.Controls.Add(lstClassIDStr)
		Me.fmeImported.Controls.Add(lstClassStr)
		Me.fmeImported.Controls.Add(lstUnitStr)
		Me.fmeImported.Controls.Add(lstAmmountStr)
		Me.fmeImported.Controls.Add(Label12)
		Me.fmeImported.Controls.Add(Label11)
		Me.fmeImported.Controls.Add(Label2)
		Me.fmeImported.Controls.Add(Label1)
		Me.Frame6.Controls.Add(cmdEdit)
		Me.Frame6.Controls.Add(cmdDelete)
		Me.Frame6.Controls.Add(cmdNew)
		Me.Frame6.Controls.Add(cmdSave)
		Me.Frame6.Controls.Add(cmdCancel)
		Me.Frame4.Controls.Add(txtFind)
		Me.Frame4.Controls.Add(cmbSearch)
		Me.Frame4.Controls.Add(txtDate2)
		Me.Frame4.Controls.Add(txtDate1)
		Me.Frame4.Controls.Add(cmbReceiver)
		Me.Frame4.Controls.Add(chkAll)
		Me.Frame4.Controls.Add(chkReceiver)
		Me.Frame4.Controls.Add(cmbAccount)
		Me.Frame4.Controls.Add(Label6)
		Me.Frame4.Controls.Add(Label10)
		Me.Frame4.Controls.Add(lblReceiver)
		Me.Frame4.Controls.Add(lblDistractor)
		Me.Frame4.Controls.Add(Label13)
		Me.Frame4.Controls.Add(lblPosition)
		Me.fmeDistracted.Controls.Add(lstClassIDDist)
		Me.fmeDistracted.Controls.Add(lstClassDist)
		Me.fmeDistracted.Controls.Add(lstUnitDist)
		Me.fmeDistracted.Controls.Add(lstAmmountDist)
		Me.fmeDistracted.Controls.Add(Label9)
		Me.fmeDistracted.Controls.Add(Label8)
		Me.fmeDistracted.Controls.Add(Label3)
		Me.fmeDistracted.Controls.Add(Label4)
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.mmnuColours})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.Picture1.ResumeLayout(False)
		Me.Frame9.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.Frame7.ResumeLayout(False)
		Me.fmeImported.ResumeLayout(False)
		Me.Frame6.ResumeLayout(False)
		Me.Frame4.ResumeLayout(False)
		Me.fmeDistracted.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class