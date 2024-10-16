Imports System.Data.SqlClient

Public Class MainAccountControl

    Private Shared ParentManageAccount As ManageAccount = Nothing
    Private MainAccountID As Integer = -1
    Private isEdit As Boolean = True
    Private isDelete As Boolean = False
    Private isView As Boolean = False
    'SQL Connection
    Private sqlConnectionString As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Public Sub SetAccountID(ByVal id As Integer)
        Me.MainAccountID = id
    End Sub

    Public Sub SetParentManageAccount(ByVal ma As ManageAccount)
        ParentManageAccount = ma
    End Sub

    Public Sub Editing()
        isEdit = True
        isDelete = False
        isView = False
        btnAction.BaseColor = Color.FromArgb(25, 182, 152)
    End Sub

    Public Sub Deleting()
        isEdit = False
        isDelete = True
        isView = False
        btnAction.BaseColor = Color.FromArgb(232, 17, 35)
    End Sub

    Public Sub Viewing()
        isEdit = False
        isDelete = False
        isView = True
        btnAction.BaseColor = Color.FromArgb(244, 184, 0)
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click

        If isEdit Then

            Dim c As New SqlConnection(sqlConnectionString)
            c.Open()

            Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE id='" & Me.MainAccountID & "'", c)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then

                If Not table.Rows(0)(1).Equals(DBNull.Value) Then
                    ParentManageAccount.pbEditProfile.Image = Converter.getImage(table.Rows(0)(1))
                Else
                    ParentManageAccount.pbEditProfile.Image = Nothing
                End If

                ParentManageAccount.txtEditUsername.Text = table.Rows(0)(2).ToString.Trim
                ParentManageAccount.txtEditPassword.Text = table.Rows(0)(3).ToString.Trim

            End If

            ParentManageAccount.SetSelectedAccount(Me.MainAccountID)
            ParentManageAccount.TabControl1.SelectedTab = ParentManageAccount.tpEdit

        ElseIf isDelete Then

            Dim result As MsgBoxResult = MsgBox("Are you sure to delete " & lblUsername.Text & " ? This cannot be undone.", vbYesNo, "Action Confirmation")

            If result = MsgBoxResult.Yes Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                Dim edit As New SqlCommand("Update tblMainAccount set enabled=@enabled where id=@id", c)
                edit.Parameters.AddWithValue("@enabled", False)
                edit.Parameters.AddWithValue("@id", MainAccountID)
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

                MsgBox("Account successfully deleted.")
                c.Close()

            End If

        ElseIf isView Then

            Dim result As MsgBoxResult = MsgBox("Are you sure to Enable " & lblUsername.Text & " ?", vbYesNo, "Action Confirmation")

            Dim c As New SqlConnection(sqlConnectionString)
            c.Open()

            Dim edit As New SqlCommand("Update tblMainAccount set enabled=@enabled where id=@id", c)
            edit.Parameters.AddWithValue("@enabled", True)
            edit.Parameters.AddWithValue("@id", MainAccountID)
            edit.ExecuteNonQuery()

            Dim search As New SqlDataAdapter("SELECT * FROM tblLog", c)
            Dim table As New DataTable
            search.Fill(table)

            Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", c)
            savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1
            savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = Settings.lblUsername.Text
            savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Enabled an account"
            savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
            savelog.ExecuteNonQuery()
            c.Close()

            MsgBox("Account successfully Enabled.")
            c.Close()

        End If

    End Sub

    Private Sub MainAccountControl_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.GhostWhite)
            Dim startPoint As New Point(0, 0)
            Dim endPoint As New Point(Me.Width, 0)
            g.DrawLine(p, startPoint, endPoint)
        End Using
    End Sub
End Class
