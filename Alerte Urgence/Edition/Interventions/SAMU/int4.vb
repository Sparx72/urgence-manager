Module int4

    Public Sub inter4()

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

        Form1.motif = "Chute pendant un match de foot"
        Form1.texteAppel = "Allo le SAMU ? Je suis entraineur de foot et pendant un match j'ai un de mes joueur qui à chuté. Son genoux est gonflé et très douloureux !"

        'Échange aver l'ARM

        Form1.reponse1 = "Son genoux est déformé ?"
        Form1.reponse2 = "Non ça a pas l'air, par contre c'est bien gonflé donc dans le doute je préfère vous appeler"
        Form1.reponse3 = "D'accord vous avez bien fait, il a quel âge le joueur ?"
        Form1.reponse4 = "Il a 18 ans"
        Form1.reponse5 = "Ok et c'est vraiment très douloureux il peut pas marcher ?"
        Form1.reponse6 = "Non non pas du tout, il est au sol il a trop mal pour se relever."
        Form1.reponse7 = "D'accord je vous envoi les Pompiers, vous nous rappeler si il y a un soucis d'accord ?"
        Form1.reponse8 = "Très bien merci !"
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

        Form1.reponse1conseil = "Du coup ça va passer ne vous inquietez pas"
        Form1.reponse2conseil = "Vous êtes vraiment sûr ??"

        Form1.reponse1garde = "Bonjour docteur, j'ai un entraineur d'un joueur de foot qui à son genoux gonflé au téléphone, je peux vous envoyer le joueur ?"
        Form1.reponse2garde = "Il aurait plutôt fallu envoyer les pompiers..."

        Form1.reponse1ap = "Bonjour c'est possible de nous envoyer une ASSU pour un footballeur qui à une douleur et eudème au genoux ?"
        Form1.reponse2ap = "Bonjour il aurait plutôt fallu demander un VSAV car c'est en mimieu public"

        Form1.reponse1pds = "Bonjour docteur, je vous passer l'entraineur d'un joueur de foot qui à chuté et à très mal au genoux"
        Form1.reponse2pds = "ça marche, mais le plus simple c'est d'envoyer les pompiers la prochaine fois"

        Form1.reponse1cta = "Salut c'est le SAMU, je te passe l'entraineur d'un joueur de foot qui à très mal au genoux"
        Form1.reponse2cta = "Salut, ok mais faut que je recontacte après faut que ça passe par le SAMU quand même..."

        Form1.reponse117 = "Salut c'est le SAMU, je te passe l'entraineur d'un joueur de foot qui à très mal au genoux"
        Form1.reponse217 = "Salut, tu ne fais pas erreur ?"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin du SAMU, donc il a un eodème au niveau du genoux, pas de déformation ?"
        Form1.reponseMR2 = "Bonjour docteur, non du moins pas apparente"
        Form1.reponseMR3 = "ok, donc là il est au sol et consient ?"
        Form1.reponseMR4 = "Oui il parle sans problème mais se plaint beaucoup de la douleur"
        Form1.reponseMR5 = "D'accord les Pompiers sont parti. Vous le laissez dans la position où il se sent le mieux. Si vous avez du froid vous mettez un linge entre l'eudème et le froid"
        Form1.reponseMR6 = "Ok merci !"
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

        Form1.départSPreponse1 = "Salut c'est le SAMU, tu peux m'engager un VSAV pour un joueur de 18 ans blessé au foot ?"
        Form1.départSPreponse2 = "Salut mince c'était pas une finale qui jouaient ? Bon bah pas de soucis je t'envoi ça A+"
        Form1.départPOLICEreponse1 = "Salut c'est le SAMU, tu pense nécéssaire d'engager une équipe pour un joueur de 18 ans blessé au foot ?"
        Form1.départPOLICEreponse2 = "Salut, si vraiment ça se passe mal entre les équipes on interviendra, merci de m'avoir prévenu"



        'bilan SP
        Form1.bilanSP = "VSAV 01 Arrivé sur les lieux, en présence d'une VSM 18 ans, eudème au genoux mais pas de déformation, on va attendre le SMUR pour la douleur mais je pense que c'est pas trop grave"
        Form1.bilanSPsmurNonengagé = "VSAV 01 Arrivé sur les lieux, en présence d'une VSM 18 ans, eudème au genoux mais pas de déformation, on conditionne dans le VSAV avec le matelas coquille"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV 01, effectivement attendez tout de même le SMUR il pourront gérer la douleur pour le transport"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV 01, vous allez pouvoir transporter. On vous laisse finir de le conditionner et préviens le CH"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV 01, laissez le sur place c'est pas nécéssaire de le transporter"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut, alors pour le jeune homme au foot rien de grave il a juste bien chuté, mais son équipe va devoir jouer sans lui !"
        Form1.bilanSMUR2 = "Salut c'est rassurant tu médicalise le VSAV des Pompiers ?"
        Form1.bilanSMUR3 = "Non non c'est pas nécéssaire on va rentrer disponible. Tu peux leur réserver une place ?"
        Form1.bilanSMUR4 = "Oui pas de soucis"
        Form1.bilanSMUR5 = "Super merci, je lui ai donné ce qu'il faut pour la douleur au passage. A+"


    End Sub

End Module
