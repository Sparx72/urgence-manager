Public Class configRecoVocale

    

    Private Sub FlatToggle1_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle1.CheckedChanged

        If FlatToggle1.Checked = True Then

            Cls_Ini.INIWrite(appdata & "config.ini", "données", "reco", "oui")

        Else

            Cls_Ini.INIWrite(appdata & "config.ini", "données", "reco", "non")

        End If

    End Sub
End Class