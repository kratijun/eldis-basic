Imports ELDIS.Client.My
Module configModule
    Public mysqlserver As String
    Public mysqluser As String
    Public mysqlpasswort As String
    Public mysqldatabase As String
    Public ELDISServerIP As String
    Public ELDISServerPort As Double
    Public FeuerwehrName As String
    Function InitMySQL(ByVal server As String, ByVal user As String, ByVal passwort As String, ByVal database As String)
        mysqlserver = server
        mysqluser = user
        mysqlpasswort = passwort
        mysqldatabase = database
    End Function
    Function InitELDISServer(ByVal ip As String, ByVal port As Double)
        ELDISServerIP = ip
        ELDISServerPort = port
    End Function
    Function InitFeuerwehr(ByVal feuerwehrname As String)
        feuerwehrname = feuerwehrname
    End Function
End Module
