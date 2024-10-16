Imports System.Data.SqlClient
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions

Public Class Settings

    'NOTE=====================================================================================
    'SYSTEM DEFAULT SETTINGS DATA
    Private Shared defaultFolderLocation As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Cafe System"
    Private Shared ClientFolderLocation As String = defaultFolderLocation & "\clients"
    Private Shared ImageFolderLocation As String = defaultFolderLocation & "\ads"
    Private Shared ScreenShotFolderLocation As String = defaultFolderLocation & "\screenshot"
    Private Shared saveConfigLocation As String = defaultFolderLocation & "\settings.xml"
    Private Shared Serverport As Integer = 9999
    Private Shared serverIP As String = Nothing
    Private Shared blockedSiteCount As Integer = 0
    Private Shared pricePerMinute As Double = 0.0
    Private Shared isModified As Boolean = False
    Private Shared AccountID As Integer = -1

    'SQL Connection
    Private sqlConnectionString As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    'GETTERS AND SETTERS
    Public Function getDefaultFolderLocation() As String
        Return defaultFolderLocation
    End Function

    Public Function getDefatultClientFolderLocation() As String
        Return ClientFolderLocation
    End Function

    Public Function getScreenShotDirectory() As String
        Return ScreenShotFolderLocation
    End Function

    Public Function getServerPort() As Integer
        Return Serverport
    End Function

    Public Function getServerIP() As String
        Return serverIP
    End Function

    Public Function getPricePerMinute() As String
        Return pricePerMinute
    End Function

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not Main.getModeStatus() Then
            pbProfile.Image = Nothing
            lblUsername.Text = ""
        End If

        btnPricing.PerformClick()

        LoadSetting()

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 1, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(flpSideNav, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnPricing, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnServer, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnClients, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnAccount, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnLogs, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnConsole, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnAbout, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlSeperator, Color.Black, 15, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        txtPORT.Text = Serverport
        txtDefaultFolderLocation.Text = defaultFolderLocation
        txtPricePerMinute.Text = pricePerMinute

    End Sub

    Public Sub LoadSetting()

        Try

            If File.Exists(saveConfigLocation) Then

                Using fs As New FileStream(saveConfigLocation, FileMode.Open, FileAccess.Read)

                    Dim bytesRead As Integer = 0

                    Dim buffer(fs.Length) As Byte
                    bytesRead = fs.Read(buffer, 0, buffer.Length)

                    Dim currentSetting As SettingsData = Class1.DeserializeObject(Of SettingsData)(Encoding.UTF8.GetString(buffer, 0, bytesRead))

                    'load directories
                    If Directory.Exists(currentSetting.defaultFolderLocation) Then
                        defaultFolderLocation = currentSetting.defaultFolderLocation
                        ClientFolderLocation = defaultFolderLocation & "\clients"
                        ImageFolderLocation = defaultFolderLocation & "\ads"
                        ScreenShotFolderLocation = defaultFolderLocation & "\screenshot"
                        saveConfigLocation = defaultFolderLocation & "\settings.xml"
                    Else
                        defaultFolderLocation = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Cafe System"
                    End If

                    Try
                        Dim value As Integer = Val(currentSetting.PORT)
                    Catch ex As Exception
                        Serverport = 9999
                    End Try

                    If currentSetting.PORT.ToString.Length > 4 Or currentSetting.PORT = Nothing Then
                        Serverport = 9999
                    Else
                        'load the saved port
                        Serverport = currentSetting.PORT
                    End If

                    'load the blocked sites
                    blockedSiteCount = currentSetting.listOfSite.Count
                    lstbOfBlockedWebsites.Items.Clear()
                    For Each website As String In currentSetting.listOfSite
                        lstbOfBlockedWebsites.Items.Add(website)
                    Next

                    'load price per minute  
                    If Not IsNumeric(currentSetting.pricePerMinute) Then
                        pricePerMinute = 0.0
                    Else
                        pricePerMinute = currentSetting.pricePerMinute
                    End If

                End Using

            Else
                CreateDeaultSettingData()
            End If

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace & " " & ex.Message)
            File.Delete(saveConfigLocation)
            CreateDeaultSettingData()
        End Try

        'CREATE A SERIALIZABLE CLASS FOR THE SETTINGS.

        If Directory.Exists(ImageFolderLocation) Then

            Dim imageFiles As String() = Directory.GetFiles(ImageFolderLocation)

            If imageFiles.Length > 0 Then
                flpClientSplashScreen.Controls.Clear()

                For Each file As String In imageFiles

                    Dim pictureb As New PictureBox
                    pictureb.Size = New Size(177, 107)
                    pictureb.SizeMode = PictureBoxSizeMode.Zoom
                    pictureb.Image = Converter.SafeImageFromFile(file)
                    flpClientSplashScreen.Controls.Add(pictureb)

                Next
            End If

        End If

        'NOTE
        'CREATE A SETTING FORM AND LOAD THE SAVED DATA 

        'checks if there are existing default falder at documents.
        If Not Directory.Exists(defaultFolderLocation) Then
            'create the  directory when the default directory not exists.
            Directory.CreateDirectory(defaultFolderLocation)
        End If

        'next after creating the default folder we need to create a sub folder for the clients.
        If Not Directory.Exists(ClientFolderLocation) Then
            Directory.CreateDirectory(ClientFolderLocation)
        End If

        If Not Directory.Exists(ImageFolderLocation) Then
            Directory.CreateDirectory(ImageFolderLocation)
        End If

        If Not Directory.Exists(ScreenShotFolderLocation) Then
            Directory.CreateDirectory(ScreenShotFolderLocation)
        End If

        serverIP = Information.getMyIPAddress()

    End Sub

    Private Sub CreateDeaultSettingData()

        'checks if there are existing default falder at documents.
        If Not Directory.Exists(defaultFolderLocation) Then
            'create the  directory when the default directory not exists.
            Directory.CreateDirectory(defaultFolderLocation)
        End If

        'using block for disposing the filestream after using it.
        Using fwriter As New FileStream(saveConfigLocation, FileMode.Create, FileAccess.Write)

            'CREATING A CLASS AND PUT THE NEW DATA INTO IT FOR SERIALIZING
            Dim newSetting As New SettingsData
            newSetting.defaultFolderLocation = defaultFolderLocation
            newSetting.PORT = Serverport

            Dim settingObj As String = Class1.SerializeObject(Of SettingsData)(newSetting)
            Dim buffer As Byte() = Encoding.UTF8.GetBytes(settingObj)

            fwriter.Write(buffer, 0, buffer.Length)

            'Console.WriteLine(settingObj)

        End Using

    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
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
                        Dim FolderDirectory As String = FolderBrowserDialog1.SelectedPath & "\Cafe System"
                        txtDefaultFolderLocation.Text = FolderDirectory
                        checkServerTabChanges()

                    End If

                    Exit For
                End If

            Next

        End If
    End Sub

    Private Sub btnAddAds_Click(sender As Object, e As EventArgs) Handles btnAddAds.Click

        If flpClientSplashScreen.Controls.Count <= 10 Then

            Dim pictureb As New PictureBox
            pictureb.Size = New Size(177, 107)
            pictureb.SizeMode = PictureBoxSizeMode.Zoom

            Dim img As Bitmap = Nothing

            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                img = Image.FromFile(OpenFileDialog1.FileName)
                pictureb.Image = img
                flpClientSplashScreen.Controls.Add(pictureb)

                'saving each image at the ads folder 
                Dim filename As String = "\SplashScreen-"
                Dim ctr As Integer = 0

                If flpClientSplashScreen.Controls.Count > 0 Then
                    For Each pb As PictureBox In flpClientSplashScreen.Controls
                        If pb.Image IsNot Nothing Then
                            Dim filepath As String = ImageFolderLocation & filename & ctr.ToString("00") & ".png"

                            Try
                                Using bmp As New Bitmap(pb.Image)
                                    bmp.Save(filepath)
                                End Using
                            Catch ex As Exception
                                File.Delete(filepath)
                                Console.WriteLine(ex.StackTrace & " " & ex.Message)
                            End Try

                            ctr += 1
                        End If
                    Next
                End If

                If Main.ClientControls.Count > 0 Then
                    For Each control In Main.ClientControls
                        control.addQueue(Information.SendSplashScreen(img))
                    Next
                End If

            End If

        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to clear the advertisements?", vbQuestion + vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then
            If flpClientSplashScreen.Controls.Count > 0 Then

                Try
                    Dim dir As New DirectoryInfo(ImageFolderLocation)
                    Dim fileObject As FileSystemInfo

                    For Each fileObject In dir.GetFileSystemInfos
                        Dim attribute As FileAttribute = File.GetAttributes(fileObject.FullName)
                        If Not attribute.HasFlag(FileAttribute.Directory) And Not attribute.HasFlag(FileAttribute.Hidden) Then
                            File.Delete(fileObject.FullName)
                        End If
                    Next

                    'removes the advertisements for each client connected to the server.
                    For Each control As ClientControl1 In Main.ClientControls
                        control.addQueue(Information.ClearAdvertisements())
                    Next

                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace & " " & ex.Message & "clear ads error")
                End Try

            End If
            flpClientSplashScreen.Controls.Clear()
        End If

    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click

        Try

            Dim errorCount As Integer = 0

            'error checking
            If Not IsNumeric(txtPricePerMinute.Text) Then
                errorCount += 1
                MsgBox("Price per minute is not valid.", vbCritical, "Invalid Price Value")
            End If

            If Not parseIPAddress(txtPORT.Text) Then
                errorCount += 1
                MsgBox("IP Address is not in correct format.", vbCritical, "Invalid IP Address")
            End If

            Try
                Dim port As Integer = Val(txtPORT.Text)
            Catch ex As Exception
                errorCount += 1
                MsgBox("Invalid Port Number.", vbCritical, "Invalid Port")
            End Try

            If errorCount = 0 Then

                'Creating new directories for the new directory folder
                '==========================================================================================
                defaultFolderLocation = txtDefaultFolderLocation.Text
                ClientFolderLocation = defaultFolderLocation & "\clients"
                ImageFolderLocation = defaultFolderLocation & "\ads"
                ScreenShotFolderLocation = defaultFolderLocation & "\screenshot"
                saveConfigLocation = defaultFolderLocation & "\settings.xml"

                If Not Directory.Exists(defaultFolderLocation) Then
                    Directory.CreateDirectory(defaultFolderLocation)
                End If

                If Not Directory.Exists(ClientFolderLocation) Then
                    Directory.CreateDirectory(ClientFolderLocation)
                End If

                'change client folder location
                If Main.ClientControls.Count > 0 Then
                    For Each control As ClientControl1 In Main.ClientControls
                        control.defaultFolderLocation = ClientFolderLocation & "\" & control.getEnvironmentName()
                        If Not Directory.Exists(control.defaultFolderLocation) Then
                            Directory.CreateDirectory(control.defaultFolderLocation)
                        End If
                    Next
                End If

                '============================================================================================

                If Not Directory.Exists(ImageFolderLocation) Then
                    Directory.CreateDirectory(ImageFolderLocation)
                End If

                'creating the save config file
                'using block for disposing the filestream after using it.
                Using fwriter As New FileStream(saveConfigLocation, FileMode.Create, FileAccess.Write)

                    'CREATING A CLASS AND PUT THE NEW DATA INTO IT FOR SERIALIZING
                    Dim newSetting As New SettingsData
                    newSetting.defaultFolderLocation = txtDefaultFolderLocation.Text
                    newSetting.PORT = txtPORT.Text

                    Dim sites As New List(Of String)
                    For Each website As String In lstbOfBlockedWebsites.Items
                        sites.Add(website)
                    Next
                    newSetting.listOfSite = sites

                    newSetting.pricePerMinute = Val(txtPricePerMinute.Text)

                    Dim settingObj As String = Class1.SerializeObject(Of SettingsData)(newSetting)
                    Dim buffer As Byte() = Encoding.UTF8.GetBytes(settingObj)

                    fwriter.Write(buffer, 0, buffer.Length)

                    'Console.WriteLine(settingObj)

                End Using

                LoadSetting()
                isModified = False
                btnApply.Enabled = False

                MsgBox("Setting saved successfully", vbInformation, "Settings")

            End If

            Me.Close()

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace & " " & ex.Message)
            MsgBox("There's an error on saving.", vbCritical, "Settings")
        End Try

    End Sub

    Private Sub txtPORT_ModifiedChanged(sender As Object, e As EventArgs) Handles txtPORT.ModifiedChanged
        checkServerTabChanges()
        txtPORT.Modified = False
    End Sub

    Private Sub txtPricePerMinute_ModifiedChanged(sender As Object, e As EventArgs) Handles txtPricePerMinute.ModifiedChanged
        If IsNumeric(txtPricePerMinute.Text) Then
            checkServerTabChanges()
        End If

        txtPricePerMinute.Modified = False
    End Sub

    Private Sub checkServerTabChanges()

        If Not (txtPORT.Text = Serverport And txtDefaultFolderLocation.Text = defaultFolderLocation And lstbOfBlockedWebsites.Items.Count = blockedSiteCount And txtPricePerMinute.Text = pricePerMinute.ToString) Then
            isModified = True
            btnApply.Enabled = True
        End If

    End Sub

    Private Sub Settings_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If isModified Then

            Dim result As MsgBoxResult = MsgBox("Continue without saving?", vbInformation + vbYesNo, "Settings")

            If result = MsgBoxResult.No Then
                e.Cancel = True
            End If

        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnPricing_Click(sender As Object, e As EventArgs) Handles btnPricing.Click
        'pricing
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Add)
        TabControl1.SelectedTab = tpPricing
        tpPricing.Select()
        btnApply.Visible = True
        ClearUpdateForm()
    End Sub

    Private Sub btnAccount_Click(sender As Object, e As EventArgs) Handles btnAccount.Click

        If Main.getModeStatus() Then

            Dim c As New SqlConnection(sqlConnectionString)
            c.Open()

            Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE enabled='" & True & "'", c)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count <= 1 Then
                Panel7.Visible = False
            Else
                Panel7.Visible = True
            End If

            c.Close()

            ' Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Remove)
            TabControl1.SelectedTab = tpAccount
            tpAccount.Select()
            btnApply.Visible = False
        Else
            MsgBox("You can't access accounts when in monitor mode.", vbInformation)
        End If
        ClearUpdateForm()

    End Sub



    Private Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Add)
        TabControl1.SelectedTab = tpServer
        tpServer.Select()
        btnApply.Visible = True
        ClearUpdateForm()

        lblHostIPAddress.Text = Information.getMyIPAddress()
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Add)
        TabControl1.SelectedTab = tpClients
        tpClients.Select()
        btnApply.Visible = True
        ClearUpdateForm()
    End Sub

    Private Sub btnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        If Main.getModeStatus() Then
            'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Remove)
            loadLogs()
            TabControl1.SelectedTab = tpLog
            tpLog.Select()
            btnApply.Visible = False
        Else
            MsgBox("You can't access accounts when in monitor mode.", vbInformation)
        End If
        ClearUpdateForm()
    End Sub

    Private Sub btnConsole_Click(sender As Object, e As EventArgs) Handles btnConsole.Click
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Remove)
        TabControl1.SelectedTab = tpConsole
        tpConsole.Select()
        btnApply.Visible = False
        ClearUpdateForm()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        'SHOW A FORM

        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel5, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop, Guna.UI.WinForms.AddOrRemove.Remove)
        btnApply.Visible = False
        TabControl1.SelectedTab = tbAbout
        tbAbout.Select()
        ClearUpdateForm()

        lblVersion.Text = "Application Version: " & My.Application.Info.Version.ToString

    End Sub

    Private Sub btnAddWebsite_Click(sender As Object, e As EventArgs) Handles btnAddWebsite.Click

        Dim errorCount As Integer = 0

        If txtWebsite.Text.Length > 4 AndAlso txtWebsite.Text.Substring(0, 4).ToLower.Equals("www.") AndAlso txtWebsite.Text.Count(Function(c As Char) c = ".") = 2 Then

            Dim s As String() = txtWebsite.Text.Split(".")

            If s(0) <> "" And s(1) <> "" And s(2) <> "" Then

                lstbOfBlockedWebsites.Items.Add(txtWebsite.Text)

                If Main.ClientControls.Count > 0 Then
                    Dim sites As New List(Of String)

                    For Each site As String In lstbOfBlockedWebsites.Items
                        sites.Add(site)
                    Next

                    For Each control As ClientControl1 In Main.ClientControls
                        control.addQueue(Information.SendBlockedWebsites(sites, False))
                    Next
                End If

                checkServerTabChanges()

                MsgBox("Site " & txtWebsite.Text & " has been blocked.", vbInformation)
                txtWebsite.Text = ""


            Else
                errorCount += 1
            End If
        Else
            errorCount += 1
        End If

        If errorCount > 0 Then
            MsgBox("Please specify a valid website.", vbInformation)
        End If
    End Sub

    Private Sub btnRemoveWebsite_Click(sender As Object, e As EventArgs) Handles btnRemoveWebsite.Click

        If lstbOfBlockedWebsites.SelectedIndex <> -1 Then

            Dim sites As New List(Of String)

            For Each site As String In lstbOfBlockedWebsites.SelectedItems
                sites.Add(site)
            Next

            If Main.ClientControls.Count > 0 Then
                For Each control As ClientControl1 In Main.ClientControls
                    control.addQueue(Information.SendBlockedWebsites(sites, True))
                Next
            End If

            For Each s As String In sites
                lstbOfBlockedWebsites.Items.Remove(s)
            Next

            checkServerTabChanges()
        Else
            MsgBox("Please select an website to delete")
        End If


    End Sub

    Public Function getListOfBlockSites() As List(Of String)
        Dim list As New List(Of String)

        For Each s As String In lstbOfBlockedWebsites.Items
            list.Add(s)
        Next

        Return list
    End Function

    Private Sub loadLogs()

        Dim c As New SqlConnection(sqlConnectionString)
        c.Open()

        Dim command As New SqlCommand("SELECT * FROM tblLog", c)
        Dim reader As SqlDataReader = command.ExecuteReader

        lboxLogs.Items.Clear()
        While reader.Read
            lboxLogs.Items.Add(reader.GetString(1).PadRight(40) & reader.GetString(2).PadRight(40) & Format(reader.GetDateTime(3), "MM-dd-yyy hh:mm:ss tt"))
        End While

        c.Close()

    End Sub

    Private Sub btnClearLog_Click(sender As Object, e As EventArgs) Handles btnClearLog.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to clear logs? This cannot be undone.", vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then

            Dim dc As New SqlConnection(sqlConnectionString)
            dc.Open()

            Dim deleteCmd As New SqlCommand("DELETE FROM tblLog", dc)
            deleteCmd.ExecuteNonQuery()

            dc.Close()

            MsgBox("Logs cleared successfully!", vbInformation)

        End If

    End Sub

    Public Sub ConsoleLog(ByVal text As String)
        rtbConsole.AppendText(text & vbNewLine)

        If rtbConsole.Lines.Length >= 100 Then
            Dim lines As List(Of String) = rtbConsole.Lines.ToList
            lines.RemoveAt(0)
            rtbConsole.Lines = lines.ToArray
        End If
    End Sub
    Private Sub btnConsoleClear_Click(sender As Object, e As EventArgs) Handles btnConsoleClear.Click
        rtbConsole.Clear()
    End Sub

    Private Sub btnManageAccount_Click(sender As Object, e As EventArgs) Handles btnManageAccount.Click
        ManageAccount.ShowDialog()
    End Sub

    Private Sub chbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbxShowPassword.CheckedChanged
        If chbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.PasswordChar = "●"
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnChangeProfile_Click(sender As Object, e As EventArgs) Handles btnChangeProfile.Click

        'Set the Filter.
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."
        OpenFileDialog1.Multiselect = False
        'Show it
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Create a new Bitmap and display it
            pbEditProfile.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Function ValidateEditInput() As Boolean

        Dim errorCount As Integer = 0

        If txtUsername.Text = "" Or txtUsername.Text.Contains("'") Or txtUsername.Text.Contains("""") Then
            txtUsername.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If txtPassword.Text = "" Or txtPassword.Text.Contains("'") Or txtPassword.Text.Contains("""") Then
            txtPassword.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If errorCount > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If ValidateEditInput() Then

            Dim connection As New SqlConnection(sqlConnectionString)
            connection.Open()


            Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE id='" & LoginForm.getAccountID() & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows(0)(2).ToString.Trim = txtUsername.Text Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                Dim edit As New SqlCommand("Update tblMainAccount set profileImg=@profileImg,username=@username,password=@password WHERE id=@id", c)
                edit.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = LoginForm.getAccountID()

                If pbEditProfile.Image IsNot Nothing Then
                    Using ms As New MemoryStream
                        pbEditProfile.Image.Save(ms, pbEditProfile.Image.RawFormat)
                        edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                    End Using
                Else
                    edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = DBNull.Value
                End If
                edit.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtUsername.Text
                edit.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtPassword.Text
                edit.ExecuteNonQuery()

                c.Close()

                MsgBox("Account updated successfully!", vbInformation, "Account")
                TabControl1.SelectedTab = tpAccount
                ClearUpdateForm()

            Else

                If Not isUsernameExist(txtUsername.Text) Then
                    Dim c As New SqlConnection(sqlConnectionString)
                    c.Open()

                    Dim edit As New SqlCommand("Update tblMainAccount set profileImg=@profileImg,username=@username,password=@password WHERE id=@id", c)
                    edit.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = LoginForm.getAccountID()

                    If pbEditProfile.Image IsNot Nothing Then
                        Using ms As New MemoryStream
                            pbEditProfile.Image.Save(ms, pbEditProfile.Image.RawFormat)
                            edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                        End Using
                    Else
                        edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = DBNull.Value
                    End If
                    edit.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtUsername.Text
                    edit.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtPassword.Text
                    edit.ExecuteNonQuery()

                    c.Close()

                    MsgBox("Account updated successfully!", vbInformation, "Account")
                    TabControl1.SelectedTab = tpAccount
                    ClearUpdateForm()
                Else
                    MsgBox("Account name already exist!", vbInformation, "Account")
                End If

            End If

        Else
            MsgBox("Blank, single and double quotes are prohibited!", vbCritical)
        End If

    End Sub

    Private Function isUsernameExist(ByVal username As String) As Boolean

        Dim exists As Boolean = False

        Dim connection As New SqlConnection(sqlConnectionString)
        connection.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE username='" & username & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            exists = True
        End If

        connection.Close()
        Return exists

    End Function

    Private Sub ClearUpdateForm()

        txtUsername.Text = ""
        txtPassword.Text = ""
        pbEditProfile.Image = Nothing

    End Sub

    Private Sub btnDisableAccount_Click(sender As Object, e As EventArgs) Handles btnDisableAccount.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to delete " & lblUsername.Text & " ? This cannot be undone.", vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then

            Dim c As New SqlConnection(sqlConnectionString)
            c.Open()

            Dim edit As New SqlCommand("Update tblMainAccount set enabled=@enabled where id=@id", c)
            edit.Parameters.AddWithValue("@enabled", False)
            edit.Parameters.AddWithValue("@id", LoginForm.getAccountID())
            edit.ExecuteNonQuery()

            Dim search As New SqlDataAdapter("SELECT * FROM tblLog", c)
            Dim table As New DataTable
            search.Fill(table)

            Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", c)
            savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1
            savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = lblUsername.Text
            savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Self Deactivate"
            savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
            savelog.ExecuteNonQuery()
            c.Close()

            MsgBox("Account successfully deleted.")
            c.Close()

        End If

    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click

        Dim c As New SqlConnection(sqlConnectionString)
        c.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE id='" & LoginForm.getAccountID() & "'", c)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then

            If Not table.Rows(0)(1).Equals(DBNull.Value) Then
                pbEditProfile.Image = Converter.getImage(table.Rows(0)(1))
            Else
                pbEditProfile.Image = Nothing
            End If

            txtUsername.Text = table.Rows(0)(2).ToString.Trim
            txtPassword.Text = table.Rows(0)(3).ToString.Trim

        End If

        TabControl1.SelectedTab = tpEditAccount

    End Sub

    Private Function parseIPAddress(ByVal ip As String) As Boolean

        Dim adrs As IPAddress = Nothing
        If IPAddress.TryParse(ip, adrs) Then
            Select Case adrs.AddressFamily
                Case Sockets.AddressFamily.InterNetwork
                    Return True
            End Select
        End If
        Return False

    End Function

    Private Sub txtPricePerMinute_TextChanged(sender As Object, e As EventArgs) Handles txtPricePerMinute.TextChanged

        Try
            Dim price As Double = Val(txtPricePerMinute.Text) * 60
            lblPrice.Text = "x 60 = " & price.ToString("N2") & " per hour."
        Catch ex As Exception
            lblPrice.Text = "x 60 = Indeterminate"
        End Try

    End Sub
End Class