Imports MaterialSkin

Public Class formLogin
    Dim user As String
    Dim pass As String


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GV.connection = New OleDb.OleDbConnection(GV.constring)
        GV.connection.Open()

        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
    End Sub


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user = txtUser.Text
        Dim pass = txtPass.Text

        Dim sql As String = "select * from adminstaff where username='" & user & "'"
        Dim dataadapter As New OleDb.OleDbDataAdapter(sql, connection)
        dataadapter.Fill(dataset, "adminstaff")

        If dataset.Tables("adminstaff").Rows.Count = 1 And pass = dataset.Tables("adminstaff").Rows(0).Item(1).ToString Then
            formMenu.Show()
            Me.Close()
        Else : lblNotification.Text = " Incorrect username or password!"
            txtUser.Clear()
            txtPass.Clear()
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblNotification.Text = ""
        txtUser.Clear()
        txtPass.Clear()
    End Sub
End Class
