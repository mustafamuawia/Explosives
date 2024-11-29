<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmprintPassPermission
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PERMISSIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.PermissionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PassCopiesDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PERMISSIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter()
        Me.PermissionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.PermissionDetailsTableAdapter()
        Me.PassCopiesDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.PassCopiesDetailsTableAdapter()
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassCopiesDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PERMISSIONSBindingSource
        '
        Me.PERMISSIONSBindingSource.DataMember = "PERMISSIONS"
        Me.PERMISSIONSBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.EnforceConstraints = False
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PermissionDetailsBindingSource
        '
        Me.PermissionDetailsBindingSource.DataMember = "PermissionDetails"
        Me.PermissionDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'PassCopiesDetailsBindingSource
        '
        Me.PassCopiesDetailsBindingSource.DataMember = "PassCopiesDetails"
        Me.PassCopiesDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsPassPermission"
        ReportDataSource1.Value = Me.PERMISSIONSBindingSource
        ReportDataSource2.Name = "dsPermissionDetails"
        ReportDataSource2.Value = Me.PermissionDetailsBindingSource
        ReportDataSource3.Name = "dsSirs"
        ReportDataSource3.Value = Me.PassCopiesDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.PassPermission.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(671, 433)
        Me.ReportViewer1.TabIndex = 0
        '
        'PERMISSIONSTableAdapter
        '
        Me.PERMISSIONSTableAdapter.ClearBeforeFill = True
        '
        'PermissionDetailsTableAdapter
        '
        Me.PermissionDetailsTableAdapter.ClearBeforeFill = True
        '
        'PassCopiesDetailsTableAdapter
        '
        Me.PassCopiesDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmprintPassPermission
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 433)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmprintPassPermission"
        Me.Text = "طباعة اذن مرور"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PERMISSIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PermissionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassCopiesDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PERMISSIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents PermissionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PERMISSIONSTableAdapter As Explosives.dsExplosivesTableAdapters.PERMISSIONSTableAdapter
    Friend WithEvents PermissionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.PermissionDetailsTableAdapter
    Friend WithEvents PassCopiesDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PassCopiesDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.PassCopiesDetailsTableAdapter
End Class
