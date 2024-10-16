<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VouchControl
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VouchControl))
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnDeleteVouch = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblVoucherID = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblUsername
        '
        Me.lblUsername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblUsername.Location = New System.Drawing.Point(273, 9)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(168, 15)
        Me.lblUsername.TabIndex = 8
        Me.lblUsername.Text = "Username"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblPassword.Location = New System.Drawing.Point(515, 9)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(168, 15)
        Me.lblPassword.TabIndex = 9
        Me.lblPassword.Text = "Password"
        Me.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDeleteVouch
        '
        Me.btnDeleteVouch.Animated = True
        Me.btnDeleteVouch.AnimationHoverSpeed = 0.07!
        Me.btnDeleteVouch.AnimationSpeed = 0.03!
        Me.btnDeleteVouch.BackColor = System.Drawing.Color.Transparent
        Me.btnDeleteVouch.BaseColor = System.Drawing.Color.Transparent
        Me.btnDeleteVouch.BorderColor = System.Drawing.Color.Transparent
        Me.btnDeleteVouch.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnDeleteVouch.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnDeleteVouch.CheckedForeColor = System.Drawing.Color.White
        Me.btnDeleteVouch.CheckedImage = CType(resources.GetObject("btnDeleteVouch.CheckedImage"), System.Drawing.Image)
        Me.btnDeleteVouch.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnDeleteVouch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDeleteVouch.FocusedColor = System.Drawing.Color.Empty
        Me.btnDeleteVouch.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteVouch.ForeColor = System.Drawing.Color.White
        Me.btnDeleteVouch.Image = Global.CafeProject.My.Resources.Resources.cancel_48px
        Me.btnDeleteVouch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeleteVouch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnDeleteVouch.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDeleteVouch.Location = New System.Drawing.Point(947, 0)
        Me.btnDeleteVouch.Name = "btnDeleteVouch"
        Me.btnDeleteVouch.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnDeleteVouch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnDeleteVouch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnDeleteVouch.OnHoverImage = Global.CafeProject.My.Resources.Resources.cancel_red
        Me.btnDeleteVouch.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnDeleteVouch.OnPressedColor = System.Drawing.Color.Black
        Me.btnDeleteVouch.Radius = 3
        Me.btnDeleteVouch.Size = New System.Drawing.Size(35, 35)
        Me.btnDeleteVouch.TabIndex = 10
        Me.btnDeleteVouch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnDeleteVouch.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.ClearTypeGridFit
        Me.ToolTip1.SetToolTip(Me.btnDeleteVouch, "Delete Voucher")
        '
        'lblTime
        '
        Me.lblTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTime.Location = New System.Drawing.Point(713, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(168, 15)
        Me.lblTime.TabIndex = 11
        Me.lblTime.Text = "00:00:00"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblVoucherID
        '
        Me.lblVoucherID.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVoucherID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblVoucherID.Location = New System.Drawing.Point(47, 9)
        Me.lblVoucherID.Name = "lblVoucherID"
        Me.lblVoucherID.Size = New System.Drawing.Size(168, 15)
        Me.lblVoucherID.TabIndex = 12
        Me.lblVoucherID.Text = "Vouch Id"
        Me.lblVoucherID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VouchControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblVoucherID)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.btnDeleteVouch)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lblUsername)
        Me.Name = "VouchControl"
        Me.Size = New System.Drawing.Size(1050, 35)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblUsername As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents btnDeleteVouch As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblTime As Label
    Friend WithEvents lblVoucherID As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
