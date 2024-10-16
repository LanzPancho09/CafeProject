Imports System.Net.Sockets

Public Class ScreenInformation

    Private Shared parentControl As ClientControl1 = Nothing
    Public Shared clientName As String = Nothing
    Public Shared clientScreenResolution As Point = Nothing

    Public Shared lastPosition As Integer
    Public Shared currentPosition As Integer

    Public Sub setParentControl(ByVal control As ClientControl1)
        parentControl = control
    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles btnView.Click
        If Main.btnScreenBroadcast.Checked = False Then

            ScreenViewing(True)
            OpenClient.clientScreenDimension = clientScreenResolution
            OpenClient.setParentControl(parentControl)
            OpenClient.clientName = clientName
            OpenClient.lblClientName.Text = clientName
            ShadowForm.Show()
            OpenClient.ShowDialog()

        Else
            MsgBox("Screen broadcast is running, please turn it off to proceed.", vbCritical, "Screen Broadcast")
        End If

    End Sub

    Private Shared Sub ScreenViewing(ByVal status As Boolean)
        parentControl.isScreenViewing = status
        parentControl.addQueue(Information.RequestRealtimeScreenShare(True))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick

        'Console.WriteLine((Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position))) & " " & (Not ClientScreenControl.isCursorActive))

        'checks if the mouse is on the control and also to the client screen control
        If Not Me.ClientRectangle.Contains(Me.PointToClient(Cursor.Position)) AndAlso Not ClientScreenControl.isCursorActive Then
            Timer1.Stop()
            Me.Dispose()
        End If

    End Sub
End Class