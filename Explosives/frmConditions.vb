Option Strict Off
Option Explicit On
Friend Class frmConditions
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
	
	'UPGRADE_NOTE: Focused was upgraded to Focused_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
    Private Focused_Renamed, Num, scrl, Its As Object
    Private OldCondition As String
	Private ToBeEdited As Boolean
	Private Sub Con()
		Dim i As Object
		On Error Resume Next
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
		'UPGRADE_WARNING: Couldn't resolve default property of object g. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmbCnditionFile.SelectedIndex = g
	End Sub
	Private Sub Label1_Change()
		Dim Label1 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Label1.Width. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Label1.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Label1.Width > VB6.PixelsToTwipsX(Frame1.Width) - 100 Then Split(Label1.Caption)
	End Sub
	
	Private Sub Text1_Change()
		Dim Label1 As Object
		Dim Text1 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object Label1.Caption. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Text1.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label1.Caption = Text1.Text
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cmbCnditionFile.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCnditionFile_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCnditionFile.SelectedIndexChanged
        Me.ConditionsTableAdapter.FillByPermissionNameID(DsExplosives.Conditions, Convert.ToInt32(cmbCnditionFile.SelectedValue))

	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Close()
    End Sub
	
	'UPGRADE_WARNING: Event cmdConditions.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdConditions_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConditions.CheckStateChanged
	
        frmCondtions0.ShowDialog()
        PermissionNamesTableAdapter.Update(DsExplosives.PermissionNames)
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        
    End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close() 'If cmdExit.CheckState = 1 Then ProgramExit()
	End Sub
	
	'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'If cmdLogout.CheckState = 1 Then LogOut()
	End Sub
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
       
    End Sub
	
	'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim index As Integer = List1.FindStringExact(txtCondition.Text)
        If ToBeEdited = True Then
            cmdPlus.Text = "+"
            If index <> -1 Then
                ErrorProvider1.SetError(txtCondition, "„ÊÃÊœ „‰ ﬁ»·")
            ElseIf txtCondition.Text = "" Then
                ErrorProvider1.SetError(txtCondition, "«·ﬁÌ„… „ÿ·Ê»…")
            Else

                ConditionsTableAdapter.UpdateCondition(txtCondition.Text, Convert.ToInt32(cmbCnditionFile.SelectedValue), OldCondition)
                If cmbCnditionFile.Items.Count > 0 Then

                    cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
                End If
                MsgBox(" „")
                txtCondition.Text = ""
                txtCondition.Focus()
                ErrorProvider1.Clear()

            End If

        Else


            If index <> -1 Then
                ErrorProvider1.SetError(txtCondition, "„ÊÃÊœ „‰ ﬁ»·")
            ElseIf txtCondition.Text = "" Then
                ErrorProvider1.SetError(txtCondition, "«·ﬁÌ„… „ÿ·Ê»…")
            Else

                ConditionsTableAdapter.Insert(txtCondition.Text, Convert.ToInt32(cmbCnditionFile.SelectedValue))
                If cmbCnditionFile.Items.Count > 0 Then

                    cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
                End If
                MsgBox(" „")
                txtCondition.Text = ""
                txtCondition.Focus()
                ErrorProvider1.Clear()
            End If
        End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdRemove.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRemove_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRemove.CheckStateChanged
        If List1.SelectedItems.Count > 0 Then
            If MessageBox.Show("Â·  Êœ Õ–› «·‘—ÿ", "Õ–›", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim Item As DataRowView = List1.SelectedItems(0)
                Dim Condition As String = Item(0).ToString
                ConditionsTableAdapter.DeleteCondition(Convert.ToInt32(cmbCnditionFile.SelectedValue), Condition)
                MsgBox(" „")
                If cmbCnditionFile.Items.Count > 0 Then

                    cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        End If

	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
	End Sub
	
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
     
    End Sub
	
	'UPGRADE_WARNING: Form event frmConditions.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmConditions_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		
        'LoadAllSettings()
        'ApplySettings()
		Con()
	End Sub
	
    Private Sub frmConditions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.PermissionNames' table. You can move, or remove it, as needed.
        Me.PermissionNamesTableAdapter.Fill(Me.DsExplosives.PermissionNames)
        'TODO: This line of code loads data into the 'DsExplosives.Conditions' table. You can move, or remove it, as needed.
        ''Me.ConditionsTableAdapter.FillByDistinctName(Me.DsExplosives.Conditions)
        If cmbCnditionFile.Items.Count > 0 Then
            cmbCnditionFile.SelectedIndex = 0
            cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
        End If
        'TODO: This line of code loads data into the 'DsExplosives.Conditions' table. You can move, or remove it, as needed.
        'Me.ConditionsTableAdapter.Fill(Me.DsExplosives.Conditions)
        'Try
        '    Me.ConditionsTableAdapter.FillByDistinctName(Me.DsExplosives.Conditions)
        'Catch ex As System.Exception
        '    System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

        'cmbCnditionFile.SelectedIndex = 0
        'cmbCnditionFile_SelectedIndexChanged(Nothing, Nothing)
        Dim scr As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object Num. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Num = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object scr. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        scr = 0

        'cmbCnditionFile.SelectedIndex = 0
    End Sub
	Private Sub frmConditions_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If List1.Items.Count > 0 Then
            'txtCondition.Text = VB6.GetItemString(List1, List1.SelectedIndex)
            cmdRemove.Enabled = True
            ToBeEdited = True
        End If
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
	
	'UPGRADE_WARNING: Event txtCondition.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtCondition_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Len(txtCondition.Text) = 0 Then
        '    cmdPlus.Enabled = False
        'Else
        '    cmdPlus.Enabled = True
        'End If
        'If ToBeEdited = True Then
        '    'VB6.SetItemString(List1, List1.SelectedIndex, txtCondition.Text)
        'End If
    End Sub
	
    Private Sub txtCondition_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cmdReturn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.CheckedChanged
        Hide()
    End Sub

    Private Sub cmdExit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckedChanged
        Close()
    End Sub

    Private Sub List1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles List1.MouseDoubleClick
        Dim item As DataRowView = List1.SelectedItems(0)
        txtCondition.Text = item(0).ToString

        ToBeEdited = True
        cmdPlus.Text = " ⁄œÌ·"

        OldCondition = txtCondition.Text
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        cmdPlus.Text = "+"
        OldCondition = ""
        ToBeEdited = False
    End Sub
End Class