Public Class frmprintPassPermission
    Private PassPermissionID As Integer
    Public Sub New(ByVal _PassPermissionIDID As Integer)
        PassPermissionID = _PassPermissionIDID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmprintPassPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.PERMISSIONS' table. You can move, or remove it, as needed.
      
        'TODO: This line of code loads data into the 'dsExplosives.PERMISSIONS' table. You can move, or remove it, as needed.
        Me.PERMISSIONSTableAdapter.FillByPassPermissionID(Me.dsExplosives.PERMISSIONS, PassPermissionID)
        'TODO: This line of code loads data into the 'dsExplosives.PermissionDetails' table. You can move, or remove it, as needed.
        Me.PermissionDetailsTableAdapter.FillByPassPermissionID(Me.dsExplosives.PermissionDetails, PassPermissionID)
        Dim dtPassCopies As New dsExplosives.PassCopiesDataTable
        Dim daPassCopies As New dsExplosivesTableAdapters.PassCopiesTableAdapter()
        Try

        
        daPassCopies.FillByPoint1Point2Point3(dtPassCopies,
            dsExplosives.PERMISSIONS(0).POINT1, dsExplosives.PERMISSIONS(0).POINT2, dsExplosives.PERMISSIONS(0).POINT3)
        Dim PassCopyID As Integer = dtPassCopies(0).ID

        'TODO: This line of code loads data into the 'dsExplosives.PassCopiesDetails' table. You can move, or remove it, as needed.
        Me.PassCopiesDetailsTableAdapter.FillByPassCopyID(Me.dsExplosives.PassCopiesDetails, PassCopyID)
        Dim drPassCopiesDetails As Explosives.dsExplosives.PassCopiesDetailsRow = dsExplosives.PassCopiesDetails.NewRow
        drPassCopiesDetails.PassCopyID = PassCopyID
        drPassCopiesDetails.Sirs = "السيد/ مدير " + Me.dsExplosives.PERMISSIONS(0).RECEIVER
            dsExplosives.PassCopiesDetails.Rows.Add(drPassCopiesDetails)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.ReportViewer1.RefreshReport()
        ReportViewer1.PrinterSettings.Copies = dsExplosives.PassCopiesDetails.Rows.Count
    End Sub
End Class