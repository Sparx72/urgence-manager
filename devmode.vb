Public Class devmode

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Kq4R3Fu6v" Then
            admin = True
            Form1.FlatAlertBox1.Visible = True
            Form1.FlatAlertBox1.kind = FlatAlertBox._Kind.Info
            Form1.FlatAlertBox1.Text = "Mode développeur activé"
            Form1.TimerAlertBox.Enabled = True
            Me.Close()
        Else
            Label2.Visible = True
        End If
    End Sub
End Class