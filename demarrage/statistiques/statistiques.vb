Public Class statistiques


    
    Public Sub actualiserStats()

        ListBox1.Items.Clear()
        ListBox1.UseCustomTabOffsets = True
        ListBox1.CustomTabOffsets.Add(195)



        'temps de jeu
        Dim playTimeT As Integer = Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "playTime")
        Dim playTimeH As Integer = Math.Round(playTimeT / 60, 0, MidpointRounding.AwayFromZero)
        Dim playTimeM As Integer = playTimeT - playTimeH * 60
        ListBox1.Items.Add("Temps de jeu" & vbTab & playTimeH & " heures et " & playTimeM & " minutes")


        'services pris
        ListBox1.Items.Add("Prises de services" & vbTab & Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "serviceTaken"))

        'appels pris
        ListBox1.Items.Add("Appels répondus" & vbTab & Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "calloutTaken"))

    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        playFxUi()
        menuJouer.TopLevel = False
        home.Panel1.Controls.Clear()
        home.Panel1.Controls.Add(menuJouer)
        menuJouer.Show()

    End Sub


End Class