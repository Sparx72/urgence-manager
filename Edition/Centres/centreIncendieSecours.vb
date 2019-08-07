Imports System.IO

Public Class centreIncendieSecours

    Public Sub actualiserCIS()

        Me.ListBox1.Items.Clear()


        If menuCentres.typeCentreAouvrir = "sp" Then
            ' SP
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

        If menuCentres.typeCentreAouvrir = "fdo" Then
            ' FDO
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

        If menuCentres.typeCentreAouvrir = "samu" Then
            ' FDO
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

        If menuCentres.typeCentreAouvrir = "sc" Then
            ' SAMU
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

        If menuCentres.typeCentreAouvrir = "dir" Then
            ' DIR
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

        If menuCentres.typeCentreAouvrir = "rdf" Then
            ' DIR
            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\").GetFiles()
                Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & Fichier.Name, "données", "nom"))
            Next
        End If

    End Sub
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click


        If menuCentres.typeCentreAouvrir = "sp" Then


            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "sous-type", ComboBox2.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")

            ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "sous-type")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If



        If menuCentres.typeCentreAouvrir = "fdo" Then



            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If



        If menuCentres.typeCentreAouvrir = "samu" Then



            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If




        If menuCentres.typeCentreAouvrir = "sc" Then



            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If




        If menuCentres.typeCentreAouvrir = "dir" Then



            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If





        If menuCentres.typeCentreAouvrir = "dir" Then



            'modification des infos
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "nom", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage", TextBox1.Text)

            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")
            TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\" & menuCentres.centreAouvrir & ".ini", "données", "urlImage")


            'si il faut renommer
            If TextBox4.Text <> menuCentres.centreAouvrir Then

                MsgBox("En raison du changement de nom de ce centre, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameDirectory(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir, TextBox4.Text)
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & menuCentres.centreAouvrir & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If


        End If





        menuCentres.actualiserCentre()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click


        'SP

        If menuCentres.typeCentreAouvrir = "sp" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouvel engin Sapeur-Pompier"
            nouveauVéhicule.Panel1.BackColor = Color.FromArgb(192, 0, 0)

            véhiculeSP()
            nouveauVéhicule.ShowDialog()

        End If


        'FDO

        If menuCentres.typeCentreAouvrir = "fdo" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouveau véhicule Police/Gendarmerie"
            nouveauVéhicule.Panel1.BackColor = Color.FromArgb(10, 10, 192)

            véhiculeFDO()
            nouveauVéhicule.ShowDialog()

        End If


        'SAMU

        If menuCentres.typeCentreAouvrir = "samu" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouveau véhicule Médical"
            nouveauVéhicule.Panel1.BackColor = Color.Orange

            véhiculeSAMU()
            nouveauVéhicule.ShowDialog()

        End If



        'SC

        If menuCentres.typeCentreAouvrir = "sc" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouveau véhicule de Sécurité Civile ou d'une Association Agrée"
            nouveauVéhicule.Panel1.BackColor = Color.DarkOrange

            véhiculeSC()
            nouveauVéhicule.ShowDialog()

        End If


        'DIR

        If menuCentres.typeCentreAouvrir = "dir" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouveau véhicule DIR ou patrouilleur autoroutier"
            nouveauVéhicule.Panel1.BackColor = Color.FromArgb(255, 128, 0)

            véhiculeDIR()
            nouveauVéhicule.ShowDialog()

        End If



        'RDF

        If menuCentres.typeCentreAouvrir = "rdf" Then

            nouveauVéhicule.FlatLabel1.Text = "Nouveau véhicule ERDF (ENEDIS) ou GRDF"
            nouveauVéhicule.Panel1.BackColor = Color.RoyalBlue

            véhiculeRDF()
            nouveauVéhicule.ShowDialog()

        End If



    End Sub


    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click


        If ListBox1.SelectedItem = "" Then

            MsgBox("Vous devez sélectionner un véhicule pour la supprimer", MsgBoxStyle.Critical)

        End If


        If ListBox1.SelectedItem <> "" And menuCentres.typeCentreAouvrir = "sp" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce véhicule ?", "Suppression d'un véhicule", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données du véhicule [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini") Then
                            My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini")
                        End If


                        actualiserCIS()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du véhicule " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCIS()
                    End Try

                End If

            End If
        End If




        If ListBox1.SelectedItem <> "" And menuCentres.typeCentreAouvrir = "samu" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce véhicule ?", "Suppression d'un véhicule", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données du véhicule [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If File.Exists(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini") Then
                            My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini")
                        End If


                        actualiserCIS()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du véhicule " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCIS()
                    End Try

                End If

            End If
        End If



        If ListBox1.SelectedItem <> "" And menuCentres.typeCentreAouvrir = "sc" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce véhicule ?", "Suppression d'un véhicule", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données du véhicule [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If File.Exists(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini") Then
                            My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini")
                        End If


                        actualiserCIS()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du véhicule " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCIS()
                    End Try

                End If

            End If
        End If



        If ListBox1.SelectedItem <> "" And menuCentres.typeCentreAouvrir = "dir" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce véhicule ?", "Suppression d'un véhicule", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données du véhicule [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If File.Exists(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini") Then
                            My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini")
                        End If


                        actualiserCIS()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du véhicule " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCIS()
                    End Try

                End If

            End If
        End If



        If ListBox1.SelectedItem <> "" And menuCentres.typeCentreAouvrir = "rdf" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce véhicule ?", "Suppression d'un véhicule", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données du véhicule [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If File.Exists(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini") Then
                            My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini")
                        End If


                        actualiserCIS()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du véhicule " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCIS()
                    End Try

                End If

            End If
        End If


        





        actualiserCIS()

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click


        If ListBox1.SelectedItem = "" Then

            MsgBox("Vous devez sélectioner un véhicule")

        Else



            'SP

            If menuCentres.typeCentreAouvrir = "sp" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel12.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "type")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.FromArgb(192, 0, 0)

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                résumé_véhicule.ShowDialog()

            End If


            'FDO

            If menuCentres.typeCentreAouvrir = "fdo" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.FromArgb(10, 10, 192)

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                résumé_véhicule.ShowDialog()

            End If


            'SAMU

            If menuCentres.typeCentreAouvrir = "samu" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel12.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "type")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.Orange

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                résumé_véhicule.ShowDialog()

            End If



            'SC

            If menuCentres.typeCentreAouvrir = "sc" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.DarkOrange

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                résumé_véhicule.ShowDialog()

            End If


            'DIR

            If menuCentres.typeCentreAouvrir = "dir" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.FromArgb(255, 128, 0)

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                nouveauVéhicule.ShowDialog()

            End If



            'RDF

            If menuCentres.typeCentreAouvrir = "rdf" Then

                résumé_véhicule.Text = Me.Text
                résumé_véhicule.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")
                résumé_véhicule.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nom")
                résumé_véhicule.FlatLabel3.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "date")
                résumé_véhicule.FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "nbpersonnel")
                résumé_véhicule.Panel1.BackColor = Color.RoyalBlue

                Dim étape As Integer = 1
                résumé_véhicule.ListBox1.Items.Clear()
                While Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape) <> ""
                    résumé_véhicule.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & menuCentres.centreAouvrir & "\engins\" & ListBox1.SelectedItem & ".ini", "données", "pers" & étape))
                    étape = étape + 1
                End While

                résumé_véhicule.ShowDialog()

            End If


        End If


        







    End Sub

End Class