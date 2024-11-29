Option Strict Off
Option Explicit On
Friend Class frmCheck
	Inherits System.Windows.Forms.Form
	Private ToBeAdded As Boolean
	
	'UPGRADE_WARNING: Event chkAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAll.CheckStateChanged
		Dim i As Object
		Dim x As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		x = 0
		If chkAll.CheckState = System.Windows.Forms.CheckState.Checked Then
			For i = 0 To List1.Items.Count - 1
				List1.SetItemChecked(i, True)
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = List1.Items.Count
		Else
			For i = 0 To List1.Items.Count - 1
				List1.SetItemChecked(i, False)
			Next 
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = 0
		End If
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
        '	List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
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
	
	'UPGRADE_WARNING: Event cmbCnditionFile.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCnditionFile_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCnditionFile.SelectedIndexChanged
		Dim i As Object
		Dim RS As Object
        Dim dtConditions As New dsExplosives.ConditionsDataTable
        Dim PermissionNameID As Int32 = Convert.ToInt32(cmbCnditionFile.SelectedValue)


        dtConditions = New dsExplosivesTableAdapters.ConditionsTableAdapter().GetDataByPermissionNameID(PermissionNameID)

        'RS = New ADODB.Recordset
		'UPGRADE_WARNING: Couldn't resolve default property of object RS.State. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object RS.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        ''UPGRADE_WARNING: Couldn't resolve default property of object RS.CursorLocation. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		'UPGRADE_WARNING: Couldn't resolve default property of object RS.Open. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'RS.Open("Select * From Conditions Where Name='" & cmbCnditionFile.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
		'UPGRADE_WARNING: Couldn't resolve default property of object RS.MoveFirst. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'RS.MoveFirst()
		List1.Items.Clear()
		chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        'cmdOK.Enabled = False
        'chkAll.Enabled = False
        'UPGRADE_WARNING: Couldn't resolve default property of object RS.RecordCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If RS.RecordCount > 0 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object RS.RecordCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	For i = 0 To RS.RecordCount - 1
        '		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '		If Not IsDbNull(RS!Condition) Then
        '			'UPGRADE_WARNING: Couldn't resolve default property of object RS!Condition. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			List1.Items.Add(RS!Condition)
        '		End If
        '		'UPGRADE_WARNING: Couldn't resolve default property of object RS.MoveNext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		RS.MoveNext()
        '	Next 
        '	If List1.Items.Count > 0 Then chkAll.Enabled = True
        'End If

        If dtConditions.Rows.Count > 0 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object RS.RecordCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            For i = 0 To dtConditions.Rows.Count - 1
                'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
                If Not IsDBNull(dtConditions.Rows(i)("Condition")) Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object RS!Condition. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    List1.Items.Add(dtConditions.Rows(i)("Condition"))
                End If
                'UPGRADE_WARNING: Couldn't resolve default property of object RS.MoveNext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

            Next
            If List1.Items.Count > 0 Then chkAll.Enabled = True
        End If
		Label2.Enabled = chkAll.Enabled
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/„‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›… ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
                ToBeAdded = False
                Close()
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
				Timer2.Enabled = True
				' EnDis False, False, True
                'frmImportPermissions.cmdRefresh.CheckState = System.Windows.Forms.CheckState.Checked
			Else
				'UPGRADE_WARNING: Form method frmCheck.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				Me.BringToFront()
			End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdOK.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdOK_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.CheckStateChanged
        Me.DialogResult = DialogResult.OK
        Close()
        
	End Sub
	
	'UPGRADE_WARNING: Form event frmCheck.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmCheck_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim i As Object
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width)) ' + 250
        'Dim a As New ADODB.Recordset
        'a.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'a.Open("Select Distinct Name From Conditions Order By Name", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'Dim g As Object
        ''UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'g = cmbCnditionFile.SelectedIndex
        'cmbCnditionFile.Items.Clear()
        'For i = 1 To a.RecordCount
        '	cmbCnditionFile.Items.Add((a.Fields(0).Value))
        '	a.MoveNext()
        'Next 
        'LoadAllSettings()
        'ApplySettings()
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
        'Timer1.Enabled = True
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) * 2)
        'cmdOK.Enabled = False
        'List1.Focus()
        'Timer1.Enabled = True
		
		
		
	End Sub
	
	Private Sub frmCheck_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.PermissionNames' table. You can move, or remove it, as needed.
        Me.PermissionNamesTableAdapter.Fill(Me.DsExplosives.PermissionNames)
        'TODO: This line of code loads data into the 'DsExplosives.Conditions' table. You can move, or remove it, as needed.
        Me.ConditionsTableAdapter.Fill(Me.DsExplosives.Conditions)
        'TODO: This line of code loads data into the 'DsExplosives.Conditions' table. You can move, or remove it, as needed.
       

        cmbCnditionFile.SelectedIndex = 0
        cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
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
		If x = List1.Items.Count Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
            ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
            'cmdOK.Enabled = True
            ''UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
            ''UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
			ToBeAdded = True
		Else
            ''UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
            ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
            'cmdOK.Enabled = False
            ''UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
            ''UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'List1.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
			ToBeAdded = False
		End If
	End Sub
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If (VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width)) / 2 <= VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) Then
        '	Timer1.Enabled = False
        '	' Me.Left = (Screen.Width - Me.Width + Me.Left) / 2
        'End If
		
	End Sub
	
	Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width) <= 0 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyForm.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	MyForm.Show()
        '	If ToBeAdded = False Then
        '		EnDis(False, False, True)
        '	End If
        '	Timer2.Enabled = False
        '	Me.Hide()
        'End If
	End Sub
	
	Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
		Dim ccontorl As Object
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
            'If Me.ActiveControl.equals(ccontrol) Then
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
            'Else
            '	'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            '	If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
            '		'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '                 'If ccontorl.Enabled = True Then
            '                 '	'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '                 '	ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
            '                 'Else
            '                 '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '                 '	ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
            '                 'End If
            '	End If
            'End If
        Next ccontrol
		
	End Sub

    Private Sub cmdOK_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOK.CheckedChanged

    End Sub

  
    Private Sub cmdCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckedChanged

    End Sub
End Class