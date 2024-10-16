Imports System.IO

Public Class Converter

    ' CONVERTING A FILE TO A BYTE ARRAY AND IT RETURN THE BYTE ARRAY OF AN FILE
    Public Shared Function FileToByteArray(FileName As String) As Byte()

        Dim stream As FileStream = File.OpenRead(FileName)
        Dim fileBytes As Byte() = New Byte(stream.Length - 1) {}
        stream.Read(fileBytes, 0, fileBytes.Length)
        stream.Close()

        Return fileBytes
    End Function

    'BYTE ARRAY FROM THE NETWORK STREAM AND CONVERTING IT INTO A FILE ON SPECIFIC FILE LOCATION.
    Public Shared Sub ByteArrayToFile(bytearray As Byte(), ReceiveFolder As String, FileName As String)

        'READING A BYTE ARRAY AND CONVERTING IT INTO A FILE

        Dim FileLocation As String = ReceiveFolder & FileName

        Using exfile As Stream = File.OpenWrite(FileLocation)
            exfile.Write(bytearray, 0, bytearray.Length)
        End Using

        'CHECKS THE FILE IF IT WAS CREATED (SUCCESSFULLY RECEIVED), AND IT WILL SEND A COMMAND TO
        'THE NETWORK STREAM THAT A SPECIFIC FILE IS SUCCESSFULLY RECIEVED.
        If File.Exists(FileLocation) Then
            Console.WriteLine("File received")
        End If


    End Sub

    Public Shared Function setImage(ByVal img As Image) As Byte()

        Using ms As New MemoryStream
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            Return ms.GetBuffer()
        End Using

    End Function

    Public Shared Function getImage(ByVal imgbyte As Byte()) As Image

        Dim img As Image
        Dim ms As MemoryStream = New MemoryStream(imgbyte)
        img = System.Drawing.Image.FromStream(ms)
        Return img

    End Function

    Public Shared Function SafeImageFromFile(path As String) As Image
        Using fs As New FileStream(path, FileMode.Open, FileAccess.Read)
            Dim img = Image.FromStream(fs)
            Return img
        End Using
    End Function

    Public Shared Function CalculateBytes(ByVal totalbyte As Long) As String

        Dim ctr As Integer = 0
        Dim sizeTerm As String() = {"B", "KB", "MB", "GB", "TB", "PB"}
        Dim size As Double = Convert.ToDouble(totalbyte)

        While size > 1024
            size /= 1024
            ctr += 1
        End While

        If ctr > 5 Then
            ctr = 5
        End If

        Return size.ToString("F2") & " " & sizeTerm(ctr) & "/s"

    End Function

    Public Shared Function computePercentage(ByVal inputvalue As Long, ByVal max As Long) As Integer

        ' 0 = min value
        Dim compute As Double = (Convert.ToDouble(inputvalue) / Convert.ToDouble(max)) * 100
        Dim result As Double = Math.Truncate(compute)
        'Console.WriteLine("compute" & compute)
        'Console.WriteLine("result" & result)

        If result >= Integer.MaxValue Then
            result = 0
        End If

        If Double.IsNaN(result) Then
            result = 0
        End If

        Return result

    End Function

End Class
