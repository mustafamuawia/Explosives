<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGasCenter
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
        Me.cmbCompany = New System.Windows.Forms.ComboBox()
        Me.GasCentersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsExplosives = New Explosives.dsExplosives()
        Me.CompanyGasCentersBindingSource7 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompanyDsExplosives7 = New Explosives.dsExplosives()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Frame6 = New System.Windows.Forms.GroupBox()
        Me.cmdCancel = New System.Windows.Forms.CheckBox()
        Me.cmdSave = New System.Windows.Forms.CheckBox()
        Me.cmdNew = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.CheckBox()
        Me.cmdEdit = New System.Windows.Forms.CheckBox()
        Me.dtpCompanyLetterDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpPermissionDate = New System.Windows.Forms.DateTimePicker()
        Me.cmbCriteria = New System.Windows.Forms.ComboBox()
        Me.cmdFindNext = New System.Windows.Forms.CheckBox()
        Me.Frame9 = New System.Windows.Forms.GroupBox()
        Me.btnPrintSecond = New System.Windows.Forms.Button()
        Me.cmbPrintFirst = New System.Windows.Forms.Button()
        Me.cmdReturn = New System.Windows.Forms.CheckBox()
        Me.cmdFound = New System.Windows.Forms.CheckBox()
        Me.cmdPrintAll = New System.Windows.Forms.CheckBox()
        Me.cmdExit = New System.Windows.Forms.CheckBox()
        Me.cmdLogout = New System.Windows.Forms.CheckBox()
        Me.txtRepresentitive = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.mnuColours = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmdFindPrev = New System.Windows.Forms.CheckBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtFind = New System.Windows.Forms.TextBox()
        Me.NameGasCentersBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameDsExplosives4 = New Explosives.dsExplosives()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Frame1 = New System.Windows.Forms.GroupBox()
        Me.cmbTownships = New System.Windows.Forms.ComboBox()
        Me.TownshipGasCentersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TownshipDsExplosives5 = New Explosives.dsExplosives()
        Me.cmbCities = New System.Windows.Forms.ComboBox()
        Me.CityGasCentersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CityDsExplosives1 = New Explosives.dsExplosives()
        Me.cmbStates = New System.Windows.Forms.ComboBox()
        Me.StateGasCentersBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StateDsExplosives2 = New Explosives.dsExplosives()
        Me.txtBlock = New System.Windows.Forms.TextBox()
        Me.txtLand = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GasCentersTableAdapter = New Explosives.dsExplosivesTableAdapters.GasCentersTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PositionDsExplosives6 = New Explosives.dsExplosives()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.StatesTableAdapter = New Explosives.dsExplosivesTableAdapters.StatesTableAdapter()
        Me.PositionGasCentersBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbRank = New System.Windows.Forms.ComboBox()
        Me.RankGasCentersBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RankDsExplosives3 = New Explosives.dsExplosives()
        Me.cmbPosition = New System.Windows.Forms.ComboBox()
        Me.cmdFirst = New System.Windows.Forms.CheckBox()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Frame7 = New System.Windows.Forms.GroupBox()
        Me.cmdNext = New System.Windows.Forms.CheckBox()
        Me.cmdLast = New System.Windows.Forms.CheckBox()
        Me.cmdPrev = New System.Windows.Forms.CheckBox()
        Me.StatesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Frame5 = New System.Windows.Forms.GroupBox()
        Me.cmbGasType = New System.Windows.Forms.ComboBox()
        Me.GasTypeGasCentersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GasTypeDsExplosives1 = New Explosives.dsExplosives()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdRefresh = New System.Windows.Forms.CheckBox()
        Me.MainMenu1 = New System.Windows.Forms.MenuStrip()
        Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog()
        Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog()
        Me.Frame3 = New System.Windows.Forms.GroupBox()
        Me.cmnDlgColor = New System.Windows.Forms.ColorDialog()
        Me.cmnDlgFont = New System.Windows.Forms.FontDialog()
        Me.GasCentersBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GasCentersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyGasCentersBindingSource7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompanyDsExplosives7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame6.SuspendLayout()
        Me.Frame9.SuspendLayout()
        CType(Me.NameGasCentersBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NameDsExplosives4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame1.SuspendLayout()
        CType(Me.TownshipGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TownshipDsExplosives5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CityDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateGasCentersBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StateDsExplosives2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionDsExplosives6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PositionGasCentersBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RankGasCentersBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RankDsExplosives3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame7.SuspendLayout()
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Frame5.SuspendLayout()
        CType(Me.GasTypeGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GasTypeDsExplosives1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainMenu1.SuspendLayout()
        Me.Frame3.SuspendLayout()
        CType(Me.GasCentersBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbCompany
        '
        Me.cmbCompany.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Company", True))
        Me.cmbCompany.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "Company", True))
        Me.cmbCompany.DataSource = Me.CompanyGasCentersBindingSource7
        Me.cmbCompany.DisplayMember = "Company"
        Me.cmbCompany.FormattingEnabled = True
        Me.cmbCompany.Location = New System.Drawing.Point(8, 63)
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.Size = New System.Drawing.Size(384, 21)
        Me.cmbCompany.TabIndex = 36
        Me.cmbCompany.ValueMember = "Company"
        '
        'GasCentersBindingSource
        '
        Me.GasCentersBindingSource.DataMember = "GasCenters"
        Me.GasCentersBindingSource.DataSource = Me.DsExplosives
        '
        'DsExplosives
        '
        Me.DsExplosives.DataSetName = "dsExplosives"
        Me.DsExplosives.EnforceConstraints = False
        Me.DsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CompanyGasCentersBindingSource7
        '
        Me.CompanyGasCentersBindingSource7.DataMember = "GasCenters"
        Me.CompanyGasCentersBindingSource7.DataSource = Me.CompanyDsExplosives7
        '
        'CompanyDsExplosives7
        '
        Me.CompanyDsExplosives7.DataSetName = "dsExplosives"
        Me.CompanyDsExplosives7.EnforceConstraints = False
        Me.CompanyDsExplosives7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.Frame6.Location = New System.Drawing.Point(22, 380)
        Me.Frame6.Name = "Frame6"
        Me.Frame6.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame6.Size = New System.Drawing.Size(681, 57)
        Me.Frame6.TabIndex = 74
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
        Me.cmdCancel.Location = New System.Drawing.Point(57, 16)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdCancel.Size = New System.Drawing.Size(81, 33)
        Me.cmdCancel.TabIndex = 37
        Me.cmdCancel.Text = "إلـــغــــاء"
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
        Me.cmdDelete.Location = New System.Drawing.Point(144, 16)
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
        Me.cmdEdit.Location = New System.Drawing.Point(248, 16)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdEdit.Size = New System.Drawing.Size(81, 33)
        Me.cmdEdit.TabIndex = 17
        Me.cmdEdit.Text = "تـــعـــديل"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdEdit.UseVisualStyleBackColor = False
        '
        'dtpCompanyLetterDate
        '
        Me.dtpCompanyLetterDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GasCentersBindingSource, "CompanyLetterDate", True))
        Me.dtpCompanyLetterDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "PermissionDate", True))
        Me.dtpCompanyLetterDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpCompanyLetterDate.Location = New System.Drawing.Point(226, 120)
        Me.dtpCompanyLetterDate.Name = "dtpCompanyLetterDate"
        Me.dtpCompanyLetterDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpCompanyLetterDate.TabIndex = 35
        '
        'dtpPermissionDate
        '
        Me.dtpPermissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GasCentersBindingSource, "PermissionDate", True))
        Me.dtpPermissionDate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "PermissionDate", True))
        Me.dtpPermissionDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpPermissionDate.Location = New System.Drawing.Point(8, 26)
        Me.dtpPermissionDate.Name = "dtpPermissionDate"
        Me.dtpPermissionDate.Size = New System.Drawing.Size(164, 20)
        Me.dtpPermissionDate.TabIndex = 35
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
        'Frame9
        '
        Me.Frame9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame9.Controls.Add(Me.btnPrintSecond)
        Me.Frame9.Controls.Add(Me.cmbPrintFirst)
        Me.Frame9.Controls.Add(Me.cmdReturn)
        Me.Frame9.Controls.Add(Me.cmdFound)
        Me.Frame9.Controls.Add(Me.cmdPrintAll)
        Me.Frame9.Controls.Add(Me.cmdExit)
        Me.Frame9.Controls.Add(Me.cmdLogout)
        Me.Frame9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame9.Location = New System.Drawing.Point(22, 72)
        Me.Frame9.Name = "Frame9"
        Me.Frame9.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame9.Size = New System.Drawing.Size(1153, 75)
        Me.Frame9.TabIndex = 79
        Me.Frame9.TabStop = False
        Me.Frame9.Text = "  خــيــــــــــــارات  "
        '
        'btnPrintSecond
        '
        Me.btnPrintSecond.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnPrintSecond.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.btnPrintSecond.ForeColor = System.Drawing.Color.White
        Me.btnPrintSecond.Location = New System.Drawing.Point(1075, 24)
        Me.btnPrintSecond.Name = "btnPrintSecond"
        Me.btnPrintSecond.Size = New System.Drawing.Size(70, 41)
        Me.btnPrintSecond.TabIndex = 48
        Me.btnPrintSecond.Text = "طباعة النهائي"
        Me.btnPrintSecond.UseVisualStyleBackColor = False
        Me.btnPrintSecond.Visible = False
        '
        'cmbPrintFirst
        '
        Me.cmbPrintFirst.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmbPrintFirst.Font = New System.Drawing.Font("Traditional Arabic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.cmbPrintFirst.ForeColor = System.Drawing.Color.White
        Me.cmbPrintFirst.Location = New System.Drawing.Point(860, 24)
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
        Me.cmdReturn.Location = New System.Drawing.Point(415, 24)
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
        Me.cmdFound.Location = New System.Drawing.Point(700, 24)
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
        Me.cmdPrintAll.Location = New System.Drawing.Point(565, 24)
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
        Me.cmdExit.Location = New System.Drawing.Point(119, 24)
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
        Me.cmdLogout.Location = New System.Drawing.Point(268, 24)
        Me.cmdLogout.Name = "cmdLogout"
        Me.cmdLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdLogout.Size = New System.Drawing.Size(129, 41)
        Me.cmdLogout.TabIndex = 43
        Me.cmdLogout.Text = "تسجيل خروج"
        Me.cmdLogout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdLogout.UseVisualStyleBackColor = False
        '
        'txtRepresentitive
        '
        Me.txtRepresentitive.AcceptsReturn = True
        Me.txtRepresentitive.BackColor = System.Drawing.SystemColors.Window
        Me.txtRepresentitive.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRepresentitive.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Representitive", True))
        Me.txtRepresentitive.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtRepresentitive.Location = New System.Drawing.Point(8, 86)
        Me.txtRepresentitive.MaxLength = 0
        Me.txtRepresentitive.Multiline = True
        Me.txtRepresentitive.Name = "txtRepresentitive"
        Me.txtRepresentitive.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtRepresentitive.Size = New System.Drawing.Size(383, 25)
        Me.txtRepresentitive.TabIndex = 29
        Me.txtRepresentitive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtId
        '
        Me.txtId.AcceptsReturn = True
        Me.txtId.BackColor = System.Drawing.SystemColors.Window
        Me.txtId.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtId.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "GasCenterID", True))
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
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(392, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(75, 24)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "مقدم الطلب"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label11.Visible = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(389, 114)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(86, 31)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "تاريخ خطاب الشركة"
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
        Me.Label10.Text = "اسم الشركة"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(168, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(57, 25)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "التاريخ"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'NameGasCentersBindingSource4
        '
        Me.NameGasCentersBindingSource4.DataMember = "GasCenters"
        Me.NameGasCentersBindingSource4.DataSource = Me.NameDsExplosives4
        '
        'NameDsExplosives4
        '
        Me.NameDsExplosives4.DataSetName = "dsExplosives"
        Me.NameDsExplosives4.EnforceConstraints = False
        Me.NameDsExplosives4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblPosition
        '
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
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
        'cmbName
        '
        Me.cmbName.BackColor = System.Drawing.SystemColors.Window
        Me.cmbName.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "Name", True))
        Me.cmbName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Name", True))
        Me.cmbName.DataSource = Me.NameGasCentersBindingSource4
        Me.cmbName.DisplayMember = "Name"
        Me.cmbName.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.Location = New System.Drawing.Point(180, 59)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbName.Size = New System.Drawing.Size(417, 21)
        Me.cmbName.TabIndex = 36
        Me.cmbName.ValueMember = "Name"
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame1.Controls.Add(Me.cmbTownships)
        Me.Frame1.Controls.Add(Me.cmbCities)
        Me.Frame1.Controls.Add(Me.cmbStates)
        Me.Frame1.Controls.Add(Me.txtBlock)
        Me.Frame1.Controls.Add(Me.txtLand)
        Me.Frame1.Controls.Add(Me.Label8)
        Me.Frame1.Controls.Add(Me.Label6)
        Me.Frame1.Controls.Add(Me.Label12)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(22, 147)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame1.Size = New System.Drawing.Size(681, 98)
        Me.Frame1.TabIndex = 73
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " بيانات الإتصال "
        '
        'cmbTownships
        '
        Me.cmbTownships.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Township", True))
        Me.cmbTownships.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "Township", True))
        Me.cmbTownships.DataSource = Me.TownshipGasCentersBindingSource1
        Me.cmbTownships.DisplayMember = "Township"
        Me.cmbTownships.FormattingEnabled = True
        Me.cmbTownships.Location = New System.Drawing.Point(262, 24)
        Me.cmbTownships.Name = "cmbTownships"
        Me.cmbTownships.Size = New System.Drawing.Size(121, 21)
        Me.cmbTownships.TabIndex = 16
        Me.cmbTownships.ValueMember = "Township"
        '
        'TownshipGasCentersBindingSource1
        '
        Me.TownshipGasCentersBindingSource1.DataMember = "GasCenters"
        Me.TownshipGasCentersBindingSource1.DataSource = Me.TownshipDsExplosives5
        '
        'TownshipDsExplosives5
        '
        Me.TownshipDsExplosives5.DataSetName = "dsExplosives"
        Me.TownshipDsExplosives5.EnforceConstraints = False
        Me.TownshipDsExplosives5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbCities
        '
        Me.cmbCities.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "City", True))
        Me.cmbCities.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "City", True))
        Me.cmbCities.DataSource = Me.CityGasCentersBindingSource1
        Me.cmbCities.DisplayMember = "City"
        Me.cmbCities.FormattingEnabled = True
        Me.cmbCities.Location = New System.Drawing.Point(43, 25)
        Me.cmbCities.Name = "cmbCities"
        Me.cmbCities.Size = New System.Drawing.Size(121, 21)
        Me.cmbCities.TabIndex = 16
        Me.cmbCities.ValueMember = "City"
        '
        'CityGasCentersBindingSource1
        '
        Me.CityGasCentersBindingSource1.DataMember = "GasCenters"
        Me.CityGasCentersBindingSource1.DataSource = Me.CityDsExplosives1
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
        Me.cmbStates.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "State", True))
        Me.cmbStates.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "State", True))
        Me.cmbStates.DataSource = Me.StateGasCentersBindingSource2
        Me.cmbStates.DisplayMember = "State"
        Me.cmbStates.FormattingEnabled = True
        Me.cmbStates.Location = New System.Drawing.Point(483, 29)
        Me.cmbStates.Name = "cmbStates"
        Me.cmbStates.Size = New System.Drawing.Size(121, 21)
        Me.cmbStates.TabIndex = 16
        Me.cmbStates.ValueMember = "State"
        '
        'StateGasCentersBindingSource2
        '
        Me.StateGasCentersBindingSource2.DataMember = "GasCenters"
        Me.StateGasCentersBindingSource2.DataSource = Me.StateDsExplosives2
        '
        'StateDsExplosives2
        '
        Me.StateDsExplosives2.DataSetName = "dsExplosives"
        Me.StateDsExplosives2.EnforceConstraints = False
        Me.StateDsExplosives2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtBlock
        '
        Me.txtBlock.AcceptsReturn = True
        Me.txtBlock.BackColor = System.Drawing.SystemColors.Window
        Me.txtBlock.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBlock.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Block", True))
        Me.txtBlock.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtBlock.Location = New System.Drawing.Point(262, 62)
        Me.txtBlock.MaxLength = 0
        Me.txtBlock.Multiline = True
        Me.txtBlock.Name = "txtBlock"
        Me.txtBlock.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtBlock.Size = New System.Drawing.Size(121, 25)
        Me.txtBlock.TabIndex = 14
        Me.txtBlock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLand
        '
        Me.txtLand.AcceptsReturn = True
        Me.txtLand.BackColor = System.Drawing.SystemColors.Window
        Me.txtLand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLand.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Land", True))
        Me.txtLand.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtLand.Location = New System.Drawing.Point(483, 63)
        Me.txtLand.MaxLength = 0
        Me.txtLand.Multiline = True
        Me.txtLand.Name = "txtLand"
        Me.txtLand.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtLand.Size = New System.Drawing.Size(121, 25)
        Me.txtLand.TabIndex = 14
        Me.txtLand.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(389, 63)
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
        Me.Label6.Size = New System.Drawing.Size(65, 25)
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
        'GasCentersTableAdapter
        '
        Me.GasCentersTableAdapter.ClearBeforeFill = True
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
        'PositionDsExplosives6
        '
        Me.PositionDsExplosives6.DataSetName = "dsExplosives"
        Me.PositionDsExplosives6.EnforceConstraints = False
        Me.PositionDsExplosives6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'StatesTableAdapter
        '
        Me.StatesTableAdapter.ClearBeforeFill = True
        '
        'PositionGasCentersBindingSource6
        '
        Me.PositionGasCentersBindingSource6.DataMember = "GasCenters"
        Me.PositionGasCentersBindingSource6.DataSource = Me.PositionDsExplosives6
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GroupBox1.Location = New System.Drawing.Point(22, 244)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(681, 135)
        Me.GroupBox1.TabIndex = 82
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "  صادر بأمـــــر  "
        '
        'cmbRank
        '
        Me.cmbRank.BackColor = System.Drawing.SystemColors.Window
        Me.cmbRank.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Rank", True))
        Me.cmbRank.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "Rank", True))
        Me.cmbRank.DataSource = Me.RankGasCentersBindingSource3
        Me.cmbRank.DisplayMember = "Rank"
        Me.cmbRank.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRank.Location = New System.Drawing.Point(180, 27)
        Me.cmbRank.Name = "cmbRank"
        Me.cmbRank.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbRank.Size = New System.Drawing.Size(417, 21)
        Me.cmbRank.TabIndex = 35
        Me.cmbRank.ValueMember = "Rank"
        '
        'RankGasCentersBindingSource3
        '
        Me.RankGasCentersBindingSource3.DataMember = "GasCenters"
        Me.RankGasCentersBindingSource3.DataSource = Me.RankDsExplosives3
        '
        'RankDsExplosives3
        '
        Me.RankDsExplosives3.DataSetName = "dsExplosives"
        Me.RankDsExplosives3.EnforceConstraints = False
        Me.RankDsExplosives3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbPosition
        '
        Me.cmbPosition.BackColor = System.Drawing.SystemColors.Window
        Me.cmbPosition.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "Position", True))
        Me.cmbPosition.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "Position", True))
        Me.cmbPosition.DataSource = Me.PositionGasCentersBindingSource6
        Me.cmbPosition.DisplayMember = "Position"
        Me.cmbPosition.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPosition.Location = New System.Drawing.Point(180, 91)
        Me.cmbPosition.Name = "cmbPosition"
        Me.cmbPosition.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmbPosition.Size = New System.Drawing.Size(417, 21)
        Me.cmbPosition.TabIndex = 37
        Me.cmbPosition.ValueMember = "Position"
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
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(224, 456)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Command1.Size = New System.Drawing.Size(121, 41)
        Me.Command1.TabIndex = 78
        Me.Command1.Text = "Command1"
        Me.Command1.UseVisualStyleBackColor = False
        Me.Command1.Visible = False
        '
        'Frame7
        '
        Me.Frame7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame7.Controls.Add(Me.cmdNext)
        Me.Frame7.Controls.Add(Me.cmdLast)
        Me.Frame7.Controls.Add(Me.cmdFirst)
        Me.Frame7.Controls.Add(Me.cmdPrev)
        Me.Frame7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame7.Location = New System.Drawing.Point(703, 378)
        Me.Frame7.Name = "Frame7"
        Me.Frame7.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame7.Size = New System.Drawing.Size(473, 57)
        Me.Frame7.TabIndex = 75
        Me.Frame7.TabStop = False
        Me.Frame7.Text = " التنقل بين السجلات "
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
        'StatesBindingSource
        '
        Me.StatesBindingSource.DataMember = "States"
        Me.StatesBindingSource.DataSource = Me.DsExplosives
        '
        'Frame5
        '
        Me.Frame5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Frame5.Controls.Add(Me.cmbGasType)
        Me.Frame5.Controls.Add(Me.cmbCompany)
        Me.Frame5.Controls.Add(Me.dtpCompanyLetterDate)
        Me.Frame5.Controls.Add(Me.dtpPermissionDate)
        Me.Frame5.Controls.Add(Me.txtRepresentitive)
        Me.Frame5.Controls.Add(Me.txtId)
        Me.Frame5.Controls.Add(Me.Label11)
        Me.Frame5.Controls.Add(Me.Label13)
        Me.Frame5.Controls.Add(Me.Label5)
        Me.Frame5.Controls.Add(Me.Label10)
        Me.Frame5.Controls.Add(Me.Label9)
        Me.Frame5.Controls.Add(Me.Label15)
        Me.Frame5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame5.Location = New System.Drawing.Point(702, 147)
        Me.Frame5.Name = "Frame5"
        Me.Frame5.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame5.Size = New System.Drawing.Size(473, 150)
        Me.Frame5.TabIndex = 77
        Me.Frame5.TabStop = False
        Me.Frame5.Text = " بيانات الملف "
        '
        'cmbGasType
        '
        Me.cmbGasType.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.GasCentersBindingSource, "GasType", True))
        Me.cmbGasType.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GasCentersBindingSource, "GasType", True))
        Me.cmbGasType.DataSource = Me.GasTypeGasCentersBindingSource1
        Me.cmbGasType.DisplayMember = "GasType"
        Me.cmbGasType.FormattingEnabled = True
        Me.cmbGasType.Location = New System.Drawing.Point(10, 119)
        Me.cmbGasType.Name = "cmbGasType"
        Me.cmbGasType.Size = New System.Drawing.Size(135, 21)
        Me.cmbGasType.TabIndex = 36
        Me.cmbGasType.ValueMember = "GasType"
        '
        'GasTypeGasCentersBindingSource1
        '
        Me.GasTypeGasCentersBindingSource1.DataMember = "GasCenters"
        Me.GasTypeGasCentersBindingSource1.DataSource = Me.GasTypeDsExplosives1
        '
        'GasTypeDsExplosives1
        '
        Me.GasTypeDsExplosives1.DataSetName = "dsExplosives"
        Me.GasTypeDsExplosives1.EnforceConstraints = False
        Me.GasTypeDsExplosives1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(151, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(66, 24)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "نوع الغاز"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Appearance = System.Windows.Forms.Appearance.Button
        Me.cmdRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.cmdRefresh.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRefresh.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.cmdRefresh.Location = New System.Drawing.Point(-88, -8)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.cmdRefresh.Size = New System.Drawing.Size(1361, 33)
        Me.cmdRefresh.TabIndex = 80
        Me.cmdRefresh.Text = "تـــــــحــــديـــــــث البيـــــــانات"
        Me.cmdRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cmdRefresh.UseVisualStyleBackColor = False
        '
        'MainMenu1
        '
        Me.MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuColours})
        Me.MainMenu1.Location = New System.Drawing.Point(0, 0)
        Me.MainMenu1.Name = "MainMenu1"
        Me.MainMenu1.Size = New System.Drawing.Size(1185, 24)
        Me.MainMenu1.TabIndex = 81
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
        Me.Frame3.Location = New System.Drawing.Point(703, 297)
        Me.Frame3.Name = "Frame3"
        Me.Frame3.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Frame3.Size = New System.Drawing.Size(473, 82)
        Me.Frame3.TabIndex = 76
        Me.Frame3.TabStop = False
        Me.Frame3.Text = " الـبــــحــــــث "
        '
        'GasCentersBindingSource5
        '
        Me.GasCentersBindingSource5.DataMember = "GasCenters"
        Me.GasCentersBindingSource5.DataSource = Me.TownshipDsExplosives5
        '
        'frmGasCenter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1185, 486)
        Me.Controls.Add(Me.Frame6)
        Me.Controls.Add(Me.Frame9)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Frame7)
        Me.Controls.Add(Me.Frame5)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.MainMenu1)
        Me.Controls.Add(Me.Frame3)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(15, 57)
        Me.Name = "frmGasCenter"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "تصاديق مراكز الغاز"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.GasCentersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyGasCentersBindingSource7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompanyDsExplosives7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame6.ResumeLayout(False)
        Me.Frame9.ResumeLayout(False)
        CType(Me.NameGasCentersBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NameDsExplosives4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        CType(Me.TownshipGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TownshipDsExplosives5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CityDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateGasCentersBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StateDsExplosives2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionDsExplosives6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PositionGasCentersBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RankGasCentersBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RankDsExplosives3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame7.ResumeLayout(False)
        CType(Me.StatesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Frame5.ResumeLayout(False)
        Me.Frame5.PerformLayout()
        CType(Me.GasTypeGasCentersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GasTypeDsExplosives1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainMenu1.ResumeLayout(False)
        Me.MainMenu1.PerformLayout()
        Me.Frame3.ResumeLayout(False)
        Me.Frame3.PerformLayout()
        CType(Me.GasCentersBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbCompany As System.Windows.Forms.ComboBox
    Friend WithEvents GasCentersBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DsExplosives As Explosives.dsExplosives
    Friend WithEvents CompanyGasCentersBindingSource7 As System.Windows.Forms.BindingSource
    Friend WithEvents CompanyDsExplosives7 As Explosives.dsExplosives
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Frame6 As System.Windows.Forms.GroupBox
    Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
    Public WithEvents cmdSave As System.Windows.Forms.CheckBox
    Public WithEvents cmdNew As System.Windows.Forms.CheckBox
    Public WithEvents cmdDelete As System.Windows.Forms.CheckBox
    Public WithEvents cmdEdit As System.Windows.Forms.CheckBox
    Friend WithEvents dtpCompanyLetterDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpPermissionDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmbCriteria As System.Windows.Forms.ComboBox
    Public WithEvents cmdFindNext As System.Windows.Forms.CheckBox
    Public WithEvents Frame9 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbPrintFirst As System.Windows.Forms.Button
    Public WithEvents cmdReturn As System.Windows.Forms.CheckBox
    Public WithEvents cmdFound As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrintAll As System.Windows.Forms.CheckBox
    Public WithEvents cmdExit As System.Windows.Forms.CheckBox
    Public WithEvents cmdLogout As System.Windows.Forms.CheckBox
    Public WithEvents txtRepresentitive As System.Windows.Forms.TextBox
    Public WithEvents txtId As System.Windows.Forms.TextBox
    Public WithEvents mnuColours As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents cmdFindPrev As System.Windows.Forms.CheckBox
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtFind As System.Windows.Forms.TextBox
    Friend WithEvents NameGasCentersBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents NameDsExplosives4 As Explosives.dsExplosives
    Public WithEvents lblPosition As System.Windows.Forms.Label
    Public WithEvents cmbName As System.Windows.Forms.ComboBox
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbTownships As System.Windows.Forms.ComboBox
    Friend WithEvents TownshipGasCentersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TownshipDsExplosives5 As Explosives.dsExplosives
    Friend WithEvents cmbCities As System.Windows.Forms.ComboBox
    Friend WithEvents CityGasCentersBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CityDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents cmbStates As System.Windows.Forms.ComboBox
    Friend WithEvents StateGasCentersBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StateDsExplosives2 As Explosives.dsExplosives
    Public WithEvents txtBlock As System.Windows.Forms.TextBox
    Public WithEvents txtLand As System.Windows.Forms.TextBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GasCentersTableAdapter As Explosives.dsExplosivesTableAdapters.GasCentersTableAdapter
    Public WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PositionDsExplosives6 As Explosives.dsExplosives
    Public WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents StatesTableAdapter As Explosives.dsExplosivesTableAdapters.StatesTableAdapter
    Friend WithEvents PositionGasCentersBindingSource6 As System.Windows.Forms.BindingSource
    Public WithEvents cmnDlgPrint As System.Windows.Forms.PrintDialog
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmbRank As System.Windows.Forms.ComboBox
    Friend WithEvents RankGasCentersBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents RankDsExplosives3 As Explosives.dsExplosives
    Public WithEvents cmbPosition As System.Windows.Forms.ComboBox
    Public WithEvents cmdFirst As System.Windows.Forms.CheckBox
    Public WithEvents Command1 As System.Windows.Forms.Button
    Public WithEvents Frame7 As System.Windows.Forms.GroupBox
    Public WithEvents cmdNext As System.Windows.Forms.CheckBox
    Public WithEvents cmdLast As System.Windows.Forms.CheckBox
    Public WithEvents cmdPrev As System.Windows.Forms.CheckBox
    Friend WithEvents StatesBindingSource As System.Windows.Forms.BindingSource
    Public WithEvents Frame5 As System.Windows.Forms.GroupBox
    Public WithEvents cmdRefresh As System.Windows.Forms.CheckBox
    Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
    Public WithEvents cmnDlgOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmnDlgSave As System.Windows.Forms.SaveFileDialog
    Public WithEvents Frame3 As System.Windows.Forms.GroupBox
    Public WithEvents cmnDlgColor As System.Windows.Forms.ColorDialog
    Public WithEvents cmnDlgFont As System.Windows.Forms.FontDialog
    Friend WithEvents GasCentersBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents cmbGasType As System.Windows.Forms.ComboBox
    Friend WithEvents GasTypeGasCentersBindingSource1 As System.Windows.Forms.BindingSource
    Public WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents GasTypeDsExplosives1 As Explosives.dsExplosives
    Friend WithEvents btnPrintSecond As System.Windows.Forms.Button
End Class
