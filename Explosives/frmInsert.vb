Option Strict Off
Option Explicit On
Friend Class frmInsert
	Inherits System.Windows.Forms.Form
	Private Sub DataGrid1_Click()
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cmdOk.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdOk_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOk.CheckStateChanged
		Dim i As Object
        'frmPassPermissions.dgvItems.Rows.Clear()
        'For i = 0 To DataGridView1.Rows.Count - 1
        '    frmPassPermissions.dgvItems.Rows.Add(DataGridView1.Rows(i).Cells(0).Value, DataGridView1.Rows(i).Cells(1).Value, DataGridView1.Rows(i).Cells(2).Value)
        'Next
        Me.Close()
		
	End Sub
	
	'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
		Dim j As Object
		Dim i As Object
		'On Error Resume Next
		If cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked Then
			If txtAmmount.Text = "" Or IsNumeric(txtAmmount.Text) = False Then
				MsgBox("⁄›Ê« ! ·„  ﬁ„ »≈œŒ«· «·ﬂ„Ì…", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
				Exit Sub
			End If
			If cmbUnit.Text = "" Then
				MsgBox("⁄›Ê« ! ·„  ﬁ„ »≈œŒ«· ÊÕœ… «·ﬁÌ«”", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
				Exit Sub
			End If
			If cmbClass.Text = "" Then
				MsgBox("⁄›Ê« ·„  ﬁ„ »≈œŒ«· «·’‰›", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
				Exit Sub
			End If
            'For i = 0 To lstClass.Items.Count - 1
            '	'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	For j = i To lstClass.Items.Count - 1
            '                 'If VB6.GetItemString(lstClass, i) = cmbClass.Text Then
            '                 '	MsgBox("⁄›Ê« ! ·ﬁœ ﬁ„  »≈œŒ«· Â–« «·’‰› (" & cmbClass.Text & "). ›÷·«  √ﬂœ „‰ ’Õ… «·»Ì«‰«  «·„œŒ·…", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
            '                 '	cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
            '                 '	Exit Sub
            '                 'End If
            '	Next 
            'Next 
			
			'  End If
            'lstAmmount.Items.Add(txtAmmount.Text)
            'lstUnit.Items.Add(cmbUnit.Text)
            'lstClass.Items.Add(cmbClass.Text)
            DataGridView1.Rows.Add(cmbClass.Text, cmbUnit.Text, txtAmmount.Text)
			cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
			txtAmmount.Text = ""
			cmbUnit.Text = ""
			cmbClass.Text = ""
			
		End If
		
	End Sub
	'UPGRADE_WARNING: Event cmdMinus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdMinus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMinus.CheckStateChanged
		Dim lstRecord As Object
		Dim lstClassID As Object
		On Error Resume Next
		If cmdMinus.CheckState Then
            'lstAmmount.Items.RemoveAt((lstAmmount.SelectedIndex))
            'lstUnit.Items.RemoveAt((lstUnit.SelectedIndex))
            'lstClass.Items.RemoveAt((lstClass.SelectedIndex))
			'UPGRADE_WARNING: Couldn't resolve default property of object lstClassID.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object lstClassID.RemoveItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'lstClassID.RemoveItem(lstClassID.ListIndex)
			'UPGRADE_WARNING: Couldn't resolve default property of object lstRecord.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object lstRecord.RemoveItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'lstRecord.RemoveItem(lstRecord.ListIndex)
			cmdMinus.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	Private Sub cmbClass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmInsert_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Icon = frmMain.Icon
        'LoadAllSettings()
        'ApplySettings()
	End Sub
	
	'UPGRADE_WARNING: Event lstAmmount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstAmmount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error Resume Next
        'lstUnit.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
        'lstClass.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
    End Sub
	
	'UPGRADE_WARNING: Event lstClass.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstClass_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error Resume Next
        'lstAmmount.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
        'lstUnit.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
    End Sub
	
	'UPGRADE_WARNING: Event lstUnit.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstUnit_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error Resume Next
        'lstAmmount.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
        'lstClass.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
    End Sub
End Class