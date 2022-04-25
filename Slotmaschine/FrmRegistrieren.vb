Public Class FrmRegistrieren
    Private Sub Registrieren_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdRegistrieren_Click(sender As Object, e As EventArgs) Handles CmdRegistrieren.Click

        Dim i As Integer

        If String.IsNullOrEmpty(TBBenutzer.Text) Then

            MessageBox.Show("Es wurde kein Benutzer angegeben", "Fehlender Benutzername")

        ElseIf String.IsNullOrEmpty(TBPasswort.Text) Then

            MessageBox.Show("Es wurde kein Passwort angegeben", "Fehlendes Passwort")

        ElseIf TBPasswort.Text <> TBPasswort2.Text Then

            MessageBox.Show("Die Passwörter stimmen nicht überein!", "Falsche Passwörter")


        ElseIf TBPasswort.Text = TBPasswort2.Text Then

            For i = 0 To 500

                If String.IsNullOrEmpty(Benutzer(i)) AndAlso String.IsNullOrEmpty(Passwort(i)) Then

                    Benutzer(i) = TBBenutzer.Text
                    Passwort(i) = TBPasswort.Text
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Benutzer", "Benutzer" & i, Benutzer(i))
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Passwörter", "Passwörter" & i, Passwort(i))
                    My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Guthaben", "Guthaben" & i, Guthaben(i))

                    MessageBox.Show("Du wurdest erfolgreich registriert", "Erfolg!")
                    Exit For

                ElseIf Benutzer(i) = TBBenutzer.Text Then

                    MessageBox.Show("Diesen Benutzernamen gibt es schon!", "Fehlgeschlagen!")
                    Exit Sub
                End If

            Next i

            FrmLogin.Show()
            Close()

        End If

    End Sub

    Private Sub CmdPWSichtbarR_MouseDown(sender As Object, e As MouseEventArgs) Handles CmdPWSichtbarR.MouseDown

        TBPasswort.PasswordChar = Nothing
        TBPasswort2.PasswordChar = Nothing

    End Sub

    Private Sub CmdPWSichtbarR_MouseUp(sender As Object, e As MouseEventArgs) Handles CmdPWSichtbarR.MouseUp

        TBPasswort.PasswordChar = "*"c
        TBPasswort2.PasswordChar = "*"c

    End Sub

    Private Sub Registrieren_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        FrmLogin.Show()

    End Sub
End Class