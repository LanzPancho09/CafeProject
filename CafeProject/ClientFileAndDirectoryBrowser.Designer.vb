<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientFileAndDirectoryBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientFileAndDirectoryBrowser))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lblDirectoryAndFileName = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.txtDirectory = New System.Windows.Forms.TextBox()
        Me.flpSideNav = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBack = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnOk = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.pbImage)
        Me.GunaPanel1.Controls.Add(Me.lblDirectoryAndFileName)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(800, 43)
        Me.GunaPanel1.TabIndex = 1
        '
        'pbImage
        '
        Me.pbImage.Image = Global.CafeProject.My.Resources.Resources.Folder
        Me.pbImage.Location = New System.Drawing.Point(13, 11)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(20, 20)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 5
        Me.pbImage.TabStop = False
        '
        'lblDirectoryAndFileName
        '
        Me.lblDirectoryAndFileName.AutoSize = True
        Me.lblDirectoryAndFileName.ForeColor = System.Drawing.Color.White
        Me.lblDirectoryAndFileName.Location = New System.Drawing.Point(39, 14)
        Me.lblDirectoryAndFileName.Name = "lblDirectoryAndFileName"
        Me.lblDirectoryAndFileName.Size = New System.Drawing.Size(89, 13)
        Me.lblDirectoryAndFileName.TabIndex = 4
        Me.lblDirectoryAndFileName.Text = "Client File System"
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
        Me.btnClose.Image = Global.CafeProject.My.Resources.Resources.Close_48px
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(752, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 43)
        Me.btnClose.TabIndex = 3
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoScroll = True
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(186, 91)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(602, 372)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'txtDirectory
        '
        Me.txtDirectory.Location = New System.Drawing.Point(42, 58)
        Me.txtDirectory.Name = "txtDirectory"
        Me.txtDirectory.Size = New System.Drawing.Size(746, 20)
        Me.txtDirectory.TabIndex = 9
        '
        'flpSideNav
        '
        Me.flpSideNav.AutoScroll = True
        Me.flpSideNav.Location = New System.Drawing.Point(7, 91)
        Me.flpSideNav.Margin = New System.Windows.Forms.Padding(0)
        Me.flpSideNav.Name = "flpSideNav"
        Me.flpSideNav.Size = New System.Drawing.Size(166, 372)
        Me.flpSideNav.TabIndex = 16
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(800, 10)
        Me.Panel3.TabIndex = 25
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(179, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 372)
        Me.Panel1.TabIndex = 26
        '
        'btnBack
        '
        Me.btnBack.Animated = True
        Me.btnBack.AnimationHoverSpeed = 0.07!
        Me.btnBack.AnimationSpeed = 0.03!
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnBack.BorderColor = System.Drawing.Color.Black
        Me.btnBack.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnBack.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnBack.CheckedForeColor = System.Drawing.Color.White
        Me.btnBack.CheckedImage = CType(resources.GetObject("btnBack.CheckedImage"), System.Drawing.Image)
        Me.btnBack.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnBack.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBack.FocusedColor = System.Drawing.Color.Empty
        Me.btnBack.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.Color.White
        Me.btnBack.Image = Global.CafeProject.My.Resources.Resources.left_grey
        Me.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBack.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBack.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(4, 58)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnBack.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBack.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBack.OnHoverImage = Nothing
        Me.btnBack.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBack.OnPressedColor = System.Drawing.Color.Black
        Me.btnBack.Radius = 3
        Me.btnBack.Size = New System.Drawing.Size(32, 20)
        Me.btnBack.TabIndex = 10
        Me.btnBack.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBack.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnOk
        '
        Me.btnOk.Animated = True
        Me.btnOk.AnimationHoverSpeed = 0.07!
        Me.btnOk.AnimationSpeed = 0.03!
        Me.btnOk.BackColor = System.Drawing.Color.Transparent
        Me.btnOk.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnOk.BorderColor = System.Drawing.Color.Black
        Me.btnOk.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnOk.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnOk.CheckedForeColor = System.Drawing.Color.White
        Me.btnOk.CheckedImage = CType(resources.GetObject("btnOk.CheckedImage"), System.Drawing.Image)
        Me.btnOk.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnOk.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnOk.FocusedColor = System.Drawing.Color.Empty
        Me.btnOk.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.ForeColor = System.Drawing.Color.White
        Me.btnOk.Image = Nothing
        Me.btnOk.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnOk.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnOk.Location = New System.Drawing.Point(650, 478)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnOk.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnOk.OnHoverForeColor = System.Drawing.Color.White
        Me.btnOk.OnHoverImage = Nothing
        Me.btnOk.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnOk.OnPressedColor = System.Drawing.Color.Black
        Me.btnOk.Radius = 3
        Me.btnOk.Size = New System.Drawing.Size(138, 29)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnOk.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'ClientFileAndDirectoryBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 519)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.flpSideNav)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtDirectory)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClientFileAndDirectoryBrowser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ClientFileAndDirectoryBrowser"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnOk As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnBack As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtDirectory As TextBox
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents lblDirectoryAndFileName As Label
    Friend WithEvents flpSideNav As FlowLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
End Class
