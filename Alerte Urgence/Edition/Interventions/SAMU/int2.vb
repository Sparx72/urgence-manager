Module int2

    Public Sub inter2()

        'heure et mois d'apparition
        Form1.touteJournée = True
        Form1.heure1début = 99
        Form1.heure1fin = 99
        Form1.heure2début = 99
        Form1.heure2fin = 99

        Form1.touteAnnée = True
        Form1.janvier = True
        Form1.février = True
        Form1.mars = True
        Form1.avril = True
        Form1.mai = True
        Form1.juin = True
        Form1.juillet = True
        Form1.aout = True
        Form1.septembre = True
        Form1.novembre = True
        Form1.décembre = True

        'Appel

        Form1.motif = "Chute VTT"
        Form1.texteAppel = "Salut c'est le CTA, je te passe un jeune homme qui à assisté à la chute d'un de ses amis qui arriverai pas à se relever"

        'Échange aver l'ARM

        Form1.reponse1 = "Salut, ça marche A+. Oui bonjour monsieur c'est le SAMU, il à chuté de quoi votre ami ?"
        Form1.reponse2 = "Bonjour, on faisait du VTT mais il c'est mal réceptionné sur son dernier saut, il assez mal et n'arrive pas à se relever"
        Form1.reponse3 = "D'accord il est conscient ?"
        Form1.reponse4 = "Oui oui on discute avec lui pour le rassurer"
        Form1.reponse5 = "Ok et il a quel âge ce jeune homme ?"
        Form1.reponse6 = "Il a 18 ans"
        Form1.reponse7 = "D'accord et il a mal où exactement ?"
        Form1.reponse8 = "Apparement toute sa jambe gauche, et surtout son bras droit qu'il arrive pas du tout à bouger. On est pas sûr mais on pense qu'il est tombé sur l'épaule"
        Form1.reponse9 = "AH oui... dans tout les cas on va vous envoyez les secours, vous êtes dans une forêt, sur la route ?"
        Form1.reponse10 = "Dans un bois où il y a très peu de monde"
        Form1.reponse11 = "Ok vous quittez pas je vous passe le médecin d'accord ?"
        Form1.reponse12 = "Ok pas de souci, merci"
        Form1.reponse13 = "."
        Form1.reponse14 = "."
        Form1.reponse15 = "."
        Form1.reponse16 = "."
        Form1.reponse17 = "."
        Form1.reponse18 = "."
        Form1.reponse19 = "."
        Form1.reponse20 = "."


        'reponse arm

        Form1.reponse1conseil = "Vous allez le laisser là et il va finir par se relever que la douleur sera passée"
        Form1.reponse2conseil = "Vous êtes vraiment sûr que ça va passer ? Il soufre là !"

        Form1.reponse1garde = "Oui bonjour docteur c'est le SAMU, je vous passer l'ami d'un jeune homme qui à fait une mauvaise réception en VTT"
        Form1.reponse2garde = "Bonjour, malheureusement je ne vais rien pouvoir faire, il faudrait envoyer les pompiers sur place"

        Form1.reponse1ap = "Oui bonjour c'est le SAMU, j'aurais besoin d'un transport pour un VTTiste qui à fait une bonne chute."
        Form1.reponse2ap = "Très bien mais vu la situation que vous m'avez décrit il risque d'être pas transportable de notre côté."

        Form1.reponse1pds = "Docteur je vous passe l'ami du jeune homme qui à fait une chute en VTT"
        Form1.reponse2pds = "Tu peux plutôt faire réguler par le médecin urgentiste ? Car pour une si grave chute..."

        Form1.reponse1cta = "Oui le CTA c'est le SAMU, je vous passe l'ami du jeune homme qui à fait une chute en VTT"
        Form1.reponse2cta = "Bonjour, ah mais on vient de vous le passer pour que faire réguler l'appel"

        Form1.reponse117 = "Oui le 17 c'est le SAMU, je vous passe l'ami du jeune homme qui à fait une chute en VTT"
        Form1.reponse217 = "On va rien pouvoir faire au 17 nous désolé"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour monsieur c'est le médecin, donc il à mal à sa jambe et son bras, qu'il arrive pas à bouger"
        Form1.reponseMR2 = "Bonjour oui c'est ça, il reste bloqué au sol et se plein pas mal de son bras"
        Form1.reponseMR3 = "Ok vous le laissez au sol surtout, les secours sont partis. Il faut pas qu'il essaye de le relever c'est important"
        Form1.reponseMR4 = "Ok pas de soucis"
        Form1.reponseMR5 = "Vous allez pouvoir racrocher monsieur, les pompiers vont arriver"
        Form1.reponseMR6 = "D'accord merci beaucoup"
        Form1.reponseMR7 = "."
        Form1.reponseMR8 = "."
        Form1.reponseMR9 = "."
        Form1.reponseMR10 = "."
        Form1.reponseMR11 = "."
        Form1.reponseMR12 = "."
        Form1.reponseMR13 = "."
        Form1.reponseMR14 = "."
        Form1.reponseMR15 = "."
        Form1.reponseMR16 = "."
        Form1.reponseMR17 = "."
        Form1.reponseMR18 = "."
        Form1.reponseMR19 = "."
        Form1.reponseMR20 = "."


        'véhicules SP à supprimer
        'Form1.vehiculeSPEngagé1 = ""
        Form1.vehiculeSPEngagé2 = "."
        Form1.vehiculeSPEngagé3 = "."
        Form1.vehiculeSPEngagé4 = "."
        Form1.vehiculeSPEngagé5 = "."


        'en cas de départ

        Form1.départSPreponse1 = "Salut c'est le centre 15, possible d'avoir un VSAV pour une VSM de 18 ans qui à chuté en VTT ?"
        Form1.départSPreponse2 = "Salut ça marche je t'engage ça"
        Form1.départPOLICEreponse1 = "Salut c'est le centre 15, vous auriez du monde pour sécuriser l'intervention des Pompiers ?"
        Form1.départPOLICEreponse2 = "Salut je regarde ça, mais normalement oui pas de soucis"



        'bilan SP
        Form1.bilanSP = "VSAV 01 Arrivé sur les lieux, sommes en précence d'un jeune homme de 18 ans non transportable"
        Form1.bilanSPsmurNonengagé = "VSAV 01 Arrivé sur les lieux, la victime n'est pas transportable nous demandons un SMUR en renfort"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV 01, bien reçu le SMUR arrive bientôt"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV 01, bien reçu transportez quand même la victime directement au CH"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV 01, bien reçu laissez la victime sur place c'est pas nécéssaire de la transporter"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut alors pour le jeune homme de 18 ans, il avait bien l'épaule luxé donc on c'est occupé de ça."
        Form1.bilanSMUR2 = "Salut super, et pour le reste"
        Form1.bilanSMUR3 = "La surement le tibia ou le fibula cassé, à l'écho pas d'hémoragie mais niveau bassin j'ai des doutes. En bref t'a moyen de me réserver une place pour un bodyscan ?"
        Form1.bilanSMUR4 = "Pas de soucis je te garde une place"
        Form1.bilanSMUR5 = "Nickel on arrive d'ici 20 minutes, je passe voir la famille et on va bientôt le transporter"


    End Sub

End Module
