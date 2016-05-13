Public Class MakePayment

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label_DateTime.Text = "Date :" & Now
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim registrationfee As Integer
        'Dim monthlyfee As Integer
        Dim transferfee As Integer

        If ComboBox1.SelectedIndex = 0 And Label8.Text = "1" Then
            registrationfee = 500
            Label19.Text = "RM" & registrationfee

        ElseIf ComboBox1.SelectedIndex = 0 And Label8.Text = "2" Then
            registrationfee = 300
            Label19.Text = "RM" & registrationfee

        ElseIf ComboBox1.SelectedIndex = 0 And Label8.Text = "3" Then
            registrationfee = 180
            Label19.Text = "RM" & registrationfee

        ElseIf ComboBox1.SelectedIndex = 2 And Label8.Text = "1" Then
            transferfee = 1000
            Label19.Text = "RM" & transferfee

        ElseIf ComboBox1.SelectedIndex = 2 And Label8.Text = "2" Then
            transferfee = 500
            Label19.Text = "RM" & transferfee

        ElseIf ComboBox1.SelectedIndex = 2 And Label8.Text = "3" Then
            transferfee = 100
            Label19.Text = "RM" & transferfee

            'ElseIf ComboBox1.SelectedItem = "Monthly Fee" & Label8.Text = "M001" Then
            '    monthlyfee = 120
            '    Label19.Text = "RM" & monthlyfee
        End If
    End Sub

    Private Sub MakePayment_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim sql As String = "select * from customerlist where customerid =" & Val(GV.paymentId)
        dataadapter = New OleDb.OleDbDataAdapter(sql, connection)
        dataadapter.Fill(dataset, "customerlist")
        If dataset.Tables("customerlist").Rows.Count = 1 Then
            Label6.Text = dataset.Tables("customerlist").Rows(0).Item(1)
            Label7.Text = dataset.Tables("customerlist").Rows(0).Item(0)
            Label8.Text = dataset.Tables("customerlist").Rows(0).Item(2)
            Label10.Text = dataset.Tables("customerlist").Rows(0).Item(7)
        End If


        ''above is customer details
       
    End Sub

    Private Sub Btn_Cancel_Click(sender As Object, e As EventArgs) Handles Btn_Cancel.Click
        formMenu.Show()
        Me.Close()

    End Sub
End Class