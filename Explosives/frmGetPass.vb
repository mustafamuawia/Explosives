Option Strict Off
Option Explicit On
Friend Class frmGetPass
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RS2 As New ADODB.Recordset
	Private IDbefore, Its, MySql As Object
	Private Loaded As Boolean
	Private myReturn As Boolean
	Private Sub Con()
		Dim i As Object
        'RS2 = New ADODB.Recordset
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS = New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        'RS2.Open("Select Max(Fdate) Mx, Min(FDate) Mn From GetPass", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'txtDate1.Text = VB6.Format(RS2.Fields("Mn").Value, "DD/MM/YYYY")
        'txtDate2.Text = VB6.Format(RS2.Fields("MX").Value, "DD/MM/YYYY")
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()

        'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) And txtDate1.Text <> txtDate2.Text Then
        '	RS.Open("Select * From GetPass Where FDate Between '" & txtDate1.Text & "' And '" & txtDate2.Text & "' Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        'Else
        '	RS.Open("Select * From GetPass Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        'End If

        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Distinct StoreAgent From GetPass Order By StoreAgent", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbStoreAgent.Items.Clear()
        'For i = 1 To RS2.RecordCount
        '	cmbStoreAgent.Items.Add(RS2.Fields(0).Value)
        '	RS2.MoveNext()
        'Next 

        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Distinct SideName From WorkAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbSideName.Items.Clear()
        'For i = 1 To RS2.RecordCount
        '	cmbSideName.Items.Add(RS2.Fields(0).Value)
        '	RS2.MoveNext()
        'Next 
	End Sub
	Private Sub FromDB()
		On Error Resume Next
        'txtPID.Text = RS.Fields("PassID").Value
        'txtDocID.Text = RS.Fields("DocID").Value
        'txtID.Text = RS.Fields("ID").Value
        'txtStoreID.Text = RS.Fields("StoreID").Value
        'txtPermission.Text = RS.Fields("Permission").Value
        'cmbSideName.Text = RS.Fields("SideName").Value
        'txtClasses.Text = RS.Fields("Classes").Value
        'cmbStoreAgent.Text = RS.Fields("StoreAgent").Value
        'txtCarID.Text = RS.Fields("CarID").Value
        'txtDate.Text = RS.Fields("FDate").Value
        'cmbReceiver.Text = RS.Fields("Receiver").Value
        'lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
        'If RS.RecordCount = 0 Then lblPosition.Text = "0 / 0"
	End Sub
	Private Sub ToDB()
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Then RS.AddNew()
        'RS.Fields("PassID").Value = txtPID.Text
        'RS.Fields("DocID").Value = txtDocID.Text
        'RS.Fields("ID").Value = txtID.Text
        'RS.Fields("StoreID").Value = txtStoreID.Text
        'RS.Fields("Permission").Value = txtPermission.Text
        'RS.Fields("SideName").Value = cmbSideName.Text
        'RS.Fields("Classes").Value = txtClasses.Text
        'RS.Fields("StoreAgent").Value = cmbStoreAgent.Text
        'RS.Fields("CarID").Value = txtCarID.Text
        'RS.Fields("FDate").Value = txtDate.Text
        'RS.Fields("Receiver").Value = cmbReceiver.Text
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cmbBy.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbBy_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbBy.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbSideName.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	'UPGRADE_WARNING: ComboBox event cmbSideName.Change was upgraded to cmbSideName.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
	Private Sub cmbSideName_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSideName.TextChanged
		Dim cmbReceivee As Object
		Dim i As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim ss As New ADODB.Recordset
		If Its = "edit" Or Its = "add" Then
            'ss.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'If ss.State = ADODB.ObjectStateEnum.adStateOpen Then ss.Close()
            'ss.Open("Select Distinct Receiver From GetPass Order By Receiver", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'cmbStoreAgent.Items.Clear()
            'For i = 0 To ss.RecordCount - 1
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmbReceivee.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmbReceivee.AddItem(ss.Fields(0))
            '	ss.MoveNext()
            'Next 
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		On Error Resume Next
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ „‰ √‰ﬂ  —Ìœ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Its = ""
				'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				IDbefore = ""
				Con()
				FromDB()
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
                'EnDis(False, False, True)
			End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim x As Object
		If cmdDelete.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ „‰ √‰ﬂ  —Ìœ Õ–› Â–« «· ’—ÌÕ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
                'RS.Delete()
				Con()
				FromDB()
			End If
			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
		If cmdEdit.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = "edit"
			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			IDbefore = txtPID.Text
            'TextUnLock()
			txtID.ReadOnly = True
			txtClasses.ReadOnly = False
			txtDocID.ReadOnly = True
            'EnDis(False, True, False)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
		If cmdNext.CheckState = 1 Then
            'RS.MoveFirst()
			FromDB()
			Beep()
			cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
		On Error Resume Next
		If cmdLast.CheckState = 1 Then
            'RS.MoveLast()
			FromDB()
			Beep()
			cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        'Dim n As New ADODB.Recordset
		If cmdNew.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = "add"
			Timer1.Enabled = True
			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			IDbefore = txtPID.Text
            'TextUnLock()
			txtID.ReadOnly = True
			txtClasses.ReadOnly = False
			txtDocID.ReadOnly = True
            'clr()
            'n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'n.Open("Select NVL(Max(ID),0) + 1 as ID From GetPass Where To_Char(FDate,'YYYY')='" & VB6.Format(Today, "yyyy") & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'txtID.Text = CStr(Val(n.Fields("ID").Value))
            'n.Close()
            'txtDate.Text = VB6.Format(Today, "YYYY/MM/DD")
			txtPID.Focus()
            'EnDis(True, False, False)
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
		On Error Resume Next
		If cmdNext.CheckState = 1 Then
            'RS.MoveNext()
            'If RS.EOF Then
            '	RS.MoveLast()
            '	Beep()
            'End If
			FromDB()
			cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
		If cmdPrev.CheckState = 1 Then
            'RS.MovePrevious()
            'If RS.BOF Then
            '	RS.MoveFirst()
            '	Beep()
            'End If
			FromDB()
			cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
		If cmdReturn.CheckState = 1 Then
			myReturn = True
			frmPassPermissions.Show()
			Me.Close()
			myReturn = False
			cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
		If cmdSave.CheckState = 1 Then
            'TextLock()
			ToDB()
			Timer1.Enabled = False
            'ApplySettings()
            'RS.Update()
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			IDbefore = "'"
			Con()
			FromDB()
            'EnDis(False, False, True)
			cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	
	
	'UPGRADE_WARNING: Form event frmGetPass.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmGetPass_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim x As Object
		myReturn = False
		Loaded = False
		cmdRefresh.Width = Me.ClientRectangle.Width
        ''LoadAllSettings()
        'ApplySettings()
		If Loaded = False Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â·  —Ìœ ≈” Œ—«Ã  ’—ÌÕ Œ—ÊÃ ·‰›”  ’—ÌÕ «·„—Ê— ø", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
			If x = MsgBoxResult.Yes Then
				cmdNew.CheckState = System.Windows.Forms.CheckState.Checked
				'UPGRADE_WARNING: Couldn't resolve default property of object MyGetPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'txtPID.Text = MyGetPass
				'UPGRADE_WARNING: Couldn't resolve default property of object MyGetPass2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'txtDocID.Text = MyGetPass2
				cmbSideName.Text = frmPassPermissions.cmbReceiver.Text
				txtPID_Leave(txtPID, New System.EventArgs())
			End If
			Loaded = True
		End If
        'MyForm = frmPassPermissions
		cmbBy.SelectedIndex = 0
		Loaded = True
	End Sub
	
	Private Sub frmGetPass_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Loaded = False
		Con()
		FromDB()
	End Sub
	
	Private Sub frmGetPass_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		If myReturn = False Then
            'ProgramExit()
			'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
            'Cancel = MyCancel
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim ccontorl As Object
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
			If Me.ActiveControl.Name = ccontrol.Name Then
				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
				End If
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
					'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
					End If
				End If
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate1.TextChanged
		If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate2.TextChanged
		If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtDocID.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDocID_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDocID.TextChanged
		Dim i As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "edit" Or Its = "add" Then
            'RS2 = New ADODB.Recordset
            'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
            'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'RS2.Open("Select Ammount, Unit, Class From DistractClass where fID='" & txtDocID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'txtClasses.Text = ""
            'If RS2.RecordCount <> 0 Then
            '	For i = 0 To RS2.RecordCount - 1
            '		txtClasses.Text = txtClasses.Text & " " & RS2.Fields("Ammount").Value & " " & RS2.Fields("Unit").Value & " " & RS2.Fields("Class").Value
            '		If RS2.AbsolutePosition < RS2.RecordCount Then txtClasses.Text = txtClasses.Text & " _ "
            '		RS2.MoveNext()
            '	Next 
            'End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
		On Error Resume Next
		If Loaded = True Then
			If cmbBy.Text = "«·ﬂ·" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (PassID='" & txtFind.Text & "' Or DocID ='" & txtFind.Text & "' Or ID =" & Val(txtFind.Text) & " Or Permission Like '%" & txtFind.Text & "%' Or SideName  Like '%" & txtFind.Text & "%' Or Classes Like '%" & txtFind.Text & "%' Or StoreAgent Like '%" & txtFind.Text & "%' Or CarID Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%' "
				If IsDate(txtFind.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MySql = MySql & " Or Fdate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "')"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					MySql = MySql & ")"
				End If
			ElseIf cmbBy.Text = "—ﬁ„ «·„·›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (ID='" & txtFind.Text & "' )"
			ElseIf cmbBy.Text = "‰„—…  ’—ÌÕ «·„—Ê—" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (PassID='" & txtFind.Text & "' )"
			ElseIf cmbBy.Text = "‰„—… „” ‰œ «·’—›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (DocID='" & txtFind.Text & "' )"
			ElseIf cmbBy.Text = "—ﬁ„ «·ﬁ”„" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (StoreID Like '%" & txtFind.Text & "%' )"
			ElseIf cmbBy.Text = "’‰›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (Classes Like '%" & txtFind.Text & "%' )"
			ElseIf cmbBy.Text = "√„Ì‰ «·„Œ«“‰" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (StoreAgent Like '%" & txtFind.Text & "%' )"
			ElseIf cmbBy.Text = "‰„—… «·⁄—»…" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (CarID Like '%" & txtFind.Text & "%' )"
			ElseIf cmbBy.Text = " «—ÌŒ «·„·›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'MySql = "Select * From GetPass Where (FDate ='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' )"
			ElseIf cmbBy.Text = "«”„ «·„” ·„" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				MySql = "Select * From GetPass Where (Receiver Like '%" & txtFind.Text & "%' )"
			End If
			If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) And txtDate1.Text <> txtDate2.Text Then
				'UPGRADE_WARNING: Couldn't resolve default property of object MySql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'MySql = MySql & " And (FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
			End If
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RS.Open(MySql, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            'FromDB()
            '' MsgBox MySql
            'If RS.RecordCount = 0 Then
            '	clr()

            'Else

            'End If
            'If RS.RecordCount < 2 Then
            '	cmdFindNext.Enabled = False
            '	cmdFindPrev.Enabled = False
            '	' If idexit = True Then Exit Sub
            'Else
            '	cmdFindNext.Enabled = True
            '	cmdFindPrev.Enabled = True
            'End If
		End If
	End Sub
	
	Private Sub txtPID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPID.Leave
		Dim R2S As Object
		Dim x As Object
		On Error Resume Next
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "add" Or (Its = "edit" And IDbefore <> txtPID.Text) Then
			If txtPID.Text = "" Or txtPID.Text = " " Or txtPID.Text = "  " Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("⁄‹‹‹›‹‹‹‹Ê« ! ⁄·Ìﬂ «·ﬁÌ«„ »≈œŒ«· —ﬁ„ „” ‰œ  ’—ÌÕ «·„—Ê—.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OKCancel)
				If x = MsgBoxResult.Cancel Then
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				ElseIf x = MsgBoxResult.OK Then 
					txtPID.Focus()
				End If
			Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("PID='" & txtPID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	If RS.EOF = False Then
                '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		x = MsgBox("⁄‹‹›‹‹‹Ê« ! Â–« «· ’—ÌÕ „ÊÃÊœ . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNoCancel)
                '		If x = MsgBoxResult.Yes Then
                '			FromDB()
                '		ElseIf x = MsgBoxResult.No Then 
                '			txtPID.Focus()
                '		ElseIf x = MsgBoxResult.Cancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	Else
                '		RS.MoveFirst()
                '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		RS.Find("PID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '		'UPGRADE_WARNING: Couldn't resolve default property of object R2S.State. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		If R2S.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
                '		RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                '		RS2.Open("Select FID From PassPermisson Where ID='" & txtPID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                '		txtDocID.Text = RS2.Fields("FID").Value
                '	End If
                'End If
				'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If Its = "add" Then
                    'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
                    'RS2.Open("Select NVL(Max(ID),0) mx From GetPAss", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                    'txtID.Text = CStr(Val(RS2.Fields("MX").Value) + 1)
                    'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
                    'txtStoreID.Focus()
				End If
			End If
		End If
	End Sub
End Class