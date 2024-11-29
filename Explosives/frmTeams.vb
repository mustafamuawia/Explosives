Option Strict Off
Option Explicit On
Friend Class frmTeams
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

    Dim IsAdd = False
    Private Sub FromDB()
        Dim i As Object
        On Error Resume Next
        'clr()
        cmbSideName.Text = ""
        cmbWorkRegion.Text = ""
        cmbRank.Text = ""
        'txtID.Text = RS.Fields("ID").Value
        'txtName.Text = RS.Fields("Name").Value
        'cmbRank.Text = RS.Fields("RANK").Value
        'txtCommissionDate.Text = RS.Fields("CommissionDate").Value
        'txtUnit.Text = RS.Fields("Unit").Value
        'txtBirth.Text = RS.Fields("Birth").Value
        'txtRoots.Text = RS.Fields("Roots").Value
        'RsSide = New ADODB.Recordset
        'If RsSide.State = ADODB.ObjectStateEnum.adStateOpen Then RsSide.Close()
        'RsSide.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RsSide.Open("SELECT * From WorkAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        'If RsSide.RecordCount <> cmbSideName.Items.Count Then
        '	cmbSideName.Items.Clear()
        '	For i = 1 To RsSide.RecordCount
        '		cmbSideName.Items.Add(RsSide.Fields("SideName").Value)
        '		RsSide.MoveNext()
        '	Next 
        'End If
        'RsSide.Close()
        'cmbSideName.Text = RS.Fields("SideName").Value
        'cmbSideName_Leave(cmbSideName, New System.EventArgs())
        'cmbWorkRegion.Text = RS.Fields("WorkRegion").Value
        'If RS.RecordCount > 0 Then
        '	lblPosition.Text = "0 / 0"
        '	lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
        'Else
        '	lblPosition.Text = "0 / 0"
        'End If
    End Sub
    Private Sub ToDB()
        On Error Resume Next
        'RSinsert = New ADODB.Recordset
        'If RSinsert.State = ADODB.ObjectStateEnum.adStateOpen Then RSinsert.Close()
        'RSinsert.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSinsert.Open("Select * From Teams Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "edit" Then RSinsert.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Then RSinsert.AddNew()
        'RSinsert.Fields("ID").Value = txtID.Text
        'RSinsert.Fields("Name").Value = txtName.Text
        'RSinsert.Fields("RANK").Value = cmbRank.Text
        'RSinsert.Fields("CommissionDate").Value = txtCommissionDate.Text
        'RSinsert.Fields("Unit").Value = txtUnit.Text
        'RSinsert.Fields("Birth").Value = txtBirth.Text
        'RSinsert.Fields("Roots").Value = txtRoots.Text
        'RSinsert.Fields("WorkRegion").Value = cmbWorkRegion.Text
        'RSinsert.Fields("SideName").Value = cmbSideName.Text
    End Sub

    'UPGRADE_WARNING: Event cmbCriteria.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbCriteria_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
        txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub


    'UPGRADE_WARNING: Event cmbOrder.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbOrder_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbOrder.SelectedIndexChanged
        'If cmbOrder.Text = "√ﬁœ„Ì… «·‰„—… Ê «·— »…" Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Seniority.snrID Desc, To_Number (Teams.ID), Teams.SideName "
        'ElseIf cmbOrder.Text = "«·«”„" Then 
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Teams.Name, Seniority.snrID Desc, To_Number (Teams.ID), Teams.SideName "
        'ElseIf cmbOrder.Text = "«·ÊÕœ…" Then 
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Teams.Unit, Seniority.snrID Desc, To_Number (Teams.ID), Teams.SideName "
        'ElseIf cmbOrder.Text = "«”„ «·ÃÂ… «·„‰ œ» ≈·ÌÂ«" Then 
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Teams.SideName, Seniority.snrID Desc, To_Number (Teams.ID) "
        'ElseIf cmbOrder.Text = " «—ÌŒ «·«‰ œ«»" Then 
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Teams.CommissionDate, Seniority.snrID Desc, To_Number (Teams.ID), Teams.SideName "
        'ElseIf cmbOrder.Text = " «—ÌŒ «·„Ì·«œ" Then 
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Order = "Teams.Birth, Seniority.snrID Desc, To_Number (Teams.ID), Teams.SideName "
        'End If
        'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'SQL = "Select * From Teams, Seniority Where Seniority.snrRank (+)=Teams.rank Order By " & Order
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrSQL = "Select * From (" & SQL & ") " '& " Order By snrID Desc, To_number(ID)"



    End Sub

    Private Sub cmbSideName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSideName.Leave
        Dim i As Object
        On Error Resume Next
        'RsSide = New ADODB.Recordset
        'If RsSide.State = ADODB.ObjectStateEnum.adStateOpen Then RsSide.Close()
        'RsSide.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RsSide.Open("SELECT Sight1, Sight2, OtherSights From WorkAllowed Where SideName='" & cmbSideName.Text & "' Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        'RsSide.MoveFirst()
        ''  If cmbWorkRegion.ListCount <> RsSide.RecordCount * 3 Then
        'cmbWorkRegion.Items.Clear()
        'For i = 1 To RsSide.RecordCount
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(RsSide.Fields("Sight1").Value) Then cmbWorkRegion.Items.Add(RsSide.Fields("Sight1").Value)
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(RsSide.Fields("Sight2").Value) Then cmbWorkRegion.Items.Add(RsSide.Fields("Sight2").Value)
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(RsSide.Fields("OtherSights").Value) Then cmbWorkRegion.Items.Add(RsSide.Fields("OtherSights").Value)
        '	RsSide.MoveNext()
        'Next 
        '   End If
    End Sub



    'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        TeamsBindingSource.CancelEdit()
        TeamsBindingSource.MoveLast()
    End Sub

    'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        If cmdDelete.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·”Ã· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                'MovementFormsBindingSource.RemoveCurrent()
                'MovementFormsBindingSource.EndEdit()
                'MovementFormsTableAdapter.Update(dsExplosives.MovementForms)
                MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
            End If
            cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        If cmdEdit.CheckState = 1 Then
            'TextUnLock()
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore = txtID.Text
            'EnDis(False, True, False)
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Its = "edit"
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
        TeamsBindingSource.MoveFirst()
    End Sub

    'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
        Dim dtrTeams As Object
        Dim Recent As Object
        On Error GoTo er
        If cmdFound.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'Recent = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object Recent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(Recent - 1)
            cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
            Exit Sub
