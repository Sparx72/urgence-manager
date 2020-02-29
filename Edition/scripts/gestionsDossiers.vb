Imports System.Collections.Generic
Imports System.IO

Module gestionsDossiers

    Public Sub créerDossierBase()


        Dim supressionOk As Boolean = False

        While supressionOk = False

            'suppression du cache
            Try
                If System.IO.Directory.Exists(appdata & "cache\") = True Then
                    My.Computer.FileSystem.DeleteDirectory(appdata & "cache\", FileIO.DeleteDirectoryOption.DeleteAllContents)
                End If
                supressionOk = True
                log("Cache supprimé")
            Catch ex As Exception
                log("Erreur supression cache - " & ex.Message)
                messageErreur = "Les dossiers du jeu sont ouvert dans l'explorateur Windows, ou l'un des fichiers du jeu est en cours de modification dans un autre logiciel. Vous devez les fermer pour jouer à Alerte d'Urgence 2020"
                rapportErreur()
            End Try

        End While
        

        

        'création des dossiers cache et game

        If System.IO.Directory.Exists(appdata) = False Then
            System.IO.Directory.CreateDirectory(appdata)
        End If

        If System.IO.Directory.Exists(appdata & "cache\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\")
        End If

        If System.IO.Directory.Exists(appdata & "workshop\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "workshop\")
        End If

        If System.IO.Directory.Exists(appdata & "cache\UTEngine\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\")
        End If

        If System.IO.Directory.Exists(appdata & "game\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "game\")
        End If

        If System.IO.Directory.Exists(appdata & "settings\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "settings\")
        End If

        Dim f As New DirectoryInfo(appdata & "settings\")
        f.Attributes = FileAttributes.Hidden



        'sous dossiers pour le SGIA
        If System.IO.Directory.Exists(appdata & "cache\UTEngine\18") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\18")
        End If

        If System.IO.Directory.Exists(appdata & "cache\UTEngine\17") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\17")
        End If

        If System.IO.Directory.Exists(appdata & "cache\UTEngine\15") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\15")
        End If



        'sous dossier workshop

        If System.IO.Directory.Exists(appdata & "workshop\callout") = False Then
            System.IO.Directory.CreateDirectory(appdata & "workshop\callout")
        End If

        If System.IO.Directory.Exists(appdata & "workshop\adress") = False Then
            System.IO.Directory.CreateDirectory(appdata & "workshop\adress")
        End If

    End Sub



    Public Sub actualiserPartie()

        lancerJeuLibreSolo.ListBox1.Items.Clear()
        gestionParties.ListBox1.Items.Clear()


        ' liste les répertoires
        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\").GetDirectories()
            lancerJeuLibreSolo.ListBox1.Items.Add(Repertoires.Name) ' le "\" pour différencier visuellement répertoires et fichiers dans la listbox
            gestionParties.ListBox1.Items.Add(Repertoires.Name)
        Next



    End Sub

End Module
