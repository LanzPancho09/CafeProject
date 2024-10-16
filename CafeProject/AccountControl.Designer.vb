<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AccountControl))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pbImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.btnExtend = New Guna.UI.WinForms.GunaAdvenceButton()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(667, 14)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(168, 15)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(407, 13)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(168, 15)
        Me.lblPassword.TabIndex = 6
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(118, 13)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(168, 15)
        Me.lblUsername.TabIndex = 7
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Location = New System.Drawing.Point(34, 4)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(35, 35)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 8
        Me.pbImage.TabStop = False
        Me.pbImage.UseTransfarantBackground = False
        '
        'btnExtend
        '
        Me.btnExtend.Animated = True
        Me.btnExtend.AnimationHoverSpeed = 0.07!
        Me.btnExtend.AnimationSpeed = 0.03!
        Me.btnExtend.BackColor = System.Drawing.Color.Transparent
        Me.btnExtend.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnExtend.BorderColor = System.Drawing.Color.Black
        Me.btnExtend.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnExtend.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnExtend.CheckedForeColor = System.Drawing.Color.White
        Me.btnExtend.CheckedImage = CType(resources.GetObject("btnExtend.CheckedImage"), System.Drawing.Image)
        Me.btnExtend.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnExtend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExtend.FocusedColor = System.Drawing.Color.Empty
        Me.btnExtend.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtend.ForeColor = System.Drawing.Color.White
        Me.btnExtend.Image = Nothing
        Me.btnExtend.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExtend.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnExtend.Location = New System.Drawing.Point(891, 7)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnExtend.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExtend.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExtend.OnHoverImage = Nothing
        Me.btnExtend.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnExtend.OnPressedColor = System.Drawing.Color.Black
        Me.btnExtend.Radius = 5
        Me.btnExtend.Size = New System.Drawing.Size(127, 27)
        Me.btnExtend.TabIndex = 9
        Me.btnExtend.Text = "Extend"
        Me.btnExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExtend.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'AccountControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnExtend)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblTime)
        Me.Name = "AccountControl"
        Me.Size = New System.Drawing.Size(1050, 45)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnExtend As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pbImage As Guna.UI.WinForms.GunaCirclePictureBox
End Class
