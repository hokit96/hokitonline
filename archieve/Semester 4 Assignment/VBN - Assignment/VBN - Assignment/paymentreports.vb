Imports MaterialSkin
Public Class paymentreports

    Private Sub paymentreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'paymentreport.payment' table. You can move, or remove it, as needed.
        Me.paymentTableAdapter.Fill(Me.paymentreport.payment)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        'This is linked to Global.vb 
        GV.connection = New OleDb.OleDbConnection(GV.constring)
        GV.connection.Open()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class