<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SetClientTime
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SetClientTime))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnMinimize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnCustom = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnMin = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn5Minute = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btn30Minute = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pnlHeader = New Guna.UI.WinForms.GunaElipsePanel()
        Me.btnDeductTime = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnAddTime = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbClientProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnHour = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblTotalTime = New System.Windows.Forms.Label()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.pnlSeperator = New Guna.UI.WinForms.GunaPanel()
        Me.lblClientName = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRemainingTime = New System.Windows.Forms.Label()
        Me.pnlMonitorMode = New System.Windows.Forms.Panel()
        Me.lblcomputername = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnConfirmOrder = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblMonitorTotalTime = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.pnlHeader.SuspendLayout()
        CType(Me.pbClientProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlMonitorMode.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.btnMinimize)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(800, 43)
        Me.GunaPanel1.TabIndex = 0
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.btnMinimize.Image = CType(resources.GetObject("btnMinimize.Image"), System.Drawing.Image)
        Me.btnMinimize.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnMinimize.ImageSize = New System.Drawing.Size(15, 15)
        Me.btnMinimize.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMinimize.Location = New System.Drawing.Point(704, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverImage = CType(resources.GetObject("btnMinimize.OnHoverImage"), System.Drawing.Image)
        Me.btnMinimize.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMinimize.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnMinimize.Size = New System.Drawing.Size(48, 43)
        Me.btnMinimize.TabIndex = 4
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
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
        Me.btnClose.Location = New System.Drawing.Point(752, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = CType(resources.GetObject("btnClose.OnHoverImage"), System.Drawing.Image)
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 43)
        Me.btnClose.TabIndex = 3
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.btnClear)
        Me.GunaElipsePanel1.Controls.Add(Me.btnCustom)
        Me.GunaElipsePanel1.Controls.Add(Me.btnMin)
        Me.GunaElipsePanel1.Controls.Add(Me.btn5Minute)
        Me.GunaElipsePanel1.Controls.Add(Me.btn30Minute)
        Me.GunaElipsePanel1.Controls.Add(Me.pnlHeader)
        Me.GunaElipsePanel1.Controls.Add(Me.btnHour)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(7, 12)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(452, 426)
        Me.GunaElipsePanel1.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Animated = True
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClear.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClear.CheckedForeColor = System.Drawing.Color.White
        Me.btnClear.CheckedImage = CType(resources.GetObject("btnClear.CheckedImage"), System.Drawing.Image)
        Me.btnClear.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageOffsetX = 8
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(150, 299)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClear.OnPressedColor = System.Drawing.Color.Black
        Me.btnClear.Radius = 6
        Me.btnClear.Size = New System.Drawing.Size(129, 119)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClear.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnCustom
        '
        Me.btnCustom.Animated = True
        Me.btnCustom.AnimationHoverSpeed = 0.07!
        Me.btnCustom.AnimationSpeed = 0.03!
        Me.btnCustom.BackColor = System.Drawing.Color.Transparent
        Me.btnCustom.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnCustom.BorderColor = System.Drawing.Color.Black
        Me.btnCustom.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnCustom.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnCustom.CheckedForeColor = System.Drawing.Color.White
        Me.btnCustom.CheckedImage = CType(resources.GetObject("btnCustom.CheckedImage"), System.Drawing.Image)
        Me.btnCustom.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnCustom.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCustom.FocusedColor = System.Drawing.Color.Empty
        Me.btnCustom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustom.ForeColor = System.Drawing.Color.White
        Me.btnCustom.Image = Global.CafeProject.My.Resources.Resources.Timer_white
        Me.btnCustom.ImageOffsetX = 8
        Me.btnCustom.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnCustom.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCustom.Location = New System.Drawing.Point(285, 299)
        Me.btnCustom.Name = "btnCustom"
        Me.btnCustom.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnCustom.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnCustom.OnHoverForeColor = System.Drawing.Color.White
        Me.btnCustom.OnHoverImage = Nothing
        Me.btnCustom.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnCustom.OnPressedColor = System.Drawing.Color.Black
        Me.btnCustom.Radius = 6
        Me.btnCustom.Size = New System.Drawing.Size(129, 119)
        Me.btnCustom.TabIndex = 5
        Me.btnCustom.Text = "Custom"
        Me.btnCustom.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.btnCustom.Visible = False
        '
        'btnMin
        '
        Me.btnMin.Animated = True
        Me.btnMin.AnimationHoverSpeed = 0.07!
        Me.btnMin.AnimationSpeed = 0.03!
        Me.btnMin.BackColor = System.Drawing.Color.Transparent
        Me.btnMin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnMin.BorderColor = System.Drawing.Color.Black
        Me.btnMin.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnMin.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnMin.CheckedForeColor = System.Drawing.Color.White
        Me.btnMin.CheckedImage = CType(resources.GetObject("btnMin.CheckedImage"), System.Drawing.Image)
        Me.btnMin.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnMin.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnMin.FocusedColor = System.Drawing.Color.Empty
        Me.btnMin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMin.ForeColor = System.Drawing.Color.White
        Me.btnMin.Image = Global.CafeProject.My.Resources.Resources.Timer_white
        Me.btnMin.ImageOffsetX = 8
        Me.btnMin.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnMin.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMin.Location = New System.Drawing.Point(15, 299)
        Me.btnMin.Name = "btnMin"
        Me.btnMin.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnMin.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMin.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMin.OnHoverImage = Nothing
        Me.btnMin.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnMin.OnPressedColor = System.Drawing.Color.Black
        Me.btnMin.Radius = 6
        Me.btnMin.Size = New System.Drawing.Size(129, 119)
        Me.btnMin.TabIndex = 4
        Me.btnMin.Text = "1 Minute"
        Me.btnMin.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btn5Minute
        '
        Me.btn5Minute.Animated = True
        Me.btn5Minute.AnimationHoverSpeed = 0.07!
        Me.btn5Minute.AnimationSpeed = 0.03!
        Me.btn5Minute.BackColor = System.Drawing.Color.Transparent
        Me.btn5Minute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn5Minute.BorderColor = System.Drawing.Color.Black
        Me.btn5Minute.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn5Minute.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn5Minute.CheckedForeColor = System.Drawing.Color.White
        Me.btn5Minute.CheckedImage = CType(resources.GetObject("btn5Minute.CheckedImage"), System.Drawing.Image)
        Me.btn5Minute.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn5Minute.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn5Minute.FocusedColor = System.Drawing.Color.Empty
        Me.btn5Minute.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5Minute.ForeColor = System.Drawing.Color.White
        Me.btn5Minute.Image = Global.CafeProject.My.Resources.Resources.Timer_white
        Me.btn5Minute.ImageOffsetX = 5
        Me.btn5Minute.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn5Minute.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn5Minute.Location = New System.Drawing.Point(285, 174)
        Me.btn5Minute.Name = "btn5Minute"
        Me.btn5Minute.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn5Minute.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn5Minute.OnHoverForeColor = System.Drawing.Color.White
        Me.btn5Minute.OnHoverImage = Nothing
        Me.btn5Minute.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn5Minute.OnPressedColor = System.Drawing.Color.Black
        Me.btn5Minute.Radius = 6
        Me.btn5Minute.Size = New System.Drawing.Size(129, 119)
        Me.btn5Minute.TabIndex = 3
        Me.btn5Minute.Text = "5 Minutes"
        Me.btn5Minute.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btn30Minute
        '
        Me.btn30Minute.Animated = True
        Me.btn30Minute.AnimationHoverSpeed = 0.07!
        Me.btn30Minute.AnimationSpeed = 0.03!
        Me.btn30Minute.BackColor = System.Drawing.Color.Transparent
        Me.btn30Minute.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btn30Minute.BorderColor = System.Drawing.Color.Black
        Me.btn30Minute.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btn30Minute.CheckedBorderColor = System.Drawing.Color.Black
        Me.btn30Minute.CheckedForeColor = System.Drawing.Color.White
        Me.btn30Minute.CheckedImage = CType(resources.GetObject("btn30Minute.CheckedImage"), System.Drawing.Image)
        Me.btn30Minute.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btn30Minute.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn30Minute.FocusedColor = System.Drawing.Color.Empty
        Me.btn30Minute.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn30Minute.ForeColor = System.Drawing.Color.White
        Me.btn30Minute.Image = Global.CafeProject.My.Resources.Resources.Timer_white
        Me.btn30Minute.ImageOffsetX = 5
        Me.btn30Minute.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn30Minute.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn30Minute.Location = New System.Drawing.Point(150, 174)
        Me.btn30Minute.Name = "btn30Minute"
        Me.btn30Minute.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btn30Minute.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btn30Minute.OnHoverForeColor = System.Drawing.Color.White
        Me.btn30Minute.OnHoverImage = Nothing
        Me.btn30Minute.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btn30Minute.OnPressedColor = System.Drawing.Color.Black
        Me.btn30Minute.Radius = 6
        Me.btn30Minute.Size = New System.Drawing.Size(129, 119)
        Me.btn30Minute.TabIndex = 2
        Me.btn30Minute.Text = "30 Minutes"
        Me.btn30Minute.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'pnlHeader
        '
        Me.pnlHeader.BackColor = System.Drawing.Color.Transparent
        Me.pnlHeader.BaseColor = System.Drawing.Color.White
        Me.pnlHeader.Controls.Add(Me.btnDeductTime)
        Me.pnlHeader.Controls.Add(Me.btnAddTime)
        Me.pnlHeader.Controls.Add(Me.Label1)
        Me.pnlHeader.Controls.Add(Me.pbClientProfile)
        Me.pnlHeader.Location = New System.Drawing.Point(15, 15)
        Me.pnlHeader.Name = "pnlHeader"
        Me.pnlHeader.Size = New System.Drawing.Size(421, 153)
        Me.pnlHeader.TabIndex = 1
        '
        'btnDeductTime
        '
        Me.btnDeductTime.Animated = True
        Me.btnDeductTime.AnimationHoverSpeed = 0.07!
        Me.btnDeductTime.AnimationSpeed = 0.03!
        Me.btnDeductTime.BackColor = System.Drawing.Color.Transparent
        Me.btnDeductTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnDeductTime.BorderColor = System.Drawing.Color.Black
        Me.btnDeductTime.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnDeductTime.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnDeductTime.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDeductTime.CheckedForeColor = System.Drawing.Color.Black
        Me.btnDeductTime.CheckedImage = Nothing
        Me.btnDeductTime.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnDeductTime.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeductTime.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeductTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeductTime.ForeColor = System.Drawing.Color.Black
        Me.btnDeductTime.Image = Nothing
        Me.btnDeductTime.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeductTime.LineBottom = 3
        Me.btnDeductTime.LineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnDeductTime.Location = New System.Drawing.Point(97, 106)
        Me.btnDeductTime.Name = "btnDeductTime"
        Me.btnDeductTime.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnDeductTime.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeductTime.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnDeductTime.OnHoverImage = Nothing
        Me.btnDeductTime.OnHoverLineColor = System.Drawing.Color.Black
        Me.btnDeductTime.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnDeductTime.Radius = 3
        Me.btnDeductTime.Size = New System.Drawing.Size(85, 44)
        Me.btnDeductTime.TabIndex = 7
        Me.btnDeductTime.Text = "Deduct"
        Me.btnDeductTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeductTime.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnAddTime
        '
        Me.btnAddTime.Animated = True
        Me.btnAddTime.AnimationHoverSpeed = 0.07!
        Me.btnAddTime.AnimationSpeed = 0.03!
        Me.btnAddTime.BackColor = System.Drawing.Color.Transparent
        Me.btnAddTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAddTime.BorderColor = System.Drawing.Color.Black
        Me.btnAddTime.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton
        Me.btnAddTime.Checked = True
        Me.btnAddTime.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnAddTime.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAddTime.CheckedForeColor = System.Drawing.Color.Black
        Me.btnAddTime.CheckedImage = Nothing
        Me.btnAddTime.CheckedLineColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnAddTime.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddTime.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTime.ForeColor = System.Drawing.Color.Black
        Me.btnAddTime.Image = Nothing
        Me.btnAddTime.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddTime.LineBottom = 3
        Me.btnAddTime.LineColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnAddTime.Location = New System.Drawing.Point(6, 106)
        Me.btnAddTime.Name = "btnAddTime"
        Me.btnAddTime.OnHoverBaseColor = System.Drawing.Color.White
        Me.btnAddTime.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAddTime.OnHoverForeColor = System.Drawing.Color.Black
        Me.btnAddTime.OnHoverImage = Nothing
        Me.btnAddTime.OnHoverLineColor = System.Drawing.Color.Black
        Me.btnAddTime.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnAddTime.Radius = 3
        Me.btnAddTime.Size = New System.Drawing.Size(85, 44)
        Me.btnAddTime.TabIndex = 6
        Me.btnAddTime.Text = "Add Time"
        Me.btnAddTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAddTime.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 26)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Client Time"
        '
        'pbClientProfile
        '
        Me.pbClientProfile.BaseColor = System.Drawing.Color.White
        Me.pbClientProfile.Image = Global.CafeProject.My.Resources.Resources.user
        Me.pbClientProfile.Location = New System.Drawing.Point(367, 16)
        Me.pbClientProfile.Name = "pbClientProfile"
        Me.pbClientProfile.Size = New System.Drawing.Size(40, 40)
        Me.pbClientProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbClientProfile.TabIndex = 0
        Me.pbClientProfile.TabStop = False
        Me.pbClientProfile.UseTransfarantBackground = False
        '
        'btnHour
        '
        Me.btnHour.Animated = True
        Me.btnHour.AnimationHoverSpeed = 0.07!
        Me.btnHour.AnimationSpeed = 0.03!
        Me.btnHour.BackColor = System.Drawing.Color.Transparent
        Me.btnHour.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnHour.BorderColor = System.Drawing.Color.Black
        Me.btnHour.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnHour.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnHour.CheckedForeColor = System.Drawing.Color.White
        Me.btnHour.CheckedImage = CType(resources.GetObject("btnHour.CheckedImage"), System.Drawing.Image)
        Me.btnHour.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnHour.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnHour.FocusedColor = System.Drawing.Color.Empty
        Me.btnHour.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHour.ForeColor = System.Drawing.Color.White
        Me.btnHour.Image = Global.CafeProject.My.Resources.Resources.Timer_white
        Me.btnHour.ImageOffsetX = 15
        Me.btnHour.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnHour.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHour.Location = New System.Drawing.Point(15, 174)
        Me.btnHour.Name = "btnHour"
        Me.btnHour.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnHour.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnHour.OnHoverForeColor = System.Drawing.Color.White
        Me.btnHour.OnHoverImage = Nothing
        Me.btnHour.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnHour.OnPressedColor = System.Drawing.Color.Black
        Me.btnHour.Radius = 6
        Me.btnHour.Size = New System.Drawing.Size(129, 119)
        Me.btnHour.TabIndex = 0
        Me.btnHour.Text = "1 Hour"
        Me.btnHour.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(484, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 26)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Order Summary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(486, 247)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Total "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(486, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Discount"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(486, 207)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Total Time"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(486, 335)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Total Ammount"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTotal.Location = New System.Drawing.Point(605, 247)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(172, 17)
        Me.lblTotal.TabIndex = 9
        Me.lblTotal.Text = "0.00"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDiscount.Location = New System.Drawing.Point(605, 227)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(172, 17)
        Me.lblDiscount.TabIndex = 10
        Me.lblDiscount.Text = "0.00"
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalTime
        '
        Me.lblTotalTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTotalTime.Location = New System.Drawing.Point(605, 207)
        Me.lblTotalTime.Name = "lblTotalTime"
        Me.lblTotalTime.Size = New System.Drawing.Size(172, 17)
        Me.lblTotalTime.TabIndex = 11
        Me.lblTotalTime.Text = "0 Min"
        Me.lblTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.lblTotalPrice.Location = New System.Drawing.Point(630, 333)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(147, 17)
        Me.lblTotalPrice.TabIndex = 12
        Me.lblTotalPrice.Text = "0.00"
        Me.lblTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlSeperator
        '
        Me.pnlSeperator.Location = New System.Drawing.Point(489, 308)
        Me.pnlSeperator.Name = "pnlSeperator"
        Me.pnlSeperator.Size = New System.Drawing.Size(288, 10)
        Me.pnlSeperator.TabIndex = 13
        '
        'lblClientName
        '
        Me.lblClientName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClientName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblClientName.Location = New System.Drawing.Point(605, 135)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(172, 17)
        Me.lblClientName.TabIndex = 16
        Me.lblClientName.Text = "PC 1"
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(486, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(90, 17)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Client Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(486, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Remaining Time"
        '
        'lblRemainingTime
        '
        Me.lblRemainingTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemainingTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblRemainingTime.Location = New System.Drawing.Point(605, 152)
        Me.lblRemainingTime.Name = "lblRemainingTime"
        Me.lblRemainingTime.Size = New System.Drawing.Size(172, 17)
        Me.lblRemainingTime.TabIndex = 18
        Me.lblRemainingTime.Text = "0 Min/s"
        Me.lblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pnlMonitorMode
        '
        Me.pnlMonitorMode.Controls.Add(Me.lblMonitorTotalTime)
        Me.pnlMonitorMode.Controls.Add(Me.Label11)
        Me.pnlMonitorMode.Controls.Add(Me.lblcomputername)
        Me.pnlMonitorMode.Controls.Add(Me.Label8)
        Me.pnlMonitorMode.Controls.Add(Me.Label7)
        Me.pnlMonitorMode.Location = New System.Drawing.Point(475, 63)
        Me.pnlMonitorMode.Name = "pnlMonitorMode"
        Me.pnlMonitorMode.Size = New System.Drawing.Size(313, 287)
        Me.pnlMonitorMode.TabIndex = 19
        '
        'lblcomputername
        '
        Me.lblcomputername.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcomputername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblcomputername.Location = New System.Drawing.Point(130, 55)
        Me.lblcomputername.Name = "lblcomputername"
        Me.lblcomputername.Size = New System.Drawing.Size(172, 17)
        Me.lblcomputername.TabIndex = 17
        Me.lblcomputername.Text = "PC 1"
        Me.lblcomputername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(11, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Client Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 26)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Monitor Mode"
        '
        'btnConfirmOrder
        '
        Me.btnConfirmOrder.Animated = True
        Me.btnConfirmOrder.AnimationHoverSpeed = 0.07!
        Me.btnConfirmOrder.AnimationSpeed = 0.03!
        Me.btnConfirmOrder.BackColor = System.Drawing.Color.Transparent
        Me.btnConfirmOrder.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnConfirmOrder.BorderColor = System.Drawing.Color.Black
        Me.btnConfirmOrder.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnConfirmOrder.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnConfirmOrder.CheckedForeColor = System.Drawing.Color.White
        Me.btnConfirmOrder.CheckedImage = CType(resources.GetObject("btnConfirmOrder.CheckedImage"), System.Drawing.Image)
        Me.btnConfirmOrder.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnConfirmOrder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnConfirmOrder.FocusedColor = System.Drawing.Color.Empty
        Me.btnConfirmOrder.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmOrder.ForeColor = System.Drawing.Color.White
        Me.btnConfirmOrder.Image = Nothing
        Me.btnConfirmOrder.ImageOffsetX = 5
        Me.btnConfirmOrder.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnConfirmOrder.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnConfirmOrder.Location = New System.Drawing.Point(489, 374)
        Me.btnConfirmOrder.Name = "btnConfirmOrder"
        Me.btnConfirmOrder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnConfirmOrder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnConfirmOrder.OnHoverForeColor = System.Drawing.Color.White
        Me.btnConfirmOrder.OnHoverImage = Nothing
        Me.btnConfirmOrder.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnConfirmOrder.OnPressedColor = System.Drawing.Color.Black
        Me.btnConfirmOrder.Radius = 6
        Me.btnConfirmOrder.Size = New System.Drawing.Size(288, 56)
        Me.btnConfirmOrder.TabIndex = 14
        Me.btnConfirmOrder.Text = "Confirm Order"
        Me.btnConfirmOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnConfirmOrder.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'lblMonitorTotalTime
        '
        Me.lblMonitorTotalTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonitorTotalTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblMonitorTotalTime.Location = New System.Drawing.Point(127, 89)
        Me.lblMonitorTotalTime.Name = "lblMonitorTotalTime"
        Me.lblMonitorTotalTime.Size = New System.Drawing.Size(172, 17)
        Me.lblMonitorTotalTime.TabIndex = 19
        Me.lblMonitorTotalTime.Text = "0 Min"
        Me.lblMonitorTotalTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(8, 89)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 17)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Total Time"
        '
        'SetClientTime
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(248, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pnlMonitorMode)
        Me.Controls.Add(Me.lblRemainingTime)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblClientName)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnConfirmOrder)
        Me.Controls.Add(Me.pnlSeperator)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.lblTotalTime)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SetClientTime"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SetClientTime"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.pnlHeader.ResumeLayout(False)
        Me.pnlHeader.PerformLayout()
        CType(Me.pbClientProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlMonitorMode.ResumeLayout(False)
        Me.pnlMonitorMode.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents Label9 As Label
    Friend WithEvents btnHour As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlHeader As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents pnlSeperator As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents lblTotalTime As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCustom As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnMin As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn5Minute As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btn30Minute As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents pbClientProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblClientName As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btnConfirmOrder As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnDeductTime As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnAddTime As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblRemainingTime As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pnlMonitorMode As Panel
    Friend WithEvents lblcomputername As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblMonitorTotalTime As Label
    Friend WithEvents Label11 As Label
End Class
