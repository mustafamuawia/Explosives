Option Strict Off
Option Explicit On
Friend Class frmWorkAllowed
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
	Private MyField, IDbefore, Its, ActvCtrl, Loaded As Object
	Private Serched As Boolean
	Private Sub Con()
        'RS = New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS.Open("Select * From WorkAllowed Order By To_Number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

        'If RS.RecordCount < 1 Then
        '	cmdSave.Enabled = False
        '	cmdEdit.Enabled = False
        '	cmdDelete.Enabled = False
        '	cmdNext.Enabled = False
        '	cmdPrev.Enabled = False
        '	cmdFirst.Enabled = False
        '	cmdLast.Enabled = False
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdSave.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdEdit.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdDelete.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdNext.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdPrev.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdLast.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdFirst.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        'End If
	End Sub
	Private Sub FromDB()
		Dim i As Object
		Dim Tel3 As Object
		On Error Resume Next
        'clr()
        'txtId.Text = RS.Fields("ID").Value
        'txtSideName.Text = RS.Fields("SideName").Value
        'txtOwner.Text = RS.Fields("Owner").Value
        'txtAddress.Text = RS.Fields("Address").Value
        'txtTel1.Text = RS.Fields("Tel1").Value
        'txtTel2.Text = RS.Fields("Tel2").Value
        ''UPGRADE_WARNING: Couldn't resolve default property of object Tel3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'txtTel3.Text = Tel3
        'txtE_mail.Text = RS.Fields("E_Mail").Value
        'txtFax.Text = RS.Fields("Fax").Value
        'txtPOB.Text = RS.Fields("POB").Value
        'txtOther.Text = RS.Fields("Other").Value
        'txtDate.Text = VB6.Format(RS.Fields("FDate").Value, "YYYY/MM/DD")
        'txtSight1.Text = RS.Fields("Sight1").Value
        'txtSight2.Text = RS.Fields("Sight2").Value
        'txtOtherSights.Text = RS.Fields("OtherSights").Value
        'Dim RSteam As New ADODB.Recordset
        'RSteam = New ADODB.Recordset
        'If RSteam.State = ADODB.ObjectStateEnum.adStateOpen Then RSteam.Close()
        'RSteam.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSteam.Open("Select ID,Rank,Name,Unit From Teams Where SideName='" & RS.Fields("SideName").Value & "' Order By ID,Rank,Unit", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'List1.Items.Clear()
        'For i = 0 To RSteam.RecordCount - 1
        '	List1.Items.Add(RSteam.Fields("ID").Value & vbTab & RSteam.Fields("Rank").Value & vbTab & RSteam.Fields("Name").Value & RSteam.Fields("Unit").Value)
        '	RSteam.MoveNext()
        'Next 
		
        'If RS.RecordCount > 0 Then
        '	lblPosition.Text = "0 / 0"
        '	lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
        'Else
        '	lblPosition.Text = "0 / 0"
        'End If
	End Sub
	Private Sub ToDB()
		Dim Tel3 As Object
		'On Error Resume Next
        'RS.Fields("ID").Value = txtId.Text
        'RS.Fields("SideName").Value = txtSideName.Text
        'RS.Fields("Owner").Value = txtOwner.Text
        'RS.Fields("Address").Value = txtAddress.Text
        'RS.Fields("Tel1").Value = txtTel1.Text
        'RS.Fields("Tel2").Value = txtTel2.Text
        ''UPGRADE_WARNING: Couldn't resolve default property of object Tel3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Tel3 = txtTel3.Text
        'RS.Fields("E_Mail").Value = txtE_mail.Text
        'RS.Fields("Fax").Value = txtFax.Text
        'RS.Fields("POB").Value = txtPOB.Text
        'RS.Fields("Other").Value = txtOther.Text
        'RS.Fields("FDate").Value = VB6.Format(txtDate.Text, "DD/MM/YYYY")
        'RS.Fields("Sight1").Value = txtSight1.Text
        'RS.Fields("Sight2").Value = txtSight2.Text
        'RS.Fields("OtherSights").Value = txtOtherSights.Text
	End Sub
	
	'UPGRADE_WARNING: Event cmbCriteria.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCriteria_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
                'TextLock()
				FromDB()
                'EnDis(False, False, True)
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
			Else
				'UPGRADE_WARNING: Couldn't resolve default property of object ActvCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If ActvCtrl = "txtSideName" Then txtSideName.Focus()
			End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim x As Object
		On Error Resume Next
		If cmdDelete.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·”Ã· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                WORKALLOWEDBindingSource.RemoveCurrent()
                WORKALLOWEDBindingSource.EndEdit()
                WORKALLOWEDTableAdapter.Update(DsExplosives.WORKALLOWED)
                'RS.Delete()
                MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
            End If
			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Con()
		FromDB()
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
		If cmdEdit.CheckState = 1 Then
            'TextUnLock()
            'EnDis(False, True, False)
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			IDbefore = txtSideName.Text
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = "edit"
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
		Dim x As Object
		If cmdExit.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ «·Œ—ÊÃ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then End
			cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        WORKALLOWEDBindingSource.MoveFirst()
        lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
        'Dim Searched As Object
        'On Error Resume Next
        'If cmdFirst.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '	End If
        '          'RS.MoveFirst()
        '	Beep()
        '	FromDB()
        '	cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
		Dim dtrWorkAllowed As Object
		Dim Recent As Object
		On Error GoTo er
		If cmdFound.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Recent = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkAllowed.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkAllowed.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkAllowed.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(Recent - 1)
			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
			Exit Sub
