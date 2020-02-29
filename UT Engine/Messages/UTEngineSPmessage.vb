Public Class UTEngineSPmessage

    Private Sub FlatButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton6.Click

        Form1.Panel6.Visible = False
        Form1.UTEngine.Enabled = True

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Try
            If Cls_Ini.INIRead(appdata & "config.ini", "données", "voix") = "oui" Then
                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                Form1.parole.SpeakAsync(FlatLabel1.Text)
            Else
                msgtitre = "La synthèse vocale doit être activée dans l'écran configuration pour réitérer oralement un message radio."
                msgInfo()
            End If

        Catch ex As Exception
        End Try

    End Sub
End Class