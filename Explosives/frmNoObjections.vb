Option Strict Off
Option Explicit On
Imports Microsoft.Office.Interop
Friend Class frmNoObjections
	Inherits System.Windows.Forms.Form
    'Private RS As New ADODB.Recordset
    'Private r As New ADODB.Recordset
    'Private dtrRS As New ADODB.Recordset
	Private dtrWhere, dtrGroup, dtrSQL, SQL, IDbefore2, Its, IDbefore, Rscnt, sqlDuration, dtrSelect, dtrHaving, dtrCompute As Object
	Private Loaded, Searched As Boolean
	Private Pay As Boolean
    Private ItemDx As Short
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
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
   
    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
    End Sub
	
	
	'UPGRADE_WARNING: Event cmbCriteria.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbCriteria_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbCriteria.SelectedIndexChanged
		txtFind_TextChanged(txtFind, New System.EventArgs())
	End Sub
	
	'UPGRADE_WARNING: Event cmbDuration.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmbDuration_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmbDuration.SelectedIndexChanged
		
		'UPGRADE_WARNING: Couldn't resolve default property of object sqlDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If cmbDuration.Text = "⁄«„" Then sqlDuration = " And ( FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' Or SDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
		'UPGRADE_WARNING: Couldn't resolve default property of object sqlDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If cmbDuration.Text = "› —… » «—ÌŒ «·„·›" Then sqlDuration = " And ( FDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
		'UPGRADE_WARNING: Couldn't resolve default property of object sqlDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If cmbDuration.Text = "› —… » «—ÌŒ «·Œÿ«»" Then sqlDuration = " And ( SDate Between '" & VB6.Format(txtDate1.Text, "DD/MM/YYYY") & "' And '" & VB6.Format(txtDate2.Text, "DD/MM/YYYY") & "' )"
	End Sub
	
	'UPGRADE_WARNING: Event cmdCancel.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdCancel_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCancel.CheckStateChanged
		Dim x As Object
		If cmdCancel.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ ≈·€«¡ «·≈÷«›…/«· ⁄œÌ· ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
			If x = MsgBoxResult.Yes Then
                'TextLock()
                'clr()
                MsgBox(" ‹‹‹‹‹„ «·≈·‹‹‹€‹‹‹«¡ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRtlReading + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkOnly)
				'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				Its = ""
                DisableSave()
			End If
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdDelete.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdDelete_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDelete.CheckStateChanged
		Dim x As Object
          x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰ Õ–› Â–« «· ’—ÌÕ ø", MsgBoxStyle.Question + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo)
        If x = MsgBoxResult.Yes Then
            NOOBJECTIONSBindingSource.RemoveCurrent()

            NOOBJECTIONSTableAdapter.Update(DsExplosives.NOOBJECTIONS)
            MsgBox(" „ «·Õ–› !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
            DisableSave()
        End If

	End Sub
	
	'UPGRADE_WARNING: Event cmdEdit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdEdit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEdit.CheckStateChanged
        EnableSave()

	End Sub
	
	'UPGRADE_WARNING: Event cmdExit.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdExit_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close()

	End Sub
	
	'UPGRADE_WARNING: Event cmdFirst.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFirst_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFirst.CheckStateChanged
        NOOBJECTIONSBindingSource.MoveFirst()
        DataGridView1.Rows.Clear()
        Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.DsExplosives.NoObjectionDetails, Convert.ToInt32(txtfID.Text))

        For i As Integer = 0 To Me.DsExplosives.NoObjectionDetails.Rows.Count - 1
            DataGridView1.Rows.Add(Me.DsExplosives.NoObjectionDetails.Rows(i)("Quantity"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Unit"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Class"))
        Next
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtAll.CheckStateChanged
	
	End Sub
	
	'UPGRADE_WARNING: Event cmdFmtDoc.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdFmtDoc_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtDoc.CheckStateChanged
        'NOOBJECTIONSBindingSource.EndEdit()

        'Dim fPrintNoObjection As New frmPrintNoObjection(Convert.ToInt32(txtfID.Text))
        'fPrintNoObjection.ShowDialog()
        Dim oTable As Word.Table
        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")

        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "NoObjection.docx")
        oWord.Visible = True

        EditBookMark("COUNTRY", cmbCountry.Text)
        EditBookMark("Date", dtpFDate.Value.ToString("dd-MMM-yyyy"))
        EditBookMark("EXPORTER", txtExporter.Text)
        EditBookMark("FSIDENAME", txtfSideName.Text)
        'EditBookMark("ArabicDate", StretchArabicMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
        'EditBookMark("EnglishDate", StretchEnglishMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Number", txtNoObjectionNO.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("Rank", cmbRank.Text)

        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("Table").Range, DataGridView1.Rows.Count + 1, 4)
        oTable.Range.ParagraphFormat.SpaceAfter = 6

        oTable.Cell(1, 1).Range.Text = "No"
        oTable.Cell(1, 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 1).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 2).Range.Text = "Qty"
        oTable.Cell(1, 2).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 2).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 3).Range.Text = "Unit"
        oTable.Cell(1, 3).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 3).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 4).Range.Text = "Description"
        oTable.Cell(1, 4).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 4).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        
        For r = 2 To DataGridView1.Rows.Count + 1
            For c = 1 To 4
                If c = 1 Then
                    oTable.Cell(r, c).Range.Text = r - 1
                    oTable.Cell(r, c).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                ElseIf c = 2 Then
                    oTable.Cell(r, c).Range.Text = DataGridView1.Rows(r - 2).Cells("Quantity").Value.ToString + " - " + DataGridView1.Rows(r - 2).Cells("Unit").Value.ToString
                    oTable.Cell(r, c).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                ElseIf c = 3 Then
                    oTable.Cell(r, c).Range.Text = DataGridView1.Rows(r - 2).Cells("Unit").Value.ToString
                    oTable.Cell(r, c).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                Else
                    oTable.Cell(r, c).Range.Text = DataGridView1.Rows(r - 2).Cells("Description").Value
                    oTable.Cell(r, c).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                End If
            Next
        Next
        oTable.AllowAutoFit = True
        Dim firstCol As Word.Column = oTable.Columns(1)
        firstCol.AutoFit()
        Dim firstColAutoWidth As Single = firstCol.Width
        oTable.AutoFitBehavior(Word.WdAutoFitBehavior.wdAutoFitWindow)
        firstCol.SetWidth(30, Word.WdRulerStyle.wdAdjustFirstColumn)
    End Sub
	
	'UPGRADE_WARNING: Event cmdFmtFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdFmtFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFmtFound.CheckStateChanged

		'On Error GoTo er
        'Dim r As New ADODB.Recordset
        'Dim ds As New ADODB.Command
		If cmdFmtFound.CheckState = 1 Then
            'If r.State = ADODB.ObjectStateEnum.adStateOpen Then r.Close()
            'r.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            'ds.let_ActiveConnection(DB)
            'ds.CommandText = "alter session set nls_date_format='dd/mm/yyyy'"
            'ds.Execute()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrCompute. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrSelect. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'r.Open(dtrSelect & " ( " & SQL & " ) " & dtrCompute, DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsfmt.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsfmt.DataSource = r
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsfmt.Refresh. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsfmt.Refresh()
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsfmt.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsfmt.Show()
            'r.Close()
            cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		cmdFmtFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
	End Sub
	
	'UPGRADE_WARNING: Event cmdLast.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub cmdLast_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLast.CheckStateChanged
        NOOBJECTIONSBindingSource.MoveLast()
        DataGridView1.Rows.Clear()
        Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.DsExplosives.NoObjectionDetails, Convert.ToInt32(txtfID.Text))

        For i As Integer = 0 To Me.DsExplosives.NoObjectionDetails.Rows.Count - 1
            DataGridView1.Rows.Add(Me.DsExplosives.NoObjectionDetails.Rows(i)("Quantity"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Unit"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Class"))
        Next
    End Sub
	
	'UPGRADE_WARNING: Event cmdLogout.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdLogout_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdLogout.CheckStateChanged
        'If cmdLogout.CheckState = 1 Then LogOut()
	End Sub
	
	'UPGRADE_WARNING: Event cmdNew.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNew_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then

            DataGridView1.Rows.Clear()
            NOOBJECTIONSBindingSource.AddNew()
            IsAdd = True
            dtpFDate.Value = DateTime.Now
            cmbCountry.SelectedIndex = 0

           If cmbRank.Items.Count > 0 Then
                cmbRank.SelectedIndex = 0
            End If
            If cmbName.Items.Count > 0 Then
                cmbName.SelectedIndex = 0
            End If
            If cmbPosition.Items.Count > 0 Then
                cmbPosition.SelectedIndex = 0
            End If
            EnableSave()
        End If

    End Sub
	
	'UPGRADE_WARNING: Event cmdNext.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdNext_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdNext.CheckStateChanged
        NOOBJECTIONSBindingSource.MoveNext()
        DataGridView1.Rows.Clear()
        Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.DsExplosives.NoObjectionDetails, Convert.ToInt32(txtfID.Text))

        For i As Integer = 0 To Me.DsExplosives.NoObjectionDetails.Rows.Count - 1
            DataGridView1.Rows.Add(Me.DsExplosives.NoObjectionDetails.Rows(i)("Quantity"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Unit"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Class"))
        Next
	End Sub
	
	'UPGRADE_WARNING: Event cmdPlus.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPlus_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPlus.CheckStateChanged
        DataGridView1.Rows.Add(nudQuantity.Value, cmbUnit.Text, cmbClass.Text)
        nudQuantity.Value = 0
        If cmbUnit.Items.Count <> 0 Then
            cmbUnit.SelectedIndex = 0
        End If
        If cmbClass.Items.Count <> 0 Then
            cmbClass.SelectedIndex = 0
        End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdPrev.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdPrev_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdPrev.CheckStateChanged
        NOOBJECTIONSBindingSource.MovePrevious()
        DataGridView1.Rows.Clear()
        Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.DsExplosives.NoObjectionDetails, Convert.ToInt32(txtfID.Text))

        For i As Integer = 0 To Me.DsExplosives.NoObjectionDetails.Rows.Count - 1
            DataGridView1.Rows.Add(Me.DsExplosives.NoObjectionDetails.Rows(i)("Quantity"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Unit"),
                                   Me.DsExplosives.NoObjectionDetails.Rows(i)("Class"))
        Next
	End Sub
	
	'UPGRADE_WARNING: Event cmdRefresh.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRefresh_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRefresh.CheckStateChanged
		If cmdRefresh.CheckState = 1 Then
			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Its = ""
			
			cmdRefresh.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdRemove.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRemove_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRemove.CheckStateChanged
		If cmdRemove.CheckState = 1 Then
			On Error Resume Next
			
			cmdRemove.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
	End Sub
	
	'UPGRADE_WARNING: Event cmdReturn.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdReturn_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()

	End Sub
	
	'UPGRADE_WARNING: Event cmdRptAll.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptAll_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptAll.CheckStateChanged
		Dim dtrNoObjectionsTab As Object
		On Error GoTo er
        'Dim s As New ADODB.Recordset
		If cmdRptAll.CheckState = 1 Then
            'If s.State = ADODB.ObjectStateEnum.adStateOpen Then s.Close()
            's.Open("Shape {Select * From NoObjections Order By ID,Pos} As cmd Compute cmd By 'ID','fDate','fSideName','SID','sSideName','SDate','Exporter','Country'", DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.DataSource = s
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.Show()
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
		Dim dtrNoObjectionsTab As Object
		On Error GoTo er
        'Dim s As New ADODB.Recordset
		If cmdRptDoc.CheckState = 1 Then
            'If s.State = ADODB.ObjectStateEnum.adStateOpen Then s.Close()
            's.Open("Shape {Select * From NoObjections Where ID='" & txtfID.Text & "' Order By ID,Pos} As cmd Compute cmd By 'ID','fDate','fSideName','SID','sSideName','SDate','Exporter','Country'", DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.DataSource = s
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.Show()
            'cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdRptDoc.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
	
	'UPGRADE_WARNING: Event cmdRptFound.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdRptFound_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdRptFound.CheckStateChanged
		Dim dtrNoObjectionsTab As Object
		On Error GoTo er
        'Dim s As New ADODB.Recordset
		If cmdRptFound.CheckState = 1 Then
            'If s.State = ADODB.ObjectStateEnum.adStateOpen Then s.Close()
            ''UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            's.Open("Shape {Select * From (" & SQL & ") Order By ID,Pos} As cmd Compute cmd By 'ID','fDate','fSideName','SID','sSideName','SDate','Exporter','Country'", DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.DataSource = s
            ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'dtrNoObjectionsTab.Show()
			cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
		End If
		Exit Sub
er: 
		MsgBox(Err.Description, MsgBoxStyle.Critical)
		Err.Clear()
		cmdRptFound.CheckState = System.Windows.Forms.CheckState.Unchecked
	End Sub
    Dim IsAdd As Boolean = False
	'UPGRADE_WARNING: Event cmdSave.CheckStateChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub cmdSave_CheckStateChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSave.CheckStateChanged
        'On Error GoTo er
        If DataGridView1.Rows.Count = 0 Then
            MsgBox("ﬁ«∆„… «·„Ê«œ ›«—€…")
        Else
            If IsAdd And txtNoObjectionNO.Text = "" Then
                Dim dtNoObjectionNo As New dsExplosives.NOOBJECTIONSDataTable
                dtNoObjectionNo = New dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter().GetDataByMaxNoObjectionNo_Year(dtpFDate.Value.Year)
                If IsDBNull(dtNoObjectionNo(0)("NoObjectionNo")) Then
                    txtNoObjectionNO.Text = 1
                Else
                    If dtNoObjectionNo.Rows.Count = 0 Then
                        txtNoObjectionNO.Text = 1
                    Else

                        txtNoObjectionNO.Text = dtNoObjectionNo(0).NoObjectionNo + 1
                    End If
                End If

            End If
            NOOBJECTIONSBindingSource.EndEdit()
            NOOBJECTIONSTableAdapter.Update(DsExplosives.NOOBJECTIONS)

            NoObjectionDetailsTableAdapter.DeleteByNoObjectionID(Convert.ToInt32(txtfID.Text))
            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                NoObjectionDetailsTableAdapter.Insert(DataGridView1.Rows(i).Cells("Description").Value.ToString,
                                       DataGridView1.Rows(i).Cells("Unit").Value.ToString,
                                       DataGridView1.Rows(i).Cells("Quantity").Value.ToString, Convert.ToInt32(txtfID.Text))
            Next
            MsgBox(" „ «·‹Õ‹‹›‹‹Ÿ !", MsgBoxStyle.Information + MsgBoxStyle.MsgBoxRight)
            IsAdd = False
            DisableSave()

        End If

    End Sub
	
	Private Sub Combo2_Change()
		
	End Sub
	
	'UPGRADE_WARNING: Form event frmNoObjections.Activate has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
	Private Sub frmNoObjections_Activated(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Activated
        'LoadAllSettings()
        'ApplySettings()
		cmdRefresh.Width = Me.ClientRectangle.Width

        'MyForm = frmMain
    End Sub
	
	Private Sub frmNoObjections_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.NOOBJECTIONS' table. You can move, or remove it, as needed.
        Me.NOOBJECTIONSTableAdapter.Fill(Me.DsExplosives.NOOBJECTIONS)
        Me.NOOBJECTIONSTableAdapter.FillDistinctRank(Me.RankDsExplosives1.NOOBJECTIONS)
        Me.NOOBJECTIONSTableAdapter.FillDistinctName(Me.NameDsExplosives1.NOOBJECTIONS)
        Me.NOOBJECTIONSTableAdapter.FillDistinctPosition(Me.PositionDsExplosives1.NOOBJECTIONS)
        If txtfID.Text <> "" Or txtfID.Text <> " " Then
            If DsExplosives.NOOBJECTIONS.Rows.Count > 0 Then



                Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.DsExplosives.NoObjectionDetails, Convert.ToInt32(txtfID.Text))

                For i As Integer = 0 To Me.DsExplosives.NoObjectionDetails.Rows.Count - 1
                    DataGridView1.Rows.Add(Me.DsExplosives.NoObjectionDetails.Rows(i)("Quantity"),
                                           Me.DsExplosives.NoObjectionDetails.Rows(i)("Unit"),
                                           Me.DsExplosives.NoObjectionDetails.Rows(i)("Class"))
                Next
            End If
        End If
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (NOOBJECTIONSBindingSource.Position + 1).ToString + " / " + NOOBJECTIONSBindingSource.Count.ToString

	End Sub
	
	Private Sub frmNoObjections_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'ProgramExit()
		'UPGRADE_ISSUE: Event parameter Cancel was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FB723E3C-1C06-4D2B-B083-E6CD0D334DA8"'
        'Cancel = MyCancel
	End Sub
	
	'UPGRADE_ISSUE: Frame event Frame10.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Frame10_DblClick()

        'Dim s As New ADODB.Recordset
        'If s.State = ADODB.ObjectStateEnum.adStateOpen Then s.Close()
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''UPGRADE_WARNING: Couldn't resolve default property of object sqlDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        's.Open("Shape {Select * From (Select * From NoObjections Where " & sqlDuration & ") " & dtrWhere & "   Order By ID,Pos} As cmd Compute cmd By 'ID','fDate','fSideName','SID','sSideName','SDate','Exporter','Country'", DBshp, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockReadOnly)
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.DataSource. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrNoObjectionsTab.DataSource = s
        ''UPGRADE_WARNING: Couldn't resolve default property of object dtrNoObjectionsTab.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dtrNoObjectionsTab.Show()
	End Sub
	
	'UPGRADE_ISSUE: Frame event Frame7.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Frame7_DblClick()
        'MsgBox(RS.RecordCount)
	End Sub
	
	'UPGRADE_ISSUE: Frame event Frame9.DblClick was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub Frame9_DblClick()
		
		'MsgBox Loaded
	End Sub
	
	'UPGRADE_WARNING: Event lstAmmount.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstAmmount_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim lstRecord As Object
        Dim lstClassID As Object
        On Error Resume Next
       
    End Sub
	
	
	
    Private Sub lstAmmount_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub
	
	'UPGRADE_WARNING: Event lstClass.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstClass_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
      
    End Sub
	
    Private Sub lstClass_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        'On Error Resume Next
        'txtAmmount.Text = VB6.GetItemString(lstAmmount, lstClass.SelectedIndex)
        'txtClass.Text = VB6.GetItemString(lstClass, lstClass.SelectedIndex)
        'txtUnit.Text = VB6.GetItemString(lstUnit, lstClass.SelectedIndex)
       
    End Sub
	
    Private Sub lstClass_KeyDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyEventArgs)
      
    End Sub
	
	'UPGRADE_WARNING: Event lstUnit.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstUnit_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
       
    End Sub
	
    Private Sub lstUnit_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)

    End Sub
	
	Public Sub mnuColours_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuColours.Click
		'UPGRADE_ISSUE: Form method frmImportPermissions.PopupMenu was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="CC4C7EC0-C903-48FC-ACCC-81861D12DA4A"'
        'frmImportPermissions.PopupMenu(frmImportPermissions.mnuColours,  ,  , 0)
	End Sub
	
	Public Sub mnuPay_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles mnuPay.Click
		Pay = True
		cmdEdit.CheckState = System.Windows.Forms.CheckState.Checked
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
	
    Private Sub txtAmmount_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
    Private Sub txtClass_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub
	
	'UPGRADE_WARNING: Event txtDate1.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate1_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Loaded = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub
	
	'UPGRADE_WARNING: Event txtDate2.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub txtDate2_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        If Loaded = True Then txtFind_TextChanged(txtFind, New System.EventArgs())
    End Sub
	
    Private Sub txtfID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtfID.Leave, txtNoObjectionNO.Leave
        Dim x As Object
        On Error Resume Next
        'UPGRADE_ISSUE: Control Name could not be resolved because it was within the generic namespace ActiveControl. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="084D22AD-ECB1-400F-B4C7-418ECEC5E36E"'
        If Me.ActiveControl.Name = "cmdCancel" Or System.Windows.Forms.Form.ActiveForm.Name <> Me.Name Then Exit Sub
        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If Its = "add" Or (Its = "edit" And txtfID.Text <> IDbefore) Then
            If txtfID.Text = vbNullString Then
                'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                x = MsgBox("⁄›Ê« ! ·« Ì„ﬂ‰ﬂ  —ﬂ „ﬂ«‰ —ﬁ„ «·„·› ›«—€‹‹‹‹«.", MsgBoxStyle.Critical + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.OkCancel)
                If x = MsgBoxResult.Ok Then
                    txtfID.Focus()
                ElseIf x = MsgBoxResult.Cancel Then
                    cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                End If
            Else
                'If RS.RecordCount > 0 Then
                '            RS.MoveFirst()
                '            RS.Find("ID='" & txtfID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '            If RS.EOF = False Then
                '                If VB6.Format(RS.Fields("FDate").Value, "yyyy") = VB6.Format(Today, "yyyy") Then
                '                    'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '                    x = MsgBox("⁄›Ê ! Â–« «· ’—ÌÕ „ÊÃÊœ. Â·  Êœ/Ì‰ —ƒÌ… »Ì«‰« Â ø", MsgBoxStyle.YesNoCancel + MsgBoxStyle.MsgBoxRight + MsgBoxStyle.Critical)
                '                    If x = MsgBoxResult.Yes Then
                '                        FromDB()
                '                        'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '                        Its = ""
                '                        'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '                        IDbefore = ""
                '                        EnDis(False, False, True)
                '                        TextLock()
                '                    ElseIf x = MsgBoxResult.No Then
                '                        txtfID.Focus()
                '                    ElseIf x = MsgBoxResult.Cancel Then
                '                        cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '                    End If
                '                End If
                '            End If
                'Else
                '            RS.MoveFirst()
                '            'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '            RS.Find("ID='" & IDbefore & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '            txtfDate.Focus()
                '        End If
            End If
        End If
    End Sub
	
	'UPGRADE_WARNING: Event txtFind.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtFind_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtFind.TextChanged
		On Error Resume Next
		If Loaded = True Then
            'If RS.State = ADODB.ObjectStateEnum.adStateOpen Then RS.Close()
			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If Searched <> True Then IDbefore = txtfID.Text
			Searched = True
			cmbDuration_SelectedIndexChanged(cmbDuration, New System.EventArgs())
			If cmbCriteria.Text = "⁄«„" Then
				If IsDate(txtFind.Text) Then
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'dtrWhere = " Where (ID='" & txtFind.Text & "' Or FDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' Or FSideName Like '%" & txtFind.Text & "%' Or SID='" & txtFind.Text & "' Or SDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' Or sSideName Like '%" & txtFind.Text & "%' Or Exporter Like '%" & txtFind.Text & "%' Or Country Like '%" & txtFind.Text & "%' Or Class Like '%" & txtFind.Text & "%' "
				Else
					'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					dtrWhere = " Where (ID='" & txtFind.Text & "' Or FSideName Like '%" & txtFind.Text & "%' Or SID='" & txtFind.Text & "' Or sSideName Like '%" & txtFind.Text & "%' Or Exporter Like '%" & txtFind.Text & "%' Or Country Like '%" & txtFind.Text & "%' Or Class Like '%" & txtFind.Text & "%' "
				End If
			ElseIf cmbCriteria.Text = "‰„—… «·„·›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where ( ID='" & txtFind.Text & "' "
			ElseIf cmbCriteria.Text = " «—ÌŒ «·„·›" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                'dtrWhere = " Where (FDate='" & VB6.Format(txtFind.Text, "DD/MM/YYYY") & "' "
			ElseIf cmbCriteria.Text = " «—ÌŒ Œÿ«» «·ÃÂ… «·ÿ«·»…" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where ( SDate='" & txtFind.Text & "' "
			ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„√–Ê‰ ·Â«" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where (FSideName Like '%" & txtFind.Text & "%' "
			ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„Œ«ÿ»…" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where ( sSideName Like '%" & txtFind.Text & "%' "
			ElseIf cmbCriteria.Text = "«”„ «·ÃÂ… «·„” Ê—œ „‰Â«" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where ( Exporter Like '%" & txtFind.Text & "%' "
			ElseIf cmbCriteria.Text = "«”„ «·œÊ·…" Then 
				'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				dtrWhere = " Where ( Country Like '%" & txtFind.Text & "%' "
			End If
            'If IsDate(txtDate1.Text) = False Or IsDate(txtDate2.Text) = False And txtDate1.Text <> txtDate2.Text Then
            '	'UPGRADE_WARNING: Couldn't resolve default property of object sqlDuration. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrWhere = dtrWhere & ") And " & sqlDuration
            'Else
            '	'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '	dtrWhere = dtrWhere & ")"
            'End If
			'UPGRADE_WARNING: Couldn't resolve default property of object dtrWhere. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: Couldn't resolve default property of object SQL. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			SQL = "Select * From NoObjections " & dtrWhere & " Order By To_Char(FDate, 'yyyy'), To_Number(ID),Pos"
			' MsgBox SQL
            'RS.Open(SQL, DB, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockPessimistic)

		End If
	End Sub
	
	Private Sub txtsID_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtsID.Leave
		Dim x As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If Its = "add" Or (Its = "edit" And IDbefore2 <> txtSID.Text) Then
			If txtSID.Text = "" Then
				'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				x = MsgBox("Â· √‰  „ √ﬂœ/… „‰ √‰ﬂ  —Ìœ/Ì‰  —ﬂ „ﬂ«‰ —ﬁ„ «·Œÿ«» ›«—€‹‹‹‹‹« ø —»„« ÌƒœÌ Â–« ≈·Ï  ÷«—» ›Ì «·»Ì«‰« ", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel + MsgBoxStyle.MsgBoxRight)
				If x = MsgBoxResult.No Then
					txtSID.Focus()
				ElseIf x = MsgBoxResult.Cancel Then 
					cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
				ElseIf x = MsgBoxResult.Yes Then 
					Exit Sub
				End If
			Else
                'If RS.RecordCount > 0 Then
                '	RS.MoveFirst()
                '	RS.Find("SID='" & txtSID.Text & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	If RS.EOF = False Then
                '		'UPGRADE_WARNING: Couldn't resolve default property of object x. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		x = MsgBox(" „  Õ—Ì—  ’—ÌÕ ⁄œ„ „„«‰⁄… ·Â–« «·Œÿ«». Â·  Êœ/Ì‰ —ƒÌ Â ø", MsgBoxStyle.Critical + MsgBoxStyle.YesNoCancel + MsgBoxStyle.MsgBoxRight)
                '		If x = MsgBoxResult.Yes Then
                '			FromDB()
                '			TextLock()
                '			'UPGRADE_WARNING: Couldn't resolve default property of object Its. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			Its = ""
                '			'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '			IDbefore = ""
                '			EnDis(False, False, True)
                '		ElseIf x = MsgBoxResult.No Then 
                '			txtSID.Focus()
                '		ElseIf x = MsgBoxResult.Cancel Then 
                '			cmdCancel.CheckState = System.Windows.Forms.CheckState.Checked
                '		End If
                '	Else
                '		RS.MoveFirst()
                '		'UPGRADE_WARNING: Couldn't resolve default property of object IDbefore2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                '		RS.Find("SID='" & IDbefore2 & "'", 0, ADODB.SearchDirectionEnum.adSearchForward, 0)
                '	End If
                'End If
			End If
		End If
	End Sub
	
    Private Sub txtUnit_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs)
        Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
        If KeyAscii = 13 Then cmdPlus.CheckState = System.Windows.Forms.CheckState.Checked
        eventArgs.KeyChar = Chr(KeyAscii)
        If KeyAscii = 0 Then
            eventArgs.Handled = True
        End If
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged

    End Sub

    Private Sub cmbClass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress
        If Asc(e.KeyChar) = 13 Then
            DataGridView1.Rows.Add(nudQuantity.Value, cmbUnit.Text, cmbClass.Text)
            nudQuantity.Value = 0
            If cmbUnit.Items.Count <> 0 Then
                cmbUnit.SelectedIndex = 0
            End If
            If cmbClass.Items.Count <> 0 Then
                cmbClass.SelectedIndex = 0
            End If
        End If
    End Sub
End Class