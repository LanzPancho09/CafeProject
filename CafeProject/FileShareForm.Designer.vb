<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileShareForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FileShareForm))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataPoint1 As System.Windows.Forms.DataVisualization.Charting.DataPoint = New System.Windows.Forms.DataVisualization.Charting.DataPoint(0R, "0,0,0,0,0,0")
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.lblDirectoryAndFileName = New System.Windows.Forms.Label()
        Me.btnClose = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.progFiles = New Guna.UI.WinForms.GunaProgressBar()
        Me.lblFileName = New System.Windows.Forms.Label()
        Me.lblByte = New System.Windows.Forms.Label()
        Me.lblTransferSpeed = New System.Windows.Forms.Label()
        Me.lblPercentage = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tmClientNetworkSpeed = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.pbImage)
        Me.GunaPanel1.Controls.Add(Me.lblDirectoryAndFileName)
        Me.GunaPanel1.Controls.Add(Me.btnClose)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel1.ForeColor = System.Drawing.Color.Black
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(679, 43)
        Me.GunaPanel1.TabIndex = 2
        '
        'pbImage
        '
        Me.pbImage.Image = Global.CafeProject.My.Resources.Resources.Folder
        Me.pbImage.Location = New System.Drawing.Point(13, 11)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(20, 20)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 5
        Me.pbImage.TabStop = False
        '
        'lblDirectoryAndFileName
        '
        Me.lblDirectoryAndFileName.AutoSize = True
        Me.lblDirectoryAndFileName.BackColor = System.Drawing.Color.Transparent
        Me.lblDirectoryAndFileName.ForeColor = System.Drawing.Color.White
        Me.lblDirectoryAndFileName.Location = New System.Drawing.Point(39, 14)
        Me.lblDirectoryAndFileName.Name = "lblDirectoryAndFileName"
        Me.lblDirectoryAndFileName.Size = New System.Drawing.Size(54, 13)
        Me.lblDirectoryAndFileName.TabIndex = 4
        Me.lblDirectoryAndFileName.Text = "File Share"
        '
        'btnClose
        '
        Me.btnClose.Animated = True
        Me.btnClose.AnimationHoverSpeed = 0.07!
        Me.btnClose.AnimationSpeed = 0.03!
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BaseColor = System.Drawing.Color.Transparent
        Me.btnClose.BorderColor = System.Drawing.Color.Black
        Me.btnClose.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClose.CheckedBorderColor = System.Drawing.Color.Black
        Me.btnClose.CheckedForeColor = System.Drawing.Color.White
        Me.btnClose.CheckedImage = CType(resources.GetObject("btnClose.CheckedImage"), System.Drawing.Image)
        Me.btnClose.CheckedLineColor = System.Drawing.Color.DimGray
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FocusedColor = System.Drawing.Color.Empty
        Me.btnClose.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Image = Global.CafeProject.My.Resources.Resources.Close_48px
        Me.btnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.btnClose.ImageSize = New System.Drawing.Size(13, 13)
        Me.btnClose.LineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.Location = New System.Drawing.Point(631, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnClose.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnClose.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClose.OnHoverImage = Nothing
        Me.btnClose.OnHoverLineColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.btnClose.OnPressedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.btnClose.Size = New System.Drawing.Size(48, 43)
        Me.btnClose.TabIndex = 3
        '
        'progFiles
        '
        Me.progFiles.BackColor = System.Drawing.Color.Transparent
        Me.progFiles.BorderColor = System.Drawing.Color.Black
        Me.progFiles.ColorStyle = Guna.UI.WinForms.ColorStyle.[Default]
        Me.progFiles.IdleColor = System.Drawing.Color.GhostWhite
        Me.progFiles.Location = New System.Drawing.Point(72, 303)
        Me.progFiles.Name = "progFiles"
        Me.progFiles.ProgressMaxColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.progFiles.ProgressMinColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.progFiles.Size = New System.Drawing.Size(500, 5)
        Me.progFiles.TabIndex = 3
        '
        'lblFileName
        '
        Me.lblFileName.AutoSize = True
        Me.lblFileName.Location = New System.Drawing.Point(79, 68)
        Me.lblFileName.Name = "lblFileName"
        Me.lblFileName.Size = New System.Drawing.Size(103, 13)
        Me.lblFileName.TabIndex = 4
        Me.lblFileName.Text = "Receiving file name:"
        '
        'lblByte
        '
        Me.lblByte.AutoSize = True
        Me.lblByte.Location = New System.Drawing.Point(79, 86)
        Me.lblByte.Name = "lblByte"
        Me.lblByte.Size = New System.Drawing.Size(92, 13)
        Me.lblByte.TabIndex = 5
        Me.lblByte.Text = "0.00MB / 0.00MB"
        '
        'lblTransferSpeed
        '
        Me.lblTransferSpeed.Location = New System.Drawing.Point(421, 86)
        Me.lblTransferSpeed.Name = "lblTransferSpeed"
        Me.lblTransferSpeed.Size = New System.Drawing.Size(151, 13)
        Me.lblTransferSpeed.TabIndex = 6
        Me.lblTransferSpeed.Text = "Transfer Speed :"
        Me.lblTransferSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPercentage
        '
        Me.lblPercentage.AutoSize = True
        Me.lblPercentage.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lblPercentage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.lblPercentage.Location = New System.Drawing.Point(67, 311)
        Me.lblPercentage.Name = "lblPercentage"
        Me.lblPercentage.Size = New System.Drawing.Size(42, 25)
        Me.lblPercentage.TabIndex = 7
        Me.lblPercentage.Text = "0%"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(72, 104)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 1)
        Me.Panel2.TabIndex = 21
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.IsLabelAutoFit = False
        ChartArea1.AxisX.LabelStyle.Angle = -90
        ChartArea1.AxisX.LabelStyle.Enabled = False
        ChartArea1.AxisX.LabelStyle.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        ChartArea1.AxisX.LineColor = System.Drawing.Color.GhostWhite
        ChartArea1.AxisX.LineWidth = 0
        ChartArea1.AxisX.MajorGrid.LineWidth = 0
        ChartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MajorTickMark.LineWidth = 0
        ChartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorGrid.LineWidth = 0
        ChartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX.MinorTickMark.LineWidth = 0
        ChartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.MajorGrid.LineWidth = 0
        ChartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.MajorTickMark.LineWidth = 0
        ChartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.MinorGrid.LineWidth = 0
        ChartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisX2.MinorTickMark.Size = 0!
        ChartArea1.AxisY.IsLabelAutoFit = False
        ChartArea1.AxisY.LabelStyle.Enabled = False
        ChartArea1.AxisY.LabelStyle.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ChartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.Silver
        ChartArea1.AxisY.LineWidth = 0
        ChartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.GhostWhite
        ChartArea1.AxisY.MajorGrid.LineWidth = 0
        ChartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Transparent
        ChartArea1.AxisY.MajorTickMark.LineWidth = 0
        ChartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Transparent
        ChartArea1.BackColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(72, 111)
        Me.Chart1.Name = "Chart1"
        Series1.BorderWidth = 2
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series1.Color = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(250, Byte), Integer))
        Series1.IsVisibleInLegend = False
        Series1.Legend = "Legend1"
        Series1.Name = "Line"
        DataPoint1.Color = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(215, Byte), Integer), CType(CType(147, Byte), Integer))
        Series1.Points.Add(DataPoint1)
        Series1.ShadowColor = System.Drawing.Color.Black
        Series1.YValuesPerPoint = 6
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(500, 175)
        Me.Chart1.TabIndex = 22
        Me.Chart1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(72, 292)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 5)
        Me.Panel1.TabIndex = 23
        Me.Panel1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 43)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 10)
        Me.Panel3.TabIndex = 24
        '
        'tmClientNetworkSpeed
        '
        '
        'FileShareForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(679, 387)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblPercentage)
        Me.Controls.Add(Me.lblTransferSpeed)
        Me.Controls.Add(Me.lblByte)
        Me.Controls.Add(Me.lblFileName)
        Me.Controls.Add(Me.progFiles)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FileShareForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FileShareForm"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblByte As Label
    Friend WithEvents lblFileName As Label
    Friend WithEvents progFiles As Guna.UI.WinForms.GunaProgressBar
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents lblDirectoryAndFileName As Label
    Friend WithEvents btnClose As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents lblTransferSpeed As Label
    Friend WithEvents lblPercentage As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents tmClientNetworkSpeed As Timer
End Class
