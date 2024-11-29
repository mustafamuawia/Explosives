Option Strict Off
Option Explicit On
Friend Class frmOurRecentDistract
	Inherits System.Windows.Forms.Form
	
    'Dim rsDist As New ADODB.Recordset
    'Dim RS As New ADODB.Recordset
    'Private RSreceiver As New ADODB.Recordset
    'Private RsDistDist As New ADODB.Recordset
    'Private RSaccount As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
	Private SQLDist As String
	Private Searched As Boolean
	Private Records, rsSQL3, rsSQL1, dtrWhere, dtrSQL3, dtrSQL1, dtrSQL2, dtrSQL, Duration, rsSQL2, rsSQL, Moves As Object
	Private Function Con() As Object
		Dim i As Object
		Searched = False
        'Dim r As New ADODB.Recordset
        'r.Open("Select Max(DistDate) mx, Min(DistDate) nx From DistractClass", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'txtDate2.Text = VB6.Format(r.Fields("MX").Value, "YYYY/MM/DD")
        'txtDate1.Text = VB6.Format(r.Fields("Nx").Value, "YYYY/MM/DD")
        'r.Close()
        'RS = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL = rsSQL1 & rsSQL2 & rsSQL3
        'RS.Open(rsSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
		
		'__________________________________________________________________________________
		
        'RSreceiver = New ADODB.Recordset
        'If RSreceiver.State = ADODB.ObjectStateEnum.adStateOpen Then RSreceiver.Close()
        'RSreceiver.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSreceiver.Open("Select SideName From WorkAllowed", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		cmbReceiver.Items.Clear()
		cmbReceiver.Items.Add("«·ﬂ·")
		cmbReceiver.Items.Add("”·«Õ «·√”·Õ… Ê «·–Œ«∆—")
        'For i = 1 To RSreceiver.RecordCount
        '	cmbReceiver.Items.Add(RSreceiver.Fields("SideName").Value)
        '	RSreceiver.MoveNext()
        'Next 
		
		'_________________________________________________________________________________
		
        'RSaccount = New ADODB.Recordset
        'If RSaccount.State = ADODB.ObjectStateEnum.adStateOpen Then RSaccount.Close()
        'RSaccount.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSaccount.Open("Select Account From Accounts", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		cmbAccount.Items.Clear()
		cmbAccount.Items.Add("«·ﬂ·")
        'For i = 1 To RSaccount.RecordCount
        '	cmbAccount.Items.Add(RSaccount.Fields("Account").Value)
        '	RSaccount.MoveNext()
        'Next 
		Searched = True
	End Function
	Private Function clr() As Object
		Dim ccontrol As System.Windows.Forms.Control
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Clear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Clear()
			End If
		Next ccontrol
	End Function
	Private Function ToLists() As Object
		Dim i As Object
		On Error Resume Next
		lstAmmountStr.Items.Clear()
		lstUnitStr.Items.Clear()
		lstClassStr.Items.Clear()
		lstClassIDStr.Items.Clear()
        'txtDistractor.Text = RS.Fields("DistDistractor").Value
        'txtReceiver.Text = RS.Fields("DistReceiver").Value
        'rsDist = New ADODB.Recordset
        'If rsDist.State = ADODB.ObjectStateEnum.adStateOpen Then rsDist.Close()
        'rsDist.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		'MsgBox "Select * From (" & rsSQL & ") Where DistReceiver='" & txtReceiver.Text & "' AND DistDistractor='" & txtDistractor.Text & "'"
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'rsDist.Open("Select * From (" & rsSQL & ") Where DistReceiver='" & txtReceiver.Text & "' AND DistDistractor='" & txtDistractor.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'lblPosition.Text = RS.RecordCount & "/" & RS.AbsolutePosition
        'For i = 1 To rsDist.RecordCount
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(rsDist.Fields("DistAmmount").Value) Then
        '		lstAmmountStr.Items.Add(rsDist.Fields("DistAmmount").Value)
        '	Else
        '		lstAmmountStr.Items.Add("")
        '	End If
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(rsDist.Fields("DistUnit").Value) Then
        '		lstUnitStr.Items.Add(rsDist.Fields("DistUnit").Value)
        '	Else
        '		lstUnitStr.Items.Add("")
        '	End If
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(rsDist.Fields("DistClass").Value) Then
        '		lstClassStr.Items.Add(rsDist.Fields("DistClass").Value)
        '	Else
        '		lstClassStr.Items.Add("")
        '	End If
        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '	If Not IsDbNull(rsDist.Fields("DistClassID").Value) Then
        '		lstClassIDStr.Items.Add(rsDist.Fields("DistClassID").Value)
        '	Else
        '		lstClassIDStr.Items.Add("")
        '	End If
        '	rsDist.MoveNext()
        'Next 
	End Function
	
	Private Sub cmbDistracter_Click()
		Dim SQL As Object
        'RS = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        ''UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'SQL = "Select DistractClass.Distractor DistDistractor, sum(DistractClass.Ammount) DistAmmount, DistractClass.Unit DistUnit, DistractClass.Class as DistClass," & " NVL(DistractClass.ClassID,'-') DistClassID," & " sum(DistractClass.Ammount) DisAmmount, DistractClass.Unit DisUnit, DistractClass.Class as DisClass," & " DistractClass.ClassID DisClassId" & " From DistractClass, DistractClass" & " Where DistractClass.Class(+)=DistractClass.Class" & " Group By (DistractClass.Distractor, DistractClass.Class,DistractClass.Unit, DistractClass.Class, DistractClass.Unit," & " DistractClass.ClassID, DistractClass.ClassID)" & " Order By DistractClass.Distractor, DistractClass.Class, DistractClass.Class"
        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
		
	End Sub
	
	Private Sub Check1_Click()
		
	End Sub
	
	Private Sub Command2_Click()
		
	End Sub
	
	Private Sub Command1_Click()
		Dim dtrOurRecent As Object
		'Set dtrOurRecent.DataSource = RS
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrOurRecent.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrOurRecent.Show()
	End Sub
	
	Private Sub Check2_Click()
		
	End Sub
	
	'UPGRADE_WARNING: Event chkAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkAll.CheckStateChanged
		If chkAll.CheckState = 1 And cmbSearch.Text <> "⁄«„" Then txtFind.Text = "«·ﬂ·"
	End Sub
	
	'UPGRADE_WARNING: Event chkReceiver.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReceiver_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReceiver.CheckStateChanged
		If chkReceiver.CheckState = 1 Then cmbReceiver.Text = "«·ﬂ·"
	End Sub
	
	'UPGRADE_WARNING: Event cmbAccount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAccount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAccount.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbReceiver.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbReceiver_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbReceiver.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
		If cmbReceiver.Text = "«·ﬂ·" Then
			chkReceiver.CheckState = System.Windows.Forms.CheckState.Checked
		Else
			chkReceiver.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbSearch.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbSearch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
		If cmbSearch.Text = "«”„ «·ÃÂ… «·’«—›…" Then
			cmbReceiver.Enabled = True
			lblDistractor.Visible = False
			lblReceiver.Visible = True
			chkAll.Enabled = True
			chkReceiver.Enabled = True
		ElseIf cmbSearch.Text = "«”„ «·ÃÂ… «·„” ·„…" Then 
			cmbReceiver.Enabled = True
			lblReceiver.Visible = False
			lblDistractor.Visible = True
			chkAll.Enabled = True
			chkReceiver.Enabled = True
		Else
			cmbReceiver.Enabled = False
			lblDistractor.Visible = False
			lblReceiver.Visible = True
			chkAll.Enabled = False
			chkReceiver.Enabled = False
		End If
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
		Dim x As Object
		If cmdExit.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ «·Œ—ÊÃ ø", MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Question)
			If x = MsgBoxResult.Yes Then End
			cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
		On Error Resume Next
		If cmdNext.CheckState = 1 Then
            'RS.Move(rsDist.RecordCount)
            'If RS.EOF Then
            '	RS.Move(-rsDist.RecordCount)
            '	Beep()
            'End If
			ToLists()
			cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
		On Error Resume Next
		If cmdPrev.CheckState = 1 Then
            'RS.MovePrevious()
            'ToLists()
            'RS.MoveNext()
            'RS.Move(-rsDist.RecordCount)
            'If RS.BOF Then
            '	RS.MoveFirst()
            '	Beep()
            'End If
			ToLists()
			cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	
	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
		Dim dtrRecentDistract As Object
		On Error GoTo er
		If cmdFound.CheckState = 1 Then
			txtFind_TextChanged(txtFind, New System.EventArgs())
			'    Load DataEnvironment1
			'    With DataEnvironment1
			'        If .rsCommand4_Grouping.State = adStateOpen Then .rsCommand4_Grouping.Close
			'        .Commands(9).CommandText = dtrSQL
			'        .Commands(9).Execute
			'    End With
            '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            '	RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            '	'MsgBox dtrSQL
            '	RsRpt.Open(dtrSQL, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.DataSource = RsRpt
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Sections(1).Controls("lblDuration").Caption = "›Ì «·› —… „‰ " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD„") & " ≈·‹‹Ï " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD„")
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Refresh()
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Show()
            '	cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
		Dim dtrRecentDistract As Object
		On Error GoTo er
		If cmdPrintAll.CheckState = 1 Then
			'  Load DataEnvironment1
			'  With DataEnvironment1
			'      If .rsCommand4_Grouping.State = adStateOpen Then .rsCommand4_Grouping.Close
			'      .Commands(9).CommandText = dtrSQL1 & dtrSQL2 & dtrSQL3
			'      .Commands(9).Execute
			'  End With
            '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            '	RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	RsRpt.Open(dtrSQL1 & dtrSQL2 & dtrSQL3, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.DataSource = RsRpt
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Sections(1).Controls("lblDuration").Caption = "›Ì «·› —… „‰ " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD„") & " ≈·‹‹Ï " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD„")
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Refresh()
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrRecentDistract.Show()
            '	cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
        Exit Sub
