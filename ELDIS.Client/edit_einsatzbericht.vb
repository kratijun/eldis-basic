Imports MySql.Data.MySqlClient
Public Class edit_einsatzbericht
    Dim AlarmUhrzeit As String
    Private Sub GetAktuellerEinsatz()
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        stringCmd = "Select * FROM sis_fw_einsatz where einsatznummer= '" & My.Settings.currenteinsatzid & "'"

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
            'Add the items from db one by one into the list box.
            einsatznummer_box.Text = My.Settings.currenteinsatzid
            einsatzart_box.Text = myReader.GetString(1) & " | " & myReader.GetString(2)
            einsatzort_box.Text = myReader.GetString(8)
            disponent_box.Text = myReader.GetString(10)
            situation.Text = myReader.GetString(11)
            tätigkeiten.Text = myReader.GetString(12)
            verbrauch.Text = myReader.GetString(13)
            einsatzleiter.Text = My.Settings.benutzername
            status_box.Text = "IN BEARBEITUNG"
        End While

        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()

    End Sub

    Private Sub edit_einsatzbericht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        GetAktuellerEinsatz()
    End Sub

    Private Sub absenden_Click(sender As Object, e As EventArgs) Handles absenden.Click
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        If situation.Text = "" Then
            MessageBox.Show("Fülle den Einsatzbericht richtig aus ;)!", "ELDIS", MessageBoxButtons.OK)
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")

            Dim READER As MySqlDataReader


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "UPDATE sis_fw_einsatz SET situation_am_einsatzort = '" & situation.Text & "',einsatzleiter = '" & einsatzleiter.Text & "',tätigkeiten_am_einsatzort = '" & tätigkeiten.Text & "',verbrauchsmaterial = '" & verbrauch.Text & "',datum = '" & AlarmUhrzeit & "',status = '" & "ERLEDIGT" & "' WHERE einsatznummer = '" & My.Settings.currenteinsatzid & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Einsatzbericht abgeschickt!")
                MysqlConn.Close()
                Me.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        AlarmUhrzeit = DateTime.Now.ToString("dd/MM/yyyy: " & DateTime.Now.ToString("HH:mm:ss"))
        datum_box.Text = AlarmUhrzeit
    End Sub
End Class