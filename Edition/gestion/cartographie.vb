Public Class cartographie

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lat", TextBox1.Text)
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "lon", TextBox4.Text)
    End Sub

    Private Sub FlatNumeric1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatNumeric1.Click
        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "zoom", FlatNumeric1.Value)
    End Sub

    Private Sub FlatComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatComboBox1.SelectedIndexChanged
        If FlatComboBox1.Text = "Mapbox streets-satellite" Then
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "sat")
        End If
        If FlatComboBox1.Text = "OSM France" Then
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "renduCarte", "OSM")
        End If


        cartevide()

    End Sub

    Private Sub FlatCheckBox1_CheckedChanged(ByVal sender As System.Object) Handles FlatCheckBox1.CheckedChanged
        'afficher coordonnées GPS
        If FlatCheckBox1.Checked = True Then
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick", "oui")
        Else
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "afficherGPSclick", "non")
        End If


        cartevide()
    End Sub
End Class