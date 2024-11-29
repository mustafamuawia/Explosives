<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintImportPermission
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
        Me.IMPORTPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.IMPORTPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter()
        Me.ImportPermissionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImportPermissionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter()
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ImportPermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IMPORTPERMISSIONSBindingSource
        '
        Me.IMPORTPERMISSIONSBindingSource.DataMember = "IMPORTPERMISSIONS"
        Me.IMPORTPERMISSIONSBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.EnforceConstraints = False
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsImportPermission"
        ReportDataSource1.Value = Me.IMPORTPERMISSIONSBindingSource
        ReportDataSource2.Name = "dsImportPermissionDetails"
        ReportDataSource2.Value = Me.ImportPermissionDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.ImportPermission.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(632, 410)
        Me.ReportViewer1.TabIndex = 0
        '
        'IMPORTPERMISSIONSTableAdapter
        '
        Me.IMPORTPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'ImportPermissionDetailsBindingSource
        '
        Me.ImportPermissionDetailsBindingSource.DataMember = "ImportPermissionDetails"
        Me.ImportPermissionDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ImportPermissionDetailsTableAdapter
        '
        Me.ImportPermissionDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintImportPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 410)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintImportPermission"
        Me.Text = "طباعة اذن الاستيراد"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.IMPORTPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ImportPermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents IMPORTPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents IMPORTPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.IMPORTPERMISSIONSTableAdapter
    Friend WithEvents ImportPermissionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ImportPermissionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.ImportPermissionDetailsTableAdapter
End Class
