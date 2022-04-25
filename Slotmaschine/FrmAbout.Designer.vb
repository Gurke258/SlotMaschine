<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbout
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
        Me.LblTitle = New System.Windows.Forms.Label()
        Me.LblCopyright = New System.Windows.Forms.Label()
        Me.LblDateiVersion = New System.Windows.Forms.Label()
        Me.LblBildRechte = New System.Windows.Forms.Label()
        Me.LlblPixabay = New System.Windows.Forms.LinkLabel()
        Me.ProcessPixabay = New System.Diagnostics.Process()
        Me.SuspendLayout()
        '
        'LblTitle
        '
        Me.LblTitle.AutoSize = True
        Me.LblTitle.Location = New System.Drawing.Point(21, 16)
        Me.LblTitle.Name = "LblTitle"
        Me.LblTitle.Size = New System.Drawing.Size(41, 13)
        Me.LblTitle.TabIndex = 0
        Me.LblTitle.Text = "LblTitle"
        '
        'LblCopyright
        '
        Me.LblCopyright.AutoSize = True
        Me.LblCopyright.Location = New System.Drawing.Point(21, 46)
        Me.LblCopyright.Name = "LblCopyright"
        Me.LblCopyright.Size = New System.Drawing.Size(65, 13)
        Me.LblCopyright.TabIndex = 1
        Me.LblCopyright.Text = "LblCopyright"
        '
        'LblDateiVersion
        '
        Me.LblDateiVersion.AutoSize = True
        Me.LblDateiVersion.Location = New System.Drawing.Point(21, 78)
        Me.LblDateiVersion.Name = "LblDateiVersion"
        Me.LblDateiVersion.Size = New System.Drawing.Size(81, 13)
        Me.LblDateiVersion.TabIndex = 2
        Me.LblDateiVersion.Text = "LblDateiVersion"
        '
        'LblBildRechte
        '
        Me.LblBildRechte.AutoSize = True
        Me.LblBildRechte.Location = New System.Drawing.Point(4, 105)
        Me.LblBildRechte.Name = "LblBildRechte"
        Me.LblBildRechte.Size = New System.Drawing.Size(252, 78)
        Me.LblBildRechte.TabIndex = 3
        Me.LblBildRechte.Text = "Die in diesem Programm verwendeten Bilder dienen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "zur freien kommerziellen Nutzu" &
    "ng und unterliegen " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "keinem Urheberrechtsschutz." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die Quelle der Bilder " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "bezi" &
    "eht sich auf:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LlblPixabay
        '
        Me.LlblPixabay.AutoSize = True
        Me.LlblPixabay.Location = New System.Drawing.Point(96, 170)
        Me.LlblPixabay.Name = "LlblPixabay"
        Me.LlblPixabay.Size = New System.Drawing.Size(93, 13)
        Me.LlblPixabay.TabIndex = 4
        Me.LlblPixabay.TabStop = True
        Me.LlblPixabay.Text = "www.pixabay.com"
        '
        'ProcessPixabay
        '
        Me.ProcessPixabay.StartInfo.Domain = ""
        Me.ProcessPixabay.StartInfo.LoadUserProfile = False
        Me.ProcessPixabay.StartInfo.Password = Nothing
        Me.ProcessPixabay.StartInfo.StandardErrorEncoding = Nothing
        Me.ProcessPixabay.StartInfo.StandardOutputEncoding = Nothing
        Me.ProcessPixabay.StartInfo.UserName = ""
        Me.ProcessPixabay.SynchronizingObject = Me
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 215)
        Me.Controls.Add(Me.LlblPixabay)
        Me.Controls.Add(Me.LblBildRechte)
        Me.Controls.Add(Me.LblDateiVersion)
        Me.Controls.Add(Me.LblCopyright)
        Me.Controls.Add(Me.LblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(278, 254)
        Me.MinimumSize = New System.Drawing.Size(278, 254)
        Me.Name = "About"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblTitle As Label
    Friend WithEvents LblCopyright As Label
    Friend WithEvents LblDateiVersion As Label
    Friend WithEvents LblBildRechte As Label
    Friend WithEvents LlblPixabay As LinkLabel
    Friend WithEvents ProcessPixabay As Process
End Class
