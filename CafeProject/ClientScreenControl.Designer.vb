<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ClientScreenControl
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.pbScreen = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'lblName
        '
        Me.lblName.BackColor = System.Drawing.Color.DimGray
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(6, 133)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(125, 18)
        Me.lblName.TabIndex = 8
        Me.lblName.Text = "Label1"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pbScreen
        '
        Me.pbScreen.BackColor = System.Drawing.Color.Black
        Me.pbScreen.BaseColor = System.Drawing.Color.White
        Me.pbScreen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbScreen.Location = New System.Drawing.Point(0, 0)
        Me.pbScreen.Name = "pbScreen"
        Me.pbScreen.Size = New System.Drawing.Size(288, 154)
        Me.pbScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbScreen.TabIndex = 7
        Me.pbScreen.TabStop = False
        '
        'ClientScreenControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbScreen)
        Me.Name = "ClientScreenControl"
        Me.Size = New System.Drawing.Size(288, 154)
        CType(Me.pbScreen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pbScreen As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents lblName As Label
End Class
