<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class memberlistreport
    Inherits MaterialSkin.Controls.MaterialForm

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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.memberreports = New VBN___Assignment.memberreports()
        Me.customerlistBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.customerlistTableAdapter = New VBN___Assignment.memberreportsTableAdapters.customerlistTableAdapter()
        CType(Me.memberreports, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.customerlistBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.customerlistBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBN___Assignment.memberreports.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(1, 64)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(700, 339)
        Me.ReportViewer1.TabIndex = 0
        '
        'memberreports
        '
        Me.memberreports.DataSetName = "memberreports"
        Me.memberreports.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'customerlistBindingSource
        '
        Me.customerlistBindingSource.DataMember = "customerlist"
        Me.customerlistBindingSource.DataSource = Me.memberreports
        '
        'customerlistTableAdapter
        '
        Me.customerlistTableAdapter.ClearBeforeFill = True
        '
        'memberlistreport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 399)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "memberlistreport"
        Me.Text = "memberlistreport"
        CType(Me.memberreports, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.customerlistBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents customerlistBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents memberreports As VBN___Assignment.memberreports
    Friend WithEvents customerlistTableAdapter As VBN___Assignment.memberreportsTableAdapters.customerlistTableAdapter
End Class
