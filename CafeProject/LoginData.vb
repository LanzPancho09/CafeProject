Public Class LoginData
    Public Property isRequest As Boolean = False
    Public Property isDenied As Boolean = False
    Public Property noTime As Boolean = False
    Public Property isGuest As Boolean = False
    Public Property isAccount As Boolean = False
    Public Property username As String = Nothing
    Public Property password As String = Nothing
    Public Property userData As Object() = Nothing
End Class
