Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Security.Cryptography
Imports System.Globalization
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports ComputerInfo
Imports Newtonsoft.Json.Linq

Public Class login
    Dim conn As MySqlConnection

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Bitte fülle die Felder aus!")
        Else
            Dim cmd As New MySqlCommand
            conn = New MySqlConnection
            conn.ConnectionString = ("server=" & configModule.mysqlserver & " ;userid=" & configModule.mysqluser & ";password=" & configModule.mysqlpasswort & ";database=" & configModule.mysqldatabase & "")
            Dim Reader As MySqlDataReader
            Try
                conn.Open()
                Dim query As String
                query = "SELECT * from sis_users where username= '" & UsernameTextBox.Text & "' and password = '" & PasswordTextBox.Text & "'"
                My.Settings.benutzername = UsernameTextBox.Text
                cmd = New MySqlCommand(query, conn)
                Reader = cmd.ExecuteReader

                Dim count As Integer
                count = 0
                While Reader.Read
                    count = count + 1
                End While

                If count = 1 Then

                    Dim usertype = Reader.GetString(4)
                    Dim username = Reader.GetString(1)
                    Dim id = Reader.GetString(0)
                    My.Settings.id = id
                    My.Settings.benutzername = username
                    My.Settings.usertype = usertype

                    If usertype = "admin" Then
                        For j = 0 To 500
                        Next
                        hauptmenu.Show()
                        Me.Hide()
                    ElseIf usertype = "disponent" Then
                        For j = 0 To 500
                        Next
                        hauptmenu.Show()
                        Me.Hide()
                    ElseIf usertype = "user" Then
                        For j = 0 To 500
                        Next
                        hauptmenu.Show()
                        Me.Hide()
                    End If

                    conn.Close()

                Else
                    MsgBox("Dein Passwort ODER Benutzername ist falsch.", MsgBoxStyle.Information)
                End If
            Catch ex As Exception
                MsgBox("Etwas stimmt nicht mit der Datenbankverbindung! Frage bei dem zuständigen Administrator nach und melde dieses Problem.", MsgBoxStyle.Critical)
            Finally
            End Try
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Application.Exit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Dies ist die Konfiguration von ELDIS!!!
        configModule.InitMySQL("deinServer", " deinBenutzer", "deinPasswort", "deineDatenbank")
        configModule.InitELDISServer("deineIP", 8000)
        configModule.FeuerwehrName = "deineFeuerwehr"
        ' ENFERNE DIESE NIEMALS! SONST FUNKTIONIERT DEIN PROGRAMM NICHT!!!
        version.Text = "Version " & Me.GetType.Assembly.GetName.Version.ToString
    End Sub
End Class
