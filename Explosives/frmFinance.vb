Option Strict Off
Option Explicit On
Friend Class frmFinance
    Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RS2 As New ADODB.Recordset
	Private SearchOf, IDbefore, Its, SQL, MyField As Object
	Private Loaded As Boolean
	Dim Thousands, Tens, Ones, Hundreds, TenThousands As Object
	Private Sub Con()
		Dim i As Object
		On Error Resume Next
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2 = New ADODB.Recordset
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Max(fDate) as Mx , Min (FDate) as Mn from Finance", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'txtDate1.Text = VB6.Format(RS2.Fields("Mn").Value, "yyyy/mm/dd")
        'txtDate2.Text = VB6.Format(RS2.Fields("MX").Value, "yyyy/mm/dd")

        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2 = New ADODB.Recordset
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Distinct Certifier From Finance Order By Certifier", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbCertifier.Items.Clear()
        'For i = 1 To RS2.RecordCount
        '	cmbCertifier.Items.Add(RS2.Fields("Certifier").Value)
        '	RS2.MoveNext()
        'Next 
		
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2 = New ADODB.Recordset
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Distinct SideName From ImportAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbSideName.Items.Clear()
        'cmbReceivee.Items.Clear()
        'For i = 1 To RS2.RecordCount
        '	cmbSideName.Items.Add(RS2.Fields("SideName").Value)
        '	cmbReceivee.Items.Add(RS2.Fields("SideName").Value)
        '	RS2.MoveNext()
        'Next 
		
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2 = New ADODB.Recordset
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Distinct SideName From WorkAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'For i = 1 To RS2.RecordCount
        '	cmbSideName.Items.Add(RS2.Fields("SideName").Value)
        '	cmbReceivee.Items.Add(RS2.Fields("SideName").Value)
        '	RS2.MoveNext()
        'Next 
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
		
        'Dim a As New ADODB.Command
        'a.CommandText = "update finance set difr = nvl(moneyin,0) - nvl(moneyout,0)"
        'a.CommandType = ADODB.CommandTypeEnum.adCmdText
        'a.ActiveConnection = DB
        'a.Execute()
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS.Open("Select Finance.*  From Finance Order By To_Number(To_Char(FDate,'YYYY')), To_number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
		
	End Sub
	
	Private Sub myclr()
        'clr()
		cmbCertifier.Text = ""
		cmbSideName.Text = ""
		cmbStation.Text = ""
	End Sub
	Private Sub FromDB()
		On Error Resume Next
		myclr()
        'txtID.Text = RS.Fields("ID").Value
        'txtMoneyText.Text = RS.Fields("MoneyText").Value
        'cmbCertifier.Text = RS.Fields("Certifier").Value
        'cmbSideName.Text = RS.Fields("SideName").Value
        'If RS.Fields("Come").Value = "Ê«—œ" Then
        '	txtMoney.Text = RS.Fields("MoneyIn").Value
        '	optInCome.Checked = True
        'ElseIf RS.Fields("Come").Value = "„‰’—›" Then 
        '	txtMoney.Text = RS.Fields("MoneyOut").Value
        '	optOutCome.Checked = True
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        'ElseIf IsDbNull(RS.Fields("Come").Value) Or RS.Fields("Come").Value = "" Then 
        '	optInCome.Checked = False
        '	optOutCome.Checked = False
        'End If
        'txtExplanation.Text = RS.Fields("Explanation").Value
        'txtreceivee.Text = RS.Fields("Receivee").Value
        'txtReceiver.Text = RS.Fields("Receiver").Value
        'cmbStation.Text = RS.Fields("Station").Value
        'txtDate.Text = VB6.Format(RS.Fields("FDate").Value, "YYYY/MM/DD")
        'lblPosition.Text = RS.RecordCount & " / " & RS.AbsolutePosition
	End Sub
	
	Private Sub ToDB()
		On Error Resume Next
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Then RS.AddNew()
        'RS.Fields("ID").Value = txtID.Text
        'RS.Fields("MoneyText").Value = txtMoneyText.Text
        'RS.Fields("Certifier").Value = cmbCertifier.Text
        'RS.Fields("SideName").Value = cmbSideName.Text
        'If optInCome.Checked = True Then
        '	RS.Fields("MoneyIn").Value = txtMoney.Text
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	RS.Fields("MoneyOut").Value = System.DBNull.Value
        '	RS.Fields("Come").Value = "Ê«—œ"
        'ElseIf optOutCome.Checked = True Then 
        '	RS.Fields("MoneyOut").Value = txtMoney.Text
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	RS.Fields("MoneyIn").Value = System.DBNull.Value
        '	RS.Fields("Come").Value = "„‰’—›"
        'End If
        'RS.Fields("Explanation").Value = txtExplanation.Text
        'RS.Fields("Receivee").Value = txtreceivee.Text
        'RS.Fields("Receiver").Value = txtReceiver.Text
        'RS.Fields("Station").Value = cmbStation.Text
        'RS.Fields("FDate").Value = txtDate.Text
	End Sub
	
	'UPGRADE_WARNING: Event cmbBy.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbBy_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
        Dim i As Object
        'Dim r As New ADODB.Recordset
        If cmbCriteria.Text = "«·ÃÂ… «·œ«›⁄…" Then
            cmbReceivee.Enabled = True
            'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'r.Open("Select Distinct Receivee From Finance Order By Receivee", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            'cmbReceivee.Items.Clear()
            'For i = 1 To r.RecordCount
            '	cmbReceivee.Items.Add(r.Fields(0).Value)
            '	r.MoveNext()
            'Next 
            cmbReceivee_SelectedIndexChanged(cmbReceivee, New System.EventArgs())
            txtFind.Enabled = False
            'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'txtFind.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
            'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmbReceivee.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)

        Else
            txtFind_TextChanged(txtFind, New System.EventArgs())
            txtFind.Enabled = True
            cmbReceivee.Enabled = False
            'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'txtFind.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
            'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'cmbReceivee.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)

        End If
    End Sub

    'UPGRADE_WARNING: Event cmbReceivee.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmbReceivee_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbReceivee.SelectedIndexChanged
        On Error GoTo er
        '		If Loaded = True Then
        '			If cmbBy.Text = "«·ÃÂ… «·œ«›⁄…" Then
        '				'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '				SQL = "Select Finance.* From Finance Where SideName Like '%" & cmbReceivee.Text & "%' "
        '			End If
        '			If IsDate(txtDate2.Text) = True And IsDate(txtDate1.Text) = True And txtDate1.Text <> txtDate2.Text Then
        '				'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '                'SQL = SQL & " And FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "'  And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' "
        '			End If
        'SkipDate: 
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        '	RS = New ADODB.Recordset
        '	RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	RS.Open(SQL & " Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        '	If RS.RecordCount > 0 Then
        '		cmdFound.Enabled = True
        '		cmdPrintDoc.Enabled = True
        '		'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		cmdFound.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        '		'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		cmdPrintDoc.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        '	Else
        '		cmdFound.Enabled = False
        '		cmdPrintDoc.Enabled = False
        '		'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		cmdFound.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '		'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		cmdPrintDoc.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '	End If
        '	FromDB()
        'End If
        Exit Sub
er:
        MsgBox(Err.Description)
        Err.Clear()
    End Sub

    Private Sub cmbSearch_Click()
        txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        On Error Resume Next
        If cmdCancel.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ „‰ √‰ﬂ  —Ìœ ≈·‹‹€‹‹«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                'RS.MoveFirst()
                'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'RS.Find("ID=" & IDbefore, 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                FromDB()
                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
                'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                Its = ""
                'EnDis(False, False, True)
            End If
            cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        'If cmdDelete.CheckState = 1 Then
        '          'If RS.RecordCount > 0 Then
        '          ''UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        x = MsgBox("Â· √‰  „ √ﬂœ „‰ √‰ﬂ  —Ìœ Õ–› Â–« «·„” ‰œ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            FINANCEBindingSource.RemoveCurrent()
            FINANCETableAdapter.Update(DsExplosives.FINANCE)
            MsgBox(" ‹‹‹‹‹‹„ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
            'Con()
            'FromDB()
        End If
        '          'End If
        '          cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
        '      End If
    End Sub

    'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        If cmdEdit.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Its = "edit"
            'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'IDbefore = txtID.Text
            'TextUnLock()
            'EnDis(False, True, False)
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        ''If cmdExit.CheckState = 1 Then ProgramExit()
    End Sub

    'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        FINANCEBindingSource.MoveFirst()
        'On Error Resume Next
        'If cmdFirst.CheckState = 1 Then
        '          'RS.MoveFirst()
        '	Beep()
        '	FromDB()
        '	cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
        Dim dtrFinance As Object
        Dim m As Object
        On Error GoTo er
        If cmdFound.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'm = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(m - 1)
            'cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        Err.Clear()
    End Sub

    'UPGRADE_WARNING: Event cmdInOut.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdInOut_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdInOut.CheckStateChanged
        Dim dtrFinanceInOut As Object
        Dim i As Object
        On Error GoTo er
        If cmdInOut.CheckState = 1 Then

            'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'i = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinanceInOut.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinanceInOut.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinanceInOut.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinanceInOut.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinanceInOut.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinanceInOut.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(i - 1)
            'cmdInOut.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        cmdInOut.CheckState = System.Windows.Forms.CheckState.Unchecked
        Err.Clear()
    End Sub

    'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        FINANCEBindingSource.MoveLast()
    End Sub

    'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'LogOut()
    End Sub

    'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        DataGridView1.Rows.Clear()
        FINANCEBindingSource.AddNew()
        dtpDate.Value = DateTime.Now
         If cmbRank.Items.Count > 0 Then
            cmbRank.SelectedIndex = 0
        End If
        If cmbName.Items.Count > 0 Then
            cmbName.SelectedIndex = 0
        End If
        If cmbPosition.Items.Count > 0 Then
            cmbPosition.SelectedIndex = 0
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        On Error Resume Next
        If cmdNext.CheckState = 1 Then
            'RS.MoveNext()
            'If RS.EOF Then
            '	RS.MoveLast()
            '	Beep()
            'End If
            FromDB()
            cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        FINANCEBindingSource.MovePrevious()
        'On Error Resume Next
        'If cmdPrev.CheckState = 1 Then
        '          'RS.MovePrevious()
        '          'If RS.BOF Then
        '          '	RS.MoveFirst()
        '          '	Beep()
        '          'End If
        '	FromDB()
        '	cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
        Dim m As Object
        Dim dtrFinance As Object
        On Error GoTo er
        If cmdPrintAll.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'm = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrFinance.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object m. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(m - 1)
            'cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        Err.Clear()
    End Sub

    'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
        Dim fPrintFinanceBill As New frmPrintFinance(Convert.ToString(txtID.Text))
        fPrintFinanceBill.ShowDialog()
        '		Dim dtrFinance As Object
        '		On Error GoTo er
        '        'Dim RSs As New ADODB.Recordset
        '        'If cmdPrintDoc.CheckState = 1 Then
        '        '	RSs = New ADODB.Recordset
        '        '	If RSs.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        '        '	RSs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '        '	RSs.Open("Select * From Finance Where ID='" & txtID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrFinance.DataSource = RSs
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrFinance.Refresh()
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrFinance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrFinance.Show()
        '        '	cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
        '        'End If
        '		Exit Sub
        'er: 
        '		cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
        '		MsgBox(Err.Description)
        '		Err.Clear()
    End Sub

    'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
        If cmdRefresh.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Its = ""
            Con()
            FromDB()
            cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        If cmdReturn.CheckState = 1 Then Hide()
    End Sub

    'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        FINANCEBindingSource.EndEdit()
        FINANCETableAdapter.Update(DsExplosives.FINANCE)
        FinanceDetailsTableAdapter.DeleteByFinanceID(Convert.ToInt32(txtID.Text))
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            FinanceDetailsTableAdapter.Insert(Convert.ToDecimal(DataGridView1.Rows(i).Cells("Amount").Value),
                                              DataGridView1.Rows(i).Cells("Data").Value.ToString,
                                              Convert.ToInt32(txtID.Text))
        Next
        ''On Error Resume Next
        'If cmdSave.CheckState = 1 Then
        '	ToDB()
        '	Timer1.Enabled = False
        '          'ApplySettings()
        '          'RS.Update()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	Its = ""
        MsgBox(" ‹‹‹‹„ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
        '	Con()
        '	FromDB()
        '          'EnDis(False, False, True)
        '          'TextLock()
        '	cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub

    Private Sub DataGrid1_Click()
        Dim dtrFinanceInOut As Object
        Dim DataGrid1 As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object DataGrid1.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'DataGrid1.DataSource = RS
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinanceInOut.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrFinanceInOut.DataSource = RS
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFinanceInOut.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrFinanceInOut.Show()
    End Sub

    'UPGRADE_WARNING: Form event frmFinance.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmFinance_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        Loaded = False
        'LoadAllSettings()
        'ApplySettings()
        'cmdRefresh.Width = Me.ClientRectangle.Width
        ''UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If Its = "add" Then txtID.Focus()
        'If FindFinance = True Then
        '	RS.MoveFirst()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FinanceIdx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	RS.Move(FinanceIdx - 1)
        '	FromDB()
        '	FindFinance = False
        'End If
        Loaded = True
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
    Private Sub frmFinance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.FINANCE' table. You can move, or remove it, as needed.
        Me.FINANCETableAdapter.Fill(Me.DsExplosives.FINANCE)
        Dim Money As Decimal = 0
        If DsExplosives.FINANCE.Rows.Count <> 0 Then

            Me.FinanceDetailsTableAdapter.FillByFinanceID(DsExplosives.FinanceDetails, Convert.ToInt32(txtID.Text))
            For i As Integer = 0 To DsExplosives.FinanceDetails.Rows.Count - 1
                DataGridView1.Rows.Add(DsExplosives.FinanceDetails.Rows(i)("Amount"), DsExplosives.FinanceDetails.Rows(i)("Data"))
                Money += Convert.ToDecimal(DsExplosives.FinanceDetails.Rows(i)("Amount"))
            Next

        End If
        nudMoney.Text = Money
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (FINANCEBindingSource.Position + 1).ToString + " / " + FINANCEBindingSource.Count.ToString


        'Loaded = True
    End Sub

    Private Sub frmFinance_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
    End Sub

    Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
        'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        ErrorProvider1.Clear()
        Timer1.Stop()

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
    Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub

    'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
        On Error Resume Next
        If Loaded = True Then
            If cmbCriteria.Text = "«·ﬂ·" And IsDate(txtFind.Text) = False Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where ( ID='" & txtFind.Text & "' Or Certifier Like '%" & txtFind.Text & "%' Or SideName Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%' Or Status Like '%" & txtFind.Text & "%') "
            ElseIf cmbCriteria.Text = "«·ﬂ·" And IsDate(txtFind.Text) = True Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'SQL = "Select Finance.* From Finance Where FDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' "
            ElseIf cmbCriteria.Text = "‰„—… «·„” ‰œ" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where ID='" & txtFind.Text & "' "
            ElseIf cmbCriteria.Text = "«·‘«Âœ" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where Certifier Like '%" & txtFind.Text & "%' "
            ElseIf cmbCriteria.Text = "«·ÃÂ… «·œ«›⁄…" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where SideName Like '%" & txtFind.Text & "%' "
            ElseIf cmbCriteria.Text = "«·ÃÂ… «·„” ·„…" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where Receiver Like '%" & txtFind.Text & "%' "
            ElseIf cmbCriteria.Text = "«· ’—ÌÕ √Ê «·≈–‰" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                SQL = "Select Finance.* From Finance Where Status Like '%" & txtFind.Text & "%' "
            ElseIf cmbCriteria.Text = " «—ÌŒ «·„” ‰œ" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'SQL = "Select Finance.* From Finance Where FDate = '" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' "
            ElseIf cmbCriteria.Text = "› —…  «—ÌŒÌ…" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'SQL = "Select Finance.* From Finance Where FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "'  And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' "
                GoTo SkipDate
            End If
            'If IsDate(txtDate2.Text) = True And IsDate(txtDate1.Text) = True And txtDate1.Text <> txtDate2.Text Then
            '	'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '             'SQL = SQL & " And (FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "'  And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
            'End If
SkipDate:
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            '	RS = New ADODB.Recordset
            '	RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            '	'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	RS.Open(SQL & " Order By ID", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
            '	If RS.RecordCount > 0 Then
            '		cmdFound.Enabled = True
            '		cmdPrintDoc.Enabled = True
            '		'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		cmdFound.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
            '		'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		cmdPrintDoc.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
            '	Else
            '		cmdFound.Enabled = False
            '		cmdPrintDoc.Enabled = False
            '		'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		cmdFound.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
            '		'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '		cmdPrintDoc.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        End If
        '	FromDB()
        'End If
    End Sub

    Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtID.Leave
        Dim x As Object
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If ActiveControl.Name = "cmdCancel" Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Its = "add" Or (Its = "edit" And txtID.Text <> IDbefore) Then
            If txtID.Text = "" Or txtID.Text = " " Or txtID.Text = "  " Then
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „«ﬂ‰ —ﬁ„ «·„” ‰œ ›«—€‹‹‹‹«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OKCancel)
                If x = MsgBoxResult.OK Then
                    txtID.Focus()
                ElseIf x = MsgBoxResult.Cancel Then
                    cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                End If
            Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("ID='" & txtID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	If RS.EOF = False Then
                '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		x = MsgBox("⁄›Ê« ! Â–« «·„ ” ‰œ „ÊÃÊœ ∫ Â·  Êœ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNoCancel)
                '		If x = MsgBoxResult.Yes Then
                '			FromDB()
                '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			Its = ""
                '			EnDis(False, False, True)
                '		ElseIf x = MsgBoxResult.No Then 
                '			txtID.Focus()
                '		ElseIf x = MsgBoxResult.Cancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	Else
                '		RS.MoveFirst()
                '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		RS.Find("ID=" & IDbefore, 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	End If
                'End If
            End If
        End If
    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub txtData_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtData.KeyPress
        If Asc(e.KeyChar) = 13 Then


            If txtData.Text <> "" Or nudAmount.Value <> 0 Then
                DataGridView1.Rows.Add(nudAmount.Value, txtData.Text)
                nudMoney.Text = Convert.ToDecimal(nudMoney.Text) + nudAmount.Value

                txtData.Text = ""
                nudAmount.Value = 0
            ElseIf txtData.Text = "" Then
                ErrorProvider1.SetError(txtData, "„ÿ·Ê»")
                If Timer1.Enabled Then
                    Timer1.Start()
                End If

            ElseIf nudAmount.Value = 0 Then
                ErrorProvider1.SetError(nudAmount, "„ÿ·Ê»")
                If Timer1.Enabled Then
                    Timer1.Start()
                End If
            End If
        End If
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub DataGridView1_RowsRemoved(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        If DataGridView1.Rows.Count > 0 Then
            nudMoney.Text = Convert.ToDecimal(nudMoney.Text) - Convert.ToDecimal(DataGridView1.Rows(e.RowIndex).Cells("Amount").Value)
        End If
    End Sub

    Private Sub txtData_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtData.TextChanged

    End Sub
End Class
