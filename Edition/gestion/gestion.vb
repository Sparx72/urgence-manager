Imports System.IO
Public Class gestion

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged


        '////// Carte





        If ListBox1.SelectedItem = "Cartographie" Then


            'latitude et logitude et zoom

            cartographie.TextBox1.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat")
            cartographie.TextBox4.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon")
            Try
                If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom") > 0 And Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom") < 21 Then
                    cartographie.FlatNumeric1.Value = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom")
                Else
                    cartographie.FlatNumeric1.Value = 12
                End If
            Catch ex As Exception
                cartographie.FlatNumeric1.Value = 12
            End Try




            'rendu carte
            If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "sat" Then
                cartographie.FlatComboBox1.Text = "Mapbox streets-satellite"
            ElseIf Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte") = "OSM" Then
                cartographie.FlatComboBox1.Text = "OSM France"
            Else
                Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "sat")
                cartographie.FlatComboBox1.Text = "Mapbox streets-satellite"
            End If


            'coordonnées GPS au clic
            If Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick") = "non" Then
                cartographie.FlatCheckBox1.Checked = False
            Else
                cartographie.FlatCheckBox1.Checked = True
            End If


            cartographie.TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(cartographie)
            cartographie.Show()
        End If





        ' /// Département


        If ListBox1.SelectedItem = "Département" Then
            departement.FlatComboBox2.Text = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département")

            departement.TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(departement)
            departement.Show()
        End If



        '//// Etare

        If ListBox1.SelectedItem = "Établissement Répertoriés (ETARE)" Then

            If Directory.Exists(appdata & "game\" & partieEnCours & "\autre") = False Then
                System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\autre")
            End If

            If Directory.Exists(appdata & "game\" & partieEnCours & "\autre\etare") = False Then
                System.IO.Directory.CreateDirectory(appdata & "game\" & partieEnCours & "\autre\etare")
            End If

            etares.actualiserEtares()

            etares.TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(etares)
            etares.Show()



        End If


    End Sub

    Private Sub FlatButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton19.Click

        Me.Close()

    End Sub
End Class