Imports MaterialSkin

Public Class formMenu

    Private Sub Form_load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This is for adjust MaterialSkin color
        Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        SkinManager.AddFormToManage(Me)
        SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        SkinManager.ColorScheme = New ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE)
        'This is linked to Global.vb 
        GV.connection = New OleDb.OleDbConnection(GV.constring)
        GV.connection.Open()
    End Sub




    Private Sub logout(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Dim response = MessageBox.Show("Are you sure you want to logout?", "Log out!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If response = Windows.Forms.DialogResult.Yes Then
            Members.Close()
            formLogin.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim sql As String = "insert into customerlist values("
        sql = sql & "'" & addmemberid.Text & "',"
        sql = sql & "'" & addfullname.Text & "',"
        If radioDeluxe.Checked = True Then
            sql = sql & "'Deluxe" & "',"
        End If
        If radionondeluxe.Checked = True Then
            sql = sql & "'Non-deluxe" & "',"
        End If
        If radioweekday.Checked = True Then
            sql = sql & "'Week-day" & "',"
        End If
        sql = sql & "'" & addcontactnumber.Text & "',"
        sql = sql & "'" & addemail.Text & "')"
        command = New OleDb.OleDbCommand(sql, connection)
        command.ExecuteNonQuery()
        MsgBox("Added!")
        'after user added the data successfully the form reset.
        addmemberid.Clear()
        addfullname.Clear()
        addcontactnumber.Clear()
        addemail.Clear()
    End Sub

    Private Sub remove_customer(sender As Object, e As EventArgs) Handles MaterialRaisedButton2.Click
        Dim response = MessageBox.Show("Are you sure you want to remove this customer?", "Remove customer!", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        If response = Windows.Forms.DialogResult.Yes Then
            Dim sql As String
            sql = "delete * from customerlist where customerid='" & removecustomer.Text & "'"
            command = New OleDb.OleDbCommand(sql, connection)
            command.ExecuteNonQuery()
            MsgBox("Customer deleted successfully!")
            removecustomer.Clear()
        End If
    End Sub

    Private Sub Reset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        addmemberid.Clear()
        addfullname.Clear()
        addcontactnumber.Clear()
        addemail.Clear()
    End Sub


    Private Sub updatemember(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        updatememberid.Enabled = False
        updatename.Enabled = False
        Dim sql As String = "update customerlist set "
        sql = sql & "contactnumber='" & updatenumber.Text & "',"
        sql = sql & "email='" & updateemail.Text & "'"

        command = New OleDb.OleDbCommand(sql, connection)
        command.ExecuteNonQuery()
        MsgBox("Customer details updated successfully!")
    End Sub

    Private Sub Search_ID_to_update(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        Dim sql As String = "select * from customerlist where customerid ='" & updatesearchmember.Text & "'"
        dataadapter = New OleDb.OleDbDataAdapter(sql, connection)
        dataadapter.Fill(dataset, "customerlist")
        Call fillupdate()
        updatesearchmember.Clear()
    End Sub

    Public Sub fillupdate()
        updatememberid.Text = dataset.Tables("customerlist").Rows(0).Item(0)
        updatename.Text = dataset.Tables("customerlist").Rows(0).Item(1)
        updatenumber.Text = dataset.Tables("customerlist").Rows(0).Item(3)
        updateemail.Text = dataset.Tables("customerlist").Rows(0).Item(4)
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        Dim sql As String = "select * from customerlist where customerid ='" & searchCustomer.Text & "'"

        dataadapter = New OleDb.OleDbDataAdapter(sql, connection)
        dataadapter.Fill(dataset, "customerlist")
        If dataset.Tables("customerlist").Rows.Count = 1 Then
            lblsearchid.Visible = True
            lblsearchemail.Visible = True
            lblsearchname.Visible = True
            lblsearchmembership.Visible = True
            lblsearchcontact.Visible = True
            not1.Visible = True
            not2.Visible = True
            not3.Visible = True
            not4.Visible = True
            not5.Visible = True
            searchid.Text = dataset.Tables("customerlist").Rows(0).Item(0)
            searchname.Text = dataset.Tables("customerlist").Rows(0).Item(1)
            searchmembership.Text = dataset.Tables("customerlist").Rows(0).Item(2)
            searchcontact.Text = dataset.Tables("customerlist").Rows(0).Item(3)
            searchemail.Text = dataset.Tables("customerlist").Rows(0).Item(4)
            searchCustomer.Clear()
        End If
        If dataset.Tables("customerlist").Rows.Count = 0 Then
            MsgBox("No such user!")
        End If

    End Sub

    Private Sub Rightclick_viewallmember(sender As Object, e As EventArgs) Handles HahaToolStripMenuItem.Click
        Members.Show()
    End Sub

End Class