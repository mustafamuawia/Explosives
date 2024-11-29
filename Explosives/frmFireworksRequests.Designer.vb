<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFireworksRequests
    Inherits System.Windows.Forms.Form
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
    Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintDoc As System.Windows.Forms.CheckBox
    Public WithEvents cmdFound As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdExit As System.Windows.Forms.CheckBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents txtFireworksRequestID As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
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
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmdPlus = New System.Windows.Forms.CheckBox()
        Me.cmdRemove = New System.Windows.Forms.CheckBox()
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
        Me.FireworksRequestsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.ReceiverBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReceiverDsExplosives1 = New Explosives.dsExplosives()
        Me.txtSender = New System.Windows.Forms.ComboBox()
        Me.SenderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SenderDsExplosives1 = New Explosives.dsExplosives()
        Me.dtpFDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFireworksRequestNo = New System.Windows.Forms.TextBox()
        Me.txtFireworksRequestID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
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
        Me.Quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Unit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Path = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives1 = New Explosives.dsExplosives()
        Me.NameBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives1 = New Explosives.dsExplosives()
        Me.FireworksRequestsTableAdapter = New Explosives.dsExplosivesTableAdapters.FireworksRequestsTableAdapter()
        Me.Frame12 = New System.Windows.Forms.GroupBox()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.WORKPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter()
        Me.IMPORTALLOWEDTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter()
        Me.Frame9.SuspendLayout()
        Me.Frame5.SuspendLayout()
        CType(Me.FireworksRequestsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReceiverDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SenderDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame3.SuspendLayout()
        Me.Frame7.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame12.SuspendLayout()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdPlus
        '
        Me.cmdPlus.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdPlus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdPlus.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdPlus.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdPlus.Location = New System.Drawing.Point(47, 51)
        Me.cmdPlus.Name = "cmdPlus"
        Me.cmdPlus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdPlus.Size = New System.Drawing.Size(27, 25)
        Me.cmdPlus.TabIndex = 75
        Me.cmdPlus.Text = "+"
        Me.cmdPlus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPlus.UseVisualStyleBackColor = False
        '
        'cmdRemove
        '
        Me.cmdRemove.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRemove.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRemove.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemove.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRemove.Location = New System.Drawing.Point(26, 52)
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRemove.Size = New System.Drawing.Size(25, 24)
        Me.cmdRemove.TabIndex = 76
        Me.cmdRemove.Text = "-"
        Me.cmdRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRemove.UseVisualStyleBackColor = False
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
        Me.cmdPrintDoc.Text = "طباعة"
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
        Me.Frame5.Controls.Add(Me.dtpFDate)
        Me.Frame5.Controls.Add(Me.Label1)
        Me.Frame5.Controls.Add(Me.txtFireworksRequestNo)
        Me.Frame5.Controls.Add(Me.txtFireworksRequestID)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label22)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(739, 179)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(473, 138)
        Me.Frame5.TabIndex = 28
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " بيانات الملف "
        '
        'txtReceiver
        '
        Me.txtReceiver.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtReceiver.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtReceiver.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FireworksRequestsBindingSource, "Receiver", True))
        Me.txtReceiver.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "Receiver", True))
        Me.txtReceiver.DataSource = Me.ReceiverBindingSource1
        Me.txtReceiver.DisplayMember = "FSIDENAME"
        Me.txtReceiver.FormattingEnabled = True
        Me.txtReceiver.Location = New System.Drawing.Point(19, 89)
        Me.txtReceiver.Name = "txtReceiver"
        Me.txtReceiver.Size = New System.Drawing.Size(358, 21)
        Me.txtReceiver.TabIndex = 37
        Me.txtReceiver.ValueMember = "FSIDENAME"
        '
        'FireworksRequestsBindingSource
        '
        Me.FireworksRequestsBindingSource.DataMember = "FireworksRequests"
        Me.FireworksRequestsBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReceiverBindingSource1
        '
        Me.ReceiverBindingSource1.DataMember = "WORKPERMISSIONS"
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
        Me.txtSender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FireworksRequestsBindingSource, "Sender", True))
        Me.txtSender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "Sender", True))
        Me.txtSender.DataSource = Me.SenderBindingSource1
        Me.txtSender.DisplayMember = "Sender"
        Me.txtSender.FormattingEnabled = True
        Me.txtSender.Location = New System.Drawing.Point(19, 56)
        Me.txtSender.Name = "txtSender"
        Me.txtSender.Size = New System.Drawing.Size(358, 21)
        Me.txtSender.TabIndex = 37
        Me.txtSender.ValueMember = "Sender"
        '
        'SenderBindingSource1
        '
        Me.SenderBindingSource1.DataMember = "FireworksRequests"
        Me.SenderBindingSource1.DataSource = Me.SenderDsExplosives1
        '
        'SenderDsExplosives1
        '
        Me.SenderDsExplosives1.DataSetName = "dsExplosives"
        Me.SenderDsExplosives1.EnforceConstraints = False
        Me.SenderDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFDate
        '
        Me.dtpFDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.FireworksRequestsBindingSource, "RequestDate", True))
        Me.dtpFDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFDate.Location = New System.Drawing.Point(19, 29)
        Me.dtpFDate.Name = "dtpFDate"
        Me.dtpFDate.RightToLeftLayout = True
        Me.dtpFDate.Size = New System.Drawing.Size(105, 20)
        Me.dtpFDate.TabIndex = 35
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
        Me.Label1.Text = "الجهة المرسل إليها"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtFireworksRequestNo
        '
        Me.txtFireworksRequestNo.AcceptsReturn = True
        Me.txtFireworksRequestNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFireworksRequestNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFireworksRequestNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "FireworksRequestNo", True))
        Me.txtFireworksRequestNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFireworksRequestNo.Location = New System.Drawing.Point(171, 25)
        Me.txtFireworksRequestNo.MaxLength = 0
        Me.txtFireworksRequestNo.Multiline = True
        Me.txtFireworksRequestNo.Name = "txtFireworksRequestNo"
        Me.txtFireworksRequestNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFireworksRequestNo.Size = New System.Drawing.Size(62, 25)
        Me.txtFireworksRequestNo.TabIndex = 29
        Me.txtFireworksRequestNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFireworksRequestID
        '
        Me.txtFireworksRequestID.AcceptsReturn = True
        Me.txtFireworksRequestID.BackColor = System.Drawing.SystemColors.Window
        Me.txtFireworksRequestID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFireworksRequestID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "FireworksRequestID", True))
        Me.txtFireworksRequestID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtFireworksRequestID.Location = New System.Drawing.Point(316, 25)
        Me.txtFireworksRequestID.MaxLength = 0
        Me.txtFireworksRequestID.Multiline = True
        Me.txtFireworksRequestID.Name = "txtFireworksRequestID"
        Me.txtFireworksRequestID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFireworksRequestID.Size = New System.Drawing.Size(62, 25)
        Me.txtFireworksRequestID.TabIndex = 29
        Me.txtFireworksRequestID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label10.Text = "الجهة المرسلة"
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
        Me.Frame3.Controls.Add(Me.txtFind)
        Me.Frame3.Controls.Add(Me.lblPosition)
        Me.Frame3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame3.Location = New System.Drawing.Point(741, 440)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(471, 79)
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
        Me.cmdCancel.Enabled = False
        Me.cmdCancel.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdCancel.Location = New System.Drawing.Point(204, 29)
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
        Me.cmdSave.Location = New System.Drawing.Point(423, 29)
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
        Me.cmdNew.Location = New System.Drawing.Point(527, 29)
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
        Me.cmdDelete.Location = New System.Drawing.Point(94, 29)
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
        Me.cmdEdit.Location = New System.Drawing.Point(319, 29)
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
        Me.Frame1.Location = New System.Drawing.Point(59, 179)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(681, 335)
        Me.Frame1.TabIndex = 0
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "بيانات المفرقعات"
        '
        'cmbUnit
        '
        Me.cmbUnit.FormattingEnabled = True
        Me.cmbUnit.Location = New System.Drawing.Point(352, 52)
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.Size = New System.Drawing.Size(161, 21)
        Me.cmbUnit.TabIndex = 74
        '
        'nudQuantity
        '
        Me.nudQuantity.Location = New System.Drawing.Point(556, 55)
        Me.nudQuantity.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudQuantity.Name = "nudQuantity"
        Me.nudQuantity.Size = New System.Drawing.Size(77, 20)
        Me.nudQuantity.TabIndex = 73
        '
        'cmbClass
        '
        Me.cmbClass.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbClass.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbClass.FormattingEnabled = True
        Me.cmbClass.Location = New System.Drawing.Point(80, 52)
        Me.cmbClass.Name = "cmbClass"
        Me.cmbClass.Size = New System.Drawing.Size(257, 21)
        Me.cmbClass.TabIndex = 72
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Quantity, Me.Unit, Me.Description, Me.Path})
        Me.DataGridView1.Location = New System.Drawing.Point(26, 89)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(648, 221)
        Me.DataGridView1.TabIndex = 1
        '
        'Quantity
        '
        Me.Quantity.DataPropertyName = "Quantity"
        Me.Quantity.FillWeight = 50.0!
        Me.Quantity.HeaderText = "الكمية"
        Me.Quantity.Name = "Quantity"
        Me.Quantity.ReadOnly = True
        '
        'Unit
        '
        Me.Unit.DataPropertyName = "Unit"
        Me.Unit.FillWeight = 70.0!
        Me.Unit.HeaderText = "الوحدة"
        Me.Unit.Name = "Unit"
        Me.Unit.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "Description"
        Me.Description.FillWeight = 130.0!
        Me.Description.HeaderText = "الوصف"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Path
        '
        Me.Path.DataPropertyName = "Path"
        Me.Path.HeaderText = "المسار"
        Me.Path.Name = "Path"
        Me.Path.ReadOnly = True
        Me.Path.Visible = False
        '
        'PositionBindingSource1
        '
        Me.PositionBindingSource1.DataMember = "FireworksRequests"
        Me.PositionBindingSource1.DataSource = Me.PositionDsExplosives1
        '
        'PositionDsExplosives1
        '
        Me.PositionDsExplosives1.DataSetName = "dsExplosives"
        Me.PositionDsExplosives1.EnforceConstraints = False
        Me.PositionDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NameBindingSource1
        '
        Me.NameBindingSource1.DataMember = "FireworksRequests"
        Me.NameBindingSource1.DataSource = Me.NameDsExplosives1
        '
        'NameDsExplosives1
        '
        Me.NameDsExplosives1.DataSetName = "dsExplosives"
        Me.NameDsExplosives1.EnforceConstraints = False
        Me.NameDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FireworksRequestsTableAdapter
        '
        Me.FireworksRequestsTableAdapter.ClearBeforeFill = True
        '
        'Frame12
        '
        Me.Frame12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame12.Controls.Add(Me.cmbPosition)
        Me.Frame12.Controls.Add(Me.cmbRank)
        Me.Frame12.Controls.Add(Me.cmbName)
        Me.Frame12.Controls.Add(Me.Label2)
        Me.Frame12.Controls.Add(Me.Label12)
        Me.Frame12.Controls.Add(Me.Label11)
        Me.Frame12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame12.Location = New System.Drawing.Point(741, 318)
        Me.Frame12.Name = "Frame12"
        Me.Frame12.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame12.Size = New System.Drawing.Size(471, 125)
        Me.Frame12.TabIndex = 74
        Me.Frame12.TabStop = False
        Me.Frame12.Text = "  صادر تحت توقيع  "
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FireworksRequestsBindingSource, "Position", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "Position", True))
        Me.cmbPosition.DataSource = Me.PositionBindingSource1
        Me.cmbPosition.DisplayMember = "POSITION"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(5, 80)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(370, 21)
        Me.cmbPosition.TabIndex = 86
        Me.cmbPosition.ValueMember = "POSITION"
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FireworksRequestsBindingSource, "Rank", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "Rank", True))
        Me.cmbRank.DataSource = Me.RankBindingSource1
        Me.cmbRank.DisplayMember = "Rank"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(5, 16)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(370, 21)
        Me.cmbRank.TabIndex = 85
        Me.cmbRank.ValueMember = "Rank"
        '
        'RankBindingSource1
        '
        Me.RankBindingSource1.DataMember = "FireworksRequests"
        Me.RankBindingSource1.DataSource = Me.RankDsExplosives1
        '
        'RankDsExplosives1
        '
        Me.RankDsExplosives1.DataSetName = "dsExplosives"
        Me.RankDsExplosives1.EnforceConstraints = False
        Me.RankDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FireworksRequestsBindingSource, "Name", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FireworksRequestsBindingSource, "Name", True))
        Me.cmbName.DataSource = Me.NameBindingSource1
        Me.cmbName.DisplayMember = "NAME"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(5, 48)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(370, 21)
        Me.cmbName.TabIndex = 85
        Me.cmbName.ValueMember = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(382, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "المنصب"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(384, 19)
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
        Me.Label11.Location = New System.Drawing.Point(382, 51)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "الاســـم"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'WORKPERMISSIONSTableAdapter
        '
        Me.WORKPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'IMPORTALLOWEDTableAdapter
        '
        Me.IMPORTALLOWEDTableAdapter.ClearBeforeFill = True
        '
        'frmFireworksRequests
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1272, 662)
        Me.Controls.Add(Me.Frame12)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmFireworksRequests"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "طلب مفرقعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Frame9.ResumeLayout(False)
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.FireworksRequestsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReceiverDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SenderDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame7.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        CType(Me.nudQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame12.ResumeLayout(False)
        Me.Frame12.PerformLayout()
        CType(Me.RankBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtpFDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtFireworksRequestNo As System.Windows.Forms.TextBox
    Public WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtReceiver As System.Windows.Forms.ComboBox
    Friend WithEvents txtSender As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClass As System.Windows.Forms.ComboBox
    Friend WithEvents cmbUnit As System.Windows.Forms.ComboBox
    Friend WithEvents nudQuantity As System.Windows.Forms.NumericUpDown
    Public WithEvents cmdPlus As System.Windows.Forms.CheckBox
    Public WithEvents cmdRemove As System.Windows.Forms.CheckBox
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents FireworksRequestsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FireworksRequestsTableAdapter As Explosives.dsExplosivesTableAdapters.FireworksRequestsTableAdapter
    Friend WithEvents SenderBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents SenderDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents ReceiverBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents ReceiverDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents NameBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NameDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents PositionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionDsExplosives1 As Explosives.dsExplosives
    Public WithEvents Frame12 As System.Windows.Forms.GroupBox
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents WORKPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter
    Friend WithEvents IMPORTALLOWEDTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTALLOWEDTableAdapter
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Friend WithEvents RankBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RankDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents Quantity As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Unit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Description As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Path As System.Windows.Forms.DataGridViewTextBoxColumn

End Class