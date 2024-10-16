Public Class SpecialFolder

    Private FileBrowser As ClientFileAndDirectoryBrowser = Nothing
    Public isSelected As Boolean = False
    Public driveDirectoryCmd As String = Nothing
    Public isDrive As Boolean = False

    Public Sub setFileBrowser(ByVal cfadb As ClientFileAndDirectoryBrowser)
        Me.FileBrowser = cfadb
    End Sub

    Private Sub SpecialFolder_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick, pbImage.MouseClick, lblName.MouseClick

        For Each sf As SpecialFolder In FileBrowser.flpSideNav.Controls
            sf.BackColor = Color.Transparent
            sf.isSelected = False
        Next

        If isDrive Then
            FileBrowser.FlowLayoutPanel1.Controls.Clear()
            FileBrowser.RequestClientDirectories(driveDirectoryCmd)
        Else
            FileBrowser.FlowLayoutPanel1.Controls.Clear()
            FileBrowser.RequestClientSpecialFolders(driveDirectoryCmd)
        End If

        Me.BackColor = Color.FromArgb(153, 209, 255)
        isSelected = True

    End Sub

    Private Sub SpecialFolder_MouseEnter(sender As Object, e As EventArgs) Handles MyBase.MouseEnter, pbImage.MouseEnter, lblName.MouseEnter
        If Not isSelected Then
            Me.BackColor = Color.FromArgb(204, 232, 255)
        End If
    End Sub

    Private Sub SpecialFolder_MouseLeave(sender As Object, e As EventArgs) Handles MyBase.MouseLeave, pbImage.MouseLeave, lblName.MouseLeave
        If Not isSelected Then
            Me.BackColor = Color.Transparent
        End If
    End Sub
End Class
