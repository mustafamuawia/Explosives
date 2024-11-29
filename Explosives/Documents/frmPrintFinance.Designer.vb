<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintFinance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.FINANCEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.FinanceDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.FINANCETableAdapter = New Explosives.dsExplosivesTableAdapters.FINANCETableAdapter()
        Me.FinanceDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.FinanceDetailsTableAdapter()
        CType(Me.FINANCEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FinanceDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FINANCEBindingSource
        '
        Me.FINANCEBindingSource.DataMember = "FINANCE"
        Me.FINANCEBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FinanceDetailsBindingSource
        '
        Me.FinanceDetailsBindingSource.DataMember = "FinanceDetails"
        Me.FinanceDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsFinance"
        ReportDataSource1.Value = Me.FINANCEBindingSource
        ReportDataSource2.Name = "dsFinanceDetails"
        ReportDataSource2.Value = Me.FinanceDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.FinanceBill.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(807, 427)
        Me.ReportViewer1.TabIndex = 0
        '
        'FINANCETableAdapter
        '
        Me.FINANCETableAdapter.ClearBeforeFill = True
        '
        'FinanceDetailsTableAdapter
        '
        Me.FinanceDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintFinance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(807, 427)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintFinance"
        Me.Text = "frmPrintFinance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.FINANCEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FinanceDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FINANCEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents FINANCETableAdapter As Explosives.dsExplosivesTableAdapters.FINANCETableAdapter
    Friend WithEvents FinanceDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FinanceDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.FinanceDetailsTableAdapter
End Class
