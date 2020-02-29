Public Class lancerJeuLibreSolo

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click

        If ListBox1.SelectedItem <> "" Then

            partieEnCours = ListBox1.SelectedItem
            Form1.FlatAlertBox1.Visible = True
            Form1.FlatAlertBox1.kind = FlatAlertBox._Kind.Success
            Form1.FlatAlertBox1.Text = "Bienvenue sur votre partie " & ListBox1.SelectedItem & " !"
            Form1.TimerAlertBox.Enabled = True

            chargementForm.Timer1.Enabled = True
            chargementForm.Show()
            Form1.Show()
            start.Hide()
            Me.Hide()
            

        Else

            FlatAlertBox1.Visible = True

        End If

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        actualiserPartie()
        gestionParties.ShowDialog()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        nouvellePartie.ShowDialog()

    End Sub

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click
        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        FlatLabel6.Text = Cls_Ini.INIRead(appdata & "game\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "date")
        FlatLabel8.Text = Cls_Ini.INIRead(appdata & "game\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "département")

    End Sub
End Class