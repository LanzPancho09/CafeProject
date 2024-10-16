<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainAccountControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainAccountControl))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnAction = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pbImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblID = New System.Windows.Forms.Label()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblUsername.ForeColor = System.Drawing.Color.Gray
        Me.lblUsername.Location = New System.Drawing.Point(230, 18)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(168, 15)
        Me.lblUsername.TabIndex = 11
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblPassword.ForeColor = System.Drawing.Color.Gray
        Me.lblPassword.Location = New System.Drawing.Point(404, 18)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(168, 15)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAction
        '
        Me.btnAction.Animated = True
        Me.btnAction.AnimationHoverSpeed = 0.07!
        Me.btnAction.AnimationSpeed = 0.03!
        Me.btnAction.BackColor = System.Drawing.Color.Transparent
        Me.btnAction.BaseColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(182, Byte), Integer), CType(CType(152, Byte), Integer))
        Me.btnAction.BorderColor = System.Drawing.Color.Black
        Me.btnAction.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAction.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnAction.CheckedForeColor = System.Drawing.Color.White
        Me.btnAction.CheckedImage = CType(resources.GetObject("btnAction.CheckedImage"), System.Drawing.Image)
        Me.btnAction.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnAction.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAction.FocusedColor = System.Drawing.Color.Empty
        Me.btnAction.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAction.ForeColor = System.Drawing.Color.White
        Me.btnAction.Image = Nothing
        Me.btnAction.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAction.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAction.Location = New System.Drawing.Point(616, 11)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.btnAction.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnAction.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAction.OnHoverImage = Nothing
        Me.btnAction.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnAction.OnPressedColor = System.Drawing.Color.Black
        Me.btnAction.Radius = 5
        Me.btnAction.Size = New System.Drawing.Size(127, 27)
        Me.btnAction.TabIndex = 13
        Me.btnAction.Text = "Edit"
        Me.btnAction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnAction.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Location = New System.Drawing.Point(157, 7)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(35, 35)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 12
        Me.pbImage.TabStop = False
        Me.pbImage.UseTransfarantBackground = False
        '
        'lblID
        '
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblID.ForeColor = System.Drawing.Color.Gray
        Me.lblID.Location = New System.Drawing.Point(15, 18)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(108, 15)
        Me.lblID.TabIndex = 14
        Me.lblID.Text = "1"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainAccountControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.btnAction)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblPassword)
        Me.Name = "MainAccountControl"
        Me.Size = New System.Drawing.Size(762, 50)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAction As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents pbImage As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblID As Label
End Class
