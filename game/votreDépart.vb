Imports System.IO
Imports System.Globalization

Public Class votreDépart


    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click



    End Sub



    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        ListBox1.Items.Remove(ListBox1.SelectedItem)
        game.FlatButton9.Text = "Votre départ (" & ListBox1.Items.Count & ")"
        playFxUi()


    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        msgtitre = "Terminer la communication avec le requérant"
        msgOui = "Engager ce départ sur intervention"
        msgNon = "Annuler"
        msgOuiNon()

        If msgRésultat = "oui" Then
            Try
                game.reco.RecognizeAsyncCancel()
            Catch ex As Exception
            End Try
            home.PlayerMusic.settings.volume = 0
            home.PlayerFond.controls.pause()
            exFinAppel()
            game.modeInter = False
            'home.PlayerMusic.controls.play()
            'home.TimerPlayerUp.Enabled = True
        End If


    End Sub


End Class