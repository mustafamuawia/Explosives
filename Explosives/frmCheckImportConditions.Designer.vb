<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmCheckConditions
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
	Public WithEvents Timer3 As System.Windows.Forms.Timer
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents cmdCancel As System.Windows.Forms.CheckBox
	Public WithEvents cmdOK As System.Windows.Forms.CheckBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents List1 As System.Windows.Forms.CheckedListBox
	Public cmnDlgOpen As System.Windows.Forms.OpenFileDialog
	Public cmnDlgSave As System.Windows.Forms.SaveFileDialog
	Public cmnDlgFont As System.Windows.Forms.FontDialog
	Public cmnDlgColor As System.Windows.Forms.ColorDialog
	Public cmnDlgPrint As System.Windows.Forms.PrintDialog
	Public WithEvents Label1 As System.Windows.Forms.Label
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckConditions))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.Timer3 = New System.Windows.Forms.Timer(components)
		Me.Timer2 = New System.Windows.Forms.Timer(components)
		Me.cmdCancel = New System.Windows.Forms.CheckBox
		Me.cmdOK = New System.Windows.Forms.CheckBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.List1 = New System.Windows.Forms.CheckedListBox
		Me.cmnDlgOpen = New System.Windows.Forms.OpenFileDialog
		Me.cmnDlgSave = New System.Windows.Forms.SaveFileDialog
		Me.cmnDlgFont = New System.Windows.Forms.FontDialog
		Me.cmnDlgColor = New System.Windows.Forms.ColorDialog
		Me.cmnDlgPrint = New System.Windows.Forms.PrintDialog
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.BackColor = System.Drawing.Color.FromARGB(255, 128, 128)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = " √ﬂÌœ «·‘—Êÿ «··«“„… ·≈” Œ—«Ã ≈–‰ ≈” Ì—«œ"
		Me.ClientSize = New System.Drawing.Size(748, 602)
		Me.Location = New System.Drawing.Point(0, 0)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmCheckConditions"
		Me.Timer3.Interval = 1
		Me.Timer3.Enabled = True
		Me.Timer2.Enabled = False
		Me.Timer2.Interval = 1
		Me.cmdCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdCancel.BackColor = System.Drawing.Color.FromARGB(0, 64, 0)
		Me.cmdCancel.Text = "≈·‹‹‹€‹‹‹‹«¡"
		Me.cmdCancel.ForeColor = System.Drawing.Color.White
		Me.cmdCancel.Size = New System.Drawing.Size(97, 33)
		Me.cmdCancel.Location = New System.Drawing.Point(120, 4)
		Me.cmdCancel.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdCancel.TabIndex = 2
		Me.cmdCancel.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdCancel.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdCancel.CausesValidation = True
		Me.cmdCancel.Enabled = True
		Me.cmdCancel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdCancel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdCancel.TabStop = True
		Me.cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdCancel.Visible = True
		Me.cmdCancel.Name = "cmdCancel"
		Me.cmdOK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdOK.BackColor = System.Drawing.Color.FromARGB(255, 192, 192)
		Me.cmdOK.Text = "„Ê«›ﬁ"
		Me.cmdOK.Enabled = False
		Me.cmdOK.Size = New System.Drawing.Size(97, 33)
		Me.cmdOK.Location = New System.Drawing.Point(224, 4)
		Me.cmdOK.Appearance = System.Windows.Forms.Appearance.Button
		Me.cmdOK.TabIndex = 1
		Me.cmdOK.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.cmdOK.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.cmdOK.CausesValidation = True
		Me.cmdOK.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdOK.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdOK.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdOK.TabStop = True
		Me.cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.cmdOK.Visible = True
		Me.cmdOK.Name = "cmdOK"
		Me.Timer1.Interval = 1
		Me.Timer1.Enabled = True
		Me.List1.BackColor = System.Drawing.Color.FromARGB(255, 192, 192)
		Me.List1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.List1.Size = New System.Drawing.Size(513, 533)
		Me.List1.Location = New System.Drawing.Point(120, 40)
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.List1.TabIndex = 0
		Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.MultiColumn = False
		Me.List1.Name = "List1"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
		Me.Label1.Text = "«· Õﬁﬁ „‰ ‘—Êÿ ≈÷«›… ≈–‰ «·≈” ‹‹‹‹‹‹‹‹‹‹‹‹‹Ì—«œ :"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.White
		Me.Label1.Size = New System.Drawing.Size(313, 25)
		Me.Label1.Location = New System.Drawing.Point(320, 8)
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.Label1.TabIndex = 3
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(cmdCancel)
		Me.Controls.Add(cmdOK)
		Me.Controls.Add(List1)
		Me.Controls.Add(Label1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class