Public Class FrmLogin

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer


        For i = 0 To 500

            Benutzer(i) = CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Benutzer", "Benutzer" & i, Benutzer(i)), String)
            Passwort(i) = CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Passwörter", "Passwörter" & i, Passwort(i)), String)
            Guthaben(i) = CType(My.Computer.Registry.GetValue("HKEY_CURRENT_USER\Software\Slotmaschine\Guthaben", "Guthaben" & i, Guthaben(i)), Decimal)

        Next i


        'LblProgBarLogin.Parent = ProgBarLogin
        'LblProgBarLogin.BackColor = Color.Transparent

        LblBenutzer.Parent = PBLogin
        LblBenutzer.BackColor = Color.Transparent

        LblPasswort.Parent = PBLogin
        LblPasswort.BackColor = Color.Transparent


    End Sub
    Private Sub CmdLogin_Click(sender As Object, e As EventArgs) Handles CmdLogin.Click

        'LoginTimer.Start()
        Einloggen()


    End Sub

    Private Sub CmdHilfe_Click(sender As Object, e As EventArgs) Handles cmdHilfe.Click

        MessageBox.Show("Der Benutzer lautet: Admin" & NewLine & "Das Passwort lautet: test", "Benutzerdaten")

    End Sub

    Private Sub CmdBeenden_Click(sender As Object, e As EventArgs) Handles CmdBeenden.Click

        Close()

    End Sub

    Private Sub CmdRegister_Click(sender As Object, e As EventArgs) Handles CmdRegister.Click

        FrmRegistrieren.Show()
        Close()

    End Sub

    Private Sub CmdPWSichtbarL_MouseDown(sender As Object, e As MouseEventArgs) Handles CmdPWSichtbarL.MouseDown

        TBPasswort.PasswordChar = Nothing

    End Sub

    Private Sub CmdPWSichtbarL_MouseUp(sender As Object, e As MouseEventArgs) Handles CmdPWSichtbarL.MouseUp

        TBPasswort.PasswordChar = "*"c

    End Sub

    Private Sub LoginTimer_Tick(sender As Object, e As EventArgs) Handles LoginTimer.Tick




        'ProgBarLogin.Value += 2


        'If ProgBarLogin.Value <= 10 Then

        '    LblProgBarLogin.Text = "Benutzer wird geladen"
        '    Logindrawing.DrawString(text, stringFont, Brushes.Black, x, y)
        'ElseIf ProgBarLogin.Value > 10 AndAlso ProgBarLogin.Value <= 25 Then

        '    LblProgBarLogin.Text = "Passwort wird verglichen"

        'ElseIf ProgBarLogin.Value > 25 AndAlso ProgBarLogin.Value <= 50 Then

        '    LblProgBarLogin.Text = "Geld wird zusammen gekratzt"

        'ElseIf ProgBarLogin.Value > 50 AndAlso ProgBarLogin.Value <= 75 Then

        '    LblProgBarLogin.Text = "Guthaben wird hinzugefügt"

        'ElseIf ProgBarLogin.Value > 75 AndAlso ProgBarLogin.Value <= 90 Then

        '    LblProgBarLogin.Text = "Es kann los gehen!"

        'ElseIf ProgBarLogin.Value > 90 Then

        '    If Loginmoeglich = True Then
        '        LoginTimer.Stop()

        'Loginmoeglich = False
        'Haupt.Show()
        '        TBBenutzer.Text = ""
        '        TBPasswort.Text = ""
        '        Close()
        '    End If

        'End If


    End Sub

    Private Sub ProgBarLogin_Paint(sender As Object, e As PaintEventArgs) Handles ProgBarLogin.Paint

        'Logindrawing = e.Graphics

    End Sub
End Class