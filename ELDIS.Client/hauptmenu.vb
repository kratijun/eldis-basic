Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Text

Public Class hauptmenu
    Private nick As String = My.Settings.benutzername
    Dim Uhrzeit As String

    Dim Time As String
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
    Dim EinsatzComboMySQL As String
    Dim READER As MySqlDataReader
    Dim conn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim JetzigeUhrzeit As String
    Dim AlarmUhrzeit As String
    Dim AlarmTime As String
    Dim Einsatznummer As Double
    Dim xcoord As Double
    Dim ycoord As Double
    Dim bar As String
    Dim sirene As Boolean
    Dim probe_sirene As Boolean
    Dim prefix As String



    Dim stringConn As String
    Dim stringCmd As String
    Dim myConn As MySqlConnection
    Dim myCmd As MySqlCommand


    Private Sub hauptmenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        eldisModule.ConnectToELDIS()
        emergencyModule.GetEinsatze()
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        Me.Text = "ELDIS @" & My.Settings.benutzername & " [" & Me.GetType.Assembly.GetName.Version.ToString & "]"
        Dim Uhrzeit = DateTime.Now.ToString("HH:mm:ss") & " Uhr | "
        initELDIS.Dock = DockStyle.Fill
        initELDIS.BackColor = Color.White
        sirene = maßnahme_feuersirene.Checked
        probe_sirene = maßnahme_probesirene.Checked
    End Sub

    Private Sub initELDIS_timer_Tick(sender As Object, e As EventArgs) Handles initELDIS_timer.Tick
        initELDIS.Visible = False
        initELDIS_Label.Visible = False
    End Sub

    Private Sub EinsatzerfassungToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinsatzerfassungToolStripMenuItem.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung
    End Sub

    Private Sub hauptmenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim result As Integer = MessageBox.Show("Willst du ELDIS wirklich beenden?", "ELDIS", MessageBoxButtons.YesNo, MessageBoxIcon.Error)
        If result = DialogResult.Yes Then
            Application.Exit()
            eldisModule.DisconnectToELDIS()
            End
        Else
            If result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub


    Private Sub controlbox_neweinsatz_Click(sender As Object, e As EventArgs) Handles controlbox_neweinsatz.Click
        emergencyModule.CreateEmergency(AlarmUhrzeit, "OFFEN", My.Settings.benutzername, "yes", My.Settings.id)
        einsatznummer_box.Text = My.Settings.currenteinsatzid
        sonstiges_intern.Text = AlarmUhrzeit
        status_box.Text = "OFFEN"
        maßnahme_pager.Enabled = True
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = True
        maßnahme_probesirene.Enabled = True
        maßnahme_ausführen.Enabled = True
        maßnahme_mehr.Enabled = True
        maßnahme_record.Enabled = False
        controlbox_neweinsatz.Enabled = False
        alarmundmelde_alarmstufebox.Enabled = True
        alarmundmelde_meldebildbox.Enabled = True
        einsatzort_straße.Enabled = True
        einsatzort_nr.Enabled = True
        einsatzort_abschnitt.Enabled = True
        einsatzort_postleitzahl.Enabled = True
        einsatzort_stadt.Enabled = True
        einsatzort_objekt.Enabled = True
        sonstiges_extern.Enabled = True
        sonstiges_intern.Enabled = True
    End Sub

    Private Sub controlbox_ende_Click(sender As Object, e As EventArgs) Handles controlbox_ende.Click
        emergencyModule.EndEmergency(einsatznummer_box.Text)
        ' Textboxen-Clearen
        maßnahme_pager.Enabled = False
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = False
        maßnahme_probesirene.Enabled = False
        maßnahme_ausführen.Enabled = False
        maßnahme_mehr.Enabled = False
        controlbox_neweinsatz.Enabled = True
        alarmundmelde_alarmstufebox.Enabled = False
        alarmundmelde_meldebildbox.Enabled = False
        einsatzort_straße.Enabled = False
        einsatzort_nr.Enabled = False
        einsatzort_abschnitt.Enabled = False
        einsatzort_postleitzahl.Enabled = False
        einsatzort_stadt.Enabled = False
        einsatzort_objekt.Enabled = False
        sonstiges_extern.Enabled = False
        sonstiges_intern.Enabled = False

        alarmundmelde_alarmstufebox.Text = ""
        alarmundmelde_meldebildbox.Text = ""
        einsatzort_straße.Text = ""
        einsatzort_nr.Text = ""
        einsatzort_abschnitt.Text = ""
        einsatzort_postleitzahl.Text = ""
        einsatzort_stadt.Text = ""
        einsatzort_objekt.Text = ""
        sonstiges_extern.Text = ""
        sonstiges_intern.Text = ""
        status_box.Text = ""
        einsatznummer_box.Text = ""
        maßnahmen_view.Rows.Clear()
        My.Settings.currenteinsatzid = ""
        '
    End Sub

    Private Sub controlbox_speichern_Click(sender As Object, e As EventArgs) Handles controlbox_speichern.Click
        emergencyModule.SaveEmergency(alarmundmelde_alarmstufebox.Text, alarmundmelde_meldebildbox.Text, AlarmUhrzeit, einsatzort_straße.Text, einsatzort_nr.Text, einsatzort_postleitzahl.Text, einsatzort_stadt.Text, sonstiges_intern.Text, sonstiges_extern.Text, einsatznummer_box.Text)
        'AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        'conn.Open()
        'Dim Query As String

        ''Query = "UPDATE sis_fw_einsatz SET alarmstufe = '" & alarmundmelde_alarmstufebox.Text & "', meldebild= '" & alarmundmelde_meldebildbox.Text & "', datum = '" & AlarmUhrzeit & "', straße = '" & einsatzort_straße.Text & "', nr = '" & einsatzort_nr.Text & "', plz = '" & einsatzort_postleitzahl.Text & "', stadt = '" & einsatzort_stadt.Text & "', einsatzort = '" & einsatzort_straße.Text + " " + einsatzort_nr.Text + ", " + einsatzort_postleitzahl.Text + " " + einsatzort_stadt.Text & "', interne_notizen = '" & sonstiges_intern.Text & "', externe_notizen = '" & sonstiges_extern.Text & "' WHERE einsatznummer = '" & einsatznummer_box.Text & "'"

        'COMMAND = New MySqlCommand(Query, conn)

        'READER = COMMAND.ExecuteReader
        'READER.Close()
        'conn.Close()
    End Sub

    Private Sub PagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagerToolStripMenuItem.Click
        pager.Show()
    End Sub
    Public Sub maßnahme_ausführen_Click(sender As Object, e As EventArgs) Handles maßnahme_ausführen.Click
        emergencyModule.DispoEmergency()
        If sirene = True Then
            prefix = "#sirene"
            maßnahmen_view.Rows.Add("LS-Dummy Generalalarm FW-" & configModule.FeuerwehrName & " Sirene", True)
        ElseIf sirene = False Then
            If maßnahme_pager.Checked = True Then
                prefix = "#pager"
                maßnahmen_view.Rows.Add("LS-Dummy Generalalarm FW-" & configModule.FeuerwehrName & True)
            Else
                If probe_sirene = True Then
                    prefix = "#probesirene"
                    maßnahmen_view.Rows.Add("LS-Dummy Sirenenproberuf" & configModule.FeuerwehrName & True)
                End If
            End If
        End If
        eldisModule.StreamToServer(prefix + " ELS:  " & alarmundmelde_meldebildbox.Text & " (" & alarmundmelde_alarmstufebox.Text & ") " & " für die Feuerwehr " & configModule.FeuerwehrName & ", " & einsatzort_postleitzahl.Text & " " & einsatzort_stadt.Text & ", " & einsatzort_straße.Text & " " & einsatzort_nr.Text & ", " & "Info: " & sonstiges_extern.Text & " um: " & DateTime.Now.ToString("HH:mm : ss"))
        'streamw.WriteLine(prefix + " ELS: " & alarmundmelde_meldebildbox.Text & " (" & alarmundmelde_alarmstufebox.Text & ") " & " für die Feuerwehr " & configModule.FeuerwehrName & ", " & einsatzort_postleitzahl.Text & " " & einsatzort_stadt.Text & ", " & einsatzort_straße.Text & " " & einsatzort_nr.Text & ", " & "Info: " & sonstiges_extern.Text & " um: " & DateTime.Now.ToString("HH:mm:ss"))
        maßnahme_ausführen.BackColor = Color.Green
        eldisModule.FlushToServer()



        'maßnahme_ausführen.backcolor = color.green
        ''if alarmstufecombo.text = "" and adressetext.text = "" & nrtext.text = "" & plztext.text = "" & stadttext.text = "" then
        ''messagebox.show("fülle die einsatzmaske richtig aus!", "eldis", messageboxbuttons.ok)
        ''else
        'dim query as string
        'alarmuhrzeit = datetime.now.tostring("dd/mm/yyyy: " & datetime.now.tostring("hh:mm:ss"))
        'query = "update sis_fw_einsatz set alarmstufe = '" & alarmundmelde_alarmstufebox.text & "',meldebild= '" & alarmundmelde_meldebildbox.text & "', datum = '" & uhrzeit + dayname & "', straße = '" & einsatzort_straße.text & "', nr = '" & einsatzort_nr.text & "', plz = '" & einsatzort_postleitzahl.text & "', stadt = '" & einsatzort_stadt.text & "', interne_notizen = '" & sonstiges_intern.text & "', externe_notizen = '" & sonstiges_extern.text & "' where einsatznummer = '" & einsatznummer_box.text & "'"
        'status_box.text = "offen"
        'command = new mysqlcommand(query, conn)
        'conn.open()
        'reader = command.executereader
        'reader.close()
        'dim sirene as boolean
        'dim probe_sirene as boolean
        'sirene = maßnahme_feuersirene.checked
        'probe_sirene = maßnahme_probesirene.checked
        'dim prefix as string

        'if sirene = true then
        '    prefix = "#sirene"
        '    maßnahmen_view.rows.add("ls-dummy generalalarm fw-" & configmodule.feuerwehrname & " sirene", true)
        'elseif sirene = false then
        '    if maßnahme_pager.checked = true then
        '        prefix = "#pager"
        '        maßnahmen_view.rows.add("ls-dummy generalalarm fw-" & configmodule.feuerwehrname & true)
        '    else
        '        if probe_sirene = true then
        '            prefix = "#probesirene"
        '            maßnahmen_view.rows.add("ls-dummy sirenenproberuf" & configmodule.feuerwehrname & true)
        '        end if
        '    end if
        'end if
        'streamw.writeline(prefix + " els: " & alarmundmelde_meldebildbox.text & " (" & alarmundmelde_alarmstufebox.text & ") " & " für die feuerwehr " & configmodule.feuerwehrname & ", " & einsatzort_postleitzahl.text & " " & einsatzort_stadt.text & ", " & einsatzort_straße.text & " " & einsatzort_nr.text & ", " & "info: " & sonstiges_extern.text & " um: " & datetime.now.tostring("hh:mm:ss"))
        'maßnahme_ausführen.backcolor = color.green
        'streamw.flush()
        'conn.close()
    End Sub

    Private Sub maßnahme_mehr_Click(sender As Object, e As EventArgs) Handles maßnahme_mehr.Click
        maßnahme_list.Show()
    End Sub

    Private Sub EinsatzberichtSchreibenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinsatzberichtSchreibenToolStripMenuItem.Click
        choose_einsatzbericht.Show()

    End Sub

    Private Sub MeinProfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MeinProfilToolStripMenuItem.Click
        meinprofil.Show()
    End Sub

    Private Sub record_sprachaufnahme_Click(sender As Object, e As EventArgs) Handles maßnahme_record.Click
        record_sprachaufnahme.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung
        emergencyModule.CreateEmergency(AlarmUhrzeit, "OFFEN", My.Settings.benutzername, "yes", My.Settings.id)
        einsatznummer_box.Text = My.Settings.currenteinsatzid
        sonstiges_intern.Text = AlarmUhrzeit
        status_box.Text = "OFFEN"
        maßnahme_pager.Enabled = True
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = True
        maßnahme_probesirene.Enabled = True
        maßnahme_ausführen.Enabled = True
        maßnahme_mehr.Enabled = True
        maßnahme_record.Enabled = False
        controlbox_neweinsatz.Enabled = False
        alarmundmelde_alarmstufebox.Enabled = True
        alarmundmelde_meldebildbox.Enabled = True
        einsatzort_straße.Enabled = True
        einsatzort_nr.Enabled = True
        einsatzort_abschnitt.Enabled = True
        einsatzort_postleitzahl.Enabled = True
        einsatzort_stadt.Enabled = True
        einsatzort_objekt.Enabled = True
        sonstiges_extern.Enabled = True
        sonstiges_intern.Enabled = True
    End Sub

    Private Sub einsatzliste_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles einsatzliste.CellDoubleClick
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        Dim cell As DataGridViewCell
        For Each cell In einsatzliste.SelectedCells
            stringCmd = "Select * FROM sis_fw_einsatz where einsatznummer= '" & cell.Value.ToString & "'"
        Next
        'Frame your connection string here.
        stringConn = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")

        'Get your connection here.
        myConn = New MySqlConnection(stringConn)

        'Get a command by using your connection and query.
        myCmd = New MySqlCommand(stringCmd, myConn)

        'Open the connection.
        myConn.Open()

        'create a reader to store the datum which will be returned from the DB
        Dim myReader As MySqlDataReader

        'Execute your query using .ExecuteReader()
        myReader = myCmd.ExecuteReader()

        'Reset your List box here.

        While (myReader.Read())
            'Sperrung wurde auskommentiert, da die Funktion ungültig ist. FIX SOON : p
            If myReader.GetString(18) = "yes" Then
                MessageBox.Show("Dieser Einsatz wird bearbeitet! (" + myReader.GetString(19) + ")", "ELDIS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf myReader.GetString(18) = "no" Then
                eldis_tabcontrol.SelectedTab = eldis_einsatzerfassung
                My.Settings.currenteinsatzid = cell.Value.ToString
                einsatznummer_box.Text = cell.Value.ToString
                sonstiges_intern.Text = AlarmUhrzeit

                status_box.Text = myReader.GetString(4)
                einsatznummer_box.Text = myReader.GetString(0)
                alarmundmelde_alarmstufebox.Text = myReader.GetString(1)
                alarmundmelde_meldebildbox.Text = myReader.GetString(2)
                einsatzort_straße.Text = myReader.GetString(5)
                einsatzort_nr.Text = myReader.GetString(6)
                einsatzort_postleitzahl.Text = myReader.GetString(7)
                einsatzort_stadt.Text = myReader.GetString(8)
                sonstiges_intern.Text = myReader.GetString(15)
                sonstiges_extern.Text = myReader.GetString(16)




                maßnahme_pager.Enabled = True
                maßnahme_proberuf.Enabled = False
                maßnahme_feuersirene.Enabled = True
                maßnahme_probesirene.Enabled = True
                maßnahme_ausführen.Enabled = True
                maßnahme_mehr.Enabled = True
                maßnahme_record.Enabled = True
                controlbox_neweinsatz.Enabled = False
                alarmundmelde_alarmstufebox.Enabled = True
                alarmundmelde_meldebildbox.Enabled = True
                einsatzort_straße.Enabled = True
                einsatzort_nr.Enabled = True
                einsatzort_abschnitt.Enabled = True
                einsatzort_postleitzahl.Enabled = True
                einsatzort_stadt.Enabled = True
                einsatzort_objekt.Enabled = True
                sonstiges_extern.Enabled = True
                sonstiges_intern.Enabled = True
                emergencyModule.OpenEmergency(My.Settings.currenteinsatzid)
            ElseIf myReader.GetString(18) = "end" Then
                MessageBox.Show("Dieser Einsatz wurde bereits beendet!", "ELDIS", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End While

        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetEinsatze()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        emergencyModule.PutAwayEmergency(einsatznummer_box.Text)
        ' Textboxen-Clearen
        maßnahme_pager.Enabled = False
        maßnahme_proberuf.Enabled = False
        maßnahme_feuersirene.Enabled = False
        maßnahme_probesirene.Enabled = False
        maßnahme_ausführen.Enabled = False
        maßnahme_mehr.Enabled = False
        controlbox_neweinsatz.Enabled = True
        alarmundmelde_alarmstufebox.Enabled = False
        alarmundmelde_meldebildbox.Enabled = False
        einsatzort_straße.Enabled = False
        einsatzort_nr.Enabled = False
        einsatzort_abschnitt.Enabled = False
        einsatzort_postleitzahl.Enabled = False
        einsatzort_stadt.Enabled = False
        einsatzort_objekt.Enabled = False
        sonstiges_extern.Enabled = False
        sonstiges_intern.Enabled = False

        alarmundmelde_alarmstufebox.Text = ""
        alarmundmelde_meldebildbox.Text = ""
        einsatzort_straße.Text = ""
        einsatzort_nr.Text = ""
        einsatzort_abschnitt.Text = ""
        einsatzort_postleitzahl.Text = ""
        einsatzort_stadt.Text = ""
        einsatzort_objekt.Text = ""
        sonstiges_extern.Text = ""
        sonstiges_intern.Text = ""
        status_box.Text = ""
        einsatznummer_box.Text = ""
        maßnahmen_view.Rows.Clear()
        My.Settings.currenteinsatzid = ""
        '
    End Sub

    Private Sub controlbox_openeinsatz_Click(sender As Object, e As EventArgs) Handles controlbox_openeinsatz.Click
        eldis_tabcontrol.SelectedTab = eldis_einsatzübersicht
    End Sub

    Private Sub einsatzliste_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles einsatzliste.CellContentClick

    End Sub

    Private Sub NeuenSISBenutzerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuenSISBenutzerToolStripMenuItem.Click
        neuen_sis.Show()
    End Sub

    Private Sub DisponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisponentToolStripMenuItem.Click

    End Sub

    Private Sub eldis_einsatzerfassung_Click(sender As Object, e As EventArgs) Handles eldis_einsatzerfassung.Click

    End Sub
End Class
