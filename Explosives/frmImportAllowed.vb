Option Strict Off
Option Explicit On
Friend Class frmImportAllowed
    Inherits System.Windows.Forms.Form
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
    'Private RS As New ADODB.Recordset
    '	Private Its, IDbefore As String
    '	Private Searched, Loaded As Boolean
    '	Private Sub Con()
    '        'RS = New ADODB.Recordset
    '        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'RS.Open("Select * From ImportAllowed", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '	End Sub
    '	Private Sub ToDB()
    '		'On Error Resume Next
    '        'RS.Fields("ID").Value = txtID.Text
    '        'RS.Fields("FDate").Value = VB6.Format(txtDate.Text, "DD/MM/YYYY")
    '        'RS.Fields("SideName").Value = txtSideName.Text
    '        'RS.Fields("Address").Value = txtAddress.Text
    '        'RS.Fields("Tel1").Value = txtTel1.Text
    '        'RS.Fields("Tel2").Value = txtTel2.Text
    '        'RS.Fields("Tel3").Value = txtTel3.Text
    '        'RS.Fields("E_Mail").Value = txtE_mail.Text
    '        'RS.Fields("Fax").Value = txtFax.Text
    '        'RS.Fields("POB").Value = txtPOB.Text
    '        'RS.Fields("Other").Value = txtOther.Text
    '	End Sub
    '	Private Sub FromDB()
    '		Dim List1 As Object
    '		Dim RSteam As Object
    '		Dim i As Object
    '		On Error Resume Next
    '        'clr()
    '        'txtID.Text = RS.Fields("ID").Value
    '        'txtDate.Text = VB6.Format(RS.Fields("FDate").Value, "YYYY/MM/DD")
    '        'txtSideName.Text = RS.Fields("SideName").Value
    '        'txtAddress.Text = RS.Fields("Address").Value
    '        'txtTel1.Text = RS.Fields("Tel1").Value
    '        'txtTel2.Text = RS.Fields("Tel2").Value
    '        'txtTel3.Text = RS.Fields("Tel3").Value
    '        'txtE_mail.Text = RS.Fields("E_Mail").Value
    '        'txtFax.Text = RS.Fields("Fax").Value
    '        'txtPOB.Text = RS.Fields("POB").Value
    '        'txtOther.Text = RS.Fields("Other").Value
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object RSteam.RecordCount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'For i = 0 To RSteam.RecordCount - 1
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object RSteam!Unit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object RSteam!Name. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object RSteam!RANK. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object RSteam!ID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object List1.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	List1.AddItem(RSteam!ID & vbTab & RSteam!RANK & vbTab & RSteam!Name & RSteam!Unit)
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object RSteam.MoveNext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	RSteam.MoveNext()
    '        'Next 
    '        'If RS.RecordCount > 0 Then
    '        '	lblPosition.Text = "0 / 0"
    '        '	lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
    '        'Else
    '        '	lblPosition.Text = "0 / 0"
    '        'End If
    '	End Sub



    '	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        If cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                IMPORTALLOWEDBindingSource.CancelEdit()
                DisableSave()
                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
            End If
        End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        On Error Resume Next
        If cmdDelete.CheckState = System.Windows.Forms.CheckState.Checked Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·„·› ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                IMPORTALLOWEDBindingSource.RemoveCurrent()
                IMPORTALLOWEDTableAdapter.Update(DsExplosives.IMPORTALLOWED)
              
                MsgBox(" „ Õ–› «·„·› !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxHelp)
                DisableSave()
            End If

        End If
    End Sub

    'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        EnableSave()
    End Sub

    '	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        If cmdExit.CheckState = 1 Then Application.Exit()
    End Sub

    '	'UPGRADE_WARNING: Event cmdFindNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFindNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindNext.CheckStateChanged

        'On Error Resume Next
        'If cmdFindNext.CheckState = System.Windows.Forms.CheckState.Checked Then
        '    'RS.MoveNext()
        '    'If RS.EOF Then
        '    '	RS.MoveLast()
        '    '	Beep()
        '    'End If
        '    FromDB()
        '    cmdFindNext.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdFindPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFindPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindPrev.CheckStateChanged
        'On Error Resume Next
        'If cmdFindPrev.CheckState = System.Windows.Forms.CheckState.Checked Then
        '    'RS.MovePrevious()
        '    'If RS.BOF Then
        '    '	RS.MoveFirst()
        '    '	Beep()
        '    'End If
        '    FromDB()
        '    cmdFindPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        'On Error Resume Next
        IMPORTALLOWEDBindingSource.MoveFirst()
      
    End Sub

    '	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
    '		Dim dtrImportAllowed As Object
    '		Dim Recent As Object
    '		On Error GoTo er
    '		If cmdFound.CheckState = 1 Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'Recent = RS.AbsolutePosition
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.DataSource = RS
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.Refresh()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.Show()
    '            'RS.MoveFirst()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RS.Move(Recent - 1)
    '			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			Exit Sub
    'er: 
    '			MsgBox(Err.Description)
    '			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If

    '	End Sub

    '	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        IMPORTALLOWEDBindingSource.MoveLast()
        'On Error Resume Next
        'If cmdLast.CheckState = System.Windows.Forms.CheckState.Checked Then
        '    If Searched = True Then
        '        Con()
        '        Searched = False
        '    End If
        '    'RS.MoveLast()
        '    Beep()
        '    FromDB()
        '    cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        IMPORTALLOWEDBindingSource.AddNew()
        dtpFDate.Value = DateTime.Now
        EnableSave()
    End Sub

    '	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        IMPORTALLOWEDBindingSource.MoveNext()
        'On Error Resume Next
      
    End Sub

    '	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        IMPORTALLOWEDBindingSource.MovePrevious()
        'On Error Resume Next
        'If cmdPrev.CheckState = System.Windows.Forms.CheckState.Checked Then
        '    If Searched = True Then
        '        Con()
        '        'RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        '        Searched = False
        '    End If
        '    'RS.MovePrevious()
        '    'If RS.BOF Then
        '    '	RS.MoveFirst()
        '    '	Beep()
        '    'End If
        '    FromDB()
        '    cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If

    End Sub

    '	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
    '		Dim dtrImportAllowed As Object
    '		On Error GoTo er
    '		If cmdPrintAll.CheckState = 1 Then
    '			Con()
    '			FromDB()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.DataSource = RS
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrImportAllowed.Refresh()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrImportAllowed.Show()
    '			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			Exit Sub
    'er: 
    '			MsgBox(Err.Description)
    '			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If

    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
    '		Dim dtrImportAllowed As Object
    '		On Error GoTo er
    '        'Dim RSs As New ADODB.Recordset
    '		If cmdPrintDoc.CheckState = 1 Then
    '            'RSs = New ADODB.Recordset
    '            'If RSs.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '            'RSs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            'RSs.Open("Select * From ImportAllowed Where SideName='" & txtSideName.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.DataSource = RSs
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.Refresh()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrImportAllowed.Show()
    '			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			Exit Sub
    'er: 
    '			MsgBox(Err.Description)
    '			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If

    '	End Sub

    '	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
    '		If cmdRefresh.CheckState = 1 Then
    '			Its = ""
    '			Con()
    '			FromDB()
    '			cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        If cmdReturn.CheckState = 1 Then
            frmMain.Show()
            Me.Hide()
            cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        
        IMPORTALLOWEDBindingSource.EndEdit()
        IMPORTALLOWEDTableAdapter.Update(DsExplosives.IMPORTALLOWED)
        MsgBox(" „ Õ›Ÿ «·„·› !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
        DisableSave()
    End Sub

    '	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
    '		Dim dtrImportAllowed As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrImportAllowed.Show()
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrImportAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrImportAllowed.DataSource = RS
    '	End Sub

    '	'UPGRADE_WARNING: Form event frmImportAllowed.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    '	Private Sub frmImportAllowed_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
    '		cmdRefresh.Width = Me.ClientRectangle.Width
    '        'LoadAllSettings()
    '        'ApplySettings()
    '	End Sub

    '	Private Sub frmImportAllowed_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    '		Con()
    '		FromDB()
    '		Loaded = False
    '		cmbCriteria.SelectedIndex = 0
    '		Loaded = True
    '	End Sub

    '	Private Sub optDate_Click()
    '		Dim optDate As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optDate.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optDate.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub optID_Click()
    '		Dim optID As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optID.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optID.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub optSideName_Click()
    '		Dim optSideName As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optSideName.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optSideName.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub frmImportAllowed_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '        'ProgramExit()
    '		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
    '        'Cancel = MyCancel
    '	End Sub

    '	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
    '		'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
    '	End Sub

    '	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
    '		Dim ccontorl As Object
    '		Dim ccontrol As System.Windows.Forms.Control
    '		On Error Resume Next
    '		For	Each ccontrol In Me.Controls
    '			'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '			If Me.ActiveControl.Name = ccontrol.Name Then
    '				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '				If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
    '					'UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                    ''ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
    '				End If
    '			Else
    '				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '				If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
    '					'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					If ccontorl.Enabled = True Then
    '						'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
    '					Else
    '						'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
    '					End If
    '					'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '					If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
    '						'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
    '					End If
    '				End If
    '			End If
    '		Next ccontrol
    '	End Sub

    '	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
    '		Dim idexit As Object
    '		Dim MyField As Object
    '		On Error Resume Next
    '        'If Loaded = True Then
    '        If Searched <> True Then IDbefore = txtSideName.Text
    '        Searched = True
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "⁄«„" Then MyField = "Where Address Like '%" & txtFind.Text & "%' Or ID Like '" & txtFind.Text & "' Or SideName Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "«”„ «·ÃÂ…" Then MyField = "Where SideName Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "«·⁄‰Ê«‰" Then MyField = "Where Address Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "‰„—… «·„·›" Then MyField = "Where ID = '" & txtFind.Text & "'"
    '        'RS = New ADODB.Recordset
    '        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'RS.Open("Select * From ImportAllowed " & MyField, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        FromDB()
    '        'If RS.RecordCount = 0 Then
    '        '          clr()
    '        '          cmdPrintDoc.Enabled = False
    '        '          cmdFound.Enabled = False
    '        '      Else
    '        '          cmdPrintDoc.Enabled = True
    '        '          cmdFound.Enabled = True
    '        '      End If
    '        '      If RS.RecordCount < 2 Then
    '        '          cmdFindNext.Enabled = False
    '        '          cmdFindPrev.Enabled = False
    '        '          'UPGRADE_WARNING: Couldn't resolve default property of object idexit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '          If idexit = True Then Exit Sub
    '        '      Else
    '        '          cmdFindNext.Enabled = True
    '        '          cmdFindPrev.Enabled = True
    '        '      End If
    '        'End If
    '    End Sub
    '	Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtID.Leave
    '		Dim Y As Object
    '		Dim x As Object
    '		On Error Resume Next
    '		If Its = "add" Or (Its = "edit" And txtID.Text <> IDbefore) Then
    '			If txtID.Text = vbNullString Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ ‰„—… «·„·› ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					txtID.Focus()
    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '                'RS.MoveFirst()
    '                'RS.Find("ID='" & txtID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '                'If RS.EOF Then
    '                '	RS.MoveFirst()
    '                'Else
    '                '	'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                '	Y = MsgBox("⁄›Ê« ! Â–« «·„·› „ÊÃÊœ ° Â·  —Ìœ/Ì‰ —ƒÌ Â ø", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
    '                '	If Y = MsgBoxResult.Yes Then
    '                '		FromDB()
    '                '		EnDis(False, False, True)
    '                '		TextLock()
    '                '		Its = ""
    '                '	ElseIf Y = MsgBoxResult.No Then 
    '                '		txtID.Focus()
    '                '	ElseIf Y = MsgBoxResult.Cancel Then 
    '                '		cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '                '	End If
    '                'End If
    '			End If
    '		End If
    '	End Sub

    Private Sub frmImportAllowed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.IMPORTALLOWED' table. You can move, or remove it, as needed.
        Me.IMPORTALLOWEDTableAdapter.Fill(Me.DsExplosives.IMPORTALLOWED)
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (IMPORTALLOWEDBindingSource.Position + 1).ToString + " / " + IMPORTALLOWEDBindingSource.Count.ToString


    End Sub

    Private Sub cmdPrintDoc_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged

    End Sub
End Class