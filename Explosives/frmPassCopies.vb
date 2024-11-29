Option Strict Off
Option Explicit On
Friend Class frmPassCopies
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RSlist As New ADODB.Recordset
    Dim IsAdd As Boolean = False
    Private dtrWhere, EmptyText, IDbefore2, IDbefore, Its, IDbefore1, IDbefore3, dtrSelect, dtrCompute As Object
    Private Sub Con()
        'RS = New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS.Open("Select Point1, Point2, Point3, Count(Point1) From PassCopies Group By Point1, Point2, Point3 " & "Order By Point1, Point2, Point3", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    End Sub
    Private Sub FromDB()
        Dim i As Object
        On Error Resume Next
        'clr()
        'lstSirs.Items.Clear()
        'txtPoint1.Text = RS.Fields("POINT1").Value
        'txtPoint2.Text = RS.Fields("POINT2").Value
        'txtPoint3.Text = RS.Fields("POINT3").Value
        'RSlist = New ADODB.Recordset
        'If RSlist.State = ADODB.ObjectStateEnum.adStateOpen Then RSlist.Close()
        'RSlist.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSlist.Open("Select Sirs From PassCopies Where Point1='" & txtPoint1.Text & "' And Point2='" & txtPoint2.Text & "' And Point3='" & txtPoint3.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        ''RSlist.MoveLast
        'For i = 1 To RSlist.RecordCount
        '	lstSirs.Items.Add(RSlist.Fields("Sirs").Value)
        '	RSlist.MoveNext()
        'Next 
        'RSlist.MoveFirst()
        'lblNo.Text = CStr(lstSirs.Items.Count)
    End Sub
    Private Sub ToDB()
        Dim i As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim a As New ADODB.Command
        If Its = "edit" Then
            'a.CommandText = "Delete From PassCopies Where Point1='" & txtPoint1.Text & "' And Point2='" & txtPoint2.Text & "' And Point3='" & txtPoint3.Text & "'"
            'a.let_ActiveConnection(DB)
            'a.Execute()
        End If
        For i = 0 To lstSirs.Items.Count - 1
            'a = New ADODB.Command
            'a.CommandText = "Insert Into PassCopies (Point1, Point2, Point3, Sirs) Values " & "('" & txtPoint1.Text & "','" & txtPoint2.Text & "', '" & txtPoint3.Text & "', '" & VB6.GetItemString(lstSirs, i) & "')"
            'a.let_ActiveConnection(DB)
            'a.Execute()
        Next
        Con()
    End Sub

     Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        On Error Resume Next
        If cmdCancel.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight)
            If x = MsgBoxResult.Yes Then
                'RS.MoveFirst()
                ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'RS.Find("Point1='" & IDbefore1 & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'RS.Find("Point2='" & IDbefore2 & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)

                cmdNew.Enabled = True
                'cmdSave.Enabled = False


                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
                'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Its = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                IDbefore1 = ""
                'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                IDbefore2 = ""
                'EnDis(False, False, True)
            End If
            cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        'Dim a As New ADODB.Command

        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·”Ã· ø", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If x = MsgBoxResult.Yes Then
            Dim daPassCopiesDetails As New dsExplosivesTableAdapters.PassCopiesDetailsTableAdapter
            'If txtID.Text <> "" Then




            '    daPassCopiesDetails.DeleteByPassCopyID(Convert.ToInt32(txtID.Text))
            'End If

            PassCopiesBindingSource.RemoveCurrent()
            PassCopiesTableAdapter.Update(DsExplosives.PassCopies)
        End If


    End Sub

    'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        cmdSave.Enabled = True
        cmdNew.Enabled = True
        
    End Sub

    'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close() 'If cmdExit.CheckState = 1 Then ProgramExit()
    End Sub

    'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        PassCopiesBindingSource.MoveFirst()
        GetPassCopySirs()
    End Sub

    'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
       
    End Sub

    'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        PassCopiesBindingSource.MoveLast()

        GetPassCopySirs()
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
        Dim i As Object
        'Dim a As New ADODB.Recordset
        If cmdNew.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Its = "add"
            Timer1.Enabled = True
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore1 = txtPoint1.Text
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore2 = txtPoint2.Text
            ''UPGRADE_WARNING: Couldn't resolve default property of object IDbefore3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore3 = txtPoint3.Text
            'clr()
            lstSirs.Items.Clear()
            'txtPoint1.Focus()
            'EnDis(True, False, False)

            'a.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            '         'a.Open("Select Distinct Sirs From PassCopies Order By Sirs", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'For i = 1 To a.RecordCount
            '	txtSir.Items.Add(Replace(a.Fields(0).Value, "«·”Ìœ/ ", ""))
            '	a.MoveNext()
            'Next 
            PassCopiesBindingSource.AddNew()
            lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·⁄·„Ì«  «·»—Ì…"))
            lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·«” Œ»«—«  «·»—Ì…"))
            lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·√„‰ «·Êﬁ«∆Ì"))
            lstSirs.Items.Add(("«·”Ìœ/ ﬁ«∆œ «·„‰ÿﬁ… «·⁄”ﬂ—Ì… «·„—ﬂ“Ì…"))
            lstSirs.Items.Add(("«·”Ìœ/ „œÌ— «·≈œ«—… «·⁄«„… ··√œ·… «·Ã‰«∆Ì…"))
            lstSirs.Items.Add(("«·”Ìœ/ ﬁ«∆œ „‰ÿﬁ… »Õ—Ì «·⁄”ﬂ—Ì… √.”"))
            lstSirs.Items.Add(("«·”Ìœ/ —ﬂ‰ √.” ”·«Õ «·√”·Õ… Ê«·–Œ«∆—"))
            cmdNew.Enabled = False
            cmdSave.Enabled = True
            cmdCancel.Enabled = True
            IsAdd = True
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        PassCopiesBindingSource.MoveNext()
        GetPassCopySirs()

    End Sub

    'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
        If cmdPlus.CheckState = 1 Then
            lstSirs.Items.Add("«·”Ìœ/ " & txtSir.Text)
            txtSir.Text = ""
            cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub


    'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        PassCopiesBindingSource.MovePrevious()
        GetPassCopySirs()
    End Sub

    'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim i As Object
        'Dim a As New ADODB.Recordset
        'If cmdRefresh.CheckState = 1 Then

        '    'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    Its = ""
        '    txtSir.Items.Clear()
        '    'a.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '    'a.Open("Select Distinct Sirs From PassCopies Order By Sirs", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '    'For i = 1 To a.RecordCount
        '    '	txtSir.Items.Add(Replace(a.Fields(0).Value, "«·”Ìœ/ ", ""))
        '    '	a.MoveNext()
        '    'Next 

        '    Con()
        '    FromDB()
        '    cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
        'If cmdReturn.CheckState = 1 Then Rtn()
    End Sub

    'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        If lstSirs.Items.Count = 0 Then
            MsgBox("·« »œ „‰ «÷«›… ÃÂ« ")
            Return
        End If

                PassCopiesBindingSource.EndEdit()
                PassCopiesTableAdapter.Update(DsExplosives.PassCopies)

        Dim daPassCopiesDetails As New dsExplosivesTableAdapters.PassCopiesDetailsTableAdapter
        If lblID.Text <> "0" Then
            daPassCopiesDetails.DeleteByPassCopyID(Convert.ToInt32(lblID.Text))
            For i = 0 To lstSirs.Items.Count - 1
                daPassCopiesDetails.Insert(lstSirs.Items(i).ToString, Convert.ToInt32(lblID.Text))

                'a = New ADODB.Command
                'a.CommandText = "Insert Into PassCopies (Point1, Point2, Point3, Sirs) Values " & "('" & txtPoint1.Text & "','" & txtPoint2.Text & "', '" & txtPoint3.Text & "', '" & VB6.GetItemString(lstSirs, i) & "')"
                'a.let_ActiveConnection(DB)
                'a.Execute()
            Next

            MsgBox(" „ «·Õ›Ÿ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)

            cmdNew.Enabled = True
            'cmdSave.Enabled = False
            cmdCancel.Enabled = False
            'IsAdd = False
        End If
    End Sub

    Private Sub DataGrid1_Click()
       
    End Sub

    'UPGRADE_WARNING: Form event frmPassCopies.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmPassCopies_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated


        'cmdRefresh.Width = Me.ClientRectangle.Width
    End Sub

    Private Sub frmPassCopies_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.PassCopies' table. You can move, or remove it, as needed.
        Me.PassCopiesTableAdapter.Fill(Me.DsExplosives.PassCopies)
        
        If DataGridView1.Rows.Count > 0 Then
            'txtPoint1.SelectedIndex = 0
            ''txtPoint1_SelectedIndexChanged(Nothing, Nothing)
            'lblID.Text=DataGridView1.Rows(0).Cells(0)
        End If
        'GetPassCopySirs()
        'TODO: This line of code loads data into the 'DsExplosives.PassCopies' table. You can move, or remove it, as needed.
        ' Me.PassCopiesTableAdapter.Fill(Me.DsExplosives.PassCopies)
        'On Error Resume Next
        'Con()
        'FromDB()
        'LoadAllSettings()
        'ApplySettings()
    End Sub
    Private Sub GetPassCopySirs()
        lstSirs.Items.Clear()


       
            Dim dtPassCopiesDetails As dsExplosives.PassCopiesDetailsDataTable
        dtPassCopiesDetails = New dsExplosivesTableAdapters.PassCopiesDetailsTableAdapter().GetDataByPassCopyID(Convert.ToInt32(lblID.Text))
            For i As Integer = 0 To dtPassCopiesDetails.Rows.Count - 1

                Dim drPassCopyDetails As dsExplosives.PassCopiesDetailsRow = dtPassCopiesDetails.Rows(i)
                lstSirs.Items.Add(drPassCopyDetails.Sirs)
            Next
            'End If

    End Sub

    'UPGRADE_WARNING: Event frmPassCopies.Resize may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub frmPassCopies_Resize(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Resize
        On Error Resume Next
        'If RS.RecordCount = 0 Then
        '	EnDis(True, False, False)
        '	cmdSave.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdCancel.BackColor = System.Drawing.ColorTranslator.FromOle(&H40C0)
        '	cmdSave.Enabled = False
        '	cmdCancel.Enabled = False
        '	cmdNew.Enabled = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdNew.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        'End If
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Its = "" Then
            'TextLock()
            'EnDis(False, False, True)
        End If
    End Sub



    Private Sub frmPassCopies_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
    End Sub

    Private Sub lstSirs_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstSirs.DoubleClick
        cmdMinus.CheckState = System.Windows.Forms.CheckState.Checked
    End Sub

    Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnucolours.Click
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

    Private Sub txtPoint2_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'Dim x As Object
        ''UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'If Me.ActiveControl.Name = "cmdCancel" Or Me.ActiveControl.Name = "txtPoint1" Then Exit Sub
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or (Its = "edit") Then
        '    If txtPoint2.Text = "" Or txtPoint2.Text = " " Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        x = MsgBox("⁄›Ê« ! ⁄·Ìﬂ ≈œŒ«· «·‰ﬁÿ… «·À«‰Ì…", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
        '        If x = MsgBoxResult.Ok Then
        '            txtPoint2.Focus()
        '        ElseIf x = MsgBoxResult.Cancel Then
        '            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        End If
        '    Else
        '        txtPoint3.Focus()
        '    End If
        'End If

    End Sub

    Private Sub txtPoint1_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'Dim x As Object
        ''UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        'If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Or (Its = "edit") Then
        '    If txtPoint1.Text = "" Or txtPoint1.Text = " " Then
        '        'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        x = MsgBox("⁄›Ê« ! ⁄·Ìﬂ ≈œŒ«· «·‰ﬁÿ… «·√Ê·Ï", MsgBoxStyle.OkCancel + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
        '        If x = MsgBoxResult.Ok Then
        '            txtPoint1.Focus()
        '        ElseIf x = MsgBoxResult.Cancel Then
        '            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '        End If
        '    Else
        '        txtPoint2.Focus()
        '    End If
        'End If
    End Sub


    Private Sub txtPoint3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim x As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Or Me.ActiveControl.Name = "txtPoint2" Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Dim ss As New ADODB.Recordset
        'If Its = "add" Or (Its = "edit" And IDbefore <> txtPoint1.Text & txtPoint2.Text & txtPoint3.Text) Then
        '	If txtPoint3.Text = "" Or txtPoint3.Text = " " Then
        '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		x = MsgBox("⁄‹›‹‹Ê« ! ·ﬁœ ﬁ„  »≈œŒ«· ‰ﬁÿ Ì‰ ›ﬁÿ »œ·« ⁄‰ À·«À ‰ﬁ«ÿ.  —Ìœ ≈œŒ«· ‰ﬁÿ… À«·À… ø", MsgBoxStyle.YesNoCancel + MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
        '		If x = MsgBoxResult.No Then
        '			txtSir.Focus()
        '		ElseIf x = MsgBoxResult.Yes Then 
        '			txtPoint3.Focus()
        '		ElseIf x = MsgBoxResult.Cancel Then 
        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '		End If
        '	Else
        '              'ss = New ADODB.Recordset
        '              'If ss.State = ADODB.ObjectStateEnum.adStateOpen Then ss.Close()
        '              'ss.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '              'ss.Open("Select * From PassCopies Where Point1='" & txtPoint1.Text & "' And Point2='" & txtPoint2.Text & "' And Point3 ='" & txtPoint3.Text & "' Order By Point1,Point2, Point3", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '              'If ss.RecordCount > 0 Then
        '              '	'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '              '	x = MsgBox("«·’Ê— Õ”» Â–Â «·‰ﬁ«ÿ „ÊÃÊœ…. Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â« ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRtlReading, "")
        '              '	If x = MsgBoxResult.Yes Then
        '              '		RS.MoveFirst()
        '              '		RS.Find("Point1='" & txtPoint1.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
        '              '		RS.Find("Point2='" & txtPoint2.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, RS.AbsolutePosition)
        '              '		RS.Find("Point3='" & txtPoint3.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, RS.AbsolutePosition)
        '              '		FromDB()
        '              '		EnDis(False, False, True)
        '              '		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '              '		Its = ""
        '              '	ElseIf x = MsgBoxResult.No Then 
        '              '		txtPoint3.Focus()
        '              '	ElseIf x = MsgBoxResult.Cancel Then 
        '              '		cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
        '              '	End If
        '              'End If
        '	End If
        'End If
    End Sub

    Private Sub txtSir_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub txtPoint3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dtPassCoppies As New dsExplosives.PassCopiesDataTable
        'dtPassCoppies = PassCopiesTableAdapter.GetDataByPoint1Point2Point3(txtPoint1.Text, txtPoint2.Text, txtPoint3.Text)
        'Dim PassCopyID As Integer = -1
        'If dtPassCoppies.Rows.Count > 0 Then
        '    PassCopyID = dtPassCoppies(0).ID

        '    Dim Index = PassCopiesBindingSource.Find("ID", PassCopyID)
        '    PassCopiesBindingSource.Position = Index
        '    GetPassCopySirs()
        'End If
        ' dtPassCoppies.Clear()
    End Sub

    Private Sub txtPoint2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim daPassCopies As New dsExplosivesTableAdapters.PassCopiesTableAdapter
        'txtPoint3.Text = ""


        'If Me.Point2DsExplosives1.PassCopies.Count > 0 Then
        '    'daPassCopies.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, txtPoint1.Text, txtPoint2.Text)
        '    If Me.Point3DsExplosives1.PassCopies.Count > 0 Then
        '        'txtPoint3.SelectedIndex = 0
        '        txtPoint3_SelectedIndexChanged(sender, e)

        '        ''  Me.PassCopiesTableAdapter.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, txtPoint1.Text, txtPoint2.Text)
        '    End If
        'End If
    End Sub

    Private Sub txtPoint1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.Point1DsExplosives1.PassCopies.Rows.Count > 0 Then


        '    Me.PassCopiesTableAdapter.FillDistinctPoint2(Me.Point2DsExplosives1.PassCopies, txtPoint1.Text)
        '    If Me.Point2DsExplosives1.PassCopies.Count > 0 Then
        '        'txtPoint2.SelectedIndex = 0
        '        txtPoint2_SelectedIndexChanged(sender, e)

        '        ''  Me.PassCopiesTableAdapter.FillDistinctPoint3(Me.Point3DsExplosives1.PassCopies, txtPoint1.Text, txtPoint2.Text)
        '    End If
        'End If
    End Sub

    Private Sub Check1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

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

    Private Sub cmdNew_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdSave_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub


    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        lblID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
          Dim dtPassCoppies As New dsExplosives.PassCopiesDataTable

        If lblID.Text <> "0" Then
            '    PassCopyID = dtPassCoppies(0).ID

            '    Dim Index = PassCopiesBindingSource.Find("ID", PassCopyID)
            '    PassCopiesBindingSource.Position = Index
            GetPassCopySirs()
        End If
        If lstSirs.Items.Count = 0 Then
            If MessageBox.Show("Â–Â «·‰ﬁÿ… ·Ì” ·œÌÂ« ÃÂ«  „Œ«ÿ»… Â·  Êœ «÷«›… ÃÂ«  ·Â«ø", " ‰»ÌÂ", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·⁄·„Ì«  «·»—Ì…"))
                lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·«” Œ»«—«  «·»—Ì…"))
                lstSirs.Items.Add(("«·”Ìœ/ „œÌ— ≈œ«—… «·√„‰ «·Êﬁ«∆Ì"))
                lstSirs.Items.Add(("«·”Ìœ/ ﬁ«∆œ «·„‰ÿﬁ… «·⁄”ﬂ—Ì… «·„—ﬂ“Ì…"))
                lstSirs.Items.Add(("«·”Ìœ/ „œÌ— «·≈œ«—… «·⁄«„… ··√œ·… «·Ã‰«∆Ì…"))
                lstSirs.Items.Add(("«·”Ìœ/ ﬁ«∆œ „‰ÿﬁ… »Õ—Ì «·⁄”ﬂ—Ì… √.”"))
                lstSirs.Items.Add(("«·”Ìœ/ —ﬂ‰ √.” ”·«Õ «·√”·Õ… Ê«·–Œ«∆—"))
            End If
        End If
    End Sub


End Class