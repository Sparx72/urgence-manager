Module int3

    Public Sub inter3()

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

        Form1.motif = "Difficulté respiratoire VSM 90 ans"
        Form1.texteAppel = "Bonjour, j'ai mon grand père de 90 ans qui n'est pas bien, il respire fort et il se sent oppressé. je l'ai allongé dans son canapé Venez vite !"

        'Échange aver l'ARM

        Form1.reponse1 = "Calmez vous j'envoi les secours, ça fait combien de temps qu'il est oppréssé ?"
        Form1.reponse2 = "Environ 5 minutes mais c'est de pire en pire !"
        Form1.reponse3 = "D'accord rassurez le, c'est bien au domicile de votre grand père ?"
        Form1.reponse4 = "Oui oui"
        Form1.reponse5 = "Ok vous ne quittez pas je vous passe le médecin du SAMU"
        Form1.reponse6 = "D'accord merci !"
        Form1.reponse7 = "."
        Form1.reponse8 = "."
        Form1.reponse9 = "."
        Form1.reponse10 = "."
        Form1.reponse11 = "."
        Form1.reponse12 = "."
        Form1.reponse13 = "."
        Form1.reponse14 = "."
        Form1.reponse15 = "."
        Form1.reponse16 = "."
        Form1.reponse17 = "."
        Form1.reponse18 = "."
        Form1.reponse19 = "."
        Form1.reponse20 = "."


        'reponse arm

        Form1.reponse1conseil = "ça va passer du coup vous inquitez pas"
        Form1.reponse2conseil = "Non mais envoyez du monde il se sent vraiment pas bien !"

        Form1.reponse1garde = "Oui bonjour docteur c'est le SAMU, je vous passe un requérant qui à sont grand père qui a des difficultés respiratoires"
        Form1.reponse2garde = "Bonjour, vous faites pas réguler par le médecin chez vous ?"

        Form1.reponse1ap = "Oui bonjour c'est le SAMU, j'aurais besoin d'un transport au domicile d'une personne en difficulté respiratoire."
        Form1.reponse2ap = "Très bien mais vu la situation que vous m'avez décrit il risque d'être pas transportable de notre côté."

        Form1.reponse1pds = "Docteur je vous passe un requérant qui à son grand père en difficulté respiratoire"
        Form1.reponse2pds = "J'aurais préféré que ça soit le médecin urgentiste qui s'occupe de ça"

        Form1.reponse1cta = "Oui le CTA c'est le SAMU, je vous passe un requérant qui à son grand père en difficulté respiratoire"
        Form1.reponse2cta = "Bonjour, vous envoyez pas de SMUR ?"

        Form1.reponse117 = "Oui le 17 c'est le SAMU, je vous passe un requérant qui à son grand père en difficulté respiratoire"
        Form1.reponse217 = "On va rien pouvoir faire au 17 nous désolé"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin. Il est allongé votre grand père ?"
        Form1.reponseMR2 = "Oui ça empire docteur"
        Form1.reponseMR3 = "D'accord vous allez le mettre doucement en position assise."
        Form1.reponseMR4 = "Ok"
        Form1.reponseMR5 = "Très bien, c'est la première fois que ça lui arrive ?"
        Form1.reponseMR6 = "Non non il a déjà eu 3 embolies pulmonaires !"
        Form1.reponseMR7 = "D'accord les secours sont partis, vous allez pouvoir racrocher. Si il y a quoique ce soit, vous nous rappelez."
        Form1.reponseMR8 = "D'accord merci beaucoup, faites vite !"
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

        Form1.départSPreponse1 = "Salut c'est le centre 15, possible d'avoir un VSAV pour une VSM de 90 ans ayant des difficultés respiratoires ?"
        Form1.départSPreponse2 = "Salut ça marche je t'engage ça"
        Form1.départPOLICEreponse1 = "Salut c'est le centre 15, vous auriez du monde pour sécuriser l'intervention des Pompiers ?"
        Form1.départPOLICEreponse2 = "Salut je regarde ça, mais comme c'est à domicile j'enverrai peut être pas."



        'bilan SP
        Form1.bilanSP = "VSAV 01 Arrivé sur les lieux, sommes en précence d'un VSM de 90 ans très opréssé et respirant très difficilement, on le met sous O2 en vous attendant"
        Form1.bilanSPsmurNonengagé = "VSAV 01 Arrivé sur les lieux, VSM 90 ans en difficultés respiratoire, on la met sous O2 nous demandons un SMUR en renfort."
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV 01, bien reçu le SMUR va pas tarder"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV 01, bien reçu transportez directement la victime directement au CH"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV 01, bien reçu laissez la victime sur place c'est pas nécéssaire de la transporter"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut, les pompiers l'avais mis sous O2, son état est très critique donc j'ai intubé."
        Form1.bilanSMUR2 = "Salut ça marche, vous la transporter bientôt ?"
        Form1.bilanSMUR3 = "Ouaip on va se dépêcher pour déboucher l'artère, tu peux nous réserver une place ?"
        Form1.bilanSMUR4 = "Pas de soucis, A+"
        Form1.bilanSMUR5 = "."


    End Sub

End Module
