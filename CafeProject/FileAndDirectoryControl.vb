Imports System.Drawing
Imports System.Net.Sockets

Public Class FileAndDirectoryControl

    Private FileBrowser As ClientFileAndDirectoryBrowser = Nothing
    Public path As String = Nothing
    Public filename As String = Nothing
    Public isDirectory As Boolean = False
    Public selected As Boolean = False
    Public DirSize As Long = 0

    Public Sub setFileBrowser(ByVal cfadb As ClientFileAndDirectoryBrowser)
        Me.FileBrowser = cfadb
    End Sub

    Private Sub FileAndDirectoryControl_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, pbImage.MouseClick, lblDirectoryAndFileName.MouseClick

        For Each control As FileAndDirectoryControl In FileBrowser.FlowLayoutPanel1.Controls
            control.BackColor = Color.FromArgb(250, 250, 251)
            control.selected = False
        Next

        FileBrowser.ViewPath(path)

        Me.BackColor = Color.FromArgb(204, 232, 255)
        selected = True

    End Sub

    Private Sub FileAndDirectoryControl_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDoubleClick, pbImage.MouseDoubleClick, lblDirectoryAndFileName.DoubleClick
        If isDirectory Then
            FileBrowser.RequestClientDirectories(path)
        End If
    End Sub

    Private Sub FileAndDirectoryControl_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, pbImage.MouseEnter, lblDirectoryAndFileName.MouseEnter
        If Not selected Then
            Me.BackColor = Color.FromArgb(229, 243, 255)
        End If
    End Sub

    Private Sub FileAndDirectoryControl_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, pbImage.MouseLeave, lblDirectoryAndFileName.MouseLeave
        If Not selected Then
            Me.BackColor = Color.FromArgb(250, 250, 251)
        End If
    End Sub

End Class
