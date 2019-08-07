Imports System.IO

Public Class nouveauVéhicule
    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

        If ListBox1.SelectedItem = "" Or TextBox4.Text = "" Then

            MsgBox("Vous devez sélectionner un véhicule")

        Else

            If File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = True Then

                MsgBox("Ce véhicule existe déjà, utilisez un autre nom")

            Else




                '///// ----- VÉHICULES POMPIERS -----




                '[CCFM] Camion Citerne Feu de Forêt Moyen

                If ListBox1.SelectedItem = "[CCFM] Camion Citerne Feu de Forêt Moyen" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "4")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[CCFM] Camion Citerne Feu de Forêt Moyen")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "CCF")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")

                End If





                '[FPT] Fourgon Pompe-Tonne

                If ListBox1.SelectedItem = "[FPT] Fourgon Pompe-Tonne" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "6")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[FPT] Fourgon Pompe-Tonne")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "INC")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers5", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers6", "Sapeur-Pompier")
                End If



                '[FPTSR] Fourgon Pompe-Tonne Secours Routier

                If ListBox1.SelectedItem = "[FPTSR] Fourgon Pompe-Tonne Secours Routier" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "6")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[FPTSR] Fourgon Pompe-Tonne Secours Routier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "INC")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction2", "SR")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers5", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers6", "Sapeur-Pompier")
                End If



                '[FSR] Fourgon Secours Routier

                If ListBox1.SelectedItem = "[FSR] Fourgon Secours Routier" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "6")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[FSR] Fourgon Secours Routier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SR")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers5", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers6", "Sapeur-Pompier")
                End If



                '[VID] Véhicule d'Interventions Diverses

                If ListBox1.SelectedItem = "[VID] Véhicule d'Interventions Diverses" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VID] Véhicule d'Interventions Diverses")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "DIV")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")

                End If



                '[VLI] Véhicule Légers Infirmier

                If ListBox1.SelectedItem = "[VLI] Véhicule Léger Infirmier" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "1")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VLI] Véhicule Léger Infirmier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "INFIRMIER")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Infirmier")

                End If



                '[VLM] Véhicule Léger Médicalisé


                If ListBox1.SelectedItem = "[VLM] Véhicule Léger Médicalisé" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VLM] Véhicule Léger Médicalisé")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SMUR")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction2", "INFIRMIER")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Médecin")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Infirmier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")

                End If


                '[VPRO] Véhicule de Protection

                If ListBox1.SelectedItem = "[VPRO] Véhicule de Protection" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "2")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VPRO] Véhicule de Protection")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "DIV")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")

                End If




                '[VTU] Véhicule Tout Usages

                If ListBox1.SelectedItem = "[VTU] Véhicule Tout Usages" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VTU] Véhicule Tout Usages")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "DIV")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")

                End If


                '[VTUTP] Véhicule Tout Usages Transport de Personnel

                If ListBox1.SelectedItem = "[VTUTP] Véhicule Tout Usages Transport de Personnel" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VTUTP] Véhicule Tout Usages Transport de Personnel")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "DIV")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction2", "VTP")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")

                End If



                '[VSAV] Véhicule de Secours et d'Assistance aux Victimes

                If ListBox1.SelectedItem = "[VSAV] Véhicule de Secours et d'Assistance aux Victimes" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "4")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VSAV] Véhicule de Secours et d'Assistance aux Victimes")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SAP")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")

                End If



                '[VSAV] Véhicule de Secours et d'Assistance aux Victimes

                If ListBox1.SelectedItem = "[VSAVHR] Véhicule de Secours et d'Assistance aux Victimes Hors Route" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "4")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VSAVHR] Véhicule de Secours et d'Assistance aux Victimes Hors Route")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SAP")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers4", "Sapeur-Pompier")

                End If


                '[VSR] Véhicule Secours Routier

                If ListBox1.SelectedItem = "[VSR] Véhicule Secours Routier" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VSR] Véhicule Secours Routier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SR")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Sapeur-Pompier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Sapeur-Pompier")

                End If


                '[VSS] Véhicule de Soutien Sanitaire

                If ListBox1.SelectedItem = "[VSS] Véhicule de Soutien Sanitaire" And File.Exists(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "2")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VSS] Véhicule de Soutien Sanitaire")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "INFIRMIER")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Infirmier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Infirmier")

                End If







                '///// ----- VÉHICULES SAMU -----



                '[VLM] Véhicule Léger Médicalisé


                If ListBox1.SelectedItem = "[VLM] Véhicule Léger Médicalisé" And File.Exists(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini") = False Then

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nbpersonnel", "3")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "type", "[VLM] Véhicule Léger Médicalisé")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction1", "SMUR")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "fonction2", "INFIRMIER")

                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers1", "Médecin")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers2", "Infirmier")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "pers3", "Ambulancier")

                End If










            End If


        End If


        centreIncendieSecours.actualiserCIS()
        Me.Close()

    End Sub

End Class