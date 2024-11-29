Public Class frmSearchPassPermission


    Private Sub frmSearchPassPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.PERMISSIONS' table. You can move, or remove it, as needed.
        Me.PERMISSIONSTableAdapter.FillByOrderByDate(Me.DsExplosives.PERMISSIONS)
        CType(DataGridView1.DataSource, BindingSource).Filter = "FDATE = '" + DateTimePicker2.Value.Date + "'"

    End Sub

    Private Sub DataGridView1_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        If MessageBox.Show("هل تود اختيار مستند الصرف؟", "تنبيه", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If DataGridView1.SelectedRows.Count > 0 Then


                Me.DialogResult = DialogResult.OK

                CType(Application.OpenForms("frmMovementForms"), frmMovementForms).PassPermissionID =
                    Convert.ToInt32(DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value)
                Close()
            End If
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSearch.TextChanged
        CType(DataGridView1.DataSource, BindingSource).Filter = ""
        Select Case ComboBox1.Text
            Case "الجهة المستلمة"
                CType(DataGridView1.DataSource, BindingSource).Filter = "Receiver like '%" + txtSearch.Text + "%'"
            Case "الجهة الصارفة"
                CType(DataGridView1.DataSource, BindingSource).Filter = "DISTRACTOR like '%" + txtSearch.Text + "%'"
            Case "نمرة مستند الصرف"
                CType(DataGridView1.DataSource, BindingSource).Filter = "PassPermissionNo like %" + txtSearch.Text + "%"


        End Select
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Close()
    End Sub

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        CType(DataGridView1.DataSource, BindingSource).Filter = "FDATE = '" + DateTimePicker2.Value.Date + "'"
    End Sub
End Class