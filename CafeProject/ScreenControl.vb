Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Threading

Public Class ScreenControl

    'Private Declare Function GetAsyncKeyState Lib "user32" (ByVal key As Integer) As Short
    Private parentControl As ClientControl1 = Nothing

    Dim MouseP As Point = Nothing
    Dim MouseL As Boolean = False
    Dim MouseM As Boolean = False
    Dim MouseR As Boolean = False

    Dim key As String = Nothing

    Dim running As Boolean = True
    Dim isStreaming As Boolean = False
    Dim enableControl As Boolean = True

    Public FPS As Integer = 0
    Public NetSpeed As Long = 0

    Public Sub setParentControl(ByVal control As ClientControl1)
        Me.parentControl = control
    End Sub

    Private Sub ScreenControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmStatus.Start()
        parentControl.addQueue(Information.RequestRealtimeScreenShare(True))
        Thrd_RemoteControl.RunWorkerAsync()
    End Sub

    Private Sub ScreenControl_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        parentControl.isScreenControling = False
        parentControl.addQueue(Information.RequestRealtimeScreenShare(False))
        parentControl.setScreenControl(Nothing)

        'reset the stream status
        If isStreaming Then
            mniShareEveryone.PerformClick()
        End If

        running = False
        Thrd_RemoteControl.CancelAsync()
        'Me.Dispose()

    End Sub

    Private Sub Thrd_RemoteControl_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Thrd_RemoteControl.DoWork

        Try

            While running

                If enableControl Then
                    'CREATING REMOTE DATA OBJECT TO SET DATA INSIDE.
                    Dim Rdata As New RemoteData

                    Rdata.MousePosition = MouseP
                    Rdata.MouseLEFT = MouseL
                    Rdata.MouseMIDDLE = MouseM
                    Rdata.MouseRIGHT = MouseR
                    Rdata.keyPRESS = key

                    'SERIALIZING THE OBJECT TO STRING
                    Dim Robj As String = Class1.SerializeObject(Of RemoteData)(Rdata)

                    'CREATING EXTENSION OBJECT TO SET AN EXTENSION TO THE SERIRIALIZED CLASS / OBJECT.
                    Dim extData As New ObjectExtension
                    extData.Extension = ".remote"
                    extData.ClassObject = Robj

                    'FINALLY SERIRIALIZING THE EXTENSION OBJECT AND SENDING IT TO THE CLIENT. 
                    Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

                    'SEND DATA TO CLIENT
                    parentControl.addQueue(extObj)

                    Thread.Sleep(100)
                Else
                    Thread.Sleep(1000)
                End If

                If e.Cancel Then
                    Return
                End If

            End While

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub

    Private Sub pbClientScreen_MouseMove(sender As Object, e As MouseEventArgs) Handles pbClientScreen.MouseMove
        If enableControl Then
            MouseP = New Point(e.X, e.Y)
        End If
    End Sub

    Private Sub pbClientScreen_MouseDown(sender As Object, e As MouseEventArgs) Handles pbClientScreen.MouseDown
        If enableControl Then
            Select Case e.Button
                Case MouseButtons.Left
                    MouseL = True
                Case MouseButtons.Middle
                    MouseM = True
                Case MouseButtons.Right
                    MouseR = True
            End Select
        End If
    End Sub

    Private Sub pbClientScreen_MouseUp(sender As Object, e As MouseEventArgs) Handles pbClientScreen.MouseUp
        If enableControl Then
            Select Case e.Button
                Case MouseButtons.Left
                    MouseL = False
                Case MouseButtons.Middle
                    MouseM = False
                Case MouseButtons.Right
                    MouseR = False
            End Select
        End If
    End Sub

    Private Sub ScreenControl_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If enableControl Then
            'SPACE BUTTOn
            If e.KeyCode = Keys.Space Then
                key = "{SPACE}"
            End If

            'BACKSPACE BUTTON
            If e.KeyCode = Keys.Back Then
                key = "{BKSP}"
            End If

            'ENTER BUTTON
            If e.KeyCode = Keys.Enter Then
                key = "{ENTER}"
            End If

            'SELECT ALL
            If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.A Then
                key = "^(A)"
                Console.WriteLine("ctl + A")
            End If

            'COPY
            If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.C Then
                key = "^(C)"
                Console.WriteLine("ctl + C")
            End If

            'PASTE
            If e.Modifiers = Keys.Control AndAlso e.KeyCode = Keys.V Then
                key = "^(V)"
                Console.WriteLine("ctl + V")
            End If

            'DELETE
            If e.KeyCode = Keys.Delete Then
                key = "{DEL}"
                Console.WriteLine("delete")
            End If

            'Console.WriteLine(e.KeyCode)
        End If
    End Sub

    Private Sub ScreenControl_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        key = Nothing
    End Sub

    Private Sub ScreenControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress

        If enableControl Then
            If Char.IsLetterOrDigit(e.KeyChar) Then
                key = e.KeyChar.ToString
            Else

                If Asc(e.KeyChar) > 32 AndAlso Asc(e.KeyChar) < 127 Then
                    key = "{" & e.KeyChar.ToString & "}"
                End If

            End If
        End If

    End Sub


    Private Sub mniShareEveryone_Click(sender As Object, e As EventArgs) Handles mniShareEveryone.Click

        'check if the server has 2 or more client or it is currently streaming
        'it checks streaming because when it started streaming there's an instance of client disconnection
        'if we tried to stop the stream we cant because it requires 2 or more clients. so we put if it is currently streamming.

        If Main.ClientControls.Count > 1 Or isStreaming Then

            If Not mniShareEveryone.Checked Then

                mniShareEveryone.Checked = True
                isStreaming = True
                Main.btnScreenBroadcast.Visible = False

                'enable infrom broadcast
                For Each control As ClientControl1 In Main.ClientControls
                    If Not control.Equals(parentControl) Then
                        control.addQueue(Information.InformScreenBroadcast(True))
                    End If
                Next

                'start the streaming
                parentControl.setSteam(True)

                MsgBox("Sharing started!", vbInformation, "Client Stream")
            Else
                mniShareEveryone.Checked = False
                isStreaming = False
                Main.btnScreenBroadcast.Visible = False

                'disable infrom broadcast
                For Each control As ClientControl1 In Main.ClientControls
                    If Not control.Equals(parentControl) Then
                        control.addQueue(Information.InformScreenBroadcast(False))
                    End If
                Next

                'stop the straming  
                parentControl.setSteam(False)

                MsgBox("Sharing ended!", vbInformation, "Client Stream")
            End If

        Else
            MsgBox("There are only one client, streaming cannot be done.", vbInformation, "Screen Streaming")
        End If

    End Sub

    Private Sub mniLockComputer_Click(sender As Object, e As EventArgs) Handles mniLockComputer.Click

        If Not mniLockComputer.Checked Then
            mniLockComputer.Checked = True
            'lock the client compter
            parentControl.LockToolStripMenuItem.PerformClick()

        Else
            mniLockComputer.Checked = False
            'unlock the client computer
            parentControl.UnlockToolStripMenuItem.PerformClick()
        End If

    End Sub

    Private Sub mniDisableControl_Click(sender As Object, e As EventArgs) Handles mniDisableControl.Click

        If Not mniDisableControl.Checked Then
            mniDisableControl.Checked = True
            'disable control
            enableControl = False
        Else
            mniDisableControl.Checked = False
            'enable control
            enableControl = True
        End If

    End Sub

    Private Sub mniScreenshot_Click(sender As Object, e As EventArgs) Handles mniScreenshot.Click

        Dim filepath As String = Settings.getScreenShotDirectory() & "\" & parentControl.getEnvironmentName() & ".png"

        Try
            Using bmp As New Bitmap(pbClientScreen.Image)
                Dim ctr As Integer = 1

                While System.IO.File.Exists(filepath)
                    Dim filenameSplit As String() = filepath.Split(".")
                    filepath = filenameSplit(0) & " (" & ctr.ToString & ")." & filenameSplit(1)
                    ctr += 1
                End While

                bmp.Save(filepath)
            End Using

            MsgBox("Image successfully saved.", vbInformation, "Success")
        Catch ex As Exception

            If System.IO.File.Exists(filepath) Then
                System.IO.File.Delete(filepath)
            End If

            MsgBox("There's problem saving the image.", vbCritical, "Failed to save")

        End Try

    End Sub

    Private Sub tmStatus_Tick(sender As Object, e As EventArgs) Handles tmStatus.Tick

        'SPEED CALCULATOR
        Dim ctr As Integer = 0
        Dim sizeTerm As String() = {"B", "KB", "MB", "GB", "TB", "PB"}
        Dim size As Double = Convert.ToDouble(parentControl.screenShareSpeed)

        While size > 1024
            size /= 1024
            ctr += 1
        End While

        If ctr > 5 Then
            ctr = 5
        End If
        '============================================================================

        lblNetworkSpeed.Text = "Network Speed: " & size.ToString("F2") & " " & sizeTerm(ctr) & "/s"
        lblFPS.Text = "FPS: " & FPS.ToString

        parentControl.screenShareSpeed = 0
        FPS = 0

    End Sub
End Class