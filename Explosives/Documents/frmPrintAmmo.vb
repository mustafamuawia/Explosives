Public Class frmPrintAmmo
    Private AmmoID As Integer
    Public Sub New(ByVal _AmmoID As Integer)
        AmmoID = _AmmoID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub frmPrintAmmo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.Ammo' table. You can move, or remove it, as needed.
        Me.AmmoTableAdapter.FillByAmmoID(Me.dsExplosives.Ammo, AmmoID)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class