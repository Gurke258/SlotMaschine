<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistrieren
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
        Me.LblBenutzer = New System.Windows.Forms.Label()
        Me.LblPasswort = New System.Windows.Forms.Label()
        Me.TBBenutzer = New System.Windows.Forms.TextBox()
        Me.TBPasswort = New System.Windows.Forms.TextBox()
        Me.TBPasswort2 = New System.Windows.Forms.TextBox()
        Me.LblPasswort2 = New System.Windows.Forms.Label()
        Me.LblRegistrierung = New System.Windows.Forms.Label()
        Me.CmdRegistrieren = New System.Windows.Forms.Button()
        Me.CmdPWSichtbarR = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LblBenutzer
        '
        Me.LblBenutzer.AutoSize = True
        Me.LblBenutzer.Location = New System.Drawing.Point(17, 63)
        Me.LblBenutzer.Name = "LblBenutzer"
        Me.LblBenutzer.Size = New System.Drawing.Size(78, 13)
        Me.LblBenutzer.TabIndex = 0
        Me.LblBenutzer.Text = "Benutzername:"
        '
        'LblPasswort
        '
        Me.LblPasswort.AutoSize = True
        Me.LblPasswort.Location = New System.Drawing.Point(17, 98)
        Me.LblPasswort.Name = "LblPasswort"
        Me.LblPasswort.Size = New System.Drawing.Size(53, 13)
        Me.LblPasswort.TabIndex = 1
        Me.LblPasswort.Text = "Passwort:"
        '
        'TBBenutzer
        '
        Me.TBBenutzer.Location = New System.Drawing.Point(134, 60)
        Me.TBBenutzer.Name = "TBBenutzer"
        Me.TBBenutzer.Size = New System.Drawing.Size(100, 20)
        Me.TBBenutzer.TabIndex = 2
        '
        'TBPasswort
        '
        Me.TBPasswort.Location = New System.Drawing.Point(134, 95)
        Me.TBPasswort.Name = "TBPasswort"
        Me.TBPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPasswort.Size = New System.Drawing.Size(100, 20)
        Me.TBPasswort.TabIndex = 3
        '
        'TBPasswort2
        '
        Me.TBPasswort2.Location = New System.Drawing.Point(134, 130)
        Me.TBPasswort2.Name = "TBPasswort2"
        Me.TBPasswort2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPasswort2.Size = New System.Drawing.Size(100, 20)
        Me.TBPasswort2.TabIndex = 5
        '
        'LblPasswort2
        '
        Me.LblPasswort2.AutoSize = True
        Me.LblPasswort2.Location = New System.Drawing.Point(17, 133)
        Me.LblPasswort2.Name = "LblPasswort2"
        Me.LblPasswort2.Size = New System.Drawing.Size(113, 13)
        Me.LblPasswort2.TabIndex = 4
        Me.LblPasswort2.Text = "Passwort wiederholen:"
        '
        'LblRegistrierung
        '
        Me.LblRegistrierung.AutoSize = True
        Me.LblRegistrierung.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.LblRegistrierung.Location = New System.Drawing.Point(29, 1)
        Me.LblRegistrierung.Name = "LblRegistrierung"
        Me.LblRegistrierung.Size = New System.Drawing.Size(268, 47)
        Me.LblRegistrierung.TabIndex = 6
        Me.LblRegistrierung.Text = "Registrierung"
        '
        'CmdRegistrieren
        '
        Me.CmdRegistrieren.Location = New System.Drawing.Point(259, 160)
        Me.CmdRegistrieren.Name = "CmdRegistrieren"
        Me.CmdRegistrieren.Size = New System.Drawing.Size(75, 23)
        Me.CmdRegistrieren.TabIndex = 7
        Me.CmdRegistrieren.Text = "Registrieren"
        Me.CmdRegistrieren.UseVisualStyleBackColor = True
        '
        'CmdPWSichtbarR
        '
        Me.CmdPWSichtbarR.Image = Global.Slotmaschine.My.Resources.Resources.magnifying_glass_1892541
        Me.CmdPWSichtbarR.Location = New System.Drawing.Point(246, 107)
        Me.CmdPWSichtbarR.Name = "CmdPWSichtbarR"
        Me.CmdPWSichtbarR.Size = New System.Drawing.Size(33, 31)
        Me.CmdPWSichtbarR.TabIndex = 8
        Me.CmdPWSichtbarR.UseVisualStyleBackColor = True
        '
        'Registrieren
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 195)
        Me.Controls.Add(Me.CmdPWSichtbarR)
        Me.Controls.Add(Me.CmdRegistrieren)
        Me.Controls.Add(Me.LblRegistrierung)
        Me.Controls.Add(Me.TBPasswort2)
        Me.Controls.Add(Me.LblPasswort2)
        Me.Controls.Add(Me.TBPasswort)
        Me.Controls.Add(Me.TBBenutzer)
        Me.Controls.Add(Me.LblPasswort)
        Me.Controls.Add(Me.LblBenutzer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(362, 234)
        Me.MinimumSize = New System.Drawing.Size(362, 234)
        Me.Name = "Registrieren"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrieren"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblBenutzer As Label
    Friend WithEvents LblPasswort As Label
    Friend WithEvents TBBenutzer As TextBox
    Friend WithEvents TBPasswort As TextBox
    Friend WithEvents TBPasswort2 As TextBox
    Friend WithEvents LblPasswort2 As Label
    Friend WithEvents LblRegistrierung As Label
    Friend WithEvents CmdRegistrieren As Button
    Friend WithEvents CmdPWSichtbarR As Button
End Class
