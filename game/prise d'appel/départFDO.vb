Imports System.IO
Imports System.Globalization

Public Class départFDO

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        actualiserFDO()

    End Sub



    Public Sub actualiserFDO()

        ListBox1.Items.Clear()
        ListBox1.UseCustomTabOffsets = True
        ListBox1.CustomTabOffsets.Add(40)
        ListBox1.CustomTabOffsets.Add(60)
        ListBox1.CustomTabOffsets.Add(160)



        Try

        


        For Each Repertoires As DirectoryInfo In New DirectoryInfo(pluginLoaded & "\center\fdo\").GetDirectories()



            'prend en compte la distance

            Dim ciClone As CultureInfo = CType(CultureInfo.InvariantCulture.Clone(), CultureInfo)
            ciClone.NumberFormat.NumberDecimalSeparator = "."

            Dim lat_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(pluginLoaded & "\center\fdo\" & Repertoires.Name & "\center.ini", "info", "lat"), ciClone)
            Dim lon_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(pluginLoaded & "\center\fdo\" & Repertoires.Name & "\center.ini", "info", "lon"), ciClone)


            Dim lat_a As Double = (Math.PI * lat_centre) / 180
            Dim lon_a As Double = (Math.PI * lon_centre) / 180

            Dim lat_b As Double = (Math.PI * Convert.ToDouble(latitudeAppel, ciClone)) / 180
            Dim lon_b As Double = (Math.PI * Convert.ToDouble(longitudeAppel, ciClone)) / 180


            Dim d As Double = 6378000 * (Math.PI / 2 - Math.Asin(Math.Sin(lat_b) * Math.Sin(lat_a) + Math.Cos(lon_b - lon_a) * Math.Cos(lat_b) * Math.Cos(lat_a)))
            d = d / 1000
            d = Math.Round(d, 1, MidpointRounding.AwayFromZero)

            Dim resultat As String
            If d < 10 Then
                resultat = "00" & d
            ElseIf d < 100 And d >= 10 Then
                resultat = "0" & d
            Else
                resultat = d
            End If



            'essai de lire le dossier moyens

            If d < 1000 Then
                Try
                    For Each Fichier As FileInfo In New DirectoryInfo(pluginLoaded & "\center\fdo\" & Repertoires.Name & "\moyens\").GetFiles()
                            ListBox1.Items.Add(resultat & " km" & vbTab & "FDO" & vbTab & Repertoires.Name & vbTab & Cls_Ini.INIRead(pluginLoaded & "\center\fdo\" & Repertoires.Name & "\moyens\" & Fichier.Name, "info", "name"))
                    Next
                Catch ex As Exception

                        msgtitre = "Nous sommes désolée mais une erreur c'est produite lorsque nous avons tenté d'accéder" & Chr(13) & "à la liste des moyens du plugin actuel. Il s'agit probablement d'une erreur lors du" & Chr(13) & "développement du plugin et il n'y a rien que vous puissiez faire pour corriger celà." & Chr(13) & "Essayer de contacter le créateur du plugin pour qu'il puisse être avisé du problème."
                        msgInfo()

                End Try
            End If




            ListBox1.Sorted = True


        Next


        Catch ex As Exception

            msgtitre = "Nous sommes désolée mais une erreur c'est produite lorsque nous avons tenté d'accéder" & Chr(13) & "à la liste des centres du plugin actuel. Il s'agit probablement d'une erreur lors du" & Chr(13) & "développement du plugin et il n'y a rien que vous puissiez faire pour corriger celà." & Chr(13) & "Essayer de contacter le créateur du plugin pour qu'il puisse être avisé du problème."
            msgInfo()
        End Try

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Try
            If votreDépart.ListBox1.FindString(ListBox1.SelectedItem) = ListBox.NoMatches Then
                votreDépart.ListBox1.Items.Add(ListBox1.SelectedItem)
                game.FlatButton9.Text = "Votre départ (" & votreDépart.ListBox1.Items.Count & ")"
                playFxUi()

                game.Panel7.Visible = True
                game.Label8.Text = "Moyen ajouté à votre liste de départ"
                game.TimerInfo.Enabled = True
            Else
                msgtitre = "Ce moyen est déjà présent dans votre liste de départ"
                msgOui = "Afficher mon départ"
                msgNon = "Annuler et continuer"
                msgOuiNon()
                If msgRésultat = "oui" Then
                    votreDépart.TopLevel = False
                    game.Panel4.Controls.Clear()
                    game.Panel4.Controls.Add(votreDépart)
                    votreDépart.Show()
                End If
            End If


        Catch ex As Exception
            msgtitre = "Sélectionner un moyen dans la liste pour l'ajouter à votre départ"
            msgInfo()
        End Try

    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        votreDépart.TopLevel = False
        game.Panel4.Controls.Clear()
        game.Panel4.Controls.Add(votreDépart)
        votreDépart.Show()
    End Sub
End Class