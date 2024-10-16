Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ClientTimeControl
    Private mainControl As ClientControl1 = Nothing
    Private Property Ontimed As Boolean = False
    Private totalTime As Integer
    Private time As String = Nothing
    Private isAccount As Boolean = False
    Private Property AccID As Integer = -1
    Private lastSavedTime As String = Nothing

    Public Sub SetMainControl(ByVal c As ClientControl1)
        Me.mainControl = c
    End Sub

    Public Function getID() As Integer
        Return Me.AccID
    End Function

    Public Function getLastSavedTime() As String
        Return Me.lastSavedTime
    End Function

    Public Function getNewUserTime() As String
        Return lblTimeRemaining.Text
    End Function

    Public Function getSeconds() As Integer
        If time IsNot Nothing Then
            Dim splitTime As String() = time.Split(":")
            Return Val(splitTime(2)) ' return total seconds.
        Else
            Return 0
        End If
    End Function

    Public Function getTotalSeconds() As Integer
        If time IsNot Nothing Then
            Dim splitTime As String() = time.Split(":")
            Return ((Val(splitTime(0)) * 60) + Val(splitTime(1))) * 60 + Val(splitTime(2)) ' return total seconds.
        Else
            Return 0
        End If
    End Function

    Public Function isOntime() As Boolean
        Return Ontimed
    End Function

    Public Function isAccountActivated() As Boolean
        Return isAccount
    End Function

    Public Sub setAccountID(ByVal id As Integer)
        Me.AccID = id
    End Sub

    Public Sub SetOntime(ByVal status As Boolean)
        Me.Ontimed = status

        If status Then
            lblTimeRemaining.ForeColor = Color.FromArgb(100, 100, 100)
        Else
            lblTimeRemaining.ForeColor = Color.FromArgb(29, 162, 97)
        End If
    End Sub

    Public Sub SetAccountStatus(ByVal status As Boolean)
        Me.isAccount = status
    End Sub

    Public Sub setSavedTime(ByVal t As String)
        Me.lastSavedTime = t
    End Sub

    Public Sub setTime(ByVal time As String)
        If time IsNot Nothing Then
            Me.time = time
        End If
    End Sub


    Private Sub btnExtend_Click(sender As Object, e As EventArgs) Handles btnExtend.Click

        ShadowForm.Show()
        SetClientTime.setMainControl(mainControl)
        SetClientTime.setTimeControl(Me)
        SetClientTime.setRemainingTime(Me.time)
        SetClientTime.lblClientName.Text = lblName.Text
        SetClientTime.lblcomputername.Text = lblName.Text
        SetClientTime.lblRemainingTime.Text = lblTimeRemaining.Text

        If Main.getModeStatus() Then
            SetClientTime.pnlMonitorMode.Visible = False
        Else
            SetClientTime.pnlMonitorMode.Visible = True
        End If

        SetClientTime.ShowDialog()

    End Sub

    Private Sub btnStopTime_Click(sender As Object, e As EventArgs) Handles btnStopTime.Click

        Dim result As MsgBoxResult = MsgBox("Are you sure to stop time " & lblName.Text & " ?", vbYesNo + vbQuestion, "Stop time")

        If result = MsgBoxResult.Yes Then
            SetDefault()
            mainControl.addQueue(Information.Stop_Client_Time())
            Main.refreshClientStatus()
        End If

    End Sub

    Public Sub SetDefault()

        lblStart.Text = "00:00:00 --"
        lblEnd.Text = "00:00:00 --"
        lblTimeRemaining.Text = "VACANT"
        time = Nothing

    End Sub

    Private Sub ClientTimeControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.GhostWhite)
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(Me.Width, 0)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
