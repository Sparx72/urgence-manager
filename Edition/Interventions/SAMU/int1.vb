Module int1

    Public Sub inter1()

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

        Form1.motif = "Arrêt cardio respiratoire devant témoin"
        Form1.texteAppel = "Bonjour je vous appelle parce que mon père ne réponds pas, que dois-je faire ? J'ai besoin d'aide !"

        'Échange aver l'ARM

        Form1.reponse1 = "Il respire votre papa ?"
        Form1.reponse2 = "Je sais pas il bouge plus aidez moi !"
        Form1.reponse3 = "Calmez vous madame, allongez votre papa sur le dos et regardez si sa poitrine se soulève."
        Form1.reponse4 = "Non il respire pas je fais quoi ?"
        Form1.reponse5 = "D'accord et si vous approcher votre visage, il n'y a aucun souffle ?"
        Form1.reponse6 = "Non non rien du tout faut venir vite là !"
        Form1.reponse7 = "Très bien on va masser. Dès que je vais vous dire top vous allez appuyez fortement sur la poitrine de votre papa, d'accord ?"
        Form1.reponse8 = "d'accord je vais essayer !"
        Form1.reponse9 = "Top - Top - Top ... Allez y répétez après moi"
        Form1.reponse10 = "Top - Top - Top"
        Form1.reponse11 = "D'accord c'est très bien ce que vous faites madame, les secours sont parti, je vous passe le médecin du SAMU, ne quittez pas."
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

        Form1.reponse1conseil = "Maintenant que vous massez vous pouvez racrocher madame. Bonne journée."
        Form1.reponse2conseil = "Vous n'envoyez personne ? Allo ?"

        Form1.reponse1garde = "Oui bonjour docteur c'est le SAMU, je vous passe une dame qui a son papa qui fait un arrêt, vous pouvez voir avec elle ?"
        Form1.reponse2garde = "Bonjour, euh ok mais pouquoi vous envoyez personne de votre côté ?"

        Form1.reponse1ap = "Oui bonjour c'est le SAMU, j'aurais besoin d'une AP au domicile d'une dame qui a son papa en arrêt."
        Form1.reponse2ap = "Très bien on envoi l'une de nos ASSU missioné par le SAMU, vous avez vraiment pas possibilité d'envoyer un SMUR ?"

        Form1.reponse1pds = "Docteur je vous passe une patiente qui a son papa en arrêt, elle s'inquiète."
        Form1.reponse2pds = "Très bien passez la moi, mais il va falloir que je là passe au médecin régulateur dès que possible."

        Form1.reponse1cta = "Oui le CTA c'est le SAMU, je vous passe une dame qui a son papa en arrêt."
        Form1.reponse2cta = "Pouquoi nous la passer vous délanchez pas de SMUR de votre côté ?"

        Form1.reponse117 = "Oui le 17 c'est le SAMU, je vous passe une dame qui a son papa en arrêt."
        Form1.reponse217 = "Ah bah on ne vas pouvoir faire grand chose pour un arrêt ! On peux venir pour baliser mais pas plus..."


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour madame c'est le médecin du SAMU, c'est votre papa qui ne respire pas c'est bien ça, vous continuez le massage cardiaque ?"
        Form1.reponseMR2 = "Oui docteur"
        Form1.reponseMR3 = "Très bien vous continuez jusqu'a l'arrivée des secours madame. Il a quel âge votre papa ?"
        Form1.reponseMR4 = "68 ans"
        Form1.reponseMR5 = "D'accord et il a des problèmes cardiaques particuliers ?"
        Form1.reponseMR6 = "Un infarctus entre 2004 et 2005 et il est suivi je crois docteur"
        Form1.reponseMR7 = "D'accord, très bien. Les secours sont parti madame, je vais rester avec vous jusqu'à leur arrivée, vous arrêtez pas de masser, c'est très bien ce que vous faites."
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

        Form1.départSPreponse1 = "Bonjour c'est le centre 15, je voudrais que vous engagiez un VSAV pour un arrêt sur une victime de 68 ans."
        Form1.départSPreponse2 = "Je t'engage ça au plus vite."
        Form1.départPOLICEreponse1 = "Bonjour c'est le centre 15, on aurait besoin d'une brigade de gendarmerie au domicile d'un homme de 68 ans en arrêt."
        Form1.départPOLICEreponse2 = "Je regarde si j'en ai une de disponible, ça marche."



        'bilan SP
        Form1.bilanSP = "VSAV 01 Arrivé sur les lieux, en présence d'un homme de 68 ans en ACR, nous massons."
        Form1.bilanSPsmurNonengagé = "VSAV 01 Arrivé sur les lieux, nous sommes en présences d'un homme de 68 ans en ACR, nous demandons un SMUR"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV 01, bien reçu continuez le massage en attandant le SMUR. Terminé"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV 01, bien reçu transporter la victime dès maintenant au Centre Hospitalier"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV 01, bien reçu laissez la victime sur place vous pouvez repartir"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut c'est Éric, c'est bon pour le monsieur il était en fibrilation, 3 chocs et c'est repartit mais va falloir qu'on surveille"
        Form1.bilanSMUR2 = "Super je te réserve une place en déchocage, tu me tiens au courant s'il y a quoi que ce soit sur le trajet"
        Form1.bilanSMUR3 = "Ok ça marche, merci à plus"
        Form1.bilanSMUR4 = "."
        Form1.bilanSMUR5 = "."


    End Sub

End Module
