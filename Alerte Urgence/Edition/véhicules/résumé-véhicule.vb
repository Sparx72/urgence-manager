Public Class résumé_véhicule

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Me.Close()

    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        'SP

        If menuCentres.typeCentreAouvrir = "sp" Then

            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", "données", "urlImage", TextBox1.Text)
            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", "données", "urlImage")

            'si faut renommer
            If TextBox4.Text <> FlatLabel1.Text Then


                MsgBox("En raison du changement de nom de ce véhicule, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\sp\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    centreIncendieSecours.actualiserCIS()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If

        End If





        'SP

        If menuCentres.typeCentreAouvrir = "samu" Then

            Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", "données", "urlImage", TextBox1.Text)
            PictureBox1.ImageLocation = Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", "données", "urlImage")

            'si faut renommer
            If TextBox4.Text <> FlatLabel1.Text Then


                MsgBox("En raison du changement de nom de ce véhicule, cette fenêtre va se fermer afin d'appliquer les modifications", MsgBoxStyle.Information)

                Try
                    My.Computer.FileSystem.RenameFile(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & FlatLabel1.Text & ".ini", TextBox4.Text & ".ini")
                    Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\samu\" & menuCentres.centreAouvrir & "\engins\" & TextBox4.Text & ".ini", "données", "nom", TextBox4.Text)
                    centreIncendieSecours.actualiserCIS()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Opération annulée, l'ancien nom à été conservé")
                End Try

            End If

        End If

    End Sub
End Class