Option Strict Off
Option Explicit On
Friend Class frmOurRecentImport
	Inherits System.Windows.Forms.Form
	
    'Private rsDist As New ADODB.Recordset
    'Private rsImp As New ADODB.Recordset
    'Private RS As New ADODB.Recordset
    'Private RSreceiver As New ADODB.Recordset
    'Private RsImpDist As New ADODB.Recordset
    'Private RSaccount As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
	Private SQLimp As String
	Private SQLDist As String
	Private Searched As Boolean
	Private Records, rsSQL3, rsSQL1, dtrWhere, dtrSQL3, dtrSQL1, dtrSQL2, dtrSQL, dtrHaving, rsSQL2, rsSQL, Moves As Object
	Private Function Con() As Object
		Dim i As Object
        'Dim r As New ADODB.Recordset
        'r.Open("Select Max(DistDate) mx, Min(DistDate) nx From ImportClass", DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        'txtDate2.Text = VB6.Format(r.Fields("MX").Value, "YYYY/MM/DD")
        'txtDate1.Text = VB6.Format(r.Fields("Nx").Value, "YYYY/MM/DD")
        'r.Close()
        'RS = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        ''UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'rsSQL = rsSQL1 & rsSQL2 & rsSQL3
        'RS.Open(rsSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
		
		'__________________________________________________________________________________
		
        'RSreceiver = New ADODB.Recordset
        'If RSreceiver.State = ADODB.ObjectStateEnum.adStateOpen Then RSreceiver.Close()
        'RSreceiver.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RSreceiver.Open("Select SideName From WorkAllowed", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbReceiver.Items.Clear()
        'cmbReceiver.Items.Add("����")
        'cmbReceiver.Items.Add("���� ������� � �������")
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
		cmbAccount.Items.Add("����")
        'For i = 1 To RSaccount.RecordCount
        '      cmbAccount.Items.Add(RSaccount.Fields("Account").Value)
        '      RSaccount.MoveNext()
        'Next 
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
		txtDistractor.Text = ""
		txtReceiver.Text = ""
		txtAccount.Text = ""
		lstAmmountStr.Items.Clear()
		lstUnitStr.Items.Clear()
		lstClassStr.Items.Clear()
		lstClassIDStr.Items.Clear()
        'txtDistractor.Text = RS.Fields("ImpDistractor").Value
        'txtReceiver.Text = RS.Fields("ImpReceiver").Value
        'txtAccount.Text = RS.Fields("ImpAccount").Value
        'rsImp = New ADODB.Recordset
        'If rsImp.State = ADODB.ObjectStateEnum.adStateOpen Then rsImp.Close()
        'rsImp.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'rsImp.Open("Select * From (" & rsSQL & ") Where ImpReceiver='" & txtReceiver.Text & "' AND ImpDistractor='" & txtDistractor.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
		
        'lblPosition.Text = RS.RecordCount & "/" & RS.AbsolutePosition
		
        'For i = 1 To rsImp.RecordCount

        '   If Not IsNull(RS!DisAmmount) Then
        '       lstAmmountDist.AddItem RS!DisAmmount
        '   Else
        '       lstAmmountDist.AddItem ""
        '   End If
        '   If Not IsNull(RS!DisUnit) Then
        '       lstUnitDist.AddItem RS!DisUnit
        '   Else
        '       lstUnitDist.AddItem ""
        '   End If
        '   If Not IsNull(RS!DisClass) Then
        '       lstClassDist.AddItem RS!DisClass
        '   Else
        '       lstClassDist.AddItem ""
        '   End If
        '   If Not IsNull(RS!DisClassId) Then
        '       lstClassIDDist.AddItem RS!DisClassId
        '   Else
        '       lstClassIDDist.AddItem ""
        '   End If
        '   If Not IsNull(RS!DisRecord) Then
        '       lstRecordDist.AddItem RS!DisRecord
        '   Else
        '       lstRecordDist.AddItem ""
        '   End If
        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '      If Not IsDBNull(rsImp.Fields("ImpAmmount").Value) Then
        '          lstAmmountStr.Items.Add(rsImp.Fields("ImpAmmount").Value)
        '      Else
        '          lstAmmountStr.Items.Add("")
        '      End If
        '      'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '      If Not IsDBNull(rsImp.Fields("ImpUnit").Value) Then
        '          lstUnitStr.Items.Add(rsImp.Fields("ImpUnit").Value)
        '      Else
        '          lstUnitStr.Items.Add("")
        '      End If
        '      'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '      If Not IsDBNull(rsImp.Fields("impClass").Value) Then
        '          lstClassStr.Items.Add(rsImp.Fields("impClass").Value)
        '      Else
        '          lstClassStr.Items.Add("")
        '      End If
        '      'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '      If Not IsDBNull(rsImp.Fields("ImpClassID").Value) Then
        '          lstClassIDStr.Items.Add(rsImp.Fields("ImpClassID").Value)
        '      Else
        '          lstClassIDStr.Items.Add("")
        '      End If
        '      rsImp.MoveNext()
        'Next 
	End Function
	
	Private Sub cmbImporter_Click()
		Dim SQL As Object
        'RS = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		SQL = "Select ImportClass.Distractor ImpDistractor, sum(ImportClass.Ammount) ImpAmmount, ImportClass.Unit impUnit, ImportClass.Class as ImpClass," & " NVL(ImportClass.ClassID,'-') impClassID," & " sum(DistractClass.Ammount) DisAmmount, DistractClass.Unit DisUnit, DistractClass.Class as DisClass," & " DistractClass.ClassID DisClassId" & " From ImportClass, DistractClass" & " Where DistractClass.Class(+)=ImportClass.Class" & " Group By (ImportClass.Distractor, ImportClass.Class,ImportClass.Unit, DistractClass.Class, DistractClass.Unit," & " ImportClass.ClassID, DistractClass.ClassID)" & " Order By ImportClass.Distractor, DistractClass.Class, ImportClass.Class"
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
		If chkAll.CheckState = 1 And cmbSearch.Text <> "���" Then txtFind.Text = "����"
	End Sub
	
	'UPGRADE_WARNING: Event chkReceiver.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chkReceiver_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chkReceiver.CheckStateChanged
		If chkReceiver.CheckState = 1 Then cmbReceiver.Text = "����"
	End Sub
	
	'UPGRADE_WARNING: Event cmbAccount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbAccount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAccount.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbReceiver.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbReceiver_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbReceiver.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
		If cmbReceiver.Text = "����" Then
			chkReceiver.CheckState = System.Windows.Forms.CheckState.Checked
		Else
			chkReceiver.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbSearch.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbSearch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
		If cmbSearch.Text = "��� ����� �������" Then
			cmbReceiver.Enabled = True
			lblDistractor.Visible = False
			lblReceiver.Visible = True
			chkAll.Enabled = True
			chkReceiver.Enabled = True
		ElseIf cmbSearch.Text = "��� ����� ��������" Then 
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
			x = MsgBox("�� ��� �����/� �� ��� ����/�� ������ �", MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Question)
			If x = MsgBoxResult.Yes Then End
			cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
		On Error Resume Next
		If cmdNext.CheckState = 1 Then
            'RS.Move(rsImp.RecordCount)
            'If RS.EOF Then
            '	RS.Move(-rsImp.RecordCount)
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
			ToLists()
            'RS.MoveNext()
            'RS.Move(-rsImp.RecordCount)
            'If RS.BOF Then
            '	RS.MoveFirst()
            '	Beep()
            'End If
            'ToLists()
            'cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	
	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
		Dim dtrRecentImport As Object
		On Error GoTo er
		If cmdFound.CheckState = 1 Then
			txtFind_TextChanged(txtFind, New System.EventArgs())
			'  Load DataEnvironment1
			'  With DataEnvironment1
			'      If .rsCommand5_Grouping.State = adStateOpen Then .rsCommand5_Grouping.Close
			'      .Commands(5).CommandText = dtrSQL
			'      .Commands(5).Execute
			'  End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'RsRpt.Open(dtrSQL, DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.DataSource = RsRpt
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.Sections(1).Controls("lblDuration").Caption = "�� ������ �� " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD�") & " ����� " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD�")
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Show()
			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
		Dim dtrRecentImport As Object
		On Error GoTo er
		If cmdPrintAll.CheckState = 1 Then
			'   Load DataEnvironment1
			'   With DataEnvironment1
			'       If .rsCommand5_Grouping.State = adStateOpen Then .rsCommand5_Grouping.Close
			'       .Commands(5).CommandText = dtrSQL1 & dtrSQL2 & dtrSQL3
			'       .Commands(5).Execute
			'   End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSQL1 & dtrSQL2 & dtrSQL3, DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.DataSource = RsRpt
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.Sections(1).Controls("lblDuration").Caption = "�� ������ �� " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD�") & " ����� " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD�")
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Show()
			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
		Dim dtrRecentImport As Object
		On Error GoTo er
		If cmdPrintDoc.CheckState = 1 Then
			' Load DataEnvironment1
			' With DataEnvironment1
			'     If .rsCommand5_Grouping.State = adStateOpen Then .rsCommand5_Grouping.Close
			'     .Commands(5).CommandText = dtrSQL1 & " Where Distractor='" & txtDistractor.Text & "' And Receiver='" & txtReceiver.Text & "' " & dtrSQL2 & dtrHaving & dtrSQL3
			'     MsgBox dtrSQL
			'     .Commands(5).Execute
			' End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSQL1 & " Where Distractor='" & txtDistractor.Text & "' And Receiver='" & txtReceiver.Text & "' " & dtrSQL2 & dtrHaving & dtrSQL3, DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.DataSource = RsRpt
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrRecentImport.Sections(1).Controls("lblDuration").Caption = "�� ������ �� " & VB6.Format(txtDate1.Text, "DDDD YYYY/MM/DD�") & " ����� " & VB6.Format(txtDate2.Text, "DDDD YYYY/MM/DD�")
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrRecentImport.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrRecentImport.Show()
			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
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
	
	'UPGRADE_WARNING: Form event frmOurRecentImport.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmOurRecentImport_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		cmdRefresh.Width = Me.ClientRectangle.Width
        'LoadAllSettings()
        'ApplySettings()
	End Sub
	
	Private Sub frmOurRecentImport_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim Serched As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL1 = "SELECT SUM(AMMOUNT) AS IMPAMMOUNT, UNIT AS IMPUNIT, CLASS AS IMPCLASS, NVL(ClassID,'�����') AS IMPCLASSID, DISTRACTOR AS IMPDISTRACTOR, RECEIVER AS IMPRECEIVER, ACCOUNT AS IMPACCOUNT, DistDate FROM IMPORTCLASS "
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL2 = " GROUP BY ACCOUNT, Class, UNIT, ClassID, DISTRACTOR, RECEIVER, DistDate "
		'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		rsSQL3 = " ORDER BY account, distractor, receiver, class, unit"
		
		Con()
		ToLists()
		'UPGRADE_WARNING: Couldn't resolve default property of object Serched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Serched = False
		cmbSearch.SelectedIndex = 0
		cmbReceiver.Text = "����"
		cmbAccount.SelectedIndex = 0
		Searched = True
		
		'* * * *  * * * * * * * * *    * * *  **      ****      **      **     **        **       **
		
		
		'* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ****************************
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL1 = "SHAPE {SELECT SUM(AMMOUNT) AS IMPAMMOUNT, UNIT AS IMPUNIT, CLASS AS IMPCLASS, DISTRACTOR AS IMPDISTRACTOR, " & "RECEIVER AS IMPRECEIVER, ACCOUNT AS IMPACCOUNT, DistDate FROM IMPORTCLASS "
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL2 = " GROUP BY ACCOUNT, Class, UNIT, DISTRACTOR, RECEIVER, DistDate "
		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dtrSQL3 = " ORDER BY account, distractor, receiver, class, unit} AS Command5 COMPUTE Command5 BY 'IMPDISTRACTOR','IMPRECEIVER','IMPACCOUNT'"
	End Sub
	
	Private Sub isButton1_Click()
		
	End Sub
	
	Private Sub frmOurRecentImport_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        ''UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	'UPGRADE_ISSUE: Frame event Frame1.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Frame1_DblClick()
		MsgBox(rsSQL)
	End Sub
	
	'UPGRADE_WARNING: Event lstAmmountDist.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub lstAmmountDist_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstAmmountDist.SelectedIndexChanged
		Dim ccontrol As System.Windows.Forms.Control
		On Error Resume Next
		For	Each ccontrol In Me.Controls
			'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			If TypeName(ccontrol) = "ListBox" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object ccontrol.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'ccontrol.Selected(lstAmmountDist.SelectedIndex) = lstAmmountDist.GetSelected(lstAmmountDist.SelectedIndex)
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
                    ''ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
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
		If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate2.TextChanged
		If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
		If Searched = True Then
			If txtFind.Text <> "" Then chkAll.CheckState = System.Windows.Forms.CheckState.Unchecked
			If txtFind.Text = "����" Then chkAll.CheckState = System.Windows.Forms.CheckState.Checked
			If cmbSearch.Text = "���" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where Class Like '%" & txtFind.Text & "%' Or Account Like '%" & txtFind.Text & "%' Or Distractor Like '%" & txtFind.Text & "%' Or Receiver Like '%" & txtFind.Text & "%' "
			ElseIf cmbSearch.Text = "��� ����� �������" Then 
				If txtFind.Text = "����" Then
					If cmbReceiver.Text = "����" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = ""
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Receiver Like '%" & cmbReceiver.Text & "%'"
					End If
				Else
					If cmbReceiver.Text = "����" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = "Where Distractor Like '%" & txtFind.Text & "%'"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Distractor Like '%" & txtFind.Text & "%' And Receiver Like '%" & cmbReceiver.Text & "%'"
					End If
				End If
			ElseIf cmbSearch.Text = "��� ����� ��������" Then 
				If txtFind.Text = "����" Then
					If cmbReceiver.Text = "����" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = ""
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Distractor Like '%" & cmbReceiver.Text & "%'"
					End If
				Else
					If cmbReceiver.Text = "����" Then
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = "Where Receiver Like '%" & txtFind.Text & "%'"
					Else
						'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						dtrWhere = " Where Receiver Like '%" & txtFind.Text & "%' And Distractor Like '%" & cmbReceiver.Text & "%'"
					End If
				End If
				
			End If
			If cmbAccount.Text = "����" Then
				If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'dtrHaving = " Having DistDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dtrHaving = " "
				End If
			Else
				If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'dtrHaving = " Having DistDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' And Account='" & cmbAccount.Text & "'"
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dtrHaving = " Having Account='" & cmbAccount.Text & "'"
				End If
			End If
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrSQL = dtrSQL1 & dtrWhere & dtrSQL2 & dtrHaving & dtrSQL3
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL3. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object rsSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rsSQL = rsSQL1 & dtrWhere & rsSQL2 & dtrHaving & rsSQL3
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
            'RS.Open(rsSQL, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)
			ToLists()
		End If
	End Sub
End Class