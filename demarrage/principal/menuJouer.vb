Imports System.IO

Public Class menuJouer

    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub FlatLabel1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click
        My.Computer.Audio.Play(My.Resources.uifx, AudioPlayMode.Background)

        menuBienvenue.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuBienvenue)
        menuBienvenue.Show()

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Image = My.Resources.débuter_service_jaune
    End Sub

    Private Sub PictureBox1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseLeave
        PictureBox1.Image = My.Resources.débuter_service_gris
    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Image = My.Resources.succès_jaune
    End Sub

    Private Sub PictureBox3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseLeave
        PictureBox3.Image = My.Resources.succès_gris
    End Sub

    Private Sub PictureBox4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Image = My.Resources.statistiques_jaune
    End Sub

    Private Sub PictureBox4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox4.MouseLeave
        PictureBox4.Image = My.Resources.statistiques_gris
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click


        'afficher la liste des plugins

        choixPlugin.ListBox2.Items.Clear()


        Try
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(Application.StartupPath & "\plugin\").GetDirectories()
                choixPlugin.ListBox2.Items.Add(Repertoires.Name)
            Next
            'supprimer description et image
            choixPlugin.FlatLabel3.Text = "Dans Urgence Manager, gérez les services de secours là où vous le souhaitez en installant autant de plugin officiels ou de la communauté que vous souhaitez. Une fois installé, le plugin sera listé ci-dessus."
            choixPlugin.PictureBox1.Image = My.Resources.aucunPluginSelect


            playFxUi()
            choixPlugin.TopLevel = False
            home.Panel1.Controls.Clear()
            home.Panel1.Controls.Add(choixPlugin)
            choixPlugin.Show()
        Catch ex As Exception
            log("Erreur - Echec d'ouverture du dossier plugin, proposition de création du dossier. " & ex.Message)
            msgtitre = "Le dossier '/plugin/' n'existe pas."
            msgOui = "Le créer maintenant"
            msgNon = "Annuler"
            msgOuiNon()

            If msgRésultat = "oui" Then
                Try
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "/plugin/")
                    'supprimer description et image
                    choixPlugin.FlatLabel3.Text = "Dans Urgence Manager, gérez les services de secours là où vous le souhaitez en installant autant de plugin officiels ou de la communauté que vous souhaitez. Une fois installé, le plugin sera listé ci-dessus."
                    choixPlugin.PictureBox1.Image = My.Resources.aucunPluginSelect


                    playFxUi()
                    choixPlugin.TopLevel = False
                    home.Panel1.Controls.Clear()
                    home.Panel1.Controls.Add(choixPlugin)
                    choixPlugin.Show()
                Catch ex2 As Exception
                    msgtitre = "Désolé, impossible de créer le dossier /'plugin'/. Vérifiez que le dossier" & Chr(13) & "d'installation n'est pas déjà utilisé."
                    msgInfo()
                    log("Erreur - impossible de créer dossier plugin. " & ex2.Message)
                End Try
            End If
        End Try
        



        


    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        playFxWin()
        statistiques.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(statistiques)
        statistiques.Show()
        statistiques.actualiserStats()

    End Sub

    Private Sub FlatLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel3.Click

        home.Close()

    End Sub
End Class