<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmPassWords
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
    'Public WithEvents txtPassword As AxMicrosoft.Vbe.Interop.Forms.AxTextBox
    'Public WithEvents txtNew As AxMicrosoft.Vbe.Interop.Forms.AxTextBox
    'Public WithEvents txtConfirm As AxMicrosoft.Vbe.Interop.Forms.AxTextBox
    'Public WithEvents Command2 As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents Check1 As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
    'Public WithEvents Command1 As AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
	Public WithEvents lblConfirm As System.Windows.Forms.Label
	Public WithEvents lblNew As System.Windows.Forms.Label
	Public WithEvents lblRecentUserPass As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmPassWords))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
        'Me.txtPassword = New AxMicrosoft.Vbe.Interop.Forms.AxTextBox
        'Me.txtNew = New AxMicrosoft.Vbe.Interop.Forms.AxTextBox
        'Me.txtConfirm = New AxMicrosoft.Vbe.Interop.Forms.AxTextBox
        'Me.Command2 = New AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
        'Me.Check1 = New AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
        'Me.Command1 = New AxMicrosoft.Vbe.Interop.Forms.AxCommandButton
		Me.lblConfirm = New System.Windows.Forms.Label
		Me.lblNew = New System.Windows.Forms.Label
		Me.lblRecentUserPass = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
        'CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.txtNew, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.txtConfirm, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Command2, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Check1, System.ComponentModel.ISupportInitialize).BeginInit()
        'CType(Me.Command1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form2"
		Me.ClientSize = New System.Drawing.Size(850, 472)
		Me.Location = New System.Drawing.Point(4, 4)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmPassWords.BackgroundImage"), System.Drawing.Image)
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmPassWords"
		Me.Timer1.Interval = 1
		Me.Timer1.Enabled = True
        'txtPassword.OcxState = CType(resources.GetObject("txtPassword.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.txtPassword.AutoSize = False
        'Me.txtPassword.Size = New System.Drawing.Size(305, 33)
        'Me.txtPassword.Location = New System.Drawing.Point(240, 128)
        'Me.txtPassword.TabIndex = 0
        'Me.txtPassword.Name = "txtPassword"
        'txtNew.OcxState = CType(resources.GetObject("txtNew.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.txtNew.AutoSize = False
        'Me.txtNew.Size = New System.Drawing.Size(305, 33)
        'Me.txtNew.Location = New System.Drawing.Point(240, 172)
        'Me.txtNew.TabIndex = 1
        'Me.txtNew.Name = "txtNew"
        'txtConfirm.OcxState = CType(resources.GetObject("txtConfirm.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.txtConfirm.AutoSize = False
        'Me.txtConfirm.Size = New System.Drawing.Size(305, 33)
        'Me.txtConfirm.Location = New System.Drawing.Point(240, 216)
        'Me.txtConfirm.TabIndex = 2
        'Me.txtConfirm.Name = "txtConfirm"
        'Command2.OcxState = CType(resources.GetObject("Command2.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Command2.Size = New System.Drawing.Size(81, 33)
        'Me.Command2.Location = New System.Drawing.Point(152, 172)
        'Me.Command2.TabIndex = 4
        'Me.Command2.Name = "Command2"
        'Check1.OcxState = CType(resources.GetObject("Check1.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Check1.Size = New System.Drawing.Size(81, 33)
        'Me.Check1.Location = New System.Drawing.Point(152, 216)
        'Me.Check1.TabIndex = 5
        'Me.Check1.Name = "Check1"
        'Command1.OcxState = CType(resources.GetObject("Command1.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.Command1.Size = New System.Drawing.Size(81, 33)
        'Me.Command1.Location = New System.Drawing.Point(152, 128)
        'Me.Command1.TabIndex = 3
        'Me.Command1.Name = "Command1"
		Me.lblConfirm.BackColor = System.Drawing.Color.Transparent
		Me.lblConfirm.Text = " √ﬂÌœ ﬂ·„… «·”— «·ÃœÌœ…"
		Me.lblConfirm.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblConfirm.ForeColor = System.Drawing.Color.FromARGB(192, 0, 192)
		Me.lblConfirm.Size = New System.Drawing.Size(146, 23)
		Me.lblConfirm.Location = New System.Drawing.Point(552, 224)
		Me.lblConfirm.TabIndex = 8
		Me.lblConfirm.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblConfirm.Enabled = True
		Me.lblConfirm.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblConfirm.UseMnemonic = True
		Me.lblConfirm.Visible = True
		Me.lblConfirm.AutoSize = True
		Me.lblConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblConfirm.Name = "lblConfirm"
		Me.lblNew.BackColor = System.Drawing.Color.Transparent
		Me.lblNew.Text = "ﬂ·„… «·”— «·ÃœÌœ…"
		Me.lblNew.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblNew.ForeColor = System.Drawing.Color.FromARGB(192, 0, 192)
		Me.lblNew.Size = New System.Drawing.Size(111, 23)
		Me.lblNew.Location = New System.Drawing.Point(552, 176)
		Me.lblNew.TabIndex = 7
		Me.lblNew.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblNew.Enabled = True
		Me.lblNew.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblNew.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblNew.UseMnemonic = True
		Me.lblNew.Visible = True
		Me.lblNew.AutoSize = True
		Me.lblNew.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblNew.Name = "lblNew"
		Me.lblRecentUserPass.BackColor = System.Drawing.Color.Transparent
		Me.lblRecentUserPass.Text = "ﬂ·„… «·”— «·Õ«·Ì…"
		Me.lblRecentUserPass.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblRecentUserPass.ForeColor = System.Drawing.Color.FromARGB(192, 0, 192)
		Me.lblRecentUserPass.Size = New System.Drawing.Size(108, 23)
		Me.lblRecentUserPass.Location = New System.Drawing.Point(552, 136)
		Me.lblRecentUserPass.TabIndex = 6
		Me.lblRecentUserPass.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblRecentUserPass.Enabled = True
		Me.lblRecentUserPass.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblRecentUserPass.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblRecentUserPass.UseMnemonic = True
		Me.lblRecentUserPass.Visible = True
		Me.lblRecentUserPass.AutoSize = True
		Me.lblRecentUserPass.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblRecentUserPass.Name = "lblRecentUserPass"
		Me.Image1.Size = New System.Drawing.Size(857, 471)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
        'Me.Controls.Add(txtPassword)
        'Me.Controls.Add(txtNew)
        'Me.Controls.Add(txtConfirm)
        'Me.Controls.Add(Command2)
        'Me.Controls.Add(Check1)
        'Me.Controls.Add(Command1)
		Me.Controls.Add(lblConfirm)
		Me.Controls.Add(lblNew)
		Me.Controls.Add(lblRecentUserPass)
		Me.Controls.Add(Image1)
        'CType(Me.Command1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Check1, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.Command2, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.txtConfirm, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.txtNew, System.ComponentModel.ISupportInitialize).EndInit()
        'CType(Me.txtPassword, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class