Imports System.IO

Public Class monOpérateur

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

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
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
            msgOui = "Enregistrer les modifications et fermer"
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
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "birthMM", FlatNumeric1.Value)
                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "birthYYYY", FlatNumeric1.Value)

                If FlatComboBox1.Text = "Nom et prénom" Then
                    Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "menuProfileDisplay", "Name and firstname")
                Else
                    Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "menuProfileDisplay", "pseudo")
                End If


                Cls_Ini.INIWrite(appdata & "settings/settings.ini", "profile", "image", PictureBox2.ImageLocation)


                log("Profile modifié")




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



            End If



        Else

            msgtitre = "Certains champs n'ont pas été completés"
            msgInfo()

        End If









    End Sub


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click


        'retour

        playFxMsg()
        msgtitre = "Les modifications apportées ne seront pas enregistrées"
        msgOui = "Ignorer les modifications"
        msgNon = "Continuer à modfier"

        msgOuiNon()


        If msgRésultat = "oui" Then


            menuBienvenue.TopLevel = False
            home.Panel1.Controls.Clear()
            home.Panel1.Controls.Add(menuBienvenue)
            menuBienvenue.Show()


        End If


    End Sub
End Class