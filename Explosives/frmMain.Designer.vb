<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmMain
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
	Public WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuLogin As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFinancial As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuUsers As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuSecurity As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuBackToDefault As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuBackToFolder As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuCreateBackup As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFromDefault As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuFromFolder As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuRecover As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuBackup As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public CommonDialog1Open As System.Windows.Forms.OpenFileDialog
	Public CommonDialog1Save As System.Windows.Forms.SaveFileDialog
	Public CommonDialog1Font As System.Windows.Forms.FontDialog
	Public CommonDialog1Color As System.Windows.Forms.ColorDialog
	Public CommonDialog1Print As System.Windows.Forms.PrintDialog
	Public WithEvents cmdLogOut As System.Windows.Forms.Button
	Public WithEvents cmdExit As System.Windows.Forms.Button
    'Public WithEvents cmdConditions As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdImportPermissions As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdPermissions As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdPassCopies As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdImoprtAllowed As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdourRecent As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdBalance As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdAccounts As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdImportDoc As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdDistractDoc As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdClasses As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdTeams As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdOurRecentDistract As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdWorkAllowed As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdWorkCopies As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdWorkPermissions As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdNoObjections As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents cmdFinancial As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents CommandButton2 As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents CommandButton1 As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSecurity = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFinancial = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUsers = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreateBackup = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackToDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBackToFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuRecover = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFromDefault = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFromFolder = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CommonDialog1Open = New System.Windows.Forms.OpenFileDialog()
        Me.CommonDialog1Save = New System.Windows.Forms.SaveFileDialog()
        Me.CommonDialog1Font = New System.Windows.Forms.FontDialog()
        Me.CommonDialog1Color = New System.Windows.Forms.ColorDialog()
        Me.CommonDialog1Print = New System.Windows.Forms.PrintDialog()
        Me.cmdLogOut = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.btnAmmo = New System.Windows.Forms.Button()
        Me.btnGasCenter = New System.Windows.Forms.Button()
        Me.btnGasDepot = New System.Windows.Forms.Button()
        Me.btnFuelStation = New System.Windows.Forms.Button()
        Me.btnClasses = New System.Windows.Forms.Button()
        Me.btnAccounts = New System.Windows.Forms.Button()
        Me.btnDistractDoc = New System.Windows.Forms.Button()
        Me.btnWorkCopies = New System.Windows.Forms.Button()
        Me.btnImportDoc = New System.Windows.Forms.Button()
        Me.btnWorkPermissions = New System.Windows.Forms.Button()
        Me.btnPassCopies = New System.Windows.Forms.Button()
        Me.btnWorkAllowed = New System.Windows.Forms.Button()
        Me.btnPermissions = New System.Windows.Forms.Button()
        Me.btnNonObjection = New System.Windows.Forms.Button()
        Me.btnImportAllowed = New System.Windows.Forms.Button()
        Me.btnFinancial = New System.Windows.Forms.Button()
        Me.btnImportPermissions = New System.Windows.Forms.Button()
        Me.btnConditions = New System.Windows.Forms.Button()
        Me.MovementForms = New System.Windows.Forms.Button()
        Me.btnFireworksRequests = New System.Windows.Forms.Button()
        Me.btnTeams = New System.Windows.Forms.Button()
        Me.MainMenu1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSecurity, Me.mnuBackup, Me.mnuAbout})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1264, 24)
        Me.MainMenu1.TabIndex = 8
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogout, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(42, 20)
        Me.mnuFile.Text = "&„·›"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.mnuLogout.Size = New System.Drawing.Size(175, 22)
        Me.mnuLogout.Text = " ”ÃÌ· Œ—ÊÃ"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(175, 22)
        Me.mnuExit.Text = "≈‰‹‹Â‹‹‹‹‹‹«¡"
        '
        'mnuSecurity
        '
        Me.mnuSecurity.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogin, Me.mnuFinancial, Me.mnuUsers})
        Me.mnuSecurity.Name = "mnuSecurity"
        Me.mnuSecurity.Size = New System.Drawing.Size(53, 20)
        Me.mnuSecurity.Text = "«·&Õ„«Ì…"
        '
        'mnuLogin
        '
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(176, 22)
        Me.mnuLogin.Text = "»Ì«‰«   ”ÃÌ· «·œŒÊ·"
        '
        'mnuFinancial
        '
        Me.mnuFinancial.Name = "mnuFinancial"
        Me.mnuFinancial.Size = New System.Drawing.Size(176, 22)
        Me.mnuFinancial.Text = " €ÌÌ— ﬂ·„… «·”—"
        '
        'mnuUsers
        '
        Me.mnuUsers.Name = "mnuUsers"
        Me.mnuUsers.Size = New System.Drawing.Size(176, 22)
        Me.mnuUsers.Text = "«·„” Œœ„Ì‰"
        '
        'mnuBackup
        '
        Me.mnuBackup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreateBackup, Me.mnuRecover})
        Me.mnuBackup.Name = "mnuBackup"
        Me.mnuBackup.Size = New System.Drawing.Size(78, 20)
        Me.mnuBackup.Text = "&œ⁄„ «·»Ì«‰« "
        '
        'mnuCreateBackup
        '
        Me.mnuCreateBackup.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBackToDefault, Me.mnuBackToFolder})
        Me.mnuCreateBackup.Name = "mnuCreateBackup"
        Me.mnuCreateBackup.Size = New System.Drawing.Size(148, 22)
        Me.mnuCreateBackup.Text = "≈‰&‘«¡ „·› œ⁄„"
        '
        'mnuBackToDefault
        '
        Me.mnuBackToDefault.Name = "mnuBackToDefault"
        Me.mnuBackToDefault.Size = New System.Drawing.Size(145, 22)
        Me.mnuBackToDefault.Text = "«·≈&› —«÷Ì"
        '
        'mnuBackToFolder
        '
        Me.mnuBackToFolder.Name = "mnuBackToFolder"
        Me.mnuBackToFolder.Size = New System.Drawing.Size(145, 22)
        Me.mnuBackToFolder.Text = "≈‰‘«¡ ›Ì &„Ã·œ"
        '
        'mnuRecover
        '
        Me.mnuRecover.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFromDefault, Me.mnuFromFolder})
        Me.mnuRecover.Name = "mnuRecover"
        Me.mnuRecover.Size = New System.Drawing.Size(148, 22)
        Me.mnuRecover.Text = "≈” —&Ã«⁄ «·œ⁄„"
        '
        'mnuFromDefault
        '
        Me.mnuFromDefault.Name = "mnuFromDefault"
        Me.mnuFromDefault.Size = New System.Drawing.Size(138, 22)
        Me.mnuFromDefault.Text = "„‰ «·≈&› —«÷Ì"
        '
        'mnuFromFolder
        '
        Me.mnuFromFolder.Name = "mnuFromFolder"
        Me.mnuFromFolder.Size = New System.Drawing.Size(138, 22)
        Me.mnuFromFolder.Text = "„‰ &„Ã·œ"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(68, 20)
        Me.mnuAbout.Text = "&⁄‰ «·‰Ÿ«„"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'cmdLogOut
        '
        Me.cmdLogOut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdLogOut.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLogOut.ForeColor = System.Drawing.Color.White
        Me.cmdLogOut.Location = New System.Drawing.Point(751, 664)
        Me.cmdLogOut.Name = "cmdLogOut"
        Me.cmdLogOut.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdLogOut.Size = New System.Drawing.Size(113, 41)
        Me.cmdLogOut.TabIndex = 3
        Me.cmdLogOut.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.cmdLogOut.UseVisualStyleBackColor = False
        Me.cmdLogOut.Visible = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.Color.White
        Me.cmdExit.Location = New System.Drawing.Point(405, 664)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(113, 41)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.UseVisualStyleBackColor = False
        Me.cmdExit.Visible = False
        '
        'btnAmmo
        '
        Me.btnAmmo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAmmo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAmmo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAmmo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnAmmo.ForeColor = System.Drawing.Color.White
        Me.btnAmmo.Location = New System.Drawing.Point(316, 461)
        Me.btnAmmo.Name = "btnAmmo"
        Me.btnAmmo.Size = New System.Drawing.Size(286, 33)
        Me.btnAmmo.TabIndex = 24
        Me.btnAmmo.Text = "—Œ’ »Ì⁄ Ê Œ“Ì‰ «·–ŒÌ—…"
        Me.btnAmmo.UseVisualStyleBackColor = False
        '
        'btnGasCenter
        '
        Me.btnGasCenter.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGasCenter.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnGasCenter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGasCenter.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnGasCenter.ForeColor = System.Drawing.Color.White
        Me.btnGasCenter.Location = New System.Drawing.Point(662, 461)
        Me.btnGasCenter.Name = "btnGasCenter"
        Me.btnGasCenter.Size = New System.Drawing.Size(286, 33)
        Me.btnGasCenter.TabIndex = 25
        Me.btnGasCenter.Text = " ’«œÌﬁ „—«ﬂ“  Ê“Ì⁄ «·€«“"
        Me.btnGasCenter.UseVisualStyleBackColor = False
        '
        'btnGasDepot
        '
        Me.btnGasDepot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGasDepot.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnGasDepot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnGasDepot.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnGasDepot.ForeColor = System.Drawing.Color.White
        Me.btnGasDepot.Location = New System.Drawing.Point(316, 420)
        Me.btnGasDepot.Name = "btnGasDepot"
        Me.btnGasDepot.Size = New System.Drawing.Size(286, 33)
        Me.btnGasDepot.TabIndex = 23
        Me.btnGasDepot.Text = " ’«œÌﬁ „” Êœ⁄«  «·€«“"
        Me.btnGasDepot.UseVisualStyleBackColor = False
        '
        'btnFuelStation
        '
        Me.btnFuelStation.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFuelStation.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFuelStation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFuelStation.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnFuelStation.ForeColor = System.Drawing.Color.White
        Me.btnFuelStation.Location = New System.Drawing.Point(662, 420)
        Me.btnFuelStation.Name = "btnFuelStation"
        Me.btnFuelStation.Size = New System.Drawing.Size(286, 33)
        Me.btnFuelStation.TabIndex = 22
        Me.btnFuelStation.Text = " ’«œÌﬁ „Õÿ«  «·ÊﬁÊœ"
        Me.btnFuelStation.UseVisualStyleBackColor = False
        '
        'btnClasses
        '
        Me.btnClasses.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClasses.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnClasses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnClasses.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnClasses.ForeColor = System.Drawing.Color.White
        Me.btnClasses.Location = New System.Drawing.Point(316, 381)
        Me.btnClasses.Name = "btnClasses"
        Me.btnClasses.Size = New System.Drawing.Size(286, 33)
        Me.btnClasses.TabIndex = 26
        Me.btnClasses.Text = "«·«’‰«›"
        Me.btnClasses.UseVisualStyleBackColor = False
        '
        'btnAccounts
        '
        Me.btnAccounts.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccounts.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnAccounts.Enabled = False
        Me.btnAccounts.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnAccounts.ForeColor = System.Drawing.Color.White
        Me.btnAccounts.Location = New System.Drawing.Point(453, 577)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.Size = New System.Drawing.Size(286, 33)
        Me.btnAccounts.TabIndex = 29
        Me.btnAccounts.Text = "Õ”«»«  «·„ﬂ »"
        Me.btnAccounts.UseVisualStyleBackColor = False
        Me.btnAccounts.Visible = False
        '
        'btnDistractDoc
        '
        Me.btnDistractDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDistractDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnDistractDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDistractDoc.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnDistractDoc.ForeColor = System.Drawing.Color.White
        Me.btnDistractDoc.Location = New System.Drawing.Point(316, 342)
        Me.btnDistractDoc.Name = "btnDistractDoc"
        Me.btnDistractDoc.Size = New System.Drawing.Size(286, 33)
        Me.btnDistractDoc.TabIndex = 27
        Me.btnDistractDoc.Text = "„” ‰œ«  «·’—›"
        Me.btnDistractDoc.UseVisualStyleBackColor = False
        '
        'btnWorkCopies
        '
        Me.btnWorkCopies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWorkCopies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnWorkCopies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnWorkCopies.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnWorkCopies.ForeColor = System.Drawing.Color.White
        Me.btnWorkCopies.Location = New System.Drawing.Point(316, 301)
        Me.btnWorkCopies.Name = "btnWorkCopies"
        Me.btnWorkCopies.Size = New System.Drawing.Size(286, 33)
        Me.btnWorkCopies.TabIndex = 13
        Me.btnWorkCopies.Text = "’Ê— «–Ê‰«  «·«” Œœ«„"
        Me.btnWorkCopies.UseVisualStyleBackColor = False
        '
        'btnImportDoc
        '
        Me.btnImportDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnImportDoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImportDoc.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnImportDoc.ForeColor = System.Drawing.Color.White
        Me.btnImportDoc.Location = New System.Drawing.Point(662, 342)
        Me.btnImportDoc.Name = "btnImportDoc"
        Me.btnImportDoc.Size = New System.Drawing.Size(286, 33)
        Me.btnImportDoc.TabIndex = 14
        Me.btnImportDoc.Text = "„” ‰œ«  «·Ê«—œ"
        Me.btnImportDoc.UseVisualStyleBackColor = False
        '
        'btnWorkPermissions
        '
        Me.btnWorkPermissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWorkPermissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnWorkPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnWorkPermissions.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnWorkPermissions.ForeColor = System.Drawing.Color.White
        Me.btnWorkPermissions.Location = New System.Drawing.Point(316, 262)
        Me.btnWorkPermissions.Name = "btnWorkPermissions"
        Me.btnWorkPermissions.Size = New System.Drawing.Size(286, 33)
        Me.btnWorkPermissions.TabIndex = 12
        Me.btnWorkPermissions.Text = "«–Ê‰«  «·«” Œœ«„"
        Me.btnWorkPermissions.UseVisualStyleBackColor = False
        '
        'btnPassCopies
        '
        Me.btnPassCopies.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPassCopies.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnPassCopies.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPassCopies.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnPassCopies.ForeColor = System.Drawing.Color.White
        Me.btnPassCopies.Location = New System.Drawing.Point(662, 301)
        Me.btnPassCopies.Name = "btnPassCopies"
        Me.btnPassCopies.Size = New System.Drawing.Size(286, 33)
        Me.btnPassCopies.TabIndex = 10
        Me.btnPassCopies.Text = "’Ê—  ’«—ÌÕ «·„—Ê—"
        Me.btnPassCopies.UseVisualStyleBackColor = False
        '
        'btnWorkAllowed
        '
        Me.btnWorkAllowed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnWorkAllowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnWorkAllowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnWorkAllowed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnWorkAllowed.ForeColor = System.Drawing.Color.White
        Me.btnWorkAllowed.Location = New System.Drawing.Point(316, 224)
        Me.btnWorkAllowed.Name = "btnWorkAllowed"
        Me.btnWorkAllowed.Size = New System.Drawing.Size(286, 33)
        Me.btnWorkAllowed.TabIndex = 11
        Me.btnWorkAllowed.Text = "«·ÃÂ«  «·„” Œœ„… ··„ ›Ã—« "
        Me.btnWorkAllowed.UseVisualStyleBackColor = False
        '
        'btnPermissions
        '
        Me.btnPermissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPermissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPermissions.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnPermissions.ForeColor = System.Drawing.Color.White
        Me.btnPermissions.Location = New System.Drawing.Point(662, 262)
        Me.btnPermissions.Name = "btnPermissions"
        Me.btnPermissions.Size = New System.Drawing.Size(286, 33)
        Me.btnPermissions.TabIndex = 15
        Me.btnPermissions.Text = " ’«—ÌÕ «·„—Ê— Ê«·Œ—ÊÃ"
        Me.btnPermissions.UseVisualStyleBackColor = False
        '
        'btnNonObjection
        '
        Me.btnNonObjection.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNonObjection.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnNonObjection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnNonObjection.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnNonObjection.ForeColor = System.Drawing.Color.White
        Me.btnNonObjection.Location = New System.Drawing.Point(316, 184)
        Me.btnNonObjection.Name = "btnNonObjection"
        Me.btnNonObjection.Size = New System.Drawing.Size(286, 33)
        Me.btnNonObjection.TabIndex = 19
        Me.btnNonObjection.Text = " ’«—ÌÕ ⁄œ„ «·„„«‰⁄…"
        Me.btnNonObjection.UseVisualStyleBackColor = False
        '
        'btnImportAllowed
        '
        Me.btnImportAllowed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportAllowed.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnImportAllowed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImportAllowed.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnImportAllowed.ForeColor = System.Drawing.Color.White
        Me.btnImportAllowed.Location = New System.Drawing.Point(662, 224)
        Me.btnImportAllowed.Name = "btnImportAllowed"
        Me.btnImportAllowed.Size = New System.Drawing.Size(286, 33)
        Me.btnImportAllowed.TabIndex = 20
        Me.btnImportAllowed.Text = "«·ÃÂ«  «·„’—Õ ·Â« »«” Ì—«œ «·„›—ﬁ⁄« "
        Me.btnImportAllowed.UseVisualStyleBackColor = False
        '
        'btnFinancial
        '
        Me.btnFinancial.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinancial.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFinancial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFinancial.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnFinancial.ForeColor = System.Drawing.Color.White
        Me.btnFinancial.Location = New System.Drawing.Point(316, 148)
        Me.btnFinancial.Name = "btnFinancial"
        Me.btnFinancial.Size = New System.Drawing.Size(286, 33)
        Me.btnFinancial.TabIndex = 18
        Me.btnFinancial.Text = "«·«—«‰Ìﬂ «·„«·Ì…"
        Me.btnFinancial.UseVisualStyleBackColor = False
        '
        'btnImportPermissions
        '
        Me.btnImportPermissions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImportPermissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnImportPermissions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnImportPermissions.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnImportPermissions.ForeColor = System.Drawing.Color.White
        Me.btnImportPermissions.Location = New System.Drawing.Point(662, 184)
        Me.btnImportPermissions.Name = "btnImportPermissions"
        Me.btnImportPermissions.Size = New System.Drawing.Size(286, 33)
        Me.btnImportPermissions.TabIndex = 16
        Me.btnImportPermissions.Text = "«–Ê‰«  «·«” Ì—«œ"
        Me.btnImportPermissions.UseVisualStyleBackColor = False
        '
        'btnConditions
        '
        Me.btnConditions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConditions.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnConditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnConditions.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnConditions.ForeColor = System.Drawing.Color.White
        Me.btnConditions.Location = New System.Drawing.Point(662, 148)
        Me.btnConditions.Name = "btnConditions"
        Me.btnConditions.Size = New System.Drawing.Size(286, 33)
        Me.btnConditions.TabIndex = 17
        Me.btnConditions.Text = "‘—Êÿ «·«–Ê‰«  Ê«· ’«—ÌÕ"
        Me.btnConditions.UseVisualStyleBackColor = False
        '
        'MovementForms
        '
        Me.MovementForms.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MovementForms.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.MovementForms.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MovementForms.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.MovementForms.ForeColor = System.Drawing.Color.White
        Me.MovementForms.Location = New System.Drawing.Point(662, 500)
        Me.MovementForms.Name = "MovementForms"
        Me.MovementForms.Size = New System.Drawing.Size(286, 33)
        Me.MovementForms.TabIndex = 25
        Me.MovementForms.Text = "√—«‰Ìﬂ «· Õ—ﬂ« "
        Me.MovementForms.UseVisualStyleBackColor = False
        '
        'btnFireworksRequests
        '
        Me.btnFireworksRequests.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFireworksRequests.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnFireworksRequests.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnFireworksRequests.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnFireworksRequests.ForeColor = System.Drawing.Color.White
        Me.btnFireworksRequests.Location = New System.Drawing.Point(316, 500)
        Me.btnFireworksRequests.Name = "btnFireworksRequests"
        Me.btnFireworksRequests.Size = New System.Drawing.Size(286, 33)
        Me.btnFireworksRequests.TabIndex = 24
        Me.btnFireworksRequests.Text = "ÿ·» „›—ﬁ⁄« "
        Me.btnFireworksRequests.UseVisualStyleBackColor = False
        '
        'btnTeams
        '
        Me.btnTeams.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnTeams.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnTeams.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnTeams.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnTeams.ForeColor = System.Drawing.Color.White
        Me.btnTeams.Location = New System.Drawing.Point(662, 381)
        Me.btnTeams.Name = "btnTeams"
        Me.btnTeams.Size = New System.Drawing.Size(286, 33)
        Me.btnTeams.TabIndex = 29
        Me.btnTeams.Text = "›—ﬁ «·⁄„· „⁄ «·ÃÂ« "
        Me.btnTeams.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1264, 734)
        Me.Controls.Add(Me.btnFireworksRequests)
        Me.Controls.Add(Me.MovementForms)
        Me.Controls.Add(Me.btnAmmo)
        Me.Controls.Add(Me.btnGasCenter)
        Me.Controls.Add(Me.btnGasDepot)
        Me.Controls.Add(Me.btnFuelStation)
        Me.Controls.Add(Me.btnClasses)
        Me.Controls.Add(Me.btnTeams)
        Me.Controls.Add(Me.btnAccounts)
        Me.Controls.Add(Me.btnDistractDoc)
        Me.Controls.Add(Me.btnWorkCopies)
        Me.Controls.Add(Me.btnImportDoc)
        Me.Controls.Add(Me.btnWorkPermissions)
        Me.Controls.Add(Me.btnPassCopies)
        Me.Controls.Add(Me.btnWorkAllowed)
        Me.Controls.Add(Me.btnPermissions)
        Me.Controls.Add(Me.btnNonObjection)
        Me.Controls.Add(Me.btnImportAllowed)
        Me.Controls.Add(Me.btnFinancial)
        Me.Controls.Add(Me.btnImportPermissions)
        Me.Controls.Add(Me.btnConditions)
        Me.Controls.Add(Me.cmdLogOut)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmMain"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "«·’‹‹›‹‹‹Õ‹‹‹‹… «·—∆Ì‹‹‹”‹‹‹‹‹‹…"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAmmo As System.Windows.Forms.Button
    Friend WithEvents btnGasCenter As System.Windows.Forms.Button
    Friend WithEvents btnGasDepot As System.Windows.Forms.Button
    Friend WithEvents btnFuelStation As System.Windows.Forms.Button
    Friend WithEvents btnClasses As System.Windows.Forms.Button
    Friend WithEvents btnAccounts As System.Windows.Forms.Button
    Friend WithEvents btnDistractDoc As System.Windows.Forms.Button
    Friend WithEvents btnWorkCopies As System.Windows.Forms.Button
    Friend WithEvents btnImportDoc As System.Windows.Forms.Button
    Friend WithEvents btnWorkPermissions As System.Windows.Forms.Button
    Friend WithEvents btnPassCopies As System.Windows.Forms.Button
    Friend WithEvents btnWorkAllowed As System.Windows.Forms.Button
    Friend WithEvents btnPermissions As System.Windows.Forms.Button
    Friend WithEvents btnNonObjection As System.Windows.Forms.Button
    Friend WithEvents btnImportAllowed As System.Windows.Forms.Button
    Friend WithEvents btnFinancial As System.Windows.Forms.Button
    Friend WithEvents btnImportPermissions As System.Windows.Forms.Button
    Friend WithEvents btnConditions As System.Windows.Forms.Button
    Friend WithEvents MovementForms As System.Windows.Forms.Button
    Friend WithEvents btnFireworksRequests As System.Windows.Forms.Button
    Friend WithEvents btnTeams As System.Windows.Forms.Button
#End Region
End Class