Public Class nouvellePartie

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click
        Me.Close()
    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        If System.IO.Directory.Exists(appdata & "game\" & TextBox4.Text) = False Then
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "nomPartie", TextBox4.Text)
            Cls_Ini.INIWrite(appdata & "game\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "date", DateTime.Now.Date)
            Cls_Ini.INIWrite(appdata & "game\" & TextBox4.Text & "\" & TextBox4.Text & ".ini", "données", "appel18", "non")
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & TextBox4.Text & ".ini", "données", "renduCarte", "sat")
            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\" & TextBox4.Text & ".ini", "données", "afficherGPSclick", "oui")


            'ajout des dossiers des services (comme pompiers, police etc)
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\sp")
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\fdo")
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\samu")
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\sc")
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\dir")
            System.IO.Directory.CreateDirectory(appdata & "game\" & TextBox4.Text & "\rdf")
        Else
            MsgBox("Cette partie existe déjà, utilisez un autre nom pour en créer une nouvelle.", MsgBoxStyle.Exclamation)
        End If




        TextBox4.Text = ""
        actualiserPartie()
        Me.Close()
    End Sub

End Class