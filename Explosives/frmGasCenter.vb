﻿Imports Microsoft.Office.Interop

Public Class frmGasCenter
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
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
    Private Sub frmGasCenter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.GasCentersTableAdapter.Fill(Me.DsExplosives.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctCity(Me.CityDsExplosives1.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctName(Me.NameDsExplosives4.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctRank(Me.RankDsExplosives3.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctState(Me.StateDsExplosives2.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctTownship(Me.TownshipDsExplosives5.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctGasType(Me.GasTypeDsExplosives1.GasCenters)
        cmbCriteria.SelectedIndex = 0
        lblPosition.Text = " " + (GasCentersBindingSource.Position + 1).ToString + " / " + GasCentersBindingSource.Count.ToString


    End Sub

    Private Sub cmdNew_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then
            GasCentersBindingSource.AddNew()
            dtpCompanyLetterDate.Value = DateTime.Now
            dtpPermissionDate.Value = DateTime.Now
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
        EnableSave()
    End Sub

    Private Sub cmdSave_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckStateChanged
        GasCentersBindingSource.EndEdit()
        GasCentersTableAdapter.Update(DsExplosives.GasCenters)
        MsgBox("تم")
        Me.GasCentersTableAdapter.Fill(Me.DsExplosives.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctCity(Me.CityDsExplosives1.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctName(Me.NameDsExplosives4.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctRank(Me.RankDsExplosives3.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctState(Me.StateDsExplosives2.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.GasCenters)
        Me.GasCentersTableAdapter.FillDistinctGasType(Me.GasTypeDsExplosives1.GasCenters)
        GasCentersBindingSource.MoveLast()
        DisableSave()
    End Sub

    Private Sub cmdDelete_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        x = MsgBox("هل أنت متأكد/ة من أنك تريد/ حذف هذا السجل ؟", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If x = MsgBoxResult.Yes Then
            GasCentersBindingSource.RemoveCurrent()
           GasCentersBindingSource.EndEdit()
            GasCentersTableAdapter.Update(DsExplosives.GasCenters)
            DisableSave()
            MsgBox("تم")
        End If
    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckStateChanged
        GasCentersBindingSource.MoveLast()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        GasCentersBindingSource.MoveFirst()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        GasCentersBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        GasCentersBindingSource.MoveNext()
    End Sub

    Private Sub cmdCancel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckStateChanged
        GasCentersBindingSource.CancelEdit()
        GasCentersBindingSource.MoveLast()
        DisableSave()
    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdEdit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckStateChanged
        GasCentersBindingSource.CancelEdit()
        EnableSave()
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub cmbStates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStates.SelectedIndexChanged

    End Sub

    Private Sub cmbPrintFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrintFirst.Click
        'Dim fPrintGasCenter As New frmPrintGasCenter(Convert.ToInt32(txtId.Text))
        'fPrintGasCenter.ShowDialog()
        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")

        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "GasCenter.docx")
        oWord.Visible = True

        EditBookMark("ArabicDate", StretchArabicMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
        EditBookMark("EnglishDate", StretchEnglishMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
        EditBookMark("Company", cmbCompany.Text)
        EditBookMark("Requester", txtRepresentitive.Text)
        EditBookMark("Company1", cmbCompany.Text)
        EditBookMark("EndYear", dtpPermissionDate.Value.Year)
        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("State", cmbStates.Text)
        EditBookMark("Township", cmbTownships.Text)
        EditBookMark("City", cmbCities.Text)
        EditBookMark("Block", txtBlock.Text)
        EditBookMark("Land", txtLand.Text)
        EditBookMark("GasType", cmbGasType.Text)
        EditBookMark("GasType1", cmbGasType.Text)
        EditBookMark("RequestDate", dtpCompanyLetterDate.Value.ToShortDateString)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnPrintLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Dim fPrintGasCenter As New frmPrintGasCenter(Convert.ToInt32(txtId.Text))
        'fPrintGasCenter.ShowDialog()

        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")

        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "GasCenter.docx")
        oWord.Visible = True

        EditBookMark("ArabicDate", StretchArabicMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
        EditBookMark("EnglishDate", StretchEnglishMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
        EditBookMark("Company", cmbCompany.Text)
        EditBookMark("Requester", txtRepresentitive.Text)
        EditBookMark("Company1", cmbCompany.Text)
        EditBookMark("EndYear", dtpPermissionDate.Value.Year)
        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("State", cmbStates.Text)
        EditBookMark("Township", cmbTownships.Text)
        EditBookMark("City", cmbCities.Text)
        EditBookMark("Block", txtBlock.Text)
        EditBookMark("Land", txtLand.Text)
        EditBookMark("GasType", cmbGasType.Text)
        EditBookMark("GasType1", cmbGasType.Text)
        EditBookMark("RequestDate", dtpCompanyLetterDate.Value.ToShortDateString)

    End Sub
    Public Function StretchArabicMonth(ByVal input As String) As String
        Dim output As String

        output = input.Replace("ربيع الأول", "ربــــيــــــع الأول")
        output = output.Replace("شعبان", "شـــــعـــــــبــــان")
        output = output.Replace("ربيع الثاني", "ربــــيــــع الثـاني")
        output = output.Replace("رجب", "رجـــــــــــــــب")
        output = output.Replace("شوال", "شــــــــــــــوال")
        output = output.Replace("رمضان", "رمـــــــضـــــــان")
        output = output.Replace("صفر", "صــــــفـــــــــر")
        output = output.Replace("محرم", "مـــــــحـــــــرم")
        output = output.Replace("جمادي الأولى", "جــمـــادي الأولى")
        output = output.Replace("جمادي الثانية", "جـمـادي الثــانية")
        output = output.Replace("ذو القعدة", "ذو الـــــقــــعــــدة")
        output = output.Replace("ذو الحجة", "ذو الـــــحــــجـــة")
        Return output
    End Function
    Public Function StretchEnglishMonth(ByVal input As String) As String
        Dim output As String

        output = input.Replace("يناير", "يــــــنــــــايـــــــر")
        output = output.Replace("فبراير", "فــــــبـــــرايـــــر")
        output = output.Replace("مارس", "مــــــــــــــــارس")
        output = output.Replace("أبريل", "أبــــــــريـــــــــل")
        output = output.Replace("مايو", "مـــــــــــايــــــــو")
        output = output.Replace("يونيو", "يــــــــونـــــــيــو")
        output = output.Replace("يوليو", "يـــــــولــــــيــــو")
        output = output.Replace("أغسطس", "أغـــــســطــــس")
        output = output.Replace("سبتمبر", "ســبـــتـــمـــبــر")
        output = output.Replace("أكتوبر", "نــــوفـــــمــــبـر")
        output = output.Replace("نوفمبر", "نــــوفـــــمــــبـر")
        output = output.Replace("ديسمبر", "ديــــســـمــــبــر")
        Return output
    End Function
    Private Sub cmdFound_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFound.CheckStateChanged

       
    End Sub

    Private Sub btnPrintSecond_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintSecond.Click
        EditBookMark("ArabicDate", StretchArabicMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
        EditBookMark("EnglishDate", StretchEnglishMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
        EditBookMark("Company", cmbCompany.Text)
        EditBookMark("Requester", txtRepresentitive.Text)
        EditBookMark("Company1", cmbCompany.Text)
        EditBookMark("EndYear", dtpPermissionDate.Value.Year)
        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("State", cmbStates.Text)
        EditBookMark("Township", cmbTownships.Text)
        EditBookMark("City", cmbCities.Text)
        EditBookMark("Block", txtBlock.Text)
        EditBookMark("Land", txtLand.Text)
        EditBookMark("GasType", cmbGasType.Text)
        EditBookMark("GasType1", cmbGasType.Text)
        EditBookMark("RequestDate", dtpCompanyLetterDate.Value.ToShortDateString)
    End Sub
End Class
