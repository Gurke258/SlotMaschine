Public Class FrmPlayer
    Private Sub FrmPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblName.Text = Loginname
        lblGuthaben.Text = Convert.ToString(FrmHaupt.NUD_Guthaben.Value)

        lblLevelInt.Text = Convert.ToString(Playerlevel & " €")


    End Sub
End Class