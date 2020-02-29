Public Class conditionsUtilisation

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        playFxMsg()
        msgtitre = "Vous avez refusé les conditions d'utilisations. Urgence Manager" & Chr(13) & "va quitter et retourner au bureau Windows."
        msgInfo()

        End
    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        playFxWin()
        Cls_Ini.INIWrite(appdata & "settings/settings.ini", "requirement", "terms", "accepted")
        scriptNouveau.étapeLancement = 1
        scriptNouveau.eXscriptNouveau()

    End Sub
End Class