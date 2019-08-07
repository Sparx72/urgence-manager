Public Class lancerJeuLibreSolo

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click

        If ListBox1.SelectedItem <> "" Then

            partieEnCours = ListBox1.SelectedItem
            Form1.FlatAlertBox1.Visible = True
            Form1.FlatAlertBox1.kind = FlatAlertBox._Kind.Success
            Form1.FlatAlertBox1.Text = "Bienvenue sur votre " & ListBox1.SelectedItem & " !"
            Form1.TimerAlertBox.Enabled = True

            Form1.Show()
            start.Hide()
            Me.Hide()

        Else

            MsgBox("Vous devez sélectionner une partie", MsgBoxStyle.Information)

        End If

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        actualiserPartie()
        gestionParties.ShowDialog()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        nouvellePartie.ShowDialog()

    End Sub
End Class