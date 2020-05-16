Imports MySql.Data.MySqlClient
Public Class neuen_sis
    Private Sub controlbox_neweinsatz_Click(sender As Object, e As EventArgs) Handles controlbox_neweinsatz.Click
        Dim MysqlConn As MySqlConnection
        Dim COMMAND As MySqlCommand
        If sis_user.Text = "" Then
            MessageBox.Show("Fülle die Maske richtig aus!", "ELDIS", MessageBoxButtons.OK)
        Else
            MysqlConn = New MySqlConnection
            MysqlConn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")

            Dim READER As MySqlDataReader


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "insert into sis_users (username,password,steamid,usertype,isdispo,fraktion) values ('" & sis_user.Text & "','" & sis_pass.Text & "','" & sis_steamid.Text & "','" & sis_usergroup.Text & "','" & sis_dispo.Text & "','" & sis_fraki.Text & "')"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader
                MsgBox("Benutzer mit dem Namen " & sis_user.Text & " und mit dem Passwort " & sis_pass.Text & " angelegt!", MsgBoxStyle.Information)
                MysqlConn.Close()

            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()

            End Try
        End If

    End Sub

    Private Sub neuen_sis_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class