Public Class CustomMessageBox

    Public Sub MessageBox(ByVal title As String, ByVal msg As String, ByVal errorType As Boolean)

        lblTitle.Text = title
        lblMessageInfo.Text = msg

        If Not errorType Then
            pbImage.Image = My.Resources.info
            pbMainLogo.Image = My.Resources.info_96px
        Else
            pbImage.Image = My.Resources.cancel
            pbMainLogo.Image = My.Resources.cancel_96px
        End If

        Me.TopMost = True

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ShadowForm.Close()
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ShadowForm.Close()
        Me.Close()
    End Sub

End Class