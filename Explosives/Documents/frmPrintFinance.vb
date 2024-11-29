Imports QRCoder
Imports System
Imports System.IO
Imports System.Drawing.Imaging
Imports Microsoft.Reporting.WinForms

Public Class frmPrintFinance
    Private ID As Integer
    Public Sub New(ByVal _ID As Integer)
        ID = _ID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintFinance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        'TODO: This line of code loads data into the 'dsExplosives.FinanceDetails' table. You can move, or remove it, as needed.
        Me.FinanceDetailsTableAdapter.FillByFinanceID(Me.dsExplosives.FinanceDetails, ID)
        'TODO: This line of code loads data into the 'dsExplosives.FINANCE' table. You can move, or remove it, as needed.
        FINANCETableAdapter.FillByID(dsExplosives.FINANCE, ID)
        Dim qrGenerator As New QRCodeGenerator()

        Dim qrCodeData = qrGenerator.CreateQrCode(ID.ToString, QRCodeGenerator.ECCLevel.Q)
        Dim qrCode = New QRCode(qrCodeData)
        Dim qrCodeImage = qrCode.GetGraphic(40)
        'qrCodeImage.Save(ID.ToString)
        Dim bImage As Bitmap = qrCodeImage  ' Your Bitmap Image
        Dim ms As MemoryStream = New MemoryStream()
        bImage.Save(ms, ImageFormat.Png)
        Dim byteImage As Byte() = ms.ToArray()
        Dim SigBase64 = Convert.ToBase64String(byteImage)
        Me.ReportViewer1.LocalReport.EnableExternalImages = True
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter("QR", SigBase64))
        Me.ReportViewer1.LocalReport.SetParameters(New ReportParameter("ReportLogoMimeType", "image/png"))


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class