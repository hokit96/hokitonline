<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMenu
	'Must add MaterialSkin.Controls.MaterialForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formMenu))
        Me.searchpicture = New MaterialSkin.Controls.MaterialTabControl()
        Me.contextmenustrip = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.HahaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.add = New System.Windows.Forms.TabPage()
        Me.addpicture = New System.Windows.Forms.PictureBox()
        Me.Reset = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnAdd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.radioweekday = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radionondeluxe = New MaterialSkin.Controls.MaterialRadioButton()
        Me.radioDeluxe = New MaterialSkin.Controls.MaterialRadioButton()
        Me.addemail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.addcontactnumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.addfullname = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.addmemberid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lbl = New MaterialSkin.Controls.MaterialLabel()
        Me.lblemail = New MaterialSkin.Controls.MaterialLabel()
        Me.lblcontactno = New MaterialSkin.Controls.MaterialLabel()
        Me.lblmembership = New MaterialSkin.Controls.MaterialLabel()
        Me.lblfirstname = New MaterialSkin.Controls.MaterialLabel()
        Me.lblmemberid = New MaterialSkin.Controls.MaterialLabel()
        Me.remove = New System.Windows.Forms.TabPage()
        Me.removecustomer = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialRaisedButton2 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.update = New System.Windows.Forms.TabPage()
        Me.MaterialFlatButton2 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.updatesearchmember = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.updatepicture = New System.Windows.Forms.PictureBox()
        Me.MaterialRaisedButton1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.MaterialRadioButton2 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialRadioButton1 = New MaterialSkin.Controls.MaterialRadioButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.updateemail = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.updatenumber = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.updatename = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.updatememberid = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel13 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel16 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel17 = New MaterialSkin.Controls.MaterialLabel()
        Me.search = New System.Windows.Forms.TabPage()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.searchemail = New MaterialSkin.Controls.MaterialLabel()
        Me.searchcontact = New MaterialSkin.Controls.MaterialLabel()
        Me.searchmembership = New MaterialSkin.Controls.MaterialLabel()
        Me.searchid = New MaterialSkin.Controls.MaterialLabel()
        Me.searchname = New MaterialSkin.Controls.MaterialLabel()
        Me.not2 = New MaterialSkin.Controls.MaterialLabel()
        Me.not3 = New MaterialSkin.Controls.MaterialLabel()
        Me.not4 = New MaterialSkin.Controls.MaterialLabel()
        Me.not5 = New MaterialSkin.Controls.MaterialLabel()
        Me.not1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblsearchemail = New MaterialSkin.Controls.MaterialLabel()
        Me.lblsearchcontact = New MaterialSkin.Controls.MaterialLabel()
        Me.lblsearchmembership = New MaterialSkin.Controls.MaterialLabel()
        Me.lblsearchid = New MaterialSkin.Controls.MaterialLabel()
        Me.lblsearchname = New MaterialSkin.Controls.MaterialLabel()
        Me.searchpic = New System.Windows.Forms.PictureBox()
        Me.searchCustomer = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.membership = New System.Windows.Forms.TabPage()
        Me.payment = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.searchpicture.SuspendLayout()
        Me.contextmenustrip.SuspendLayout()
        Me.add.SuspendLayout()
        CType(Me.addpicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.remove.SuspendLayout()
        Me.update.SuspendLayout()
        CType(Me.updatepicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.search.SuspendLayout()
        CType(Me.searchpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'searchpicture
        '
        Me.searchpicture.ContextMenuStrip = Me.contextmenustrip
        Me.searchpicture.Controls.Add(Me.add)
        Me.searchpicture.Controls.Add(Me.remove)
        Me.searchpicture.Controls.Add(Me.update)
        Me.searchpicture.Controls.Add(Me.search)
        Me.searchpicture.Controls.Add(Me.membership)
        Me.searchpicture.Controls.Add(Me.payment)
        Me.searchpicture.Depth = 0
        Me.searchpicture.Location = New System.Drawing.Point(3, 100)
        Me.searchpicture.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchpicture.Name = "searchpicture"
        Me.searchpicture.SelectedIndex = 0
        Me.searchpicture.Size = New System.Drawing.Size(639, 444)
        Me.searchpicture.TabIndex = 1
        '
        'contextmenustrip
        '
        Me.contextmenustrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.contextmenustrip.Depth = 0
        Me.contextmenustrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HahaToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.contextmenustrip.MouseState = MaterialSkin.MouseState.HOVER
        Me.contextmenustrip.Name = "contextmenustrip"
        Me.contextmenustrip.Size = New System.Drawing.Size(148, 48)
        '
        'HahaToolStripMenuItem
        '
        Me.HahaToolStripMenuItem.Name = "HahaToolStripMenuItem"
        Me.HahaToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.HahaToolStripMenuItem.Text = "View member"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'add
        '
        Me.add.BackColor = System.Drawing.Color.White
        Me.add.ContextMenuStrip = Me.contextmenustrip
        Me.add.Controls.Add(Me.addpicture)
        Me.add.Controls.Add(Me.Reset)
        Me.add.Controls.Add(Me.btnAdd)
        Me.add.Controls.Add(Me.radioweekday)
        Me.add.Controls.Add(Me.radionondeluxe)
        Me.add.Controls.Add(Me.radioDeluxe)
        Me.add.Controls.Add(Me.addemail)
        Me.add.Controls.Add(Me.addcontactnumber)
        Me.add.Controls.Add(Me.addfullname)
        Me.add.Controls.Add(Me.addmemberid)
        Me.add.Controls.Add(Me.MaterialLabel5)
        Me.add.Controls.Add(Me.MaterialLabel4)
        Me.add.Controls.Add(Me.MaterialLabel3)
        Me.add.Controls.Add(Me.MaterialLabel1)
        Me.add.Controls.Add(Me.lbl)
        Me.add.Controls.Add(Me.lblemail)
        Me.add.Controls.Add(Me.lblcontactno)
        Me.add.Controls.Add(Me.lblmembership)
        Me.add.Controls.Add(Me.lblfirstname)
        Me.add.Controls.Add(Me.lblmemberid)
        Me.add.Location = New System.Drawing.Point(4, 22)
        Me.add.Name = "add"
        Me.add.Padding = New System.Windows.Forms.Padding(3)
        Me.add.Size = New System.Drawing.Size(631, 418)
        Me.add.TabIndex = 0
        Me.add.Text = "ADD"
        '
        'addpicture
        '
        Me.addpicture.Location = New System.Drawing.Point(260, 6)
        Me.addpicture.Name = "addpicture"
        Me.addpicture.Size = New System.Drawing.Size(100, 133)
        Me.addpicture.TabIndex = 28
        Me.addpicture.TabStop = False
        '
        'Reset
        '
        Me.Reset.AutoSize = True
        Me.Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Reset.Depth = 0
        Me.Reset.Location = New System.Drawing.Point(329, 331)
        Me.Reset.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Reset.MouseState = MaterialSkin.MouseState.HOVER
        Me.Reset.Name = "Reset"
        Me.Reset.Primary = False
        Me.Reset.Size = New System.Drawing.Size(53, 36)
        Me.Reset.TabIndex = 27
        Me.Reset.Text = "Reset"
        Me.Reset.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Depth = 0
        Me.btnAdd.Location = New System.Drawing.Point(238, 334)
        Me.btnAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Primary = True
        Me.btnAdd.Size = New System.Drawing.Size(53, 30)
        Me.btnAdd.TabIndex = 26
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'radioweekday
        '
        Me.radioweekday.AutoSize = True
        Me.radioweekday.Depth = 0
        Me.radioweekday.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radioweekday.Location = New System.Drawing.Point(483, 216)
        Me.radioweekday.Margin = New System.Windows.Forms.Padding(0)
        Me.radioweekday.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radioweekday.MouseState = MaterialSkin.MouseState.HOVER
        Me.radioweekday.Name = "radioweekday"
        Me.radioweekday.Ripple = True
        Me.radioweekday.Size = New System.Drawing.Size(91, 30)
        Me.radioweekday.TabIndex = 25
        Me.radioweekday.TabStop = True
        Me.radioweekday.Text = "Week-Day"
        Me.radioweekday.UseVisualStyleBackColor = True
        '
        'radionondeluxe
        '
        Me.radionondeluxe.AutoSize = True
        Me.radionondeluxe.Depth = 0
        Me.radionondeluxe.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radionondeluxe.Location = New System.Drawing.Point(383, 216)
        Me.radionondeluxe.Margin = New System.Windows.Forms.Padding(0)
        Me.radionondeluxe.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radionondeluxe.MouseState = MaterialSkin.MouseState.HOVER
        Me.radionondeluxe.Name = "radionondeluxe"
        Me.radionondeluxe.Ripple = True
        Me.radionondeluxe.Size = New System.Drawing.Size(100, 30)
        Me.radionondeluxe.TabIndex = 24
        Me.radionondeluxe.TabStop = True
        Me.radionondeluxe.Text = "Non-Deluxe"
        Me.radionondeluxe.UseVisualStyleBackColor = True
        '
        'radioDeluxe
        '
        Me.radioDeluxe.AutoSize = True
        Me.radioDeluxe.Depth = 0
        Me.radioDeluxe.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.radioDeluxe.Location = New System.Drawing.Point(298, 216)
        Me.radioDeluxe.Margin = New System.Windows.Forms.Padding(0)
        Me.radioDeluxe.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.radioDeluxe.MouseState = MaterialSkin.MouseState.HOVER
        Me.radioDeluxe.Name = "radioDeluxe"
        Me.radioDeluxe.Ripple = True
        Me.radioDeluxe.Size = New System.Drawing.Size(71, 30)
        Me.radioDeluxe.TabIndex = 23
        Me.radioDeluxe.TabStop = True
        Me.radioDeluxe.Text = "Deluxe"
        Me.radioDeluxe.UseVisualStyleBackColor = True
        '
        'addemail
        '
        Me.addemail.Depth = 0
        Me.addemail.Hint = ""
        Me.addemail.Location = New System.Drawing.Point(298, 275)
        Me.addemail.MaxLength = 32767
        Me.addemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.addemail.Name = "addemail"
        Me.addemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addemail.SelectedText = ""
        Me.addemail.SelectionLength = 0
        Me.addemail.SelectionStart = 0
        Me.addemail.Size = New System.Drawing.Size(276, 23)
        Me.addemail.TabIndex = 22
        Me.addemail.TabStop = False
        Me.addemail.UseSystemPasswordChar = False
        '
        'addcontactnumber
        '
        Me.addcontactnumber.Depth = 0
        Me.addcontactnumber.Hint = ""
        Me.addcontactnumber.Location = New System.Drawing.Point(298, 246)
        Me.addcontactnumber.MaxLength = 32767
        Me.addcontactnumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.addcontactnumber.Name = "addcontactnumber"
        Me.addcontactnumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addcontactnumber.SelectedText = ""
        Me.addcontactnumber.SelectionLength = 0
        Me.addcontactnumber.SelectionStart = 0
        Me.addcontactnumber.Size = New System.Drawing.Size(276, 23)
        Me.addcontactnumber.TabIndex = 21
        Me.addcontactnumber.TabStop = False
        Me.addcontactnumber.UseSystemPasswordChar = False
        '
        'addfullname
        '
        Me.addfullname.Depth = 0
        Me.addfullname.Hint = ""
        Me.addfullname.Location = New System.Drawing.Point(298, 188)
        Me.addfullname.MaxLength = 32767
        Me.addfullname.MouseState = MaterialSkin.MouseState.HOVER
        Me.addfullname.Name = "addfullname"
        Me.addfullname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addfullname.SelectedText = ""
        Me.addfullname.SelectionLength = 0
        Me.addfullname.SelectionStart = 0
        Me.addfullname.Size = New System.Drawing.Size(276, 23)
        Me.addfullname.TabIndex = 14
        Me.addfullname.TabStop = False
        Me.addfullname.UseSystemPasswordChar = False
        '
        'addmemberid
        '
        Me.addmemberid.Depth = 0
        Me.addmemberid.Hint = ""
        Me.addmemberid.Location = New System.Drawing.Point(298, 159)
        Me.addmemberid.MaxLength = 32767
        Me.addmemberid.MouseState = MaterialSkin.MouseState.HOVER
        Me.addmemberid.Name = "addmemberid"
        Me.addmemberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.addmemberid.SelectedText = ""
        Me.addmemberid.SelectionLength = 0
        Me.addmemberid.SelectionStart = 0
        Me.addmemberid.Size = New System.Drawing.Size(276, 23)
        Me.addmemberid.TabIndex = 13
        Me.addmemberid.TabStop = False
        Me.addmemberid.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(256, 279)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel5.TabIndex = 12
        Me.MaterialLabel5.Text = ":"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(256, 250)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel4.TabIndex = 11
        Me.MaterialLabel4.Text = ":"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(256, 221)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel3.TabIndex = 10
        Me.MaterialLabel3.Text = ":"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(256, 192)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel1.TabIndex = 8
        Me.MaterialLabel1.Text = ":"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Depth = 0
        Me.lbl.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl.Location = New System.Drawing.Point(256, 163)
        Me.lbl.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(13, 19)
        Me.lbl.TabIndex = 7
        Me.lbl.Text = ":"
        '
        'lblemail
        '
        Me.lblemail.AutoSize = True
        Me.lblemail.Depth = 0
        Me.lblemail.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblemail.Location = New System.Drawing.Point(53, 279)
        Me.lblemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(47, 19)
        Me.lblemail.TabIndex = 6
        Me.lblemail.Text = "Email"
        '
        'lblcontactno
        '
        Me.lblcontactno.AutoSize = True
        Me.lblcontactno.Depth = 0
        Me.lblcontactno.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblcontactno.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblcontactno.Location = New System.Drawing.Point(53, 250)
        Me.lblcontactno.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblcontactno.Name = "lblcontactno"
        Me.lblcontactno.Size = New System.Drawing.Size(116, 19)
        Me.lblcontactno.TabIndex = 5
        Me.lblcontactno.Text = "Contact number"
        '
        'lblmembership
        '
        Me.lblmembership.AutoSize = True
        Me.lblmembership.Depth = 0
        Me.lblmembership.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblmembership.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmembership.Location = New System.Drawing.Point(53, 221)
        Me.lblmembership.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblmembership.Name = "lblmembership"
        Me.lblmembership.Size = New System.Drawing.Size(146, 19)
        Me.lblmembership.TabIndex = 4
        Me.lblmembership.Text = "Type of membership"
        '
        'lblfirstname
        '
        Me.lblfirstname.AutoSize = True
        Me.lblfirstname.Depth = 0
        Me.lblfirstname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblfirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblfirstname.Location = New System.Drawing.Point(53, 192)
        Me.lblfirstname.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblfirstname.Name = "lblfirstname"
        Me.lblfirstname.Size = New System.Drawing.Size(74, 19)
        Me.lblfirstname.TabIndex = 2
        Me.lblfirstname.Text = "Full name"
        '
        'lblmemberid
        '
        Me.lblmemberid.AutoSize = True
        Me.lblmemberid.Depth = 0
        Me.lblmemberid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblmemberid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblmemberid.Location = New System.Drawing.Point(53, 163)
        Me.lblmemberid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblmemberid.Name = "lblmemberid"
        Me.lblmemberid.Size = New System.Drawing.Size(82, 19)
        Me.lblmemberid.TabIndex = 1
        Me.lblmemberid.Text = "Member ID"
        '
        'remove
        '
        Me.remove.BackColor = System.Drawing.Color.White
        Me.remove.Controls.Add(Me.removecustomer)
        Me.remove.Controls.Add(Me.MaterialRaisedButton2)
        Me.remove.Location = New System.Drawing.Point(4, 22)
        Me.remove.Name = "remove"
        Me.remove.Padding = New System.Windows.Forms.Padding(3)
        Me.remove.Size = New System.Drawing.Size(631, 418)
        Me.remove.TabIndex = 1
        Me.remove.Text = "REMOVE"
        '
        'removecustomer
        '
        Me.removecustomer.Depth = 0
        Me.removecustomer.Hint = "Please insert the customer ID which you wish to remove."
        Me.removecustomer.Location = New System.Drawing.Point(117, 160)
        Me.removecustomer.MaxLength = 32767
        Me.removecustomer.MouseState = MaterialSkin.MouseState.HOVER
        Me.removecustomer.Name = "removecustomer"
        Me.removecustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.removecustomer.SelectedText = ""
        Me.removecustomer.SelectionLength = 0
        Me.removecustomer.SelectionStart = 0
        Me.removecustomer.Size = New System.Drawing.Size(405, 23)
        Me.removecustomer.TabIndex = 1
        Me.removecustomer.TabStop = False
        Me.removecustomer.UseSystemPasswordChar = False
        '
        'MaterialRaisedButton2
        '
        Me.MaterialRaisedButton2.Depth = 0
        Me.MaterialRaisedButton2.Location = New System.Drawing.Point(257, 218)
        Me.MaterialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton2.Name = "MaterialRaisedButton2"
        Me.MaterialRaisedButton2.Primary = True
        Me.MaterialRaisedButton2.Size = New System.Drawing.Size(121, 43)
        Me.MaterialRaisedButton2.TabIndex = 0
        Me.MaterialRaisedButton2.Text = "Remove"
        Me.MaterialRaisedButton2.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.White
        Me.update.Controls.Add(Me.MaterialFlatButton2)
        Me.update.Controls.Add(Me.updatesearchmember)
        Me.update.Controls.Add(Me.updatepicture)
        Me.update.Controls.Add(Me.MaterialRaisedButton1)
        Me.update.Controls.Add(Me.MaterialRadioButton2)
        Me.update.Controls.Add(Me.MaterialRadioButton1)
        Me.update.Controls.Add(Me.MaterialLabel6)
        Me.update.Controls.Add(Me.MaterialLabel2)
        Me.update.Controls.Add(Me.updateemail)
        Me.update.Controls.Add(Me.updatenumber)
        Me.update.Controls.Add(Me.updatename)
        Me.update.Controls.Add(Me.updatememberid)
        Me.update.Controls.Add(Me.MaterialLabel7)
        Me.update.Controls.Add(Me.MaterialLabel9)
        Me.update.Controls.Add(Me.MaterialLabel10)
        Me.update.Controls.Add(Me.MaterialLabel11)
        Me.update.Controls.Add(Me.MaterialLabel12)
        Me.update.Controls.Add(Me.MaterialLabel13)
        Me.update.Controls.Add(Me.MaterialLabel16)
        Me.update.Controls.Add(Me.MaterialLabel17)
        Me.update.Location = New System.Drawing.Point(4, 22)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(631, 418)
        Me.update.TabIndex = 2
        Me.update.Text = "UPDATE"
        '
        'MaterialFlatButton2
        '
        Me.MaterialFlatButton2.AutoSize = True
        Me.MaterialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton2.Depth = 0
        Me.MaterialFlatButton2.Location = New System.Drawing.Point(545, 6)
        Me.MaterialFlatButton2.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton2.Name = "MaterialFlatButton2"
        Me.MaterialFlatButton2.Primary = False
        Me.MaterialFlatButton2.Size = New System.Drawing.Size(64, 36)
        Me.MaterialFlatButton2.TabIndex = 49
        Me.MaterialFlatButton2.Text = "Search"
        Me.MaterialFlatButton2.UseVisualStyleBackColor = True
        '
        'updatesearchmember
        '
        Me.updatesearchmember.Depth = 0
        Me.updatesearchmember.Hint = "Please enter customer profile you wish to update"
        Me.updatesearchmember.Location = New System.Drawing.Point(34, 9)
        Me.updatesearchmember.MaxLength = 32767
        Me.updatesearchmember.MouseState = MaterialSkin.MouseState.HOVER
        Me.updatesearchmember.Name = "updatesearchmember"
        Me.updatesearchmember.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatesearchmember.SelectedText = ""
        Me.updatesearchmember.SelectionLength = 0
        Me.updatesearchmember.SelectionStart = 0
        Me.updatesearchmember.Size = New System.Drawing.Size(483, 23)
        Me.updatesearchmember.TabIndex = 48
        Me.updatesearchmember.TabStop = False
        Me.updatesearchmember.UseSystemPasswordChar = False
        '
        'updatepicture
        '
        Me.updatepicture.Location = New System.Drawing.Point(261, 38)
        Me.updatepicture.Name = "updatepicture"
        Me.updatepicture.Size = New System.Drawing.Size(100, 133)
        Me.updatepicture.TabIndex = 47
        Me.updatepicture.TabStop = False
        '
        'MaterialRaisedButton1
        '
        Me.MaterialRaisedButton1.Depth = 0
        Me.MaterialRaisedButton1.Location = New System.Drawing.Point(299, 342)
        Me.MaterialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRaisedButton1.Name = "MaterialRaisedButton1"
        Me.MaterialRaisedButton1.Primary = True
        Me.MaterialRaisedButton1.Size = New System.Drawing.Size(106, 32)
        Me.MaterialRaisedButton1.TabIndex = 46
        Me.MaterialRaisedButton1.Text = "UPDATE"
        Me.MaterialRaisedButton1.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton2
        '
        Me.MaterialRadioButton2.AutoSize = True
        Me.MaterialRadioButton2.Depth = 0
        Me.MaterialRadioButton2.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton2.Location = New System.Drawing.Point(431, 288)
        Me.MaterialRadioButton2.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton2.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton2.Name = "MaterialRadioButton2"
        Me.MaterialRadioButton2.Ripple = True
        Me.MaterialRadioButton2.Size = New System.Drawing.Size(71, 30)
        Me.MaterialRadioButton2.TabIndex = 45
        Me.MaterialRadioButton2.Text = "Closed"
        Me.MaterialRadioButton2.UseVisualStyleBackColor = True
        '
        'MaterialRadioButton1
        '
        Me.MaterialRadioButton1.AutoSize = True
        Me.MaterialRadioButton1.Checked = True
        Me.MaterialRadioButton1.Depth = 0
        Me.MaterialRadioButton1.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.MaterialRadioButton1.Location = New System.Drawing.Point(299, 288)
        Me.MaterialRadioButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.MaterialRadioButton1.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.MaterialRadioButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialRadioButton1.Name = "MaterialRadioButton1"
        Me.MaterialRadioButton1.Ripple = True
        Me.MaterialRadioButton1.Size = New System.Drawing.Size(68, 30)
        Me.MaterialRadioButton1.TabIndex = 44
        Me.MaterialRadioButton1.TabStop = True
        Me.MaterialRadioButton1.Text = "Active"
        Me.MaterialRadioButton1.UseVisualStyleBackColor = True
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(257, 293)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel6.TabIndex = 43
        Me.MaterialLabel6.Text = ":"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(56, 293)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(52, 19)
        Me.MaterialLabel2.TabIndex = 42
        Me.MaterialLabel2.Text = "Status"
        '
        'updateemail
        '
        Me.updateemail.Depth = 0
        Me.updateemail.Hint = ""
        Me.updateemail.Location = New System.Drawing.Point(299, 260)
        Me.updateemail.MaxLength = 32767
        Me.updateemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.updateemail.Name = "updateemail"
        Me.updateemail.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updateemail.SelectedText = ""
        Me.updateemail.SelectionLength = 0
        Me.updateemail.SelectionStart = 0
        Me.updateemail.Size = New System.Drawing.Size(276, 23)
        Me.updateemail.TabIndex = 41
        Me.updateemail.TabStop = False
        Me.updateemail.UseSystemPasswordChar = False
        '
        'updatenumber
        '
        Me.updatenumber.Depth = 0
        Me.updatenumber.Hint = ""
        Me.updatenumber.Location = New System.Drawing.Point(299, 231)
        Me.updatenumber.MaxLength = 32767
        Me.updatenumber.MouseState = MaterialSkin.MouseState.HOVER
        Me.updatenumber.Name = "updatenumber"
        Me.updatenumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatenumber.SelectedText = ""
        Me.updatenumber.SelectionLength = 0
        Me.updatenumber.SelectionStart = 0
        Me.updatenumber.Size = New System.Drawing.Size(276, 23)
        Me.updatenumber.TabIndex = 40
        Me.updatenumber.TabStop = False
        Me.updatenumber.UseSystemPasswordChar = False
        '
        'updatename
        '
        Me.updatename.Depth = 0
        Me.updatename.Enabled = False
        Me.updatename.Hint = ""
        Me.updatename.Location = New System.Drawing.Point(299, 202)
        Me.updatename.MaxLength = 32767
        Me.updatename.MouseState = MaterialSkin.MouseState.HOVER
        Me.updatename.Name = "updatename"
        Me.updatename.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatename.SelectedText = ""
        Me.updatename.SelectionLength = 0
        Me.updatename.SelectionStart = 0
        Me.updatename.Size = New System.Drawing.Size(276, 23)
        Me.updatename.TabIndex = 39
        Me.updatename.TabStop = False
        Me.updatename.UseSystemPasswordChar = False
        '
        'updatememberid
        '
        Me.updatememberid.Depth = 0
        Me.updatememberid.Enabled = False
        Me.updatememberid.Hint = ""
        Me.updatememberid.Location = New System.Drawing.Point(299, 173)
        Me.updatememberid.MaxLength = 32767
        Me.updatememberid.MouseState = MaterialSkin.MouseState.HOVER
        Me.updatememberid.Name = "updatememberid"
        Me.updatememberid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.updatememberid.SelectedText = ""
        Me.updatememberid.SelectionLength = 0
        Me.updatememberid.SelectionStart = 0
        Me.updatememberid.Size = New System.Drawing.Size(276, 23)
        Me.updatememberid.TabIndex = 38
        Me.updatememberid.TabStop = False
        Me.updatememberid.UseSystemPasswordChar = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(257, 264)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel7.TabIndex = 36
        Me.MaterialLabel7.Text = ":"
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(257, 235)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel9.TabIndex = 34
        Me.MaterialLabel9.Text = ":"
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(257, 206)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel10.TabIndex = 33
        Me.MaterialLabel10.Text = ":"
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(257, 177)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(13, 19)
        Me.MaterialLabel11.TabIndex = 32
        Me.MaterialLabel11.Text = ":"
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(56, 264)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel12.TabIndex = 31
        Me.MaterialLabel12.Text = "Email"
        '
        'MaterialLabel13
        '
        Me.MaterialLabel13.AutoSize = True
        Me.MaterialLabel13.Depth = 0
        Me.MaterialLabel13.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel13.Location = New System.Drawing.Point(56, 235)
        Me.MaterialLabel13.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel13.Name = "MaterialLabel13"
        Me.MaterialLabel13.Size = New System.Drawing.Size(116, 19)
        Me.MaterialLabel13.TabIndex = 30
        Me.MaterialLabel13.Text = "Contact number"
        '
        'MaterialLabel16
        '
        Me.MaterialLabel16.AutoSize = True
        Me.MaterialLabel16.Depth = 0
        Me.MaterialLabel16.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel16.Location = New System.Drawing.Point(56, 206)
        Me.MaterialLabel16.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel16.Name = "MaterialLabel16"
        Me.MaterialLabel16.Size = New System.Drawing.Size(74, 19)
        Me.MaterialLabel16.TabIndex = 27
        Me.MaterialLabel16.Text = "Full name"
        '
        'MaterialLabel17
        '
        Me.MaterialLabel17.AutoSize = True
        Me.MaterialLabel17.Depth = 0
        Me.MaterialLabel17.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel17.Location = New System.Drawing.Point(56, 177)
        Me.MaterialLabel17.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel17.Name = "MaterialLabel17"
        Me.MaterialLabel17.Size = New System.Drawing.Size(82, 19)
        Me.MaterialLabel17.TabIndex = 26
        Me.MaterialLabel17.Text = "Member ID"
        '
        'search
        '
        Me.search.BackColor = System.Drawing.Color.White
        Me.search.Controls.Add(Me.MaterialFlatButton1)
        Me.search.Controls.Add(Me.searchemail)
        Me.search.Controls.Add(Me.searchcontact)
        Me.search.Controls.Add(Me.searchmembership)
        Me.search.Controls.Add(Me.searchid)
        Me.search.Controls.Add(Me.searchname)
        Me.search.Controls.Add(Me.not2)
        Me.search.Controls.Add(Me.not3)
        Me.search.Controls.Add(Me.not4)
        Me.search.Controls.Add(Me.not5)
        Me.search.Controls.Add(Me.not1)
        Me.search.Controls.Add(Me.lblsearchemail)
        Me.search.Controls.Add(Me.lblsearchcontact)
        Me.search.Controls.Add(Me.lblsearchmembership)
        Me.search.Controls.Add(Me.lblsearchid)
        Me.search.Controls.Add(Me.lblsearchname)
        Me.search.Controls.Add(Me.searchpic)
        Me.search.Controls.Add(Me.searchCustomer)
        Me.search.Location = New System.Drawing.Point(4, 22)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(631, 418)
        Me.search.TabIndex = 3
        Me.search.Text = "SEARCH"
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(543, 6)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(64, 36)
        Me.MaterialFlatButton1.TabIndex = 37
        Me.MaterialFlatButton1.Text = "search"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'searchemail
        '
        Me.searchemail.AutoSize = True
        Me.searchemail.Depth = 0
        Me.searchemail.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.searchemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchemail.Location = New System.Drawing.Point(289, 323)
        Me.searchemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchemail.Name = "searchemail"
        Me.searchemail.Size = New System.Drawing.Size(0, 19)
        Me.searchemail.TabIndex = 36
        '
        'searchcontact
        '
        Me.searchcontact.AutoSize = True
        Me.searchcontact.Depth = 0
        Me.searchcontact.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.searchcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchcontact.Location = New System.Drawing.Point(289, 300)
        Me.searchcontact.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchcontact.Name = "searchcontact"
        Me.searchcontact.Size = New System.Drawing.Size(0, 19)
        Me.searchcontact.TabIndex = 35
        '
        'searchmembership
        '
        Me.searchmembership.AutoSize = True
        Me.searchmembership.Depth = 0
        Me.searchmembership.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.searchmembership.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchmembership.Location = New System.Drawing.Point(289, 277)
        Me.searchmembership.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchmembership.Name = "searchmembership"
        Me.searchmembership.Size = New System.Drawing.Size(0, 19)
        Me.searchmembership.TabIndex = 34
        '
        'searchid
        '
        Me.searchid.AutoSize = True
        Me.searchid.Depth = 0
        Me.searchid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.searchid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchid.Location = New System.Drawing.Point(289, 233)
        Me.searchid.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchid.Name = "searchid"
        Me.searchid.Size = New System.Drawing.Size(0, 19)
        Me.searchid.TabIndex = 33
        '
        'searchname
        '
        Me.searchname.AutoSize = True
        Me.searchname.Depth = 0
        Me.searchname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.searchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchname.Location = New System.Drawing.Point(289, 255)
        Me.searchname.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchname.Name = "searchname"
        Me.searchname.Size = New System.Drawing.Size(0, 19)
        Me.searchname.TabIndex = 32
        '
        'not2
        '
        Me.not2.AutoSize = True
        Me.not2.Depth = 0
        Me.not2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.not2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.not2.Location = New System.Drawing.Point(260, 233)
        Me.not2.MouseState = MaterialSkin.MouseState.HOVER
        Me.not2.Name = "not2"
        Me.not2.Size = New System.Drawing.Size(13, 19)
        Me.not2.TabIndex = 31
        Me.not2.Tag = ""
        Me.not2.Text = ":"
        Me.not2.Visible = False
        '
        'not3
        '
        Me.not3.AutoSize = True
        Me.not3.Depth = 0
        Me.not3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.not3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.not3.Location = New System.Drawing.Point(260, 277)
        Me.not3.MouseState = MaterialSkin.MouseState.HOVER
        Me.not3.Name = "not3"
        Me.not3.Size = New System.Drawing.Size(13, 19)
        Me.not3.TabIndex = 30
        Me.not3.Tag = ""
        Me.not3.Text = ":"
        Me.not3.Visible = False
        '
        'not4
        '
        Me.not4.AutoSize = True
        Me.not4.Depth = 0
        Me.not4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.not4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.not4.Location = New System.Drawing.Point(260, 300)
        Me.not4.MouseState = MaterialSkin.MouseState.HOVER
        Me.not4.Name = "not4"
        Me.not4.Size = New System.Drawing.Size(13, 19)
        Me.not4.TabIndex = 29
        Me.not4.Tag = ""
        Me.not4.Text = ":"
        Me.not4.Visible = False
        '
        'not5
        '
        Me.not5.AutoSize = True
        Me.not5.Depth = 0
        Me.not5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.not5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.not5.Location = New System.Drawing.Point(260, 323)
        Me.not5.MouseState = MaterialSkin.MouseState.HOVER
        Me.not5.Name = "not5"
        Me.not5.Size = New System.Drawing.Size(13, 19)
        Me.not5.TabIndex = 28
        Me.not5.Tag = ""
        Me.not5.Text = ":"
        Me.not5.Visible = False
        '
        'not1
        '
        Me.not1.AutoSize = True
        Me.not1.Depth = 0
        Me.not1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.not1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.not1.Location = New System.Drawing.Point(260, 255)
        Me.not1.MouseState = MaterialSkin.MouseState.HOVER
        Me.not1.Name = "not1"
        Me.not1.Size = New System.Drawing.Size(13, 19)
        Me.not1.TabIndex = 27
        Me.not1.Tag = ""
        Me.not1.Text = ":"
        Me.not1.Visible = False
        '
        'lblsearchemail
        '
        Me.lblsearchemail.AutoSize = True
        Me.lblsearchemail.Depth = 0
        Me.lblsearchemail.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblsearchemail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsearchemail.Location = New System.Drawing.Point(161, 323)
        Me.lblsearchemail.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblsearchemail.Name = "lblsearchemail"
        Me.lblsearchemail.Size = New System.Drawing.Size(47, 19)
        Me.lblsearchemail.TabIndex = 26
        Me.lblsearchemail.Tag = ""
        Me.lblsearchemail.Text = "Email"
        Me.lblsearchemail.Visible = False
        '
        'lblsearchcontact
        '
        Me.lblsearchcontact.AutoSize = True
        Me.lblsearchcontact.Depth = 0
        Me.lblsearchcontact.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblsearchcontact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsearchcontact.Location = New System.Drawing.Point(160, 300)
        Me.lblsearchcontact.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblsearchcontact.Name = "lblsearchcontact"
        Me.lblsearchcontact.Size = New System.Drawing.Size(62, 19)
        Me.lblsearchcontact.TabIndex = 25
        Me.lblsearchcontact.Tag = ""
        Me.lblsearchcontact.Text = "Contact"
        Me.lblsearchcontact.Visible = False
        '
        'lblsearchmembership
        '
        Me.lblsearchmembership.AutoSize = True
        Me.lblsearchmembership.Depth = 0
        Me.lblsearchmembership.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblsearchmembership.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsearchmembership.Location = New System.Drawing.Point(161, 277)
        Me.lblsearchmembership.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblsearchmembership.Name = "lblsearchmembership"
        Me.lblsearchmembership.Size = New System.Drawing.Size(92, 19)
        Me.lblsearchmembership.TabIndex = 24
        Me.lblsearchmembership.Tag = ""
        Me.lblsearchmembership.Text = "Membership"
        Me.lblsearchmembership.Visible = False
        '
        'lblsearchid
        '
        Me.lblsearchid.AutoSize = True
        Me.lblsearchid.Depth = 0
        Me.lblsearchid.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblsearchid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsearchid.Location = New System.Drawing.Point(160, 233)
        Me.lblsearchid.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblsearchid.Name = "lblsearchid"
        Me.lblsearchid.Size = New System.Drawing.Size(93, 19)
        Me.lblsearchid.TabIndex = 23
        Me.lblsearchid.Tag = ""
        Me.lblsearchid.Text = "Customer ID"
        Me.lblsearchid.Visible = False
        '
        'lblsearchname
        '
        Me.lblsearchname.AutoSize = True
        Me.lblsearchname.Depth = 0
        Me.lblsearchname.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblsearchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblsearchname.Location = New System.Drawing.Point(161, 255)
        Me.lblsearchname.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblsearchname.Name = "lblsearchname"
        Me.lblsearchname.Size = New System.Drawing.Size(49, 19)
        Me.lblsearchname.TabIndex = 22
        Me.lblsearchname.Tag = ""
        Me.lblsearchname.Text = "Name"
        Me.lblsearchname.Visible = False
        '
        'searchpic
        '
        Me.searchpic.Location = New System.Drawing.Point(238, 73)
        Me.searchpic.Name = "searchpic"
        Me.searchpic.Size = New System.Drawing.Size(100, 133)
        Me.searchpic.TabIndex = 21
        Me.searchpic.TabStop = False
        '
        'searchCustomer
        '
        Me.searchCustomer.Depth = 0
        Me.searchCustomer.Hint = "Enter Customer ID"
        Me.searchCustomer.Location = New System.Drawing.Point(33, 9)
        Me.searchCustomer.MaxLength = 32767
        Me.searchCustomer.MouseState = MaterialSkin.MouseState.HOVER
        Me.searchCustomer.Name = "searchCustomer"
        Me.searchCustomer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.searchCustomer.SelectedText = ""
        Me.searchCustomer.SelectionLength = 0
        Me.searchCustomer.SelectionStart = 0
        Me.searchCustomer.Size = New System.Drawing.Size(481, 23)
        Me.searchCustomer.TabIndex = 0
        Me.searchCustomer.TabStop = False
        Me.searchCustomer.Tag = ""
        Me.searchCustomer.UseSystemPasswordChar = False
        '
        'membership
        '
        Me.membership.Location = New System.Drawing.Point(4, 22)
        Me.membership.Name = "membership"
        Me.membership.Size = New System.Drawing.Size(631, 418)
        Me.membership.TabIndex = 4
        Me.membership.Text = "MEMBERSHIP"
        Me.membership.UseVisualStyleBackColor = True
        '
        'payment
        '
        Me.payment.Location = New System.Drawing.Point(4, 22)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(631, 418)
        Me.payment.TabIndex = 5
        Me.payment.Text = "PAYMENT"
        Me.payment.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.BaseTabControl = Me.searchpicture
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-13, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(674, 33)
        Me.MaterialTabSelector1.TabIndex = 2
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'formMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 535)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.searchpicture)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formMenu"
        Me.Sizable = False
        Me.Text = "Menu"
        Me.searchpicture.ResumeLayout(False)
        Me.contextmenustrip.ResumeLayout(False)
        Me.add.ResumeLayout(False)
        Me.add.PerformLayout()
        CType(Me.addpicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.remove.ResumeLayout(False)
        Me.update.ResumeLayout(False)
        Me.update.PerformLayout()
        CType(Me.updatepicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.search.ResumeLayout(False)
        Me.search.PerformLayout()
        CType(Me.searchpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents searchpicture As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents add As System.Windows.Forms.TabPage
    Friend WithEvents remove As System.Windows.Forms.TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents update As System.Windows.Forms.TabPage
    Friend WithEvents search As System.Windows.Forms.TabPage
    Friend WithEvents membership As System.Windows.Forms.TabPage
    Friend WithEvents payment As System.Windows.Forms.TabPage
    Friend WithEvents lblfirstname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblmemberid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbl As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblemail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblcontactno As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblmembership As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents radioweekday As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radionondeluxe As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents radioDeluxe As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents addemail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents addcontactnumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents addfullname As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents addmemberid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Reset As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnAdd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents contextmenustrip As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents HahaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents updateemail As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents updatenumber As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents updatename As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents updatememberid As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel13 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel16 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel17 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialRadioButton2 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRadioButton1 As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents MaterialRaisedButton1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents searchCustomer As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents searchemail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents searchcontact As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents searchmembership As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents searchid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents searchname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents not2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents not3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents not4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents not5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents not1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblsearchemail As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblsearchcontact As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblsearchmembership As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblsearchid As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblsearchname As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents searchpic As System.Windows.Forms.PictureBox
    Friend WithEvents addpicture As System.Windows.Forms.PictureBox
    Friend WithEvents updatepicture As System.Windows.Forms.PictureBox
    Friend WithEvents removecustomer As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialRaisedButton2 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialFlatButton2 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents updatesearchmember As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
