<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class neuen_sis
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.sis_group = New System.Windows.Forms.GroupBox()
        Me.controlbox_neweinsatz = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.sis_dispo = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.sis_fraki = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sis_usergroup = New System.Windows.Forms.ComboBox()
        Me.sis_steamid = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sis_pass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sis_user = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sis_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'sis_group
        '
        Me.sis_group.Controls.Add(Me.controlbox_neweinsatz)
        Me.sis_group.Controls.Add(Me.Label6)
        Me.sis_group.Controls.Add(Me.sis_dispo)
        Me.sis_group.Controls.Add(Me.Label5)
        Me.sis_group.Controls.Add(Me.sis_fraki)
        Me.sis_group.Controls.Add(Me.Label4)
        Me.sis_group.Controls.Add(Me.sis_usergroup)
        Me.sis_group.Controls.Add(Me.sis_steamid)
        Me.sis_group.Controls.Add(Me.Label3)
        Me.sis_group.Controls.Add(Me.sis_pass)
        Me.sis_group.Controls.Add(Me.Label1)
        Me.sis_group.Controls.Add(Me.sis_user)
        Me.sis_group.Controls.Add(Me.Label2)
        Me.sis_group.Location = New System.Drawing.Point(12, 12)
        Me.sis_group.Name = "sis_group"
        Me.sis_group.Size = New System.Drawing.Size(776, 222)
        Me.sis_group.TabIndex = 0
        Me.sis_group.TabStop = False
        '
        'controlbox_neweinsatz
        '
        Me.controlbox_neweinsatz.BackColor = System.Drawing.Color.Teal
        Me.controlbox_neweinsatz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.controlbox_neweinsatz.ForeColor = System.Drawing.Color.White
        Me.controlbox_neweinsatz.Location = New System.Drawing.Point(11, 184)
        Me.controlbox_neweinsatz.Name = "controlbox_neweinsatz"
        Me.controlbox_neweinsatz.Size = New System.Drawing.Size(150, 32)
        Me.controlbox_neweinsatz.TabIndex = 19
        Me.controlbox_neweinsatz.Text = "Benutzer erzeugen"
        Me.controlbox_neweinsatz.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(352, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 17)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Dispo (Nur Polizei):"
        '
        'sis_dispo
        '
        Me.sis_dispo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sis_dispo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sis_dispo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sis_dispo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sis_dispo.FormattingEnabled = True
        Me.sis_dispo.Items.AddRange(New Object() {"yes", "false"})
        Me.sis_dispo.Location = New System.Drawing.Point(355, 124)
        Me.sis_dispo.Name = "sis_dispo"
        Me.sis_dispo.Size = New System.Drawing.Size(415, 21)
        Me.sis_dispo.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(352, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 17)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Fraktion:"
        '
        'sis_fraki
        '
        Me.sis_fraki.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sis_fraki.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sis_fraki.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sis_fraki.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sis_fraki.FormattingEnabled = True
        Me.sis_fraki.Items.AddRange(New Object() {"fire", "ambulance", "police"})
        Me.sis_fraki.Location = New System.Drawing.Point(355, 80)
        Me.sis_fraki.Name = "sis_fraki"
        Me.sis_fraki.Size = New System.Drawing.Size(415, 21)
        Me.sis_fraki.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(350, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Benutzergruppe:"
        '
        'sis_usergroup
        '
        Me.sis_usergroup.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sis_usergroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.sis_usergroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.sis_usergroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sis_usergroup.FormattingEnabled = True
        Me.sis_usergroup.Items.AddRange(New Object() {"user", "disponent", "admin"})
        Me.sis_usergroup.Location = New System.Drawing.Point(353, 36)
        Me.sis_usergroup.Name = "sis_usergroup"
        Me.sis_usergroup.Size = New System.Drawing.Size(415, 21)
        Me.sis_usergroup.TabIndex = 13
        '
        'sis_steamid
        '
        Me.sis_steamid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sis_steamid.Location = New System.Drawing.Point(13, 122)
        Me.sis_steamid.Name = "sis_steamid"
        Me.sis_steamid.Size = New System.Drawing.Size(333, 20)
        Me.sis_steamid.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(10, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "SteamID:"
        '
        'sis_pass
        '
        Me.sis_pass.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sis_pass.Location = New System.Drawing.Point(13, 79)
        Me.sis_pass.Name = "sis_pass"
        Me.sis_pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.sis_pass.Size = New System.Drawing.Size(333, 20)
        Me.sis_pass.TabIndex = 9
        Me.sis_pass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Passwort:"
        '
        'sis_user
        '
        Me.sis_user.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sis_user.Location = New System.Drawing.Point(11, 36)
        Me.sis_user.Name = "sis_user"
        Me.sis_user.Size = New System.Drawing.Size(333, 20)
        Me.sis_user.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Benutzername:"
        '
        'neuen_sis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 246)
        Me.Controls.Add(Me.sis_group)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "neuen_sis"
        Me.Text = "Neuen ELDIS Benutzer"
        Me.sis_group.ResumeLayout(False)
        Me.sis_group.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents sis_group As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents sis_fraki As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sis_usergroup As ComboBox
    Friend WithEvents sis_steamid As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents sis_pass As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents sis_user As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents sis_dispo As ComboBox
    Friend WithEvents controlbox_neweinsatz As Button
End Class
