<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmAbout
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
	Public WithEvents cmdSysInfo As System.Windows.Forms.Button
	Public WithEvents cmdOK As System.Windows.Forms.Button
	Public WithEvents picIcon As System.Windows.Forms.PictureBox
	Public WithEvents lblDescription As System.Windows.Forms.Label
	Public WithEvents lblDisclaimer As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents lblTitle As System.Windows.Forms.Label
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAbout))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdSysInfo = New System.Windows.Forms.Button
		Me.cmdOK = New System.Windows.Forms.Button
		Me.picIcon = New System.Windows.Forms.PictureBox
		Me.lblDescription = New System.Windows.Forms.Label
		Me.lblDisclaimer = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.lblTitle = New System.Windows.Forms.Label
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.InactiveBorder
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "About MyApp"
		Me.ClientSize = New System.Drawing.Size(999, 586)
		Me.Location = New System.Drawing.Point(153, 103)
		Me.Icon = CType(resources.GetObject("frmAbout.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmAbout.BackgroundImage"), System.Drawing.Image)
		Me.ShowInTaskbar = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmAbout"
		Me.cmdSysInfo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.cmdSysInfo.Size = New System.Drawing.Size(123, 39)
		Me.cmdSysInfo.Location = New System.Drawing.Point(592, 536)
		Me.cmdSysInfo.Image = CType(resources.GetObject("cmdSysInfo.Image"), System.Drawing.Image)
		Me.cmdSysInfo.TabIndex = 5
		Me.cmdSysInfo.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSysInfo.CausesValidation = True
		Me.cmdSysInfo.Enabled = True
		Me.cmdSysInfo.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSysInfo.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSysInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSysInfo.TabStop = True
		Me.cmdSysInfo.Name = "cmdSysInfo"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter
		Me.CancelButton = Me.cmdOK
		Me.AcceptButton = Me.cmdOK
		Me.cmdOK.Size = New System.Drawing.Size(76, 39)
		Me.cmdOK.Location = New System.Drawing.Point(728, 536)
		Me.cmdOK.Image = CType(resources.GetObject("cmdOK.Image"), System.Drawing.Image)
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.cmdOK.TabIndex = 2
		Me.cmdOK.BackColor = System.Drawing.SystemColors.Control
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.Enabled = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.TabStop = True
		Me.cmdOK.Name = "cmdOK"
		Me.picIcon.BackColor = System.Drawing.Color.Black
		Me.picIcon.Size = New System.Drawing.Size(32, 32)
		Me.picIcon.Location = New System.Drawing.Point(496, 496)
		Me.picIcon.Image = CType(resources.GetObject("picIcon.Image"), System.Drawing.Image)
		Me.picIcon.TabIndex = 0
		Me.picIcon.Dock = System.Windows.Forms.DockStyle.None
		Me.picIcon.CausesValidation = True
		Me.picIcon.Enabled = True
		Me.picIcon.ForeColor = System.Drawing.SystemColors.ControlText
		Me.picIcon.Cursor = System.Windows.Forms.Cursors.Default
		Me.picIcon.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.picIcon.TabStop = True
		Me.picIcon.Visible = True
		Me.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
		Me.picIcon.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.picIcon.Name = "picIcon"
		Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDescription.Text = " „ «· ’„Ì„ Ê «·»—„Ã… »Ê«”ÿ… „—ﬂ“ ‰Ÿ„ "
		Me.lblDescription.Font = New System.Drawing.Font("Traditional Arabic", 36!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblDescription.ForeColor = System.Drawing.Color.Black
		Me.lblDescription.Size = New System.Drawing.Size(587, 78)
		Me.lblDescription.Location = New System.Drawing.Point(200, 192)
		Me.lblDescription.TabIndex = 6
		Me.lblDescription.BackColor = System.Drawing.Color.Transparent
		Me.lblDescription.Enabled = True
		Me.lblDescription.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblDescription.UseMnemonic = True
		Me.lblDescription.Visible = True
		Me.lblDescription.AutoSize = False
		Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDescription.Name = "lblDescription"
		Me.lblDisclaimer.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblDisclaimer.Text = "Ã„Ì⁄ «·ÕﬁÊﬁ „Õ›ÊŸ… ·„—ﬂ“ ‰Ÿ„ «·„⁄·Ê„«  Ê «·≈ ’«·«  _ ”·«Õ «·√”·Õ… Ê «·–Œ«∆—"
		Me.lblDisclaimer.Font = New System.Drawing.Font("Traditional Arabic", 18!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblDisclaimer.ForeColor = System.Drawing.Color.White
		Me.lblDisclaimer.Size = New System.Drawing.Size(303, 74)
		Me.lblDisclaimer.Location = New System.Drawing.Point(538, 464)
		Me.lblDisclaimer.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.lblDisclaimer.TabIndex = 4
		Me.lblDisclaimer.BackColor = System.Drawing.Color.Transparent
		Me.lblDisclaimer.Enabled = True
		Me.lblDisclaimer.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblDisclaimer.UseMnemonic = True
		Me.lblDisclaimer.Visible = True
		Me.lblDisclaimer.AutoSize = True
		Me.lblDisclaimer.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblDisclaimer.Name = "lblDisclaimer"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.Text = "«·„⁄·Ê„«  Ê «·≈ ’«·«  »”·«Õ «·√”·Õ… Ê «·–Œ«∆—"
		Me.Label1.Font = New System.Drawing.Font("Traditional Arabic", 36!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Black
		Me.Label1.Size = New System.Drawing.Size(529, 65)
		Me.Label1.Location = New System.Drawing.Point(217, 262)
		Me.Label1.TabIndex = 3
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.lblTitle.Text = "≈œ«—… «·„›—ﬁ⁄« "
		Me.lblTitle.Font = New System.Drawing.Font("Traditional Arabic", 36!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.lblTitle.ForeColor = System.Drawing.Color.Black
		Me.lblTitle.Size = New System.Drawing.Size(251, 60)
		Me.lblTitle.Location = New System.Drawing.Point(380, 136)
		Me.lblTitle.TabIndex = 1
		Me.lblTitle.BackColor = System.Drawing.Color.Transparent
		Me.lblTitle.Enabled = True
		Me.lblTitle.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblTitle.UseMnemonic = True
		Me.lblTitle.Visible = True
		Me.lblTitle.AutoSize = False
		Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblTitle.Name = "lblTitle"
		Me.Image1.Enabled = False
		Me.Image1.Size = New System.Drawing.Size(999, 586)
		Me.Image1.Location = New System.Drawing.Point(0, 0)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Controls.Add(cmdSysInfo)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(picIcon)
		Me.Controls.Add(lblDescription)
		Me.Controls.Add(lblDisclaimer)
		Me.Controls.Add(Label1)
		Me.Controls.Add(lblTitle)
		Me.Controls.Add(Image1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class