Imports MaterialSkin
Public Class memberlistreport

    Private Sub memberlistreport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'memberreports.customerlist' table. You can move, or remove it, as needed.
        Me.customerlistTableAdapter.Fill(Me.memberreports.customerlist)
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class