<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMovementForms
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
    Public WithEvents txtMovementFormID As System.Windows.Forms.TextBox
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
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdPrintDoc = New System.Windows.Forms.CheckBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.txtReceiver = New System.Windows.Forms.ComboBox()
        Me.MovementFormsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.ReceiverBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiverDsExplosives1 = New Explosives.dsExplosives()
        Me.txtSender = New System.Windows.Forms.ComboBox()
        Me.SenderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SenderDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbGuard1 = New System.Windows.Forms.ComboBox()
        Me.Guard1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Guard1DsExplosives1 = New Explosives.dsExplosives()
        Me.cmbCommander = New System.Windows.Forms.ComboBox()
        Me.CommanderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommanderDsExplosives1 = New Explosives.dsExplosives()
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceiverLocation = New System.Windows.Forms.TextBox()
        Me.txtSenderLocation = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMovmentFormsNo = New System.Windows.Forms.TextBox()
        Me.txtMovementFormID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
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
        Me.cmbUnit = New System.Windows.Forms.ComboBox()
        Me.nudQuantity = New System.Windows.Forms.NumericUpDown()
        Me.cmbClass = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.Frame12 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.Position1BindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Position1DsExplosives3 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Name1BindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name1DsExplosives2 = New Explosives.dsExplosives()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.Rank1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rank1DsExplosives1 = New Explosives.dsExplosives()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition2 = New System.Windows.Forms.ComboBox()
        Me.Position2BindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Position2DsExplosives6 = New Explosives.dsExplosives()
        Me.cmbName2 = New System.Windows.Forms.ComboBox()
        Me.Name2BindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name2DsExplosives5 = New Explosives.dsExplosives()
        Me.cmbRank2 = New System.Windows.Forms.ComboBox()
        Me.Rank2BindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rank2DsExplosives4 = New Explosives.dsExplosives()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition3 = New System.Windows.Forms.ComboBox()
        Me.Position3BindingSource9 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Position3DsExplosives9 = New Explosives.dsExplosives()
        Me.cmbName3 = New System.Windows.Forms.ComboBox()
        Me.Name3BindingSource8 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Name3DsExplosives8 = New Explosives.dsExplosives()
        Me.cmbRank3 = New System.Windows.Forms.ComboBox()
        Me.Rank3BindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Rank3DsExplosives7 = New Explosives.dsExplosives()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.MovementFormsTableAdapter = New Explosives.dsExplosivesTableAdapters.MovementFormsTableAdapter()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbBy = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtPoint3 = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtPoint2 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtPoint1 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.MainMenu1.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.MovementFormsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guard1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guard1DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommanderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommanderDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame12.SuspendLayout()
        CType(Me.Position1BindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Position1DsExplosives3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name1BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name1DsExplosives2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank1DsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Position2BindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Position2DsExplosives6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name2BindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name2DsExplosives5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank2BindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank2DsExplosives4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Position3BindingSource9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Position3DsExplosives9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name3BindingSource8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Name3DsExplosives8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank3BindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rank3DsExplosives7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(328, 24)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(21, 25)
        Me.cmdPlus.TabIndex = 75
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdPlus, "إضافة")
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemove.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRemove.Location = New System.Drawing.Point(307, 25)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(25, 24)
        Me.cmdRemove.TabIndex = 76
        Me.cmdRemove.Text = "-"
        Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.cmdRemove, "إزالة")
        Me.cmdRemove.UseVisualStyleBackColor = False
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
        Me.mnuColours.Text = "ضبط الألوان"
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
        Me.cmdRefresh.Text = "تـــــــحــــديـــــــث البيـــــــانات"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdPrintDoc)
        Me.Frame9.Controls.Add(Me.Command1)
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
        Me.Frame9.Text = "  خــيــــــــــــارات  "
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
        Me.cmdReturn.Text = "رجـــــوع"
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
        Me.cmdPrintDoc.Text = "طباعة الاورنيك"
        Me.cmdPrintDoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrintDoc.UseVisualStyleBackColor = False
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(-47, 24)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command1.Size = New System.Drawing.Size(121, 41)
        Me.Command1.TabIndex = 40
        Me.Command1.Text = "Command1"
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
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
        Me.cmdFound.Text = "طباعة نتيجة البحث"
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
        Me.cmdPrintAll.Text = "طباعة الكل"
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
        Me.cmdExit.Text = "خـــــــــروج"
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
        Me.cmdLogout.Text = "تسجيل خروج"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.txtReceiver)
        Me.Frame5.Controls.Add(Me.txtSender)
        Me.Frame5.Controls.Add(Me.cmbGuard1)
        Me.Frame5.Controls.Add(Me.cmbCommander)
        Me.Frame5.Controls.Add(Me.dtpFDate)
        Me.Frame5.Controls.Add(Me.Label17)
        Me.Frame5.Controls.Add(Me.Label2)
        Me.Frame5.Controls.Add(Me.txtReceiverLocation)
        Me.Frame5.Controls.Add(Me.txtSenderLocation)
        Me.Frame5.Controls.Add(Me.Label1)
        Me.Frame5.Controls.Add(Me.Label16)
        Me.Frame5.Controls.Add(Me.txtMovmentFormsNo)
        Me.Frame5.Controls.Add(Me.txtMovementFormID)
        Me.Frame5.Controls.Add(Me.Label14)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label22)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(739, 179)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(473, 194)
        Me.Frame5.TabIndex = 28
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " بيانات الملف "
        '
        'txtReceiver
        '
        Me.txtReceiver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Receiver", True))
        Me.txtReceiver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Receiver", True))
        Me.txtReceiver.DataSource = Me.ReceiverBindingSource1
        Me.txtReceiver.DisplayMember = "Receiver"
        Me.txtReceiver.FormattingEnabled = True
        Me.txtReceiver.Location = New System.Drawing.Point(171, 89)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(206, 21)
        Me.txtReceiver.TabIndex = 37
        Me.txtReceiver.ValueMember = "Receiver"
        '
        'MovementFormsBindingSource
        '
        Me.MovementFormsBindingSource.DataMember = "MovementForms"
        Me.MovementFormsBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiverBindingSource1
        '
        Me.ReceiverBindingSource1.DataMember = "MovementForms"
        Me.ReceiverBindingSource1.DataSource = Me.ReceiverDsExplosives1
        '
        'ReceiverDsExplosives1
        '
        Me.ReceiverDsExplosives1.DataSetName = "dsExplosives"
        Me.ReceiverDsExplosives1.EnforceConstraints = False
        Me.ReceiverDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtSender
        '
        Me.txtSender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Sender", True))
        Me.txtSender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Sender", True))
        Me.txtSender.DataSource = Me.SenderBindingSource1
        Me.txtSender.DisplayMember = "Sender"
        Me.txtSender.FormattingEnabled = True
        Me.txtSender.Location = New System.Drawing.Point(171, 56)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(206, 21)
        Me.txtSender.TabIndex = 37
        Me.txtSender.ValueMember = "Sender"
        '
        'SenderBindingSource1
        '
        Me.SenderBindingSource1.DataMember = "MovementForms"
        Me.SenderBindingSource1.DataSource = Me.SenderDsExplosives1
        '
        'SenderDsExplosives1
        '
        Me.SenderDsExplosives1.DataSetName = "dsExplosives"
        Me.SenderDsExplosives1.EnforceConstraints = False
        Me.SenderDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbGuard1
        '
        Me.cmbGuard1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Guard1", True))
        Me.cmbGuard1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Guard1", True))
        Me.cmbGuard1.DataSource = Me.Guard1BindingSource1
        Me.cmbGuard1.DisplayMember = "Guard1"
        Me.cmbGuard1.FormattingEnabled = True
        Me.cmbGuard1.Location = New System.Drawing.Point(9, 157)
        Me.cmbGuard1.Name = "cmbGuard1"
        Me.cmbGuard1.Size = New System.Drawing.Size(369, 21)
        Me.cmbGuard1.TabIndex = 36
        Me.cmbGuard1.ValueMember = "Guard1"
        '
        'Guard1BindingSource1
        '
        Me.Guard1BindingSource1.DataMember = "MovementForms"
        Me.Guard1BindingSource1.DataSource = Me.Guard1DsExplosives1
        '
        'Guard1DsExplosives1
        '
        Me.Guard1DsExplosives1.DataSetName = "dsExplosives"
        Me.Guard1DsExplosives1.EnforceConstraints = False
        Me.Guard1DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCommander
        '
        Me.cmbCommander.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Commander", True))
        Me.cmbCommander.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Commander", True))
        Me.cmbCommander.DataSource = Me.CommanderBindingSource1
        Me.cmbCommander.DisplayMember = "Commander"
        Me.cmbCommander.FormattingEnabled = True
        Me.cmbCommander.Location = New System.Drawing.Point(8, 123)
        Me.cmbCommander.Name = "cmbCommander"
        Me.cmbCommander.Size = New System.Drawing.Size(369, 21)
        Me.cmbCommander.TabIndex = 36
        Me.cmbCommander.ValueMember = "Commander"
        '
        'CommanderBindingSource1
        '
        Me.CommanderBindingSource1.DataMember = "MovementForms"
        Me.CommanderBindingSource1.DataSource = Me.CommanderDsExplosives1
        '
        'CommanderDsExplosives1
        '
        Me.CommanderDsExplosives1.DataSetName = "dsExplosives"
        Me.CommanderDsExplosives1.EnforceConstraints = False
        Me.CommanderDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFDate
        '
        Me.dtpFDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MovementFormsBindingSource, "MovementDate", True))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFDate.Location = New System.Drawing.Point(8, 26)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.RightToLeftLayout = True
        Me.dtpFDate.Size = New System.Drawing.Size(105, 20)
        Me.dtpFDate.TabIndex = 35
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(379, 153)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(92, 25)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "الحراسة"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(378, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(92, 25)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "قائد المجموعة"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtReceiverLocation
        '
        Me.txtReceiverLocation.AcceptsReturn = True
        Me.txtReceiverLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtReceiverLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReceiverLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "ReceiverLocation", True))
        Me.txtReceiverLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtReceiverLocation.Location = New System.Drawing.Point(8, 86)
        Me.txtReceiverLocation.MaxLength = 0
        Me.txtReceiverLocation.Multiline = True
        Me.txtReceiverLocation.Name = "txtReceiverLocation"
        Me.txtReceiverLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtReceiverLocation.Size = New System.Drawing.Size(105, 25)
        Me.txtReceiverLocation.TabIndex = 33
        Me.txtReceiverLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSenderLocation
        '
        Me.txtSenderLocation.AcceptsReturn = True
        Me.txtSenderLocation.BackColor = System.Drawing.SystemColors.Window
        Me.txtSenderLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSenderLocation.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "SenderLocation", True))
        Me.txtSenderLocation.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSenderLocation.Location = New System.Drawing.Point(8, 52)
        Me.txtSenderLocation.MaxLength = 0
        Me.txtSenderLocation.Multiline = True
        Me.txtSenderLocation.Name = "txtSenderLocation"
        Me.txtSenderLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSenderLocation.Size = New System.Drawing.Size(105, 25)
        Me.txtSenderLocation.TabIndex = 33
        Me.txtSenderLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(378, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(92, 49)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "الجهة المرسل اليها"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label16.Location = New System.Drawing.Point(119, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(46, 23)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "الموقع"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtMovmentFormsNo
        '
        Me.txtMovmentFormsNo.AcceptsReturn = True
        Me.txtMovmentFormsNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtMovmentFormsNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMovmentFormsNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "MovementFormNo", True))
        Me.txtMovmentFormsNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMovmentFormsNo.Location = New System.Drawing.Point(171, 25)
        Me.txtMovmentFormsNo.MaxLength = 0
        Me.txtMovmentFormsNo.Multiline = True
        Me.txtMovmentFormsNo.Name = "txtMovmentFormsNo"
        Me.txtMovmentFormsNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMovmentFormsNo.Size = New System.Drawing.Size(62, 25)
        Me.txtMovmentFormsNo.TabIndex = 29
        Me.txtMovmentFormsNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMovementFormID
        '
        Me.txtMovementFormID.AcceptsReturn = True
        Me.txtMovementFormID.BackColor = System.Drawing.SystemColors.Window
        Me.txtMovementFormID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMovementFormID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "MovementFormID", True))
        Me.txtMovementFormID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMovementFormID.Location = New System.Drawing.Point(316, 25)
        Me.txtMovementFormID.MaxLength = 0
        Me.txtMovementFormID.Multiline = True
        Me.txtMovementFormID.Name = "txtMovementFormID"
        Me.txtMovementFormID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMovementFormID.Size = New System.Drawing.Size(62, 25)
        Me.txtMovementFormID.TabIndex = 29
        Me.txtMovementFormID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label14.Location = New System.Drawing.Point(119, 58)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(46, 23)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "الموقع"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(378, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(92, 49)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "الجهة المرسل منها"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label22.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label22.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label22.Location = New System.Drawing.Point(241, 29)
        Me.Label22.Name = "Label22"
        Me.Label22.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label22.Size = New System.Drawing.Size(65, 25)
        Me.Label22.TabIndex = 31
        Me.Label22.Text = "نمرة الملف"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(119, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "التاريخ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label15.Location = New System.Drawing.Point(386, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(65, 25)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "التسلسلي"
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
        Me.Frame3.Location = New System.Drawing.Point(741, 440)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(469, 79)
        Me.Frame3.TabIndex = 26
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " الـبــــحــــــث "
        '
        'cmbCriteria
        '
        Me.cmbCriteria.BackColor = System.Drawing.SystemColors.Window
        Me.cmbCriteria.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbCriteria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCriteria.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCriteria.Items.AddRange(New Object() {"عام", "نمرة الملف", "اسم الجهة", "العنوان"})
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
        Me.Frame7.Location = New System.Drawing.Point(740, 520)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(472, 62)
        Me.Frame7.TabIndex = 21
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " التنقل بين السجلات "
        '
        'cmdNext
        '
        Me.cmdNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNext.Location = New System.Drawing.Point(245, 14)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNext.Size = New System.Drawing.Size(81, 33)
        Me.cmdNext.TabIndex = 25
        Me.cmdNext.Text = "< التــــالي"
        Me.cmdNext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNext.UseVisualStyleBackColor = False
        '
        'cmdLast
        '
        Me.cmdLast.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdLast.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdLast.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdLast.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdLast.Location = New System.Drawing.Point(338, 14)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 24
        Me.cmdLast.Text = "<< الأخيـــر"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'cmdFirst
        '
        Me.cmdFirst.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFirst.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFirst.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFirst.Location = New System.Drawing.Point(42, 14)
        Me.cmdFirst.Name = "cmdFirst"
        Me.cmdFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFirst.Size = New System.Drawing.Size(81, 33)
        Me.cmdFirst.TabIndex = 23
        Me.cmdFirst.Text = "الأول >>"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
        '
        'cmdPrev
        '
        Me.cmdPrev.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPrev.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPrev.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPrev.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPrev.Location = New System.Drawing.Point(143, 14)
        Me.cmdPrev.Name = "cmdPrev"
        Me.cmdPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPrev.Size = New System.Drawing.Size(81, 33)
        Me.cmdPrev.TabIndex = 22
        Me.cmdPrev.Text = "الســــابق >"
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
        Me.Frame6.Location = New System.Drawing.Point(59, 505)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(681, 78)
        Me.Frame6.TabIndex = 16
        Me.Frame6.TabStop = False
        Me.Frame6.Text = " عمليات على السجلات "
        '
        'cmdCancel
        '
        Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(199, 30)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 37
        Me.cmdCancel.Text = "إلـــغــــاء"
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
        Me.cmdSave.Location = New System.Drawing.Point(373, 29)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdSave.Size = New System.Drawing.Size(81, 33)
        Me.cmdSave.TabIndex = 20
        Me.cmdSave.Text = "حـــفـــظ"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdNew
        '
        Me.cmdNew.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdNew.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdNew.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdNew.Location = New System.Drawing.Point(472, 30)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdNew.Size = New System.Drawing.Size(81, 33)
        Me.cmdNew.TabIndex = 19
        Me.cmdNew.Text = "جــديـــد"
        Me.cmdNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdNew.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.Enabled = False
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(112, 30)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdDelete.Size = New System.Drawing.Size(81, 33)
        Me.cmdDelete.TabIndex = 18
        Me.cmdDelete.Text = "حـــــذف"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdEdit
        '
        Me.cmdEdit.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdEdit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEdit.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdEdit.Location = New System.Drawing.Point(286, 30)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 17
        Me.cmdEdit.Text = "تـــعـــديل"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmdPlus)
        Me.Frame1.Controls.Add(Me.cmdRemove)
        Me.Frame1.Controls.Add(Me.cmbUnit)
        Me.Frame1.Controls.Add(Me.nudQuantity)
        Me.Frame1.Controls.Add(Me.cmbClass)
        Me.Frame1.Controls.Add(Me.DataGridView1)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(388, 307)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(352, 207)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "بيانات المفرقعات"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(79, 25)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(68, 21)
        Me.cmbUnit.TabIndex = 74
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(14, 26)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(59, 20)
        Me.nudQuantity.TabIndex = 73
        '
        'cmbClass
        '
        Me.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(159, 25)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(147, 21)
        Me.cmbClass.TabIndex = 72
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Description, Me.Unit, Me.Quantity, Me.Path})
        Me.DataGridView1.Location = New System.Drawing.Point(14, 52)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(333, 140)
        Me.DataGridView1.TabIndex = 1
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.FillWeight = 130.0!
        Me.Description.HeaderText = "الوصف"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.FillWeight = 70.0!
        Me.Unit.HeaderText = "الوحدة"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "الكمية"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Path
        '
        Me.Path.DataPropertyName = "Path"
        Me.Path.HeaderText = "المسار"
        Me.Path.Name = "Path"
        Me.Path.ReadOnly = True
        Me.Path.Visible = False
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame12.Controls.Add(Me.cmbPosition)
        Me.Frame12.Controls.Add(Me.cmbName)
        Me.Frame12.Controls.Add(Me.cmbRank)
        Me.Frame12.Controls.Add(Me.Label3)
        Me.Frame12.Controls.Add(Me.Label12)
        Me.Frame12.Controls.Add(Me.Label11)
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(388, 179)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame12.Size = New System.Drawing.Size(349, 129)
        Me.Frame12.TabIndex = 74
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "توقيع الاستخبارات"
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Position1", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Position1", True))
        Me.cmbPosition.DataSource = Me.Position1BindingSource3
        Me.cmbPosition.DisplayMember = "Position1"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(23, 90)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(272, 21)
        Me.cmbPosition.TabIndex = 86
        Me.cmbPosition.ValueMember = "Position1"
        '
        'Position1BindingSource3
        '
        Me.Position1BindingSource3.DataMember = "MovementForms"
        Me.Position1BindingSource3.DataSource = Me.Position1DsExplosives3
        '
        'Position1DsExplosives3
        '
        Me.Position1DsExplosives3.DataSetName = "dsExplosives"
        Me.Position1DsExplosives3.EnforceConstraints = False
        Me.Position1DsExplosives3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Name1", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Name1", True))
        Me.cmbName.DataSource = Me.Name1BindingSource2
        Me.cmbName.DisplayMember = "Name1"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(23, 58)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(272, 21)
        Me.cmbName.TabIndex = 85
        Me.cmbName.ValueMember = "Name1"
        '
        'Name1BindingSource2
        '
        Me.Name1BindingSource2.DataMember = "MovementForms"
        Me.Name1BindingSource2.DataSource = Me.Name1DsExplosives2
        '
        'Name1DsExplosives2
        '
        Me.Name1DsExplosives2.DataSetName = "dsExplosives"
        Me.Name1DsExplosives2.EnforceConstraints = False
        Me.Name1DsExplosives2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Rank1", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Rank1", True))
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(23, 26)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(272, 21)
        Me.cmbRank.TabIndex = 84
        '
        'Rank1BindingSource1
        '
        Me.Rank1BindingSource1.DataMember = "MovementForms"
        Me.Rank1BindingSource1.DataSource = Me.Rank1DsExplosives1
        '
        'Rank1DsExplosives1
        '
        Me.Rank1DsExplosives1.DataSetName = "dsExplosives"
        Me.Rank1DsExplosives1.EnforceConstraints = False
        Me.Rank1DsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(298, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "المنصب"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(300, 30)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "الرتبة "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(298, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "الاســـم"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbPosition2)
        Me.GroupBox1.Controls.Add(Me.cmbName2)
        Me.GroupBox1.Controls.Add(Me.cmbRank2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(59, 179)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(329, 129)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "توقيع الاسلحة والذخائر"
        '
        'cmbPosition2
        '
        Me.cmbPosition2.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Position2", True))
        Me.cmbPosition2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Position2", True))
        Me.cmbPosition2.DataSource = Me.Position2BindingSource6
        Me.cmbPosition2.DisplayMember = "Position2"
        Me.cmbPosition2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition2.Location = New System.Drawing.Point(18, 89)
        Me.cmbPosition2.Name = "cmbPosition2"
        Me.cmbPosition2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition2.Size = New System.Drawing.Size(257, 21)
        Me.cmbPosition2.TabIndex = 86
        Me.cmbPosition2.ValueMember = "Position2"
        '
        'Position2BindingSource6
        '
        Me.Position2BindingSource6.DataMember = "MovementForms"
        Me.Position2BindingSource6.DataSource = Me.Position2DsExplosives6
        '
        'Position2DsExplosives6
        '
        Me.Position2DsExplosives6.DataSetName = "dsExplosives"
        Me.Position2DsExplosives6.EnforceConstraints = False
        Me.Position2DsExplosives6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName2
        '
        Me.cmbName2.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Name2", True))
        Me.cmbName2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Name2", True))
        Me.cmbName2.DataSource = Me.Name2BindingSource5
        Me.cmbName2.DisplayMember = "Name2"
        Me.cmbName2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName2.Location = New System.Drawing.Point(18, 57)
        Me.cmbName2.Name = "cmbName2"
        Me.cmbName2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName2.Size = New System.Drawing.Size(257, 21)
        Me.cmbName2.TabIndex = 85
        Me.cmbName2.ValueMember = "Name2"
        '
        'Name2BindingSource5
        '
        Me.Name2BindingSource5.DataMember = "MovementForms"
        Me.Name2BindingSource5.DataSource = Me.Name2DsExplosives5
        '
        'Name2DsExplosives5
        '
        Me.Name2DsExplosives5.DataSetName = "dsExplosives"
        Me.Name2DsExplosives5.EnforceConstraints = False
        Me.Name2DsExplosives5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank2
        '
        Me.cmbRank2.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Rank2", True))
        Me.cmbRank2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Rank2", True))
        Me.cmbRank2.DataSource = Me.Rank2BindingSource4
        Me.cmbRank2.DisplayMember = "Rank2"
        Me.cmbRank2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank2.Location = New System.Drawing.Point(18, 25)
        Me.cmbRank2.Name = "cmbRank2"
        Me.cmbRank2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank2.Size = New System.Drawing.Size(257, 21)
        Me.cmbRank2.TabIndex = 84
        Me.cmbRank2.ValueMember = "Rank2"
        '
        'Rank2BindingSource4
        '
        Me.Rank2BindingSource4.DataMember = "MovementForms"
        Me.Rank2BindingSource4.DataSource = Me.Rank2DsExplosives4
        '
        'Rank2DsExplosives4
        '
        Me.Rank2DsExplosives4.DataSetName = "dsExplosives"
        Me.Rank2DsExplosives4.EnforceConstraints = False
        Me.Rank2DsExplosives4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(278, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "المنصب"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(280, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "الرتبة "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(278, 61)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "الاســـم"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.cmbPosition3)
        Me.GroupBox2.Controls.Add(Me.cmbName3)
        Me.GroupBox2.Controls.Add(Me.cmbRank3)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(59, 307)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(329, 207)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "توقيع العمليات"
        '
        'cmbPosition3
        '
        Me.cmbPosition3.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Position3", True))
        Me.cmbPosition3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Position3", True))
        Me.cmbPosition3.DataSource = Me.Position3BindingSource9
        Me.cmbPosition3.DisplayMember = "Position3"
        Me.cmbPosition3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition3.Location = New System.Drawing.Point(18, 120)
        Me.cmbPosition3.Name = "cmbPosition3"
        Me.cmbPosition3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition3.Size = New System.Drawing.Size(257, 21)
        Me.cmbPosition3.TabIndex = 86
        Me.cmbPosition3.ValueMember = "Position3"
        '
        'Position3BindingSource9
        '
        Me.Position3BindingSource9.DataMember = "MovementForms"
        Me.Position3BindingSource9.DataSource = Me.Position3DsExplosives9
        '
        'Position3DsExplosives9
        '
        Me.Position3DsExplosives9.DataSetName = "dsExplosives"
        Me.Position3DsExplosives9.EnforceConstraints = False
        Me.Position3DsExplosives9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName3
        '
        Me.cmbName3.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Name3", True))
        Me.cmbName3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Name3", True))
        Me.cmbName3.DataSource = Me.Name3BindingSource8
        Me.cmbName3.DisplayMember = "Name3"
        Me.cmbName3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName3.Location = New System.Drawing.Point(18, 88)
        Me.cmbName3.Name = "cmbName3"
        Me.cmbName3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName3.Size = New System.Drawing.Size(257, 21)
        Me.cmbName3.TabIndex = 85
        Me.cmbName3.ValueMember = "Name3"
        '
        'Name3BindingSource8
        '
        Me.Name3BindingSource8.DataMember = "MovementForms"
        Me.Name3BindingSource8.DataSource = Me.Name3DsExplosives8
        '
        'Name3DsExplosives8
        '
        Me.Name3DsExplosives8.DataSetName = "dsExplosives"
        Me.Name3DsExplosives8.EnforceConstraints = False
        Me.Name3DsExplosives8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbRank3
        '
        Me.cmbRank3.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank3.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Rank3", True))
        Me.cmbRank3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.MovementFormsBindingSource, "Rank3", True))
        Me.cmbRank3.DataSource = Me.Rank3BindingSource7
        Me.cmbRank3.DisplayMember = "Rank3"
        Me.cmbRank3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank3.Location = New System.Drawing.Point(18, 56)
        Me.cmbRank3.Name = "cmbRank3"
        Me.cmbRank3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank3.Size = New System.Drawing.Size(257, 21)
        Me.cmbRank3.TabIndex = 84
        Me.cmbRank3.ValueMember = "Rank3"
        '
        'Rank3BindingSource7
        '
        Me.Rank3BindingSource7.DataMember = "MovementForms"
        Me.Rank3BindingSource7.DataSource = Me.Rank3DsExplosives7
        '
        'Rank3DsExplosives7
        '
        Me.Rank3DsExplosives7.DataSetName = "dsExplosives"
        Me.Rank3DsExplosives7.EnforceConstraints = False
        Me.Rank3DsExplosives7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(278, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 76
        Me.Label7.Text = "المنصب"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(280, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(34, 13)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "الرتبة "
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(278, 92)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 74
        Me.Label13.Text = "الاســـم"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MovementFormsTableAdapter
        '
        Me.MovementFormsTableAdapter.ClearBeforeFill = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.cmbBy)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.txtPoint3)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtPoint2)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtPoint1)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(741, 374)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(469, 69)
        Me.GroupBox3.TabIndex = 50
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "خط السير"
        '
        'cmbBy
        '
        Me.cmbBy.DisplayMember = "TRANSPORTEDBY"
        Me.cmbBy.FormattingEnabled = True
        Me.cmbBy.Location = New System.Drawing.Point(18, 41)
        Me.cmbBy.Name = "cmbBy"
        Me.cmbBy.Size = New System.Drawing.Size(127, 21)
        Me.cmbBy.TabIndex = 92
        Me.cmbBy.ValueMember = "TRANSPORTEDBY"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label23.Location = New System.Drawing.Point(166, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label23.Size = New System.Drawing.Size(41, 17)
        Me.Label23.TabIndex = 91
        Me.Label23.Text = "بــــ "
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPoint3
        '
        Me.txtPoint3.AcceptsReturn = True
        Me.txtPoint3.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Point3", True))
        Me.txtPoint3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint3.Location = New System.Drawing.Point(229, 41)
        Me.txtPoint3.MaxLength = 0
        Me.txtPoint3.Multiline = True
        Me.txtPoint3.Name = "txtPoint3"
        Me.txtPoint3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint3.Size = New System.Drawing.Size(132, 25)
        Me.txtPoint3.TabIndex = 33
        '
        'Label21
        '
        Me.Label21.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label21.Location = New System.Drawing.Point(377, 42)
        Me.Label21.Name = "Label21"
        Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label21.Size = New System.Drawing.Size(72, 23)
        Me.Label21.TabIndex = 34
        Me.Label21.Text = "النقطة الثالثة"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPoint2
        '
        Me.txtPoint2.AcceptsReturn = True
        Me.txtPoint2.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Point2", True))
        Me.txtPoint2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint2.Location = New System.Drawing.Point(18, 13)
        Me.txtPoint2.MaxLength = 0
        Me.txtPoint2.Multiline = True
        Me.txtPoint2.Name = "txtPoint2"
        Me.txtPoint2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint2.Size = New System.Drawing.Size(127, 25)
        Me.txtPoint2.TabIndex = 33
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label20.Location = New System.Drawing.Point(151, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(72, 23)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "النقطة الثانية"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtPoint1
        '
        Me.txtPoint1.AcceptsReturn = True
        Me.txtPoint1.BackColor = System.Drawing.SystemColors.Window
        Me.txtPoint1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPoint1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MovementFormsBindingSource, "Point1", True))
        Me.txtPoint1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPoint1.Location = New System.Drawing.Point(229, 13)
        Me.txtPoint1.MaxLength = 0
        Me.txtPoint1.Multiline = True
        Me.txtPoint1.Name = "txtPoint1"
        Me.txtPoint1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtPoint1.Size = New System.Drawing.Size(132, 25)
        Me.txtPoint1.TabIndex = 33
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label19.Location = New System.Drawing.Point(377, 19)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label19.Size = New System.Drawing.Size(72, 23)
        Me.Label19.TabIndex = 34
        Me.Label19.Text = "النقطة الأولى"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmMovementForms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 662)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame12)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.MainMenu1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmMovementForms"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "اورنيك التحركات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.MovementFormsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guard1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guard1DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommanderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommanderDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        CType(Me.Position1BindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Position1DsExplosives3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name1BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name1DsExplosives2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank1DsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Position2BindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Position2DsExplosives6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name2BindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name2DsExplosives5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank2BindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank2DsExplosives4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Position3BindingSource9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Position3DsExplosives9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name3BindingSource8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Name3DsExplosives8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank3BindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rank3DsExplosives7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents MovementFormsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovementFormsTableAdapter As Explosives.dsExplosivesTableAdapters.MovementFormsTableAdapter
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCommander As System.Windows.Forms.ComboBox
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPosition2 As System.Windows.Forms.ComboBox
    Public WithEvents cmbName2 As System.Windows.Forms.ComboBox
    Public WithEvents cmbRank2 As System.Windows.Forms.ComboBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPosition3 As System.Windows.Forms.ComboBox
    Public WithEvents cmbName3 As System.Windows.Forms.ComboBox
    Public WithEvents cmbRank3 As System.Windows.Forms.ComboBox
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CommanderBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CommanderDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Guard1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Guard1DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Rank1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Rank1DsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Name1BindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents Name1DsExplosives2 As Explosives.dsExplosives
    Friend WithEvents Position1BindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Position1DsExplosives3 As Explosives.dsExplosives
    Friend WithEvents Rank2BindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents Rank2DsExplosives4 As Explosives.dsExplosives
    Friend WithEvents Name2BindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents Name2DsExplosives5 As Explosives.dsExplosives
    Friend WithEvents Position2BindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents Position2DsExplosives6 As Explosives.dsExplosives
    Friend WithEvents Rank3BindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents Rank3DsExplosives7 As Explosives.dsExplosives
    Friend WithEvents Name3BindingSource8 As System.Windows.Forms.BindingSource
    Friend WithEvents Name3DsExplosives8 As Explosives.dsExplosives
    Friend WithEvents Position3BindingSource9 As System.Windows.Forms.BindingSource
    Friend WithEvents Position3DsExplosives9 As Explosives.dsExplosives
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents txtReceiverLocation As System.Windows.Forms.TextBox
    Public WithEvents txtSenderLocation As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbGuard1 As System.Windows.Forms.ComboBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents txtPoint3 As System.Windows.Forms.TextBox
    Public WithEvents Label21 As System.Windows.Forms.Label
    Public WithEvents txtPoint2 As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents txtPoint1 As System.Windows.Forms.TextBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn
    Public WithEvents txtMovmentFormsNo As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtReceiver As System.Windows.Forms.ComboBox
    Friend WithEvents txtSender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
    Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Friend WithEvents cmbBy As System.Windows.Forms.ComboBox
    Public WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents SenderBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SenderDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents ReceiverBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiverDsExplosives1 As Explosives.dsExplosives

End Class