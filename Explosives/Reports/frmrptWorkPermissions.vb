Imports Microsoft.Reporting.WinForms

Public Class frmrptWorkPermissions

    Private Sub frmrptWorkPermissions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.WORKPERMISSIONS' table. You can move, or remove it, as needed.
        nudYear.Value = DateTime.Now.Year


    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Me.WORKPERMISSIONSTableAdapter.FillByYear(Me.dsExplosives.WORKPERMISSIONS, Convert.ToInt32(nudYear.Value))
        'If ReportViewer1.LocalReport.GetParameters().Count = 0 Then
        'Dim rpYear As

        ReportViewer1.LocalReport.SetParameters(New ReportParameter("Year", nudYear.Value.ToString()))
        'Else

        'End If

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class