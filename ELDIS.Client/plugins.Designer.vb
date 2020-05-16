<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class plugins
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
        Me.modauthor = New System.Windows.Forms.Label()
        Me.modversion = New System.Windows.Forms.Label()
        Me.modname = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'modauthor
        '
        Me.modauthor.AutoSize = True
        Me.modauthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.modauthor.Location = New System.Drawing.Point(688, 72)
        Me.modauthor.Name = "modauthor"
        Me.modauthor.Size = New System.Drawing.Size(0, 30)
        Me.modauthor.TabIndex = 14
        '
        'modversion
        '
        Me.modversion.AutoSize = True
        Me.modversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.modversion.Location = New System.Drawing.Point(688, 42)
        Me.modversion.Name = "modversion"
        Me.modversion.Size = New System.Drawing.Size(0, 30)
        Me.modversion.TabIndex = 13
        '
        'modname
        '
        Me.modname.AutoSize = True
        Me.modname.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!)
        Me.modname.Location = New System.Drawing.Point(688, 12)
        Me.modname.Name = "modname"
        Me.modname.Size = New System.Drawing.Size(0, 30)
        Me.modname.TabIndex = 12
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 12)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(670, 418)
        Me.CheckedListBox1.TabIndex = 11
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'plugins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1310, 690)
        Me.Controls.Add(Me.modauthor)
        Me.Controls.Add(Me.modversion)
        Me.Controls.Add(Me.modname)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "plugins"
        Me.Text = "ELDIS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents modauthor As Label
    Friend WithEvents modversion As Label
    Friend WithEvents modname As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
