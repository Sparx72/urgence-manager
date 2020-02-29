Imports System.IO
Imports WMPLib

Public Class splash


    Private Sub splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load



        'création dossier log
        If System.IO.Directory.Exists(appdata) = False Then
            System.IO.Directory.CreateDirectory(appdata)
        End If

        'If System.IO.Directory.Exists(appdata & "logs\") = False Then
        'System.IO.Directory.CreateDirectory(appdata & "logs\")
        'End If


        console.Width = Me.Width
        log("Urgence Manager " & versionPublic & "(build " & buildPublic & ") - Initialisation" & vbCrLf)



        WebBrowser1.Navigate("http://urgence-manager.zd.fr/online/chargementTitre.txt")
        WebBrowser2.Navigate("http://urgence-manager.zd.fr/online/chargementContenu.txt")
        Timer1.Enabled = True






        'message accueil

        'affichage bonjour et bonsoir
        Dim bonjourBonsoir As String
        If DateTime.Now.ToString("HH") >= 2 And DateTime.Now.ToString("HH") < 5 Then
            bonjourBonsoir = "Bonne nuit "
        End If
        If DateTime.Now.ToString("HH") >= 5 And DateTime.Now.ToString("HH") < 19 Then
            bonjourBonsoir = "Bonjour"
        End If
        If DateTime.Now.ToString("HH") >= 19 And DateTime.Now.ToString("HH") < 0 Then
            bonjourBonsoir = "Bonsoir"
        End If
        If DateTime.Now.ToString("HH") >= 0 And DateTime.Now.ToString("HH") < 2 Then
            bonjourBonsoir = "Bonsoir"
        End If

        Dim nom As String
        If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "surname") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "firstname") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "pseudo") <> "" And Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "menuProfileDisplay") <> "" Then

            'afffichage profile
            If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "menuProfileDisplay") = "Name and firstname" Then
                nom = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "firstname") & " " & Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "surname")
            Else
                nom = Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "pseudo")
            End If
            Label1.Text = bonjourBonsoir & " " & nom & ", un instant"
        Else
            Label1.Text = bonjourBonsoir & " et bienvenue" & ", un instant"
        End If



    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False



        Label1.Text = "Initialisation d'UT Engine et de la reconnaissance vocale"



        'affichage écran de chargement
        Try
            chargementForm.FlatLabel2.Text = WebBrowser1.Document.Body.InnerText
            chargementForm.Label1.Text = WebBrowser2.Document.Body.InnerText
            chargementForm.FlatLabel3.Visible = True
        Catch ex As Exception

        End Try

        eXscriptNouveau()







        'création playlist music

        Try

            log("Chargement musique")

            home.PlayerMusic.currentPlaylist.clear()
            home.PlayerMusic.settings.setMode("shuffle", True)

            Dim étapeLecteur As Integer = 0
            For Each Fichiers As FileInfo In New DirectoryInfo(Application.StartupPath & "\music\").GetFiles()


                'si l'extension correspond
                If Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".mp3" Or Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".wma" Or Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".wav" Or Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".aac" Or Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".m4a" Or Path.GetExtension(Application.StartupPath & "\music\" & Fichiers.Name) = ".flac" Then
                    Dim Xwmp As WMPLib.IWMPMedia
                    Xwmp = home.PlayerMusic.newMedia(Application.StartupPath & "\music\" & Fichiers.Name)
                    home.PlayerMusic.currentPlaylist.insertItem(étapeLecteur, Xwmp)
                    étapeLecteur = étapeLecteur + 1
                End If



            Next

            home.PlayerMusic.settings.volume = 35


            home.PlayerMusic.controls.play()
            home.PlayerMusic.controls.next()
            home.PlayerMusic.controls.play()




            'audio pour sons


        Catch ex As Exception

            log("Erreur dans le changement de la musique : " & ex.Message)
            msgtitre = "Impossible de lire la musique en jeu" & Chr(13) & "Vérifier le contenu et l'existance du dossier '/music/'"
            msgInfo()

        End Try




    End Sub

End Class