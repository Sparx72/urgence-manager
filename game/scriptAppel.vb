Imports System.IO

Module scriptAppel

    Public Sub scriptQuestionSP()




        'question et réponnses

        Dim tempreponseSP As String = reponseSP



        For Each Fichiers As FileInfo In New DirectoryInfo(Application.StartupPath & "\callout\" & interChargé & "\communication\").GetFiles()


            Dim numeroMotActuel As Integer = 1
            Dim correspondanceRéponse As Boolean = False

            While Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\communication\" & Fichiers.Name, "données", "mot" & numeroMotActuel) <> ""


                If questionSP.Contains(Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\communication\" & Fichiers.Name, "données", "mot" & numeroMotActuel)) Then
                    correspondanceRéponse = True
                Else
                    correspondanceRéponse = False
                End If


                numeroMotActuel = numeroMotActuel + 1


            End While


            If correspondanceRéponse = True Then
                reponseSP = Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\communication\" & Fichiers.Name, "données", "réponse")
            End If

        Next





        If reponseSP = tempreponseSP Then
            reponseSP = ""
        End If



        'adaptation de la réponse

        reponseSP = reponseSP.Replace("[ADRESSE]", adresseAppel)
        reponseSP = reponseSP.Replace("[CODEPOSTAL]", codePostalAppel)
        reponseSP = reponseSP.Replace("[COMMUNE]", villeAppel)
        reponseSP = reponseSP.Replace("[DÉPARTEMENT]", départementAppel)
        reponseSP = reponseSP.Replace("[PAYS]", paysAppel)

        If Cls_Ini.INIRead(appdata & "settings/settings.ini", "profile", "gender") = "Homme" Then
            reponseSP = reponseSP.Replace("[CIVILITE]", "monsieur")
        Else
            reponseSP = reponseSP.Replace("[CIVILITE]", "madame")
        End If

        reponseSP = reponseSP.Replace("[HEURE]", DateTime.Now.ToString("HH heures mm"))






        'affichage de la réponse
        game.Label4.Font = New Font(game.Label4.Font.Name, game.Label4.Font.Size, FontStyle.Regular)
        game.Label4.Text = reponseSP



        home.PlayerMusic.settings.volume = 50

        Try
            game.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
            game.parole.SpeakAsync(reponseSP)

        Catch ex As Exception
        End Try


        'si pas de réponse
        If reponseSP = "" Then
            game.Label4.Font = New Font(game.Label4.Font.Name, game.Label4.Font.Size, FontStyle.Italic)
            game.Label4.Text = "Votre question n'a pas été comprise ou le callout ne prévoit pas de réponse"
        End If



    End Sub

End Module
