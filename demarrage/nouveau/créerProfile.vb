Imports System.IO

Public Class créerProfile

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged

        If TextBox1.Text <> "" And TextBox2.Text <> "" Then

            FlatLabel2.Text = TextBox2.Text.ToUpper & " " & TextBox1.Text.ToUpper

        Else

            FlatLabel2.Text = "MON OPÉRATEUR"

        End If


    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click


        log("Ouverture OpenfileDialog pour importation photo ou image de profile opérateur")



        OpenFileDialog1.Filter = "Images compatibles|*.jpg; *.jpeg; *.png"
        OpenFileDialog1.Title = "Choisr une photo ou un logo - Urgence Manager"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = DialogResult.OK then
            'Do things here, the path is stored in openFileDialog1.Filename
            'If no files were selected, openFileDialog1.Filename is ""  

            PictureBox2.ImageLocation = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click


        My.Computer.Audio.Play(My.Resources.uiMsg, AudioPlayMode.Background)

        'vérification données completées
        If TextBox1.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" And FlatComboBox1.Text <> "" And FlatComboBox2.Text <> "" Then



            'si complet

            msgtitre = "Avez vous terminé la création de votre opérateur ?"
            msgOui = "Enregistrer les modifications et continuer"
            msgNon = "Continuer à modfier"

            msgOuiNon()



            If msgRésultat = "oui" Then

                'création du profile
                log("Création du profile")

                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "surname", TextBox1.Text)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "firstname", TextBox2.Text)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "pseudo", TextBox3.Text)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "gender", FlatComboBox2.Text)

                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "birthDD", FlatNumeric1.Value)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "birthMM", FlatNumeric2.Value)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "birthYYYY", FlatNumeric3.Value)

                If FlatComboBox1.Text = "Nom et prénom" Then
                    Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "menuProfileDisplay", "Name and firstname")
                Else
                    Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "menuProfileDisplay", "pseudo")
                End If


                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "image", PictureBox2.ImageLocation)


                log("Profile créé")


                My.Computer.Audio.Play(My.Resources.uiMsg, AudioPlayMode.Background)
                msgtitre = "Votre opérateur " & TextBox2.Text & " " & TextBox1.Text & " à été créé avec succès." & Chr(13) & "Vous êtes désormais prêt(e) à vous lancer dans Urgence Manager." & Chr(13) & "L'ensemble des données de jeu (opérateur, stats, succès...) restent sur ce PC" & Chr(13) & "et ne sont pas transmis à nos serveurs. Pensez à effectuer régulièrement des" & Chr(13) & "sauvegardes ou à configurer un emplacement de sauvegarde en ligne."
                msgInfo()

                scriptNouveau.eXscriptNouveau()



            End If



            Else

                msgtitre = "Certains champs n'ont pas été completés"
                msgInfo()

            End If









    End Sub


End Class