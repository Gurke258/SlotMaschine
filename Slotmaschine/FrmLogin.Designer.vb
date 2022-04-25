<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.CmdLogin = New System.Windows.Forms.Button()
        Me.LblSlotmaschine = New System.Windows.Forms.Label()
        Me.LblBenutzer = New System.Windows.Forms.Label()
        Me.LblPasswort = New System.Windows.Forms.Label()
        Me.TBBenutzer = New System.Windows.Forms.TextBox()
        Me.TBPasswort = New System.Windows.Forms.TextBox()
        Me.cmdHilfe = New System.Windows.Forms.Button()
        Me.CmdBeenden = New System.Windows.Forms.Button()
        Me.CmdRegister = New System.Windows.Forms.Button()
        Me.CmdPWSichtbarL = New System.Windows.Forms.Button()
        Me.PBLogin = New System.Windows.Forms.PictureBox()
        Me.LoginTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ProgBarLogin = New System.Windows.Forms.ProgressBar()
        Me.LblProgBarLogin = New System.Windows.Forms.Label()
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdLogin
        '
        Me.CmdLogin.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLogin.Location = New System.Drawing.Point(203, 240)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(75, 23)
        Me.CmdLogin.TabIndex = 0
        Me.CmdLogin.Text = "Login"
        Me.CmdLogin.UseVisualStyleBackColor = True
        '
        'LblSlotmaschine
        '
        Me.LblSlotmaschine.AutoSize = True
        Me.LblSlotmaschine.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.25!)
        Me.LblSlotmaschine.Location = New System.Drawing.Point(49, 29)
        Me.LblSlotmaschine.Name = "LblSlotmaschine"
        Me.LblSlotmaschine.Size = New System.Drawing.Size(354, 47)
        Me.LblSlotmaschine.TabIndex = 1
        Me.LblSlotmaschine.Text = "SLOTMASCHINE!"
        Me.LblSlotmaschine.Visible = False
        '
        'LblBenutzer
        '
        Me.LblBenutzer.AutoSize = True
        Me.LblBenutzer.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBenutzer.Location = New System.Drawing.Point(81, 123)
        Me.LblBenutzer.Name = "LblBenutzer"
        Me.LblBenutzer.Size = New System.Drawing.Size(116, 23)
        Me.LblBenutzer.TabIndex = 2
        Me.LblBenutzer.Text = "Benutzername:"
        '
        'LblPasswort
        '
        Me.LblPasswort.AutoSize = True
        Me.LblPasswort.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPasswort.Location = New System.Drawing.Point(81, 159)
        Me.LblPasswort.Name = "LblPasswort"
        Me.LblPasswort.Size = New System.Drawing.Size(79, 23)
        Me.LblPasswort.TabIndex = 3
        Me.LblPasswort.Text = "Passwort:"
        '
        'TBBenutzer
        '
        Me.TBBenutzer.Location = New System.Drawing.Point(203, 126)
        Me.TBBenutzer.Name = "TBBenutzer"
        Me.TBBenutzer.Size = New System.Drawing.Size(100, 20)
        Me.TBBenutzer.TabIndex = 4
        '
        'TBPasswort
        '
        Me.TBPasswort.Location = New System.Drawing.Point(203, 162)
        Me.TBPasswort.Name = "TBPasswort"
        Me.TBPasswort.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPasswort.Size = New System.Drawing.Size(100, 20)
        Me.TBPasswort.TabIndex = 5
        '
        'cmdHilfe
        '
        Me.cmdHilfe.Location = New System.Drawing.Point(57, 240)
        Me.cmdHilfe.Name = "cmdHilfe"
        Me.cmdHilfe.Size = New System.Drawing.Size(75, 23)
        Me.cmdHilfe.TabIndex = 6
        Me.cmdHilfe.Text = "Hilfe"
        Me.cmdHilfe.UseVisualStyleBackColor = True
        Me.cmdHilfe.Visible = False
        '
        'CmdBeenden
        '
        Me.CmdBeenden.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdBeenden.Location = New System.Drawing.Point(309, 240)
        Me.CmdBeenden.Name = "CmdBeenden"
        Me.CmdBeenden.Size = New System.Drawing.Size(75, 23)
        Me.CmdBeenden.TabIndex = 7
        Me.CmdBeenden.Text = "Beenden"
        Me.CmdBeenden.UseVisualStyleBackColor = True
        '
        'CmdRegister
        '
        Me.CmdRegister.Font = New System.Drawing.Font("Comic Sans MS", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdRegister.Location = New System.Drawing.Point(199, 271)
        Me.CmdRegister.Name = "CmdRegister"
        Me.CmdRegister.Size = New System.Drawing.Size(84, 23)
        Me.CmdRegister.TabIndex = 8
        Me.CmdRegister.Text = "Registrieren"
        Me.CmdRegister.UseVisualStyleBackColor = True
        '
        'CmdPWSichtbarL
        '
        Me.CmdPWSichtbarL.Image = Global.Slotmaschine.My.Resources.Resources.magnifying_glass_1892541
        Me.CmdPWSichtbarL.Location = New System.Drawing.Point(309, 159)
        Me.CmdPWSichtbarL.Name = "CmdPWSichtbarL"
        Me.CmdPWSichtbarL.Size = New System.Drawing.Size(30, 30)
        Me.CmdPWSichtbarL.TabIndex = 9
        Me.CmdPWSichtbarL.UseVisualStyleBackColor = True
        '
        'PBLogin
        '
        Me.PBLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PBLogin.Image = Global.Slotmaschine.My.Resources.Resources.slot_machine_159972_1280
        Me.PBLogin.Location = New System.Drawing.Point(0, 0)
        Me.PBLogin.Name = "PBLogin"
        Me.PBLogin.Size = New System.Drawing.Size(464, 349)
        Me.PBLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBLogin.TabIndex = 10
        Me.PBLogin.TabStop = False
        '
        'LoginTimer
        '
        '
        'ProgBarLogin
        '
        Me.ProgBarLogin.Location = New System.Drawing.Point(57, 314)
        Me.ProgBarLogin.Name = "ProgBarLogin"
        Me.ProgBarLogin.Size = New System.Drawing.Size(363, 23)
        Me.ProgBarLogin.TabIndex = 11
        Me.ProgBarLogin.Visible = False
        '
        'LblProgBarLogin
        '
        Me.LblProgBarLogin.AutoSize = True
        Me.LblProgBarLogin.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LblProgBarLogin.Location = New System.Drawing.Point(163, 319)
        Me.LblProgBarLogin.Name = "LblProgBarLogin"
        Me.LblProgBarLogin.Size = New System.Drawing.Size(39, 13)
        Me.LblProgBarLogin.TabIndex = 12
        Me.LblProgBarLogin.Text = "Label1"
        Me.LblProgBarLogin.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 349)
        Me.Controls.Add(Me.LblProgBarLogin)
        Me.Controls.Add(Me.ProgBarLogin)
        Me.Controls.Add(Me.CmdPWSichtbarL)
        Me.Controls.Add(Me.CmdRegister)
        Me.Controls.Add(Me.CmdBeenden)
        Me.Controls.Add(Me.cmdHilfe)
        Me.Controls.Add(Me.TBPasswort)
        Me.Controls.Add(Me.TBBenutzer)
        Me.Controls.Add(Me.LblPasswort)
        Me.Controls.Add(Me.LblBenutzer)
        Me.Controls.Add(Me.LblSlotmaschine)
        Me.Controls.Add(Me.CmdLogin)
        Me.Controls.Add(Me.PBLogin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 349)
        Me.MinimumSize = New System.Drawing.Size(464, 349)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.PBLogin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmdLogin As Button
    Friend WithEvents LblSlotmaschine As Label
    Friend WithEvents LblBenutzer As Label
    Friend WithEvents LblPasswort As Label
    Friend WithEvents TBBenutzer As TextBox
    Friend WithEvents TBPasswort As TextBox
    Friend WithEvents cmdHilfe As Button
    Friend WithEvents CmdBeenden As Button
    Friend WithEvents CmdRegister As Button
    Friend WithEvents CmdPWSichtbarL As Button
    Friend WithEvents PBLogin As PictureBox
    Friend WithEvents LoginTimer As Timer
    Friend WithEvents ProgBarLogin As ProgressBar
    Friend WithEvents LblProgBarLogin As Label
End Class
