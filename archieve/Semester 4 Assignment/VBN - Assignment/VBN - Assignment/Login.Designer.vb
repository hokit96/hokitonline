<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formLogin))
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtUser = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtPass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnReset = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.Depth = 0
        Me.btnLogin.Location = New System.Drawing.Point(69, 331)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.Depth = 0
        Me.txtUser.Hint = "Username"
        Me.txtUser.Location = New System.Drawing.Point(69, 254)
        Me.txtUser.MaxLength = 32767
        Me.txtUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtUser.Name = "txtUser"
        Me.txtUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUser.SelectedText = ""
        Me.txtUser.SelectionLength = 0
        Me.txtUser.SelectionStart = 0
        Me.txtUser.Size = New System.Drawing.Size(172, 23)
        Me.txtUser.TabIndex = 1
        Me.txtUser.TabStop = False
        Me.txtUser.UseSystemPasswordChar = False
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.Depth = 0
        Me.txtPass.Hint = "Password"
        Me.txtPass.Location = New System.Drawing.Point(69, 283)
        Me.txtPass.MaxLength = 32767
        Me.txtPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPass.Name = "txtPass"
        Me.txtPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPass.SelectedText = ""
        Me.txtPass.SelectionLength = 0
        Me.txtPass.SelectionStart = 0
        Me.txtPass.Size = New System.Drawing.Size(172, 23)
        Me.txtPass.TabIndex = 2
        Me.txtPass.TabStop = False
        Me.txtPass.UseSystemPasswordChar = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.White
        Me.btnReset.Depth = 0
        Me.btnReset.Location = New System.Drawing.Point(166, 331)
        Me.btnReset.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Primary = True
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.Red
        Me.lblNotification.Location = New System.Drawing.Point(72, 312)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(0, 13)
        Me.lblNotification.TabIndex = 4
        '
        'formLogin
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(322, 405)
        Me.Controls.Add(Me.lblNotification)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.btnLogin)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "formLogin"
        Me.Sizable = False
        Me.Text = "User Login - Imperial Golf Club"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents txtUser As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtPass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnReset As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblNotification As System.Windows.Forms.Label

End Class
