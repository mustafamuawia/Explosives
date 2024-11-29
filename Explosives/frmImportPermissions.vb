Option Strict Off
Option Explicit On

Imports Microsoft.Office.Interop
Friend Class frmImportPermissions
    Inherits System.Windows.Forms.Form
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
    End Sub
    'Private RS As New ADODB.Recordset
	Private strDuration, strSQL, MyField, IDbefore, Its, IDbefore2, SQL, dtrSQL, dtrWhere As Object
	Private Durated, Loaded, FocusID As Boolean
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

	
	
	'UPGRADE_WARNING: Event cmbDuration.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDuration_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDuration.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbSearch.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbSearch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
        txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    Private Sub cmbCriteria_Change()

    End Sub

    Private Sub cmbCriteria_Click()

    End Sub

    'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        If cmdCancel.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight)
            If x = MsgBoxResult.Yes Then
                cmdNew.Enabled = True
                cmdSave.Enabled = False
                IMPORTPERMISSIONSBindingSource.CancelEdit()
                'EnableDisable(False)
                DisableSave()
                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
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
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «· ’—ÌÕ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                IMPORTALLOWEDBindingSource.RemoveCurrent()
                IMPORTALLOWEDBindingSource.EndEdit()
                IMPORTPERMISSIONSTableAdapter.Update(Me.DsExplosives.IMPORTPERMISSIONS)
                DisableSave()
                MsgBox(" „ Õ–› «· ’—ÌÕ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)

            End If

        End If
    End Sub

    'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub

    'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        'If cmdExit.CheckState = 1 Then ProgramExit()
    End Sub

    'UPGRADE_WARNING: Event cmdFindNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFindNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

        
    End Sub

    'UPGRADE_WARNING: Event cmdFindPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFindPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        
    End Sub

    'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        IMPORTPERMISSIONSBindingSource.MoveFirst()
        GetImportPermissionDetails()
    End Sub

    'UPGRADE_WARNING: Event cmdFmtAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtAll.CheckStateChanged

    End Sub

    'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
        'Dim fPrintImportPermission As New frmPrintImportPermission(txtID.Text)
        'fPrintImportPermission.ShowDialog()
        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")
        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "ImportPermission.doc")
        oWord.Visible = True
        Dim Description As String = ""
        For i As Integer = 0 To DataGridView1.Rows.Count - 1


            Description = "⁄œœ (" & DataGridView1.Rows(i).Cells("Quantity").Value & ") "
            If DataGridView1.Rows(i).Cells("Description").Value = "Õ«ÊÌ…" Then
                Description = Description & DataGridView1.Rows(i).Cells("Description").Value & " " & DataGridView1.Rows(i).Cells("Unit").Value + Environment.NewLine
            Else
                Description = Description & DataGridView1.Rows(i).Cells("Unit").Value & " " & DataGridView1.Rows(i).Cells("Description").Value + Environment.NewLine

            End If



        Next
        oWord.Visible = True
        EditBookMark("ADDRESS", txtAddress.Text)
        EditBookMark("CRAFTSMANSHIP", txtCraftsManship.Text)
        EditBookMark("Description", Description)
        EditBookMark("FDATE", dtpFDate.Value)
        EditBookMark("ImportPermissionNo", txtImportPermissionNo.Text)

        EditBookMark("PERMITTED", cmbPermitted.Text)
        EditBookMark("PORT", txtPort.Text)

        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
    End Sub

    'UPGRADE_WARNING: Event cmdFmtFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtFound.CheckStateChanged
        Dim dtrImpPermissionsFrmt As Object
        On Error GoTo er
        'Dim dtrRS As New ADODB.Recordset
        If cmdFmtFound.CheckState = 1 Then
            'If dtrRS.State = ADODB.ObjectStateEnum.adStateOpen Then dtrRS.Close()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRS.Open(dtrSQL & dtrWhere & " Order By  FDate,  ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionsFrmt.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrImpPermissionsFrmt.DataSource = dtrRS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionsFrmt.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrImpPermissionsFrmt.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionsFrmt.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrImpPermissionsFrmt.Show()
            cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "")
        cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    End Sub
    Private Sub GetImportPermissionDetails()
        DataGridView1.Rows.Clear()

        If txtID.Text <> "" Then

            Dim dtImportPermissionDetails As New dsExplosives.ImportPermissionDetailsDataTable
            dtImportPermissionDetails = New dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter().GetDataByImportPermissionID(txtID.Text)


            For i As Integer = 0 To dtImportPermissionDetails.Rows.Count - 1
                If txtID.Text <> "" Then
                    Dim drImportPermissionDetails As dsExplosives.ImportPermissionDetailsRow
                    drImportPermissionDetails = dtImportPermissionDetails.Rows(i)
                    DataGridView1.Rows.Add(drImportPermissionDetails.Description, drImportPermissionDetails.Unit, drImportPermissionDetails.Quantity)

                End If
            Next

        End If

    End Sub
    'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        IMPORTPERMISSIONSBindingSource.MoveLast()
        GetImportPermissionDetails()
    End Sub

    'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'LogOut()
    End Sub
    Dim IsAdd As Boolean = False

    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then


            IMPORTPERMISSIONSBindingSource.AddNew()
            DataGridView1.Rows.Clear()


            IsAdd = True
            'EnableDisable(True)

            dtpFDate.Value = DateTime.Now
            dtpSDate.Value = DateTime.Now
            If cmbRank.Items.Count > 0 Then
                cmbRank.SelectedIndex = 0
            End If
            If cmbName.Items.Count > 0 Then
                cmbName.SelectedIndex = 0
            End If
            If cmbPosition.Items.Count > 0 Then
                cmbPosition.SelectedIndex = 0
            End If
            EnableSave()
        End If
    End Sub
    Private Sub EnableDisable(ByVal Enable As Boolean)
        If Enable Then
            cmdNew.Enabled = False
            cmdSave.Enabled = True
            Frame5.Enabled = True
            Frame3.Enabled = True
            Frame2.Enabled = True
            Frame4.Enabled = True
            Frame1.Enabled = True

        Else
            cmdNew.Enabled = True
            cmdSave.Enabled = False
            Frame5.Enabled = False
            Frame3.Enabled = False
            Frame2.Enabled = False
            Frame4.Enabled = False
            Frame1.Enabled = False
        End If
    End Sub
    'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        IMPORTPERMISSIONSBindingSource.MoveNext()
        GetImportPermissionDetails()
    End Sub

    'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        IMPORTPERMISSIONSBindingSource.MovePrevious()
        GetImportPermissionDetails()
    End Sub

    'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged

    End Sub

    'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        'If cmdReturn.CheckState = 1 Then Rtn()
        Loaded = False
        Me.Close()
    End Sub

    'UPGRADE_WARNING: Event cmdRptAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRptAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptAll.CheckStateChanged
        Dim dtrImpPermissionTab As Object
        'Dim dtrRS As New ADODB.Recordset
        'If cmdRptAll.CheckState = 1 Then
        '	If dtrRS.State = ADODB.ObjectStateEnum.adStateOpen Then dtrRS.Close()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrRS.Open(dtrSQL & "Order By FDate,  ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.DataSource = dtrRS
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.Refresh()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.Show()
        '	cmdRptAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    'UPGRADE_WARNING: Event cmdRptDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRptDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptDoc.CheckStateChanged

    End Sub

    'UPGRADE_WARNING: Event cmdRptFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRptFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptFound.CheckStateChanged
        Dim dtrImpPermissionTab As Object
        On Error GoTo er
        'Dim dtrRS As New ADODB.Recordset
        'If cmdRptFound.CheckState = 1 Then
        '	If dtrRS.State = ADODB.ObjectStateEnum.adStateOpen Then dtrRS.Close()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrRS.Open(dtrSQL & dtrWhere & " Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.DataSource = dtrRS
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.Refresh()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrImpPermissionTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrImpPermissionTab.Show()
        '	cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
        Exit Sub
er:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "")
        cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    End Sub

    'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("·« »œ „‰ «÷«›… „Ê«œ")
            Return
        End If
        If IsAdd And txtImportPermissionNo.Text = "" Then
            Dim dtImportPermissionNo As New dsExplosives.IMPORTPERMISSIONSDataTable
            dtImportPermissionNo = New dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter().GetDataByMaxImportPermissionNo_Year(dtpFDate.Value.Year)
            If dtImportPermissionNo.Rows.Count = 0 Then
                txtImportPermissionNo.Text = 1
            Else
                If IsDBNull(dtImportPermissionNo(0)("ImportPermissionNo")) Then
                    txtImportPermissionNo.Text = 1
                Else
                    txtImportPermissionNo.Text = dtImportPermissionNo(0).ImportPermissionNo + 1
                End If
            End If



        End If
        IMPORTPERMISSIONSBindingSource.EndEdit()
        IMPORTPERMISSIONSTableAdapter.Update(DsExplosives.IMPORTPERMISSIONS)
        Dim daImportPermissionDetails As New dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter
        If txtID.Text <> "" Then
            daImportPermissionDetails.DeleteByImportPermissionID(Convert.ToInt32(txtID.Text))
        End If
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If txtID.Text <> "" Then


                daImportPermissionDetails.Insert(DataGridView1.Rows(i).Cells("Description").Value.ToString,
                                                    DataGridView1.Rows(i).Cells("Unit").Value.ToString,
                                                  Convert.ToInt32(DataGridView1.Rows(i).Cells("Quantity").Value.ToString),
                                                               Convert.ToInt32(txtID.Text))
            End If
        Next
        MsgBox(" „ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
        IsAdd = False
        'EnableDisable(False)
        DisableSave()
    End Sub

    'UPGRADE_WARNING: Form event frmImportPermissions.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmImportPermissions_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'cmdRefresh.Width = Me.ClientRectangle.Width
        'LoadAllSettings()
        'ApplySettings()
        'MyForm = frmMain
    End Sub

    Private Sub frmImportPermissions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.IMPORTALLOWED' table. You can move, or remove it, as needed.
        Me.IMPORTALLOWEDTableAdapter.FillDistinctSideName(Me.DsExplosives.IMPORTALLOWED)
        'TODO: This line of code loads data into the 'DescriptionDsExplosives1.ImportPermissionDetails' table. You can move, or remove it, as needed.
        Me.ImportPermissionDetailsTableAdapter.Fill(Me.DescriptionDsExplosives1.ImportPermissionDetails)

        'TODO: This line of code loads data into the 'DsExplosives.IMPORTPERMISSIONS' table. You can move, or remove it, as needed.
        Me.IMPORTPERMISSIONSTableAdapter.Fill(Me.DsExplosives.IMPORTPERMISSIONS)
        Me.IMPORTPERMISSIONSTableAdapter.FillDISTINCTPosition(Me.PositionDsExplosives1.IMPORTPERMISSIONS)
        Me.IMPORTPERMISSIONSTableAdapter.FillDISTINCTRANK(Me.RankDsExplosives1.IMPORTPERMISSIONS)
        Me.IMPORTPERMISSIONSTableAdapter.FillName(Me.NameDsExplosives1.IMPORTPERMISSIONS)
        Dim daImportPermissionDetails As New dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter
        daImportPermissionDetails.FillDistinctDescription(Me.DescriptionDsExplosives1.ImportPermissionDetails)
        daImportPermissionDetails.FillDistinctUnit(Me.UnitDsExplosives1.ImportPermissionDetails)
        GetImportPermissionDetails()
        cmbCriteria.SelectedIndex = 0

        lblPosition.Text = " " + (IMPORTPERMISSIONSBindingSource.Position + 1).ToString + " / " + IMPORTPERMISSIONSBindingSource.Count.ToString

    End Sub

    Private Sub optAll_Click()
        Dim optAll As Object
        Dim Duration As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object optAll.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If optAll.Value = True Then Duration = ""
    End Sub

    'UPGRADE_ISSUE: Frame event Frame9.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    Private Sub Frame9_DblClick()
        MsgBox(strSQL)
    End Sub

    Public Sub mnuActiveControl_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuActiveControl.Click
        'ClrActiveControl()
    End Sub

    Public Sub mnuAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAll.Click
        'ClrAll()
    End Sub

    Public Sub mnuButtons_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuButtons.Click
        'ClrButtons()
    End Sub

    Public Sub mnuDefAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDefAll.Click
        'DefaultAll()
        'SaveAllSettings()
    End Sub

    Public Sub mnuDefBacks_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDefBacks.Click
        'DefaultBacks()
        'SaveClrSettings()
    End Sub

    Public Sub mnuDefFont_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuDefFont.Click
        'DefaultFonts()
    End Sub

    Public Sub mnuEmpty_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuEmpty.Click
        'ClrEmptyControl()
    End Sub

    Public Sub mnufAll_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnufAll.Click
        'FntAll()
    End Sub

    Public Sub mnufButtons_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnufButtons.Click
        'FntButtons()
    End Sub

    Public Sub mnuFFrames_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFFrames.Click
        'FntFrames()
    End Sub

    Public Sub mnuFLabels_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFLabels.Click
        'FntLabels()
    End Sub

    Public Sub mnuFrames_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFrames.Click
        'ClrFrames()
    End Sub

    Public Sub mnufTexts_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnufTexts.Click
        'FntTexts()
    End Sub

    Public Sub mnuBack_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBack.Click
        'ClrBack()
    End Sub

    Public Sub mnuLabels_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLabels.Click
        'ClrLabels()
    End Sub



    Public Sub mnuPay_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPay.Click

    End Sub

    Public Sub mnuTexts_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuTexts.Click
        'ClrTexts()
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        'Dim ccontorl As Object
        'Dim ccontrol As System.Windows.Forms.Control
        'On Error Resume Next
        'For	Each ccontrol In Me.Controls
        '	'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '	If Me.ActiveControl.Name = ccontrol.Name Then
        '		'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
        '			'UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                  'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
        '		End If
        '	Else
        '		'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
        '			'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			If ccontorl.Enabled = True Then
        '				'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                      'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        '			Else
        '				'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                      'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '			End If
        '			'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        '			If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
        '				'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                      'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
        '			End If
        '		End If
        '	End If
        'Next ccontrol
    End Sub

    'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate1.TextChanged
        txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate2.TextChanged
        txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
        'On Error Resume Next
        If Loaded = True Then
            If IsDate(txtFind.Text) = False Then
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If cmbCriteria.Text = "⁄«„" Then MyField = " ID='" & txtFind.Text & "'  OR SID='" & txtFind.Text & "' " & " OR Permitted Like '%" & txtFind.Text & "%' OR Address Like '%" & txtFind.Text & "%' OR Port Like '%" & txtFind.Text & "%' "
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'If cmbSearch.Text = "⁄«„" Then MyField = " ID='" & txtFind.Text & "'  OR SID='" & txtFind.Text & "' OR fDate= '" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "'" & " OR SDate= '" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' OR Permitted Like '%" & txtFind.Text & "%' OR Address Like '%" & txtFind.Text & "%' OR Port Like '%" & txtFind.Text & "%' "
            End If
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "‰„—… «· ’—ÌÕ" Then MyField = " ID='" & txtFind.Text & "'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbSearch.Text = " «—ÌŒ «· ’—ÌÕ" Then MyField = " FDate ='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "‰„—… Œÿ«» «·ÃÂ…" Then MyField = " SID='" & txtFind.Text & "'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbSearch.Text = " «—ÌŒ Œÿ«» «·ÃÂ…" Then MyField = " SDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "«·ÃÂ… «·„„‰ÊÕ…" Then MyField = " Permitted Like '%" & txtFind.Text & "%'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "⁄‰Ê«‰ «·ÃÂ… «·„„‰ÊÕ…" Then MyField = " Address Like '%" & txtFind.Text & "%'"
            'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If cmbCriteria.Text = "„Ì‰«¡ «·œŒÊ·" Then MyField = " Port Like '%" & txtFind.Text & "%'"

            'UPGRADE_WARNING: Couldn't resolve default property of object strDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbDuration.Text = "⁄«„" Then strDuration = " And (fDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' Or Sdate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
            'UPGRADE_WARNING: Couldn't resolve default property of object strDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbDuration.Text = "› —… » «—ÌŒ «·„·›" Then strDuration = " And (fDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "')"
            'UPGRADE_WARNING: Couldn't resolve default property of object strDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If cmbDuration.Text = "› —… » «—ÌŒ «·Œÿ«»" Then strDuration = " And (sDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "')"

            'If Durated <> True Then cmbDuration_Click
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then
                'UPGRADE_WARNING: Couldn't resolve default property of object strDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                dtrWhere = " Where (" & MyField & ") " & strDuration
                'UPGRADE_WARNING: Couldn't resolve default property of object strDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object strSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = "Select * From ImportPermissions Where (" & MyField & ") " & strDuration
            Else
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                dtrWhere = " Where(" & MyField & ") "
                'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'UPGRADE_WARNING: Couldn't resolve default property of object strSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                strSQL = "Select * From ImportPermissions Where(" & MyField & ") "
            End If
            'RS.Open(strSQL, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
            'If RS.RecordCount = 0 Then
            '	lblPosition.Text = 0 & " / " & 0
            'Else
            '	lblPosition.Text = RS.RecordCount & " / " & RS.AbsolutePosition
            'End If

        End If
    End Sub

    Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtID.Leave, txtImportPermissionNo.Leave
        Dim x As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
        'Dim r As New ADODB.Recordset
        If FocusID = True Then
            'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If Its = "add" Or (Its = "edit" And IDbefore <> txtID.Text) Then
                If txtID.Text = "" Or txtID.Text = " " Then
                    'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ —ﬁ„ «·„·› ›«—€‹‹‹‹‹‹‹«.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
                    If x = MsgBoxResult.Ok Then
                        txtID.Focus()
                    ElseIf x = MsgBoxResult.Cancel Then
                        cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    End If
                Else
                    'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
                    'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                    'r.Open("Select * From ImportPermissions Where ID='" & txtID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                    'If r.RecordCount > 0 Then
                    '	'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	x = MsgBox("⁄›Ê« ! Â–« «· ’—ÌÕ „ÊÃÊœ. Â·  Êœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                    '	If x = MsgBoxResult.No Then
                    '		txtID.Focus()
                    '	ElseIf x = MsgBoxResult.Cancel Then 
                    '		cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    '	ElseIf x = MsgBoxResult.Yes Then 
                    '		Con()
                    '		RS.Find("ID='" & txtID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                    '		FromDB()
                    '		TextLock()
                    '		EnDis(False, False, True)
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		Its = ""
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		IDbefore = ""
                    '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '		IDbefore2 = ""
                    '	End If
                    'End If
                End If
            End If
        End If
    End Sub

    Private Sub txtNoObjectionID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtNoObjectionID.Leave
        Dim x As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim r As New ADODB.Recordset
        If Its = "add" Or (Its = "edit" And IDbefore2 <> txtNoObjectionID.Text) Then
            If txtNoObjectionID.Text = "" Or txtNoObjectionID.Text = " " Then
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ —ﬁ„ „·› ⁄œ„ «·„„«‰⁄… ›«—€‹‹‹‹‹‹‹«.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
                If x = MsgBoxResult.Ok Then
                    txtNoObjectionID.Focus()
                ElseIf x = MsgBoxResult.Cancel Then
                    cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                End If
            Else
                'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
                'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                ''  MsgBox Its & vbNewLine & strsql
                'r.Open("Select * From NoObjections Where ID='" & txtNoObjectionID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                If Its = "add" Then
                    '					If r.RecordCount < 1 Then
                    'noObjectMe: 
                    '						'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '						x = MsgBox("⁄›Ê« ! ·„ Ì „ «” Œ—«Ã  ’—ÌÕ ⁄œ„ „„«‰⁄… »Â–« «·—ﬁ„. Â·  Êœ/Ì‰ ≈÷«›…  ’—ÌÕ »⁄œ„ «·„„«‰⁄… ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                    '						If x = MsgBoxResult.No Then
                    '							txtNoObjectionID.Focus()
                    '						ElseIf x = MsgBoxResult.Cancel Then 
                    '							cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    '						ElseIf x = MsgBoxResult.Yes Then 
                    '							frmNoObjections.Show()
                    '							frmNoObjections.cmdNew.CheckState = System.Windows.Forms.CheckState.Checked
                    '							Me.Hide()
                    '                            'ToImportPermision = True
                    '						End If
                    '					Else
                    '						GoTo NoObjectMe2
                    '					End If
                    '					'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				ElseIf Its = "edit" Then 
                    '					If r.RecordCount < 1 Then GoTo noObjectMe
                    'NoObjectMe2: 
                    '					If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
                    '					r.Open("Select * From ImportPermissions Where NoObjectionID='" & txtNoObjectionID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
                    '					If r.RecordCount > 0 Then
                    '						FocusID = False
                    '						'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '						x = MsgBox("⁄›Ê« ! Â–« «·—ﬁ„ „— »ÿ » ’—ÌÕ ¬Œ—. Â·  Êœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                    '						If x = MsgBoxResult.No Then
                    '							'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '							If Its = "add" Then txtNoObjectionID.Focus()
                    '							'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '							If Its = "edit" Then txtNoObjectionID.Focus()
                    '						ElseIf x = MsgBoxResult.Cancel Then 
                    '							cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                    '						ElseIf x = MsgBoxResult.Yes Then 
                    '							Con()
                    '							RS.Find("ID='" & txtNoObjectionID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                    '							FromDB()
                    '							'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '							Its = ""
                    '							'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '							IDbefore = ""
                    '							'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '							IDbefore2 = ""
                    '							EnDis(False, False, True)
                    '						End If
                    '					Else
                    '						FocusID = True
                    '					End If
                End If
            End If
        End If
    End Sub

    Private Sub IMPORTPERMISSIONSBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.IMPORTPERMISSIONSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DsExplosives)

    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged

    End Sub

    Private Sub cmdFmtDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFmtDoc.CheckedChanged

    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub txtNoObjectionID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoObjectionID.TextChanged

    End Sub

    Private Sub txtNoObjectionID_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoObjectionID.KeyPress
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii = 13 Then
            Dim dtImportPermission As New dsExplosives.IMPORTPERMISSIONSDataTable
            'dtImportPermission=IMPORTPERMISSIONSTableAdapter.GetDataByID(Convert.ToInt32(txt)
        End If
    End Sub

    Private Sub btnMovementForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovementForm.Click
        Dim fMovementForms As New frmMovementForms()
        fMovementForms.Show()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        'EnableDisable(True)
        EnableSave()
    End Sub

    Private Sub cmdPlus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckedChanged
        nudQuantity.BackColor = Color.White
        cmbUnit.BackColor = Color.White
        cmbClass.BackColor = Color.White
        If nudQuantity.Value = 0 Then
            nudQuantity.BackColor = Color.Red

        ElseIf cmbUnit.Text = "" Then
            cmbUnit.BackColor = Color.Red

        ElseIf cmbClass.Text = "" Then
            cmbClass.BackColor = Color.Red
        Else
            DataGridView1.Rows.Add(cmbClass.Text, cmbUnit.Text, nudQuantity.Value)
            'cmbClass_SelectedIndexChanged(Nothing, Nothing)
            nudQuantity.Value = 0
            cmbUnit.Text = ""
            cmbClass.Text = ""

        End If
    End Sub

    Private Sub cmdRemove_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.CheckStateChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub cmbClass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nudQuantity.KeyPress, cmbUnit.KeyPress, cmbClass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            cmdPlus_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub
End Class