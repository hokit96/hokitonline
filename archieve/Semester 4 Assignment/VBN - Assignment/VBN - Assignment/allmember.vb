Imports MaterialSkin
Public Class Members
    Dim sql As String = "Select * from customerlist"
    Dim nextpre As Integer = 0
    Private Sub allmember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)

        GV.connection = New OleDb.OleDbConnection(GV.constring)
        GV.connection.Open()
        dataadapter = New OleDb.OleDbDataAdapter(Sql, connection)
        dataadapter.Fill(dataset, "customerlist")
        Call filldata()
    End Sub

    Public Sub filldata()
        lblid.Text = dataset.Tables("customerlist").Rows(nextpre).Item(0)
        lblname.Text = dataset.Tables("customerlist").Rows(nextpre).Item(1)
        lblmembership.Text = dataset.Tables("customerlist").Rows(nextpre).Item(2)
        lblcontact.Text = dataset.Tables("customerlist").Rows(nextpre).Item(3)
        lblemail.Text = dataset.Tables("customerlist").Rows(nextpre).Item(4)

    End Sub

    Private Sub btnprevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        nextpre = nextpre - 1

        If nextpre = -1 Then
            nextpre = 0
            MsgBox("You had reach the first customers!")
        End If
        filldata()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        nextpre = nextpre + 1
        If nextpre >= dataset.Tables("customerlist").Rows.Count Then
            nextpre = 0
        End If
        filldata()
    End Sub
End Class