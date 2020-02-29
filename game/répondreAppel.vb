Module répondreAppel

    Public modeÉcrit As Boolean = False

    Public Sub exRépondreAppel()



        'arrêter sonnerie
        game.TimerSonnerieB.Enabled = False
        game.Panel4.Visible = True
        game.Panel1.Visible = True

        If modeÉcrit = True Then
            game.Panel5.Visible = True
        End If


        game.TimerChrono.Enabled = True
        game.PictureBox3.Visible = False
        game.PictureBox4.Visible = False
        game.PictureBox5.Visible = False
        home.TimerPlayerDown.Enabled = True





        'afficher menu donnnéeAppelService

        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "18" Then
            donnéeAppelSP.TopLevel = False
            game.Panel4.Controls.Clear()
            game.Panel4.Controls.Add(donnéeAppelSP)
            donnéeAppelSP.Show()
        End If
        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "17" Then
            donnéeAppelFDO.TopLevel = False
            game.Panel4.Controls.Clear()
            game.Panel4.Controls.Add(donnéeAppelFDO)
            donnéeAppelFDO.Show()
        End If
        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "15" Then
            donnéeAppelSAMU.TopLevel = False
            game.Panel4.Controls.Clear()
            game.Panel4.Controls.Add(donnéeAppelSAMU)
            donnéeAppelSAMU.Show()
        End If






        'fond
        If Cls_Ini.INIRead(Application.StartupPath & "/callout/" & interChargé & "/callout.ini", "données", "fond") <> "" Then
            home.PlayerFond.URL = Application.StartupPath & "/callout/" & interChargé & "/" & Cls_Ini.INIRead(Application.StartupPath & "/callout/" & interChargé & "/callout.ini", "données", "fond")
            home.PlayerFond.controls.play()
        End If


        'texte
        game.Label4.Font = New Font(game.Label4.Font.Name, game.Label4.Font.Size, FontStyle.Italic)
        game.Label4.Text = "Prononcer une phrase d'accueil pour débuter la conversation"


        'vider les champs
        votreDépart.ListBox1.Items.Clear()
        votreDépart.ListBox1.UseCustomTabOffsets = True
        votreDépart.ListBox1.CustomTabOffsets.Add(40)
        votreDépart.ListBox1.CustomTabOffsets.Add(65)
        votreDépart.ListBox1.CustomTabOffsets.Add(165)


        'stats

        If Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "calloutTaken") = "" Then
            Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "calloutTaken", "0")
        End If

        Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "calloutTaken", Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "calloutTaken") + 1)
        

    End Sub

End Module
