Public Class donnéeAppelFDO

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        départFDO.TopLevel = False
        game.Panel4.Controls.Clear()
        game.Panel4.Controls.Add(départFDO)
        départFDO.Show()
        départFDO.actualiserFDO()
    End Sub
End Class