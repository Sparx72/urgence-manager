Imports System.IO

Public Class centreIncendieSecours



    Public Sub actualiserCentre()

        If FlatComboBox1.Text = "Sapeurs-Pompiers" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If

        If FlatComboBox1.Text = "Police / Gendarmerie" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\fdo\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If


        If FlatComboBox1.Text = "SAMU / Ambulances privées" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If


        If FlatComboBox1.Text = "Sécurité Civile / associations agréées" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sc\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If


        If FlatComboBox1.Text = "DIR / Patrouilleurs" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\dir\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If

        If FlatComboBox1.Text = "ENEDIS / GRDF" Then
            ListBox2.Items.Clear()
            For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\rdf\").GetDirectories()
                Me.ListBox2.Items.Add(Repertoires.Name)
            Next
        End If

    End Sub


    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub FlatButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton12.Click
        Me.Close()
    End Sub

    Private Sub FlatComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatComboBox1.SelectedIndexChanged

        actualiserCentre()

    End Sub

    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox2.SelectedIndexChanged



        'SI SAPEURS POMPIER

        If FlatComboBox1.Text = "Sapeurs-Pompiers" Then



            '//// Affiche le centre pompier
            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "sous-type")


        End If




        'SI POLICE GENDARMERIE

        If FlatComboBox1.Text = "Police / Gendarmerie" Then

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")

        End If


        'SI SAMU AMBULANCES


        If FlatComboBox1.Text = "SAMU / Ambulances privées" Then

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")

        End If

        'SI SÉCURITÉ CIVILE

        If FlatComboBox1.Text = "Sécurité Civile / associations agréées" Then

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")

        End If

        'SI DIR PATROUILLEURS

        If FlatComboBox1.Text = "DIR / Patrouilleurs" Then

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")

        End If

        'SI ENEDIS / GRDF

        If FlatComboBox1.Text = "ENEDIS / GRDF" Then

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")
            TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lat")
            FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "lon")
            FlatLabel2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")

        End If

        afficherCarteCentre()


    End Sub

    Private Sub FlatLabel2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel2.TextChanged

        ToolTip1.SetToolTip(FlatLabel2, FlatLabel2.Text)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        ToolTip1.SetToolTip(TextBox1, TextBox1.Text & Chr(13) & "Vous pouvez utiliser une image locale de votre ordinateur ou saisir l'URL d'une image Internet")

    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click


        If FlatComboBox1.Text = "Sapeurs-Pompiers" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\sp\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If



        If FlatComboBox1.Text = "Police / Gendarmerie" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If



        If FlatComboBox1.Text = "SAMU / Ambulances privées" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\samu\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If



        If FlatComboBox1.Text = "Sécurité Civile / associations agréées" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\sc\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If


        If FlatComboBox1.Text = "DIR / Patrouilleurs" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\dir\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If



        If FlatComboBox1.Text = "ENEDIS / GRDF" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then

                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\rdf\" & ListBox2.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If

                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox2.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try

                End If
            End If
        End If


    End Sub

    Private Sub FlatButton20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton20.Click



        If FlatComboBox1.Text = "Sapeurs-Pompiers" Then

            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Centre d'Incendie et de Secours (CIS)")
            nouveauCentre.ListBox1.Items.Add("Direction Départementale d'Incendie et de Secours (DDIS)")
            nouveauCentre.ListBox1.Items.Add("Centre Opérationnel Départemental d'Incendie et de Secours (CTA-CODIS)")

            nouveauCentre.FlatLabel1.Text = "Nouveau Centre Sapeurs-Pompiers"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If



        If FlatComboBox1.Text = "Police / Gendarmerie" Then

            'nouveau centre police gendarmerie


            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Hôtel de Police")
            nouveauCentre.ListBox1.Items.Add("Commissariat de Police Nationale")
            nouveauCentre.ListBox1.Items.Add("Bureau de Police Municipale")
            nouveauCentre.ListBox1.Items.Add("Brigade de Gendarmerie")
            nouveauCentre.ListBox1.Items.Add("Brigade Rapide d'Intervention (BRI)")
            nouveauCentre.ListBox1.Items.Add("Antenne GIGN")
            nouveauCentre.ListBox1.Items.Add("Peloton de surveillance et d'intervention de la Gendarmerie (PSIG)")
            nouveauCentre.ListBox1.Items.Add("Antenne RAID")
            nouveauCentre.ListBox1.Items.Add("Centre d'Information et de Commandement (CIC)")
            nouveauCentre.ListBox1.Items.Add("Centre Opérationnel de Gendarmerie (COG)")

            nouveauCentre.FlatLabel1.Text = "Nouveau centre Police ou Gendarmerie"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If


        If FlatComboBox1.Text = "SAMU / Ambulances privées" Then

            'nouveau centre SAMU


            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Service Mobile d'Urgence et de Réanimation (SMUR)")
            nouveauCentre.ListBox1.Items.Add("Centre Hospitalier (CH)")
            nouveauCentre.ListBox1.Items.Add("Société d'Ambulance Privée")
            nouveauCentre.ListBox1.Items.Add("Centre de Réception et de Régulation des Appels - Centre 15")

            nouveauCentre.FlatLabel1.Text = "Nouveau centre SAMU et Hôpitaux"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If


        If FlatComboBox1.Text = "Sécurité Civile / associations agréées" Then

            'nouveau sécurité civile et associations agrées


            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Unité d'Instruction et d'Intervention de la Sécurité-Civile (UIISC)")
            nouveauCentre.ListBox1.Items.Add("Base d'Avions de la Sécurité Civile (BASC)")
            nouveauCentre.ListBox1.Items.Add("Groupement d'Hélicoptères de la Sécurité Civile (GHSC)")
            nouveauCentre.ListBox1.Items.Add("Réserves communales de sécurité civile (RCSC)")
            nouveauCentre.ListBox1.Items.Add("Croix Rouge Française (CRF)")
            nouveauCentre.ListBox1.Items.Add("Association Départementale de Protection Civile (ADPC)")
            nouveauCentre.ListBox1.Items.Add("Société Nationale de Sauvetage en Mer (SNSM)")

            nouveauCentre.FlatLabel1.Text = "Nouveau centre Sécurité Civile ou association agréée"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If


        If FlatComboBox1.Text = "DIR / Patrouilleurs" Then

            'nouveau dir et patrouilleur


            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Direction Interdépartementale des Routes (DIR)")
            nouveauCentre.ListBox1.Items.Add("Patrouilleur Autoroutier")

            nouveauCentre.FlatLabel1.Text = "Nouveau centre DIR et patrouilleurs autoroutier"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If


        If FlatComboBox1.Text = "ENEDIS / GRDF" Then

            'nouveau erdf grdf


            nouveauCentre.ListBox1.Items.Clear()
            nouveauCentre.ListBox1.Items.Add("Électricité Réseau Distribution de France (ENEDIS)")
            nouveauCentre.ListBox1.Items.Add("Gaz Réseau Distribution de France (GRDF)")

            nouveauCentre.FlatLabel1.Text = "Nouveau centre ERDF (ENEDIS) et GRDF"

            nouveauCentre.carteVideNouveauCentre()
            nouveauCentre.ShowDialog()

        End If



    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        If ListBox2.SelectedItem <> "" Then


            If FlatComboBox1.Text = "Sapeurs-Pompiers" Then

                vehicules.centreVehicule = "/sp/" & ListBox2.SelectedItem & "/engins/"

            End If



            If FlatComboBox1.Text = "Police / Gendarmerie" Then

                vehicules.centreVehicule = "/fdo/" & ListBox2.SelectedItem & "/engins/"

            End If


            If FlatComboBox1.Text = "SAMU / Ambulances privées" Then

                vehicules.centreVehicule = "/samu/" & ListBox2.SelectedItem & "/engins/"

            End If


            If FlatComboBox1.Text = "Sécurité Civile / associations agréées" Then

                vehicules.centreVehicule = "/sc/" & ListBox2.SelectedItem & "/engins/"

            End If


            If FlatComboBox1.Text = "DIR / Patrouilleurs" Then

                vehicules.centreVehicule = "/dir/" & ListBox2.SelectedItem & "/engins/"

            End If


            If FlatComboBox1.Text = "ENEDIS / GRDF" Then

                vehicules.centreVehicule = "/rdf/" & ListBox2.SelectedItem & "/engins/"

            End If

            vehicules.actualiserVehicule()
            vehicules.FlatLabel1.Text = FlatLabel1.Text
            vehicules.ShowDialog()



        End If


        

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        actualiserCentre()

    End Sub
End Class