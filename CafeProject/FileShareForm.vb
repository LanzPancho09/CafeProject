Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class FileShareForm

    Public totalfilesize As String = Nothing
    Private control As ClientControl1 = Nothing

    Public Sub setControl(ByVal c As ClientControl1)
        Me.control = c
    End Sub

    Private Sub FileShareForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel3, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel1, Color.FromArgb(25, 155, 250), 50, 3, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        lblPercentage.Text = progFiles.Value & "%"

        For i As Integer = 1 To 25
            Chart1.Series("Line").Points.AddY(0)
        Next

        tmClientNetworkSpeed.Start()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Dim result As MsgBoxResult = MsgBox("Are you cure to cancel operations?", vbYesNo + vbQuestion, "File Share")

        If result = MsgBoxResult.Yes Then

            control.isFileReceiving = False
            control.DefaultFileSharing()
            tmClientNetworkSpeed.Stop()
            control.addQueue(Information.CancelFileSharing())

            Me.Hide()
            ShadowForm.Close()
            Main.focusMe()

        End If

    End Sub

    Private Sub tmClientNetworkSpeed_Tick(sender As Object, e As EventArgs) Handles tmClientNetworkSpeed.Tick

        If control IsNot Nothing And control.isFileReceiving Then

            'SPEED CALCULATOR
            Dim ctr As Integer = 0
            Dim sizeTerm As String() = {"B", "KB", "MB", "GB", "TB", "PB"}
            Dim size As Double = Convert.ToDouble(control.FileShareSpeed)

            While size > 1024
                size /= 1024
                ctr += 1
            End While

            If ctr > 5 Then
                ctr = 5
            End If

            lblTransferSpeed.Text = "Transfer Speed : " & size.ToString("F2") & " " & sizeTerm(ctr) & "/s"

            Me.Chart1.Series("Line").Points.AddY(size)

            If Me.Chart1.Series("Line").Points.Count > 25 Then
                Me.Chart1.Series("Line").Points.RemoveAt(0)
                Me.Chart1.ResetAutoValues()
            End If

            control.FileShareSpeed = 0

        End If
    End Sub

    Private Sub FileShareForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ShadowForm.Close()
    End Sub
End Class