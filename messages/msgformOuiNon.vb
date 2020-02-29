Public Class msgformOuiNon

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        playFxUi()
        msgRésultat = "oui"

        msgBlackOuiNon.Close()
        Me.Close()


    End Sub

    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        playFxUi()
        msgRésultat = "non"

        msgBlackOuiNon.Close()
        Me.Close()

    End Sub
End Class