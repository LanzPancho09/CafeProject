Imports System.Drawing
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Threading
Imports System.Data.SqlClient

Public Class Main

    Dim ServerListener As TcpListener

    'NOTE
    'Default Receive Folder is in Windows "Document" Folder and cafe system folder inside.
    'Public Shared ServerReceiveFolder As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) & "\Cafe System"
    Public Shared ServerRunning As Boolean = False
    Public Shared ClientControls As New List(Of ClientControl1)
    'false = monitor mode, true = cafe mode.
    Private Shared isCafeMode As Boolean = True

    Private listOfTasks As New List(Of Task)

    'SQL Connection
    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Public Sub setMode(ByVal mode As Boolean)
        isCafeMode = mode
    End Sub

    Public Function getModeStatus() As Boolean
        Return isCafeMode
    End Function


    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load all shadows including the main settings
        load_Main()

        'SERVER START
        ServerListener = New TcpListener(IPAddress.Any, Settings.getServerPort())
        ServerListener.Start()

        'tells to every thread that the server is running.
        ServerRunning = True

        listOfTasks.Add(Task.Run(Function() clientHandlerAsync()))

        'Data Transfer Speed Calculator
        TmAccountTimeUpdater.Start()
        TmClientNetworkSpeed.Start()

        Console.WriteLine("SERVER STARTED!")
        Console.WriteLine("SERVER PORT : " & Settings.getServerPort())

        Settings.ConsoleLog("SERVER STARTED!")
        Settings.ConsoleLog("SERVER PORT : " & Settings.getServerPort())

    End Sub

    'SERVER CLIENT HANDLER
    Private Async Function clientHandlerAsync() As Task

        While ServerRunning

            Try
                Dim client As TcpClient = Await ServerListener.AcceptTcpClientAsync()

                Dim nw As NetworkStream = client.GetStream
                Dim formatter As New BinaryFormatter
                formatter.Serialize(nw, Information.Request_Information())
                Console.WriteLine("1 Client connected, requesting information...")

                Dim obj As String = formatter.Deserialize(nw)
                Console.WriteLine("Information Received, finalizing...")

                'DESERIALIZING THE OBJECT RETRIEVED FROM THE NETWORK STREAM
                Dim objData As ObjectExtension = Class1.DeserializeObject(Of ObjectExtension)(obj)

                'DETERMINING THE OBJECT EXTENSION TO PROVIDE CORRECT CLASS DESERIALIZER.
                If objData.Extension = ".info" Then

                    Dim infoObj As RequestClientInfoData = Class1.DeserializeObject(Of RequestClientInfoData)(objData.ClassObject)

                    Dim objs(5) As Object
                    objs(0) = infoObj.ClientScreenResolution
                    objs(1) = Converter.getImage(infoObj.ClientProfile)
                    objs(2) = infoObj.ClientEnvironmentName
                    objs(3) = infoObj.ClientComputerNo
                    objs(4) = Information.getClientIP(client)

                    Me.Invoke(Sub()

                                  Dim control As ClientControl1 = ManageClientControl.Create_Client_Control(client, objs)
                                  control.setNetworkStream(client.GetStream)

                                  'CREATING CLIENT NAME DIRECTORY FOLDER FOR FILES
                                  control.defaultFolderLocation = Settings.getDefatultClientFolderLocation & "\" & objs(2)

                                  'create a directory for file sharing.
                                  If Not Directory.Exists(control.defaultFolderLocation) Then
                                      Directory.CreateDirectory(control.defaultFolderLocation)
                                  End If

                                  control.setMessageControl(ManageClientControl.Create_Client_Contact(control, objs(1), objs(2)))
                                  control.setClientScreenControl(ManageClientControl.Create_Client_Screen_Control(control, objs(2) & " # " & objs(3), objs(0)))
                                  control.getFileShareForm().setControl(control)
                                  control.getFileBrowser().setControl(control)

                                  Dim timeControl As ClientTimeControl = ManageClientControl.CreateTimeControl(objs(1), objs(2), objs(3), objs(4))
                                  timeControl.SetMainControl(control)
                                  control.setTimeControl(timeControl)

                                  ClientControls.Add(control)

                                  If ClientControls.Count > 1 Then

                                      'creating contacts for each client
                                      For Each c As ClientControl1 In ClientControls
                                          For Each cc As ClientControl1 In ClientControls
                                              If Not c.getIPAddress().Equals(cc.getIPAddress()) Then
                                                  c.addContact(cc.getIPAddress, cc.getEnvironmentName, cc.getProfileImage)
                                              End If
                                          Next
                                      Next

                                  End If

                                  'SETTINGS
                                  If Settings.flpClientSplashScreen.Controls.Count > 0 Then
                                      'send splash screen to client
                                      For Each pb As PictureBox In Settings.flpClientSplashScreen.Controls
                                          control.addQueue(Information.SendSplashScreen(pb.Image))
                                      Next
                                  End If

                                  If Settings.lstbOfBlockedWebsites.Items.Count > 0 Then
                                      'send blocked sites if there's any
                                      control.addQueue(Information.SendBlockedWebsites(Settings.getListOfBlockSites, False))
                                  End If

                                  'add the control to the flowlayout panel
                                  flpMonitorClient.Controls.Add(control)

                                  'add the task to the list of task.
                                  listOfTasks.Add(Task.Run(Function() control.StartAsync()))
                              End Sub)

                    Console.WriteLine("Client Information aquired!")
                    Console.WriteLine("Informning Connected!")

                    'FINALLY SENDING IT TO THE CLIENT
                    formatter.Serialize(nw, Information.Inform_ServerMode(isCafeMode))
                    'INFORMING CONNECTED
                    formatter.Serialize(nw, Information.Inform_Connected())
                End If

                Me.Invoke(Sub()
                              refreshClientStatus()
                          End Sub)

            Catch ex As Exception
                Console.WriteLine(ex.Message & "Client handler error")
            End Try

        End While

    End Function

    Private Sub load_Main()

        Settings.LoadSetting()
        load_shadows()

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height

        'flpMonitorChat.Height = screenHeight - (183 + 80)
        TabControl1.Size = New Size(screenWidth - TabControl1.Location.X, screenHeight - TabControl1.Location.Y)
        TabControlMonitor.Size = New Size(TabControl1.Size.Width - TabControlMonitor.Location.X, TabControl1.Size.Height - TabControlMonitor.Location.Y)
        TabControlSales.Size = New Size(TabControl1.Size.Width - TabControlSales.Location.X, TabControl1.Size.Height - TabControlSales.Location.Y)

        Console.WriteLine(Information.getMyIPAddress)

        'Dim c As New SqlConnection(sqlConnection)
        'c.Open()

        'Dim command As New SqlCommand("select * from tblSales", c)
        'Dim reader As SqlDataReader = command.ExecuteReader

        'Dim cs As New SqlConnection(sqlConnection)
        'cs.Open()

        'While reader.Read

        '    Dim edit As New SqlCommand("Update tblSales set date=@date where customerID=@cID", cs)
        '    edit.Parameters.AddWithValue("@cID", reader.GetString(0))
        '    edit.Parameters.AddWithValue("@date", Format(Convert.ToDateTime(reader.GetString(6)), "dd MMMM yyyy"))
        '    edit.ExecuteNonQuery()

        'End While


    End Sub

    Dim vScrollBarHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Dim hScrollHelper As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub load_shadows()

        'SHADOWS
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlSideNavigationBar, Color.FromArgb(106, 122, 144), 40, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel1, Color.FromArgb(106, 122, 144), 40, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        'Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlSalesRecord, Color.FromArgb(106, 122, 144), 70, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

        'SCROLL BARS
        vScrollBarHelper = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlSalesRecord, vsbSalesRecord, True)
        vScrollBarHelper.UpdateScrollBar()

        vScrollBarHelperVoucher = New Guna.UI.Lib.ScrollBar.PanelScrollHelper(flpVoucher, vsVoucher, True)
        vScrollBarHelperVoucher.UpdateScrollBar()

    End Sub

    Private Sub pnlSalesRecord_Resize(sender As Object, e As EventArgs) Handles pnlSalesRecord.Resize
        If vScrollBarHelper IsNot Nothing Then vScrollBarHelper.UpdateScrollBar()
    End Sub

    Private Sub pnlSalesRecord_Scroll(sender As Object, e As ScrollEventArgs) Handles pnlSalesRecord.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            pnlSalesRecord.VerticalScroll.Value = e.NewValue
        End If
    End Sub

    Dim vScrollBarHelperVoucher As Guna.UI.Lib.ScrollBar.PanelScrollHelper
    Private Sub flpVoucher_Resize(sender As Object, e As EventArgs) Handles flpVoucher.Resize
        If vScrollBarHelperVoucher IsNot Nothing Then vScrollBarHelperVoucher.UpdateScrollBar()
    End Sub

    Private Sub flpVoucher_Scroll(sender As Object, e As ScrollEventArgs) Handles flpVoucher.Scroll
        If e.ScrollOrientation = ScrollOrientation.VerticalScroll Then
            flpVoucher.VerticalScroll.Value = e.NewValue
        End If
    End Sub



    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to exit?", vbInformation + vbYesNo, "Action Confirmation")

        If result = MsgBoxResult.Yes Then

            ServerRunning = False

            While ClientControls.Count > 0
                ClientControls(0).Disconnect()
            End While

            LoginForm.SetDefaultAccount()
            ServerListener.Stop()
            TmClientNetworkSpeed.Stop()
            TmAccountTimeUpdater.Stop()

            lblAccountLevel.Text = "Account Level"
            lblTime.Text = "00:00:00 AM"
            lblUsername.Text = "Username"
            pbUserImage.Image = Nothing

            Me.Close()
            LoginForm.Show()

        End If

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        TabControl1.SelectedTab = TabPageHome
    End Sub

    Private Sub btnMonitor_Click(sender As Object, e As EventArgs) Handles btnMonitor.Click
        TabControl1.SelectedTab = TabPageMonitor
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click

        If ClientControls.Count > 0 Then
            cbSort.Enabled = True
        Else
            cbSort.Enabled = False
        End If

        TabControlMonitor.SelectedTab = TabTimer
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        TabControlMonitor.SelectedTab = TabClient
    End Sub

    Private Sub btnScreen_Click(sender As Object, e As EventArgs) Handles btnScreen.Click
        TabControlMonitor.SelectedTab = TabScreen
    End Sub

    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        TabControlMonitor.SelectedTab = TabMessage
    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        TabControl1.SelectedTab = TabPageSales
        loadSummaryChart()
    End Sub

    Private Sub loadSummaryChart()

        Dim dateNow As DateTime = DateTime.Now
        Dim startDatetime As DateTime = dateNow.Date
        Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)

        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "hh:mm:ss tt"

        Dim c As New SqlConnection(sqlConnection)
        c.Open()

        Dim command As New SqlCommand(query, c)
        Dim reader As SqlDataReader = command.ExecuteReader

        Chartsales.Series("Profit").Points.Clear()
        While reader.Read
            Dim recordProfit As Double = CDbl(reader.GetString(5).Trim)
            Chartsales.Series("Profit").Points.AddXY(Format(reader.GetDateTime(6), dateFmt), recordProfit)
        End While

    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ShadowForm.Show()
        Settings.ShowDialog()
        ShadowForm.Close()
    End Sub

    Private Sub btnSale_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        TabControlSales.SelectedTab = PageSummary
    End Sub

    Private Sub btnPricing_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        TabControlSales.SelectedTab = PageAccount

        flpAccounts.Controls.Clear()
        loadAccounts()

    End Sub

    Public Sub loadAccounts()

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim command As New SqlCommand("select * from tblaccount", c)
            Dim reader As SqlDataReader = command.ExecuteReader

            flpAccounts.Controls.Clear()

            While reader.Read

                If reader.GetBoolean(7) Then

                    Dim control As New AccountControl
                    control.Margin = New Padding(3, 3, 3, 3)

                    With control
                        .setTime(reader.GetString(6).Trim)
                        .setValues(reader.GetString(0), reader.GetString(2).Trim, reader.GetString(3).Trim)

                        If Not reader(1).Equals(DBNull.Value) Then
                            .pbImage.Image = Converter.getImage(reader(1))
                        End If

                        .lblUsername.Text = reader.GetString(4).Trim
                        .lblPassword.Text = reader.GetString(5).Trim
                        .lblTime.Text = reader.GetString(6).Trim
                    End With

                    flpAccounts.Controls.Add(control)

                End If

            End While

        Else
            MsgBox("SQL Connection failed.", vbCritical, "Database Connection")
        End If

    End Sub

    Public Function SearchAccount(ByVal username As String, ByVal password As String) As Boolean

        Dim status As Boolean = False

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblaccount where AccUsername='" & username & "' and AccPassword='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        'checks if there are existing acc record
        If table.Rows.Count > 0 Then
            'checks if the account is enable
            If table.Rows(0)(7) Then
                'checks if the username and password is equals to the data searched
                If (username = table.Rows(0)(4).ToString.Trim) And (password = table.Rows(0)(5).ToString.Trim) Then
                    status = True
                End If
            End If
        End If

        connection.Close()

        Return status
    End Function

    Public Function getAccountID(ByVal username As String, ByVal password As String) As Integer

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblaccount where AccUsername='" & username & "' and AccPassword='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            Return Val(table.Rows(0)(0).ToString.Trim)
        Else
            Return -1
        End If

    End Function

    Public Function getVouchID(ByVal username As String, ByVal password As String) As Integer

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblvouch where username='" & username & "' and password='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            Return Val(table.Rows(0)(0).ToString.Trim)
        Else
            Return -1
        End If

    End Function

    Public Function SearchVouch(ByVal username As String, ByVal password As String) As Boolean
        Dim status As Boolean = False

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblvouch where username='" & username & "' and password='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            If (table.Rows(0)(1).ToString.Trim = username And table.Rows(0)(2).ToString.Trim = password) Then
                status = True
            End If
        End If

        connection.Close()

        Return status
    End Function

    Public Function getAccountData(ByVal username As String, ByVal password As String) As Object()

        Dim obj(7) As Object

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblaccount where AccUsername='" & username & "' and AccPassword='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        'checks if there are existing acc record
        If table.Rows.Count > 0 Then

            'checks if the account is enable
            If table.Rows(0)(7) Then
                If (username = table.Rows(0)(4).ToString.Trim) And password.Equals(table.Rows(0)(5).ToString.Trim) Then
                    obj(0) = table.Rows(0)(0).ToString.Trim 'Account ID
                    obj(1) = table.Rows(0)(1) 'accunt image
                    obj(2) = table.Rows(0)(2).ToString.Trim ' account Firstname
                    obj(3) = table.Rows(0)(3).ToString.Trim ' account lastname
                    obj(4) = table.Rows(0)(4).ToString.Trim ' account username
                    obj(5) = table.Rows(0)(5).ToString.Trim ' account password
                    obj(6) = table.Rows(0)(6).ToString.Trim ' account time
                End If
            End If

        End If

        Return obj

    End Function

    Public Function getVouchTime(ByVal username As String, ByVal password As String) As String

        Dim time As String = Nothing

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("select * from tblvouch where username='" & username & "' and password='" & password & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then

            Console.WriteLine("username " & (table.Rows(0)(1).ToString.Trim = username) & " " & "password " & (table.Rows(0)(2).ToString.Trim = password))

            If ((table.Rows(0)(1).ToString.Trim = username) And (table.Rows(0)(2).ToString.Trim = password)) Then
                time = table.Rows(0)(3)
            End If
        End If

        connection.Close()
        Return time

    End Function

    Private Function checkSQLConnection(ByVal c As SqlConnection) As Boolean

        Try
            c.Open()

            If c.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Shared currentContact As ClientMessageControl = Nothing
    Private Sub btnSendMessage_Click(sender As Object, e As EventArgs) Handles btnSendMessage.Click

        'SEND MESSAGE
        If currentContact IsNot Nothing Then
            currentContact.SendMessage(txtMessage.Text)

            'for storing data message runtime
            Dim message As New MsgStorage
            message.msg = txtMessage.Text
            message.isUser = True
            message.dateandtime = Format(Date.Now, "MM/dd/yy h:mm tt")

            currentContact.AddMessage(message)

            'Dim chatbox As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(txtMessage.Text, True)
            'flpMonitorChat.Controls.Add(chatbox)

            If currentContact.getTextControl() IsNot Nothing AndAlso currentContact.getTextControl().isUser() Then
                Dim chatb As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(currentContact.getTextControl(), message.msg, True)
                currentContact.SetTextControl(chatb)
            Else
                Dim chatb As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(Nothing, message.msg, True)

                If Main.isCafeMode Then
                    chatb.pbImage.Image = Settings.pbProfile.Image
                    chatb.lblName.Text = Settings.lblUsername.Text
                Else
                    chatb.pbImage.Image = My.Resources.monitor_48px_grey
                    chatb.lblName.Text = "Server"
                End If

                chatb.lblDateAndTime.Text = message.dateandtime
                currentContact.SetTextControl(chatb)
                flpMonitorChat.Controls.Add(chatb)
            End If

            txtMessage.Text = ""
            txtMessage.Select()
        End If

    End Sub

    Public Sub focusMe()
        Me.Activate()
    End Sub

    Private Sub TmClientNetworkSpeed_Tick(sender As Object, e As EventArgs) Handles TmClientNetworkSpeed.Tick

        lblTime.Text = Format(Date.Now, "dddd, MMMM-dd-yyyy     h:mm:ss tt")

        'removes all tasks that is completed in the list of tasks.
        listOfTasks.RemoveAll(Function(x) x.IsCompleted)

        If ClientControls.Count > 0 Then
            For Each control As ClientControl1 In ClientControls
                control.totalReceivedbytes = 0
            Next
        End If

    End Sub

    'Private Async Function Network_start() As Task
    '    'single thread for sending and receiving data from client.
    '    While ServerRunning

    '        Try
    '            If ClientControls.Count > 0 Then

    '                For Each control In ClientControls

    '                    If Not control.isStarted() Then
    '                        control.StartAsync()
    '                    End If

    '                    If Not ServerRunning Then
    '                        Return
    '                    End If

    '                    Console.WriteLine("Network running")

    '                    Await Task.Delay(1000)
    '                Next

    '            Else
    '                Await Task.Delay(1000)
    '            End If

    '        Catch ex As Exception
    '            Console.WriteLine(ex.Message & " " & "Client network error")
    '        End Try

    '    End While

    'End Function

    Private Sub TmAccountTimeUpdater_Tick(sender As Object, e As EventArgs) Handles TmAccountTimeUpdater.Tick

        If ServerRunning Then

            If flpMonitorTimer.Controls.Count > 0 Then

                Try
                    'get the controls available in flowlayout panel timer controls
                    For Each control As ClientTimeControl In flpMonitorTimer.Controls

                        'checks if the client account is valid means the client uses vouch or account
                        If control.getID() <> -1 Then
                            'checks if the lastsavedtime is null
                            If control.getLastSavedTime() = Nothing Then
                                'when null it just save the new usertime to the user account database
                                'and also saving the new user time to that control. 
                                control.setSavedTime(control.getNewUserTime())

                                If control.isAccountActivated() Then
                                    UpdateClientAccountTime(control.getID, control.getNewUserTime())
                                End If
                            Else

                                'if there's a saved time, then we need to compare it to the new usertime.
                                'if they are matched with the last saved time it will not update, else it will update.
                                If Not (control.getLastSavedTime() = control.getNewUserTime()) Then
                                    control.setSavedTime(control.getNewUserTime())

                                    If control.isAccountActivated() Then
                                        UpdateClientAccountTime(control.getID, control.getNewUserTime())
                                    End If
                                End If

                            End If
                        End If

                    Next


                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try

            End If

        End If
    End Sub

    Public Sub refreshClientStatus()

        Dim availableCount As Integer = 0
        Dim occupiedCount As Integer = 0

        If ClientControls.Count > 0 Then
            For Each control As ClientControl1 In ClientControls
                If Not control.getTimeControl().isOntime() Then
                    availableCount += 1
                Else
                    occupiedCount += 1
                End If
            Next
        End If

        lblAvailablePC.Text = availableCount
        lblOccupiedPC.Text = occupiedCount

    End Sub

    Private Sub UpdateClientAccountTime(ByVal id As Integer, ByVal time As String)

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim update As New SqlDataAdapter("UPDATE tblaccount SET AccTime ='" & time & "' WHERE AccID = '" & id & "'", c)
            Dim updatetable As New DataTable
            update.Fill(updatetable)

            'Console.WriteLine("ID: " & id & " time: " & time)
            'Console.WriteLine("updated sucess!")

        Else
            Console.WriteLine("Connecting to database failed. : Update client time ")
        End If

    End Sub

    Private Sub btnAccountView_Click(sender As Object, e As EventArgs) Handles btnAccountView.Click

        If flpAccounts.Controls.Count > 0 Then
            For Each control As AccountControl In flpAccounts.Controls
                With control
                    .Normal()
                    .btnExtend.BaseColor = Color.FromArgb(25, 182, 152)
                    .btnExtend.Text = "Extend"
                End With
            Next
        End If

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        ShadowForm.Show()
        CreateAccount.ShowDialog()
        ShadowForm.Close()

        If flpAccounts.Controls.Count > 0 Then
            For Each control As AccountControl In flpAccounts.Controls
                With control
                    .Normal()
                    .btnExtend.BaseColor = Color.FromArgb(25, 182, 152)
                    .btnExtend.Text = "Extend"
                End With
            Next
        End If

    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs) Handles btnEditAccount.Click

        If flpAccounts.Controls.Count > 0 Then
            For Each control As AccountControl In flpAccounts.Controls
                With control
                    .Editing()
                    .btnExtend.BaseColor = Color.FromArgb(26, 182, 111)
                    .btnExtend.Text = "Edit"
                End With
            Next
        End If

    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click

        If flpAccounts.Controls.Count > 0 Then
            For Each control As AccountControl In flpAccounts.Controls
                With control
                    .Deleting()
                    .btnExtend.BaseColor = Color.FromArgb(209, 54, 57)
                    .btnExtend.Text = "Delete"
                End With
            Next
        End If

    End Sub

    Private Sub btnAppSetting_Click(sender As Object, e As EventArgs)
        ShadowForm.Show()
        Settings.ShowDialog()
        ShadowForm.Close()
    End Sub

    Private Sub btnSale_Click_1(sender As Object, e As EventArgs) Handles btnSale.Click
        TabControlSales.SelectedTab = PageSales
        btnSalesSummary.PerformClick()
    End Sub

    Public page As Integer
    Public search As Boolean = False
    Public DateSearch As Boolean = False
    Private rowSpacing As Integer = 20

    Private Sub btnSalesSummary_Click(sender As Object, e As EventArgs) Handles btnSalesSummary.Click

        btnSalesPrev.Visible = False
        'reset page
        page = 0
        Me.search = False
        Me.DateSearch = False
        Me.searchS = Nothing
        Me.dateFrom = Nothing
        Me.dateTo = Nothing
        Dim query As String = "select * from tblSales ORDER BY customerID + 0 ASC"
        SalesData(rowSpacing, query)

    End Sub

    Public Sub SalesData(ByVal spacing As Integer, ByVal query As String)

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim command As New SqlCommand(query, c)
            Dim reader As SqlDataReader = command.ExecuteReader

            pnlSalesRecord.Controls.Clear()

            Dim ctr As Integer = 0
            Dim listOfControl As New List(Of SaleRecordControl)

            While reader.Read

                If (ctr >= (page * spacing) And ctr <= ((page * spacing) + spacing)) Then
                    Dim control As New SaleRecordControl
                    With control
                        .Margin = New Padding(1)
                        .Dock = DockStyle.Top

                        .lblCustomerID.Text = reader.GetString(0).Trim
                        .lblCustomerName.Text = reader.GetString(1).Trim
                        .lblComputerNumber.Text = reader.GetString(2).Trim
                        .lblTimeAmmount.Text = reader.GetString(3).Trim
                        .lblAction.Text = reader.GetString(4).Trim
                        .lblProfit.Text = reader.GetString(5).Trim
                        .lblDate.Text = Format(reader.GetDateTime(6), "MM-dd-yyyy")

                    End With
                    listOfControl.Add(control)
                End If

                If ctr > ((page * spacing) + spacing) Then
                    Exit While
                End If

                ctr += 1
            End While

            If page <> 0 Then
                btnSalesPrev.Visible = True
            End If

            If listOfControl.Count <= spacing Then
                btnSalesNext.Visible = False
            Else
                btnSalesNext.Visible = True
            End If

            listOfControl.Reverse()
            For Each control As SaleRecordControl In listOfControl
                pnlSalesRecord.Controls.Add(control)
            Next

        Else
            MsgBox("SQL Connection failed.", vbCritical, "Database Connection")
        End If

    End Sub

    Private Sub btnSalesDay_Click(sender As Object, e As EventArgs) Handles btnSalesDay.Click
        btnSalesPrev.Visible = False
        'reset page
        page = 0
        Me.search = False
        Me.DateSearch = False
        Me.searchS = Nothing
        Me.dateFrom = Nothing
        Me.dateTo = Nothing

        Dim dateNow As DateTime = DateTime.Now
        Dim startDatetime As DateTime = dateNow.Date
        Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)

        Dim query As String = "select * from tblSales where date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
        SalesData(rowSpacing, query)
    End Sub

    Private Sub btnSalesWeek_Click(sender As Object, e As EventArgs) Handles btnSalesWeek.Click
        btnSalesPrev.Visible = False
        'reset page
        page = 0
        Me.search = False
        Me.DateSearch = False
        Me.searchS = Nothing
        Me.dateFrom = Nothing
        Me.dateTo = Nothing

        Dim dayOfWeek As Integer = CInt(DateTime.Today.DayOfWeek)
        Dim startOfWeek As Date = DateTime.Today.AddDays(-1 * dayOfWeek)
        Dim endOfWeek As Date = DateTime.Today.AddDays(7 - dayOfWeek).AddSeconds(-1)
        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfWeek & "'AND '" & endOfWeek & "' ORDER BY customerID + 0 ASC"
        SalesData(rowSpacing, query)

    End Sub

    Private Sub btnSalesMonth_Click(sender As Object, e As EventArgs) Handles btnSalesMonth.Click
        btnSalesPrev.Visible = False
        'reset page
        page = 0
        Me.search = False
        Me.DateSearch = False
        Me.searchS = Nothing
        Me.dateFrom = Nothing
        Me.dateTo = Nothing

        Dim dateNow As DateTime = Date.Now
        Dim startOfMonth As DateTime = New DateTime(dateNow.Year, dateNow.Month, 1) 'start of month 12:00:00 AM
        Dim endOfMonth As DateTime = startOfMonth.AddMonths(1).AddSeconds(-1) 'end of month 11:59:59 PM
        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfMonth & "'AND '" & endOfMonth & "' ORDER BY customerID + 0 ASC"
        SalesData(rowSpacing, query)

    End Sub

    Private Sub btnSalesAnnually_Click(sender As Object, e As EventArgs) Handles btnSalesAnnually.Click
        btnSalesPrev.Visible = False
        'reset page
        page = 0
        Me.search = False
        Me.DateSearch = False
        Me.searchS = Nothing
        Me.dateFrom = Nothing
        Me.dateTo = Nothing

        Dim dateNow As DateTime = Date.Now
        Dim startOfYear As DateTime = New DateTime(dateNow.Year, 1, 1)
        Dim endOfYear As DateTime = startOfYear.AddYears(1).AddSeconds(-1) 'end of month 11:59:59 PM
        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfYear & "'AND '" & endOfYear & "' ORDER BY customerID + 0 ASC"
        SalesData(rowSpacing, query)

    End Sub

    Private Sub btnSalesSearch_Click(sender As Object, e As EventArgs)
        btnSalesPrev.Visible = False
        SalesSearch.ShowDialog()
    End Sub

    Public searchS As String = Nothing
    Public dateFrom As String = Nothing
    Public dateTo As String = Nothing

    Private Sub btnSalesNext_Click(sender As Object, e As EventArgs) Handles btnSalesNext.Click

        page += 1
        btnSalesNext.Visible = False
        btnSalesPrev.Visible = False

        'MsgBox(page)
        If search Then
            If searchS IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE customerID LIKE '%" & searchS & "%' OR computerName LIKE '%" & searchS & "%' OR computerNumber LIKE '%" & searchS & "%' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)
            End If
        ElseIf DateSearch Then
            If dateTo IsNot Nothing AndAlso dateFrom IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & dateFrom & "'AND '" & dateTo & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)
            End If
        Else

            If btnSalesSummary.Checked Then

                Dim query As String = "select * from tblSales ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesDay.Checked Then

                Dim dateNow As DateTime = DateTime.Now
                Dim startDatetime As DateTime = dateNow.Date
                Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)
                Dim query As String = "select * from tblSales where date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesWeek.Checked Then

                Dim dayOfWeek As Integer = CInt(DateTime.Today.DayOfWeek)
                Dim startOfWeek As Date = DateTime.Today.AddDays(-1 * dayOfWeek)
                Dim endOfWeek As Date = DateTime.Today.AddDays(7 - dayOfWeek).AddSeconds(-1)
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfWeek & "'AND '" & endOfWeek & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesMonth.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfMonth As DateTime = New DateTime(dateNow.Year, dateNow.Month, 1) 'start of month 12:00:00 AM
                Dim endOfMonth As DateTime = startOfMonth.AddMonths(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfMonth & "'AND '" & endOfMonth & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesAnnually.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfYear As DateTime = New DateTime(dateNow.Year, 1, 1)
                Dim endOfYear As DateTime = startOfYear.AddYears(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfYear & "'AND '" & endOfYear & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            End If

        End If




    End Sub

    Private Sub btnSalesPrev_Click(sender As Object, e As EventArgs) Handles btnSalesPrev.Click
        page -= 1
        btnSalesPrev.Visible = False
        btnSalesNext.Visible = False

        If search Then
            If searchS IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE customerID LIKE '%" & searchS & "%' OR computerName LIKE '%" & searchS & "%' OR computerNumber LIKE '%" & searchS & "%' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)
            End If
        ElseIf DateSearch Then
            If dateTo IsNot Nothing AndAlso dateFrom IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & dateFrom & "'AND '" & dateTo & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)
            End If
        Else

            If btnSalesSummary.Checked Then

                Dim query As String = "select * from tblSales ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesDay.Checked Then

                Dim dateNow As DateTime = DateTime.Now
                Dim startDatetime As DateTime = dateNow.Date
                Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)
                Dim query As String = "select * from tblSales where date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesWeek.Checked Then

                Dim dayOfWeek As Integer = CInt(DateTime.Today.DayOfWeek)
                Dim startOfWeek As Date = DateTime.Today.AddDays(-1 * dayOfWeek)
                Dim endOfWeek As Date = DateTime.Today.AddDays(7 - dayOfWeek).AddSeconds(-1)
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfWeek & "'AND '" & endOfWeek & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesMonth.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfMonth As DateTime = New DateTime(dateNow.Year, dateNow.Month, 1) 'start of month 12:00:00 AM
                Dim endOfMonth As DateTime = startOfMonth.AddMonths(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfMonth & "'AND '" & endOfMonth & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            ElseIf btnSalesAnnually.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfYear As DateTime = New DateTime(dateNow.Year, 1, 1)
                Dim endOfYear As DateTime = startOfYear.AddYears(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfYear & "'AND '" & endOfYear & "' ORDER BY customerID + 0 ASC"
                SalesData(rowSpacing, query)

            End If

        End If

    End Sub

    Private Sub btnSalesChart_Click(sender As Object, e As EventArgs) Handles btnSalesChart.Click
        TabControlSales.SelectedTab = PageChart
        btnChartSummary.PerformClick()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click

        Try
            crtSales.Printing.PrintPreview()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Dim profit As Double
    Dim profitLoss As Double
    Dim overAllProfit As Double

    Private Sub btnChartSummary_Click(sender As Object, e As EventArgs) Handles btnChartSummary.Click

        Dim query As String = "select * from tblSales ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "MM-dd-yyyy"
        ChartData(query, dateFmt)

    End Sub

    Private Sub ChartData(ByVal query As String, ByVal dateFormat As String)

        Dim connection As New SqlConnection(sqlConnection)
        crtSales.Series("Profit").Points.Clear()

        If checkSQLConnection(connection) Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim command As New SqlCommand(query, c)
            Dim reader As SqlDataReader = command.ExecuteReader

            profit = 0
            profitLoss = 0
            overAllProfit = 0

            While reader.Read
                Dim recordProfit As Double = CDbl(reader.GetString(5).Trim)
                crtSales.Series("Profit").Points.AddXY(Format(reader.GetDateTime(6), dateFormat), recordProfit)

                If recordProfit > 0 Then
                    profit += recordProfit
                Else
                    profitLoss += recordProfit
                End If
            End While

            overAllProfit = profitLoss + profit

            lblProfitLoss.Text = profitLoss.ToString("N2")
            lblProfit.Text = profit.ToString("N2")
            lblOverAllProfit.Text = overAllProfit.ToString("N2")

        Else
            MsgBox("SQL Connection failed.", vbCritical, "Database Connection")
        End If

    End Sub

    Private Sub btnChartDaily_Click(sender As Object, e As EventArgs) Handles btnChartDaily.Click

        Dim dateNow As DateTime = DateTime.Now
        Dim startDatetime As DateTime = dateNow.Date
        Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)

        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "hh:mm:ss tt"
        ChartData(query, dateFmt)

    End Sub

    Private Sub btnChartWeekly_Click(sender As Object, e As EventArgs) Handles btnChartWeekly.Click

        Dim dayOfWeek As Integer = CInt(DateTime.Today.DayOfWeek)
        Dim startOfWeek As Date = DateTime.Today.AddDays(-1 * dayOfWeek)
        Dim endOfWeek As Date = DateTime.Today.AddDays(7 - dayOfWeek).AddSeconds(-1)

        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfWeek & "' AND '" & endOfWeek & "' ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "MMMM-dd-yyyy"
        ChartData(query, dateFmt)

    End Sub

    Private Sub btnChartMonthly_Click(sender As Object, e As EventArgs) Handles btnChartMonthly.Click

        Dim dateNow As DateTime = Date.Now
        Dim startOfMonth As DateTime = New DateTime(dateNow.Year, dateNow.Month, 1) 'start of month 12:00:00 AM
        Dim endOfMonth As DateTime = startOfMonth.AddMonths(1).AddSeconds(-1) 'end of month 11:59:59 PM

        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfMonth & "' AND '" & endOfMonth & "' ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "MMMM-yyyy"
        ChartData(query, dateFmt)

    End Sub

    Private Sub btnChartAnnually_Click(sender As Object, e As EventArgs) Handles btnChartAnnually.Click

        Dim dateNow As DateTime = Date.Now
        Dim startOfYear As DateTime = New DateTime(dateNow.Year, 1, 1)
        Dim endOfYear As DateTime = startOfYear.AddYears(1).AddSeconds(-1) 'end of month 11:59:59 PM

        Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfYear & "' AND '" & endOfYear & "' ORDER BY customerID + 0 ASC"
        Dim dateFmt As String = "yyyy"
        ChartData(query, dateFmt)

    End Sub

    Private Sub btnSalesPrint_Click(sender As Object, e As EventArgs) Handles btnSalesPrint.Click

        If search Then
            If searchS IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE customerID LIKE '%" & searchS & "%' OR computerName LIKE '%" & searchS & "%' OR computerNumber LIKE '%" & searchS & "%' ORDER BY customerID + 0 ASC"
                ReportData(query)
            End If
        ElseIf DateSearch Then
            If dateTo IsNot Nothing AndAlso dateFrom IsNot Nothing Then
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & dateFrom & "'AND '" & dateTo & "' ORDER BY customerID + 0 ASC"
                ReportData(query)
            End If
        Else

            If btnSalesSummary.Checked Then

                Dim query As String = "select * from tblSales ORDER BY customerID + 0 ASC"
                ReportData(query)

            ElseIf btnSalesDay.Checked Then

                Dim dateNow As DateTime = DateTime.Now
                Dim startDatetime As DateTime = dateNow.Date
                Dim endDateTime As DateTime = dateNow.Date.AddDays(1).AddSeconds(-1)
                Dim query As String = "select * from tblSales where date BETWEEN '" & startDatetime & "' AND '" & endDateTime & "' ORDER BY customerID + 0 ASC"
                ReportData(query)

            ElseIf btnSalesWeek.Checked Then

                Dim dayOfWeek As Integer = CInt(DateTime.Today.DayOfWeek)
                Dim startOfWeek As Date = DateTime.Today.AddDays(-1 * dayOfWeek)
                Dim endOfWeek As Date = DateTime.Today.AddDays(7 - dayOfWeek).AddSeconds(-1)
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfWeek & "'AND '" & endOfWeek & "' ORDER BY customerID + 0 ASC"
                ReportData(query)

            ElseIf btnSalesMonth.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfMonth As DateTime = New DateTime(dateNow.Year, dateNow.Month, 1) 'start of month 12:00:00 AM
                Dim endOfMonth As DateTime = startOfMonth.AddMonths(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfMonth & "'AND '" & endOfMonth & "' ORDER BY customerID + 0 ASC"
                ReportData(query)

            ElseIf btnSalesAnnually.Checked Then

                Dim dateNow As DateTime = Date.Now
                Dim startOfYear As DateTime = New DateTime(dateNow.Year, 1, 1)
                Dim endOfYear As DateTime = startOfYear.AddYears(1).AddSeconds(-1) 'end of month 11:59:59 PM
                Dim query As String = "SELECT * FROM tblSales WHERE date BETWEEN '" & startOfYear & "'AND '" & endOfYear & "' ORDER BY customerID + 0 ASC"
                ReportData(query)

            End If

        End If




    End Sub

    Private Sub ReportData(ByVal query As String)

        Dim c As New SqlConnection(sqlConnection)
        c.Open()

        Dim command As New SqlCommand(query, c)
        Dim reader As SqlDataReader = command.ExecuteReader

        Dim ctr As Integer = 0

        Dim cs As New SqlConnection(sqlConnection)
        cs.Open()

        While reader.Read

            Dim search As New SqlDataAdapter("SELECT * FROM tblReport WHERE computerName='" & reader.GetString(1) & "'", cs)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then

                Dim edit As New SqlCommand("Update tblReport set profit=@profit, date=@date where computerName=@computerName", cs)

                edit.Parameters.AddWithValue("@profit", CDbl(table.Rows(0)(3).ToString.Trim) + CDbl(reader.GetString(5).Trim))
                edit.Parameters.AddWithValue("@date", reader.GetDateTime(6))
                edit.Parameters.AddWithValue("@computerName", reader.GetString(1))
                edit.ExecuteNonQuery()

            Else

                Dim save As New SqlCommand("insert into tblReport (id, computerName, computerNo, profit, date) values (@id, @computerName, @computerNo, @profit, @date)", cs)
                save.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = ctr
                save.Parameters.Add(New SqlParameter("@computerName", SqlDbType.NChar)).Value = reader.GetString(1)
                save.Parameters.Add(New SqlParameter("@computerNo", SqlDbType.NChar)).Value = reader.GetString(2)
                save.Parameters.Add(New SqlParameter("@profit", SqlDbType.NChar)).Value = reader.GetString(5)
                save.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = reader.GetDateTime(6)
                save.ExecuteNonQuery()

            End If

            ctr += 1
        End While

        ReportForm.ShowDialog()

        cs.Close()
        c.Close()

        Dim dc As New SqlConnection(sqlConnection)
        dc.Open()

        Dim deleteCmd As New SqlCommand("DELETE FROM tblReport", dc)
        deleteCmd.ExecuteNonQuery()

        dc.Close()

    End Sub

    Private Sub btnScreenBroadcast_Click(sender As Object, e As EventArgs) Handles btnScreenBroadcast.Click

        If ClientControls.Count > 0 Then

            If btnScreenBroadcast.Checked Then

                'ENABLE INFROM BROADCAST
                For Each control As ClientControl1 In ClientControls
                    control.addQueue(Information.InformScreenBroadcast(True))
                Next

                btnScreenBroadcast.Text = "Screen Broadcast Off"
                Thrd_ScreenShare.RunWorkerAsync()

                MsgBox("Broadcasting Started!", vbInformation, "Screen Broadcast")

            Else

                Thrd_ScreenShare.CancelAsync()
                'DISABLE INFROM BROADCAST
                For Each control As ClientControl1 In ClientControls
                    control.addQueue(Information.InformScreenBroadcast(False))
                Next
                btnScreenBroadcast.Text = "Screen Broadcast On"

                MsgBox("Broadcasting ended!", vbInformation, "Screen Broadcast")

            End If

        Else
            MsgBox("There's no client connected.", vbInformation, "No clients available")
        End If


    End Sub

    Private Sub Thrd_ScreenShare_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thrd_ScreenShare.DoWork

        While True

            Dim screendata As String = Information.SendScreen()

            Try
                For Each control As ClientControl1 In ClientControls
                    control.addQueue(screendata)
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message & " Broadcasting error!")
            End Try

            If Thrd_ScreenShare.CancellationPending Then
                e.Cancel = True
                Return
            End If

        End While

    End Sub

    Private Sub btnShowChart_Click(sender As Object, e As EventArgs) Handles btnShowChart.Click
        btnSalesChart.PerformClick()
    End Sub

    Private Sub btnVouchers_Click(sender As Object, e As EventArgs) Handles btnVouchers.Click
        TabControlSales.SelectedTab = PageVoucher
        refreshVoucher()
    End Sub

    Private Sub btnAddVoucher_Click(sender As Object, e As EventArgs) Handles btnAddVoucher.Click
        ShadowForm.Show()
        VoucherForm.ShowDialog()
        ShadowForm.Close()
    End Sub

    Public Sub refreshVoucher()

        Dim c As New SqlConnection(sqlConnection)
        c.Open()

        Dim command As New SqlCommand("SELECT * FROM tblvouch", c)
        Dim reader As SqlDataReader = command.ExecuteReader

        flpVoucher.Controls.Clear()
        While reader.Read

            Dim vouchC As New VouchControl

            With vouchC
                .setVouchId(Val(reader.GetString(0)))
                .Margin = New Padding(0)
                .Width = .Width - 20

                .lblVoucherID.Text = reader.GetString(0)
                .lblUsername.Text = reader.GetString(1)
                .lblPassword.Text = reader.GetString(2)
                .lblTime.Text = reader.GetString(3)
            End With

            flpVoucher.Controls.Add(vouchC)

        End While
        c.Close()

    End Sub

    Public Sub DeleteVouchID(ByVal id As Integer, ByVal computerName As String, ByVal computerNumber As Integer, ByVal time As String)

        Dim dc As New SqlConnection(sqlConnection)
        dc.Open()

        Dim search As New SqlDataAdapter("select * from tblSales", dc)
        Dim table As New DataTable
        search.Fill(table)

        Dim addRecord As New SqlCommand("insert into tblSales (customerID, costumerName, computerNumber, timeAmmount, action, profit, date) values (@customerID, @costumerName, @computerNumber, @timeAmmount, @action, @profit, @date)", dc)
        addRecord.Parameters.Add(New SqlParameter("@customerID", SqlDbType.NChar)).Value = table.Rows.Count + 1
        addRecord.Parameters.Add(New SqlParameter("@costumerName", SqlDbType.NVarChar)).Value = computerName
        addRecord.Parameters.Add(New SqlParameter("@computerNumber", SqlDbType.NChar)).Value = computerNumber
        addRecord.Parameters.Add(New SqlParameter("@timeAmmount", SqlDbType.NVarChar)).Value = time
        addRecord.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Voucher"

        Dim timeA() As String = time.Split(":")
        Dim hour As Integer = Convert.ToInt32(timeA(0))
        Dim min As Integer = Convert.ToInt32(timeA(1))

        Dim price As Double = ((hour * 60) + min) * Settings.getPricePerMinute()

        addRecord.Parameters.Add(New SqlParameter("@profit", SqlDbType.NChar)).Value = price.ToString("N2")
        addRecord.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Date.Now
        addRecord.ExecuteNonQuery()

        Dim deleteCmd As New SqlCommand("DELETE FROM tblvouch WHERE vouchID='" & id & "'", dc)
        deleteCmd.ExecuteNonQuery()

        dc.Close()

        refreshVoucher()

    End Sub

    Public Sub DeleteVouchID(ByVal id As Integer)
        Dim dc As New SqlConnection(sqlConnection)
        dc.Open()

        Dim deleteCmd As New SqlCommand("DELETE FROM tblvouch WHERE vouchID='" & id & "'", dc)
        deleteCmd.ExecuteNonQuery()

        dc.Close()
        refreshVoucher()
    End Sub

    Private Sub btnPrintVouch_Click(sender As Object, e As EventArgs) Handles btnPrintVouch.Click
        VouchReportForm.Show()
    End Sub

    Private Sub btnRecordSearch_Click(sender As Object, e As EventArgs) Handles btnRecordSearch.Click

        If Not (txtSearch.Text.Contains("'") Or txtSearch.Text.Contains("""")) Then
            btnSalesPrev.Visible = False
            page = 0
            search = True
            DateSearch = False

            Dim query As String = "SELECT * FROM tblSales WHERE customerID LIKE '%" & txtSearch.Text & "%' OR computerName LIKE '%" & txtSearch.Text & "%' OR computerNumber LIKE '%" & txtSearch.Text & "%' ORDER BY customerID + 0 ASC"
            searchS = txtSearch.Text
            SalesData(rowSpacing, query)
        Else
            MsgBox("Single or double quote is prohibited.", vbInformation)
            txtSearch.Text = ""
            txtSearch.Select()
        End If

    End Sub

    Private Sub txtSearch_Enter(sender As Object, e As EventArgs) Handles txtSearch.Enter
        txtSearch.Text = ""
    End Sub

    Private Sub btnDateSearch_Click(sender As Object, e As EventArgs) Handles btnDateSearch.Click
        SalesSearch.ShowDialog()
    End Sub

    Private Sub txtMessage_Enter(sender As Object, e As EventArgs) Handles txtMessage.Enter
        txtMessage.Text = ""
        txtMessage.ForeColor = Color.Black
    End Sub

    Private Sub txtMessage_Leave(sender As Object, e As EventArgs) Handles txtMessage.Leave
        If txtMessage.Text = "" Then
            txtMessage.Text = "Aa"
            txtMessage.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtMessage_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMessage.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not txtMessage.Text = "" Then
                btnSendMessage.PerformClick()
            End If
        End If
    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))
            Dim startPoint As New Point(0, Panel4.Height - 1)
            Dim endPoint As New Point(Me.Width, Panel4.Height - 1)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))

            'Dim startPoint() As Point = {New Point(0, 0), New Point(0, 0), New Point(0, Me.Height - 1), New Point(Me.Width - 1, 0)}
            'Dim endPoint() As Point = {New Point(Me.Width - 1, 0), New Point(0, Me.Height - 1), New Point(Me.Width - 1, Me.Height - 1), New Point(Me.Width - 1, Me.Height - 1)}

            'For i As Integer = 0 To startPoint.Length - 1
            '    g.DrawLine(p, startPoint(i), endPoint(i))
            'Next

        End Using
    End Sub

    Private Sub cbSort_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSort.SelectedIndexChanged

        Try
            sortTimeControlBy(cbSort.SelectedIndex)
        Catch ex As Exception
            Console.WriteLine(ex.Message & " sort error.")
        End Try

    End Sub

    Private Sub sortTimeControlBy(ByVal i As Integer)

        flpMonitorTimer.Controls.Clear()

        If i = 0 Then
            'ALL CONTROLS
            For Each control As ClientControl1 In ClientControls
                Me.Invoke(Sub()
                              flpMonitorTimer.Controls.Add(control.getTimeControl())
                          End Sub)
            Next
        ElseIf i = 1 Then

            'VACANT
            For Each control As ClientControl1 In ClientControls
                Dim timeControl As ClientTimeControl = control.getTimeControl()
                If Not timeControl.isOntime() Then
                    Me.Invoke(Sub()
                                  flpMonitorTimer.Controls.Add(control.getTimeControl())
                              End Sub)
                End If
            Next

        ElseIf i = 2 Then
            'IN USE
            For Each control As ClientControl1 In ClientControls
                Dim timeControl As ClientTimeControl = control.getTimeControl()
                If timeControl.isOntime() Then
                    Me.Invoke(Sub()
                                  flpMonitorTimer.Controls.Add(control.getTimeControl())
                              End Sub)
                End If
            Next

        End If

    End Sub

    Private Sub txtSearch_Leave(sender As Object, e As EventArgs) Handles txtSearch.Leave

        If txtSearch.Text = "" Then
            txtSearch.Text = "Click here to search records, or click the date icon to search between dates"
        End If

    End Sub

    Private Sub btnUnlockAllClients_Click(sender As Object, e As EventArgs) Handles btnUnlockAllClients.Click

        While True

            Try
                If ClientControls.Count > 0 Then
                    For Each client As ClientControl1 In ClientControls
                        client.UnlockToolStripMenuItem.PerformClick()
                    Next
                Else
                    MsgBox("There's no client connected.", vbCritical, "Invalid Action")
                End If

                Exit While
            Catch ex As Exception

            End Try

        End While

    End Sub

    Public Sub UpdateUserProfile(ByVal imgbyte As Byte(), ByVal accId As Integer)

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then
            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Console.WriteLine("Account id: " & accId)

            Dim update As New SqlCommand("UPDATE tblaccount SET AccImg=@AccImg WHERE AccID=@AccID", connection)
            update.Parameters.AddWithValue("@AccID", accId)
            update.Parameters.AddWithValue("@AccImg", imgbyte)
            update.ExecuteNonQuery()

            Console.WriteLine("Profile changed successfully!")

        End If

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click

        If Me.WindowState = FormWindowState.Minimized Then
            Me.WindowState = FormWindowState.Minimized
        End If

    End Sub
End Class
