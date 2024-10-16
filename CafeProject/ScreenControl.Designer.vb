<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScreenControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScreenControl))
        Me.pbClientScreen = New System.Windows.Forms.PictureBox()
        Me.Thrd_RemoteControl = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmStatus = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniScreenshot = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniShareEveryone = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniLockComputer = New System.Windows.Forms.ToolStripMenuItem()
        Me.mniDisableControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlStatus = New System.Windows.Forms.Panel()
        Me.lblNetworkSpeed = New System.Windows.Forms.Label()
        Me.lblFPS = New System.Windows.Forms.Label()
        CType(Me.pbClientScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.pnlStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'pbClientScreen
        '
        Me.pbClientScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbClientScreen.Name = "pbClientScreen"
        Me.pbClientScreen.Size = New System.Drawing.Size(770, 400)
        Me.pbClientScreen.TabIndex = 0
        Me.pbClientScreen.TabStop = False
        '
        'Thrd_RemoteControl
        '
        Me.Thrd_RemoteControl.WorkerSupportsCancellation = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pbClientScreen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 453)
        Me.Panel1.TabIndex = 1
        '
        'tmStatus
        '
        Me.tmStatus.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.ControlsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(840, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniScreenshot, Me.mniShareEveryone})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'mniScreenshot
        '
        Me.mniScreenshot.Name = "mniScreenshot"
        Me.mniScreenshot.Size = New System.Drawing.Size(168, 22)
        Me.mniScreenshot.Text = "Take Screenshot"
        '
        'mniShareEveryone
        '
        Me.mniShareEveryone.Name = "mniShareEveryone"
        Me.mniShareEveryone.Size = New System.Drawing.Size(168, 22)
        Me.mniShareEveryone.Text = "Share to Everyone"
        '
        'ControlsToolStripMenuItem
        '
        Me.ControlsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mniLockComputer, Me.mniDisableControl})
        Me.ControlsToolStripMenuItem.Name = "ControlsToolStripMenuItem"
        Me.ControlsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ControlsToolStripMenuItem.Text = "Controls"
        '
        'mniLockComputer
        '
        Me.mniLockComputer.Name = "mniLockComputer"
        Me.mniLockComputer.Size = New System.Drawing.Size(156, 22)
        Me.mniLockComputer.Text = "Lock Computer"
        '
        'mniDisableControl
        '
        Me.mniDisableControl.Name = "mniDisableControl"
        Me.mniDisableControl.Size = New System.Drawing.Size(156, 22)
        Me.mniDisableControl.Text = "Disable Control"
        '
        'pnlStatus
        '
        Me.pnlStatus.Controls.Add(Me.lblNetworkSpeed)
        Me.pnlStatus.Controls.Add(Me.lblFPS)
        Me.pnlStatus.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlStatus.Location = New System.Drawing.Point(0, 477)
        Me.pnlStatus.Name = "pnlStatus"
        Me.pnlStatus.Size = New System.Drawing.Size(840, 20)
        Me.pnlStatus.TabIndex = 3
        '
        'lblNetworkSpeed
        '
        Me.lblNetworkSpeed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNetworkSpeed.Location = New System.Drawing.Point(590, 3)
        Me.lblNetworkSpeed.Name = "lblNetworkSpeed"
        Me.lblNetworkSpeed.Size = New System.Drawing.Size(166, 13)
        Me.lblNetworkSpeed.TabIndex = 1
        Me.lblNetworkSpeed.Text = "Network Speed: 0Kbp/s"
        Me.lblNetworkSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFPS
        '
        Me.lblFPS.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFPS.Location = New System.Drawing.Point(762, 3)
        Me.lblFPS.Name = "lblFPS"
        Me.lblFPS.Size = New System.Drawing.Size(66, 13)
        Me.lblFPS.TabIndex = 0
        Me.lblFPS.Text = "FPS: 0000"
        Me.lblFPS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ScreenControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 497)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.pnlStatus)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScreenControl"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScreenControl"
        CType(Me.pbClientScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.pnlStatus.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbClientScreen As PictureBox
    Friend WithEvents Thrd_RemoteControl As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tmStatus As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mniScreenshot As ToolStripMenuItem
    Friend WithEvents mniShareEveryone As ToolStripMenuItem
    Friend WithEvents ControlsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mniLockComputer As ToolStripMenuItem
    Friend WithEvents mniDisableControl As ToolStripMenuItem
    Friend WithEvents pnlStatus As Panel
    Friend WithEvents lblNetworkSpeed As Label
    Friend WithEvents lblFPS As Label
End Class
