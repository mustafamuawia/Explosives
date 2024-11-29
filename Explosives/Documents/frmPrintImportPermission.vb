Public Class frmPrintImportPermission
    Private ID As Integer
    Public Sub New(ByVal _ID As Integer)


        InitializeComponent()
        ID = _ID


    End Sub
    Private Sub frmPrintImportPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.IMPORTPERMISSIONSTableAdapter.FillByID(Me.dsExplosives.IMPORTPERMISSIONS, ID)
        Me.ImportPermissionDetailsTableAdapter.FillByImportPermissionID(Me.dsExplosives.ImportPermissionDetails, ID)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class