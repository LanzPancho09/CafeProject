Imports System.Net
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class ManageClientControl

    Public Shared Function Create_Client_Control(ByVal client As TcpClient, ByVal objArray As Object()) As ClientControl1

        Dim Clientcontainer As New ClientControl1
        Clientcontainer.Margin = New Padding(0, 5, 0, 0)

        Clientcontainer.setInfo(client, objArray)

        With Clientcontainer
            .BackColor = Color.FromArgb(255, 255, 255)
        End With

        Return Clientcontainer

    End Function

    Public Shared Function Create_Client_Screen_Control(ByVal parentControl As ClientControl1, ByVal name As String, ByVal screensize As Point) As ClientScreenControl

        Dim control As New ClientScreenControl
        control.Margin = New Padding(3, 3, 0, 0)

        With control
            .setParentControl(parentControl)
            .setScreenDimension(screensize)
            .setName(name)
            .BackColor = Color.FromArgb(255, 255, 255)
            .lblName.BackColor = Color.FromArgb(100, 40, 40, 40)
            .lblName.Parent = control.pbScreen
            .lblName.Text = name
        End With

        Main.flpMonitorScreen.Controls.Add(control)

        Return control
    End Function

    Public Shared Function Create_Client_Message_Control(ByVal c As ChatBoxControl, ByVal msg As String, ByVal isUser As Boolean) As ChatBoxControl

        'NOTE
        ' max character length of a line is 45
        ' new line height + 15

        Dim control As ChatBoxControl

        If c IsNot Nothing Then
            control = c
        Else
            control = New ChatBoxControl
            control.Margin = New Padding(0, 1, 0, 0)
            control.Width = Main.flpMonitorChat.Width - 20
        End If

        With control
            .Dock = DockStyle.Top
            .setUser(isUser)

            Dim maxLabelCharacters As Integer = 40
            Dim line As Integer = msg.Length \ maxLabelCharacters

            If msg.Length >= maxLabelCharacters Then
                Dim messageline As String = ""
                Dim messagelength As Integer = 0

                '.Size = New Size(control.Width, control.Height + (15 * line))
                '.lblName.Size = New Size(control.lblName.Width, control.lblName.Height + (15 * line))

                If msg.Contains(" ") Then

                    Dim words As String() = msg.Split(" ")

                    For Each word As String In words

                        If (messagelength + word.Length) < maxLabelCharacters Then
                            messageline += word & " "
                            messagelength += word.Length + 1
                        Else

                            Dim newLabel As New Label
                            newLabel.Size = New Size(control.flpMessage.Width, control.lblName.Height)
                            newLabel.Padding = New Padding(0)
                            newLabel.ForeColor = Color.FromArgb(40, 40, 40)
                            newLabel.Text = messageline
                            AddHandler newLabel.MouseEnter, AddressOf control.pbImage_MouseEnter
                            AddHandler newLabel.MouseLeave, AddressOf control.pbImage_MouseLeave

                            .flpMessage.Controls.Add(newLabel)

                            If .flpMessage.Controls.Count > 2 Then
                                .Size = New Size(control.Width, control.Height + newLabel.Height)
                                .flpMessage.Size = New Size(.flpMessage.Width, .flpMessage.Height + newLabel.Height)
                            End If

                            messageline = word & " "
                            messagelength = word.Length + 1

                        End If

                    Next

                Else

                    For Each chr As Char In msg
                        messageline += chr
                        messagelength += 1

                        If messagelength >= maxLabelCharacters Then
                            'messageline += "-"

                            Dim newLabel As New Label
                            newLabel.Size = New Size(control.flpMessage.Width, control.lblName.Height)
                            newLabel.Padding = New Padding(0)
                            newLabel.ForeColor = Color.FromArgb(40, 40, 40)
                            newLabel.Text = messageline
                            AddHandler newLabel.MouseEnter, AddressOf control.pbImage_MouseEnter
                            AddHandler newLabel.MouseLeave, AddressOf control.pbImage_MouseLeave

                            .flpMessage.Controls.Add(newLabel)

                            If .flpMessage.Controls.Count > 2 Then
                                .Size = New Size(control.Width, control.Height + newLabel.Height)
                                .flpMessage.Size = New Size(.flpMessage.Width, .flpMessage.Height + newLabel.Height)
                            End If

                            messageline = Nothing
                            messagelength = 0
                        End If
                    Next
                    messageline += " "
                    messagelength += 1

                End If

                If messageline IsNot Nothing Then
                    Dim newLabel As New Label
                    newLabel.Size = New Size(control.flpMessage.Width, control.lblName.Height)
                    newLabel.Padding = New Padding(0)
                    newLabel.ForeColor = Color.FromArgb(40, 40, 40)
                    newLabel.Text = messageline
                    AddHandler newLabel.MouseEnter, AddressOf control.pbImage_MouseEnter
                    AddHandler newLabel.MouseLeave, AddressOf control.pbImage_MouseLeave

                    .flpMessage.Controls.Add(newLabel)

                    If .flpMessage.Controls.Count > 2 Then
                        .Size = New Size(control.Width, control.Height + newLabel.Height)
                        .flpMessage.Size = New Size(.flpMessage.Width, .flpMessage.Height + newLabel.Height)
                    End If
                End If

            Else
                Dim newLabel As New Label
                newLabel.Size = New Size(control.flpMessage.Width, control.lblName.Height)
                newLabel.Padding = New Padding(0)
                newLabel.ForeColor = Color.FromArgb(40, 40, 40)
                newLabel.Text = msg
                AddHandler newLabel.MouseEnter, AddressOf control.pbImage_MouseEnter
                AddHandler newLabel.MouseLeave, AddressOf control.pbImage_MouseLeave

                .flpMessage.Controls.Add(newLabel)

                If .flpMessage.Controls.Count > 2 Then
                    .Size = New Size(control.Width, control.Height + newLabel.Height)
                    .flpMessage.Size = New Size(.flpMessage.Width, .flpMessage.Height + newLabel.Height)
                End If
            End If
        End With

        Return control

    End Function

    Public Shared Function Create_Client_Contact(ByVal c As ClientControl1, ByVal clientImg As Image, ByVal clientName As String) As ClientMessageControl

        Dim control As New ClientMessageControl
        control.Margin = New Padding(3, 3, 0, 0)

        With control

            .SetMainControl(c)
            .pbProfile.Image = clientImg
            .lblName.Text = clientName
            .lblDate.Text = Format(Date.Today, "MMMM dd, yyyy")
            .lblMessage.Text = ""

        End With

        Main.flpMonitorMessage.Controls.Add(control)

        Return control

    End Function

    Public Shared Function CreateTimeControl(ByVal profileImg As Image, ByVal cName As String, ByVal cNumber As String, ByVal IPAddress As String) As ClientTimeControl

        Dim control As New ClientTimeControl
        control.Margin = New Padding(0)

        With control
            'DISPLAY INFO
            .pbImage.Image = profileImg
            .lblName.Text = cName
            .lblIpAddress.Text = IPAddress
            .lblComputerNo.Text = cNumber
        End With

        Main.flpMonitorTimer.Controls.Add(control)

        If Main.flpMonitorTimer.Controls.Count > 0 Then
            Main.cbSort.Enabled = True
        End If

        Return control

    End Function

End Class
