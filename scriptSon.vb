Module scriptSon



    Public Sub playFxMsg()

        home.PlayerFX.URL = Application.StartupPath & "\data\sound\uiMsg.wav"
        home.PlayerFX.controls.play()

    End Sub


    Public Sub playFxUi()

        home.PlayerFX.URL = Application.StartupPath & "\data\sound\uifx.wav"
        home.PlayerFX.controls.play()

    End Sub



    Public Sub playFxWin()

        home.PlayerFX.URL = Application.StartupPath & "\data\sound\uiWin.wav"
        home.PlayerFX.controls.play()

    End Sub


End Module
