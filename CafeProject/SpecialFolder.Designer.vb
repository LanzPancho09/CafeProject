<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SpecialFolder
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
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.pbImage = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lblName.Location = New System.Drawing.Point(39, 5)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(80, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Special Folder"
        Me.lblName.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Image = Global.CafeProject.My.Resources.Resources.Folder
        Me.pbImage.Location = New System.Drawing.Point(8, 0)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(25, 25)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 0
        Me.pbImage.TabStop = False
        '
        'SpecialFolder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbImage)
        Me.Name = "SpecialFolder"
        Me.Size = New System.Drawing.Size(163, 25)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbImage As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
End Class
