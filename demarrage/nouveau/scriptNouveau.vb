Module scriptNouveau

    Public étapeLancement As Integer = 0


    Dim titreOk As Boolean = False
    Public vocalMarche As Boolean = False


    Public Sub eXscriptNouveau()




        'script création dossier

        créerDossierBase()


        'initialisation synthèse vocale

        Try
                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                Form1.parole.SpeakAsync("")
                log("Synthèse vocale initialisé")

        Catch ex As Exception
            log("Échec initialisation synthèse vocale - " & ex.Message)
        End Try



        'affichage home
        log("Affichage home")
        home.Show()


        'fermeture fenêtre splash
        splash.Close()




        'conditions utilisation
        If Cls_Ini.INIRead(appdata & "settings/settings.ini", "requirement", "terms") <> "accepted" And étapeLancement = 0 Then

            conditionsUtilisation.TopLevel = False
            home.Panel1.Controls.Clear()
            home.Panel1.Controls.Add(conditionsUtilisation)
            conditionsUtilisation.Show()

            conditionsUtilisation.TextBox1.SelectionStart = erreur.TextBox1.Text.Length
            conditionsUtilisation.TextBox1.SelectionLength = erreur.TextBox1.Text.Length


            log("Conditions d'utilisations non acceptées, affichage demande")

        Else

            étapeLancement = 1
            log("Conditions d'utilisations déjà acceptées")

        End If





        'synthèse vocale

        If étapeLancement = 1 Then



            Try

                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                Form1.parole.SpeakAsync("")
                log("Synthèse vocale initialisé")
                vocalMarche = True

            Catch ex As Exception
                log("Échec initialisation synthèse vocale, affichage demande - " & ex.Message)
            End Try


            If vocalMarche = False Then


                tutoSyntheseVocal.TopLevel = False
                home.Panel1.Controls.Clear()
                home.Panel1.Controls.Add(tutoSyntheseVocal)
                tutoSyntheseVocal.Show()


            Else

                étapeLancement = 2
                log("Synthèse vocale installé, affichage ignoré")

            End If

        End If



        If étapeLancement = 2 Then


            If titreOk = False Then
                titre.TopLevel = False
                home.Panel1.Controls.Clear()
                home.Panel1.Controls.Add(titre)
                titre.Show()
            Else
                étapeLancement = 3
            End If

            titreOk = True


        End If








        'affichage menu principal
        If étapeLancement = 3 Then


            If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "surname") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "firstname") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "pseudo") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "menuProfileDisplay") <> "" Then

                'afffichage profile
                If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "menuProfileDisplay") = "Name and firstname" Then
                    home.Label1.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "firstname").ToUpper & " " & Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "surname").ToUpper
                Else
                    home.Label1.Text = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "pseudo").ToUpper
                End If

                home.PictureBox5.ImageLocation = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "image")

                home.Label1.Visible = True
                home.PictureBox5.Visible = True

                log("Affichage profile sur interface")



                menuBienvenue.TopLevel = False
                home.Panel1.Controls.Clear()
                home.Panel1.Controls.Add(menuBienvenue)
                menuBienvenue.Show()

                log("Affichage menu principal")




            Else

                log("Affichage création premier profile")

                créerProfile.TopLevel = False
                home.Panel1.Controls.Clear()
                home.Panel1.Controls.Add(créerProfile)
                créerProfile.Show()


                msgtitre = "Bienvenue dans Urgence Manager !" & Chr(13) & "Il semblerait que vous soyez nouveau parmis nous, créez dès maintenant" & Chr(13) & "votre opérateur avant de vous lancer dans vos premiers services."
                msgInfo()


            End If





        End If



    End Sub

End Module
