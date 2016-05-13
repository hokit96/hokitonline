<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentreports
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
        Me.paymentreport = New VBN___Assignment.paymentreport()
        Me.paymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.paymentTableAdapter = New VBN___Assignment.paymentreportTableAdapters.paymentTableAdapter()
        CType(Me.paymentreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.paymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.paymentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBN___Assignment.paymentreport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 65)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(736, 312)
        Me.ReportViewer1.TabIndex = 0
        '
        'paymentreport
        '
        Me.paymentreport.DataSetName = "paymentreport"
        Me.paymentreport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'paymentBindingSource
        '
        Me.paymentBindingSource.DataMember = "payment"
        Me.paymentBindingSource.DataSource = Me.paymentreport
        '
        'paymentTableAdapter
        '
        Me.paymentTableAdapter.ClearBeforeFill = True
        '
        'paymentreports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 379)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "paymentreports"
        Me.Text = "paymentreports"
        CType(Me.paymentreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.paymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents paymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents paymentreport As VBN___Assignment.paymentreport
    Friend WithEvents paymentTableAdapter As VBN___Assignment.paymentreportTableAdapters.paymentTableAdapter
End Class
