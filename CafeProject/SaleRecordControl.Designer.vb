<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaleRecordControl
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
        Me.lblTimeAmmount = New Guna.UI.WinForms.GunaLabel()
        Me.lblAction = New Guna.UI.WinForms.GunaLabel()
        Me.lblComputerNumber = New Guna.UI.WinForms.GunaLabel()
        Me.lblCustomerName = New Guna.UI.WinForms.GunaLabel()
        Me.lblCustomerID = New Guna.UI.WinForms.GunaLabel()
        Me.lblProfit = New Guna.UI.WinForms.GunaLabel()
        Me.lblDate = New Guna.UI.WinForms.GunaLabel()
        Me.SuspendLayout()
        '
        'lblTimeAmmount
        '
        Me.lblTimeAmmount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeAmmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblTimeAmmount.Location = New System.Drawing.Point(654, 9)
        Me.lblTimeAmmount.Name = "lblTimeAmmount"
        Me.lblTimeAmmount.Size = New System.Drawing.Size(160, 16)
        Me.lblTimeAmmount.TabIndex = 11
        Me.lblTimeAmmount.Text = "TIME AMMOUNT"
        Me.lblTimeAmmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAction
        '
        Me.lblAction.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblAction.Location = New System.Drawing.Point(976, 9)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(101, 16)
        Me.lblAction.TabIndex = 10
        Me.lblAction.Text = "ACTION"
        Me.lblAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblComputerNumber
        '
        Me.lblComputerNumber.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComputerNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblComputerNumber.Location = New System.Drawing.Point(340, 9)
        Me.lblComputerNumber.Name = "lblComputerNumber"
        Me.lblComputerNumber.Size = New System.Drawing.Size(128, 16)
        Me.lblComputerNumber.TabIndex = 9
        Me.lblComputerNumber.Text = "COMPUTER NUMBER"
        Me.lblComputerNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerName
        '
        Me.lblCustomerName.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCustomerName.Location = New System.Drawing.Point(118, 9)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(216, 16)
        Me.lblCustomerName.TabIndex = 8
        Me.lblCustomerName.Text = "CUSTOMER NAME"
        Me.lblCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCustomerID
        '
        Me.lblCustomerID.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblCustomerID.Location = New System.Drawing.Point(18, 9)
        Me.lblCustomerID.Name = "lblCustomerID"
        Me.lblCustomerID.Size = New System.Drawing.Size(94, 16)
        Me.lblCustomerID.TabIndex = 7
        Me.lblCustomerID.Text = "CUSTOMER ID"
        Me.lblCustomerID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblProfit
        '
        Me.lblProfit.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblProfit.Location = New System.Drawing.Point(820, 9)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(150, 16)
        Me.lblProfit.TabIndex = 12
        Me.lblProfit.Text = "PROFIT"
        Me.lblProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDate
        '
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.lblDate.Location = New System.Drawing.Point(510, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(128, 16)
        Me.lblDate.TabIndex = 13
        Me.lblDate.Text = "DATE"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SaleRecordControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblProfit)
        Me.Controls.Add(Me.lblTimeAmmount)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.lblComputerNumber)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.lblCustomerID)
        Me.Name = "SaleRecordControl"
        Me.Size = New System.Drawing.Size(1116, 35)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblTimeAmmount As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblAction As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblComputerNumber As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCustomerName As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblCustomerID As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblProfit As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblDate As Guna.UI.WinForms.GunaLabel
End Class
