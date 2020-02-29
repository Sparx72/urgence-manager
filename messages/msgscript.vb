Module msgscript

    Public msgtitre As String
    Public msgOui As String
    Public msgNon As String
    Public msgRésultat As String = ""


    Public Sub msgInfo()

        msgformInfo.FlatLabel1.Text = msgtitre
        msgformInfo.Width = 20 + msgformInfo.FlatLabel1.Width
        msgformInfo.Height = 48 + msgformInfo.FlatLabel1.Height
        playFxMsg()

        msgBlack.ShowDialog()
        msgBlack.Close()


    End Sub


    Public Sub msgOuiNon()

        msgRésultat = ""

        msgformOuiNon.FlatLabel1.Text = msgtitre
        msgformOuiNon.FlatButton1.Text = msgOui
        msgformOuiNon.FlatButton2.Text = msgNon
        playFxMsg()

        msgformOuiNon.Width = 20 + msgformOuiNon.FlatLabel1.Width
        msgformOuiNon.Height = 66 + msgformOuiNon.FlatLabel1.Height

        msgBlackOuiNon.ShowDialog()
        msgBlackOuiNon.Close()


    End Sub

End Module
