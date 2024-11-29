Public Class frmPrintGasDepot
    Private GasDepotID As Integer
    Public Sub New(ByVal _GasDepotID As Integer)
        GasDepotID = _GasDepotID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintGasDepot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.GasDepots' table. You can move, or remove it, as needed.
        Me.GasDepotsTableAdapter.FillByGasDepotID(Me.dsExplosives.GasDepots, GasDepotID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class