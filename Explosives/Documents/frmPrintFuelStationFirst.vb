Public Class frmPrintFuelStationFirst
    Private FuelStationID As Integer
    Public Sub New(ByVal _FuelStationID As Integer)
        FuelStationID = _FuelStationID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintFuelStationFirst_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.FuelStations' table. You can move, or remove it, as needed.
        Me.FuelStationsTableAdapter.FillByFuelStationID(Me.dsExplosives.FuelStations, FuelStationID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class