Option Strict Off
Option Explicit On
Friend Class frmClasses
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private RS2 As New ADODB.Recordset
    'Private Rs3 As New ADODB.Recordset
    'Private Rs4 As New ADODB.Recordset
    'Private RsRpt As New ADODB.Recordset
    '	Private Its, IDbefore As String
    '	Private Searched, Loaded As Boolean
    '	Private Hdate, dtrHaving, dtrWhere, RsCurrent, dtrSelect, dtrGroup, dtrOrder, Ldate As Object
    '	Dim SQL1, j, i, SQL, SQL2 As Object
    '	Private Sub Con()
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Hdate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'Hdate = VB6.Format(Today, "DD/MM/YYYY")
    '		'UPGRADE_WARNING: Couldn't resolve default property of object Ldate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'If IsDate(txtFrom.Text) = False Then Ldate = VB6.Format("1/1/2013", "DD/MM/YYYY")
    '        'Rs4 = New ADODB.Recordset
    '        'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '        'If RS2.State = ADODB.ObjectStateEnum.adStateOpen Then RS2.Close()
    '        'If Rs3.State = ADODB.ObjectStateEnum.adStateOpen Then Rs3.Close()
    '        'If Rs4.State = ADODB.ObjectStateEnum.adStateOpen Then Rs4.Close()
    '        'RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'RS2.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'Rs3.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '        'Rs4.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrSelect = "Select Row_number() Over (Order By Classes.Account, Classes.Class) As Num, Sum(NVL(ImportClass.Ammount,0)) Imported, " & " NVL(e.Distracted,0) Distracted, " & " Sum(NVL(ImportClass.Ammount,0)) - NVL(e.Distracted,0)  Recent, " & " NVL(Classes.ID,'‹‹‹‹‹') ID, Classes.Class Class, Classes.Unit Unit,  " & " Classes.Account Account " & " From  Classes, ImportClass, (Select Class, Sum(NVL(DistractClass.Ammount,0)) Distracted From DistractClass Group By Class) e " & " Where e.Class(+)=Classes.Class And ImportClass.Class(+)=Classes.Class "
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrWhere = " "
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrGroup = " Group By  Classes.Class, e.Distracted, Classes.Unit, " & " Classes.Account, Classes.ID "
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrHaving = ""
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrOrder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		dtrOrder = " Order By  Classes.Account, Classes.Class"


    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrOrder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '		SQL = dtrSelect & dtrWhere & dtrGroup & dtrHaving & dtrOrder
    '		My.Computer.Clipboard.Clear()
    '		My.Computer.Clipboard.SetText(SQL)
    '		'MsgBox Hdate & "   " & Ldate
    '        'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        'RS2.Open("Select * From Classes Order By Class", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)

    '        'Rs4.Open("Select Account From Accounts Order By Account", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '        'cmbAccount.Items.Clear()
    '        'For i = 0 To Rs4.RecordCount - 1
    '        '	cmbAccount.Items.Add(Rs4.Fields("Account").Value)
    '        '	Rs4.MoveNext()
    '        'Next 
    '		'ImportClass.Class, DistractCLass.Class,DistractCLass.Unit,
    '		' Sum(NVL(ImportClass.Ammount,0))- Sum(NVL(DistractClass.Ammount,0))
    '	End Sub
    '	Private Sub myclr()
    '        'clr()
    '		cmbAccount.Text = ""
    '	End Sub
    '	Private Sub FromDB()
    '		On Error Resume Next
    '		myclr()
    '        'txtClass.Text = RS.Fields("Class").Value
    '        ''txtClassID.Text = RS!ID
    '        'txtUnit.Text = RS.Fields("Unit").Value
    '        'cmbAccount.Text = RS.Fields("Account").Value
    '        'lblRecent.Text = RS.Fields("Recent").Value
    '        'lblImported.Text = RS.Fields("Imported").Value
    '        'lblDistracted.Text = RS.Fields("Distracted").Value
    '	End Sub
    '	Private Sub ToDB()
    '		'On Error Resume Next
    '        'RS2.Fields("Class").Value = txtClass.Text
    '        'RS2.Fields("ID").Value = txtClassID.Text
    '        'RS2.Fields("Unit").Value = txtUnit.Text
    '        'RS2.Fields("Account").Value = cmbAccount.Text
    '	End Sub



    '	'UPGRADE_WARNING: Event cmbSearch.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmbSearch_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbSearch.SelectedIndexChanged
    '		If Loaded = True Then
    '			If IsDate(txtFrom.Text) And IsDate(txtTo.Text) Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "⁄«„" Then dtrWhere = " "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "«”„ «·’‰›" Then dtrHaving = " Having Classes.Class Like '%" & txtFind.Text & "%' "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "ÊÕœ… «·ﬁÌ«”" Then dtrHaving = " Having Acount Like '%" & txtFind.Text & "%' "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "«·Õ”«»" Then dtrHaving = " Having Classes.Account Like '%" & txtFind.Text & "%' "
    '				If cmbSearch.Text = "Ê«—œ ’‰› ›Ì › —… „«" Then
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					dtrHaving = " Having Classes.Account Like '%" & txtFind.Text & "%' "
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					dtrWhere = ""
    '				End If

    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                'dtrWhere = " And ImportClass.DistDate Between '" & VB6.Format(txtFrom.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtTo.Text, "DD/MM/YYYY") & "' "
    '			Else
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "⁄«„" Then dtrWhere = " "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "«”„ «·’‰›" Then dtrHaving = " Having Classes.Class Like '%" & txtFind.Text & "%' "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "ÊÕœ… «·ﬁÌ«”" Then dtrHaving = " Having Classes.Account Like '%" & txtFind.Text & "%' "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				If cmbSearch.Text = "«·Õ”«»" Then dtrHaving = " Having Acount Like '%" & txtFind.Text & "%' "
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				dtrWhere = " "
    '			End If
    '            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrOrder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrHaving. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RS.Open(dtrSelect & dtrWhere & dtrGroup & dtrHaving & dtrOrder, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '			FromDB()
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFound.CheckStateChanged
    '		Dim dtrClasses As Object
    '		On Error GoTo er
    '		If cmdFound.CheckState = 1 Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.DataSource = RS
    '			With dtrClasses
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				With .Sections(2)
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblImported").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblDistracted").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblRecent").Visible = False
    '				End With
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				With .Sections(3)
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtImported").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtDistracted").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtRecent").Visible = False
    '				End With
    '			End With
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Refresh()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Show()
    '			FromDB()
    '			cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description)
    '		Err.Clear()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdImpDISTAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdImpDISTAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImpDISTAll.CheckStateChanged
    '		Dim dtrClasses As Object
    '		On Error GoTo er
    '		If cmdImpDISTAll.CheckState = 1 Then
    '			Con()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.DataSource = RS
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Refresh()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Show()
    '			FromDB()
    '			cmdImpDISTAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 

    '		MsgBox(Err.Description)
    '		Err.Clear()
    '		cmdImpDISTAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdImpDistDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdImpDistDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImpDistDoc.CheckStateChanged
    '		Dim dtrClasses As Object
    '		Dim dtrSQL As Object
    '		On Error GoTo er
    '        'If cmdImpDistDoc.CheckState = 1 Then
    '        '	If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	dtrSQL = dtrSelect & dtrGroup & " Having Classes.Class='" & txtClass.Text & "'"
    '        '	RsRpt.Open(dtrSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	dtrClasses.DataSource = RsRpt
    '        'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        dtrClasses.Refresh()
    '        'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        dtrClasses.Show()
    '        cmdImpDistDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        'End If
    '        Exit Sub
    'er:
    '        cmdImpDistDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        MsgBox(Err.Description)
    '        Err.Clear()
    '	End Sub

    '	Private Sub cmdpImpDistFound_Click()


    '	End Sub

    '	'UPGRADE_WARNING: Event cmdImpDistFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdImpDistFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImpDistFound.CheckStateChanged
    '		Dim dtrClasses As Object
    '		On Error GoTo er
    '		If cmdImpDistFound.CheckState = 1 Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.DataSource = RS
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Refresh()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Show()
    '			FromDB()
    '			cmdImpDistFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdImpDistFound.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description)
    '		Err.Clear()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
    '		On Error Resume Next
    '		If cmdPrev.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'If Searched = True Then
    '            '	Con()
    '            '	RS.Find("Class='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '            '	Searched = False
    '            'End If
    '            'RS.MovePrevious()
    '            'If RS.BOF Then
    '            '	RS.MoveFirst()
    '            '	Beep()
    '            'End If
    '            FromDB()
    '            cmdPrev.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        End If

    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrintAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintAll.CheckStateChanged
    '		Dim dtrClasses As Object
    '		On Error GoTo er
    '		If cmdPrintAll.CheckState = 1 Then
    '			Con()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.DataSource = RS
    '			With dtrClasses
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				With .Sections(2)
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblImported").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblDistracted").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("lblRecent").Visible = False
    '				End With
    '				'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				With .Sections(3)
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtImported").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtDistracted").Visible = False
    '					'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '					.Controls.Item("txtRecent").Visible = False
    '				End With
    '			End With
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Refresh()
    '			'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			dtrClasses.Show()
    '			FromDB()
    '			cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '		Exit Sub
    'er: 
    '		cmdPrintAll.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description)
    '		Err.Clear()
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdPrintDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdPrintDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrintDoc.CheckStateChanged
    '		Dim dtrClasses As Object
    '		Dim dtrSQL As Object
    '		On Error GoTo er
    '		If cmdPrintDoc.CheckState = 1 Then
    '            'If RsRpt.State = ADODB.ObjectStateEnum.adStateOpen Then RsRpt.Close()
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrGroup. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrSQL = dtrSelect & dtrGroup & " Having Classes.Class='" & txtClass.Text & "'"
    '            'RsRpt.Open(dtrSQL, DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.DataSource = RsRpt
    '            'With dtrClasses
    '            'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'With .Sections(2)
    '            '    'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '    .Controls.Item("lblImported").Visible = False
    '            '    'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '    .Controls.Item("lblDistracted").Visible = False
    '            '    'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '    .Controls.Item("lblRecent").Visible = False
    '            'End With
    '            '         'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '         With .Sections(3)
    '            '             'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '             .Controls.Item("txtImported").Visible = False
    '            '             'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '             .Controls.Item("txtDistracted").Visible = False
    '            '             'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Sections. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            '             .Controls.Item("txtRecent").Visible = False
    '            '         End With
    '            'End With
    '            'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'dtrClasses.Refresh()
    '            'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            dtrClasses.Show()
    '            cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '        End If
    '		Exit Sub
    'er: 
    '		cmdPrintDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		MsgBox(Err.Description)
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
    '		'On Error Resume Next
    '		If cmdSave.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'If Its = "add" Then RS2.AddNew()
    '			ToDB()
    '            'RS2.Update()
    '			Timer1.Enabled = False
    '            'ApplySettings()
    '			MsgBox(" „ Õ›Ÿ «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
    '			Con()
    '			FromDB()
    '            'TextLock()
    '			Its = ""
    '			cmdCancel.Visible = False
    '			cmdEdit.Visible = True
    '			cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
    '            'EnDis(False, False, True)
    '			cmdSave.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If

    '	End Sub




    '	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
    '		Dim lstUnit As Object
    '		Dim lstAmmount As Object
    '		Dim l As Object
    '		Dim Ammount As Object
    '		Dim Unit As Object
    '		Dim lstClass As Object
    '		On Error Resume Next
    '        'For i = 0 To RS.RecordCount - 1
    '        'UPGRADE_WARNING: Couldn't resolve default property of object lstClass.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'lstClass.AddItem(RS.Fields("Class"))
    '        'UPGRADE_WARNING: Couldn't resolve default property of object Unit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        Unit = ""
    '        'UPGRADE_WARNING: Couldn't resolve default property of object Ammount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        Ammount = 0
    '        'For j = 0 To RS2.RecordCount - 1
    '        '	If RS.Fields("Class").Value = RS2.Fields("Class").Value Then
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object Ammount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		Ammount = RS2.Fields("amnt").Value
    '        '		'UPGRADE_WARNING: Couldn't resolve default property of object Unit. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '		Unit = RS2.Fields("Unit").Value
    '        '		For l = 0 To Rs3.RecordCount - 1
    '        '			If Rs3.Fields("Class").Value = RS2.Fields("Class").Value Then
    '        '				'UPGRADE_WARNING: Couldn't resolve default property of object Ammount. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '				Ammount = RS2.Fields("Ammount").Value - Rs3.Fields("Ammount").Value
    '        '			End If
    '        '			Rs3.MoveNext()
    '        '		Next 
    '        '	End If
    '        '	Rs3.MoveFirst()
    '        '	RS2.MoveNext()
    '        'Next 
    '        'RS2.MoveFirst()
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object lstAmmount.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'lstAmmount.AddItem(Ammount)
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object lstUnit.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'lstUnit.AddItem(Unit)
    '        'RS.MoveNext()
    '        'Next 
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
    '		Dim x As Object
    '		On Error Resume Next
    '		If cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNo)
    '			If x = MsgBoxResult.Yes Then
    '				FromDB()
    '				Its = ""
    '				cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
    '				cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
    '                'EnDis(False, False, True)
    '				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
    '				cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
    '			End If
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
    '		Dim x As Object
    '		If cmdDelete.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «·„” ‰œ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
    '			If x = MsgBoxResult.Yes Then
    '                'RS2.MoveFirst()
    '                'RS2.Find("Class='" & txtClass.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '                'RS2.Delete()
    '				MsgBox(" „ Õ–› «·”Ã· !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
    '			End If
    '			'Con
    '			FromDB()
    '            'EnDis(False, False, True)
    '			cmdDelete.CheckState = System.Windows.Forms.CheckState.Unchecked
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
    '		'On Error Resume Next
    '		If cmdEdit.CheckState = System.Windows.Forms.CheckState.Checked Then
    '            'TextUnLock()
    '            'Its = "edit"
    '            'IDbefore = txtClass.Text
    '            ''UPGRADE_WARNING: Couldn't resolve default property of object RsCurrent. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '            'RsCurrent = RS2.AbsolutePosition
    '            'RS2.MoveFirst()
    '            'RS2.Find("Class='" & txtClass.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '            'EnDis(False, True, False)
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
    '		On Error Resume Next
    '		If cmdFirst.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			If Searched = True Then
    '				Con()
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
    '			If Searched = True Then
    '				Con()
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
    '		If cmdNew.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			Its = "add"
    '			Timer1.Enabled = True
    '            'TextUnLock()
    '			If Not txtClass.Text = "" Then IDbefore = txtClass.Text
    '			myclr()
    '			txtClass.Focus()
    '			cmdCancel.Visible = True
    '            'EnDis(True, False, False)
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
    '		On Error Resume Next
    '		If cmdNext.CheckState = System.Windows.Forms.CheckState.Checked Then
    '			If Searched = True Then
    '				Con()
    '				Searched = False
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

    '	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
    '		Dim dtrClasses As Object
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrClasses.DataSource = RS
    '		'UPGRADE_WARNING: Couldn't resolve default property of object dtrClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'dtrClasses.Show()
    '	End Sub

    '	'UPGRADE_WARNING: Form event frmClasses.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    '	Private Sub frmClasses_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
    '        'LoadAllSettings()
    '        'ApplySettings()
    '		cmdRefresh.Width = Me.ClientRectangle.Width
    '	End Sub

    '	Private Sub frmClasses_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
    '		'On Error Resume Next
    '		Loaded = False
    '		cmbSearch.SelectedIndex = 0
    '		Loaded = True
    '        'txtTo.Text = VB6.Format(Today, "YYYY/MM/DD")
    '        'Dim r As New ADODB.Recordset
    '        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
    '        'r.Open("Select Min(ImportClass.DistDate) As Imp , Min (DistractClass.DistDate) As Dist From ImportClass, DistractClass", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
    '        'txtFrom.Text = VB6.Format(r.Fields("Imp").Value, "YYYY/MM/DD")
    '        'If r.Fields("Dist").Value < r.Fields("Imp").Value Then txtFrom.Text = VB6.Format(r.Fields("Dist").Value, "YYYY/MM/DD")
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object Ldate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'If IsDate(txtFrom.Text) Then Ldate = VB6.Format(txtFrom.Text, "DD/MM/YYYY")
    '        'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
    '		Con()
    '		FromDB()
    '	End Sub

    '	Private Sub frmClasses_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '        'ProgramExit()
    '        ''UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
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
    '                    'ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
    '				End If
    '			Else
    '				'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '				If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
    '					'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                    'If ccontorl.Enabled = True Then
    '                    '	'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                    '	ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
    '                    'Else
    '                    '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                    '	ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
    '                    'End If
    '                    ''UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '                    'If ccontrol.Name <> Me.ActiveControl.Name And ccontrol.Text = "" Then
    '                    '	'UPGRADE_WARNING: Couldn't resolve default property of object EmptyClrlVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                    '	ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(EmptyClrlVal)
    '                    'End If
    '				End If
    '			End If
    '		Next ccontrol
    '	End Sub

    '	Private Sub txtclass_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtclass.Leave
    '		Dim Y As Object
    '		Dim x As Object
    '		On Error Resume Next
    '		'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
    '		If Me.ActiveControl.Name = "cmdCancel" Then
    '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '			Exit Sub
    '		End If
    '		If Its = "add" Or (IDbefore <> txtClass.Text And Its = "edit") Then
    '			If txtClass.Text = "" Then
    '				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '				x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ  „ﬂ«‰ «·’‰› ›«—€«", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKCancel)
    '				If x = MsgBoxResult.OK Then
    '					txtClass.Focus()
    '				ElseIf x = MsgBoxResult.Cancel Then 
    '					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '				End If
    '			Else
    '                'RS2.MoveFirst()
    '                'RS.MoveFirst()
    '                'RS2.Find("Class='" & txtClass.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '                'If RS2.EOF Then
    '                '	RS2.MoveFirst()
    '                '	RS2.Find("Class='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '                'Else
    '                '	'UPGRADE_WARNING: Couldn't resolve default property of object Y. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '                '	Y = MsgBox("⁄›Ê« ! Â–« «·’‰› „ÊÃÊœ . Â·  Êœ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNoCancel)
    '                '	If Y = MsgBoxResult.Yes Then
    '                '		RS.Find("Class='" & txtClass.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
    '                '		FromDB()
    '                '		Its = ""
    '                '		cmdNew.CheckState = System.Windows.Forms.CheckState.Unchecked
    '                '		cmdEdit.CheckState = System.Windows.Forms.CheckState.Unchecked
    '                '		EnDis(False, False, True)
    '                '	ElseIf Y = MsgBoxResult.No Then 
    '                '		txtClass.Focus()
    '                '	ElseIf Y = MsgBoxResult.Cancel Then 
    '                '		cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
    '                '	End If
    '                'End If
    '			End If
    '		End If
    '	End Sub

    '	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    '	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
    '		cmbSearch_SelectedIndexChanged(cmbSearch, New System.EventArgs())
    '	End Sub

    Private Sub frmClasses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.CLASSES' table. You can move, or remove it, as needed.
        Me.CLASSESTableAdapter.Fill(Me.DsExplosives.CLASSES)
        Me.CLASSESTableAdapter.FillDistinctUnit(Me.UnitDsExplosives1.CLASSES)
        cmbCriteria.SelectedIndex = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblPosition.Text = " " + (CLASSESBindingSource.Position + 1).ToString + " / " + CLASSESBindingSource.Count.ToString


    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckStateChanged
        CLASSESBindingSource.MoveLast()
    End Sub

    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        CLASSESBindingSource.MoveNext()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        CLASSESBindingSource.MovePrevious()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        CLASSESBindingSource.MoveFirst()
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
    Private Sub cmdNew_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckStateChanged
        CLASSESBindingSource.AddNew()
        EnableSave()
    End Sub

    Private Sub cmdSave_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckStateChanged
        CLASSESBindingSource.EndEdit()
        CLASSESTableAdapter.Update(DsExplosives.CLASSES)
        MessageBox.Show(" „")
        DisableSave()
    End Sub

    Private Sub cmdCancel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckStateChanged
        CLASSESBindingSource.CancelEdit()
    End Sub

    Private Sub cmdEdit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckedChanged
        EnableSave()
    End Sub

    Private Sub cmdReturn_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Close()
    End Sub

    Private Sub cmdExit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close()
    End Sub

    Private Sub cmdDelete_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/ Õ–› Â–« «·Õ”«» ø", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If x = MsgBoxResult.Yes Then
            CLASSESBindingSource.RemoveCurrent()
            CLASSESBindingSource.EndEdit()
            CLASSESTableAdapter.Update(DsExplosives.CLASSES)
            MsgBox(" „")
            DisableSave()
        End If
    End Sub
End Class