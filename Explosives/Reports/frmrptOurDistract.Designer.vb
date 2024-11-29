<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmrptOurDistract
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
        Me.OURDISTRACTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsExplosives = New Explosives.dsExplosives()
        Me.OurDistractDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dtpTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.OURDISTRACTTableAdapter = New Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter()
        Me.OurDistractDetailsTableAdapter = New Explosives.dsExplosivesTableAdapters.OurDistractDetailsTableAdapter()
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OurDistractDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OURDISTRACTBindingSource
        '
        Me.OURDISTRACTBindingSource.DataMember = "OURDISTRACT"
        Me.OURDISTRACTBindingSource.DataSource = Me.dsExplosives
        '
        'dsExplosives
        '
        Me.dsExplosives.DataSetName = "dsExplosives"
        Me.dsExplosives.EnforceConstraints = False
        Me.dsExplosives.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OurDistractDetailsBindingSource
        '
        Me.OurDistractDetailsBindingSource.DataMember = "OurDistractDetails"
        Me.OurDistractDetailsBindingSource.DataSource = Me.dsExplosives
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "dsOurDistract"
        ReportDataSource1.Value = Me.OURDISTRACTBindingSource
        ReportDataSource2.Name = "dsOurDistractDetails"
        ReportDataSource2.Value = Me.OurDistractDetailsBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Explosives.OurDistract.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(963, 404)
        Me.ReportViewer1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(826, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(29, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "من"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(212, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpTo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnOpen)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ReportViewer1)
        Me.SplitContainer1.Size = New System.Drawing.Size(963, 468)
        Me.SplitContainer1.SplitterDistance = 58
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 1
        '
        'dtpTo
        '
        Me.dtpTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTo.Location = New System.Drawing.Point(447, 14)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpTo.RightToLeftLayout = True
        Me.dtpTo.Size = New System.Drawing.Size(137, 27)
        Me.dtpTo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(600, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(34, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "إلى"
        '
        'dtpFrom
        '
        Me.dtpFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFrom.Location = New System.Drawing.Point(673, 14)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dtpFrom.RightToLeftLayout = True
        Me.dtpFrom.Size = New System.Drawing.Size(137, 27)
        Me.dtpFrom.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(117, Byte), Integer))
        Me.btnOpen.ForeColor = System.Drawing.Color.White
        Me.btnOpen.Location = New System.Drawing.Point(202, 12)
        Me.btnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnOpen.Size = New System.Drawing.Size(112, 34)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "فتح التقرير"
        Me.btnOpen.UseVisualStyleBackColor = False
        '
        'OURDISTRACTTableAdapter
        '
        Me.OURDISTRACTTableAdapter.ClearBeforeFill = True
        '
        'OurDistractDetailsTableAdapter
        '
        Me.OurDistractDetailsTableAdapter.ClearBeforeFill = True
        '
        'frmrptOurDistract
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 468)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmrptOurDistract"
        Me.Text = "تقرير المنصرف"
        CType(Me.OURDISTRACTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsExplosives, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OurDistractDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents dtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents OURDISTRACTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dsExplosives As Explosives.dsExplosives
    Friend WithEvents OURDISTRACTTableAdapter As Explosives.dsExplosivesTableAdapters.OURDISTRACTTableAdapter
    Friend WithEvents OurDistractDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OurDistractDetailsTableAdapter As Explosives.dsExplosivesTableAdapters.OurDistractDetailsTableAdapter
End Class
