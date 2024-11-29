Option Strict Off
Option Explicit On
Friend Class frmOurDistract
	Inherits System.Windows.Forms.Form
    '	Dim mYear, ListNew, Y1, ListExist, IDbefore, Searched As Object
    '    'Private RS As New ADODB.Recordset
    '    'Private RS2 As New ADODB.Recordset
    '    'Private Rs3 As New ADODB.Recordset
    '    'Private Rs4 As New ADODB.Recordset
    '    'Private RsRpt As New ADODB.Recordset
    '	Private SQL2, SQL, Its As String
    '	Private dtrSQL2, dtrsql0, MyField As Object
    '	Private sht As Boolean
    '	Private Sub myclr()
    '		'On Error Resume Next
    '        'clr()
    '        'cmbAccount.Text = ""
    '        'cmbDistractor.Text = ""
    '        'cmbReceiver.Text = ""
    '        'lstAmmount.Items.Clear()
    '        'lstUnit.Items.Clear()
    '        'lstClass.Items.Clear()
    '        'lstClassID.Items.Clear()
    '        'lstRecord.Items.Clear()
    '	End Sub
    '	Private Sub Con()
    '        'Dim i As Object
    '        'On Error Resume Next
    '        'RS = New ADODB.Recordset
    '        'Rs4 = New ADODB.Recordset
    '        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '        'If Rs4.State = ADODB.ObjectStateEnum.adStateOpen Then Rs4.Close()
    '        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'Rs4.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'SQL = "select * from OurDistract order by DistDate, To_Number(ID)"
    '        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        'Rs4.Open("Select Account From Accounts Order By Account", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        'cmbAccount.Items.Clear()
    '        'For i = 0 To Rs4.RecordCount - 1
    '        '	cmbAccount.Items.Add(Rs4.Fields("Account").Value)
    '        '	Rs4.MoveNext()
    '        'Next 
    '	End Sub
    '	Private Sub ConList()
    '        'On Error Resume Next
    '        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
    '        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'If RS.RecordCount = 0 Then
    '        '	SQL2 = "Select * From DistractClass"
    '        'Else
    '        '	SQL2 = "Select * from DistractClass where fid='" & RS.Fields("ID").Value & "'"
    '        'End If
    '        'RS2.Open(SQL2, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic, ADODB.CommandTypeEnum.adCmdText)
    '	End Sub
    '	Private Sub FromDB()
    '        'On Error Resume Next
    '        'myclr()
    '        'txtID.Text = RS.Fields("ID").Value
    '        'cmbAccount.Text = RS.Fields("Account").Value
    '        'txtDuration.Text = RS.Fields("Duration").Value
    '        'txtStationDist.Text = RS.Fields("STATIONDIST").Value
    '        'cmbDistractor.Text = RS.Fields("DISTRACTOR").Value
    '        'txtStationRec.Text = RS.Fields("STATIONREC").Value
    '        'cmbReceiver.Text = RS.Fields("Receiver").Value
    '        'txtConsignment.Text = RS.Fields("CONSIGNMENT").Value
    '        'txtDate.Text = VB6.Format(RS.Fields("DistDate").Value, "YYYY/MM/DD")
    '        'txtPolicyID.Text = RS.Fields("POLICYID").Value
    '        'txtNotes.Text = RS.Fields("NOTES").Value
    '        'txtInstructions.Text = RS.Fields("INSTRUCTIONS").Value
    '        'txtDistractAutherity.Text = RS.Fields("DISTRACTAUTHERITY").Value
    '        'txtDistRank.Text = RS.Fields("Rank").Value
    '        'txtDistSignature.Text = RS.Fields("DISTSIGNATURE").Value
    '        'txtDisAdoption.Text = RS.Fields("DISTADOPTION").Value
    '        'txtRecAutherity.Text = RS.Fields("RECAUTHERITY").Value
    '        'txtRecRank.Text = RS.Fields("RECRANK").Value
    '        'txtRecName.Text = RS.Fields("RECNAME").Value
    '        'txtDistName.Text = RS.Fields("DISTNAME").Value
    '        'txtRecSignature.Text = RS.Fields("RECSIGNATURE").Value
    '        'txtRecAdoption.Text = RS.Fields("RECADOPTION").Value
    '        'ConList()
    '        'ToList()
    '	End Sub
    '	Private Sub ToDB()
    '        'On Error Resume Next
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtID.Text) Then RS.Fields("ID").Value = txtID.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(cmbAccount.Text) Then RS.Fields("Account").Value = cmbAccount.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDuration.Text) Then RS.Fields("Duration").Value = txtDuration.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtStationDist.Text) Then RS.Fields("STATIONDIST").Value = txtStationDist.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(cmbDistractor.Text) Then RS.Fields("DISTRACTOR").Value = cmbDistractor.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtStationRec.Text) Then RS.Fields("STATIONREC").Value = txtStationRec.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(cmbReceiver.Text) Then RS.Fields("Receiver").Value = cmbReceiver.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtConsignment.Text) Then RS.Fields("CONSIGNMENT").Value = txtConsignment.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDate.Text) Then RS.Fields("DistDate").Value = txtDate.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtPolicyID.Text) Then RS.Fields("POLICYID").Value = txtPolicyID.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtNotes.Text) Then RS.Fields("NOTES").Value = txtNotes.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtInstructions.Text) Then RS.Fields("INSTRUCTIONS").Value = txtInstructions.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDistractAutherity.Text) Then RS.Fields("DISTRACTAUTHERITY").Value = txtDistractAutherity.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDistRank.Text) Then RS.Fields("Rank").Value = txtDistRank.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDistSignature.Text) Then RS.Fields("DISTSIGNATURE").Value = txtDistSignature.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDisAdoption.Text) Then RS.Fields("DISTADOPTION").Value = txtDisAdoption.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtRecAutherity.Text) Then RS.Fields("RECAUTHERITY").Value = txtRecAutherity.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtRecRank.Text) Then RS.Fields("RECRANK").Value = txtRecRank.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtRecName.Text) Then RS.Fields("RECNAME").Value = txtRecName.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtDistName.Text) Then RS.Fields("DISTNAME").Value = txtDistName.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtRecSignature.Text) Then RS.Fields("RECSIGNATURE").Value = txtRecSignature.Text
    '        ''UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        'If Not IsDbNull(txtRecAdoption.Text) Then RS.Fields("RECADOPTION").Value = txtRecAdoption.Text
    '        'FromList()
    '	End Sub
    '	Private Sub FromList()
    '        'Dim i As Object
    '        'On Error Resume Next
    '        'Dim cmd As New ADODB.Command
    '        'If Its = "edit" Then
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	cmd.CommandText = "Delete From DistractClass Where fid='" & IDbefore & "'"
    '        '	cmd.let_ActiveConnection(DB)
    '        '	cmd.Execute()
    '        'End If
    '        'For i = 0 To lstAmmount.Items.Count - 1
    '        '	RS2.AddNew()
    '        '	RS2.Fields("FID").Value = txtID.Text
    '        '	RS2.Fields("Ammount").Value = VB6.GetItemString(lstAmmount, i)
    '        '	RS2.Fields("Unit").Value = VB6.GetItemString(lstUnit, i)
    '        '	RS2.Fields("Class").Value = VB6.GetItemString(lstClass, i)
    '        '	RS2.Fields("ClassID").Value = VB6.GetItemString(lstClassID, i)
    '        '	RS2.Fields("Record").Value = VB6.GetItemString(lstRecord, i)
    '        '	RS2.Fields("DISTRACTOR").Value = cmbDistractor.Text
    '        '	RS2.Fields("Receiver").Value = cmbReceiver.Text
    '        '	RS2.Fields("Account").Value = cmbAccount.Text
    '        '	RS2.Fields("DistDate").Value = txtDate.Text
    '        '	RS2.Update()
    '        'Next 
    '	End Sub
    '	Private Sub ToList()
    '        'Dim i As Object
    '        'On Error Resume Next
    '        'For i = 1 To RS2.RecordCount
    '        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        '	If Not IsDbNull(RS2.Fields("Ammount").Value) Then
    '        '		lstAmmount.Items.Add(RS2.Fields("Ammount").Value)
    '        '	Else
    '        '		lstAmmount.Items.Add("")
    '        '	End If
    '        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        '	If Not IsDbNull(RS2.Fields("Unit").Value) Then
    '        '		lstUnit.Items.Add(RS2.Fields("Unit").Value)
    '        '	Else
    '        '		lstUnit.Items.Add("")
    '        '	End If
    '        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        '	If Not IsDbNull(RS2.Fields("Class").Value) Then
    '        '		lstClass.Items.Add(RS2.Fields("Class").Value)
    '        '	Else
    '        '		lstClass.Items.Add("")
    '        '	End If
    '        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        '	If Not IsDbNull(RS2.Fields("ClassID").Value) Then
    '        '		lstClassID.Items.Add(RS2.Fields("ClassID").Value)
    '        '	Else
    '        '		lstClassID.Items.Add("")
    '        '	End If
    '        '	'UPGRADE_WARNING: Use of Null/IsNull() detected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"'
    '        '	If Not IsDbNull(RS2.Fields("Record").Value) Then
    '        '		lstRecord.Items.Add(RS2.Fields("Record").Value)
    '        '	Else
    '        '		lstRecord.Items.Add("")
    '        '	End If
    '        '	RS2.MoveNext()
    '        'Next 
    '        'RS2.MoveFirst()
    '	End Sub
    '	Private Sub FillClass()
    '		Dim i As Object
    '		On Error Resume Next
    '        'Rs3.MoveFirst()
    '        'cmbClass.Items.Clear()
    '        'For i = 0 To Rs3.RecordCount - 1
    '        '	cmbClass.Items.Add(Rs3.Fields("Class").Value)
    '        '	Rs3.MoveNext()
    '        'Next 
    '	End Sub

    '	Private Sub cmbAccount_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbAccount.Leave
    '        'Dim f As Object
    '        'Dim MyCtrl As Object
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'MyCtrl = "cmbAccount"
    '        ''UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '        'If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '        'If Its = "add" Or Its = "edit" Then
    '        '	If cmbAccount.Text = "" Or cmbAccount.Text = " " Or cmbAccount.Text = "  " Then
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		f = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·Õ”«» ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '        '		If f = MsgBoxResult.OK Then
    '        '			cmbAccount.Focus()
    '        '		ElseIf f = MsgBoxResult.Cancel Then 
    '        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '        '		End If
    '        '	Else
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		MyCtrl = ""
    '        '	End If
    '        'End If
    '	End Sub

    '	Private Sub cmbClass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress
    '        'Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '        'If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
    '        'eventArgs.KeyChar = Chr(KeyAscii)
    '        'If KeyAscii = 0 Then
    '        '	eventArgs.Handled = True
    '        'End If
    '	End Sub


    '	Private Sub cmbDistractor_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDistractor.Leave
    '		Dim MyCtrl As Object
    '		Dim x As Object
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "txtStationDist" Then Exit Sub
    '		If Its = "add" Or Its = "edit" Then
    '			If cmbDistractor.Text = "" Or cmbDistractor.Text = " " Or cmbDistractor.Text = "  " Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·ÊÕœ… «·’«—›… ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					cmbDistractor.Focus()
    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '				'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				MyCtrl = ""
    '			End If
    '		End If
    '	End Sub


    '	Private Sub cmbReceiver_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbReceiver.Leave
    '		Dim x As Object
    '		Dim MyCtrl As Object
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If MyCtrl <> "" Then Exit Sub
    '		If Its = "add" Or Its = "edit" Then
    '			If cmbReceiver.Text = "" Or cmbReceiver.Text = " " Or cmbReceiver.Text = "  " Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·ÃÂ… «·„” ·„… ›«—€« ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then

    '					cmbReceiver.Focus()

    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '				'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				MyCtrl = ""
    '			End If
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmbSearch.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmbSearch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If cmbSearch.Text = "‰„—… «·„” ‰œ" Then MyField = "OurDistract.ID='" & txtFind.Text & "'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If cmbSearch.Text = "«·Õ”«»" Then MyField = "OurDistract.Account Like '%" & txtFind.Text & "%'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If cmbSearch.Text = "«·ÊÕœ… «·’«—›…" Then MyField = "OurDistract.Distractor Like '%" & txtFind.Text & "%'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If cmbSearch.Text = "«·ÊÕœ… «·„” ·„…" Then MyField = "OurDistract.Receiver Like '%" & txtFind.Text & "%'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'If cmbSearch.Text = " «—ÌŒ «·’—›" Then MyField = " OurDistract.distDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'If cmbSearch.Text = "› —…  «—ÌŒÌ…" Then MyField = " OurDistract.distDate >='" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And OurDistract.distDate<='" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "'"
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If cmbSearch.Text = "" Then MyField = ""
    '	End Sub

    '	Private Sub cmbUnit_Enter(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbUnit.Enter
    '		Dim i As Object
    '		On Error Resume Next
    '		If cmbUnit.Text = vbNullString Then
    '            'Rs3 = New ADODB.Recordset
    '            'If Rs3.State = ADODB.ObjectStateEnum.adStateOpen Then Rs3.Close()
    '            'Rs3.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            'Rs3.Open("Select Distinct Unit From Classes Where Account='" & cmbAccount.Text & "' Order By Unit", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '            'cmbUnit.Items.Clear()
    '            'For i = 0 To Rs3.RecordCount - 1
    '            '	cmbUnit.Items.Add(Rs3.Fields("Unit").Value)
    '            '	Rs3.MoveNext()
    '            'Next 
    '		End If
    '	End Sub
    '	Private Sub cmbUnit_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmbUnit.KeyDown
    '		Dim KeyCode As Short = eventArgs.KeyCode
    '		Dim Shift As Short = eventArgs.KeyData \ &H10000
    '		If KeyCode = 16 Then sht = True
    '	End Sub

    '	Private Sub cmbUnit_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles cmbUnit.KeyPress
    '		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '		If sht = True And KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
    '		sht = False
    '		eventArgs.KeyChar = Chr(KeyAscii)
    '		If KeyAscii = 0 Then
    '			eventArgs.Handled = True
    '		End If
    '	End Sub

    '	Private Sub cmbUnit_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles cmbUnit.KeyUp
    '		Dim KeyCode As Short = eventArgs.KeyCode
    '		Dim Shift As Short = eventArgs.KeyData \ &H10000
    '		If KeyCode = 16 Then sht = False
    '	End Sub

    '	Private Sub cmbUnit_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbUnit.Leave
    '		Dim SqlQ As Object
    '		On Error Resume Next
    '		If Not cmbUnit.Text = "" Then
    '            'Rs3 = New ADODB.Recordset
    '            'If Rs3.State = ADODB.ObjectStateEnum.adStateOpen Then Rs3.Close()
    '            'Rs3.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object SqlQ. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'SqlQ = "Select Distinct Class From Classes Where Unit='" & cmbUnit.Text & "' And Account='" & cmbAccount.Text & "' And Class In (Select Class From ImportClass Where Distractor ='" & cmbDistractor.Text & "')"
    '            'Rs3.Open(SqlQ, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '			FillClass()
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
    '		Dim x As Object
    '		If cmdExit.CheckState = 1 Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ «·Œ—ÊÃ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
    '			If x = MsgBoxResult.Yes Then End
    '			cmdExit.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFindNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFindNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindNext.CheckStateChanged
    '		On Error Resume Next
    '		If cmdFindNext.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'RS.MoveNext()
    '            'If RS.EOF Then
    '            '	RS.MoveLast()
    '            '	Beep()
    '            'End If
    '			FromDB()
    '			cmdFindNext.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFindPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFindPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFindPrev.CheckStateChanged
    '		On Error Resume Next
    '		If cmdFindPrev.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'RS.MovePrevious()
    '            'If RS.BOF Then
    '            '	RS.MoveFirst()
    '            '	Beep()
    '            'End If
    '			FromDB()
    '			cmdFindPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
    '		Dim dtrDistract As Object
    '		On Error GoTo er
    '		If cmdFound.CheckState = 1 Then
    '			' Load DataEnvironment1
    '			' With DataEnvironment1
    '			'     If .rsDistract_Grouping.State = adStateOpen Then .rsDistract_Grouping.Close
    '			'     .Commands(8).CommandText = dtrsql0 & "And " & MyField & " " & dtrSQL2
    '			'     .Commands(8).Execute
    '			' End With
    '            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
    '            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrsql0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RsRpt.Open(dtrsql0 & " And " & MyField & " " & dtrSQL2, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.DataSource = RsRpt
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Refresh()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Show()
    '            'cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description, MsgBoxStyle.Critical)
    '		Err.Clear()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdMinus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdMinus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdMinus.CheckStateChanged
    '		On Error Resume Next
    '		lstAmmount.Items.RemoveAt((lstAmmount.SelectedIndex))
    '		lstUnit.Items.RemoveAt((lstUnit.SelectedIndex))
    '		lstClass.Items.RemoveAt((lstClass.SelectedIndex))
    '		lstClassID.Items.RemoveAt((lstClassID.SelectedIndex))
    '		lstRecord.Items.RemoveAt((lstRecord.SelectedIndex))
    '	End Sub
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

    'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
        Dim x As Object
        On Error Resume Next
        If cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
            If x = MsgBoxResult.Yes Then
                OURDISTRACTBindingSource.CancelEdit()
                IsAdd = False

                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
                DisableSave()
            End If
            cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
        End If
    End Sub

    '	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
    '		Dim x As Object
    '		'On Error Resume Next
    '        'Dim cmd As New ADODB.Command
    '		If cmdDelete.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·„” ‰œ« ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
    '			If x = MsgBoxResult.Yes Then
    '                'RS.Delete()
    '                'cmd.let_ActiveConnection(DB)
    '                'cmd.CommandType = ADODB.CommandTypeEnum.adCmdText
    '                'cmd.CommandText = "Delete From OurDistract Where ID='" & txtID.Text & "'"
    '                'cmd.Execute()

    '                'cmd.CommandText = "Delete From DistractClass Where FID='" & txtID.Text & "'"
    '                'cmd.Execute()
    '				MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
    '			End If
    '			Con()
    '			FromDB()
    '            'EnDis(False, False, True)
    '			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
    '		On Error Resume Next
    '		If cmdEdit.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'TextUnLock()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			IDbefore = txtID.Text
    '			'UPGRADE_WARNING: Couldn't resolve default property of object mYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'mYear = RS.Fields("DistDate").Value
    '			Its = "edit"
    '            'EnDis(False, True, False)
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
    '		On Error Resume Next
    '		If cmdFirst.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			If Searched = True Then
    '				Con()
    '				'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				Searched = False
    '			End If
    '            'RS.MoveFirst()
    '			Beep()
    '			FromDB()
    '			cmdFirst.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
    '		On Error Resume Next
    '		If cmdLast.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			If Searched = True Then
    '				Con()
    '				'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				Searched = False
    '			End If
    '            'RS.MoveLast()
    '			Beep()
    '			FromDB()
    '			cmdLast.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub
    '	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
    '		On Error Resume Next
    '        'Dim n As New ADODB.Recordset
    '		If cmdNew.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			Its = "add"
    '			Timer1.Enabled = True
    '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			IDbefore = txtID.Text
    '			'UPGRADE_WARNING: Couldn't resolve default property of object mYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'mYear = RS.Fields("DistDate").Value
    '            'TextUnLock()
    '			myclr()
    '            'n.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            'n.Open("Select NVL(Max(To_Number(ID)),0) +1 ID From OurDistract Where To_Char(DistDate,'YYYY') ='" & VB6.Format(Today, "yyyy") & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            'txtID.Text = CStr(Val(n.Fields("ID").Value))
    '            'n.Close()
    '			txtID.Focus()
    '			cmdCancel.Visible = True
    '            'EnDis(True, False, False)
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
    '		On Error Resume Next
    '		If cmdNext.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			If Searched = True Then
    '				Con()
    '				'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				Searched = False
    '				'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                'RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward)
    '			End If
    '            'RS.MoveNext()
    '            'If RS.EOF Then
    '            '	RS.MoveLast()
    '            '	Beep()
    '            'End If
    '			FromDB()
    '			cmdNext.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
    '		Dim rcnt As Object
    '		Dim j As Object
    '		Dim i As Object
    '		'On Error Resume Next
    '        'Dim r As New ADODB.Recordset
    '		If cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			If txtAmmount.Text = "" Or IsNumeric(txtAmmount.Text) = False Then
    '				MsgBox("⁄›Ê« ! ·„  ﬁ„ »≈œŒ«· «·ﬂ„Ì…", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
    '				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '				Exit Sub
    '			End If
    '			If cmbUnit.Text = "" And cmbAccount.Text = "„›—ﬁ⁄« " Then
    '				MsgBox("⁄›Ê« ! ·„  ﬁ„ »≈œŒ«· ÊÕœ… «·ﬁÌ«”", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
    '				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '				Exit Sub
    '			End If
    '			If cmbClass.Text = "" Then
    '				MsgBox("⁄›Ê« ·„  ﬁ„ »≈œŒ«· «·’‰›", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight)
    '				cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '				Exit Sub
    '			End If
    '			For i = 0 To lstClass.Items.Count - 1
    '				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				For j = i To lstClass.Items.Count - 1
    '                    'If VB6.GetItemString(lstClass, i) = cmbClass.Text Then
    '                    '	MsgBox("⁄›Ê« ! ·ﬁœ ﬁ„  »≈œŒ«· Â–« «·’‰› (" & cmbClass.Text & "). ›÷·«  √ﬂœ „‰ ’Õ… «·»Ì«‰«  «·„œŒ·…", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
    '                    '	cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '                    '	Exit Sub
    '                    'End If
    '				Next 
    '			Next 
    '            'r = New ADODB.Recordset
    '            'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '			' r.Open "Select Sum(ImportClass.Ammount)-Sum(DistractClass.Ammount) Recent, ImportClass.Unit, " _
    '			'& "ImportClass.Class  From DistractClass, ImportClass Where ImportClass.Unit='" & cmbUnit.Text & "' " _
    '			'& "And ImportClass.Class='" & cmbClass.Text & "' And DistractClass.Class(+)=ImportClass.Class " _
    '			'& "And DistractClass.Unit(+)= ImportClass.Unit Group By ImportClass.Class,ImportClass.Unit", DB, adOpenKeyset, adLockReadOnly

    '            'r.Open("Select NVL(Sum(ImportClass.Ammount),0) - NVL(e.Distracted,0) Recent, ImportClass.Unit, " & "ImportClass.Class  From  ImportClass, (Select Class, Sum(Ammount) Distracted From DistractClass Group By Class) e " & "Where ImportClass.Class='" & cmbClass.Text & "' And e.Class(+)=ImportClass.Class  " & "Group By ImportClass.Class,ImportClass.Unit, e.Distracted", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            '' MsgBox r.RecordCount
    '            ''   If r.RecordCount > 0 Then
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object rcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'rcnt = r.Fields("Recent").Value
    '            'For i = 0 To lstAmmount.Items.Count - 1
    '            '	'UPGRADE_WARNING: Couldn't resolve default property of object rcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '	If VB6.GetItemString(lstClass, i) = r.Fields("Class").Value Then rcnt = rcnt - Val(VB6.GetItemString(lstAmmount, i))
    '            'Next 
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object rcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'If rcnt < Val(txtAmmount.Text) Then
    '            '	'UPGRADE_WARNING: Couldn't resolve default property of object rcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '	MsgBox("⁄›Ê« ! Â–Â «·ﬂ„Ì… „‰ Â–« «·’‰› €Ì— „ Ê›—… »«·„Œ«“‰ (" & cmbClass.Text & ")" & ". Ê·« Ì„ﬂ‰ﬂ  ”ÃÌ·Â« ›Ì „” ‰œ «·’—›." & vbNewLine & " «·ﬂ„Ì… «·„ Ê›—… »«·„Œ“‰ ÂÌ ⁄œœ(" & r.Fields("Recent").Value & ") " & r.Fields("Unit").Value & " . Êﬁœ  »ﬁÏ ·ﬂ „‰Â« ⁄œœ (" & rcnt & ") " & r.Fields("Unit").Value & " ·Â–« «·„” ‰œ." & vbNewLine & "Ì—ÃÏ ≈⁄«œ…  €–Ì… »Ì«‰«  „” ‰œ«  «·Ê«—œ ›Ì «·‰Ÿ«„ ≈‰ ﬂ«‰  «·ﬂ„Ì… «·„ Ê›—… √ﬂ»— „‰ «·ﬂ„Ì… «·„ Ê›—… ›Ì ”Ã·«  «·‰Ÿ«„", MsgBoxStyle.Critical + MsgBoxResult.OK + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading)
    '            '	cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '            '	Exit Sub
    '            'End If

    '			'  End If
    '			lstAmmount.Items.Add(txtAmmount.Text)
    '			lstUnit.Items.Add(cmbUnit.Text)
    '			lstClass.Items.Add(cmbClass.Text)
    '			lstClassID.Items.Add(txtClassID.Text)
    '			lstRecord.Items.Add(txtRecord.Text)
    '			cmdPlus.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			txtAmmount.Text = ""
    '			cmbUnit.Text = ""
    '			cmbClass.Text = ""
    '			txtClassID.Text = ""
    '			txtRecord.Text = ""
    '		End If
    '	End Sub
    '	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
    '		On Error Resume Next
    '		If cmdPrev.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'If Searched = True Then
    '            '	Con()
    '            '	'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '	RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '            '	'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '	Searched = False
    '            'End If
    '            'RS.MovePrevious()
    '            'If RS.BOF Then
    '            '	RS.MoveFirst()
    '            '	Beep()
    '            'End If
    '			FromDB()
    '			cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
    '		Dim dtrDistract As Object
    '		On Error GoTo er
    '		If cmdPrintAll.CheckState = 1 Then
    '			'Load DataEnvironment1
    '			'With DataEnvironment1
    '			'    If .rsDistract_Grouping.State = adStateOpen Then .rsDistract_Grouping.Close
    '			'    .Commands(7).CommandText = dtrsql0 & dtrSQL2
    '			'    .Commands(7).Execute
    '			'End With
    '            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
    '            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrsql0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RsRpt.Open(dtrsql0 & dtrSQL2, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.DataSource = RsRpt
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Refresh()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Show()
    '			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description, MsgBoxStyle.Critical)
    '		Err.Clear()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
    '		Dim dtrDistract As Object
    '		On Error GoTo er
    '		If cmdPrintDoc.CheckState = 1 Then
    '			' Load DataEnvironment1
    '			' With DataEnvironment1
    '			'     If .rsDistract_Grouping.State = adStateOpen Then .rsDistract_Grouping.Close
    '			'     .Commands(7).CommandText = dtrsql0 & "And OurDistract.ID='" & txtID.Text & "'" & dtrSQL2
    '			'     .Commands(7).Execute
    '			' End With
    '            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
    '            'RsRpt.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrsql0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RsRpt.Open(dtrsql0 & "And OurDistract.ID='" & txtID.Text & "'" & dtrSQL2, DBshp, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.DataSource = RsRpt
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Refresh()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrDistract.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrDistract.Show()
    '			cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description, MsgBoxStyle.Critical)
    '		Err.Clear()
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
    '	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
    '        'If cmdReturn.CheckState = 1 Then Rtn()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
    '		On Error Resume Next
    '        'If cmdSave.CheckState = System.Windows.Forms.CheckState.Checked Then
    '        '	If Its = "add" Then RS.AddNew()
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object DisID. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	If AddDistract = True Then DisID = txtID.Text
    '        '	ToDB()
    '        '	RS.Update()
    '        '	Timer1.Enabled = False
    '        '	ApplySettings()
    '        '	MsgBox(" „ Õ›Ÿ «·„” ‰œ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
    '        '	Con()
    '        '	FromDB()
    '        '	ConList()
    '        '	Its = ""
    '        '	TextLock()
    '        '	EnDis(False, False, True)
    '        '	cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        '	cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        '	If AddDistract = True Then
    '        '		Distracted = True
    '        '		frmPassPermissions.Show()
    '        '		Me.Hide()
    '        '		frmPassPermissions.cmdDistract.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        '	End If
    '        '	cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        'End If
    '    End Sub

    '	Private Sub Command1_Click()
    '        'MsgBox("" & RS2.State)
    '	End Sub

    '	'UPGRADE_WARNING: Form event frmOurDistract.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    '	Private Sub frmOurDistract_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
    '		cmdRefresh.Width = Me.ClientRectangle.Width
    '        'LoadAllSettings()
    '        'ApplySettings()
    '	End Sub

    '	Private Sub frmOurDistract_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    '		Dim i As Object
    '		On Error Resume Next
    '		Con()
    '		ConList()
    '		FromDB()
    '        'Dim Allowed As New ADODB.Recordset
    '        'Dim distSide As New ADODB.Recordset
    '        'distSide = New ADODB.Recordset
    '        'Allowed = New ADODB.Recordset
    '        'If distSide.State = ADODB.ObjectStateEnum.adStateOpen Then distSide.Close()
    '        'If Allowed.State = ADODB.ObjectStateEnum.adStateOpen Then Allowed.Close()
    '        'distSide.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'Allowed.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'Allowed.Open("Select SideName From WorkAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '        'distSide.Open("Select SideName From ImportAllowed Order By SideName", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '        'For i = 0 To Allowed.RecordCount - 1
    '        '	cmbReceiver.Items.Add(Allowed.Fields("SideName").Value)
    '        '	Allowed.MoveNext()
    '        'Next 
    '        'For i = 0 To distSide.RecordCount - 1
    '        '	cmbDistractor.Items.Add(distSide.Fields("SideName").Value)
    '        '	distSide.MoveNext()
    '        'Next 
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrsql0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrsql0 = "SHAPE {SELECT DistractCLASS.AMMOUNT AS AMMOUNT, DistractCLASS.UNIT AS UNIT, DistractCLASS.CLASS AS CLASS, NVL(DistractCLASS.CLASSID,'   ‹‹‹‹') AS CLASSID, NVL(DistractCLASS.RECORD,'   ‹‹‹‹') AS RECORD, OURDistract.ID, OURDistract.ACCOUNT, OURDistract.DISTRACTOR, OURDistract.STATIONREC, OURDistract.RECEIVER, OURDistract.CONSIGNMENT, OURDistract.DISTDATE, OURDistract.POLICYID, OURDistract.NOTES, OURDistract.DISTRACTAUTHERITY, OURDistract.RANK, OURDistract.DISTSIGNATURE, OURDistract.DISTADOPTION, OURDistract.RECAUTHERITY, OURDistract.RECRANK, OURDistract.RECNAME, OURDistract.DISTNAME, OURDistract.RECSIGNATURE, OURDistract.RECADOPTION, OURDistract.DURATION, OURDistract.STATIONDIST, OURDistract.ROWID AS EXPR1," & "DistractCLASS.FID, OURDistract.INSTRUCTIONS FROM OURDistract, DistractCLASS" & " WHERE OURDistract.ID = DistractCLASS.FID "

    '        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrSQL2 = "GROUP BY DistractCLASS.AMMOUNT, DistractCLASS.UNIT, DistractCLASS.CLASS, DistractCLASS.CLASSID, DistractCLASS.RECORD, OURDistract.ID, OURDistract.ACCOUNT, OURDistract.DISTRACTOR, OURDistract.STATIONREC, OURDistract.RECEIVER, OURDistract.CONSIGNMENT, OURDistract.DISTDATE, OURDistract.POLICYID," & "OURDistract.NOTES, OURDistract.DISTRACTAUTHERITY, OURDistract.RANK, OURDistract.DISTSIGNATURE, OURDistract.DISTADOPTION, OURDistract.RECAUTHERITY, OURDistract.RECRANK, OURDistract.RECNAME, OURDistract.DISTNAME, OURDistract.RECSIGNATURE, OURDistract.RECADOPTION, OURDistract.DURATION, OURDistract.STATIONDIST, OURDistract.ROWID, DistractCLASS.FID, OURDistract.INSTRUCTIONS } " & "AS Distract COMPUTE Distract BY 'ID','ACCOUNT','DISTRACTOR','STATIONREC','RECEIVER','CONSIGNMENT','DISTDATE','POLICYID','NOTES','DISTRACTAUTHERITY','RANK','DISTSIGNATURE','DISTADOPTION','RECAUTHERITY','RECRANK','RECNAME','DISTNAME','RECSIGNATURE','RECADOPTION','DURATION','STATIONDIST','EXPR1','FID','INSTRUCTIONS'"

    '		'If AddDistract = True Then cmdNew.Value = vbChecked
    '	End Sub

    '	Private Sub frmOurDistract_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '        'ProgramExit()
    '		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
    '        'Cancel = MyCancel
    '	End Sub

    '	'UPGRADE_WARNING: Event lstAmmount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub lstAmmount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstAmmount.SelectedIndexChanged
    '		On Error Resume Next
    '		lstUnit.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
    '		lstClass.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
    '		lstClassID.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
    '		lstRecord.SetSelected(lstAmmount.SelectedIndex, lstAmmount.GetSelected(lstAmmount.SelectedIndex))
    '	End Sub

    '	'UPGRADE_WARNING: Event lstClass.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub lstClass_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClass.SelectedIndexChanged
    '		On Error Resume Next
    '		lstAmmount.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
    '		lstClassID.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
    '		lstRecord.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
    '		lstUnit.SetSelected(lstClass.SelectedIndex, lstClass.GetSelected(lstClass.SelectedIndex))
    '	End Sub

    '	'UPGRADE_WARNING: Event lstClassID.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub lstClassID_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstClassID.SelectedIndexChanged
    '		On Error Resume Next
    '		lstAmmount.SetSelected(lstClassID.SelectedIndex, lstClassID.GetSelected(lstClassID.SelectedIndex))
    '		lstUnit.SetSelected(lstClassID.SelectedIndex, lstClassID.GetSelected(lstClassID.SelectedIndex))
    '		lstClass.SetSelected(lstClassID.SelectedIndex, lstClassID.GetSelected(lstClassID.SelectedIndex))
    '		lstRecord.SetSelected(lstClassID.SelectedIndex, lstClassID.GetSelected(lstClassID.SelectedIndex))
    '	End Sub

    '	'UPGRADE_WARNING: Event lstRecord.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub lstRecord_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstRecord.SelectedIndexChanged
    '		On Error Resume Next
    '		lstAmmount.SetSelected(lstRecord.SelectedIndex, lstRecord.GetSelected(lstRecord.SelectedIndex))
    '		lstClass.SetSelected(lstRecord.SelectedIndex, lstRecord.GetSelected(lstRecord.SelectedIndex))
    '		lstUnit.SetSelected(lstRecord.SelectedIndex, lstRecord.GetSelected(lstRecord.SelectedIndex))
    '		lstClassID.SetSelected(lstRecord.SelectedIndex, lstRecord.GetSelected(lstRecord.SelectedIndex))
    '	End Sub

    '	'UPGRADE_WARNING: Event lstUnit.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub lstUnit_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstUnit.SelectedIndexChanged
    '		On Error Resume Next
    '		lstAmmount.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
    '		lstClass.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
    '		lstUnit.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
    '		lstRecord.SetSelected(lstUnit.SelectedIndex, lstUnit.GetSelected(lstUnit.SelectedIndex))
    '	End Sub

    '	Private Sub Option3_Click()

    '	End Sub

    '	Private Sub optDate_Click()
    '		Dim optDate As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optDate.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optDate.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub optDistractor_Click()
    '		Dim optDistractor As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optDistractor.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optDistractor.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub optID_Click()
    '		Dim optID As Object
    '		On Error Resume Next
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optID.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optID.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Private Sub optReceiver_Click()
    '		Dim optReceiver As Object
    '		On Error Resume Next
    '		'UPGRADE_WARNING: Couldn't resolve default property of object optReceiver.Value. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If optReceiver.Value = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    '	End Sub

    '	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
    '		'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
    '	End Sub

    '	'UPGRADE_ISSUE: PictureBox event Picture1.KeyDown was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
    '	Private Sub Picture1_KeyDown(ByRef KeyCode As Short, ByRef Shift As Short)
    '		On Error Resume Next
    '		If KeyCode = 40 Then
    '            'Picture1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Picture1.Top) + 150)
    '		ElseIf KeyCode = 38 Then 
    '            'Picture1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Picture1.Top) - 150)
    '		ElseIf KeyCode = 116 Then 
    '			If Its = "" Then
    '				Con()
    '				FromDB()
    '			End If
    '		End If
    '	End Sub

    '	Private Sub Picture1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Picture1.MouseDown
    '		Dim Button As Short = eventArgs.Button \ &H100000
    '		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
    '        'Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
    '        'Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
    '		On Error Resume Next
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Y1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'Y1 = Y
    '		'UPGRADE_ISSUE: PictureBox property Picture1.MousePointer does not support custom mousepointers. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="45116EAB-7060-405E-8ABE-9DBB40DC2E86"'
    '        'Picture1.Cursor = vbCustom
    '		'UPGRADE_ISSUE: PictureBox property Picture1.MouseIcon was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '        'Picture1.MouseIcon = System.Drawing.Image.FromFile("C:\WINDOWS\Cursors\hmove.cur")
    '	End Sub

    '	Private Sub Picture1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Picture1.MouseMove
    '		Dim Button As Short = eventArgs.Button \ &H100000
    '		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
    '        'Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
    '        'Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
    '		On Error Resume Next
    '		If Button = 1 Then
    '            'If VB6.PixelsToTwipsY(Picture1.Top) < -VB6.PixelsToTwipsY(Picture1.Height) / 2 Then
    '            '	Picture1.Top = VB6.TwipsToPixelsY(-VB6.PixelsToTwipsY(Picture1.Height) / 2 + 1)
    '            'ElseIf VB6.PixelsToTwipsY(Picture1.Top) > 0 Then 
    '            '	Picture1.Top = 0
    '            'Else
    '            '	'UPGRADE_WARNING: Couldn't resolve default property of object Y1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '	Picture1.Top = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Picture1.Top) - Y1 + Y)
    '            'End If
    '		End If
    '	End Sub

    '	Private Sub Picture1_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles Picture1.MouseUp
    '		Dim Button As Short = eventArgs.Button \ &H100000
    '		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
    '        'Dim x As Single = VB6.PixelsToTwipsX(eventArgs.X)
    '        'Dim Y As Single = VB6.PixelsToTwipsY(eventArgs.Y)
    '		On Error Resume Next
    '		Picture1.Cursor = System.Windows.Forms.Cursors.Default
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

    '	Private Sub txtAmmount_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtAmmount.Leave
    '		On Error Resume Next
    '		If cmbAccount.Text = "√·⁄«»" Then cmbUnit.Text = "ﬁÿ⁄…"
    '	End Sub
    '	Private Sub txtAmmount_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtAmmount.KeyDown
    '		Dim KeyCode As Short = eventArgs.KeyCode
    '		Dim Shift As Short = eventArgs.KeyData \ &H10000
    '		If KeyCode = 16 Then sht = True
    '	End Sub

    '	Private Sub txtAmmount_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles txtAmmount.KeyPress
    '		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
    '		If sht = True And KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
    '		sht = False
    '		eventArgs.KeyChar = Chr(KeyAscii)
    '		If KeyAscii = 0 Then
    '			eventArgs.Handled = True
    '		End If
    '	End Sub

    '	Private Sub txtAmmount_KeyUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs) Handles txtAmmount.KeyUp
    '		Dim KeyCode As Short = eventArgs.KeyCode
    '		Dim Shift As Short = eventArgs.KeyData \ &H10000
    '		If KeyCode = 16 Then sht = False
    '	End Sub


    '	Private Sub txtConsignment_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtConsignment.Leave
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmbDistractor" Then Exit Sub
    '		txtStationRec.Focus()
    '	End Sub

    '	Private Sub txtDate_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate.Leave
    '		Dim x As Object
    '		Dim MyCtrl As Object
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If MyCtrl <> "" Then Exit Sub
    '		If Its = "add" Or Its = "edit" Then
    '			If txtDate.Text = "" Or txtDate.Text = " " Or txtDate.Text = "  " Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰  «—ÌŒ «·’—› ›«—€‹‹‹«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					txtDate.Focus()
    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			ElseIf IsDate(txtDate.Text) = False Then 
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ’Ì€… «· «—ÌŒ Œ«ÿ∆…", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					txtDate.Focus()
    '					Exit Sub
    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '				'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				MyCtrl = ""
    '			End If
    '		End If

    '	End Sub

    '	'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate1.TextChanged
    '		Dim idexit As Object
    '		Dim dtrSQL As Object
    '		On Error Resume Next
    '		cmbSearch_SelectedIndexChanged(cmbSearch, New System.EventArgs())
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		Searched = True
    '		Con()
    '        'RS.Close()
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrSQL = "Select * From OurDistract Where " & MyField & " Order By DistDate, To_Number(ID)"
    '        'RS.Open(dtrSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        'FromDB()
    '        'If RS.RecordCount = 0 Then
    '        '	myclr()
    '        '	cmdPrintDoc.Enabled = False
    '        '	cmdFound.Enabled = False
    '        'Else
    '        '	cmdPrintDoc.Enabled = True
    '        '	cmdFound.Enabled = True
    '        'End If
    '        'If RS.RecordCount < 2 Then
    '        '	cmdFindNext.Enabled = False
    '        '	cmdFindPrev.Enabled = False
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object idexit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	If idexit = True Then Exit Sub
    '        'Else
    '        '	cmdFindNext.Enabled = True
    '        '	cmdFindPrev.Enabled = True
    '        'End If
    '		lblFound.Text = ""
    '        'lblFound.Text = " „ «·⁄ÀÊ— ⁄·Ï " & lblFound.Text & RS.RecordCount & " ”Ã·"

    '	End Sub

    '	'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDate2.TextChanged
    '		'on error resume next
    '		txtDate1_TextChanged(txtDate1, New System.EventArgs())
    '	End Sub

    '	Private Sub txtDuration_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtDuration.Leave
    '		Dim MyCtrl As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If MyCtrl <> "" Then Exit Sub
    '		txtStationDist.Focus()
    '	End Sub

    '	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
    '		Dim idexit As Object
    '		Dim dtrSQL As Object
    '		On Error Resume Next
    '		cmbSearch_SelectedIndexChanged(cmbSearch, New System.EventArgs())
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Searched. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		Searched = True
    '		Con()
    '        'RS.Close()
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrSQL = "Select * From OurDistract Where " & MyField & "  order by To_Number(ID)"
    '        'RS.Open(dtrSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '		FromDB()
    '        'If RS.RecordCount = 0 Then
    '        '	myclr()
    '        '	cmdPrintDoc.Enabled = False
    '        '	cmdFound.Enabled = False
    '        'Else
    '        '	cmdPrintDoc.Enabled = True
    '        '	cmdFound.Enabled = True
    '        'End If
    '        'If RS.RecordCount < 2 Then
    '        '	cmdFindNext.Enabled = False
    '        '	cmdFindPrev.Enabled = False
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object idexit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	If idexit = True Then Exit Sub
    '        'Else
    '        '	cmdFindNext.Enabled = True
    '        '	cmdFindPrev.Enabled = True
    '        'End If
    '		lblFound.Text = ""
    '        'lblFound.Text = " „ «·⁄ÀÊ— ⁄·Ï ⁄œœ " & lblFound.Text & RS.RecordCount & " ”Ã·"
    '	End Sub

    '	Private Sub txtID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtID.Leave
    '		Dim Y As Object
    '		Dim o As Object
    '		Dim x As Object
    '		'On Error Resume Next
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then
    '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '			Exit Sub
    '		End If
    '		'UPGRADE_WARNING: Couldn't resolve default property of object mYear. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'Dim r As New ADODB.Recordset
    '        'If Its = "add" Or (Its = "edit" And IDbefore <> txtID.Text And mYear <> txtDate.Text) Then
    '        '	If txtID.Text = "" Then
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		x = MsgBox("⁄›Ê« ! ⁄·Ìﬂ «·ﬁÌ«„ »≈œŒ«· —ﬁ„ «·„” ‰œ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '        '		If x = MsgBoxResult.OK Then
    '        '			txtID.Focus()
    '        '		ElseIf x = MsgBoxResult.Cancel Then 
    '        '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '        '		End If
    '        '	Else
    '        '		'  Set r = New ADODB.Recordset
    '        '		r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        '		'Dim o As String
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object o. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		o = VB6.Format(txtDate.Text, "yyyy")
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object o. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		r.Open("Select RowNum, OurDistract.* From OurDistract Where ID='" & txtID.Text & "' And To_char(DistDate,'YYYY')='" & o & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '        '		If r.RecordCount > 0 Then
    '        '			'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '			Y = MsgBox("⁄›Ê« ! Â–« «·„” ‰œ „ÊÃÊœ »«·”Ã·«  . Â·  —Ìœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Exclamation + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
    '        '			If Y = MsgBoxResult.No Then
    '        '				txtID.Focus()
    '        '			ElseIf Y = MsgBoxResult.Yes Then 
    '        '				r.Move((r.Fields(0).Value - 1))
    '        '				FromDB()
    '        '				Its = ""
    '        '				EnDis(False, False, True)
    '        '				TextLock()
    '        '			ElseIf Y = MsgBoxResult.Cancel Then 
    '        '				cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '        '			End If
    '        '		Else
    '        '			r.Close()
    '        '			cmbAccount.Focus()
    '        '		End If
    '        '	End If
    '        'End If
    '	End Sub

    '	'UPGRADE_WARNING: Event txtStationDist.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtStationDist_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStationDist.TextChanged
    '		If Its = "add" Or Its = "edit" Then txtStationRec.Text = txtStationDist.Text
    '	End Sub

    '	Private Sub txtStationDist_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStationDist.Leave
    '		Dim vbancel As Object
    '		Dim x As Object
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '		If Its = "add" Or Its = "edit" Then
    '			If txtStationDist.Text = "" Or txtStationDist.Text = " " Or txtDisAdoption.Text = "  " Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «”„ «·„Õÿ… ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					txtStationDist.Focus()
    '					'UPGRADE_WARNING: Couldn't resolve default property of object vbancel. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				ElseIf x = vbancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			End If
    '		End If
    '	End Sub

    '	Private Sub txtStationRec_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtStationRec.Leave
    '		Dim f As Object
    '		Dim MyCtrl As Object
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then Exit Sub
    '		'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		If MyCtrl <> "" Then Exit Sub
    '		If Its = "add" Or Its = "edit" Then
    '			If txtStationRec.Text = "" Or txtStationRec.Text = " " Or txtStationRec.Text = "  " Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object f. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				f = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ «·„Õÿ…«·„” ·„… ›«—€‹‹‹«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If f = MsgBoxResult.OK Then
    '					txtStationRec.Focus()
    '				ElseIf f = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '				'UPGRADE_WARNING: Couldn't resolve default property of object MyCtrl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				MyCtrl = ""
    '			End If
    '		End If
    '	End Sub

    Private Sub frmOurDistract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.WORKPERMISSIONSTableAdapter.FillDistinctFSideName(Me.DsExplosives.WORKPERMISSIONS)
        'TODO: This line of code loads data into the 'DsExplosives.WORKALLOWED' table. You can move, or remove it, as needed.
        '  Me.WORKALLOWEDTableAdapter.Fill(Me.DsExplosives.WORKALLOWED)
        'TODO: This line of code loads data into the 'DsExplosives.IMPORTALLOWED' table. You can move, or remove it, as needed.
        Me.IMPORTALLOWEDTableAdapter.FillByIsDistractor(Me.DsExplosives.IMPORTALLOWED, True)
        'TODO: This line of code loads data into the 'DsExplosives.Accounts' table. You can move, or remove it, as needed.
        Me.AccountsTableAdapter.Fill(Me.DsExplosives.Accounts)
        'TODO: This line of code loads data into the 'DsExplosives.OURDISTRACT' table. You can move, or remove it, as needed.
        Me.OURDISTRACTTableAdapter.Fill(Me.DsExplosives.OURDISTRACT)
        If cmbAccount.Items.Count > 0 Then
            cmbAccount.SelectedIndex = 0
            cmbAccount_SelectedIndexChanged(Nothing, Nothing)
        End If
        GetOurDistractDetails()
        Dim dtCLASSES As New dsExplosives.CLASSESDataTable
        dtCLASSES = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataDistinctUnit()
        For i As Integer = 0 To dtCLASSES.Rows.Count - 1
            cmbUnit.Items.Add(dtCLASSES(i).UNIT)
        Next
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (OURDISTRACTBindingSource.Position + 1).ToString + " / " + OURDISTRACTBindingSource.Count.ToString

    End Sub

    Private Sub cmbAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbAccount.Items.Count > 0 Then
            Dim dtClasses As New dsExplosives.CLASSESDataTable
            dtClasses = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataByAccount(cmbAccount.Text)
            cmbClass.Items.Clear()
            For i As Integer = 0 To dtClasses.Rows.Count - 1
                Dim Row As dsExplosives.CLASSESRow = dtClasses.Rows(i)
                cmbClass.Items.Add(Row._CLASS)
            Next
        End If

    End Sub

    Private Sub Picture1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub cmdSave_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckStateChanged
        If DataGridView1.Rows.Count > 0 Then
           
            If IsAdd And txtOurDistractNo.Text <> "" Then
                Dim dtOurDistractNo As New dsExplosives.OURDISTRACTDataTable
                dtOurDistractNo = New dsExplosivesTableAdapters.OURDISTRACTTableAdapter().GetDataByMaxDistractNo_Year(dtpDate.Value.Year)
                If IsDBNull(dtOurDistractNo.Rows(0)("OurDistractNo")) Then
                    txtOurDistractNo.Text = 1
                Else

                    txtOurDistractNo.Text = dtOurDistractNo(0).OurDistractNo + 1
                End If


            End If


            OURDISTRACTBindingSource.EndEdit()
            OURDISTRACTTableAdapter.Update(DsExplosives.OURDISTRACT)
            Dim daOurDistract As New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter
            If txtID.Text <> "" Then
                daOurDistract.DeleteByOurDistractID(Convert.ToInt32(txtID.Text))
            End If
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If txtID.Text <> "" Then


                    daOurDistract.Insert(DataGridView1.Rows(i).Cells("Description").Value.ToString,
                                                      Convert.ToDecimal(DataGridView1.Rows(i).Cells("Quantity").Value.ToString),
                    DataGridView1.Rows(i).Cells("Unit").Value.ToString,
                    DataGridView1.Rows(i).Cells("SampleNo").Value.ToString,
                    DataGridView1.Rows(i).Cells("RecordNo").Value.ToString,
                                                      Convert.ToInt32(txtID.Text))
                End If
            Next
            MsgBox(" „")
            DisableSave()
        Else
            MsgBox("⁄›Ê« ·« »œ „‰  ÕœÌœ „Ê«œ")
        End If
    End Sub

    Private Sub cmdPlus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim daClasses As New dsExplosivesTableAdapters.CLASSESTableAdapter
        If daClasses.GetDataByClass(cmbClass.Text).Rows.Count = 0 Then
            MsgBox("«·⁄‰’— €Ì— „⁄—›")
            Return
        End If
        Dim daOurImportDetails As New dsExplosivesTableAdapters.OurImportDetailsTableAdapter
        If chbSkipImport.Checked Then
            Dim Index As Integer = -1
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells("Description").ToString = cmbClass.Text Then
                    Index = i
                End If
            Next
            If Index = -1 Then


                txtAmmount.BackColor = Color.White
                cmbUnit.BackColor = Color.White
                cmbClass.BackColor = Color.White
                If txtAmmount.Value = 0 Then
                    txtAmmount.BackColor = Color.Red

                ElseIf cmbUnit.Text = "" Then
                    cmbUnit.BackColor = Color.Red

                ElseIf cmbClass.Text = "" Then
                    cmbClass.BackColor = Color.Red
                Else
                    DataGridView1.Rows.Add(txtAmmount.Text, cmbUnit.Text, cmbClass.Text, txtClassID.Text, txtRecord.Text)
                    cmbClass_SelectedIndexChanged(Nothing, Nothing)
                    txtAmmount.Value = 0
                    cmbUnit.Text = ""
                    cmbClass.Text = ""
                    txtClassID.Text = ""
                    txtRecord.Text = ""
                End If
            Else
                MsgBox("«·⁄‰’— „ÊÃÊœ ›Ì «·ﬁ«∆„…")
            End If
        Else
            Dim dtOurImportDetails As New dsExplosives.OurImportDetailsDataTable
            daOurImportDetails.FillByDescriptionSumQuantity(dtOurImportDetails, cmbClass.Text)

            If daOurImportDetails.GetDataByDescription(cmbClass.Text).Rows.Count > 0 Then


                Dim daRecentClasses As New dsExplosivesTableAdapters.RecentClassesTableAdapter
                If daRecentClasses.GetData(cmbClass.Text).Rows.Count > 0 Then
                    If daRecentClasses.GetData(cmbClass.Text)(0).RECENT >= txtAmmount.Value Then
                        Dim Index As Integer = -1
                        For i As Integer = 0 To DataGridView1.Rows.Count - 1
                            If DataGridView1.Rows(i).Cells("Description").ToString = cmbClass.Text Then
                                Index = i
                            End If
                        Next
                        If Index = -1 Then


                            txtAmmount.BackColor = Color.White
                            cmbUnit.BackColor = Color.White
                            cmbClass.BackColor = Color.White
                            If txtAmmount.Value = 0 Then
                                txtAmmount.BackColor = Color.Red

                            ElseIf cmbUnit.Text = "" Then
                                cmbUnit.BackColor = Color.Red

                            ElseIf cmbClass.Text = "" Then
                                cmbClass.BackColor = Color.Red
                            Else
                                DataGridView1.Rows.Add(txtAmmount.Text, cmbUnit.Text, cmbClass.Text, txtClassID.Text, txtRecord.Text)
                                cmbClass_SelectedIndexChanged(Nothing, Nothing)
                                txtAmmount.Value = 0
                                cmbUnit.Text = ""
                                cmbClass.Text = ""
                                txtClassID.Text = ""
                                txtRecord.Text = ""
                            End If

                        Else
                            MsgBox("«·⁄‰’— „ÊÃÊœ ›Ì «·ﬁ«∆„…")
                        End If
                    Else
                        MessageBox.Show("«·ﬂ„Ì… ›Ì «·„Œ“‰ «ﬁ· „‰ «·„ÿ·Ê»")
                    End If
                ElseIf dtOurImportDetails.Rows.Count > 0 Then
                    If dtOurImportDetails(0).Quantity < txtAmmount.Value Then
                        MessageBox.Show("«·ﬂ„Ì… ›Ì «·„Œ“‰ «ﬁ· „‰ «·„ÿ·Ê»")
                    Else
                        txtAmmount.BackColor = Color.White
                        cmbUnit.BackColor = Color.White
                        cmbClass.BackColor = Color.White
                        If txtAmmount.Value = 0 Then
                            txtAmmount.BackColor = Color.Red

                        ElseIf cmbUnit.Text = "" Then
                            cmbUnit.BackColor = Color.Red

                        ElseIf cmbClass.Text = "" Then
                            cmbClass.BackColor = Color.Red
                        Else
                            DataGridView1.Rows.Add(txtAmmount.Text, cmbUnit.Text, cmbClass.Text, txtClassID.Text, txtRecord.Text)
                            cmbClass_SelectedIndexChanged(Nothing, Nothing)
                            txtAmmount.Value = 0
                            cmbUnit.Text = ""
                            cmbClass.Text = ""
                            txtClassID.Text = ""
                            txtRecord.Text = ""
                        End If
                    End If
                Else
                    txtAmmount.BackColor = Color.White
                    cmbUnit.BackColor = Color.White
                    cmbClass.BackColor = Color.White
                    If txtAmmount.Value = 0 Then
                        txtAmmount.BackColor = Color.Red

                    ElseIf cmbUnit.Text = "" Then
                        cmbUnit.BackColor = Color.Red

                    ElseIf cmbClass.Text = "" Then
                        cmbClass.BackColor = Color.Red
                    Else
                        DataGridView1.Rows.Add(txtAmmount.Text, cmbUnit.Text, cmbClass.Text, txtClassID.Text, txtRecord.Text)
                        cmbClass_SelectedIndexChanged(Nothing, Nothing)
                        txtAmmount.Value = 0
                        cmbUnit.Text = ""
                        cmbClass.Text = ""
                        txtClassID.Text = ""
                        txtRecord.Text = ""
                    End If
                End If
            Else
                MsgBox("«·ﬂ„Ì… €Ì— „ÊÃÊœ… ›Ì «·Ê«—œ")
            End If
        End If
           
    End Sub
    Dim IsAdd As Boolean = False
    Private Sub cmdNew_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckStateChanged
        OURDISTRACTBindingSource.AddNew()
        IsAdd = True
        dtpDate.Value = DateTime.Now
        DataGridView1.Rows.Clear()
        EnableSave()

    End Sub

    Private Sub cmdMinus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMinus.CheckStateChanged
        If DataGridView1.SelectedRows.Count > 0 Then
            DataGridView1.Rows.Remove(DataGridView1.SelectedRows(0))
        End If
    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckedChanged
        OURDISTRACTBindingSource.MoveLast()
        GetOurDistractDetails()
    End Sub
    Private Sub GetOurDistractDetails()
        DataGridView1.Rows.Clear()

        If txtID.Text <> "" Then

            Dim dtOurDistractDetails As New dsExplosives.OurDistractDetailsDataTable
            dtOurDistractDetails = New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter().GetDataByOurDistractID(txtID.Text)
           

                For i As Integer = 0 To dtOurDistractDetails.Rows.Count - 1
                    If txtID.Text <> "" Then
                        Dim drOurDistractDetails As dsExplosives.OurDistractDetailsRow
                        drOurDistractDetails = dtOurDistractDetails.Rows(i)
                        DataGridView1.Rows.Add(drOurDistractDetails.Quantity, drOurDistractDetails.Unit, drOurDistractDetails.Description, drOurDistractDetails.SampleNo, drOurDistractDetails.RecordNo)

                    End If
                Next

        End If

    End Sub
    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        OURDISTRACTBindingSource.MoveNext()
        GetOurDistractDetails()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        OURDISTRACTBindingSource.MovePrevious()
        GetOurDistractDetails()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        OURDISTRACTBindingSource.MoveFirst()
        GetOurDistractDetails()
    End Sub

    Private Sub cmdPrintDoc_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtID.Text <> "" Then
            'Dim fPrintOurDistract As New frmPrintOurDistract()
            'fPrintOurDistract.ShowDialog()
        End If
    End Sub

    Private Sub cmdReturn_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Hide()
    End Sub

    Private Sub cmdExit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Close()
    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbClass.Items.Count > 0 Then
            Dim dtOurDistractDetails As New dsExplosives.OurDistractDetailsDataTable
            dtOurDistractDetails = New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter().GetDataDistinctUnit
            'cmbUnit.Items.Clear()
            For i As Integer = 0 To dtOurDistractDetails.Rows.Count - 1
                Dim Row As dsExplosives.OurDistractDetailsRow = dtOurDistractDetails.Rows(i)
                Dim OurDistractIndex As Integer = cmbUnit.FindStringExact(Row.Unit)
                If OurDistractIndex = -1 Then


                    cmbUnit.Items.Add(Row.Unit)
                End If
            Next
            If cmbClass.Items.Count > 0 Then


                Dim ClassUnit As String = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataByClass(cmbClass.Text)(0)("UNIT")
                Dim Index As Integer = cmbUnit.FindStringExact(ClassUnit)
                If Index = -1 Then


                    cmbUnit.Items.Add(ClassUnit)
                End If
            End If
        End If
    End Sub

    Private Sub cmbDistractor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbReceiver_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub cmbReceiver_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'cmbReceiver.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        ''cmbReceiver.AutoCompleteSource = AutoCompleteSource.CustomSource
        'If cmbReceiver.Text <> "" Then


        '    Dim ACCSSideName As New AutoCompleteStringCollection
        '    Dim daReceivers As New dsExplosivesTableAdapters.WORKALLOWEDTableAdapter()
        '    Dim dtReceivers As New dsExplosives.WORKALLOWEDDataTable
        '    dtReceivers = daReceivers.GetDataByLikeSideName(cmbReceiver.Text)
        '    For i As Integer = 0 To dtReceivers.Rows.Count - 1
        '        ACCSSideName.Add(dtReceivers.Rows(i)("SIDENAME"))
        '    Next
        '    cmbReceiver.AutoCompleteCustomSource = ACCSSideName
        'End If
        'cmbReceiver.SelectedIndex = -1
        'CType(cmbReceiver.DataSource, BindingSource).Filter = "SIDENAME like '%" + cmbReceiver.Text + "%'"
    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If cmbCriteria.Text = "⁄«„" Then
            If IsNumeric(txtFind.Text) Then
                OURDISTRACTBindingSource.Filter = " ID =" & txtFind.Text & " or ACCOUNT Like '%" & txtFind.Text & "%' or DISTRACTOR Like '%" & txtFind.Text & "%' " &
                    "or RECEIVER Like '%" & txtFind.Text & "%'  or CONSIGNMENT Like '%" & txtFind.Text & "%' or STATIONDIST Like '%" & txtFind.Text & "%' or INSTRUCTIONS Like '%" & txtFind.Text & "%' "
            Else
                OURDISTRACTBindingSource.Filter = " ACCOUNT Like '%" & txtFind.Text & "%' or DISTRACTOR Like '%" & txtFind.Text & "%' " &
                    "or RECEIVER Like '%" & txtFind.Text & "%'  or CONSIGNMENT Like '%" & txtFind.Text & "%' or STATIONDIST Like '%" & txtFind.Text & "%' or INSTRUCTIONS Like '%" & txtFind.Text & "%' "
            End If
        End If
        lblPosition.Text = " " + (OURDISTRACTBindingSource.Position + 1).ToString + " / " + OURDISTRACTBindingSource.Count.ToString


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

    Private Sub cmdEdit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckStateChanged
        EnableSave()
    End Sub

    Private Sub cmdExit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckedChanged

    End Sub

    Private Sub cmdExit_CheckStateChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close()
    End Sub

    Private Sub cmdReturn_CheckStateChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
    End Sub

    Private Sub cmdPlus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckedChanged

    End Sub

    Private Sub cmbClass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress, txtAmmount.KeyPress, cmbUnit.KeyPress
       
    End Sub

    Private Sub Frame2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame2.Enter

    End Sub

    Private Sub cmbAccount_SelectedIndexChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccount.SelectedIndexChanged

    End Sub

  

    Private Sub MainMenu1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles MainMenu1.ItemClicked

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub OURDISTRACTBindingSource_AddingNew(ByVal sender As System.Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles OURDISTRACTBindingSource.AddingNew

    End Sub

    Private Sub cmbClass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbClass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdPlus_CheckStateChanged(Nothing, Nothing)

        End If
    End Sub

    Private Sub cmdFound_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFound.CheckStateChanged
        Dim frptOurDistract As New frmrptOurDistract()
        frptOurDistract.ShowDialog()
    End Sub

    Private Sub cmdDelete_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckStateChanged
        
        Dim x As Object
        x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·”Ã· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            OURDISTRACTBindingSource.RemoveCurrent()

            OURDISTRACTBindingSource.EndEdit()
            OURDISTRACTTableAdapter.Update(DsExplosives.OURDISTRACT)
            MsgBox(" „")
            DataGridView1.Rows.Clear()
            DisableSave()
        End If
    End Sub

    
End Class