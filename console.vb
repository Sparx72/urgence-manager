Public Class console

    Private Sub console_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
        Me.Hide()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Me.Hide()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown


        If (e.KeyCode = Keys.Escape) Then

            Me.Hide()

        End If


        If (e.KeyCode = Keys.Enter) Then



            '////////// CONSOLE


            If TextBox2.Text = "> version" Then

                log("Version " & versionPublic & ", build " & buildPublic)

            End If



            If TextBox2.Text = "> exit" Then

                playFxMsg()
                msgtitre = "Souhaitez vous quitter Urgence Manager ?"
                msgOui = "Oui revenir au bureau Windows"
                msgNon = "Non annuler"

                msgOuiNon()

                If msgRésultat = "oui" Then
                    End
                End If

            End If



            If TextBox2.Text = "> force exit" Then

                End

            End If




            '//////// FIN CONSOLE


            TextBox2.Text = "> "
            TextBox2.SelectionStart = TextBox2.Text.Length
            TextBox2.SelectionLength = TextBox2.Text.Length
            TextBox1.ScrollToCaret()

        End If


    End Sub
End Class