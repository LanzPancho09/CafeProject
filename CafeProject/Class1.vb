Imports System.IO
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Public Class Class1
    Public Shared Function SerializeObject(Of t)(ByVal obj As t) As String
        Try
            Dim xmlString As String = Nothing
            Dim memoryStream As New MemoryStream
            Dim xs As XmlSerializer = New XmlSerializer(GetType(t))
            Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(memoryStream, Encoding.UTF8)
            xs.Serialize(xmlTextWriter, obj)
            memoryStream = CType(xmlTextWriter.BaseStream, MemoryStream)
            xmlString = Converters.ByteArrayToUTF8String(memoryStream.ToArray())
            Return xmlString
        Catch ex As Exception
            Console.WriteLine(ex.Message & "Serializing error")
            Return String.Empty
        End Try
    End Function

    Public Shared Function DeserializeObject(Of t)(ByVal xml As String) As t
        Dim xs As XmlSerializer = New XmlSerializer(GetType(t))
        Dim memoryStream As MemoryStream = New MemoryStream(Converters.StringToUTF8ByteArray(xml))
        Dim xmlTextWriter As XmlTextWriter = New XmlTextWriter(memoryStream, Encoding.UTF8)
        Return CType(xs.Deserialize(memoryStream), t)
    End Function

    Public Class Converters
        Public Shared Function ByteArrayToUTF8String(ByVal characters As Byte()) As String
            Dim encoding As UTF8Encoding = New UTF8Encoding()
            Dim constructedString As String = encoding.GetString(characters)
            Return (constructedString)
        End Function

        Public Shared Function StringToUTF8ByteArray(ByVal stringVal As String) As Byte()
            Dim encoding As UTF8Encoding = New UTF8Encoding()
            Dim byteArray As Byte() = encoding.GetBytes(stringVal)
            Return byteArray
        End Function
    End Class

End Class
