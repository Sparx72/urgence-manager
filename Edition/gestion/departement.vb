Public Class departement

    
    Private Sub FlatComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatComboBox2.SelectedIndexChanged
        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & partieEnCours & ".ini", "données", "département", FlatComboBox2.Text)
    End Sub
End Class