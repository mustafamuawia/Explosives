Option Strict Off
Option Explicit On
Friend Class frmCondtions0
	Inherits System.Windows.Forms.Form

    Private Sub List1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles List1.SelectedIndexChanged

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim daPermissionNames As New dsExplosivesTableAdapters.PermissionNamesTableAdapter
        daPermissionNames.Insert(txtPermissionName.Text)
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

    End Sub

    Private Sub cmdPlus_CheckStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckStateChanged
        Dim dtConditions As New DataTable
        'dtConditions = New dsExplosivesTableAdapters.ConditionsTableAdapter().GetDataByName(txtPermissionName.Text)
        'If dtConditions.Rows.Count > 0 Then
        '    MsgBox("Â–« «·«–‰ „÷«› „‰ ﬁ»·")
        'ElseIf txtPermissionName.Text <> "" Then
        '    List1.Items.Add(txtPermissionName.Text)
        '    txtPermissionName.Text = ""
        'Else
        '    ErrorProvider1.SetError(txtPermissionName, "·« »œ „‰ ﬂ «»… ﬁÌ„…")
        'End If

    End Sub

    Private Sub frmCondtions0_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DsExplosives.Conditions' table. You can move, or remove it, as needed.
        Dim dtPermissionName As New dsExplosives.PermissionNamesDataTable
        dtPermissionName = New dsExplosivesTableAdapters.PermissionNamesTableAdapter().GetData
        List1.Items.Clear()
        For i As Integer = 0 To dtPermissionName.Rows.Count - 1
            List1.Items.Add(dtPermissionName.Rows(i)("PermissionName"))
        Next
    End Sub

    Private Sub cmdPlus_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlus.CheckedChanged

    End Sub

    Private Sub txtCondition_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPermissionName.TextChanged

    End Sub
End Class