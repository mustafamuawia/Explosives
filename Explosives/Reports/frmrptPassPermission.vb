Public Class frmrptPassPermission


    Private Sub frmrptPassPermission_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.OURDISTRACT' table. You can move, or remove it, as needed.
        Dim Year As Integer = DateTime.Now.Year
        Dim Month As Integer = DateTime.Now.Month
        dtpFrom.Value = New DateTime(Year, Month, 1)
        dtpTo.Value = New DateTime(Year, Month + 1, 1).AddDays(-1)


        Me.OURDISTRACTTableAdapter.Fill(Me.dsExplosives.OURDISTRACT)

    End Sub

End Class