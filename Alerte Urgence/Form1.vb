Imports System.Speech.Synthesis
Imports System.IO

Public Class Form1


    Public parole As SpeechSynthesizer = New SpeechSynthesizer()

    Public dep As String
    Public interforncé As Integer = 0
    Public disponibleAppels As Boolean = False
    Public étapeTimerInfo As Integer = 1
    Public étapeClignotement As Integer = 1


    'liste des variables

    Public numeroAppel As String

    Public texteAppel As String
    Public infoAppelant As String

    Public nomAppelant As String
    Public prénomAppelant As String

    Public adresse As String
    Public ville As String
    Public codePostal As String

    Public lat As String = "48.833"
    Public lon As String = "2.333"

    Public maxVSAV As Integer

    'heure et mois d'apparitions

    Public touteJournée As Boolean
    Public heure1début As Integer
    Public heure1fin As Integer
    Public heure2début As Integer
    Public heure2fin As Integer

    Public touteAnnée As Boolean
    Public janvier As Boolean
    Public février As Boolean
    Public mars As Boolean
    Public avril As Boolean
    Public mai As Boolean
    Public juin As Boolean
    Public juillet As Boolean
    Public aout As Boolean
    Public septembre As Boolean
    Public octobre As Boolean
    Public novembre As Boolean
    Public décembre As Boolean

    'données des appels

    Public motif As String

    Public reponse1 As String
    Public reponse2 As String
    Public reponse3 As String
    Public reponse4 As String
    Public reponse5 As String
    Public reponse6 As String
    Public reponse7 As String
    Public reponse8 As String
    Public reponse9 As String
    Public reponse10 As String
    Public reponse11 As String
    Public reponse12 As String
    Public reponse13 As String
    Public reponse14 As String
    Public reponse15 As String
    Public reponse16 As String
    Public reponse17 As String
    Public reponse18 As String
    Public reponse19 As String
    Public reponse20 As String

    Public reponseMR1 As String
    Public reponseMR2 As String
    Public reponseMR3 As String
    Public reponseMR4 As String
    Public reponseMR5 As String
    Public reponseMR6 As String
    Public reponseMR7 As String
    Public reponseMR8 As String
    Public reponseMR9 As String
    Public reponseMR10 As String
    Public reponseMR11 As String
    Public reponseMR12 As String
    Public reponseMR13 As String
    Public reponseMR14 As String
    Public reponseMR15 As String
    Public reponseMR16 As String
    Public reponseMR17 As String
    Public reponseMR18 As String
    Public reponseMR19 As String
    Public reponseMR20 As String

    Public reponse1conseil As String
    Public reponse2conseil As String

    Public reponse1garde As String
    Public reponse2garde As String

    Public reponse1ap As String
    Public reponse2ap As String

    Public reponse1pds As String
    Public reponse2pds As String

    Public reponse1cta As String
    Public reponse2cta As String

    Public reponse117 As String
    Public reponse217 As String


    'départ smur sp et gendarmerie

    Public départSPreponse1 As String
    Public départSPreponse2 As String

    Public départPOLICEreponse1 As String
    Public départPOLICEreponse2 As String

    Public vehiculeSPEngagé1 As String
    Public vehiculeSPEngagé2 As String
    Public vehiculeSPEngagé3 As String
    Public vehiculeSPEngagé4 As String
    Public vehiculeSPEngagé5 As String

    Public policeGendarmerieEngagé As String

    'bilan

    Public bilanSP As String
    Public bilanSPsmurNonengagé As String
    Public bilanSPrepAttendreSmur As String
    Public bilanSPrepTransportCH As String
    Public bilanSPrepLaisserVictimes As String

    Public bilanSMUR1 As String
    Public bilanSMUR2 As String
    Public bilanSMUR3 As String
    Public bilanSMUR4 As String
    Public bilanSMUR5 As String



    'bilanSGIA

    Public SGIAbilanSP As String
    Public SGIAbilanSPsmurNonengagé As String
    Public SGIAbilanSPrepAttendreSmur As String
    Public SGIAbilanSPrepTransportCH As String
    Public SGIAbilanSPrepLaisserVictimes As String
    Public SGIAMotif As String

    Public SGIAbilanSMUR1 As String
    Public SGIAbilanSMUR2 As String
    Public SGIAbilanSMUR3 As String
    Public SGIAbilanSMUR4 As String
    Public SGIAbilanSMUR5 As String



    Public reguleParMR As String
    Public heureInter As String
    Public SMURengagé As Boolean = False
    Public SPengagé As Boolean = False
    Public POLICEengagé As Boolean = False
    Public SMURengagésSurInter As String = ""

    Public texteRésuméFinInter As String


    'statistique
    Public statsTotalInters As Integer = 0
    Public statsIntersEnCours As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'plein écran
        If Cls_Ini.INIRead(appdata & "config.ini", "données", "fullscreen") = "oui" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            FlatClose1.Visible = True
            Me.Hide()
            Me.Show()
        End If
        

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
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

        devmode.ShowDialog()

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

        menuCentres.actualiserCentre()
        menuCentres.ShowDialog()

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

        cta_codis.ShowDialog()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        'département
        gestion.FlatComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département")

        'latitude et logitude et zoom

        gestion.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat")
        gestion.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon")
        Try
            If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom") > 0 And Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom") < 21 Then
                gestion.FlatNumeric1.Value = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom")
            Else
                gestion.FlatNumeric1.Value = 12
            End If
        Catch ex As Exception
            gestion.FlatNumeric1.Value = 12
        End Try
        



        'rendu carte
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "sat" Then
            gestion.FlatComboBox1.Text = "Mapbox streets-satellite"
        ElseIf Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "OSM" Then
            gestion.FlatComboBox1.Text = "OSM France"
        Else
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "sat")
            gestion.FlatComboBox1.Text = "Mapbox streets-satellite"
        End If


        'coordonnées GPS au clic
        If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick") = "non" Then
            gestion.FlatCheckBox1.Checked = False
        Else
            gestion.FlatCheckBox1.Checked = True
        End If

        gestion.ShowDialog()

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click

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
        int1données()
        générerAdresse()



        'créer l'intervention dans les fichiers
        Randomize()
        Dim random As New Random(), rndnbr As Integer
        rndnbr = random.Next(10000000, 99999999)
        System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\18\SP-" & rndnbr)
        System.IO.Directory.CreateDirectory(appdata & "cache\SGIA\18\SP-" & rndnbr & "\engins\")

        interEnCours = "SP-" & rndnbr
        cta_codis.FlatLabel10.Text = interEnCours

        Cls_Ini.INIWrite(appdata & "cache\SGIA\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "code", "SP-" & rndnbr)
        Cls_Ini.INIWrite(appdata & "cache\SGIA\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "heure", Format(Now, "HH:mm"))
        Cls_Ini.INIWrite(appdata & "cache\SGIA\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "état", "Prise d'Appel")
        Cls_Ini.INIWrite(appdata & "cache\SGIA\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "lat", latitudeAppel)
        Cls_Ini.INIWrite(appdata & "cache\SGIA\18\SP-" & rndnbr & "\SP-" & rndnbr & ".ini", "données", "lon", longitudeAppel)

        scriptAffichageInter()
        scriptStatutBar()
        cta_codis.ShowDialog()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        'nouvel appel

        FlashWindows.FlashWindow(Process.GetCurrentProcess().MainWindowHandle, True, True, 5)
        My.Computer.Audio.Play(My.Resources.alcatel_lucent_ringing, AudioPlayMode.Background)
        clignotement.Enabled = True
        FlatButton2.Visible = True
        FlatButton7.Visible = True
        PictureBox1.Visible = True
        PictureBox1.Image = My.Resources.sapeurs_pompiers
        sonnerie.Enabled = True
        Timer1.Enabled = False

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
End Class
