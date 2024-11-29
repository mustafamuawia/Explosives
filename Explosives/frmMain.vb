Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmMain
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private kk As New ADODB.Recordset
    '	Dim i, j As Object
    '    'Private Declare Function ShellExecute Lib "shell32.dll"  Alias "ShellExecuteA"(ByVal hwnd As Integer, ByVal lpOperation As String, ByVal lpFile As String, ByVal lpParameters As String, ByVal lpDirectory As String, ByVal nShowCmd As Integer) As Integer
    '    'Private Function PictureRepaint() As Object
    '    '	'On Error Resume Next

    '    '	'UPGRADE_ISSUE: PictureBox property Picture3.ScaleMode was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '    '       'Picture3.ScaleMode = 3
    '    '       ''UPGRADE_ISSUE: PictureBox property Picture3.AutoRedraw was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '    '       'Picture3.AutoRedraw = True
    '    '       ''UPGRADE_ISSUE: Panel property Me.Picture3.BackgroundImage will be tiled. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ED2DEFAA-C59C-4EDB-AF23-73A16C92C3AC"'
    '    '       ''UPGRADE_ISSUE: Picture property Picture3.Picture.Height was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '    '       ''UPGRADE_ISSUE: Picture property Picture3.Picture.Width was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '    '       ''UPGRADE_ISSUE: PictureBox method Picture3.PaintPicture was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '    '       'Picture3.PaintPicture(Me.Picture3.BackgroundImage, 0, 0, VB6.PixelsToTwipsX(Picture3.ClientRectangle.Width), VB6.PixelsToTwipsY(Me.Picture3.ClientRectangle.Height) + 150, 0, 0, Me.Picture3.BackgroundImage.Width / 26.46, Me.Picture3.BackgroundImage.Height / 26.46)
    '    'End Function

    '    'Private Sub cmdConditions_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConditions.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmConditions.Show()
    '    '	Me.Hide()
    '    'End Sub

    '    'Private Sub cmdFinancial_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFinancial.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmFinance.Show()
    '    '	Me.Hide()
    '    'End Sub


    '    'Private Sub cmdNoObjections_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNoObjections.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmNoObjections.Show()
    '    '	Me.Hide()
    '    'End Sub

    '    'Private Sub cmdTeams_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdTeams.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmTeams.Show()
    '    '       'Me.Hide()
    '    'End Sub



    '    Private Sub cmdAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '        'frmAbout.Show()
    '    End Sub

    '    'Private Sub cmdBalance_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdBalance.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmBalance.Show()
    '    '	Me.Hide()
    '    'End Sub

    '    'Private Sub cmdClasses_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClasses.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmClasses.Show()
    '    '	Me.Hide()
    '    'End Sub

    '    Private Sub cmdExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '        ''UPGRADE_ISSUE: CommandButton property cmdExit.Value was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
    '        'If cmdExit.Value = 1 Then ProgramExit()
    '    End Sub

    '	Private Sub cmdImporters_Click()
    '        'Dim frmPermitted As Object
    '        'MyForm = Me
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object frmPermitted.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'frmPermitted.Show()
    '        'Me.Hide()
    '	End Sub

    '	Private Sub cmdFireWorks_Click()
    '        'Dim frmFireWorksClasses As Object
    '        'MyForm = Me
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object frmFireWorksClasses.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'frmFireWorksClasses.Show()
    '        'Me.Hide()
    '	End Sub

    '    'Private Sub cmdImoprtAllowed_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImoprtAllowed.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmImportAllowed.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdImportPermissions_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportPermissions.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmImportPermissions.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '	Private Sub cmdLogout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.Click
    '        'LogOut()
    '	End Sub

    '	Private Sub cmdObjectionConditions_Click()

    '		'me.Hide
    '	End Sub

    '    'Private Sub cmdWorkAllowed_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWorkAllowed.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmWorkAllowed.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdWorkPermissions_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWorkPermissions.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmWorkPermissions.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdourRecent_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdourRecent.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmOurRecentImport.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '	Private Sub cmdOurs_Click()
    '        'Dim frmOurs As Object
    '        'MyForm = Me
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object frmOurs.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'frmOurs.Show()
    '        'Me.Hide()
    '	End Sub

    '	Private Sub cmdPermitted_Click()
    '        'Dim frmExploders As Object
    '        'MyForm = Me
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object frmExploders.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'frmExploders.Show()
    '        'Me.Hide()
    '	End Sub

    '    'Private Sub cmdOurRecentDistract_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdOurRecentDistract.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmOurRecentDistract.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdPassCopies_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPassCopies.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmPassCopies.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdPermissions_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPermissions.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmPassPermissions.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '	Private Sub cmdTheirRecent_Click()
    '        'Dim frmTheirRecent As Object
    '        'MyForm = Me
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object frmTheirRecent.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'frmTheirRecent.Show()
    '        'Me.Hide()
    '	End Sub

    '    'Private Sub cmdTheirs_Click()
    '    '	Dim frmTheirs As Object
    '    '	MyForm = Me
    '    '	'UPGRADE_WARNING: Couldn't resolve default property of object frmTheirs.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '    '	frmTheirs.Show()
    '    '	Me.Hide()
    '    'End Sub

    '	Private Sub ComboBox1_GotFocus()
    '        'Dim ComboBox1 As Object
    '        'For i = 0 To 10
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object ComboBox1.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	ComboBox1.AddItem(i & "„Õ„œ ⁄»œ «·„«Ãœ")
    '        'Next 
    '	End Sub

    '    'Private Sub cmdWorkCopies_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdWorkCopies.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmWorkCopies.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
    '        'Dim Form1 As Object
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object Form1.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'Form1.Show()
    '        ''ShellExecute hWnd, "open", "C:\Users\Muhammed\Desktop\Notes.txt", vbNullString, vbNullString, 1
    '	End Sub

    '    'Private Sub cmdDistractDoc_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDistractDoc.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmOurDistract.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdImportDoc_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdImportDoc.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmOurImport.Show()
    '    '       'Me.Hide()
    '    'End Sub

    '    'Private Sub cmdAccounts_ClickEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdAccounts.ClickEvent
    '    '       'MyForm = Me
    '    '       'frmAccounts.Show()
    '    '       'Me.Hide()
    '    'End Sub



    '	'UPGRADE_WARNING: Form event frmMain.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
    '    'Private Sub frmMain_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
    '    ''On Error Resume Next
    '    'Picture3.Width = Me.ClientRectangle.Width
    '    'Picture3.Height = VB6.TwipsToPixelsY(VB6.PixelsToTwipsY(Me.Height) + 360)
    '    'PictureRepaint()

    '    'Dim ds As New ADODB.Command
    '    'ds.let_ActiveConnection(DB)

    '    'Dim DD As Date
    '    'DD = CDate(VB6.Format(VB.Day(Today) & "/" & Month(Today) & "/" & Year(Today) - 1, "DD/MM/YYYY"))

    '    'ds.CommandText = "alter session set nls_date_format='dd/mm/yyyy'"
    '    'ds.Execute()

    '    'ds.CommandText = "Update Workpermissions Set Valid='·«' Where fDate < '" & DD & "'"
    '    'ds.Execute()

    '    'ds = New ADODB.Command
    '    'ds.let_ActiveConnection(DB)
    '    'ds.CommandText = "Update Workpermissions Set Valid='‰⁄„' Where FDate >='" & DD & "'"
    '    'ds.Execute()
    '    'End Sub

    '    Private Sub frmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load

    '        'Timer1.Enabled = True
    '        'Timer1.Interval = 60000
    '        'TimerX_Timer()
    '        'On Error Resume Next
    '    End Sub

    '    Private Sub L2_Click()
    '        'Dim L1 As Object
    '        'Dim L2 As Object

    '        ''UPGRADE_WARNING: Couldn't resolve default property of object L2.ListIndex. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object L1.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object L2.Selected. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'L1.Selected(L2.ListIndex) = L2.Selected(L2.ListIndex)
    '    End Sub

    '    Private Sub L2_GotFocus()
    '        'Dim L2 As Object
    '        'Dim L1 As Object
    '        'For i = 0 To 10
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object L1.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	L1.AddItem(i)
    '        '	'UPGRADE_WARNING: Couldn't resolve default property of object L2.AddItem. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        '	L2.AddItem(i)
    '        'Next 
    '    End Sub

    '    Private Sub frmConditions_Click()

    '        Me.Hide()
    '    End Sub

    '    Private Sub frmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
    '        'ProgramExit()
    '        'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
    '        'Cancel = MyCancel
    '    End Sub

    '    Public Sub mnuAbout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuAbout.Click
    '        '		On Error GoTo er
    '        '		frmAbout.Show()
    '        '		Exit Sub
    '        'er: 
    '        '		MsgBox(Err.Description, MsgBoxStyle.Critical)
    '    End Sub

    '    Public Sub mnuBackToDefault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBackToDefault.Click
    '        '		On Error GoTo er
    '        '		'ShellExecute hwnd, "open", "cmd", "cmd.exe /k Exp Explosives/explosives File='" & App.Path & "Backup.DMP'", "", 1
    '        '		Shell("cmd.exe /c Exp Explosives/explosives@Orcl File='" & My.Application.Info.DirectoryPath & "Backup.DMP'")
    '        '		'Shell "cmd.exe /k exit", vbNormalFocus
    '        '		Exit Sub
    '        'er: 
    '        '		MsgBox(Err.Description,  , "")
    '    End Sub

    '    Public Sub mnuBackToFolder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuBackToFolder.Click
    '        '		On Error GoTo er
    '        '		'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '        '		cmnDlgOpen.Filter = "Dump Files (*.dmp) |*.dmp"
    '        '		cmnDlgSave.Filter = "Dump Files (*.dmp) |*.dmp"
    '        '		cmnDlgOpen.FileName = "Backup"
    '        '		cmnDlgSave.FileName = "Backup"
    '        '		cmnDlgSave.ShowDialog()
    '        '		cmnDlgOpen.FileName = cmnDlgSave.FileName
    '        '		Shell("cmd.exe /c Exp Explosives/explosives@Orcl file='" & cmnDlgOpen.FileName & "'")
    '        '		Exit Sub
    '        'er: 
    '        '		MsgBox(Err.Description,  , "")
    '    End Sub

    '    Public Sub mnuExit_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuExit.Click
    '        cmdExit.PerformClick()
    '    End Sub

    '    Public Sub mnuFromDefault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFromDefault.Click
    '        On Error GoTo er
    '        Shell("cmd.exe /c IMP Explosives/explosives@Orcl File='" & My.Application.Info.DirectoryPath & "Backup.DMP' full=yes")
    '        Exit Sub
    'er:
    '        MsgBox(Err.Description, , "")
    '    End Sub

    '    Public Sub mnuFromFolder_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuFromFolder.Click
    '        On Error GoTo er
    '        'UPGRADE_WARNING: Filter has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
    '        cmnDlgOpen.Filter = "Dump Files (*.dmp) |*.dmp"
    '        cmnDlgSave.Filter = "Dump Files (*.dmp) |*.dmp"
    '        cmnDlgOpen.FileName = "Backup"
    '        cmnDlgSave.FileName = "Backup"
    '        cmnDlgOpen.ShowDialog()
    '        cmnDlgSave.FileName = cmnDlgOpen.FileName
    '        Shell("cmd.exe /c IMP Explosives/explosives@orcl file='" & cmnDlgOpen.FileName & "' full=yes")
    '        Exit Sub
    'er:
    '        MsgBox(Err.Description, , "")
    '    End Sub

    '    Public Sub mnuLogin_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogin.Click
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'UserPass = "pass"
    '        'frmPassWords.Show()
    '        'Me.Hide()
    '    End Sub

    '    Public Sub mnuLogout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuLogout.Click, cmdLogOut.Click, cmdExit.Click
    '        cmdLogOut.PerformClick()
    '    End Sub

    '    Private Sub mnuPass_Click()
    '        ''UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'UserPass = "pass"
    '        'frmPassWords.Show()
    '        'Me.Hide()
    '    End Sub

    '    Private Sub mnuUser_Click()
    '        'UPGRADE_WARNING: Couldn't resolve default property of object UserPass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
    '        'UserPass = "user"
    '        'frmPassWords.Show()
    '        'Me.Hide()
    '    End Sub

    '    Public Sub mnuUsers_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuUsers.Click
    '        'MyForm = Me
    '        'frmUsers.Show()
    '        'Me.Hide()
    '    End Sub

    Private Sub btnConditions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConditions.Click
        If Application.OpenForms("frmConditions") Is Nothing Then
            Dim fConditions As New frmConditions()


            'fConditions.MdiParent = Me
            fConditions.ShowDialog()
            'fConditions.BringToFront()


        Else
            Application.OpenForms("frmConditions").Focus()

        End If
    End Sub

    Private Sub btnImportPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportPermissions.Click
        If Application.OpenForms("frmImportPermissions") Is Nothing Then
            Dim fImportPermissions As New frmImportPermissions()
            'fImportPermissions.MdiParent = Me
            fImportPermissions.ShowDialog()
            fImportPermissions.BringToFront()
        Else
            Application.OpenForms("frmImportPermissions").Focus()

        End If
    End Sub

    Private Sub btnImportAllowed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportAllowed.Click
        If Application.OpenForms("frmImportAllowed") Is Nothing Then
            Dim fImportAllowed As New frmImportAllowed()
            'fImportAllowed.MdiParent = Me
            fImportAllowed.ShowDialog()
        Else
            Application.OpenForms("frmImportAllowed").Focus()

        End If
    End Sub

    Private Sub btnPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPermissions.Click
        If Application.OpenForms("frmPassPermissions") Is Nothing Then
            Dim fPassPermissions As New frmPassPermissions()
            'fPassPermissions.MdiParent = Me
            fPassPermissions.ShowDialog()
        Else
            Application.OpenForms("frmPermissions").Focus()

        End If
    End Sub

    Private Sub btnPassCopies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPassCopies.Click
        If Application.OpenForms("frmPassCopies") Is Nothing Then
            Dim fPassCopies As New frmPassCopies()
            'fPassCopies.MdiParent = Me
            fPassCopies.ShowDialog()
        Else
            Application.OpenForms("frmPassCopies").Focus()

        End If
    End Sub

    Private Sub btnImportDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImportDoc.Click
        If Application.OpenForms("frmOurImport") Is Nothing Then
            Dim fOurImport As New frmOurImport()
            'fOurImport.MdiParent = Me
            fOurImport.ShowDialog()
        Else
            Application.OpenForms("frmOurImport").Focus()

        End If
    End Sub

    Private Sub btnOurRecent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Application.OpenForms("frmConditions") Is Nothing Then
            Dim fConditions As New frmConditions()
            'fConditions.MdiParent = Me
            fConditions.ShowDialog()
        Else
            Application.OpenForms("frmConditions").Focus()

        End If
    End Sub

    Private Sub btnAccounts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Application.OpenForms("frmConditions") Is Nothing Then
            Dim fConditions As New frmConditions()
            'fConditions.MdiParent = Me
            fConditions.ShowDialog()
        Else
            Application.OpenForms("frmConditions").Focus()

        End If
    End Sub

    Private Sub btnBalance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Application.OpenForms("frmBalance") Is Nothing Then
            Dim fBalance As New frmBalance()
            'fBalance.MdiParent = Me
            fBalance.ShowDialog()
        Else
            Application.OpenForms("frmBalance").Focus()

        End If
    End Sub

    Private Sub btnFuelStation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuelStation.Click
        If Application.OpenForms("frmFuelStation") Is Nothing Then
            Dim fFuelStation As New frmFuelStation()
            'fFuelStation.MdiParent = Me
            fFuelStation.ShowDialog()
        Else
            Application.OpenForms("frmFuelStation").Focus()

        End If
    End Sub

    Private Sub btnGasCenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGasCenter.Click
        If Application.OpenForms("frmGasCenter") Is Nothing Then
            Dim fGasCenter As New frmGasCenter()
            'fGasCenter.MdiParent = Me
            fGasCenter.ShowDialog()
        Else
            Application.OpenForms("frmGasCenter").Focus()

        End If
    End Sub

    Private Sub btnFinancial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinancial.Click
        If Application.OpenForms("frmFinance") Is Nothing Then
            Dim fFinance As New frmFinance()
            'fFinance.MdiParent = Me
            fFinance.ShowDialog()
        Else
            Application.OpenForms("frmFinance").Focus()

        End If
    End Sub

    Private Sub btnNonObjection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNonObjection.Click
        If Application.OpenForms("frmNoObjections") Is Nothing Then
            Dim fNoObjections As New frmNoObjections()
            'fNoObjections.MdiParent = Me
            fNoObjections.ShowDialog()
        Else
            Application.OpenForms("frmNoObjections").Focus()

        End If
    End Sub

    Private Sub btnWorkAllowed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkAllowed.Click
        If Application.OpenForms("frmWorkAllowed") Is Nothing Then
            Dim fWorkAllowed As New frmWorkAllowed()
            'fWorkAllowed.MdiParent = Me
            fWorkAllowed.ShowDialog()
        Else
            Application.OpenForms("frmWorkAllowed").Focus()

        End If
    End Sub

    Private Sub btnWorkPermissions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkPermissions.Click
        If Application.OpenForms("frmWorkPermissions") Is Nothing Then
            Dim fWorkPermissions As New frmWorkPermissions()
            'fWorkPermissions.MdiParent = Me
            fWorkPermissions.ShowDialog()
        Else
            Application.OpenForms("frmWorkPermissions").Focus()

        End If
    End Sub

    Private Sub btnWorkCopies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWorkCopies.Click
        If Application.OpenForms("frmWorkCopies") Is Nothing Then
            Dim fWorkCopies As New frmWorkCopies()
            'fWorkCopies.MdiParent = Me
            fWorkCopies.ShowDialog()
        Else
            Application.OpenForms("frmWorkCopies").Focus()

        End If
    End Sub

    Private Sub btnDistractDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDistractDoc.Click
        If Application.OpenForms("frmOurDistract") Is Nothing Then
            Dim fOurDistract As New frmOurDistract()
            'fOurDistract.MdiParent = Me
            fOurDistract.ShowDialog()
        Else
            Application.OpenForms("frmOurDistract").Focus()

        End If
    End Sub

    Private Sub btnOurRecentDistract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Application.OpenForms("frmOurRecentImport") Is Nothing Then
            Dim fOurRecentImport As New frmOurRecentImport()
            'fOurRecentImport.MdiParent = Me
            fOurRecentImport.ShowDialog()
        Else
            Application.OpenForms("frmOurRecentImport").Focus()

        End If
    End Sub

    Private Sub btnClasses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClasses.Click
        If Application.OpenForms("frmClasses") Is Nothing Then
            Dim fClasses As New frmClasses()
            'fClasses.MdiParent = Me
            fClasses.ShowDialog()
        Else
            Application.OpenForms("frmClasses").Focus()

        End If
    End Sub

    Private Sub btnTeams_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTeams.Click
        If Application.OpenForms("frmTeams") Is Nothing Then
            Dim fTeams As New frmTeams()
            'fTeams.MdiParent = Me
            fTeams.ShowDialog()
        Else
            Application.OpenForms("frmTeams").Focus()

        End If
    End Sub

    Private Sub btnGasDepot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGasDepot.Click
        If Application.OpenForms("frmGasDepot") Is Nothing Then
            Dim fGasDepot As New frmGasDepot()
            'fGasDepot.MdiParent = Me
            fGasDepot.ShowDialog()
        Else
            Application.OpenForms("frmGasDepot").Focus()

        End If
    End Sub

    Private Sub btnAmmo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmmo.Click
        If Application.OpenForms("frmAmmo") Is Nothing Then
            Dim fAmmo As New frmAmmo()
            'fWeapons.MdiParent = Me
            fAmmo.ShowDialog()
        Else
            Application.OpenForms("frmAmmo").Focus()

        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Application.Exit()
    End Sub

    Private Sub btnFireworks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

   
    Private Sub frmMain_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.OpenForms("frmLogin").Show()
    End Sub

    Private Sub MovementForms_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovementForms.Click
        If Application.OpenForms("frmMovementForms") Is Nothing Then
            Dim fMovementForms As New frmMovementForms()
            'fWeapons.MdiParent = Me
            fMovementForms.ShowDialog()
        Else
            Application.OpenForms("frmMovementForms").Focus()

        End If
    End Sub

    Private Sub btnFireworksRequests_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFireworksRequests.Click
        If Application.OpenForms("frmFireworksRequests") Is Nothing Then
            Dim fFireworksRequests As New frmFireworksRequests()
            'fWeapons.MdiParent = Me
            fFireworksRequests.ShowDialog()
        Else
            Application.OpenForms("frmFireworksRequests").Focus()

        End If
    End Sub
End Class