Option Strict Off
Option Explicit On
Friend Class frmCheckNoObjections
	Inherits System.Windows.Forms.Form
	Private ToBeAdded As Boolean
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/„‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›… ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
				ToBeAdded = False
				frmNoObjections.cmdRefresh.CheckState = System.Windows.Forms.CheckState.Checked
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
				Timer2.Enabled = True
				
				' EnDis False, False, True
			Else
				'UPGRADE_WARNING: Form method frmCheckNoObjections.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				Me.BringToFront()
			End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdOK.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdOK_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.CheckStateChanged
		If cmdOK.CheckState = 1 Then
			ToBeAdded = True
			Timer2.Enabled = True
			frmCheckFinance.Show()
			cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	Private Sub frmCheckNoObjections_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim i As Object
		On Error Resume Next
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) + 500)
        'Dim RS As New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS.Open("Select * From NoObjectionConditions Where Condition Is Not Null Order By Condition ", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'List1.Items.Clear()
        'For i = 1 To RS.RecordCount
        '	List1.Items.Add(RS.Fields("Condition").Value)
        '	RS.MoveNext()
        'Next 
		List1.Focus()
		ToBeAdded = False
		'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdCancel.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
		Timer1.Enabled = True
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) * 2)
		Timer1.Enabled = True
	End Sub
	
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Dim i As Object
		Dim x As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = 0
		For i = 0 To List1.Items.Count - 1
			If List1.GetItemChecked(i) = True Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = x + 1
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = x - 1
			End If
		Next 
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If x = List1.Items.Count Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        '	cmdOK.Enabled = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '          'List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        '	ToBeAdded = True
        'Else
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        '	cmdOK.Enabled = False
        '	'UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        '	ToBeAdded = False
        'End If
	End Sub
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width) / 2 <= VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) Then
        '	Timer1.Enabled = False
        'End If
	End Sub
	
	Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width) <= 0 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyForm.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	MyForm.Show()
        '	If ToBeAdded = False Then EnDis(False, False, True)
        '	Timer2.Enabled = False
        '	Me.Hide()
        'End If
	End Sub
	
	Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
		Dim ccontorl As Object
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			If Me.ActiveControl.equals(ccontrol) Then
				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
			Else
				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If ccontorl.Enabled = True Then
						'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
					End If
				End If
			End If
		Next ccontrol
		
	End Sub
End Class