Public Class start

    
    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'plein écran
        If Cls_Ini.INIRead(appdata & "config.ini", "données", "fullscreen") = "oui" Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            FlatClose1.Visible = True
            FlatButton1.Text = "Mode Fenêtré"
            Me.Hide()
            Me.Show()
        End If


        créerDossierBase()
        Label1.Text = versionPublic & " [DEV]"
        actualiserPartie()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        nouvellePartie.ShowDialog()

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        gestionParties.ShowDialog()

    End Sub



    Private Sub FlatButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton7.Click

        MsgBox("Le support de mods n'est pas disponible dans les versions de développement", MsgBoxStyle.Information)
        Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) & "\Alerte d'Urgence\mods\")

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If admin = True Then



        Else
            MsgBox("Cette fonction est indisponible pour le moment", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FlatButton3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click
        Process.Start("https://alerte-urgence.000webhostapp.com/")
    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click
        Process.Start("https://www.facebook.com/projetalerteurgence/")
    End Sub

    Private Sub FlatButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Process.Start("https://discord.gg/Ea9QrJ3")

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter

        PictureBox2.Location = New Point(PictureBox2.Location.X - 15, PictureBox2.Location.Y - 15)
        PictureBox2.Height = 230
        PictureBox2.Width = 230
        FlatLabel1.Text = "Jeu libre Solo (En développement)"
        PictureBox2.BringToFront()

    End Sub

    Private Sub PictureBox2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseLeave

        PictureBox2.Location = New Point(PictureBox2.Location.X + 15, PictureBox2.Location.Y + 15)
        FlatLabel1.Text = ""
        PictureBox2.Height = 200
        PictureBox2.Width = 200

    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

        lancerJeuLibreSolo.ShowDialog()

    End Sub

    Private Sub FlatButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        If Cls_Ini.INIRead(appdata & "config.ini", "données", "fullscreen") <> "oui" Then
            Cls_Ini.INIWrite(appdata & "config.ini", "données", "fullScreen", "oui")
            FlatButton1.Text = "Mode Fenêtré"
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            FlatClose1.Visible = True
            Me.Hide()
            Me.Show()
        Else
            Cls_Ini.INIWrite(appdata & "config.ini", "données", "fullScreen", "non")
            FlatButton1.Text = "Plein Écran"
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            FlatClose1.Visible = False
        End If


    End Sub
End Class