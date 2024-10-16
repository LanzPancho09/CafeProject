<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientTimeControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientTimeControl))
        Me.lblName = New Guna.UI.WinForms.GunaLabel()
        Me.lblIpAddress = New Guna.UI.WinForms.GunaLabel()
        Me.lblStart = New Guna.UI.WinForms.GunaLabel()
        Me.lblEnd = New Guna.UI.WinForms.GunaLabel()
        Me.lblTimeRemaining = New Guna.UI.WinForms.GunaLabel()
        Me.lblComputerNo = New Guna.UI.WinForms.GunaLabel()
        Me.btnExtend = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnStopTime = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.pbImage = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoEllipsis = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblName.Location = New System.Drawing.Point(126, 11)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(123, 18)
        Me.lblName.TabIndex = 4
        Me.lblName.Text = "Username"
        '
        'lblIpAddress
        '
        Me.lblIpAddress.AutoSize = True
        Me.lblIpAddress.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIpAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblIpAddress.Location = New System.Drawing.Point(291, 11)
        Me.lblIpAddress.Name = "lblIpAddress"
        Me.lblIpAddress.Size = New System.Drawing.Size(59, 17)
        Me.lblIpAddress.TabIndex = 7
        Me.lblIpAddress.Text = "127.0.0.1"
        Me.lblIpAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblStart.Location = New System.Drawing.Point(497, 11)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(70, 17)
        Me.lblStart.TabIndex = 8
        Me.lblStart.Text = "00:00:00 --"
        Me.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblEnd
        '
        Me.lblEnd.AutoSize = True
        Me.lblEnd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnd.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblEnd.Location = New System.Drawing.Point(671, 11)
        Me.lblEnd.Name = "lblEnd"
        Me.lblEnd.Size = New System.Drawing.Size(70, 17)
        Me.lblEnd.TabIndex = 9
        Me.lblEnd.Text = "00:00:00 --"
        Me.lblEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.ForeColor = System.Drawing.Color.FromArgb(CType(CType(29, Byte), Integer), CType(CType(162, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(853, 11)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(56, 17)
        Me.lblTimeRemaining.TabIndex = 10
        Me.lblTimeRemaining.Text = "VACANT"
        Me.lblTimeRemaining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerNo
        '
        Me.lblComputerNo.AutoEllipsis = True
        Me.lblComputerNo.BackColor = System.Drawing.Color.Transparent
        Me.lblComputerNo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblComputerNo.Location = New System.Drawing.Point(51, 10)
        Me.lblComputerNo.Name = "lblComputerNo"
        Me.lblComputerNo.Size = New System.Drawing.Size(39, 18)
        Me.lblComputerNo.TabIndex = 11
        Me.lblComputerNo.Text = "No"
        Me.lblComputerNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExtend
        '
        Me.btnExtend.Animated = True
        Me.btnExtend.AnimationHoverSpeed = 0.07!
        Me.btnExtend.AnimationSpeed = 0.03!
        Me.btnExtend.BackColor = System.Drawing.Color.Transparent
        Me.btnExtend.BaseColor = System.Drawing.Color.Transparent
        Me.btnExtend.BorderColor = System.Drawing.Color.Black
        Me.btnExtend.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnExtend.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnExtend.CheckedForeColor = System.Drawing.Color.White
        Me.btnExtend.CheckedImage = CType(resources.GetObject("btnExtend.CheckedImage"), System.Drawing.Image)
        Me.btnExtend.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnExtend.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExtend.FocusedColor = System.Drawing.Color.Empty
        Me.btnExtend.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExtend.ForeColor = System.Drawing.Color.White
        Me.btnExtend.Image = Global.CafeProject.My.Resources.Resources.Extend_Silver
        Me.btnExtend.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExtend.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnExtend.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnExtend.Location = New System.Drawing.Point(990, 0)
        Me.btnExtend.Name = "btnExtend"
        Me.btnExtend.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnExtend.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnExtend.OnHoverForeColor = System.Drawing.Color.White
        Me.btnExtend.OnHoverImage = Global.CafeProject.My.Resources.Resources.Extend
        Me.btnExtend.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnExtend.OnPressedColor = System.Drawing.Color.Black
        Me.btnExtend.Radius = 3
        Me.btnExtend.Size = New System.Drawing.Size(40, 40)
        Me.btnExtend.TabIndex = 6
        Me.btnExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnExtend.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.btnExtend, "Extend")
        '
        'btnStopTime
        '
        Me.btnStopTime.Animated = True
        Me.btnStopTime.AnimationHoverSpeed = 0.07!
        Me.btnStopTime.AnimationSpeed = 0.03!
        Me.btnStopTime.BackColor = System.Drawing.Color.Transparent
        Me.btnStopTime.BaseColor = System.Drawing.Color.Transparent
        Me.btnStopTime.BorderColor = System.Drawing.Color.Transparent
        Me.btnStopTime.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnStopTime.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnStopTime.CheckedForeColor = System.Drawing.Color.White
        Me.btnStopTime.CheckedImage = CType(resources.GetObject("btnStopTime.CheckedImage"), System.Drawing.Image)
        Me.btnStopTime.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnStopTime.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnStopTime.FocusedColor = System.Drawing.Color.Empty
        Me.btnStopTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStopTime.ForeColor = System.Drawing.Color.White
        Me.btnStopTime.Image = Global.CafeProject.My.Resources.Resources.Stoptime_Silver
        Me.btnStopTime.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStopTime.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnStopTime.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStopTime.Location = New System.Drawing.Point(1036, 0)
        Me.btnStopTime.Name = "btnStopTime"
        Me.btnStopTime.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnStopTime.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnStopTime.OnHoverForeColor = System.Drawing.Color.White
        Me.btnStopTime.OnHoverImage = Global.CafeProject.My.Resources.Resources.stoptime
        Me.btnStopTime.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnStopTime.OnPressedColor = System.Drawing.Color.Black
        Me.btnStopTime.Radius = 3
        Me.btnStopTime.Size = New System.Drawing.Size(40, 40)
        Me.btnStopTime.TabIndex = 5
        Me.btnStopTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnStopTime.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.btnStopTime, "Stoptime")
        '
        'pbImage
        '
        Me.pbImage.BaseColor = System.Drawing.Color.White
        Me.pbImage.Image = CType(resources.GetObject("pbImage.Image"), System.Drawing.Image)
        Me.pbImage.Location = New System.Drawing.Point(5, 5)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(30, 30)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbImage.TabIndex = 3
        Me.pbImage.TabStop = False
        Me.pbImage.UseTransfarantBackground = False
        '
        'ClientTimeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblComputerNo)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.lblEnd)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblIpAddress)
        Me.Controls.Add(Me.btnExtend)
        Me.Controls.Add(Me.btnStopTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.pbImage)
        Me.Name = "ClientTimeControl"
        Me.Size = New System.Drawing.Size(1092, 40)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pbImage As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents lblName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnExtend As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnStopTime As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblIpAddress As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblStart As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblTimeRemaining As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblEnd As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblComputerNo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents ToolTip1 As ToolTip
End Class
