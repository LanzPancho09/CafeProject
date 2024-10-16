Imports System.Data.SqlClient
Imports System.Threading

Public Class VoucherForm
    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"
    Private Sub generateAccounts()

        For i As Integer = 0 To nudAccountNumber.Value - 1

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim save As New SqlCommand("INSERT INTO tblvouch (vouchID,username,password,time) values (@vouchID,@username,@password,@time)", c)
            save.Parameters.Add(New SqlParameter("@vouchId", SqlDbType.NChar)).Value = getValidVouchId()
            save.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = "VCHR" & generateRandomString(5)
            save.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = generateRandomString(7)

            Dim concatinateValues As String = nudHour.Value.ToString("00") & ":" & nudMinute.Value.ToString("00") & ":" & nudSecond.Value.ToString("00")
            save.Parameters.Add(New SqlParameter("@time", SqlDbType.NChar)).Value = concatinateValues
            save.ExecuteNonQuery()

            c.Close()
        Next

    End Sub

    Private Function getValidVouchId() As Integer

        Dim c As New SqlConnection(sqlConnection)
        c.Open()

        Dim searchC As New SqlConnection(sqlConnection)
        searchC.Open()

        Dim search As New SqlDataAdapter("SELECT * FROM tblvouch", searchC)
        Dim table As New DataTable
        search.Fill(table)

        Dim id As Integer = 0

        If table.Rows.Count > 0 Then

            Dim command As New SqlCommand("SELECT * FROM tblvouch ORDER BY vouchID + 0 ASC", c)
            Dim reader As SqlDataReader = command.ExecuteReader

            Dim ctr As Integer = 0

            While True
                Dim contain As Boolean = False

                While reader.Read
                    If Val(reader.GetString(0).Trim) = ctr Then
                        contain = True
                        Exit While
                    End If
                End While

                If Not contain Then
                    id = ctr
                    Exit While
                Else
                    ctr += 1
                End If

            End While

        Else
            id = 0
        End If

        searchC.Close()
        c.Close()

        Return id

    End Function

    Private Function generateRandomString(ByVal lng As Integer) As String

        Dim randomString As String = Nothing

        For i As Integer = 1 To lng
            Dim random As Integer = GetRandom(1, 3)
            'numbers
            If random = 1 Then
                randomString += Chr(GetRandom(48, 57))
            ElseIf random = 2 Then 'lowercase
                randomString += Chr(GetRandom(97, 122))
            ElseIf random = 3 Then 'uppercase
                randomString += Chr(GetRandom(65, 90))
            End If
        Next

        Return randomString

    End Function

    'number generator
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max + 1)
    End Function

    Private Sub btnCreateVouch_Click(sender As Object, e As EventArgs) Handles btnCreateVouch.Click

        generateAccounts()
        Main.refreshVoucher()
        Me.Close()

    End Sub
End Class