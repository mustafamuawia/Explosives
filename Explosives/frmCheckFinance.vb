Option Strict Off
Option Explicit On
Friend Class frmCheckFinance
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
	Private ToBeAdded As Boolean
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/„‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›… ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
				ToBeAdded = False
				MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OKOnly)
				Timer2.Enabled = True
				'UPGRADE_WARNING: Couldn't resolve default property of object MyForm.cmdRefresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'MyForm.cmdRefresh.Value = 1
			Else
				'UPGRADE_WARNING: Form method frmCheckFinance.ZOrder has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
				Me.BringToFront()
			End If
			cmdCancel.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdOK.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdOK_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.CheckStateChanged
		Dim x As Object
		If Not IsNumeric(Text1.Text) Then
			MsgBox("⁄‹‹›‹‹‹Ê«! «·‰’ ÌÕ ÊÌ ⁄·Ï —„Ê“ €Ì— —ﬁ„Ì….", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight)
			Exit Sub
        End If
        If Text1.Text = "" Or Text1.Text = " " Or Text1.Text = "   " Then
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("⁄›Ê« ! ⁄·Ìﬂ ≈œŒ«· —ﬁ„ «·„” ‰œ «·„«·Ì.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OkCancel)
            If x = MsgBoxResult.Ok Then
                Text1.Focus()
            ElseIf x = MsgBoxResult.Cancel Then
                cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            End If
        End If


       
        '            'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select * From Finance Where ID='" & Text1.Text & "' And To_Char(FDate,'YYYY') = '" & cmbYear.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'If r.RecordCount > 0 Then
        '	r.Close()
        '	r.Open("Select Status, StatusID From Finance Where ID='" & Text1.Text & "' And To_Char(FDate,'YYYY') = '" & cmbYear.Text & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        Dim dtFinance As New DataTable()
        dtFinance = New dsExplosivesTableAdapters.FINANCETableAdapter().GetDataByIDYear(Convert.ToInt32(Text1.Text), Convert.ToDecimal(cmbYear.Text))
        If dtFinance.Rows.Count > 0 Then
            '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("⁄›Ê« !  „  Œ’Ì’ Â–« «·„” ‰œ «·„«·Ì ·œ›⁄ —”Ê„ " & dtFinance.Rows(0)("Status").Value & ". Â·  Êœ —ƒÌ… »Ì«‰« Â ø" & "«÷€ÿ ⁄·Ï (·«) ··„ «»⁄… Ê·ﬂ‰ ”Ì €Ì—  Œ’Ì’ «·„” ‰œ", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.YesNoCancel)
            If x = MsgBoxResult.Yes Then
                '			r.Close()
                '			r.Open("Select Finance.*,To_Char(FDate,'YYYY') as FF  From Finance Order By To_Number(To_Char(FDate,'YYYY')), To_number(ID)", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
                '			r.Find("FF='" & cmbYear.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '			r.Find("ID='" & Text1.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '			'UPGRADE_WARNING: Couldn't resolve default property of object FinanceIdx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			FinanceIdx = r.AbsolutePosition
                frmFinance.Show()
                '			Me.Hide()
                '			FindFinance = True
                '		ElseIf x = MsgBoxResult.No Then 
                '			cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
                '			GoTo cont
                '		ElseIf x = MsgBoxResult.Cancel Then 
                '			cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
            End If
            '					Else
            'cont:
            '                'UPGRADE_WARNING: Couldn't resolve default property of object FinanceIdx. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '                FinanceIdx = r.AbsolutePosition
            '                ToBeAdded = True
            '                Timer2.Enabled = True
            '                cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            x = MsgBox("⁄›Ê« ! ·„ Ì „ «·⁄ÀÊ— ⁄·Ï —ﬁ„ «·„” ‰œ «·„«·Ì «·–Ì √œŒ· Â.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.OkCancel)
            If x = MsgBoxResult.Ok Then
                Text1.Focus()
            ElseIf x = MsgBoxResult.Cancel Then
                cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
                cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '          End If
            End If
            '      
        End If
        '	End If
        '      cmdOK.CheckState = System.Windows.Forms.CheckState.Unchecked
        'End If
    End Sub
	
	'UPGRADE_WARNING: Form event frmCheckFinance.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmCheckFinance_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
		Dim i As Object
		On Error Resume Next
		Me.Left = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width
		ToBeAdded = False
		cmdOK.Enabled = False
        ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdOK.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object BackClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Me.BackColor = System.Drawing.ColorTranslator.FromOle(BackClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Frame1.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object FramesFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Frame1.ForeColor = System.Drawing.ColorTranslator.FromOle(FramesFntVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object LabelsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Label1.BackColor = System.Drawing.ColorTranslator.FromOle(LabelsClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object LabelsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'Label3.BackColor = System.Drawing.ColorTranslator.FromOle(LabelsClrVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsFntVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdCancel.ForeColor = System.Drawing.ColorTranslator.FromOle(ButtonsFntVal)
        ''UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'cmdCancel.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        'Dim r As New ADODB.Recordset
        'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        'r.Open("Select To_Char(FDate,'YYYY'), Count(*) From Finance Group By To_Char(FDate,'YYYY') Order By To_Number(To_Char(FDate,'YYYY'))", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockReadOnly)
        'cmbYear.Items.Clear()
        'For i = 1 To r.RecordCount
        '	cmbYear.Items.Add(r.Fields(0).Value)
        '	r.MoveNext()
        'Next 
        'cmbYear.SelectedIndex = 0
        'Timer1.Enabled = True
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(System.Windows.Forms.Form.ActiveForm.Width) * 2)
        ''Timer1.Enabled = True
        ''Me.Left = Screen.ActiveForm.Width * 2

        'FindFinance = False
        On Error Resume Next
        Dim dtYears As New dsExplosives.FINANCEYEARDataTable()
        dtYears = New dsExplosivesTableAdapters.FINANCEYEARTableAdapter().GetData

        cmbYear.Items.Clear()
        For i = 0 To dtYears.Rows.Count
            cmbYear.Items.Add(dtYears.Rows(i)("YEAR").ToString)

        Next
        cmbYear.SelectedIndex = 0
	End Sub
	
	Private Sub frmCheckFinance_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim dtYears As New dsExplosives.FINANCEYEARDataTable()
        dtYears = New dsExplosivesTableAdapters.FINANCEYEARTableAdapter().GetData

        cmbYear.Items.Clear()
        For i = 0 To dtYears.Rows.Count
            cmbYear.Items.Add(dtYears.Rows(i)("YEAR").ToString)

        Next
        cmbYear.SelectedIndex = 0
		
	End Sub
	
	'UPGRADE_WARNING: Event Text1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.TextChanged
        'If Text1.Text = vbNullString Then
        '	cmdOK.Enabled = False
        '	'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        'Else
        '	cmdOK.Enabled = True
        '	'UPGRADE_WARNING: Couldn't resolve default property of object ButtonsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	cmdOK.BackColor = System.Drawing.ColorTranslator.FromOle(ButtonsClrVal)
        'End If
	End Sub
	
	Private Sub Text1_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles Text1.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 13 Then cmdOK.CheckState = System.Windows.Forms.CheckState.Checked
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        ''On Error Resume Next
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If VB6.PixelsToTwipsX(Me.Left) <= VB6.PixelsToTwipsX(System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width) / 2 - VB6.PixelsToTwipsX(Me.Width) / 2 Then
        '	'Me.Left = Screen.ActiveForm.ScaleWidth / 2 + Me.Width / 2
        '	Timer1.Enabled = False
        'End If
	End Sub
	
	Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        'Me.Left = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Me.Left) - 500)
        'If VB6.PixelsToTwipsX(Me.Left) + VB6.PixelsToTwipsX(Me.Width) <= 0 Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object MyForm.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	MyForm.Show()
        '	Timer2.Enabled = False
        '	Me.Close()
        '	If ToBeAdded = False Then EnDis(False, False, True)
        'End If
	End Sub
	
	Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
        'Dim ccontorl As Object
        'Dim ccontrol As System.Windows.Forms.Control
        'On Error Resume Next
        'For	Each ccontrol In Me.Controls
        '	If Me.ActiveControl.equals(ccontrol) Then
        '		'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		'UPGRADE_WARNING: Couldn't resolve default property of object ActiveClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(ActiveClrVal)
        '	Else
        '		'UPGRADE_WARNING: TypeName has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        '		If TypeName(ccontrol) = "TextBox" Or TypeName(ccontrol) = "ComboBox" Or TypeName(ccontrol) = "ListBox" Then
        '			'UPGRADE_WARNING: Couldn't resolve default property of object ccontorl.Enabled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '			If ccontorl.Enabled = True Then
        '				'UPGRADE_WARNING: Couldn't resolve default property of object TextsClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '				ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(TextsClrVal)
        '			Else
        '				'UPGRADE_WARNING: Couldn't resolve default property of object FramesClrVal. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '				ccontrol.BackColor = System.Drawing.ColorTranslator.FromOle(FramesClrVal)
        '			End If
        '		End If
        '	End If
        'Next ccontrol
		
	End Sub
End Class