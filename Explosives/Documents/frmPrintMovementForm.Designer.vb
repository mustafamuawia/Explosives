<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintMovementForm
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.MovementFormsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovementFormsTableAdapter = New Explosives.dsExplosivesTableAdapters.MovementFormsTableAdapter()
        Me.MovementFormDetialsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MovementFormDetialsTableAdapter = New Explosives.dsExplosivesTableAdapters.MovementFormDetialsTableAdapter()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovementFormsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MovementFormDetialsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsMovementForm"
        ReportDataSource1.Value = Me.MovementFormsBindingSource
        ReportDataSource2.Name = "dsMovementFormDetails"
        ReportDataSource2.Value = Me.MovementFormDetialsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.MovementForm.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(284, 261)
        Me.ReportViewer1.TabIndex = 0
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MovementFormsBindingSource
        '
        Me.MovementFormsBindingSource.DataMember = "MovementForms"
        Me.MovementFormsBindingSource.DataSource = Me.dsExplosives
        '
        'MovementFormsTableAdapter
        '
        Me.MovementFormsTableAdapter.ClearBeforeFill = True
        '
        'MovementFormDetialsBindingSource
        '
        Me.MovementFormDetialsBindingSource.DataMember = "MovementFormDetials"
        Me.MovementFormDetialsBindingSource.DataSource = Me.dsExplosives
        '
        'MovementFormDetialsTableAdapter
        '
        Me.MovementFormDetialsTableAdapter.ClearBeforeFill = True
        '
        'frmPrintMovementForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintMovementForm"
        Me.Text = "طباعة اورنيك التحركات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovementFormsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MovementFormDetialsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MovementFormsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents MovementFormDetialsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MovementFormsTableAdapter As Explosives.dsExplosivesTableAdapters.MovementFormsTableAdapter
    Friend WithEvents MovementFormDetialsTableAdapter As Explosives.dsExplosivesTableAdapters.MovementFormDetialsTableAdapter
End Class
