Public Class configuration

    Private Sub FlatButton19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton19.Click

        Me.Close()

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged


        'synthèse vocale


        If ListBox1.SelectedItem = "Synthèse vocale" Then


            If Cls_Ini.INIRead(appdata & "config.ini", "données", "voix") = "oui" Then
                configSyntheseVocale.FlatToggle2.Checked = True
            Else
                configSyntheseVocale.FlatToggle2.Checked = False
            End If


            configSyntheseVocale.TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(configSyntheseVocale)
            configSyntheseVocale.Show()
        End If




        'synthèse vocale


        If ListBox1.SelectedItem = "Reconnaissance vocale" Then


            If Cls_Ini.INIRead(appdata & "config.ini", "données", "reco") = "oui" Then
                configRecoVocale.FlatToggle1.Checked = True
            Else
                configRecoVocale.FlatToggle1.Checked = False
            End If


            configRecoVocale.TopLevel = False
            Panel3.Controls.Clear()
            Panel3.Controls.Add(configRecoVocale)
            configRecoVocale.Show()
        End If

    End Sub

    Private Sub FlatButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatButton1.Click

        Try
            Process.Start("control")
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class