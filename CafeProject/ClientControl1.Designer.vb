<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientControl1
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnlockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SystemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShutDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblUsername = New Guna.UI.WinForms.GunaLabel()
        Me.lblIpAddress = New Guna.UI.WinForms.GunaLabel()
        Me.pbStatus = New Guna.UI.WinForms.GunaPictureBox()
        Me.pbProfile = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.SleepToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LockToolStripMenuItem, Me.UnlockToolStripMenuItem, Me.GetFileToolStripMenuItem, Me.SystemToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 114)
        '
        'LockToolStripMenuItem
        '
        Me.LockToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.lock_48
        Me.LockToolStripMenuItem.Name = "LockToolStripMenuItem"
        Me.LockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.LockToolStripMenuItem.Text = "Lock"
        '
        'UnlockToolStripMenuItem
        '
        Me.UnlockToolStripMenuItem.Enabled = False
        Me.UnlockToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.unlock
        Me.UnlockToolStripMenuItem.Name = "UnlockToolStripMenuItem"
        Me.UnlockToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UnlockToolStripMenuItem.Text = "Unlock"
        '
        'GetFileToolStripMenuItem
        '
        Me.GetFileToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.Folder
        Me.GetFileToolStripMenuItem.Name = "GetFileToolStripMenuItem"
        Me.GetFileToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.GetFileToolStripMenuItem.Text = "Get File"
        '
        'SystemToolStripMenuItem
        '
        Me.SystemToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShutDownToolStripMenuItem, Me.RestartToolStripMenuItem, Me.SleepToolStripMenuItem})
        Me.SystemToolStripMenuItem.Name = "SystemToolStripMenuItem"
        Me.SystemToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SystemToolStripMenuItem.Text = "System"
        '
        'ShutDownToolStripMenuItem
        '
        Me.ShutDownToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.shutdown_48px
        Me.ShutDownToolStripMenuItem.Name = "ShutDownToolStripMenuItem"
        Me.ShutDownToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ShutDownToolStripMenuItem.Text = "Shut Down"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.restart_48px
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(133, 22)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(66, 32)
        Me.lblUsername.TabIndex = 2
        Me.lblUsername.Text = "PC 1"
        '
        'lblIpAddress
        '
        Me.lblIpAddress.AutoSize = True
        Me.lblIpAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpAddress.ForeColor = System.Drawing.Color.Silver
        Me.lblIpAddress.Location = New System.Drawing.Point(136, 55)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(62, 17)
        Me.lblIpAddress.TabIndex = 3
        Me.lblIpAddress.Text = "127.0.0.1"
        '
        'pbStatus
        '
        Me.pbStatus.BaseColor = System.Drawing.Color.White
        Me.pbStatus.Image = Global.CafeProject.My.Resources.Resources.online
        Me.pbStatus.Location = New System.Drawing.Point(999, 3)
        Me.pbStatus.Name = "pbStatus"
        Me.pbStatus.Size = New System.Drawing.Size(15, 15)
        Me.pbStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbStatus.TabIndex = 6
        Me.pbStatus.TabStop = False
        '
        'pbProfile
        '
        Me.pbProfile.BaseColor = System.Drawing.Color.White
        Me.pbProfile.Image = Global.CafeProject.My.Resources.Resources.user
        Me.pbProfile.Location = New System.Drawing.Point(27, 3)
        Me.pbProfile.Name = "pbProfile"
        Me.pbProfile.Size = New System.Drawing.Size(90, 90)
        Me.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProfile.TabIndex = 1
        Me.pbProfile.TabStop = False
        Me.pbProfile.UseTransfarantBackground = False
        '
        'SleepToolStripMenuItem
        '
        Me.SleepToolStripMenuItem.Image = Global.CafeProject.My.Resources.Resources.hibernate_48px
        Me.SleepToolStripMenuItem.Name = "SleepToolStripMenuItem"
        Me.SleepToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SleepToolStripMenuItem.Text = "Sleep"
        '
        'ClientControl1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.pbStatus)
        Me.Controls.Add(Me.lblIpAddress)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.pbProfile)
        Me.Name = "ClientControl1"
        Me.Size = New System.Drawing.Size(1017, 97)
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.pbStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProfile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnlockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbProfile As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblIpAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblUsername As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pbStatus As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GetFileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SystemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ShutDownToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SleepToolStripMenuItem As ToolStripMenuItem
End Class
