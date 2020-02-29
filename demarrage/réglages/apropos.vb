Public Class apropos





    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        playFxUi()
        menuBienvenue.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuBienvenue)
        menuBienvenue.Show()
    End Sub


End Class