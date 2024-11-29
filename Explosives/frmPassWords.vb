Option Strict Off
Option Explicit On
Friend Class frmPassWords
	Inherits System.Windows.Forms.Form
	Private MyField, MyFieldText As Object
    'Private Sub Check1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Check1.ClickEvent
    '	'If Check1.Value = 1 Then
    '	Change()
    '	' Check1.Value = 0
    '	'End If
    'End Sub
	
    'Private Sub Command1_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.ClickEvent
    'If Command1.Value = 1 Then
    'Dim RS As New ADODB.Recordset
    'If txtNew.Text = txtConfirm.Text Then
    '	If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
    '	RS.CursorLocation = ADODB.CursorLocationEnum.adUseClient
    '	'UPGRADE_WARNING: Couldn't resolve default property of object MyFieldText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '	RS.Open("Select * From Security Where " & MyField & "='" & MyFieldText & "'", DB, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockPessimistic)
    '	'UPGRADE_WARNING: Couldn't resolve default property of object MyFieldText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '	'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '	MsgBox("Select * From Security Where " & MyField & "='" & MyFieldText & "'")
    '	If RS.RecordCount > 0 Then
    '		RS.Fields(MyField).Value = txtNew.Text
    '		RS.Update()
    '		MsgBox(" „  €ÌÌ— " & lblRecentUserPass.Text & " !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
    '		frmMain.Show()
    '		Me.Hide()
    '	Else
    '		MsgBox("Œÿ√ ›Ì " & lblRecentUserPass.Text, MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
    '	End If
    'Else
    '	MsgBox(lblNew.Text & " Ê " & lblConfirm.Text & " ·« Ì ”«ÊÌ«‰", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight)
    'End If
    '' Command1.Value = 0
    ''End If
    'End Sub

    'Private Sub Command2_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.ClickEvent
    '    'If Command2.Value = 1 Then
    '    frmMain.Show()
    '    Me.Hide()
    '    'End If
    'End Sub

    'UPGRADE_WARNING: Form event frmPassWords.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    Private Sub frmPassWords_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'Check1_Click()
    End Sub

    Private Sub Change()
        'UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If UserPass = "user" Then
        '    lblRecentUserPass.Text = "«”„ «·„” Œœ„ «·Õ«·Ì"
        '    lblNew.Text = "«”„ «·„” Œœ„ «·ÃœÌœ"
        '    lblConfirm.Text = " √ﬂÌœ «”„ «·„” Œœ„ «·ÃœÌœ"
        '    Check1.Text = "ﬂ·„… «·”—"
        '    'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    MyField = "USERNAME"
        '    txtPassword.PasswordChar = ""
        '    txtNew.PasswordChar = ""
        '    txtConfirm.PasswordChar = ""
        '    'UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    UserPass = "pass"
        '    'UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'ElseIf UserPass = "pass" Then
        '    lblRecentUserPass.Text = "ﬂ·„… «·”— «·Õ«·Ì…"
        '    lblNew.Text = "ﬂ·„… «·”— «·ÃœÌœ…"
        '    lblConfirm.Text = " √ﬂÌœ ﬂ·„… «·”— «·ÃœÌœ…"
        '    Check1.Text = "«”„ «·„” Œœ„"
        '    'UPGRADE_WARNING: Couldn't resolve default property of object MyField. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    MyField = "PASSWORD"
        '    'UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    UserPass = "user"
        '    txtPassword.PasswordChar = "*"
        '    txtNew.PasswordChar = "*"
        '    txtConfirm.PasswordChar = "*"
        'End If
        'txtPassword.Text = ""
        'txtNew.Text = ""
        'txtConfirm.Text = ""
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

    'Private Sub txtConfirm_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMicrosoft.Vbe.Interop.Forms.MdcTextEvents_KeyPressEvent) Handles txtConfirm.KeyPressEvent
    '	If eventArgs.KeyAscii.Value = 13 Then Command1_Click()
    'End Sub

    'Private Sub txtNew_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMicrosoft.Vbe.Interop.Forms.MdcTextEvents_KeyPressEvent) Handles txtNew.KeyPressEvent
    '	If eventArgs.KeyAscii.Value = 13 Then Command1_Click()
    'End Sub

    Private Sub TextBox2_Change()

    End Sub

    'Private Sub txtPassword_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtPassword.Change
    '    'UPGRADE_WARNING: Couldn't resolve default property of object MyFieldText. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    MyFieldText = txtPassword.Text
    'End Sub

    'Private Sub txtPassWord_KeyPress(KeyAscii As Integer)
    '
    'End Sub
    'Private Sub txtPassword_KeyPressEvent(ByVal eventSender As System.Object, ByVal eventArgs As AxMicrosoft.Vbe.Interop.Forms.MdcTextEvents_KeyPressEvent) Handles txtPassword.KeyPressEvent
    '	If eventArgs.KeyAscii.Value = 13 Then Command1_Click()
    'End Sub
End Class