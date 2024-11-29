Public Class frmPrintWorkPermission
    Private WorkPermissionID As Integer
    Public Sub New(ByVal _WorkPermissionID As Integer)
        WorkPermissionID = _WorkPermissionID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintWorkPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.WORKPERMISSIONS' table. You can move, or remove it, as needed.
        Me.WORKPERMISSIONSTableAdapter.FillByID(Me.dsExplosives.WORKPERMISSIONS, WorkPermissionID)
        'TODO: This line of code loads data into the 'dsExplosives.WorkCopiesDetails' table. You can move, or remove it, as needed.

        Dim WorkCopyID As Integer = New dsExplosivesTableAdapters.WorkCopiesTableAdapter().GetDataByStateRegion(
         dsExplosives.WORKPERMISSIONS(0).STATE, dsExplosives.WORKPERMISSIONS(0).LOCATION)(0).ID

        'TODO: This line of code loads data into the 'dsExplosives.PassCopiesDetails' table. You can move, or remove it, as needed.
        Me.WorkCopiesDetailsTableAdapter.FillByWorkCopyID(Me.dsExplosives.WorkCopiesDetails, WorkCopyID)
        Dim drWorkCopiesDetails As Explosives.dsExplosives.WorkCopiesDetailsRow = dsExplosives.WorkCopiesDetails.NewRow
        drWorkCopiesDetails.WorkCopyID = WorkCopyID
        drWorkCopiesDetails.Sirs = "السيد/ مدير " + Me.dsExplosives.WORKPERMISSIONS(0).FSIDENAME
        dsExplosives.WorkCopiesDetails.Rows.Add(drWorkCopiesDetails)
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.PrinterSettings.Copies = dsExplosives.WORKPERMISSIONS.Rows.Count
    End Sub
End Class