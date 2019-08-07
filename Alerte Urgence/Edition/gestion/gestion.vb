Public Class gestion

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Try

            'département
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département", FlatComboBox2.Text)

            'validation latitude et longitude et zoom
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat", TextBox1.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom", FlatNumeric1.Value)

            'validation carte
            If FlatComboBox1.Text = "Mapbox streets-satellite" Then
                Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "sat")
            End If
            If FlatComboBox1.Text = "OSM France" Then
                Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "OSM")
            End If


            'afficher coordonnées GPS
            If FlatCheckBox1.Checked = True Then
                Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick", "oui")
            Else
                Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick", "non")
            End If



            cartevide()
            scriptStatutBar()

            Form1.FlatAlertBox1.Visible = True
            Form1.FlatAlertBox1.Text = "Modifications effectuées"
            Form1.TimerAlertBox.Enabled = True
        Catch ex As Exception
            messageErreur = "Impossible d'enregistrer les coordonnées GPS dans le fichier ini de la partie"
            erreur.ShowDialog()
        End Try
        



    End Sub


    Private Sub FlatCheckBox1_CheckedChanged(ByVal sender As System.Object)

    End Sub
End Class
