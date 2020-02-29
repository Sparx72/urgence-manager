Imports System.IO

Public Class etares



    Public Sub actualiserEtares()

        ListBox1.Items.Clear()
        For Each Fichier As FileInfo In New DirectoryInfo(appdata & "game\" & partieEnCours & "\autre\etare\").GetFiles()
            Me.ListBox1.Items.Add(Cls_Ini.INIRead(appdata & "game\" & partieEnCours & "\autre\etare\" & Fichier.Name, "données", "nom"))
        Next

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        If TextBox1.Text <> "" Then

        Else
            msgtitre = "Vous devez saisir un nom pour cet ETARE"
            msgInfo()
        End If

        Cls_Ini.INIWrite(appdata & "game\" & partieEnCours & "\autre\etare\" & TextBox1.Text & ".um", "données", "nom", TextBox1.Text)
        actualiserEtares()
        TextBox1.Text = ""

    End Sub

    Private Sub FlatButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton14.Click

        If ListBox1.SelectedItem = "" Then

            msgtitre = "Vous devez sélectionner un établissement répertorié pour le retirer de la liste"
            msgInfo()

        End If


        If ListBox1.SelectedItem <> "" Then




            Try
                'supression d'un etare
                If File.Exists((appdata & "game\" & partieEnCours & "\autre\etare\" & ListBox1.SelectedItem & ".um")) Then
                    My.Computer.FileSystem.DeleteFile(appdata & "game\" & partieEnCours & "\autre\etare\" & ListBox1.SelectedItem & ".um")
                End If

                actualiserEtares()

            Catch ex As Exception
                version.messageErreur = "Échec lors de la supression de l'etare " & ListBox1.SelectedItem & " / " & ex.ToString
                rapportErreur()
            End Try

        End If

    End Sub
End Class