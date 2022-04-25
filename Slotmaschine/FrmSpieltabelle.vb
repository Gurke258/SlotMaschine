Public Class FrmSpieltabelle



    Private Sub Spieltabelle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TopMost = True

        'Kirsche
        PB_1_Kirsche.Image = Slotbilder(4)
        PB_2_Kirsche.Image = Slotbilder(4)
        PB_3_Kirsche.Image = Slotbilder(4)
        LblKirsche.Text = String.Concat(CType(Einsatz * 1.1, String) & " €")

        'Kiwi
        PB_1_Kiwi.Image = Slotbilder(1)
        PB_2_Kiwi.Image = Slotbilder(1)
        PB_3_Kiwi.Image = Slotbilder(1)
        LblKiwi.Text = String.Concat(CType(Einsatz * 1.3, String) & " €")

        'Zitrone
        PB_1_Zitrone.Image = Slotbilder(5)
        PB_2_Zitrone.Image = Slotbilder(5)
        PB_3_Zitrone.Image = Slotbilder(5)
        LblZitrone.Text = String.Concat(CType(Einsatz * 1.5, String) & " €")

        'Kokusnuss
        PB_1_Kokusnuss.Image = Slotbilder(3)
        PB_2_Kokusnuss.Image = Slotbilder(3)
        PB_3_Kokusnuss.Image = Slotbilder(3)
        LblKokusnuss.Text = String.Concat(CType(Math.Round(Einsatz * 1.69, 2), String) & " €")

        'Birne
        PB_1_Birne.Image = Slotbilder(6)
        PB_2_Birne.Image = Slotbilder(6)
        PB_3_Birne.Image = Slotbilder(6)
        LblBirne.Text = String.Concat(CType(Einsatz * 1.75, String) & " €")

        'Banane
        PB_1_Banane.Image = Slotbilder(2)
        PB_2_Banane.Image = Slotbilder(2)
        PB_3_Banane.Image = Slotbilder(2)
        LblBanane.Text = String.Concat(CType(Einsatz * 1.8, String) & " €")

        'Ananas
        PB_1_Ananas.Image = Slotbilder(8)
        PB_2_Ananas.Image = Slotbilder(8)
        PB_3_Ananas.Image = Slotbilder(8)
        LblAnanas.Text = String.Concat(CType(Math.Round(Einsatz * 1.89, 2), String) & " €")

        'Apfel
        PB_1_Apfel.Image = Slotbilder(9)
        PB_2_Apfel.Image = Slotbilder(9)
        PB_3_Apfel.Image = Slotbilder(9)
        LblApfel.Text = String.Concat(CType(Einsatz * 1.95, String) & " €")

        'Erdbeer
        PB_1_Erdbeer.Image = Slotbilder(7)
        PB_2_Erdbeer.Image = Slotbilder(7)
        PB_3_Erdbeer.Image = Slotbilder(7)
        LblErdbeer.Text = String.Concat(CType(Einsatz * 2.0, String) & " €")

        'Stern
        PB_1_Stern.Image = Slotbilder(0)
        PB_2_Stern.Image = Slotbilder(0)
        PB_3_Stern.Image = Slotbilder(0)
        LblStern.Text = "" 'String.Concat(CType(Einsatz * 1.1, String) & " €")

    End Sub

    Private Sub Cmd_Schließen_Click(sender As Object, e As EventArgs) Handles Cmd_Schließen.Click

        Close()

    End Sub
End Class