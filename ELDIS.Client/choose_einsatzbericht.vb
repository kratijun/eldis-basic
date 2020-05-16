Imports MySql.Data.MySqlClient
Public Class choose_einsatzbericht
    Private Sub choose_einsatzbericht_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetEinsatze()
    End Sub


    Private Sub GetEinsatze()
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
        einsatzbericht.DataSource = table
    End Sub

    Private Sub einsatzbericht_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles einsatzbericht.CellDoubleClick
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        Dim cell As DataGridViewCell
        For Each cell In einsatzbericht.SelectedCells
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
            If myReader.GetString(3) = "ERLEDIGT" Then

                MessageBox.Show("Dieser Einsatz ist gesperrt!", "ELDIS", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                My.Settings.currenteinsatzid = cell.Value.ToString
                edit_einsatzbericht.Show()
                Me.Close()
            End If
        End While

        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()
    End Sub
End Class