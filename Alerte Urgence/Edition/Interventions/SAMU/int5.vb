Module int5

    Public Sub inter5()

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

        Form1.motif = "Renfort SMUR pour un AVP"
        Form1.texteAppel = "Oui le SAMU c'est le chef d'agrès du VSAV, on est sur un AVP avec une dame de 54 ans incarcéré dans son véhicule mais son état se dégrade..."

        'Échange aver l'ARM

        Form1.reponse1 = "Elle est consience cette dame ?"
        Form1.reponse2 = "Oui les équipiers tente de la maintenir éveillé"
        Form1.reponse3 = "ça marche, je te passe le médecin"
        Form1.reponse4 = "Merci"
        Form1.reponse5 = "."
        Form1.reponse6 = "."
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

        Form1.reponse1conseil = "Finalement pas besoin de SMUR"
        Form1.reponse2conseil = "Vous êtes vraiment sûr ??"

        Form1.reponse1garde = "Bonjour docteur, je vous passe les SP pour un AVP"
        Form1.reponse2garde = "Je vais rien pouvoir faire"

        Form1.reponse1ap = "Bonjour c'est possible de nous envoyer une ASSU pour un AVP ?"
        Form1.reponse2ap = "Bonjour faut plutôt envoyer un SMUR désolé"

        Form1.reponse1pds = "Bonjour docteur, je vous passe les SP qui sont sur un AVP"
        Form1.reponse2pds = "Passe plutôt au médecin urgentiste la prochaine fois"

        Form1.reponse1cta = "Salut c'est le SAMU, j'ai la demande d'un SP d'envoyer un SMUR je te le passe"
        Form1.reponse2cta = "Salut, euh..."

        Form1.reponse117 = "Salut c'est le SAMU, j'ai un SP qui me demande un SMUR je te le passe"
        Form1.reponse217 = "Salut, euh t'es au 17 là"


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin, tu peux me passer ses constantes ?"
        Form1.reponseMR2 = "62 de pouds, 80% en SAT, 10/6 en tension..."
        Form1.reponseMR3 = "Mouais pas super, on arrive."
        Form1.reponseMR4 = "Très bien merci"
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

        Form1.départSPreponse1 = "Salut c'est le SAMU, tu peux m'engager un autre VSAV pour l'AVP ?"
        Form1.départSPreponse2 = "Salut, reçu j'en envoi un autre en renfort"
        Form1.départPOLICEreponse1 = "Salut c'est le SAMU, vous êtes déjà sur les lieux de l'AVP ? On aurait besoin que vous sécurisiez l'intervention des Pompiers et du SAMU"
        Form1.départPOLICEreponse2 = "Salut, oui j'ai déjà du monde, tiens moi au courant s'il faut du renfort."



        'bilan SP
        Form1.bilanSP = "VSAV 02 Arrivé sur les lieux, on assiste l'équipe du 1er VSAV la victime se dégrade de plus en plus, on arrive toujours pas à désincarcérer. On vous attend."
        Form1.bilanSPsmurNonengagé = "VSAV 02 Arrivé sur les lieux, on assiste l'équipe du 1er VSAV la victime se dégrade de plus en plus, nous demendons à nouveau un SMUR en renfort !"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV 02, bien reçu le SMUR va pas tarder."
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV 02, faite au mieux pour désincarcérer et transportez directement !"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV 02, il y a plus rien à faire laissez la victime sur place."


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut, j'ai franchement pas de bonnes nouvelles, toujours bloqué et on risque de perdre la patiente. Si dans 2 minutes toujours bloqué..."
        Form1.bilanSMUR2 = "Salut, mince t'a vraiment aucun autre moyen ?"
        Form1.bilanSMUR3 = "Malheureusement non, soit ça jambe soit sa vie. Tu sais ce qui te reste à faire..."
        Form1.bilanSMUR4 = "Oui oui, je demande de la place et une équipe au bloc au CH."
        Form1.bilanSMUR5 = "Merci, je te recontacte après."


    End Sub

End Module
