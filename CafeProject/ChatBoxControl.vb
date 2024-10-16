Public Class ChatBoxControl
    Private User As Boolean = False
    Public Sub setUser(ByVal status As Boolean)
        User = status
    End Sub
    Public Function isUser() As Boolean
        Return User
    End Function

    Public Sub pbImage_MouseEnter(sender As Object, e As EventArgs) Handles pbImage.MouseEnter, Me.MouseEnter, lblName.MouseEnter, lblDateAndTime.MouseEnter, flpMessage.MouseEnter
        Me.BackColor = Color.FromArgb(252, 252, 252)
        Me.lblDateAndTime.Visible = True
    End Sub

    Public Sub pbImage_MouseLeave(sender As Object, e As EventArgs) Handles pbImage.MouseLeave, Me.MouseLeave, lblName.MouseLeave, lblDateAndTime.MouseLeave, flpMessage.MouseLeave
        Me.BackColor = Color.White
        Me.lblDateAndTime.Visible = False
    End Sub
End Class
