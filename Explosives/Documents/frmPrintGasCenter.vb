Public Class frmPrintGasCenter
    Private GasCenterID As Integer
    Public Sub New(ByVal _GasCenterID As Integer)
        GasCenterID = _GasCenterID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintGasCenter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.GasCenters' table. You can move, or remove it, as needed.
        Me.GasCentersTableAdapter.FillByGasCenterID(Me.dsExplosives.GasCenters, GasCenterID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class