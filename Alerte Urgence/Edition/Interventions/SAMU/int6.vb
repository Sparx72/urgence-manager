Module int6

    Public Sub inter6()

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

        Form1.motif = "Gendarme violament percuté"
        Form1.texteAppel = "Oui le SAMU c'est la gendarmerie, on faisait un contrôle routier mais il y a un mec qui vient de forcer et percuter mon collègue !"

        'Échange aver l'ARM

        Form1.reponse1 = "Il est consient votre collègue ?"
        Form1.reponse2 = "Non non il respire mais c'est tout il répond pas du tout ! On stoppe les hémoragies comme on peut !"
        Form1.reponse3 = "D'accord il a quel âge ?"
        Form1.reponse4 = "34 ans il y a quelque jours ! Il est vraiment blessé il nous faut du monde"
        Form1.reponse5 = "Pas de soucis j'engage les Pompiers et un SMUR, je te passe le médecin"
        Form1.reponse6 = "Ok merci !"
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

        Form1.reponse1conseil = "Il va revenir à ses esprits vous pouvez attendre avec lui"
        Form1.reponse2conseil = "Vous êtes vraiment sûr ??"

        Form1.reponse1garde = "Bonjour docteur, j'ai le collègue d'un gendarme qui c'est fait percuté par une voiture, inconscient."
        Form1.reponse2garde = "Oulà envoi un SMUR"

        Form1.reponse1ap = "Bonjour c'est possible de nous envoyer une ASSU pour un AVP Pieton/VL ?"
        Form1.reponse2ap = "Bonjour faut plutôt envoyer un SMUR désolé"

        Form1.reponse1pds = "Bonjour docteur, j'ai le collègue d'un gendarme qui c'est fait percuté par une voiture, inconscient."
        Form1.reponse2pds = "Passe plutôt au médecin urgentiste"

        Form1.reponse1cta = "Salut c'est le SAMU, je te passe le collègue d'un gendarme qui s'est fait percuté par une voiture"
        Form1.reponse2cta = "Salut, euh vous gérez pas l'appel directement au centre 15 ?"

        Form1.reponse117 = "Salut c'est le SAMU, je te passe le collègue d'un gendarme qui s'est fait percuté par une voiture"
        Form1.reponse217 = "Salut, merci de nous tenir au courant mais faut envoyer des moyens !!!"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Salut c'est le médecin, percuté par une voiture ok, ça saigne beaucoup pour les hémoragies ?"
        Form1.reponseMR2 = "Pas mal mais on arrive à contenir avec ce qu'on avait dans notre véhicule en premier secours !"
        Form1.reponseMR3 = "Ok tu me rappel si ça évolue surtout !"
        Form1.reponseMR4 = "Très bien merci beaucoup docteur"
        Form1.reponseMR5 = "."
        Form1.reponseMR6 = "."
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

        Form1.départSPreponse1 = "Salut c'est le SAMU, j'aurai besoin d'une équipe pour un AVP, un gendarme c'est fait percuté par une voiture lors d'un contrôle, on envoi un SMUR de notre côté."
        Form1.départSPreponse2 = "Salut, reçu j'envoi un VSAV et un Secours Routier. A+"
        Form1.départPOLICEreponse1 = "Salut c'est le SAMU, on a apris qu'un gars de l'une de vos équipe c'est fait percuté lors d'un contrôle. C'est assez sérieux on envoi Pompiers et SMUR"
        Form1.départPOLICEreponse2 = "Salut, ouai on à eu l'info ça a l'air assez critique pour lui. On a envoyer du renfort on se tien au courant !"



        'bilan SP
        Form1.bilanSP = "VSAV arrivé sur les lieux, on a bien qu'une seule victime, inconsciente et surment plusieurs membres cassés. On attend le SMUR"
        Form1.bilanSPsmurNonengagé = "VSAV arrivé sur les lieux, on a bien qu'une seule victime, inconsciente et surment plusieurs membres cassés. Vu son état nous demandons d'urgence un SMUR en renfort"
        Form1.bilanSPrepAttendreSmur = "Centre 15 à VSAV, bien reçu"
        Form1.bilanSPrepTransportCH = "Centre 15 à VSAV transportez maintenant la victime au Centre Hospitalier malgré ces blessures"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 à VSAV laisser la victime sur place, fin d'intervention"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut donc pour l'AVP le gendarme est toujours inconscient, polytromatisé. On a réduit quelque fractures mais faudra une place rapidement"
        Form1.bilanSMUR2 = "Salut ça marche je te réserve une place dès maintenant, vous le transportez quand ?"
        Form1.bilanSMUR3 = "Dans 5-10 minutes"
        Form1.bilanSMUR4 = "Ok ça marche, je te réserve la place à plus tard"
        Form1.bilanSMUR5 = "."


    End Sub

End Module
