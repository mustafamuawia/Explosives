Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmWorkPermissions
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RsSideName As New ADODB.Recordset
    'Private RSdate As New ADODB.Recordset
    'Dim WorkAllowed As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
	Dim Its, SQL, SideBefore As String
	Dim Duration, dtrHaving, dtrWhere, dtrSelect, IDbefore, dtrFromSelection, dtrGroup, dtrCompute, ActvCtrl As Object
	Dim Searched, Loaded As Boolean
	Private Sub Con()
		Dim MyYear As Object
		Dim MyMonth As Object
		Dim myDay As Object
		Dim i As Object
        'DB = New ADODB.Connection
        'RS = New ADODB.Recordset
        'WorkAllowed = New ADODB.Recordset
        'RsSideName = New ADODB.Recordset
        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RsSideName.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'WorkAllowed.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'If DB.State = ADODB.ObjectStateEnum.adStateOpen Then DB.Close()
        'If RSdate.State = ADODB.ObjectStateEnum.adStateOpen Then RSdate.Close()
		'If WorkAllowed.State = adStateOpen Then WorkAllowed.Close
		SQL = "Select * from WorkPermissions Order By To_Number(To_Char(FDate, 'yyyy')) Desc, To_Number(ID) Desc"
        'DB.Open("Provider=MSDAORA.1;Password=explosives;User ID=explosives;Data Source=orcl;Persist Security Info=True")
        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        'RSdate.Open("Select Max(FDate) MaxDate ,Min(FDate) MinDate from WorkPermissions", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'RsSideName.Open("Select SideName From ImportAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'WorkAllowed.Open("Select SideName From WorkAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbsSideName.Items.Clear()
        'For i = 0 To RsSideName.RecordCount - 1
        '	cmbsSideName.Items.Add(RsSideName.Fields("SideName").Value)
        '	RsSideName.MoveNext()
        'Next 

        'Dim RsOwner As New ADODB.Recordset
        'RsOwner.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'RsOwner.Open("Select Distinct Owner From (Select Owner From WorkAllowed Union All Select Distinct Owner From WorkPermissions) Where Owner is Not Null Order By Owner ", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbOwner.Items.Clear()
        'For i = 0 To RsOwner.RecordCount - 1
        '	cmbOwner.Items.Add(RsOwner.Fields("Owner").Value)
        '	RsOwner.MoveNext()
        'Next 
        'RsOwner.Close()

        'cmbfSideName.Items.Clear()
        'For i = 0 To WorkAllowed.RecordCount - 1
        '	cmbfSideName.Items.Add(WorkAllowed.Fields("SideName").Value)
        '	WorkAllowed.MoveNext()
        'Next 

        'Dim r As New ADODB.Recordset
        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
        'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select Distinct Name From WorkPermissions Order By Name", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbName.Items.Clear()
        'For i = 1 To r.RecordCount
        '	cmbName.Items.Add(r.Fields(0).Value)
        '	r.MoveNext()
        'Next 

        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
        'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select Distinct Rank From WorkPermissions Order By Rank", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbRank.Items.Clear()
        'For i = 1 To r.RecordCount
        '	cmbRank.Items.Add(r.Fields(0).Value)
        '	r.MoveNext()
        'Next 

        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
        'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select Distinct Position From WorkPermissions Order By Position", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbPosition.Items.Clear()
        'For i = 1 To r.RecordCount
        '	cmbPosition.Items.Add(r.Fields(0).Value)
        '	r.MoveNext()
        'Next 

        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
        'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select Distinct State From Copies Order By State", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbState.Items.Clear()
        'For i = 1 To r.RecordCount
        '	cmbState.Items.Add(r.Fields(0).Value)
        '	r.MoveNext()
        'Next 

        ''UPGRADE_WARNING: Couldn't resolve default property of object myDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'myDay = VB.Day(Today)
        ''UPGRADE_WARNING: Couldn't resolve default property of object MyMonth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'MyMonth = Month(Today)
        ''UPGRADE_WARNING: Couldn't resolve default property of object MyYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'MyYear = Year(Today) - 1

        'Dim ds As New ADODB.Command
        'ds.let_ActiveConnection(DB)

        'ds.CommandText = "alter session set nls_date_format='dd/mm/yyyy'"
        'ds.Execute()

        ''UPGRADE_WARNING: Couldn't resolve default property of object MyYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object MyMonth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object myDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ds.CommandText = "Update Workpermissions Set Valid='·«' Where FDate <'" & VB6.Format(myDay & "/" & MyMonth & "/" & MyYear, "DD/MM/YYYY") & "'"
        'ds.Execute()
        'ds = New ADODB.Command
        'ds.let_ActiveConnection(DB)
        ''UPGRADE_WARNING: Couldn't resolve default property of object MyYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object MyMonth. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object myDay. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ds.CommandText = "Update Workpermissions Set Valid='‰⁄„' Where FDate >='" & VB6.Format(myDay & "/" & MyMonth & "/" & MyYear, "DD/MM/YYYY") & "'"
        'ds.Execute()
	End Sub
	
	Private Sub FromDB()
		On Error Resume Next
        'clr()
        'cmbfSideName.Text = ""
        'cmbsSideName.Text = ""
        'txtfID.Text = RS.Fields("ID").Value
        'txtFDate.Text = VB6.Format(RS.Fields("FDate").Value, "YYYY/MM/DD")
        'cmbfSideName.Text = RS.Fields("FSIDENAME").Value
        'txtSID.Text = RS.Fields("sID").Value
        'txtSDate.Text = VB6.Format(RS.Fields("SDATE").Value, "yyyy/mm/dd")
        'cmbsSideName.Text = RS.Fields("sSideName").Value
        'cmbOwner.Text = ""
        'cmbOwner.Text = RS.Fields("Owner").Value
        'txtPurpose.Text = RS.Fields("PURPOSE").Value
        'cmbState.Text = RS.Fields("State").Value
        'cmbLocation.Items.Clear()
        'cmbLocation.Items.Add((RS.Fields("Location").Value))
        'cmbLocation.Text = RS.Fields("Location").Value
        'cmbRank.Text = RS.Fields("Rank").Value
        'cmbName.Text = RS.Fields("Name").Value
        'cmbPosition.Text = RS.Fields("Position").Value
        'If RS.RecordCount > 0 Then
        '	lblPosition.Text = "0 / 0"
        '	lblPosition.Text = RS.AbsolutePosition & " / " & RS.RecordCount
        'Else
        '	lblPosition.Text = "0 / 0"
        'End If
	End Sub
	Private Sub ToDB()
		On Error Resume Next
        'RS.Fields("ID").Value = txtfID.Text
        'RS.Fields("FDate").Value = VB6.Format(txtFDate.Text, "dd/mm/yyyy")
        'RS.Fields("FSIDENAME").Value = cmbfSideName.Text
        'RS.Fields("sID").Value = txtSID.Text
        'RS.Fields("SDATE").Value = VB6.Format(txtSDate.Text, "dd/mm/yyyy")
        'RS.Fields("sSideName").Value = cmbsSideName.Text
        'RS.Fields("Owner").Value = cmbOwner.Text
        'RS.Fields("PURPOSE").Value = txtPurpose.Text
        'RS.Fields("State").Value = cmbState.Text
        'RS.Fields("Location").Value = cmbLocation.Text
        'RS.Fields("Rank").Value = cmbRank.Text
        'RS.Fields("Name").Value = cmbName.Text
        'RS.Fields("Position").Value = cmbPosition.Text
		'If Right(cmbLocation1.Text, 1) = "_" Then
		'    If cmbLocation2.Text = "" Then
		'        RS!Location1 = Left$(cmbLocation1.Text, Len(cmbLocation1.Text) - 2)
		'   Else
		'        RS!Location1 = cmbLocation1.Text
		'    End If
		'Else
		'    If cmbLocation2.Text <> "" Then RS!Location1 = cmbLocation1.Text & " _"
		'    If cmbLocation2.Text = "" Then RS!Location1 = cmbLocation1.Text
		'End If
		'If Right(cmbLocation2.Text, 1) = "_" Then
		'    If cmbLocation3.Text = "" Then
		'        RS!Location2 = Left$(cmbLocation2.Text, Len(cmbLocation2.Text) - 2)
		'   Else
		'        RS!Location2 = cmbLocation2.Text
		'    End If
		'Else
		'    If cmbLocation3.Text <> "" Then RS!Location2 = cmbLocation2.Text & " _"
		'    If cmbLocation3.Text = "" Then RS!Location2 = cmbLocation2.Text
		'End If
		'If Right(cmbLocation3.Text, 1) = "_" Then
		'    If cmbLocation4.Text = "" Then
		'        RS!Location3 = Left$(cmbLocation3.Text, Len(cmbLocation3.Text) - 2)
		'   Else
		'        RS!Location3 = cmbLocation3.Text
		'    End If
		'Else
		'    If cmbLocation4.Text <> "" Then RS!Location3 = cmbLocation3.Text & " _"
		'    If cmbLocation4.Text = "" Then RS!Location3 = cmbLocation3.Text
		'End If
	End Sub
	
	'UPGRADE_WARNING: Event cmbCriteria.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCriteria_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
		txtDate1_TextChanged(txtDate1, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbDuration.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDuration_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDuration.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Duration = " "
		If cmbDuration.Text = "⁄«„" Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) And txtDate1.Text <> txtDate2.Text Then Duration = " And ( To_CHar(WorkPermissions.fdate,'DD/MM/YYYY') <= '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And To_CHar(WorkPermissions.fdate,'DD/MM/YYYY') >='" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' Or To_Char(WorkPermissions.sdate,'DD/MM/YYYY') Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "'  And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
		ElseIf cmbDuration.Text = "› —… » «—ÌŒ «·„·›" Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) And txtDate1.Text <> txtDate2.Text Then Duration = " And ( To_CHar(WorkPermissions.fdate,'DD/MM/YYYY') <= '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And To_CHar(WorkPermissions.fdate,'DD/MM/YYYY') >='" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
		ElseIf cmbDuration.Text = "› —… » «—ÌŒ «·Œÿ«»" Then 
			'UPGRADE_WARNING: Couldn't resolve default property of object Duration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'If IsDate(txtDate1.Text) And IsDate(txtDate2.Text) And txtDate1.Text <> txtDate2.Text Then Duration = " And ( To_Char(WorkPermissions.sdate,'DD/MM/YYYY') <= '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And To_CHar(WorkPermissions.fdate,'DD/MM/YYYY') >= '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
		End If
		txtDate1_TextChanged(txtDate1, New System.EventArgs())
	End Sub
	
	Private Sub cmdCopies_Click()
		frmWorkCopies.Show()
	End Sub
	
	
	
	
	
	Private Sub cmbfSideName_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbfSideName.Leave
		Dim i As Object
		Dim x As Object
		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
		If Its = "add" Or (Its = "edit" And SideBefore <> cmbfSideName.Text) Then
			'UPGRADE_WARNING: Couldn't resolve default property of object ActvCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ActvCtrl = "cmbfSideName"
			If cmbfSideName.Text = vbNullString Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·ÃÂ… ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
				If x = MsgBoxResult.OK Then
					cmbfSideName.Focus()
				ElseIf x = MsgBoxResult.Cancel Then 
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				End If
			Else
				'   If RS.RecordCount > 0 Then
				'      RS.MoveFirst
				'      RS.Find "fSideName='" & cmbfSideName.Text & "'", 0, adSearchForward, 0
				'      If RS.EOF = False Then
				'         x = MsgBox("⁄›Ê« ! Â–Â «·ÃÂ… „ÊÃÊœ… . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì‰« Â« ø", vbExclamation + vbMsgBoxRight + vbYesNoCancel)
				'         If x = vbYes Then
				'             FromDB
				'             EnDis False, False, True
				'             Its = ""
				'             IDbefore = ""
				'         ElseIf x = vbNo Then
				'             cmbfSideName.SetFocus
				'         ElseIf x = vbacancel Then
				'             cmdCancel.Value = 1
				'         End If
				'     Else
				'    RS.Find "ID='" & IDbefore & "'", 0, adSearchBackward, RS.RecordCount
				'     End If
				' End If
				
			End If
		End If
		Dim t As String
        'Dim RsOwner As New ADODB.Recordset
        'If Its <> "" Then
        '	t = cmbOwner.Text
        '	RsOwner.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        '	RsOwner.Open("Select Distinct Owner From (Select Owner, SideName S From WorkAllowed " & "Union All " & "Select Distinct Owner, SSideName S From WorkPermissions) " & "Where S='" & cmbfSideName.Text & "' Order By Owner ", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)

        '	cmbOwner.Items.Clear()
        '	For i = 0 To RsOwner.RecordCount - 1
        '		'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        '		If Not IsDbNull(RsOwner.Fields("Owner").Value) Then cmbOwner.Items.Add(RsOwner.Fields("Owner").Value)
        '		RsOwner.MoveNext()
        '	Next 
        '	cmbOwner.Text = t
        '	RsOwner.Close()
        'End If
		
	End Sub
	
	
	'UPGRADE_WARNING: Event cmbState.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbState_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbState.SelectedIndexChanged
    
        If StateDsExplosives1.WorkCopies.Rows.Count > 0 Then

            Me.WorkCopiesTableAdapter.FillDistinctRegion(Me.LocationDsExplosives1.WorkCopies, cmbState.Text)
        End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptAll.CheckStateChanged
		Dim dtrWorkPermissions As Object
		On Error GoTo er
		If cmdRptAll.CheckState = 1 Then
			Con()
			FromDB()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.DataSource = RS
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dtrWorkPermissions.Show()
			cmdRptAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdRptAll.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRptDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptDoc.CheckStateChanged
        Dim frptWorkPermissions As New frmrptWorkPermissions()
        frptWorkPermissions.ShowDialog()
        '        Dim dtrWorkPermissions As Object
        '        On Error GoTo er
        '        'Dim rsDoc As New ADODB.Recordset
        '        'If cmdRptDoc.CheckState = 1 Then
        '        '	rsDoc = New ADODB.Recordset
        '        '	If rsDoc.State = ADODB.ObjectStateEnum.adStateOpen Then rsDoc.Close()
        '        '	rsDoc.Open("Select * From WorkPermissions Where id='" & txtfID.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrWorkPermissions.DataSource = rsDoc
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrWorkPermissions.Refresh()
        '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '        '	dtrWorkPermissions.Show()
        '        '	cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
        '        'End If
        '        Exit Sub
        'er:
        '        MsgBox(Err.Description, MsgBoxStyle.Critical)
        '        Err.Clear()
        '        cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    End Sub
	
	'UPGRADE_WARNING: Event cmdFmtFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtFound.CheckStateChanged
		Dim DataReport3 As Object
		On Error GoTo er
		If cmdFmtFound.CheckState = 1 Then
			'    Load DataEnvironment1
			'        With DataEnvironment1
			'            If .rsCommand9_Grouping.State = adStateOpen Then .rsCommand9_Grouping.Close
			'            .Commands(9).CommandType = adCmdText
			'            .Commands(9).CommandText = dtrSelect & dtrWhere & dtrGroup & dtrHaving & dtrCompute
			'            .Commands(9).Execute
			'        End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrCompute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrFromSelection. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSelect & " From " & dtrFromSelection & "  WHERE COPIES.STATE (+) = WORKPERMISSIONS.STATE And Region (+)= Location " & dtrCompute, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport3.DataSource = RsRpt
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport3.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport3.Show()
            'cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
			
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptFound.CheckStateChanged
		Dim dtrWorkPermissions As Object
		Dim x As Object
		On Error GoTo er
		If cmdRptFound.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'x = RS.AbsolutePosition
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.DataSource = RS
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.Show()
            'RS.MoveFirst()
            ''UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RS.Move(x - 1)
            'cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtAll.CheckStateChanged
		Dim DataReport3 As Object
		On Error GoTo er
		If cmdFmtAll.CheckState = 1 Then
			'    Load DataEnvironment1
			'    With DataEnvironment1
			'        If .rsCommand9_Grouping.State = adStateOpen Then .rsCommand9_Grouping.Close
			'        .Commands(9).CommandType = adCmdText
			'        DataEnvironment1.Commands(9).CommandText = dtrSelect & dtrGroup & dtrCompute
			'        DataEnvironment1.Commands(9).Execute
			'    End With
            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrCompute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'RsRpt.Open(dtrSelect & " From  WorkPermissions, Copies WHERE COPIES.STATE (+) = WORKPERMISSIONS.STATE And Region (+)= Location " & dtrCompute, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport3.DataSource = RsRpt
			'UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'DataReport3.Refresh()
			'UPGRADE_WARNING: Couldn't resolve default property of object DataReport3.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			DataReport3.Show()
			cmdFmtAll.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdFmtAll.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then

                WORKPERMISSIONSBindingSource.CancelEdit()
                'FromDB()
                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
                'cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
                'cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
                'cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
                'cmdCancel.Visible = False
                'cmdEdit.Visible = True
                'Its = ""
                '            'EnDis(False, False, True)
                'cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
            End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim x As Object
		On Error Resume Next
		If cmdDelete.CheckState = System.Windows.Forms.CheckState.Checked Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·”Ã· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
            'If x = MsgBoxResult.Yes Then
            WORKPERMISSIONSBindingSource.RemoveCurrent()
            WORKPERMISSIONSBindingSource.EndEdit()
            WORKPERMISSIONSTableAdapter.Update(Me.DsExplosives.WORKPERMISSIONS)
            MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
            '	FromDB()
            'End If
            'EnDis(False, False, True)
			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        cmdSave.Enabled = True
        cmdNew.Enabled = False
    End Sub

    'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        WORKPERMISSIONSBindingSource.MoveFirst()
        lblPosition.Text = " " + (WORKPERMISSIONSBindingSource.Position + 1).ToString + " / " + WORKPERMISSIONSBindingSource.Count.ToString

    End Sub

    'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        WORKPERMISSIONSBindingSource.MoveLast()
        lblPosition.Text = " " + (WORKPERMISSIONSBindingSource.Position + 1).ToString + " / " + WORKPERMISSIONSBindingSource.Count.ToString

    End Sub

    'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then

            WORKPERMISSIONSBindingSource.AddNew()
            cmdSave.Enabled = True
            cmdNew.Enabled = False
            IsAdd = True
            dtpFdate.Value = DateTime.Now
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
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        WORKPERMISSIONSBindingSource.MoveNext()
        lblPosition.Text = " " + (WORKPERMISSIONSBindingSource.Position + 1).ToString + " / " + WORKPERMISSIONSBindingSource.Count.ToString

    End Sub

    'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        WORKPERMISSIONSBindingSource.MovePrevious()
        lblPosition.Text = " " + (WORKPERMISSIONSBindingSource.Position + 1).ToString + " / " + WORKPERMISSIONSBindingSource.Count.ToString

    End Sub

    Private Sub cmdPrint_Click()
        Dim cmdPrint As Object
        Dim dtrWorkPermissions As Object
        'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrint.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If cmdPrint.Value = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrWorkPermissions.DataSource = RS
            'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkPermissions.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            dtrWorkPermissions.Show()
            'UPGRADE_WARNING: Couldn't resolve default property of object cmdPrint.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            cmdPrint.Value = 0
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
        frmWorkPermissions_Load(Me, New System.EventArgs())
        cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
        Its = ""
    End Sub

    'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
        If txtfID.Text <> "" Then
            Dim fPrintWorkPermission As New frmPrintWorkPermission(Convert.ToInt32(txtfID.Text))
            fPrintWorkPermission.ShowDialog()
        End If
    End Sub

    'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide() 'If cmdReturn.CheckState = 1 Then Rtn()
    End Sub
    'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        Dim x As Object
        If cmdExit.CheckState = 1 Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ «·Œ—ÊÃ ø", MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Question)
            If x = MsgBoxResult.Yes Then
                Close()
            End If
            cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub
    Dim IsAdd As Boolean = False
    'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        If IsAdd And txtWorkPermissionNo.Text = "" Then
            Dim daWorkPermissionNo As New dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter
            Dim dtWorkPermissions As New dsExplosives.WORKPERMISSIONSDataTable

            daWorkPermissionNo.FillByMaxWorkPermissionNO_Year(dtWorkPermissions, dtpFdate.Value.Year)
            If IsDBNull(dtWorkPermissions.Rows(0)("WorkPermissionNO")) Then
                txtWorkPermissionNo.Text = 1
            Else

                txtWorkPermissionNo.Text = dtWorkPermissions(0).WorkPermissionNo + 1
            End If


        End If

        'Dim n As New ADODB.Recordset
        'If cmdSave.CheckState = System.Windows.Forms.CheckState.Checked Then
        '	If Its = "add" Then RS.AddNew()
        '	ToDB()
        '	Timer1.Enabled = False
        '	ApplySettings()
        '	RS.Update()
        '	n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        '	n.Open("Select Status From Finance order By To_Number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FinanceIdx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	n.Move(FinanceIdx - 1)
        '	n.Fields("Status").Value = "≈–‰ ≈” Œœ«„"
        '	n.Update()
        WORKPERMISSIONSBindingSource.EndEdit()
        'DsExplosives.WORKPERMISSIONS.Clear()
        WORKPERMISSIONSTableAdapter.Update(DsExplosives.WORKPERMISSIONS)
        MsgBox(" „ Õ›Ÿ «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
        cmdSave.Enabled = False
        cmdNew.Enabled = True
        Dim daWorkAllowed As New dsExplosivesTableAdapters.WORKALLOWEDTableAdapter()
        If daWorkAllowed.GetDataBySideName(cmbfSideName.Text).Rows.Count = 0 Then

            daWorkAllowed.InsertSideNameSight1(cmbfSideName.Text, cmbLocation.Text)
            
        End If


        '	Con()
        '	FromDB()
        '	TextLock()
        '	Its = ""
        '	cmdCancel.Visible = False
        '	cmdDelete.Visible = True
        '	cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
        '	cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
        '	EnDis(False, False, True)
        '	'UPGRADE_WARNING: Couldn't resolve default property of object vbuncecked. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdSave.CheckState = vbuncecked
        'End If
    End Sub

    Private Sub Combo1_Change()

    End Sub

    Private Sub Command1_Click()
        'Dim dtrWorkAllowed As Object
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '      'dtrWorkAllowed.DataSource = RS
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrWorkAllowed.Show()
    End Sub

    Private Sub cmdSearchFormat_Click()

    End Sub

    Private Sub cmFound_Click()

    End Sub

    'UPGRADE_WARNING: Form event frmWorkPermissions.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmWorkPermissions_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
        'cmdRefresh.Width = Me.ClientRectangle.Width
        'MyForm = frmMain
        'If Its = "edit" Then
        '	FromDB()
        '	EnDis(False, True, False)
        'Else
        '	If Its = "add" Then
        '		EnDis(True, False, False)
        '	Else
        '		EnDis(False, False, True)
        '	End If
        'End If
    End Sub

    Private Sub frmWorkPermissions_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StateDsExplosives1.WorkCopies' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'DsExplosives.WORKPERMISSIONS' table. You can move, or remove it, as needed.
        Me.WORKPERMISSIONSTableAdapter.Fill(Me.DsExplosives.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctFSideName(Me.FSideNameDsExplosives1.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctLocation(Me.LocationDsExplosives1.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctName(Me.NameDsExplosives1.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctRank(Me.RankDsExplosives1.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctPosition(Me.PositionDsExplosives1.WORKPERMISSIONS)
        Me.WORKPERMISSIONSTableAdapter.FillDistinctState(Me.StateDsExplosives1.WORKPERMISSIONS)

        Me.WorkCopiesTableAdapter.FillDistinctState(Me.StateDsExplosives1.WorkCopies)
        If StateDsExplosives1.WorkCopies.Rows.Count > 0 Then

            Me.WorkCopiesTableAdapter.FillDistinctRegion(Me.LocationDsExplosives1.WorkCopies, StateDsExplosives1.WorkCopies(0).State)
        End If

        Dim dtrWorkAllowed As Object
        On Error Resume Next

        'UPGRADE_WARNING: Couldn't resolve default property of object dtrWorkAllowed.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrWorkAllowed.DataSource = RS
        'txtDate1.Text = VB6.Format(RSdate.Fields("MinDate").Value, "YYYY/MM/DD")
        'txtDate2.Text = VB6.Format(RSdate.Fields("MaxDate").Value, "YYYY/MM/DD")
        cmbCriteria.SelectedIndex = 0
        cmbDuration.SelectedIndex = 0
        lblPosition.Text = " " + (WORKPERMISSIONSBindingSource.Position + 1).ToString + " / " + WORKPERMISSIONSBindingSource.Count.ToString


    End Sub

    Private Sub frmWorkPermissions_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
    End Sub

    'UPGRADE_ISSUE: Frame event Frame4.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    Private Sub Frame4_DblClick()
        'MsgBox(VB6.Format(txtSDate.Text, "mm/dd/yyyy"))
    End Sub

    Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
        'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
    End Sub

    Public Sub mnuPay_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPay.Click
        cmdEdit.CheckState = System.Windows.Forms.CheckState.Checked
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

    'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        On Error Resume Next
        Dim Query As String
        If Loaded = True Then
            txtFind_TextChanged(txtFind, New System.EventArgs())
        End If
    End Sub

    'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        txtDate1_TextChanged(txtDate1, New System.EventArgs())
    End Sub


    Private Sub txtfID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtWorkPermissionNo.Leave, txtfID.Leave
        Dim Y As Object
        Dim x As Object
        On Error Resume Next
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Then
            cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            Exit Sub
        End If
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Its = "add" Or (IDbefore <> txtWorkPermissionNo.Text And Its = "edit") Then
            If txtWorkPermissionNo.Text = "" Then
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ  „ﬂ«‰ ‰„—… «·„·› ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
                If x = MsgBoxResult.Ok Then
                    txtWorkPermissionNo.Focus()
                ElseIf x = MsgBoxResult.Cancel Then
                    cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                End If
            Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("ID='" & txtfID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	If RS.EOF Then
                '		RS.MoveFirst()
                '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '		Exit Sub
                '	Else
                '		'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		Y = MsgBox("⁄›Ê« ! Â–« «·„·› „ÊÃÊœ . Â·  Êœ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
                '		If Y = MsgBoxResult.Yes Then
                '			FromDB()
                '			cmdCancel.Visible = False
                '			cmdEdit.Visible = True
                '			cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
                '			cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
                '		ElseIf Y = MsgBoxResult.No Then 
                '			txtfID.Focus()
                '		ElseIf Y = MsgBoxResult.Cancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	End If
                'End If
            End If
        End If
    End Sub

    'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
       
        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
        If cmbCriteria.Text = "⁄«„" Then
            If IsNumeric(txtFind.Text) Then
                WORKPERMISSIONSBindingSource.Filter = "WorkPermissionNo ='" & txtFind.Text & "' Or SID='" & txtFind.Text & "' or fSideName Like '%" & txtFind.Text & "%' or sSideName Like '%" & txtFind.Text & "%' "
            Else
                WORKPERMISSIONSBindingSource.Filter = "SID='" & txtFind.Text & "' or fSideName Like '%" & txtFind.Text & "%' or sSideName Like '%" & txtFind.Text & "%' "
            End If


        ElseIf cmbCriteria.Text = "‰„—… «·„·›" Then
            If IsNumeric(txtFind.Text) Then
                WORKPERMISSIONSBindingSource.Filter = "WorkPermissionNo ='" & txtFind.Text & "'"""
            End If

        ElseIf cmbCriteria.Text = " «—ÌŒ «·„·›" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object frmSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WORKPERMISSIONSBindingSource.Filter = "fDate ='" & txtFind.Text & "'"""
        ElseIf cmbCriteria.Text = " «—ÌŒ «·Œÿ«»" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object frmSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WORKPERMISSIONSBindingSource.Filter = "sDate ='" & txtFind.Text & "'"""
        ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„√–Ê‰ ·Â«" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object frmSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WORKPERMISSIONSBindingSource.Filter = "fSideName Like '%" & txtFind.Text & "%'"
        ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„Œ«ÿ»…" Then
            'UPGRADE_WARNING: Couldn't resolve default property of object frmSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            WORKPERMISSIONSBindingSource.Filter = "sSideName Like '%" & txtFind.Text & "%'"
        End If

    End Sub

    Private Sub txtFind_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.Enter
        'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Not IsDBNull(txtWorkPermissionNo.Text) Then IDbefore = txtWorkPermissionNo.Text
    End Sub

    'UPGRADE_WARNING: Event cmbPosition.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    'UPGRADE_WARNING: ComboBox event cmbPosition.Change was upgraded to cmbPosition.TextChanged which has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="DFCDE711-9694-47D7-9C50-45A99CD8E91E"'
    Private Sub cmbPosition_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbPosition.TextChanged
        'If Len(cmbPosition.Text) > 70 Then
        '    MsgBox("·ﬁœ  Ã«Ê“  «·Õœ «·„”„ÊÕ »Â „‰ Õ—Ê› (35 Õ—›)", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
        '    cmbPosition.SelectionStart = 0
        '    cmbPosition.SelectionLength = 35
        '    cmbPosition.Text = cmbPosition.SelectedText
        '    cmbPosition.SelectionStart = 35
        'End If
    End Sub

    Private Sub cmbfSideName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbfSideName.SelectedIndexChanged
       
    End Sub

    Private Sub cmbLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocation.SelectedIndexChanged

    End Sub
End Class