Imports System.Data.SqlClient
Imports System.IO

Public Class Startup
    Private sqlConnectionString As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint
        Using g As Graphics = e.Graphics
            Dim p As New Pen(Color.FromArgb(40, 40, 40))

            'TOP
            Dim startPoint As New Point(Panel2.Width, 0)
            Dim endPoint As New Point(Panel1.Width, 0)
            g.DrawLine(p, startPoint, endPoint)

            'RIGHT
            Dim RstartPoint As New Point(Panel1.Width - 1, 0)
            Dim RendPoint As New Point(Panel1.Width - 1, Panel1.Height - 1)
            g.DrawLine(p, RstartPoint, RendPoint)

            'BOTTOM
            Dim BstartPoint As New Point(Panel2.Width, Panel1.Height - 1)
            Dim BendPoint As New Point(Panel1.Width - 1, Panel1.Height - 1)
            g.DrawLine(p, BstartPoint, BendPoint)
        End Using
    End Sub

    Private Sub Startup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
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

    Dim ctr As Integer = 2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        lblloading.Text = "Checking database connection..."

        If ctr = 2 Then

            If checkSQLConnection(sqlConnectionString) Then

                Dim c As New SqlConnection(sqlConnectionString)
                c.Open()

                Dim search As New SqlDataAdapter("SELECT * FROM tblMainAccount", c)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count = 0 Then

                    Dim save As New SqlCommand("INSERT INTO tblMainAccount (id, profileImg, username, password, accLevel, enabled) VALUES (@id, @profileImg, @username, @password, @accLevel, @enabled)", c)
                    save.Parameters.Add(New SqlParameter("@id", SqlDbType.NChar)).Value = table.Rows.Count + 1

                    Dim img As Image = My.Resources.male_admin
                    Using ms As New MemoryStream
                        img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                        save.Parameters.Add(New SqlParameter("@profileImg", SqlDbType.Image)).Value = ms.ToArray
                    End Using

                    save.Parameters.Add(New SqlParameter("@username", SqlDbType.NChar)).Value = "admin"
                    save.Parameters.Add(New SqlParameter("@password", SqlDbType.NChar)).Value = "1234"
                    save.Parameters.Add(New SqlParameter("@accLevel", SqlDbType.Bit)).Value = True
                    save.Parameters.Add(New SqlParameter("@enabled", SqlDbType.Bit)).Value = True
                    save.ExecuteNonQuery()

                End If

                c.Close()
            End If

            pgbar.Value = pgbar.Maximum

        ElseIf ctr > 2 Then
            Me.Hide()
            LoginForm.Show()
            Timer1.Stop()
        End If

        ctr += 1

    End Sub
End Class