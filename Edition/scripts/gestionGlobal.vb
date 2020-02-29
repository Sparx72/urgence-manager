Imports System.IO

Module gestionGlobal

    Public Sub scriptStatutBar()



        'département
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département") = "" Then
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département", "75 Paris")
        End If
        Dim département As String = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département")

        'inters en cours
        Dim nbDossier = System.IO.Directory.GetDirectories(appdata & "cache\UTEngine\18\").Count + System.IO.Directory.GetDirectories(appdata & "cache\UTEngine\17\").Count + System.IO.Directory.GetDirectories(appdata & "cache\UTEngine\15\").Count


        'si sgia est activé ou non
        Dim UTActif As String
        If Form1.UTEngine.Enabled = True Then
            UTActif = "  |  UT Engine : En cours"
        Else
            UTActif = "  |  UT Engine : En attente"
        End If



        'affichage

        Form1.FlatStatusBar1.Text = " Partie : " & partieEnCours & "  |  " & "Secteur : " & département & "  |  " & nbDossier & " Intervention en cours" & UTActif
        centreIncendieSecours.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text
        vehicules.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text
        gestion.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text

        cta_codis.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text
        cta_codis_aviser15.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text
        cta_codis_aviser17.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text
        suiviInterSP.FlatStatusBar1.Text = Form1.FlatStatusBar1.Text

    End Sub



    Public Sub scriptAffichageInter()


        Form1.ListBox1.Items.Clear()
        Form1.ListBox1.UseCustomTabOffsets = True
        Form1.ListBox1.CustomTabOffsets.Add(62)

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\").GetDirectories()

            Form1.ListBox1.Items.Add(Repertoires.Name)


        Next

    End Sub

End Module
