Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmBalance
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
	Private SQL, dtrSQL As Object
	Private Loaded As Boolean
	
	Private Sub Con()
        'On Error Resume Next
        'RS = New ADODB.Recordset
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        ''UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) 
        'Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, 
        'ImportClass.Class Class," & " ImportClass.ClassID ClassID, 
        'To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor,
        ' ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, 
        'DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account " & " Group By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class "
        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		Loaded = False
		cmbAccount.SelectedIndex = 0
		cmbSearchSide.SelectedIndex = 0
		cmbYear.SelectedIndex = 0
		Loaded = True
	End Sub
	Private Sub FromDB()
		Dim i As Object
		txtAccount.Text = ""
		txtDate.Text = ""
		txtSideName.Text = ""
        'lstClass.Items.Clear()
        'lstClassID.Items.Clear()
        'lstDist.Items.Clear()
        'lstImp.Items.Clear()
        'lstLeft.Items.Clear()
        'lstUnit.Items.Clear()
        'On Error Resume Next
        'txtAccount.Text = RS.Fields("Account").Value
        'txtSideName.Text = RS.Fields("DISTRACTOR").Value
        'txtDate.Text = RS.Fields("Dt").Value
        'Dim RS2 As New ADODB.Recordset
        'RS2 = New ADODB.Recordset
        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RS2.Open("Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account  " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having ImportClass.Account='" & txtAccount.Text & "' And ImportClass.Distractor='" & txtSideName.Text & "' And To_Char(ImportClass.DistDate,'YYYY')='" & txtDate.Text & "'" & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class ", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		
        'For i = 1 To RS2.RecordCount
        'lstImp.Items.Add(RS2.Fields("Imp").Value)
        'lstDist.Items.Add(RS2.Fields("Dist").Value)
        'lstLeft.Items.Add(RS2.Fields("Left").Value)
        'lstUnit.Items.Add(RS2.Fields("Unit").Value)
        'lstClass.Items.Add(RS2.Fields("Class").Value)
        'lstClassID.Items.Add(RS2.Fields("ClassID").Value)
        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        'If IsDbNull(RS2.Fields("ClassID").Value) Then lstClassID.Items.Add("")
        'RS2.MoveNext()
        'Next 
	End Sub
	
	'UPGRADE_WARNING: Event cmbAccount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAccount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAccount.SelectedIndexChanged
		cmdSearch_Click()
	End Sub
	
	'UPGRADE_WARNING: Event cmbSearchSide.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbSearchSide_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSearchSide.SelectedIndexChanged
		cmdSearch_Click()
	End Sub
	
	'UPGRADE_WARNING: Event cmbYear.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbYear_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbYear.SelectedIndexChanged
		cmdSearch_Click()
	End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        'If cmdExit.CheckState = 1 Then ProgramExit()
	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
		On Error Resume Next
        'If cmdFirst.CheckState = 1 Then
        '	RS.MoveFirst()
        '	FromDB()
        '	Beep()
        '	cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
		Dim dtrBalance As Object
		On Error GoTo er
        'If cmdFound.CheckState = 1 Then
        '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
        '	RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	RsRpt.Open("SHAPE {" & SQL & " } As Balance Compute Balance By 'Dt', 'Distractor', 'Account','Balanced'", DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.DataSource = RsRpt
        'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrBalance.Refresh()
        'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        dtrBalance.Show()
        cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
        Exit Sub
er:
        MsgBox(Err.Description)
        Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        'If cmdLast.CheckState = 1 Then
        '	RS.MoveLast()
        '	FromDB()
        '	RS.Move(-lstClass.Items.Count + 1)
        '	FromDB()
        '	cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'LogOut()
	End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
		On Error Resume Next
        'If cmdNext.CheckState = 1 Then
        '	RS.Move(lstClass.Items.Count)
        '	If RS.EOF Then
        '		RS.MoveLast()
        '		RS.Move(-lstClass.Items.Count + 1)
        '		Beep()
        '	End If
        '	FromDB()
        '	cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        'On Error Resume Next
        'If cmdPrev.CheckState = 1 Then
        '	RS.MovePrevious()
        '	If RS.BOF Then
        '		RS.MoveFirst()
        '		FromDB()
        '		Beep()
        '	Else
        '		FromDB()
        '		RS.Move(-lstClass.Items.Count + 1)
        '	End If
        '	cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
        'Dim dtrBalance As Object
        'On Error GoTo er
        'If cmdPrintAll.CheckState = 1 Then
        '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
        '	RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	RsRpt.Open("SHAPE {" & SQL & " } As Balance Compute Balance By 'Dt', 'Distractor', 'Account','Balanced'", DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.DataSource = RsRpt
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.Refresh()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.Show()
        '	cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
        'Dim dtrBalance As Object
        'On Error GoTo er
        'If cmdPrintDoc.CheckState = 1 Then
        '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
        '	RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	RsRpt.Open("Shape {Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account And DistractClass.DistDate(+)=ImportClass.DistDate " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having ImportClass.Account='" & txtAccount.Text & "' And ImportClass.Distractor='" & txtSideName.Text & "' And To_Char(ImportClass.DistDate,'YYYY')='" & txtDate.Text & "'" & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class } As Balance " & " Compute Balance By 'Dt', 'Distractor', 'Account','Balanced' ", DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.DataSource = RsRpt
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.Refresh()
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrBalance.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	dtrBalance.Show()
        '	cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
		Exit Sub
er: 
		MsgBox(Err.Description)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
		Dim Its As Object
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
		If cmdReturn.CheckState = 1 Then
			frmMain.Show()
			cmdReturn.CheckState = System.Windows.Forms.CheckState.Unchecked
			Me.Hide()
		End If
	End Sub
	
	Private Sub cmdSearch_Click()
		If Loaded = True Then
			If cmbAccount.Text <> "«·ﬂ·" Then
				If cmbSearchSide.Text = "«·ﬂ·" And cmbYear.Text <> "«·ﬂ·" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account " & " Group By ImportClass.Class, ImportClass.Unit, ImportClass.ClassID, ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having To_Char(ImportClass.DistDate,'YYYY')='" & VB.Left(cmbYear.Text, 4) & "' And ImportClass.Account='" & cmbAccount.Text & "' " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text <> "«·ﬂ·" And cmbYear.Text = "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account   " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having ImportClass.Distractor Like '%" & cmbSearchSide.Text & "%'  And ImportClass.Account='" & cmbAccount.Text & "' " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text <> "«·ﬂ·" And cmbYear.Text <> "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account " & " Group By ImportClass.Class, ImportClass.Unit, ImportClass.ClassID, DistractClass.Class, ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having ImportClass.Distractor Like '%" & cmbSearchSide.Text & "%' And To_Char(ImportClass.DistDate,'YYYY')='" & VB.Left(cmbYear.Text, 4) & "' And ImportClass.Account='" & cmbAccount.Text & "' " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text = "«·ﬂ·" And cmbYear.Text = "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account, DistractClass.Account AccountDist, NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account,DistractClass.Account, NVL(ImportClass.Balanced,'·«') " & " Having ImportClass.Account='" & cmbAccount.Text & "' " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				End If
			ElseIf cmbAccount.Text = "«·ﬂ·" Then 
				If cmbSearchSide.Text = "«·ﬂ·" And cmbYear.Text <> "«·ﬂ·" Then
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account And To_Char(ImportClass.DistDate,'YYYY')='" & VB.Left(cmbYear.Text, 4) & "'  " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text <> "«·ﬂ·" And cmbYear.Text = "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account And ImportClass.Distractor Like '%" & cmbSearchSide.Text & "%'  " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text <> "«·ﬂ·" And cmbYear.Text <> "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account And ImportClass.Distractor Like '%" & cmbSearchSide.Text & "%' And To_Char(ImportClass.DistDate,'YYYY')='" & VB.Left(cmbYear.Text, 4) & "'  " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				ElseIf cmbSearchSide.Text = "«·ﬂ·" And cmbYear.Text = "«·ﬂ·" Then 
					'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					SQL = "Select Sum(NVl(ImportClass.Ammount,0)) Imp, Sum(NVl(DistractClass.Ammount,0)) Dist, Sum(NVl(ImportClass.Ammount,0)-NVL(DistractClass.Ammount,0)) Left, ImportClass.Unit Unit, ImportClass.Class Class," & " ImportClass.ClassID ClassID, To_Char(ImportClass.DistDate,'YYYY') Dt, DistractClass.DistDate,ImportClass.Distractor Distractor, ImportClass.Account Account,NVL(ImportClass.Balanced,'·«') Balanced From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class And DistractClass.Account(+)=ImportClass.Account " & " Group By ImportClass.Class,ImportClass.Unit, ImportClass.ClassID,DistractClass.Class,ImportClass.DistDate, DistractClass.DistDate, ImportClass.Distractor, ImportClass.Account, NVL(ImportClass.Balanced,'·«') " & " Order By To_Char(ImportClass.DistDate,'YYYY'), ImportClass.Distractor, ImportClass.Class"
				End If
			End If
			'  MsgBox SQL
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
			FromDB()
		End If
	End Sub
	
	'UPGRADE_WARNING: Form event frmBalance.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmBalance_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
        'cmdRefresh.Width = Me.ClientRectangle.Width
	End Sub
	
	Private Sub frmBalance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.Balance' table. You can move, or remove it, as needed.
        Me.BalanceTableAdapter.Fill(Me.DsExplosives.Balance)
        '      Dim i As Object
        'On Error Resume Next
        'Dim cmb As New ADODB.Recordset
        'cmb = New ADODB.Recordset
        'If cmb.State = ADODB.ObjectStateEnum.adStateOpen Then cmb.Close()
        'cmb.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'cmb.Open("Select Distinct Distractor From ImportClass Order By Distractor", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbSearchSide.Items.Clear()
        'cmbYear.Items.Clear()
        'cmbSearchSide.Items.Add("«·ﬂ·")
        'cmbYear.Items.Add("«·ﬂ·")
        'cmbAccount.Items.Add("«·ﬂ·")
        'For i = 1 To cmb.RecordCount
        '	cmbSearchSide.Items.Add(cmb.Fields("DISTRACTOR").Value)
        '	cmb.MoveNext()
        'Next 
        'If cmb.State = ADODB.ObjectStateEnum.adStateOpen Then cmb.Close()
        'cmb.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'cmb.Open("Select Distinct To_Char(DistDate,'YYYY') Dt From ImportClass Order By To_Number(dt)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'For i = 1 To cmb.RecordCount
        '	cmbYear.Items.Add(cmb.Fields("Dt").Value & " / " & Val(cmb.Fields("Dt").Value) + 1)
        '	cmb.MoveNext()
        'Next 
        'If cmb.State = ADODB.ObjectStateEnum.adStateOpen Then cmb.Close()
        'cmb.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'cmb.Open("Select Distinct Account From Accounts", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'For i = 1 To cmb.RecordCount
        '	cmbAccount.Items.Add(cmb.Fields("Account").Value)
        '	cmb.MoveNext()
        'Next 
        'cmb.Close()
		Con()
		FromDB()
	End Sub
	
	Private Sub frmBalance_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        ''UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	'UPGRADE_WARNING: Event lstDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstDist.SelectedIndex) = lstDist.GetSelected(lstDist.SelectedIndex)
            End If
        Next ccontrol
    End Sub
	
	'UPGRADE_ISSUE: ListBox event lstDist.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstDist_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstDist.TopIndex
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstImp.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstImp_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstImp.SelectedIndex) = lstImp.GetSelected(lstImp.SelectedIndex)
            End If
        Next ccontrol
    End Sub
	
	'UPGRADE_WARNING: Event lstClass.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstClass_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClass.SelectedIndex) = lstClass.GetSelected(lstClass.SelectedIndex)
            End If
        Next ccontrol
    End Sub
	
	'UPGRADE_WARNING: Event lstClassID.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstClassID_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstClassID.SelectedIndex) = lstClassID.GetSelected(lstClassID.SelectedIndex)
            End If
        Next ccontrol
    End Sub
	
	'UPGRADE_WARNING: Event lstLeft.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstLeft_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstLeft.SelectedIndex) = lstLeft.GetSelected(lstLeft.SelectedIndex)
            End If
        Next ccontrol

    End Sub
	
	'UPGRADE_ISSUE: ListBox event lstLeft.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstLeft_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstLeft.TopIndex
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_WARNING: Event lstUnit.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstUnit_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim ccontrol As System.Windows.Forms.Control
        On Error Resume Next
        For Each ccontrol In Me.Controls
            'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
            If TypeName(ccontrol) = "ListBox" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstUnit.SelectedIndex) = lstUnit.GetSelected(lstUnit.SelectedIndex)
            End If
        Next ccontrol

    End Sub
	
	'UPGRADE_ISSUE: ListBox event lstImp.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstImp_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstImp.TopIndex
			End If
		Next ccontrol
	End Sub
	'UPGRADE_ISSUE: ListBox event lstClass.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstClass_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstClass.TopIndex
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_ISSUE: ListBox event lstClassID.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstClassID_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstClassID.TopIndex
			End If
		Next ccontrol
	End Sub
	
	'UPGRADE_ISSUE: ListBox event lstUnit.Scroll was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub lstUnit_Scroll()
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.TopIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.TopIndex = lstUnit.TopIndex
            End If
		Next ccontrol
	End Sub
	
	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
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
                    'If ccontorl.Enabled = True Then
                    '	'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '                   'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
                    'Else
                    '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '                   'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
                    'End If
					'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
					If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                        'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
					End If
				End If
			End If
		Next ccontrol
	End Sub
End Class