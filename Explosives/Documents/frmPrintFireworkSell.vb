Public Class frmPrintFireworkSell
    Private FireworksID As Integer
    Public Sub New(ByVal _FireworksID As Integer)
        FireworksID = _FireworksID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintFireworkSell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.Fireworks' table. You can move, or remove it, as needed.
        Me.FireworksTableAdapter.FillByFireworksID(Me.dsExplosives.Fireworks, FireworksID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class