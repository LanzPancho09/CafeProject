Imports System.Data.SqlClient
Imports System.IO

Public Class CreateAccount

    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Main.loadAccounts()
        pbAccountImage.Image = My.Resources.user1
        Me.Close()
    End Sub

    Private Sub chbShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbShowPassword.CheckedChanged

        If chbShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.PasswordChar = "•"
            txtPassword.UseSystemPasswordChar = True
        End If

    End Sub


    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            If checkForm() Then

                Dim c As New SqlConnection(sqlConnection)
                c.Open()

                Dim checkName As New SqlDataAdapter("SELECT * FROM tblaccount WHERE AccUsername='" & txtUsername.Text & "'", c)
                Dim checktable As New DataTable
                checkName.Fill(checktable)

                If checktable.Rows.Count = 0 Then

                    Dim save As New SqlCommand("insert into tblaccount (AccID, AccImg, AccFirstname, AccLastname, AccUsername, AccPassword, AccTime, AccEnable) values (@AccID, @AccImg, @AccFirstname, @AccLastname, @AccUsername, @AccPassword, @AccTime, @AccEnable)", c)
                    save.Parameters.Add(New SqlParameter("@AccID", SqlDbType.NChar)).Value = getId(connection)

                    If pbAccountImage.Image IsNot Nothing Then

                        Using ms As New MemoryStream
                            pbAccountImage.Image.Save(ms, pbAccountImage.Image.RawFormat)
                            save.Parameters.Add(New SqlParameter("@AccImg", SqlDbType.Image)).Value = ms.ToArray
                        End Using

                    Else
                        save.Parameters.Add(New SqlParameter("@AccImg", SqlDbType.Image)).Value = DBNull.Value
                    End If
                    save.Parameters.Add(New SqlParameter("@AccFirstname", SqlDbType.NChar)).Value = txtFirstname.Text
                    save.Parameters.Add(New SqlParameter("@AccLastname", SqlDbType.NChar)).Value = txtLastname.Text
                    save.Parameters.Add(New SqlParameter("@AccUsername", SqlDbType.NChar)).Value = txtUsername.Text
                    save.Parameters.Add(New SqlParameter("@AccPassword", SqlDbType.NChar)).Value = txtPassword.Text

                    If chkFreetime.Checked Then
                        save.Parameters.Add(New SqlParameter("@Acctime", SqlDbType.NChar)).Value = getAccountFreetime()
                    Else
                        save.Parameters.Add(New SqlParameter("@Acctime", SqlDbType.NChar)).Value = "00:00:00"
                    End If

                    save.Parameters.Add(New SqlParameter("@AccEnable", SqlDbType.Bit)).Value = True
                    save.ExecuteNonQuery()

                    'ADD ACOUNT LOG
                    Dim search As New SqlDataAdapter("SELECT * FROM tblLog", c)
                    Dim table As New DataTable
                    search.Fill(table)

                    Dim savelog As New SqlCommand("INSERT INTO tblLog (id,name,action,dateTime) values (@id,@name,@action,@dateTime)", c)
                    savelog.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1
                    savelog.Parameters.Add(New SqlParameter("@name", SqlDbType.NChar)).Value = Settings.lblUsername.Text
                    savelog.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = "Created an account"
                    savelog.Parameters.Add(New SqlParameter("@dateTime", SqlDbType.DateTime)).Value = Date.Now
                    savelog.ExecuteNonQuery()

                    c.Close()

                    MsgBox("Account successfully created!", vbInformation, "Create Account")
                    Main.loadAccounts()
                    Me.Close()

                Else
                    MsgBox("Account already exists!", vbInformation, "Create Account")
                End If

            Else
                MsgBox("Blank text and Single or Double quote are prohibited!", vbCritical, "Invalid Input")
            End If

        Else
            MsgBox("SQL Connection failed.", vbCritical, "Database Connection")
        End If

    End Sub

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

    Private Function getAccountFreetime() As String

        'default value change it if you created a new setting for the accounts
        Dim time As String = "01:00:00"
        Return time

    End Function

    Private Function getId(ByVal c As SqlConnection) As Integer

        Dim command As SqlCommand = New SqlCommand("select * from tblaccount", c)
        Dim reader As SqlDataReader = command.ExecuteReader

        Dim max As Integer = 0

        While reader.Read

            If Val(reader.GetString(0)) > max Then
                max = Val(reader.GetString(0))
            End If

        End While

        Return max + 1

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