Imports Microsoft.Reporting.WinForms

Public Class frmrptOurDistract



    Private Sub frmrptOurDistract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim Year As Integer = DateTime.Now.Year
        Dim Month As Integer = DateTime.Now.Month
        dtpFrom.Value = New DateTime(Year, Month, 1)
        dtpTo.Value = New DateTime(Year, Month + 1, 1).AddDays(-1)
    End Sub
    Public Sub SubreportProcessing(ByVal sender As Object, ByVal e As Microsoft.Reporting.WinForms.SubreportProcessingEventArgs)
        Dim ID As Integer = Convert.ToInt32(e.Parameters(0).Values(0))
        Dim dtOurDistractDetails As New dsExplosives.OurDistractDetailsDataTable
        Dim daOurDistractDetailsTA As New dsExplosivesTableAdapters.OurDistractDetailsTableAdapter
        daOurDistractDetailsTA.FillByOurDistractID(dtOurDistractDetails, ID)
        Dim rptSource As New ReportDataSource
        rptSource.Name = "dsOurDistractDetails"
        rptSource.Value = dtOurDistractDetails
        e.DataSources.Add(rptSource)
    End Sub

    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        'TODO: This line of code loads data into the 'dsExplosives.OURDISTRACT' table. You can move, or remove it, as needed.
     

        Me.OURDISTRACTTableAdapter.FillByBetweenDates(Me.dsExplosives.OURDISTRACT, dtpFrom.Value, dtpTo.Value.AddDays(1))
        Me.OurDistractDetailsTableAdapter.FillByBetweenTwoDates(Me.dsExplosives.OurDistractDetails, dtpFrom.Value, dtpTo.Value.AddDays(1))



        ReportViewer1.LocalReport.SetParameters(New ReportParameter("FromDate", dtpFrom.Value))
        ReportViewer1.LocalReport.SetParameters(New ReportParameter("ToDate", dtpTo.Value))
        AddHandler ReportViewer1.LocalReport.SubreportProcessing, AddressOf SubreportProcessing
        ReportViewer1.RefreshReport()
    End Sub
End Class