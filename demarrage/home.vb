Imports WMPLib
Imports System.IO

Public Class home



    'Windows media player music
    Public WithEvents PlayerMusic As New WMPLib.WindowsMediaPlayer


    'Windows media player fx
    Public WithEvents PlayerFX As New WMPLib.WindowsMediaPlayer


    'Windows media player sonnerie
    Public WithEvents PlayerRing As New WMPLib.WindowsMediaPlayer

    'Windows media player fond
    Public WithEvents PlayerFond As New WMPLib.WindowsMediaPlayer




    Private Sub home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

        playFxMsg()
        msgtitre = "Souhaitez vous quitter Urgence Manager ?"
        msgOui = "Oui revenir au bureau Windows"
        msgNon = "Non annuler"

        msgOuiNon()

        If msgRésultat = "oui" Then
            End
        Else
            e.Cancel = True
        End If

    End Sub


    Private Sub home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        PlayerFond.settings.setMode("loop", True)
        PlayerFond.settings.volume = 25

    End Sub

    Private Sub TimerPlayerDown_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerDown.Tick

        If PlayerMusic.settings.volume > 0 Then
            PlayerMusic.settings.volume = PlayerMusic.settings.volume - 1
        Else
            PlayerMusic.controls.pause()
            TimerPlayerDown.Enabled = False
        End If

    End Sub

    Private Sub TimerPlayerUp_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayerUp.Tick

        PlayerMusic.controls.play()
        If PlayerMusic.settings.volume < 35 Then
            PlayerMusic.settings.volume = PlayerMusic.settings.volume + 1
        Else
            TimerPlayerUp.Enabled = False
        End If

    End Sub

    Private Sub TimerPlayTime_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerPlayTime.Tick
        If Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "playTime") = "" Then
            Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "playTime", "0")
        End If

        Cls_Ini.INIWrite(appdata & "settings/stats.ini", "info", "playTime", Cls_Ini.INIRead(appdata & "settings/stats.ini", "info", "playTime") + 1)
    End Sub

    Private Sub PlayerMusic_EndOfStram() Handles PlayerMusic.PlayStateChange

        'si musique terminée


        If PlayerMusic.playState = WMPPlayState.wmppsMediaEnded Then


            log("Chargement musique")

            

                PlayerMusic.controls.play()

        End If



    End Sub
End Class