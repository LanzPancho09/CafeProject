<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpHome = New System.Windows.Forms.TabPage()
        Me.pnlMonitorMode = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnGo = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnMonitorMode = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCafeMode = New Guna.UI.WinForms.GunaCircleButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnLogin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.chbxShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.linklCreateAccount = New System.Windows.Forms.LinkLabel()
        Me.tpCreate = New System.Windows.Forms.TabPage()
        Me.btnBack = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.chbxCreateShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnEditProfile = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCreateAccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCreatePassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCreateUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpHome.SuspendLayout()
        Me.pnlMonitorMode.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpCreate.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 494)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpHome)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Location = New System.Drawing.Point(-5, -23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(353, 526)
        Me.TabControl1.TabIndex = 11
        '
        'tpHome
        '
        Me.tpHome.Controls.Add(Me.pnlMonitorMode)
        Me.tpHome.Controls.Add(Me.btnMonitorMode)
        Me.tpHome.Controls.Add(Me.btnCafeMode)
        Me.tpHome.Controls.Add(Me.Label9)
        Me.tpHome.Controls.Add(Me.btnLogin)
        Me.tpHome.Controls.Add(Me.Label10)
        Me.tpHome.Controls.Add(Me.Label11)
        Me.tpHome.Controls.Add(Me.txtPassword)
        Me.tpHome.Controls.Add(Me.txtUsername)
        Me.tpHome.Controls.Add(Me.PictureBox2)
        Me.tpHome.Controls.Add(Me.chbxShowPassword)
        Me.tpHome.Controls.Add(Me.linklCreateAccount)
        Me.tpHome.Location = New System.Drawing.Point(4, 22)
        Me.tpHome.Name = "tpHome"
        Me.tpHome.Padding = New System.Windows.Forms.Padding(3)
        Me.tpHome.Size = New System.Drawing.Size(345, 500)
        Me.tpHome.TabIndex = 0
        Me.tpHome.Text = "Home"
        Me.tpHome.UseVisualStyleBackColor = True
        '
        'pnlMonitorMode
        '
        Me.pnlMonitorMode.Controls.Add(Me.Label7)
        Me.pnlMonitorMode.Controls.Add(Me.btnGo)
        Me.pnlMonitorMode.Controls.Add(Me.Label8)
        Me.pnlMonitorMode.Location = New System.Drawing.Point(0, 160)
        Me.pnlMonitorMode.Name = "pnlMonitorMode"
        Me.pnlMonitorMode.Size = New System.Drawing.Size(340, 240)
        Me.pnlMonitorMode.TabIndex = 20
        Me.pnlMonitorMode.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(37, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Monitor Mode"
        '
        'btnGo
        '
        Me.btnGo.Animated = True
        Me.btnGo.AnimationHoverSpeed = 0.07!
        Me.btnGo.AnimationSpeed = 0.03!
        Me.btnGo.BackColor = System.Drawing.Color.Transparent
        Me.btnGo.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnGo.BorderColor = System.Drawing.Color.Black
        Me.btnGo.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnGo.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnGo.CheckedForeColor = System.Drawing.Color.White
        Me.btnGo.CheckedImage = Nothing
        Me.btnGo.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnGo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGo.FocusedColor = System.Drawing.Color.Empty
        Me.btnGo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.White
        Me.btnGo.Image = Nothing
        Me.btnGo.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGo.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGo.Location = New System.Drawing.Point(40, 165)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnGo.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGo.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGo.OnHoverImage = Nothing
        Me.btnGo.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnGo.OnPressedColor = System.Drawing.Color.Black
        Me.btnGo.Radius = 2
        Me.btnGo.Size = New System.Drawing.Size(260, 34)
        Me.btnGo.TabIndex = 11
        Me.btnGo.Text = "Go"
        Me.btnGo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnGo.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(37, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(263, 96)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Let you manage clients only, Time transaction" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "will not apply."
        '
        'btnMonitorMode
        '
        Me.btnMonitorMode.Animated = True
        Me.btnMonitorMode.AnimationHoverSpeed = 0.07!
        Me.btnMonitorMode.AnimationSpeed = 0.03!
        Me.btnMonitorMode.BaseColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.btnMonitorMode.BorderColor = System.Drawing.Color.Black
        Me.btnMonitorMode.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMonitorMode.FocusedColor = System.Drawing.Color.Empty
        Me.btnMonitorMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMonitorMode.ForeColor = System.Drawing.Color.White
        Me.btnMonitorMode.Image = Nothing
        Me.btnMonitorMode.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnMonitorMode.Location = New System.Drawing.Point(170, 406)
        Me.btnMonitorMode.Name = "btnMonitorMode"
        Me.btnMonitorMode.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnMonitorMode.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMonitorMode.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMonitorMode.OnHoverImage = Nothing
        Me.btnMonitorMode.OnPressedColor = System.Drawing.Color.Black
        Me.btnMonitorMode.Size = New System.Drawing.Size(10, 10)
        Me.btnMonitorMode.TabIndex = 19
        '
        'btnCafeMode
        '
        Me.btnCafeMode.Animated = True
        Me.btnCafeMode.AnimationHoverSpeed = 0.07!
        Me.btnCafeMode.AnimationSpeed = 0.03!
        Me.btnCafeMode.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCafeMode.BorderColor = System.Drawing.Color.Black
        Me.btnCafeMode.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCafeMode.FocusedColor = System.Drawing.Color.Empty
        Me.btnCafeMode.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnCafeMode.ForeColor = System.Drawing.Color.White
        Me.btnCafeMode.Image = Nothing
        Me.btnCafeMode.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnCafeMode.Location = New System.Drawing.Point(156, 406)
        Me.btnCafeMode.Name = "btnCafeMode"
        Me.btnCafeMode.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCafeMode.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCafeMode.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCafeMode.OnHoverImage = Nothing
        Me.btnCafeMode.OnPressedColor = System.Drawing.Color.Black
        Me.btnCafeMode.Size = New System.Drawing.Size(10, 10)
        Me.btnCafeMode.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(37, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Cafe Mode"
        '
        'btnLogin
        '
        Me.btnLogin.Animated = True
        Me.btnLogin.AnimationHoverSpeed = 0.07!
        Me.btnLogin.AnimationSpeed = 0.03!
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnLogin.BorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnLogin.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnLogin.CheckedForeColor = System.Drawing.Color.White
        Me.btnLogin.CheckedImage = Nothing
        Me.btnLogin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnLogin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnLogin.FocusedColor = System.Drawing.Color.Empty
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = Nothing
        Me.btnLogin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnLogin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(40, 329)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnLogin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnLogin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnLogin.OnHoverImage = Nothing
        Me.btnLogin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnLogin.OnPressedColor = System.Drawing.Color.Black
        Me.btnLogin.Radius = 2
        Me.btnLogin.Size = New System.Drawing.Size(260, 34)
        Me.btnLogin.TabIndex = 16
        Me.btnLogin.Text = "Login"
        Me.btnLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnLogin.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Silver
        Me.Label10.Location = New System.Drawing.Point(37, 253)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(37, 202)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 15)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtPassword.BaseColor = System.Drawing.Color.White
        Me.txtPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtPassword.BorderSize = 1
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPassword.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(40, 271)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Radius = 2
        Me.txtPassword.Size = New System.Drawing.Size(260, 30)
        Me.txtPassword.TabIndex = 13
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtUsername.BaseColor = System.Drawing.Color.White
        Me.txtUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtUsername.BorderSize = 1
        Me.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtUsername.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtUsername.Location = New System.Drawing.Point(40, 220)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Radius = 2
        Me.txtUsername.Size = New System.Drawing.Size(260, 30)
        Me.txtUsername.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeProject.My.Resources.Resources.Redfox
        Me.PictureBox2.Location = New System.Drawing.Point(25, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(307, 168)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'chbxShowPassword
        '
        Me.chbxShowPassword.BaseColor = System.Drawing.Color.White
        Me.chbxShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chbxShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.chbxShowPassword.FillColor = System.Drawing.Color.White
        Me.chbxShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxShowPassword.Location = New System.Drawing.Point(40, 303)
        Me.chbxShowPassword.Name = "chbxShowPassword"
        Me.chbxShowPassword.Size = New System.Drawing.Size(115, 20)
        Me.chbxShowPassword.TabIndex = 21
        Me.chbxShowPassword.Text = "Show Password"
        '
        'linklCreateAccount
        '
        Me.linklCreateAccount.AutoSize = True
        Me.linklCreateAccount.LinkColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.linklCreateAccount.Location = New System.Drawing.Point(37, 366)
        Me.linklCreateAccount.Name = "linklCreateAccount"
        Me.linklCreateAccount.Size = New System.Drawing.Size(185, 13)
        Me.linklCreateAccount.TabIndex = 22
        Me.linklCreateAccount.TabStop = True
        Me.linklCreateAccount.Text = "Don't have an account? Sign up here"
        '
        'tpCreate
        '
        Me.tpCreate.Controls.Add(Me.btnBack)
        Me.tpCreate.Controls.Add(Me.chbxCreateShowPassword)
        Me.tpCreate.Controls.Add(Me.btnEditProfile)
        Me.tpCreate.Controls.Add(Me.btnCreateAccount)
        Me.tpCreate.Controls.Add(Me.Label2)
        Me.tpCreate.Controls.Add(Me.txtCreatePassword)
        Me.tpCreate.Controls.Add(Me.Label3)
        Me.tpCreate.Controls.Add(Me.txtCreateUsername)
        Me.tpCreate.Controls.Add(Me.Label1)
        Me.tpCreate.Controls.Add(Me.pbProfile)
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreate.Size = New System.Drawing.Size(345, 500)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "Create"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.AnimationHoverSpeed = 0.07!
        Me.btnBack.AnimationSpeed = 0.03!
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.Transparent
        Me.btnBack.BorderColor = System.Drawing.Color.Black
        Me.btnBack.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnBack.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnBack.CheckedForeColor = System.Drawing.Color.White
        Me.btnBack.CheckedImage = Nothing
        Me.btnBack.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack.FocusedColor = System.Drawing.Color.Empty
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = Global.CafeProject.My.Resources.Resources.back_grey
        Me.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBack.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBack.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(13, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnBack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBack.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBack.OnHoverImage = Global.CafeProject.My.Resources.Resources.back_white
        Me.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBack.OnPressedColor = System.Drawing.Color.Black
        Me.btnBack.Radius = 10
        Me.btnBack.Size = New System.Drawing.Size(46, 25)
        Me.btnBack.TabIndex = 31
        Me.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chbxCreateShowPassword
        '
        Me.chbxCreateShowPassword.BaseColor = System.Drawing.Color.White
        Me.chbxCreateShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chbxCreateShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.chbxCreateShowPassword.FillColor = System.Drawing.Color.White
        Me.chbxCreateShowPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxCreateShowPassword.Location = New System.Drawing.Point(44, 327)
        Me.chbxCreateShowPassword.Name = "chbxCreateShowPassword"
        Me.chbxCreateShowPassword.Size = New System.Drawing.Size(115, 20)
        Me.chbxCreateShowPassword.TabIndex = 30
        Me.chbxCreateShowPassword.Text = "Show Password"
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
        Me.btnEditProfile.Location = New System.Drawing.Point(205, 175)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEditProfile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditProfile.OnHoverImage = Nothing
        Me.btnEditProfile.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditProfile.Size = New System.Drawing.Size(20, 20)
        Me.btnEditProfile.TabIndex = 29
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Animated = True
        Me.btnCreateAccount.AnimationHoverSpeed = 0.07!
        Me.btnCreateAccount.AnimationSpeed = 0.03!
        Me.btnCreateAccount.BackColor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCreateAccount.BorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCreateAccount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.CheckedForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.CheckedImage = Nothing
        Me.btnCreateAccount.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCreateAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreateAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreateAccount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.Image = Nothing
        Me.btnCreateAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCreateAccount.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCreateAccount.Location = New System.Drawing.Point(44, 396)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(158, Byte), Integer))
        Me.btnCreateAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreateAccount.OnHoverImage = Nothing
        Me.btnCreateAccount.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCreateAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreateAccount.Radius = 5
        Me.btnCreateAccount.Size = New System.Drawing.Size(260, 42)
        Me.btnCreateAccount.TabIndex = 28
        Me.btnCreateAccount.Text = "Create"
        Me.btnCreateAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(41, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Password"
        '
        'txtCreatePassword
        '
        Me.txtCreatePassword.BackColor = System.Drawing.Color.Transparent
        Me.txtCreatePassword.BaseColor = System.Drawing.Color.White
        Me.txtCreatePassword.BorderColor = System.Drawing.Color.Silver
        Me.txtCreatePassword.BorderSize = 1
        Me.txtCreatePassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreatePassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCreatePassword.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtCreatePassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCreatePassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCreatePassword.Location = New System.Drawing.Point(44, 291)
        Me.txtCreatePassword.MaxLength = 30
        Me.txtCreatePassword.Name = "txtCreatePassword"
        Me.txtCreatePassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCreatePassword.Radius = 2
        Me.txtCreatePassword.Size = New System.Drawing.Size(260, 30)
        Me.txtCreatePassword.TabIndex = 26
        Me.txtCreatePassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(41, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Username"
        '
        'txtCreateUsername
        '
        Me.txtCreateUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtCreateUsername.BaseColor = System.Drawing.Color.White
        Me.txtCreateUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtCreateUsername.BorderSize = 1
        Me.txtCreateUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCreateUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtCreateUsername.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtCreateUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCreateUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtCreateUsername.Location = New System.Drawing.Point(44, 235)
        Me.txtCreateUsername.MaxLength = 30
        Me.txtCreateUsername.Name = "txtCreateUsername"
        Me.txtCreateUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCreateUsername.Radius = 2
        Me.txtCreateUsername.Size = New System.Drawing.Size(260, 30)
        Me.txtCreateUsername.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(88, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 30)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Create Account"
        '
        'pbProfile
        '
        Me.pbProfile.BaseColor = System.Drawing.Color.White
        Me.pbProfile.Image = CType(resources.GetObject("pbProfile.Image"), System.Drawing.Image)
        Me.pbProfile.Location = New System.Drawing.Point(116, 95)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(100, 100)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 22
        Me.pbProfile.TabStop = False
        Me.pbProfile.UseTransfarantBackground = False
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(340, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(460, 41)
        Me.GunaPanel1.TabIndex = 5
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
        Me.btnClose.Image = Global.CafeProject.My.Resources.Resources.close
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(412, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 41)
        Me.btnClose.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Gray
        Me.Label5.Location = New System.Drawing.Point(407, 348)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(355, 96)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Red fox cafe provides solution for client monitoring," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "With professional design f" &
    "or best user experience. Login now" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to access platform functionality and start m" &
    "onitoring." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.CafeProject.My.Resources.Resources.Fox_art
        Me.PictureBox3.Location = New System.Drawing.Point(278, -55)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(581, 537)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(20, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 494)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpHome.ResumeLayout(False)
        Me.tpHome.PerformLayout()
        Me.pnlMonitorMode.ResumeLayout(False)
        Me.pnlMonitorMode.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label5 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpHome As TabPage
    Friend WithEvents pnlMonitorMode As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents btnGo As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btnMonitorMode As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCafeMode As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents Label9 As Label
    Friend WithEvents btnLogin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents chbxShowPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents tpCreate As TabPage
    Friend WithEvents linklCreateAccount As LinkLabel
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents chbxCreateShowPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents btnEditProfile As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCreateAccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCreatePassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCreateUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
