Imports System.IO
Imports System.Globalization

Public Class listeInter


    


    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        game.Panel4.Controls.Clear()
        menuGame.TopLevel = False
        game.Panel4.Controls.Add(menuGame)
        menuGame.Show()
    End Sub
End Class