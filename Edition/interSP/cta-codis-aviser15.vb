Imports System.IO
Imports System.Globalization

Public Class cta_codis_aviser15


    Public Sub actualiserListeEngagementSP()

        'permet d'actualiser les véhicules
        ListBox2.Items.Clear()
        For Each Fichiers As FileInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\").GetFiles
            ListBox2.Items.Add(Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichiers.Name, "données", "nom"))
        Next

    End Sub


    Public Sub actualiserMoyenSMUR()

        ListBox1.Items.Clear()
        ListBox1.UseCustomTabOffsets = True
        ListBox1.CustomTabOffsets.Add(45)
        ListBox1.CustomTabOffsets.Add(200)

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\").GetDirectories()



            'prend en compte la distance

            Dim ciClone As CultureInfo = CType(CultureInfo.InvariantCulture.Clone(), CultureInfo)
            ciClone.NumberFormat.NumberDecimalSeparator = "."

            Dim lat_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat"), ciClone)
            Dim lon_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon"), ciClone)


            Dim lat_a As Double = (Math.PI * lat_centre) / 180
            Dim lon_a As Double = (Math.PI * lon_centre) / 180

            Dim lat_b As Double = (Math.PI * Convert.ToDouble(latitudeAppel, ciClone)) / 180
            Dim lon_b As Double = (Math.PI * Convert.ToDouble(longitudeAppel, ciClone)) / 180


            Dim d As Double = 6378000 * (Math.PI / 2 - Math.Asin(Math.Sin(lat_b) * Math.Sin(lat_a) + Math.Cos(lon_b - lon_a) * Math.Cos(lat_b) * Math.Cos(lat_a)))
            d = d / 1000
            d = Math.Round(d, 1, MidpointRounding.AwayFromZero)

            Dim resultat As String
            If d < 10 Then resultat = "0" & d Else resultat = d



            'essai de lire le dossier engin sinon le créer

            If d < 100 Then

                Try
                    For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\engins\").GetFiles()
                        ListBox1.Items.Add(resultat & " km" & vbTab & Repertoires.Name & vbTab & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\engins\" & Fichier.Name, "données", "nom"))
                    Next
                Catch ex As Exception

                    System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\engins\")
                    messageErreur = "Les fichiers du centre " & Repertoires.Name & " sont corrompus, des modifications ont été éffectuées. Vous pouvez normalement cliquer sur ""Tenter de continuer""."
                    rapportErreur()

                End Try


                ListBox1.Sorted = True

            End If


        Next


        'afficher un message si pas d'engins
        If ListBox1.Items.Count = 0 Then
            msgtitre = "Il y a aucun SMUR disponible dans un rayon de 100 km. Vérifier que vous avez" & Chr(13) & "bien des centres dans le département que vous gérez ou cliquez sur ""Afficher" & Chr(13) & "tout les engins disponible"""
            msgInfo()
        End If




    End Sub


    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Me.Close()

    End Sub

    Private Sub FlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton7.Click

        actualiserMoyenSMUR()

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click

        'valider ce véhicule

        Dim donnée As String = ListBox1.SelectedItem


        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()

            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\").GetFiles()

                If donnée.Contains(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\" & Fichier.Name, "données", "nom")) And donnée.Contains(Repertoires.Name) Then

                    'récupérer la distance
                    Dim distance As String = ListBox1.SelectedItem
                    distance = Split(distance, " km")(0)



                    'si le véhicule existe l'ajouter

                    My.Computer.FileSystem.CopyFile(appdata & "game\" & partieEnCours & "\samu\" & Repertoires.Name & "\engins\" & Fichier.Name, appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichier.Name, overwrite:=True)

                    Dim temps As Double = Math.Round((distance * coefVitesseSP) * 60, 0, MidpointRounding.AwayFromZero)
                    Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichier.Name, "données", "temps", temps)

                    actualiserListeEngagementSP()


                End If


            Next


        Next

    End Sub

    Private Sub cta_codis_aviser15_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class