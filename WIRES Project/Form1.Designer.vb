<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.MaterialDivider1 = New MaterialSkin.Controls.MaterialDivider()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pic_user = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogin = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtPassword = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txt_UserName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialDivider1
        '
        Me.MaterialDivider1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialDivider1.Depth = 0
        Me.MaterialDivider1.Location = New System.Drawing.Point(-1, 226)
        Me.MaterialDivider1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialDivider1.Name = "MaterialDivider1"
        Me.MaterialDivider1.Size = New System.Drawing.Size(578, 296)
        Me.MaterialDivider1.TabIndex = 6
        Me.MaterialDivider1.Text = "MaterialDivider1"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-7, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(584, 175)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Login"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pic_user
        '
        Me.pic_user.BackColor = System.Drawing.Color.Transparent
        Me.pic_user.Image = CType(resources.GetObject("pic_user.Image"), System.Drawing.Image)
        Me.pic_user.Location = New System.Drawing.Point(116, 24)
        Me.pic_user.Name = "pic_user"
        Me.pic_user.Size = New System.Drawing.Size(59, 59)
        Me.pic_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_user.TabIndex = 1
        Me.pic_user.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txt_UserName)
        Me.Panel1.Controls.Add(Me.pic_user)
        Me.Panel1.Location = New System.Drawing.Point(131, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 356)
        Me.Panel1.TabIndex = 5
        '
        'btnLogin
        '
        Me.btnLogin.Depth = 0
        Me.btnLogin.Location = New System.Drawing.Point(139, 287)
        Me.btnLogin.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Primary = True
        Me.btnLogin.Size = New System.Drawing.Size(95, 35)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(56, 286)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = False
        Me.btnCancel.Size = New System.Drawing.Size(64, 36)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.Depth = 0
        Me.txtPassword.Hint = "Password"
        Me.txtPassword.Location = New System.Drawing.Point(63, 188)
        Me.txtPassword.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.SelectedText = ""
        Me.txtPassword.SelectionLength = 0
        Me.txtPassword.SelectionStart = 0
        Me.txtPassword.Size = New System.Drawing.Size(165, 23)
        Me.txtPassword.TabIndex = 3
        Me.txtPassword.UseSystemPasswordChar = False
        '
        'txt_UserName
        '
        Me.txt_UserName.Depth = 0
        Me.txt_UserName.Hint = "Username"
        Me.txt_UserName.Location = New System.Drawing.Point(63, 151)
        Me.txt_UserName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txt_UserName.Name = "txt_UserName"
        Me.txt_UserName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt_UserName.SelectedText = ""
        Me.txt_UserName.SelectionLength = 0
        Me.txt_UserName.SelectionStart = 0
        Me.txt_UserName.Size = New System.Drawing.Size(165, 23)
        Me.txt_UserName.TabIndex = 2
        Me.txt_UserName.UseSystemPasswordChar = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 511)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MaterialDivider1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LoginForm"
        CType(Me.pic_user, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialDivider1 As MaterialSkin.Controls.MaterialDivider
    Friend WithEvents Label1 As Label
    Friend WithEvents pic_user As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLogin As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtPassword As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txt_UserName As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
