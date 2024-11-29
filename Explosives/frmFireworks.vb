Public Class frmFireworks

    Private Sub frmFireworks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FireworksTableAdapter.Fill(Me.DsExplosives.Fireworks)
        Me.FireworksTableAdapter.FillDistinctCity(Me.CityDsExplosives1.Fireworks)
        Me.FireworksTableAdapter.FillDistinctName(Me.NameDsExplosives4.Fireworks)
        Me.FireworksTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.Fireworks)
        Me.FireworksTableAdapter.FillDistinctRank(Me.RankDsExplosives3.Fireworks)
        Me.FireworksTableAdapter.FillDistinctState(Me.StateDsExplosives2.Fireworks)
        Me.FireworksTableAdapter.FillDistinctTownship(Me.TownshipDsExplosives5.Fireworks)
        Me.FireworksTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.Fireworks)
        'dtpCompanyLetterDate.Value = DateTime.Now
        'dtpPermissionDate.Value = DateTime.Now
        ''dtpCompanyLetterDate.Checked = dtpPermissionDate.Checked = True
        'MsgBox(dtpCompanyLetterDate.Value)
        'Me.FireworksTableAdapter.Fill(Me.DsExplosives.Fireworks)
        'TODO: This line of code loads data into the 'DsExplosives.States' table. You can move, or remove it, as needed.
        'Me.StatesTableAdapter.Fill(Me.DsExplosives.States)

    End Sub

    Private Sub cmdNew_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckStateChanged
        Dim fCheck As New frmCheck
        If fCheck.ShowDialog = DialogResult.OK Then
            FireworksBindingSource.AddNew()
            'dtpCompanyLetterDate.Value = DateTime.Now
            dtpPermissionDate.Value = DateTime.Now
        End If
        'cmdSave.Enabled = True
        'cmdCancel.Enabled = True
        'cmdNew.Enabled = False
        'cmdEdit.Enabled = False
    End Sub

    Private Sub cmdSave_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckStateChanged
        FireworksBindingSource.EndEdit()
        FireworksTableAdapter.Update(DsExplosives.Fireworks)
        MsgBox("تم")
        Me.FireworksTableAdapter.Fill(Me.DsExplosives.Fireworks)
        Me.FireworksTableAdapter.FillDistinctCity(Me.CityDsExplosives1.Fireworks)
        Me.FireworksTableAdapter.FillDistinctName(Me.NameDsExplosives4.Fireworks)
        Me.FireworksTableAdapter.FillDistinctPosition(Me.PositionDsExplosives6.Fireworks)
        Me.FireworksTableAdapter.FillDistinctRank(Me.RankDsExplosives3.Fireworks)
        Me.FireworksTableAdapter.FillDistinctState(Me.StateDsExplosives2.Fireworks)
        Me.FireworksTableAdapter.FillDistinctCompany(Me.CompanyDsExplosives7.Fireworks)
        FireworksBindingSource.MoveLast()
        'frmFuelStation_Load(Nothing, Nothing)
        'cmdSave.Enabled = False
        'cmdCancel.Enabled = False
        'cmdNew.Enabled = True
        'cmdEdit.Enabled = True
    End Sub

    Private Sub cmdDelete_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.CheckStateChanged
        FireworksBindingSource.EndEdit()
        FireworksTableAdapter.Update(DsExplosives.Fireworks)
        MsgBox("تم")

    End Sub

    Private Sub cmdLast_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.CheckStateChanged
        FireworksBindingSource.MoveLast()
    End Sub

    Private Sub cmdFirst_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFirst.CheckStateChanged
        FireworksBindingSource.MoveFirst()
    End Sub

    Private Sub cmdPrev_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrev.CheckStateChanged
        FireworksBindingSource.MovePrevious()
    End Sub

    Private Sub cmdNext_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.CheckStateChanged
        FireworksBindingSource.MoveNext()
    End Sub

    Private Sub cmdCancel_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.CheckStateChanged
        FireworksBindingSource.CancelEdit()
        FireworksBindingSource.MoveLast()
    End Sub

    Private Sub cmdNew_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.CheckedChanged

    End Sub

    Private Sub cmdEdit_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.CheckStateChanged
        FireworksBindingSource.CancelEdit()

    End Sub

    Private Sub cmdSave_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.CheckedChanged

    End Sub

    Private Sub cmbStates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStates.SelectedIndexChanged

    End Sub

    Private Sub cmbPrintFirst_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrintFirst.Click
        If cmbType.Text = "بيع" Then


            Dim fPrintFuelStation As New frmPrintFireworkSell(Convert.ToInt32(txtId.Text))
            fPrintFuelStation.ShowDialog()
        Else
            Dim fPrintFuelStation As New frmPrintFireworksStore(Convert.ToInt32(txtId.Text))
            fPrintFuelStation.ShowDialog()

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

 
End Class