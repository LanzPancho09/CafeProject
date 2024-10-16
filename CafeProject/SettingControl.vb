Imports System.IO

Public Class SettingControl
    Private Sub SettingControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'txtPort.Text = Main.Serverport

        Dim defaultFolderLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Cafe System"

        If Not Directory.Exists(defaultFolderLocation) Then
            Directory.CreateDirectory(defaultFolderLocation)
        End If

        'Main.ServerReceiveFolder = defaultFolderLocation
        txtDefaultFolderLocation.Text = defaultFolderLocation
    End Sub

    Private Sub btnBrowseFolder_Click(sender As Object, e As EventArgs) Handles btnBrowseFolder.Click
        'CHANGE THE TITLE NAME OF THE FOLDER BROWSER DIALOG
        FolderBrowserDialog1.Description = "Choose Folder For Receiving Files"

        'IF THE USER SELECT OK IN THE DIALOG BOX 
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then

            'IT WILL STORE THE PATH OF THE SELECTED FILE AND ADDING A BACKSLASH IN THE END
            'IN ORDER TO CHECK THE FILES STORED WHEN RECEIVING FROM THE NETWORK STREAM.

            For Each drive As DriveInfo In DriveInfo.GetDrives

                'if the root is equal to the drive then check
                If drive.Name.Equals(Directory.GetDirectoryRoot(FolderBrowserDialog1.SelectedPath)) Then

                    ' the 104857600 is equivalent to 100mb to prevent the exact needed space for the drive
                    If Not drive.DriveType.Equals(DriveType.Fixed) Then

                        MsgBox("Please provide a directory from a non-removable drive type.")

                    Else

                        'Folder Directory
                        Dim FolderDirectory As String = FolderBrowserDialog1.SelectedPath & "Cafe System"
                        txtDefaultFolderLocation.Text = FolderDirectory

                        'Main.ServerReceiveFolder = FolderDirectory

                        If Not Directory.Exists(FolderDirectory) Then
                            Directory.CreateDirectory(FolderDirectory)
                        End If

                        For Each control As ClientControl1 In Main.ClientControls

                            'control.defaultFolderLocation = Main.ServerReceiveFolder & "\" & control.getEnvironmentName()

                            If Not Directory.Exists(control.defaultFolderLocation) Then
                                Directory.CreateDirectory(control.defaultFolderLocation)
                            End If

                        Next

                    End If

                End If

            Next

        End If
    End Sub

End Class
