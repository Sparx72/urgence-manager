Module int10

    Public Sub inter10()

        'heure et mois d'apparition
        Form1.touteJournée = True
        Form1.heure1début = 21
        Form1.heure1fin = 24
        Form1.heure2début = 0
        Form1.heure2fin = 6

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

        Form1.motif = "Rixe sans arme"
        Form1.texteAppel = "Oui le SAMU je suis désolé je vous appel parce qu'on à fait une mauvaise rencontre avec un mec qui c'est battu avec mon copain"

        'Échange aver l'ARM

        Form1.reponse1 = "D'accord il est encore là vous agresseur ?"
        Form1.reponse2 = "Non heureusement il à pris la fuite"
        Form1.reponse3 = "D'accord je suppose qu'il est blessé votre copain, il à quoi exactement ?"
        Form1.reponse4 = "Il a le visage en sang... En fait le mec voulais s'en prendre à moi mais il c'est interposé. L'autre c'est énervé et il l'a frappé..."
        Form1.reponse5 = "Ok il y a du monde à côté de vous ? Des témoins pour être en séucirté ?"
        Form1.reponse6 = "Oui oui merci, du monde est venu nous aider. "
        Form1.reponse7 = "D'accord dans tout les cas on envoi pompiers et police vous inquiétez pas. Il a quel âge votre copain ? Il semble avoir quelque chose de cassé ?"
        Form1.reponse8 = "19 ans le soucis c'est qu'on sait pas trop, il commence à avoir un peu mal."
        Form1.reponse9 = "D'accord c'est normal sous le coup de l'adrénaline on ressent pas la douleur. Les secours sont parti, je préviens la police. Restez bien avec les témoins, je vous passe le médecin du SAMU"
        Form1.reponse10 = "Pas de soucis. Je vous remercie."
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

        Form1.reponse1conseil = "Finalement pas besoin de secours vous inquiétez pas"
        Form1.reponse2conseil = "Vous n'envoyez personne ? Allo ?"

        Form1.reponse1garde = "Oui bonjour docteur c'est le SAMU... je suis en train de faire une erreur désolé"
        Form1.reponse2garde = "Bonjour, pas de soucis à plus"

        Form1.reponse1ap = "Oui bonjour c'est le SAMU, j'aurais besoin d'une AP pour un blessé suite à une rixe"
        Form1.reponse2ap = "Bonjour il faut un VSAV pour ça"

        Form1.reponse1pds = "Docteur je vous passe l'amie du jeune homme de 19 ans agressé"
        Form1.reponse2pds = "Très bien passez la moi... mais faut plutôt envoyer les pompiers"

        Form1.reponse1cta = "Oui le CTA c'est le SAMU, je te passe passe l'amie du jeune homme de 19 ans agressé"
        Form1.reponse2cta = "Salut, ça marche mais dans tout les cas on va devoir repasser par vous pour faire réguler"

        Form1.reponse117 = "Oui le 17 c'est le SAMU, je te passe passe l'amie du jeune homme de 19 ans agressé"
        Form1.reponse217 = "Salut, ça marche vous demandez pas les SP ?"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour madame c'est le médecin du SAMU. Vous inquietez pas pour l'agression vous pourrez en parler aux Pompiers n'hésitez pas. Il est conscient votre petit ami ?"
        Form1.reponseMR2 = "Bonjour docteur oui il est conscient. Mais bien blessé à la tête avec du sang un peu partout."
        Form1.reponseMR3 = "Il a reçu un seul ou plusieurs coups ? Violents ou modérés ?"
        Form1.reponseMR4 = "Il me semble plus un seul gros coup, puisqu'il à chuté"
        Form1.reponseMR5 = "D'accord. Les pompiers sont sur la route."
        Form1.reponseMR6 = "Ok merci beaucoup docteur !"
        Form1.reponseMR7 = "Je vous en pris, bon courage."
        Form1.reponseMR8 = "Merci !"
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

        Form1.départSPreponse1 = "Bonjour c'est le centre 15, nous aurions besoin d'un VSAV pour une  VSM de 19 ans blessé suite à une rixe, sans arme."
        Form1.départSPreponse2 = "Salut, je t'envoi une équipe"
        Form1.départPOLICEreponse1 = "Bonjour c'est le centre 15, j'aurais besoin de la police, un jeune c'est fait agressé par un type non armé apparement, il serait en fuite."
        Form1.départPOLICEreponse2 = "Salut, merci pour l'info j'envoi nos équipes"



        'bilan SP
        Form1.bilanSP = "VSAV Arrivé sur les lieux, en présence d'une VSM de 19 ans, blessé au visage avec probablement le nez cassé. Les constantes sont correctes, et il semble orienté. On attend le SMUR."
        Form1.bilanSPsmurNonengagé = "VSAV Arrivé sur les lieux, en présence d'une VSM de 19 ans, blessé au visage avec probablement le nez cassé. Les constantes sont correctes, et il semble orienté. A vous"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV, bien reçu le SMUR est en route"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV, bien reçu vous pouvez transporter la victime au Centre Hospitalier"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV, bien reçu laissez la victime sur place vous pouvez repartir. C'est pas si grave..."


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut pour le jeune homme il a le nez cassé. Il aurai été mis à terre quand il c'est pris le coup de son agresseur, donc je peux pas mettre de côté un éventuel trauma crânien"
        Form1.bilanSMUR2 = "D'accord je réserve un scan donc ?"
        Form1.bilanSMUR3 = "Oui s'il te plait. On conditionne dans le VSAV et on arrive. On le médicalise."
        Form1.bilanSMUR4 = "Très bien, en espérant que le scan ne montre rien"
        Form1.bilanSMUR5 = "Ouaip pour le moment il est bien orienté et se souvient bien de l'agresseur. Sur ce à plus"


    End Sub

End Module
