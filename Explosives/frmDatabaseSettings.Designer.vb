<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDatabaseSettings
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
        Me.txtSQLPassword = New System.Windows.Forms.TextBox()
        Me.txtSQLUser = New System.Windows.Forms.TextBox()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnGetDatabaseServers = New System.Windows.Forms.Button()
        Me.cbDataBases = New System.Windows.Forms.ComboBox()
        Me.lblDataBases = New System.Windows.Forms.Label()
        Me.btnConnectionTest = New System.Windows.Forms.Button()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.cbServerName = New System.Windows.Forms.ComboBox()
        Me.lblServerName = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtSQLPassword
        '
        Me.txtSQLPassword.Location = New System.Drawing.Point(481, 175)
        Me.txtSQLPassword.Name = "txtSQLPassword"
        Me.txtSQLPassword.Size = New System.Drawing.Size(218, 27)
        Me.txtSQLPassword.TabIndex = 22
        Me.txtSQLPassword.UseSystemPasswordChar = True
        '
        'txtSQLUser
        '
        Me.txtSQLUser.Location = New System.Drawing.Point(171, 175)
        Me.txtSQLUser.Name = "txtSQLUser"
        Me.txtSQLUser.Size = New System.Drawing.Size(142, 27)
        Me.txtSQLUser.TabIndex = 23
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"Windows", "SQL"})
        Me.comboBox1.Location = New System.Drawing.Point(170, 121)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(143, 27)
        Me.comboBox1.TabIndex = 21
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(409, 284)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnCancel.Size = New System.Drawing.Size(194, 55)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.Text = "إلغاء الأمر"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(144, 284)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnSave.Size = New System.Drawing.Size(194, 55)
        Me.btnSave.TabIndex = 19
        Me.btnSave.Text = "حفظ الإعدادات"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnGetDatabaseServers
        '
        Me.btnGetDatabaseServers.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGetDatabaseServers.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnGetDatabaseServers.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnGetDatabaseServers.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetDatabaseServers.ForeColor = System.Drawing.Color.White
        Me.btnGetDatabaseServers.Location = New System.Drawing.Point(481, 57)
        Me.btnGetDatabaseServers.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetDatabaseServers.Name = "btnGetDatabaseServers"
        Me.btnGetDatabaseServers.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnGetDatabaseServers.Size = New System.Drawing.Size(218, 37)
        Me.btnGetDatabaseServers.TabIndex = 15
        Me.btnGetDatabaseServers.Text = "ابحث عن المخدم"
        Me.btnGetDatabaseServers.UseVisualStyleBackColor = False
        '
        'cbDataBases
        '
        Me.cbDataBases.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbDataBases.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDataBases.FormattingEnabled = True
        Me.cbDataBases.Location = New System.Drawing.Point(170, 229)
        Me.cbDataBases.Margin = New System.Windows.Forms.Padding(4)
        Me.cbDataBases.Name = "cbDataBases"
        Me.cbDataBases.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbDataBases.Size = New System.Drawing.Size(260, 27)
        Me.cbDataBases.TabIndex = 17
        '
        'lblDataBases
        '
        Me.lblDataBases.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDataBases.AutoSize = True
        Me.lblDataBases.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataBases.Location = New System.Drawing.Point(42, 232)
        Me.lblDataBases.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDataBases.Name = "lblDataBases"
        Me.lblDataBases.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblDataBases.Size = New System.Drawing.Size(104, 19)
        Me.lblDataBases.TabIndex = 16
        Me.lblDataBases.Text = "قواعد البيانات:"
        '
        'btnConnectionTest
        '
        Me.btnConnectionTest.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConnectionTest.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnConnectionTest.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnConnectionTest.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectionTest.ForeColor = System.Drawing.Color.White
        Me.btnConnectionTest.Location = New System.Drawing.Point(481, 229)
        Me.btnConnectionTest.Margin = New System.Windows.Forms.Padding(4)
        Me.btnConnectionTest.Name = "btnConnectionTest"
        Me.btnConnectionTest.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnConnectionTest.Size = New System.Drawing.Size(218, 37)
        Me.btnConnectionTest.TabIndex = 18
        Me.btnConnectionTest.Text = "اختبار الاتصال"
        Me.btnConnectionTest.UseVisualStyleBackColor = False
        '
        'label3
        '
        Me.label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.Location = New System.Drawing.Point(382, 177)
        Me.label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label3.Name = "label3"
        Me.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label3.Size = New System.Drawing.Size(92, 19)
        Me.label3.TabIndex = 11
        Me.label3.Text = "كلمة المرور:"
        '
        'label2
        '
        Me.label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(24, 177)
        Me.label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label2.Name = "label2"
        Me.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label2.Size = New System.Drawing.Size(122, 19)
        Me.label2.TabIndex = 10
        Me.label2.Text = "اسم المستخدم:"
        '
        'label1
        '
        Me.label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(41, 123)
        Me.label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.label1.Name = "label1"
        Me.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.label1.Size = New System.Drawing.Size(105, 19)
        Me.label1.TabIndex = 12
        Me.label1.Text = "طريقة الدخول:"
        '
        'cbServerName
        '
        Me.cbServerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbServerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbServerName.FormattingEnabled = True
        Me.cbServerName.Location = New System.Drawing.Point(170, 61)
        Me.cbServerName.Margin = New System.Windows.Forms.Padding(4)
        Me.cbServerName.Name = "cbServerName"
        Me.cbServerName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cbServerName.Size = New System.Drawing.Size(260, 27)
        Me.cbServerName.TabIndex = 14
        '
        'lblServerName
        '
        Me.lblServerName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblServerName.AutoSize = True
        Me.lblServerName.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServerName.Location = New System.Drawing.Point(47, 64)
        Me.lblServerName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServerName.Name = "lblServerName"
        Me.lblServerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblServerName.Size = New System.Drawing.Size(99, 19)
        Me.lblServerName.TabIndex = 13
        Me.lblServerName.Text = "اسم المخدم:"
        '
        'frmDatabaseSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(722, 397)
        Me.Controls.Add(Me.txtSQLPassword)
        Me.Controls.Add(Me.txtSQLUser)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnGetDatabaseServers)
        Me.Controls.Add(Me.cbDataBases)
        Me.Controls.Add(Me.lblDataBases)
        Me.Controls.Add(Me.btnConnectionTest)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.cbServerName)
        Me.Controls.Add(Me.lblServerName)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDatabaseSettings"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "اعدادات قواعد البيانات"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtSQLPassword As System.Windows.Forms.TextBox
    Private WithEvents txtSQLUser As System.Windows.Forms.TextBox
    Private WithEvents comboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents btnSave As System.Windows.Forms.Button
    Private WithEvents btnGetDatabaseServers As System.Windows.Forms.Button
    Private WithEvents cbDataBases As System.Windows.Forms.ComboBox
    Private WithEvents lblDataBases As System.Windows.Forms.Label
    Private WithEvents btnConnectionTest As System.Windows.Forms.Button
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents cbServerName As System.Windows.Forms.ComboBox
    Private WithEvents lblServerName As System.Windows.Forms.Label
End Class
