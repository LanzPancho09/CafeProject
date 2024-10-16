Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class Information

    'REQUEST INFORMATION METHOD
    Public Shared Function Request_Information() As String

        'CREATING A COMMAND OBJECT INORDER TO SEND A COMMAND TO A CLIENT.
        Dim cmdObj As New CommandData
        cmdObj.cmd = "/Request_Info"

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING TO BE ABLE TO SEND IN THE CLIENT.
        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        'CREATING A EXTENSION OBJECT CLASS INORDER TO STORE THE SERIALIZED CLASS AND SPECIFY ITS EXTENSION
        'FOR DETERMINING THE OBJECT TO WHAT CLASS TO BE DESERIALIZED FOR.
        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING WITH THE SERIALIZED OBJECT TO BE ABLE TO SEND IN THE CLIENT.
        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function Request_Client_Drives() As String

        Dim cmdobj As New CommandData
        cmdobj.cmd = "Request_Drives"

        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdobj)

        Dim extobj As New ObjectExtension
        extobj.Extension = ".cmd"
        extobj.ClassObject = objData

        Dim extdata As String = Class1.SerializeObject(Of ObjectExtension)(extobj)

        Return extdata

    End Function

    Public Shared Function Request_Client_SpecialFolder_Directory(ByVal specialFolder As String)

        Dim cmdata As New CommandData
        cmdata.cmd = "Request_SpecialFolder_" & specialFolder

        Dim cmdobj As String = Class1.SerializeObject(Of CommandData)(cmdata)

        Dim extsndata As New ObjectExtension
        extsndata.Extension = ".cmd"
        extsndata.ClassObject = cmdobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsndata)

        Return extsnObj

    End Function

    Public Shared Function Request_Client_Directories(ByVal isNewRequest As Boolean, ByVal path As String) As String

        'CREATING A COMMAND OBJECT INORDER TO SEND A COMMAND TO A CLIENT.
        Dim DirObj As New DirectoryData
        DirObj.isNewRequest = isNewRequest
        DirObj.rootDirectory = path

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING TO BE ABLE TO SEND IN THE CLIENT.
        Dim objData As String = Class1.SerializeObject(Of DirectoryData)(DirObj)

        'CREATING A EXTENSION OBJECT CLASS INORDER TO STORE THE SERIALIZED CLASS AND SPECIFY ITS EXTENSION
        'FOR DETERMINING THE OBJECT TO WHAT CLASS TO BE DESERIALIZED FOR.
        Dim extObj As New ObjectExtension
        extObj.Extension = ".dir"
        extObj.ClassObject = objData

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING WITH THE SERIALIZED OBJECT TO BE ABLE TO SEND IN THE CLIENT.
        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Console.WriteLine("directories successfully requested")

        Return extData

    End Function

    Public Shared Function Request_FileSharing(ByVal path As String) As String

        Dim fdata As New RequestFileShare
        fdata.path = path
        fdata.totalsize = 0
        fdata.isNewRequest = True
        fdata.isSingletype = False
        fdata.isReady = False
        fdata.isStarted = False
        fdata.isDenied = False

        Dim fobj As String = Class1.SerializeObject(Of RequestFileShare)(fdata)

        Dim extsnData As New ObjectExtension
        extsnData.Extension = ".fs"
        extsnData.ClassObject = fobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsnData)

        Return extsnObj

    End Function

    Public Shared Function Request_Single_FileSharing(ByVal path As String) As String

        Dim fdata As New RequestFileShare
        fdata.path = path
        fdata.totalsize = 0
        fdata.isNewRequest = True
        fdata.isSingletype = True
        fdata.isReady = False
        fdata.isStarted = False
        fdata.isDenied = False

        Dim fobj As String = Class1.SerializeObject(Of RequestFileShare)(fdata)

        Dim extsnData As New ObjectExtension
        extsnData.Extension = ".fs"
        extsnData.ClassObject = fobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsnData)

        Return extsnObj

    End Function

    Public Shared Function Accept_FileSharing(ByVal status As Boolean, ByVal isSingleFile As Boolean) As String

        Dim fdata As New RequestFileShare

        If status Then
            fdata.isStarted = True
        Else
            fdata.isDenied = True
        End If

        fdata.isSingletype = isSingleFile

        Dim fobj As String = Class1.SerializeObject(Of RequestFileShare)(fdata)

        Dim extsnData As New ObjectExtension
        extsnData.Extension = ".fs"
        extsnData.ClassObject = fobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsnData)

        Return extsnObj

    End Function

    Public Shared Function Inform_FileTransferFinished() As String

        Dim fdata As New RequestFileShare
        fdata.isDone = True

        Dim fobj As String = Class1.SerializeObject(Of RequestFileShare)(fdata)

        Dim extsnData As New ObjectExtension
        extsnData.Extension = ".fs"
        extsnData.ClassObject = fobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsnData)

        Return extsnObj

    End Function

    Public Shared Function Inform_Connected() As String

        'CREATING A COMMAND OBJECT INORDER TO SEND A COMMAND TO A CLIENT.
        Dim cmdObj As New CommandData
        cmdObj.cmd = "/Connected"

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING TO BE ABLE TO SEND IN THE CLIENT.
        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        'CREATING A EXTENSION OBJECT CLASS INORDER TO STORE THE SERIALIZED CLASS AND SPECIFY ITS EXTENSION
        'FOR DETERMINING THE OBJECT TO WHAT CLASS TO BE DESERIALIZED FOR.
        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING WITH THE SERIALIZED OBJECT TO BE ABLE TO SEND IN THE CLIENT.
        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

        ''FINALLY SENDING IT TO THE CLIENT
        'Dim nw As NetworkStream = client.GetStream
        'Dim formatter As New BinaryFormatter
        'formatter.Serialize(nw, extData)

    End Function

    Public Shared Function ClearAdvertisements() As String

        'CREATING A COMMAND OBJECT INORDER TO SEND A COMMAND TO A CLIENT.
        Dim cmdObj As New CommandData
        cmdObj.cmd = "/ClearAds"

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING TO BE ABLE TO SEND IN THE CLIENT.
        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        'CREATING A EXTENSION OBJECT CLASS INORDER TO STORE THE SERIALIZED CLASS AND SPECIFY ITS EXTENSION
        'FOR DETERMINING THE OBJECT TO WHAT CLASS TO BE DESERIALIZED FOR.
        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING WITH THE SERIALIZED OBJECT TO BE ABLE TO SEND IN THE CLIENT.
        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData
    End Function

    Public Shared Function Inform_ServerMode(ByVal isCafeMode As Boolean) As String

        'CREATING A COMMAND OBJECT INORDER TO SEND A COMMAND TO A CLIENT.
        Dim cmdObj As New CommandData

        If isCafeMode Then
            cmdObj.cmd = "/CafeMode"
        Else
            cmdObj.cmd = "/MonitorMode"
        End If

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING TO BE ABLE TO SEND IN THE CLIENT.
        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        'CREATING A EXTENSION OBJECT CLASS INORDER TO STORE THE SERIALIZED CLASS AND SPECIFY ITS EXTENSION
        'FOR DETERMINING THE OBJECT TO WHAT CLASS TO BE DESERIALIZED FOR.
        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        'SERIALIZING (CONVERTING) THE CLASS OBJECT INTO XML STRING WITH THE SERIALIZED OBJECT TO BE ABLE TO SEND IN THE CLIENT.
        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function CancelFileSharing() As String

        Dim fdata As New RequestFileShare
        fdata.path = Nothing
        fdata.totalsize = 0
        fdata.isNewRequest = False
        fdata.isSingletype = False
        fdata.isReady = False
        fdata.isStarted = False
        fdata.isDenied = True

        Dim fobj As String = Class1.SerializeObject(Of RequestFileShare)(fdata)

        Dim extsnData As New ObjectExtension
        extsnData.Extension = ".fs"
        extsnData.ClassObject = fobj

        Dim extsnObj As String = Class1.SerializeObject(Of ObjectExtension)(extsnData)

        Return extsnObj

    End Function

    Public Shared Function SendMessage(ByVal from As String, ByVal sendTo As String, ByVal msg As String) As String

        Dim msgdata As New MessageData
        msgdata.fromClient = from
        msgdata.ToClient = sendTo
        msgdata.message = msg

        Dim msgobj As String = Class1.SerializeObject(Of MessageData)(msgdata)

        Dim objext As New ObjectExtension
        objext.Extension = ".msg"
        objext.ClassObject = msgobj

        Dim objData As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return objData

    End Function

    Public Shared Function CreateContact(ByVal clientIP As String, ByVal clientName As String, ByVal img As Image)

        Dim contdata As New ContactData
        contdata.IP = clientIP
        contdata.ClientName = clientName
        contdata.ClientImage = Converter.setImage(img)
        contdata.isRemove = False

        Dim contobj As String = Class1.SerializeObject(Of ContactData)(contdata)

        Dim objext As New ObjectExtension
        objext.Extension = ".cont"
        objext.ClassObject = contobj

        Dim objdata As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return objdata

    End Function

    Public Shared Function RemoveContact(ByVal ip As String) As String

        Dim contdata As New ContactData
        contdata.IP = ip
        contdata.ClientName = Nothing
        contdata.isRemove = True

        Dim contobj As String = Class1.SerializeObject(Of ContactData)(contdata)

        Dim objext As New ObjectExtension
        objext.Extension = ".cont"
        objext.ClassObject = contobj

        Dim objdata As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return objdata

    End Function


    Public Shared Function getClientIP(ByVal client As TcpClient) As String

        Dim endPoint As IPEndPoint = CType(client.Client.RemoteEndPoint, IPEndPoint)
        ' .. or LocalEndPoint - depending on which end you want to identify

        Dim ipAddress As IPAddress = endPoint.Address

        ' get the hostname
        Dim hostEntry As IPHostEntry = Dns.GetHostEntry(ipAddress)
        Dim hostName As String = hostEntry.HostName

        ' get the port
        Dim port As Integer = endPoint.Port

        'get Ip address
        Dim Address As IPAddress = CType(client.Client.RemoteEndPoint, IPEndPoint).Address

        Return Address.ToString

    End Function

    Public Shared Function haveFreeSpace(ByVal root As String, ByVal neededspace As Long) As Boolean

        'it checks if the drive meet the neededspace requirement

        'checks each available drive in the computer
        For Each drive As DriveInfo In DriveInfo.GetDrives
            'if the root is equal to the drive then check
            If drive.Name.Equals(root) Then
                ' the 104857600 is equivalent to 100mb to prevent the exact needed space for the drive
                If drive.AvailableFreeSpace - 104857600 > neededspace Then
                    Return True
                End If
            End If
        Next

        Return False

    End Function

    Public Shared Function getMyIPAddress() As String

        Dim strHostName As String = Dns.GetHostName()
        Dim hosts() As IPAddress = Dns.GetHostAddresses(strHostName)

        Dim hostAddress As String = Nothing

        For Each address As IPAddress In hosts
            If address.AddressFamily = AddressFamily.InterNetwork Then
                hostAddress = address.ToString
                Console.WriteLine("Host Name: " & strHostName & "; IP Address v4: " & address.ToString)
                Exit For
            End If
        Next

        Return hostAddress

    End Function

    Public Shared Function lockComputer(ByVal Lock As Boolean) As String

        Dim extData As String = Nothing

        If Lock Then

            Dim cmdObj As New CommandData
            cmdObj.cmd = "/Lock"

            Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

            Dim extObj As New ObjectExtension
            extObj.Extension = ".cmd"
            extObj.ClassObject = objData

            extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Else

            Dim cmdObj As New CommandData
            cmdObj.cmd = "/Unlock"

            Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

            Dim extObj As New ObjectExtension
            extObj.Extension = ".cmd"
            extObj.ClassObject = objData

            extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        End If

        Return extData

    End Function

    Public Shared Function RequestRealtimeScreenShare(ByVal status As Boolean) As String

        Dim extData As String = Nothing

        Dim cmdObj As New CommandData

        If status Then
            cmdObj.cmd = "/Request_Realtime_ScreenShare_ON"
        Else
            cmdObj.cmd = "/Request_Realtime_ScreenShare_OFF"
        End If

        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function shutdown() As String

        Dim extData As String = Nothing

        Dim cmdObj As New CommandData
        cmdObj.cmd = "/shutdown"

        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function Restart() As String

        Dim extData As String = Nothing

        Dim cmdObj As New CommandData
        cmdObj.cmd = "/restart"

        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function Sleep() As String

        Dim extData As String = Nothing

        Dim cmdObj As New CommandData
        cmdObj.cmd = "/sleep"

        Dim objData As String = Class1.SerializeObject(Of CommandData)(cmdObj)

        Dim extObj As New ObjectExtension
        extObj.Extension = ".cmd"
        extObj.ClassObject = objData

        extData = Class1.SerializeObject(Of ObjectExtension)(extObj)

        Return extData

    End Function

    Public Shared Function sendUserData(ByVal isAccount As Boolean, ByVal userData As Object()) As String

        Dim ldata As New LoginData
        ldata.isRequest = False
        ldata.isDenied = False

        If isAccount Then
            ldata.isAccount = True
            ldata.userData = userData
        Else
            ldata.isGuest = True
        End If

        Dim Lobj As String = Class1.SerializeObject(Of LoginData)(ldata)

        Dim objext As New ObjectExtension
        objext.ClassObject = Lobj
        objext.Extension = ".login"

        Dim ext As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return ext

    End Function

    Public Shared Function SendInvalidLogin() As String

        Dim ldata As New LoginData
        ldata.isRequest = False
        ldata.isDenied = True

        Dim Lobj As String = Class1.SerializeObject(Of LoginData)(ldata)

        Dim objext As New ObjectExtension
        objext.ClassObject = Lobj
        objext.Extension = ".login"

        Dim ext As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return ext

    End Function

    Public Shared Function SendInsufficientTime() As String

        Dim ldata As New LoginData
        ldata.isRequest = False
        ldata.isDenied = False
        ldata.noTime = True

        Dim Lobj As String = Class1.SerializeObject(Of LoginData)(ldata)

        Dim objext As New ObjectExtension
        objext.ClassObject = Lobj
        objext.Extension = ".login"

        Dim ext As String = Class1.SerializeObject(Of ObjectExtension)(objext)

        Return ext

    End Function

    Public Shared Function OpenClient(ByVal time As String) As String

        'CREATE AN TIME DATA OBJECT AND PASSING ITS VALUE INSIDE.
        Dim tData As New TimeData
        tData.isSetTime = True
        tData.isUpdate = False
        tData.time = time

        'SERIALIZING THE DATA FOR PUTTING IT ON THE EXTENSION OBJECT DATA.
        Dim Tobj As String = Class1.SerializeObject(Of TimeData)(tData)

        'CREATE AN EXTENSION OBJECT AND PASSING ITS VALUE INSIDE.
        Dim extData As New ObjectExtension
        extData.Extension = ".time"
        extData.ClassObject = Tobj

        'SERIALIZING THE DATA FOR SENDING.
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        Return extObj

    End Function

    Public Shared Function SendSplashScreen(ByVal i As Image) As String

        Dim Slide As New SlideShowData
        Slide.image = Converter.setImage(i)

        Dim SlideData As String = Class1.SerializeObject(Of SlideShowData)(Slide)

        Dim ObjExtension As New ObjectExtension
        ObjExtension.ClassObject = SlideData
        ObjExtension.Extension = ".ads"

        Dim extData As String = Class1.SerializeObject(Of ObjectExtension)(ObjExtension)

        Return extData

    End Function

    Public Shared Function SendBlockedWebsites(ByVal w As List(Of String), ByVal isRemove As Boolean) As String

        Dim webData As New WebsiteBlockData
        webData.listOfWebsite = w
        webData.isRemove = isRemove

        Dim webObj As String = Class1.SerializeObject(Of WebsiteBlockData)(webData)

        Dim ObjExtension As New ObjectExtension
        ObjExtension.ClassObject = webObj
        ObjExtension.Extension = ".site"

        Dim extdata As String = Class1.SerializeObject(Of ObjectExtension)(ObjExtension)

        Return extdata

    End Function

    Public Shared Function Stop_Client_Time() As String

        'CREATE AN TIME DATA OBJECT AND PASSING ITS VALUE INSIDE.
        Dim tData As New TimeData
        tData.isStopTime = True

        'SERIALIZING THE DATA FOR PUTTING IT ON THE EXTENSION OBJECT DATA.
        Dim Tobj As String = Class1.SerializeObject(Of TimeData)(tData)

        'CREATE AN EXTENSION OBJECT AND PASSING ITS VALUE INSIDE.
        Dim extData As New ObjectExtension
        extData.Extension = ".time"
        extData.ClassObject = Tobj

        'SERIALIZING THE DATA FOR SENDING.
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        'Console.WriteLine("CLIENT TIME SUCCESSFULLY SET")

        Return extObj

    End Function

    Public Shared Function InformScreenBroadcast(ByVal status As Boolean) As String

        'CREATE A OBJECT TO STORE IMAGE BYTE
        Dim cData As New CommandData

        If status Then
            cData.cmd = "/EnableBroadcast"
        Else
            cData.cmd = "/DisableBroadcast"
        End If

        'SERIALIZE THE OBJECT
        Dim cmdObj As String = Class1.SerializeObject(Of CommandData)(cData)

        'CREATE AN EXTERNAL DATA FOR OBJECT EXTENSION
        Dim extData As New ObjectExtension
        extData.ClassObject = cmdObj
        extData.Extension = ".cmd"

        'SERIALIZE THE OBJECT
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        Return extObj

    End Function

    Public Shared Function SendScreen() As String

        'CREATE A OBJECT TO STORE IMAGE BYTE
        Dim sData As New ScreenData
        sData.imgByte = Converter.setImage(ScreenCap())

        'SERIALIZE THE OBJECT
        Dim sObj As String = Class1.SerializeObject(Of ScreenData)(sData)

        'CREATE AN EXTERNAL DATA FOR OBJECT EXTENSION
        Dim extData As New ObjectExtension
        extData.ClassObject = sObj
        extData.Extension = ".screen"

        'SERIALIZE THE OBJECT
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        Return extObj

    End Function

    Public Shared Function SendScreen(ByVal imgbyte As Byte()) As String

        'CREATE A OBJECT TO STORE IMAGE BYTE
        Dim sData As New ScreenData
        sData.imgByte = imgbyte

        'SERIALIZE THE OBJECT
        Dim sObj As String = Class1.SerializeObject(Of ScreenData)(sData)

        'CREATE AN EXTERNAL DATA FOR OBJECT EXTENSION
        Dim extData As New ObjectExtension
        extData.ClassObject = sObj
        extData.Extension = ".screen"

        'SERIALIZE THE OBJECT
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        Return extObj

    End Function

End Class
