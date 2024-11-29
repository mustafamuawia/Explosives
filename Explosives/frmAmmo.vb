
Imports Microsoft.Office.Interop

Public Class frmAmmo
    Dim oWord As Word.Application
    Dim oDoc As Word.Document
    Private Sub EditBookMark(ByVal Name As String, ByVal Value As String)
        Dim BookMark As Word.Range
        BookMark = oDoc.Bookmarks(Name).Range
        BookMark.Text = Value
        oDoc.Bookmarks.Add(Name, BookMark)
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
    Private Sub frmAmmo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.AmmoTableAdapter.Fill(Me.DsExplosives.Ammo)
        Me.AmmoTableAdapter.FillDistinctCity(Me.CityDsExplosives1.Ammo)
        Me.AmmoTableAdapter.FillDistinctName(Me.NameDsExplosives4.Ammo)
        Me.AmmoTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.Ammo)
        Me.AmmoTableAdapter.FillDistinctRank(Me.RankDsExplosives3.Ammo)
        Me.AmmoTableAdapter.FillDistinctState(Me.StateDsExplosives2.Ammo)
        Me.AmmoTableAdapter.FillDistinctTownship(Me.TownshipDsExplosives5.Ammo)
        Me.AmmoTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.Ammo)

        If cmbRank.Items.Count > 0 Then
            cmbRank.SelectedIndex = 0
        End If
        If cmbName.Items.Count > 0 Then
            cmbName.SelectedIndex = 0
        End If
        If cmbPosition.Items.Count > 0 Then
            cmbPosition.SelectedIndex = 0
        End If
        cmbCriteria.SelectedIndex = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object Loaded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lblPosition.Text = " " + (AmmoBindingSource.Position + 1).ToString + " / " + AmmoBindingSource.Count.ToString

        'Me.AmmoTableAdapter.FillDistinctGasType(Me.GasTypeDsExplosives1.Ammo)
        'dtpCompanyLetterDate.Value = DateTime.Now
        'dtpPermissionDate.Value = DateTime.Now
        ''dtpCompanyLetterDate.Checked = dtpPermissionDate.Checked = True
        'MsgBox(dtpCompanyLetterDate.Value)
        'Me.AmmoTableAdapter.Fill(Me.DsExplosives.Ammo)
        'TODO: This line of code loads data into the 'DsExplosives.States' table. You can move, or remove it, as needed.
        'Me.StatesTableAdapter.Fill(Me.DsExplosives.States)

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

    Dim IsAdd = False
    Private Sub cmdNew_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then
            AmmoBindingSource.AddNew()
            dtpCompanyLetterDate.Value = DateTime.Now
            dtpPermissionDate.Value = DateTime.Now
            IsAdd = True
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
        If IsAdd Then
            Dim dtAmmoNo As New dsExplosives.AmmoDataTable
            dtAmmoNo = New dsExplosivesTableAdapters.AmmoTableAdapter().GetDataMaxAmmoNoYear(dtpPermissionDate.Value.Year)
            If dtAmmoNo.Rows.Count = 0 Then
                txtAmmoNo.Text = 1
            Else
                If IsDBNull(dtAmmoNo.Rows(0)("AmmoNo")) Then
                    txtAmmoNo.Text = 1
                Else
                    txtAmmoNo.Text = dtAmmoNo(0).AmmoNo + 1
                End If
            End If

        End If
        AmmoBindingSource.EndEdit()
        AmmoTableAdapter.Update(DsExplosives.Ammo)
        MsgBox("تم")
        Me.AmmoTableAdapter.Fill(Me.DsExplosives.Ammo)
        Me.AmmoTableAdapter.FillDistinctCity(Me.CityDsExplosives1.Ammo)
        Me.AmmoTableAdapter.FillDistinctName(Me.NameDsExplosives4.Ammo)
        Me.AmmoTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.Ammo)
        Me.AmmoTableAdapter.FillDistinctRank(Me.RankDsExplosives3.Ammo)
        Me.AmmoTableAdapter.FillDistinctState(Me.StateDsExplosives2.Ammo)
        Me.AmmoTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.Ammo)
        AmmoBindingSource.MoveLast()
        lblPosition.Text = " " + (AmmoBindingSource.Position + 1).ToString + " / " + AmmoBindingSource.Count.ToString
        DisableSave()

    End Sub

    Private Sub cmdDelete_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckStateChanged
        Dim x As Object
        x = MsgBox("هل أنت متأكد/ة من أنك تريد/ حذف هذا السجل ؟", MsgBoxStyle.MsgBoxRight + MsgBoxStyle.YesNo + MsgBoxStyle.Question)
        If x = MsgBoxResult.Yes Then
            AmmoBindingSource.RemoveCurrent()
            AmmoBindingSource.EndEdit()
            AmmoTableAdapter.Update(DsExplosives.Ammo)
            MsgBox("تم")
            DisableSave()

        End If
    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckStateChanged
        AmmoBindingSource.MoveLast()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        AmmoBindingSource.MoveFirst()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        AmmoBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        AmmoBindingSource.MoveNext()
    End Sub

    Private Sub cmdCancel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckStateChanged
        AmmoBindingSource.CancelEdit()
        AmmoBindingSource.MoveLast()
        DisableSave()

    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdEdit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckStateChanged
        AmmoBindingSource.CancelEdit()
        EnableSave()
    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub cmbStates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStates.SelectedIndexChanged

    End Sub

    Private Sub cmbPrintFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrintFirst.Click
        'Dim fPrintAmmo As New frmPrintAmmo(Convert.ToInt32(txtId.Text))
        'fPrintAmmo.ShowDialog()
        oWord = CreateObject("Word.Application")
        oDoc = CreateObject("Word.Document")

        oDoc = oWord.Documents.Add(AppDomain.CurrentDomain.BaseDirectory() + "Ammo.doc")
        oWord.Visible = True
        EditBookMark("AmmoNo", txtAmmoNo.Text)
        EditBookMark("AmmoNo1", txtAmmoNo.Text)
        EditBookMark("AmmoNo2", txtAmmoNo.Text)
        EditBookMark("LargeAmmoNo", txtAmmoNo.Text)
        EditBookMark("ArabicDate", StretchArabicMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar"))))
        EditBookMark("EnglishDate", StretchEnglishMonth(dtpPermissionDate.Value.ToString("MMMMM yyy", System.Globalization.CultureInfo.CreateSpecificCulture("ar-EG"))))
        EditBookMark("Date", dtpPermissionDate.Value.Date.ToString("yyy/MM/dd"))
        EditBookMark("Date1", dtpPermissionDate.Value.Date.ToString("yyy/MM/dd"))
        EditBookMark("Company", cmbCompany.Text)
        EditBookMark("Company1", cmbCompany.Text)
        EditBookMark("Company2", cmbCompany.Text)
        EditBookMark("Company3", cmbCompany.Text)
        EditBookMark("Rank", cmbRank.Text)
        EditBookMark("Name", cmbName.Text)
        EditBookMark("Position", cmbPosition.Text)
        EditBookMark("Rank1", cmbRank.Text)
        EditBookMark("Name1", cmbName.Text)
        EditBookMark("Position1", cmbPosition.Text)
        EditBookMark("Rank2", cmbRank.Text)
        EditBookMark("Name2", cmbName.Text)
        EditBookMark("Position2", cmbPosition.Text)
        EditBookMark("State", cmbStates.Text)
        EditBookMark("State1", cmbStates.Text)
        EditBookMark("State2", cmbStates.Text)
        EditBookMark("State3", cmbStates.Text)
        EditBookMark("State4", cmbStates.Text)
        EditBookMark("State5", cmbStates.Text)
        EditBookMark("State6", cmbStates.Text)
        EditBookMark("Township", cmbTownships.Text)
        EditBookMark("Township1", cmbTownships.Text)
        EditBookMark("Township2", cmbTownships.Text)
        EditBookMark("City", cmbCities.Text)
        EditBookMark("Block", txtBlock.Text)
        EditBookMark("Land", txtLand.Text)
        EditBookMark("City1", cmbCities.Text)
        EditBookMark("Block1", txtBlock.Text)
        EditBookMark("Land1", txtLand.Text)
        EditBookMark("City2", cmbCities.Text)
        EditBookMark("Block2", txtBlock.Text)
        EditBookMark("Land2", txtLand.Text)
        EditBookMark("Job", txtJob.Text)
        EditBookMark("Job1", txtJob.Text)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtFind_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFind.TextChanged
        If cmbCriteria.Text = "عام" Then
            AmmoBindingSource.Filter = "AmmoStoreNo = '" + txtFind.Text + "'  or  Company like '%" + txtFind.Text + "%' or " &
                "City like '%" + txtFind.Text + "%' or Land like '%" + txtFind.Text + "%' or Block = '%" + txtFind.Text + "%' or " &
                "ReceiptNo like '%" + txtFind.Text + "%' or FID  = '" + txtFind.Text + "' or Job like '%" + txtFind.Text + "%' or " &
                "LargStoreNo like '%" + txtFind.Text + "%' or MidStoreNo like '%" + txtFind.Text + "%' or " &
                " SmallStoreNo like '%" + txtFind.Text + "%' or Address like '%" + txtFind.Text + "%'"
            lblPosition.Text = " " + (AmmoBindingSource.Position + 1).ToString + " / " + AmmoBindingSource.Count.ToString
        End If


    End Sub

    Private Sub cmdReturn_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdReturn.CheckStateChanged
        Hide()
    End Sub

    Private Sub cmdExit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.CheckStateChanged
        Close()
    End Sub
End Class
