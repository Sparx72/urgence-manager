Public Class Appels


    Private Sub FlatButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Me.Close()

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Try
            Process.Start("C:\Windows\System32\Speech\SpeechUX\sapi.cpl")
        Catch ex As Exception

        End Try

    End Sub

    Private Sub FlatButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton3.Click

        Try
            Process.Start("sndVol")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FlatButton2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton2.Click

        Try
            Process.Start("mmsys.cpl")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub FlatButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton14.Click

        If MessageBox.Show("Le téléchargement du programme d'installation de la voix (3-RSSolo4FrenchVirginie.exe - 23,4 Mo) va s'effectuer dans votre navigateur. Cette voix pourra être également utilisé par d'autres applications la nécéssitant. Continuer ?", "Installation de la voix française", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Process.Start("http://dl.free.fr/jMSqbyVaB/3-RSSolo4FrenchVirginie.exe")
        End If

    End Sub

    Private Sub FlatToggle2_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle2.CheckedChanged

        If FlatToggle2.Checked = True Then

            Try
                Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
                Form1.parole.SpeakAsync("Synthèse vocale parfaitement activée")
            Catch ex As Exception
                MsgBox("La voix n'est pas correctement installée sur cet ordinateur, vous pouvez l'installer gratuitement en cliquant sur ""Installer la voix française"".", MsgBoxStyle.Exclamation)
                FlatToggle2.Checked = False
            End Try

        End If

    End Sub

    Private Sub FlatButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton4.Click

        Try
            Form1.parole.SelectVoice("ScanSoft Virginie_Dri40_16kHz")
            Form1.parole.SpeakAsync("Test de la synthèse vocale. La sortie audio par défaut étant utilisé, vous pouvez la modifier en cliquant sur : périférique entrée sortie : en haut à droite de cette fenêtre")
        Catch ex As Exception
            MsgBox("La voix n'est pas correctement installée sur cet ordinateur, vous pouvez l'installer gratuitement en cliquant sur ""Installer la voix française"".", MsgBoxStyle.Exclamation)
        End Try

    End Sub

    Private Sub FlatToggle5_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle5.CheckedChanged

        If FlatToggle3.Checked = True Or FlatToggle4.Checked = True Or FlatToggle3.Checked = True Then

            Form1.Timer1.Enabled = True
        Else

            Form1.Timer1.Enabled = False
        End If

    End Sub

    Private Sub FlatToggle4_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle4.CheckedChanged

        If FlatToggle3.Checked = True Or FlatToggle4.Checked = True Or FlatToggle3.Checked = True Then

            Form1.Timer1.Enabled = True
        Else

            Form1.Timer1.Enabled = False
        End If

    End Sub

    Private Sub FlatToggle3_CheckedChanged(ByVal sender As System.Object) Handles FlatToggle3.CheckedChanged

        If FlatToggle3.Checked = True Or FlatToggle4.Checked = True Or FlatToggle3.Checked = True Then

            Form1.Timer1.Enabled = True
        Else

            Form1.Timer1.Enabled = False
        End If

    End Sub
End Class