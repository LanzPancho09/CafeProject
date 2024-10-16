<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChatBoxControl
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
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.lblDateAndTime = New Guna.UI.WinForms.GunaLabel()
        Me.flpMessage = New System.Windows.Forms.FlowLayoutPanel()
        Me.pbImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 0
        Me.GunaElipse1.TargetControl = Me
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblName.Location = New System.Drawing.Point(54, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(136, 16)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateAndTime
        '
        Me.lblDateAndTime.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblDateAndTime.ForeColor = System.Drawing.Color.DarkGray
        Me.lblDateAndTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDateAndTime.Location = New System.Drawing.Point(205, 6)
        Me.lblDateAndTime.Name = "lblDateAndTime"
        Me.lblDateAndTime.Size = New System.Drawing.Size(140, 16)
        Me.lblDateAndTime.TabIndex = 2
        Me.lblDateAndTime.Text = "12/31/18 12:00 am"
        Me.lblDateAndTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblDateAndTime.Visible = False
        '
        'flpMessage
        '
        Me.flpMessage.BackColor = System.Drawing.Color.Transparent
        Me.flpMessage.Location = New System.Drawing.Point(52, 25)
        Me.flpMessage.Name = "flpMessage"
        Me.flpMessage.Size = New System.Drawing.Size(287, 31)
        Me.flpMessage.TabIndex = 3
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Location = New System.Drawing.Point(8, 9)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(40, 40)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 4
        Me.pbImage.TabStop = False
        Me.pbImage.UseTransfarantBackground = False
        '
        'ChatBoxControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblDateAndTime)
        Me.Controls.Add(Me.flpMessage)
        Me.Controls.Add(Me.lblName)
        Me.Name = "ChatBoxControl"
        Me.Size = New System.Drawing.Size(348, 59)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents flpMessage As FlowLayoutPanel
    Friend WithEvents lblDateAndTime As Guna.UI.WinForms.GunaLabel
    Friend WithEvents pbImage As Guna.UI.WinForms.GunaCirclePictureBox
End Class
