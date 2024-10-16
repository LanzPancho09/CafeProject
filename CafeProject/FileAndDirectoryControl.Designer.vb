<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileAndDirectoryControl
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
        Me.lblDirectoryAndFileName = New System.Windows.Forms.Label()
        Me.ContextMenuFile = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RenameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbImage = New System.Windows.Forms.PictureBox()
        Me.ContextMenuFile.SuspendLayout()
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblDirectoryAndFileName
        '
        Me.lblDirectoryAndFileName.AutoSize = True
        Me.lblDirectoryAndFileName.Location = New System.Drawing.Point(39, 9)
        Me.lblDirectoryAndFileName.Name = "lblDirectoryAndFileName"
        Me.lblDirectoryAndFileName.Size = New System.Drawing.Size(23, 13)
        Me.lblDirectoryAndFileName.TabIndex = 0
        Me.lblDirectoryAndFileName.Text = "File"
        '
        'ContextMenuFile
        '
        Me.ContextMenuFile.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.RenameToolStripMenuItem})
        Me.ContextMenuFile.Name = "ContextMenuStrip1"
        Me.ContextMenuFile.Size = New System.Drawing.Size(118, 70)
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RenameToolStripMenuItem
        '
        Me.RenameToolStripMenuItem.Name = "RenameToolStripMenuItem"
        Me.RenameToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.RenameToolStripMenuItem.Text = "Rename"
        '
        'pbImage
        '
        Me.pbImage.Image = Global.CafeProject.My.Resources.Resources.Folder
        Me.pbImage.Location = New System.Drawing.Point(13, 6)
        Me.pbImage.Name = "pbImage"
        Me.pbImage.Size = New System.Drawing.Size(20, 20)
        Me.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbImage.TabIndex = 1
        Me.pbImage.TabStop = False
        '
        'FileAndDirectoryControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.pbImage)
        Me.Controls.Add(Me.lblDirectoryAndFileName)
        Me.Name = "FileAndDirectoryControl"
        Me.Size = New System.Drawing.Size(708, 31)
        Me.ContextMenuFile.ResumeLayout(False)
        CType(Me.pbImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDirectoryAndFileName As Label
    Friend WithEvents pbImage As PictureBox
    Friend WithEvents ContextMenuFile As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RenameToolStripMenuItem As ToolStripMenuItem
End Class
