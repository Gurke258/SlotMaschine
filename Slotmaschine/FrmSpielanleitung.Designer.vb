<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Spielaanleitung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Spielaanleitung))
        Me.Lbl_Spielanleitung = New System.Windows.Forms.Label()
        Me.Lbl_Spielablauf_text = New System.Windows.Forms.Label()
        Me.Cmd_Verstanden = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_Spielanleitung
        '
        Me.Lbl_Spielanleitung.AutoSize = True
        Me.Lbl_Spielanleitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Spielanleitung.Location = New System.Drawing.Point(24, 38)
        Me.Lbl_Spielanleitung.Name = "Lbl_Spielanleitung"
        Me.Lbl_Spielanleitung.Size = New System.Drawing.Size(180, 29)
        Me.Lbl_Spielanleitung.TabIndex = 0
        Me.Lbl_Spielanleitung.Text = "Spielanleitung:"
        '
        'Lbl_Spielablauf_text
        '
        Me.Lbl_Spielablauf_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.Lbl_Spielablauf_text.Location = New System.Drawing.Point(25, 88)
        Me.Lbl_Spielablauf_text.MaximumSize = New System.Drawing.Size(610, 240)
        Me.Lbl_Spielablauf_text.MinimumSize = New System.Drawing.Size(610, 240)
        Me.Lbl_Spielablauf_text.Name = "Lbl_Spielablauf_text"
        Me.Lbl_Spielablauf_text.Size = New System.Drawing.Size(610, 240)
        Me.Lbl_Spielablauf_text.TabIndex = 1
        Me.Lbl_Spielablauf_text.Text = resources.GetString("Lbl_Spielablauf_text.Text")
        '
        'Cmd_Verstanden
        '
        Me.Cmd_Verstanden.Location = New System.Drawing.Point(556, 318)
        Me.Cmd_Verstanden.Name = "Cmd_Verstanden"
        Me.Cmd_Verstanden.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Verstanden.TabIndex = 2
        Me.Cmd_Verstanden.Text = "Verstanden!"
        Me.Cmd_Verstanden.UseVisualStyleBackColor = True
        '
        'Spielaanleitung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(643, 353)
        Me.Controls.Add(Me.Cmd_Verstanden)
        Me.Controls.Add(Me.Lbl_Spielablauf_text)
        Me.Controls.Add(Me.Lbl_Spielanleitung)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximumSize = New System.Drawing.Size(659, 392)
        Me.MinimumSize = New System.Drawing.Size(659, 392)
        Me.Name = "Spielaanleitung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Spielanleitung"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_Spielanleitung As Label
    Friend WithEvents Lbl_Spielablauf_text As Label
    Friend WithEvents Cmd_Verstanden As Button
End Class
