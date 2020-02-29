Public Class msgModManquants


    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        msgtitre = "La page de téléchargement de la voix va s'afficher dans" & Chr(13) & "votre navigateur par défaut"
        msgInfo()

        home.WindowState = FormWindowState.Minimized
        Process.Start("http://dl.free.fr/getfile.pl?file=/MSqbyVaB/3-RSSolo4FrenchVirginie.exe")

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        msgtitre = "Nos forums vont s'afficher dans votre navigateur par défaut"
        msgInfo()


        Process.Start("https://urgence-manager.zd.fr/forums/")
        home.WindowState = FormWindowState.Minimized


    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        étapeLancement = 2
        eXscriptNouveau()
        playFxWin()

    End Sub

    Private Sub FlatButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Try
            Process.Start(Application.StartupPath & "/plugin/")
            home.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            log("Erreur - Echec d'ouverture du dossier plugin, proposition de création du dossier. " & ex.Message)
            msgtitre = "Le dossier '/plugin/' n'existe pas."
            msgOui = "Le créer maintenant"
            msgNon = "Annuler"
            msgOuiNon()

            If msgRésultat = "oui" Then
                Try
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "/plugin/")
                    home.WindowState = FormWindowState.Minimized
                    Process.Start(Application.StartupPath & "/plugin/")
                Catch ex2 As Exception
                    msgtitre = "Désolé, impossible de créer le dossier /'plugin'/. Vérifiez que le dossier" & Chr(13) & "d'installation n'est pas déjà utilisé."
                    msgInfo()
                    log("Erreur - impossible de créer dossier plugin. " & ex2.Message)
                End Try
            End If
        End Try

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        Try
            Process.Start(Application.StartupPath & "/callout/")
            home.WindowState = FormWindowState.Minimized
        Catch ex As Exception
            log("Erreur - Echec d'ouverture du dossier callout, proposition de création du dossier. " & ex.Message)
            msgtitre = "Le dossier '/callout/' n'existe pas."
            msgOui = "Le créer maintenant"
            msgNon = "Annuler"
            msgOuiNon()

            If msgRésultat = "oui" Then
                Try
                    System.IO.Directory.CreateDirectory(Application.StartupPath & "/callout/")
                    home.WindowState = FormWindowState.Minimized
                    Process.Start(Application.StartupPath & "/callout/")
                Catch ex2 As Exception
                    msgtitre = "Désolé, impossible de créer le dossier '/callout/'. Vérifiez que le dossier" & Chr(13) & "d'installation n'est pas déjà utilisé."
                    msgInfo()
                    log("Erreur - impossible de créer dossier callout. " & ex2.Message)
                End Try
            End If
        End Try

    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click


        playFxUi()
        menuJouer.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuJouer)
        menuJouer.Show()


    End Sub
End Class