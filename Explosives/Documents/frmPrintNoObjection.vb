Public Class frmPrintNoObjection
    Private NoObjectionID As Integer
    Public Sub New(ByVal _NoObjectionID As Integer)
        NoObjectionID = _NoObjectionID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintNoObjection_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.NOOBJECTIONS' table. You can move, or remove it, as needed.
        Me.NOOBJECTIONSTableAdapter.FillByID(Me.dsExplosives.NOOBJECTIONS, NoObjectionID)
        'TODO: This line of code loads data into the 'dsExplosives.NoObjectionDetails' table. You can move, or remove it, as needed.
        Me.NoObjectionDetailsTableAdapter.FillByNoObjectionID(Me.dsExplosives.NoObjectionDetails, NoObjectionID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class