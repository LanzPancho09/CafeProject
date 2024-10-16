<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SettingControl))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPort = New Guna.UI.WinForms.GunaTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDefaultFolderLocation = New Guna.UI.WinForms.GunaTextBox()
        Me.btnBrowseFolder = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnStopTime = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(36, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 26)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Server Port"
        '
        'txtPort
        '
        Me.txtPort.BackColor = System.Drawing.Color.Transparent
        Me.txtPort.BaseColor = System.Drawing.Color.White
        Me.txtPort.BorderColor = System.Drawing.Color.Silver
        Me.txtPort.BorderSize = 1
        Me.txtPort.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPort.Enabled = False
        Me.txtPort.FocusedBaseColor = System.Drawing.Color.White
        Me.txtPort.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtPort.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPort.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPort.Location = New System.Drawing.Point(41, 76)
        Me.txtPort.MaxLength = 4
        Me.txtPort.Name = "txtPort"
        Me.txtPort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPort.Radius = 5
        Me.txtPort.Size = New System.Drawing.Size(203, 36)
        Me.txtPort.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Mont Heavy DEMO", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(249, 26)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Receive Folder Location"
        '
        'txtDefaultFolderLocation
        '
        Me.txtDefaultFolderLocation.BackColor = System.Drawing.Color.Transparent
        Me.txtDefaultFolderLocation.BaseColor = System.Drawing.Color.White
        Me.txtDefaultFolderLocation.BorderColor = System.Drawing.Color.Silver
        Me.txtDefaultFolderLocation.BorderSize = 1
        Me.txtDefaultFolderLocation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDefaultFolderLocation.Enabled = False
        Me.txtDefaultFolderLocation.FocusedBaseColor = System.Drawing.Color.White
        Me.txtDefaultFolderLocation.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.txtDefaultFolderLocation.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDefaultFolderLocation.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDefaultFolderLocation.Location = New System.Drawing.Point(41, 175)
        Me.txtDefaultFolderLocation.Name = "txtDefaultFolderLocation"
        Me.txtDefaultFolderLocation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDefaultFolderLocation.Radius = 5
        Me.txtDefaultFolderLocation.Size = New System.Drawing.Size(1044, 36)
        Me.txtDefaultFolderLocation.TabIndex = 9
        '
        'btnBrowseFolder
        '
        Me.btnBrowseFolder.Animated = True
        Me.btnBrowseFolder.AnimationHoverSpeed = 0.07!
        Me.btnBrowseFolder.AnimationSpeed = 0.03!
        Me.btnBrowseFolder.BackColor = System.Drawing.Color.Transparent
        Me.btnBrowseFolder.BaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnBrowseFolder.BorderColor = System.Drawing.Color.Black
        Me.btnBrowseFolder.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnBrowseFolder.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnBrowseFolder.CheckedForeColor = System.Drawing.Color.White
        Me.btnBrowseFolder.CheckedImage = CType(resources.GetObject("btnBrowseFolder.CheckedImage"), System.Drawing.Image)
        Me.btnBrowseFolder.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnBrowseFolder.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnBrowseFolder.FocusedColor = System.Drawing.Color.Empty
        Me.btnBrowseFolder.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseFolder.ForeColor = System.Drawing.Color.White
        Me.btnBrowseFolder.Image = Global.CafeProject.My.Resources.Resources.search_folder
        Me.btnBrowseFolder.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBrowseFolder.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnBrowseFolder.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBrowseFolder.Location = New System.Drawing.Point(1089, 180)
        Me.btnBrowseFolder.Name = "btnBrowseFolder"
        Me.btnBrowseFolder.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.btnBrowseFolder.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnBrowseFolder.OnHoverForeColor = System.Drawing.Color.White
        Me.btnBrowseFolder.OnHoverImage = Global.CafeProject.My.Resources.Resources.search_folder_grey
        Me.btnBrowseFolder.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnBrowseFolder.OnPressedColor = System.Drawing.Color.Black
        Me.btnBrowseFolder.Radius = 3
        Me.btnBrowseFolder.Size = New System.Drawing.Size(35, 29)
        Me.btnBrowseFolder.TabIndex = 10
        Me.btnBrowseFolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnBrowseFolder.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'btnStopTime
        '
        Me.btnStopTime.Animated = True
        Me.btnStopTime.AnimationHoverSpeed = 0.07!
        Me.btnStopTime.AnimationSpeed = 0.03!
        Me.btnStopTime.BackColor = System.Drawing.Color.Transparent
        Me.btnStopTime.BaseColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnStopTime.BorderColor = System.Drawing.Color.Black
        Me.btnStopTime.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnStopTime.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStopTime.CheckedForeColor = System.Drawing.Color.White
        Me.btnStopTime.CheckedImage = CType(resources.GetObject("btnStopTime.CheckedImage"), System.Drawing.Image)
        Me.btnStopTime.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStopTime.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStopTime.FocusedColor = System.Drawing.Color.Empty
        Me.btnStopTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopTime.ForeColor = System.Drawing.Color.White
        Me.btnStopTime.Image = Nothing
        Me.btnStopTime.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStopTime.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStopTime.Location = New System.Drawing.Point(250, 79)
        Me.btnStopTime.Name = "btnStopTime"
        Me.btnStopTime.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnStopTime.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStopTime.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStopTime.OnHoverImage = Nothing
        Me.btnStopTime.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStopTime.OnPressedColor = System.Drawing.Color.Black
        Me.btnStopTime.Radius = 3
        Me.btnStopTime.Size = New System.Drawing.Size(96, 29)
        Me.btnStopTime.TabIndex = 7
        Me.btnStopTime.Text = "Change"
        Me.btnStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStopTime.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'SettingControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.btnBrowseFolder)
        Me.Controls.Add(Me.txtDefaultFolderLocation)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStopTime)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.Label9)
        Me.Name = "SettingControl"
        Me.Size = New System.Drawing.Size(1130, 820)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents txtPort As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnStopTime As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDefaultFolderLocation As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents btnBrowseFolder As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
