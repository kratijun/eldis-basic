Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel
Imports TeamSpeak3QueryApi.Net
Imports System.Runtime.InteropServices
Public Class pager
    Private Declare Function PlaySound Lib "winmm.dll" Alias "PlaySoundA" (ByVal lpszName As String, ByVal hModule As Int32, ByVal dwFlags As Int32) As Int32
    Private stream As NetworkStream
    Private streamw As StreamWriter
    Private streamr As StreamReader
    Private client As New TcpClient
    Private t As New Threading.Thread(AddressOf Listen)
    Private Delegate Sub DAddItem(ByVal s As String)
    Private nick As String = My.Settings.benutzername & "'s Pager"
    Dim FilePath As String = "C:/Sprachaufnahme.mp3"
    Dim FilePathPager As String = "C:/pager.wav"
    Dim Prefix As String
    Private Const SND_FILENAME As Int32 = &H20000
    Public Const SND_ASYNC = &H1

    Private Sub AddItem(ByVal s As String)
        Dim x = s.Split(New Char() {" "c}, 2)
        pager_text.Text = x(1)
        Select Case x(0)
            Case "#sirene"
                Me.Show()
                PlaySirenenAlarm()
                Prefix = "#sirene"
            Case "#pager"
                Me.Show()
                PlayStillerAlarm()
                Prefix = "#pager"
            Case "#probesirene"
                Me.Show()
                PlayProbeSirenenAlarm()
                Prefix = "#probesirene"
        End Select
    End Sub


    Private Sub SpieleSprachaufnahme()
        '        My.Computer.Audio.Play("C:/Sprachaufnahme.mp3",
        'AudioPlayMode.Background)
        Dim musicAlias As String = "myAudio"
        PlaySound(FilePath, Nothing, SND_FILENAME Or SND_ASYNC)
    End Sub

    Private Sub pager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            client.Connect(configModule.ELDISServerIP, configModule.ELDISServerPort) ' hier die ip des servers eintragen. 
            ' da dieser beim testen wohl lokal läuft, hier die loopback-ip 127.0.0.1.
            If client.Connected Then
                stream = client.GetStream
                streamw = New StreamWriter(stream)
                streamr = New StreamReader(stream)
                streamw.WriteLine(nick) ' das ist optional.
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
    End Sub

    Sub PlayStillerAlarm()
        My.Computer.Audio.Play(My.Resources.pager,
        AudioPlayMode.Background)
    End Sub

    Sub PlaySirenenAlarm()
        My.Computer.Audio.Play(My.Resources.sirene_feuer,
        AudioPlayMode.Background)
    End Sub

    Sub PlayProbeSirenenAlarm()
        My.Computer.Audio.Play(My.Resources.sirene_probe,
        AudioPlayMode.Background)
    End Sub

    Private Sub Listen()
        While client.Connected
            Try
                Me.Invoke(New DAddItem(AddressOf AddItem), streamr.ReadLine)
            Catch
            End Try
        End While
    End Sub

    Private Sub pager_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Me.Hide()
    End Sub

End Class