Imports MySql.Data.MySqlClient
Public Class meinprofil
    Private Sub meinprofil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetUserData()
    End Sub


    Private Sub GetUserData()
        Dim stringConn As String
        Dim stringCmd As String
        Dim myConn As MySqlConnection
        Dim myCmd As MySqlCommand

        'Frame your query here.
        stringCmd = "Select * FROM sis_users where id= '" & My.Settings.id & "'"

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
            id_box.Text = My.Settings.id
            username_box.Text = myReader.GetString(1)
            steamid_box.Text = myReader.GetString(3)
            usertype_box.Text = myReader.GetString(4)
            yourip_box.Text = myReader.GetString(5)
        End While

        'Close the reader and the connection.
        myReader.Close()
        myConn.Close()

    End Sub
End Class