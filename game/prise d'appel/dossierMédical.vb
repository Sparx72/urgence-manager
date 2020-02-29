Public Class dossierMédical

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        départSAMU.TopLevel = False
        game.Panel4.Controls.Clear()
        game.Panel4.Controls.Add(départSAMU)
        départFDO.Show()
        départSAMU.actualiserSAMU()

    End Sub
End Class