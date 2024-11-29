Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmLogin
	Inherits System.Windows.Forms.Form
    'Private Sub cmdExit_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.ClickEvent
    '       'Dim x As Object
    '       ''UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '       'x = MsgBox("Â· ›⁄·«  —Ìœ «·Œ—ÊÃ „‰ «·‰Ÿ«„ ø", MsgBoxStyle.YesNo + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Question)
    '       'If x = MsgBoxResult.Yes Then
    '       '	If DB.State = ADODB.ObjectStateEnum.adStateOpen Then DB.Close()
    '       '	End
    '       'End If
    'End Sub
	
    'Private Sub cmdOK_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOK.ClickEvent
    '       '		Dim x As Object
    '       '		On Error GoTo er
    '       '		'If cmdOk.Value = 1 Then
    '       '		Con()
    '       '		If RS.RecordCount = 0 Then
    '       '			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '       '			x = MsgBox("⁄›Ê« ! Œÿ‹‹‹‹‹√ ›Ì «”„ «·„” Œœ„ Ê/√Ê ﬂ·„… «·”— .", MsgBoxStyle.OKOnly + MsgBoxStyle.Critical)
    '       '		ElseIf RS.RecordCount = 1 Then 
    '       '			frmMain.Show()
    '       '			Me.Hide()
    '       '		End If
    '       '		'    cmdOk.Value = 0
    '       '		Exit Sub
    '       'er: 
    '       '		MsgBox(Err.Description)
    '       '		cmdOK.Value = 0
    '	'End If
    'End Sub
	
	Private Sub CommandButton1_Click()
		
	End Sub
	
	Private Sub frmLogin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        'Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        'If KeyAscii = 13 Then cmdOK.Value = 1
        'eventArgs.KeyChar = Chr(KeyAscii)
        'If KeyAscii = 0 Then
        '	eventArgs.Handled = True
        'End If
	End Sub
	
	Private Sub frmLogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        If My.MySettings.Default.Auth = "SQL" Or My.MySettings.Default.Auth = "Windows" Then
            If My.MySettings.Default.Auth = "SQL" Then


                My.MySettings.Default.explosivesConnectionString = "data source=" + My.MySettings.Default.Server + ";initial catalog=" + My.MySettings.Default.Database + ";user id=" + My.MySettings.Default.SQLUser + ";password=" + My.MySettings.Default.Password + ""

            Else
                My.MySettings.Default.explosivesConnectionString = "data source=" + My.MySettings.Default.Server + ";initial catalog=" + My.MySettings.Default.Database + ";integrated security=SSPI"

            End If
           
        End If
    End Sub
	
	'Private Sub txtPassWord_KeyPress(KeyAscii As Integer)
	'If KeyAscii = 13 Then cmdOK.Value = 1
	'End Sub
	
	'Private Sub txtUsername_KeyPress(KeyAscii As Integer)
	'If KeyAscii = 13 Then cmdOK.Value = 1
	'End Sub
	
    'Private Sub frmLogOut_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles frmLogOut.Click

    'End Sub


    Private Sub login_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles login_btn.Click
        Try
            Dim dtSecurity As New dsExplosives.SecurityDataTable()
            dtSecurity = New dsExplosivesTableAdapters.SecurityTableAdapter().GetDataByUsernamePassword(username_txt.Text, password_txt.Text)
            If (dtSecurity.Rows.Count > 0) Then
                username_txt.Text = ""
                password_txt.Text = ""

                frmMain.Show()

                Hide()
            Else
                MsgBox("Œÿ√ ›Ì «”„ «·„” Œœ„ √Ê ﬂ·„… «·„—Ê—")
            End If

        Catch ex As Exception
            MsgBox("ÌÊÃœ Œÿ√ ›Ì ﬁ«⁄œ… «·»Ì«‰« ")
        End Try
        
    End Sub

  
  
    Private Sub Cancel_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_btn.Click
        Close()

    End Sub

    Private Sub groupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupBox1.Enter

    End Sub

    Private Sub frmLogin_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        For i As Integer = 0 To Application.OpenForms.Count - 1
            If Application.OpenForms(i).Name <> "frmLogin" Then
                Application.OpenForms(i).Close()
            End If
        Next
    End Sub

    Private Sub pictureBox1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pictureBox1.DoubleClick
        Dim fDatabaseSettings As New frmDatabaseSettings()
        fDatabaseSettings.ShowDialog()

    End Sub
End Class