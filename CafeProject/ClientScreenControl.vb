Imports System.Net.Sockets

Public Class ClientScreenControl

    Private parentControl As ClientControl1 = Nothing
    Private clientName As String = Nothing
    Private clientScreenResolution As Point = Nothing
    Public Shared isCursorActive As Boolean = False

    Public Sub setParentControl(ByVal control As ClientControl1)
        Me.parentControl = control
    End Sub

    Public Sub setName(ByVal nm As String)
        Me.clientName = nm
    End Sub

    Public Sub setScreenDimension(ByVal p As Point)
        Me.clientScreenResolution = p
    End Sub

    Private Sub pbScreen_MouseEnter(sender As Object, e As EventArgs) Handles pbScreen.MouseEnter

        isCursorActive = True

        ScreenInformation.setParentControl(Me.parentControl)
        ScreenInformation.clientName = Me.clientName
        ScreenInformation.clientScreenResolution = Me.clientScreenResolution

        ScreenInformation.lastPosition = 125
        ScreenInformation.currentPosition = 75
        ScreenInformation.lblName.Text = clientName

        Dim position As Point = Me.PointToScreen(Point.Empty)
        position.X += Me.Width + 5
        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width

        If ((position.X + 373) > screenWidth) Then
            position.X -= Me.Width + 5
            position.X -= ScreenInformation.Size.Width + 5
        End If

        ScreenInformation.Location = position
        ScreenInformation.pbProfile.Image = parentControl.getProfileImage()
        ScreenInformation.Timer2.Start()
        ScreenInformation.Show()

    End Sub

    Private Sub pbScreen_MouseHover(sender As Object, e As EventArgs) Handles pbScreen.MouseHover
        isCursorActive = True
    End Sub

    Private Sub pbScreen_MouseLeave(sender As Object, e As EventArgs) Handles pbScreen.MouseLeave
        isCursorActive = False
    End Sub

End Class
