Module Funktionen

    Public Sub CheckLine()


        If Feld1 = Feld2 AndAlso Feld2 = Feld3 OrElse
           Feld1 = 0 AndAlso Feld2 = Feld3 OrElse
           Feld2 = 0 AndAlso Feld1 = Feld3 OrElse
           Feld3 = 0 AndAlso Feld1 = Feld2 OrElse
           Feld3 = 0 AndAlso Feld1 = 0 OrElse
           Feld1 = 0 AndAlso Feld2 = 0 OrElse
           Feld2 = 0 AndAlso Feld3 = 0 Then
            LinesOfHaupt(0) = True 'Linie 1

        ElseIf Feld4 = Feld5 AndAlso Feld5 = Feld6 OrElse
           Feld4 = 0 AndAlso Feld5 = Feld6 OrElse
           Feld5 = 0 AndAlso Feld4 = Feld6 OrElse
           Feld6 = 0 AndAlso Feld5 = Feld4 OrElse
           Feld6 = 0 AndAlso Feld4 = 0 OrElse
           Feld5 = 0 AndAlso Feld6 = 0 OrElse
           Feld5 = 0 AndAlso Feld4 = 0 Then
            LinesOfHaupt(1) = True 'Linie 2

        ElseIf Feld7 = Feld8 AndAlso Feld8 = Feld9 OrElse
            Feld7 = 0 AndAlso Feld8 = Feld9 OrElse
            Feld8 = 0 AndAlso Feld7 = Feld9 OrElse
            Feld9 = 0 AndAlso Feld7 = Feld8 OrElse
            Feld9 = 0 AndAlso Feld7 = 0 OrElse
            Feld7 = 0 AndAlso Feld8 = 0 OrElse
            Feld9 = 0 AndAlso Feld8 = 0 Then
            LinesOfHaupt(2) = True 'Linie 3

        ElseIf Feld1 = Feld5 AndAlso Feld5 = Feld9 OrElse
            Feld1 = 0 AndAlso Feld5 = Feld9 OrElse
            Feld5 = 0 AndAlso Feld1 = Feld9 OrElse
            Feld9 = 0 AndAlso Feld1 = Feld5 OrElse
            Feld1 = 0 AndAlso Feld5 = 0 OrElse
            Feld5 = 0 AndAlso Feld9 = 0 OrElse
            Feld1 = 0 AndAlso Feld9 = 0 Then
            LinesOfHaupt(3) = True 'Linie 4

        ElseIf Feld3 = Feld5 AndAlso Feld5 = Feld7 OrElse
            Feld3 = 0 AndAlso Feld5 = Feld7 OrElse
            Feld5 = 0 AndAlso Feld7 = Feld3 OrElse
            Feld7 = 0 AndAlso Feld5 = Feld3 OrElse
            Feld7 = 0 AndAlso Feld5 = 0 OrElse
            Feld7 = 0 AndAlso Feld3 = 0 OrElse
            Feld3 = 0 AndAlso Feld5 = 0 Then
            LinesOfHaupt(4) = True 'Linie 5

        End If


    End Sub



    Public Sub Drehen()

        Früchte = 0
        FrmHaupt.TB_Gewinn.Text = ""

        Dim Rnd As New Random

        Feld1 = Rnd.Next(Slotbilder.Length)
        Feld2 = Rnd.Next(Slotbilder.Length)
        Feld3 = Rnd.Next(Slotbilder.Length)
        Feld4 = Rnd.Next(Slotbilder.Length)
        Feld5 = Rnd.Next(Slotbilder.Length)
        Feld6 = Rnd.Next(Slotbilder.Length)
        Feld7 = Rnd.Next(Slotbilder.Length)
        Feld8 = Rnd.Next(Slotbilder.Length)
        Feld9 = Rnd.Next(Slotbilder.Length)


        FrmHaupt.PBFeld_1.Image = Slotbilder(Feld1)
        FrmHaupt.PBFeld_2.Image = Slotbilder(Feld2)
        FrmHaupt.PBFeld_3.Image = Slotbilder(Feld3)
        FrmHaupt.PBFeld_4.Image = Slotbilder(Feld4)
        FrmHaupt.PBFeld_5.Image = Slotbilder(Feld5)
        FrmHaupt.PBFeld_6.Image = Slotbilder(Feld6)
        FrmHaupt.PBFeld_7.Image = Slotbilder(Feld7)
        FrmHaupt.PBFeld_8.Image = Slotbilder(Feld8)
        FrmHaupt.PBFeld_9.Image = Slotbilder(Feld9)

    End Sub


    Public Sub Gewinn()

        For Früchte = 1 To 9
            If Früchte = 1 Then 'Kiwi
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.3) 'Obere Linie 
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.3) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.3) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.3) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.3) 'Diagonal unten links

            ElseIf Früchte = 2 Then 'Banane
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.8) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.8) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.8) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.8) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.8) 'Diagonal unten links

            ElseIf Früchte = 3 Then 'Kokusnuss
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.69) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.69) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.69) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.69) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.69) 'Diagonal unten links

            ElseIf Früchte = 4 Then 'Kirsche
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.1) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.1) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.1) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.1) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.1) 'Diagonal unten links

            ElseIf Früchte = 5 Then 'Zitrone
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.5) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.5) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.5) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.5) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.5) 'Diagonal unten links

            ElseIf Früchte = 6 Then 'Birne
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.75) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.75) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.75) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.75) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.75) 'Diagonal unten links

            ElseIf Früchte = 7 Then 'Erdbeere
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 2.0) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 2.0) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 2.0) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 2.0) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 2.0) 'Diagonal unten links

            ElseIf Früchte = 8 Then 'Pfirsich
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.89) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.89) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.89) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.89) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.89) 'Diagonal unten links

            ElseIf Früchte = 9 Then 'Apfel
                CheckForWin({Feld1, Feld2, Feld3}, Früchte, Einsatz * 1.95) 'Obere Linie
                CheckForWin({Feld4, Feld5, Feld6}, Früchte, Einsatz * 1.95) 'Mittellinie
                CheckForWin({Feld7, Feld8, Feld9}, Früchte, Einsatz * 1.95) 'Untere Linie
                CheckForWin({Feld1, Feld5, Feld9}, Früchte, Einsatz * 1.95) 'Diagonal oben links
                CheckForWin({Feld7, Feld5, Feld3}, Früchte, Einsatz * 1.95) 'Diagonal unten links
            End If
        Next

        CheckLine()
        FrmHaupt.Invalidate()

        If Levelscore >= 100 Then
            Levelscore = 0
            Playerlevel += 1
        End If

        GewinnGesamt = 0
        Feld1 = 0
        Feld2 = 0
        Feld3 = 0
        Feld4 = 0
        Feld5 = 0
        Feld6 = 0
        Feld7 = 0
        Feld8 = 0
        Feld9 = 0

    End Sub

    Public Sub Einloggen()

        Dim i As Integer = 0

        For i = 0 To Benutzer.Length
            If Benutzer(i) = FrmLogin.TBBenutzer.Text AndAlso Passwort(i) = FrmLogin.TBPasswort.Text Then

                Loginname = Benutzer(i)
                Loginpasswort = Passwort(i)
                LoginGuthaben = Guthaben(i)
                Exit For

            ElseIf String.IsNullOrEmpty(Benutzer(i)) Then

                MessageBox.Show("Benuzter wurde nicht gefunden", "Benutzer nicht gefunden")
                Exit Sub

            End If



        Next i


        If Not String.IsNullOrEmpty(Loginname) AndAlso Not String.IsNullOrEmpty(Loginpasswort) Then

            FrmLogin.TBBenutzer.Text = ""
            FrmLogin.TBPasswort.Text = ""

            FrmHaupt.Show()

            FrmLogin.Close()

            'Loginmoeglich = True


        Else

            MessageBox.Show("Die eingegeben Benutzerdaten stimmen nicht überein!", "Falsche Benutzerdaten")

        End If

    End Sub

    Private Sub CheckForWin(PicturesToCheck As Integer(), FruitIndex As Integer, Bonus As Double)
        For Each PictureToCheck In PicturesToCheck
            If Not PictureToCheck.IsOneOf(0, FruitIndex) Then Return
        Next
        GewinnGesamt += Bonus

        If Playerlevel = 0 Then
            Levelscore += GewinnGesamt / 2
        Else
            Levelscore += (GewinnGesamt / 2 / Playerlevel)
        End If

        FrmHaupt.TB_Gewinn.Text = String.Concat(CType(Math.Round(GewinnGesamt, 2), String) & " €")
        FrmHaupt.NUD_Guthaben.Value += CType(Math.Round(GewinnGesamt, 2), Decimal)

    End Sub
End Module
