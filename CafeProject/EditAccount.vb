Imports System.Data.SqlClient
Public Class EditAccount

    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"
    Public Shared AccountID As Integer = Nothing

    Public Sub setValues(ByVal id As Integer, ByVal fname As String, ByVal lname As String, ByVal username As String, ByVal pass As String)
        AccountID = id
        txtFirstname.Text = fname
        txtLastname.Text = lname
        txtUsername.Text = username
        txtPassword.Text = pass
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        pbAccountImage.Image = My.Resources.user1
        Me.Close()
    End Sub

    Private Sub txtFirstname_Leave(sender As Object, e As EventArgs) Handles txtFirstname.Leave

        If txtFirstname.Text.Count > 0 Then
            txtFirstname.BorderColor = Color.FromArgb(242, 245, 245)
        End If

    End Sub

    Private Sub txtLastname_Leave(sender As Object, e As EventArgs) Handles txtLastname.Leave

        If txtLastname.Text.Count > 0 Then
            txtLastname.BorderColor = Color.FromArgb(242, 245, 245)
        End If

    End Sub

    Private Sub txtUsername_Leave(sender As Object, e As EventArgs) Handles txtUsername.Leave

        If txtUsername.Text.Count > 0 Then
            txtUsername.BorderColor = Color.FromArgb(242, 245, 245)
        End If

    End Sub

    Private Sub txtPassword_Leave(sender As Object, e As EventArgs) Handles txtPassword.Leave

        If txtPassword.Text.Count > 0 Then
            txtPassword.BorderColor = Color.FromArgb(242, 245, 245)
        End If

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            If checkForm() Then
                Dim c As New SqlConnection(sqlConnection)
                c.Open()

                Dim search As New SqlDataAdapter("SELECT * FROM tblaccount WHERE AccID='" & AccountID & "'", c)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows(0)(4).ToString.Trim = txtUsername.Text Then

                    Dim edit As New SqlCommand("Update tblaccount set AccImg=@AccImg,AccFirstname=@AccFirstname,AccLastname=@AccLastname,AccUsername=@AccUsername,AccPassword=@AccPassword where AccID=@AccID", connection)

                    edit.Parameters.AddWithValue("@AccImg", Converter.setImage(pbAccountImage.Image))
                    edit.Parameters.AddWithValue("@AccFirstname", txtFirstname.Text)
                    edit.Parameters.AddWithValue("@AccLastname", txtLastname.Text)
                    edit.Parameters.AddWithValue("@AccUsername", txtUsername.Text)
                    edit.Parameters.AddWithValue("@AccPassword", txtPassword.Text)
                    edit.Parameters.AddWithValue("@AccID", AccountID)
                    edit.ExecuteNonQuery()

                    Dim searchLog As New SqlDataAdapter("SELECT * FROM tblLog", connection)
                    Dim tableLog As New DataTable
                    searchLog.Fill(tableLog)

                    Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", connection)
                    savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = tableLog.Rows.Count + 1
                    savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = Settings.lblUsername.Text
                    savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Edited an account"
                    savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
                    savelog.ExecuteNonQuery()

                    connection.Close()

                    MsgBox("Account successfully updated!", vbInformation, "Edit Account")
                    Main.loadAccounts()
                    Me.Close()

                Else

                    If Not isUsernameExist(txtUsername.Text) Then

                        Dim edit As New SqlCommand("Update tblaccount set AccImg=@AccImg,AccFirstname=@AccFirstname,AccLastname=@AccLastname,AccUsername=@AccUsername,AccPassword=@AccPassword where AccID=@AccID", connection)

                        edit.Parameters.AddWithValue("@AccImg", Converter.setImage(pbAccountImage.Image))
                        edit.Parameters.AddWithValue("@AccFirstname", txtFirstname.Text)
                        edit.Parameters.AddWithValue("@AccLastname", txtLastname.Text)
                        edit.Parameters.AddWithValue("@AccUsername", txtUsername.Text)
                        edit.Parameters.AddWithValue("@AccPassword", txtPassword.Text)
                        edit.Parameters.AddWithValue("@AccID", AccountID)
                        edit.ExecuteNonQuery()

                        Dim searchLog As New SqlDataAdapter("SELECT * FROM tblLog", connection)
                        Dim tableLog As New DataTable
                        searchLog.Fill(tableLog)

                        Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", connection)
                        savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = tableLog.Rows.Count + 1
                        savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = Settings.lblUsername.Text
                        savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Edited an account"
                        savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
                        savelog.ExecuteNonQuery()

                        connection.Close()

                        MsgBox("Account successfully updated!", vbInformation, "Edit Account")
                        Main.loadAccounts()
                        Me.Close()

                    Else
                        MsgBox("Account name already exist!", vbInformation, "Edit Account")
                    End If

                End If

            Else
                MsgBox("Blank text and Single or Double quote are prohibited!", vbCritical, "Invalid Input")
            End If

        Else
            MsgBox("SQL Connection failed.", vbCritical, "Database Connection")
        End If

    End Sub

    Private Function isUsernameExist(ByVal username As String) As Boolean

        Dim exists As Boolean = False

        Dim connection As New SqlConnection(sqlConnection)
        connection.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblaccount WHERE AccUsername='" & username & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            exists = True
        End If

        connection.Close()
        Return exists

    End Function


    Private Function checkForm() As Boolean
        Dim status As Boolean = False

        Dim errors As Integer = 0

        If txtFirstname.Text = "" Or (txtFirstname.Text.Contains("""") Or txtFirstname.Text.Contains("'")) Then
            txtFirstname.BorderColor = Color.FromArgb(255, 81, 92)
            errors += 1
        End If

        If txtLastname.Text = "" Or (txtLastname.Text.Contains("""") Or txtLastname.Text.Contains("'")) Then
            txtLastname.BorderColor = Color.FromArgb(255, 81, 92)
            errors += 1
        End If

        If txtUsername.Text = "" Or (txtUsername.Text.Contains("""") Or txtUsername.Text.Contains("'")) Then
            txtUsername.BorderColor = Color.FromArgb(255, 81, 92)
            errors += 1
        End If

        If txtPassword.Text = "" Or (txtPassword.Text.Contains("""") Or txtPassword.Text.Contains("'")) Then
            txtPassword.BorderColor = Color.FromArgb(255, 81, 92)
            errors += 1
        End If

        If errors = 0 Then
            Return True
        End If

        Return status
    End Function

    Private Function checkSQLConnection(ByVal c As SqlConnection) As Boolean

        Try
            c.Open()

            If c.State = ConnectionState.Open Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub chbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPassword.CheckedChanged

        If chbShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.PasswordChar = "•"
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click
        'Set the Filter.
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."
        OpenFileDialog1.Multiselect = False
        'Show it
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Create a new Bitmap and display it
            pbAccountImage.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub
End Class