er:
            MsgBox(Err.Description)
            Err.Clear()
            cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        TeamsBindingSource.MoveLast()
    End Sub

    'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'If cmdLogout.CheckState = 1 Then LogOut()
    End Sub

    'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then
            AmmoBindingSource.AddNew()
            dtpCompanyLetterDate.Value = DateTime.Now
            dtpPermissionDate.Value = DateTime.Now
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
        EnableSave()
    End Sub

    'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        TeamsBindingSource.MoveNext()
    End Sub

    'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        TeamsBindingSource.MovePrevious()
    End Sub

    'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
        Dim dtrTeams As Object
        On Error GoTo er
        If cmdPrintAll.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.DataSource = RS
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            dtrTeams.Refresh()
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            dtrTeams.Show()
            cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
            Exit Sub
er:
            MsgBox(Err.Description)
            cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
        Dim dtrTeams As Object
        On Error GoTo er
        'Dim RSs As New ADODB.Recordset
        If cmdPrintDoc.CheckState = 1 Then
            'RSs = New ADODB.Recordset
            'If RSs.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RSs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RSs.Open(dtrSQL & " Where ID='" & txtID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.DataSource = RSs
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrTeams.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrTeams.Show()
            'cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
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
            'Its = ""
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
        If IsAdd Then
            Dim today = New DateTime

            Dim dtTeamNo As New dsExplosives.TeamsDataTable
            dtTeamNo = New dsExplosivesTableAdapters.TeamsTableAdapter().GetDataMaxTeamNoYear(today.Year)
            If dtTeamNo.Rows.Count = 0 Then
                txtCardNo.Text = 1
            Else
                If IsDBNull(dtTeamNo.Rows(0)("TeamNo")) Then
                    txtCardNo.Text = 1
                Else
                    txtCardNo.Text = dtTeamNo(0).TeamNo + 1
                End If
            End If

        End If
        TeamsBindingSource.EndEdit()
        TeamsTableAdapter.Update(DsExplosives.Teams)

    End Sub

    Private Sub Combo1_Change()

    End Sub




    'UPGRADE_WARNING: Form event frmTeams.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmTeams_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
        cmdRefresh.Width = Me.ClientRectangle.Width
    End Sub

    Private Sub frmTeams_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.Teams' table. You can move, or remove it, as needed.
        Me.TeamsTableAdapter.Fill(Me.DsExplosives.Teams)
        On Error Resume Next
        cmbOrder.SelectedIndex = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Order. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'SQL = "Select * From Teams, Seniority Where Seniority.snrRank (+)=Teams.rank Order By " & Order
        'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrSQL = "Select * From (" & SQL & ") " '& " Order By snrID Desc, To_number(ID)"
        'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Loaded = False
        'cmbCriteria.SelectedIndex = 0
        ''UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Loaded = True
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Its = ""
        'If RS.RecordCount = 0 Then
        '	cmdEdit.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdEdit.Enabled = False
        '	cmdDelete.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdDelete.Enabled = False
        '	cmdNext.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdNext.Enabled = False
        '	cmdPrev.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdPrev.Enabled = False
        '	cmdLast.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdLast.Enabled = False
        '	cmdFirst.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdFirst.Enabled = False
        'End If
        cmdRefresh.Width = Me.Width
    End Sub

    Private Sub frmTeams_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
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

    'UPGRADE_WARNING: Event txtBirth.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtBirth_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If IsDate(txtBirth.Text) Then
        '    'UPGRADE_WARNING: DateDiff behavior may be different. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
        '    lblAge.Text = DateDiff(Microsoft.VisualBasic.DateInterval.DayOfYear, CDate(txtBirth.Text), Today) \ 365 & " ”‰… Ê" & DateDiff(Microsoft.VisualBasic.DateInterval.Month, CDate(txtBirth.Text), Today) Mod 12 & " ‘Â—"
        'End If
    End Sub

    Private Sub txtf_Change()
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        FromDB()
    End Sub

    'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
        Dim finsql As Object
        Dim MyField As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Loaded = True Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Searched = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "⁄«„" Then MyField = " Where ID Like '" & txtFind.Text & "' or Name Like '%" & txtFind.Text & "%' or Rank Like '%" & txtFind.Text & "%'" & " or Unit Like '%" & txtFind.Text & "%' " & " or SideName Like '%" & txtFind.Text & "%' or WorkRegion Like '%" & txtFind.Text & "%' "
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "" Or IsDate(txtFind.Text) Then MyField = "Where Birth='" & txtFind.Text & "' Or CommissionDate ='" & txtFind.Text & "'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "‰„—… «·»ÿ«ﬁ…" Then MyField = "Where ID='" & txtFind.Text & "'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "«·«”„" Then MyField = " Where Name Like '%" & txtFind.Text & "%'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "«·— »…" Then MyField = " Where Rank Like '%" & txtFind.Text & "%'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "«·ÊÕœ…" Then MyField = " Where Unit Like '%" & txtFind.Text & "%'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = " «—ÌŒ «·„Ì·«œ" Then MyField = " Where Birth = '" & txtFind.Text & "'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = " «—ÌŒ ¬Œ— «» ⁄«À" Then MyField = " Where CommissionDate = '" & txtFind.Text & "'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "«”„ «·ÃÂ… «·„»⁄ÊÀ ≈·ÌÂ«" Then MyField = " Where SideName Like '%" & txtFind.Text & "%'"
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	If cmbCriteria.Text = "„Êﬁ⁄ «·⁄„·" Then MyField = " Where WorkRegion Like '%" & txtFind.Text & "%'"
        '	RS = New ADODB.Recordset
        '	If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        '	RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object finsql. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	finsql = dtrSQL & " " & MyField & " Order By SideName"
        '	RS.Open(finsql, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        '	FromDB()
        'End If
    End Sub

    Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtCardNo.Leave, txtTeamNo.Leave
        Dim x As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Then
            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            Exit Sub
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or (Its = "edit" Or IDbefore <> txtID.Text) Then
        '    'UPGRADE_WARNING: Couldn't resolve default property of object ActvCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    ActvCtrl = "txtID"
        '    If txtID.Text = vbNullString Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ —ﬁ„ «·»ÿ«ﬁ… Œ«·Ì« !", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
        '        If x = MsgBoxResult.Cancel Then
        '            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        Else
        '            txtID.Focus()
        '        End If
        '    Else
        '        'If RS.RecordCount > 0 Then
        '        '	RS.MoveFirst()
        '        '	RS.Find("ID='" & txtID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        '        '	If RS.EOF = False Then
        '        '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '		x = MsgBox("⁄›Ê« ! Â–« «·›—œ „ÊÃÊœ . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
        '        '		If x = MsgBoxResult.Cancel Then
        '        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        '		ElseIf x = MsgBoxResult.Yes Then 
        '        '			FromDB()
        '        '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '			Its = ""
        '        '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '			IDbefore = ""
        '        '			EnDis(False, False, True)
        '        '		Else
        '        '			txtID.Focus()
        '        '		End If
        '        '	Else
        '        '		RS.MoveFirst()
        '        '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '		RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchBackward)
        '        '	End If
        '        'End If
        '    End If
        'End If
    End Sub

    Private Sub cmdSave_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub
End Class