er: 
			MsgBox(Err.Description)
			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        WORKALLOWEDBindingSource.MoveLast()
        lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
        'Dim cmdlst As Object
        'Dim Searched As Object
        'On Error Resume Next
        ''UPGRADE_WARNING: Couldn't resolve default property of object cmdlst.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If cmdlst.Value = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '	End If
        '          'RS.MoveLast()
        '	Beep()
        '	FromDB()
        '	cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
		
            WORKALLOWEDBindingSource.AddNew()

            'clr()
            'Timer1.Enabled = True
            'TextUnLock()
            'n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'n.Open("Select NVL(Max(To_Number(ID)),0) ID From WorkAllowed order By To_Number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            '' n.MoveLast
            'txtId.Text = CStr(Val(n.Fields("ID").Value) + 1)
            'n.Close()
            ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Its = "add"
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore = txtSideName.Text
            'EnDis(True, False, False)
            'If Not RS.RecordCount < 1 Then RS.MoveLast()
            'txtId.Text = CStr(Val(RS.Fields("ID").Value) + 1)
            'If txtId.Text = "" Then txtId.Text = CStr(1)
            'txtDate.Text = CStr(Today)
            'txtSideName.Focus()

	End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        WORKALLOWEDBindingSource.MoveNext()
        lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
        'Dim Searched As Object
        'On Error Resume Next
        'If cmdNext.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '              'RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '	End If
        '          'RS.MoveNext()
        '          'If RS.EOF Then
        '          '	RS.MoveLast()
        '          '	Beep()
        '          'End If
        '	FromDB()
        '	cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        WORKALLOWEDBindingSource.MovePrevious()
        lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
        'Dim Searched As Object
        'On Error Resume Next
        'If cmdPrev.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '              '	RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '              'End If
        '              'RS.MovePrevious()
        '              'If RS.BOF Then
        '              '	RS.MoveFirst()
        '              '	Beep()
        '          End If
        '          FromDB()
        '          cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        '      End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
		Dim dtrWorkAllowed As Object
		On Error GoTo er
		If cmdPrintAll.CheckState = 1 Then
			Con()
			FromDB()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkAllowed.DataSource = RS
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrWorkAllowed.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrWorkAllowed.Show()
			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
			Exit Sub
er: 
			MsgBox(Err.Description)
			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
		Dim dtrWorkAllowed As Object
		On Error GoTo er
        'Dim RSs As New ADODB.Recordset
		If cmdPrintDoc.CheckState = 1 Then
            'RSs = New ADODB.Recordset
            'If RSs.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RSs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'RSs.Open("Select * From WorkAllowed Where SideName='" & txtSideName.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkAllowed.DataSource = RSs
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrWorkAllowed.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrWorkAllowed.Show()
			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
			Exit Sub
er: 
			MsgBox(Err.Description)
			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
		If cmdRefresh.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = ""
			Con()
			FromDB()
			cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
		If cmdReturn.CheckState = 1 Then
			Me.Hide()
			frmMain.Show()
			cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        WORKALLOWEDTableAdapter.Update(DsExplosives.WORKALLOWED)
        MsgBox(" „ «·Õ›Ÿ »‰Ã«Õ")

        '		On Error GoTo er
        '		If cmdSave.CheckState = 1 Then
        '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			If Its = "add" Then RS.AddNew()
        '			ToDB()
        '            'RS.Update()
        '			Timer1.Enabled = False
        '            'ApplySettings()
        '			Con()
        '			FromDB()
        '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			Its = ""
        '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			IDbefore = ""
        '            'TextLock()
        '            'EnDis(False, False, True)
        '			Exit Sub
        'er: 
        '			MsgBox(Err.Description)
        '			cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
        '		End If
    End Sub
	
	Private Sub Combo1_Change()
		
	End Sub
	
	Private Sub Command1_Click()
        'ApplySettings()
	End Sub
	
	'UPGRADE_WARNING: Form event frmWorkAllowed.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmWorkAllowed_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
		cmdRefresh.Width = Me.ClientRectangle.Width
	End Sub
	
	Private Sub frmWorkAllowed_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.WORKALLOWED' table. You can move, or remove it, as needed.
        Me.WORKALLOWEDTableAdapter.Fill(Me.DsExplosives.WORKALLOWED)
        '      Con()
        'FromDB()
		'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cmbCriteria.SelectedIndex = 0
		'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
    End Sub
	
	Private Sub frmWorkAllowed_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        ''UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
		'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
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
	
	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
		Dim idexit As Object
		Dim Searched As Object
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

        'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

        'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If cmbCriteria.Text = "⁄«„" Then
            WORKALLOWEDBindingSource.Filter = "SideName Like '%" & txtFind.Text & "%' Or Address Like '%" & txtFind.Text & "%' Or Sight1 Like '%" & txtFind.Text & "%'" & " Or Sight2 Like '%" & txtFind.Text & "%' Or OtherSights Like '%" & txtFind.Text & "%'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "«”„ «·ÃÂ…" Then MyField = "Where SideName Like '%" & txtFind.Text & "%'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "«·⁄‰Ê«‰" Then MyField = "Where Address Like '%" & txtFind.Text & "%'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "„Êﬁ⁄ ⁄„·" Then MyField = "Where Sight Like '%" & txtFind.Text & "%'" & " Or Sight2 Like '%" & txtFind.Text & "%' Or OtherSights Like '%" & txtFind.Text & "%'"
            'RS = New ADODB.Recordset
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Open("Select * From WorkAllowed " & MyField, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            'FromDB()
            'If RS.RecordCount = 0 Then
            '	clr()
            '	cmdPrintDoc.Enabled = False
            '	cmdFound.Enabled = False
            'Else
            '	cmdPrintDoc.Enabled = True
            '	cmdFound.Enabled = True
            'End If
            'If RS.RecordCount < 2 Then
            '	cmdFindNext.Enabled = False
            '	cmdFindPrev.Enabled = False
            '	'UPGRADE_WARNING: Couldn't resolve default property of object idexit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	If idexit = True Then Exit Sub
            'Else
            '	cmdFindNext.Enabled = True
            '	cmdFindPrev.Enabled = True
            'End If
            lblPosition.Text = " " + (WORKALLOWEDBindingSource.Position + 1).ToString + " / " + WORKALLOWEDBindingSource.Count.ToString
        End If
    End Sub
	
	Private Sub txtSideName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtSideName.Leave
		Dim vbacancel As Object
		Dim x As Object
		On Error Resume Next
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "add" Or (Its = "edit" And IDbefore <> txtSideName.Text) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ActvCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ActvCtrl = "txtSideName"
			If txtSideName.Text = vbNullString Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·ÃÂ… ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
				If x = MsgBoxResult.OK Then
					txtSideName.Focus()
				ElseIf x = MsgBoxResult.Cancel Then 
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				End If
			Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("SideName='" & txtSideName.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	If RS.EOF = False Then
                '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		x = MsgBox("⁄›Ê« ! Â–Â «·ÃÂ… „ÊÃÊœ… . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì‰« Â« ø", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                '		If x = MsgBoxResult.Yes Then
                '			FromDB()
                '			EnDis(False, False, True)
                '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			Its = ""
                '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			IDbefore = ""
                '		ElseIf x = MsgBoxResult.No Then 
                '			txtSideName.Focus()
                '			'UPGRADE_WARNING: Couldn't resolve default property of object vbacancel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		ElseIf x = vbacancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	Else
                '		RS.MoveFirst()
                '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		RS.Find("SideName='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '		'   MsgBox RS.EOF
                '	End If
                'End If
			End If
		End If
	End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckedChanged

    End Sub

    Private Sub cmdNext_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckedChanged

    End Sub
End Class