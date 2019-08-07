Module générerDonnées


    Public Sub générerAdresse()

        Dim departement As String = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département")

        If departement = "72 Sarthe" Then adresses72()



    End Sub



    Public Sub générerNomPrénom()

        'générer nom

        Randomize()
        Dim random As New Random(), rndnbr As Integer
        rndnbr = random.Next(1, 45)

        If rndnbr = 1 Then
            Form1.nomAppelant = "Chicot"
        End If

        If rndnbr = 2 Then
            Form1.nomAppelant = "Dupont"
        End If

        If rndnbr = 3 Then
            Form1.nomAppelant = "Martin"
        End If

        If rndnbr = 5 Then
            Form1.nomAppelant = "Bernard"
        End If

        If rndnbr = 6 Then
            Form1.nomAppelant = "Thomas"
        End If

        If rndnbr = 7 Then
            Form1.nomAppelant = "Petit"
        End If

        If rndnbr = 8 Then
            Form1.nomAppelant = "Robert"
        End If

        If rndnbr = 9 Then
            Form1.nomAppelant = "Richard"
        End If

        If rndnbr = 10 Then
            Form1.nomAppelant = "Durant"
        End If

        If rndnbr = 11 Then
            Form1.nomAppelant = "Dubois"
        End If

        If rndnbr = 12 Then
            Form1.nomAppelant = "Moreau"
        End If

        If rndnbr = 13 Then
            Form1.nomAppelant = "Laurent"
        End If

        If rndnbr = 14 Then
            Form1.nomAppelant = "Simon"
        End If

        If rndnbr = 15 Then
            Form1.nomAppelant = "Michel"
        End If

        If rndnbr = 16 Then
            Form1.nomAppelant = "Lefèvre"
        End If

        If rndnbr = 17 Then
            Form1.nomAppelant = "Leroy"
        End If

        If rndnbr = 18 Then
            Form1.nomAppelant = "Roux"
        End If

        If rndnbr = 19 Then
            Form1.nomAppelant = "David"
        End If

        If rndnbr = 20 Then
            Form1.nomAppelant = "Morel"
        End If

        If rndnbr = 21 Then
            Form1.nomAppelant = "Fournier"
        End If

        If rndnbr = 22 Then
            Form1.nomAppelant = "Girard"
        End If

        If rndnbr = 23 Then
            Form1.nomAppelant = "Bonnet"
        End If

        If rndnbr = 27 Then
            Form1.nomAppelant = "Lambert"
        End If

        If rndnbr = 25 Then
            Form1.nomAppelant = "Rousseau"
        End If

        If rndnbr = 26 Then
            Form1.nomAppelant = "Vincent"
        End If

        If rndnbr = 27 Then
            Form1.nomAppelant = "Faure"
        End If

        If rndnbr = 28 Then
            Form1.nomAppelant = "André"
        End If

        If rndnbr = 29 Then
            Form1.nomAppelant = "Mercier"
        End If

        If rndnbr = 30 Then
            Form1.nomAppelant = "Blanc"
        End If

        If rndnbr = 31 Then
            Form1.nomAppelant = "Guerin"
        End If

        If rndnbr = 32 Then
            Form1.nomAppelant = "Garnier"
        End If

        If rndnbr = 33 Then
            Form1.nomAppelant = "Chevalier"
        End If

        If rndnbr = 34 Then
            Form1.nomAppelant = "Legrand"
        End If

        If rndnbr = 35 Then
            Form1.nomAppelant = "Gauthier"
        End If

        If rndnbr = 36 Then
            Form1.nomAppelant = "Perrin"
        End If

        If rndnbr = 37 Then
            Form1.nomAppelant = "Nicolas"
        End If

        If rndnbr = 38 Then
            Form1.nomAppelant = "Roussel"
        End If

        If rndnbr = 39 Then
            Form1.nomAppelant = "Duval"
        End If

        If rndnbr = 40 Then
            Form1.nomAppelant = "Dufour"
        End If

        If rndnbr = 41 Then
            Form1.nomAppelant = "Brunet"
        End If

        If rndnbr = 42 Then
            Form1.nomAppelant = "Barbier"
        End If

        If rndnbr = 43 Then
            Form1.nomAppelant = "Roche"
        End If

        If rndnbr = 44 Then
            Form1.nomAppelant = "Renard"
        End If





        'générer nom

        Randomize()
        Dim random2 As New Random(), rndnbr2 As Integer
        rndnbr2 = random.Next(1, 77)

        If rndnbr2 = 1 Then
            Form1.prénomAppelant = "Jean"
        End If

        If rndnbr2 = 2 Then
            Form1.prénomAppelant = "Marie"
        End If

        If rndnbr2 = 3 Then
            Form1.prénomAppelant = "Pierre"
        End If

        If rndnbr2 = 4 Then
            Form1.prénomAppelant = "Jeanne"
        End If

        If rndnbr2 = 5 Then
            Form1.prénomAppelant = "Michel"
        End If

        If rndnbr2 = 6 Then
            Form1.prénomAppelant = "Françoise"
        End If

        If rndnbr2 = 7 Then
            Form1.prénomAppelant = "André"
        End If

        If rndnbr2 = 8 Then
            Form1.prénomAppelant = "Monique"
        End If

        If rndnbr2 = 9 Then
            Form1.prénomAppelant = "Philippe"
        End If

        If rndnbr2 = 10 Then
            Form1.prénomAppelant = "Cathrine"
        End If

        If rndnbr2 = 11 Then
            Form1.prénomAppelant = "René"
        End If

        If rndnbr2 = 12 Then
            Form1.prénomAppelant = "Nathalie"
        End If

        If rndnbr2 = 13 Then
            Form1.prénomAppelant = "Louis"
        End If

        If rndnbr2 = 14 Then
            Form1.prénomAppelant = "Isabelle"
        End If

        If rndnbr2 = 15 Then
            Form1.prénomAppelant = "Alain"
        End If

        If rndnbr2 = 16 Then
            Form1.prénomAppelant = "Jaqueline"
        End If

        If rndnbr2 = 17 Then
            Form1.prénomAppelant = "Jaques"
        End If

        If rndnbr2 = 18 Then
            Form1.prénomAppelant = "Anne"
        End If

        If rndnbr2 = 19 Then
            Form1.prénomAppelant = "Bernard"
        End If

        If rndnbr2 = 20 Then
            Form1.prénomAppelant = "Sylvie"
        End If

        If rndnbr2 = 21 Then
            Form1.prénomAppelant = "Marcel"
        End If

        If rndnbr2 = 22 Then
            Form1.prénomAppelant = "Martine"
        End If

        If rndnbr2 = 23 Then
            Form1.prénomAppelant = "Daniel"
        End If

        If rndnbr2 = 24 Then
            Form1.prénomAppelant = "Madeleine"
        End If

        If rndnbr2 = 25 Then
            Form1.prénomAppelant = "Roger"
        End If

        If rndnbr2 = 26 Then
            Form1.prénomAppelant = "Nicole"
        End If

        If rndnbr2 = 27 Then
            Form1.prénomAppelant = "Robert"
        End If

        If rndnbr2 = 28 Then
            Form1.prénomAppelant = "Suzane"
        End If

        If rndnbr2 = 29 Then
            Form1.prénomAppelant = "Paul"
        End If

        If rndnbr2 = 30 Then
            Form1.prénomAppelant = "Hélène"
        End If

        If rndnbr2 = 31 Then
            Form1.prénomAppelant = "Claude"
        End If

        If rndnbr2 = 32 Then
            Form1.prénomAppelant = "Christine"
        End If

        If rndnbr2 = 33 Then
            Form1.prénomAppelant = "Christian"
        End If

        If rndnbr2 = 34 Then
            Form1.prénomAppelant = "Marguerite"
        End If

        If rndnbr2 = 35 Then
            Form1.prénomAppelant = "Henri"
        End If

        If rndnbr2 = 36 Then
            Form1.prénomAppelant = "Denise"
        End If

        If rndnbr2 = 37 Then
            Form1.prénomAppelant = "George"
        End If

        If rndnbr2 = 38 Then
            Form1.prénomAppelant = "Louise"
        End If

        If rndnbr2 = 39 Then
            Form1.prénomAppelant = "Nicolas"
        End If

        If rndnbr2 = 40 Then
            Form1.prénomAppelant = "Christiane"
        End If

        If rndnbr2 = 41 Then
            Form1.prénomAppelant = "François"
        End If

        If rndnbr2 = 42 Then
            Form1.prénomAppelant = "Yvonne"
        End If

        If rndnbr2 = 43 Then
            Form1.prénomAppelant = "Patrik"
        End If

        If rndnbr2 = 44 Then
            Form1.prénomAppelant = "Valérie"
        End If

        If rndnbr2 = 45 Then
            Form1.prénomAppelant = "Gérard"
        End If

        If rndnbr2 = 46 Then
            Form1.prénomAppelant = "Sophie"
        End If

        If rndnbr2 = 47 Then
            Form1.prénomAppelant = "Christophe"
        End If

        If rndnbr2 = 48 Then
            Form1.prénomAppelant = "Sandrine"
        End If

        If rndnbr2 = 49 Then
            Form1.prénomAppelant = "Joseph"
        End If

        If rndnbr2 = 50 Then
            Form1.prénomAppelant = "Stéphanie"
        End If

        If rndnbr2 = 51 Then
            Form1.prénomAppelant = "Julien"
        End If

        If rndnbr2 = 52 Then
            Form1.prénomAppelant = "Céline"
        End If

        If rndnbr2 = 53 Then
            Form1.prénomAppelant = "Maurice"
        End If

        If rndnbr2 = 54 Then
            Form1.prénomAppelant = "Véronique"
        End If

        If rndnbr2 = 55 Then
            Form1.prénomAppelant = "Laurent"
        End If

        If rndnbr2 = 56 Then
            Form1.prénomAppelant = "Chantal"
        End If

        If rndnbr2 = 57 Then
            Form1.prénomAppelant = "Frédéric"
        End If

        If rndnbr2 = 58 Then
            Form1.prénomAppelant = "Marcelle"
        End If

        If rndnbr2 = 59 Then
            Form1.prénomAppelant = "Eric"
        End If

        If rndnbr2 = 60 Then
            Form1.prénomAppelant = "Renée"
        End If

        If rndnbr2 = 61 Then
            Form1.prénomAppelant = "François"
        End If

        If rndnbr2 = 62 Then
            Form1.prénomAppelant = "David"
        End If

        If rndnbr2 = 63 Then
            Form1.prénomAppelant = "Stéphane"
        End If

        If rndnbr2 = 64 Then
            Form1.prénomAppelant = "Pascal"
        End If

        If rndnbr2 = 65 Then
            Form1.prénomAppelant = "Sébastien"
        End If

        If rndnbr2 = 66 Then
            Form1.prénomAppelant = "Alexandre"
        End If

        If rndnbr2 = 67 Then
            Form1.prénomAppelant = "Thierry"
        End If

        If rndnbr2 = 68 Then
            Form1.prénomAppelant = "Olivier"
        End If

        If rndnbr2 = 69 Then
            Form1.prénomAppelant = "Thomas"
        End If

        If rndnbr2 = 70 Then
            Form1.prénomAppelant = "Antoine"
        End If

        If rndnbr2 = 71 Then
            Form1.prénomAppelant = "Julie"
        End If

        If rndnbr2 = 72 Then
            Form1.prénomAppelant = "Paulette"
        End If

        If rndnbr2 = 73 Then
            Form1.prénomAppelant = "Germaine"
        End If

        If rndnbr2 = 74 Then
            Form1.prénomAppelant = "Annie"
        End If

        If rndnbr2 = 75 Then
            Form1.prénomAppelant = "Patricia"
        End If

        If rndnbr2 = 76 Then
            Form1.prénomAppelant = "Yvette"
        End If


    End Sub

End Module
