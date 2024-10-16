<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManageAccount))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnMinimize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.flpAccounts = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlShadow = New Guna.UI.WinForms.GunaPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEnableAccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnDeleteAccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnEditAccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCreateAccount = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnAccounts = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpAccount = New System.Windows.Forms.TabPage()
        Me.tpCreate = New System.Windows.Forms.TabPage()
        Me.chbxShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnEditProfile = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnCreate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbAccountType = New Guna.UI.WinForms.GunaComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.pbProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.tpEdit = New System.Windows.Forms.TabPage()
        Me.chbxEditShowPassword = New Guna.UI.WinForms.GunaCheckBox()
        Me.btnChangeProfile = New Guna.UI.WinForms.GunaCircleButton()
        Me.btnUpdate = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEditPassword = New Guna.UI.WinForms.GunaTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtEditUsername = New Guna.UI.WinForms.GunaTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.pbEditProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpAccount.SuspendLayout()
        Me.tpCreate.SuspendLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEdit.SuspendLayout()
        CType(Me.pbEditProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.White
        Me.GunaPanel1.Controls.Add(Me.PictureBox5)
        Me.GunaPanel1.Controls.Add(Me.Label6)
        Me.GunaPanel1.Controls.Add(Me.btnMinimize)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1006, 41)
        Me.GunaPanel1.TabIndex = 10
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.CafeProject.My.Resources.Resources.admin_settings_male_48px
        Me.PictureBox5.Location = New System.Drawing.Point(11, 10)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(20, 20)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 6
        Me.PictureBox5.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(37, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Manage Accounts"
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.BaseColor = System.Drawing.Color.Transparent
        Me.btnMinimize.BorderColor = System.Drawing.Color.Black
        Me.btnMinimize.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnMinimize.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnMinimize.CheckedForeColor = System.Drawing.Color.White
        Me.btnMinimize.CheckedImage = CType(resources.GetObject("btnMinimize.CheckedImage"), System.Drawing.Image)
        Me.btnMinimize.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnMinimize.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnMinimize.FocusedColor = System.Drawing.Color.Empty
        Me.btnMinimize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnMinimize.ForeColor = System.Drawing.Color.White
        Me.btnMinimize.Image = Global.CafeProject.My.Resources.Resources.Minimize_black
        Me.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMinimize.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnMinimize.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(910, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverImage = Global.CafeProject.My.Resources.Resources.minimize_white
        Me.btnMinimize.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMinimize.Size = New System.Drawing.Size(48, 41)
        Me.btnMinimize.TabIndex = 2
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
        Me.btnClose.Image = Global.CafeProject.My.Resources.Resources.Close_black
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(958, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Global.CafeProject.My.Resources.Resources.Close_48px
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 41)
        Me.btnClose.TabIndex = 1
        '
        'flpAccounts
        '
        Me.flpAccounts.AutoScroll = True
        Me.flpAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.flpAccounts.Location = New System.Drawing.Point(3, 38)
        Me.flpAccounts.Name = "flpAccounts"
        Me.flpAccounts.Size = New System.Drawing.Size(798, 367)
        Me.flpAccounts.TabIndex = 12
        '
        'pnlShadow
        '
        Me.pnlShadow.Location = New System.Drawing.Point(206, 41)
        Me.pnlShadow.Name = "pnlShadow"
        Me.pnlShadow.Size = New System.Drawing.Size(806, 5)
        Me.pnlShadow.TabIndex = 36
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(798, 35)
        Me.Panel1.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Silver
        Me.Label5.Location = New System.Drawing.Point(633, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Action"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Silver
        Me.Label4.Location = New System.Drawing.Point(441, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Silver
        Me.Label3.Location = New System.Drawing.Point(267, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(131, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Profile"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(21, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEnableAccount)
        Me.Panel2.Controls.Add(Me.btnDeleteAccount)
        Me.Panel2.Controls.Add(Me.btnEditAccount)
        Me.Panel2.Controls.Add(Me.btnCreateAccount)
        Me.Panel2.Controls.Add(Me.btnAccounts)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(206, 409)
        Me.Panel2.TabIndex = 38
        '
        'btnEnableAccount
        '
        Me.btnEnableAccount.AnimationHoverSpeed = 0.07!
        Me.btnEnableAccount.AnimationSpeed = 0.03!
        Me.btnEnableAccount.BaseColor = System.Drawing.Color.Transparent
        Me.btnEnableAccount.BorderColor = System.Drawing.Color.Black
        Me.btnEnableAccount.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnEnableAccount.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEnableAccount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEnableAccount.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEnableAccount.CheckedImage = Global.CafeProject.My.Resources.Resources.Admin_Disabled_Account
        Me.btnEnableAccount.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEnableAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEnableAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEnableAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnEnableAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnableAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEnableAccount.Image = Global.CafeProject.My.Resources.Resources.Admin_Disabled_Account
        Me.btnEnableAccount.ImageOffsetX = 6
        Me.btnEnableAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEnableAccount.LineColor = System.Drawing.Color.Transparent
        Me.btnEnableAccount.LineLeft = 4
        Me.btnEnableAccount.Location = New System.Drawing.Point(0, 168)
        Me.btnEnableAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEnableAccount.Name = "btnEnableAccount"
        Me.btnEnableAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEnableAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEnableAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEnableAccount.OnHoverImage = Nothing
        Me.btnEnableAccount.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnEnableAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnEnableAccount.Size = New System.Drawing.Size(206, 42)
        Me.btnEnableAccount.TabIndex = 6
        Me.btnEnableAccount.Text = "Enable Accounts"
        Me.btnEnableAccount.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnDeleteAccount
        '
        Me.btnDeleteAccount.AnimationHoverSpeed = 0.07!
        Me.btnDeleteAccount.AnimationSpeed = 0.03!
        Me.btnDeleteAccount.BaseColor = System.Drawing.Color.Transparent
        Me.btnDeleteAccount.BorderColor = System.Drawing.Color.Black
        Me.btnDeleteAccount.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnDeleteAccount.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnDeleteAccount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAccount.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeleteAccount.CheckedImage = Global.CafeProject.My.Resources.Resources.admin_Remove_Account
        Me.btnDeleteAccount.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnDeleteAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnDeleteAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeleteAccount.Image = Global.CafeProject.My.Resources.Resources.admin_Remove_Account
        Me.btnDeleteAccount.ImageOffsetX = 6
        Me.btnDeleteAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeleteAccount.LineColor = System.Drawing.Color.Transparent
        Me.btnDeleteAccount.LineLeft = 4
        Me.btnDeleteAccount.Location = New System.Drawing.Point(0, 126)
        Me.btnDeleteAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDeleteAccount.Name = "btnDeleteAccount"
        Me.btnDeleteAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnDeleteAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeleteAccount.OnHoverImage = Nothing
        Me.btnDeleteAccount.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnDeleteAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteAccount.Size = New System.Drawing.Size(206, 42)
        Me.btnDeleteAccount.TabIndex = 5
        Me.btnDeleteAccount.Text = "Delete Account"
        Me.btnDeleteAccount.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnEditAccount
        '
        Me.btnEditAccount.AnimationHoverSpeed = 0.07!
        Me.btnEditAccount.AnimationSpeed = 0.03!
        Me.btnEditAccount.BaseColor = System.Drawing.Color.Transparent
        Me.btnEditAccount.BorderColor = System.Drawing.Color.Black
        Me.btnEditAccount.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnEditAccount.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEditAccount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnEditAccount.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditAccount.CheckedImage = Global.CafeProject.My.Resources.Resources.admin_Update_Account
        Me.btnEditAccount.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnEditAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEditAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEditAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnEditAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditAccount.Image = Global.CafeProject.My.Resources.Resources.admin_Update_Account
        Me.btnEditAccount.ImageOffsetX = 6
        Me.btnEditAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnEditAccount.LineColor = System.Drawing.Color.Transparent
        Me.btnEditAccount.LineLeft = 4
        Me.btnEditAccount.Location = New System.Drawing.Point(0, 84)
        Me.btnEditAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnEditAccount.Name = "btnEditAccount"
        Me.btnEditAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnEditAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnEditAccount.OnHoverImage = Nothing
        Me.btnEditAccount.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnEditAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditAccount.Size = New System.Drawing.Size(206, 42)
        Me.btnEditAccount.TabIndex = 4
        Me.btnEditAccount.Text = "Edit Account"
        Me.btnEditAccount.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.AnimationHoverSpeed = 0.07!
        Me.btnCreateAccount.AnimationSpeed = 0.03!
        Me.btnCreateAccount.BaseColor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.BorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnCreateAccount.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCreateAccount.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreateAccount.CheckedImage = Global.CafeProject.My.Resources.Resources.add_user_male_48px
        Me.btnCreateAccount.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnCreateAccount.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnCreateAccount.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreateAccount.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateAccount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreateAccount.Image = Global.CafeProject.My.Resources.Resources.add_user_male_48px
        Me.btnCreateAccount.ImageOffsetX = 6
        Me.btnCreateAccount.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCreateAccount.LineColor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.LineLeft = 4
        Me.btnCreateAccount.Location = New System.Drawing.Point(0, 42)
        Me.btnCreateAccount.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnCreateAccount.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreateAccount.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCreateAccount.OnHoverImage = Nothing
        Me.btnCreateAccount.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnCreateAccount.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreateAccount.Size = New System.Drawing.Size(206, 42)
        Me.btnCreateAccount.TabIndex = 3
        Me.btnCreateAccount.Text = "Create Account"
        Me.btnCreateAccount.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnAccounts
        '
        Me.btnAccounts.AnimationHoverSpeed = 0.07!
        Me.btnAccounts.AnimationSpeed = 0.03!
        Me.btnAccounts.BaseColor = System.Drawing.Color.Transparent
        Me.btnAccounts.BorderColor = System.Drawing.Color.Black
        Me.btnAccounts.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnAccounts.Checked = True
        Me.btnAccounts.CheckedBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnAccounts.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAccounts.CheckedForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAccounts.CheckedImage = Global.CafeProject.My.Resources.Resources.people
        Me.btnAccounts.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnAccounts.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAccounts.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnAccounts.FocusedColor = System.Drawing.Color.Empty
        Me.btnAccounts.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccounts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAccounts.Image = Global.CafeProject.My.Resources.Resources.people
        Me.btnAccounts.ImageOffsetX = 6
        Me.btnAccounts.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAccounts.LineColor = System.Drawing.Color.Transparent
        Me.btnAccounts.LineLeft = 4
        Me.btnAccounts.Location = New System.Drawing.Point(0, 0)
        Me.btnAccounts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAccounts.Name = "btnAccounts"
        Me.btnAccounts.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(237, Byte), Integer))
        Me.btnAccounts.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAccounts.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAccounts.OnHoverImage = Nothing
        Me.btnAccounts.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnAccounts.OnPressedColor = System.Drawing.Color.Black
        Me.btnAccounts.Size = New System.Drawing.Size(206, 42)
        Me.btnAccounts.TabIndex = 2
        Me.btnAccounts.Text = "Accounts"
        Me.btnAccounts.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpAccount)
        Me.TabControl1.Controls.Add(Me.tpCreate)
        Me.TabControl1.Controls.Add(Me.tpEdit)
        Me.TabControl1.Location = New System.Drawing.Point(201, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(812, 431)
        Me.TabControl1.TabIndex = 39
        '
        'tpAccount
        '
        Me.tpAccount.Controls.Add(Me.flpAccounts)
        Me.tpAccount.Controls.Add(Me.Panel1)
        Me.tpAccount.Location = New System.Drawing.Point(4, 22)
        Me.tpAccount.Name = "tpAccount"
        Me.tpAccount.Padding = New System.Windows.Forms.Padding(3)
        Me.tpAccount.Size = New System.Drawing.Size(804, 405)
        Me.tpAccount.TabIndex = 0
        Me.tpAccount.Text = "Accounts"
        Me.tpAccount.UseVisualStyleBackColor = True
        '
        'tpCreate
        '
        Me.tpCreate.Controls.Add(Me.chbxShowPassword)
        Me.tpCreate.Controls.Add(Me.btnEditProfile)
        Me.tpCreate.Controls.Add(Me.btnCreate)
        Me.tpCreate.Controls.Add(Me.Label7)
        Me.tpCreate.Controls.Add(Me.cbAccountType)
        Me.tpCreate.Controls.Add(Me.Label8)
        Me.tpCreate.Controls.Add(Me.txtPassword)
        Me.tpCreate.Controls.Add(Me.Label9)
        Me.tpCreate.Controls.Add(Me.txtUsername)
        Me.tpCreate.Controls.Add(Me.Label10)
        Me.tpCreate.Controls.Add(Me.pbProfile)
        Me.tpCreate.Location = New System.Drawing.Point(4, 22)
        Me.tpCreate.Name = "tpCreate"
        Me.tpCreate.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCreate.Size = New System.Drawing.Size(804, 405)
        Me.tpCreate.TabIndex = 1
        Me.tpCreate.Text = "Create"
        Me.tpCreate.UseVisualStyleBackColor = True
        '
        'chbxShowPassword
        '
        Me.chbxShowPassword.BaseColor = System.Drawing.Color.White
        Me.chbxShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chbxShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.chbxShowPassword.FillColor = System.Drawing.Color.White
        Me.chbxShowPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxShowPassword.Location = New System.Drawing.Point(274, 261)
        Me.chbxShowPassword.Name = "chbxShowPassword"
        Me.chbxShowPassword.Size = New System.Drawing.Size(107, 20)
        Me.chbxShowPassword.TabIndex = 32
        Me.chbxShowPassword.Text = "Show Password"
        Me.chbxShowPassword.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
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
        Me.btnEditProfile.Location = New System.Drawing.Point(435, 124)
        Me.btnEditProfile.Name = "btnEditProfile"
        Me.btnEditProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnEditProfile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnEditProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnEditProfile.OnHoverImage = Nothing
        Me.btnEditProfile.OnPressedColor = System.Drawing.Color.Black
        Me.btnEditProfile.Size = New System.Drawing.Size(20, 20)
        Me.btnEditProfile.TabIndex = 31
        '
        'btnCreate
        '
        Me.btnCreate.Animated = True
        Me.btnCreate.AnimationHoverSpeed = 0.07!
        Me.btnCreate.AnimationSpeed = 0.03!
        Me.btnCreate.BackColor = System.Drawing.Color.Transparent
        Me.btnCreate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(254, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCreate.BorderColor = System.Drawing.Color.Black
        Me.btnCreate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCreate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCreate.CheckedForeColor = System.Drawing.Color.White
        Me.btnCreate.CheckedImage = Nothing
        Me.btnCreate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCreate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCreate.FocusedColor = System.Drawing.Color.Empty
        Me.btnCreate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.ForeColor = System.Drawing.Color.White
        Me.btnCreate.Image = Nothing
        Me.btnCreate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCreate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCreate.Location = New System.Drawing.Point(274, 341)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnCreate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCreate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCreate.OnHoverImage = Nothing
        Me.btnCreate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCreate.OnPressedColor = System.Drawing.Color.Black
        Me.btnCreate.Radius = 5
        Me.btnCreate.Size = New System.Drawing.Size(260, 42)
        Me.btnCreate.TabIndex = 30
        Me.btnCreate.Text = "Create"
        Me.btnCreate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnCreate.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Silver
        Me.Label7.Location = New System.Drawing.Point(271, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 15)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Account Type"
        '
        'cbAccountType
        '
        Me.cbAccountType.BackColor = System.Drawing.Color.Transparent
        Me.cbAccountType.BaseColor = System.Drawing.Color.White
        Me.cbAccountType.BorderColor = System.Drawing.Color.Silver
        Me.cbAccountType.BorderSize = 1
        Me.cbAccountType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAccountType.FocusedColor = System.Drawing.Color.Empty
        Me.cbAccountType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAccountType.ForeColor = System.Drawing.Color.Black
        Me.cbAccountType.FormattingEnabled = True
        Me.cbAccountType.Items.AddRange(New Object() {"Admin", "User"})
        Me.cbAccountType.Location = New System.Drawing.Point(274, 305)
        Me.cbAccountType.Name = "cbAccountType"
        Me.cbAccountType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbAccountType.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbAccountType.Radius = 2
        Me.cbAccountType.Size = New System.Drawing.Size(260, 24)
        Me.cbAccountType.StartIndex = 0
        Me.cbAccountType.TabIndex = 28
        Me.cbAccountType.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Silver
        Me.Label8.Location = New System.Drawing.Point(271, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 15)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Password"
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
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtPassword.Location = New System.Drawing.Point(274, 225)
        Me.txtPassword.MaxLength = 30
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPassword.Radius = 2
        Me.txtPassword.Size = New System.Drawing.Size(260, 30)
        Me.txtPassword.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Silver
        Me.Label9.Location = New System.Drawing.Point(271, 151)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 15)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Username"
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
        Me.txtUsername.Location = New System.Drawing.Point(274, 169)
        Me.txtUsername.MaxLength = 30
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtUsername.Radius = 2
        Me.txtUsername.Size = New System.Drawing.Size(260, 30)
        Me.txtUsername.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(320, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 30)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Create Account"
        '
        'pbProfile
        '
        Me.pbProfile.BaseColor = System.Drawing.Color.White
        Me.pbProfile.Image = Global.CafeProject.My.Resources.Resources.user
        Me.pbProfile.Location = New System.Drawing.Point(346, 44)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(100, 100)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 22
        Me.pbProfile.TabStop = False
        Me.pbProfile.UseTransfarantBackground = False
        '
        'tpEdit
        '
        Me.tpEdit.Controls.Add(Me.chbxEditShowPassword)
        Me.tpEdit.Controls.Add(Me.btnChangeProfile)
        Me.tpEdit.Controls.Add(Me.btnUpdate)
        Me.tpEdit.Controls.Add(Me.Label11)
        Me.tpEdit.Controls.Add(Me.txtEditPassword)
        Me.tpEdit.Controls.Add(Me.Label12)
        Me.tpEdit.Controls.Add(Me.txtEditUsername)
        Me.tpEdit.Controls.Add(Me.Label13)
        Me.tpEdit.Controls.Add(Me.pbEditProfile)
        Me.tpEdit.Location = New System.Drawing.Point(4, 22)
        Me.tpEdit.Name = "tpEdit"
        Me.tpEdit.Size = New System.Drawing.Size(804, 405)
        Me.tpEdit.TabIndex = 2
        Me.tpEdit.Text = "Edit"
        Me.tpEdit.UseVisualStyleBackColor = True
        '
        'chbxEditShowPassword
        '
        Me.chbxEditShowPassword.BaseColor = System.Drawing.Color.White
        Me.chbxEditShowPassword.CheckedOffColor = System.Drawing.Color.Gray
        Me.chbxEditShowPassword.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.chbxEditShowPassword.FillColor = System.Drawing.Color.White
        Me.chbxEditShowPassword.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbxEditShowPassword.Location = New System.Drawing.Point(274, 281)
        Me.chbxEditShowPassword.Name = "chbxEditShowPassword"
        Me.chbxEditShowPassword.Size = New System.Drawing.Size(107, 20)
        Me.chbxEditShowPassword.TabIndex = 38
        Me.chbxEditShowPassword.Text = "Show Password"
        Me.chbxEditShowPassword.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnChangeProfile
        '
        Me.btnChangeProfile.Animated = True
        Me.btnChangeProfile.AnimationHoverSpeed = 0.07!
        Me.btnChangeProfile.AnimationSpeed = 0.03!
        Me.btnChangeProfile.BaseColor = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnChangeProfile.BorderColor = System.Drawing.Color.Black
        Me.btnChangeProfile.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnChangeProfile.FocusedColor = System.Drawing.Color.Empty
        Me.btnChangeProfile.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnChangeProfile.ForeColor = System.Drawing.Color.White
        Me.btnChangeProfile.Image = Global.CafeProject.My.Resources.Resources.registration_24px
        Me.btnChangeProfile.ImageSize = New System.Drawing.Size(10, 10)
        Me.btnChangeProfile.Location = New System.Drawing.Point(443, 138)
        Me.btnChangeProfile.Name = "btnChangeProfile"
        Me.btnChangeProfile.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.btnChangeProfile.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnChangeProfile.OnHoverForeColor = System.Drawing.Color.White
        Me.btnChangeProfile.OnHoverImage = Nothing
        Me.btnChangeProfile.OnPressedColor = System.Drawing.Color.Black
        Me.btnChangeProfile.Size = New System.Drawing.Size(20, 20)
        Me.btnChangeProfile.TabIndex = 37
        '
        'btnUpdate
        '
        Me.btnUpdate.Animated = True
        Me.btnUpdate.AnimationHoverSpeed = 0.07!
        Me.btnUpdate.AnimationSpeed = 0.03!
        Me.btnUpdate.BackColor = System.Drawing.Color.Transparent
        Me.btnUpdate.BaseColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.BorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdate.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdate.CheckedImage = Nothing
        Me.btnUpdate.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.Color.White
        Me.btnUpdate.Image = Nothing
        Me.btnUpdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdate.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.Location = New System.Drawing.Point(274, 307)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(113, Byte), Integer))
        Me.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnUpdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdate.OnHoverImage = Nothing
        Me.btnUpdate.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnUpdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnUpdate.Radius = 5
        Me.btnUpdate.Size = New System.Drawing.Size(260, 42)
        Me.btnUpdate.TabIndex = 36
        Me.btnUpdate.Text = "Edit"
        Me.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnUpdate.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Silver
        Me.Label11.Location = New System.Drawing.Point(271, 227)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(57, 15)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Password"
        '
        'txtEditPassword
        '
        Me.txtEditPassword.BackColor = System.Drawing.Color.Transparent
        Me.txtEditPassword.BaseColor = System.Drawing.Color.White
        Me.txtEditPassword.BorderColor = System.Drawing.Color.Silver
        Me.txtEditPassword.BorderSize = 1
        Me.txtEditPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditPassword.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEditPassword.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtEditPassword.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEditPassword.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditPassword.Location = New System.Drawing.Point(274, 245)
        Me.txtEditPassword.MaxLength = 30
        Me.txtEditPassword.Name = "txtEditPassword"
        Me.txtEditPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtEditPassword.Radius = 2
        Me.txtEditPassword.Size = New System.Drawing.Size(260, 30)
        Me.txtEditPassword.TabIndex = 34
        Me.txtEditPassword.UseSystemPasswordChar = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Silver
        Me.Label12.Location = New System.Drawing.Point(271, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Username"
        '
        'txtEditUsername
        '
        Me.txtEditUsername.BackColor = System.Drawing.Color.Transparent
        Me.txtEditUsername.BaseColor = System.Drawing.Color.White
        Me.txtEditUsername.BorderColor = System.Drawing.Color.Silver
        Me.txtEditUsername.BorderSize = 1
        Me.txtEditUsername.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEditUsername.FocusedBaseColor = System.Drawing.Color.White
        Me.txtEditUsername.FocusedBorderColor = System.Drawing.Color.Silver
        Me.txtEditUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtEditUsername.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtEditUsername.Location = New System.Drawing.Point(274, 189)
        Me.txtEditUsername.MaxLength = 30
        Me.txtEditUsername.Name = "txtEditUsername"
        Me.txtEditUsername.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEditUsername.Radius = 2
        Me.txtEditUsername.Size = New System.Drawing.Size(260, 30)
        Me.txtEditUsername.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(337, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(139, 30)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Edit Account"
        '
        'pbEditProfile
        '
        Me.pbEditProfile.BaseColor = System.Drawing.Color.White
        Me.pbEditProfile.Image = Global.CafeProject.My.Resources.Resources.user
        Me.pbEditProfile.Location = New System.Drawing.Point(354, 58)
        Me.pbEditProfile.Name = "pbEditProfile"
        Me.pbEditProfile.Size = New System.Drawing.Size(100, 100)
        Me.pbEditProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEditProfile.TabIndex = 30
        Me.pbEditProfile.TabStop = False
        Me.pbEditProfile.UseTransfarantBackground = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ManageAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1006, 450)
        Me.Controls.Add(Me.pnlShadow)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ManageAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ManageAccount"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpAccount.ResumeLayout(False)
        Me.tpCreate.ResumeLayout(False)
        Me.tpCreate.PerformLayout()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEdit.ResumeLayout(False)
        Me.tpEdit.PerformLayout()
        CType(Me.pbEditProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents flpAccounts As FlowLayoutPanel
    Friend WithEvents pnlShadow As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCreateAccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnAccounts As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnEditAccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnDeleteAccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnEnableAccount As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tpAccount As TabPage
    Friend WithEvents tpCreate As TabPage
    Friend WithEvents tpEdit As TabPage
    Friend WithEvents btnEditProfile As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnCreate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label7 As Label
    Friend WithEvents cbAccountType As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents pbProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents btnChangeProfile As Guna.UI.WinForms.GunaCircleButton
    Friend WithEvents btnUpdate As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label11 As Label
    Friend WithEvents txtEditPassword As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtEditUsername As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents pbEditProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents chbxShowPassword As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents chbxEditShowPassword As Guna.UI.WinForms.GunaCheckBox
End Class
