Imports System.Speech.Synthesis
Imports System.IO
Imports System.Speech.Recognition

Public Class game

    Public reco As New SpeechRecognitionEngine
    Dim voca As New GrammarBuilder


    Public chrono As Integer = 0
    Public parole As SpeechSynthesizer = New SpeechSynthesizer()
    Public modeInter As Boolean = False


    Private Sub TimerAppel_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerAppel.Tick
        TimerAppel.Enabled = False
        générerAppel()
    End Sub

    Private Sub game_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        playFxMsg()
        msgtitre = "Souhaitez vous quitter Urgence Manager ?"
        msgOui = "Oui revenir au bureau Windows"
        msgNon = "Non annuler"

        msgOuiNon()

        If msgRésultat = "oui" Then
            End
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        donnéeAppelSP.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(donnéeAppelSP)
        donnéeAppelSP.Show()
    End Sub

    Private Sub TimerSonnerieB_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSonnerieB.Tick
        TimerSonnerieA.Enabled = False
        home.PlayerRing.URL = Application.StartupPath & "\data\sound\tonalité.wav"
        home.PlayerRing.controls.play()
    End Sub

    Private Sub TimerSonnerieA_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerSonnerieA.Tick
        TimerSonnerieA.Enabled = False
        TimerSonnerieB.Enabled = True
        Label6.Text = "Appel entrant"
        PictureBox3.Visible = True
        PictureBox4.Visible = True
        PictureBox5.Visible = True
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click

        modeÉcrit = True
        exRépondreAppel()

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click
        dossierMédical.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(dossierMédical)
        dossierMédical.Show()
    End Sub

    Private Sub FlatButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton10.Click

        Dim tempReponse As String = TextBox6.Text
        questionSP = tempReponse.ToUpper()
        TextBox6.Text = ""

        'traitement de la réponse
        scriptQuestionSP()

    End Sub

    Private Sub TextBox6_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox6.KeyDown

        If (e.KeyCode = Keys.Enter) Then

            Dim tempReponse As String = TextBox6.Text
            questionSP = tempReponse.ToUpper()
            TextBox6.Text = ""

            'traitement de la réponse
            scriptQuestionSP()

        End If

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted

        chargementForm.Timer1.Enabled = True

    End Sub

    Private Sub FlatButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton11.Click

        If Panel4.Visible = False Then
            Panel4.Visible = True
        Else
            Panel4.Visible = False
        End If

        
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        départSP.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départSP)
        départSP.Show()
        départSP.actualiserSP()
    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click

        départFDO.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départFDO)
        départFDO.Show()
        départFDO.actualiserFDO()

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        départSAMU.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départSAMU)
        départSAMU.Show()
        départSAMU.actualiserSAMU()

    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click

        départSC.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départSC)
        départSC.Show()
        départSC.actualiserSC()

    End Sub

    Private Sub FlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton7.Click

        départDIR.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départDIR)
        départDIR.Show()
        départDIR.actualiserDIR()

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click

        départRDF.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(départRDF)
        départRDF.Show()
        départRDF.actualiserRDF()

    End Sub

    Private Sub FlatButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton9.Click

        votreDépart.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(votreDépart)
        votreDépart.Show()

    End Sub

    Private Sub TimerHeure_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerHeure.Tick

        Try
            Label1.Text = Format(Now, "dddd dd MMMM yyyy, HH:mmm:ss")
            Label1.Text = Microsoft.VisualBasic.StrConv(Label1.Text, VbStrConv.ProperCase)
        Catch ex As Exception
            TimerHeure.Enabled = False
            log("Ereur - Problème affichage date et heure")
        End Try


    End Sub

    Private Sub game_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.KeyPreview = True

    End Sub

    Private Sub TimerInfo_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerInfo.Tick

        Panel7.Visible = False

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

        msgtitre = "Le mode vocal requiert d'avoir configuré la reconnaissance vocal Windows depuis" & Chr(13) & "panneau de configuration Windows. Vous devez configurer un microphone, puis" & Chr(13) & "effectuer un apprentissage de votre voix pour profiter du mode vocal."
        msgOui = "Continuer en mode vocal"
        msgNon = "Passer en mode écrit"
        msgOuiNon()

        If msgRésultat = "oui" Then
            modeÉcrit = False
            exRépondreAppel()

            reco.LoadGrammarAsync(New DictationGrammar)
            reco.SetInputToDefaultAudioDevice()
            reco.RecognizeAsync(RecognizeMode.Multiple)
            AddHandler reco.SpeechRecognized, AddressOf reconnaissance
        Else
            modeÉcrit = True
            exRépondreAppel()
        End If

        


    End Sub


    Private Sub reconnaissance(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)

        Dim mot As String = e.Result.Text
        questionSP = mot.ToUpper()

        'traitement de la réponse
        scriptQuestionSP()

    End Sub

    Private Sub TimerChrono_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerChrono.Tick

        chrono = chrono + 1
        Dim playTimeM As Integer = Math.Round(chrono / 60, 0, MidpointRounding.AwayFromZero)
        Dim playTimeS As Integer = chrono - playTimeM * 60
        If playTimeS < 10 Then
            Label6.Text = playTimeM & ":0" & playTimeS
        Else
            Label6.Text = playTimeM & ":" & playTimeS
        End If

        If modeÉcrit = False Then
            Label6.Text = Label6.Text & " (Vocal)"
        End If

    End Sub

    Private Sub FlatButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click


        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "18" Then
            donnéeAppelSP.TopLevel = False
            Panel4.Controls.Clear()
            Panel4.Controls.Add(donnéeAppelSP)
            donnéeAppelSP.Show()
        End If
        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "17" Then
            donnéeAppelFDO.TopLevel = False
            Panel4.Controls.Clear()
            Panel4.Controls.Add(donnéeAppelFDO)
            donnéeAppelFDO.Show()
        End If
        If Cls_Ini.INIRead(Application.StartupPath & "\callout\" & interChargé & "\callout.ini", "données", "type") = "15" Then
            donnéeAppelSAMU.TopLevel = False
            Panel4.Controls.Clear()
            Panel4.Controls.Add(donnéeAppelSAMU)
            donnéeAppelSAMU.Show()
        End If

    End Sub

End Class