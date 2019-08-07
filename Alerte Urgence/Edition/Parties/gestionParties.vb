Public Class gestionParties


    Private Sub FlatButton4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click
        actualiserPartie()
    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        If ListBox1.SelectedItem <> "" Then

            If MessageBox.Show("Souhaitez-vous vraiment supprimer cette couverture opérationnelle ?", "Suppression d'une couverture opérationnelle", MessageBoxButtons.YesNo) = DialogResult.Yes Then

                If MessageBox.Show("Toutes les données de la couverture opérationnelle [" & ListBox1.SelectedItem & "] seront définitivement supprimés et ne pourront jamais être récupérés. Souhaitez-vous vraiment continuer ?", "Avertissement avant suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then



                    Try
                        'supression de la partie
                        My.Computer.FileSystem.DeleteDirectory(appdata & "game\" & ListBox1.SelectedItem, FileIO.DeleteDirectoryOption.DeleteAllContents)
                        actualiserPartie()

                    Catch ex As Exception
                        version.messageErreur = "Échec lors de la supression de la couverture opérationnelle " & ListBox1.SelectedItem
                        rapportErreur()
                        actualiserPartie()
                    End Try





                End If

            End If

        Else
            MsgBox("Vous devez sélectionner une couverture opérationnelle pour la supprimer", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub FlatButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton5.Click

        If ListBox1.SelectedItem <> "" Then
            Try
                Dim nouveauNom As String = InputBox("Comment souhaitez vous renommer cette couverture opérationnelle ?")
                My.Computer.FileSystem.RenameDirectory(appdata & "game\" & ListBox1.SelectedItem, nouveauNom)
                My.Computer.FileSystem.RenameFile(appdata & "game\" & nouveauNom & "\" & ListBox1.SelectedItem & ".ini", nouveauNom & ".ini")
                Cls_Ini.INIWrite(appdata & "game\" & nouveauNom & "\" & nouveauNom & ".ini", "données", "nomPartie", nouveauNom)
            Catch ex As Exception
                MsgBox("L'ancien nom à été conservé")
            End Try
        Else
            MsgBox("Opération impossible : aucune couverture opérationnelle sélectionnée")
        End If



        actualiserPartie()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        'lorque la partie sélectionné change
        FlatLabel5.Text = Cls_Ini.INIRead(appdata & "game\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "nomPartie")
        FlatLabel6.Text = Cls_Ini.INIRead(appdata & "game\" & ListBox1.SelectedItem & "\" & ListBox1.SelectedItem & ".ini", "données", "date")

    End Sub

End Class