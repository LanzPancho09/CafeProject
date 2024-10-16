Imports System.Net.Sockets

Public Class ClientMessageControl
    'note Message Storage

    Private MainControl As ClientControl1 = Nothing
    Private messages As New List(Of MsgStorage)
    Private txtMessageControl As ChatBoxControl = Nothing
    Private messageLimit As Integer = 100

    Public Function getTextControl() As ChatBoxControl
        Return Me.txtMessageControl
    End Function
    Public Sub SetMainControl(ByVal c As ClientControl1)
        Me.MainControl = c
    End Sub

    Public Sub SetTextControl(ByVal c As ChatBoxControl)
        Me.txtMessageControl = c
    End Sub

    Public Sub SendMessage(ByVal msg As String)
        MainControl.addQueue(Information.SendMessage(Information.getMyIPAddress(), MainControl.getIPAddress(), msg))
    End Sub

    Public Sub AddMessage(ByVal msg As MsgStorage)
        If Not messages.Count > messageLimit Then
            messages.Add(msg)
        Else
            messages.RemoveAt(0)
            messages.Add(msg)
        End If
    End Sub

    Private Sub ClientMessageControl_DoubleClick(sender As Object, e As EventArgs) Handles MyBase.DoubleClick, pbProfile.DoubleClick, lblName.DoubleClick, lblDate.DoubleClick, lblMessage.DoubleClick, Panel1.DoubleClick

        If MainControl.isStarted() Then

            Main.pnlChatBox.Visible = True
            Main.lblContactName.Text = lblName.Text
            Main.currentContact = Me

            'Console.WriteLine(Main.currentContact Is Nothing)

            Main.flpMonitorChat.Controls.Clear()
            If messages.Count > 0 Then

                Dim chatbox As ChatBoxControl = Nothing
                For Each message As MsgStorage In messages

                    If chatbox IsNot Nothing AndAlso chatbox.isUser().Equals(message.isUser) Then
                        chatbox = ManageClientControl.Create_Client_Message_Control(chatbox, message.msg, message.isUser)
                    Else
                        chatbox = ManageClientControl.Create_Client_Message_Control(Nothing, message.msg, message.isUser)

                        chatbox.lblDateAndTime.Text = message.dateandtime

                        If chatbox.isUser() Then
                            chatbox.lblName.Text = Settings.lblUsername.Text
                            chatbox.pbImage.Image = Settings.pbProfile.Image
                        Else
                            chatbox.lblName.Text = Me.lblName.Text
                            chatbox.pbImage.Image = Me.pbProfile.Image
                        End If

                    End If

                    'Dim chatbox As ChatBoxControl = ManageClientControl.Create_Client_Message_Control(message.msg, message.isUser)
                    Main.flpMonitorChat.Controls.Add(chatbox)
                Next
            End If
        Else
            MsgBox("Client not ready please try again.", vbCritical, "Message")
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))
            Dim startPoint As New Point(0, Panel1.Height - 1)
            Dim endPoint As New Point(Me.Width, Panel1.Height - 1)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
