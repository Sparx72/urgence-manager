Imports System.Text

Public Class choixPlugin



    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        playFxUi()
        menuJouer.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuJouer)
        menuJouer.Show()

    End Sub

    Private Sub FlatLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel2.Click

        playFxMsg()
        msgModManquants.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(msgModManquants)
        msgModManquants.Show()

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged


        'affichage image et description
        If ListBox2.SelectedItem <> "" Then
            FlatLabel3.Text = Cls_Ini.INIRead(Application.StartupPath & "\plugin\" & ListBox2.SelectedItem & "\plugin.ini", "info", "pluginDescription")
            PictureBox1.ImageLocation = Application.StartupPath & "\plugin\" & ListBox2.SelectedItem & "\plugin.jpg"
        End If

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

        If ListBox2.SelectedItem <> "" Then

            pluginLoaded = Application.StartupPath & "\plugin\" & ListBox2.SelectedItem


            Try
                chargementForm.PictureBox5.Image = home.PictureBox5.Image
            Catch ex As Exception

            End Try
            chargementForm.Label3.Text = home.Label1.Text



            'affichage game

            chargementForm.Show()
            game.Show()


            game.Panel4.Controls.Clear()
            menuGame.TopLevel = False
            game.Panel4.Controls.Add(menuGame)
            menuGame.Show()




            home.Hide()
            latInter = Cls_Ini.INIRead(pluginLoaded & "/plugin.ini", "info", "initLat")
            lonInter = Cls_Ini.INIRead(pluginLoaded & "/plugin.ini", "info", "initLon")
            cartevide()

            Dim random As New Random(), rndnbr As Integer
            Randomize()
            rndnbr = random.Next(25000, 70000)
            game.TimerAppel.Interval = rndnbr
            game.TimerAppel.Enabled = True
            game.modeInter = False

            'stats

            If Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "serviceTaken") = "" Then
                Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "serviceTaken", "0")
            End If

            Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "serviceTaken", Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "serviceTaken") + 1)
        Else
            msgtitre = "Vous devez sélectionner un plugin parmis ceux installés"
            msgInfo()
        End If

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        msgtitre = "Cette fonctionnalité sera prochainement disponible"
        msgInfo()
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        msgtitre = "Cette fonctionnalité sera prochainement disponible"
        msgInfo()
    End Sub
End Class