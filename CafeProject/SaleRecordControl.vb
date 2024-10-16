Public Class SaleRecordControl
    Private Sub SaleRecordControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'MyBase.OnPaint(e)
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(Me.Width, 0)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
