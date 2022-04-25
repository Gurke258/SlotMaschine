Public Class FrmAufladen


    Private Sub Guthaben_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblGuthaben.Parent = PictureBox1
        LblGuthaben.BackColor = Color.Transparent
        'transparent only to its parent

        TopMost = True




    End Sub
    Private Sub Cmd_1_euro_Click(sender As Object, e As EventArgs) Handles Cmd_1_euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(1.0, Decimal)

    End Sub

    Private Sub Cmd_5_euro_Click(sender As Object, e As EventArgs) Handles Cmd_5_euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(5.0, Decimal)

    End Sub

    Private Sub Cmd_10_euro_Click(sender As Object, e As EventArgs) Handles Cmd_10_euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(10.0, Decimal)

    End Sub

    Private Sub Cmd_25_Euro_Click(sender As Object, e As EventArgs) Handles Cmd_25_Euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(25.0, Decimal)

    End Sub

    Private Sub Cmd_50_euro_Click(sender As Object, e As EventArgs) Handles Cmd_50_euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(50.0, Decimal)

    End Sub

    Private Sub Cmd_100_euro_Click(sender As Object, e As EventArgs) Handles Cmd_100_euro.Click

        FrmHaupt.NUD_Guthaben.Value += CType(100.0, Decimal)

    End Sub

    Private Sub Cmd_Schließen_Click(sender As Object, e As EventArgs) Handles Cmd_Schließen.Click

        Close()

    End Sub

End Class