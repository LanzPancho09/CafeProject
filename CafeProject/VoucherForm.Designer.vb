<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VoucherForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.nudHour = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudMinute = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nudSecond = New System.Windows.Forms.NumericUpDown()
        Me.btnCreateVouch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudAccountNumber = New System.Windows.Forms.NumericUpDown()
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudAccountNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'nudHour
        '
        Me.nudHour.Location = New System.Drawing.Point(26, 38)
        Me.nudHour.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudHour.Name = "nudHour"
        Me.nudHour.Size = New System.Drawing.Size(48, 20)
        Me.nudHour.TabIndex = 0
        Me.nudHour.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Hour/s"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Minute/s"
        '
        'nudMinute
        '
        Me.nudMinute.Location = New System.Drawing.Point(114, 38)
        Me.nudMinute.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudMinute.Name = "nudMinute"
        Me.nudMinute.Size = New System.Drawing.Size(48, 20)
        Me.nudMinute.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Second/s"
        '
        'nudSecond
        '
        Me.nudSecond.Location = New System.Drawing.Point(203, 38)
        Me.nudSecond.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSecond.Name = "nudSecond"
        Me.nudSecond.Size = New System.Drawing.Size(48, 20)
        Me.nudSecond.TabIndex = 4
        '
        'btnCreateVouch
        '
        Me.btnCreateVouch.Location = New System.Drawing.Point(181, 143)
        Me.btnCreateVouch.Name = "btnCreateVouch"
        Me.btnCreateVouch.Size = New System.Drawing.Size(104, 23)
        Me.btnCreateVouch.TabIndex = 6
        Me.btnCreateVouch.Text = "Create Vouch"
        Me.btnCreateVouch.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(150, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "How many account to create?"
        '
        'nudAccountNumber
        '
        Me.nudAccountNumber.Location = New System.Drawing.Point(26, 97)
        Me.nudAccountNumber.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.nudAccountNumber.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudAccountNumber.Name = "nudAccountNumber"
        Me.nudAccountNumber.Size = New System.Drawing.Size(225, 20)
        Me.nudAccountNumber.TabIndex = 8
        Me.nudAccountNumber.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'VoucherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 178)
        Me.Controls.Add(Me.nudAccountNumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCreateVouch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.nudSecond)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.nudMinute)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudHour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "VoucherForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Vouchers"
        CType(Me.nudHour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinute, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSecond, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudAccountNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents nudHour As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents nudMinute As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents nudSecond As NumericUpDown
    Friend WithEvents btnCreateVouch As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents nudAccountNumber As NumericUpDown
End Class
