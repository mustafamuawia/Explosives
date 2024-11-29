Option Strict Off
Option Explicit On
Friend Class frmPassPermissions
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RS2 As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
    'Private RSMaxMin As New ADODB.Recordset
	Private MinDate, dtrWhere, dtrSelect, MyField, str2, IDbefore, Its, str1, str3, Searched, FromSelection, dtrCompute, MaxDate As Object
	Private Loaded, FDistracted As Boolean
    Private MyWPValidation As String
    Public OurDistactID As Integer = -1
    Public ImportPermissionID As Integer = -1
	
	
	
	
	
	
	Private Sub Check4_Click()
		
	End Sub
	
	'UPGRADE_WARNING: Event cmbCriteria.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCriteria_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
		If cmbCriteria.Text <> "" Then
			txtFind_TextChanged(txtFind, New System.EventArgs())
		Else
			txtDate1_TextChanged(txtDate1, New System.EventArgs())
		End If
	End Sub
	
	
	
	
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
				'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Its = ""
                PERMISSIONSBindingSource.CancelEdit()

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
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «· ’—ÌÕ ø", MsgBoxStyle.YesNo + MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight)
			If x = MsgBoxResult.Yes Then
                PERMISSIONSBindingSource.RemoveCurrent()
                PERMISSIONSTableAdapter.Update(DsExplosives.PERMISSIONS)
				MsgBox(" ‹‹‹‹‹‹‹„ «·Õ‹‹–› !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
                cmdDelete.Enabled = False
			End If
			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDistract.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDistract_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistract.CheckStateChanged
		If cmdDistract.CheckState = 1 Then
            'If Distracted = True Then
            '	cmdDistract.CheckState = System.Windows.Forms.CheckState.Unchecked
            '	Distracted = False
            '	Exit Sub
            'End If
			Me.Hide()
            'AddDistract = True
            'frmOurDistract.Show()
            'MyForm = Me
            'frmOurDistract.cmdNew.CheckState = System.Windows.Forms.CheckState.Checked
		ElseIf cmdDistract.CheckState = 0 Then 
			'   Distracted = True
			'   Distracted = False
			'  cmdNew.Value = 1
			'  txtfID.Text = DisID
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        IsAdd = False
        cmdSave.Enabled = True
        cmdDelete.Enabled = True
        cmdNew.Enabled = False
        
    End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
		Dim x As Object
		If cmdExit.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ «·Œ—ÊÃ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                Close()

            End If

		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        PermissionDetailsBindingSource.MoveFirst()
        DataGridView1.Rows.Clear()

        If DsExplosives.PERMISSIONS.Rows.Count > 0 Then


            Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.DsExplosives.PermissionDetails, Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DsExplosives.PermissionDetails.Rows.Count - 1
                DataGridView1.Rows.Add(DsExplosives.PermissionDetails(i).Description, DsExplosives.PermissionDetails(i).Unit, DsExplosives.PermissionDetails(i).Quanitity)
            Next
        End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtAll.CheckStateChanged
		Dim DataReport2 As Object
		On Error GoTo er
		If cmdFmtAll.CheckState = 1 Then
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrCompute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSelect & dtrCompute, DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport2.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport2.DataSource = RsRpt
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport2.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport2.Show()
            'cmdFmtAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdFmtAll.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
        If txtID.Text <> "" Then
            Dim fPrintPassPermission As New frmprintPassPermission(Convert.ToInt32(txtID.Text))
            fPrintPassPermission.ShowDialog()
        End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtFound.CheckStateChanged
		
	End Sub
	
	'UPGRADE_WARNING: Event cmdGetPass.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdGetPass_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdGetPass.CheckStateChanged
		If cmdGetPass.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object MyGetPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'MyGetPass = txtID.Text
            ''UPGRADE_WARNING: Couldn't resolve default property of object MyGetPass2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'MyGetPass2 = txtfID.Text
            'frmGetPass.Show()
            'MyForm = Me
            'Me.Hide()
			cmdGetPass.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdInsertExplosives.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdInsertExplosives_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInsertExplosives.CheckStateChanged
		If cmdInsertExplosives.CheckState Then
            frmInsert.Show()
			cmdInsertExplosives.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        'On Error Resume Next
        PERMISSIONSBindingSource.MoveLast()

        DataGridView1.Rows.Clear()

        If DsExplosives.PERMISSIONS.Rows.Count > 0 Then


            Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.DsExplosives.PermissionDetails, Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DsExplosives.PermissionDetails.Rows.Count - 1
                DataGridView1.Rows.Add(DsExplosives.PermissionDetails(i).Description, DsExplosives.PermissionDetails(i).Unit, DsExplosives.PermissionDetails(i).Quanitity)
            Next
        End If
	End Sub
	
    Dim IsAdd As Boolean = False
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
      
            If optDistract.Checked Then
                Dim fSearchOurDistract As New frmSearchOurDistract()
                If fSearchOurDistract.ShowDialog = DialogResult.OK Then

                    Dim dtOurDistract As New dsExplosives.OURDISTRACTDataTable
                    dtOurDistract = New dsExplosivesTableAdapters.OURDISTRACTTableAdapter().GetDataByID(OurDistactID)
                    If dtOurDistract.Rows.Count > 0 Then


                        DataGridView1.DataSource = Nothing
                    PERMISSIONSBindingSource.AddNew()
                    txtIsImport.Text = "IsDistract"
                        dtpStoreDate.Value = DateTime.Now
                        dtpDate.Value = DateTime.Now
                        dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1)



                    Dim dtOurDistractDetails As New dsExplosives.OurDistractDetailsDataTable
                    cmbSender.Text = dtOurDistract(0).DISTRACTOR
                    cmbReceiver.Text = dtOurDistract(0).RECEIVER.Trim
                    dtOurDistractDetails = New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter().GetDataByOurDistractID(OurDistactID)
                    DataGridView1.DataSource = dtOurDistractDetails
                    If New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER).Rows.Count > 0 Then
                        txtReceiverAddress.Text = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER)(0).LOCATION
                        Try
                            txtWorkID.Text = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER)(0).WorkPermissionNo
                            txtStoreID.Text = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER)(0).WorkPermissionNo
                        Catch ex As Exception

                        End Try

                        txtPurpose.Text = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER)(0).PURPOSE
                        dtpStoreDate.Value = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByFSideName(dtOurDistract(0).RECEIVER)(0).FDATE

                    End If
                    'For i As Integer = 0 To New dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter().GetDataDistinctAddressByPermitted(dtOurDistract(0).DISTRACTOR).Count - 1
                    '    Dim drImportPermission As dsExplosives.IMPORTPERMISSIONSRow
                    '    drImportPermission = New dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter().GetDataDistinctAddressByPermitted(dtOurDistract(0).DISTRACTOR).Rows(i)

                    '    If drImportPermission.ADDRESS <> "" Or drImportPermission.ADDRESS <> " " Then
                    '        txtSenderAddress.Items.Add(drImportPermission.ADDRESS)
                    '    End If

                    'Next
                    If txtSenderAddress.Items.Count > 0 Then
                        txtSenderAddress.SelectedIndex = 0
                    End If

                    cmdSave.Enabled = True
                    cmdNew.Enabled = False
                    IsAdd = True
                    If cmbRank.Items.Count > 0 Then
                        cmbRank.SelectedIndex = 0
                    End If
                    If cmbName.Items.Count > 0 Then
                        cmbName.SelectedIndex = 0
                    End If
                    If cmbPosition.Items.Count > 0 Then
                        cmbPosition.SelectedIndex = 0
                    End If
                End If
                End If
            ElseIf optImport.Checked Then
                Dim fSearchOurDistract As New frmSearchImportPermission()
                If fSearchOurDistract.ShowDialog = DialogResult.OK Then
                'txtSenderAddress.Items.Clear()
                    Dim dtImportPermission As New dsExplosives.IMPORTPERMISSIONSDataTable
                    dtImportPermission = New dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter().GetDataByID(ImportPermissionID)
                    If dtImportPermission.Rows.Count > 0 Then


                        DataGridView1.DataSource = Nothing
                    PERMISSIONSBindingSource.AddNew()
                    txtIsImport.Text = "IsImport"
                        dtpStoreDate.Value = DateTime.Now
                        dtpDate.Value = DateTime.Now
                        dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1)
                        Try


                        Dim dtImportPermissionDetails As New dsExplosives.ImportPermissionDetailsDataTable
                        cmbSender.Text = dtImportPermission(0).PERMITTED
                        cmbReceiver.Text = dtImportPermission(0).PERMITTED
                        dtImportPermissionDetails = New dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter().GetDataByImportPermissionID(ImportPermissionID)
                        DataGridView1.DataSource = dtImportPermissionDetails
                        
                            cmdSave.Enabled = True
                            cmdNew.Enabled = False
                        IsAdd = True
                        If cmbRank.Items.Count > 0 Then
                            cmbRank.SelectedIndex = 0
                        End If
                        If cmbName.Items.Count > 0 Then
                            cmbName.SelectedIndex = 0
                        End If
                        If cmbPosition.Items.Count > 0 Then
                            cmbPosition.SelectedIndex = 0
                        End If

                        Catch ex As Exception

                        End Try
                    End If
                End If
            End If
    End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        PERMISSIONSBindingSource.MoveNext()
        DataGridView1.Rows.Clear()

        If DsExplosives.PERMISSIONS.Rows.Count > 0 Then


            Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.DsExplosives.PermissionDetails, Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DsExplosives.PermissionDetails.Rows.Count - 1
                DataGridView1.Rows.Add(DsExplosives.PermissionDetails(i).Description, DsExplosives.PermissionDetails(i).Unit, DsExplosives.PermissionDetails(i).Quanitity)
            Next
        End If
        'On Error Resume Next
        'If cmdNext.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '	End If
        '	RS.MoveNext()
        '	If RS.EOF Then
        '		RS.MoveLast()
        '		Beep()
        '	End If
        '	FromDB()
        '	cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        PERMISSIONSBindingSource.MovePrevious()
        DataGridView1.Rows.Clear()

        If DsExplosives.PERMISSIONS.Rows.Count > 0 Then


            Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.DsExplosives.PermissionDetails, Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DsExplosives.PermissionDetails.Rows.Count - 1
                DataGridView1.Rows.Add(DsExplosives.PermissionDetails(i).Description, DsExplosives.PermissionDetails(i).Unit, DsExplosives.PermissionDetails(i).Quanitity)
            Next
        End If
        'On Error Resume Next
        'If cmdPrev.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Searched = True Then
        '		Con()
        '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		Searched = False
        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
        '	End If
        '	RS.MovePrevious()
        '	If RS.BOF Then
        '		RS.MoveFirst()
        '		Beep()
        '	End If
        '	FromDB()
        '	cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged

        'If cmdRefresh.CheckState = 1 Then
        '    'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    Its = ""
        '    Con()
        '    FromDB()
        '    cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptAll.CheckStateChanged
        '		Dim dtrPermissions As Object
        '		On Error GoTo er
        '		If cmdRptAll.CheckState = 1 Then
        '			Con()
        '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '            'dtrPermissions.DataSource = RS
        '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			dtrPermissions.Show()
        '			cmdRptAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        '		End If
        '		Exit Sub
        'er: 
        '		cmdRptAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        '		MsgBox(Err.Description)
        '		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptFound.CheckStateChanged
		Dim dtrPermissions As Object
		Dim Recent As Object
		On Error GoTo er
        'If cmdRptFound.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Recent = RS.AbsolutePosition
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrPermissions.DataSource = RS
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrPermissions.Refresh()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrPermissions.Show()
        '	RS.MoveFirst()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	RS.Move(Recent - 1)
        '	cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
		Exit Sub
