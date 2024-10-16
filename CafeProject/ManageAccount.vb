Imports System.Data.SqlClient
Imports System.IO

Public Class ManageAccount

    Private Shared selectedAccount As Integer = -1
    'SQL Connection
    Private sqlConnectionString As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Public Sub SetSelectedAccount(ByVal id As Integer)
        selectedAccount = id
    End Sub

    Private Sub ManageAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlShadow, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(Panel2, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnAccounts, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnCreateAccount, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnEditAccount, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnDeleteAccount, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(btnEnableAccount, Color.Black, 30, 4, Guna.UI.WinForms.VerHorAlign.VerticalRight)

        loadAccount()
    End Sub

    Private Sub btnEditAccount_Click(sender As Object, e As EventArgs)
        loadAccount()
    End Sub

    Private Sub btnDeleteAccount_Click(sender As Object, e As EventArgs)
        loadAccount()
    End Sub

    Private Sub btnDisabledAccount_Click(sender As Object, e As EventArgs)
        loadAccount()
    End Sub

    Private Sub loadAccount()

        Dim c As New SqlConnection(sqlConnectionString)
        c.Open()

        Dim command As New SqlCommand("SELECT * FROM tblMainAccount", c)
        Dim reader As SqlDataReader = command.ExecuteReader

        flpAccounts.Controls.Clear()

        While reader.Read

            If Not btnEnableAccount.Checked And reader.GetBoolean(5) Then

                Dim control As New MainAccountControl

                With control
                    .SetParentManageAccount(Me)
                    .Width = flpAccounts.Width - 20

                    .SetAccountID(Val(reader.GetString(0).Trim))
                    .lblID.Text = reader.GetString(0).Trim
                    If Not reader(1).Equals(DBNull.Value) Then
                        .pbImage.Image = Converter.getImage(reader(1))
                    End If
                    .lblUsername.Text = reader.GetString(2).Trim
                    .lblPassword.Text = reader.GetString(3).Trim

                    If btnAccounts.Checked Then
                        .btnAction.Visible = False
                    ElseIf btnEditAccount.Checked Then
                        .btnAction.Text = "Edit"
                        .Editing()
                    ElseIf btnDeleteAccount.Checked Then
                        .btnAction.Text = "Delete"
                        .Deleting()
                    ElseIf btnEnableAccount.Checked Then
                        If Not reader.GetBoolean(5) Then
                            .btnAction.Text = "Enable"
                            .Viewing()
                        End If
                    End If

                End With

                flpAccounts.Controls.Add(control)

            Else

                'means the account is disabled
                If Not reader.GetBoolean(5) And btnEnableAccount.Checked Then
                    Dim control As New MainAccountControl

                    With control
                        .SetParentManageAccount(Me)
                        .Width = flpAccounts.Width - 20

                        .SetAccountID(Val(reader.GetString(0).Trim))
                        .lblID.Text = reader.GetString(0).Trim
                        If Not reader(1).Equals(DBNull.Value) Then
                            .pbImage.Image = Converter.getImage(reader(1))
                        End If
                        .lblUsername.Text = reader.GetString(2).Trim
                        .lblPassword.Text = reader.GetString(3).Trim

                        .btnAction.Text = "Enable"
                        .Viewing()

                    End With
                    flpAccounts.Controls.Add(control)
                End If
            End If
        End While

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        loadAccount()
        selectedAccount = -1
        TabControl1.SelectedTab = tpAccount
    End Sub

    Private Sub btnEditAccount_Click_1(sender As Object, e As EventArgs) Handles btnEditAccount.Click
        loadAccount()
        selectedAccount = -1
        TabControl1.SelectedTab = tpAccount
    End Sub
    Private Sub btnDeleteAccount_Click_1(sender As Object, e As EventArgs) Handles btnDeleteAccount.Click
        loadAccount()
        selectedAccount = -1
        TabControl1.SelectedTab = tpAccount
    End Sub
    Private Sub btnEnableAccount_Click(sender As Object, e As EventArgs) Handles btnEnableAccount.Click
        loadAccount()
        selectedAccount = -1
        TabControl1.SelectedTab = tpAccount
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click

        If isCreateInputValid() Then

            Dim c As New SqlConnection(sqlConnectionString)
            c.Open()

            Dim checkName As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE username='" & txtUsername.Text & "'", c)
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

                save.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtUsername.Text
                save.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtPassword.Text

                If cbAccountType.SelectedIndex = 0 Then
                    save.Parameters.Add(New SqlParameter("@accLevel", SqlDbType.Bit)).Value = True
                Else
                    save.Parameters.Add(New SqlParameter("@accLevel", SqlDbType.Bit)).Value = False
                End If

                save.Parameters.Add(New SqlParameter("@enabled", SqlDbType.Bit)).Value = True
                save.ExecuteNonQuery()

                txtUsername.Text = ""
                txtPassword.Text = ""

                MsgBox("Account Successfully created!", vbInformation)
                btnAccounts.PerformClick()

            Else
                MsgBox("Account Already Exists!", vbInformation)
            End If
            c.Close()

        Else
            MsgBox("Blank, single and double quotes are prohibited.", vbInformation)
        End If
    End Sub

    Private Function isCreateInputValid() As Boolean

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

    Private Sub chbxShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbxShowPassword.CheckedChanged

        If chbxShowPassword.Checked Then
            txtPassword.PasswordChar = ""
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.PasswordChar = "●"
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
            pbProfile.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub chbxEditShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chbxEditShowPassword.CheckedChanged

        If chbxEditShowPassword.Checked Then
            txtEditPassword.PasswordChar = ""
            txtEditPassword.UseSystemPasswordChar = False
        Else
            txtEditPassword.PasswordChar = "●"
            txtEditPassword.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub btnChangeProfile_Click(sender As Object, e As EventArgs) Handles btnChangeProfile.Click

        'Set the Filter.
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;..."
        OpenFileDialog1.Multiselect = False
        'Show it
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            'Create a new Bitmap and display it
            pbEditProfile.Image = System.Drawing.Bitmap.FromFile(OpenFileDialog1.FileName)
        End If

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If IsEditValidInputs() Then
            Dim connection As New SqlConnection(sqlConnectionString)
            connection.Open()

            Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE id='" & selectedAccount & "'", connection)
            Dim table As New DataTable
            search.Fill(table)

            'check if the account username is equal to the current username
            'then it only change the image and password.
            If table.Rows(0)(2).ToString.Trim = txtEditUsername.Text Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                Dim edit As New SqlCommand("Update tblMainAccount set profileImg=@profileImg,username=@username,password=@password WHERE id=@id", c)
                edit.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = selectedAccount

                If pbEditProfile.Image IsNot Nothing Then
                    Using ms As New MemoryStream
                        pbEditProfile.Image.Save(ms, pbEditProfile.Image.RawFormat)
                        edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                    End Using
                Else
                    edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = DBNull.Value
                End If
                edit.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtEditUsername.Text
                edit.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtEditPassword.Text
                edit.ExecuteNonQuery()

                c.Close()

                txtEditUsername.Text = ""
                txtEditPassword.Text = ""

                selectedAccount = -1
                MsgBox("Account updated successfully!", vbInformation)
                btnEditAccount.PerformClick()

            Else

                'if the current username does not equal to the database
                'it checks if the username exists in the database
                'if not we will change all the information in the account.
                If Not isUsernameExist(txtEditUsername.Text) Then

                    Dim c As New SqlConnection(sqlConnectionString)
                    c.Open()

                    Dim edit As New SqlCommand("Update tblMainAccount set profileImg=@profileImg,username=@username,password=@password WHERE id=@id", c)
                    edit.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = selectedAccount

                    If pbEditProfile.Image IsNot Nothing Then
                        Using ms As New MemoryStream
                            pbEditProfile.Image.Save(ms, pbEditProfile.Image.RawFormat)
                            edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                        End Using
                    Else
                        edit.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = DBNull.Value
                    End If
                    edit.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = txtEditUsername.Text
                    edit.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = txtEditPassword.Text
                    edit.ExecuteNonQuery()

                    c.Close()

                    txtEditUsername.Text = ""
                    txtEditPassword.Text = ""

                    selectedAccount = -1
                    MsgBox("Account updated successfully!", vbInformation)
                    btnEditAccount.PerformClick()
                Else
                    MsgBox("Account name already exist!", vbInformation, "Edit Account")
                End If

            End If

        Else
            MsgBox("Blanks, single and double quotes are prohibited.", vbInformation)
        End If
    End Sub

    Private Function isUsernameExist(ByVal username As String) As Boolean

        Dim exists As Boolean = False

        Dim connection As New SqlConnection(sqlConnectionString)
        connection.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount WHERE username='" & username & "'", connection)
        Dim table As New DataTable
        search.Fill(table)

        If table.Rows.Count > 0 Then
            exists = True
        End If

        connection.Close()
        Return exists

    End Function

    Private Function IsEditValidInputs() As Boolean

        Dim errorCount As Integer = 0

        If txtEditUsername.Text = "" Or txtEditUsername.Text.Contains("'") Or txtEditUsername.Text.Contains("""") Then
            txtEditUsername.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If txtEditPassword.Text = "" Or txtEditPassword.Text.Contains("'") Or txtEditPassword.Text.Contains("""") Then
            txtEditPassword.BorderColor = Color.FromArgb(254, 57, 2)
            errorCount += 1
        End If

        If errorCount > 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Private Sub txtEditUsername_Enter(sender As Object, e As EventArgs) Handles txtEditUsername.Enter
        txtEditUsername.BorderColor = Color.Silver
    End Sub

    Private Sub txtEditPassword_Enter(sender As Object, e As EventArgs) Handles txtEditPassword.Enter
        txtEditPassword.BorderColor = Color.Silver
    End Sub

    Private Sub txtUsername_Enter(sender As Object, e As EventArgs) Handles txtUsername.Enter
        txtUsername.BorderColor = Color.Silver
    End Sub

    Private Sub txtPassword_Enter(sender As Object, e As EventArgs) Handles txtPassword.Enter
        txtPassword.BorderColor = Color.Silver
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        TabControl1.SelectedTab = tpCreate
    End Sub
End Class