er:
        cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        MsgBox(Err.Description, MsgBoxStyle.Critical)
        Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
		Dim dtrRecentDistract As Object
		On Error GoTo er
		If cmdPrintDoc.CheckState = 1 Then
			'    Load DataEnvironment1
			'    With DataEnvironment1
			'        If .rsCommand4_Grouping.State = adStateOpen Then .rsCommand4_Grouping.Close
			'        .Commands(9).CommandText = dtrSQL1 & " Where Distractor='" & txtDistractor.Text & "' And Receiver='" & txtReceiver.Text & "' " & dtrSQL2 & Duration & dtrSQL3
			'        MsgBox dtrSQL
			'        .Commands(9).Execute
			'    End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSQL1 & " Where Distractor='" & txtDistractor.Text & "' And Receiver='" & txtReceiver.Text & "' " & Duration & dtrSQL2 & dtrSQL3, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentDistract.DataSource = RsRpt
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentDistract.Sections(1).Controls("lblDuration").Caption = "›Ì «·› —… „‰ " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD„") & " ≈·‹‹Ï " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD„")
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentDistract.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentDistract.Show()
            'cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
		Dim Its As Object
		If cmdRefresh.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = ""
			Con()
			ToLists()
			cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
		If cmdReturn.CheckState = 1 Then
			frmMain.Show()
			Me.Hide()
			cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmOurRecentDistract.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmOurRecentDistract_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		cmdRefresh.Width = Me.ClientRectangle.Width
        'LoadAllSettings()
        'ApplySettings()
	End Sub
	
	Private Sub frmOurRecentDistract_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim Serched As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL1 = "SELECT SUM(AMMOUNT) AS DistAMMOUNT, UNIT AS DistUNIT, CLASS AS DistCLASS, NVL(ClassID,'‹‹‹‹‹') AS DistCLASSID, DISTRACTOR AS DistDISTRACTOR, RECEIVER AS DistRECEIVER, ACCOUNT AS DistACCOUNT FROM DistractCLASS "
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL2 = " GROUP BY ACCOUNT, Class, UNIT, ClassID, DISTRACTOR, RECEIVER"
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL3 = " ORDER BY account, distractor, receiver, class, unit"
		
		Con()
		ToLists()
		'UPGRADE_WARNING: Couldn't resolve default property of object Serched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Serched = False
		cmbSearch.SelectedIndex = 0
		cmbReceiver.Text = "«·ﬂ·"
		cmbAccount.SelectedIndex = 0
		Searched = True
		'* * * *  * * * * * * * * *    * * *  **      ****      **      **     **        **       **
		
		'* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ****************************
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL1 = "SHAPE {SELECT SUM(AMMOUNT) AS DistAMMOUNT, UNIT AS DistUNIT, CLASS AS DistCLASS, DISTRACTOR AS DistDISTRACTOR, " & "RECEIVER AS DistRECEIVER, ACCOUNT AS DistACCOUNT FROM DistractCLASS "
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL2 = " GROUP BY ACCOUNT, Class, UNIT, DISTRACTOR, RECEIVER "
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL3 = " ORDER BY account, distractor, receiver, class, unit} AS Command4 COMPUTE Command4 BY 'DistDISTRACTOR','DistRECEIVER','DistACCOUNT'"
	End Sub
	
	Private Sub isButton1_Click()
		
	End Sub
	
	Private Sub frmOurRecentDistract_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	'UPGRADE_WARNING: Event lstAmmountDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstAmmountDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstAmmountDist.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '(lstAmmountDist.SelectedIndex) = lstAmmountDist.GetSelected(lstAmmountDist.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstAmmountStr.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstAmmountStr_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstAmmountStr.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstAmmountStr.SelectedIndex) = lstAmmountStr.GetSelected(lstAmmountStr.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstClassDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstClassDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClassDist.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClassDist.SelectedIndex) = lstClassDist.GetSelected(lstClassDist.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstClassIDDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstClassIDDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClassIDDist.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClassIDDist.SelectedIndex) = lstClassIDDist.GetSelected(lstClassIDDist.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstClassIDStr.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstClassIDStr_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClassIDStr.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClassIDStr.SelectedIndex) = lstClassIDStr.GetSelected(lstClassIDStr.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstClassStr.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstClassStr_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClassStr.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClassStr.SelectedIndex) = lstClassStr.GetSelected(lstClassStr.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	Private Sub lstRecordDist_Click()
		Dim lstRecordDist As Object
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object lstRecordDist.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object lstRecordDist.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstRecordDist.ListIndex) = lstRecordDist.Selected(lstRecordDist.ListIndex)
			End If
		Next ccontrol
	End Sub
	
	Private Sub lstRecordStr_Click()
		Dim lstRecordStr As Object
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object lstRecordStr.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Couldn't resolve default property of object lstRecordStr.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstRecordStr.ListIndex) = lstRecordStr.Selected(lstRecordStr.ListIndex)
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstUnitDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstUnitDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstUnitDist.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstUnitDist.SelectedIndex) = lstUnitDist.GetSelected(lstUnitDist.SelectedIndex)
			End If
		Next ccontrol
		
	End Sub
	
	'UPGRADE_WARNING: Event lstUnitStr.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstUnitStr_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstUnitStr.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstUnitStr.SelectedIndex) = lstUnitStr.GetSelected(lstUnitStr.SelectedIndex)
			End If
		Next ccontrol
	End Sub
	
	
	
	
	
	Public Sub mmnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mmnuColours.Click
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
		If Searched = True Then
			If txtFind.Text <> "" Then chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked
			If txtFind.Text = "«·ﬂ·" Then chkAll.CheckState = System.Windows.Forms.CheckState.Checked
			If cmbSearch.Text = "⁄«„" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where (Class Like '%" & txtFind.Text & "%' Or Account Like '%" & txtFind.Text & "%' Or Distractor Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%' ) "
			ElseIf cmbSearch.Text = "«”„ «·ÃÂ… «·’«—›…" Then 
				If txtFind.Text = "«·ﬂ·" Then
					If cmbReceiver.Text = "«·ﬂ·" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = ""
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Receiver Like '%" & cmbReceiver.Text & "%'"
					End If
				Else
					If cmbReceiver.Text = "«·ﬂ·" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = "Where Distractor Like '%" & txtFind.Text & "%'"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where ( Distractor Like '%" & txtFind.Text & "%' And Receiver Like '%" & cmbReceiver.Text & "%') "
					End If
				End If
			ElseIf cmbSearch.Text = "«”„ «·ÃÂ… «·„” ·„…" Then 
				If txtFind.Text = "«·ﬂ·" Then
					If cmbReceiver.Text = "«·ﬂ·" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = ""
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Distractor Like '%" & cmbReceiver.Text & "%'"
					End If
				Else
					If cmbReceiver.Text = "«·ﬂ·" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = "Where Receiver Like '%" & txtFind.Text & "%'"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where (Receiver Like '%" & txtFind.Text & "%' And Distractor Like '%" & cmbReceiver.Text & "%')"
					End If
				End If
				
			End If
			If cmbAccount.Text = "«·ﬂ·" Then
				If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'Duration = " And (DistDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Duration = " "
				End If
			Else
				If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'Duration = " And (DistDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' And Account='" & cmbAccount.Text & "') "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					Duration = " And Account='" & cmbAccount.Text & "'"
				End If
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrSQL = dtrSQL1 & dtrWhere & Duration & dtrSQL2 & dtrSQL3
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rsSQL = rsSQL1 & dtrWhere & Duration & rsSQL2 & rsSQL3
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
			' MsgBox rsSQL
            'RS.Open(rsSQL, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
			ToLists()
		End If
	End Sub
End Class