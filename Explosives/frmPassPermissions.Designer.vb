<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPassPermissions
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
	Public WithEvents mnuPay As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents optImport As System.Windows.Forms.RadioButton
	Public WithEvents optDistract As System.Windows.Forms.RadioButton
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
	Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
	Public WithEvents cmbName As System.Windows.Forms.ComboBox
	Public WithEvents cmbRank As System.Windows.Forms.ComboBox
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Frame12 As System.Windows.Forms.GroupBox
	Public WithEvents txtPurpose As System.Windows.Forms.TextBox
	Public WithEvents cmdFmtDoc As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdFmtAll As System.Windows.Forms.CheckBox
	Public WithEvents Check3 As System.Windows.Forms.CheckBox
	Public WithEvents Check2 As System.Windows.Forms.CheckBox
	Public WithEvents Check1 As System.Windows.Forms.CheckBox
	Public WithEvents Frame11 As System.Windows.Forms.GroupBox
	Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
	Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
	Public WithEvents cmdExit As System.Windows.Forms.CheckBox
	Public WithEvents cmdRptAll As System.Windows.Forms.CheckBox
	Public WithEvents cmdRptFound As System.Windows.Forms.CheckBox
	Public WithEvents cmdRptDoc As System.Windows.Forms.CheckBox
	Public WithEvents Frame9 As System.Windows.Forms.GroupBox
	Public WithEvents txtSenderAddress As System.Windows.Forms.ComboBox
	Public WithEvents cmbSender As System.Windows.Forms.TextBox
	Public WithEvents cmbReceiver As System.Windows.Forms.TextBox
    Public WithEvents txtStoreID As System.Windows.Forms.TextBox
    Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Frame10 As System.Windows.Forms.GroupBox
	Public WithEvents txtPoint3 As System.Windows.Forms.ComboBox
	Public WithEvents txtPoint2 As System.Windows.Forms.ComboBox
	Public WithEvents txtPoint1 As System.Windows.Forms.ComboBox
    Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Frame6 As System.Windows.Forms.GroupBox
	Public WithEvents txtReceiverAddress As System.Windows.Forms.TextBox
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Frame2 As System.Windows.Forms.GroupBox
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
	Public WithEvents cmdSave As System.Windows.Forms.CheckBox
	Public WithEvents cmdNew As System.Windows.Forms.CheckBox
	Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
	Public WithEvents Frame8 As System.Windows.Forms.GroupBox
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
	Public WithEvents cmbDuration As System.Windows.Forms.ComboBox
	Public WithEvents txtFind As System.Windows.Forms.TextBox
	Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
	Public WithEvents txtDate2 As System.Windows.Forms.TextBox
	Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
	Public WithEvents txtDate1 As System.Windows.Forms.TextBox
	Public WithEvents lblPosition As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents Label20 As System.Windows.Forms.Label
	Public WithEvents Label22 As System.Windows.Forms.Label
	Public WithEvents Frame4 As System.Windows.Forms.GroupBox
	Public WithEvents cmbYear As System.Windows.Forms.ComboBox
	Public WithEvents cmdInsertExplosives As System.Windows.Forms.CheckBox
    Public WithEvents cmdGetPass As System.Windows.Forms.CheckBox
	Public WithEvents cmdDistract As System.Windows.Forms.CheckBox
	Public WithEvents txtfID As System.Windows.Forms.TextBox
	Public WithEvents txtLicenseID As System.Windows.Forms.TextBox
    Public WithEvents txtID As System.Windows.Forms.TextBox
	Public WithEvents txtPlace As System.Windows.Forms.TextBox
	Public WithEvents lblWorkID As System.Windows.Forms.Label
	Public WithEvents lblfID As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
	Public WithEvents cmdLast As System.Windows.Forms.CheckBox
	Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
	Public WithEvents cmdNext As System.Windows.Forms.CheckBox
	Public WithEvents Frame7 As System.Windows.Forms.GroupBox
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
        Me.mnuPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.optImport = New System.Windows.Forms.RadioButton()
        Me.PERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.optDistract = New System.Windows.Forms.RadioButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame12 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.NameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PERMISSIONSBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Point3DsExplosives1 = New Explosives.dsExplosives()
        Me.PERMISSIONSBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Point2DsExplosives1 = New Explosives.dsExplosives()
        Me.PERMISSIONSBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Point1DsExplosives1 = New Explosives.dsExplosives()
        Me.Frame11 = New System.Windows.Forms.GroupBox()
        Me.btnMovementForm = New System.Windows.Forms.Button()
        Me.cmdFmtDoc = New System.Windows.Forms.CheckBox()
        Me.cmdFmtFound = New System.Windows.Forms.CheckBox()
        Me.cmdFmtAll = New System.Windows.Forms.CheckBox()
        Me.Check3 = New System.Windows.Forms.CheckBox()
        Me.Check2 = New System.Windows.Forms.CheckBox()
        Me.Check1 = New System.Windows.Forms.CheckBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdRptAll = New System.Windows.Forms.CheckBox()
        Me.cmdRptFound = New System.Windows.Forms.CheckBox()
        Me.cmdRptDoc = New System.Windows.Forms.CheckBox()
        Me.Frame2 = New System.Windows.Forms.GroupBox()
        Me.txtSenderAddress = New System.Windows.Forms.ComboBox()
        Me.SenderAddressBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SenderAddressDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbSender = New System.Windows.Forms.TextBox()
        Me.cmbReceiver = New System.Windows.Forms.TextBox()
        Me.Frame10 = New System.Windows.Forms.GroupBox()
        Me.txtToStore = New System.Windows.Forms.ComboBox()
        Me.ToStoreBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToStoreDsExplosives1 = New Explosives.dsExplosives()
        Me.dtpStoreDate = New System.Windows.Forms.DateTimePicker()
        Me.txtStoreID = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.txtIsImport = New System.Windows.Forms.TextBox()
        Me.cmbBy = New System.Windows.Forms.ComboBox()
        Me.TransportByPERMISSIONSBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TransportByDsExplosives1 = New Explosives.dsExplosives()
        Me.txtPoint3 = New System.Windows.Forms.ComboBox()
        Me.Point3PassCopiesBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPoint2 = New System.Windows.Forms.ComboBox()
        Me.Point2PassCopiesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtPoint1 = New System.Windows.Forms.ComboBox()
        Me.Point1PassCopiesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReceiverAddress = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Frame8 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PermissionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmbDuration = New System.Windows.Forms.ComboBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.txtDate2 = New System.Windows.Forms.TextBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.txtDate1 = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Frame4 = New System.Windows.Forms.GroupBox()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmdInsertExplosives = New System.Windows.Forms.CheckBox()
        Me.txtWorkID = New System.Windows.Forms.TextBox()
        Me.cmdGetPass = New System.Windows.Forms.CheckBox()
        Me.cmdDistract = New System.Windows.Forms.CheckBox()
        Me.txtfID = New System.Windows.Forms.TextBox()
        Me.txtLicenseID = New System.Windows.Forms.TextBox()
        Me.txtPassPermissionNo = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPlace = New System.Windows.Forms.TextBox()
        Me.lblWorkID = New System.Windows.Forms.Label()
        Me.lblfID = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.PermissionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.PermissionDetailsTableAdapter()
        Me.PERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter()
        Me.PassCopiesTableAdapter = New Explosives.dsExplosivesTableAdapters.PassCopiesTableAdapter()
        Me.TransportByBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MainMenu1.SuspendLayout()
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame12.SuspendLayout()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISSIONSBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point3DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point2DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point1DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame11.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame2.SuspendLayout()
        CType(Me.SenderAddressBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderAddressDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame10.SuspendLayout()
        CType(Me.ToStoreBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToStoreDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame6.SuspendLayout()
        CType(Me.TransportByPERMISSIONSBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TransportByDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point3PassCopiesBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point2PassCopiesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Point1PassCopiesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame8.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.Frame1.SuspendLayout()
        Me.Frame7.SuspendLayout()
        CType(Me.TransportByBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours, Me.mnuPay})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1333, 24)
        Me.MainMenu1.TabIndex = 92
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "÷»ÿ «·√·Ê«‰"
        '
        'mnuPay
        '
        Me.mnuPay.Name = "mnuPay"
        Me.mnuPay.Size = New System.Drawing.Size(101, 20)
        Me.mnuPay.Text = " √ﬂÌœ œ›⁄ «·—”Ê„"
        '
        'optImport
        '
        Me.optImport.BackColor = System.Drawing.SystemColors.Control
        Me.optImport.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optImport.Cursor = System.Windows.Forms.Cursors.Default
        Me.optImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optImport.Location = New System.Drawing.Point(1008, 248)
        Me.optImport.Name = "optImport"
        Me.optImport.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optImport.Size = New System.Drawing.Size(89, 25)
        Me.optImport.TabIndex = 91
        Me.optImport.Text = "≈” Ì—«œ"
        Me.optImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optImport.UseVisualStyleBackColor = False
        '
        'PERMISSIONSBindingSource
        '
        Me.PERMISSIONSBindingSource.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'optDistract
        '
        Me.optDistract.BackColor = System.Drawing.SystemColors.Control
        Me.optDistract.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optDistract.Checked = True
        Me.optDistract.Cursor = System.Windows.Forms.Cursors.Default
        Me.optDistract.ForeColor = System.Drawing.SystemColors.ControlText
        Me.optDistract.Location = New System.Drawing.Point(1136, 248)
        Me.optDistract.Name = "optDistract"
        Me.optDistract.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.optDistract.Size = New System.Drawing.Size(89, 25)
        Me.optDistract.TabIndex = 90
        Me.optDistract.TabStop = True
        Me.optDistract.Text = "„‰’—›"
        Me.optDistract.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optDistract.UseVisualStyleBackColor = False
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
        Me.cmdRefresh.TabIndex = 78
        Me.cmdRefresh.Text = " ‹‹‹‹‹‹‹Õ‹‹‹‹œÌ‹‹‹‹‹‹‹À «·»Ì‹‹‹‹‹‹‹«‰« "
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame12.Controls.Add(Me.cmbPosition)
        Me.Frame12.Controls.Add(Me.cmbName)
        Me.Frame12.Controls.Add(Me.cmbRank)
        Me.Frame12.Controls.Add(Me.Label15)
        Me.Frame12.Controls.Add(Me.Label12)
        Me.Frame12.Controls.Add(Me.Label11)
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(105, 540)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame12.Size = New System.Drawing.Size(289, 163)
        Me.Frame12.TabIndex = 73
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "  ’«œ—  Õ   ÊﬁÌ⁄  "
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "POSITION", True))
        Me.cmbPosition.DataSource = Me.PositionBindingSource1
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(8, 104)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(233, 21)
        Me.cmbPosition.TabIndex = 86
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'PositionBindingSource1
        '
        Me.PositionBindingSource1.DataMember = "PERMISSIONS"
        Me.PositionBindingSource1.DataSource = Me.PositionDsExplosives1
        '
        'PositionDsExplosives1
        '
        Me.PositionDsExplosives1.DataSetName = "dsExplosives"
        Me.PositionDsExplosives1.EnforceConstraints = False
        Me.PositionDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "NAME", True))
        Me.cmbName.DataSource = Me.NameBindingSource1
        Me.cmbName.DisplayMember = "NAME"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(8, 72)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(233, 21)
        Me.cmbName.TabIndex = 85
        Me.cmbName.ValueMember = "NAME"
        '
        'NameBindingSource1
        '
        Me.NameBindingSource1.DataMember = "PERMISSIONS"
        Me.NameBindingSource1.DataSource = Me.NameDsExplosives1
        '
        'NameDsExplosives1
        '
        Me.NameDsExplosives1.DataSetName = "dsExplosives"
        Me.NameDsExplosives1.EnforceConstraints = False
        Me.NameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "RANK", True))
        Me.cmbRank.DataSource = Me.RankBindingSource1
        Me.cmbRank.DisplayMember = "RANK"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(8, 40)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(233, 21)
        Me.cmbRank.TabIndex = 84
        Me.cmbRank.ValueMember = "RANK"
        '
        'RankBindingSource1
        '
        Me.RankBindingSource1.DataMember = "PERMISSIONS"
        Me.RankBindingSource1.DataSource = Me.RankDsExplosives1
        '
        'RankDsExplosives1
        '
        Me.RankDsExplosives1.DataSetName = "dsExplosives"
        Me.RankDsExplosives1.EnforceConstraints = False
        Me.RankDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(244, 112)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 76
        Me.Label15.Text = "«·„‰’»"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(246, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "«·— »… "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(244, 76)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "«·«”‹‹‹„"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PERMISSIONSBindingSource3
        '
        Me.PERMISSIONSBindingSource3.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource3.DataSource = Me.Point3DsExplosives1
        '
        'Point3DsExplosives1
        '
        Me.Point3DsExplosives1.DataSetName = "dsExplosives"
        Me.Point3DsExplosives1.EnforceConstraints = False
        Me.Point3DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERMISSIONSBindingSource2
        '
        Me.PERMISSIONSBindingSource2.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource2.DataSource = Me.Point2DsExplosives1
        '
        'Point2DsExplosives1
        '
        Me.Point2DsExplosives1.DataSetName = "dsExplosives"
        Me.Point2DsExplosives1.EnforceConstraints = False
        Me.Point2DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PERMISSIONSBindingSource1
        '
        Me.PERMISSIONSBindingSource1.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource1.DataSource = Me.Point1DsExplosives1
        '
        'Point1DsExplosives1
        '
        Me.Point1DsExplosives1.DataSetName = "dsExplosives"
        Me.Point1DsExplosives1.EnforceConstraints = False
        Me.Point1DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Frame11
        '
        Me.Frame11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame11.Controls.Add(Me.btnMovementForm)
        Me.Frame11.Controls.Add(Me.cmdFmtDoc)
        Me.Frame11.Controls.Add(Me.cmdFmtFound)
        Me.Frame11.Controls.Add(Me.cmdFmtAll)
        Me.Frame11.Controls.Add(Me.Check3)
        Me.Frame11.Controls.Add(Me.Check2)
        Me.Frame11.Controls.Add(Me.Check1)
        Me.Frame11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame11.Location = New System.Drawing.Point(105, 151)
        Me.Frame11.Name = "Frame11"
        Me.Frame11.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame11.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame11.Size = New System.Drawing.Size(1137, 75)
        Me.Frame11.TabIndex = 66
        Me.Frame11.TabStop = False
        Me.Frame11.Text = " ’Ì‹‹‹€‹‹‹… Œ‹‹‹‹‹ÿ‹‹«» "
        '
        'btnMovementForm
        '
        Me.btnMovementForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnMovementForm.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnMovementForm.Font = New System.Drawing.Font("Traditional Arabic", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMovementForm.ForeColor = System.Drawing.Color.White
        Me.btnMovementForm.Location = New System.Drawing.Point(888, 24)
        Me.btnMovementForm.Name = "btnMovementForm"
        Me.btnMovementForm.Size = New System.Drawing.Size(120, 41)
        Me.btnMovementForm.TabIndex = 96
        Me.btnMovementForm.Text = "«Ê—‰Ìﬂ «· Õ—ﬂ« "
        Me.btnMovementForm.UseVisualStyleBackColor = False
        '
        'cmdFmtDoc
        '
        Me.cmdFmtDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFmtDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFmtDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFmtDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFmtDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFmtDoc.Location = New System.Drawing.Point(753, 24)
        Me.cmdFmtDoc.Name = "cmdFmtDoc"
        Me.cmdFmtDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtDoc.Size = New System.Drawing.Size(97, 41)
        Me.cmdFmtDoc.TabIndex = 72
        Me.cmdFmtDoc.Text = "ÿ»«⁄… «· ’—ÌÕ"
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
        Me.cmdFmtFound.Location = New System.Drawing.Point(618, 24)
        Me.cmdFmtFound.Name = "cmdFmtFound"
        Me.cmdFmtFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtFound.Size = New System.Drawing.Size(113, 41)
        Me.cmdFmtFound.TabIndex = 71
        Me.cmdFmtFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
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
        Me.cmdFmtAll.Location = New System.Drawing.Point(491, 24)
        Me.cmdFmtAll.Name = "cmdFmtAll"
        Me.cmdFmtAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFmtAll.Size = New System.Drawing.Size(97, 41)
        Me.cmdFmtAll.TabIndex = 70
        Me.cmdFmtAll.Text = "ÿ»«⁄… «·ﬂ·"
        Me.cmdFmtAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFmtAll.UseVisualStyleBackColor = False
        '
        'Check3
        '
        Me.Check3.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check3.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check3.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check3.Location = New System.Drawing.Point(128, 24)
        Me.Check3.Name = "Check3"
        Me.Check3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check3.Size = New System.Drawing.Size(97, 41)
        Me.Check3.TabIndex = 69
        Me.Check3.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.Check3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check3.UseVisualStyleBackColor = False
        '
        'Check2
        '
        Me.Check2.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check2.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check2.Location = New System.Drawing.Point(247, 24)
        Me.Check2.Name = "Check2"
        Me.Check2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check2.Size = New System.Drawing.Size(97, 41)
        Me.Check2.TabIndex = 68
        Me.Check2.Text = " ”ÃÌ· Œ—ÊÃ"
        Me.Check2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check2.UseVisualStyleBackColor = False
        '
        'Check1
        '
        Me.Check1.Appearance = System.Windows.Forms.Appearance.Button
        Me.Check1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.Check1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Check1.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Check1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Check1.Location = New System.Drawing.Point(367, 24)
        Me.Check1.Name = "Check1"
        Me.Check1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Check1.Size = New System.Drawing.Size(97, 41)
        Me.Check1.TabIndex = 67
        Me.Check1.Text = "—Ã‹‹‹‹‹Ê⁄"
        Me.Check1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Check1.UseVisualStyleBackColor = False
        '
        'txtPurpose
        '
        Me.txtPurpose.AcceptsReturn = True
        Me.txtPurpose.BackColor = System.Drawing.SystemColors.Window
        Me.txtPurpose.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPurpose.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "PURPOSE", True))
        Me.txtPurpose.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPurpose.Location = New System.Drawing.Point(34, 56)
        Me.txtPurpose.MaxLength = 0
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPurpose.Size = New System.Drawing.Size(97, 20)
        Me.txtPurpose.TabIndex = 95
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdRptAll)
        Me.Frame9.Controls.Add(Me.cmdRptFound)
        Me.Frame9.Controls.Add(Me.cmdRptDoc)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(105, 76)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1137, 75)
        Me.Frame9.TabIndex = 58
        Me.Frame9.TabStop = False
        Me.Frame9.Text = " ’Ì‹‹‹€‹‹‹…  ‹‹ﬁ‹‹‹‹‹‹—Ì— (ÃœÊ·) "
        Me.Frame9.Visible = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(426, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 65
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
        Me.cmdLogout.Location = New System.Drawing.Point(277, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 64
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
        Me.cmdExit.Location = New System.Drawing.Point(128, 24)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdExit.Size = New System.Drawing.Size(129, 41)
        Me.cmdExit.TabIndex = 63
        Me.cmdExit.Text = "Œ‹‹‹‹‹‹‹‹‹—ÊÃ"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdRptAll
        '
        Me.cmdRptAll.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptAll.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptAll.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptAll.Location = New System.Drawing.Point(574, 24)
        Me.cmdRptAll.Name = "cmdRptAll"
        Me.cmdRptAll.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptAll.Size = New System.Drawing.Size(129, 41)
        Me.cmdRptAll.TabIndex = 61
        Me.cmdRptAll.Text = "ÿ»«⁄… «·ﬂ·"
        Me.cmdRptAll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptAll.UseVisualStyleBackColor = False
        '
        'cmdRptFound
        '
        Me.cmdRptFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptFound.Location = New System.Drawing.Point(723, 24)
        Me.cmdRptFound.Name = "cmdRptFound"
        Me.cmdRptFound.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptFound.Size = New System.Drawing.Size(145, 41)
        Me.cmdRptFound.TabIndex = 60
        Me.cmdRptFound.Text = "ÿ»«⁄… ‰ ÌÃ… «·»ÕÀ"
        Me.cmdRptFound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptFound.UseVisualStyleBackColor = False
        '
        'cmdRptDoc
        '
        Me.cmdRptDoc.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRptDoc.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRptDoc.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRptDoc.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdRptDoc.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRptDoc.Location = New System.Drawing.Point(888, 24)
        Me.cmdRptDoc.Name = "cmdRptDoc"
        Me.cmdRptDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRptDoc.Size = New System.Drawing.Size(129, 41)
        Me.cmdRptDoc.TabIndex = 59
        Me.cmdRptDoc.Text = "ÿ»«⁄… «· ’—ÌÕ"
        Me.cmdRptDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRptDoc.UseVisualStyleBackColor = False
        '
        'Frame2
        '
        Me.Frame2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame2.Controls.Add(Me.txtSenderAddress)
        Me.Frame2.Controls.Add(Me.cmbSender)
        Me.Frame2.Controls.Add(Me.cmbReceiver)
        Me.Frame2.Controls.Add(Me.Frame10)
        Me.Frame2.Controls.Add(Me.Frame6)
        Me.Frame2.Controls.Add(Me.txtReceiverAddress)
        Me.Frame2.Controls.Add(Me.Label6)
        Me.Frame2.Controls.Add(Me.Label2)
        Me.Frame2.Controls.Add(Me.Label8)
        Me.Frame2.Controls.Add(Me.Label5)
        Me.Frame2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame2.Location = New System.Drawing.Point(105, 226)
        Me.Frame2.Name = "Frame2"
        Me.Frame2.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame2.Size = New System.Drawing.Size(641, 314)
        Me.Frame2.TabIndex = 32
        Me.Frame2.TabStop = False
        Me.Frame2.Text = "  »Ì«‰«   —ÕÌ· «·„›—ﬁ⁄«   "
        '
        'txtSenderAddress
        '
        Me.txtSenderAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenderAddress.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtSenderAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "SENDERADDRESS", True))
        Me.txtSenderAddress.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "SENDERADDRESS", True))
        Me.txtSenderAddress.DataSource = Me.SenderAddressBindingSource1
        Me.txtSenderAddress.DisplayMember = "SENDERADDRESS"
        Me.txtSenderAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenderAddress.Location = New System.Drawing.Point(8, 24)
        Me.txtSenderAddress.Name = "txtSenderAddress"
        Me.txtSenderAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSenderAddress.Size = New System.Drawing.Size(257, 21)
        Me.txtSenderAddress.TabIndex = 93
        Me.txtSenderAddress.ValueMember = "SENDERADDRESS"
        '
        'SenderAddressBindingSource1
        '
        Me.SenderAddressBindingSource1.DataMember = "PERMISSIONS"
        Me.SenderAddressBindingSource1.DataSource = Me.SenderAddressDsExplosives1
        '
        'SenderAddressDsExplosives1
        '
        Me.SenderAddressDsExplosives1.DataSetName = "dsExplosives"
        Me.SenderAddressDsExplosives1.EnforceConstraints = False
        Me.SenderAddressDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbSender
        '
        Me.cmbSender.AcceptsReturn = True
        Me.cmbSender.BackColor = System.Drawing.SystemColors.Window
        Me.cmbSender.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbSender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "SENDER", True))
        Me.cmbSender.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSender.Location = New System.Drawing.Point(328, 24)
        Me.cmbSender.MaxLength = 0
        Me.cmbSender.Multiline = True
        Me.cmbSender.Name = "cmbSender"
        Me.cmbSender.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbSender.Size = New System.Drawing.Size(225, 25)
        Me.cmbSender.TabIndex = 83
        '
        'cmbReceiver
        '
        Me.cmbReceiver.AcceptsReturn = True
        Me.cmbReceiver.BackColor = System.Drawing.SystemColors.Window
        Me.cmbReceiver.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.cmbReceiver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "RECEIVER", True))
        Me.cmbReceiver.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbReceiver.Location = New System.Drawing.Point(328, 56)
        Me.cmbReceiver.MaxLength = 0
        Me.cmbReceiver.Multiline = True
        Me.cmbReceiver.Name = "cmbReceiver"
        Me.cmbReceiver.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbReceiver.Size = New System.Drawing.Size(225, 25)
        Me.cmbReceiver.TabIndex = 82
        '
        'Frame10
        '
        Me.Frame10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame10.Controls.Add(Me.txtToStore)
        Me.Frame10.Controls.Add(Me.txtPurpose)
        Me.Frame10.Controls.Add(Me.dtpStoreDate)
        Me.Frame10.Controls.Add(Me.txtStoreID)
        Me.Frame10.Controls.Add(Me.Label23)
        Me.Frame10.Controls.Add(Me.Label19)
        Me.Frame10.Controls.Add(Me.Label18)
        Me.Frame10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame10.Location = New System.Drawing.Point(8, 208)
        Me.Frame10.Name = "Frame10"
        Me.Frame10.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame10.Size = New System.Drawing.Size(625, 89)
        Me.Frame10.TabIndex = 48
        Me.Frame10.TabStop = False
        Me.Frame10.Text = "   »Ì«‰«  «· Œ“Ì‹‰   "
        '
        'txtToStore
        '
        Me.txtToStore.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "TOSTORE", True))
        Me.txtToStore.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "TOSTORE", True))
        Me.txtToStore.DataSource = Me.ToStoreBindingSource1
        Me.txtToStore.DisplayMember = "TOSTORE"
        Me.txtToStore.FormattingEnabled = True
        Me.txtToStore.Location = New System.Drawing.Point(34, 21)
        Me.txtToStore.Name = "txtToStore"
        Me.txtToStore.Size = New System.Drawing.Size(440, 21)
        Me.txtToStore.TabIndex = 56
        Me.txtToStore.ValueMember = "TOSTORE"
        '
        'ToStoreBindingSource1
        '
        Me.ToStoreBindingSource1.DataMember = "PERMISSIONS"
        Me.ToStoreBindingSource1.DataSource = Me.ToStoreDsExplosives1
        '
        'ToStoreDsExplosives1
        '
        Me.ToStoreDsExplosives1.DataSetName = "dsExplosives"
        Me.ToStoreDsExplosives1.EnforceConstraints = False
        Me.ToStoreDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpStoreDate
        '
        Me.dtpStoreDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERMISSIONSBindingSource, "STOREDATE", True))
        Me.dtpStoreDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStoreDate.Location = New System.Drawing.Point(172, 53)
        Me.dtpStoreDate.Name = "dtpStoreDate"
        Me.dtpStoreDate.RightToLeftLayout = True
        Me.dtpStoreDate.Size = New System.Drawing.Size(85, 20)
        Me.dtpStoreDate.TabIndex = 55
        '
        'txtStoreID
        '
        Me.txtStoreID.AcceptsReturn = True
        Me.txtStoreID.BackColor = System.Drawing.SystemColors.Window
        Me.txtStoreID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStoreID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "STOREID", True))
        Me.txtStoreID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStoreID.Location = New System.Drawing.Point(320, 48)
        Me.txtStoreID.MaxLength = 0
        Me.txtStoreID.Multiline = True
        Me.txtStoreID.Name = "txtStoreID"
        Me.txtStoreID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtStoreID.Size = New System.Drawing.Size(225, 25)
        Me.txtStoreID.TabIndex = 52
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(263, 57)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(49, 17)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = " «—ÌŒÂ«"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(552, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(65, 33)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "‰„—… —Œ’… «·Œ“‰…"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label18.Location = New System.Drawing.Point(480, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(137, 17)
        Me.Label18.TabIndex = 50
        Me.Label18.Text = "«·„›—ﬁ⁄«  „‰ﬁÊ·… ·· Œ“Ì‰ ›Ì "
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.txtIsImport)
        Me.Frame6.Controls.Add(Me.cmbBy)
        Me.Frame6.Controls.Add(Me.txtPoint3)
        Me.Frame6.Controls.Add(Me.txtPoint2)
        Me.Frame6.Controls.Add(Me.txtPoint1)
        Me.Frame6.Controls.Add(Me.Label17)
        Me.Frame6.Controls.Add(Me.Label10)
        Me.Frame6.Controls.Add(Me.Label9)
        Me.Frame6.Controls.Add(Me.Label7)
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(8, 88)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(625, 105)
        Me.Frame6.TabIndex = 39
        Me.Frame6.TabStop = False
        Me.Frame6.Text = "    Œÿ «·”Ì‹‹‹‹‹—   "
        '
        'txtIsImport
        '
        Me.txtIsImport.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "IsImport", True))
        Me.txtIsImport.Location = New System.Drawing.Point(178, 65)
        Me.txtIsImport.Name = "txtIsImport"
        Me.txtIsImport.Size = New System.Drawing.Size(100, 20)
        Me.txtIsImport.TabIndex = 91
        Me.txtIsImport.Text = "IsDistract"
        Me.txtIsImport.Visible = False
        '
        'cmbBy
        '
        Me.cmbBy.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "TRANSPORTEDBY", True))
        Me.cmbBy.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "TRANSPORTEDBY", True))
        Me.cmbBy.DataSource = Me.TransportByPERMISSIONSBindingSource4
        Me.cmbBy.DisplayMember = "TRANSPORTEDBY"
        Me.cmbBy.FormattingEnabled = True
        Me.cmbBy.Location = New System.Drawing.Point(408, 65)
        Me.cmbBy.Name = "cmbBy"
        Me.cmbBy.Size = New System.Drawing.Size(137, 21)
        Me.cmbBy.TabIndex = 90
        Me.cmbBy.ValueMember = "TRANSPORTEDBY"
        '
        'TransportByPERMISSIONSBindingSource4
        '
        Me.TransportByPERMISSIONSBindingSource4.DataMember = "PERMISSIONS"
        Me.TransportByPERMISSIONSBindingSource4.DataSource = Me.TransportByDsExplosives1
        '
        'TransportByDsExplosives1
        '
        Me.TransportByDsExplosives1.DataSetName = "dsExplosives"
        Me.TransportByDsExplosives1.EnforceConstraints = False
        Me.TransportByDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtPoint3
        '
        Me.txtPoint3.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint3.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPoint3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "POINT3", True))
        Me.txtPoint3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "POINT3", True))
        Me.txtPoint3.DataSource = Me.Point3PassCopiesBindingSource2
        Me.txtPoint3.DisplayMember = "Point3"
        Me.txtPoint3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint3.Location = New System.Drawing.Point(8, 24)
        Me.txtPoint3.Name = "txtPoint3"
        Me.txtPoint3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint3.Size = New System.Drawing.Size(161, 21)
        Me.txtPoint3.TabIndex = 89
        Me.txtPoint3.ValueMember = "Point3"
        '
        'Point3PassCopiesBindingSource2
        '
        Me.Point3PassCopiesBindingSource2.DataMember = "PassCopies"
        Me.Point3PassCopiesBindingSource2.DataSource = Me.Point3DsExplosives1
        '
        'txtPoint2
        '
        Me.txtPoint2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint2.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPoint2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "POINT2", True))
        Me.txtPoint2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "POINT2", True))
        Me.txtPoint2.DataSource = Me.Point2PassCopiesBindingSource1
        Me.txtPoint2.DisplayMember = "Point2"
        Me.txtPoint2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint2.Location = New System.Drawing.Point(216, 24)
        Me.txtPoint2.Name = "txtPoint2"
        Me.txtPoint2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint2.Size = New System.Drawing.Size(153, 21)
        Me.txtPoint2.TabIndex = 88
        Me.txtPoint2.ValueMember = "Point2"
        '
        'Point2PassCopiesBindingSource1
        '
        Me.Point2PassCopiesBindingSource1.DataMember = "PassCopies"
        Me.Point2PassCopiesBindingSource1.DataSource = Me.Point2DsExplosives1
        '
        'txtPoint1
        '
        Me.txtPoint1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint1.Cursor = System.Windows.Forms.Cursors.Default
        Me.txtPoint1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "POINT1", True))
        Me.txtPoint1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.PERMISSIONSBindingSource, "POINT1", True))
        Me.txtPoint1.DataSource = Me.Point1PassCopiesBindingSource
        Me.txtPoint1.DisplayMember = "Point1"
        Me.txtPoint1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint1.Location = New System.Drawing.Point(408, 24)
        Me.txtPoint1.Name = "txtPoint1"
        Me.txtPoint1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint1.Size = New System.Drawing.Size(137, 21)
        Me.txtPoint1.TabIndex = 87
        Me.txtPoint1.ValueMember = "Point1"
        '
        'Point1PassCopiesBindingSource
        '
        Me.Point1PassCopiesBindingSource.DataMember = "PassCopies"
        Me.Point1PassCopiesBindingSource.DataSource = Me.Point1DsExplosives1
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(560, 72)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(41, 17)
        Me.Label17.TabIndex = 43
        Me.Label17.Text = "»‹‹‹‹ "
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(179, 32)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "3"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(384, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(568, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtReceiverAddress
        '
        Me.txtReceiverAddress.AcceptsReturn = True
        Me.txtReceiverAddress.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceiverAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceiverAddress.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "RECEIVERADDRESS", True))
        Me.txtReceiverAddress.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceiverAddress.Location = New System.Drawing.Point(8, 56)
        Me.txtReceiverAddress.MaxLength = 0
        Me.txtReceiverAddress.Multiline = True
        Me.txtReceiverAddress.Name = "txtReceiverAddress"
        Me.txtReceiverAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtReceiverAddress.Size = New System.Drawing.Size(257, 25)
        Me.txtReceiverAddress.TabIndex = 33
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(272, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(33, 17)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "⁄‰Ê«‰Â"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(272, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(33, 17)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "⁄‰Ê«‰Â"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(560, 64)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "«·„—”· ≈·ÌÂ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(560, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "«·„—”· „‰‹‹Â"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame8
        '
        Me.Frame8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame8.Controls.Add(Me.cmdCancel)
        Me.Frame8.Controls.Add(Me.cmdDelete)
        Me.Frame8.Controls.Add(Me.cmdSave)
        Me.Frame8.Controls.Add(Me.cmdNew)
        Me.Frame8.Controls.Add(Me.cmdEdit)
        Me.Frame8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame8.Location = New System.Drawing.Point(745, 630)
        Me.Frame8.Name = "Frame8"
        Me.Frame8.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame8.Size = New System.Drawing.Size(497, 73)
        Me.Frame8.TabIndex = 26
        Me.Frame8.TabStop = False
        Me.Frame8.Text = " ⁄„·Ì«  ⁄·Ï «·”Ã·«  "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(9, 22)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(89, 33)
        Me.cmdCancel.TabIndex = 28
        Me.cmdCancel.Text = "≈·‹‹‹‹‹€‹‹‹‹«¡"
        Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdCancel.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(101, 22)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(89, 33)
        Me.cmdDelete.TabIndex = 29
        Me.cmdDelete.Text = "Õ‹‹–›"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.Enabled = False
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdSave.Location = New System.Drawing.Point(297, 22)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(89, 33)
        Me.cmdSave.TabIndex = 31
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
        Me.cmdNew.Location = New System.Drawing.Point(393, 22)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(89, 33)
        Me.cmdNew.TabIndex = 30
        Me.cmdNew.Text = "Ã‹‹œÌ‹‹œ"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(200, 22)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(89, 33)
        Me.cmdEdit.TabIndex = 27
        Me.cmdEdit.Text = " ‹⁄‹œÌ‹·"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.DataGridView1)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(393, 540)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(353, 163)
        Me.Frame5.TabIndex = 25
        Me.Frame5.TabStop = False
        Me.Frame5.Text = "   »Ì«‰«  «·„›—ﬁ⁄«    "
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Unit, Me.Quantity})
        Me.DataGridView1.Location = New System.Drawing.Point(13, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(333, 115)
        Me.DataGridView1.TabIndex = 0
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.FillWeight = 130.0!
        Me.Description.HeaderText = "«·Ê’›"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.FillWeight = 70.0!
        Me.Unit.HeaderText = "«·ÊÕœ…"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "«·ﬂ„Ì…"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'PermissionDetailsBindingSource
        '
        Me.PermissionDetailsBindingSource.DataMember = "PermissionDetails"
        Me.PermissionDetailsBindingSource.DataSource = Me.DsExplosives
        '
        'Frame3
        '
        Me.Frame3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame3.Controls.Add(Me.cmbDuration)
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.cmbCriteria)
        Me.Frame3.Controls.Add(Me.txtDate2)
        Me.Frame3.Controls.Add(Me.cmdFindPrev)
        Me.Frame3.Controls.Add(Me.cmdFindNext)
        Me.Frame3.Controls.Add(Me.txtDate1)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.Controls.Add(Me.Label13)
        Me.Frame3.Controls.Add(Me.Label14)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(746, 436)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(497, 121)
        Me.Frame3.TabIndex = 16
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " «·»‹Õ‹À ⁄‹‰ ”‹Ã‹· "
        '
        'cmbDuration
        '
        Me.cmbDuration.BackColor = System.Drawing.SystemColors.Window
        Me.cmbDuration.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDuration.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDuration.Items.AddRange(New Object() {"⁄«„", "› —… » «—ÌŒ «·„·›", "› —… » «—ÌŒ «·Œÿ«»"})
        Me.cmbDuration.Location = New System.Drawing.Point(296, 56)
        Me.cmbDuration.Name = "cmbDuration"
        Me.cmbDuration.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbDuration.Size = New System.Drawing.Size(177, 21)
        Me.cmbDuration.TabIndex = 77
        '
        'txtFind
        '
        Me.txtFind.AcceptsReturn = True
        Me.txtFind.BackColor = System.Drawing.SystemColors.Window
        Me.txtFind.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFind.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFind.Location = New System.Drawing.Point(33, 24)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(233, 25)
        Me.txtFind.TabIndex = 22
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"⁄«„", "‰„—… «·„·›", " «—ÌŒ «·„·›", "‰„—… „” ‰œ «·’—›", "«”„ «·ÃÂ… «·„—”·…", "«”„ «·ÃÂ… «·„” ﬁ»·…", "› —…  «—ÌŒÌ… » «—ÌŒ «·„·›"})
        Me.cmbCriteria.Location = New System.Drawing.Point(296, 24)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbCriteria.Size = New System.Drawing.Size(177, 21)
        Me.cmbCriteria.TabIndex = 21
        '
        'txtDate2
        '
        Me.txtDate2.AcceptsReturn = True
        Me.txtDate2.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate2.Location = New System.Drawing.Point(33, 56)
        Me.txtDate2.MaxLength = 0
        Me.txtDate2.Name = "txtDate2"
        Me.txtDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate2.Size = New System.Drawing.Size(89, 20)
        Me.txtDate2.TabIndex = 20
        Me.txtDate2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdFindPrev
        '
        Me.cmdFindPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindPrev.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindPrev.Location = New System.Drawing.Point(8, 24)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindPrev.TabIndex = 19
        Me.cmdFindPrev.Text = ">"
        Me.cmdFindPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindPrev.UseVisualStyleBackColor = False
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindNext.Location = New System.Drawing.Point(275, 24)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(17, 57)
        Me.cmdFindNext.TabIndex = 18
        Me.cmdFindNext.Text = "<"
        Me.cmdFindNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFindNext.UseVisualStyleBackColor = False
        '
        'txtDate1
        '
        Me.txtDate1.AcceptsReturn = True
        Me.txtDate1.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDate1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDate1.Location = New System.Drawing.Point(161, 56)
        Me.txtDate1.MaxLength = 0
        Me.txtDate1.Name = "txtDate1"
        Me.txtDate1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDate1.Size = New System.Drawing.Size(89, 20)
        Me.txtDate1.TabIndex = 17
        Me.txtDate1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPosition.Location = New System.Drawing.Point(32, 89)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(233, 25)
        Me.lblPosition.TabIndex = 62
        Me.lblPosition.Text = "******************"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(253, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(21, 13)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "„‰"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(120, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(25, 17)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "≈·Ï"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame4.Controls.Add(Me.dtpTo)
        Me.Frame4.Controls.Add(Me.dtpFrom)
        Me.Frame4.Controls.Add(Me.Label20)
        Me.Frame4.Controls.Add(Me.Label22)
        Me.Frame4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame4.Location = New System.Drawing.Point(746, 379)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame4.Size = New System.Drawing.Size(497, 57)
        Me.Frame4.TabIndex = 11
        Me.Frame4.TabStop = False
        Me.Frame4.Text = "   »Ì«‰«  ”—Ì«‰ „›⁄Ê· «· —ŒÌ’  "
        '
        'dtpTo
        '
        Me.dtpTo.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERMISSIONSBindingSource, "FTO", True))
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(8, 26)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.RightToLeftLayout = True
        Me.dtpTo.Size = New System.Drawing.Size(177, 20)
        Me.dtpTo.TabIndex = 55
        '
        'dtpFrom
        '
        Me.dtpFrom.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERMISSIONSBindingSource, "FFROM", True))
        Me.dtpFrom.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "FFROM", True))
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(262, 26)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.RightToLeftLayout = True
        Me.dtpFrom.Size = New System.Drawing.Size(171, 20)
        Me.dtpFrom.TabIndex = 55
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(424, 32)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 17)
        Me.Label20.TabIndex = 15
        Me.Label20.Text = "„‰"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(176, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 17)
        Me.Label22.TabIndex = 14
        Me.Label22.Text = "≈·‹‹‹Ï"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.dtpDate)
        Me.Frame1.Controls.Add(Me.cmbYear)
        Me.Frame1.Controls.Add(Me.cmdInsertExplosives)
        Me.Frame1.Controls.Add(Me.txtWorkID)
        Me.Frame1.Controls.Add(Me.cmdGetPass)
        Me.Frame1.Controls.Add(Me.cmdDistract)
        Me.Frame1.Controls.Add(Me.txtfID)
        Me.Frame1.Controls.Add(Me.txtLicenseID)
        Me.Frame1.Controls.Add(Me.txtPassPermissionNo)
        Me.Frame1.Controls.Add(Me.txtID)
        Me.Frame1.Controls.Add(Me.txtPlace)
        Me.Frame1.Controls.Add(Me.lblWorkID)
        Me.Frame1.Controls.Add(Me.lblfID)
        Me.Frame1.Controls.Add(Me.Label16)
        Me.Frame1.Controls.Add(Me.Label1)
        Me.Frame1.Controls.Add(Me.Label21)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(746, 226)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(497, 153)
        Me.Frame1.TabIndex = 5
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "  »Ì«‰«  „·› «·≈–‰ "
        '
        'dtpDate
        '
        Me.dtpDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PERMISSIONSBindingSource, "FDATE", True))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(256, 122)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.RightToLeftLayout = True
        Me.dtpDate.Size = New System.Drawing.Size(169, 20)
        Me.dtpDate.TabIndex = 95
        '
        'cmbYear
        '
        Me.cmbYear.BackColor = System.Drawing.SystemColors.Window
        Me.cmbYear.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbYear.Location = New System.Drawing.Point(360, 56)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbYear.Size = New System.Drawing.Size(65, 21)
        Me.cmbYear.TabIndex = 94
        '
        'cmdInsertExplosives
        '
        Me.cmdInsertExplosives.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdInsertExplosives.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdInsertExplosives.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInsertExplosives.Enabled = False
        Me.cmdInsertExplosives.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdInsertExplosives.Location = New System.Drawing.Point(126, 16)
        Me.cmdInsertExplosives.Name = "cmdInsertExplosives"
        Me.cmdInsertExplosives.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdInsertExplosives.Size = New System.Drawing.Size(113, 33)
        Me.cmdInsertExplosives.TabIndex = 92
        Me.cmdInsertExplosives.Text = "≈œŒ«· «·„Ê«œ"
        Me.cmdInsertExplosives.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdInsertExplosives.UseVisualStyleBackColor = False
        Me.cmdInsertExplosives.Visible = False
        '
        'txtWorkID
        '
        Me.txtWorkID.AcceptsReturn = True
        Me.txtWorkID.BackColor = System.Drawing.SystemColors.Window
        Me.txtWorkID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWorkID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtWorkID.Location = New System.Drawing.Point(8, 56)
        Me.txtWorkID.MaxLength = 0
        Me.txtWorkID.Multiline = True
        Me.txtWorkID.Name = "txtWorkID"
        Me.txtWorkID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtWorkID.Size = New System.Drawing.Size(121, 25)
        Me.txtWorkID.TabIndex = 81
        '
        'cmdGetPass
        '
        Me.cmdGetPass.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdGetPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdGetPass.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdGetPass.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdGetPass.Location = New System.Drawing.Point(8, 16)
        Me.cmdGetPass.Name = "cmdGetPass"
        Me.cmdGetPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdGetPass.Size = New System.Drawing.Size(113, 33)
        Me.cmdGetPass.TabIndex = 79
        Me.cmdGetPass.Text = "«” Œ—«Ã  ’—ÌÕ Œ—ÊÃ"
        Me.cmdGetPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdGetPass.UseVisualStyleBackColor = False
        Me.cmdGetPass.Visible = False
        '
        'cmdDistract
        '
        Me.cmdDistract.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDistract.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDistract.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDistract.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDistract.Location = New System.Drawing.Point(128, 16)
        Me.cmdDistract.Name = "cmdDistract"
        Me.cmdDistract.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDistract.Size = New System.Drawing.Size(113, 33)
        Me.cmdDistract.TabIndex = 57
        Me.cmdDistract.Text = "«” Œ—«Ã „” ‰œ ’—›"
        Me.cmdDistract.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDistract.UseVisualStyleBackColor = False
        '
        'txtfID
        '
        Me.txtfID.AcceptsReturn = True
        Me.txtfID.BackColor = System.Drawing.SystemColors.Window
        Me.txtfID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtfID.Location = New System.Drawing.Point(256, 56)
        Me.txtfID.MaxLength = 0
        Me.txtfID.Multiline = True
        Me.txtfID.Name = "txtfID"
        Me.txtfID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtfID.Size = New System.Drawing.Size(97, 25)
        Me.txtfID.TabIndex = 55
        '
        'txtLicenseID
        '
        Me.txtLicenseID.AcceptsReturn = True
        Me.txtLicenseID.BackColor = System.Drawing.SystemColors.Window
        Me.txtLicenseID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLicenseID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "LICENSEID", True))
        Me.txtLicenseID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLicenseID.Location = New System.Drawing.Point(8, 120)
        Me.txtLicenseID.MaxLength = 0
        Me.txtLicenseID.Multiline = True
        Me.txtLicenseID.Name = "txtLicenseID"
        Me.txtLicenseID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLicenseID.Size = New System.Drawing.Size(177, 25)
        Me.txtLicenseID.TabIndex = 46
        Me.txtLicenseID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPassPermissionNo
        '
        Me.txtPassPermissionNo.AcceptsReturn = True
        Me.txtPassPermissionNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassPermissionNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassPermissionNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "PassPermissionNo", True))
        Me.txtPassPermissionNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassPermissionNo.Location = New System.Drawing.Point(231, 89)
        Me.txtPassPermissionNo.MaxLength = 0
        Me.txtPassPermissionNo.Multiline = True
        Me.txtPassPermissionNo.Name = "txtPassPermissionNo"
        Me.txtPassPermissionNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPassPermissionNo.Size = New System.Drawing.Size(65, 25)
        Me.txtPassPermissionNo.TabIndex = 7
        Me.txtPassPermissionNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtID
        '
        Me.txtID.AcceptsReturn = True
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "ID", True))
        Me.txtID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtID.Location = New System.Drawing.Point(360, 88)
        Me.txtID.MaxLength = 0
        Me.txtID.Multiline = True
        Me.txtID.Name = "txtID"
        Me.txtID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtID.Size = New System.Drawing.Size(65, 25)
        Me.txtID.TabIndex = 7
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPlace
        '
        Me.txtPlace.AcceptsReturn = True
        Me.txtPlace.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlace.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPlace.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PERMISSIONSBindingSource, "PLACE", True))
        Me.txtPlace.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPlace.Location = New System.Drawing.Point(8, 88)
        Me.txtPlace.MaxLength = 0
        Me.txtPlace.Multiline = True
        Me.txtPlace.Name = "txtPlace"
        Me.txtPlace.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPlace.Size = New System.Drawing.Size(177, 25)
        Me.txtPlace.TabIndex = 6
        Me.txtPlace.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWorkID
        '
        Me.lblWorkID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblWorkID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblWorkID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblWorkID.Location = New System.Drawing.Point(123, 56)
        Me.lblWorkID.Name = "lblWorkID"
        Me.lblWorkID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblWorkID.Size = New System.Drawing.Size(118, 25)
        Me.lblWorkID.TabIndex = 80
        Me.lblWorkID.Text = "‰„—… ≈–‰ «·«” Œœ«„"
        Me.lblWorkID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblfID
        '
        Me.lblfID.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblfID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblfID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblfID.Location = New System.Drawing.Point(424, 56)
        Me.lblfID.Name = "lblfID"
        Me.lblfID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblfID.Size = New System.Drawing.Size(73, 33)
        Me.lblfID.TabIndex = 56
        Me.lblfID.Text = "‰„—… „” ‰œ «·’—›"
        Me.lblfID.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(184, 122)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(78, 23)
        Me.Label16.TabIndex = 47
        Me.Label16.Text = "‰„—… «· —ŒÌ’"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(192, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(41, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "«·„ﬂ«‰"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(291, 96)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(65, 25)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "‰„—… «·„·›"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(432, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "«· «—ÌŒ"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(424, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "«· ”·”·Ì"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(746, 557)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(497, 73)
        Me.Frame7.TabIndex = 0
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " «· ‰ﬁ· »Ì‰ «·”Ã·«  "
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(56, 24)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(89, 33)
        Me.cmdFirst.TabIndex = 4
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
        Me.cmdLast.Location = New System.Drawing.Point(344, 24)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(89, 33)
        Me.cmdLast.TabIndex = 3
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
        Me.cmdPrev.Location = New System.Drawing.Point(152, 24)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(89, 33)
        Me.cmdPrev.TabIndex = 2
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
        Me.cmdNext.Location = New System.Drawing.Point(248, 24)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(89, 33)
        Me.cmdNext.TabIndex = 1
        Me.cmdNext.Text = "< «· ‹‹«·Ì"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'PermissionDetailsTableAdapter
        '
        Me.PermissionDetailsTableAdapter.ClearBeforeFill = True
        '
        'PERMISSIONSTableAdapter
        '
        Me.PERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'PassCopiesTableAdapter
        '
        Me.PassCopiesTableAdapter.ClearBeforeFill = True
        '
        'TransportByBindingSource1
        '
        Me.TransportByBindingSource1.DataMember = "PERMISSIONS"
        Me.TransportByBindingSource1.DataSource = Me.TransportByDsExplosives1
        '
        'frmPassPermissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1333, 734)
        Me.Controls.Add(Me.optImport)
        Me.Controls.Add(Me.optDistract)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame12)
        Me.Controls.Add(Me.Frame11)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame2)
        Me.Controls.Add(Me.Frame8)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmPassPermissions"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = " ’‹‹‹‹‹‹‹«—ÌÕ «·„‹‹‹‹‹‹‹‹—Ê—"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISSIONSBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point3DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISSIONSBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point2DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PERMISSIONSBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point1DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame11.ResumeLayout(False)
        Me.Frame9.ResumeLayout(False)
        Me.Frame2.ResumeLayout(False)
        Me.Frame2.PerformLayout()
        CType(Me.SenderAddressBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderAddressDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame10.ResumeLayout(False)
        Me.Frame10.PerformLayout()
        CType(Me.ToStoreBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToStoreDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame6.ResumeLayout(False)
        Me.Frame6.PerformLayout()
        CType(Me.TransportByPERMISSIONSBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TransportByDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point3PassCopiesBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point2PassCopiesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Point1PassCopiesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame8.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        CType(Me.TransportByBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents PermissionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PermissionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.PermissionDetailsTableAdapter
    Friend WithEvents PERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter
    Friend WithEvents dtpStoreDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents PERMISSIONSBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISSIONSBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISSIONSBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Point1DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Point2DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Point3DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents cmbBy As System.Windows.Forms.ComboBox
    Friend WithEvents Point1PassCopiesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassCopiesTableAdapter As Explosives.dsExplosivesTableAdapters.PassCopiesTableAdapter
    Friend WithEvents Point3PassCopiesBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Point2PassCopiesBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TransportByPERMISSIONSBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TransportByBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TransportByDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents NameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PositionDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents RankBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtToStore As System.Windows.Forms.ComboBox
    Friend WithEvents ToStoreBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ToStoreDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents btnMovementForm As System.Windows.Forms.Button
    Public WithEvents txtPassPermissionNo As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txtWorkID As System.Windows.Forms.TextBox
    Friend WithEvents SenderAddressBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SenderAddressDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents txtIsImport As System.Windows.Forms.TextBox
#End Region
End Class