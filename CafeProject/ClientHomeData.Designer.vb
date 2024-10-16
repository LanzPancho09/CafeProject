<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientHomeData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientHomeData))
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.pbImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.lblIpAddress = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(60, 7)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(82, 18)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Username"
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Image = CType(resources.GetObject("pbImage.Image"), System.Drawing.Image)
        Me.pbImage.Location = New System.Drawing.Point(10, 7)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(40, 40)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 2
        Me.pbImage.TabStop = False
        Me.pbImage.UseTransfarantBackground = False
        '
        'lblIpAddress
        '
        Me.lblIpAddress.AutoSize = True
        Me.lblIpAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblIpAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblIpAddress.Location = New System.Drawing.Point(61, 29)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(62, 17)
        Me.lblIpAddress.TabIndex = 3
        Me.lblIpAddress.Text = "127.0.0.1"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(561, 18)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(82, 17)
        Me.GunaLabel1.TabIndex = 4
        Me.GunaLabel1.Text = "Connected"
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'ClientHomeData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.lblIpAddress)
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ClientHomeData"
        Me.Size = New System.Drawing.Size(669, 56)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pbImage As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblIpAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
End Class
