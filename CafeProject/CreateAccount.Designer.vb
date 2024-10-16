<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateAccount
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateAccount))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFirstname = New Guna.UI.WinForms.GunaTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLastname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnRegister = New Guna.UI.WinForms.GunaGradientButton()
        Me.chkFreetime = New Guna.UI.WinForms.GunaCheckBox()
        Me.chbShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnEditProfile = New Guna.UI.WinForms.GunaCircleButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pbAccountImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAccountImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(762, 35)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClose.CheckedForeColor = System.Drawing.Color.White
        Me.btnClose.CheckedImage = CType(resources.GetObject("btnClose.CheckedImage"), System.Drawing.Image)
        Me.btnClose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(714, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = CType(resources.GetObject("btnClose.OnHoverImage"), System.Drawing.Image)
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 35)
        Me.btnClose.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(25, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.Color.Transparent
        Me.txtFirstname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtFirstname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtFirstname.BorderSize = 1
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtFirstname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtFirstname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtFirstname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtFirstname.Location = New System.Drawing.Point(28, 229)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstname.Radius = 3
        Me.txtFirstname.Size = New System.Drawing.Size(159, 30)
        Me.txtFirstname.TabIndex = 3
        Me.txtFirstname.TextOffsetX = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(204, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Last Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(25, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Create Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(25, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Username"
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.Color.Transparent
        Me.txtLastname.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtLastname.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtLastname.BorderSize = 1
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtLastname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtLastname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLastname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtLastname.Location = New System.Drawing.Point(207, 229)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastname.Radius = 3
        Me.txtLastname.Size = New System.Drawing.Size(159, 30)
        Me.txtLastname.TabIndex = 9
        Me.txtLastname.TextOffsetX = 2
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtUsername.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtUsername.BorderSize = 1
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.Location = New System.Drawing.Point(28, 286)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Radius = 3
        Me.txtUsername.Size = New System.Drawing.Size(196, 30)
        Me.txtUsername.TabIndex = 10
        Me.txtUsername.TextOffsetX = 2
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.txtPassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(30, 344)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Radius = 3
        Me.txtPassword.Size = New System.Drawing.Size(194, 30)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.TextOffsetX = 2
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Password"
        '
        'btnRegister
        '
        Me.btnRegister.Animated = True
        Me.btnRegister.AnimationHoverSpeed = 0.07!
        Me.btnRegister.AnimationSpeed = 0.03!
        Me.btnRegister.BackColor = System.Drawing.Color.Transparent
        Me.btnRegister.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnRegister.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnRegister.BorderColor = System.Drawing.Color.Black
        Me.btnRegister.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRegister.FocusedColor = System.Drawing.Color.Empty
        Me.btnRegister.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.White
        Me.btnRegister.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.btnRegister.Image = Nothing
        Me.btnRegister.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRegister.Location = New System.Drawing.Point(29, 462)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.btnRegister.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.btnRegister.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnRegister.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRegister.OnHoverImage = Nothing
        Me.btnRegister.OnPressedColor = System.Drawing.Color.Black
        Me.btnRegister.Radius = 5
        Me.btnRegister.Size = New System.Drawing.Size(157, 44)
        Me.btnRegister.TabIndex = 13
        Me.btnRegister.Text = "Register"
        Me.btnRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnRegister.TextOffsetX = 5
        Me.btnRegister.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'chkFreetime
        '
        Me.chkFreetime.BaseColor = System.Drawing.Color.White
        Me.chkFreetime.Checked = True
        Me.chkFreetime.CheckedOffColor = System.Drawing.Color.Gray
        Me.chkFreetime.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.chkFreetime.FillColor = System.Drawing.Color.White
        Me.chkFreetime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkFreetime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.chkFreetime.Location = New System.Drawing.Point(30, 424)
        Me.chkFreetime.Name = "chkFreetime"
        Me.chkFreetime.Size = New System.Drawing.Size(213, 20)
        Me.chkFreetime.TabIndex = 14
        Me.chkFreetime.Text = "Account Free Time Included"
        Me.chkFreetime.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'chbShowPassword
        '
        Me.chbShowPassword.BaseColor = System.Drawing.Color.White
        Me.chbShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chbShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.chbShowPassword.FillColor = System.Drawing.Color.White
        Me.chbShowPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbShowPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.chbShowPassword.Location = New System.Drawing.Point(28, 380)
        Me.chbShowPassword.Name = "chbShowPassword"
        Me.chbShowPassword.Size = New System.Drawing.Size(129, 20)
        Me.chbShowPassword.TabIndex = 15
        Me.chbShowPassword.Text = "Show Password"
        Me.chbShowPassword.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnEditProfile
        '
        Me.btnEditProfile.Animated = True
        Me.btnEditProfile.AnimationHoverSpeed = 0.07!
        Me.btnEditProfile.AnimationSpeed = 0.03!
        Me.btnEditProfile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditProfile.BorderColor = System.Drawing.Color.Black
        Me.btnEditProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditProfile.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnEditProfile.ForeColor = System.Drawing.Color.White
        Me.btnEditProfile.Image = Global.CafeProject.My.Resources.Resources.registration_24px
        Me.btnEditProfile.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnEditProfile.Location = New System.Drawing.Point(225, 164)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEditProfile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditProfile.OnHoverImage = Nothing
        Me.btnEditProfile.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditProfile.Size = New System.Drawing.Size(20, 20)
        Me.btnEditProfile.TabIndex = 30
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CafeProject.My.Resources.Resources.Register_Image
        Me.PictureBox1.Location = New System.Drawing.Point(385, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(344, 398)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'pbAccountImage
        '
        Me.pbAccountImage.BaseColor = System.Drawing.Color.White
        Me.pbAccountImage.Image = Global.CafeProject.My.Resources.Resources.user1
        Me.pbAccountImage.Location = New System.Drawing.Point(136, 84)
        Me.pbAccountImage.Name = "pbAccountImage"
        Me.pbAccountImage.Size = New System.Drawing.Size(100, 100)
        Me.pbAccountImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbAccountImage.TabIndex = 1
        Me.pbAccountImage.TabStop = False
        Me.pbAccountImage.UseTransfarantBackground = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CreateAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(762, 533)
        Me.Controls.Add(Me.btnEditProfile)
        Me.Controls.Add(Me.chbShowPassword)
        Me.Controls.Add(Me.chkFreetime)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbAccountImage)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CreateAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CreateAccount"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAccountImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbAccountImage As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnRegister As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtLastname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents chkFreetime As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chbShowPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnEditProfile As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
