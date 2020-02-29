Public Class nouveauCentre
    Private Sub FlatButton2_Click(ByVal sender As Object, ByVal e As EventArgs)

        Me.Close()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FlatButton1.Click


        If ListBox1.SelectedItem = "" Or TextBox4.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" Then

            'si rien est sélectioné
            MsgBox("Vous devez choisir le centre que vous souhaitez ajouter, le nommer et saisir ses coorrdonées GPS." & Chr(13) & "Vous trouverez facilement les coordonnées GPS sur Google Maps ou Openstreetmaps.")






        Else


            If TextBox1.Text.Contains(",") = False And TextBox2.Text.Contains(",") = False Then



                '///// PARTIE SAPEURS-POMPIERS


                '/// DDIS
                If ListBox1.SelectedItem = "Direction Départementale d'Incendie et de Secours (DDIS)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Direction Départementale d'Incendie et de Secours (DDIS)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette direction départementale d'incendie et de secours existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If


                '/// CTA-CODIS
                If ListBox1.SelectedItem = "Centre Opérationnel Départemental d'Incendie et de Secours (CTA-CODIS)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre Opérationnel Départemental d'Incendie et de Secours (CTA-CODIS)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce centre opérationnel CTA-CODIS existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If


                '/// CIS
                If ListBox1.SelectedItem = "Centre d'Incendie et de Secours (CIS)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre d'Incendie et de Secours (CIS)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "sous-type", "Centre de Secours (CS)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce centre d'incendie et de secours existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '///// PARTIE POLICE GENDARMERIE

                '/// HOTEL DE POLICE
                If ListBox1.SelectedItem = "Hôtel de Police" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Hôtel de Police")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cet Hôtel de Police existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// PN
                If ListBox1.SelectedItem = "Commissariat de Police Nationale" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Commissariat de Police Nationale")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Commissariat de Police Nationale existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// POLICE MUNICIPAL
                If ListBox1.SelectedItem = "Bureau de Police Municipale" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Bureau de Police Municipale")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Bureau de Police Municipale existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// GENDARMERIE NATIONALE
                If ListBox1.SelectedItem = "Brigade de Gendarmerie" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Brigade de Gendarmerie")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Brigade de Gendarmerie existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If





                '/// BRI
                If ListBox1.SelectedItem = "Brigade Rapide d'Intervention (BRI)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Brigade Rapide d'Intervention (BRI)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Brigade Rapide d'Intervention (BRI) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// GIGN
                If ListBox1.SelectedItem = "Antenne GIGN" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Antenne GIGN")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Antenne GIGN existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If


                '/// PSIG
                If ListBox1.SelectedItem = "Peloton de surveillance et d'intervention de la Gendarmerie (PSIG)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Peloton de surveillance et d'intervention de la Gendarmerie (PSIG)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Peloton de surveillance et d'intervention de la Gendarmerie (PSIG) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// RAID
                If ListBox1.SelectedItem = "Antenne RAID" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Antenne RAID")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Antenne RAID existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// CIC
                If ListBox1.SelectedItem = "Centre d'Information et de Commandement (CIC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre d'Information et de Commandement (CIC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Centre d'Information et de Commandement (CIC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// COG
                If ListBox1.SelectedItem = "Centre Opérationnel de Gendarmerie (COG)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre Opérationnel de Gendarmerie (COG)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\fdo\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Centre Opérationnel de Gendarmerie (COG) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If





                '///// PARTIE SAMU ET HÔPITAUX

                '/// SMUR
                If ListBox1.SelectedItem = "Service Mobile d'Urgence et de Réanimation (SMUR)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Service Mobile d'Urgence et de Réanimation (SMUR)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce SMUR existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// CH
                If ListBox1.SelectedItem = "Centre Hospitalier (CH)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre Hospitalier (CH)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Centre Hospitalier (CH) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '///AP
                If ListBox1.SelectedItem = "Société d'Ambulance Privée" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Société d'Ambulance Privée")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Société d'Ambulance Privée existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '///C15
                If ListBox1.SelectedItem = "Centre de Réception et de Régulation des Appels - Centre 15" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Centre de Réception et de Régulation des Appels - Centre 15")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Centre de Réception et de Régulation des Appels - Centre 15 existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If






                '///// SÉCURITÉ CIVILE ET ASSOCIATIONS


                '/// UIISC
                If ListBox1.SelectedItem = "Unité d'Instruction et d'Intervention de la Sécurité-Civile (UIISC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Unité d'Instruction et d'Intervention de la Sécurité-Civile (UIISC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Unité d'Instruction et d'Intervention de la Sécurité-Civile (UIISC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If

                '/// BASC
                If ListBox1.SelectedItem = "Base d'Avions de la Sécurité Civile (BASC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Base d'Avions de la Sécurité Civile (BASC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Base d'Avions de la Sécurité Civile (BASC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// GHSC
                If ListBox1.SelectedItem = "Groupement d'Hélicoptères de la Sécurité Civile (GHSC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Groupement d'Hélicoptères de la Sécurité Civile (GHSC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Groupement d'Hélicoptères de la Sécurité Civile (GHSC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If





                '/// RCSC
                If ListBox1.SelectedItem = "Réserves communales de sécurité civile (RCSC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Réserves communales de sécurité civile (RCSC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Réserves communales de sécurité civile (RCSC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// CRF
                If ListBox1.SelectedItem = "Croix Rouge Française (CRF)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Croix Rouge Française (CRF)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Croix Rouge Française (CRF) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If



                '/// ADPC
                If ListBox1.SelectedItem = "Association Départementale de Protection Civile (ADPC)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Association Départementale de Protection Civile (ADPC)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Association Départementale de Protection Civile (ADPC) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// SNSM
                If ListBox1.SelectedItem = "Société Nationale de Sauvetage en Mer (SNSM)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Société Nationale de Sauvetage en Mer (SNSM)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sc\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Société Nationale de Sauvetage en Mer (SNSM) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If





                '///// DIR ET PATROUILLEURS

                '/// DIR
                If ListBox1.SelectedItem = "Direction Interdépartementale des Routes (DIR)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Direction Interdépartementale des Routes (DIR)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cette Direction Interdépartementale des Routes (DIR) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// Patrouilleurs
                If ListBox1.SelectedItem = "Patrouilleur Autoroutier" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Patrouilleur Autoroutier")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\dir\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Patrouilleur Autoroutier existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If





                '///// ERDF ET GRDF

                '/// ERDF
                If ListBox1.SelectedItem = "Électricité Réseau Distribution de France (ENEDIS)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Électricité Réseau Distribution de France (ENEDIS)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Cet Électricité Réseau Distribution de France (ENEDIS) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                '/// GRDF
                If ListBox1.SelectedItem = "Gaz Réseau Distribution de France (GRDF)" Then

                    If System.IO.Directory.Exists(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text) = False Then
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text)
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\engins\")
                        System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\personnel\")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "type", "Gaz Réseau Distribution de France (GRDF)")
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lat", TextBox2.Text)
                        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\rdf\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "lon", TextBox1.Text)
                    Else
                        MsgBox("Ce Gaz Réseau Distribution de France (GRDF) existe déjà, trouvez lui un autre nom", MsgBoxStyle.Exclamation)
                    End If

                End If




                centreIncendieSecours.actualiserCentre()
                cartevide()
                Me.Close()





            Else

                MsgBox("Vous devez retirer les virgules quand vous collez les coordonnées GPS")

            End If





        End If



    End Sub

    Private Sub FlatButton3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles FlatButton3.Click

        latAperçu = TextBox2.Text
        lonAperçu = TextBox1.Text

        carteNouveauxCentres()
        WebBrowser1.Navigate(appdata & "cache/" & "carteNouveauxCentres.html")

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        MsgBox("Vous pouvez facilement trouver les coordonnées en cliquant sur un lieu précis dans Google Maps (les coordonnées s'affichent dans ce cas en bas de page) ou sur le site https://www.coordonnees-gps.fr/." & Chr(13) & Chr(13) & "Veillez à le pas laisser de virgule lors du copié-collé des coordonnées")

    End Sub


    Public Sub carteVideNouveauCentre()

        Timer1.Enabled = True

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False

        latAperçu = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat")
        lonAperçu = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon")

        carteNouveauxCentres()
        WebBrowser1.Navigate(appdata & "cache/" & "carteNouveauxCentres.html")

    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click


        Me.Close()
    End Sub
End Class