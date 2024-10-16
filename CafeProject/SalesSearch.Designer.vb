<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesSearch
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SalesSearch))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnDateSearch = New System.Windows.Forms.Button()
        Me.dtpFrom = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.dtpTo = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(38, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "From:"
        '
        'btnDateSearch
        '
        Me.btnDateSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDateSearch.Location = New System.Drawing.Point(231, 169)
        Me.btnDateSearch.Name = "btnDateSearch"
        Me.btnDateSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnDateSearch.TabIndex = 2
        Me.btnDateSearch.Text = "Search"
        Me.btnDateSearch.UseVisualStyleBackColor = True
        '
        'dtpFrom
        '
        Me.dtpFrom.BaseColor = System.Drawing.Color.White
        Me.dtpFrom.BorderColor = System.Drawing.Color.Silver
        Me.dtpFrom.CustomFormat = Nothing
        Me.dtpFrom.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFrom.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpFrom.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpFrom.Location = New System.Drawing.Point(41, 50)
        Me.dtpFrom.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpFrom.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpFrom.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpFrom.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpFrom.OnPressedColor = System.Drawing.Color.Black
        Me.dtpFrom.Size = New System.Drawing.Size(223, 30)
        Me.dtpFrom.TabIndex = 5
        Me.dtpFrom.Text = "Friday, March 4, 2022"
        Me.dtpFrom.Value = New Date(2022, 3, 4, 23, 5, 11, 548)
        '
        'dtpTo
        '
        Me.dtpTo.BaseColor = System.Drawing.Color.White
        Me.dtpTo.BorderColor = System.Drawing.Color.Silver
        Me.dtpTo.CustomFormat = Nothing
        Me.dtpTo.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpTo.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.dtpTo.ForeColor = System.Drawing.Color.Black
        Me.dtpTo.Location = New System.Drawing.Point(41, 109)
        Me.dtpTo.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpTo.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.OnHoverBaseColor = System.Drawing.Color.White
        Me.dtpTo.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTo.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dtpTo.OnPressedColor = System.Drawing.Color.Black
        Me.dtpTo.Size = New System.Drawing.Size(223, 30)
        Me.dtpTo.TabIndex = 6
        Me.dtpTo.Text = "Friday, March 4, 2022"
        Me.dtpTo.Value = New Date(2022, 3, 4, 23, 5, 11, 548)
        '
        'SalesSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 204)
        Me.Controls.Add(Me.dtpTo)
        Me.Controls.Add(Me.dtpFrom)
        Me.Controls.Add(Me.btnDateSearch)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SalesSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Date Search"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnDateSearch As Button
    Friend WithEvents dtpFrom As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents dtpTo As Guna.UI.WinForms.GunaDateTimePicker
End Class
