<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Startup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.lblloading = New Guna.UI.WinForms.GunaLabel()
        Me.pgbar = New Guna.UI.WinForms.GunaProgressBar()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(775, 130)
        Me.Panel1.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Controls.Add(Me.GunaLabel2)
        Me.Panel2.Controls.Add(Me.lblloading)
        Me.Panel2.Controls.Add(Me.pgbar)
        Me.Panel2.Controls.Add(Me.GunaPictureBox2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(775, 130)
        Me.Panel2.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.White
        Me.GunaLabel2.Location = New System.Drawing.Point(259, 38)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(362, 30)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "CAFE MANAGEMENT SYSTEM 2022"
        '
        'lblloading
        '
        Me.lblloading.AutoSize = True
        Me.lblloading.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblloading.ForeColor = System.Drawing.Color.White
        Me.lblloading.Location = New System.Drawing.Point(261, 83)
        Me.lblloading.Name = "lblloading"
        Me.lblloading.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblloading.Size = New System.Drawing.Size(54, 13)
        Me.lblloading.TabIndex = 10
        Me.lblloading.Text = "Loading..."
        '
        'pgbar
        '
        Me.pgbar.BackColor = System.Drawing.Color.Transparent
        Me.pgbar.BorderColor = System.Drawing.Color.Black
        Me.pgbar.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.pgbar.IdleColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pgbar.Location = New System.Drawing.Point(261, 74)
        Me.pgbar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pgbar.Maximum = 1
        Me.pgbar.Name = "pgbar"
        Me.pgbar.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgbar.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.pgbar.Radius = 1
        Me.pgbar.Size = New System.Drawing.Size(389, 4)
        Me.pgbar.TabIndex = 9
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.CafeProject.My.Resources.Resources.Fox_Icon
        Me.GunaPictureBox2.Location = New System.Drawing.Point(101, 6)
        Me.GunaPictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(118, 118)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 2
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Silver
        Me.GunaLabel1.Location = New System.Drawing.Point(135, 240)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(48, 17)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "Ver 1.0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Startup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(776, 339)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Startup"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Startup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblloading As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pgbar As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents Timer1 As Timer
End Class
