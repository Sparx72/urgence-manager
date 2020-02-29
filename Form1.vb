Imports System.Speech.Synthesis
Imports System.IO

Public Class Form1


    Public parole As SpeechSynthesizer = New SpeechSynthesizer()

    Public dep As String
    Public interforncé As Integer = 0
    Public disponibleAppels As Boolean = False
    Public étapeTimerInfo As Integer = 1
    Public étapeClignotement As Integer = 1


    'liste des variables pour les appels

    Public nomAppelant As String
    Public prénomAppelant As String

    Public lat As String = "48.833"
    Public lon As String = "2.333"



    'statistique
    Public statsTotalInters As Integer = 0
    Public statsIntersEnCours As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        

        'version
        Label4.Text = "Version : " & version.versionPublic & " [DEV]"

        'barre du bas
        scriptStatutBar()

        'carte
        cartevide()

        

    End Sub

    Private Sub sonnerie_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sonnerie.Tick

        My.Computer.Audio.Play(My.Resources.alcatel_lucent_ringing, AudioPlayMode.Background)

    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        start.ShowDialog()

    End Sub

    Private Sub heure_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles heure.Tick
        Label7.Text = Format(Now, "HH:mm:ss")
        scriptStatutBar()
    End Sub





    Private Sub FlatLabel9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        version.messageErreur = "Cette fonctionalité n'est pas encore disponible."
        rapportErreur()

    End Sub

    Private Sub TimerAlertBox_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAlertBox.Tick
        FlatAlertBox1.Visible = False
        TimerAlertBox.Enabled = False
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        version.messageErreur = "Fonctionalité indisponible pour le moment"
        rapportErreur()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        version.messageErreur = "Fonctionalité indisponible pour le moment"
        rapportErreur()

    End Sub

    Private Sub Label9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        version.messageErreur = "Fonctionalité indisponible pour le moment"
        rapportErreur()

    End Sub


    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        'menuCentres.actualiserCentre()
        'menuCentres.ShowDialog()

        afficherCarteCentre()
        centreIncendieSecours.ShowDialog()

    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        start.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cta_codis.ShowDialog()
    End Sub

    Private Sub TimerInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If étapeTimerInfo = 1 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Les premières interventions arriveront en juillet : profitez en pour mettre en place centres et engins !"
        End If


        If étapeTimerInfo = 2 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Les mises à jour sont automatiques pour profiter de nos avancées dans le développement du simulateur"
        End If

        If étapeTimerInfo = 3 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Vous pouvez gérez les secours partout en France Métropole, Corse et départements Outre-Mer"
        End If

        If étapeTimerInfo = 4 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Prévoyez une couverture à l'échelle départementale, car les appels viendront ensuite par département"
        End If

        If étapeTimerInfo = 5 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Ce projet est entièrement bénévole et réalisé par des passionnés. Il vous interesse ? Hésitez pas à nous suivre sur Facebook !"
        End If

        If étapeTimerInfo = 6 Then
            FlatStatusBar1.Text = "Simulateur Alerte d'Urgence | Vous pouvez créez autant de partie que vous le souhaitez, et les organiser comme bon vous semble"
            étapeTimerInfo = 0
        End If

        étapeTimerInfo = étapeTimerInfo + 1

    End Sub


    Private Sub Label3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

        cta_codis.ShowDialog()

    End Sub

    Private Sub FlatButton5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectTab(0)
    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        TabControl1.SelectTab(1)
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

        version.messageErreur = "Cette fonctionalité n'est pas encore disponible."
        rapportErreur()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click




        gestion.ShowDialog()

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click

        'messageErreur = "Les interventions ne sont pas encore disponible mais nous travaillons dessus. Suivez nous sur les réseaux sociaux pour suivre le développement d'Alerte d'Urgence 2020 !"
        'rapportErreur()

        Appels.ShowDialog()

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        'prise d'appel
        Panel5.BackColor = Color.FromArgb(35, 35, 35)
        clignotement.Enabled = False
        sonnerie.Enabled = False
        FlatButton2.Visible = False
        FlatButton7.Visible = False
        PictureBox1.Visible = False



        'créer l'intervention dans les fichiers
        Randomize()
        Dim random As New Random(), rndnbr As Integer
        rndnbr = random.Next(10000000, 99999999)
        System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\18\SP-" & rndnbr)
        System.IO.Directory.CreateDirectory(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\engins\")

        interEnCours = "SP-" & rndnbr
        cta_codis.FlatLabel10.Text = interEnCours
        cta_codis.ListBox2.Items.Clear()

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "code", "SP-" & rndnbr)
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "interChargé", interChargé)
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "heure", Format(Now, "HH:mm"))
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "état", "Prise d'Appel")
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "lat", latitudeAppel)
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "lon", longitudeAppel)

        scriptAffichageInter()
        scriptStatutBar()
        cta_codis.actualiserMoyenSP()
        cta_codis.ShowDialog()


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Timer1.Enabled = False
        générerAppel()

    End Sub

    Private Sub clignotement_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clignotement.Tick




        If étapeClignotement = 1 Then
            Panel5.BackColor = Color.FromArgb(175, 92, 26)
        End If

        If étapeClignotement = 2 Then
            Panel5.BackColor = Color.FromArgb(255, 35, 35, 35)
            étapeClignotement = 0
        End If

        étapeClignotement = étapeClignotement + 1

    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        End

    End Sub

    Private Sub FlatButton6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click

        If ListBox1.SelectedItem <> "" Then


            Dim intervention As String = ListBox1.SelectedItem


            'si inter sp

            If intervention.Contains("SP") Then

                interEnCours = intervention
                suiviInterSP.ListBox1.Items.Clear()
                suiviInterSP.ListBox2.Items.Clear()
                suiviInterSP.TextBox2.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "adresse")
                suiviInterSP.TextBox4.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "cp")
                suiviInterSP.TextBox6.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "ville")
                suiviInterSP.TextBox1.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "précisionAdresse")
                suiviInterSP.ComboBox1.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "catégorie")
                suiviInterSP.ComboBox2.Text = Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "motif")

                'ajout engins
                For Each Fichier As FileInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\").GetFiles()
                    suiviInterSP.ListBox2.Items.Add(Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichier.Name, "données", "nom"))
                Next

                'texte
                If File.Exists(appdata & "cache\UTEngine\18\" & interEnCours & "\notes.txt") Then
                    Dim sr As New StreamReader(appdata & "cache\UTEngine\18\" & interEnCours & "\notes.txt")
                    suiviInterSP.TextBox3.Text = sr.ReadToEnd
                    sr.Close()
                End If


                suiviInterSP.ShowDialog()
            End If





        Else

            msgtitre = "Vous devez sélectionner une intervention en cours pour en afficher son suivi"
            msgInfo()

        End If

    End Sub

    Private Sub TimerSGIA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTEngine.Tick

        scriptUTEngine()

    End Sub

    Private Sub FlatButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton12.Click

        configuration.ShowDialog()

    End Sub

    Private Sub WebBrowser2_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser2.DocumentCompleted

        chargementForm.Close()

    End Sub


    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
