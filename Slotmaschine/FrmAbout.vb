Public Class FrmAbout
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LblTitle.Text = My.Application.Info.Title

        LblCopyright.Text = My.Application.Info.Copyright

        LblDateiVersion.Text = My.Application.Info.Version.ToString


    End Sub

    Private Sub LlblPixabay_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LlblPixabay.LinkClicked

        System.Diagnostics.Process.Start("https://www.pixabay.com")

    End Sub
End Class