er: 
		cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptDoc.CheckStateChanged
		Dim dtrPermissions As Object
		On Error GoTo er
        'Dim rsperm As New ADODB.Recordset
        'If cmdRptDoc.CheckState = 1 Then
        '	rsperm = New ADODB.Recordset
        '	If rsperm.State = ADODB.ObjectStateEnum.adStateOpen Then rsperm.Close()
        '	rsperm.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	rsperm.Open("Select * From Permissions Where ID='" & txtID.Text & "'", DB)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrPermissions.DataSource = rsperm
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrPermissions.Show()
        '	cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical, "")
		Err.Clear()
		cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
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
        cmbRank.BackColor = Color.White
        cmbName.BackColor = Color.White
        cmbPosition.BackColor = Color.White
        cmbRank.BackColor = Color.White
        cmbBy.BackColor = Color.White
        txtPoint1.BackColor = Color.White
        txtPoint2.BackColor = Color.White
        txtPoint3.BackColor = Color.White
        cmbSender.BackColor = Color.White
        txtToStore.BackColor = Color.White
        cmbReceiver.BackColor = Color.White
        txtSenderAddress.BackColor = Color.White
        txtReceiverAddress.BackColor = Color.White
        If cmbRank.Text = "" Then
            cmbRank.BackColor = Color.Red
            Return
        End If
        If cmbName.Text = "" Then
            cmbName.BackColor = Color.Red
            Return
        End If
        If cmbPosition.Text = "" Then
            cmbPosition.BackColor = Color.Red
            Return
        End If
        If cmbBy.Text = "" Then
            cmbBy.BackColor = Color.Red
            Return
        End If
        If txtPoint1.Text = "" Then
            txtPoint1.BackColor = Color.Red
            Return
        End If
        If txtPoint2.Text = "" Then
            txtPoint2.BackColor = Color.Red
            Return
        End If
        If txtPoint3.Text = "" Then
            txtPoint3.BackColor = Color.Red
            Return
        End If
        If txtToStore.Text = "" Then
            txtToStore.BackColor = Color.Red
            Return
        End If
        If cmbSender.Text = "" Then
            cmbSender.BackColor = Color.Red
            Return
        End If
        If cmbReceiver.Text = "" Then
            cmbReceiver.BackColor = Color.Red
            Return
        End If
        If txtSenderAddress.Text = "" Then
            txtSenderAddress.BackColor = Color.Red
            Return
        End If
        If txtReceiverAddress.Text = "" Then
            txtReceiverAddress.BackColor = Color.Red
            Return
        End If
        


        If IsAdd And txtPassPermissionNo.Text = "" Then
            Dim dtPassPermissionNo As New dsExplosives.PERMISSIONSDataTable
            'dtPassPermissionNo = New dsExplosivesTableAdapters.PERMISSIONSTableAdapter().GetDataByYearPassPermissionNo(dtpDate.Value.Year, Convert.ToInt32(txtPassPermissionNo.Text))
            'If dtPassPermissionNo.Rows.Count > 0 Then


            '    MsgBox("«Œ— ‰„—… ÂÌ : " & dtPassPermissionNo(0).PassPermissionNo & Environment.NewLine & "«·—Ã«¡  €ÌÌ— «·‰„—…")
            '    Return
            'End If
            dtPassPermissionNo = New dsExplosivesTableAdapters.PERMISSIONSTableAdapter().GetDataByMaxPassPermissionNO_Year(dtpDate.Value.Year)
            If dtPassPermissionNo.Rows.Count = 0 Then
                txtPassPermissionNo.Text = 1
            Else
                If IsDBNull(dtPassPermissionNo(0)("PassPermissionNo")) Then
                    txtPassPermissionNo.Text = 1
                Else

                    txtPassPermissionNo.Text = dtPassPermissionNo(0).PassPermissionNo + 1
                End If
            End If

        End If

        PERMISSIONSBindingSource.EndEdit()
        PERMISSIONSTableAdapter.Update(DsExplosives.PERMISSIONS)

        If DataGridView1.Rows.Count > 0 Then
            Dim daPassPermissionDetails As New dsExplosivesTableAdapters.PermissionDetailsTableAdapter
            daPassPermissionDetails.DeleteByPermissionID(Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DataGridView1.Rows.Count - 1

                daPassPermissionDetails.Insert(Convert.ToInt32(txtID.Text), DataGridView1.Rows(i).Cells("Description").Value,
                                               DataGridView1.Rows(i).Cells("Unit").Value,
                                               Convert.ToInt32(DataGridView1.Rows(i).Cells("Quantity").Value))
            Next
        End If
        MsgBox(" „")
        cmdSave.Enabled = False
        cmdDelete.Enabled = False
        cmdNew.Enabled = True
        IsAdd = False
        'Dim n As New ADODB.Recordset
        'If cmdSave.CheckState = 1 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Its = "add" Then RS.AddNew()
        '	ToDB()
        '	RS.Update()
        '	Timer1.Enabled = False
        '	ApplySettings()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If Its = "add" Then
        '		n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '		n.Open("Select Status From Finance order By To_Number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        '		'UPGRADE_WARNING: Couldn't resolve default property of object FinanceIdx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		n.Move(FinanceIdx - 1)
        '		n.Fields("Status").Value = " ’—ÌÕ „—Ê—"
        '		n.Update()
        '	End If
        '	EnDis(False, False, True)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Its = ""
        '	'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	IDbefore = ""
        'End If
    End Sub
	
	
	'UPGRADE_WARNING: Form event frmPassPermissions.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmPassPermissions_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim myfrom As Object
        'LoadAllSettings()
        'ApplySettings()
		cmdRefresh.Width = Me.ClientRectangle.Width
		myfrom = frmMain
	End Sub
	
	Private Sub frmPassPermissions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False

        'TODO: This line of code loads data into the 'DsExplosives.PassCopies' table. You can move, or remove it, as needed.
        Me.PassCopiesTableAdapter.Fill(Me.DsExplosives.PassCopies)
        'TODO: This line of code loads data into the 'DsExplosives.PERMISSIONS' table. You can move, or remove it, as needed.
        Me.PERMISSIONSTableAdapter.Fill(Me.DsExplosives.PERMISSIONS)
        Me.PERMISSIONSTableAdapter.FillByDistinctRank(Me.RankDsExplosives1.PERMISSIONS)
        Me.PERMISSIONSTableAdapter.FillByDistinctName(Me.NameDsExplosives1.PERMISSIONS)
        Me.PERMISSIONSTableAdapter.FillByDistinctPosition(Me.PositionDsExplosives1.PERMISSIONS)
        Me.PERMISSIONSTableAdapter.FillDistinctTransportedBy(Me.TransportByDsExplosives1.PERMISSIONS)
        Me.PERMISSIONSTableAdapter.FillDistinctToStore(Me.ToStoreDsExplosives1.PERMISSIONS)


        Me.PassCopiesTableAdapter.FillDistinctPoint1(Me.Point1DsExplosives1.PassCopies)
        Me.PERMISSIONSTableAdapter.FillDistinctSenderAddress(Me.SenderAddressDsExplosives1.PERMISSIONS)
        If Me.Point1DsExplosives1.PassCopies.Rows.Count > 0 Then
            Dim Point1 As String = Me.Point1DsExplosives1.PassCopies.Rows(0)("Point1")

            Me.PassCopiesTableAdapter.FillDistinctPoint2(Me.Point2DsExplosives1.PassCopies, Point1)
            If Me.Point2DsExplosives1.PassCopies.Count > 0 Then
                'Dim Point2 As String = Me.Point2DsExplosives1.PassCopies.Rows(0)("Point2")
                txtPoint1.SelectedIndex = 0
                'Me.PassCopiesTableAdapter.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, Point2)
                '  txtPoint2_SelectedIndexChanged()
            End If
            txtPoint1_SelectedIndexChanged(Nothing, Nothing)
            txtPoint2_SelectedIndexChanged(Nothing, Nothing)
        End If
        If txtID.Text <> "" Or txtID.Text <> " " Then


            If DsExplosives.PERMISSIONS.Rows.Count > 0 Then


                Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.DsExplosives.PermissionDetails, Convert.ToInt32(txtID.Text))
                For i As Integer = 0 To DsExplosives.PermissionDetails.Rows.Count - 1
                    DataGridView1.Rows.Add(DsExplosives.PermissionDetails(i).Description, DsExplosives.PermissionDetails(i).Unit, DsExplosives.PermissionDetails(i).Quanitity)
                Next
            End If
        End If

        If cmbRank.Items.Count > 0 Then
            cmbRank.SelectedIndex = 0
        End If
        If cmbName.Items.Count > 0 Then
            cmbName.SelectedIndex = 0
        End If
        If cmbPosition.Items.Count > 0 Then
            cmbPosition.SelectedIndex = 0
        End If
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (PERMISSIONSBindingSource.Position + 1).ToString + " / " + PERMISSIONSBindingSource.Count.ToString

    End Sub
	
	Private Sub frmPassPermissions_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        ''UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
		'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
	End Sub
	
	Public Sub mnuPay_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPay.Click
		cmdEdit.CheckState = System.Windows.Forms.CheckState.Checked
	End Sub
	
	'UPGRADE_WARNING: Event optDistract.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optDistract_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optDistract.CheckedChanged
        'If eventSender.Checked Then
        Dim i As Object
        On Error Resume Next
        cmdDistract.Visible = optDistract.Checked
        txtfID.Enabled = optDistract.Checked
        lblfID.Enabled = optDistract.Checked
        txtWorkID.Enabled = optDistract.Checked
        lblWorkID.Enabled = optDistract.Checked
        cmdInsertExplosives.Visible = optImport.Checked
        txtIsImport.Text = "IsDistract"
        '	Dim n As New ADODB.Recordset
        '	Dim c As String
        '	If optDistract.Checked Then
        '		n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '		n.Open("Select Distinct To_Number(To_Char(DistDate,'yyyy')) From OurDistract Order By To_Number(To_Char(DistDate,'yyyy')) Desc", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '		c = cmbYear.Text
        '		cmbYear.Items.Clear()
        '		For i = 1 To n.RecordCount
        '			cmbYear.Items.Add((n.Fields(0).Value))
        '			n.MoveNext()
        '		Next 
        '		cmbYear.Text = c
        '	End If

        'End If
    End Sub
	
	'UPGRADE_WARNING: Event optImport.CheckedChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub optImport_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles optImport.CheckedChanged
        txtIsImport.Text = "IsImport"
        'If eventSender.Checked Then
        '	cmdDistract.Visible = optDistract.Checked
        '	txtfID.Enabled = optDistract.Checked
        '	lblfID.Enabled = optDistract.Checked
        '	txtWorkID.Enabled = optDistract.Checked
        '	lblWorkID.Enabled = optDistract.Checked
        '	cmdInsertExplosives.Visible = optImport.Checked
        '	If optImport.Checked Then cmdInsertExplosives.CheckState = System.Windows.Forms.CheckState.Checked
        'End If
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
                    '	If ccontorl.Enabled = True Then
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
                    '	Else
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
                    '	End If
                    '	'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
                    '	If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
                    '	End If
                End If
			End If
		Next ccontrol
		
	End Sub
	
	'UPGRADE_WARNING: Event txtDate.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or Its = "edit" Then txtFrom.Text = txtDate.Text
    End Sub
	
    Private Sub txtDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'Dim x As Object
        ''UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or Its = "edit" Then
        '    If txtDate.Text = "" Or txtDate.Text = " " Or txtDate.Text = "  " Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰  «—ÌŒ «·„·› ›«—€‹‹‹«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
        '        If x = MsgBoxResult.Ok Then
        '            txtDate.Focus()
        '        ElseIf x = MsgBoxResult.Cancel Then
        '            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        End If
        '    ElseIf IsDate(txtDate.Text) = False Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        x = MsgBox("⁄›Ê« ! ’Ì€… «· «—ÌŒ Œ«ÿ∆…", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
        '        If x = MsgBoxResult.Ok Then
        '            txtDate.Focus()
        '            Exit Sub
        '        ElseIf x = MsgBoxResult.Cancel Then
        '            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        End If
        '    End If
        'End If
    End Sub
	
	'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate1.TextChanged
		Dim idexit As Object
		Dim cmdPrintAll As Object
		Dim cmdPrintDoc As Object
		Dim cmdFound As Object
		Dim cmdPrint As Object
		Dim SQL As Object
		On Error Resume Next
		If Loaded = True Then
			'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbCriteria.Text = "› —…  «—ÌŒÌ… » «—ÌŒ «·„·›" Then MyField = "Where FDate >='" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And FDate<='" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "'"
            '         'RS = New ADODB.Recordset
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = "Select * From Permissions " & MyField
            'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

            'If RS.RecordCount = 0 Or txtDate1.Text = vbNullString Or txtDate2.Text = vbNullString Then
            '	clr()
            '	cmbSender.Text = ""
            '	cmbReceiver.Text = ""
            '	List1.Items.Clear()
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrint.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdPrint.Enabled = False
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdFound.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdFound.Enabled = False
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrintDoc.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdPrintDoc.Enabled = False
            'Else
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrintAll.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdPrintAll.Enabled = True
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdFound.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdFound.Enabled = True
            '	'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrintDoc.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	cmdPrintDoc.Enabled = True
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
            'If RS.RecordCount > 0 Then
            '	lblPosition.Text = "0 / 0"
            '	lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
            'Else
            '	lblPosition.Text = "0 / 0"
            'End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate2.TextChanged
		txtDate1_TextChanged(txtDate1, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtfID.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtfID_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtfID.TextChanged

        If IsNumeric(txtfID.Text) Then
            Dim dtOurDistract As New dsExplosives.OURDISTRACTDataTable
            dtOurDistract = New dsExplosivesTableAdapters.OURDISTRACTTableAdapter().GetDataByID(txtfID.Text)
            If dtOurDistract.Rows.Count > 0 Then


                ' DataGridView1.DataSource = Nothing
                PERMISSIONSBindingSource.AddNew()
                dtpStoreDate.Value = DateTime.Now
                dtpDate.Value = DateTime.Now
                dtpTo.Value = dtpFrom.Value.AddMonths(1).AddDays(-1)



                Dim dtOurDistractDetails As New dsExplosives.OurDistractDetailsDataTable
                cmbSender.Text = dtOurDistract(0).DISTRACTOR
                cmbReceiver.Text = dtOurDistract(0).RECEIVER.Trim
                dtOurDistractDetails = New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter().GetDataByOurDistractID(OurDistactID)
                ' DataGridView1.DataSource = dtOurDistractDetails
                For i As Integer = 0 To dtOurDistractDetails.Rows.Count - 1
                    DataGridView1.Rows.Add(dtOurDistractDetails(i).Description, dtOurDistractDetails(i).Unit, dtOurDistractDetails(i).Quantity)
                Next
            End If
        End If
    End Sub
	
	Private Sub txtfID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtfID.Leave
		Dim x As Object
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "add" Or Its = "edit" Then
            '    'If RS2.RecordCount = 0 Then
            '    FDistracted = False
            '    'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '    x = MsgBox("⁄›Ê« ! ·„ Ì „ «·⁄ÀÊ— ⁄·Ï „” ‰œ ’—› ·Â–« «· ’—ÌÕ . Â·  —Ìœ/Ì‰ «” Œ—«Ã „” ‰œ ø", MsgBoxStyle.YesNoCancel + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Critical)
            '    If x = MsgBoxResult.Yes Then
            '        cmdDistract.CheckState = System.Windows.Forms.CheckState.Checked
            '    ElseIf x = MsgBoxResult.No Then
            '        txtfID.Focus()
            '    ElseIf x = MsgBoxResult.Cancel Then
            '        cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            '    End If
            '    Exit Sub
            'Else
            '    If RS.RecordCount < -1 Then
            '        '  Dim r As New ADODB.Recordset
            '        '  r.CursorLocation = adUseClient
            '        '  r.Open "Select fID From Permissions Where "
            '        RS.MoveFirst()
            '        RS.Find("fID='" & txtfID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
            '        If RS.EOF = False Then
            '            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '            If Its = "add" Then
            '                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '                x = MsgBox("⁄›Ê« ! ·ﬁœ  „ «” Œ—«Ã  ’—ÌÕ ”«»ﬁ »Â–« «·„” ‰œ. Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.YesNoCancel + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Exclamation)
            '                If x = MsgBoxResult.Yes Then
            '                    FromDB()
            '                    EnDis(False, False, True)
            '                    TextLock()
            '                ElseIf x = MsgBoxResult.No Then
            '                    txtfID.Focus()
            '                ElseIf x = MsgBoxResult.Cancel Then
            '                    cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            '                End If
            '                'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '            ElseIf Its = "edit" Then
            '                Exit Sub
            '            End If
            '        Else
            '            '  RS.MoveFirst
            '            ' RS.Find "fID='" & txtfID.Text & "'", 0, adSearchForward, 0
            '            txtWorkID.Focus()
            '            FDistracted = True
            '        End If
            '    End If
            'End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
		

        If cmbCriteria.Text = "⁄«„" Then
            If IsNumeric(txtFind.Text) Then
                PERMISSIONSBindingSource.Filter = " ID=" + txtFind.Text + " Or FID like '" & txtFind.Text & "' Or Sender Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%'"
            Else
                PERMISSIONSBindingSource.Filter = " FID like '" & txtFind.Text & "' Or Sender Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%'"
            End If

        ElseIf cmbCriteria.Text = "‰„—… «·„·›" Then
            If IsNumeric(txtFind.Text) Then

                PERMISSIONSBindingSource.Filter = " ID=" & txtFind.Text & ""

            End If

            ElseIf cmbCriteria.Text = " «—ÌŒ «·„·›" Then
                PERMISSIONSBindingSource.Filter = " FDate = '" & txtFind.Text & "'"

            ElseIf cmbCriteria.Text = "‰„—… „” ‰œ «·’—›" Then
                PERMISSIONSBindingSource.Filter = " FID = '" & txtFind.Text & "'"
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„—”·…" Then
                PERMISSIONSBindingSource.Filter = " Sender Like '%" & txtFind.Text & "%'"

            ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„” ﬁ»·…" Then


                PERMISSIONSBindingSource.Filter = " Receiver Like '%" & txtFind.Text & "%'"
            End If
    End Sub
	
	'UPGRADE_WARNING: Event txtFrom.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFrom_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If IsDate(txtFrom.Text) And Its <> "" Then
        '    'txtTo.Text = VB6.Format(DateAdd(Microsoft.VisualBasic.DateInterval.Day, 30, CDate(txtFrom.Text)), "YYYY/MM/DD")
        'End If
    End Sub
	
    Private Sub txtFrom_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'txtFrom.Text = VB6.Format(txtFrom.Text, "YYYY/MM/DD")
    End Sub
	
    Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtID.Leave, txtPassPermissionNo.Leave
        Dim x As Object
        If FDistracted = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Its = "add" Or (Its = "edit" And IDbefore <> txtID.Text) Then
                If txtID.Text = "" Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ ‰„—… «·„·› ›«—€«", MsgBoxStyle.OkCancel + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Critical)
                    If x = MsgBoxResult.Ok Then
                        txtID.Focus()
                    ElseIf x = MsgBoxResult.Cancel Then
                        cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    End If
                Else
                    'RS.MoveFirst()
                    'RS.Find("ID='" & txtID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                    ''find ID accordin to year
                    'If RS.EOF = False Then
                    '	'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	x = MsgBox("⁄›Ê« ! Â–« «· ’—ÌÕ „ÊÃÊœ . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                    '	If x = MsgBoxResult.No Then
                    '		txtID.Focus()
                    '	ElseIf x = MsgBoxResult.Yes Then 
                    '		FromDB()
                    '		EnDis(False, False, True)
                    '	ElseIf x = MsgBoxResult.Cancel Then 
                    '		cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    '	End If
                    'Else
                    '	txtfID.Focus()
                    'End If
                End If
            End If
        End If
    End Sub
	
	'UPGRADE_WARNING: Event txtPoint1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPoint1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPoint1.SelectedIndexChanged

        If Me.Point1DsExplosives1.PassCopies.Rows.Count > 0 Then


            Me.PassCopiesTableAdapter.FillDistinctPoint2(Me.Point2DsExplosives1.PassCopies, txtPoint1.Text)
            If Me.Point2DsExplosives1.PassCopies.Count > 0 Then


                Me.PassCopiesTableAdapter.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, txtPoint1.Text, txtPoint2.Text)
            End If
        End If
	End Sub
	
	'UPGRADE_WARNING: Event txtPoint2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtPoint2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPoint2.SelectedIndexChanged



        If Me.Point2DsExplosives1.PassCopies.Count > 0 Then

            Me.PassCopiesTableAdapter.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, txtPoint1.Text, txtPoint2.Text)

        End If

	End Sub
	
	
	
	'UPGRADE_WARNING: Event txtWorkID.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtWorkID_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWorkID.TextChanged
        If IsNumeric(txtWorkID) Then


            Dim dtWorkPermission As New dsExplosives.WORKPERMISSIONSDataTable
            dtWorkPermission = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByWorkPermissionNo(Convert.ToInt32(txtWorkID.Text))
            If dtWorkPermission.Rows.Count > 0 Then
                txtReceiverAddress.Text = dtWorkPermission(0).LOCATION
                Try
                    ' txtWorkID.Text = dtWorkPermission(0).WorkPermissionNo
                    txtStoreID.Text = dtWorkPermission(0).WorkPermissionNo
                    txtPurpose.Text = dtWorkPermission(0).PURPOSE
                    dtpStoreDate.Value = dtWorkPermission(0).FDATE
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            End If
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim ss As New ADODB.Recordset
        'If Its = "edit" Or Its = "add" Then
        '	cmbReceiver.ReadOnly = True
        '	cmbSender.ReadOnly = True
        '	MyWPValidation = CStr(False)
        '	If ss.State = ADODB.ObjectStateEnum.adStateOpen Then ss.Close()
        '	ss.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        '	ss.Open("Select To_Number(ID) ID, To_Char(FDate, 'YYYY/MM/DD') FDate, Valid, fSideName, sSideName, Location, PURPOSE " & "From Workpermissions Where ID='" & txtWorkID.Text & "' AND To_Char(FDate, 'yyyy')='" & cmbYear.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	If ss.RecordCount = 0 Then
        '		MyWPValidation = "NoRecord"
        '	ElseIf ss.RecordCount > 0 Then 
        '		If ss.Fields("Valid").Value = "‰⁄„" Then
        '			MyWPValidation = "Valid"
        '			'  cmbReceiver.Text = ss!FSIDENAME
        '			'  cmbSender.Text = ss!sSideName
        '			txtPurpose.Text = ""
        '			txtReceiverAddress.Text = ""
        '			txtToStore.Text = ""
        '			txtStoreID.Text = ""
        '			txtStoreDate.Text = ""

        '			txtPurpose.Text = ss.Fields("PURPOSE").Value
        '			txtReceiverAddress.Text = ss.Fields("Location").Value
        '			txtToStore.Text = "„Œ«“‰ " & ss.Fields("FSIDENAME").Value
        '			txtStoreID.Text = ss.Fields("ID").Value
        '			txtStoreDate.Text = ss.Fields("FDate").Value

        '		ElseIf ss.Fields("Valid").Value = "·«" Then 

        '			MyWPValidation = "NotValid"
        '		End If
        '	End If
        'End If
        'MsgBox MyWPValidation
    End Sub
	
	Private Sub txtWorkID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWorkID.Leave
		Dim x As Object
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If Me.ActiveControl.Name = "cmdCancel" Or Me.ActiveControl.Name = "txtfID" Or Me.ActiveControl Is cmbYear Then Exit Sub
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "edit" Or Its = "add" Then
			If txtWorkID.Text = "" Or txtWorkID.Text = " " Or txtWorkID.Text = "  " Or txtWorkID.Text = "    " Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("⁄›Ê« ⁄·Ìﬂ ≈œŒ«· —ﬁ„ ≈–‰ «” Œœ«„ «·ÃÂ… «· Ì  —Ìœ ≈’œ«—  ’—ÌÕ „—Ê— ·Â«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OKCancel, "")
				If x = MsgBoxResult.OK Then
					txtWorkID.Focus()
				ElseIf x = MsgBoxResult.Cancel Then 
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				End If
			Else
				If MyWPValidation = "Valid" Then
					txtPlace.Focus()
				ElseIf MyWPValidation = "NotValid" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					x = MsgBox("⁄‹›‹Ê« ! ≈–‰ «·≈” Œœ«„ «·–Ì √œŒ·  —ﬁ„Â „‰ ÂÌ «·’·«ÕÌ…", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OKCancel)
					If x = MsgBoxResult.OK Then
						txtWorkID.Focus()
					ElseIf x = MsgBoxResult.Cancel Then 
						cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
					End If
				ElseIf MyWPValidation = "NoRecord" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					x = MsgBox("⁄‹›‹Ê« ! ≈–‰ «·≈” Œœ«„ «·–Ì √œŒ·  —ﬁ„Â €Ì— „ÊÃÊœ.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OKCancel)
					If x = MsgBoxResult.OK Then
						txtWorkID.Focus()
					ElseIf x = MsgBoxResult.Cancel Then 
						cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
					End If
				End If
			End If
		End If
	End Sub

    Private Sub dtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFrom.ValueChanged
        dtpTo.Value = dtpFrom.Value.AddMonths(1)
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub Check1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check1.CheckedChanged

    End Sub

    Private Sub Check1_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check1.CheckStateChanged
        Hide()
    End Sub

    Private Sub Check3_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Check3.CheckStateChanged
        Close()
    End Sub

    Private Sub MovementForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovementForm.Click
        If txtID.Text <> "" Then
            ' Dim fMovementForms As New frmMovementForms(Convert.ToInt32(txtID.Text), "PassPermission")
            Dim fMovementForms As New frmMovementForms()
            fMovementForms.ShowDialog()
        End If
    End Sub

    Private Sub txtWorkID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtWorkID.KeyPress
        If Asc(e.KeyChar) = 13 Then


            If IsNumeric(txtWorkID.Text) Then
                Dim dtWorkPermissions As dsExplosives.WORKPERMISSIONSDataTable
                dtWorkPermissions = New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter().GetDataByWorkPermissionNo(Convert.ToInt32(txtWorkID.Text))
                If dtWorkPermissions.Rows.Count > 0 Then
                    cmbReceiver.Text = dtWorkPermissions(0).FSIDENAME
                    txtStoreID.Text = dtWorkPermissions(0).WorkPermissionNo
                    txtPurpose.Text = dtWorkPermissions(0).PURPOSE
                    dtpStoreDate.Value = dtWorkPermissions(0).FDATE
                End If
            End If
        End If
    End Sub

    Private Sub txtPurpose_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPurpose.KeyPress

    End Sub

    Private Sub cmbSender_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSender.TextChanged

    End Sub

    Private Sub cmdFmtDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFmtDoc.CheckedChanged

    End Sub
End Class