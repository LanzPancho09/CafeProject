Imports System.Net.Sockets

Public Class ClientFileAndDirectoryBrowser

    Private control As ClientControl1 = Nothing
    Public Property currentDirectory As String = Nothing

    Public Sub setControl(ByVal c As ClientControl1)
        Me.control = c
    End Sub

    Private Sub ClientFileAndDirectoryBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel3, Color.Black, 30, 3, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        loadSpecialFolders()
        flpSideNav.Margin = New Padding(0, 0, 0, 0)

    End Sub

    Private Sub loadSpecialFolders()

        Dim img() As Bitmap = {My.Resources.document, My.Resources.download, My.Resources.musicFolder, My.Resources.pictures, My.Resources.Videos}
        Dim sfName() As String = {"Document", "Download", "Music", "Pictures", "Videos"}

        flpSideNav.Controls.Clear()

        For i As Integer = 0 To 4

            Dim specialF As New SpecialFolder
            specialF.Margin = New Padding(0)

            With specialF

                .setFileBrowser(Me)
                .pbImage.Image = img(i)
                .lblName.Text = sfName(i)
                .driveDirectoryCmd = sfName(i)

            End With

            flpSideNav.Controls.Add(specialF)

        Next

    End Sub

    Public Sub Clear_Selection()
        For Each c As SpecialFolder In flpSideNav.Controls
            'Console.WriteLine(c.lblName.Text)
            c.isSelected = False
            c.BackColor = Color.FromArgb(240, 240, 240)
        Next
    End Sub

    Public Sub clear_Drives()
        For Each c As SpecialFolder In flpSideNav.Controls
            If c.isDrive Then
                flpSideNav.Controls.Remove(c)
            End If
        Next
    End Sub

    Public Function Create_Drive(ByVal drivename As String, ByVal volumeLabel As String) As SpecialFolder

        Dim specialF As New SpecialFolder
        specialF.Margin = New Padding(0)

        With specialF

            .setFileBrowser(Me)
            .pbImage.Image = My.Resources.Drive1

            If volumeLabel = "" Then
                .lblName.Text = "Local Disk" & " (" & drivename.Replace("\", "") & ")"
            Else
                .lblName.Text = volumeLabel & " (" & drivename.Replace("\", "") & ")"
            End If

            .driveDirectoryCmd = drivename
            .isDrive = True

        End With

        Return specialF

    End Function

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ShadowForm.Close()
        Main.focusMe()
        Me.Hide()
    End Sub

    Public Sub create_File_Control(ByVal path As String, ByVal filename As String)

        Dim control As New FileAndDirectoryControl
        control.Margin = New Padding(0, 1, 0, 0)

        With control

            .setFileBrowser(Me)
            .path = path

            If filename.Contains(".") Then

                .isDirectory = False
                Dim name As String() = filename.Split(".")
                .lblDirectoryAndFileName.Text = name(0)
                .pbImage.Image = My.Resources.File

            Else

                .isDirectory = True
                .lblDirectoryAndFileName.Text = filename
                .pbImage.Image = My.Resources.Folder

            End If


        End With

        FlowLayoutPanel1.Controls.Add(control)

    End Sub
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        FlowLayoutPanel1.Controls.Clear()
        Dim pastdirectory As String() = currentDirectory.Split("\")
        Dim pastPath As String = Nothing

        If pastdirectory.Count > 2 Then

            For i As Integer = 0 To pastdirectory.Count - 2

                'if i is less than to the last element of the array append with slash
                'if not then simply add without slash

                If i < pastdirectory.Count - 2 Then
                    pastPath += pastdirectory(i) & "\"
                Else
                    pastPath += pastdirectory(i)
                End If

            Next

            btnBack.Enabled = True

        Else

            pastPath = pastdirectory(0) & "\"
            btnBack.Enabled = False

        End If

        Console.WriteLine(pastPath)
        control.addQueue(Information.Request_Client_Directories(False, pastPath))


    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        If Not isCurrentlyControlling() Then

            If control.isScreenControling Then

                Dim result As MsgBoxResult = MsgBox("You are currently viewing " & control.getEnvironmentName & ". Any screen viewing must be closed before proceeding, Are you sure to close screen viewing? ", vbYesNo + vbQuestion, "File Browser")

                If result = MsgBoxResult.Yes Then
                    control.getScreenControl().Close()
                ElseIf result = MsgBoxResult.No Then
                    Return
                End If

            End If

            Dim selectedDirectory As String = Nothing
            Dim isSingleFile As Boolean = False

            'informs the client control, for determining that the client is receiving files from it
            control.isFileReceiving = True

            For Each control As FileAndDirectoryControl In FlowLayoutPanel1.Controls

                If control.selected Then
                    selectedDirectory = control.path

                    If Not control.isDirectory Then
                        isSingleFile = True
                    End If

                    Exit For
                End If

            Next

            If selectedDirectory IsNot Nothing Then

                If isSingleFile Then

                    ' open a receiving progress of single file sharing
                    Console.WriteLine(selectedDirectory)
                    control.addQueue(Information.Request_Single_FileSharing(selectedDirectory))
                    Console.WriteLine("single")

                Else

                    ' open a receiving progress of multiple file sharing
                    control.addQueue(Information.Request_FileSharing(selectedDirectory))

                End If

                Me.Hide()
                Main.focusMe()
                ShadowForm.focusMe()
                control.getFileShareForm().ShowDialog()

            Else
                MsgBox("Please select a folder or a file to receive.")
            End If

        Else
            MsgBox("There are active remote control, Please close the other screen controls before proceeding.", vbCritical, "File Browser")
        End If


    End Sub

    Private Function isCurrentlyControlling() As Boolean

        Dim status As Boolean = False

        Try
            For Each ctrl As ClientControl1 In Main.ClientControls
                If Not ctrl.Equals(Me.control) And ctrl.isScreenControling Then
                    status = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            isCurrentlyControlling()
        End Try

        Return status

    End Function

    Public Sub ViewPath(ByVal path As String)
        txtDirectory.Text = path
        Dim directory As String() = currentDirectory.Split("\")

        If directory.Count > 1 Then
            btnBack.Enabled = True
        End If
    End Sub

    Public Sub RequestClientDirectories(ByVal path As String)
        Me.FlowLayoutPanel1.Controls.Clear()
        control.addQueue(Information.Request_Client_Directories(False, path))
    End Sub

    Public Sub RequestClientSpecialFolders(ByVal path As String)
        control.addQueue(Information.Request_Client_SpecialFolder_Directory(path))
    End Sub
End Class