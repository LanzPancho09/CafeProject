<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OpenClient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OpenClient))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.lblClientName = New Guna.UI.WinForms.GunaLabel()
        Me.btnMinimize = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.btnViewAndControl = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chBroadcast = New Guna.UI.WinForms.GunaCheckBox()
        Me.chRemoteControl = New Guna.UI.WinForms.GunaCheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbScreen = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaElipsePanel1 = New Guna.UI.WinForms.GunaElipsePanel()
        Me.GunaPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaElipsePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Black
        Me.GunaPanel1.Controls.Add(Me.lblClientName)
        Me.GunaPanel1.Controls.Add(Me.btnMinimize)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(924, 43)
        Me.GunaPanel1.TabIndex = 1
        '
        'lblClientName
        '
        Me.lblClientName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblClientName.ForeColor = System.Drawing.SystemColors.Control
        Me.lblClientName.Location = New System.Drawing.Point(192, 10)
        Me.lblClientName.Name = "lblClientName"
        Me.lblClientName.Size = New System.Drawing.Size(542, 23)
        Me.lblClientName.TabIndex = 5
        Me.lblClientName.Text = "Client Name"
        Me.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimize
        '
        Me.btnMinimize.Animated = True
        Me.btnMinimize.AnimationHoverSpeed = 0.07!
        Me.btnMinimize.AnimationSpeed = 0.03!
        Me.btnMinimize.BaseColor = System.Drawing.Color.Black
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
        Me.btnMinimize.Location = New System.Drawing.Point(828, 0)
        Me.btnMinimize.Name = "btnMinimize"
        Me.btnMinimize.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.btnMinimize.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnMinimize.OnHoverForeColor = System.Drawing.Color.White
        Me.btnMinimize.OnHoverImage = Global.CafeProject.My.Resources.Resources.minimize_grey
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
        Me.btnClose.BaseColor = System.Drawing.Color.Black
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
        Me.btnClose.Location = New System.Drawing.Point(876, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Global.CafeProject.My.Resources.Resources.close
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 43)
        Me.btnClose.TabIndex = 3
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'btnViewAndControl
        '
        Me.btnViewAndControl.Animated = True
        Me.btnViewAndControl.AnimationHoverSpeed = 0.07!
        Me.btnViewAndControl.AnimationSpeed = 0.03!
        Me.btnViewAndControl.BackColor = System.Drawing.Color.Transparent
        Me.btnViewAndControl.BaseColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.btnViewAndControl.BorderColor = System.Drawing.Color.Black
        Me.btnViewAndControl.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnViewAndControl.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnViewAndControl.CheckedForeColor = System.Drawing.Color.White
        Me.btnViewAndControl.CheckedImage = CType(resources.GetObject("btnViewAndControl.CheckedImage"), System.Drawing.Image)
        Me.btnViewAndControl.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnViewAndControl.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnViewAndControl.FocusedColor = System.Drawing.Color.Empty
        Me.btnViewAndControl.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnViewAndControl.ForeColor = System.Drawing.Color.White
        Me.btnViewAndControl.Image = Nothing
        Me.btnViewAndControl.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnViewAndControl.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnViewAndControl.Location = New System.Drawing.Point(54, 351)
        Me.btnViewAndControl.Name = "btnViewAndControl"
        Me.btnViewAndControl.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnViewAndControl.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnViewAndControl.OnHoverForeColor = System.Drawing.Color.White
        Me.btnViewAndControl.OnHoverImage = Nothing
        Me.btnViewAndControl.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnViewAndControl.OnPressedColor = System.Drawing.Color.Black
        Me.btnViewAndControl.Radius = 3
        Me.btnViewAndControl.Size = New System.Drawing.Size(171, 29)
        Me.btnViewAndControl.TabIndex = 6
        Me.btnViewAndControl.Text = "View"
        Me.btnViewAndControl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnViewAndControl.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Panel1.Controls.Add(Me.chBroadcast)
        Me.Panel1.Controls.Add(Me.chRemoteControl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnViewAndControl)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(651, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(273, 418)
        Me.Panel1.TabIndex = 8
        '
        'chBroadcast
        '
        Me.chBroadcast.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.chBroadcast.CheckedOffColor = System.Drawing.Color.Gray
        Me.chBroadcast.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chBroadcast.FillColor = System.Drawing.Color.White
        Me.chBroadcast.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chBroadcast.ForeColor = System.Drawing.Color.White
        Me.chBroadcast.Location = New System.Drawing.Point(54, 193)
        Me.chBroadcast.Name = "chBroadcast"
        Me.chBroadcast.Size = New System.Drawing.Size(140, 20)
        Me.chBroadcast.TabIndex = 9
        Me.chBroadcast.Text = "Broadcast Upon Open"
        '
        'chRemoteControl
        '
        Me.chRemoteControl.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.chRemoteControl.Checked = True
        Me.chRemoteControl.CheckedOffColor = System.Drawing.Color.Gray
        Me.chRemoteControl.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.chRemoteControl.FillColor = System.Drawing.Color.White
        Me.chRemoteControl.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chRemoteControl.ForeColor = System.Drawing.Color.White
        Me.chRemoteControl.Location = New System.Drawing.Point(54, 167)
        Me.chRemoteControl.Name = "chRemoteControl"
        Me.chRemoteControl.Size = New System.Drawing.Size(109, 20)
        Me.chRemoteControl.TabIndex = 8
        Me.chRemoteControl.Text = "Remote Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "View Settings"
        '
        'pbScreen
        '
        Me.pbScreen.BaseColor = System.Drawing.Color.White
        Me.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbScreen.Name = "pbScreen"
        Me.pbScreen.Size = New System.Drawing.Size(633, 400)
        Me.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbScreen.TabIndex = 0
        Me.pbScreen.TabStop = False
        '
        'GunaElipsePanel1
        '
        Me.GunaElipsePanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.GunaElipsePanel1.BaseColor = System.Drawing.Color.White
        Me.GunaElipsePanel1.Controls.Add(Me.pbScreen)
        Me.GunaElipsePanel1.Location = New System.Drawing.Point(9, 51)
        Me.GunaElipsePanel1.Name = "GunaElipsePanel1"
        Me.GunaElipsePanel1.Size = New System.Drawing.Size(633, 400)
        Me.GunaElipsePanel1.TabIndex = 7
        '
        'OpenClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(924, 461)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaElipsePanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OpenClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OpenClient"
        Me.GunaPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaElipsePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnMinimize As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents btnViewAndControl As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblClientName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents chBroadcast As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents chRemoteControl As Guna.UI.WinForms.GunaCheckBox
    Friend WithEvents GunaElipsePanel1 As Guna.UI.WinForms.GunaElipsePanel
    Friend WithEvents pbScreen As Guna.UI.WinForms.GunaPictureBox
End Class
