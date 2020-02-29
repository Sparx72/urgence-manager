Imports System.Speech.Recognition
Imports System.IO
Imports System.Globalization

Public Class cta_codis

    Dim reco As New SpeechRecognitionEngine
    Dim voca As New GrammarBuilder


    Public Sub actualiserListeEngagementSP()

        'permet d'actualiser les véhicules
        ListBox2.Items.Clear()
        For Each Fichiers As FileInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\").GetFiles
            ListBox2.Items.Add(Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichiers.Name, "données", "nom"))
        Next

    End Sub


    Public Sub FlatButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton14.Click

        Dim tempReponse As String = TextBox5.Text
        questionSP = tempReponse.ToUpper()

        'traitement de la réponse
        scriptQuestionSP()



    End Sub

    Private Sub cta_codis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'reconnaissance vocale
        If Cls_Ini.INIRead(appdata & "config.ini", "données", "reco") = "oui" Then
            reco.LoadGrammarAsync(New DictationGrammar)
            reco.SetInputToDefaultAudioDevice()
            reco.RecognizeAsync(RecognizeMode.Multiple)
            AddHandler reco.SpeechRecognized, AddressOf reconnaissance
        End If


    End Sub

    Private Sub reconnaissance(ByVal sender As Object, ByVal e As SpeechRecognizedEventArgs)

        Dim mot As String = e.Result.Text
        questionSP = mot.ToUpper()

        'traitement de la réponse
        scriptQuestionSP()

    End Sub



    Private Sub cta_codis_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        If Cls_Ini.INIRead(appdata & "config.ini", "données", "reco") = "oui" Then
            reco.RecognizeAsyncCancel()
        End If


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged

        If ComboBox1.Text = "SECOURS ROUTIER" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP 2 ROUES CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP 2 ROUES CONTRE PIETON")
            ComboBox2.Items.Add("AVP 2 ROUES SEUL")
            ComboBox2.Items.Add("AVP 2 ROUES CONTRE ANIMAL")
            ComboBox2.Items.Add("AVP BUS CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP BUS CONTRE VL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP BUS CONTRE PL")
            ComboBox2.Items.Add("AVP BUS CONTRE PL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP BUS CONTRE ENGIN AGRICOLE")
            ComboBox2.Items.Add("AVP BUS SEUL")
            ComboBox2.Items.Add("AVP BUS CONTRE PIETON")
            ComboBox2.Items.Add("AVP BUS CONTRE ANIMAL")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE VL")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE VL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE PL")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE PL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE PIETON")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE SEUL")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE SEUL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE CONTRE ANIMAL")
            ComboBox2.Items.Add("AVP PL CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP PL CONTRE PIETON")
            ComboBox2.Items.Add("AVP PL CONTRE PL")
            ComboBox2.Items.Add("AVP PL CONTRE PL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL CONTRE VL")
            ComboBox2.Items.Add("AVP PL CONTRE VL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL SEUL")
            ComboBox2.Items.Add("AVP PL SEUL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL TMD")
            ComboBox2.Items.Add("AVP PL TMR")
            ComboBox2.Items.Add("AVP PL CONTRE ANIMAL")
            ComboBox2.Items.Add("AVP VL CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP VL CONTRE PIETON")
            ComboBox2.Items.Add("AVP VL CONTRE VL")
            ComboBox2.Items.Add("AVP VL CONTRE VL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP VL SEUL")
            ComboBox2.Items.Add("AVP VL SEUL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP +3 VL")
            ComboBox2.Items.Add("AVP +3 VL / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP VL CONTRE ANIMAL")

        End If



        If ComboBox1.Text = "AVP AUTOROUTE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP 2 ROUES CONTRE 2 ROUES / AUTOROUTE")
            ComboBox2.Items.Add("AVP 2 ROUES SEUL / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS CONTRE 2 ROUES / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS CONTRE VL / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS CONTRE VL / INCARCÉRÉ / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS CONTRE PL / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS CONTRE PL / INCARCÉRÉ / AUTOROUTE")
            ComboBox2.Items.Add("AVP BUS SEUL / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL CONTRE 2 ROUES / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL CONTRE PL / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL CONTRE PL / AUTOROUTE / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL CONTRE VL / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL CONTRE VL / AUTOROUTE / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL SEUL / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL SEUL / AUTOROUTE / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP PL TMD / AUTOROUTE")
            ComboBox2.Items.Add("AVP PL TMR / AUTOROUTE")
            ComboBox2.Items.Add("AVP VL CONTRE 2 ROUES / AUTOROUTE")
            ComboBox2.Items.Add("AVP VL CONTRE VL / AUTOROUTE")
            ComboBox2.Items.Add("AVP VL CONTRE VL / AUTOROUTE / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP VL SEUL / AUTOROUTE")
            ComboBox2.Items.Add("AVP VL SEUL / AUTOROUTE / INCARCÉRÉ")
            ComboBox2.Items.Add("AVP +3 VL / AUTOROUTE")
            ComboBox2.Items.Add("AVP +3 VL / INCARCÉRÉ / AUTOROUTE")

        End If



        If ComboBox1.Text = "ACCIDENT FLUVIALE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP BATEAU")
            ComboBox2.Items.Add("AVP 2 ROUES TOMBÉE À L'EAU")
            ComboBox2.Items.Add("AVP BUS TOMBÉE A L'EAU")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE TOMBÉE À L'EAU")
            ComboBox2.Items.Add("AVP PL TOMBÉE À L'EAU")
            ComboBox2.Items.Add("AVP VL TOMBÉE À L'EAU")


        End If


        If ComboBox1.Text = "ACCIDENT AÉRONOTIQUE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("CRASH AVION DE LIGNE")
            ComboBox2.Items.Add("CRASH AVION DE TOURISME")
            ComboBox2.Items.Add("CRASH AVION MILITAIRE")
            ComboBox2.Items.Add("CRASH HELICOPTERE")
            ComboBox2.Items.Add("CRASH MONGOLFIERE / ULM")
            ComboBox2.Items.Add("RECHERCHE D'AERONEF")


        End If


        If ComboBox1.Text = "ACCIDENTS FÉROVIAIRE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP TRAIN CONTRE BUS")
            ComboBox2.Items.Add("AVP TRAIN CONTRE TRAIN")
            ComboBox2.Items.Add("AVP TRAIN CONTRE VL")
            ComboBox2.Items.Add("AVP TRAIN CONTRE PL")
            ComboBox2.Items.Add("AVP TRAIN CONTRE 2 ROUES")
            ComboBox2.Items.Add("AVP TRAIN CONTRE ENGIN AGRICOLE")
            ComboBox2.Items.Add("AVP TRAIN CONTRE PIETON")

        End If


        If ComboBox1.Text = "ACCIDENT AUTRES" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP VL/PL/2ROUES DANS UN RAVIN")
            ComboBox2.Items.Add("AVP QUAD")
            ComboBox2.Items.Add("AVP VELO / VTT")

        End If



        If ComboBox1.Text = "ACCIDENT AVEC FEUX" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("AVP 2 ROUES AVEC FEUX")
            ComboBox2.Items.Add("AVP ENGIN AGRICOLE AVEC FEUX")
            ComboBox2.Items.Add("AVP PL AVEC FEUX")
            ComboBox2.Items.Add("AVP PL TMD AVEC FEUX")
            ComboBox2.Items.Add("AVP PL TMR AVEC FEUX")
            ComboBox2.Items.Add("AVP VL AVEC FEUX")
            ComboBox2.Items.Add("AVP TRAIN AVEC FEUX")

        End If


        If ComboBox1.Text = "SECOURS A PERSONNE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("ACCOUCHEMENT INOPINÉ À DOMICILE")
            ComboBox2.Items.Add("ACCOUCHEMENT INOPINÉ LP/VP")
            ComboBox2.Items.Add("ASSISTANCE À PERSONNE")
            ComboBox2.Items.Add("DECLENCHEMENT ALARME SECOURS VL")
            ComboBox2.Items.Add("DECLENCHEMENT DE TELE-ALARME")
            ComboBox2.Items.Add("INTOXICATION CO SITUATION D'URGENCE")
            ComboBox2.Items.Add("INTOXICATION MEDICAMENTEUSE SITUATION D'URGENCE")
            ComboBox2.Items.Add("INTOXICATION PAR GAZ/PRODUITS TOXIQUES")
            ComboBox2.Items.Add("MALAISE URGENCE VITALE / ALTERCATION À LA CONSCIENCE")
            ComboBox2.Items.Add("MALAISE URGENCE VITALE / ARRÊT CARDIO-RESPIRATOIRE")
            ComboBox2.Items.Add("MALAISE URGENCE VITALE / DIFFICULTÉ RESPIRATOIRE")
            ComboBox2.Items.Add("MALAISE URGENCE VITALE / DOULEURS THORACIQUES")
            ComboBox2.Items.Add("MALAISE-MALADE A DOMICILE SITUATION D'URGENCE")
            ComboBox2.Items.Add("MALAISE-MALADE AU TRAVAIL SITUATION D'URGENCE")
            ComboBox2.Items.Add("MALAISE-MALADE AU TRAVAIL / AUTOROUTE")
            ComboBox2.Items.Add("MALAISE-MALADE DANS VEHICULE")
            ComboBox2.Items.Add("MALAISE-MALADE DANS VEHICULE / AUTOROUTE")
            ComboBox2.Items.Add("MALAISE-MALADE LIEU PUBLIC / VOIE PUBLIC")
            ComboBox2.Items.Add("MALAISE-MALADE LIEU PUBLIC / VOIE PUBLIC / AUTOROUTE")
            ComboBox2.Items.Add("MALAISE-MALADE AU SPORT")
            ComboBox2.Items.Add("NOYADE (PISCINE, BAIGNOIRE, …)")
            ComboBox2.Items.Add("NOYADE (FLEUVE, LAC, RIVIÈRE, PUIT, …)")
            ComboBox2.Items.Add("NOYADE AUTRES")
            ComboBox2.Items.Add("PERSONNE BLESSE A DOMICILE SITUATION D'URGENCE")
            ComboBox2.Items.Add("PERSONNE BLESSE AU TRAVAIL SITUATION D'URGENCE")
            ComboBox2.Items.Add("PERSONNE BLESSE AU SPORT")
            ComboBox2.Items.Add("PERSONNE BLESSE BRÛLER GRAVE")
            ComboBox2.Items.Add("PERSONNE BLESSE DANS UN MILLIEUX PÉRRIEUX")
            ComboBox2.Items.Add("PERSONNE BLESSE ELECTRISATION / FOUDROIEMENT")
            ComboBox2.Items.Add("PERSONNE BLESSE ENSEVELIE")
            ComboBox2.Items.Add("PERSONNE BLESSE LIEU PUBLIC / VOIE PUBLIQUE")
            ComboBox2.Items.Add("PERSONNE BLESSE LIEU PUBLIC / VOIE PUBLIQUE / AUTOROUTE")
            ComboBox2.Items.Add("PERSONNE BLESSE PAR ARME A FEU / ARME BLANCHE")
            ComboBox2.Items.Add("PERSONNE BLESSE PAR MORSURE D'ANIMAL")
            ComboBox2.Items.Add("PERSONNE BLESSE PAR MORSURE D'ANIMAL / AUTOROUTE")
            ComboBox2.Items.Add("PERSONNE BLESSE PAR PIQÛRE(S) D'INSECTE(S)")
            ComboBox2.Items.Add("PERSONNE BLESSE PAR PIQÛRE(S) D'INSECTE(S) / AUTOROUTE")
            ComboBox2.Items.Add("PERSONNE BLESSE PLAIE / HEMORAGGIE")
            ComboBox2.Items.Add("PERSONNE BLESSE SECTION DE MEMBRE / DOIGT")
            ComboBox2.Items.Add("PERSONNE BLESSE SUITE A RIXE OU AGRESSION")
            ComboBox2.Items.Add("PERSONNE RÉPONDANT PAS AUX APPELS")
            ComboBox2.Items.Add("RELEVAGE DE PERSONNE")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR ARME BLANCHE")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR ARME A FEU")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR DEFENESTRATION")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR GAZ")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR IMMOLATION")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR MEDICAMENTS")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR NOYADE")
            ComboBox2.Items.Add("TENTATIVE DE SUCIDE PAR PENDAISON")

        End If


        If ComboBox1.Text = "APPELS RÉGULÉ PAR SAMU" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("MALAISE-MALADE SAMU RÉGULÉ")
            ComboBox2.Items.Add("MALAISE-MALADE SAMU RÉGULÉ / AUTOROUTE")
            ComboBox2.Items.Add("MALAISE-MALADE SAMU RÉGULÉ RETOURS")
            ComboBox2.Items.Add("PERSONNE BLESSE SAMU RÉGULÉ")
            ComboBox2.Items.Add("PERSONNE BLESSE SAMU RÉGULÉ / AUTOROUTE")
            ComboBox2.Items.Add("PERSONNE BLESSE SAMU RÉGULÉ RETOURS")
            ComboBox2.Items.Add("CARENCE D'AMBULANCE")
            ComboBox2.Items.Add("CARENCE D'AMBULANCE RETOURS")
            ComboBox2.Items.Add("CARENCE BRANCARDAGE RENFORT")
            ComboBox2.Items.Add("CARENCE RENFORT SSSM")
            ComboBox2.Items.Add("CARENCE SOINS PSYCHIATRIQUES")
            ComboBox2.Items.Add("CARENCE TRANSFERT EQUIPE MEDICALE DZ")
            ComboBox2.Items.Add("CARENCE TRANSFERT VICTIME DZ")
            ComboBox2.Items.Add("CARENCE TRANSFERT INTER-HOSPITALIER")

        End If


        If ComboBox1.Text = "FEUX DE BATIMENT" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("FEU DE CHATEAU")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (APPARTEMENT)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (CAGE D'ESCALIER)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (CAVE)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (GARAGE)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (MAISON)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION (SOUS SOL)")
            ComboBox2.Items.Add("FEU D'IMMEUBLE D'HABITATION NON HABITER")
            ComboBox2.Items.Add("FEU D'ETABLISSEMENT D'ENSEIGNEMENT (AVEC INTERNAT)")
            ComboBox2.Items.Add("FEU D'ETABLISSEMENT D'ENSEIGNEMENT (SANS INTERNAT)")
            ComboBox2.Items.Add("FEU D'ETABLISSEMENT PENITENTIAIRE")
            ComboBox2.Items.Add("FEU DANS UN ETABLISSEMENT DE LOISIRS")
            ComboBox2.Items.Add("FEU DANS UN ETABLISSEMENT DE SOINS")
            ComboBox2.Items.Add("FEU DANS UN HOTEL / RESTAURANT")
            ComboBox2.Items.Add("FEU DANS UN MAGASIN DE VENTE")
            ComboBox2.Items.Add("FEU D'ATELIER")
            ComboBox2.Items.Add("FEU D'ENTREPOT")
            ComboBox2.Items.Add("FEU DE BATIMENT AGRICOLE")
            ComboBox2.Items.Add("FEU D'USINE")
            ComboBox2.Items.Add("FEU DE BUREAUX/LOCAUX ADMINISTRATIFS DANS UN ERP")
            ComboBox2.Items.Add("FEU D'ERP AUTRES")
            ComboBox2.Items.Add("FEU DE PARKING SOUTERRAIN")
            ComboBox2.Items.Add("FEU DE POUBELLES / DETRITUTS SUR VP")
            ComboBox2.Items.Add("FEU DE SILO")
            ComboBox2.Items.Add("FEU DE STATION SERVICE")

        End If


        If ComboBox1.Text = "FEUX DE VEHICULE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("FEU D'AERONEF")
            ComboBox2.Items.Add("FEU DE BATEAU")
            ComboBox2.Items.Add("FEU DE CARAVANE / CAMPING CAR")
            ComboBox2.Items.Add("FEU D'ENGIN AGRICOLE")
            ComboBox2.Items.Add("FEU D'ENGIN HORS ROUTE")
            ComboBox2.Items.Add("FEU DE 2 ROUES")
            ComboBox2.Items.Add("FEU DE 2 ROUES / AUTOROUTE")
            ComboBox2.Items.Add("FEU DE BUS")
            ComboBox2.Items.Add("FEU DE BUS / AUTOROUTE")
            ComboBox2.Items.Add("FEU DE PL")
            ComboBox2.Items.Add("FEU DE PL / AUTOROUTE")
            ComboBox2.Items.Add("FEU DE PL TMD")
            ComboBox2.Items.Add("FEU DE PL TMD / AUTOROUTE")
            ComboBox2.Items.Add("FEU DE PL TMR")
            ComboBox2.Items.Add("FEU DE PL TMR / AUTOROUTE")
            ComboBox2.Items.Add("FEU DE TRAIN")
            ComboBox2.Items.Add("FEU DE VL")
            ComboBox2.Items.Add("FEU DE VL / AUTOROUTE")
            ComboBox2.Items.Add("FEU D'ENGINS DIVERS")
            ComboBox2.Items.Add("FEU DE VEHICULES AUTRES")

        End If


        If ComboBox1.Text = "FEUX" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("FEU")
            ComboBox2.Items.Add("FEU D'ORIGINE ELECTRIQUE")
            ComboBox2.Items.Add("FEU D'APPAREIL MÉNAGER")
            ComboBox2.Items.Add("FEU DE CHAUFFERIE (FIUL)")
            ComboBox2.Items.Add("FEU DE CHAUFFERIE (GAZ)")
            ComboBox2.Items.Add("FEU DE CHAUFFERIE (BOIS)")
            ComboBox2.Items.Add("FEU DE CHAUFFERIE (AUTRES)")
            ComboBox2.Items.Add("FEU DE CHEMINEE")
            ComboBox2.Items.Add("FEU DE TOITURE / COMBLES")
            ComboBox2.Items.Add("FEU DE TRANSFORMATEUR ELECTRIQUE")

        End If



        If ComboBox1.Text = "FEUX DE FORÊTS" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("FEU DE BROUSSAILLE")
            ComboBox2.Items.Add("FEU DE CHAUME")
            ComboBox2.Items.Add("FEU D'ARBRE")
            ComboBox2.Items.Add("FEU DE DECHARGE / ENFOUISSEMENT")
            ComboBox2.Items.Add("FEU DE DECHETS VERTS")
            ComboBox2.Items.Add("FEU DE FORET")
            ComboBox2.Items.Add("FEU DE RECOLTE")
            ComboBox2.Items.Add("FEU DE PAILLER")
            ComboBox2.Items.Add("FEU DE VEGETATION")
        End If


        If ComboBox1.Text = "AUTRES" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("DECLENCHEMENT ALARME INCENDIE")
            ComboBox2.Items.Add("EXPLOSION D'HABITATION")
            ComboBox2.Items.Add("EXPLOSION DANS UN ERP")
            ComboBox2.Items.Add("EXPLOSION AUTRES")
            ComboBox2.Items.Add("FUITE DE GAZ (PGC) SUR VOIE PUBLIQUE")
            ComboBox2.Items.Add("FUITE DE GAZ (PGR) SUR VOIE PUBLIQUE")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMMÉE (PGC) SUR VOIE PUBLIQUE")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMMÉE (PGR) SUR VOIE PUBLIQUE")
            ComboBox2.Items.Add("FUITE DE GAZ (PGC) DANS UN LIEU PUBLIC")
            ComboBox2.Items.Add("FUITE DE GAZ (PGR) DANS UN LIEU PUBLIC")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMMÉE (PGC) DANS UN LIEU PUBLIC")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMMÉE (PGR) DANS UN LIEU PUBLIC")
            ComboBox2.Items.Add("FUITE DE GAZ (PGC) DANS UN BATIMENT")
            ComboBox2.Items.Add("FUITE DE GAZ (PGR) DANS UN BATIMENT")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMÉE(PGC) DANS UN BATIMENT")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMÉE(PGR) DANS UN BATIMENT")
            ComboBox2.Items.Add("FUITE DE GAZ (PGC) DANS UN IMMEUBLE")
            ComboBox2.Items.Add("FUITE DE GAZ (PGR) DANS UN BATIMENT")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMÉE (PGC) DANS UN IMMEUBLE")
            ComboBox2.Items.Add("FUITE DE GAZ ENFLAMÉE (PGR) DANS UN IMMEUBLE")
            ComboBox2.Items.Add("FUITE / ODEURS DE GAZ")
            ComboBox2.Items.Add("FUMEE SUSPECTE")
            ComboBox2.Items.Add("ODEUR SUSPECTE")

        End If


        If ComboBox1.Text = "CNPE" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("INTERVENTION CNPE INC")
            ComboBox2.Items.Add("INTERVENTION CNPE FUMÉE SUSPECTE")
            ComboBox2.Items.Add("INTERVENTION CNPE SAP")
            ComboBox2.Items.Add("INTERVENTION CNPE OD")
            ComboBox2.Items.Add("INTERVENTION CNPE ODEUR SUSPECTE")

        End If


        If ComboBox1.Text = "ESSAIS" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("ESSAI CTA")
            ComboBox2.Items.Add("ESSAI SAMU")
            ComboBox2.Items.Add("ESSAI TRANSMISSION")

        End If


        If ComboBox1.Text = "INTERVENTIONS DIVERSES" Then

            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("ALERTE A LA BOMBE")
            ComboBox2.Items.Add("ASSISTANCE À TRAIN IMMOBILISÉ")
            ComboBox2.Items.Add("ATTAQUE / ATTENTATS NRBCE")
            ComboBox2.Items.Add("ATTAQUE / ATTENTATS NOVI-ALPHA")
            ComboBox2.Items.Add("ANIMAL BLESSE SUR VOIE PUBLIC")
            ComboBox2.Items.Add("BACHAGE")
            ComboBox2.Items.Add("BALISAGE")
            ComboBox2.Items.Add("CAPTURE DE REPTILE")
            ComboBox2.Items.Add("DÉGAGEMENT DE VOIE PLUBLIQUE")
            ComboBox2.Items.Add("CHUTE DE FILS ÉLECTRIQUE SUR VOIE PUBLIC")
            ComboBox2.Items.Add("DÉPOSE D'OBJETS MENACANT DE TOMBER")
            ComboBox2.Items.Add("DESTRUCTION D'HYMENOPTERES")
            ComboBox2.Items.Add("EFFONDREMENT / EBOULEMENT DE CONTRUCTION")
            ComboBox2.Items.Add("EFFONDREMENT / EBOULEMENT DE TERRAIN")
            ComboBox2.Items.Add("FUITE DE RESERVOIR VL/PL/2ROUES")
            ComboBox2.Items.Add("FUITE DE MATIÈRE DANGEREUGE")
            ComboBox2.Items.Add("FUITE D'EAU")
            ComboBox2.Items.Add("INONDATION / FUITE D'EAU DANS UN ERP")
            ComboBox2.Items.Add("INONDATION / FUITE D'EAU DANS UNE MAISON D’HABITATION")
            ComboBox2.Items.Add("INONDATION / FUITE D'EAU DANS UN APPARTEMENT")
            ComboBox2.Items.Add("INONDATION / FUITE D'EAU SUR LA VOIE PUBLIC")
            ComboBox2.Items.Add("INONDATIONS AUTRES")
            ComboBox2.Items.Add("NETTOYAGE VP")
            ComboBox2.Items.Add("OUVERTURE DE PORTE")
            ComboBox2.Items.Add("PERSONNE BLOQUEE DANS UN ASCENSEUR")
            ComboBox2.Items.Add("PROTECTION DE BIEN")
            ComboBox2.Items.Add("POLLUTION AQUATIQUE (COURS D'EAU, PLAN D'EAU,…)")
            ComboBox2.Items.Add("POLLUTION TERRESTRE")
            ComboBox2.Items.Add("POLLUTION RESEAUX D'EAU")
            ComboBox2.Items.Add("POLLUTIONS AUTRES")
            ComboBox2.Items.Add("RECONNAISSANCE")
            ComboBox2.Items.Add("RECHERCHE DE PERSONNE")
            ComboBox2.Items.Add("RECHERCHE SUBAQUATIQUE")
            ComboBox2.Items.Add("RECHERCHE SUBAQUATIQUE DE PERSONNE")
            ComboBox2.Items.Add("SAUVETAGE ANIMALIER")


        End If


        If ComboBox1.Text = "RENFORTS ET AUTRES" Then


            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("RENFORT GROUPEMENT/ETAT-MAJOR")
            ComboBox2.Items.Add("RENFORT AU CS")
            ComboBox2.Items.Add("RENFORT INONDATION")
            ComboBox2.Items.Add("SERVICE SECURITE")
            ComboBox2.Items.Add("EXERCICES")
            ComboBox2.Items.Add("EXERCICE ATTANTAT/INTRUSION")
            ComboBox2.Items.Add("EXERCICE CNPE")
            ComboBox2.Items.Add("EXERCICE NOVI")
            ComboBox2.Items.Add("EXERCICE AUTRES")
            ComboBox2.Items.Add("MANŒUVRE CENTRE")

        End If



        If ComboBox1.Text = "RECLASSIFICATIONS DES INTERVENTIONS" Then


            ComboBox2.Items.Clear()
            ComboBox2.Items.Add("FAUSSE ALERTE INC")
            ComboBox2.Items.Add("FAUSSE ALERTE OD")
            ComboBox2.Items.Add("FAUSSE ALERTE SAP")
            ComboBox2.Items.Add("INTERVENTION ANNULÉE INC")
            ComboBox2.Items.Add("INTERVENTION ANNULÉE OD")
            ComboBox2.Items.Add("INTERVENTION ANNULÉE SAP")

        End If



        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "catégorie", ComboBox1.Text)

    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "adresse", TextBox2.Text)

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "cp", TextBox4.Text)

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "ville", TextBox6.Text)

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "précisionAdresse", TextBox1.Text)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "motif", ComboBox2.Text)

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

        Dim sw As New StreamWriter(appdata & "cache\UTEngine\18\" & interEnCours & "\notes.txt", False, System.Text.Encoding.UTF8)
        sw.Write(TextBox3.Text)
        sw.Close()

    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown

        If (e.KeyCode = Keys.Enter) Then

            Dim tempReponse As String = TextBox5.Text
            questionSP = tempReponse.ToUpper()

            'traitement de la réponse
            scriptQuestionSP()

        End If

    End Sub


    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        'supprimer un engin

        If ListBox2.SelectedItem = "" Then

            MsgBox("Vous devez sélectionner un engin pour le retirer de la liste", MsgBoxStyle.Critical)

        End If


        If ListBox2.SelectedItem <> "" Then




            Try
                'supression d'un engin
                If File.Exists((appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & ListBox2.SelectedItem & ".ini")) Then
                    My.Computer.FileSystem.DeleteFile(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & ListBox2.SelectedItem & ".ini")
                End If

                actualiserListeEngagementSP()

            Catch ex As Exception
                version.messageErreur = "Échec lors de la supression de l'engin " & ListBox2.SelectedItem & " / " & ex.ToString
                rapportErreur()
            End Try

        End If


    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        cta_codis_aviser17.ShowDialog()


    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        cta_codis_aviser15.actualiserMoyenSMUR()
        cta_codis_aviser15.actualiserListeEngagementSP()
        cta_codis_aviser15.ShowDialog()

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        'déclancher intervention

        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "données", "état", "En cours")
        Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\" & interEnCours & ".ini", "messages", "présentation", ctaMessagePresentation)
        scriptAffichageInter()

        Me.Close()

        For Each Fichiers As FileInfo In New DirectoryInfo(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\").GetFiles
            Form1.RichTextBox1.Text = Form1.RichTextBox1.Text + Chr(13) + Chr(13) + "CODIS de " + Cls_Ini.INIRead(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichiers.Name, "données", "nom") & " prenons le départ sur " & ComboBox2.Text
        Next


        Form1.FlatAlertBox1.Visible = True
        Form1.FlatAlertBox1.kind = FlatAlertBox._Kind.Info
        Form1.FlatAlertBox1.Text = "Moyens engagés sur intervention"
        Form1.TimerAlertBox.Enabled = True

    End Sub

    Public Sub actualiserMoyenSP()

        ListBox1.Items.Clear()
        ListBox1.UseCustomTabOffsets = True
        ListBox1.CustomTabOffsets.Add(45)
        ListBox1.CustomTabOffsets.Add(200)

        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()



            'prend en compte la distance

            Dim ciClone As CultureInfo = CType(CultureInfo.InvariantCulture.Clone(), CultureInfo)
            ciClone.NumberFormat.NumberDecimalSeparator = "."

            Dim lat_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat"), ciClone)
            Dim lon_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon"), ciClone)


            Dim lat_a As Double = (Math.PI * lat_centre) / 180
            Dim lon_a As Double = (Math.PI * lon_centre) / 180

            Dim lat_b As Double = (Math.PI * Convert.ToDouble(latitudeAppel, ciClone)) / 180
            Dim lon_b As Double = (Math.PI * Convert.ToDouble(longitudeAppel, ciClone)) / 180


            Dim d As Double = 6378000 * (Math.PI / 2 - Math.Asin(Math.Sin(lat_b) * Math.Sin(lat_a) + Math.Cos(lon_b - lon_a) * Math.Cos(lat_b) * Math.Cos(lat_a)))
            d = d / 1000
            d = Math.Round(d, 1, MidpointRounding.AwayFromZero)

            Dim resultat As String
            If d < 10 Then resultat = "0" & d Else resultat = d



            'essai de lire le dossier engin sinon le créer

            If d < 100 Then

                Try
                    For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\").GetFiles()
                        ListBox1.Items.Add(resultat & " km" & vbTab & Repertoires.Name & vbTab & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\" & Fichier.Name, "données", "nom"))
                    Next
                Catch ex As Exception

                    System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\")
                    messageErreur = "Les fichiers du centre " & Repertoires.Name & " sont corrompus, des modifications ont été éffectuées. Vous pouvez normalement cliquer sur ""Tenter de continuer""."
                    rapportErreur()

                End Try


                ListBox1.Sorted = True

            End If


        Next


        'afficher un message si pas d'engins
        If ListBox1.Items.Count = 0 Then

            msgtitre = "Il y a aucun engin disponible dans un rayon de 100 km. Vérifier que vous avez" & Chr(13) & "bien des centres dans le département que vous gérez ou cliquez sur ""Afficher" & Chr(13) & "tout les engins disponible"""
            msgInfo()
        End If




    End Sub

    Private Sub FlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton7.Click

        actualiserMoyenSP()

    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click

        msgtitre = "Tout les engins vont être affichés et classés par centre (et non par distance) jusqu'à ce que vous cliquiez sur ""Re-Scanner"""
        msgInfo()

        ListBox1.Items.Clear()
        ListBox1.UseCustomTabOffsets = True
        ListBox1.CustomTabOffsets.Add(45)
        ListBox1.CustomTabOffsets.Add(200)
        ListBox1.Sorted = False


        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()



            'prend en compte la distance

            Dim ciClone As CultureInfo = CType(CultureInfo.InvariantCulture.Clone(), CultureInfo)
            ciClone.NumberFormat.NumberDecimalSeparator = "."

            Dim lat_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lat"), ciClone)
            Dim lon_centre As Double = Convert.ToDouble(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\" & Repertoires.Name & ".ini", "données", "lon"), ciClone)


            Dim lat_a As Double = (Math.PI * lat_centre) / 180
            Dim lon_a As Double = (Math.PI * lon_centre) / 180

            Dim lat_b As Double = (Math.PI * Convert.ToDouble(latitudeAppel, ciClone)) / 180
            Dim lon_b As Double = (Math.PI * Convert.ToDouble(longitudeAppel, ciClone)) / 180


            Dim d As Double = 6378000 * (Math.PI / 2 - Math.Asin(Math.Sin(lat_b) * Math.Sin(lat_a) + Math.Cos(lon_b - lon_a) * Math.Cos(lat_b) * Math.Cos(lat_a)))
            d = d / 1000
            d = Math.Round(d, 1, MidpointRounding.AwayFromZero)



            'essai de lire le dossier engin sinon le créer

            Try
                For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\").GetFiles()
                    ListBox1.Items.Add(d & " km" & vbTab & Repertoires.Name & vbTab & Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\" & Fichier.Name, "données", "nom"))
                Next
            Catch ex As Exception

                System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\")
                messageErreur = "Les fichiers du centre " & Repertoires.Name & " sont corrompus, des modifications ont été éffectuées. Vous pouvez normalement cliquer sur ""Tenter de continuer""."
                rapportErreur()

            End Try



        Next

    End Sub

    Private Sub FlatButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton8.Click

        'valider ce véhicule

        Dim donnée As String = ListBox1.SelectedItem


        For Each Repertoires As DirectoryInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\").GetDirectories()

            For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\").GetFiles()

                If donnée.Contains(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\" & Fichier.Name, "données", "nom")) And donnée.Contains(Repertoires.Name) Then

                    'récupérer la distance
                    Dim distance As String = ListBox1.SelectedItem
                    distance = Split(distance, " km")(0)



                    'si le véhicule existe l'ajouter

                    My.Computer.FileSystem.CopyFile(appdata & "game\" & partieEnCours & "\sp\" & Repertoires.Name & "\engins\" & Fichier.Name, appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichier.Name, overwrite:=True)

                    Dim temps As Double = Math.Round((distance * coefVitesseSP) * 60, 0, MidpointRounding.AwayFromZero)
                    Cls_Ini.INIWrite(appdata & "cache\UTEngine\18\" & interEnCours & "\engins\" & Fichier.Name, "données", "temps", temps)

                    actualiserListeEngagementSP()


                End If


            Next


        Next

    End Sub

End Class