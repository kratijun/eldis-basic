<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class hauptmenu
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ELDISToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FunkgerätToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisponentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinsatzerfassungToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuenSISBenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BenutzerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinsatzberichtSchreibenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MeinProfilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.eldis_tabcontrol = New System.Windows.Forms.TabControl()
        Me.tab_startseite = New System.Windows.Forms.TabPage()
        Me.initELDIS_Label = New System.Windows.Forms.Label()
        Me.initELDIS = New System.Windows.Forms.PictureBox()
        Me.eldis_einsatzerfassung = New System.Windows.Forms.TabPage()
        Me.einsatzerfassung_maßnahmen = New System.Windows.Forms.GroupBox()
        Me.maßnahme_record = New System.Windows.Forms.Button()
        Me.maßnahmen_view = New System.Windows.Forms.DataGridView()
        Me.Maßnahme = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ausgeführt = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.maßnahme_mehr = New System.Windows.Forms.Button()
        Me.maßnahme_ausführen = New System.Windows.Forms.Button()
        Me.maßnahme_probesirene = New System.Windows.Forms.RadioButton()
        Me.maßnahme_feuersirene = New System.Windows.Forms.RadioButton()
        Me.maßnahme_proberuf = New System.Windows.Forms.RadioButton()
        Me.maßnahme_pager = New System.Windows.Forms.RadioButton()
        Me.einsatzerfassung_sonstiges = New System.Windows.Forms.GroupBox()
        Me.sonstiges_extern = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.sonstiges_intern = New System.Windows.Forms.TextBox()
        Me.einsatzerfassung_einsatzort = New System.Windows.Forms.GroupBox()
        Me.einsatzort_objekt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.einsatzort_stadt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.einsatzort_postleitzahl = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.einsatzort_abschnitt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.einsatzort_nr = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.einsatzort_straße = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.einsatzerfassung_meldeundalarm = New System.Windows.Forms.GroupBox()
        Me.alarmundmelde_meldebild = New System.Windows.Forms.Label()
        Me.alarmundmelde_meldebildbox = New System.Windows.Forms.ComboBox()
        Me.alarmundmelde_alarmstufe = New System.Windows.Forms.Label()
        Me.alarmundmelde_alarmstufebox = New System.Windows.Forms.ComboBox()
        Me.einsatzerfassung_einsatz = New System.Windows.Forms.GroupBox()
        Me.einsatznummer_box = New System.Windows.Forms.TextBox()
        Me.einsatz_einsatznummer = New System.Windows.Forms.Label()
        Me.status_box = New System.Windows.Forms.TextBox()
        Me.einsatz_status = New System.Windows.Forms.Label()
        Me.einsatzerfassung_controlbox = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.controlbox_openeinsatz = New System.Windows.Forms.Button()
        Me.controlbox_ende = New System.Windows.Forms.Button()
        Me.controlbox_speichern = New System.Windows.Forms.Button()
        Me.controlbox_neweinsatz = New System.Windows.Forms.Button()
        Me.eldis_einsatzübersicht = New System.Windows.Forms.TabPage()
        Me.einsatzübersicht_box = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.einsatzliste = New System.Windows.Forms.DataGridView()
        Me.initELDIS_timer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.eldis_tabcontrol.SuspendLayout()
        Me.tab_startseite.SuspendLayout()
        CType(Me.initELDIS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.eldis_einsatzerfassung.SuspendLayout()
        Me.einsatzerfassung_maßnahmen.SuspendLayout()
        CType(Me.maßnahmen_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.einsatzerfassung_sonstiges.SuspendLayout()
        Me.einsatzerfassung_einsatzort.SuspendLayout()
        Me.einsatzerfassung_meldeundalarm.SuspendLayout()
        Me.einsatzerfassung_einsatz.SuspendLayout()
        Me.einsatzerfassung_controlbox.SuspendLayout()
        Me.eldis_einsatzübersicht.SuspendLayout()
        Me.einsatzübersicht_box.SuspendLayout()
        CType(Me.einsatzliste, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELDISToolStripMenuItem, Me.DisponentToolStripMenuItem, Me.AdminToolStripMenuItem, Me.BenutzerToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 1, 0, 1)
        Me.MenuStrip1.Size = New System.Drawing.Size(1759, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "eldis_menustrip"
        '
        'ELDISToolStripMenuItem
        '
        Me.ELDISToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagerToolStripMenuItem, Me.FunkgerätToolStripMenuItem})
        Me.ELDISToolStripMenuItem.Name = "ELDISToolStripMenuItem"
        Me.ELDISToolStripMenuItem.Size = New System.Drawing.Size(48, 22)
        Me.ELDISToolStripMenuItem.Text = "ELDIS"
        '
        'PagerToolStripMenuItem
        '
        Me.PagerToolStripMenuItem.Image = ELDIS.Client.My.Resources.Resources._32_0
        Me.PagerToolStripMenuItem.Name = "PagerToolStripMenuItem"
        Me.PagerToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.PagerToolStripMenuItem.Text = "Pager"
        '
        'FunkgerätToolStripMenuItem
        '
        Me.FunkgerätToolStripMenuItem.Image = ELDIS.Client.My.Resources.Resources.motorola_mtp850_3l_tetra_pt911b
        Me.FunkgerätToolStripMenuItem.Name = "FunkgerätToolStripMenuItem"
        Me.FunkgerätToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.FunkgerätToolStripMenuItem.Text = "Funkgerät"
        '
        'DisponentToolStripMenuItem
        '
        Me.DisponentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinsatzerfassungToolStripMenuItem})
        Me.DisponentToolStripMenuItem.Name = "DisponentToolStripMenuItem"
        Me.DisponentToolStripMenuItem.Size = New System.Drawing.Size(73, 22)
        Me.DisponentToolStripMenuItem.Text = "Disponent"
        '
        'EinsatzerfassungToolStripMenuItem
        '
        Me.EinsatzerfassungToolStripMenuItem.Name = "EinsatzerfassungToolStripMenuItem"
        Me.EinsatzerfassungToolStripMenuItem.Size = New System.Drawing.Size(161, 22)
        Me.EinsatzerfassungToolStripMenuItem.Text = "Einsatzerfassung"
        '
        'AdminToolStripMenuItem
        '
        Me.AdminToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuenSISBenutzerToolStripMenuItem})
        Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
        Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 22)
        Me.AdminToolStripMenuItem.Text = "Admin"
        '
        'NeuenSISBenutzerToolStripMenuItem
        '
        Me.NeuenSISBenutzerToolStripMenuItem.Name = "NeuenSISBenutzerToolStripMenuItem"
        Me.NeuenSISBenutzerToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NeuenSISBenutzerToolStripMenuItem.Text = "Neuen SIS Benutzer"
        '
        'BenutzerToolStripMenuItem
        '
        Me.BenutzerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EinsatzberichtSchreibenToolStripMenuItem, Me.MeinProfilToolStripMenuItem})
        Me.BenutzerToolStripMenuItem.Name = "BenutzerToolStripMenuItem"
        Me.BenutzerToolStripMenuItem.Size = New System.Drawing.Size(65, 22)
        Me.BenutzerToolStripMenuItem.Text = "Benutzer"
        '
        'EinsatzberichtSchreibenToolStripMenuItem
        '
        Me.EinsatzberichtSchreibenToolStripMenuItem.Name = "EinsatzberichtSchreibenToolStripMenuItem"
        Me.EinsatzberichtSchreibenToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.EinsatzberichtSchreibenToolStripMenuItem.Text = "Einsatzbericht schreiben"
        '
        'MeinProfilToolStripMenuItem
        '
        Me.MeinProfilToolStripMenuItem.Name = "MeinProfilToolStripMenuItem"
        Me.MeinProfilToolStripMenuItem.Size = New System.Drawing.Size(201, 22)
        Me.MeinProfilToolStripMenuItem.Text = "Mein Profil"
        '
        'eldis_tabcontrol
        '
        Me.eldis_tabcontrol.Controls.Add(Me.tab_startseite)
        Me.eldis_tabcontrol.Controls.Add(Me.eldis_einsatzerfassung)
        Me.eldis_tabcontrol.Controls.Add(Me.eldis_einsatzübersicht)
        Me.eldis_tabcontrol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.eldis_tabcontrol.Location = New System.Drawing.Point(0, 24)
        Me.eldis_tabcontrol.Multiline = True
        Me.eldis_tabcontrol.Name = "eldis_tabcontrol"
        Me.eldis_tabcontrol.SelectedIndex = 0
        Me.eldis_tabcontrol.Size = New System.Drawing.Size(1759, 834)
        Me.eldis_tabcontrol.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.eldis_tabcontrol.TabIndex = 1
        '
        'tab_startseite
        '
        Me.tab_startseite.Controls.Add(Me.initELDIS_Label)
        Me.tab_startseite.Controls.Add(Me.initELDIS)
        Me.tab_startseite.Location = New System.Drawing.Point(4, 22)
        Me.tab_startseite.Name = "tab_startseite"
        Me.tab_startseite.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tab_startseite.Size = New System.Drawing.Size(1751, 808)
        Me.tab_startseite.TabIndex = 0
        Me.tab_startseite.Text = "Startseite"
        Me.tab_startseite.UseVisualStyleBackColor = True
        '
        'initELDIS_Label
        '
        Me.initELDIS_Label.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.initELDIS_Label.AutoSize = True
        Me.initELDIS_Label.Font = New System.Drawing.Font("Arial", 40.75!, System.Drawing.FontStyle.Bold)
        Me.initELDIS_Label.ForeColor = System.Drawing.Color.Red
        Me.initELDIS_Label.Location = New System.Drawing.Point(426, 342)
        Me.initELDIS_Label.Name = "initELDIS_Label"
        Me.initELDIS_Label.Size = New System.Drawing.Size(884, 64)
        Me.initELDIS_Label.TabIndex = 1
        Me.initELDIS_Label.Text = "Einsatzleitsystem wird gestartet!"
        '
        'initELDIS
        '
        Me.initELDIS.BackColor = System.Drawing.Color.Red
        Me.initELDIS.Location = New System.Drawing.Point(385, 251)
        Me.initELDIS.Name = "initELDIS"
        Me.initELDIS.Size = New System.Drawing.Size(964, 262)
        Me.initELDIS.TabIndex = 0
        Me.initELDIS.TabStop = False
        '
        'eldis_einsatzerfassung
        '
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_maßnahmen)
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_sonstiges)
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_einsatzort)
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_meldeundalarm)
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_einsatz)
        Me.eldis_einsatzerfassung.Controls.Add(Me.einsatzerfassung_controlbox)
        Me.eldis_einsatzerfassung.Location = New System.Drawing.Point(4, 22)
        Me.eldis_einsatzerfassung.Name = "eldis_einsatzerfassung"
        Me.eldis_einsatzerfassung.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.eldis_einsatzerfassung.Size = New System.Drawing.Size(1751, 811)
        Me.eldis_einsatzerfassung.TabIndex = 1
        Me.eldis_einsatzerfassung.Text = "Einsatzerfassung"
        Me.eldis_einsatzerfassung.UseVisualStyleBackColor = True
        '
        'einsatzerfassung_maßnahmen
        '
        Me.einsatzerfassung_maßnahmen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_record)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahmen_view)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.Button5)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.Button4)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.Button3)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_mehr)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_ausführen)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_probesirene)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_feuersirene)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_proberuf)
        Me.einsatzerfassung_maßnahmen.Controls.Add(Me.maßnahme_pager)
        Me.einsatzerfassung_maßnahmen.Location = New System.Drawing.Point(902, 360)
        Me.einsatzerfassung_maßnahmen.Name = "einsatzerfassung_maßnahmen"
        Me.einsatzerfassung_maßnahmen.Size = New System.Drawing.Size(841, 405)
        Me.einsatzerfassung_maßnahmen.TabIndex = 5
        Me.einsatzerfassung_maßnahmen.TabStop = False
        Me.einsatzerfassung_maßnahmen.Text = "Maßnahmen"
        '
        'maßnahme_record
        '
        Me.maßnahme_record.Enabled = False
        Me.maßnahme_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maßnahme_record.Image = ELDIS.Client.My.Resources.Resources.Music1
        Me.maßnahme_record.Location = New System.Drawing.Point(257, 93)
        Me.maßnahme_record.Name = "maßnahme_record"
        Me.maßnahme_record.Size = New System.Drawing.Size(37, 35)
        Me.maßnahme_record.TabIndex = 10
        Me.maßnahme_record.UseVisualStyleBackColor = True
        '
        'maßnahmen_view
        '
        Me.maßnahmen_view.AllowUserToAddRows = False
        Me.maßnahmen_view.AllowUserToDeleteRows = False
        Me.maßnahmen_view.AllowUserToOrderColumns = True
        Me.maßnahmen_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.maßnahmen_view.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.maßnahmen_view.BackgroundColor = System.Drawing.Color.White
        Me.maßnahmen_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.maßnahmen_view.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Maßnahme, Me.Ausgeführt})
        Me.maßnahmen_view.Location = New System.Drawing.Point(6, 134)
        Me.maßnahmen_view.Name = "maßnahmen_view"
        Me.maßnahmen_view.ReadOnly = True
        Me.maßnahmen_view.RowHeadersWidth = 62
        Me.maßnahmen_view.Size = New System.Drawing.Size(829, 270)
        Me.maßnahmen_view.TabIndex = 9
        '
        'Maßnahme
        '
        Me.Maßnahme.HeaderText = "Maßnahme"
        Me.Maßnahme.MinimumWidth = 8
        Me.Maßnahme.Name = "Maßnahme"
        Me.Maßnahme.ReadOnly = True
        '
        'Ausgeführt
        '
        Me.Ausgeführt.HeaderText = "Ausgeführt"
        Me.Ausgeführt.MinimumWidth = 8
        Me.Ausgeführt.Name = "Ausgeführt"
        Me.Ausgeführt.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Image = ELDIS.Client.My.Resources.Resources.cog
        Me.Button5.Location = New System.Drawing.Point(214, 93)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(37, 35)
        Me.Button5.TabIndex = 8
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Enabled = False
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Image = ELDIS.Client.My.Resources.Resources.folder_page
        Me.Button4.Location = New System.Drawing.Point(171, 93)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(37, 35)
        Me.Button4.TabIndex = 7
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Enabled = False
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Image = ELDIS.Client.My.Resources.Resources.Delete
        Me.Button3.Location = New System.Drawing.Point(92, 93)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 35)
        Me.Button3.TabIndex = 6
        Me.Button3.UseVisualStyleBackColor = True
        '
        'maßnahme_mehr
        '
        Me.maßnahme_mehr.Enabled = False
        Me.maßnahme_mehr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maßnahme_mehr.Image = ELDIS.Client.My.Resources.Resources.Create
        Me.maßnahme_mehr.Location = New System.Drawing.Point(49, 93)
        Me.maßnahme_mehr.Name = "maßnahme_mehr"
        Me.maßnahme_mehr.Size = New System.Drawing.Size(37, 35)
        Me.maßnahme_mehr.TabIndex = 5
        Me.maßnahme_mehr.UseVisualStyleBackColor = True
        '
        'maßnahme_ausführen
        '
        Me.maßnahme_ausführen.Enabled = False
        Me.maßnahme_ausführen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.maßnahme_ausführen.Image = ELDIS.Client.My.Resources.Resources.Application
        Me.maßnahme_ausführen.Location = New System.Drawing.Point(6, 93)
        Me.maßnahme_ausführen.Name = "maßnahme_ausführen"
        Me.maßnahme_ausführen.Size = New System.Drawing.Size(37, 35)
        Me.maßnahme_ausführen.TabIndex = 4
        Me.maßnahme_ausführen.UseVisualStyleBackColor = True
        '
        'maßnahme_probesirene
        '
        Me.maßnahme_probesirene.AutoSize = True
        Me.maßnahme_probesirene.Enabled = False
        Me.maßnahme_probesirene.Location = New System.Drawing.Point(6, 70)
        Me.maßnahme_probesirene.Name = "maßnahme_probesirene"
        Me.maßnahme_probesirene.Size = New System.Drawing.Size(92, 17)
        Me.maßnahme_probesirene.TabIndex = 3
        Me.maßnahme_probesirene.TabStop = True
        Me.maßnahme_probesirene.Text = "Probe (Sirene)"
        Me.maßnahme_probesirene.UseVisualStyleBackColor = True
        '
        'maßnahme_feuersirene
        '
        Me.maßnahme_feuersirene.AutoSize = True
        Me.maßnahme_feuersirene.Enabled = False
        Me.maßnahme_feuersirene.Location = New System.Drawing.Point(6, 53)
        Me.maßnahme_feuersirene.Name = "maßnahme_feuersirene"
        Me.maßnahme_feuersirene.Size = New System.Drawing.Size(91, 17)
        Me.maßnahme_feuersirene.TabIndex = 2
        Me.maßnahme_feuersirene.TabStop = True
        Me.maßnahme_feuersirene.Text = "Feuer (Sirene)"
        Me.maßnahme_feuersirene.UseVisualStyleBackColor = True
        '
        'maßnahme_proberuf
        '
        Me.maßnahme_proberuf.AutoSize = True
        Me.maßnahme_proberuf.Enabled = False
        Me.maßnahme_proberuf.Location = New System.Drawing.Point(6, 36)
        Me.maßnahme_proberuf.Name = "maßnahme_proberuf"
        Me.maßnahme_proberuf.Size = New System.Drawing.Size(65, 17)
        Me.maßnahme_proberuf.TabIndex = 1
        Me.maßnahme_proberuf.TabStop = True
        Me.maßnahme_proberuf.Text = "Proberuf"
        Me.maßnahme_proberuf.UseVisualStyleBackColor = True
        '
        'maßnahme_pager
        '
        Me.maßnahme_pager.AutoSize = True
        Me.maßnahme_pager.Enabled = False
        Me.maßnahme_pager.Location = New System.Drawing.Point(6, 19)
        Me.maßnahme_pager.Name = "maßnahme_pager"
        Me.maßnahme_pager.Size = New System.Drawing.Size(167, 17)
        Me.maßnahme_pager.TabIndex = 0
        Me.maßnahme_pager.TabStop = True
        Me.maßnahme_pager.Text = "Stiller Alarm (Pageralamierung)"
        Me.maßnahme_pager.UseVisualStyleBackColor = True
        '
        'einsatzerfassung_sonstiges
        '
        Me.einsatzerfassung_sonstiges.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_sonstiges.Controls.Add(Me.sonstiges_extern)
        Me.einsatzerfassung_sonstiges.Controls.Add(Me.Label8)
        Me.einsatzerfassung_sonstiges.Controls.Add(Me.Label7)
        Me.einsatzerfassung_sonstiges.Controls.Add(Me.sonstiges_intern)
        Me.einsatzerfassung_sonstiges.Location = New System.Drawing.Point(8, 360)
        Me.einsatzerfassung_sonstiges.Name = "einsatzerfassung_sonstiges"
        Me.einsatzerfassung_sonstiges.Size = New System.Drawing.Size(885, 294)
        Me.einsatzerfassung_sonstiges.TabIndex = 4
        Me.einsatzerfassung_sonstiges.TabStop = False
        Me.einsatzerfassung_sonstiges.Text = "Sonstiges"
        '
        'sonstiges_extern
        '
        Me.sonstiges_extern.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sonstiges_extern.Enabled = False
        Me.sonstiges_extern.Location = New System.Drawing.Point(501, 36)
        Me.sonstiges_extern.Multiline = True
        Me.sonstiges_extern.Name = "sonstiges_extern"
        Me.sonstiges_extern.Size = New System.Drawing.Size(360, 252)
        Me.sonstiges_extern.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label8.Location = New System.Drawing.Point(6, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(150, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Interne-Dispo-Notizen:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label7.Location = New System.Drawing.Point(498, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Externe-Dispo-Notizen:"
        '
        'sonstiges_intern
        '
        Me.sonstiges_intern.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.sonstiges_intern.Enabled = False
        Me.sonstiges_intern.Location = New System.Drawing.Point(9, 36)
        Me.sonstiges_intern.Multiline = True
        Me.sonstiges_intern.Name = "sonstiges_intern"
        Me.sonstiges_intern.Size = New System.Drawing.Size(483, 252)
        Me.sonstiges_intern.TabIndex = 15
        '
        'einsatzerfassung_einsatzort
        '
        Me.einsatzerfassung_einsatzort.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_objekt)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label6)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_stadt)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label5)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_postleitzahl)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label4)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_abschnitt)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label3)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_nr)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label2)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.einsatzort_straße)
        Me.einsatzerfassung_einsatzort.Controls.Add(Me.Label1)
        Me.einsatzerfassung_einsatzort.Location = New System.Drawing.Point(8, 188)
        Me.einsatzerfassung_einsatzort.Name = "einsatzerfassung_einsatzort"
        Me.einsatzerfassung_einsatzort.Size = New System.Drawing.Size(1735, 166)
        Me.einsatzerfassung_einsatzort.TabIndex = 3
        Me.einsatzerfassung_einsatzort.TabStop = False
        Me.einsatzerfassung_einsatzort.Text = "Einsatzort"
        '
        'einsatzort_objekt
        '
        Me.einsatzort_objekt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_objekt.Enabled = False
        Me.einsatzort_objekt.Location = New System.Drawing.Point(645, 88)
        Me.einsatzort_objekt.Name = "einsatzort_objekt"
        Me.einsatzort_objekt.Size = New System.Drawing.Size(1084, 20)
        Me.einsatzort_objekt.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label6.Location = New System.Drawing.Point(637, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Objekt:"
        '
        'einsatzort_stadt
        '
        Me.einsatzort_stadt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_stadt.Enabled = False
        Me.einsatzort_stadt.Location = New System.Drawing.Point(499, 88)
        Me.einsatzort_stadt.Name = "einsatzort_stadt"
        Me.einsatzort_stadt.Size = New System.Drawing.Size(138, 20)
        Me.einsatzort_stadt.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label5.Location = New System.Drawing.Point(494, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Stadt:"
        '
        'einsatzort_postleitzahl
        '
        Me.einsatzort_postleitzahl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_postleitzahl.Enabled = False
        Me.einsatzort_postleitzahl.Location = New System.Drawing.Point(9, 88)
        Me.einsatzort_postleitzahl.Name = "einsatzort_postleitzahl"
        Me.einsatzort_postleitzahl.Size = New System.Drawing.Size(483, 20)
        Me.einsatzort_postleitzahl.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(6, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Postleitzahl:"
        '
        'einsatzort_abschnitt
        '
        Me.einsatzort_abschnitt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_abschnitt.Enabled = False
        Me.einsatzort_abschnitt.Location = New System.Drawing.Point(645, 45)
        Me.einsatzort_abschnitt.Name = "einsatzort_abschnitt"
        Me.einsatzort_abschnitt.Size = New System.Drawing.Size(1084, 20)
        Me.einsatzort_abschnitt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(637, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Abschnitt:"
        '
        'einsatzort_nr
        '
        Me.einsatzort_nr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_nr.Enabled = False
        Me.einsatzort_nr.Location = New System.Drawing.Point(499, 45)
        Me.einsatzort_nr.Name = "einsatzort_nr"
        Me.einsatzort_nr.Size = New System.Drawing.Size(138, 20)
        Me.einsatzort_nr.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(494, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nr:"
        '
        'einsatzort_straße
        '
        Me.einsatzort_straße.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.einsatzort_straße.Enabled = False
        Me.einsatzort_straße.Location = New System.Drawing.Point(9, 45)
        Me.einsatzort_straße.Name = "einsatzort_straße"
        Me.einsatzort_straße.Size = New System.Drawing.Size(483, 20)
        Me.einsatzort_straße.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Straße:"
        '
        'einsatzerfassung_meldeundalarm
        '
        Me.einsatzerfassung_meldeundalarm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_meldeundalarm.Controls.Add(Me.alarmundmelde_meldebild)
        Me.einsatzerfassung_meldeundalarm.Controls.Add(Me.alarmundmelde_meldebildbox)
        Me.einsatzerfassung_meldeundalarm.Controls.Add(Me.alarmundmelde_alarmstufe)
        Me.einsatzerfassung_meldeundalarm.Controls.Add(Me.alarmundmelde_alarmstufebox)
        Me.einsatzerfassung_meldeundalarm.Location = New System.Drawing.Point(8, 75)
        Me.einsatzerfassung_meldeundalarm.Name = "einsatzerfassung_meldeundalarm"
        Me.einsatzerfassung_meldeundalarm.Size = New System.Drawing.Size(1735, 107)
        Me.einsatzerfassung_meldeundalarm.TabIndex = 2
        Me.einsatzerfassung_meldeundalarm.TabStop = False
        Me.einsatzerfassung_meldeundalarm.Text = "Alarmstufe und Meldebild"
        '
        'alarmundmelde_meldebild
        '
        Me.alarmundmelde_meldebild.AutoSize = True
        Me.alarmundmelde_meldebild.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.alarmundmelde_meldebild.Location = New System.Drawing.Point(891, 28)
        Me.alarmundmelde_meldebild.Name = "alarmundmelde_meldebild"
        Me.alarmundmelde_meldebild.Size = New System.Drawing.Size(72, 17)
        Me.alarmundmelde_meldebild.TabIndex = 3
        Me.alarmundmelde_meldebild.Text = "Meldebild:"
        '
        'alarmundmelde_meldebildbox
        '
        Me.alarmundmelde_meldebildbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.alarmundmelde_meldebildbox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.alarmundmelde_meldebildbox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.alarmundmelde_meldebildbox.Enabled = False
        Me.alarmundmelde_meldebildbox.FormattingEnabled = True
        Me.alarmundmelde_meldebildbox.Location = New System.Drawing.Point(891, 48)
        Me.alarmundmelde_meldebildbox.Name = "alarmundmelde_meldebildbox"
        Me.alarmundmelde_meldebildbox.Size = New System.Drawing.Size(832, 21)
        Me.alarmundmelde_meldebildbox.TabIndex = 2
        '
        'alarmundmelde_alarmstufe
        '
        Me.alarmundmelde_alarmstufe.AutoSize = True
        Me.alarmundmelde_alarmstufe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.alarmundmelde_alarmstufe.Location = New System.Drawing.Point(6, 28)
        Me.alarmundmelde_alarmstufe.Name = "alarmundmelde_alarmstufe"
        Me.alarmundmelde_alarmstufe.Size = New System.Drawing.Size(79, 17)
        Me.alarmundmelde_alarmstufe.TabIndex = 1
        Me.alarmundmelde_alarmstufe.Text = "Alarmstufe:"
        '
        'alarmundmelde_alarmstufebox
        '
        Me.alarmundmelde_alarmstufebox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.alarmundmelde_alarmstufebox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.alarmundmelde_alarmstufebox.Enabled = False
        Me.alarmundmelde_alarmstufebox.FormattingEnabled = True
        Me.alarmundmelde_alarmstufebox.Location = New System.Drawing.Point(9, 48)
        Me.alarmundmelde_alarmstufebox.Name = "alarmundmelde_alarmstufebox"
        Me.alarmundmelde_alarmstufebox.Size = New System.Drawing.Size(876, 21)
        Me.alarmundmelde_alarmstufebox.TabIndex = 0
        '
        'einsatzerfassung_einsatz
        '
        Me.einsatzerfassung_einsatz.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_einsatz.Controls.Add(Me.einsatznummer_box)
        Me.einsatzerfassung_einsatz.Controls.Add(Me.einsatz_einsatznummer)
        Me.einsatzerfassung_einsatz.Controls.Add(Me.status_box)
        Me.einsatzerfassung_einsatz.Controls.Add(Me.einsatz_status)
        Me.einsatzerfassung_einsatz.Location = New System.Drawing.Point(8, 6)
        Me.einsatzerfassung_einsatz.Name = "einsatzerfassung_einsatz"
        Me.einsatzerfassung_einsatz.Size = New System.Drawing.Size(1735, 63)
        Me.einsatzerfassung_einsatz.TabIndex = 1
        Me.einsatzerfassung_einsatz.TabStop = False
        Me.einsatzerfassung_einsatz.Text = "Einsatz"
        '
        'einsatznummer_box
        '
        Me.einsatznummer_box.Enabled = False
        Me.einsatznummer_box.Location = New System.Drawing.Point(313, 22)
        Me.einsatznummer_box.Name = "einsatznummer_box"
        Me.einsatznummer_box.Size = New System.Drawing.Size(169, 20)
        Me.einsatznummer_box.TabIndex = 3
        '
        'einsatz_einsatznummer
        '
        Me.einsatz_einsatznummer.AutoSize = True
        Me.einsatz_einsatznummer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.einsatz_einsatznummer.Location = New System.Drawing.Point(203, 23)
        Me.einsatz_einsatznummer.Name = "einsatz_einsatznummer"
        Me.einsatz_einsatznummer.Size = New System.Drawing.Size(109, 17)
        Me.einsatz_einsatznummer.TabIndex = 2
        Me.einsatz_einsatznummer.Text = "Einsatznummer:"
        '
        'status_box
        '
        Me.status_box.Enabled = False
        Me.status_box.Location = New System.Drawing.Point(59, 22)
        Me.status_box.Name = "status_box"
        Me.status_box.Size = New System.Drawing.Size(138, 20)
        Me.status_box.TabIndex = 1
        '
        'einsatz_status
        '
        Me.einsatz_status.AutoSize = True
        Me.einsatz_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.einsatz_status.Location = New System.Drawing.Point(6, 21)
        Me.einsatz_status.Name = "einsatz_status"
        Me.einsatz_status.Size = New System.Drawing.Size(52, 17)
        Me.einsatz_status.TabIndex = 0
        Me.einsatz_status.Text = "Status:"
        '
        'einsatzerfassung_controlbox
        '
        Me.einsatzerfassung_controlbox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.einsatzerfassung_controlbox.Controls.Add(Me.Button6)
        Me.einsatzerfassung_controlbox.Controls.Add(Me.controlbox_openeinsatz)
        Me.einsatzerfassung_controlbox.Controls.Add(Me.controlbox_ende)
        Me.einsatzerfassung_controlbox.Controls.Add(Me.controlbox_speichern)
        Me.einsatzerfassung_controlbox.Controls.Add(Me.controlbox_neweinsatz)
        Me.einsatzerfassung_controlbox.Location = New System.Drawing.Point(8, 655)
        Me.einsatzerfassung_controlbox.Name = "einsatzerfassung_controlbox"
        Me.einsatzerfassung_controlbox.Size = New System.Drawing.Size(885, 110)
        Me.einsatzerfassung_controlbox.TabIndex = 0
        Me.einsatzerfassung_controlbox.TabStop = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Orange
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(365, 41)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(114, 39)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Weglegen"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'controlbox_openeinsatz
        '
        Me.controlbox_openeinsatz.BackColor = System.Drawing.Color.DarkGreen
        Me.controlbox_openeinsatz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.controlbox_openeinsatz.ForeColor = System.Drawing.Color.Black
        Me.controlbox_openeinsatz.Location = New System.Drawing.Point(485, 41)
        Me.controlbox_openeinsatz.Name = "controlbox_openeinsatz"
        Me.controlbox_openeinsatz.Size = New System.Drawing.Size(114, 39)
        Me.controlbox_openeinsatz.TabIndex = 3
        Me.controlbox_openeinsatz.Text = "Öffnen"
        Me.controlbox_openeinsatz.UseVisualStyleBackColor = False
        '
        'controlbox_ende
        '
        Me.controlbox_ende.BackColor = System.Drawing.Color.DarkSlateBlue
        Me.controlbox_ende.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.controlbox_ende.ForeColor = System.Drawing.Color.Black
        Me.controlbox_ende.Location = New System.Drawing.Point(246, 41)
        Me.controlbox_ende.Name = "controlbox_ende"
        Me.controlbox_ende.Size = New System.Drawing.Size(114, 39)
        Me.controlbox_ende.TabIndex = 2
        Me.controlbox_ende.Text = "Einsatz Ende"
        Me.controlbox_ende.UseVisualStyleBackColor = False
        '
        'controlbox_speichern
        '
        Me.controlbox_speichern.BackColor = System.Drawing.Color.Crimson
        Me.controlbox_speichern.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.controlbox_speichern.ForeColor = System.Drawing.Color.Black
        Me.controlbox_speichern.Location = New System.Drawing.Point(126, 41)
        Me.controlbox_speichern.Name = "controlbox_speichern"
        Me.controlbox_speichern.Size = New System.Drawing.Size(114, 39)
        Me.controlbox_speichern.TabIndex = 1
        Me.controlbox_speichern.Text = "Speichern"
        Me.controlbox_speichern.UseVisualStyleBackColor = False
        '
        'controlbox_neweinsatz
        '
        Me.controlbox_neweinsatz.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.controlbox_neweinsatz.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.controlbox_neweinsatz.ForeColor = System.Drawing.Color.Black
        Me.controlbox_neweinsatz.Location = New System.Drawing.Point(6, 41)
        Me.controlbox_neweinsatz.Name = "controlbox_neweinsatz"
        Me.controlbox_neweinsatz.Size = New System.Drawing.Size(114, 39)
        Me.controlbox_neweinsatz.TabIndex = 0
        Me.controlbox_neweinsatz.Text = "Einsatz erzeugen"
        Me.controlbox_neweinsatz.UseVisualStyleBackColor = False
        '
        'eldis_einsatzübersicht
        '
        Me.eldis_einsatzübersicht.Controls.Add(Me.einsatzübersicht_box)
        Me.eldis_einsatzübersicht.Controls.Add(Me.einsatzliste)
        Me.eldis_einsatzübersicht.Location = New System.Drawing.Point(4, 22)
        Me.eldis_einsatzübersicht.Name = "eldis_einsatzübersicht"
        Me.eldis_einsatzübersicht.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.eldis_einsatzübersicht.Size = New System.Drawing.Size(1751, 811)
        Me.eldis_einsatzübersicht.TabIndex = 2
        Me.eldis_einsatzübersicht.Text = "Einsatzübersicht"
        Me.eldis_einsatzübersicht.UseVisualStyleBackColor = True
        '
        'einsatzübersicht_box
        '
        Me.einsatzübersicht_box.Controls.Add(Me.Button2)
        Me.einsatzübersicht_box.Controls.Add(Me.Button1)
        Me.einsatzübersicht_box.Location = New System.Drawing.Point(8, 3)
        Me.einsatzübersicht_box.Name = "einsatzübersicht_box"
        Me.einsatzübersicht_box.Size = New System.Drawing.Size(1740, 135)
        Me.einsatzübersicht_box.TabIndex = 1
        Me.einsatzübersicht_box.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = ELDIS.Client.My.Resources.Resources.Application
        Me.Button2.Location = New System.Drawing.Point(136, 33)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 96)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Aktualisieren"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Image = ELDIS.Client.My.Resources.Resources.application_add
        Me.Button1.Location = New System.Drawing.Point(6, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(124, 110)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Neu"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'einsatzliste
        '
        Me.einsatzliste.AllowUserToAddRows = False
        Me.einsatzliste.AllowUserToDeleteRows = False
        Me.einsatzliste.AllowUserToOrderColumns = True
        Me.einsatzliste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.einsatzliste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.einsatzliste.BackgroundColor = System.Drawing.Color.White
        Me.einsatzliste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.einsatzliste.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.einsatzliste.Location = New System.Drawing.Point(3, 147)
        Me.einsatzliste.Name = "einsatzliste"
        Me.einsatzliste.ReadOnly = True
        Me.einsatzliste.RowHeadersWidth = 62
        Me.einsatzliste.Size = New System.Drawing.Size(1745, 661)
        Me.einsatzliste.TabIndex = 0
        '
        'initELDIS_timer
        '
        Me.initELDIS_timer.Enabled = True
        Me.initELDIS_timer.Interval = 4000
        '
        'hauptmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1759, 858)
        Me.Controls.Add(Me.eldis_tabcontrol)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "hauptmenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ELDIS"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.eldis_tabcontrol.ResumeLayout(False)
        Me.tab_startseite.ResumeLayout(False)
        Me.tab_startseite.PerformLayout()
        CType(Me.initELDIS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.eldis_einsatzerfassung.ResumeLayout(False)
        Me.einsatzerfassung_maßnahmen.ResumeLayout(False)
        Me.einsatzerfassung_maßnahmen.PerformLayout()
        CType(Me.maßnahmen_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.einsatzerfassung_sonstiges.ResumeLayout(False)
        Me.einsatzerfassung_sonstiges.PerformLayout()
        Me.einsatzerfassung_einsatzort.ResumeLayout(False)
        Me.einsatzerfassung_einsatzort.PerformLayout()
        Me.einsatzerfassung_meldeundalarm.ResumeLayout(False)
        Me.einsatzerfassung_meldeundalarm.PerformLayout()
        Me.einsatzerfassung_einsatz.ResumeLayout(False)
        Me.einsatzerfassung_einsatz.PerformLayout()
        Me.einsatzerfassung_controlbox.ResumeLayout(False)
        Me.eldis_einsatzübersicht.ResumeLayout(False)
        Me.einsatzübersicht_box.ResumeLayout(False)
        CType(Me.einsatzliste, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ELDISToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisponentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BenutzerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents eldis_tabcontrol As TabControl
    Friend WithEvents tab_startseite As TabPage
    Friend WithEvents eldis_einsatzerfassung As TabPage
    Friend WithEvents initELDIS_Label As Label
    Friend WithEvents initELDIS As PictureBox
    Friend WithEvents initELDIS_timer As Timer
    Friend WithEvents EinsatzerfassungToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents einsatzerfassung_controlbox As GroupBox
    Friend WithEvents controlbox_speichern As Button
    Friend WithEvents controlbox_neweinsatz As Button
    Friend WithEvents einsatzerfassung_einsatz As GroupBox
    Friend WithEvents controlbox_ende As Button
    Friend WithEvents einsatznummer_box As TextBox
    Friend WithEvents einsatz_einsatznummer As Label
    Friend WithEvents status_box As TextBox
    Friend WithEvents einsatz_status As Label
    Friend WithEvents einsatzerfassung_meldeundalarm As GroupBox
    Friend WithEvents alarmundmelde_meldebild As Label
    Friend WithEvents alarmundmelde_meldebildbox As ComboBox
    Friend WithEvents alarmundmelde_alarmstufe As Label
    Friend WithEvents alarmundmelde_alarmstufebox As ComboBox
    Friend WithEvents einsatzerfassung_einsatzort As GroupBox
    Friend WithEvents einsatzort_objekt As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents einsatzort_stadt As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents einsatzort_postleitzahl As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents einsatzort_abschnitt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents einsatzort_nr As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents einsatzort_straße As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents einsatzerfassung_sonstiges As GroupBox
    Friend WithEvents sonstiges_extern As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents sonstiges_intern As TextBox
    Friend WithEvents einsatzerfassung_maßnahmen As GroupBox
    Friend WithEvents maßnahme_ausführen As Button
    Friend WithEvents maßnahme_probesirene As RadioButton
    Friend WithEvents maßnahme_feuersirene As RadioButton
    Friend WithEvents maßnahme_proberuf As RadioButton
    Friend WithEvents maßnahme_pager As RadioButton
    Friend WithEvents maßnahme_mehr As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents maßnahmen_view As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents PagerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Maßnahme As DataGridViewTextBoxColumn
    Friend WithEvents Ausgeführt As DataGridViewCheckBoxColumn
    Friend WithEvents EinsatzberichtSchreibenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MeinProfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents maßnahme_record As Button
    Friend WithEvents controlbox_openeinsatz As Button
    Friend WithEvents eldis_einsatzübersicht As TabPage
    Friend WithEvents einsatzübersicht_box As GroupBox
    Friend WithEvents einsatzliste As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents FunkgerätToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents NeuenSISBenutzerToolStripMenuItem As ToolStripMenuItem
End Class
