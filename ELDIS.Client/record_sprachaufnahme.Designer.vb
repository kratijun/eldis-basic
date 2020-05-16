<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class record_sprachaufnahme
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
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.play = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.record = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mic_name = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ELDIS.Client.My.Resources.Resources.Update
        Me.Button1.Location = New System.Drawing.Point(711, 198)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(37, 35)
        Me.Button1.TabIndex = 15
        Me.Button1.UseVisualStyleBackColor = True
        '
        'play
        '
        Me.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.play.Image = Global.ELDIS.Client.My.Resources.Resources.Dial
        Me.play.Location = New System.Drawing.Point(12, 198)
        Me.play.Name = "play"
        Me.play.Size = New System.Drawing.Size(37, 35)
        Me.play.TabIndex = 13
        Me.play.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.delete.Image = Global.ELDIS.Client.My.Resources.Resources._Erase
        Me.delete.Location = New System.Drawing.Point(725, 95)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(66, 35)
        Me.delete.TabIndex = 12
        Me.delete.UseVisualStyleBackColor = True
        '
        'record
        '
        Me.record.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.record.Image = Global.ELDIS.Client.My.Resources.Resources.Application1
        Me.record.Location = New System.Drawing.Point(12, 25)
        Me.record.Name = "record"
        Me.record.Size = New System.Drawing.Size(66, 35)
        Me.record.TabIndex = 11
        Me.record.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = ELDIS.Client.My.Resources.Resources.Load
        Me.Button2.Location = New System.Drawing.Point(754, 198)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(37, 35)
        Me.Button2.TabIndex = 16
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Sprachdurchsage durchsagen:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 66)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(779, 23)
        Me.ProgressBar1.TabIndex = 19
        '
        'Timer1
        '
        '
        'mic_name
        '
        Me.mic_name.AutoSize = True
        Me.mic_name.Location = New System.Drawing.Point(12, 95)
        Me.mic_name.Name = "mic_name"
        Me.mic_name.Size = New System.Drawing.Size(0, 13)
        Me.mic_name.TabIndex = 20
        '
        'record_sprachaufnahme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 245)
        Me.Controls.Add(Me.mic_name)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.play)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.record)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "record_sprachaufnahme"
        Me.Text = "Sprachaufnahme aufnehmen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents play As Button
    Friend WithEvents delete As Button
    Friend WithEvents record As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents mic_name As Label
End Class
