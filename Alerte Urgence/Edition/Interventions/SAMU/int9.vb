Module int9

    Public Sub inter9()

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

        Form1.motif = "Feu de maison avec possible intoxiqués"
        Form1.texteAppel = "Bonjour le SAMU c'est le chef de groupe des pompier, nous sommes sur un feu de maison, et on aurait besoin d'un renfort médical"

        'Échange aver l'ARM

        Form1.reponse1 = "Bonjour, vous avez des victimes ou c'est pour du soutien ?"
        Form1.reponse2 = "Oui deux, qui ont très probablement du inhaler des fumées puisqu'ils ont étés évacués par les pompiers. Leur état nous semble assez inquiétants"
        Form1.reponse3 = "Ok je vous envoi une équipe"
        Form1.reponse4 = "Reçu, je peux vous laisser faire la demande d'un second VSAV également ?"
        Form1.reponse5 = "Pas de soucis je m'en occupe. Bon courage à votre équipe je vous passe le médecin"
        Form1.reponse6 = "Merci à vous, à plus tard"
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

        Form1.reponse1conseil = "Pour les fumés j'ai demandé au médecin, "
        Form1.reponse2conseil = "Vous n'envoyez personne ? Allo ?"

        Form1.reponse1garde = "Oui bonjour docteur c'est le SAMU... je suis en train de faire une erreur désolé"
        Form1.reponse2garde = "Bonjour, pas de soucis à plus"

        Form1.reponse1ap = "Oui bonjour c'est le SAMU, j'aurais besoin d'une AP pour deux blessés suite à un incendie. Inahlation de fumées"
        Form1.reponse2ap = "Bonjour il faut un VSAV pour ça"

        Form1.reponse1pds = "Docteur je vous passe une patiente qui a son papa en arrêt, elle s'inquiète."
        Form1.reponse2pds = "Très bien passez la moi, mais il va falloir que je là passe au médecin régulateur dès que possible."

        Form1.reponse1cta = "Oui le CTA c'est le SAMU, je vous passe le chef de groupe de l'une de vos intervention"
        Form1.reponse2cta = "Salut, c'était bien au SAMU qu'il souhaitait s'adresser..."

        Form1.reponse117 = "Oui le 17 c'est le SAMU, je te passe le chef de groupe d'une inter des pompier, qui sont sur feu de maison"
        Form1.reponse217 = "Salut, c'est le 17 tu fais peut être erreur..."


        'Échange aver le médecin régulateur

        Form1.reponseMR1 = "Bonjour c'est le médecin, tu peux m'en dire plus sur les deux victimes ?"
        Form1.reponseMR2 = "D'après le bilan du chef d'agrès ne notre VSAV, un homme de 42 ans, et une femme de 41 ans. Les deux sont consicent, mais les constantes sont pas super."
        Form1.reponseMR3 = "En saturation ils sont à combien ?"
        Form1.reponseMR4 = "87 et 91% ils ont l'air un peu désorientés également."
        Form1.reponseMR5 = "Ok les deux sont sous O2 ?"
        Form1.reponseMR6 = "Affirmatif"
        Form1.reponseMR7 = "D'accord, une équipe est engagé de notre côté j'ai noté aussi pour le second VSAV je m'en charge. Hésitez pas à rappeler si ça se dégrade trop."
        Form1.reponseMR8 = "Reçu, merci à vous."
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

        Form1.départSPreponse1 = "Bonjour c'est le centre 15, sur demande d'un chef de groupe de chez vous, il faudrait un second VSAV pour feu de maison."
        Form1.départSPreponse2 = "Salut, c'est reçu."
        Form1.départPOLICEreponse1 = "Bonjour c'est le centre 15, vous avez du monde sur le feu de maison ?"
        Form1.départPOLICEreponse2 = "Salut, je regarde ça... Oui j'ai une brigade sur les lieux"



        'bilan SP
        Form1.bilanSP = "VSAV Arrivé sur les lieux, nous prenons en charge la seconde victime, nous la gardons sous O2. On attend le SMUR."
        Form1.bilanSPsmurNonengagé = "VSAV Arrivé sur les lieux, nous prenons en charge la seconde victime, nous la gardons sous O2. nous demandons à nouveau un SMUR"
        Form1.bilanSPrepAttendreSmur = "Centre 15 pour VSAV, bien reçu le SMUR est en route"
        Form1.bilanSPrepTransportCH = "Centre 15 pour VSAV, bien reçu transportez directement la victime au Centre Hospitalier"
        Form1.bilanSPrepLaisserVictimes = "Centre 15 pour VSAV, bien reçu laissez la victime sur place vous pouvez repartir"


        'bilan SMUR
        Form1.bilanSMUR1 = "Salut j'ai osculté les deux victimes, on va pouvoir les transporter avec les VSAV pour faire des examens approfondis."
        Form1.bilanSMUR2 = "D'accord ça marche. A plus"
        Form1.bilanSMUR3 = "."
        Form1.bilanSMUR4 = "."
        Form1.bilanSMUR5 = "."


    End Sub

End Module
