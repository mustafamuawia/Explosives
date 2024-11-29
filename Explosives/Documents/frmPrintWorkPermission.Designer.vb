<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintWorkPermission
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
        Me.WORKPERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.WorkCopiesDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.WORKPERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter()
        Me.WorkCopiesDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.WorkCopiesDetailsTableAdapter()
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WorkCopiesDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WORKPERMISSIONSBindingSource
        '
        Me.WORKPERMISSIONSBindingSource.DataMember = "WORKPERMISSIONS"
        Me.WORKPERMISSIONSBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WorkCopiesDetailsBindingSource
        '
        Me.WorkCopiesDetailsBindingSource.DataMember = "WorkCopiesDetails"
        Me.WorkCopiesDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsWorkPermission"
        ReportDataSource1.Value = Me.WORKPERMISSIONSBindingSource
        ReportDataSource2.Name = "dsWorkCopies"
        ReportDataSource2.Value = Me.WorkCopiesDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.WorkPermission.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(590, 449)
        Me.ReportViewer1.TabIndex = 0
        '
        'WORKPERMISSIONSTableAdapter
        '
        Me.WORKPERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'WorkCopiesDetailsTableAdapter
        '
        Me.WorkCopiesDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintWorkPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 449)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintWorkPermission"
        Me.Text = "طباعة اذن استخدام"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.WORKPERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WorkCopiesDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents WORKPERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents WorkCopiesDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents WORKPERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.WORKPERMISSIONSTableAdapter
    Friend WithEvents WorkCopiesDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.WorkCopiesDetailsTableAdapter
End Class
