<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FileDataControl
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
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.lblFileName = New Guna.UI.WinForms.GunaLabel()
        Me.lblFileSize = New Guna.UI.WinForms.GunaLabel()
        Me.pbFileType = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.pbFileType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblFileName
        '
        Me.lblFileName.AutoEllipsis = True
        Me.lblFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblFileName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblFileName.Location = New System.Drawing.Point(62, 16)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(123, 18)
        Me.lblFileName.TabIndex = 5
        Me.lblFileName.Text = "soft.exe"
        '
        'lblFileSize
        '
        Me.lblFileSize.AutoEllipsis = True
        Me.lblFileSize.BackColor = System.Drawing.Color.Transparent
        Me.lblFileSize.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFileSize.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblFileSize.Location = New System.Drawing.Point(216, 14)
        Me.lblFileSize.Name = "lblFileSize"
        Me.lblFileSize.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblFileSize.Size = New System.Drawing.Size(88, 18)
        Me.lblFileSize.TabIndex = 6
        Me.lblFileSize.Text = "1.0 Gb"
        Me.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pbFileType
        '
        Me.pbFileType.BaseColor = System.Drawing.Color.White
        Me.pbFileType.Image = Global.CafeProject.My.Resources.Resources.Image_file
        Me.pbFileType.Location = New System.Drawing.Point(18, 8)
        Me.pbFileType.Name = "pbFileType"
        Me.pbFileType.Size = New System.Drawing.Size(33, 31)
        Me.pbFileType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFileType.TabIndex = 0
        Me.pbFileType.TabStop = False
        '
        'FileDataControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblFileSize)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.pbFileType)
        Me.Name = "FileDataControl"
        Me.Size = New System.Drawing.Size(360, 51)
        CType(Me.pbFileType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents pbFileType As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents lblFileSize As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblFileName As Guna.UI.WinForms.GunaLabel
End Class
