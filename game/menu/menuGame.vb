Imports System.IO
Imports System.Globalization

Public Class menuGame





    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click
        game.Panel4.Controls.Clear()
        listeInter.TopLevel = False
        game.Panel4.Controls.Add(listeInter)
        listeInter.Show()
    End Sub
End Class