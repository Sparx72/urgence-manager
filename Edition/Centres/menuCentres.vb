Imports System.IO
Public Class menuCentres

    Public centreAouvrir As String = ""
    Public typeCentreAouvrir As String

    Public Sub actualiserCentre()

        '///// Actualiser les centres

        Me.ListBox1.Items.Clear()
        Me.ListBox2.Items.Clear()
        Me.ListBox3.Items.Clear()
        Me.ListBox4.Items.Clear()
        Me.ListBox5.Items.Clear()
        Me.ListBox6.Items.Clear()

        ' liste les répertoires
        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()
            Me.ListBox1.Items.Add(Repertoires.Name)
        Next

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\fdo\").GetDirectories()
            Me.ListBox2.Items.Add(Repertoires.Name)
        Next

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\").GetDirectories()
            Me.ListBox3.Items.Add(Repertoires.Name)
        Next

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sc\").GetDirectories()
            Me.ListBox4.Items.Add(Repertoires.Name)
        Next

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\dir\").GetDirectories()
            Me.ListBox5.Items.Add(Repertoires.Name)
        Next

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\rdf\").GetDirectories()
            Me.ListBox6.Items.Add(Repertoires.Name)
        Next

    End Sub

    Public Sub ouvrirCentrePompiers()

        '//// Affiche le centre pompier
        centreIncendieSecours.Panel1.BackColor = Color.FromArgb(192, 0, 0)
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "Sapeurs-Pompiers - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        Dim type As String = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")
        If type = "Centre d'Incendie et de Secours (CIS)" Then
            centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "sous-type")
            centreIncendieSecours.ComboBox2.Items.Clear()
            centreIncendieSecours.ComboBox2.Enabled = True
            centreIncendieSecours.ComboBox2.Items.Add("Centre de Secours Principal (CSP)")
            centreIncendieSecours.ComboBox2.Items.Add("Centre de Secours (CS)")
            centreIncendieSecours.ComboBox2.Items.Add("Centre de Première Intervention (CPI)")

        Else
            centreIncendieSecours.ComboBox2.Items.Clear()
            centreIncendieSecours.ComboBox2.Enabled = False
            centreIncendieSecours.ComboBox2.Text = "DDIS ou CTA-CODIS"
        End If

        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Public Sub ouvrirCentrePolice()

        '//// Affiche le centre police
        centreIncendieSecours.Panel1.BackColor = Color.FromArgb(10, 10, 192)
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "Police / Gendarmerie - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        centreIncendieSecours.ComboBox2.Items.Clear()
        centreIncendieSecours.ComboBox2.Enabled = False
        centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")


        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Public Sub ouvrirCentreSAMU()

        '//// Affiche le centre samu ou hôpital ou ap
        centreIncendieSecours.Panel1.BackColor = Color.Orange
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "Médical - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        centreIncendieSecours.ComboBox2.Items.Clear()
        centreIncendieSecours.ComboBox2.Enabled = False
        centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")


        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Public Sub ouvrirCentreSC()

        '//// Affiche le centre sécurité civile ou association agrée
        centreIncendieSecours.Panel1.BackColor = Color.Orange
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "Sécurité Civile et Associations - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        centreIncendieSecours.ComboBox2.Items.Clear()
        centreIncendieSecours.ComboBox2.Enabled = False
        centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")


        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Public Sub ouvrirCentreDIR()

        '//// Affiche le centre DIR ou patrouilleurs
        centreIncendieSecours.Panel1.BackColor = Color.Orange
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "DIR ou patrouilleurs autoroutiers - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        centreIncendieSecours.ComboBox2.Items.Clear()
        centreIncendieSecours.ComboBox2.Enabled = False
        centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")


        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Public Sub ouvrirCentreRDF()

        '//// Affiche le centre ERDF ou GRDF
        centreIncendieSecours.Panel1.BackColor = Color.RoyalBlue
        centreIncendieSecours.PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "urlImage")
        centreIncendieSecours.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.Text = "ERDF et GRDF - " & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "nom")
        centreIncendieSecours.FlatLabel9.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lat")
        centreIncendieSecours.FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "lon")

        centreIncendieSecours.ComboBox2.Items.Clear()
        centreIncendieSecours.ComboBox2.Enabled = False
        centreIncendieSecours.ComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & centreAouvrir & "\" & centreAouvrir & ".ini", "données", "type")


        centreIncendieSecours.actualiserCIS()
        centreIncendieSecours.ShowDialog()

    End Sub


    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        'nouveau centre sapeurs pompiers

        nouveauCentre.ListBox1.Items.Clear()
        nouveauCentre.ListBox1.Items.Add("Centre d'Incendie et de Secours (CIS)")
        nouveauCentre.ListBox1.Items.Add("Direction Départementale d'Incendie et de Secours (DDIS)")
        nouveauCentre.ListBox1.Items.Add("Centre Opérationnel Départemental d'Incendie et de Secours (CTA-CODIS)")

        nouveauCentre.FlatLabel1.Text = "Nouveau Centre Sapeurs-Pompiers"
        nouveauCentre.Panel1.BackColor = Color.FromArgb(192, 0, 0)

        nouveauCentre.ShowDialog()

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click

        If ListBox1.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox1.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (pompiers)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If


                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox1.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()

    End Sub

    Private Sub FlatButton8_Click(sender As Object, e As EventArgs) Handles FlatButton8.Click

        If ListBox1.SelectedItem <> "" Then
            centreAouvrir = ListBox1.SelectedItem
            typeCentreAouvrir = "sp"
            ouvrirCentrePompiers()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If



    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

        'quand on change la sélection

        If ListBox1.SelectedItem <> "" Then

            FlatLabel12.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "nom")
            FlatLabel6.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "type")
            If FlatLabel6.Text = "Centre d'Incendie et de Secours (CIS)" Then
                FlatLabel6.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "sous-type")
            End If
            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel12.Text = "-"
            FlatLabel6.Text = "-"
            PictureBox1.ImageLocation = ""

        End If




    End Sub



    Private Sub ListBox2_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox2.SelectedIndexChanged

        'quand on change la sélection

        If ListBox2.SelectedItem <> "" Then

            FlatLabel32.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "nom")
            FlatLabel31.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "type")
            PictureBox3.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\fdo\" & ListBox2.SelectedItem & "\" & ListBox2.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel32.Text = "-"
            FlatLabel31.Text = "-"
            PictureBox3.ImageLocation = ""

        End If

    End Sub


    Private Sub ListBox3_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox3.SelectedIndexChanged

        'quand on change la sélection

        If ListBox3.SelectedItem <> "" Then

            FlatLabel24.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox3.SelectedItem & "\" & ListBox3.SelectedItem & ".ini", "données", "nom")
            FlatLabel23.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox3.SelectedItem & "\" & ListBox3.SelectedItem & ".ini", "données", "type")
            PictureBox2.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & ListBox3.SelectedItem & "\" & ListBox3.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel24.Text = "-"
            FlatLabel23.Text = "-"
            PictureBox2.ImageLocation = ""

        End If

    End Sub



    Private Sub ListBox4_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox4.SelectedIndexChanged

        'quand on change la sélection

        If ListBox4.SelectedItem <> "" Then

            FlatLabel40.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox4.SelectedItem & "\" & ListBox4.SelectedItem & ".ini", "données", "nom")
            FlatLabel39.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox4.SelectedItem & "\" & ListBox4.SelectedItem & ".ini", "données", "type")
            PictureBox4.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sc\" & ListBox4.SelectedItem & "\" & ListBox4.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel40.Text = "-"
            FlatLabel39.Text = "-"
            PictureBox4.ImageLocation = ""

        End If

    End Sub



    Private Sub ListBox5_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox5.SelectedIndexChanged

        'quand on change la sélection

        If ListBox5.SelectedItem <> "" Then

            FlatLabel48.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox5.SelectedItem & "\" & ListBox5.SelectedItem & ".ini", "données", "nom")
            FlatLabel47.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox5.SelectedItem & "\" & ListBox5.SelectedItem & ".ini", "données", "type")
            PictureBox5.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\dir\" & ListBox5.SelectedItem & "\" & ListBox5.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel48.Text = "-"
            FlatLabel47.Text = "-"
            PictureBox5.ImageLocation = ""

        End If

    End Sub




    Private Sub ListBox6_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles ListBox6.SelectedIndexChanged

        'quand on change la sélection

        If ListBox6.SelectedItem <> "" Then

            FlatLabel57.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox6.SelectedItem & "\" & ListBox6.SelectedItem & ".ini", "données", "nom")
            FlatLabel56.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox6.SelectedItem & "\" & ListBox6.SelectedItem & ".ini", "données", "type")
            PictureBox6.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\rdf\" & ListBox6.SelectedItem & "\" & ListBox6.SelectedItem & ".ini", "données", "urlImage")

        Else

            FlatLabel57.Text = "-"
            FlatLabel56.Text = "-"
            PictureBox6.ImageLocation = ""

        End If

    End Sub






    Private Sub FlatButton11_Click(sender As Object, e As EventArgs) Handles FlatButton11.Click


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
        nouveauCentre.Panel1.BackColor = Color.FromArgb(10, 10, 192)

        nouveauCentre.ShowDialog()


    End Sub

    Private Sub FlatButton9_Click(sender As Object, e As EventArgs) Handles FlatButton9.Click

        'nouveau centre SAMU


        nouveauCentre.ListBox1.Items.Clear()
        nouveauCentre.ListBox1.Items.Add("Service Mobile d'Urgence et de Réanimation (SMUR)")
        nouveauCentre.ListBox1.Items.Add("Centre Hospitalier (CH)")
        nouveauCentre.ListBox1.Items.Add("Société d'Ambulance Privée")
        nouveauCentre.ListBox1.Items.Add("Centre de Réception et de Régulation des Appels - Centre 15")

        nouveauCentre.FlatLabel1.Text = "Nouveau centre SAMU et Hôpitaux"
        nouveauCentre.Panel1.BackColor = Color.Orange

        nouveauCentre.ShowDialog()

    End Sub

    Private Sub FlatButton13_Click(sender As Object, e As EventArgs) Handles FlatButton13.Click

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
        nouveauCentre.Panel1.BackColor = Color.DarkOrange

        nouveauCentre.ShowDialog()


    End Sub

    Private Sub FlatButton15_Click(sender As Object, e As EventArgs) Handles FlatButton15.Click


        'nouveau dir et patrouilleur


        nouveauCentre.ListBox1.Items.Clear()
        nouveauCentre.ListBox1.Items.Add("Direction Interdépartementale des Routes (DIR)")
        nouveauCentre.ListBox1.Items.Add("Patrouilleur Autoroutier")

        nouveauCentre.FlatLabel1.Text = "Nouveau centre DIR et patrouilleurs autoroutier"
        nouveauCentre.Panel1.BackColor = Color.FromArgb(255, 128, 0)

        nouveauCentre.ShowDialog()

    End Sub

    Private Sub FlatButton18_Click(sender As Object, e As EventArgs) Handles FlatButton18.Click

        'nouveau erdf grdf


        nouveauCentre.ListBox1.Items.Clear()
        nouveauCentre.ListBox1.Items.Add("Électricité Réseau Distribution de France (ENEDIS)")
        nouveauCentre.ListBox1.Items.Add("Gaz Réseau Distribution de France (GRDF)")

        nouveauCentre.FlatLabel1.Text = "Nouveau centre ERDF (ENEDIS) et GRDF"
        nouveauCentre.Panel1.BackColor = Color.RoyalBlue

        nouveauCentre.ShowDialog()

    End Sub

    Private Sub FlatButton10_Click(sender As Object, e As EventArgs) Handles FlatButton10.Click


        If ListBox2.SelectedItem <> "" Then
            centreAouvrir = ListBox2.SelectedItem
            typeCentreAouvrir = "fdo"
            ouvrirCentrePolice()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click

        If ListBox3.SelectedItem <> "" Then
            centreAouvrir = ListBox3.SelectedItem
            typeCentreAouvrir = "samu"
            ouvrirCentreSAMU()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click


        'supprimer FDO

        If ListBox2.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox2.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (fdo)
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

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()


    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click


        'supprimer SAMU

        If ListBox3.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox3.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (samu)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & ListBox3.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\samu\" & ListBox3.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If


                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox3.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click


        'supprimer SC

        If ListBox4.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox4.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (sc)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & ListBox4.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\sc\" & ListBox4.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If


                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox4.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click


        'supprimer DIR

        If ListBox5.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox5.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (dir)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\dir\" & ListBox5.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\dir\" & ListBox5.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If


                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox5.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()

    End Sub

    Private Sub FlatButton16_Click(sender As Object, e As EventArgs) Handles FlatButton16.Click


        'supprimer RDF

        If ListBox6.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer ce centre ?", "Suppression d'un centre", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données (moyens, personnels...) du centre [" & ListBox6.SelectedItem & "] seront définitivements supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression du centre (rdf)
                        If Directory.Exists(appdata & "game\" & partieEnCours & "\rdf\" & ListBox6.SelectedItem) Then
                            My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & partieEnCours & "\rdf\" & ListBox6.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        End If


                        actualiserCentre()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression du centre " & ListBox6.SelectedItem & " / " & ex.ToString
                        rapportErreur()
                        actualiserCentre()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une partie pour la supprimer", MsgBoxStyle.Critical)
        End If

        actualiserCentre()


    End Sub

    Private Sub FlatButton12_Click(sender As Object, e As EventArgs) Handles FlatButton12.Click

        If ListBox4.SelectedItem <> "" Then
            centreAouvrir = ListBox4.SelectedItem
            typeCentreAouvrir = "sc"
            ouvrirCentreSC()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub FlatButton14_Click(sender As Object, e As EventArgs) Handles FlatButton14.Click

        If ListBox5.SelectedItem <> "" Then
            centreAouvrir = ListBox5.SelectedItem
            typeCentreAouvrir = "dir"
            ouvrirCentreDIR()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub FlatButton17_Click(sender As Object, e As EventArgs) Handles FlatButton17.Click

        If ListBox6.SelectedItem <> "" Then
            centreAouvrir = ListBox6.SelectedItem
            typeCentreAouvrir = "RDF"
            ouvrirCentreRDF()
        Else
            MsgBox("Vous devez sélectionner un centre pour l'ouvrir", MsgBoxStyle.Exclamation)
        End If

    End Sub


    Private Sub menuCentres_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class