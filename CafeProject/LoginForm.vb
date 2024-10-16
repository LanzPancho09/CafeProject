Imports System.Data.SqlClient
Imports System.IO

Public Class LoginForm

    Private Shared isAdmin As Boolean = True
    Private Shared AccountID As Integer = -1
    'SQL Connection
    Private sqlConnectionString As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Public Function getAccountStatus() As Boolean
        Return isAdmin
    End Function

    Public Function getAccountID() As Integer
        Return AccountID
    End Function

    Public Sub SetDefaultAccount()
        AccountID = -1
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Function checkSQLConnection(ByVal connectionString As String) As Boolean

        Dim status As Boolean = False

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                If connection.State = ConnectionState.Open Then
                    status = True
                End If
            Catch ex As Exception
                status = False
            End Try
        End Using

        Return status

    End Function

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)
        txtUsername.BorderColor = Color.Silver
    End Sub


    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)
        txtPassword.BorderColor = Color.Silver
    End Sub

    Private Sub chbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbxShowPassword.CheckedChanged
        If chbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.PasswordChar = "●"
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        If IsLoginValidInput() Then

            'checks database connection
            If checkSQLConnection(sqlConnectionString) Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                'seach the username and password in the database.
                Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE username='" & txtUsername.Text & "' AND password='" & txtPassword.Text & "'", c)
                Dim table As New DataTable
                search.Fill(table)

                'checks if the account exists in the database.
                If table.Rows.Count > 0 Then

                    'when the account is exist in the database, the account double checked by each characters in the string.
                    If table.Rows(0)(2).ToString.Trim.Equals(txtUsername.Text) And table.Rows(0)(3).ToString.Trim.Equals(txtPassword.Text) Then
                        'displays the information of the user account in the settings.
                        Dim img As Image = Converter.getImage(table.Rows(0)(1))
                        Dim username As String = table.Rows(0)(2).ToString.Trim

                        AccountID = Val(table.Rows(0)(0).ToString.Trim)

                        Settings.pbProfile.Image = img
                        Settings.lblUsername.Text = username
                        Main.pbUserImage.Image = img
                        Main.lblUsername.Text = username
                        Main.lblUser.Text = username

                        'converting the column 2 to boolean value
                        Dim admin As Boolean = CBool(table.Rows(0)(4))

                        'If the user Is Not admin Then we will disable the account view In the sales tab
                        If Not admin Then
                            isAdmin = False
                            Main.btnAccounts.Visible = False
                            Main.lblAccountLevel.Text = "User"
                            Settings.pnlManagement.Visible = False
                            Settings.lblAccountLevel.Text = "User"
                            Main.pnlUserInfo.Visible = True
                        Else
                            Main.lblAccountLevel.Text = "Administrator"
                            Main.pnlUserInfo.Visible = True
                        End If

                        txtUsername.Text = ""
                        txtPassword.Text = ""

                        txtUsername.BackColor = Color.Silver
                        txtPassword.BackColor = Color.Silver

                        'Set server mode true = cafe mode; false = monitor mode
                        Main.setMode(True)

                        Main.Show()
                        Me.Hide()

                    Else
                        'shows invalid message that the account is not exact as in the database.
                        MsgBox("Invalid username or password.", vbCritical)
                        txtUsername.BorderColor = Color.FromArgb(232, 17, 35)
                        txtPassword.BorderColor = Color.FromArgb(232, 17, 35)
                    End If

                Else
                    'shows invalid message when the account is not found.
                    MsgBox("Invalid username or password.", vbCritical)
                    txtUsername.BorderColor = Color.FromArgb(232, 17, 35)
                    txtPassword.BorderColor = Color.FromArgb(232, 17, 35)
                End If

                c.Close()

            Else
                MsgBox("There's a problem connecting to database.", vbCritical)
            End If

        Else
            MsgBox("Blanks, single and double quotes are prohibited.", vbCritical)
        End If

    End Sub

    Private Function IsLoginValidInput() As Boolean

        Dim errorCount As Integer = 0

        If txtUsername.Text = "" Or txtUsername.Text.Contains("'") Or txtUsername.Text.Contains("""") Then
            txtUsername.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If txtPassword.Text = "" Or txtPassword.Text.Contains("'") Or txtPassword.Text.Contains("""") Then
            txtPassword.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If errorCount > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnCafeMode_Click(sender As Object, e As EventArgs) Handles btnCafeMode.Click
        btnCafeMode.BaseColor = Color.FromArgb(254, 57, 2)
        btnMonitorMode.BaseColor = Color.FromArgb(20, 20, 20)
        pnlMonitorMode.Visible = False
    End Sub

    Private Sub btnMonitorMode_Click(sender As Object, e As EventArgs) Handles btnMonitorMode.Click
        btnCafeMode.BaseColor = Color.FromArgb(20, 20, 20)
        btnMonitorMode.BaseColor = Color.FromArgb(254, 57, 2)
        pnlMonitorMode.Visible = True
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        For Each b As Guna.UI.WinForms.GunaAdvenceButton In Main.Panel1.Controls
            If b.Name.Equals("btnSales") Then
                Main.Panel1.Controls.Remove(b)
                Exit For
            End If
        Next

        Main.setMode(False)
        Main.lblAccountLevel.Text = "Monitor Mode"
        Main.pnlUserInfo.Visible = False

        Main.Show()
        Me.Hide()

    End Sub

    Private Sub linklCreateAccount_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linklCreateAccount.LinkClicked
        TabControl1.SelectedTab = tpCreate
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        TabControl1.SelectedTab = tpHome
    End Sub

    Private Sub chbxCreateShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbxCreateShowPassword.CheckedChanged

        If chbxCreateShowPassword.Checked Then
            txtCreatePassword.PasswordChar = ""
            txtCreatePassword.UseSystemPasswordChar = False
        Else
            txtCreatePassword.PasswordChar = "●"
            txtCreatePassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If isCreateValidInput() Then

            If checkSQLConnection(sqlConnectionString) Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                Dim checkName As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE username='" & txtCreateUsername.Text & "'", c)
                Dim checktable As New DataTable
                checkName.Fill(checktable)

                If checktable.Rows.Count = 0 Then

                    Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount", c)
                    Dim table As New DataTable
                    search.Fill(table)

                    Dim save As New SqlCommand("insert into tblMainAccount (id, profileImg, username, password, accLevel, enabled) values (@id, @profileImg, @username, @password, @accLevel, @enabled)", c)
                    save.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1

                    If pbProfile.Image IsNot Nothing Then

                        Using ms As New MemoryStream
                            pbProfile.Image.Save(ms, pbProfile.Image.RawFormat)
                            save.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                        End Using

                    Else
                        save.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = DBNull.Value
                    End If

                    save.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtCreatePassword.Text
                    save.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtCreatePassword.Text
                    save.Parameters.Add(New SqlParameter("@accLevel", SqlDbType.Bit)).Value = False
                    save.Parameters.Add(New SqlParameter("@enabled", SqlDbType.Bit)).Value = True
                    save.ExecuteNonQuery()

                    MsgBox("Account Successfully created!", vbInformation)
                    TabControl1.SelectedTab = tpHome

                    txtCreateUsername.Text = ""
                    txtCreatePassword.Text = ""

                Else
                    txtCreateUsername.BorderColor = Color.FromArgb(254, 57, 2)
                    txtCreatePassword.BorderColor = Color.FromArgb(254, 57, 2)
                    MsgBox("Username Already Exist!", vbCritical)
                End If
                c.Close()

            End If
        Else
            MsgBox("Blanks, single and double quotes are prohibited!", vbCritical)
        End If


    End Sub

    Private Function isCreateValidInput() As Boolean

        Dim errorCount As Integer = 0

        If txtCreateUsername.Text = "" Or txtCreateUsername.Text.Contains("'") Or txtCreateUsername.Text.Contains("""") Then
            txtCreateUsername.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If txtCreatePassword.Text = "" Or txtCreatePassword.Text.Contains("'") Or txtCreatePassword.Text.Contains("""") Then
            txtCreatePassword.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If errorCount > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub btnEditProfile_Click(sender As Object, e As EventArgs) Handles btnEditProfile.Click

        'Set the Filter.
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."
        OpenFileDialog1.Multiselect = False
        'Show it
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Create a new Bitmap and display it
            pbProfile.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BorderColor = Color.Silver
    End Sub

    Private Sub txtCreateUsername_Enter(sender As Object, e As EventArgs) Handles txtCreateUsername.Enter
        txtCreateUsername.BorderColor = Color.Silver
    End Sub

    Private Sub txtCreatePassword_Enter(sender As Object, e As EventArgs) Handles txtCreatePassword.Enter
        txtCreatePassword.BorderColor = Color.Silver
    End Sub

    Private Sub LoginForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit()
    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPassword.Select()
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub txtCreateUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCreateUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtCreatePassword.Select()
        End If
    End Sub

    Private Sub txtCreatePassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCreatePassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnCreateAccount.PerformClick()
        End If
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BorderColor = Color.Silver
    End Sub
End Class