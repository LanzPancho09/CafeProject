Imports System.Data.SqlClient
Public Class AccountControl

    Private minutes As Integer = 0
    Private isEditing As Boolean = False
    Private isDeleting As Boolean = False
    Private isNormal As Boolean = True

    Private AccountID As Integer = -1
    Private Firstname As String = Nothing
    Private Lastname As String = Nothing

    Private time As String

    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Public Sub setMinutes(ByVal time As Integer)
        Me.minutes = time
    End Sub

    Public Sub setValues(ByVal Id As Integer, ByVal fname As String, ByVal lname As String)
        Me.AccountID = Id
        Me.Firstname = fname
        Me.Lastname = lname
    End Sub

    Public Sub setTime(ByVal t As String)
        Me.time = t
    End Sub

    Public Function getID() As Integer
        Return AccountID
    End Function

    Public Function getName() As String
        Return Firstname & " " & Lastname
    End Function


    Public Function getTotalTime() As Integer

        Dim totaltime As Integer = 0

        If Me.AccountID <> -1 Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim search As New SqlDataAdapter("SELECT * FROM tblAccount WHERE AccID='" & Me.AccountID & "'", c)
            Dim dtable As New DataTable
            search.Fill(dtable)

            If dtable.Rows.Count > 0 Then
                Dim t As String() = dtable.Rows(0)(6).ToString.Split(":")
                totaltime = (Val(t(0)) * 60) + Val(t(1))
            End If

            c.Close()

        End If

        Return totaltime

    End Function

    Public Function getAccountTime() As String

        Dim c As New SqlConnection(sqlConnection)
        c.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblAccount WHERE AccID='" & Me.AccountID & "'", c)
        Dim dtable As New DataTable
        search.Fill(dtable)

        If dtable.Rows.Count > 0 Then
            Return dtable.Rows(0)(6).ToString.Trim
        End If

        c.Close()

        Return Nothing

    End Function

    Public Sub Normal()

        Me.isNormal = True
        Me.isEditing = False
        Me.isDeleting = False

    End Sub

    Public Sub Editing()

        Me.isNormal = False
        Me.isEditing = True
        Me.isDeleting = False

    End Sub

    Public Sub Deleting()

        Me.isNormal = False
        Me.isEditing = False
        Me.isDeleting = True

    End Sub

    Private Sub btnExtend_Click(sender As Object, e As EventArgs) Handles btnExtend.Click

        If isNormal Then

            ShadowForm.Show()
            SetClientTime.setAccountControl(Me)

            Dim accountTime As String = getAccountTime()

            If accountTime Is Nothing Then
                accountTime = "00:00:00"
            End If

            Dim t As String() = accountTime.Split(":")
            Dim hour As Integer = t(0)
            Dim minutes As Integer = t(1)
            Dim seconds As Integer = t(2)
            Dim clientTime As String = hour.ToString() & "hr/s " & minutes.ToString() & "min/s " & seconds.ToString() & "sec/s"

            SetClientTime.setRemainingTime(time)
            SetClientTime.lblRemainingTime.Text = clientTime
            SetClientTime.pnlMonitorMode.Visible = False
            SetClientTime.ShowDialog()

        ElseIf isEditing Then

            ShadowForm.Show()
            EditAccount.setValues(AccountID, Firstname, Lastname, lblUsername.Text, lblPassword.Text)
            EditAccount.ShowDialog()
            ShadowForm.Close()

        ElseIf isDeleting Then

            Dim result As MsgBoxResult = MsgBox("Are you sure to delete " & lblUsername.Text & " ? This cannot be undone.", vbYesNo, "Action Confirmation")

            If result = MsgBoxResult.Yes Then

                Dim c As New SqlConnection(sqlConnection)
                c.Open()

                Dim edit As New SqlCommand("Update tblaccount set AccEnable=@AccEnable where AccID=@AccID", c)
                edit.Parameters.AddWithValue("@AccEnable", False)
                edit.Parameters.AddWithValue("@AccID", AccountID)
                edit.ExecuteNonQuery()

                Dim search As New SqlDataAdapter("SELECT * FROM tblLog", c)
                Dim table As New DataTable
                search.Fill(table)

                Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", c)
                savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1
                savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = Settings.lblUsername.Text
                savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Deleted an account"
                savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
                savelog.ExecuteNonQuery()

                c.Close()

                Main.loadAccounts()
                MsgBox("Account successfully deleted.")
                c.Close()

            End If

        End If

    End Sub

    Private Sub AccountControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(240, 240, 240))
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(Me.Width, 0)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
