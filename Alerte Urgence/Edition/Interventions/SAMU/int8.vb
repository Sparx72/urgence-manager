Module int8

    Public Sub inter8()

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

        Form1.motif = "Légère coupure avec couteau"
        Form1.texteAppel = "Bonjour j'ai un petit soucis, je me suis couper avec un couteau en coupant des carottes et ça saigne je fais quoi ?"

        'Échange aver l'ARM

        Form1.reponse1 = "Vous vous êtes coupés le doigt ou juste écourché ?"
        Form1.reponse2 = "Ah non non c'est pas grand chose mon doigt est pas coupé ! Mais ça saigne là !!"
        Form1.reponse3 = "Essayez de vous calmer d'accord ? C'est pas grave ce qui vous arrive il va juste falloir prendre un pancement ou un mouchoir et entourer votre doigt avec."
        Form1.reponse4 = "Ok bah je vais faire ça je vais mettre un pancement ça se calme."
        Form1.reponse5 = "Très bien, vous pourrez l'enlever plus tard dans la journée."
        Form1.reponse6 = "Ok merci !"
        Form1.reponse7 = "Je vous en pris madame, au revoir."
        Form1.reponse8 = "Au revoir !"
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

        Form1.reponse1conseil = "Pour résumer madame il suffit simplement d'arrêter le saignement et mettre un pancement."
        Form1.reponse2conseil = "D'accord merci beaucoup !"

        Form1.reponse1garde = "Bonjour docteur, je vous passe une dame qui c'est écourché un peu avec un couteau en coupant des carottes"
        Form1.reponse2garde = "Bonjour désolé mais je vais pas prendre une patiente pour ça..."

        Form1.reponse1ap = "Bonjour j'aurais besoin d'une ambulance pour une dame qui c'est coupé un peu avec un couteau en coupant des carottes"
        Form1.reponse2ap = "Bonjour, euh faut vraiment une ambulance pour ça ?"

        Form1.reponse1pds = "Docteur je vous passe une dame qui c'est écourché un peu avec un couteau en coupant des carottes"
        Form1.reponse2pds = "Ok tu étais pas obligé de faire réguler par un médecin pour ça"

        Form1.reponse1cta = "Salut c'est le SAMU, je te passe une dame qui c'est écourché un peu avec un couteau en coupant des carottes"
        Form1.reponse2cta = "Salut, euh vous gérez pas l'appel directement au centre 15 ?"

        Form1.reponse117 = "Salut c'est le SAMU, je te passe une dame qui c'est écourché un peu avec un couteau en coupant des carottes"
        Form1.reponse217 = "Salut, c'est le 17 t'a du faire une erreur"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin du SAMU, vous me confirmer que vous vous êtes juste un peu coupé ?"
        Form1.reponseMR2 = "Bonjour docteur, euh oui et ça saigne"
        Form1.reponseMR3 = "Vous avez mis un sopalin ou un pancement pour arrêter le saignement ?"
        Form1.reponseMR4 = "Pas encore je vais faire ça"
        Form1.reponseMR5 = "Très bien, ça va arrêter le saignement. Bonne journée madame"
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

        Form1.départSPreponse1 = "Salut c'est le SAMU, j'ai une dame qui c'est coupé un peu avec un couteau"
        Form1.départSPreponse2 = "Salut, tu es vraiment sûr qu'il faut engager un VSAV pour ça ?"
        Form1.départPOLICEreponse1 = "Salut c'est le SAMU, j'ai une dame qui c'est coupé un peu avec un couteau en coupant des carottes"
        Form1.départPOLICEreponse2 = "Salut, oulà je pensais que tu parlais d'une rixe. C'est rien alors"



        'bilan SP
        Form1.bilanSP = "VSAV arrivé sur les lieux, sommes en présence d'une dame de 56 ans, elle c'était juste un peu coupé elle à mis un pancement avant notre arrivée. On attend le SMUR"
        Form1.bilanSPsmurNonengagé = "VSAV arrivé sur les lieux, sommes en présence d'une dame de 56 ans, elle c'était juste un peu coupé elle à mis un pancement avant notre arrivée"
        Form1.bilanSPrepAttendreSmur = "Centre 15 à VSAV, bien reçu attendez bien le SMUR même si votre bilan est rassurant"
        Form1.bilanSPrepTransportCH = "Centre 15 à VSAV transportez là tout de même au centre hospitalier. Par sécurité..."
        Form1.bilanSPrepLaisserVictimes = "Centre 15 à VSAV ça marche merci elle peut être rassurée, désolé de vous avoir fait venir pour rien vous pouvez la laisser."


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut rien à signialez. Le pancement sur son doigts à même été bien mis !"
        Form1.bilanSMUR2 = "Salut ça marche désolé de vous avoir fait venir pour rien. Bon retour"
        Form1.bilanSMUR3 = "."
        Form1.bilanSMUR4 = "."
        Form1.bilanSMUR5 = "."


    End Sub

End Module
