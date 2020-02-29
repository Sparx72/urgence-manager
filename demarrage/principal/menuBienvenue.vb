Public Class menuBienvenue

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.jouer_mode_libre_jaune
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.jouer_mode_libre_gris
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.mon_opérateur_jaune
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.mon_opérateur_gris
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.mods_installés_jaune
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.mods_installés_gris
    End Sub

    Private Sub PictureBox5_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Image = My.Resources.réglages_jaune
    End Sub

    Private Sub PictureBox5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox5.MouseLeave
        PictureBox5.Image = My.Resources.réglages_gris
    End Sub

    Private Sub FlatLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel2.Click

        playFxUi()
        menuJouer.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuJouer)
        menuJouer.Show()



    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        playFxUi()
        menuJouer.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuJouer)
        menuJouer.Show()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click



        'chargement opérateur
        log("Affichage menu opérateur et chargement")
        playFxMsg()

        Try
            monOpérateur.PictureBox2.ImageLocation = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "image")
            monOpérateur.TextBox1.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "surname")
            monOpérateur.TextBox2.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "firstname")
            monOpérateur.TextBox3.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "pseudo")
            monOpérateur.FlatComboBox2.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "gender")

            monOpérateur.FlatNumeric1.Value = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "birthDD")
            monOpérateur.FlatNumeric2.Value = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "birthMM")
            monOpérateur.FlatNumeric3.Value = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "birthYYYY")


            If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "menuProfileDisplay") = "Name and firstname" Then
                monOpérateur.FlatComboBox1.Text = "Nom et prénom"
            Else
                monOpérateur.FlatComboBox1.Text = "Surnom ou pseudo"
            End If


            log("Chargement opérateur avec succès")
        Catch ex As Exception
            log("Erreur lors du chargement : " & ex.Message)
        End Try

        



        monOpérateur.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(monOpérateur)
        monOpérateur.Show()

    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click

        playFxWin()
        apropos.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(apropos)
        apropos.Show()

    End Sub

    Private Sub FlatLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel3.Click
        home.Close()
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        msgtitre = "Cette fonctionnalité sera prochainement disponible"
        msgInfo()
    End Sub
End Class