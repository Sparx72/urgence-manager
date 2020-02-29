Imports System.IO
Module gestionAppels

    Public interChargé As String



    Public Sub générerAppel()


        Dim accordAfficherInter As Boolean = False


        '///////////////////// Choisir appel
        log("UT Engine - Génération d'un nouvel appel")

        Dim totalCallout As Integer

        Try
            totalCallout = Directory.EnumerateDirectories(Application.StartupPath & "\callout\", "*", SearchOption.TopDirectoryOnly).Count()
            log("UT Engine - " & totalCallout & " appels installés trouvés")
        Catch ex As Exception
            totalCallout = 0
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
                    msgtitre = "Désolé, impossible de créer le dossier /'callout'/. Vérifiez que le dossier" & Chr(13) & "d'installation n'est pas déjà utilisé."
                    msgInfo()
                    log("Erreur - impossible de créer dossier callout. " & ex2.Message)
                End Try
            End If
        End Try
        




        If totalCallout <> 0 And Directory.Exists(pluginLoaded & "\adress\") = True Then

            'si il y a des appels d'installé

            Dim random As New Random(), rndnbr As Integer
            Randomize()
            rndnbr = random.Next(1, totalCallout + 1)

            Dim étape = 1

            For Each Repertoires As DirectoryInfo In New DirectoryInfo(Application.StartupPath & "\callout\").GetDirectories()

                If étape = rndnbr Then
                    interChargé = Repertoires.Name
                End If


                étape = étape + 1

            Next

            log("UT Engine - Chargement de '" & Application.StartupPath & "\callout\" & interChargé & "\callout.ini" & "'")









            '////////////////////////// générer une adresse



            Dim typeLocalitéInter As String = Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "typeLocalité")

            Dim totalAdress As Integer



            Try
                totalAdress = Directory.EnumerateFiles(pluginLoaded & "\adress\" & typeLocalitéInter, "*").Count()
            Catch ex As Exception
                totalAdress = 0
                log("UT Engine - '" & pluginLoaded & "\adress\" & typeLocalitéInter & "' inexistant, appel non généré suite à l'absence d'adresses pour ce type d'intervention")
            End Try


            log("UT Engine - " & totalAdress & " adresses trouvés  répertoire '" & pluginLoaded & "\adress\" & typeLocalitéInter & "'")



            'si adresse existante pour le type de localité

            Dim adresschargé As String


            If totalAdress <> 0 Then


                Dim randomAdress As New Random(), rndnbrAdress As Integer
                Randomize()
                rndnbrAdress = random.Next(1, totalAdress + 1)

                Dim étapeAdress = 1

                For Each Fichier As FileInfo In New DirectoryInfo(pluginLoaded & "\adress\" & typeLocalitéInter & "\").GetFiles()

                    If étapeAdress = rndnbrAdress Then
                        adresschargé = Fichier.Name
                    End If


                    étapeAdress = étapeAdress + 1

                Next

                log("UT Engine - Chargement de '" & pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé & "'")


                accordAfficherInter = True



                'attribution des variables
                adresseAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "adresse")
                villeAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "commune")
                codePostalAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "codePostal")
                départementAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "département")
                paysAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "pays")
                urlImageAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "urlGoogleStreetView")
                latitudeAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "lat")
                longitudeAppel = Cls_Ini.INIRead(pluginLoaded & "\adress\" & typeLocalitéInter & "\" & adresschargé, "données", "lon")




                'affichage carte
                latInter = latitudeAppel
                lonInter = longitudeAppel
                zoom = 19
                game.modeInter = True
                cartevide()



            End If




            '//////////////////////////  afficher l'appel

            If accordAfficherInter = True Then

                log("UT Engine - Appel généré et affiché affiché")

                'nouvel appel

                game.PanelCallout.Visible = True
                game.Label6.Text = "Composition..."
                game.TimerSonnerieA.Enabled = True
                game.PictureBox3.Visible = False
                game.PictureBox4.Visible = False
                game.PictureBox5.Visible = False



                'affichage de l'icone selon le service
                If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "18" Then
                    game.PictureBox1.Image = My.Resources.sapeurs_pompiers
                    game.Label3.Text = "SAPEURS-POMPIERS"
                    game.Label2.Text = "CTA-CODIS"
                    home.PlayerRing.URL = Application.StartupPath & "\data\sound\18.wav"
                    home.PlayerRing.controls.play()
                End If
                If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "17" Then
                    game.PictureBox1.Image = My.Resources.police_secours
                    game.Label3.Text = "POLICE SECOURS"
                    game.Label2.Text = "CIC-COG"
                    home.PlayerRing.URL = Application.StartupPath & "\data\sound\17.wav"
                    home.PlayerRing.controls.play()
                End If
                If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "15" Then
                    game.PictureBox1.Image = My.Resources.samu
                    game.Label3.Text = "SAMU"
                    game.Label2.Text = "CRRA-CENTRE15"
                    home.PlayerRing.URL = Application.StartupPath & "\data\sound\15.wav"
                    home.PlayerRing.controls.play()
                End If



            End If



        Else
            msgtitre = "Vous n'avez installé aucune adresse pour ce département ou aucun appel." & Chr(13) & "Vous pouvez télécharger du contenu officiel depuis notre workshop, ou" & Chr(13) & "installer des adresses et appels de la communauté."
            msgInfo()
            log("UT Engine - Aucun appels installé ou répertoire '" & pluginLoaded & "\adress\" & " non créé")

        End If





    End Sub



End Module
