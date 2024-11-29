Imports Microsoft.Office.Interop

Public Class frmFireworksRequests
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
    End Sub
    Private Sub frmFireworksRequests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SenderDsExplosives1.IMPORTALLOWED' table. You can move, or remove it, as needed.
        Me.IMPORTALLOWEDTableAdapter.FillByIsDistractor(Me.DsExplosives.IMPORTALLOWED, True)


        Me.FireworksRequestsTableAdapter.Fill(Me.DsExplosives.FireworksRequests)
        Me.FireworksRequestsTableAdapter.FillDistinctName(Me.NameDsExplosives1.FireworksRequests)
        Me.FireworksRequestsTableAdapter.FillDistinctRank(Me.RankDsExplosives1.FireworksRequests)
        Me.FireworksRequestsTableAdapter.FillDistinctPosition(Me.PositionDsExplosives1.FireworksRequests)
        Me.FireworksRequestsTableAdapter.FillDistinctSender(Me.SenderDsExplosives1.FireworksRequests)

        WORKPERMISSIONSTableAdapter.FillDistinctFSideName(Me.ReceiverDsExplosives1.WORKPERMISSIONS)

        Dim dtCLASSES As New dsExplosives.CLASSESDataTable
        dtCLASSES = New dsExplosivesTableAdapters.CLASSESTableAdapter().GetDataDistinctUnit()
        For i As Integer = 0 To dtCLASSES.Rows.Count - 1
            cmbUnit.Items.Add(dtCLASSES(i).UNIT)
        Next

        If cmbRank.Items.Count > 0 Then
            cmbRank.SelectedIndex = 0
        End If
        If cmbName.Items.Count > 0 Then
            cmbName.SelectedIndex = 0
        End If
        If cmbPosition.Items.Count > 0 Then
            cmbPosition.SelectedIndex = 0
        End If

        GetFireworksRequestDetails()
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (FireworksRequestsBindingSource.Position + 1).ToString + " / " + FireworksRequestsBindingSource.Count.ToString

   
        'Dim oDoc As Word.Document
        'Dim oTable As Word.Table
        'Dim oPara1 As Word.Paragraph, oPara2 As Word.Paragraph
        'Dim oPara3 As Word.Paragraph, oPara4 As Word.Paragraph
        'Dim oRng As Word.Range
        'Dim oShape As Word.InlineShape
        'Dim oChart As Object
        'Dim Pos As Double

        ''Start Word and open the document template.
        'oWord = CreateObject("Word.Application")
        'oWord.Visible = True
        'oDoc = oWord.Documents.Add

        ''Insert a paragraph at the beginning of the document.
        'oPara1 = oDoc.Content.Paragraphs.Add
        'oPara1.Range.Text = "Heading 1"
        'oPara1.Range.Font.Bold = True
        'oPara1.Format.SpaceAfter = 24    '24 pt spacing after paragraph.
        'oPara1.Range.InsertParagraphAfter()

        ''Insert a paragraph at the end of the document.
        ''** \endofdoc is a predefined bookmark.
        'oPara2 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        'oPara2.Range.Text = "Heading 2"
        'oPara2.Format.SpaceAfter = 6
        'oPara2.Range.InsertParagraphAfter()

        ''Insert another paragraph.
        'oPara3 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        'oPara3.Range.Text = "This is a sentence of normal text. Now here is a table:"
        'oPara3.Range.Font.Bold = False
        'oPara3.Format.SpaceAfter = 24
        'oPara3.Range.InsertParagraphAfter()

        ''Insert a 3 x 5 table, fill it with data, and make the first row
        ''bold and italic.
        'Dim r As Integer, c As Integer
        'oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 3, 5)
        'oTable.Range.ParagraphFormat.SpaceAfter = 6
        'For r = 1 To 3
        '    For c = 1 To 5
        '        oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
        '    Next
        'Next
        'oTable.Rows.Item(1).Range.Font.Bold = True
        'oTable.Rows.Item(1).Range.Font.Italic = True

        ''Add some text after the table.
        ''oTable.Range.InsertParagraphAfter()
        'oPara4 = oDoc.Content.Paragraphs.Add(oDoc.Bookmarks.Item("\endofdoc").Range)
        'oPara4.Range.InsertParagraphBefore()
        'oPara4.Range.Text = "And here's another table:"
        'oPara4.Format.SpaceAfter = 24
        'oPara4.Range.InsertParagraphAfter()

        ''Insert a 5 x 2 table, fill it with data, and change the column widths.
        'oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 5, 2)
        'oTable.Range.ParagraphFormat.SpaceAfter = 6
        'For r = 1 To 5
        '    For c = 1 To 2
        '        oTable.Cell(r, c).Range.Text = "r" & r & "c" & c
        '    Next
        'Next
        'oTable.Columns.Item(1).Width = oWord.InchesToPoints(2)   'Change width of columns 1 & 2
        'oTable.Columns.Item(2).Width = oWord.InchesToPoints(3)

        ''Keep inserting text. When you get to 7 inches from top of the
        ''document, insert a hard page break.
        'Pos = oWord.InchesToPoints(7)
        'oDoc.Bookmarks.Item("\endofdoc").Range.InsertParagraphAfter()
        'Do
        '    oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        '    oRng.ParagraphFormat.SpaceAfter = 6
        '    oRng.InsertAfter("A line of text")
        '    oRng.InsertParagraphAfter()
        'Loop While Pos >= oRng.Information(Word.WdInformation.wdVerticalPositionRelativeToPage)
        'oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        'oRng.InsertBreak(Word.WdBreakType.wdPageBreak)
        'oRng.Collapse(Word.WdCollapseDirection.wdCollapseEnd)
        'oRng.InsertAfter("We're now on page 2. Here's my chart:")
        'oRng.InsertParagraphAfter()

        ''Insert a chart and change the chart.
        'oShape = oDoc.Bookmarks.Item("\endofdoc").Range.InlineShapes.AddOLEObject( _
        '    ClassType:="MSGraph.Chart.8", FileName _
        '    :="", LinkToFile:=False, DisplayAsIcon:=False)
        'oChart = oShape.OLEFormat.Object
        'oChart.charttype = 4 'xlLine = 4
        'oChart.Application.Update()
        'oChart.Application.Quit()
        ''If desired, you can proceed from here using the Microsoft Graph 
        ''Object model on the oChart object to make additional changes to the
        ''chart.
        'oShape.Width = oWord.InchesToPoints(6.25)
        'oShape.Height = oWord.InchesToPoints(3.57)

        ''Add text after the chart.
        'oRng = oDoc.Bookmarks.Item("\endofdoc").Range
        'oRng.InsertParagraphAfter()
        'oRng.InsertAfter("THE END.")

        ''All done. Close this form.
        'Me.Close()
    End Sub

    Private Sub cmdCancel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdFindPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdFindNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Function NumbetToText(ByVal Number As Integer) As String
        Dim Text As String
        Select Case Number
            Case 1
                Text = "واحد"
            Case 2
                Text = "أثنان"
            Case 3
                Text = "ثلاثة"
            Case 4
                Text = "أربعة"
            Case 5
                Text = "خمسة"
            Case 6
                Text = "ستة"
            Case 7
                Text = "سبعة"
            Case 8
                Text = "ثمانية"
            Case 9
                Text = "تسعة"
            Case 10
                Text = "عشرة"
            Case 11
                Text = "أحد عشر"
            Case 12
                Text = "أثنا عشر"
            Case 13
                Text = "ثلاثة عشر"
            Case 14
                Text = "أربعة عشر"
            Case 15
                Text = "خمسة عشر"
            Case 16
                Text = "ستة عشر"
            Case 17
                Text = "سبعة عشر"
            Case 18
                Text = "ثمانية عشر"
            Case 19
                Text = "تسعة عشر"
            Case 20
                Text = "عشرون"
            Case 21
                Text = "واحد وعشرون"
        End Select
        NumbetToText = Text
    End Function

    Private Sub cmdPrintDoc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintDoc.CheckedChanged
        Dim oTable As Word.Table
        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")

        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "FireworksRequest.docx")
        oWord.Visible = True

        EditBookMark("ArabicDate", DateTime.Now.Date.ToString("dd/MM/yyyy"))
        EditBookMark("EnglishDate", DateTime.Now.Date.ToShortDateString)
        EditBookMark("Sender", txtSender.Text)
        EditBookMark("Receiver", txtReceiver.Text)
        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("Number", NumbetToText(DataGridView1.Rows.Count))
        If DataGridView1.Rows.Count > 2 And DataGridView1.Rows.Count < 11 Then
            EditBookMark("Classes", "أصناف")
        
        Else
            EditBookMark("Classes", "صنف")
        End If
        oTable = oDoc.Tables.Add(oDoc.Bookmarks.Item("Table").Range, DataGridView1.Rows.Count + 1, 4)
        oTable.Range.ParagraphFormat.SpaceAfter = 6

        oTable.Cell(1, 1).Range.Text = "م"
        oTable.Cell(1, 1).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 1).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 2).Range.Text = "الكمية"
        oTable.Cell(1, 2).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 2).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 3).Range.Text = "الوحدة"
        oTable.Cell(1, 3).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 3).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
        oTable.Cell(1, 4).Range.Text = "الصنف"
        oTable.Cell(1, 4).Range.Shading.BackgroundPatternColor = Word.WdColor.wdColorGray10
        oTable.Cell(1, 4).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle

        For r = 2 To DataGridView1.Rows.Count + 1
            For c = 1 To 4
                If c = 1 Then
                    oTable.Cell(r, c).Range.Text = r - 1
                    oTable.Cell(r, c).Range.Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleSingle
                Else
                    oTable.Cell(r, c).Range.Text = DataGridView1.Rows(r - 2).Cells(c - 2).Value
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

    Private Sub cmbClass_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClass.SelectedIndexChanged

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

    Private Sub cmdPlus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckedChanged

    End Sub

    Private Sub cmdPlus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim Index As Integer = -1
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(i).Cells("Description").ToString = cmbClass.Text Then
                Index = i
            End If
        Next
        If Index = -1 Then
            nudQuantity.BackColor = Color.White
            cmbUnit.BackColor = Color.White
            cmbClass.BackColor = Color.White
            If nudQuantity.Value = 0 Then
                nudQuantity.BackColor = Color.Red

            ElseIf cmbUnit.Text = "" Then
                cmbUnit.BackColor = Color.Red

            ElseIf cmbClass.Text = "" Then
                cmbClass.BackColor = Color.Red
            Else
                DataGridView1.Rows.Add(nudQuantity.Value, cmbUnit.Text, cmbClass.Text)
                cmbClass_SelectedIndexChanged(Nothing, Nothing)
                nudQuantity.Value = 0
                cmbUnit.Text = ""
                cmbClass.Text = ""

            End If

        Else
            MsgBox("العنصر موجود في القائمة")
        End If
    End Sub

    Private Sub cmdLast_CheckStateChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckStateChanged
        FireworksRequestsBindingSource.MoveLast()
        GetFireworksRequestDetails()
    End Sub

    Private Sub cmdNext_CheckStateChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        FireworksRequestsBindingSource.MoveNext()
        GetFireworksRequestDetails()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        FireworksRequestsBindingSource.MovePrevious()
        GetFireworksRequestDetails()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        FireworksRequestsBindingSource.MoveFirst()
        GetFireworksRequestDetails()
    End Sub
    Dim IsAdd = False
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
        FireworksRequestsBindingSource.AddNew()
        DataGridView1.Rows.Clear()
        dtpFDate.Value = DateTime.Now
        IsAdd = True
        cmdNew.Enabled = False
        cmdSave.Enabled = True
        cmdCancel.Enabled = True
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
    End Sub
    Private Sub GetFireworksRequestDetails()
        DataGridView1.Rows.Clear()

        If txtFireworksRequestID.Text <> "" Then

            Dim dtFireworksRequestDetails As New dsExplosives.FireworksRequestDetailsDataTable
            dtFireworksRequestDetails = New dsExplosivesTableAdapters.FireworksRequestDetailsTableAdapter().GetDataByFireworksRequestID(txtFireworksRequestID.Text)


            For i As Integer = 0 To dtFireworksRequestDetails.Rows.Count - 1
                If txtFireworksRequestID.Text <> "" Then
                    Dim drFireworksRequestDetails As dsExplosives.FireworksRequestDetailsRow
                    drFireworksRequestDetails = dtFireworksRequestDetails.Rows(i)
                    DataGridView1.Rows.Add(drFireworksRequestDetails.Quantity, drFireworksRequestDetails.Unti, drFireworksRequestDetails.Description)

                End If
            Next

        End If

    End Sub
    Private Sub cmdSave_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckStateChanged

        If IsAdd Then
            Dim dttxtFireworksRequestNo As New dsExplosives.FireworksRequestsDataTable
            dttxtFireworksRequestNo = New dsExplosivesTableAdapters.FireworksRequestsTableAdapter().GetDataByMaxFireworksRequestNo_Year(dtpFDate.Value.Year)
            If dttxtFireworksRequestNo.Rows.Count = 0 Then
                txtFireworksRequestNo.Text = 1

            Else

                If IsDBNull(dttxtFireworksRequestNo.Rows(0)("FireworksRequestNo")) Then
                    txtFireworksRequestNo.Text = 1
                Else

                    txtFireworksRequestNo.Text = dttxtFireworksRequestNo(0).FireworksRequestNo + 1
                End If
            End If

        End If
        FireworksRequestsBindingSource.EndEdit()
        FireworksRequestsTableAdapter.Update(DsExplosives.FireworksRequests)
        Dim daFireworksRequest As New dsExplosivesTableAdapters.FireworksRequestDetailsTableAdapter
        If txtFireworksRequestID.Text <> "" Then
            daFireworksRequest.DeleteByFireworksRequestID(Convert.ToInt32(txtFireworksRequestID.Text))
        End If
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            If txtFireworksRequestID.Text <> "" Then


                daFireworksRequest.Insert(DataGridView1.Rows(i).Cells("Description").Value.ToString,
                                     DataGridView1.Rows(i).Cells("Unit").Value.ToString,
                                                  Convert.ToInt32(DataGridView1.Rows(i).Cells("Quantity").Value.ToString),
                                                  Convert.ToInt32(txtFireworksRequestID.Text))
            End If
        Next
        MsgBox("تــــم")
        IsAdd = False
        DisableSave()
    End Sub

    Private Sub cmdEdit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckStateChanged
        DisableSave()
    End Sub

    Private Sub cmbClass_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbClass.KeyPress
       
    End Sub

    Private Sub cmdCancel_CheckStateChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckStateChanged
        FireworksRequestsBindingSource.CancelEdit()
        DisableSave()
    End Sub

    Private Sub cmbRank_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmbPosition_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdReturn_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
    End Sub

    Private Sub cmdExit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckStateChanged
        Hide()
    End Sub

    Private Sub cmbClass_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbClass.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdPlus_CheckStateChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmbUnit_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbUnit.KeyDown
        If e.KeyCode = Keys.Enter Then
            cmdPlus_CheckStateChanged(Nothing, Nothing)

        End If
    End Sub

    Private Sub cmdDelete_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckedChanged
        Dim x As Object
        x = MsgBox("هل أنت متأكد/ة من أنك تريد/ حذف هذا السجل ؟", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If x = MsgBoxResult.Yes Then
            FireworksRequestsBindingSource.RemoveCurrent()
            FireworksRequestsBindingSource.EndEdit()
            FireworksRequestsTableAdapter.Update(DsExplosives.FireworksRequests)
            MsgBox("تم")
            DisableSave()

        End If
    End Sub
End Class