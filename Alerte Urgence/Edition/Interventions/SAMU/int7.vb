Module int7

    Public Sub inter7()

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

        Form1.motif = "Demande de médecin de garde"
        Form1.texteAppel = "Oui bonjour je suis malade depuis plusieurs jours et aucun médecin est disponible.. ça m'inquiète je sais pas quoi faire."

        'Échange aver l'ARM

        Form1.reponse1 = "Qu'es ce qui vous arrive exactement ?"
        Form1.reponse2 = "Bah j'ai mal au ventre et des vaumissements. Mais vous savez c'est dûr de trouver un médecin et commme je peux pas me déplacer..."
        Form1.reponse3 = "Ah peut être une bonne gastrot, vous avez quelle âge ?"
        Form1.reponse4 = "ah 84 ans je suis plus tout jeune ahah"
        Form1.reponse5 = "Oui je comprends, je vais pas vous laisser comme ça on va voir avec un médecin de garde d'accord ?"
        Form1.reponse6 = "D'accord merci car je commençait vraiment à m'inquiété et mon petit fils habite trop loin..."
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

        Form1.reponse1conseil = "Bon malheureusement je peux pas avoir de médecin de garde, la gastrot devrait passer"
        Form1.reponse2conseil = "Vous êtes vraiment sûr ? Je suis vieux vous savez"

        Form1.reponse1garde = "Bonjour docteur, j'ai une dame agée de 84 ans qui semble avoir une belle gastro depuis plusieurs jours mais pas de médecin pour la prendre"
        Form1.reponse2garde = "Bonjour ça marche passe la moi, je vais voir pour la prendre rapidement"

        Form1.reponse1ap = "Bonjour c'est possible de nous envoyer une ASSU pour une dame agée qui a une belle gastro et qui n'a pas pu voir de médecin ?"
        Form1.reponse2ap = "Bonjour, pas de soucis j'envoi une ambulance"

        Form1.reponse1pds = "Bonjour docteur, je vous passe une dame agée qui a une gastro mais elle a pas pu voir de médecin"
        Form1.reponse2pds = "Ok je vais voir avec elle, merci"

        Form1.reponse1cta = "Salut c'est le SAMU, je te passe une dame agée qui a une gastro mais elle a pas pu voir de médecin"
        Form1.reponse2cta = "Salut, euh vous gérez pas l'appel directement au centre 15 ?"

        Form1.reponse117 = "Salut c'est le SAMU, je te passe une dame agée qui a une gastro mais elle a pas pu voir de médecin"
        Form1.reponse217 = "Salut, c'est le 17 t'a du faire une erreur"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin du SAMU, vous avez juste des douleurs aux ventres et nausées c'est tout ?"
        Form1.reponseMR2 = "Euh oui, enfin c'est tout c'est tout... c'est tout de même assez embêtant"
        Form1.reponseMR3 = "Je comprends ne vous en faite pas. On va voir avec un médecin de garde pour vous prendre, ça ira ?"
        Form1.reponseMR4 = "Oui c'est très gentil docteur"
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

        Form1.départSPreponse1 = "Salut c'est le SAMU, j'ai une dame agée qui à une gastro"
        Form1.départSPreponse2 = "Salut, ça marche je vais t'envoyer une équipe au cas ou"
        Form1.départPOLICEreponse1 = "Salut c'est le SAMU, j'ai une dame agée qui à une gastro moyen d'envoyer du monde ?"
        Form1.départPOLICEreponse2 = "Salut, disons qu'on envoi pas les force de l'ordre pour une gastro habituellement"



        'bilan SP
        Form1.bilanSP = "VSAV arrivé sur les lieux, sommes en présence d'une dame de 84 ans. Les constantes sont pas trop mal, elle est juste malade. On attend le SMUR"
        Form1.bilanSPsmurNonengagé = "VSAV arrivé sur les lieux, sommes en présence d'une dame de 84 ans. Les constantes sont pas trop mal, elle est juste malade."
        Form1.bilanSPrepAttendreSmur = "Centre 15 à VSAV, bien reçu"
        Form1.bilanSPrepTransportCH = "Centre 15 à VSAV transportez là tout de même au centre hospitalier. Elle est assez agée donc au cas où.."
        Form1.bilanSPrepLaisserVictimes = "Centre 15 à VSAV ça marche merci elle peut être rassurée, vous pouvez la laisser."


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut rien à signialez la dame à juste une gastro, constante ok. J'ai téléphoné à un médecin de son secteur il va la prendre dans quelque heure. On va rentrer disponible"
        Form1.bilanSMUR2 = "Salut ça marche à toute"
        Form1.bilanSMUR3 = "."
        Form1.bilanSMUR4 = "."
        Form1.bilanSMUR5 = "."


    End Sub

End Module
