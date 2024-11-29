<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintNoObjection
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
        Me.NOOBJECTIONSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.NoObjectionDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.NOOBJECTIONSTableAdapter = New Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter()
        Me.NoObjectionDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.NoObjectionDetailsTableAdapter()
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoObjectionDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NOOBJECTIONSBindingSource
        '
        Me.NOOBJECTIONSBindingSource.DataMember = "NOOBJECTIONS"
        Me.NOOBJECTIONSBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NoObjectionDetailsBindingSource
        '
        Me.NoObjectionDetailsBindingSource.DataMember = "NoObjectionDetails"
        Me.NoObjectionDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsNoObjection"
        ReportDataSource1.Value = Me.NOOBJECTIONSBindingSource
        ReportDataSource2.Name = "dsNoObjectionDetails"
        ReportDataSource2.Value = Me.NoObjectionDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.NoObjection.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(776, 439)
        Me.ReportViewer1.TabIndex = 0
        '
        'NOOBJECTIONSTableAdapter
        '
        Me.NOOBJECTIONSTableAdapter.ClearBeforeFill = True
        '
        'NoObjectionDetailsTableAdapter
        '
        Me.NoObjectionDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintNoObjection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 439)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintNoObjection"
        Me.Text = "طباعة عدم ممانعة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.NOOBJECTIONSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoObjectionDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents NOOBJECTIONSBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents NoObjectionDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOOBJECTIONSTableAdapter As Explosives.dsExplosivesTableAdapters.NOOBJECTIONSTableAdapter
    Friend WithEvents NoObjectionDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.NoObjectionDetailsTableAdapter
End Class
