Option Strict Off
Option Explicit On
Friend Class frmAccounts
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RS2 As New ADODB.Recordset
	Private IDbefore, Its, SQL As String
	Private Sub Con()
        'RS = New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'SQL = "Select Accounts.ID, Accounts.Account, Sum(NVL(ImportClass.Ammount,0)) Imported, Sum(NVL(DistractClass.Ammount,0)) Distracted," & " Sum(NVL(ImportClass.Ammount,0))-Sum(NVL(DistractClass.Ammount,0)) Recent" & " From Accounts, ImportClass, DistractClass" & " Where ImportClass.Account(+)=Accounts.Account And DistractClass.Account(+)= Accounts.Account" & " Group By (Accounts.ID, Accounts.Account)" & " Order By Accounts.Id"
        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
	End Sub
	Private Sub myclr()
        'clr()
		lblClassesNo.Text = ""
		lblRecent.Text = ""
		lblImported.Text = ""
		lblDistracted.Text = ""
	End Sub
	Private Sub FromDB()
        'On Error Resume Next
        'RS2 = New ADODB.Recordset
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select NVL(Count(Classes.Class),0) ClassesNo From Classes Where Account='" & RS.Fields("Account").Value & "' Group By Classes.Account", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'myclr()
        'txtID.Text = RS.Fields("ID").Value
        'txtAccount.Text = RS.Fields("Account").Value
        ''lblClassesNo.Caption = RS2!ClassesNo
        'If RS2.RecordCount < 1 Then lblClassesNo.Text = CStr(RS2.RecordCount)
        'lblRecent.Text = RS.Fields("Recent").Value
        'lblImported.Text = RS.Fields("Imported").Value
        'lblDistracted.Text = RS.Fields("Distracted").Value
	End Sub
	Private Sub ToDB()
        'On Error Resume Next
        'RS.Fields("ID").Value = txtID.Text
        'RS.Fields("Account").Value = txtAccount.Text
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
				FromDB()
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
                DisableSave()

                Its = ""
                'EnDis(False, False, True)
				cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim x As Object
		If cmdDelete.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/ Õ–› Â–« «·Õ”«» ø", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
			If x = MsgBoxResult.Yes Then
                AccountsBindingSource.RemoveCurrent()
                AccountsTableAdapter.Update(DsExplosives.Accounts)
                cmdSave.Enabled = False
                cmdCancel.Enabled = True
                cmdDelete.Enabled = True
                cmdNew.Enabled = True
				MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
			End If
			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        EnableSave()

	End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        'If cmdExit.CheckState = 1 Then ProgramExit()
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        AccountsBindingSource.MoveFirst()
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString

	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        AccountsBindingSource.MoveLast()
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString
	End Sub
	
	'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'If cmdLogout.CheckState = 1 Then LogOut()
	End Sub
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged, cmdNew.Click
        AccountsBindingSource.AddNew()
       EnableSave
    End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        AccountsBindingSource.MoveNext()
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        AccountsBindingSource.MovePrevious()
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If cmdRefresh.CheckState = 1 Then
        '    Its = ""
        '    Con()
        '    FromDB()
        '    cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub
    Private Sub EnableSave()
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
        cmdNew.Enabled = False
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
    End Sub
    Private Sub DisableSave()
        cmdSave.Enabled = False
        cmdCancel.Enabled = False
        cmdNew.Enabled = True
        cmdEdit.Enabled = True
        cmdDelete.Enabled = True
    End Sub
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        'If cmdReturn.CheckState = 1 Then Rtn()
	End Sub
	
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        AccountsBindingSource.EndEdit()
        AccountsTableAdapter.Update(DsExplosives.Accounts)
        DisableSave()

        MsgBox(" „")
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString

	End Sub
	
	'UPGRADE_WARNING: Form event frmAccounts.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmAccounts_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
        'cmdRefresh.Width = Me.ClientRectangle.Width
	End Sub
	
	Private Sub frmAccounts_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.DsExplosives.Accounts)
        'TODO: This line of code loads data into the 'DsExplosives.Accounts_Imported_Distracted' table. You can move, or remove it, as needed.
        Me.Accounts_Imported_DistractedTableAdapter.Fill(Me.DsExplosives.Accounts_Imported_Distracted)
        lblPosition.Text = " " + (AccountsBindingSource.Position + 1).ToString + " / " + AccountsBindingSource.Count.ToString

	End Sub
	
	Private Sub frmAccounts_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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
	
	Private Sub txtAccount_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAccount.Leave
		Dim no As Object
		Dim o As Object
        'Dim vbExclamaion As Object
		Dim x As Object
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
		If Its = "add" Or (txtAccount.Text <> IDbefore And Its = "edit") Then
			'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
			If IsDbNull(txtAccount.Text) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ «”„ «·Õ”«» ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
				If x = MsgBoxResult.OK Then
					txtAccount.Focus()
				ElseIf x = MsgBoxResult.Cancel Then 
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				End If
			Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("Account='" & txtAccount.Text & "'", 0)
                '	If RS.EOF = False Then
                '		'UPGRADE_WARNING: Couldn't resolve default property of object vbExclamaion. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		x = MsgBox("⁄‹‹‹‹›‹‹‹‹Ê« ! Â–« «·Õ”«» „ÊÃÊœ. Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.MsgBoxRight + vbExclamaion + MsgBoxStyle.YesNoCancel)
                '		If x = MsgBoxResult.Yes Then
                '			EnDis(False, False, True)
                '			FromDB()
                '			TextLock()
                '			'UPGRADE_WARNING: Couldn't resolve default property of object no. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		ElseIf x = no Then 
                '			txtAccount.Focus()
                '			'UPGRADE_WARNING: Couldn't resolve default property of object o. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			txtAccount.SelectionStart = o
                '			txtAccount.SelectionLength = Len(txtAccount.Text)
                '		ElseIf x = MsgBoxResult.Cancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	Else
                '		RS.Find("Account='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchBackward)
                '	End If
                'End If
			End If
		End If
	End Sub

    Private Sub cmdFmtDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFmtDoc.CheckedChanged

    End Sub

    Private Sub cmdFmtFound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFmtFound.CheckedChanged

    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub
End Class