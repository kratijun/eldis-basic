Imports ELDIS.Client.hauptmenu
Imports MySql.Data.MySqlClient
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports System.Text
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
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Dim Uhrzeit = DateTime.Now.ToString("HH:mm:ss") & " Uhr | "
    Private nick As String = My.Settings.benutzername
    Function NewEmergency()
        conn = New MySqlConnection()
        conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
        hauptmenu.maßnahme_ausführen.BackColor = Color.Green
        'If alarmstufeCombo.Text = "" And adressetext.Text = "" & nrtext.Text = "" & plztext.Text = "" & stadttext.Text = "" Then
        'MessageBox.Show("Fülle die Einsatzmaske richtig aus!", "ELDIS", MessageBoxButtons.OK)
        'Else
        Dim Query As String
        Dim AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        Query = "UPDATE sis_fw_einsatz SET alarmstufe = '" & hauptmenu.alarmundmelde_alarmstufebox.Text & "',meldebild= '" & hauptmenu.alarmundmelde_meldebildbox.Text & "', datum = '" & Uhrzeit + dayName & "', straße = '" & hauptmenu.einsatzort_straße.Text & "', nr = '" & hauptmenu.einsatzort_nr.Text & "', plz = '" & hauptmenu.einsatzort_postleitzahl.Text & "', stadt = '" & hauptmenu.einsatzort_stadt.Text & "', interne_notizen = '" & hauptmenu.sonstiges_intern.Text & "', externe_notizen = '" & hauptmenu.sonstiges_extern.Text & "' WHERE einsatznummer = '" & hauptmenu.einsatznummer_box.Text & "'"
        hauptmenu.status_box.Text = "OFFEN"
        COMMAND = New MySqlCommand(Query, conn)
        conn.Open()
        READER = COMMAND.ExecuteReader
        READER.Close()

    End Function
End Module
