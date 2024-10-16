Imports System.Collections.Concurrent
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ClientControl1

    Public Property defaultFolderLocation As String = Nothing

    'client informations
    Private client As TcpClient = Nothing
    Private clientScreenResolution As Point = Nothing
    Private controlIndex As Integer = Nothing
    Private EnvironmentName As String = Nothing
    Private ProfileImage As Image = Nothing
    Private ipAddress As String = Nothing
    Private PCNo As String = Nothing

    'checks if the control is started means checking if the control
    'started to do async tasks.
    Private Started As Boolean = False
    Private running As Boolean = True
    Private hasError As Boolean = False
    Private ready As Boolean = False

    'network stream
    Private nw As NetworkStream

    ' STORE THE CONTROLS HERE
    Private MessageControl As ClientMessageControl = Nothing

    Private TimeControl As ClientTimeControl = Nothing
    'Private clientTime As SetClientTime
    'Private Property isAccountActive As Boolean = False
    'Private isGuest As Boolean = False

    Private ScreenControl As ScreenControl = Nothing
    Private ClientScreenControl As ClientScreenControl = Nothing
    Private isStreaming As Boolean = False
    Public isScreenViewing As Boolean = False
    Public isScreenControling As Boolean = False
    Public screenShareSpeed As Long = 0

    Private openFileAndDirectoryBrowser As New ClientFileAndDirectoryBrowser
    Private filesharing As New FileShareForm

    Private maxVal As Long = 0
    Private value As Long = 0
    Public isFileAndDirectoryRequestsReceived As Boolean = False
    Public isFileReceiving As Boolean = False

    Public totalReceivedbytes As Long = 0
    Public totalSentBytes As Long = 0
    Public FileShareSpeed As Long = 0

    Public Function getClient() As TcpClient
        Return Me.client
    End Function

    Public Function getIPAddress() As String
        Return Me.ipAddress
    End Function

    Public Function getProfileImage() As Image
        Return Me.ProfileImage
    End Function

    Public Function getEnvironmentName() As String
        Return Me.EnvironmentName
    End Function

    Public Function getPCNo() As String
        Return Me.PCNo
    End Function

    Public Function getTimeControl() As ClientTimeControl
        Return TimeControl
    End Function

    Public Function getStreamStatus() As Boolean
        Return Me.isStreaming
    End Function

    Public Function getFileBrowser() As ClientFileAndDirectoryBrowser
        Return Me.openFileAndDirectoryBrowser
    End Function

    Public Function getFileShareForm() As FileShareForm
        Return Me.filesharing
    End Function

    Public Function getScreenControl() As ScreenControl
        Return Me.ScreenControl
    End Function

    Public Function isStarted() As Boolean
        Return Me.Started
    End Function

    Public Sub StopClient()
        hasError = True
    End Sub

    Public Sub setNetworkStream(ByVal ns As NetworkStream)
        Me.nw = ns
    End Sub

    Public Sub setTimeControl(ByVal control As ClientTimeControl)
        Me.TimeControl = control
    End Sub

    Public Sub setSteam(ByVal status As Boolean)
        Me.isStreaming = status
    End Sub

    Public Sub setInfo(ByVal tcp As TcpClient, ByVal obj As Object())

        Me.client = tcp
        Me.clientScreenResolution = obj(0)
        Me.ProfileImage = obj(1)
        Me.pbProfile.Image = obj(1)
        Me.EnvironmentName = obj(2)
        Me.lblUsername.Text = obj(2)
        Me.PCNo = obj(3)
        Me.ipAddress = obj(4)
        Me.lblIpAddress.Text = obj(4)

    End Sub

    Public Sub setMessageControl(ByVal control As ClientMessageControl)
        Me.MessageControl = control
    End Sub

    Public Sub setScreenControl(ByVal control As ScreenControl)
        Me.ScreenControl = control
    End Sub

    Public Sub setClientScreenControl(ByVal control As ClientScreenControl)
        Me.ClientScreenControl = control
    End Sub

    Public Sub DefaultFileSharing()
        maxVal = 0
        value = 0
    End Sub

    Dim CDataQueue As New ConcurrentQueue(Of String)

    Public Sub addQueue(ByVal data As String)
        CDataQueue.Enqueue(data)
    End Sub

    Public Async Function StartAsync() As Task

        Dim tasks As New List(Of Task)

        Started = True

        'starting the sending and receiving data.
        tasks.Add(sendDataAsync())
        tasks.Add(ReceiveAndProcessDataAsync())

        If Not Connected() Or hasError Then
            running = False
            Await Task.WhenAll(tasks)
            tasks.Clear()
            Disconnect()
        End If

        'While True

        '    If Not Connected() Or hasError Then
        '        running = False
        '        Await Task.WhenAll(tasks)
        '        Disconnect()
        '        Exit While
        '    End If

        '    Await Task.Delay(1000)
        'End While

        Console.WriteLine("Async work is done.")

    End Function

    Private Function Connected() As Boolean

        Try
            'checks if the client is still readable
            If Me.client.Client.Poll(0, SelectMode.SelectRead) Then
                Dim buff As Byte() = New Byte(0) {}

                'if the response returns 0 then we know that that client disconnects.
                Try
                    If Me.client.Client.Receive(buff, SocketFlags.Peek) = 0 Then
                        Return False
                    End If
                Catch ex As Exception
                    Return False
                End Try

            End If

            Return True
        Catch ex As Exception
            Console.WriteLine("MESSAGE: " & ex.Message & "   STACKSTRACE: " & ex.StackTrace & " Connected function error")
            Return False
        End Try

    End Function

    Private Async Function sendDataAsync() As Task

        Console.WriteLine("Send data started!")

        Try

            While running

                If Not Main.ServerRunning Then
                    Return
                End If

                'checks if the client is ready.
                If ready Then
                    'Emptying the queue
                    While CDataQueue.Count > 0
                        If nw IsNot Nothing Then
                            Dim formatter As New BinaryFormatter
                            Dim data As String = Nothing
                            CDataQueue.TryDequeue(data)

                            If data IsNot Nothing Then
                                formatter.Serialize(nw, data)
                            End If
                        End If
                    End While

                    'after emptying rest for 50 milisec.
                    Await Task.Delay(50)
                Else
                    'if not rest for 1 sec.
                    Await Task.Delay(1000)
                End If
            End While

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Console.WriteLine(ex.Message)
            hasError = True
        End Try

    End Function

    'FILE STREAM
    Dim streamWRITE As FileStream

    'CLIENT RECEIVE NETWORK
    Delegate Sub MainDelegate()
    Delegate Sub refreshDir()

    Private Async Function ReceiveAndProcessDataAsync() As Task

        Console.WriteLine("Receiving data started!")

        'CHECKS IF THE CLIENT DISCONECTED FROM THE SERVER
        Try

            While running

                'RETRIEVING DATA FROM CLIENTS
                Dim formatter As New BinaryFormatter
                'waits for the data before proceeding.
                Dim obj As String = formatter.Deserialize(nw)

                'Update ReceivedbyteSpeed
                If totalReceivedbytes >= Long.MaxValue Then
                    totalReceivedbytes = 0
                End If

                totalReceivedbytes += obj.Length

                'DESERIALIZING THE OBJECT RETRIEVED FROM THE NETWORK STREAM
                Dim ext As ObjectExtension = Class1.DeserializeObject(Of ObjectExtension)(obj)

                If Not Main.ServerRunning Then
                    Return
                End If

                If ext.Extension = ".data" Then

                    Dim ClientObj As ClientData = Class1.DeserializeObject(Of ClientData)(ext.ClassObject)

                    'checks if the two display control is active in the application, if it is then we update its status (image or even speed).
                    If ClientScreenControl IsNot Nothing Or ScreenControl IsNot Nothing Then

                        'convert bytearray into image.
                        Dim img As Image = Converter.getImage(ClientObj.display)

                        Me.Invoke(Sub()

                                      If ClientScreenControl IsNot Nothing Then
                                          ClientScreenControl.pbScreen.Image = img
                                      End If

                                      If isScreenViewing Then
                                          OpenClient.pbScreen.Image = img
                                      End If

                                      If isScreenControling Then

                                          ScreenControl.pbClientScreen.Image = img

                                          If isStreaming Then
                                              Try
                                                  For Each control As ClientControl1 In Main.ClientControls
                                                      If Not control.Equals(Me) Then
                                                          'resend the screendata to 
                                                          control.addQueue(Information.SendScreen(ClientObj.display))
                                                      End If
                                                  Next
                                              Catch ex As Exception
                                                  Console.WriteLine("stream refresh")
                                              End Try
                                          End If


                                      End If
                                  End Sub)

                        If ScreenControl IsNot Nothing Then
                            screenShareSpeed += ClientObj.display.Length
                            ScreenControl.FPS += 1
                        End If

                    End If

                    'checks if the client is on Timed then we set new time status.
                    If TimeControl.isOntime() Then
                        'Display client remaining time
                        TimeControl.setTime(ClientObj.timeStatus)

                        Me.Invoke(Sub()
                                      TimeControl.lblTimeRemaining.Text = ClientObj.timeStatus

                                      'checks if the stop time is disabled, it will reneable if the client is ontimed.
                                      If Not TimeControl.btnStopTime.Enabled Then
                                          TimeControl.btnStopTime.Enabled = True
                                      End If
                                  End Sub)

                    End If

                ElseIf ext.Extension = ".time" Then

                    Dim Tobj As TimeData = Class1.DeserializeObject(Of TimeData)(ext.ClassObject)

                    If Tobj.isStopTime Then

                        TimeControl.SetAccountStatus(False)
                        TimeControl.setAccountID(-1)
                        TimeControl.SetOntime(False)

                        Me.Invoke(Sub()
                                      TimeControl.SetDefault()
                                      TimeControl.btnStopTime.Enabled = False

                                      If Not Main.getModeStatus() Then
                                          Me.LockToolStripMenuItem.PerformClick()
                                      End If

                                      'Refresh counter
                                      Main.refreshClientStatus()

                                  End Sub)
                    End If

                ElseIf ext.Extension = ".dir" Then

                    Dim Dobj As DirectoryData = Class1.DeserializeObject(Of DirectoryData)(ext.ClassObject)

                    Me.Invoke(Sub()

                                  openFileAndDirectoryBrowser.FlowLayoutPanel1.Controls.Clear()

                                  For Each dir As String In Dobj.filesAndDirectories

                                      Dim filename As String() = dir.Split("\")
                                      openFileAndDirectoryBrowser.create_File_Control(dir, filename(filename.Count - 1))

                                  Next

                                  If Dobj.isNewRequest Then
                                      openFileAndDirectoryBrowser.currentDirectory = Dobj.rootDirectory
                                  End If

                                  openFileAndDirectoryBrowser.txtDirectory.Text = openFileAndDirectoryBrowser.currentDirectory

                              End Sub)

                    isFileAndDirectoryRequestsReceived = True

                    Console.WriteLine(isFileAndDirectoryRequestsReceived & "request received")

                ElseIf ext.Extension = ".fs" Then

                    Dim fobj As RequestFileShare = Class1.DeserializeObject(Of RequestFileShare)(ext.ClassObject)

                    If fobj.isReady Then

                        Console.WriteLine("total size : " & fobj.totalsize)
                        maxVal = fobj.totalsize
                        Console.WriteLine("maxVal : " & maxVal)

                        Me.Invoke(Sub()

                                      filesharing.progFiles.Value = Converter.computePercentage(0, maxVal)
                                      filesharing.progFiles.Maximum = 100
                                      filesharing.lblFileName.Text = "Receiving files..."
                                      filesharing.totalfilesize = Converter.CalculateBytes(fobj.totalsize).Replace("/s", "")
                                      filesharing.lblByte.Text = "0 B / " & filesharing.totalfilesize
                                      filesharing.lblPercentage.Text = "0%"

                                  End Sub)

                        Dim rootfolder As String = Directory.GetDirectoryRoot(Settings.getDefaultFolderLocation)

                        If Information.haveFreeSpace(rootfolder, fobj.totalsize) Then

                            If fobj.isSingletype Then
                                addQueue(Information.Accept_FileSharing(True, True))
                            Else
                                addQueue(Information.Accept_FileSharing(True, False))
                            End If

                        Else

                            Console.WriteLine("out of space ")
                            Me.Invoke(Sub()
                                          CustomMessageBox.MessageBox("Insufficient Space", "Action cannot be done, Insufficient disk space for root Folder " & rootfolder & " .", True)
                                          CustomMessageBox.Show()
                                      End Sub)

                        End If

                    End If

                    If fobj.isFileNotExist Then

                        Me.Invoke(Sub()

                                      filesharing.progFiles.Value = 0
                                      filesharing.progFiles.Maximum = 0
                                      filesharing.lblFileName.Text = "File not exists, maybe it deleted or moved to another directory."
                                      filesharing.lblByte.Text = "0 / " & 0
                                      filesharing.lblPercentage.Text = filesharing.progFiles.Value & "%"

                                      filesharing.Hide()


                                  End Sub)

                        Console.WriteLine("File not exists, maybe it deleted or moved to another directory.")

                    End If

                ElseIf ext.Extension = ".file" Then

                    'CONVERTING THE STRING CLASSOBJECT FROM EXTENSION AND DESERIALIZING IT TO FILE DATA CLASS
                    Dim FData As fileData = Class1.DeserializeObject(Of fileData)(ext.ClassObject)

                    If isFileReceiving Then

                        If FData.isFolder Then

                            Dim createFolder As String = defaultFolderLocation & FData.fullpath

                            If Not Directory.Exists(createFolder) Then
                                Directory.CreateDirectory(createFolder)
                            End If

                        Else

                            If FData.isCreateFile Then

                                Dim CreateFile As String = defaultFolderLocation & FData.fullpath

                                Me.Invoke(Sub()
                                              filesharing.lblFileName.Text = "Receiving file : " & FData.fileName
                                          End Sub)

                                If Not File.Exists(CreateFile) Then
                                    Console.WriteLine("NOT EXIST: " & CreateFile)
                                    streamWRITE = New FileStream(CreateFile, FileMode.Create, FileAccess.Write)
                                Else

                                    Dim ctr As Integer = 1
                                    Dim removeExtsn As String() = Path.GetFileName(CreateFile).Split(".")
                                    Dim newFilename As String = Nothing

                                    While File.Exists(CreateFile)

                                        If removeExtsn.Length > 2 Then
                                            For i As Integer = 0 To removeExtsn.Length - 1
                                                If i <> removeExtsn.Length - 1 Then
                                                    newFilename += removeExtsn(i) + "."
                                                Else
                                                    newFilename += " (" & ctr.ToString & ")." & removeExtsn(i)
                                                End If
                                            Next
                                        Else
                                            newFilename = removeExtsn(0) & " (" & ctr.ToString & ")." & removeExtsn(1)
                                        End If

                                        If FData.folderpath = "" Then
                                            CreateFile = defaultFolderLocation & "\" & newFilename
                                        Else
                                            CreateFile = defaultFolderLocation & FData.folderpath & newFilename
                                        End If

                                        ctr += 1

                                    End While

                                    Console.WriteLine("EXISTED: " & CreateFile)
                                    streamWRITE = New FileStream(CreateFile, FileMode.Create, FileAccess.Write)

                                End If

                            End If

                            'if the data is reading then write the received bytes.
                            'else we know that it is done and we need to dispose the streamWrite to write the next file.
                            If FData.isReading Then

                                'the client are reading the file so we write the received byte.
                                If streamWRITE IsNot Nothing Then
                                    streamWRITE.Write(FData.filebyte, 0, FData.bytesRead)
                                End If

                            Else

                                'we know the client is done reading the file
                                If streamWRITE IsNot Nothing Then
                                    streamWRITE.Dispose()
                                    streamWRITE = Nothing
                                End If

                                If FData.isCancelled Then

                                    Me.Invoke(Sub()

                                                  isFileReceiving = False
                                                  filesharing.Hide()
                                                  addQueue(Information.Inform_FileTransferFinished())

                                                  maxVal = 0
                                                  value = 0

                                              End Sub)

                                End If

                            End If

                            If Not FData.isCancelled Then

                                Me.Invoke(Sub()

                                              filesharing.lblByte.Text = Converter.CalculateBytes(value).Replace("/s", "") & " : " & filesharing.totalfilesize
                                              filesharing.progFiles.Value = Converter.computePercentage(value, maxVal)
                                              filesharing.lblPercentage.Text = filesharing.progFiles.Value & "%"

                                              FileShareSpeed += FData.bytesRead
                                              value += FData.bytesRead

                                              If value >= maxVal Then

                                                  isFileReceiving = False
                                                  filesharing.Hide()
                                                  filesharing.tmClientNetworkSpeed.Stop()
                                                  ShadowForm.Close()
                                                  Main.focusMe()

                                                  If streamWRITE IsNot Nothing Then
                                                      streamWRITE.Dispose()
                                                      streamWRITE = Nothing
                                                  End If

                                                  addQueue(Information.Inform_FileTransferFinished())
                                                  'Console.WriteLine("Not FData.isCancelled")

                                                  maxVal = 0
                                                  value = 0
                                                  FileShareSpeed = 0

                                              End If

                                          End Sub)

                            End If

                        End If

                    End If

                ElseIf ext.Extension = ".drive" Then

                    Dim dinfo As DriveInformation = Class1.DeserializeObject(Of DriveInformation)(ext.ClassObject)

                    Me.Invoke(Sub()

                                  openFileAndDirectoryBrowser.clear_Drives()

                                  For Each d As String In dinfo.Drive

                                      Dim info As String() = d.Split(",")
                                      Console.WriteLine(d)
                                      openFileAndDirectoryBrowser.flpSideNav.Controls.Add(openFileAndDirectoryBrowser.Create_Drive(info(0), info(1)))

                                  Next

                              End Sub)

                ElseIf ext.Extension = ".msg" Then

                    Dim msgData As MessageData = Class1.DeserializeObject(Of MessageData)(ext.ClassObject)

                    'making the msgstorage
                    Dim message As New MsgStorage
                    message.isUser = False
                    message.msg = msgData.message
                    message.dateandtime = Format(Date.Now, "MM/dd/yy h:mm tt")

                    'Console.WriteLine("a message recieved from : " & msgData.ToClient)
                    'Console.WriteLine(Main.serverIP.Equals(msgData.ToClient))

                    'checks if the message if to server
                    If Settings.getServerIP.Equals(msgData.ToClient) Then

                        'add the message to the message storage
                        MessageControl.AddMessage(message)

                        Me.Invoke(Sub()
                                      MessageControl.lblMessage.Text = msgData.message

                                      If MessageControl.getTextControl() Is Nothing Then

                                          Dim chatbox As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(Nothing, msgData.message, False)
                                          chatbox.lblName.Text = Me.EnvironmentName
                                          chatbox.lblDateAndTime.Text = message.dateandtime
                                          chatbox.pbImage.Image = Me.ProfileImage
                                          MessageControl.SetTextControl(chatbox)
                                          Main.flpMonitorChat.Controls.Add(chatbox)

                                      Else
                                          If Not MessageControl.getTextControl().isUser() Then
                                              MessageControl.SetTextControl(ManageClientControl.Create_Client_Message_Control(MessageControl.getTextControl(), msgData.message, False))
                                          Else
                                              Dim chatbox As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(Nothing, msgData.message, False)
                                              chatbox.lblName.Text = Me.EnvironmentName
                                              chatbox.lblDateAndTime.Text = message.dateandtime
                                              chatbox.pbImage.Image = Me.ProfileImage
                                              MessageControl.SetTextControl(chatbox)
                                              Main.flpMonitorChat.Controls.Add(chatbox)
                                          End If
                                      End If
                                  End Sub)
                    Else

                        'if the message is not for the server then it will check each controls if the 
                        'IP is matches to that control
                        'when that happens it will just send a message to that client
                        'invoking to the main thread to do the work and proceed doing other work.
                        Me.Invoke(Sub()
                                      For Each control As ClientControl1 In Main.ClientControls
                                          If control.ipAddress.Equals(msgData.ToClient) Then
                                              control.addQueue(Information.SendMessage(msgData.fromClient, msgData.ToClient, msgData.message))
                                          End If
                                      Next
                                  End Sub)

                    End If

                ElseIf ext.Extension = ".login" Then

                    If Main.getModeStatus() Then

                        Dim LogInData As LoginData = Class1.DeserializeObject(Of LoginData)(ext.ClassObject)

                        Dim account As Boolean = False
                        Dim vouch As Boolean = False

                        If LogInData.username.Length > 4 AndAlso LogInData.username.Substring(0, 4).Equals("VCHR") Then
                            vouch = Main.SearchVouch(LogInData.username, LogInData.password)
                        Else
                            account = Main.SearchAccount(LogInData.username, LogInData.password)
                        End If

                        If (account Or vouch) Then
                            'if account exists in the database
                            Dim time As String()

                            If account Then
                                Dim userData As Object() = Main.getAccountData(LogInData.username, LogInData.password)
                                time = userData(6).ToString.Split(":")

                                Me.Invoke(Sub()

                                              TimeControl.setAccountID(Val(userData(0).ToString))
                                              Console.WriteLine("Account ID: " & userData(0).ToString)

                                              'CALCULATING THE STATING TIME OF THE CLIENT AND ENDING TIME AND ALSO DISPLAYING IT IN THE CONTROL
                                              Dim hour As Integer = time(0)
                                              Dim minutes As Integer = time(1)
                                              Dim seconds As Integer = time(2)

                                              If hour = 0 And minutes = 0 And seconds = 0 Then
                                                  addQueue(Information.SendInsufficientTime())
                                              Else
                                                  'DISPLAYING THE STARTING TIME
                                                  Dim t As Date = Date.Now
                                                  Dim currentTime As String = t.ToString("hh:mm:ss tt")
                                                  TimeControl.lblStart.Text = currentTime

                                                  'DISPLAYING THE CLIENT LAST TIME
                                                  Dim totalminutes As Integer = (hour * 60) + minutes
                                                  t = t.AddMinutes(totalminutes)
                                                  t = t.AddSeconds(seconds)
                                                  TimeControl.lblEnd.Text = t.ToString("hh:mm:ss tt")

                                                  'SETTING THE TIME
                                                  TimeControl.lblTimeRemaining.Text = hour.ToString("00") & ":" & minutes.ToString("00") & seconds.ToString("00")
                                                  TimeControl.SetOntime(True)
                                                  TimeControl.SetAccountStatus(True)

                                                  Dim joinedtime As String = time(0) & ":" & time(1) & ":" & time(2)
                                                  TimeControl.setTime(joinedtime)

                                                  'SEND USER DATA TO CLIENT
                                                  addQueue(Information.sendUserData(True, userData))
                                                  addQueue(Information.OpenClient(joinedtime))
                                              End If


                                          End Sub)

                            ElseIf vouch Then

                                time = Main.getVouchTime(LogInData.username, LogInData.password).Split(":")

                                Me.Invoke(Sub()

                                              Dim accountId As Integer = Main.getVouchID(LogInData.username, LogInData.password)
                                              TimeControl.setAccountID(accountId)

                                              'CALCULATING THE STATING TIME OF THE CLIENT AND ENDING TIME AND ALSO DISPLAYING IT IN THE CONTROL
                                              Dim hour As Integer = time(0)
                                              Dim minutes As Integer = time(1)
                                              Dim seconds As Integer = time(2)

                                              Dim t As Date = Date.Now
                                              Dim currentTime As String = t.ToString("hh:mm:ss tt")
                                              TimeControl.lblStart.Text = currentTime

                                              Dim totalminutes As Integer = (hour * 60) + minutes
                                              t = t.AddMinutes(totalminutes)
                                              t = t.AddSeconds(seconds)
                                              TimeControl.lblEnd.Text = t.ToString("hh:mm:ss tt")

                                              'SETTING THE TIME
                                              TimeControl.lblTimeRemaining.Text = hour.ToString("00") & ":" & minutes.ToString("00") & seconds.ToString("00")
                                              TimeControl.SetOntime(True)
                                              TimeControl.SetAccountStatus(False)

                                              Dim joinedtime As String = time(0) & ":" & time(1) & ":" & time(2)
                                              TimeControl.setTime(joinedtime)
                                              addQueue(Information.sendUserData(False, Nothing))
                                              addQueue(Information.OpenClient(joinedtime))

                                              'deletes the voucher id after login.
                                              Dim userTime As String = time(0) & ":" & time(1) & ":" & time(2)
                                              Main.DeleteVouchID(accountId, EnvironmentName, Convert.ToInt32(PCNo), userTime)

                                          End Sub)

                            End If

                            'Refresh counter
                            Me.Invoke(Sub()
                                          Main.refreshClientStatus()
                                      End Sub)

                        Else
                            addQueue(Information.SendInvalidLogin())
                        End If

                    End If

                ElseIf ext.Extension = ".usr" Then

                    Dim usrData As UserData = Class1.DeserializeObject(Of UserData)(ext.ClassObject)

                    Me.Invoke(Sub()
                                  Main.UpdateUserProfile(usrData.profileImage, TimeControl.getID)
                              End Sub)

                    Console.WriteLine("Update data received")

                ElseIf ext.Extension = ".cmd" Then

                    Dim cmdata As CommandData = Class1.DeserializeObject(Of CommandData)(ext.ClassObject)
                    If cmdata.cmd = "/ready" Then
                        Me.ready = True
                        Console.WriteLine("Client Ready")
                    End If

                End If

            End While

        Catch ex As Exception
            Console.WriteLine(ex.StackTrace)
            Console.WriteLine(ex.Message)
            hasError = True
        End Try

        Await Task.Delay(0)

    End Function

    Public Sub Disconnect()

        Try
            Dim mydelegate As New MainDelegate(AddressOf delegateAction)
            Me.Invoke(mydelegate)
        Catch ex As Exception
            Console.WriteLine("MESSAGE: " & ex.Message & vbNewLine & "STACKTRACE: " & ex.StackTrace & " DISCONNECTION ERROR.")
        End Try

    End Sub

    Private Sub delegateAction()

        If Me.client IsNot Nothing Then
            Me.client.Close()
            Me.client = Nothing
        End If

        'removing individual control in the list
        openFileAndDirectoryBrowser.Close()
        filesharing.Close()

        If TimeControl IsNot Nothing Then
            Main.flpMonitorTimer.Controls.Remove(TimeControl)
        End If

        If ClientScreenControl IsNot Nothing Then
            Main.flpMonitorScreen.Controls.Remove(ClientScreenControl)
        End If

        If ScreenControl IsNot Nothing Then
            ScreenControl.Close()
        End If

        If MessageControl IsNot Nothing Then

            If Main.currentContact IsNot Nothing AndAlso Main.currentContact.Equals(MessageControl) Then

                Main.lblContactName.Text = "Contact Name"
                Main.flpMonitorChat.Controls.Clear()
                Main.pnlChatBox.Visible = False
                Main.currentContact = Nothing

            End If

            Main.flpMonitorMessage.Controls.Remove(MessageControl)
        End If

        'checks every active client 
        For Each control As ClientControl1 In Main.ClientControls
            If Not control.ipAddress.Equals(ipAddress) Then
                control.removeContact(ipAddress)
            End If
        Next

        'removing the control and removing the client to the list of clients connected.
        Main.flpMonitorClient.Controls.Remove(Me)
        Main.ClientControls.Remove(Me)

        Console.WriteLine("Client: " & EnvironmentName & " : " & ipAddress & " Disconected.")

        Main.refreshClientStatus()

    End Sub

    Public Sub addContact(ByVal ip As String, ByVal name As String, ByVal profileImg As Image)

        'sending contact data to the client for creating contact
        addQueue(Information.CreateContact(ip, name, profileImg))

    End Sub

    'pwede mo palitan to inform offline imbis na tatanggalin mo sya sa contacts ng client
    Public Sub removeContact(ByVal clientIp As String)

        'sending contact data to the client for removing contact
        addQueue(Information.RemoveContact(clientIp))

    End Sub

    Private Sub AddTimeToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        ShadowForm.Show()
    End Sub

    Private Sub GetFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetFileToolStripMenuItem.Click

        addQueue(Information.Request_Client_Drives)
        addQueue(Information.Request_Client_Directories(True, ""))

        'ShadowForm.MdiParent = Mainform
        ShadowForm.Show()
        ' openFileAndDirectoryBrowser.MdiParent = ShadowForm
        openFileAndDirectoryBrowser.ShowDialog()

    End Sub

    Private Sub LockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockToolStripMenuItem.Click

        addQueue(Information.lockComputer(True))
        LockToolStripMenuItem.Enabled = False
        UnlockToolStripMenuItem.Enabled = True

    End Sub

    Private Sub UnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockToolStripMenuItem.Click

        addQueue(Information.lockComputer(False))
        LockToolStripMenuItem.Enabled = True
        UnlockToolStripMenuItem.Enabled = False

    End Sub

    Private Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to Shutdown 'Computer: " & Me.EnvironmentName & " '?", vbYesNo + vbQuestion, "Action Confirmation")
        If result = MsgBoxResult.Yes Then
            addQueue(Information.shutdown())
        End If

    End Sub

    Private Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to Restart 'Computer: " & Me.EnvironmentName & " '?", vbYesNo + vbQuestion, "Action Confirmation")
        If result = MsgBoxResult.Yes Then
            addQueue(Information.Restart())
        End If

    End Sub

    Private Sub SleepToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SleepToolStripMenuItem.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to put sleep 'Computer: " & Me.EnvironmentName & " '?", vbYesNo + vbQuestion, "Action Confirmation")
        If result = MsgBoxResult.Yes Then
            addQueue(Information.Sleep())
        End If

    End Sub
End Class
