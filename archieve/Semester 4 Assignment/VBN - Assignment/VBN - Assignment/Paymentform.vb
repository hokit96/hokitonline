Public Class Paymentform

    Private Sub Paymentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet2.payment' table. You can move, or remove it, as needed.
        Me.paymentTableAdapter.Fill(Me.DataSet2.payment)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class