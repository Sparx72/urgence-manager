Module version

    Public partieEnCours As String = ""
    Public interEnCours As String = ""
    Public versionPublic As String = "0.43"
    Public admin As Boolean = False
    Public activerForcerInter As Boolean = False
    Public url As String = "https://sc15.000webhostapp.com/data/"
    Public appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Alerte d'Urgence\"



    Public messageErreur As String


    Public Sub rapportErreur()
        erreur.TextBox1.Text = messageErreur
        erreur.ShowDialog()
    End Sub

End Module
