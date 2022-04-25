<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHaupt
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
        Me.Cmd_Bet = New System.Windows.Forms.Button()
        Me.Lbl_Kontostand = New System.Windows.Forms.Label()
        Me.MenuStrip_Haupt = New System.Windows.Forms.MenuStrip()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpieltabelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuthabenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HighscoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielinfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpielverlaufToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Lbl_Einsatz = New System.Windows.Forms.Label()
        Me.Lbl_Gewinn = New System.Windows.Forms.Label()
        Me.TB_Gewinn = New System.Windows.Forms.TextBox()
        Me.NUD_Einsatz = New System.Windows.Forms.NumericUpDown()
        Me.Lbl_Zahl1 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl2 = New System.Windows.Forms.Label()
        Me.LbL_Zahl3 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl4 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl5 = New System.Windows.Forms.Label()
        Me.Cmd_Max_Bet = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.Timer_Willkommen = New System.Windows.Forms.Timer(Me.components)
        Me.PBFeld_5 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_7 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_4 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_1 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_2 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_3 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_6 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_9 = New System.Windows.Forms.PictureBox()
        Me.PBFeld_8 = New System.Windows.Forms.PictureBox()
        Me.Lbl_Zahl5_5 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl4_4 = New System.Windows.Forms.Label()
        Me.LbL_Zahl3_3 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl2_2 = New System.Windows.Forms.Label()
        Me.Lbl_Zahl1_1 = New System.Windows.Forms.Label()
        Me.NUD_Guthaben = New Slotmaschine.FormattedNumericUpDown()
        Me.Timer_Playerlevel = New System.Windows.Forms.Timer(Me.components)
        Me.PbPlayerLevel = New System.Windows.Forms.ProgressBar()
        Me.lblPlayerlevel = New System.Windows.Forms.Label()
        Me.lblLevelscore = New System.Windows.Forms.Label()
        Me.MenuStrip_Haupt.SuspendLayout()
        CType(Me.NUD_Einsatz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBFeld_8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD_Guthaben, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cmd_Bet
        '
        Me.Cmd_Bet.Location = New System.Drawing.Point(633, 457)
        Me.Cmd_Bet.Name = "Cmd_Bet"
        Me.Cmd_Bet.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Bet.TabIndex = 0
        Me.Cmd_Bet.Text = "BET"
        Me.Cmd_Bet.UseVisualStyleBackColor = True
        '
        'Lbl_Kontostand
        '
        Me.Lbl_Kontostand.AutoSize = True
        Me.Lbl_Kontostand.Location = New System.Drawing.Point(178, 462)
        Me.Lbl_Kontostand.Name = "Lbl_Kontostand"
        Me.Lbl_Kontostand.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_Kontostand.TabIndex = 4
        Me.Lbl_Kontostand.Text = "Aktuelles Guthaben:"
        '
        'MenuStrip_Haupt
        '
        Me.MenuStrip_Haupt.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.SpieltabelleToolStripMenuItem, Me.GuthabenToolStripMenuItem, Me.HighscoresToolStripMenuItem, Me.SpielinfoToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip_Haupt.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip_Haupt.Name = "MenuStrip_Haupt"
        Me.MenuStrip_Haupt.Size = New System.Drawing.Size(1090, 24)
        Me.MenuStrip_Haupt.TabIndex = 6
        Me.MenuStrip_Haupt.Text = "MenuStrip1"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(43, 20)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'SpieltabelleToolStripMenuItem
        '
        Me.SpieltabelleToolStripMenuItem.Name = "SpieltabelleToolStripMenuItem"
        Me.SpieltabelleToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.SpieltabelleToolStripMenuItem.Text = "Spieltabelle"
        '
        'GuthabenToolStripMenuItem
        '
        Me.GuthabenToolStripMenuItem.Name = "GuthabenToolStripMenuItem"
        Me.GuthabenToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.GuthabenToolStripMenuItem.Text = "Guthaben"
        '
        'HighscoresToolStripMenuItem
        '
        Me.HighscoresToolStripMenuItem.Name = "HighscoresToolStripMenuItem"
        Me.HighscoresToolStripMenuItem.Size = New System.Drawing.Size(78, 20)
        Me.HighscoresToolStripMenuItem.Text = "Highscores"
        '
        'SpielinfoToolStripMenuItem
        '
        Me.SpielinfoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SpielerToolStripMenuItem, Me.SpielverlaufToolStripMenuItem})
        Me.SpielinfoToolStripMenuItem.Name = "SpielinfoToolStripMenuItem"
        Me.SpielinfoToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.SpielinfoToolStripMenuItem.Text = "Spielinfo"
        '
        'SpielerToolStripMenuItem
        '
        Me.SpielerToolStripMenuItem.Name = "SpielerToolStripMenuItem"
        Me.SpielerToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SpielerToolStripMenuItem.Text = "Spieler"
        '
        'SpielverlaufToolStripMenuItem
        '
        Me.SpielverlaufToolStripMenuItem.Name = "SpielverlaufToolStripMenuItem"
        Me.SpielverlaufToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.SpielverlaufToolStripMenuItem.Text = "Spielanleitung"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Lbl_Einsatz
        '
        Me.Lbl_Einsatz.AutoSize = True
        Me.Lbl_Einsatz.Location = New System.Drawing.Point(421, 463)
        Me.Lbl_Einsatz.Name = "Lbl_Einsatz"
        Me.Lbl_Einsatz.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_Einsatz.TabIndex = 8
        Me.Lbl_Einsatz.Text = "Dein Einsatz:"
        '
        'Lbl_Gewinn
        '
        Me.Lbl_Gewinn.AutoSize = True
        Me.Lbl_Gewinn.Location = New System.Drawing.Point(739, 462)
        Me.Lbl_Gewinn.Name = "Lbl_Gewinn"
        Me.Lbl_Gewinn.Size = New System.Drawing.Size(77, 13)
        Me.Lbl_Gewinn.TabIndex = 9
        Me.Lbl_Gewinn.Text = "letzter Gewinn:"
        '
        'TB_Gewinn
        '
        Me.TB_Gewinn.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.TB_Gewinn.Location = New System.Drawing.Point(822, 457)
        Me.TB_Gewinn.Name = "TB_Gewinn"
        Me.TB_Gewinn.ReadOnly = True
        Me.TB_Gewinn.Size = New System.Drawing.Size(73, 20)
        Me.TB_Gewinn.TabIndex = 10
        '
        'NUD_Einsatz
        '
        Me.NUD_Einsatz.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NUD_Einsatz.DecimalPlaces = 2
        Me.NUD_Einsatz.Increment = New Decimal(New Integer() {2, 0, 0, 65536})
        Me.NUD_Einsatz.Location = New System.Drawing.Point(496, 460)
        Me.NUD_Einsatz.Name = "NUD_Einsatz"
        Me.NUD_Einsatz.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Einsatz.TabIndex = 18
        Me.NUD_Einsatz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Lbl_Zahl1
        '
        Me.Lbl_Zahl1.AutoSize = True
        Me.Lbl_Zahl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Zahl1.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Zahl1.Location = New System.Drawing.Point(265, 169)
        Me.Lbl_Zahl1.Name = "Lbl_Zahl1"
        Me.Lbl_Zahl1.Size = New System.Drawing.Size(27, 29)
        Me.Lbl_Zahl1.TabIndex = 19
        Me.Lbl_Zahl1.Text = "1"
        '
        'Lbl_Zahl2
        '
        Me.Lbl_Zahl2.AutoSize = True
        Me.Lbl_Zahl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Zahl2.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_Zahl2.Location = New System.Drawing.Point(265, 239)
        Me.Lbl_Zahl2.Name = "Lbl_Zahl2"
        Me.Lbl_Zahl2.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Zahl2.TabIndex = 20
        Me.Lbl_Zahl2.Text = "2"
        '
        'LbL_Zahl3
        '
        Me.LbL_Zahl3.AutoSize = True
        Me.LbL_Zahl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_Zahl3.ForeColor = System.Drawing.Color.Purple
        Me.LbL_Zahl3.Location = New System.Drawing.Point(265, 314)
        Me.LbL_Zahl3.Name = "LbL_Zahl3"
        Me.LbL_Zahl3.Size = New System.Drawing.Size(26, 29)
        Me.LbL_Zahl3.TabIndex = 21
        Me.LbL_Zahl3.Text = "3"
        '
        'Lbl_Zahl4
        '
        Me.Lbl_Zahl4.AutoSize = True
        Me.Lbl_Zahl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Zahl4.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Zahl4.Location = New System.Drawing.Point(294, 169)
        Me.Lbl_Zahl4.Name = "Lbl_Zahl4"
        Me.Lbl_Zahl4.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Zahl4.TabIndex = 22
        Me.Lbl_Zahl4.Text = "4"
        '
        'Lbl_Zahl5
        '
        Me.Lbl_Zahl5.AutoSize = True
        Me.Lbl_Zahl5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Zahl5.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Zahl5.Location = New System.Drawing.Point(294, 314)
        Me.Lbl_Zahl5.Name = "Lbl_Zahl5"
        Me.Lbl_Zahl5.Size = New System.Drawing.Size(27, 29)
        Me.Lbl_Zahl5.TabIndex = 23
        Me.Lbl_Zahl5.Text = "5"
        '
        'Cmd_Max_Bet
        '
        Me.Cmd_Max_Bet.Location = New System.Drawing.Point(633, 487)
        Me.Cmd_Max_Bet.Name = "Cmd_Max_Bet"
        Me.Cmd_Max_Bet.Size = New System.Drawing.Size(75, 23)
        Me.Cmd_Max_Bet.TabIndex = 24
        Me.Cmd_Max_Bet.Text = "Max. BET"
        Me.Cmd_Max_Bet.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.LblName.Location = New System.Drawing.Point(410, 76)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(330, 24)
        Me.LblName.TabIndex = 25
        Me.LblName.Text = "Hallo *Spieler*, schön das du da bist :)"
        '
        'Timer_Willkommen
        '
        Me.Timer_Willkommen.Interval = 4000
        '
        'PBFeld_5
        '
        Me.PBFeld_5.Location = New System.Drawing.Point(524, 225)
        Me.PBFeld_5.Name = "PBFeld_5"
        Me.PBFeld_5.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_5.TabIndex = 26
        Me.PBFeld_5.TabStop = False
        '
        'PBFeld_7
        '
        Me.PBFeld_7.Location = New System.Drawing.Point(338, 301)
        Me.PBFeld_7.Name = "PBFeld_7"
        Me.PBFeld_7.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_7.TabIndex = 27
        Me.PBFeld_7.TabStop = False
        '
        'PBFeld_4
        '
        Me.PBFeld_4.Location = New System.Drawing.Point(338, 225)
        Me.PBFeld_4.Name = "PBFeld_4"
        Me.PBFeld_4.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_4.TabIndex = 28
        Me.PBFeld_4.TabStop = False
        '
        'PBFeld_1
        '
        Me.PBFeld_1.Location = New System.Drawing.Point(338, 153)
        Me.PBFeld_1.Name = "PBFeld_1"
        Me.PBFeld_1.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_1.TabIndex = 29
        Me.PBFeld_1.TabStop = False
        '
        'PBFeld_2
        '
        Me.PBFeld_2.Location = New System.Drawing.Point(524, 153)
        Me.PBFeld_2.Name = "PBFeld_2"
        Me.PBFeld_2.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_2.TabIndex = 30
        Me.PBFeld_2.TabStop = False
        '
        'PBFeld_3
        '
        Me.PBFeld_3.Location = New System.Drawing.Point(700, 153)
        Me.PBFeld_3.Name = "PBFeld_3"
        Me.PBFeld_3.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_3.TabIndex = 31
        Me.PBFeld_3.TabStop = False
        '
        'PBFeld_6
        '
        Me.PBFeld_6.Location = New System.Drawing.Point(700, 225)
        Me.PBFeld_6.Name = "PBFeld_6"
        Me.PBFeld_6.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_6.TabIndex = 32
        Me.PBFeld_6.TabStop = False
        '
        'PBFeld_9
        '
        Me.PBFeld_9.Location = New System.Drawing.Point(700, 301)
        Me.PBFeld_9.Name = "PBFeld_9"
        Me.PBFeld_9.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_9.TabIndex = 33
        Me.PBFeld_9.TabStop = False
        '
        'PBFeld_8
        '
        Me.PBFeld_8.Location = New System.Drawing.Point(524, 301)
        Me.PBFeld_8.Name = "PBFeld_8"
        Me.PBFeld_8.Size = New System.Drawing.Size(61, 56)
        Me.PBFeld_8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBFeld_8.TabIndex = 34
        Me.PBFeld_8.TabStop = False
        '
        'Lbl_Zahl5_5
        '
        Me.Lbl_Zahl5_5.AutoSize = True
        Me.Lbl_Zahl5_5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Zahl5_5.ForeColor = System.Drawing.Color.Blue
        Me.Lbl_Zahl5_5.Location = New System.Drawing.Point(831, 169)
        Me.Lbl_Zahl5_5.Name = "Lbl_Zahl5_5"
        Me.Lbl_Zahl5_5.Size = New System.Drawing.Size(27, 29)
        Me.Lbl_Zahl5_5.TabIndex = 40
        Me.Lbl_Zahl5_5.Text = "5"
        '
        'Lbl_Zahl4_4
        '
        Me.Lbl_Zahl4_4.AutoSize = True
        Me.Lbl_Zahl4_4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Zahl4_4.ForeColor = System.Drawing.Color.Red
        Me.Lbl_Zahl4_4.Location = New System.Drawing.Point(832, 314)
        Me.Lbl_Zahl4_4.Name = "Lbl_Zahl4_4"
        Me.Lbl_Zahl4_4.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Zahl4_4.TabIndex = 39
        Me.Lbl_Zahl4_4.Text = "4"
        '
        'LbL_Zahl3_3
        '
        Me.LbL_Zahl3_3.AutoSize = True
        Me.LbL_Zahl3_3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbL_Zahl3_3.ForeColor = System.Drawing.Color.Purple
        Me.LbL_Zahl3_3.Location = New System.Drawing.Point(800, 314)
        Me.LbL_Zahl3_3.Name = "LbL_Zahl3_3"
        Me.LbL_Zahl3_3.Size = New System.Drawing.Size(26, 29)
        Me.LbL_Zahl3_3.TabIndex = 38
        Me.LbL_Zahl3_3.Text = "3"
        '
        'Lbl_Zahl2_2
        '
        Me.Lbl_Zahl2_2.AutoSize = True
        Me.Lbl_Zahl2_2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Zahl2_2.ForeColor = System.Drawing.Color.Yellow
        Me.Lbl_Zahl2_2.Location = New System.Drawing.Point(800, 239)
        Me.Lbl_Zahl2_2.Name = "Lbl_Zahl2_2"
        Me.Lbl_Zahl2_2.Size = New System.Drawing.Size(26, 29)
        Me.Lbl_Zahl2_2.TabIndex = 37
        Me.Lbl_Zahl2_2.Text = "2"
        '
        'Lbl_Zahl1_1
        '
        Me.Lbl_Zahl1_1.AutoSize = True
        Me.Lbl_Zahl1_1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.Lbl_Zahl1_1.ForeColor = System.Drawing.Color.Green
        Me.Lbl_Zahl1_1.Location = New System.Drawing.Point(800, 169)
        Me.Lbl_Zahl1_1.Name = "Lbl_Zahl1_1"
        Me.Lbl_Zahl1_1.Size = New System.Drawing.Size(27, 29)
        Me.Lbl_Zahl1_1.TabIndex = 36
        Me.Lbl_Zahl1_1.Text = "1"
        '
        'NUD_Guthaben
        '
        Me.NUD_Guthaben.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.NUD_Guthaben.DecimalPlaces = 2
        Me.NUD_Guthaben.Format = "{0:0.00}  €"
        Me.NUD_Guthaben.Increment = New Decimal(New Integer() {0, 0, 0, 0})
        Me.NUD_Guthaben.InterceptArrowKeys = False
        Me.NUD_Guthaben.Location = New System.Drawing.Point(285, 458)
        Me.NUD_Guthaben.Maximum = New Decimal(New Integer() {1874919423, 2328306, 0, 0})
        Me.NUD_Guthaben.Name = "NUD_Guthaben"
        Me.NUD_Guthaben.ReadOnly = True
        Me.NUD_Guthaben.Size = New System.Drawing.Size(120, 20)
        Me.NUD_Guthaben.TabIndex = 35
        Me.NUD_Guthaben.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer_Playerlevel
        '
        Me.Timer_Playerlevel.Interval = 10
        '
        'PbPlayerLevel
        '
        Me.PbPlayerLevel.Location = New System.Drawing.Point(338, 395)
        Me.PbPlayerLevel.Name = "PbPlayerLevel"
        Me.PbPlayerLevel.Size = New System.Drawing.Size(423, 23)
        Me.PbPlayerLevel.TabIndex = 41
        '
        'lblPlayerlevel
        '
        Me.lblPlayerlevel.AutoSize = True
        Me.lblPlayerlevel.BackColor = System.Drawing.Color.Transparent
        Me.lblPlayerlevel.Location = New System.Drawing.Point(460, 421)
        Me.lblPlayerlevel.Name = "lblPlayerlevel"
        Me.lblPlayerlevel.Size = New System.Drawing.Size(106, 13)
        Me.lblPlayerlevel.TabIndex = 42
        Me.lblPlayerlevel.Text = "Aktueller Levelscore:"
        '
        'lblLevelscore
        '
        Me.lblLevelscore.AutoSize = True
        Me.lblLevelscore.Location = New System.Drawing.Point(572, 421)
        Me.lblLevelscore.Name = "lblLevelscore"
        Me.lblLevelscore.Size = New System.Drawing.Size(48, 13)
        Me.lblLevelscore.TabIndex = 43
        Me.lblLevelscore.Text = "10 / 100"
        '
        'FrmHaupt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1090, 518)
        Me.Controls.Add(Me.lblLevelscore)
        Me.Controls.Add(Me.lblPlayerlevel)
        Me.Controls.Add(Me.PbPlayerLevel)
        Me.Controls.Add(Me.Lbl_Zahl5_5)
        Me.Controls.Add(Me.Lbl_Zahl4_4)
        Me.Controls.Add(Me.LbL_Zahl3_3)
        Me.Controls.Add(Me.Lbl_Zahl2_2)
        Me.Controls.Add(Me.Lbl_Zahl1_1)
        Me.Controls.Add(Me.NUD_Guthaben)
        Me.Controls.Add(Me.PBFeld_8)
        Me.Controls.Add(Me.PBFeld_9)
        Me.Controls.Add(Me.PBFeld_6)
        Me.Controls.Add(Me.PBFeld_3)
        Me.Controls.Add(Me.PBFeld_2)
        Me.Controls.Add(Me.PBFeld_1)
        Me.Controls.Add(Me.PBFeld_4)
        Me.Controls.Add(Me.PBFeld_7)
        Me.Controls.Add(Me.PBFeld_5)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.Cmd_Max_Bet)
        Me.Controls.Add(Me.Lbl_Zahl5)
        Me.Controls.Add(Me.Lbl_Zahl4)
        Me.Controls.Add(Me.LbL_Zahl3)
        Me.Controls.Add(Me.Lbl_Zahl2)
        Me.Controls.Add(Me.Lbl_Zahl1)
        Me.Controls.Add(Me.NUD_Einsatz)
        Me.Controls.Add(Me.TB_Gewinn)
        Me.Controls.Add(Me.Lbl_Gewinn)
        Me.Controls.Add(Me.Lbl_Einsatz)
        Me.Controls.Add(Me.Cmd_Bet)
        Me.Controls.Add(Me.MenuStrip_Haupt)
        Me.Controls.Add(Me.Lbl_Kontostand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.MenuStrip_Haupt
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1110, 561)
        Me.MinimumSize = New System.Drawing.Size(1110, 561)
        Me.Name = "FrmHaupt"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Slotmaschine"
        Me.MenuStrip_Haupt.ResumeLayout(False)
        Me.MenuStrip_Haupt.PerformLayout()
        CType(Me.NUD_Einsatz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBFeld_8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD_Guthaben, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Cmd_Bet As Button
    Friend WithEvents Lbl_Kontostand As Label
    Friend WithEvents MenuStrip_Haupt As MenuStrip
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpieltabelleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuthabenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl_Einsatz As Label
    Friend WithEvents Lbl_Gewinn As Label
    Friend WithEvents TB_Gewinn As TextBox
    Friend WithEvents NUD_Einsatz As NumericUpDown
    Friend WithEvents Lbl_Zahl1 As Label
    Friend WithEvents Lbl_Zahl2 As Label
    Friend WithEvents LbL_Zahl3 As Label
    Friend WithEvents Lbl_Zahl4 As Label
    Friend WithEvents Lbl_Zahl5 As Label
    Friend WithEvents SpielinfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Cmd_Max_Bet As Button
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpielerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpielverlaufToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LblName As Label
    Friend WithEvents Timer_Willkommen As Timer
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PBFeld_5 As PictureBox
    Friend WithEvents PBFeld_7 As PictureBox
    Friend WithEvents PBFeld_4 As PictureBox
    Friend WithEvents PBFeld_1 As PictureBox
    Friend WithEvents PBFeld_2 As PictureBox
    Friend WithEvents PBFeld_3 As PictureBox
    Friend WithEvents PBFeld_6 As PictureBox
    Friend WithEvents PBFeld_9 As PictureBox
    Friend WithEvents PBFeld_8 As PictureBox
    Friend WithEvents NUD_Guthaben As FormattedNumericUpDown
    Friend WithEvents HighscoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Lbl_Zahl5_5 As Label
    Friend WithEvents Lbl_Zahl4_4 As Label
    Friend WithEvents LbL_Zahl3_3 As Label
    Friend WithEvents Lbl_Zahl2_2 As Label
    Friend WithEvents Lbl_Zahl1_1 As Label
    Friend WithEvents Timer_Playerlevel As Timer
    Friend WithEvents PbPlayerLevel As ProgressBar
    Friend WithEvents lblPlayerlevel As Label
    Friend WithEvents lblLevelscore As Label
End Class
