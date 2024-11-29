Imports Microsoft.Office.Interop

Public Class frmMovementForms
    Inherits System.Windows.Forms.Form
    Public PassPermissionID As Integer = -1
    Private NoObjectionID As Integer = -1
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
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

    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
    End Sub
    Public Sub New(ByVal _ID As Integer, ByVal Type As String)

        ' This call is required by the designer.
        InitializeComponent()
        If Type = "PassPermission" Then
            PassPermissionID = _ID
        Else
            NoObjectionID = _ID

        End If



        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        If cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("هل أنت متأكد/ة من أنك تريد/ين إلغاء الإضافة/التعديل ؟", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then

                MovementFormsBindingSource.CancelEdit()
                DisableSave()
            End If
        End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        On Error Resume Next
        If cmdDelete.CheckState = System.Windows.Forms.CheckState.Checked Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("هل أنت متأكد/ة من أنك تريد/ين حذف هذا الملف ؟", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then

                MovementFormsBindingSource.RemoveCurrent()
                MovementFormsBindingSource.EndEdit()
                MovementFormsTableAdapter.Update(DsExplosives.MovementForms)
                MsgBox("تم حذف الملف !")
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
        Close()
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
        MovementFormsBindingSource.MoveFirst()
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
    Private Sub GetMovementFormDetails()
        DataGridView1.Rows.Clear()
        Dim dtMovementDetails As New dsExplosives.MovementFormDetialsDataTable
        dtMovementDetails = New dsExplosivesTableAdapters.MovementFormDetialsTableAdapter().GetDataByMovementFormID(Convert.ToInt32(txtMovementFormID.Text))
        For i As Integer = 0 To dtMovementDetails.Rows.Count - 1
            Dim Description As Object
            Dim Unit As Object
            Dim Quantity As Object
            Dim MovementPath As Object
            If IsDBNull(dtMovementDetails.Rows(i)("Class")) Then
                Description = Nothing
            Else

                Description = dtMovementDetails(i)._Class

            End If
            If IsDBNull(dtMovementDetails.Rows(i)("Unit")) Then
                Unit = Nothing
            Else

                Unit = dtMovementDetails(i).Unit

            End If
            If IsDBNull(dtMovementDetails.Rows(i)("Quantity")) Then
                Quantity = Nothing
            Else

                Quantity = dtMovementDetails(i).Quantity

            End If
            If IsDBNull(dtMovementDetails.Rows(i)("MovementPath")) Then
                MovementPath = Nothing
            Else

                MovementPath = dtMovementDetails(i).MovementPath

            End If


            DataGridView1.Rows.Add(Description,
                                   Unit,
                                   Quantity, MovementPath)
        Next
    End Sub
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        MovementFormsBindingSource.MoveLast()
        GetMovementFormDetails()
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
    Dim IsAdd As Boolean = False
    '	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged

        Dim fSearchPassPermission As New frmSearchPassPermission

        If fSearchPassPermission.ShowDialog = DialogResult.OK Then


            DataGridView1.AutoGenerateColumns = False
            Dim dtMovementForms As New dsExplosives.MovementFormsDataTable

            'If PassPermissionID <> -1 Then

            dtMovementForms = New dsExplosivesTableAdapters.MovementFormsTableAdapter().GetDataByPassPermissionID(PassPermissionID)
            If dtMovementForms.Rows.Count = 0 Then


                MovementFormsBindingSource.AddNew()
                dtpFDate.Value = DateTime.Now
                DataGridView1.Rows.Clear()
                IsAdd = True
                Dim daPassPermission As New dsExplosivesTableAdapters.PERMISSIONSTableAdapter
                ' CType(Application.OpenForms("frmPassPermissions"), frmPassPermissions).DsExplosives.Clear()
                Try


                    daPassPermission.FillByPassPermissionID(DsExplosives.PERMISSIONS, PassPermissionID)
                    Dim drPassPermission As dsExplosives.PERMISSIONSRow = DsExplosives.PERMISSIONS(0)
                    'CType(Application.OpenForms("frmPassPermissions"), frmPassPermissions).DsExplosives.PERMISSIONS.FindByID(PassPermissionID)
                    txtSender.Text = drPassPermission.SENDER
                    txtReceiver.Text = drPassPermission.RECEIVER
                    txtSenderLocation.Text = drPassPermission.SENDERADDRESS
                    txtReceiverLocation.Text = drPassPermission.RECEIVERADDRESS
                    txtPoint1.Text = drPassPermission.POINT1
                    txtPoint2.Text = drPassPermission.POINT2
                    txtPoint3.Text = drPassPermission.POINT3
                    cmbBy.Text = drPassPermission.TRANSPORTEDBY
                    Dim dtPermissionDetails As New dsExplosives.PermissionDetailsDataTable
                    dtPermissionDetails = New dsExplosivesTableAdapters.PermissionDetailsTableAdapter().GetDataByPassPermissionID(PassPermissionID)
                    DataGridView1.Rows.Add("", "", "", txtPoint1.Text)
                    DataGridView1.Rows.Add("", "", "", txtPoint2.Text)
                    DataGridView1.Rows.Add("", "", "", txtPoint3.Text)
                    DataGridView1.Rows.Add("", "", "", cmbBy.Text)
                    For i As Integer = 0 To dtPermissionDetails.Rows.Count - 1
                        If i < 4 Then
                            DataGridView1.Rows(i).Cells("Description").Value = dtPermissionDetails(i).Description
                            DataGridView1.Rows(i).Cells("Unit").Value = dtPermissionDetails(i).Unit
                            DataGridView1.Rows(i).Cells("Quantity").Value = dtPermissionDetails(i).Quanitity
                        Else
                            DataGridView1.Rows.Add(dtPermissionDetails(i).Description,
                            dtPermissionDetails(i).Unit,
                            dtPermissionDetails(i).Quanitity, "")
                        End If

                    Next
                    If cmbRank.Items.Count > 0 Then
                        cmbRank.SelectedIndex = 0
                    End If
                    If cmbName.Items.Count > 0 Then
                        cmbName.SelectedIndex = 0
                    End If
                    If cmbPosition.Items.Count > 0 Then
                        cmbPosition.SelectedIndex = 0
                    End If

                    If cmbRank3.Items.Count > 0 Then
                        cmbRank3.SelectedIndex = 0
                    End If
                    If cmbName3.Items.Count > 0 Then
                        cmbName3.SelectedIndex = 0
                    End If
                    If cmbPosition3.Items.Count > 0 Then
                        cmbPosition3.SelectedIndex = 0
                    End If

                    If cmbRank2.Items.Count > 0 Then
                        cmbRank2.SelectedIndex = 0
                    End If
                    If cmbName2.Items.Count > 0 Then
                        cmbName2.SelectedIndex = 0
                    End If
                    If cmbPosition2.Items.Count > 0 Then
                        cmbPosition2.SelectedIndex = 0
                    End If
                    EnableSave()
                Catch ex As Exception

                End Try
            End If


        Else
            MovementFormsBindingSource.AddNew()
            dtpFDate.Value = DateTime.Now.Date
            DataGridView1.Rows.Clear()
            IsAdd = True
            EnableSave()
        End If


    End Sub

    '	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        MovementFormsBindingSource.MoveNext()
        GetMovementFormDetails()
        'On Error Resume Next

    End Sub

    '	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        MovementFormsBindingSource.MovePrevious()
        GetMovementFormDetails()
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


        Me.Hide()

    End Sub

    '	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged

        If IsAdd And txtMovmentFormsNo.Text = "" Then
            Dim dtMovementFormNo As New dsExplosives.MovementFormsDataTable
            dtMovementFormNo = New dsExplosivesTableAdapters.MovementFormsTableAdapter().GetDataByMaxMovementFormNo_Year(dtpFDate.Value.Year)
            If dtMovementFormNo.Rows.Count = 0 Then
                txtMovmentFormsNo.Text = 1
            Else


                If IsDBNull(dtMovementFormNo.Rows(0)("MovementFormNo")) Then
                    txtMovmentFormsNo.Text = 1
                Else

                    txtMovmentFormsNo.Text = dtMovementFormNo(0).MovementFormNo + 1
                End If


            End If
        End If
        MovementFormsBindingSource.EndEdit()
        MovementFormsTableAdapter.Update(DsExplosives.MovementForms)


        Dim daMovmentDetials As New dsExplosivesTableAdapters.MovementFormDetialsTableAdapter()
        daMovmentDetials.DeleteMovementForm(Convert.ToInt32(txtMovementFormID.Text))
        DataGridView1.Rows(0).Cells("Path").Value = txtPoint1.Text
        DataGridView1.Rows(1).Cells("Path").Value = txtPoint2.Text
        DataGridView1.Rows(2).Cells("Path").Value = txtPoint3.Text
        DataGridView1.Rows(3).Cells("Path").Value = cmbBy.Text


        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            Dim Description As Object
            Dim Unit As Object
            Dim Quantity As Object
            If DataGridView1.Rows(i).Cells("Description").Value = "" Then
                Description = Nothing
            Else

                Description = DataGridView1.Rows(i).Cells("Description").Value

            End If
            If DataGridView1.Rows(i).Cells("Unit").Value = "" Then
                Unit = Nothing
            Else

                Unit = DataGridView1.Rows(i).Cells("Unit").Value

            End If
            If Not IsNumeric(DataGridView1.Rows(i).Cells("Quantity").Value) Then
                Quantity = Nothing
            Else

                Quantity = Convert.ToInt32(DataGridView1.Rows(i).Cells("Quantity").Value)

            End If
            daMovmentDetials.Insert(Description,
                                    Unit,
                                    Quantity,
                                    txtMovementFormID.Text,
                                    DataGridView1.Rows(i).Cells("Path").Value)
        Next
        MsgBox("تم حفظ الملف !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
        DisableSave()
        IsAdd = False
        Me.MovementFormsTableAdapter.Fill(Me.DsExplosives.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctCommander(Me.CommanderDsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctGuard1(Me.Guard1DsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank1(Me.Rank1DsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName1(Me.Name1DsExplosives2.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition1(Me.Position1DsExplosives3.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank2(Me.Rank2DsExplosives4.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName2(Me.Name2DsExplosives5.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition2(Me.Position2DsExplosives6.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank3(Me.Rank3DsExplosives7.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName3(Me.Name3DsExplosives8.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition3(Me.Position3DsExplosives9.MovementForms)
        MovementFormsBindingSource.MoveLast()
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
    '        If cmbCriteria.Text = "عام" Then MyField = "Where Address Like '%" & txtFind.Text & "%' Or ID Like '" & txtFind.Text & "' Or SideName Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "اسم الجهة" Then MyField = "Where SideName Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "العنوان" Then MyField = "Where Address Like '%" & txtFind.Text & "%'"
    '        'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        If cmbCriteria.Text = "نمرة الملف" Then MyField = "Where ID = '" & txtFind.Text & "'"
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
    '				x = MsgBox("عفوا ! لا يمكنك ترك مكان نمرة الملف فارغا", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
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
    '                '	Y = MsgBox("عفوا ! هذا الملف موجود ، هل تريد/ين رؤيته ؟", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
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
    ' Dim daPassPermission
    Private Sub frmImportAllowed_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MovementFormsTableAdapter.Fill(Me.DsExplosives.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctCommander(Me.CommanderDsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctGuard1(Me.Guard1DsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank1(Me.Rank1DsExplosives1.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName1(Me.Name1DsExplosives2.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition1(Me.Position1DsExplosives3.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank2(Me.Rank2DsExplosives4.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName2(Me.Name2DsExplosives5.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition2(Me.Position2DsExplosives6.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctRank3(Me.Rank3DsExplosives7.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctName3(Me.Name3DsExplosives8.MovementForms)
        Me.MovementFormsTableAdapter.FillDistinctPosition3(Me.Position3DsExplosives9.MovementForms)
        'TODO: This line of code loads data into the 'DsExplosives.MovementForms' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsExplosives.IMPORTALLOWED' table. You can move, or remove it, as needed.
        Dim dtCLASSES As New dsExplosives.CLASSESDataTable
        dtCLASSES = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataDistinctUnit()
        For i As Integer = 0 To dtCLASSES.Rows.Count - 1
            cmbUnit.Items.Add(dtCLASSES(i).UNIT)
        Next
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (MovementFormsBindingSource.Position + 1).ToString + " / " + MovementFormsBindingSource.Count.ToString


    End Sub

    Private Sub cmdPrintDoc_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged

    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub cmdPrintDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDoc.CheckedChanged
        If txtMovementFormID.Text <> "" Then
            oWord = CreateObject("Word.Application")
            oDoc = CreateObject("Word.Document")

            oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "MovementLetter.doc")
            oWord.Visible = True

            EditBookMark("ArabicDate", StretchArabicMonth(dtpFDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
            EditBookMark("EnglishDate", StretchEnglishMonth(dtpFDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
            EditBookMark("From", txtSenderLocation.Text)
            EditBookMark("To", txtReceiverLocation.Text)
            EditBookMark("MovementFormNo", txtMovmentFormsNo.Text)
            EditBookMark("Receiver", txtReceiver.Text)
            EditBookMark("Rank", cmbRank2.Text)
            EditBookMark("Name", cmbName2.Text)
            EditBookMark("Position", cmbPosition2.Text)
           

            Dim fPrintMovementForm As New frmPrintMovementForm(Convert.ToInt32(txtMovementFormID.Text))
            fPrintMovementForm.ShowDialog()
        End If
    End Sub

    Private Sub cmbName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbName.SelectedIndexChanged

    End Sub

    Private Sub cmbClass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress

        If Asc(e.KeyChar) = 13 Then
            cmdPlus_CheckStateChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmdPlus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim daOurImportDetails As New dsExplosivesTableAdapters.OurImportDetailsTableAdapter
        If daOurImportDetails.GetDataByDescription(cmbClass.Text).Rows.Count > 0 Then
            Dim daRecentClasses As New dsExplosivesTableAdapters.RecentClassesTableAdapter
            If daRecentClasses.GetData(cmbClass.Text).Rows.Count > 0 Then
                If daRecentClasses.GetData(cmbClass.Text)(0).RECENT > nudQuantity.Value Then
                    Dim Index As Integer = -1
                    For i As Integer = 0 To DataGridView1.Rows.Count - 1
                        If DataGridView1.Rows(i).Cells("Description").ToString = cmbClass.Text Then
                            Index = i
                        End If
                    Next
                    If Index = -1 Then
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
                            nudQuantity.Value = 0
                            cmbUnit.Text = ""
                            cmbClass.Text = ""
                        End If
                    Else
                        MsgBox("العنصر موجود في القائمة")
                    End If
                Else
                    MessageBox.Show("الكمية في المخزن اقل من المطلوب")
                End If

            Else
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
            End If
        Else
            MsgBox("الكمية غير موجودة في الوارد")
        End If
    End Sub

    Private Sub cmbUnit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnit.SelectedIndexChanged
        If cmbUnit.Items.Count > 0 And cmbUnit.Text <> "" Then
            Dim dtClasses As New dsExplosives.CLASSESDataTable()
            dtClasses = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataByUnit(cmbUnit.Text)
            cmbClass.Items.Clear()
            For i As Integer = 0 To dtClasses.Rows.Count - 1
                cmbClass.Items.Add(dtClasses(i)._CLASS)
            Next
        End If
    End Sub

    Private Sub cmdRemove_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.CheckStateChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub
    Public Function StretchArabicMonth(ByVal input As String) As String
        Dim output As String

        output = input.Replace("ربيع الأول", "ربــــيــــــع الأول")
        output = output.Replace("شعبان", "شـــــعـــــــبــــان")
        output = output.Replace("ربيع الثاني", "ربــــيــــع الثـاني")
        output = output.Replace("رجب", "رجـــــــــــــــب")
        output = output.Replace("شوال", "شــــــــــــــوال")
        output = output.Replace("رمضان", "رمـــــــضـــــــان")
        output = output.Replace("صفر", "صــــــفـــــــــر")
        output = output.Replace("محرم", "مـــــــحـــــــرم")
        output = output.Replace("جمادي الأولى", "جــمـــادي الأولى")
        output = output.Replace("جمادي الثانية", "جـمـادي الثــانية")
        output = output.Replace("ذو القعدة", "ذو الـــــقــــعــــدة")
        output = output.Replace("ذو الحجة", "ذو الـــــحــــجـــة")
        Return output
    End Function
    Public Function StretchEnglishMonth(ByVal input As String) As String
        Dim output As String

        output = input.Replace("يناير", "يــــــنــــــايـــــــر")
        output = output.Replace("فبراير", "فــــــبـــــرايـــــر")
        output = output.Replace("مارس", "مــــــــــــــــارس")
        output = output.Replace("أبريل", "أبــــــــريـــــــــل")
        output = output.Replace("مايو", "مـــــــــــايــــــــو")
        output = output.Replace("يونيو", "يــــــــونـــــــيــو")
        output = output.Replace("يوليو", "يـــــــولــــــيــــو")
        output = output.Replace("أغسطس", "أغـــــســطــــس")
        output = output.Replace("سبتمبر", "ســبـــتـــمـــبــر")
        output = output.Replace("أكتوبر", "نــــوفـــــمــــبـر")
        output = output.Replace("نوفمبر", "نــــوفـــــمــــبـر")
        output = output.Replace("ديسمبر", "ديــــســـمــــبــر")
        Return output
    End Function
End Class