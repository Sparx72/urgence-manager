Imports System.IO

Module gestionGlobal

    Public Sub scriptStatutBar()



        'département
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département") = "" Then
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département", "75 Paris")
        End If
        Dim département As String = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département")

        'inters en cours
        Dim nbDossier = System.IO.Directory.GetDirectories(appdata & "cache\SGIA\18\").Count + System.IO.Directory.GetDirectories(appdata & "cache\SGIA\17\").Count + System.IO.Directory.GetDirectories(appdata & "cache\SGIA\15\").Count


        Form1.FlatStatusBar1.Text = " Partie : " & partieEnCours & "  |  " & "Département : " & département & "  |  " & nbDossier & " Intervention en cours"


    End Sub



    Public Sub scriptAffichageInter()


        Form1.ListBox1.Items.Clear()
        Form1.ListBox1.UseCustomTabOffsets = True
        Form1.ListBox1.CustomTabOffsets.Add(62)

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "cache\SGIA\18\").GetDirectories()

            Form1.ListBox1.Items.Add(Repertoires.Name & vbTab & Cls_Ini.INIRead(appdata & "cache\SGIA\18\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "état"))


        Next

    End Sub

End Module
