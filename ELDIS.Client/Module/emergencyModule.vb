Imports ELDIS.Client.hauptmenu
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports System.Text
Imports ELDIS.Client.eldisModule
Module emergencyModule
    Dim hauptmenu As New hauptmenu
    Dim Time As String
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
    Dim EinsatzComboMySQL As String
    Dim READER As MySqlDataReader
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Public stream As NetworkStream
    Public streamw As StreamWriter
    Public streamr As StreamReader
    Public client As New TcpClient
    Public LastEmergencyIDText As String

    Function DispoEmergency()
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        hauptmenu.maßnahme_ausführen.BackColor = Color.Green
        'If alarmstufeCombo.Text = "" And adressetext.Text = "" & nrtext.Text = "" & plztext.Text = "" & stadttext.Text = "" Then
        'MessageBox.Show("Fülle die Einsatzmaske richtig aus!", "ELDIS", MessageBoxButtons.OK)
        'Else
        Dim Query As String
        Dim AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        Query = "UPDATE sis_fw_einsatz SET alarmstufe = '" & hauptmenu.alarmundmelde_alarmstufebox.Text & "',meldebild= '" & hauptmenu.alarmundmelde_meldebildbox.Text & "', datum = '" & eldisModule.Uhrzeit + dayName & "', straße = '" & hauptmenu.einsatzort_straße.Text & "', nr = '" & hauptmenu.einsatzort_nr.Text & "', plz = '" & hauptmenu.einsatzort_postleitzahl.Text & "', stadt = '" & hauptmenu.einsatzort_stadt.Text & "', interne_notizen = '" & hauptmenu.sonstiges_intern.Text & "', externe_notizen = '" & hauptmenu.sonstiges_extern.Text & "' WHERE einsatznummer = '" & hauptmenu.einsatznummer_box.Text & "'"
        hauptmenu.status_box.Text = "OFFEN"
        COMMAND = New MySqlCommand(Query, conn)
        conn.Open()
        READER = COMMAND.ExecuteReader
        READER.Close()

    End Function

    Function CreateEmergency(ByVal datum As String, ByVal status As String, ByVal disponent As String, ByVal islocked As String, ByVal idlocked As Double)
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        conn.Open()
        Dim QueryID As String
        QueryID = "insert into sis_fw_einsatz (datum,status,disponent,islocked,idlocked) values ('" & Uhrzeit & "','" & "OFFEN" & "','" & My.Settings.benutzername & "','" & "yes" & "','" & My.Settings.id & "')"
        COMMAND = New MySqlCommand(QueryID, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()

        conn.Open()
        QueryID = "SELECT MAX(einsatznummer) FROM sis_fw_einsatz"
        Dim cmd_query As New MySqlCommand(QueryID, conn)
        Dim cmd_result As Integer = CInt(cmd_query.ExecuteScalar())
        My.Settings.currenteinsatzid = cmd_result
        hauptmenu.einsatznummer_box.Text = cmd_result
        COMMAND = New MySqlCommand(QueryID, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Function

    Function OpenEmergency(ByVal einsatzid As String)
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET idlocked = '" & My.Settings.id & "',islocked = '" & "yes" & "' WHERE einsatznummer = '" & einsatzid & "'"
        COMMAND = New MySqlCommand(Query, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Function

    Function SaveEmergency(ByVal alarmstufe As String, ByVal meldebild As String, ByVal datum As String, ByVal straße As String, ByVal nr As String, ByVal plz As String, ByVal stadt As String, ByVal interne_notizen As String, ByVal externe_notizen As String, ByVal whereEinsatzID As String)
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        conn.Open()
        Dim Query As String

        Query = "UPDATE sis_fw_einsatz SET 
alarmstufe = '" & alarmstufe & "', 
meldebild= '" & meldebild & "', 
datum = '" & datum & "', 
straße = '" & straße & "', 
nr = '" & nr & "', plz = '" & plz & "', 
stadt = '" & stadt & "', 
einsatzort = '" & straße + " " + nr + ", " + plz + " " + stadt & "', 
interne_notizen = '" & interne_notizen & "', 
externe_notizen = '" & externe_notizen & "' 
WHERE einsatznummer = '" & whereEinsatzID & "'"
        COMMAND = New MySqlCommand(Query, conn)

        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Function

    Function PutAwayEmergency(ByVal whereEinsatzID As String)
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET status = '" & "OFFEN" & "',idlocked = '" & "" & "',islocked = '" & "no" & "' WHERE einsatznummer = '" & whereEinsatzID & "'"
        COMMAND = New MySqlCommand(Query, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Function

    Function EndEmergency(ByVal whereEinsatzID As String)
        conn.Open()
        Dim Query As String
        Query = "UPDATE sis_fw_einsatz SET status = '" & "ABGESCHLOSSEN" & "',idlocked = '" & "" & "',islocked = '" & "end" & "' WHERE einsatznummer = '" & whereEinsatzID & "'"
        COMMAND = New MySqlCommand(Query, conn)
        READER = COMMAND.ExecuteReader
        READER.Close()
        conn.Close()
    End Function

    Function GetEinsatze(ByVal whatTable As DataGridView)
        Dim conn As MySqlConnection
        Dim cmd As New MySqlCommand
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        Try
            conn.Open() ' Verbindung öffnen
        Catch myerror As MySqlException
            MsgBox("Keine Verbindung zur Datenbank : " & myerror.Message.ToString) ' Falls Fehler : Fehler anzeigen
        End Try
        Dim table As New DataTable
        cmd.Connection = conn
        cmd.CommandText = "SELECT einsatznummer as 'Einsatznummer',datum as 'Datum',alarmstufe as 'Alarmstufe',meldebild as 'Meldebild', einsatzort as 'Einsatzadresse' FROM sis_fw_einsatz"

        Dim adapter As New MySqlDataAdapter
        adapter.SelectCommand = cmd
        adapter.Fill(table)
        whatTable.DataSource = table
    End Function
End Module
