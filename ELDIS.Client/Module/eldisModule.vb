Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports System.Text
Module eldisModule
    Public stream As NetworkStream
    Public streamw As StreamWriter
    Public streamr As StreamReader
    Public client As New TcpClient
    Public t As New Threading.Thread(AddressOf Listen)
    Public Delegate Sub DAddItem(ByVal s As String)
    Public Uhrzeit = DateTime.Now.ToString("HH:mm:ss") & " Uhr | "
    Public Benutzername As String = My.Settings.benutzername

    Function ConnectToELDIS()
        Try
            client.Connect(configModule.ELDISServerIP, configModule.ELDISServerPort) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(My.Settings.benutzername) ' das ist optional.
                streamw.Flush()
                t.Start()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Verbindung zum Server nicht möglich!")
            Application.Exit()
        End Try


        If My.Settings.usertype = "user" Then
            hauptmenu.eldis_tabcontrol.TabPages.Remove(hauptmenu.eldis_einsatzerfassung)
            hauptmenu.eldis_tabcontrol.TabPages.Remove(hauptmenu.eldis_einsatzübersicht)
            hauptmenu.DisponentToolStripMenuItem.Visible = False
            hauptmenu.AdminToolStripMenuItem.Visible = False
        End If

        If My.Settings.usertype = "admin" Then
            hauptmenu.AdminToolStripMenuItem.Visible = True
        End If

        If My.Settings.usertype = "disponent" Then
            hauptmenu.DisponentToolStripMenuItem.Visible = True
            hauptmenu.AdminToolStripMenuItem.Visible = False
        End If
    End Function

    Function ConnectToELDISPager()
        Try
            client.Connect(configModule.ELDISServerIP, configModule.ELDISServerPort) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(My.Settings.benutzername) ' das ist optional.
                streamw.Flush()
                t.Start()
            Else
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End If
        Catch ex As Exception
            MessageBox.Show("Verbindung zum Server nicht möglich!")
            Application.Exit()
        End Try
    End Function

    Function DisconnectToELDIS()
        client.Close()
    End Function

    Private Sub Listen()
        While client.Connected
            Try
            Catch
                MessageBox.Show("Verbindung zum Server nicht möglich!")
                Application.Exit()
            End Try
        End While
    End Sub



    Function StreamToServer(ByVal StringServer As String)
        streamw.WriteLine(StringServer)
    End Function

    Function FlushToServer()
        streamw.Flush()
    End Function
End Module
