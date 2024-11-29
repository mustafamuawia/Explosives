Option Strict Off
Option Explicit On
Friend Class frmWorkCopies
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RSlist As New ADODB.Recordset
    Dim Current As Integer = 0
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

    Private Sub cmbRegion_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'txtState_Leave(txtState, New System.EventArgs())
    End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        'Dim ActvCtrl As Object
        'Dim txtID As Object
		Dim X As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			X = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
			If X = MsgBoxResult.Yes Then
                'TextLock()
                WorkCopiesBindingSource.CancelEdit()
                DisableSave()
                IsAdd = False

				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
			Else
            End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim X As Object
      
			X = MsgBox("Â· √‰  „ √ﬂœ „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·„·› ø", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If X = MsgBoxResult.Yes Then
            Dim daWorkCopiesDetails As New dsExplosivesTableAdapters.WorkCopiesDetailsTableAdapter
            'If txtID.Text <> "" Then
            '    daWorkCopiesDetails.DeleteByWorkCopyID(Convert.ToInt32(txtID.Text))
            'End If
            WorkCopiesBindingSource.RemoveCurrent()
            WorkCopiesTableAdapter.Update(DsExplosives.WorkCopies)
            MessageBox.Show(" „")
            DisableSave()
        End If
        cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked

	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        EnableSave()

	End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close()
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        Current = 0
        WorkCopiesBindingSource.Position = Current
        GetWorkCopySirs()
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
		Dim dtrWorkCopies As Object
		On Error GoTo er
        'Dim r As New ADODB.Recordset
		If cmdFmtDoc.CheckState = 1 Then
            'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
            'r.Open("Shape  {Select * From Copies Order By State} As Cmd Compute Cmd By 'State'", DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkCopies.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkCopies.DataSource = r
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkCopies.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkCopies.Show()
            '' If r.State = adStateOpen Then r.Close
            'cmdFmtDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		cmdFmtDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        Current = WorkCopiesBindingSource.Count - 1
        WorkCopiesBindingSource.Position = Current

        
        GetWorkCopySirs()
    End Sub
	
	'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'If cmdLogout.CheckState = 1 Then LogOut()
	End Sub
	
	'UPGRADE_WARNING: Event cmdMinus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdMinus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMinus.CheckStateChanged
        On Error Resume Next
        If cmdMinus.CheckState = 1 Then
            lstSirs.Items.RemoveAt((lstSirs.SelectedIndex))
            lblNo.Text = CStr(lstSirs.Items.Count)
            cmdMinus.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        WorkCopiesBindingSource.AddNew()
        EnableSave()

        lstSirs.Items.Clear()
        IsAdd = True
	End Sub

	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged

        'Current = WorkCopiesBindingSource.Position
        If Current <= WorkCopiesBindingSource.Count - 1 Then
            Current += 1
            WorkCopiesBindingSource.Position = Current

        End If

    End Sub
	
	'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim Index As Integer = lstSirs.FindStringExact(txtSir.Text)
        If Index = -1 Then


            lstSirs.Items.Add("«·”Ìœ/ " & txtSir.Text)
            txtSir.Text = ""
        Else

            MsgBox("„÷«› „”»ﬁ«")

        End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged


        If Current > 0 Then
            Current -= 1
            WorkCopiesBindingSource.Position = Current
            GetWorkCopySirs()
        End If

	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
		If cmdRefresh.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

			cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
	End Sub
    Dim IsAdd As Boolean = False
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        If lstSirs.Items.Count = 0 Then
            MsgBox("·« »œ „‰ «÷«›… ÃÂ« ")
            Return
        End If
        If IsAdd Then

            'If WorkCopiesTableAdapter.GetDataByStateRegion(txtState.Text, cmbRegion.Text).Rows.Count > 0 Then
            '    MsgBox("«·„‰ÿﬁ… „÷«›… „‰ ﬁ»·")
            '    Return
            'End If
        End If

        WorkCopiesBindingSource.EndEdit()
        WorkCopiesTableAdapter.Update(DsExplosives.WorkCopies)
        Dim daWorkCopiesDetails As New dsExplosivesTableAdapters.WorkCopiesDetailsTableAdapter
        If lblID.Text <> "-1" Then
            daWorkCopiesDetails.DeleteByWorkCopyID(Convert.ToInt32(lblID.Text))
            For i = 0 To lstSirs.Items.Count - 1
                daWorkCopiesDetails.Insert(lstSirs.Items(i).ToString, Convert.ToInt32(lblID.Text))
            Next
            MsgBox(" „ «·Õ›Ÿ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
            lblDestination.Text = ""
            DisableSave()
            IsAdd = False
        End If
    End Sub
	
	Private Sub DataGrid1_Click()
		
	End Sub
	
	Private Sub Command1_Click()
        'ApplySettings()
	End Sub
	
	
	
	'UPGRADE_WARNING: Form event frmWorkCopies.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmWorkCopies_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'LoadAllSettings()
        'ApplySettings()
        cmdRefresh.Width = Me.ClientRectangle.Width
    End Sub
	
    Private Sub GetWorkCopySirs()

        lstSirs.Items.Clear()
        Dim dtWorkCopiesDetails As dsExplosives.WorkCopiesDetailsDataTable
        dtWorkCopiesDetails = New dsExplosivesTableAdapters.WorkCopiesDetailsTableAdapter().GetDataByWorkCopyID(Convert.ToInt32(lblID.Text))
        For i As Integer = 0 To dtWorkCopiesDetails.Rows.Count - 1
            Dim drWorkCopyDetails As dsExplosives.WorkCopiesDetailsRow = dtWorkCopiesDetails.Rows(i)
            lstSirs.Items.Add(drWorkCopyDetails.Sirs)
        Next
        lblNo.Text = lstSirs.Items.Count.ToString
    End Sub
	Private Sub frmWorkCopies_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.WorkCopies' table. You can move, or remove it, as needed.
        Me.WorkCopiesTableAdapter.Fill(Me.DsExplosives.WorkCopies)
        Me.WorkCopiesTableAdapter.FillDistinctState(Me.StateDsExplosives1.WorkCopies)

        'If Me.StateDsExplosives1.WorkCopies.Rows.Count > 0 Then
        '    txtState.SelectedIndex = 0

        '    txtState_SelectedIndexChanged(Nothing, Nothing)

        '    GetWorkCopySirs()

        'End If



        'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkCopies.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrWorkCopies.DataSource = RS
    End Sub
	
	Private Sub frmWorkCopies_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	Private Sub lstSirs_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstSirs.DoubleClick
		cmdMinus_CheckStateChanged(cmdMinus, New System.EventArgs())
	End Sub
	
    Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
    End Sub
	
    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontorl As Object
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
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
	
    Private Sub txtSir_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
    Private Sub FillRegion()
        'cmbRegion.Items.Clear()

        'For i As Integer = 0 To Me.RegionDsExplosives1.WorkCopies.Rows.Count - 1
        '    cmbRegion.Items.Add(RegionDsExplosives1.WorkCopies(i)._Region)
        'Next
        'If cmbRegion.Items.Count Then
        '    cmbRegion.SelectedIndex = 0
        '    cmbRegion_SelectedIndexChanged(Nothing, Nothing)
        'End If
        
    End Sub

	'UPGRADE_WARNING: Event txtState.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtState_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If Not IsAdd Then


        'If Me.StateDsExplosives1.WorkCopies.Rows.Count > 0 Then
        '    Dim daWorkCopies As New dsExplosivesTableAdapters.WorkCopiesTableAdapter
        '    daWorkCopies.GetDataDistinctRegion(txtState.Text).CopyToDataTable(Me.RegionDsExplosives1.WorkCopies, LoadOption.OverwriteChanges)

        '    FillRegion()
        'End If

        'End If
    End Sub
	
    Private Sub txtState_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim X As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Or Me.ActiveControl.Name = "cmbRegion" Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or (Its = "edit" And txtState.Text <> IDbefore And IDbefore2 <> cmbRegion.Text) Then
        '	If txtState.Text = "" Then
        '		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		X = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·Ê·«Ì… ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
        '		If X = MsgBoxResult.OK Then
        '			txtState.Focus()
        '		ElseIf X = MsgBoxResult.Cancel Then 
        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '		End If
        '	Else
        'If RS.RecordCount > 0 Then
        '	RS.MoveFirst()
        '	RS.Find("State='" & txtState.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        '	RS.Find("Region ='" & cmbRegion.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '	If RS.EOF Then
        '		RS.MoveFirst()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		RS.Find("State='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		RS.Find("Region='" & IDbefore2 & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '		RS.Move(RSlist.RecordCount)
        '	Else
        '		'UPGRADE_WARNING: Couldn't resolve default property of object X. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		X = MsgBox("⁄›Ê« ! »Ì«‰«  Â–Â «·Ê·«Ì… „ÊÃÊœ… ∫ Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â« ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
        '		If X = MsgBoxResult.No Then
        '			txtState.Focus()
        '		ElseIf X = MsgBoxResult.Yes Then 
        '			TextLock()
        '			EnDis(False, False, True)
        '			FromDB()
        '		ElseIf X = MsgBoxResult.Cancel Then 
        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '		End If
        '	End If
        '          End If
        '	End If
        'End If
    End Sub

    Private Sub cmbRegion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Not IsAdd Then
        'If cmbRegion.Items.Count > 0 Then
        '    Dim dtWorkCopies As New dsExplosives.WorkCopiesDataTable
        '    dtWorkCopies = New dsExplosivesTableAdapters.WorkCopiesTableAdapter().GetDataByStateRegion(txtState.Text, cmbRegion.Text)

        '    If dtWorkCopies.Rows.Count > 0 Then
        '        Dim WorkID As Integer = dtWorkCopies(0).ID

        '        Current = WorkCopiesBindingSource.Find("ID", WorkID)

        '        'txtID.Text = WorkID

        '        GetWorkCopySirs()
        '    End If
        'End If
        'End If
    End Sub

  
    'Private Function MoveListboxItem(ByVal List1 As ListBox, ByVal CurrentIndex As Integer, ByVal NewIndex As Integer)
    '    Dim strItem As String
    '    strItem = lstSirs.List(CurrentIndex)
    '    lstSirs.RemoveItem(CurrentIndex)
    '    lstSirs.AddItem(strItem, NewIndex)
    'End Function
    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click

        If lstSirs.SelectedItems.Count <> 1 Then Exit Sub
        Dim pos As Integer = lstSirs.SelectedIndex
        If pos < 1 Then Exit Sub
        Dim item As Object = lstSirs.SelectedItem
        lstSirs.Items.Remove(item)
        lstSirs.Items.Insert(pos - 1, item)
        lstSirs.SelectedItem = item
        lstSirs.Focus()

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        If lstSirs.SelectedItems.Count <> 1 Then Exit Sub
        Dim pos As Integer = lstSirs.SelectedIndex
        If pos > lstSirs.Items.Count - 1 Then Exit Sub
        Dim item As Object = lstSirs.SelectedItem
        lstSirs.Items.Remove(item)
        lstSirs.Items.Insert(pos + 1, item)
        lstSirs.SelectedItem = item
        lstSirs.Focus()
    End Sub

    Private Sub WorkCopiesBindingSource_PositionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If e.RowIndex = DataGridView1.NewRowIndex Then
            lblID.Text = "-1"

            'MessageBox.Show("new row")
        Else
            GetWorkCopySirs()
            lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
            lblDestination.Text = DataGridView1.Rows(e.RowIndex).Cells("StateDataGridViewTextBoxColumn").Value + " - " + DataGridView1.Rows(e.RowIndex).Cells("RegionDataGridViewTextBoxColumn").Value
        End If
        'lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        'Dim dtPassCoppies As New dsExplosives.PassCopiesDataTable

        'If lblID.Text <> "0" Then
        '    '    PassCopyID = dtPassCoppies(0).ID

        '    '    Dim Index = PassCopiesBindingSource.Find("ID", PassCopyID)
        '    '    PassCopiesBindingSource.Position = Index
        '    GetWorkCopySirs()
        'End If
        'If lstSirs.Items.Count = 0 Then
        '    If MessageBox.Show("Â–Â «·‰ﬁÿ… ·Ì” ·œÌÂ« ÃÂ«  „Œ«ÿ»… Â·  Êœ «÷«›… ÃÂ«  ·Â«ø", " ‰»ÌÂ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

        '    End If
        'End If
    End Sub

    Private Sub cmdSave_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub
End Class