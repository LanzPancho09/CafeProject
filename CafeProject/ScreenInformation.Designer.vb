<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenInformation
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenInformation))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.btnView = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pbProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(12, 12)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(293, 26)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Client Screen"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(14, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Available"
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Timer2
        '
        Me.Timer2.Interval = 2000
        '
        'btnView
        '
        Me.btnView.Animated = True
        Me.btnView.AnimationHoverSpeed = 0.07!
        Me.btnView.AnimationSpeed = 0.03!
        Me.btnView.BackColor = System.Drawing.Color.Transparent
        Me.btnView.BaseColor = System.Drawing.Color.Transparent
        Me.btnView.BorderColor = System.Drawing.Color.Black
        Me.btnView.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnView.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnView.CheckedForeColor = System.Drawing.Color.White
        Me.btnView.CheckedImage = CType(resources.GetObject("btnView.CheckedImage"), System.Drawing.Image)
        Me.btnView.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnView.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnView.FocusedColor = System.Drawing.Color.Empty
        Me.btnView.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnView.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnView.Image = Global.CafeProject.My.Resources.Resources.View1
        Me.btnView.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.btnView.ImageOffsetX = 5
        Me.btnView.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnView.LineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnView.LineTop = 1
        Me.btnView.Location = New System.Drawing.Point(0, 83)
        Me.btnView.Name = "btnView"
        Me.btnView.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.btnView.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnView.OnHoverForeColor = System.Drawing.Color.White
        Me.btnView.OnHoverImage = Global.CafeProject.My.Resources.Resources.view_white
        Me.btnView.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnView.OnPressedColor = System.Drawing.Color.Black
        Me.btnView.Size = New System.Drawing.Size(373, 42)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "View"
        Me.btnView.TextOffsetX = 7
        Me.btnView.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'pbProfile
        '
        Me.pbProfile.BaseColor = System.Drawing.Color.White
        Me.pbProfile.Location = New System.Drawing.Point(311, 12)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(50, 50)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 0
        Me.pbProfile.TabStop = False
        Me.pbProfile.UseTransfarantBackground = False
        '
        'ScreenInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 125)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbProfile)
        Me.Controls.Add(Me.lblName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ScreenInformation"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ScreenInformation"
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pbProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnView As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Timer2 As Timer
End Class
