﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintAmmo
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
        Me.AmmoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.AmmoTableAdapter = New Explosives.dsExplosivesTableAdapters.AmmoTableAdapter()
        CType(Me.AmmoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AmmoBindingSource
        '
        Me.AmmoBindingSource.DataMember = "Ammo"
        Me.AmmoBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsAmmo"
        ReportDataSource1.Value = Me.AmmoBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.Ammo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(697, 396)
        Me.ReportViewer1.TabIndex = 0
        '
        'AmmoTableAdapter
        '
        Me.AmmoTableAdapter.ClearBeforeFill = True
        '
        'frmPrintAmmo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 396)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmPrintAmmo"
        Me.Text = "طباعة رخصة ذخيرة"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AmmoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents AmmoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents AmmoTableAdapter As Explosives.dsExplosivesTableAdapters.AmmoTableAdapter
End Class
