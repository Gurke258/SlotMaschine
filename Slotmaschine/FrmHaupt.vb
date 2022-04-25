Public Class FrmHaupt



    Private Sub Haupt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Guthaben übertragen
        NUD_Guthaben.Value = LoginGuthaben 'CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine", "Guthaben", NUD_Guthaben), Decimal)
        NUD_Guthaben.Controls(0).Enabled = False

        'Begrüßung
        LblName.Text = "Hallo " & Loginname & ", schön das du da bist :)"
        Timer_Willkommen.Start()
        Timer_Playerlevel.Start()

        'Labels
        Lbl_Zahl1.Parent = Me
        Lbl_Zahl1.BackColor = Color.Transparent
        Lbl_Zahl2.Parent = Me
        Lbl_Zahl2.BackColor = Color.Transparent
        LbL_Zahl3.Parent = Me
        LbL_Zahl3.BackColor = Color.Transparent
        Lbl_Zahl4.Parent = Me
        Lbl_Zahl4.BackColor = Color.Transparent
        Lbl_Zahl5.Parent = Me
        Lbl_Zahl5.BackColor = Color.Transparent


        'Slotbilder laden
        PBFeld_1.Image = Slotbilder(0)
        PBFeld_1.BackColor = Color.Transparent
        PBFeld_2.Image = Slotbilder(0)
        PBFeld_2.BackColor = Color.Transparent
        PBFeld_3.Image = Slotbilder(0)
        PBFeld_3.BackColor = Color.Transparent
        PBFeld_4.Image = Slotbilder(0)
        PBFeld_4.BackColor = Color.Transparent
        PBFeld_5.Image = Slotbilder(0)
        PBFeld_5.BackColor = Color.Transparent
        PBFeld_6.Image = Slotbilder(0)
        PBFeld_6.BackColor = Color.Transparent
        PBFeld_7.Image = Slotbilder(0)
        PBFeld_7.BackColor = Color.Transparent
        PBFeld_8.Image = Slotbilder(0)
        PBFeld_8.BackColor = Color.Transparent
        PBFeld_9.Image = Slotbilder(0)
        PBFeld_9.BackColor = Color.Transparent





    End Sub
    Private Sub Linie1(sender As Object, e As PaintEventArgs) Handles Me.Paint

        linie = e.Graphics
        If LinesOfHaupt(3) Then
            linie.DrawLine(RedLine, 350, 175, 740, 340) 'Rote Linie
            LinesOfHaupt(3) = False
        End If
        If LinesOfHaupt(4) Then
            linie.DrawLine(BlueLine, 740, 180, 350, 340)   'Blaue Linie
            LinesOfHaupt(4) = False
        End If
        If LinesOfHaupt(0) Then
            linie.DrawLine(GreenLine, 350, 190, 740, 190)  'Grüne Linie
            LinesOfHaupt(0) = False
        End If
        If LinesOfHaupt(1) Then
            linie.DrawLine(YellowLine, 350, 260, 740, 260) 'Gelbe Linie
            LinesOfHaupt(1) = False
        End If
        If LinesOfHaupt(2) Then
            linie.DrawLine(PurpleLine, 350, 335, 740, 335) 'Lila Linie
            LinesOfHaupt(2) = False
        End If

        linie.DrawRectangle(Black, 250, 135, 610, 240) 'Rechteck
        linie.DrawLine(Black, 325, 135, 325, 375) 'Trennung links
        linie.DrawLine(Black, 790, 135, 790, 375) 'Trennung rechts

    End Sub
    Private Sub Cmd_Bet_Click(sender As Object, e As EventArgs) Handles Cmd_Bet.Click

        If NUD_Einsatz.Value = 0.00 Then

            MessageBox.Show("Du musst erst einen Einsatz eingeben!", "Einsatz eingeben")

        ElseIf NUD_Guthaben.Value = 0.00 Then

            MessageBox.Show("Du hast dein Guthaben aufgebraucht! Bitte neues aufladen.", "Kein Guthaben", MessageBoxButtons.OK)

        ElseIf NUD_Guthaben.Value < NUD_Einsatz.Value Then

            MessageBox.Show("Dein Einsatz ist größer als das vorhandene Guthaben!" & NewLine &
                            "Bitte neues Guthaben aufladen oder den Einsatz verringern.", "Guthaben zu niedrig", MessageBoxButtons.OK)


        Else

            NUD_Guthaben.Value = NUD_Guthaben.Value - NUD_Einsatz.Value

            Drehen()
            Gewinn()

        End If



    End Sub

    Private Sub GuthabenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuthabenToolStripMenuItem.Click

        FrmAufladen.Show()



    End Sub

    Private Sub SpieltabelleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpieltabelleToolStripMenuItem.Click

        FrmSpieltabelle.Show()

    End Sub


    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click

        Close()

    End Sub

    Private Sub Cmd_Max_Bet_Click(sender As Object, e As EventArgs) Handles Cmd_Max_Bet.Click

        If NUD_Guthaben.Value < NUD_Einsatz.Maximum AndAlso NUD_Guthaben.Value > 0 Then

            NUD_Einsatz.Value = NUD_Guthaben.Value
            NUD_Guthaben.Value = 0
            Drehen()
            Gewinn()

        ElseIf NUD_Guthaben.Value = 0 Then

            MessageBox.Show("Du hast dein Guthaben aufgebraucht! Bitte neues aufladen.", "Kein Guthaben", MessageBoxButtons.OK)

        Else


            NUD_Einsatz.Value = NUD_Einsatz.Maximum
            NUD_Guthaben.Value = NUD_Guthaben.Value - NUD_Einsatz.Value
            Drehen()
            Gewinn()
        End If



    End Sub

    Private Sub NUD_Guthaben_Paint(sender As Object, e As PaintEventArgs)

        'e.Graphics.FillRectangle(Pinsel, 235, 394, 20, 20)

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

        FrmAbout.Show()

    End Sub

    Private Sub SpielverlaufToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpielverlaufToolStripMenuItem.Click

        Spielaanleitung.Show()

    End Sub

    Private Sub Timer_Willkommen_Tick(sender As Object, e As EventArgs) Handles Timer_Willkommen.Tick

        Timer_Willkommen.Stop()

        LblName.Text = ""


    End Sub

    Private Sub SpielerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpielerToolStripMenuItem.Click

        FrmPlayer.Show()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click

        FrmLogin.Show()
        Close()

    End Sub

    Private Sub Haupt_Close(sender As Object, e As EventArgs) Handles MyBase.Closed

        Dim i As Integer

        LoginGuthaben = NUD_Guthaben.Value

        For i = 0 To 500

            If Loginname = Benutzer(i) AndAlso Loginpasswort = Passwort(i) Then

                My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Slotmaschine", "Guthaben" & i, LoginGuthaben)
                Exit For
            End If

        Next i

        Loginname = ""
        Loginpasswort = ""
        LoginGuthaben = 0

    End Sub

    Private Sub NUD_Einsatz_ValueChanged(sender As Object, e As EventArgs) Handles NUD_Einsatz.ValueChanged

        Einsatz = NUD_Einsatz.Value

    End Sub

    Private Sub HighscoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HighscoresToolStripMenuItem.Click
        FrmHighscore.Show()
    End Sub

    Private Sub Timer_Playerlevel_Tick(sender As Object, e As EventArgs) Handles Timer_Playerlevel.Tick
        PbPlayerLevel.Value = CType(Levelscore, Integer)
        lblLevelscore.Text = Convert.ToString(Levelscore & " / 100")
    End Sub
End Class
