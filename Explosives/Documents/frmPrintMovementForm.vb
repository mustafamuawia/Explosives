Public Class frmPrintMovementForm
    Dim MovementFormID As Integer
    Public Sub New(ByVal _MovementFormID As Integer)
        MovementFormID = _MovementFormID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmPrintMovementForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'dsExplosives.MovementForms' table. You can move, or remove it, as needed.
        Me.MovementFormsTableAdapter.FillByMovementFormID(Me.dsExplosives.MovementForms, MovementFormID)
        'TODO: This line of code loads data into the 'dsExplosives.MovementFormDetials' table. You can move, or remove it, as needed.
        Me.MovementFormDetialsTableAdapter.FillByMovementFormID(Me.dsExplosives.MovementFormDetials, MovementFormID)

        Me.ReportViewer1.RefreshReport()
        ReportViewer1.PrinterSettings.Copies = 3
    End Sub
End Class