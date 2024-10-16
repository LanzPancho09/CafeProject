<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomMessageBox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CustomMessageBox))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblMessageInfo = New System.Windows.Forms.Label()
        Me.pbMainLogo = New System.Windows.Forms.PictureBox()
        Me.btnOK = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbMainLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.pbImage)
        Me.GunaPanel1.Controls.Add(Me.lblTitle)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(416, 43)
        Me.GunaPanel1.TabIndex = 3
        '
        'pbImage
        '
        Me.pbImage.Image = Global.CafeProject.My.Resources.Resources.info
        Me.pbImage.Location = New System.Drawing.Point(13, 11)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(20, 20)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 5
        Me.pbImage.TabStop = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(39, 14)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(71, 13)
        Me.lblTitle.TabIndex = 4
        Me.lblTitle.Text = "Message Box"
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
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
        Me.btnClose.Location = New System.Drawing.Point(368, 0)
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
        'lblMessageInfo
        '
        Me.lblMessageInfo.Location = New System.Drawing.Point(92, 77)
        Me.lblMessageInfo.Name = "lblMessageInfo"
        Me.lblMessageInfo.Size = New System.Drawing.Size(276, 50)
        Me.lblMessageInfo.TabIndex = 5
        Me.lblMessageInfo.Text = "Message Info"
        '
        'pbMainLogo
        '
        Me.pbMainLogo.Image = Global.CafeProject.My.Resources.Resources.info
        Me.pbMainLogo.Location = New System.Drawing.Point(31, 77)
        Me.pbMainLogo.Name = "pbMainLogo"
        Me.pbMainLogo.Size = New System.Drawing.Size(50, 50)
        Me.pbMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbMainLogo.TabIndex = 6
        Me.pbMainLogo.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Animated = True
        Me.btnOK.AnimationHoverSpeed = 0.07!
        Me.btnOK.AnimationSpeed = 0.03!
        Me.btnOK.BackColor = System.Drawing.Color.Transparent
        Me.btnOK.BaseColor = System.Drawing.Color.Transparent
        Me.btnOK.BorderColor = System.Drawing.Color.Black
        Me.btnOK.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnOK.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnOK.CheckedForeColor = System.Drawing.Color.White
        Me.btnOK.CheckedImage = CType(resources.GetObject("btnOK.CheckedImage"), System.Drawing.Image)
        Me.btnOK.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOK.FocusedColor = System.Drawing.Color.Empty
        Me.btnOK.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnOK.ForeColor = System.Drawing.Color.Black
        Me.btnOK.Image = Nothing
        Me.btnOK.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOK.ImageSize = New System.Drawing.Size(16, 16)
        Me.btnOK.LineBottom = 1
        Me.btnOK.LineColor = System.Drawing.Color.FromArgb(CType(CType(5, Byte), Integer), CType(CType(124, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnOK.LineLeft = 1
        Me.btnOK.LineRight = 1
        Me.btnOK.LineTop = 1
        Me.btnOK.Location = New System.Drawing.Point(326, 136)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnOK.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOK.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOK.OnHoverImage = CType(resources.GetObject("btnOK.OnHoverImage"), System.Drawing.Image)
        Me.btnOK.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnOK.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnOK.Size = New System.Drawing.Size(78, 28)
        Me.btnOK.TabIndex = 7
        Me.btnOK.Text = "OK"
        Me.btnOK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CustomMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 170)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.pbMainLogo)
        Me.Controls.Add(Me.lblMessageInfo)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CustomMessageBox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CustomMessageBox"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbMainLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pbMainLogo As PictureBox
    Friend WithEvents lblMessageInfo As Label
    Friend WithEvents btnOK As Guna.UI.WinForms.GunaAdvenceButton
End Class
