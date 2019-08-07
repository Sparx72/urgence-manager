Imports System.Collections.Generic
Imports System.IO

Module gestionsDossiers

    Public Sub créerDossierBase()

        'suppression du cache
        My.Computer.FileSystem.DeleteDirectory(appdata & "cache\", FileIO.DeleteDirectoryOption.DeleteAllContents)

        'création des dossiers cache et game

        If System.IO.Directory.Exists(appdata) = False Then
            System.IO.Directory.CreateDirectory(appdata)
        End If

        If System.IO.Directory.Exists(appdata & "cache\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\")
        End If

        If System.IO.Directory.Exists(appdata & "mods\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "mods\")
        End If

        If System.IO.Directory.Exists(appdata & "cache\SGIA\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\")
        End If

        If System.IO.Directory.Exists(appdata & "game\") = False Then
            System.IO.Directory.CreateDirectory(appdata & "game\")
        End If



        'sous dossiers pour le SGIA
        If System.IO.Directory.Exists(appdata & "cache\SGIA\18") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\18")
        End If

        If System.IO.Directory.Exists(appdata & "cache\SGIA\17") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\17")
        End If

        If System.IO.Directory.Exists(appdata & "cache\SGIA\15") = False Then
            System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\15")
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
