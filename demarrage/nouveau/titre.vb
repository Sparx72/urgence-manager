Public Class titre


    Dim sensTimer As String = "positif"
    Dim r As Integer = 0
    Dim g As Integer = 0
    Dim b As Integer = 0
    
    Private Sub FlatLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel2.Click
        Timer1.Enabled = False
        playFxWin()
        scriptNouveau.eXscriptNouveau()
    End Sub
    Private Sub FlatLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel1.Click
        Timer1.Enabled = False
        playFxWin()
        scriptNouveau.eXscriptNouveau()
    End Sub
    Private Sub FlatLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FlatLabel3.Click
        Timer1.Enabled = False
        playFxWin()
        scriptNouveau.eXscriptNouveau()
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Timer1.Enabled = False
        playFxWin()
        scriptNouveau.eXscriptNouveau()
    End Sub

    Private Sub titre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Timer1.Enabled = False
        playFxWin()
        scriptNouveau.eXscriptNouveau()

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        If r < 250 And sensTimer = "positif" Then
            r = r + 2
            g = g + 2
            b = b + 2
        End If

        If r = 250 Then
            sensTimer = "négatif"
        End If

        If r > 50 And sensTimer = "négatif" Then
            r = r - 2
            g = g - 2
            b = b - 2
        End If

        If r = 50 Then
            sensTimer = "positif"
        End If

        FlatLabel3.ForeColor = Color.FromArgb(r, g, b)

    End Sub



End Class