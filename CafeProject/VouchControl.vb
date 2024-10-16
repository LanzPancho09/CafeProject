Public Class VouchControl
    Private vouchId As Integer = -1

    Public Sub setVouchId(ByVal id As Integer)
        Me.vouchId = id
    End Sub

    Private Sub btnDeleteVouch_Click(sender As Object, e As EventArgs) Handles btnDeleteVouch.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to delete VouchID " & vouchId & " ? This cannot be undone.", vbYesNo + vbQuestion, "Confirmation")

        If result = MsgBoxResult.Yes Then
            If Not vouchId = -1 Then
                Main.DeleteVouchID(Me.vouchId)
            End If
        End If

    End Sub

    Private Sub VouchControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(Me.Width, 0)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
