Imports System.Net.Sockets

Public Class OpenClient

    Private parentControl As ClientControl1 = Nothing
    Public clientScreenDimension As Point = Nothing
    Public Property clientName As String = Nothing

    Public Sub setParentControl(ByVal control As ClientControl1)
        parentControl = control
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        ScreenViewing(False)
        ShadowForm.Close()
        Main.focusMe()
        Me.Dispose()

    End Sub

    Private Sub btnViewAndControl_Click(sender As Object, e As EventArgs) Handles btnViewAndControl.Click

        If Not isCurrentlyControlling() Then

            If Not parentControl.isScreenControling Then

                ScreenViewing(False)
                ShadowForm.Close()
                Main.focusMe()

                Dim screen As New ScreenControl
                screen.Text = clientName
                screen.setParentControl(Me.parentControl)
                'screen.Size = New Size(clientScreenDimension.X + 30, clientScreenDimension.Y + 20)
                screen.pbClientScreen.Size = New Size(clientScreenDimension)

                'inform screen controlling
                parentControl.setScreenControl(screen)
                parentControl.isScreenControling = True

                screen.Show()

                If chRemoteControl.Checked = False Then
                    screen.mniDisableControl.PerformClick()
                End If

                If chBroadcast.Checked = True And Main.ClientControls.Count > 1 Then
                    screen.mniShareEveryone.PerformClick()
                End If

                Me.Close()

            Else
                MsgBox("Remote control is already running.", vbCritical, "Open Client")
            End If

        Else
            MsgBox("There are active remote control, Please close the other screen controls before proceeding.", vbCritical, "Open Client")
        End If

    End Sub

    Private Sub ScreenViewing(ByVal status As Boolean)
        parentControl.isScreenViewing = status
        If Not parentControl.isScreenControling Then
            parentControl.addQueue(Information.RequestRealtimeScreenShare(False))
        End If
    End Sub

    Private Function isCurrentlyControlling() As Boolean

        Dim status As Boolean = False

        Try
            For Each control As ClientControl1 In Main.ClientControls
                If control.isScreenControling Then
                    status = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            isCurrentlyControlling()
        End Try

        Return status

    End Function
End Class