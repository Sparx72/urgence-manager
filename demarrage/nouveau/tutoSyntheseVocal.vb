Public Class tutoSyntheseVocal


    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click


        msgtitre = "La page de téléchargement de la voix va s'afficher dans" & Chr(13) & "votre navigateur par défaut"
        msgInfo()

        home.WindowState = FormWindowState.Minimized
        Process.Start("http://dl.free.fr/getfile.pl?file=/MSqbyVaB/3-RSSolo4FrenchVirginie.exe")

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click


        Try
            Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
            Form1.parole.SpeakAsync("")
            log("Synthèse vocale initialisé")

            msgtitre = "La voix française est parfaitement installée et reconnue dans Urgence Manager"
            msgInfo()

            étapeLancement = 1
            eXscriptNouveau()

        Catch ex As Exception
            log("Échec initialisation synthèse vocale - " & ex.Message)

            msgtitre = "La voix française ScanSoft Virginie_Dri40_16kHz n'est pas correctement installée." & Chr(13) & "Vérifiez que vous avez bien installé la voix depuis la page de téléchargement" & Chr(13) & "qui est proposée. Si besoin, vérifier si elle apparait dans la liste de la section" & Chr(13) & """Ajout et suppression de programmes"" du panneau de configuration Windows." & Chr(13) & "Enfin, tentez également de relancer Urgence Manager"
            msgInfo()

        End Try


    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        scriptNouveau.vocalmarche = True
        eXscriptNouveau()
        playFxWin()

    End Sub
End Class