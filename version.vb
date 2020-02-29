Imports System.IO

Module version

    Public partieEnCours As String = ""
    Public pluginLoaded As String = ""
    Public interEnCours As String = ""
    Public versionPublic As String = "0.1"
    Public buildPublic As String = "59"
    Public admin As Boolean = False
    Public activerForcerInter As Boolean = False
    Public url As String = "https://sc15.000webhostapp.com/data/"
    Public appdata As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Urgence Manager\"


    Public messageErreur As String


    Public Sub rapportErreur()
        erreur.TextBox1.Text = messageErreur
        erreur.TextBox1.SelectionStart = erreur.TextBox1.Text.Length
        erreur.TextBox1.SelectionLength = erreur.TextBox1.Text.Length
        erreur.ShowDialog()
    End Sub

    Function log(ByVal logtext As String)
        'Dim sw As New StreamWriter(appdata & "logs/logfile.txt", True, System.Text.Encoding.UTF8)
        'sw.WriteLine("[" & Format(Now, "HH:mm:ss") & "] " & logtext)
        'sw.Close()


        console.TextBox1.Text = console.TextBox1.Text & vbCrLf & "[" & Format(Now, "HH:mm:ss") & "] " & logtext
        console.TextBox1.SelectionStart = console.TextBox1.Text.Length
        console.TextBox1.SelectionLength = console.TextBox1.Text.Length
        console.TextBox1.ScrollToCaret()

    End Function

End Module
