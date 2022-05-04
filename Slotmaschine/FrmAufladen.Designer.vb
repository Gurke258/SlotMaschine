<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAufladen
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
        Me.LblGuthaben = New System.Windows.Forms.Label()
        Me.Cmd_1_euro = New System.Windows.Forms.Button()
        Me.Cmd_5_euro = New System.Windows.Forms.Button()
        Me.Cmd_10_euro = New System.Windows.Forms.Button()
        Me.Cmd_25_Euro = New System.Windows.Forms.Button()
        Me.Cmd_50_euro = New System.Windows.Forms.Button()
        Me.Cmd_100_euro = New System.Windows.Forms.Button()
        Me.Cmd_Schließen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblGuthaben
        '
        Me.LblGuthaben.AutoSize = True
        Me.LblGuthaben.BackColor = System.Drawing.Color.Transparent
        Me.LblGuthaben.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.25!)
        Me.LblGuthaben.Location = New System.Drawing.Point(42, 9)
        Me.LblGuthaben.Name = "LblGuthaben"
        Me.LblGuthaben.Size = New System.Drawing.Size(346, 76)
        Me.LblGuthaben.TabIndex = 0
        Me.LblGuthaben.Text = "Wie viel Guthaben " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "möchtest du aufladen?"
        '
        'Cmd_1_euro
        '
        Me.Cmd_1_euro.Location = New System.Drawing.Point(49, 109)
        Me.Cmd_1_euro.Name = "Cmd_1_euro"
        Me.Cmd_1_euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_1_euro.TabIndex = 1
        Me.Cmd_1_euro.Text = "1 €"
        Me.Cmd_1_euro.UseVisualStyleBackColor = True
        '
        'Cmd_5_euro
        '
        Me.Cmd_5_euro.Location = New System.Drawing.Point(49, 138)
        Me.Cmd_5_euro.Name = "Cmd_5_euro"
        Me.Cmd_5_euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_5_euro.TabIndex = 2
        Me.Cmd_5_euro.Text = "5 €"
        Me.Cmd_5_euro.UseVisualStyleBackColor = True
        '
        'Cmd_10_euro
        '
        Me.Cmd_10_euro.Location = New System.Drawing.Point(49, 167)
        Me.Cmd_10_euro.Name = "Cmd_10_euro"
        Me.Cmd_10_euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_10_euro.TabIndex = 3
        Me.Cmd_10_euro.Text = "10 €"
        Me.Cmd_10_euro.UseVisualStyleBackColor = True
        '
        'Cmd_25_Euro
        '
        Me.Cmd_25_Euro.Location = New System.Drawing.Point(301, 109)
        Me.Cmd_25_Euro.Name = "Cmd_25_Euro"
        Me.Cmd_25_Euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_25_Euro.TabIndex = 4
        Me.Cmd_25_Euro.Text = "25 €"
        Me.Cmd_25_Euro.UseVisualStyleBackColor = True
        '
        'Cmd_50_euro
        '
        Me.Cmd_50_euro.Location = New System.Drawing.Point(301, 138)
        Me.Cmd_50_euro.Name = "Cmd_50_euro"
        Me.Cmd_50_euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_50_euro.TabIndex = 5
        Me.Cmd_50_euro.Text = "50 €"
        Me.Cmd_50_euro.UseVisualStyleBackColor = True
        '
        'Cmd_100_euro
        '
        Me.Cmd_100_euro.Location = New System.Drawing.Point(301, 167)
        Me.Cmd_100_euro.Name = "Cmd_100_euro"
        Me.Cmd_100_euro.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_100_euro.TabIndex = 6
        Me.Cmd_100_euro.Text = "100 €"
        Me.Cmd_100_euro.UseVisualStyleBackColor = True
        '
        'Cmd_Schließen
        '
        Me.Cmd_Schließen.Location = New System.Drawing.Point(168, 220)
        Me.Cmd_Schließen.Name = "Cmd_Schließen"
        Me.Cmd_Schließen.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Schließen.TabIndex = 7
        Me.Cmd_Schließen.Text = "Schließen"
        Me.Cmd_Schließen.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Slotmaschine.My.Resources.Resources.piggy_bank_2889042_1920
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(419, 255)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'FrmAufladen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 255)
        Me.Controls.Add(Me.Cmd_Schließen)
        Me.Controls.Add(Me.Cmd_100_euro)
        Me.Controls.Add(Me.Cmd_50_euro)
        Me.Controls.Add(Me.Cmd_25_Euro)
        Me.Controls.Add(Me.Cmd_10_euro)
        Me.Controls.Add(Me.Cmd_5_euro)
        Me.Controls.Add(Me.Cmd_1_euro)
        Me.Controls.Add(Me.LblGuthaben)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(435, 294)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(435, 294)
        Me.Name = "FrmAufladen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guthaben"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblGuthaben As Label
    Friend WithEvents Cmd_1_euro As Button
    Friend WithEvents Cmd_5_euro As Button
    Friend WithEvents Cmd_10_euro As Button
    Friend WithEvents Cmd_25_Euro As Button
    Friend WithEvents Cmd_50_euro As Button
    Friend WithEvents Cmd_100_euro As Button
    Friend WithEvents Cmd_Schließen As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
