<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmmo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RankDsExplosives3 = New Explosives.dsExplosives()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.AmmoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.RankAmmoBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.PositionAmmoBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PositionDsExplosives6 = New Explosives.dsExplosives()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.NameAmmoBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives4 = New Explosives.dsExplosives()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.CompanyAmmoBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDsExplosives7 = New Explosives.dsExplosives()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.cmbCities = New System.Windows.Forms.ComboBox()
        Me.CityAmmoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDsExplosives1 = New Explosives.dsExplosives()
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.cmbStates = New System.Windows.Forms.ComboBox()
        Me.StateAmmoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateDsExplosives2 = New Explosives.dsExplosives()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.StatesTableAdapter = New Explosives.dsExplosivesTableAdapters.StatesTableAdapter()
        Me.cmbTownships = New System.Windows.Forms.ComboBox()
        Me.TownshipAmmoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TownshipDsExplosives5 = New Explosives.dsExplosives()
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.dtpCompanyLetterDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPermissionDate = New System.Windows.Forms.DateTimePicker()
        Me.txtAmmoStoreNo = New System.Windows.Forms.TextBox()
        Me.txtAmmoNo = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.AmmoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GasTypeAmmoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GasTypeDsExplosives1 = New Explosives.dsExplosives()
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AmmoTableAdapter = New Explosives.dsExplosivesTableAdapters.AmmoTableAdapter()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.cmbPrintFirst = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.txtJob = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.AmmoBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtMidStoreNo = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtSmallStoreNo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtLargStoreNo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        CType(Me.RankDsExplosives3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AmmoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankAmmoBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionAmmoBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameAmmoBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyAmmoBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDsExplosives7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame7.SuspendLayout()
        CType(Me.CityAmmoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateAmmoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateDsExplosives2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TownshipAmmoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TownshipDsExplosives5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        CType(Me.AmmoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasTypeAmmoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasTypeDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        Me.Frame9.SuspendLayout()
        Me.Frame6.SuspendLayout()
        Me.Frame1.SuspendLayout()
        CType(Me.AmmoBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'RankDsExplosives3
        '
        Me.RankDsExplosives3.DataSetName = "dsExplosives"
        Me.RankDsExplosives3.EnforceConstraints = False
        Me.RankDsExplosives3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.cmbRank)
        Me.GroupBox1.Controls.Add(Me.cmbPosition)
        Me.GroupBox1.Controls.Add(Me.cmbName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(53, 313)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(681, 139)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  صادر بأمـــــر  "
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Rank", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "Rank", True))
        Me.cmbRank.DataSource = Me.RankAmmoBindingSource3
        Me.cmbRank.DisplayMember = "Rank"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(180, 27)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(417, 21)
        Me.cmbRank.TabIndex = 35
        Me.cmbRank.ValueMember = "Rank"
        '
        'AmmoBindingSource
        '
        Me.AmmoBindingSource.DataMember = "Ammo"
        Me.AmmoBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RankAmmoBindingSource3
        '
        Me.RankAmmoBindingSource3.DataMember = "Ammo"
        Me.RankAmmoBindingSource3.DataSource = Me.RankDsExplosives3
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Position", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "Position", True))
        Me.cmbPosition.DataSource = Me.PositionAmmoBindingSource6
        Me.cmbPosition.DisplayMember = "Position"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(180, 91)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(417, 21)
        Me.cmbPosition.TabIndex = 37
        Me.cmbPosition.ValueMember = "Position"
        '
        'PositionAmmoBindingSource6
        '
        Me.PositionAmmoBindingSource6.DataMember = "Ammo"
        Me.PositionAmmoBindingSource6.DataSource = Me.PositionDsExplosives6
        '
        'PositionDsExplosives6
        '
        Me.PositionDsExplosives6.DataSetName = "dsExplosives"
        Me.PositionDsExplosives6.EnforceConstraints = False
        Me.PositionDsExplosives6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "Name", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Name", True))
        Me.cmbName.DataSource = Me.NameAmmoBindingSource4
        Me.cmbName.DisplayMember = "Name"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(180, 59)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(417, 21)
        Me.cmbName.TabIndex = 36
        Me.cmbName.ValueMember = "Name"
        '
        'NameAmmoBindingSource4
        '
        Me.NameAmmoBindingSource4.DataMember = "Ammo"
        Me.NameAmmoBindingSource4.DataSource = Me.NameDsExplosives4
        '
        'NameDsExplosives4
        '
        Me.NameDsExplosives4.DataSetName = "dsExplosives"
        Me.NameDsExplosives4.EnforceConstraints = False
        Me.NameDsExplosives4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(618, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "الرتبة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(618, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "الاســــم"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(614, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "المنــصــب"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbCompany
        '
        Me.cmbCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Company", True))
        Me.cmbCompany.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "Company", True))
        Me.cmbCompany.DataSource = Me.CompanyAmmoBindingSource7
        Me.cmbCompany.DisplayMember = "Company"
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(8, 63)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(384, 21)
        Me.cmbCompany.TabIndex = 36
        Me.cmbCompany.ValueMember = "Company"
        '
        'CompanyAmmoBindingSource7
        '
        Me.CompanyAmmoBindingSource7.DataMember = "Ammo"
        Me.CompanyAmmoBindingSource7.DataSource = Me.CompanyDsExplosives7
        '
        'CompanyDsExplosives7
        '
        Me.CompanyDsExplosives7.DataSetName = "dsExplosives"
        Me.CompanyDsExplosives7.EnforceConstraints = False
        Me.CompanyDsExplosives7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.cmdFirst.Text = "الأول >>"
        Me.cmdFirst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdFirst.UseVisualStyleBackColor = False
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
        Me.cmdLast.Location = New System.Drawing.Point(344, 16)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLast.Size = New System.Drawing.Size(81, 33)
        Me.cmdLast.TabIndex = 24
        Me.cmdLast.Text = "<< الأخيـــر"
        Me.cmdLast.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLast.UseVisualStyleBackColor = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(735, 453)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(473, 57)
        Me.Frame7.TabIndex = 85
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " التنقل بين السجلات "
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
        Me.cmdPrev.Text = "الســــابق >"
        Me.cmdPrev.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdPrev.UseVisualStyleBackColor = False
        '
        'cmbCities
        '
        Me.cmbCities.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "City", True))
        Me.cmbCities.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "City", True))
        Me.cmbCities.DataSource = Me.CityAmmoBindingSource1
        Me.cmbCities.DisplayMember = "City"
        Me.cmbCities.FormattingEnabled = True
        Me.cmbCities.Location = New System.Drawing.Point(43, 25)
        Me.cmbCities.Name = "cmbCities"
        Me.cmbCities.Size = New System.Drawing.Size(121, 21)
        Me.cmbCities.TabIndex = 16
        Me.cmbCities.ValueMember = "City"
        '
        'CityAmmoBindingSource1
        '
        Me.CityAmmoBindingSource1.DataMember = "Ammo"
        Me.CityAmmoBindingSource1.DataSource = Me.CityDsExplosives1
        '
        'CityDsExplosives1
        '
        Me.CityDsExplosives1.DataSetName = "dsExplosives"
        Me.CityDsExplosives1.EnforceConstraints = False
        Me.CityDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbStates
        '
        Me.cmbStates.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbStates.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "State", True))
        Me.cmbStates.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "State", True))
        Me.cmbStates.DataSource = Me.StateAmmoBindingSource2
        Me.cmbStates.DisplayMember = "State"
        Me.cmbStates.FormattingEnabled = True
        Me.cmbStates.Location = New System.Drawing.Point(483, 29)
        Me.cmbStates.Name = "cmbStates"
        Me.cmbStates.Size = New System.Drawing.Size(121, 21)
        Me.cmbStates.TabIndex = 16
        Me.cmbStates.ValueMember = "State"
        '
        'StateAmmoBindingSource2
        '
        Me.StateAmmoBindingSource2.DataMember = "Ammo"
        Me.StateAmmoBindingSource2.DataSource = Me.StateDsExplosives2
        '
        'StateDsExplosives2
        '
        Me.StateDsExplosives2.DataSetName = "dsExplosives"
        Me.StateDsExplosives2.EnforceConstraints = False
        Me.StateDsExplosives2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtLand
        '
        Me.txtLand.AcceptsReturn = True
        Me.txtLand.BackColor = System.Drawing.SystemColors.Window
        Me.txtLand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Land", True))
        Me.txtLand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLand.Location = New System.Drawing.Point(518, 62)
        Me.txtLand.MaxLength = 0
        Me.txtLand.Multiline = True
        Me.txtLand.Name = "txtLand"
        Me.txtLand.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLand.Size = New System.Drawing.Size(86, 25)
        Me.txtLand.TabIndex = 14
        Me.txtLand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'cmbTownships
        '
        Me.cmbTownships.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Township", True))
        Me.cmbTownships.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AmmoBindingSource, "Township", True))
        Me.cmbTownships.DataSource = Me.TownshipAmmoBindingSource1
        Me.cmbTownships.DisplayMember = "Township"
        Me.cmbTownships.FormattingEnabled = True
        Me.cmbTownships.Location = New System.Drawing.Point(262, 24)
        Me.cmbTownships.Name = "cmbTownships"
        Me.cmbTownships.Size = New System.Drawing.Size(121, 21)
        Me.cmbTownships.TabIndex = 16
        Me.cmbTownships.ValueMember = "Township"
        '
        'TownshipAmmoBindingSource1
        '
        Me.TownshipAmmoBindingSource1.DataMember = "Ammo"
        Me.TownshipAmmoBindingSource1.DataSource = Me.TownshipDsExplosives5
        '
        'TownshipDsExplosives5
        '
        Me.TownshipDsExplosives5.DataSetName = "dsExplosives"
        Me.TownshipDsExplosives5.EnforceConstraints = False
        Me.TownshipDsExplosives5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.cmbCompany)
        Me.Frame5.Controls.Add(Me.dtpCompanyLetterDate)
        Me.Frame5.Controls.Add(Me.dtpPermissionDate)
        Me.Frame5.Controls.Add(Me.txtAmmoStoreNo)
        Me.Frame5.Controls.Add(Me.txtAmmoNo)
        Me.Frame5.Controls.Add(Me.txtId)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label5)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label20)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(733, 146)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(473, 150)
        Me.Frame5.TabIndex = 87
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " بيانات الملف "
        '
        'dtpCompanyLetterDate
        '
        Me.dtpCompanyLetterDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AmmoBindingSource, "CompanyLetterDate", True))
        Me.dtpCompanyLetterDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "PermissionDate", True))
        Me.dtpCompanyLetterDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompanyLetterDate.Location = New System.Drawing.Point(226, 100)
        Me.dtpCompanyLetterDate.Name = "dtpCompanyLetterDate"
        Me.dtpCompanyLetterDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpCompanyLetterDate.TabIndex = 35
        '
        'dtpPermissionDate
        '
        Me.dtpPermissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.AmmoBindingSource, "PermissionDate", True))
        Me.dtpPermissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "PermissionDate", True))
        Me.dtpPermissionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPermissionDate.Location = New System.Drawing.Point(8, 26)
        Me.dtpPermissionDate.Name = "dtpPermissionDate"
        Me.dtpPermissionDate.Size = New System.Drawing.Size(107, 20)
        Me.dtpPermissionDate.TabIndex = 35
        '
        'txtAmmoStoreNo
        '
        Me.txtAmmoStoreNo.AcceptsReturn = True
        Me.txtAmmoStoreNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmmoStoreNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmmoStoreNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "AmmoStoreNo", True))
        Me.txtAmmoStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmmoStoreNo.Location = New System.Drawing.Point(8, 97)
        Me.txtAmmoStoreNo.MaxLength = 0
        Me.txtAmmoStoreNo.Multiline = True
        Me.txtAmmoStoreNo.Name = "txtAmmoStoreNo"
        Me.txtAmmoStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmmoStoreNo.Size = New System.Drawing.Size(140, 25)
        Me.txtAmmoStoreNo.TabIndex = 29
        Me.txtAmmoStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAmmoNo
        '
        Me.txtAmmoNo.AcceptsReturn = True
        Me.txtAmmoNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtAmmoNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAmmoNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtAmmoNo.Location = New System.Drawing.Point(192, 26)
        Me.txtAmmoNo.MaxLength = 0
        Me.txtAmmoNo.Multiline = True
        Me.txtAmmoNo.Name = "txtAmmoNo"
        Me.txtAmmoNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtAmmoNo.Size = New System.Drawing.Size(58, 25)
        Me.txtAmmoNo.TabIndex = 29
        Me.txtAmmoNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtId
        '
        Me.txtId.AcceptsReturn = True
        Me.txtId.BackColor = System.Drawing.SystemColors.Window
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "AmmoID", True))
        Me.txtId.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtId.Location = New System.Drawing.Point(332, 26)
        Me.txtId.MaxLength = 0
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtId.Size = New System.Drawing.Size(58, 25)
        Me.txtId.TabIndex = 29
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(144, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(84, 24)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "مخزن الذخيرة"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(389, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "تاريخ الطلب"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(400, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(66, 24)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "ألاسم"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(256, 29)
        Me.Label20.Name = "Label20"
        Me.Label20.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label20.Size = New System.Drawing.Size(65, 25)
        Me.Label20.TabIndex = 31
        Me.Label20.Text = "نمرة الملف"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(121, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "التاريخ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(400, 32)
        Me.Label15.Name = "Label15"
        Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label15.Size = New System.Drawing.Size(65, 25)
        Me.Label15.TabIndex = 31
        Me.Label15.Text = "نمرة الملف"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'AmmoBindingSource1
        '
        Me.AmmoBindingSource1.DataMember = "Ammo"
        Me.AmmoBindingSource1.DataSource = Me.RankDsExplosives3
        '
        'GasTypeAmmoBindingSource1
        '
        Me.GasTypeAmmoBindingSource1.DataMember = "Ammo"
        Me.GasTypeAmmoBindingSource1.DataSource = Me.GasTypeDsExplosives1
        '
        'GasTypeDsExplosives1
        '
        Me.GasTypeDsExplosives1.DataSetName = "dsExplosives"
        Me.GasTypeDsExplosives1.EnforceConstraints = False
        Me.GasTypeDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRefresh.Location = New System.Drawing.Point(-57, -9)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
        Me.cmdRefresh.TabIndex = 90
        Me.cmdRefresh.Text = "تـــــــحــــديـــــــث البيـــــــانات"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.DsExplosives
        '
        'AmmoTableAdapter
        '
        Me.AmmoTableAdapter.ClearBeforeFill = True
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1246, 24)
        Me.MainMenu1.TabIndex = 91
        '
        'mnuColours
        '
        Me.mnuColours.Name = "mnuColours"
        Me.mnuColours.Size = New System.Drawing.Size(79, 20)
        Me.mnuColours.Text = "ضبط الألوان"
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
        Me.Frame3.Location = New System.Drawing.Point(735, 370)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(473, 82)
        Me.Frame3.TabIndex = 86
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
        Me.cmbCriteria.Location = New System.Drawing.Point(276, 16)
        Me.cmbCriteria.Name = "cmbCriteria"
        Me.cmbCriteria.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmbCriteria.Size = New System.Drawing.Size(169, 21)
        Me.cmbCriteria.TabIndex = 53
        '
        'cmdFindNext
        '
        Me.cmdFindNext.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFindNext.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFindNext.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFindNext.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFindNext.Location = New System.Drawing.Point(228, 16)
        Me.cmdFindNext.Name = "cmdFindNext"
        Me.cmdFindNext.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindNext.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindNext.TabIndex = 52
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
        Me.cmdFindPrev.Location = New System.Drawing.Point(28, 16)
        Me.cmdFindPrev.Name = "cmdFindPrev"
        Me.cmdFindPrev.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdFindPrev.Size = New System.Drawing.Size(33, 25)
        Me.cmdFindPrev.TabIndex = 51
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
        Me.txtFind.Location = New System.Drawing.Point(68, 16)
        Me.txtFind.MaxLength = 0
        Me.txtFind.Multiline = True
        Me.txtFind.Name = "txtFind"
        Me.txtFind.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtFind.Size = New System.Drawing.Size(153, 25)
        Me.txtFind.TabIndex = 50
        Me.txtFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPosition.ForeColor = System.Drawing.Color.White
        Me.lblPosition.Location = New System.Drawing.Point(36, 56)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblPosition.Size = New System.Drawing.Size(201, 25)
        Me.lblPosition.TabIndex = 54
        Me.lblPosition.Text = "********"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBlock
        '
        Me.txtBlock.AcceptsReturn = True
        Me.txtBlock.BackColor = System.Drawing.SystemColors.Window
        Me.txtBlock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBlock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Block", True))
        Me.txtBlock.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBlock.Location = New System.Drawing.Point(365, 62)
        Me.txtBlock.MaxLength = 0
        Me.txtBlock.Multiline = True
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBlock.Size = New System.Drawing.Size(86, 25)
        Me.txtBlock.TabIndex = 14
        Me.txtBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.cmbPrintFirst)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(53, 71)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1153, 75)
        Me.Frame9.TabIndex = 89
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "  خــيــــــــــــارات  "
        '
        'cmbPrintFirst
        '
        Me.cmbPrintFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmbPrintFirst.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.cmbPrintFirst.ForeColor = System.Drawing.Color.White
        Me.cmbPrintFirst.Location = New System.Drawing.Point(872, 24)
        Me.cmbPrintFirst.Name = "cmbPrintFirst"
        Me.cmbPrintFirst.Size = New System.Drawing.Size(169, 41)
        Me.cmbPrintFirst.TabIndex = 48
        Me.cmbPrintFirst.Text = "طباعة"
        Me.cmbPrintFirst.UseVisualStyleBackColor = False
        '
        'cmdReturn
        '
        Me.cmdReturn.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdReturn.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdReturn.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdReturn.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdReturn.Location = New System.Drawing.Point(369, 24)
        Me.cmdReturn.Name = "cmdReturn"
        Me.cmdReturn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdReturn.Size = New System.Drawing.Size(129, 41)
        Me.cmdReturn.TabIndex = 41
        Me.cmdReturn.Text = "رجـــــوع"
        Me.cmdReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdReturn.UseVisualStyleBackColor = False
        '
        'cmdFound
        '
        Me.cmdFound.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdFound.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdFound.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFound.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.cmdFound.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdFound.Location = New System.Drawing.Point(668, 24)
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
        Me.cmdPrintAll.Location = New System.Drawing.Point(519, 24)
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
        Me.cmdExit.Location = New System.Drawing.Point(71, 24)
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
        Me.cmdLogout.Location = New System.Drawing.Point(222, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 43
        Me.cmdLogout.Text = "تسجيل خروج"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'Frame6
        '
        Me.Frame6.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame6.Controls.Add(Me.cmdCancel)
        Me.Frame6.Controls.Add(Me.cmdSave)
        Me.Frame6.Controls.Add(Me.cmdNew)
        Me.Frame6.Controls.Add(Me.cmdDelete)
        Me.Frame6.Controls.Add(Me.cmdEdit)
        Me.Frame6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame6.Location = New System.Drawing.Point(53, 453)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(681, 57)
        Me.Frame6.TabIndex = 84
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
        Me.cmdCancel.Location = New System.Drawing.Point(278, 16)
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
        Me.cmdSave.Location = New System.Drawing.Point(365, 16)
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
        Me.cmdNew.Location = New System.Drawing.Point(456, 16)
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
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdDelete.Location = New System.Drawing.Point(104, 16)
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
        Me.cmdEdit.Location = New System.Drawing.Point(191, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 17
        Me.cmdEdit.Text = "تـــعـــديل"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(447, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(65, 25)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "المربع"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(613, 65)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(61, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "رقم القطعة"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(389, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label12.Size = New System.Drawing.Size(65, 25)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "المحلية"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(170, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(65, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "المدينة"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmbTownships)
        Me.Frame1.Controls.Add(Me.cmbCities)
        Me.Frame1.Controls.Add(Me.cmbStates)
        Me.Frame1.Controls.Add(Me.txtJob)
        Me.Frame1.Controls.Add(Me.txtBlock)
        Me.Frame1.Controls.Add(Me.Label19)
        Me.Frame1.Controls.Add(Me.txtLand)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(53, 146)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(681, 98)
        Me.Frame1.TabIndex = 83
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " بيانات الإتصال "
        '
        'txtJob
        '
        Me.txtJob.AcceptsReturn = True
        Me.txtJob.BackColor = System.Drawing.SystemColors.Window
        Me.txtJob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtJob.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Job", True))
        Me.txtJob.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtJob.Location = New System.Drawing.Point(43, 59)
        Me.txtJob.MaxLength = 0
        Me.txtJob.Multiline = True
        Me.txtJob.Name = "txtJob"
        Me.txtJob.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtJob.Size = New System.Drawing.Size(250, 25)
        Me.txtJob.TabIndex = 14
        Me.txtJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(289, 62)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(65, 25)
        Me.Label19.TabIndex = 15
        Me.Label19.Text = "الحرفة"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(613, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(65, 25)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "الولاية"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'AmmoBindingSource5
        '
        Me.AmmoBindingSource5.DataMember = "Ammo"
        Me.AmmoBindingSource5.DataSource = Me.TownshipDsExplosives5
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.txtMidStoreNo)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtSmallStoreNo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtLargStoreNo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox2.Location = New System.Drawing.Point(734, 296)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(473, 77)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "رخصة التخزين"
        '
        'txtMidStoreNo
        '
        Me.txtMidStoreNo.AcceptsReturn = True
        Me.txtMidStoreNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtMidStoreNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMidStoreNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "MidStoreNo", True))
        Me.txtMidStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtMidStoreNo.Location = New System.Drawing.Point(3, 13)
        Me.txtMidStoreNo.MaxLength = 0
        Me.txtMidStoreNo.Multiline = True
        Me.txtMidStoreNo.Name = "txtMidStoreNo"
        Me.txtMidStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtMidStoreNo.Size = New System.Drawing.Size(137, 25)
        Me.txtMidStoreNo.TabIndex = 37
        Me.txtMidStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(146, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(92, 24)
        Me.Label17.TabIndex = 34
        Me.Label17.Text = "رخصة متوسطة رقم"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtSmallStoreNo
        '
        Me.txtSmallStoreNo.AcceptsReturn = True
        Me.txtSmallStoreNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtSmallStoreNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSmallStoreNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "SmallStoreNo", True))
        Me.txtSmallStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSmallStoreNo.Location = New System.Drawing.Point(238, 45)
        Me.txtSmallStoreNo.MaxLength = 0
        Me.txtSmallStoreNo.Multiline = True
        Me.txtSmallStoreNo.Name = "txtSmallStoreNo"
        Me.txtSmallStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtSmallStoreNo.Size = New System.Drawing.Size(137, 25)
        Me.txtSmallStoreNo.TabIndex = 37
        Me.txtSmallStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(381, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label16.Size = New System.Drawing.Size(92, 24)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "رخصة صغيرة رقم"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtLargStoreNo
        '
        Me.txtLargStoreNo.AcceptsReturn = True
        Me.txtLargStoreNo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLargStoreNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLargStoreNo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "LargStoreNo", True))
        Me.txtLargStoreNo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLargStoreNo.Location = New System.Drawing.Point(238, 14)
        Me.txtLargStoreNo.MaxLength = 0
        Me.txtLargStoreNo.Multiline = True
        Me.txtLargStoreNo.Name = "txtLargStoreNo"
        Me.txtLargStoreNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLargStoreNo.Size = New System.Drawing.Size(137, 25)
        Me.txtLargStoreNo.TabIndex = 37
        Me.txtLargStoreNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(381, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(92, 24)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "رخصة كبيرة رقم"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.TextBox2)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TextBox3)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox3.Location = New System.Drawing.Point(53, 246)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(681, 64)
        Me.GroupBox3.TabIndex = 94
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "المعلومات المالية"
        '
        'TextBox2
        '
        Me.TextBox2.AcceptsReturn = True
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "Fees", True))
        Me.TextBox2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox2.Location = New System.Drawing.Point(180, 15)
        Me.TextBox2.MaxLength = 0
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox2.Size = New System.Drawing.Size(137, 25)
        Me.TextBox2.TabIndex = 37
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(323, 18)
        Me.Label14.Name = "Label14"
        Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label14.Size = New System.Drawing.Size(92, 24)
        Me.Label14.TabIndex = 34
        Me.Label14.Text = "الرسوم"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox3
        '
        Me.TextBox3.AcceptsReturn = True
        Me.TextBox3.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox3.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "FID", True))
        Me.TextBox3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TextBox3.Location = New System.Drawing.Point(425, 15)
        Me.TextBox3.MaxLength = 0
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox3.Size = New System.Drawing.Size(137, 25)
        Me.TextBox3.TabIndex = 37
        Me.TextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AmmoBindingSource, "FID", True))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(568, 18)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(92, 24)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "رقم الايصال"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1246, 613)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.Frame3)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmAmmo"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "تصاديق مخازن السلاح"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RankDsExplosives3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AmmoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankAmmoBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionAmmoBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameAmmoBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyAmmoBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDsExplosives7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame7.ResumeLayout(False)
        CType(Me.CityAmmoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateAmmoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateDsExplosives2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TownshipAmmoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TownshipDsExplosives5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.AmmoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasTypeAmmoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasTypeDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        Me.Frame9.ResumeLayout(False)
        Me.Frame6.ResumeLayout(False)
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.AmmoBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RankDsExplosives3 As Explosives.dsExplosives
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Friend WithEvents AmmoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents RankAmmoBindingSource3 As System.Windows.Forms.BindingSource
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Friend WithEvents PositionAmmoBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents PositionDsExplosives6 As Explosives.dsExplosives
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents NameAmmoBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents NameDsExplosives4 As Explosives.dsExplosives
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents CompanyAmmoBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyDsExplosives7 As Explosives.dsExplosives
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCities As System.Windows.Forms.ComboBox
    Friend WithEvents CityAmmoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CityDsExplosives1 As Explosives.dsExplosives
    Public WithEvents cmnDlgPrint As System.Windows.Forms.PrintDialog
    Friend WithEvents cmbStates As System.Windows.Forms.ComboBox
    Friend WithEvents StateAmmoBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StateDsExplosives2 As Explosives.dsExplosives
    Public WithEvents txtLand As System.Windows.Forms.TextBox
    Friend WithEvents StatesTableAdapter As Explosives.dsExplosivesTableAdapters.StatesTableAdapter
    Friend WithEvents cmbTownships As System.Windows.Forms.ComboBox
    Friend WithEvents TownshipAmmoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TownshipDsExplosives5 As Explosives.dsExplosives
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Friend WithEvents GasTypeAmmoBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents GasTypeDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents dtpCompanyLetterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPermissionDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtId As System.Windows.Forms.TextBox
    Public WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AmmoTableAdapter As Explosives.dsExplosivesTableAdapters.AmmoTableAdapter
    Public WithEvents cmnDlgSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents cmnDlgOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents mnuColours As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Public WithEvents lblPosition As System.Windows.Forms.Label
    Public WithEvents cmnDlgColor As System.Windows.Forms.ColorDialog
    Public WithEvents cmnDlgFont As System.Windows.Forms.FontDialog
    Public WithEvents txtBlock As System.Windows.Forms.TextBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPrintFirst As System.Windows.Forms.Button
    Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
    Public WithEvents cmdFound As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdExit As System.Windows.Forms.CheckBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents AmmoBindingSource5 As System.Windows.Forms.BindingSource
    Public WithEvents txtAmmoStoreNo As System.Windows.Forms.TextBox
    Friend WithEvents AmmoBindingSource1 As System.Windows.Forms.BindingSource
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents txtMidStoreNo As System.Windows.Forms.TextBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents txtSmallStoreNo As System.Windows.Forms.TextBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents txtLargStoreNo As System.Windows.Forms.TextBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents TextBox2 As System.Windows.Forms.TextBox
    Public WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents TextBox3 As System.Windows.Forms.TextBox
    Public WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents txtJob As System.Windows.Forms.TextBox
    Public WithEvents Label19 As System.Windows.Forms.Label
    Public WithEvents txtAmmoNo As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
End Class
