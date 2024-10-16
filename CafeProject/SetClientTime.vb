Imports System.Data.SqlClient
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class SetClientTime

    'SQL Connection
    Private sqlConnection As String = "Server=localhost\SQLEXPRESS; Database=CAFESYS; User Id=sa; Password=1234"
    'CONTROLS
    Private Shared mainControl As ClientControl1 = Nothing
    Private Shared timeControl As ClientTimeControl = Nothing
    Private Shared accControl As AccountControl = Nothing

    Private Shared isClientNew As Boolean = False
    Private isAddTime As Boolean = True
    Private remainingTime As String = "00:00:00"
    Private remainingTotalSeconds As Integer = 0
    Private time As String = "00:00:00"

    'PRICING
    Public Shared pricePerMinute As Double = Settings.getPricePerMinute()
    Private totalPrice As Double = 0.00
    Private discount As Double = 0.00

    Public Sub setMainControl(ByVal c As ClientControl1)
        mainControl = c
    End Sub

    Public Sub setTimeControl(ByVal c As ClientTimeControl)
        timeControl = c
    End Sub

    Public Sub setAccountControl(ByVal c As AccountControl)
        accControl = c
    End Sub

    Public Sub setRemainingTime(ByVal t As String)

        If t IsNot Nothing Then
            Dim splitTime As String() = t.Split(":")
            Me.remainingTime = t
            Me.remainingTotalSeconds = (Val(splitTime(0)) * 3600) + (Val(splitTime(1)) * 60) + Val(splitTime(2))
        End If

    End Sub

    Private Sub SetClientTime_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'SHADOWS
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlHeader, Color.Black, 40, 2, Guna.UI.WinForms.VerHorAlign.HorizontalBottom)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlSeperator, Color.Black, 40, 2, Guna.UI.WinForms.VerHorAlign.HorizontalBottom)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        ShadowForm.Close()
        Main.focusMe()
        Me.Close()
    End Sub
    Private Sub deductControler(ByVal subtractType As String, ByVal x As Integer)

        If subtractType = "hour" Then

            If remainingTotalSeconds >= 3600 Then
                remainingTotalSeconds -= 3600

                If remainingTotalSeconds < 3600 Then
                    btnHour.Enabled = False
                End If
            End If

        ElseIf subtractType = "min" Then

            If x = 30 Then

                If remainingTotalSeconds >= 1800 Then
                    remainingTotalSeconds -= 1800

                    If remainingTotalSeconds < 1800 Then
                        btn30Minute.Enabled = False
                    End If
                End If

            ElseIf x = 5 Then

                If remainingTotalSeconds >= 300 Then
                    remainingTotalSeconds -= 300

                    If remainingTotalSeconds < 300 Then
                        btn5Minute.Enabled = False
                    End If
                End If

            ElseIf x = 1 Then

                If remainingTotalSeconds >= 60 Then
                    remainingTotalSeconds -= 60

                    If remainingTotalSeconds < 60 Then
                        btn5Minute.Enabled = False
                    End If
                End If

            End If

        End If

        If remainingTotalSeconds < 3600 Then
            btnHour.Enabled = False
        End If

        If remainingTotalSeconds < 1800 Then
            btn30Minute.Enabled = False
        End If

        If remainingTotalSeconds < 300 Then
            btn5Minute.Enabled = False
        End If

        If remainingTotalSeconds < 60 Then
            btnMin.Enabled = False
        End If

    End Sub

    Private Sub btnHour_Click(sender As Object, e As EventArgs) Handles btnHour.Click
        AddClientTime(60)
        If Not isAddTime Then
            deductControler("hour", 60)
        End If
    End Sub

    Private Sub btn30Minute_Click(sender As Object, e As EventArgs) Handles btn30Minute.Click
        AddClientTime(30)
        If Not isAddTime Then
            deductControler("min", 30)
        End If
    End Sub

    Private Sub btn5Minute_Click(sender As Object, e As EventArgs) Handles btn5Minute.Click
        AddClientTime(5)
        If Not isAddTime Then
            deductControler("min", 5)
        End If
    End Sub

    Private Sub btnMin_Click(sender As Object, e As EventArgs) Handles btnMin.Click
        AddClientTime(1)
        If Not isAddTime Then
            deductControler("min", 1)
        End If
    End Sub

    Private Sub enableButtons()
        btnHour.Enabled = True
        btn30Minute.Enabled = True
        btn5Minute.Enabled = True
        btnMin.Enabled = True
        btnCustom.Enabled = True
    End Sub

    Private Sub AddClientTime(ByVal x As Integer)

        Dim splitTime As String() = time.Split(":")
        Dim hour As Integer = splitTime(0)
        Dim minute As Integer = splitTime(1)
        Dim sec As Integer = splitTime(2)

        If x > 59 Then
            hour += 1

            If isAddTime Then
                lblTotalTime.Text = hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
                lblMonitorTotalTime.Text = hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
            Else
                lblTotalTime.Text = "- " & hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
                lblMonitorTotalTime.Text = "- " & hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
            End If
        Else
            minute += x

            If minute > 59 Then
                hour += 1
                minute -= 60
            End If

            If isAddTime Then
                lblTotalTime.Text = hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
                lblMonitorTotalTime.Text = hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
            Else
                lblTotalTime.Text = "- " & hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
                lblMonitorTotalTime.Text = "- " & hour.ToString() & " Hour/s " & minute.ToString() & " Minute/s " & sec.ToString() & " Sec/s"
            End If

        End If

        Dim price As Double = ((hour * 60) + minute) * pricePerMinute

        If isAddTime Then
            lblTotal.Text = price.ToString("N2")
            totalPrice = price - discount
            lblTotalPrice.ForeColor = Color.FromArgb(119, 200, 120)
        Else
            lblTotal.Text = "-" & price.ToString("N2")
            totalPrice = (price - discount) * -1
            lblTotalPrice.ForeColor = Color.FromArgb(221, 81, 69)
        End If

        lblTotalPrice.Text = totalPrice.ToString("N2")

        'update new time value.
        time = hour.ToString("00") & ":" & minute.ToString("00") & ":" & sec.ToString("00")

    End Sub

    Private Sub btnAddTime_Click(sender As Object, e As EventArgs) Handles btnAddTime.Click
        isAddTime = True

        btnHour.Enabled = True
        btn30Minute.Enabled = True
        btn5Minute.Enabled = True
        btnMin.Enabled = True

        lblDiscount.Visible = True
        lblTotal.Visible = True
        lblTotalPrice.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label5.Visible = True

        lblTotalTime.Text = "0 Min"
        lblDiscount.Text = "0.00"
        lblTotal.Text = "0.00"
        lblTotalPrice.Text = "0.00"

        time = "00:00:00"
    End Sub

    Private Sub btnDeductTime_Click(sender As Object, e As EventArgs) Handles btnDeductTime.Click
        isAddTime = False

        Dim splitTime As String() = remainingTime.Split(":")
        Me.remainingTotalSeconds = (Val(splitTime(0)) * 3600) + (Val(splitTime(1)) * 60) + Val(splitTime(2))

        If remainingTotalSeconds < 3600 Then
            btnHour.Enabled = False
        End If

        If remainingTotalSeconds < 1800 Then
            btn30Minute.Enabled = False
        End If

        If remainingTotalSeconds < 300 Then
            btn5Minute.Enabled = False
        End If

        If remainingTotalSeconds < 60 Then
            btnMin.Enabled = False
        End If

        lblDiscount.Visible = False
        lblTotal.Visible = False
        lblTotalPrice.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label5.Visible = False

        lblTotalTime.Text = "0 Min"
        lblDiscount.Text = "0.00"
        lblTotal.Text = "0.00"
        lblTotalPrice.Text = "0.00"

        time = "00:00:00"
    End Sub

    Private Sub btnConfirmOrder_Click(sender As Object, e As EventArgs) Handles btnConfirmOrder.Click

        If accControl IsNot Nothing Then

            'ADDTIME ACCOUNT    
            If isAddTime Then
                UpdateClientAccountTime(accControl.getID(), time, True)

                If Main.getModeStatus() Then
                    'ADD A RECORD TO THE SALES CHART DATABASE
                    addSalesRecord(accControl.lblUsername.Text, accControl.getID())
                End If
            Else 'DEDUCT ACCOUNT
                Dim c As New SqlConnection(sqlConnection)
                c.Open()

                Dim search As New SqlDataAdapter("SELECT * FROM tblaccount WHERE AccID='" & accControl.getID() & "'", c)
                Dim table As New DataTable
                search.Fill(table)

                If table.Rows.Count > 0 Then

                    Dim splitTime As String() = time.Split(":")
                    Dim h As Integer = splitTime(0)
                    Dim m As Integer = splitTime(1)
                    Dim s As Integer = splitTime(2)

                    Dim totalDeductSeconds As Integer = (h * 60 + m) * 60 + s

                    Dim currentTime As String() = table.Rows(0)(6).ToString.Split(":")
                    Dim totalSeconds As Integer = ((Val(currentTime(0)) * 60) + Val(currentTime(1))) * 60 + Val(2) 'get the total seconds

                    If totalDeductSeconds >= totalSeconds Then
                        UpdateClientAccountTime(accControl.getID(), "00:00:00", False)
                    Else
                        UpdateClientAccountTime(accControl.getID(), time, True)
                    End If

                End If

                c.Close()
            End If

            Main.loadAccounts()
        Else

            'checks if the client currently is use (onTime)
            If Not timeControl.isOntime() Then
                'computer is not in use.

                isClientNew = True
                'CALCULATING THE STATING TIME OF THE CLIENT AND ENDING TIME AND ALSO DISPLAYING IT IN THE CONTROL
                Dim t As Date = Date.Now
                Dim currentTime As String = t.ToString("hh:mm:ss tt")
                timeControl.lblStart.Text = currentTime

                'ADD TIME
                Dim splitTime As String() = time.Split(":")
                Dim hour As Integer = splitTime(0)
                Dim minute As Integer = splitTime(1)
                Dim second As Integer = splitTime(2)

                t = t.AddHours(hour)
                t = t.AddMinutes(minute)
                t = t.AddSeconds(second)
                timeControl.lblEnd.Text = t.ToString("hh:mm:ss tt")

                timeControl.lblTimeRemaining.Text = time
                timeControl.setTime(time)

                'Checks if the client opened from server meaning the client do not login using vouch or account from database.
                If Not timeControl.isAccountActivated() Then
                    mainControl.addQueue(Information.sendUserData(False, Nothing))
                Else
                    'checks if the account is activated and then updating its time value at the database.   
                    UpdateClientAccountTime(timeControl.getID(), time, True)
                End If

                'set client time
                mainControl.addQueue(Set_Client_Time(time, False, False))

                'Set the client Ontimed
                timeControl.SetOntime(True)
            Else
                'EXTEND TIME
                'update user time

                Dim dt As DateTime = Convert.ToDateTime(timeControl.lblEnd.Text)
                Console.WriteLine("extracted time " & dt.ToString("hh:mm:ss tt"))

                If isAddTime Then

                    Dim splitTime As String() = time.Split(":")
                    Dim hour As Integer = splitTime(0)
                    Dim minute As Integer = splitTime(1)
                    Dim second As Integer = splitTime(2)

                    dt = dt.AddHours(hour)
                    dt = dt.AddMinutes(minute)
                    dt = dt.AddSeconds(second)
                    timeControl.lblEnd.Text = dt.ToString("hh:mm:ss tt")

                    mainControl.addQueue(Set_Client_Time(time, True, False))

                    'checks if the account is activated and then updating its time value at the database.   
                    If timeControl.isAccountActivated() Then
                        UpdateClientAccountTime(timeControl.getID(), time, True)
                    End If
                Else

                    Dim splitTime As String() = time.Split(":")
                    Dim h As Integer = splitTime(0)
                    Dim m As Integer = splitTime(1)
                    Dim s As Integer = splitTime(2)

                    Dim totalDeductSeconds As Integer = (h * 60 + m) * 60 + s

                    'checks if the time deduction is greater than the remaining time
                    'when this happen we just stop the time of the client, Else
                    'we just simply deduct time.
                    If totalDeductSeconds >= timeControl.getTotalSeconds() Then
                        mainControl.addQueue(Information.Stop_Client_Time())
                        timeControl.SetDefault()
                        timeControl.SetOntime(False)

                        'checks if the account is activated and then updating its time value at the database.   
                        If timeControl.isAccountActivated() Then
                            UpdateClientAccountTime(timeControl.getID(), 0, False)
                        End If
                    Else

                        dt = dt.AddHours(-h)
                        dt = dt.AddMinutes(-m)
                        dt = dt.AddSeconds(-timeControl.getSeconds())
                        timeControl.lblEnd.Text = dt.ToString("hh:mm:ss tt")
                        mainControl.addQueue(Set_Client_Time(time, True, True))

                        'checks if the account is activated and then updating its time value at the database.   
                        If timeControl.isAccountActivated() Then
                            UpdateClientAccountTime(timeControl.getID(), time, True)
                        End If
                    End If

                End If

                'Set the client Ontimed
                timeControl.SetOntime(True)
            End If
            MsgBox("Time successfully set!", vbInformation, "Time set successfully!")

            If Main.getModeStatus() And isAddTime Then
                'ADD A RECORD TO THE SALES CHART DATABASE
                addSalesRecord(timeControl.lblName.Text, timeControl.lblComputerNo.Text)
            End If
        End If

        Me.Invoke(Sub()
                      Main.refreshClientStatus()
                  End Sub)

        accControl = Nothing
        timeControl = Nothing
        mainControl = Nothing

        ShadowForm.Close()
        Main.focusMe()
        Me.Close()

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
        Finally
            c.Close()
        End Try

    End Function

    Private Sub addSalesRecord(ByVal clientName As String, ByVal computerNo As String)

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            connection.Open()
            Dim search As New SqlDataAdapter("select * from tblSales", connection)
            Dim table As New DataTable
            search.Fill(table)

            Dim addRecord As New SqlCommand("insert into tblSales (customerID, costumerName, computerNumber, timeAmmount, action, profit, date) values (@customerID, @costumerName, @computerNumber, @timeAmmount, @action, @profit, @date)", connection)
            addRecord.Parameters.Add(New SqlParameter("@customerID", SqlDbType.NChar)).Value = table.Rows.Count + 1
            addRecord.Parameters.Add(New SqlParameter("@costumerName", SqlDbType.NVarChar)).Value = clientName
            addRecord.Parameters.Add(New SqlParameter("@computerNumber", SqlDbType.NChar)).Value = Format(Val(computerNo), 2)
            addRecord.Parameters.Add(New SqlParameter("@timeAmmount", SqlDbType.NVarChar)).Value = time

            'CHECKING THE CLIENT IF IT IS ALREADY RUNNING,
            'IF IT IS THEN THE ACTION IS "NEW"
            'ELSE IF NOT, IT WILL NOW CHECK IF IT IS EXTEND OR DEDUCT
            Dim Myaction As String = Nothing

            If isClientNew Then
                Myaction = "New"
            Else

                If isAddTime Then
                    Myaction = "Extend"
                End If

            End If

            addRecord.Parameters.Add(New SqlParameter("@action", SqlDbType.NChar)).Value = Myaction
            addRecord.Parameters.Add(New SqlParameter("@profit", SqlDbType.NChar)).Value = totalPrice.ToString("N2")
            addRecord.Parameters.Add(New SqlParameter("@date", SqlDbType.DateTime)).Value = Date.Now
            addRecord.ExecuteNonQuery()

            connection.Close()
        Else
            Console.WriteLine("There's an error connecting to a database.")
        End If

    End Sub

    Private Sub UpdateClientAccountTime(ByVal id As Integer, ByVal time As String, ByVal isUpdate As Boolean)

        Dim connection As New SqlConnection(sqlConnection)

        If checkSQLConnection(connection) Then

            Dim c As New SqlConnection(sqlConnection)
            c.Open()

            Dim search As New SqlDataAdapter("SELECT * FROM tblaccount WHERE AccID='" & id & "'", c)
            Dim table As New DataTable
            search.Fill(table)

            If table.Rows.Count > 0 Then

                Dim currentTime As String() = table.Rows(0)(6).ToString.Split(":")
                Dim chour As Integer = currentTime(0)
                Dim cminute As Integer = currentTime(1)
                Dim csecond As Integer = currentTime(2)
                Dim query As String = Nothing

                Dim splitTime As String() = time.Split(":")
                Dim hour As Integer = splitTime(0)
                Dim minute As Integer = splitTime(1)
                Dim second As Integer = splitTime(2)

                If isUpdate Then

                    Console.WriteLine("current time: " & chour.ToString("00") & ":" & cminute.ToString("00") & ":" & csecond.ToString("00"))
                    If isAddTime Then
                        chour += hour
                        cminute += minute
                        csecond += second
                        Console.WriteLine("update time: " & chour.ToString("00") & ":" & cminute.ToString("00") & ":" & csecond.ToString("00"))
                    Else
                        If (chour - hour) < 0 Then
                            chour = 0
                        Else
                            chour -= hour
                        End If

                        If (cminute - minute) < 0 Then
                            cminute = 0
                        Else
                            cminute -= minute
                        End If

                        If (csecond - second) < 0 Then
                            csecond = 0
                        Else
                            csecond -= second
                        End If

                        Console.WriteLine("deduct time: " & chour.ToString("00") & ":" & cminute.ToString("00") & ":" & csecond.ToString("00"))
                    End If

                    Dim newTime As String = chour.ToString("00") & ":" & cminute.ToString("00") & ":" & csecond.ToString("00")
                    query = "UPDATE tblaccount SET AccTime ='" & newTime & "' WHERE AccID = '" & id & "'"
                Else
                    query = "UPDATE tblaccount SET AccTime ='00:00:00' WHERE AccID = '" & id & "'"
                End If

                Dim update As New SqlDataAdapter(query, c)
                Dim updatetable As New DataTable
                update.Fill(updatetable)
            End If

        Else
            Console.WriteLine("Connecting to database failed. : Update client time ")
        End If

    End Sub

    Private Function Set_Client_Time(ByVal time As String, ByVal isUpdate As Boolean, ByVal isDeduct As Boolean) As String

        'CREATE AN TIME DATA OBJECT AND PASSING ITS VALUE INSIDE.
        Dim tData As New TimeData
        tData.isSetTime = True
        tData.isUpdate = isUpdate
        tData.isDeduct = isDeduct
        tData.time = time

        'SERIALIZING THE DATA FOR PUTTING IT ON THE EXTENSION OBJECT DATA.
        Dim Tobj As String = Class1.SerializeObject(Of TimeData)(tData)

        'CREATE AN EXTENSION OBJECT AND PASSING ITS VALUE INSIDE.
        Dim extData As New ObjectExtension
        extData.Extension = ".time"
        extData.ClassObject = Tobj

        'SERIALIZING THE DATA FOR SENDING.
        Dim extObj As String = Class1.SerializeObject(Of ObjectExtension)(extData)

        Console.WriteLine("CLIENT TIME SUCCESSFULLY SET")

        Return extObj

    End Function

    Private Sub lblTotalPrice_TextChanged(sender As Object, e As EventArgs) Handles lblTotalPrice.TextChanged

        If Val(lblTotalPrice.Text) > 0 Then
            lblTotalPrice.ForeColor = Color.FromArgb(119, 200, 120)
        ElseIf Val(lblTotalPrice.Text) < 0 Then
            lblTotalPrice.ForeColor = Color.FromArgb(209, 54, 57)
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        If isAddTime Then

            lblTotalTime.Text = "0 Min"
            lblDiscount.Text = "0.00"
            lblTotal.Text = "0.00"
            lblTotalPrice.Text = "0.00"

            time = "00:00:00"

        Else

            Dim splitTime As String() = remainingTime.Split(":")
            Me.remainingTotalSeconds = (Val(splitTime(0)) * 3600) + (Val(splitTime(1)) * 60) + Val(splitTime(2))

            If remainingTotalSeconds < 3600 Then
                btnHour.Enabled = False
            Else
                btnHour.Enabled = True
            End If

            If remainingTotalSeconds < 1800 Then
                btn30Minute.Enabled = False
            Else
                btn30Minute.Enabled = True
            End If

            If remainingTotalSeconds < 300 Then
                btn5Minute.Enabled = False
            Else
                btn5Minute.Enabled = True
            End If

            If remainingTotalSeconds < 60 Then
                btnMin.Enabled = False
            Else
                btnMin.Enabled = True
            End If

            lblTotalTime.Text = "0 Min"
            lblDiscount.Text = "0.00"
            lblTotal.Text = "0.00"
            lblTotalPrice.Text = "0.00"

            time = "00:00:00"

        End If

    End Sub

    Private Sub SetClientTime_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        accControl = Nothing
        timeControl = Nothing
    End Sub
End Class