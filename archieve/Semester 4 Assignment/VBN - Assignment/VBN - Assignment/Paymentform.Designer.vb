<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paymentform
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
        Me.paymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New VBN___Assignment.DataSet2()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.paymentTableAdapter = New VBN___Assignment.DataSet2TableAdapters.paymentTableAdapter()
        CType(Me.paymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'paymentBindingSource
        '
        Me.paymentBindingSource.DataMember = "payment"
        Me.paymentBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "payment"
        ReportDataSource1.Value = Me.paymentBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "VBN___Assignment.payment.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 63)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(868, 376)
        Me.ReportViewer1.TabIndex = 0
        '
        'paymentTableAdapter
        '
        Me.paymentTableAdapter.ClearBeforeFill = True
        '
        'Paymentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 437)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "Paymentform"
        Me.Text = "Payment Report"
        CType(Me.paymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents paymentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataSet2 As VBN___Assignment.DataSet2
    Friend WithEvents paymentTableAdapter As VBN___Assignment.DataSet2TableAdapters.paymentTableAdapter
End Class
